using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync();
        Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync(string guid);
    }

    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync() => await GetDisclosureTrackingLogsAsync(LoanGuid);
        public async Task<List<LenderApiContractsV1.LoanContractDisclosureTracking2015Logs>> GetDisclosureTrackingLogsAsync(string guid)
        {
            SetResponse();
            var provider = new LoanProviderService(_accessToken);
            var results = await provider.GetDisclosureTrackingLogsAsync(guid);
            _lastResponse = results.Item2;
            return results.Item1;
        }
    }
}
