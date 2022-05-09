using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using ICE.SDKtoAPI.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ICE.SDKtoAPI.Providers
{
    public class TokenProviderService : BaseProviderService
    {
        private UserCredentials _credentials;

        public AccessToken SecurityAccessToken { get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public TokenProviderService(AccessToken token) : base(token) { paths.SetV1(); }
        public TokenProviderService(UserCredentials credentials) : base() { _credentials = credentials; }

        public async Task<Tuple<AccessToken, LenderApiResponse>> GetTokenAsync()
        {
            LenderApiResponse response = null;
            AccessToken theToken = null;

            var usePath = paths.TokenPathFull;

            try
            {
                var clientSecret = Uri.EscapeDataString(_credentials.ClientSecret);
                var clientId = Uri.EscapeDataString(_credentials.ClientId);

                var basicAuthValue = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));

                var resp = await usePath
                        .WithHeaders(new
                        {
                            Authorization = basicAuthValue,
                            ContentType = "application/x-www-form-urlencoded"
                        })
                        .PostUrlEncodedAsync(new
                        {
                            grant_type = "password",
                            username = $"{_credentials.UserName}@encompass:{_credentials.InstanceId}",
                            password = _credentials.Password,
                            scope = "lp"
                        });

                theToken = resp.ReceiveJson<AccessToken>();

                response = OkResponse(resp.Headers, usePath);

            }
            catch (FlurlHttpException fe)
            {
                response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                response = BadResponse(exp, usePath);
            }
            return new Tuple<AccessToken, LenderApiResponse>(theToken, response);
        }

        public async Task<LenderApiResponse> ValidateTokenAsync(AccessToken token)
        {
            LenderApiResponse response = null;
            var usePath = paths.TokenValid;

            var temp = new
            {
                token = token.Access_Token
            };

            try
            {
                var clientSecret = Uri.EscapeDataString(_credentials.ClientSecret);
                var clientId = Uri.EscapeDataString(_credentials.ClientId);

                var basicAuthValue = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{clientId}:{clientSecret}"));

                var resp = usePath
                .WithHeaders(new
                {
                    Authorization = basicAuthValue,
                    ContentType = "application/x-www-form-urlencoded"
                })
                .PostUrlEncodedAsync(temp);

                var validToken = await resp.ReceiveJson();

                response = OkResponse(usePath);
            }
            catch (FlurlHttpException fe)
            {
                response = BadResponse(fe, usePath);
            }
            catch (Exception exp)
            {
                response = BadResponse(exp, usePath);
            }
            return response;
        }
    }
}
