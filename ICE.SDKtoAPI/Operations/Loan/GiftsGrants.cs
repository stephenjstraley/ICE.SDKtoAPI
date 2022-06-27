using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string appGuid);
        Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(int app);
        Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string guid, int app);
        Task<List<LenderApiContractsV3.GiftGrantContract>> GetGiftsGrantsAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> AddGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<List<LenderApiContractsV3.GiftGrantContract>> UpdateGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<bool> DeleteGiftsGrantsAsync(int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<bool> DeleteGiftsGrantsAsync(string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<bool> DeleteGiftsGrantsAsync(string guid, int app, List<LenderApiContractsV3.GiftGrantContract> contract);
        Task<bool> DeleteGiftsGrantsAsync(string guid, string appGuid, List<LenderApiContractsV3.GiftGrantContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
