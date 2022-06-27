using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync();
        Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync(string guid);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync() => await GetUnderwritingConditionsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanUnderwritingConditionsContract>> GetUnderwritingConditionsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetUnderwitingConditionsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
    }
}
