using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync();
        Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync(string guid);
        Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract);
        Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract);
        Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract);
        Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract);
        Task<bool> DeleteNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract);
        Task<bool> DeleteNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract);

    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync() => await GetNonVolsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.NonVolContract>> GetNonVolsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetNonVols(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await AddNonVolsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.NonVolContract>> AddNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await UpdateNonVolsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.NonVolContract>> UpdateNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteNonVolsAsync(List<LenderApiContractsV3.NonVolContract> contract) => await DeleteNonVolsAsync(LoanGuid, contract);
        public async Task<bool> DeleteNonVolsAsync(string guid, List<LenderApiContractsV3.NonVolContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageNonVols("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }

    }
}
