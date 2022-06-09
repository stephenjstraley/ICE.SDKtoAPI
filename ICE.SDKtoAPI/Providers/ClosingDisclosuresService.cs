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
            List<PlanCode> codes = null;

            var usePath = paths.EncompassDocsPathFull + $"/planCodes?planCodeType={type}";

            try
            {
                codes = await Get<List<PlanCode>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<PlanCode>, LenderApiResponse>(codes, _response);
        }

        
    }
}
