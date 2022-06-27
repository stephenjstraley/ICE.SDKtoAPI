using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string appGuid);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(int app);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, int app);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, string appGuid);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<bool> DeleteAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<bool> DeleteAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<bool> DeleteAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract);
        Task<bool> DeleteAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract);

    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string appGuid) => await GetAdditionalLoansAsync(LoanGuid, appGuid);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(int app) => await GetAdditionalLoansAsync(LoanGuid, app);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, int app)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await GetAdditionalLoansAsync(guid, appGuid);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> GetAdditionalLoansAsync(string guid, string appGuid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetAdditionalLoans(guid, appGuid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await AddAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await AddAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddAdditionalLoansAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> AddAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("add", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await UpdateAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await UpdateAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateAdditionalLoansAsync(guid, appGuid, contract);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.AdditionalLoanContract>> UpdateAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("update", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteAdditionalLoansAsync(int app, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await DeleteAdditionalLoansAsync(LoanGuid, app, contract);
        public async Task<bool> DeleteAdditionalLoansAsync(string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract) => await DeleteAdditionalLoansAsync(LoanGuid, appGuid, contract);
        public async Task<bool> DeleteAdditionalLoansAsync(string guid, int app, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteAdditionalLoansAsync(guid, appGuid, contract);
            else
                return false;
        }
        public async Task<bool> DeleteAdditionalLoansAsync(string guid, string appGuid, List<LenderApiContractsV3.AdditionalLoanContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAdditionalLoans("delete", guid, appGuid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
    }
}
