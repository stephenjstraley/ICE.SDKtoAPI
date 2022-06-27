using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string appGuid);
        Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(int app);
        Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string guid, int app);
        Task<List<LenderApiContractsV3.VodContract>> GetVodsAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(int app, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> AddVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(int app, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract);
        Task<List<LenderApiContractsV3.VodContract>> UpdateVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract);
        Task<bool> DeleteVodAsync(int app, List<LenderApiContractsV3.VodContract> contract);
        Task<bool> DeleteVodAsync(string appGuid, List<LenderApiContractsV3.VodContract> contract);
        Task<bool> DeleteVodAsync(string guid, int app, List<LenderApiContractsV3.VodContract> contract);
        Task<bool> DeleteVodAsync(string guid, string appGuid, List<LenderApiContractsV3.VodContract> contract);
    }
    public partial class LenderAPI : ILenderAPI
    {
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

    }
}
