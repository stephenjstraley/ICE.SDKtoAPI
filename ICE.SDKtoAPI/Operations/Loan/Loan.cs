using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        void Close();
        Task<bool> CommitAsync();
        Task<string> GetApplicationId(string guid, int app);
        Task<int> GetApplicationPosition(string guid, string appGuid);
        Task<bool> LoadLoanAsync(bool loadDictionary = false);
        Task<bool> LoadLoanAsync(string guid, bool loadDictionary = false);
        Task<object> GetLoanAsync(string guid);
        Task<V3LoanSchema> GetV3LoanSchemaAsync();
        Task SetLoanAsync(LenderApiContractsV1.LoanContract theLoan);
        Task<bool> UpdateLoanAsync();
        Task<bool> UpdateLoanAsync(string guid);
        Task<bool> UpdateLoanAsync(string guid, object loan, string lockId = null);
        Task<LenderApiResponse> DeleteLoanAsync();
        Task<LenderApiResponse> DeleteLoanAsync(string guid);
        Task<LenderApiContractsV1.LoanContract> CreateLoanAsync(LenderApiContractsV1.LoanContractBase loan, string folderName);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public bool HasLoanGuid => !string.IsNullOrEmpty(LoanGuid);
        public void Close() { }
        public async Task<bool> CommitAsync() => await UpdateLoanAsync();
        public async Task<string> GetApplicationId(string guid, int app)
        {
            string applicationId = null;
            int offSet = app - 1;

            try
            {
                SetResponse();
                if (_loadV3 && _loanV3 != null)
                {
                    applicationId = _loanV3.Applications[offSet].Id;
                    SetResponse();
                }
                else if (_loanV1 != null)
                {
                    applicationId = _loanV1.Applications[offSet].Id;
                    SetResponse();
                }
                else
                {
                    var service = new LoanProviderService(_accessToken);
                    var values = await service.GetV3LoanAsync(guid);
                    _lastResponse = values.Item3;
                    if (_lastResponse.IsSuccess)
                        applicationId = values.Item1.Applications[offSet].Id;
                }
            }
            catch (Exception e)
            {
                SetBadResponse(HttpStatusCode.NotFound, $"Unable to obtain application ID = {e.Message}");
            }

            return applicationId;
        }
        public async Task<int> GetApplicationPosition(string guid, string appGuid)
        {

            int appPosition = -1;

            try
            {
                SetResponse();
                if (_loadV3 && _loanV3 != null)
                {
                    appPosition = _loanV3.Applications.FindIndex(t => t.Id == appGuid);
                    if (appPosition != -1)
                        appPosition += 1;

                    SetResponse();
                }
                else if (_loanV1 != null)
                {
                    appPosition = _loanV1.Applications.FindIndex(t => t.Id == appGuid);
                    if (appPosition != -1)
                        appPosition += 1;

                    SetResponse();
                }
                else
                {
                    var service = new LoanProviderService(_accessToken);
                    var values = await service.GetV3LoanAsync(guid);
                    _lastResponse = values.Item3;
                    if (_lastResponse.IsSuccess)
                    {
                        appPosition = values.Item1.Applications.FindIndex(t=> t.Id == appGuid);
                        if (appPosition != -1)
                            appPosition += 1;

                    }
                }
            }
            catch (Exception e)
            {
                SetBadResponse(HttpStatusCode.NotFound, $"Unable to obtain application ID = {e.Message}");
            }

            return appPosition;

        }

        #region Loan Operations
        public async Task<bool> LoadLoanAsync(bool loadDictionary = false) => await LoadLoanAsync(LoanGuid, loadDictionary);
        public async Task<bool> LoadLoanAsync(string guid, bool loadDictionary = false)
        {
            // clear all values first
            Fields.SetCustomFields();
            Fields.ClearPreviousUpdatedLoan(); // Just in case the above was called in a loop
            Fields.ClearLoan();
            Fields.ClearVirtualFields();

            if (loadDictionary)
            {
                Fields.ReloadDictionary();
            }

            try
            {
                SetResponse();
                var service = new LoanProviderService(_accessToken);

                if (_loadV3)
                {
                    var values = await service.GetV3LoanAsync(guid, true);
                    _lastResponse = values.Item3;

                    _rawLoan = values.Item2;
                    _loanV3 = values.Item1;

                    if (values.Item3.IsSuccess)
                    {
                        SetResponse();
                        _guid = guid;

                        Fields.SetLoan(_loanV3);

                        if (values.Item3.IsSuccess)
                        {
                            var vMeta = service.GetVirutalFieldsAsync().Result;
                            _lastResponse = vMeta.Item2;
                            if (vMeta.Item2.IsSuccess)
                            {
                                List<string> items = vMeta.Item1.Where(t => !t.MultiInstance && t.InstanceSpecifierType.ToUpper() == "NONE").Select(t => t.Id).ToList();
                                var fields = service.GetFieldValuesAsync(guid, items).Result;

                                if (fields.Item2.IsSuccess)
                                {
                                    if (fields.Item1 != null)
                                    {
                                        Fields.LoadVirtualFields(fields.Item1);
                                    }
                                }
                                Fields.GetCustomFields().Wait();

                                _associates = GetLoanAssociatesAsync(guid).Result;
                            }
                        }
                        else
                        {
                            _meta = null;
                            Fields.ClearLoan();
                            Fields.ClearVirtualFields();
                            _associates = null;

                            return false;
                        }
                    }
                    else
                        return false;
                }
                else  // loanV1
                {
                    var values = service.GetLoanAsync(guid).Result;
                    _lastResponse = values.Item3;

                    _rawLoan = values.Item2;
                    _loanV1 = values.Item1;

                    if (values.Item3.IsSuccess)
                    {
                        SetResponse();
                        _guid = guid;

                        Fields.SetLoan(_loanV1);

                        var data = service.GetLoanMetaDataAsync(guid).Result;
                        _lastResponse = data.Item2;
                        _meta = data.Item1;

                        if (values.Item3.IsSuccess)
                        {
                            Fields.LoadVirtualFields();
                            Fields.GetCustomFields().Wait();

                            _associates = GetLoanAssociatesAsync(guid).Result;
                        }
                        else
                        {
                            _meta = null;
                            Fields.ClearLoan();
                            Fields.ClearVirtualFields();
                            _associates = null;

                            return false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                SetBadResponse(HttpStatusCode.ExpectationFailed, ex.Message);
                _rawLoan = null;
                Fields.ClearLoan();
                Fields.ClearVirtualFields();
                _associates = null;
                _guid = null;
                return false;
            }

            return true;
        }
        public async Task<object> GetLoanAsync(string guid)
        {
            SetResponse();
            _guid = guid;
            var service = new LoanProviderService(_accessToken);
            if (_loadV3)
            {
                var results = await service.GetV3LoanAsync(guid);
                _lastResponse = results.Item3;
                _rawLoan = results.Item2;
                return results.Item1;
            }
            else
            {
                var results = await service.GetLoanAsync(guid);
                _lastResponse = results.Item3;
                _rawLoan = results.Item2;
                return results.Item1;
            }
        }
        public async Task<V3LoanSchema> GetV3LoanSchemaAsync()
        {
            SetResponse();
            var service = new LoanProviderService(_accessToken);
            var results = await service.GetV3LoanSchemaAsync();
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task SetLoanAsync(LenderApiContractsV1.LoanContract theLoan)
        {
            // clear all values first
            Fields.SetCustomFields();
            Fields.ClearPreviousUpdatedLoan(); // Just in case the above was called in a loop
            Fields.ClearLoan();
            Fields.ClearVirtualFields();

            _loanV1 = theLoan;
            _rawLoan = JsonConvert.SerializeObject(theLoan);

            SetResponse();
            var service = new LoanProviderService(_accessToken);

            Fields.SetLoan(theLoan);

            var data = await service.GetLoanMetaDataAsync(_loanV1.Id);
            _lastResponse = data.Item2;
            _meta = data.Item1;

            Fields.LoadVirtualFields();
            Fields.GetCustomFields().Wait();

            _associates = GetLoanAssociatesAsync(_loanV1.Id).Result;
        }
        public async Task<bool> UpdateLoanAsync() => Fields.LoanWasUpdated ? await UpdateLoanAsync(LoanGuid, Fields.UpdatedLoan) : false;
        public async Task<bool> UpdateLoanAsync(string guid) => Fields.LoanWasUpdated ? await UpdateLoanAsync(guid, Fields.UpdatedLoan) : false;
        public async Task<bool> UpdateLoanAsync(string guid, object loan, string lockId = null)
        {
            SetResponse();
            if (_loadV3)
            {
                _thisWasLastCalled = JsonConvert.SerializeObject(loan, Formatting.Indented);
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.UpdateLoanAsync(guid, (LenderApiContractsV3.LoanContract)loan, lockId);
                _lastResponse = results;
                return results.IsSuccess;
            }
            else
            {
                _thisWasLastCalled = JsonConvert.SerializeObject(loan, Formatting.Indented);
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.UpdateLoanAsync(guid, (LenderApiContractsV1.LoanContract)loan);
                _lastResponse = results;
                return results.IsSuccess;
            }
        }
        public async Task<LenderApiResponse> DeleteLoanAsync() => await DeleteLoanAsync(LoanGuid);
        public async Task<LenderApiResponse> DeleteLoanAsync(string guid)
        {
            if (_loadV3) // need extra
            {
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.DeleteLoanAsync(guid, true);
                _lastResponse = results;
                return results;
            }
            else
            {
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.DeleteLoanAsync(guid);
                _lastResponse = results;
                return results;
            }
        }
        public async Task<LenderApiContractsV1.LoanContract> CreateLoanAsync(LenderApiContractsV1.LoanContractBase loan, string folderName)
        {
            try
            {
                SetResponse();
                var service = new LoanProviderService(_accessToken);
                var values = await service.CreateLoanAsync(loan, folderName);
                _lastResponse = values.Item2;
                _loanV1 = values.Item1;
                if (values.Item2.IsSuccess)
                {
                    Fields.SetLoan(_loanV1);
                    return _loanV1;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                SetBadResponse(HttpStatusCode.ExpectationFailed, ex.Message);
                return null;
            }
        }
        #endregion



        public async Task<List<LenderApiContractsV3.RecipientContract>> GetLoanRecipients() => await GetLoanRecipients(LoanGuid);
        public async Task<List<LenderApiContractsV3.RecipientContract>> GetLoanRecipients(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.GetLoanRecipients(guid);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }


        // Create Reg Log
        // Update Reg log
    }
}
