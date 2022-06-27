using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, string appGuid, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, int app, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<bool> DeleteResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<bool> DeleteResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<bool> DeleteResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
        Task<bool> DeleteResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true);
    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(int app, bool forBorrower = true) => await GetResidencesAsync(LoanGuid, app, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string appGuid, bool forBorrower = true) => await GetResidencesAsync(LoanGuid, appGuid, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, string appGuid, bool forBorrower = true)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetResidences(guid, appGuid, forBorrower);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> GetResidencesAsync(string guid, int app, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
            {
                SetResponse();
                var provider = new LoanProviderService(_accessToken);
                var results = await provider.GetResidences(guid, appGuid, forBorrower);
                _lastResponse = results.Item2;
                return results.Item1;
            }
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await AddResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await AddResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await AddResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> AddResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("add", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await UpdateResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await UpdateResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await UpdateResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return null;
        }
        public async Task<List<LenderApiContractsV3.ResidenceContract>> UpdateResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("update", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteResidenceAsync(string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await DeleteResidenceAsync(LoanGuid, appGuid, contract, forBorrower);
        public async Task<bool> DeleteResidenceAsync(int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true) => await DeleteResidenceAsync(LoanGuid, app, contract, forBorrower);
        public async Task<bool> DeleteResidenceAsync(string guid, int app, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            string appGuid = await GetApplicationId(guid, app);
            if (appGuid != null)
                return await DeleteResidenceAsync(guid, appGuid, contract, forBorrower);
            else
                return false;
        }
        public async Task<bool> DeleteResidenceAsync(string guid, string appGuid, List<LenderApiContractsV3.ResidenceContract> contract, bool forBorrower = true)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageResidence("delete", guid, appGuid, contract, forBorrower);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }

    }
}
