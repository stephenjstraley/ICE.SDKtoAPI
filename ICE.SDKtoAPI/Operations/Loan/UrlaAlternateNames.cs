using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string guid, int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> GetUrlaAlternateNamesAsync(string guid, string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> AddUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.UrlaAlternateNameContract>> UpdateUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<bool> DeleteUrlaAlternateNameAsync(int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<bool> DeleteUrlaAlternateNameAsync(string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<bool> DeleteUrlaAlternateNameAsync(string guid, int app, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
        Task<bool> DeleteUrlaAlternateNameAsync(string guid, string appGuid, List<LenderApiContractsV3.UrlaAlternateNameContract> contract, bool forBorrower = true);
    }
    public partial class LenderAPI : ILenderAPI
    {
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
    }
}
