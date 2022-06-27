using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Providers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        List<ApplicationContract> GetAllBorrowerPairs();
        Task<List<ApplicationContract>> GetAllBorrowerPairsAsync();
        Task<List<ApplicationContract>> GetAllBorrowerPairsAsync(string guid);
        Task<ApplicationContract> GetBorrowerPairAsync(string guid, int app);
        Task<ApplicationContract> GetBorrowerPairAsync(string guid, string appGuid);
        Task<string> CreateBorrowerPair(string guid, ApplicationContract pair);
        // Update Borrow Pair
        Task<bool> UpdateBorrowerPair(string guid, int app, ApplicationContract pair);
        Task<bool> UpdateBorrowerPair(string guid, string appGuid, ApplicationContract pair);
    }
    public partial class LenderAPI : ILenderAPI
    {
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
        public async Task<string> CreateBorrowerPair(string guid, ApplicationContract pair)
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
