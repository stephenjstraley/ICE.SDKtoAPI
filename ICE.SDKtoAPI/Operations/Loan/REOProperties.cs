using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string appGuid);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(int app);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string guid, int app);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> GetReoPropertiesAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> AddReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<List<LenderApiContractsV3.ReoPropertyContract>> UpdateReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<bool> DeleteReoPropertyAsync(int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<bool> DeleteReoPropertyAsync(string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<bool> DeleteReoPropertyAsync(string guid, int app, List<LenderApiContractsV3.ReoPropertyContract> contract);
        Task<bool> DeleteReoPropertyAsync(string guid, string appGuid, List<LenderApiContractsV3.ReoPropertyContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
