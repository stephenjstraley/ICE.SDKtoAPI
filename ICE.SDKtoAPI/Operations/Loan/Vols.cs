using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string appGuid);
        Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(int app);
        Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string guid, int app);
        Task<List<LenderApiContractsV3.VolContract>> GetVolsAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(int app, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> AddVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(int app, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract);
        Task<List<LenderApiContractsV3.VolContract>> UpdateVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract);
        Task<bool> DeleteVolAsync(int app, List<LenderApiContractsV3.VolContract> contract);
        Task<bool> DeleteVolAsync(string appGuid, List<LenderApiContractsV3.VolContract> contract);
        Task<bool> DeleteVolAsync(string guid, int app, List<LenderApiContractsV3.VolContract> contract);
        Task<bool> DeleteVolAsync(string guid, string appGuid, List<LenderApiContractsV3.VolContract> contract);

    }

    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
