using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string appGuid);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(int app);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string guid, int app);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> GetOtherLiabilitiesAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> AddOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<List<LenderApiContractsV3.OtherLiabilityContract>> UpdateOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<bool> DeleteOtherLiabilitiesAsync(int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<bool> DeleteOtherLiabilitiesAsync(string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<bool> DeleteOtherLiabilitiesAsync(string guid, int app, List<LenderApiContractsV3.OtherLiabilityContract> contract);
        Task<bool> DeleteOtherLiabilitiesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherLiabilityContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
