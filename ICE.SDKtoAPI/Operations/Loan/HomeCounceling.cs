using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync();
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync(string guid);
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
        Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
        Task<bool> DeleteHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
        Task<bool> DeleteHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync() => await GetHomeCounselingProvidersAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> GetHomeCounselingProvidersAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetHomeCounselingProviders(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await AddHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> AddHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await UpdateHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.HomeCounselingProviderContract>> UpdateHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteHomeCounselingProvidersAsync(List<LenderApiContractsV3.HomeCounselingProviderContract> contract) => await DeleteHomeCounselingProvidersAsync(LoanGuid, contract);
        public async Task<bool> DeleteHomeCounselingProvidersAsync(string guid, List<LenderApiContractsV3.HomeCounselingProviderContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageHomeCouncilingProviders("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
    }
}
