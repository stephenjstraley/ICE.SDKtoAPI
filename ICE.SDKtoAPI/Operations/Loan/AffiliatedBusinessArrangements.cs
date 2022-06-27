using ICE.SDKtoAPI.Providers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync();
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync(string guid);
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
        Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
        Task<bool> DeleteAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
        Task<bool> DeleteAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync() => await GetAffiliatedBusinessArragementsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> GetAffiliatedBusinessArragementsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetAffliatedBusinessArrangements(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await AddAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> AddAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("add", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await UpdateAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<List<LenderApiContractsV3.AffiliatedBusinessArrangementContract>> UpdateAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("update", guid, contract);
            _lastResponse = temp.Item2;
            return temp.Item1;
        }
        public async Task<bool> DeleteAffiliatedBusinessArragementsAsync(List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract) => await DeleteAffiliatedBusinessArragementsAsync(LoanGuid, contract);
        public async Task<bool> DeleteAffiliatedBusinessArragementsAsync(string guid, List<LenderApiContractsV3.AffiliatedBusinessArrangementContract> contract)
        {
            SetResponse();
            _thisWasLastCalled = JsonConvert.SerializeObject(contract, Formatting.Indented);
            var provider = new LoanProviderService(_accessToken);
            var temp = await provider.ManageAffiliatedBusinessArrangements("delete", guid, contract);
            _lastResponse = temp.Item2;
            return _lastResponse.IsSuccess;
        }
    }
}
