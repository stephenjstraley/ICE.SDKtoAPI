using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    [Serializable]
    public class SDKAPIBaseError : ApplicationException
    {
        public string LoanId { get; set; }
        public string LoanNumber { get; set; }
        public SDKAPIBaseError(string message) : base(message) { }
        public SDKAPIBaseError(string message, Exception inner) : base(message, inner) { }
    }
    [Serializable]
    public class SDKAPIBaseURLError : SDKAPIBaseError
    {
        public string HTTPCde { get; set; }

        public SDKAPIBaseURLError(string message) : base(message) { }
    }
    [Serializable]
    public class SDKAPIBaseAccessTokenException : SDKAPIBaseError
    {
        public SDKAPIBaseAccessTokenException(string message) : base(message) { }
        public SDKAPIBaseAccessTokenException(string message, Exception inner) : base(message, inner) { }
    }
    [Serializable]
    public class SDKAPIBaseBadRequestException : SDKAPIBaseError
    {
        public string RootRequest { get; set; } = "";
        public string Summary { get; set; } = "";
        public string Details { get; set; } = "";
        public SDKAPIBaseBadRequestException(string message) : base(message)
        {
            ParseMessage(message);
        }
        public SDKAPIBaseBadRequestException(string message, Exception inner) : base(message, inner)
        {
            ParseMessage(message);
        }
        protected void ParseMessage(string msg)
        {
            var items = msg.Split('{');
            RootRequest = items[0];
            var rest = "{" + items[1];
            var tt = Newtonsoft.Json.JsonConvert.DeserializeObject<SummaryDetails>(rest);
            Summary = tt.Summary;
            Details = tt.Details;
        }
    }

    class SummaryDetails
    {
        public string Summary { get; set; }
        public string Details { get; set; }
    }
}
