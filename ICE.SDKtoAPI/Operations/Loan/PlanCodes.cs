using ICE.SDKtoAPI.Providers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial interface ILenderAPI
    {
        Task<List<LenderApiContractsV1.PlanCode>> GetOpeningPlanCodes();
        Task<List<LenderApiContractsV1.PlanCode>> GetClosingPlanCodes();

    }
    public partial class LenderAPI : ILenderAPI
    {
        public async Task<List<LenderApiContractsV1.PlanCode>> GetOpeningPlanCodes()
        {
            SetResponse();
            var provider = new ClosingDisclosuresService(_accessToken);
            var resp = await provider.GetPlanCodesAsync("Opening");
            _lastResponse = resp.Item2;
            return resp.Item1;
        }
        public async Task<List<LenderApiContractsV1.PlanCode>> GetClosingPlanCodes()
        {
            SetResponse();
            var provider = new ClosingDisclosuresService(_accessToken);
            var resp = await provider.GetPlanCodesAsync("Closing");
            _lastResponse = resp.Item2;
            return resp.Item1;
        }
    }
}
