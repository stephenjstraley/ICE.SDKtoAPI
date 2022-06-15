using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.LenderApiContractsV1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class BatchProviderService : BaseProviderService
    {
        public BatchProviderService(AccessToken token = null) : base(token) { paths.SetV1(); }

        public async Task<LenderApiResponse> BatchUpdateEncompass(LoanBatchUpdateRequestContract model)
        {
            LenderApiResponse apiResponse;

            var usePath = paths.UpdateBatchFull;

            try
            {
                var url = Authenticate(usePath);
                
                var response = await url.PostJsonAsync(model);

                apiResponse = OkResponse(response.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath, "");
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath, "");
            }

            return apiResponse;

        }
    }
}
