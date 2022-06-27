using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string appGuid);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(int app);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string guid, int app);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> GetOtherIncomeSourcesAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> AddOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<List<LenderApiContractsV3.OtherIncomeSourceContract>> UpdateOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<bool> DeleteOtherIncomeSorcesAsync(int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<bool> DeleteOtherIncomeSorcesAsync(string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<bool> DeleteOtherIncomeSorcesAsync(string guid, int app, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);
        Task<bool> DeleteOtherIncomeSorcesAsync(string guid, string appGuid, List<LenderApiContractsV3.OtherIncomeSourceContract> contract);

    }

    public partial class LenderAPI : ILenderAPI
    {
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

    }
}
