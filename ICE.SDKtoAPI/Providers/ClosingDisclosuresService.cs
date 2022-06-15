using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class ClosingDisclosuresService : BaseProviderService
    {
        public ClosingDisclosuresService(AccessToken token) : base(token) { paths.SetV1(); }

        public async Task<Tuple<List<PlanCode>, LenderApiResponse>> GetPlanCodesAsync(string type)
        {
            var usePath = paths.EncompassDocsPathFull + $"/planCodes?planCodeType={type}";

            List<PlanCode> codes = await Get<List<PlanCode>>(usePath);

            return new Tuple<List<PlanCode>, LenderApiResponse>(codes, _response);
        }

        
    }
}
