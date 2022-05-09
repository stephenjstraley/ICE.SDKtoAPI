using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class BorrowerPairProviderService : BaseProviderService
    {
        public BorrowerPairProviderService(AccessToken token) : base(token) { }
        public async Task<Tuple<List<LenderApiContractsV1.ApplicationContract>, LenderApiResponse>> GetBorrowerPairsAsync(string guid)
        {
            List<LenderApiContractsV1.ApplicationContract> list = null;

            var usePath = paths.ApplicationsPath(guid);

            try
            {
                list = await Get<List<LenderApiContractsV1.ApplicationContract>>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<List<LenderApiContractsV1.ApplicationContract>, LenderApiResponse>(list, _response);
        }
        public async Task<Tuple<LenderApiContractsV1.ApplicationContract, LenderApiResponse>> GetBorrowerPairAsync(string guid, string appGuid)
        {
            LenderApiContractsV1.ApplicationContract item = null;

            var usePath = paths.ApplicationsPath(guid) + $"/{appGuid}";

            try
            {
                item = await Get<LenderApiContractsV1.ApplicationContract>(usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<LenderApiContractsV1.ApplicationContract, LenderApiResponse>(item, _response);
        }
        public async Task<Tuple<string, LenderApiResponse>> CreateBorrowerPair(string guid, LenderApiContractsV1.ApplicationContract app)
        {
            string appId = null;

            var usePath = paths.ApplicationsPath(guid);

            try
            {
                appId = await Post<string>(app, usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return new Tuple<string, LenderApiResponse>(appId, _response);
        }
        public async Task<LenderApiResponse> UpdateBorrowerPair(string guid, string appGuid, LenderApiContractsV1.ApplicationContract app)
        {
            paths.SetV1();

            var usePath = paths.ApplicationsPath(guid) + $"/{appGuid}";

            try
            {
                var temp = await Patch<object>(app, usePath);
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, usePath);
            }

            return _response;
        }

        
    }
}
