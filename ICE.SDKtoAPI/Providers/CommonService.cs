using Flurl.Http;
using ICE.SDKtoAPI.Contracts;
using System.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using ICE.SDKtoAPI.LenderApiContractsV1;
using ICE.SDKtoAPI.Extensions;
using Flurl;

namespace ICE.SDKtoAPI.Providers
{
    public class CommonService
    {
        protected AccessToken _token;
        protected HttpResponseMessage _lastMsg;
        protected LenderApiResponse _response;
        protected UrlPaths paths = new UrlPaths();
        public bool SaveResponse = false;

        public CommonService(AccessToken token) { _token = token; }
        public IFlurlRequest Authenticate(string url)
        {
            return url.AllowAnyHttpStatus()
                      .WithHeader("Authorization", $"Bearer {_token.Access_Token}");
        }
        public void ClearResponse()
        {
            _response = null;
            _lastMsg = null;
        }
        public LenderApiResponse OkResponse(string url = "")
        {
            return new LenderApiResponse()
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Url = url
            };
        }
        public LenderApiResponse OkResponse(HttpResponseHeaders headers, string url = "")
        {
            return new LenderApiResponse()
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Url = url,
                Headers = headers
            };
        }
        public LenderApiResponse OkResponse(HttpResponseMessage response, string url = "")
        {
            return new LenderApiResponse()
            {
                StatusCode = response?.StatusCode ?? HttpStatusCode.OK,
                IsSuccess = true,
                Url = url,
                Headers = response?.Headers ?? null
            };
        }
        public LenderApiResponse OkResponse(HttpResponseMessage response, string url, string query)
        {
            return new LenderApiResponse()
            {
                StatusCode = response?.StatusCode ?? HttpStatusCode.OK,
                IsSuccess = true,
                Url = url,
                Query = query,
                Headers = response?.Headers ?? null
            };
        }
        public LenderApiResponse BadResponse(FlurlHttpException e, string path, string respCont)
        {
            var errorMessage = e.GetResponseJsonAsync().Result;
            var status = (e.Call.HttpStatus == null) ? HttpStatusCode.InternalServerError : (HttpStatusCode)e.Call.HttpStatus;
            return BadResponse(status, e?.Message ?? string.Empty, errorMessage, path, respCont);
        }
        public LenderApiResponse BadResponse(Exception ex, string path, string respCont) => BadResponse(HttpStatusCode.ExpectationFailed, 
                                                                                                        ex?.Message ?? string.Empty, 
                                                                                                        ex.InnerException?.Message ?? string.Empty, 
                                                                                                        respCont, 
                                                                                                        path);
        public LenderApiResponse BadResponse(HttpStatusCode status, string message, string errorMessage, string respCont, string url = "")
        {
            return new LenderApiResponse
            {
                IsSuccess = false,
                StatusCode = status,
                Message = message,
                ErrorMessage = errorMessage,
                Url = url,
                ResponseContext = respCont
            };
        }
        public LenderApiResponse BadResponse(HttpStatusCode status, string message, object errorMessage, string respCont, string url = "")
        {
            return new LenderApiResponse
            {
                IsSuccess = false,
                StatusCode = status,
                Message = message,
                ErrorMessage = errorMessage.ToString(),
                Url = url,
                ResponseContext = respCont
            };
        }

        protected async Task<T> Get<T>(string path)
        {
            var cont = string.Empty;
            try
            {
                var client = Authenticate(path);
                _lastMsg = await client.GetAsync();

                if (SaveResponse)
                    cont = await _lastMsg.Content.ReadAsStringAsync();

                var ret = _lastMsg.ReceiveJson<T>();
                _response = OkResponse(_lastMsg.Headers, path);
                return ret;
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, path, cont);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, path, cont);
            }

            return default;
        }
        protected async Task<string> GetString(string path)
        {
            try
            {
                var client = Authenticate(path);
                _lastMsg = await client.GetAsync();
                var ret = await _lastMsg.Content.ReadAsStringAsync();
                _response = OkResponse(_lastMsg.Headers, path);
                return ret;
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, path, string.Empty);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, path, string.Empty);
            }

            return null;

        }
        protected async Task<T> Patch<T>(object item, string path)
        {
            var client = Authenticate(path);
            _lastMsg = await client.PatchJsonAsync(item);
            var ret = _lastMsg.ReceiveJson<T>();
            _response = OkResponse(_lastMsg.Headers, path);
            return ret;
        }
        protected async Task Patch(object item, string path)
        {
            var client = Authenticate(path);
            _lastMsg = await client.PatchJsonAsync(item);
            _response = OkResponse(_lastMsg.Headers, path);
        }
        protected async Task<T> Post<T>(object item, string path)
        {
            var cont = string.Empty;

            try
            {
                var client = Authenticate(path);
                _lastMsg = await client.PostJsonAsync(item);

                if (SaveResponse)
                    cont = await _lastMsg.Content.ReadAsStringAsync();

                var ret = _lastMsg.ReceiveJson<T>();
                _response = OkResponse(_lastMsg.Headers, path);
                return ret;
            }
            catch (FlurlHttpException fe)
            {
                _response = BadResponse(fe, path, cont);
            }
            catch (Exception exp)
            {
                _response = BadResponse(exp, path, cont);
            }

            return default;
        }
        protected async Task Post(object item, string path)
        {
            var client = Authenticate(path);
            _lastMsg = await client.PostJsonAsync(item);
            _response = OkResponse(_lastMsg.Headers, path);
        }
        protected async Task Delete(string path)
        {
            var client = Authenticate(path);
            _lastMsg = await client.DeleteAsync();
            _response = OkResponse(_lastMsg.Headers, path);
        }
    }
}
