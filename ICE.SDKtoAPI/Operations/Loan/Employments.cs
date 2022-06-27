using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<bool> DeleteEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<bool> DeleteEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<bool> DeleteEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);
        Task<bool> DeleteEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true);

    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string appGuid, bool forBorrower = true) => await GetEmploymentsAsync(LoanGuid, appGuid, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(int app, bool forBorrower = true) => await GetEmploymentsAsync(LoanGuid, app, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, string appGuid, bool forBorrower = true)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetEmployments(guid, appGuid, forBorrower);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> GetEmploymentsAsync(string guid, int app, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
            {
                SetResponse();
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.GetEmployments(guid, appGuid, forBorrower);
                _lastResponse = results.Item2;
                return results.Item1;
            }
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await AddEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await AddEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> AddEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("add", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await UpdateEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await UpdateEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.EmploymentContract>> UpdateEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("update", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteEmploymentAsync(string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await DeleteEmploymentAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<bool> DeleteEmploymentAsync(int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true) => await DeleteEmploymentAsync(LoanGuid, app, contract, forBorrower);
        public async Task<bool> DeleteEmploymentAsync(string guid, int app, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteEmploymentAsync(guid, appGuid, contract, forBorrower);
            else
                return false;
        }
        public async Task<bool> DeleteEmploymentAsync(string guid, string appGuid, List<LenderApiContractsV3.EmploymentContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageEmployment("delete", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
    }
}
