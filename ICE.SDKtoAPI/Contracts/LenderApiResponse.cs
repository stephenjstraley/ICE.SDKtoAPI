using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;

namespace ICE.SDKtoAPI.Contracts
{
    public class LenderApiResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.OK;
        public string ExtraInfo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Query { get; set; } = string.Empty;
        public HttpResponseHeaders Headers { get; set; }
        public string GetHeaderValue(string header)
        {
            if (Headers != null)
            {
                IEnumerable<string> tCount = null;
                Headers.TryGetValues(header, out tCount);
                if (tCount != null) return tCount.FirstOrDefault();
                else return null;

            }
            return null;
        }
        public string ResponseContext { get; set; } = string.Empty;

    }
}
