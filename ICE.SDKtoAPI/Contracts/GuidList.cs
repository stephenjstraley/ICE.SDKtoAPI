using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class Guid
    {
        [JsonProperty(PropertyName = "loanGuid")]
        public string LoanGuid { get; set; }
    }
}
