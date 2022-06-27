using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync();
        Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync(string guid);
        Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract);
        Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract);
        Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract);
        Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract);
        Task<bool> DeleteServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract);
        Task<bool> DeleteServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract);

    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync() => await GetServiceProvidersAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> GetServiceProvidersAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetServiceProviders(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await AddServiceProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> AddServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await UpdateServiceProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.ServiceProviderContract>> UpdateServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteServiceProvidersAsync(List<LenderApiContractsV3.ServiceProviderContract> contract) => await DeleteServiceProvidersAsync(LoanGuid, contract);
        public async Task<bool> DeleteServiceProvidersAsync(string guid, List<LenderApiContractsV3.ServiceProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageServiceProviders("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }

    }
}
