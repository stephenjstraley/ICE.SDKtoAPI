using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
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
        public async Task<bool> GetFullLoanAsync(bool loadDictionary = false) => await GetFullLoanAsync(LoanGuid, loadDictionary);
        public async Task<bool> GetFullLoanAsync(string guid, bool loadDictionary = false)
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

        #region Underwriting
        public async Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync() => await GetUnderwritingConditionsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetUnderwitingConditionsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Borrow Pairs
        public async Task<bool> GetLoanBorrowerCoBorrowerAsync() => await GetLoanBorrowerCoBorrowerAsync(LoanGuid);
        public async Task<bool> GetLoanBorrowerCoBorrowerAsync(string guid)
        {
            try
            {
                SetResponse();
                var service = new LoanProviderService(_accessToken);
                var values = await service.GetBorrowerCoborrowerAsync(guid);
                _lastResponse = values.Item2;
                _loanV1 = values.Item1;
                if (values.Item2.IsSuccess)
                {
                    Fields.SetLoan(_loanV1);
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                SetBadResponse(HttpStatusCode.ExpectationFailed, ex.Message);
                return false;
            }
        }
        #endregion

        #region Conversation Logs
        public async Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync() => await GetConversationLogsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanContractConversationLogs>> GetConversationLogsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetConversationLogsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string id) => await GetConversationLogAsync(LoanGuid, id);
        public async Task<LenderApiContractsV1.LoanContractConversationLogs> GetConversationLogAsync(string guid, string id)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetConversationLogAsync(guid, id);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Disclosure Tracking Logs
        public async Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync() => await GetDisclosureTrackingLogsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetDisclosureTrackingLogsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        #endregion

        #region Loan Residences
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(int app, bool forBorrower = true) => await GetResidencesAsync(LoanGuid, app, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string appGuid, bool forBorrower = true) => await GetResidencesAsync(LoanGuid, appGuid, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, string appGuid, bool forBorrower = true)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetResidences(guid, appGuid, forBorrower);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, int app, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
            {
                SetResponse();
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.GetResidences(guid, appGuid, forBorrower);
                _lastResponse = results.Item2;
                return results.Item1;
            }
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await AddResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await AddResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("add", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await UpdateResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await UpdateResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("update", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await DeleteResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<bool> DeleteResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await DeleteResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<bool> DeleteResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return false;
        }
        public async Task<bool> DeleteResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("delete", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Loan Residences
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string appGuid) => await GetGiftsGrantsAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(int app) => await GetGiftsGrantsAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetGiftsGrantsAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetGiftsGrants(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract) => await AddGiftsGrantsAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract) => await AddGiftsGrantsAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddGiftsGrantsAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageGiftsGrants("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract) => await UpdateGiftsGrantsAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract) => await UpdateGiftsGrantsAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateGiftsGrantsAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageGiftsGrants("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract) => await DeleteGiftsGrantsAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract) => await DeleteGiftsGrantsAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteGiftsGrantsAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract)
        {
            var newSet = new List<LenderApiContractsV3.GiftGrantContract>();
            foreach (var i in contract)
            {
                newSet.Add(new LenderApiContractsV3.GiftGrantContract()
                {
                    Id = i.Id
                });
            }
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageGiftsGrants("delete", guid, appGuid, newSet);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }


        #endregion

        #region Additional Loans
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string appGuid) => await GetAdditionalLoansAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(int app) => await GetAdditionalLoansAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetAdditionalLoansAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetAdditionalLoans(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await AddAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await AddAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddAdditionalLoansAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await UpdateAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await UpdateAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateAdditionalLoansAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await DeleteAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await DeleteAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteAdditionalLoansAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Other Assets
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string appGuid) => await GetOtherAssetsAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(int app) => await GetOtherAssetsAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await (GetOtherAssetsAsync(guid, appGuid));
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetOtherAssets(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract) => await AddOtherAssetsAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract) => await AddOtherAssetsAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddOtherAssetsAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherAssets("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract) => await UpdateOtherAssetsAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract) => await UpdateOtherAssetsAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateOtherAssetsAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherAssets("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract) => await DeleteOtherAssetsAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract) => await DeleteOtherAssetsAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteOtherAssetsAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherAssets("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Other Income Sources
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string appGuid) => await GetOtherIncomeSourcesAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(int app) => await GetOtherIncomeSourcesAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetOtherIncomeSourcesAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetOtherIncomeSources(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await AddOtherIncomeSorcesAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await AddOtherIncomeSorcesAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddOtherIncomeSorcesAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherIncomeSources("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await UpdateOtherIncomeSorcesAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await UpdateOtherIncomeSorcesAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateOtherIncomeSorcesAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherIncomeSources("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await DeleteOtherIncomeSorcesAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract) => await DeleteOtherIncomeSorcesAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteOtherIncomeSorcesAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherIncomeSources("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Other Liabilities
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string appGuid) => await GetOtherLiabilitiesAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(int app) => await GetOtherLiabilitiesAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetOtherLiabilitiesAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetOtherLiabilities(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await AddOtherLiabilitiesAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await AddOtherLiabilitiesAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddOtherLiabilitiesAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherLiabilities("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await UpdateOtherLiabilitiesAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await UpdateOtherLiabilitiesAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateOtherLiabilitiesAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherLiabilities("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await DeleteOtherLiabilitiesAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract) => await DeleteOtherLiabilitiesAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteOtherLiabilitiesAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageOtherLiabilities("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region NonVols
        public async Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync() => await GetNonVolsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetNonVols(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await AddNonVolsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await UpdateNonVolsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await DeleteNonVolsAsync(LoanGuid, contract);
        public async Task<bool> DeleteNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Affiliated Business Arrangements
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync() => await GetAffiliatedBusinessArragementsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetAffliatedBusinessArrangements(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await AddAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await UpdateAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await DeleteAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<bool> DeleteAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Service Providers
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync() => await GetServiceProvidersAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetServiceProviders(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await AddServiceProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await UpdateServiceProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await DeleteServiceProvidersAsync(LoanGuid, contract);
        public async Task<bool> DeleteServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Home Counceling
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync() => await GetHomeCounselingProvidersAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetHomeCounselingProviders(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await AddHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await UpdateHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await DeleteHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<bool> DeleteHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Employments
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string appGuid, bool forBorrower = true) => await GetEmploymentsAsync(LoanGuid, appGuid, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(int app, bool forBorrower = true) => await GetEmploymentsAsync(LoanGuid, app, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, string appGuid, bool forBorrower = true)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetEmployments(guid, appGuid, forBorrower);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, int app, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
            {
                SetResponse();
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.GetEmployments(guid, appGuid, forBorrower);
                _lastResponse = results.Item2;
                return results.Item1;
            }
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await AddEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await AddEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("add", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await UpdateEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await UpdateEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("update", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await DeleteEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<bool> DeleteEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await DeleteEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<bool> DeleteEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return false;
        }
        public async Task<bool> DeleteEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("delete", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region REOProperties
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string appGuid) => await GetReoPropertiesAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(int app) => await GetReoPropertiesAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetReoPropertiesAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetReoProperties(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract) => await AddReoPropertyAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddReoPropertyAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageReoProperties("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract) => await UpdateReoPropertyAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract) => await UpdateReoPropertyAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateReoPropertyAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageReoProperties("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract) => await DeleteReoPropertyAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteReoPropertyAsync(string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract) => await DeleteReoPropertyAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteReoPropertyAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageReoProperties("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Vols
        public async Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string appGuid) => await GetVolsAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(int app) => await GetVolsAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetVolsAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetVols(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(int app, List<LenderApiContractsV3.VolContract> contract) => await AddVolAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract) => await AddVolAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddVolAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVols("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(int app, List<LenderApiContractsV3.VolContract> contract) => await UpdateVolAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract) => await UpdateVolAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateVolAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVols("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteVolAsync(int app, List<LenderApiContractsV3.VolContract> contract) => await DeleteVolAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract) => await DeleteVolAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteVolAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVols("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Vods
        public async Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string appGuid) => await GetVodsAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(int app) => await GetVodsAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetVodsAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetVods(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(int app, List<LenderApiContractsV3.VodContract> contract) => await AddVodAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract) => await AddVodAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddVodAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVods("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(int app, List<LenderApiContractsV3.VodContract> contract) => await UpdateVodAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract) => await UpdateVodAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateVodAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVods("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteVodAsync(int app, List<LenderApiContractsV3.VodContract> contract) => await DeleteVodAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract) => await DeleteVodAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteVodAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageVods("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
        #endregion

        #region Urla AlternateNames
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string appGuid, bool forBorrower = true) => await GetUrlaAlternateNamesAsync(LoanGuid, appGuid, forBorrower);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(int app, bool forBorrower = true) => await GetUrlaAlternateNamesAsync(LoanGuid, app, forBorrower);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string guid, int app, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetUrlaAlternateNamesAsync(guid, appGuid, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string guid, string appGuid, bool forBorrower = true)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetURLAAlternateNames(guid, appGuid, forBorrower);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await AddUrlaAlternateNameAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await AddUrlaAlternateNameAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddUrlaAlternateNameAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageUrlaAlternaNames("add", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await UpdateUrlaAlternateNameAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await UpdateUrlaAlternateNameAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateUrlaAlternateNameAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageUrlaAlternaNames("update", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await DeleteUrlaAlternateNameAsync(LoanGuid, app, contract, forBorrower);
        public async Task<bool> DeleteUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true) => await DeleteUrlaAlternateNameAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<bool> DeleteUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteUrlaAlternateNameAsync(guid, appGuid, contract, forBorrower);
            else
                return false;
        }
        public async Task<bool> DeleteUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageUrlaAlternaNames("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
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

        public async Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs() => await GetRegistrationLogs(LoanGuid);
        public async Task<List<LenderApiContractsV3.RegistrationLogContract>> GetRegistrationLogs(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.GetRegistrationLogs(guid);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }

        public async Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string logId) => await GetRegistrationLog(LoanGuid, logId);
        public async Task<LenderApiContractsV3.RegistrationLogContract> GetRegistrationLog(string guid, string logId)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.GetRegistrationLog(guid, logId);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }

        // Create Reg Log
        // Update Reg log
    }
}
