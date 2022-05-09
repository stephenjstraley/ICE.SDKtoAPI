using System;
using System.Collections.Generic;
using System.Net;
using ICE.SDKtoAPI.Providers;
using System.Text;
using ICE.SDKtoAPI.Contracts;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI
{
    public partial class LenderAPI
    {
        public bool GetToken()
        {
            GetTokenAsync().Wait();
            return (LastStatus == HttpStatusCode.OK && _accessToken != null);
        }
        public async Task<AccessToken> GetTokenAsync()
        {
            SetResponse();

            _accessToken = null;

            var ta = new TokenProviderService(_credentials);

            var providerReturn = await ta.GetTokenAsync();

            _accessToken = providerReturn.Item1;
            _lastResponse = providerReturn.Item2;

            if (LastStatus == HttpStatusCode.OK)
                Fields.SetAccessToken(_accessToken);

            return _accessToken;
        }
        public async Task<Tuple<AccessToken, LenderApiResponse>> ValidateTokenAsync()
        {
            SetResponse();

            var ta = new TokenProviderService(_credentials);
            _lastResponse = await ta.ValidateTokenAsync(_accessToken);

            if (_lastResponse.IsSuccess)
                return new Tuple<AccessToken, LenderApiResponse>(_accessToken, _lastResponse);
            else
                return new Tuple<AccessToken, LenderApiResponse>(null, _lastResponse);
        }
        public async Task<string> GetLoanGuidAsync(string loanNumber)
        {
            _guid = null;

            if (_accessToken == null)
            {
                throw new SDKAPIBaseAccessTokenException("No access token defined")
                {
                    LoanId = _loanV1?.EncompassId,
                    LoanNumber = _loanV1?.LoanNumber
                };
            }

            SetResponse();
            var service = new PipelineProviderService(_accessToken);
            var values = await service.GetLoanGuidAsync(loanNumber);

            _guid = values.Item1;
            _lastResponse = values.Item2;

            return _guid;
        }
    }
}
