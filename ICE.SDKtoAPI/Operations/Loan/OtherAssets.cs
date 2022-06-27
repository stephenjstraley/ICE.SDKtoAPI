using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string appGuid);
        Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(int app);
        Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string guid, int app);
        Task<List<LenderApiContractsV3.OtherAssetContract>> GetOtherAssetsAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> AddOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<List<LenderApiContractsV3.OtherAssetContract>> UpdateOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<bool> DeleteOtherAssetsAsync(int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<bool> DeleteOtherAssetsAsync(string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<bool> DeleteOtherAssetsAsync(string guid, int app, List<LenderApiContractsV3.OtherAssetContract> contract);
        Task<bool> DeleteOtherAssetsAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherAssetContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
