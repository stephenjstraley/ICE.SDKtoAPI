using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        //public bool? BorrowerCoBorrowerMarriedIndicator() => BorrowerCoBorrowerMarriedIndicator(LoanGuid);
        //public bool? BorrowerCoBorrowerMarriedIndicator(string guid)
        //{
        //    try
        //    { 
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerCoBorrowerMarriedIndicator;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? BorrowerPaidClosingCostsAmount() => BorrowerPaidClosingCostsAmount(LoanGuid);
        //public double? BorrowerPaidClosingCostsAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerPaidClosingCostsAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? BorrowerPaidDiscountPointsAmount() => BorrowerPaidDiscountPointsAmount(LoanGuid);
        //public double? BorrowerPaidDiscountPointsAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerPaidDiscountPointsAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? BorrowerPaidFHAVAClosingCostsAmount() => BorrowerPaidFHAVAClosingCostsAmount(LoanGuid);
        //public double? BorrowerPaidFHAVAClosingCostsAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerPaidFHAVAClosingCostsAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public int? BorrowerPairCount() => BorrowerPairCount(LoanGuid);
        //public int? BorrowerPairCount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerPairCount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? BorrowerRequestedLoanAmount() => BorrowerRequestedLoanAmount(LoanGuid);
        //public double? BorrowerRequestedLoanAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.BorrowerRequestedLoanAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? CashFromToBorrowerAmount() => CashFromToBorrowerAmount(LoanGuid);
        //public double? CashFromToBorrowerAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.CashFromToBorrowerAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public bool? IsCreditorProhibitsBorrower() => IsCreditorProhibitsBorrower(LoanGuid);
        //public bool? IsCreditorProhibitsBorrower(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.IsCreditorProhibitsBorrower;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}

        //public double? LinkedBorrowerRequestedLoanAmount() => LinkedBorrowerRequestedLoanAmount(LoanGuid);
        //public double? LinkedBorrowerRequestedLoanAmount(string guid)
        //{
        //    try
        //    {
        //        var loanApiClient = ApiClientProvider.GetApiClient<LoanContract>(_accessToken);
        //        return loanApiClient.LinkedBorrowerRequestedLoanAmount;
        //    }
        //    catch
        //    {
        //        _lastCode = System.Net.HttpStatusCode.ExpectationFailed;
        //        throw;
        //    }
        //}


        //}

        public List<ApplicationContract> GetAllBorrowerPairs() => GetAllBorrowerPairsAsync(LoanGuid).Result;
        public async Task<List<ApplicationContract>> GetAllBorrowerPairsAsync() => await GetAllBorrowerPairsAsync(LoanGuid);
        public async Task<List<ApplicationContract>> GetAllBorrowerPairsAsync(string guid)
        {
            if (guid != null)
            {
                SetResponse();
                try
                {
                    var provider = new BorrowerPairProviderService(_accessToken);
                    var results = await provider.GetBorrowerPairsAsync(guid);
                    _lastResponse = results.Item2;
                    return results.Item1;
                }
                catch (Exception ex)
                {
                    SetBadResponse(System.Net.HttpStatusCode.ExpectationFailed, ex.Message);

                    return null;
                }

            }
            else
                return null;
        }
        public async Task<ApplicationContract> GetBorrowerPairAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetBorrowerPairAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<ApplicationContract> GetBorrowerPairAsync(string guid, string appGuid)
        {
            if (guid != null)
            {
                try
                {
                    SetResponse();
                    var provider = new BorrowerPairProviderService(_accessToken);
                    var results = await provider.GetBorrowerPairAsync(guid, appGuid);
                    _lastResponse = results.Item2;
                    return results.Item1;
                }
                catch (Exception ex)
                {
                    SetBadResponse(System.Net.HttpStatusCode.ExpectationFailed, ex.Message);

                    return null;
                }
            }
            else
                return null;
        }

        public async Task<string> CreateBorrowerPaid(string guid, ApplicationContract pair)
        {
            SetResponse();
            var provider = new BorrowerPairProviderService(_accessToken);
            var results = await provider.CreateBorrowerPair(guid, pair);
            _lastResponse = results.Item2;
            return results.Item1;
        }

        // Update Borrow Pair
        public async Task<bool> UpdateBorrowerPair(string guid, int app, ApplicationContract pair)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateBorrowerPair(guid, appGuid, pair);
            else
            {
                SetBadResponse(System.Net.HttpStatusCode.NotModified, "No application guid");
                return false;
            }

        }
        public async Task<bool> UpdateBorrowerPair(string guid, string appGuid, ApplicationContract pair)
        {
            if (appGuid != null)
            {
                try
                {
                    SetResponse();
                    var provider = new BorrowerPairProviderService(_accessToken);
                    var result = await provider.UpdateBorrowerPair(guid, appGuid, pair);
                    return _lastResponse.IsSuccess;
                }
                catch (Exception ex)
                {
                    SetBadResponse(System.Net.HttpStatusCode.ExpectationFailed, ex.Message);

                    return false;
                }
            }
            else
            {
                SetBadResponse(System.Net.HttpStatusCode.NotModified, "No application guid");
                return false;
            }                
        }


        // Delete Borrower Pair
    }
}
