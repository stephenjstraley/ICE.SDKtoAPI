using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineItemContract
    {
        [DataMember(Name = "fields")]
        public object Fields { get; set; }

        [DataMember(Name = "loanGuid")]
        public string LoanGuid { get; set; }
    }
}
