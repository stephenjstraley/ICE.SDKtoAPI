using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class MismoProviderService : BaseProviderService
    {
        public MismoProviderService(AccessToken token) : base(token) { paths.SetV3(); }

        public async Task<Tuple<string, LenderApiResponse>> ConvertMismoToLoan(string xml)
        {
            string returnedResp = string.Empty;

            var usePath = paths.EncompassPathFull + "/converter/loans?mediaType=mismo";

            try
            {
                returnedResp = await GetString(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<string, LenderApiResponse>(returnedResp, _response);
        }
        public async Task<LenderApiResponse> CreateLoanFromConvertedMemoAsync(object loan, string folder)
        {
            LenderApiResponse apiResponse;

            var usePath = paths.EncompassPathFull + $"/loans?loanFolder={folder}&view=entity";

            try
            {
                var url = Authenticate(usePath).WithHeader("Content-Type", "application/json"); ;

                var resp = await url.PostJsonAsync(loan);

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return apiResponse;
        }
        public async Task<LenderApiResponse> UpdateLoanFromMismoAsync(string guid, string xml)
        {
            LenderApiResponse apiResponse;
            string returnedResp = string.Empty;

            var usePath = paths.EncompassPathFull + $"/loans/{guid}/importer?mediaType=mismo";

            try
            {
                var url = Authenticate(usePath).WithHeader("Content-Type", "application/vnd.elliemae.mismo34+xml");

                var resp = await url.PostStringAsync(xml);

                returnedResp = resp.Content.ReadAsStringAsync().Result;

                apiResponse = OkResponse(resp.Headers, usePath);
            }
            catch (FlurlHttpException e)
            {
                apiResponse = BadResponse(e, usePath);
            }
            catch (Exception exp)
            {
                apiResponse = BadResponse(exp, usePath);
            }

            return apiResponse;
        }
    }
}
