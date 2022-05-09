using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineItemContract
    {
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public object Fields { get; set; }

        [DataMember(Name = "loanGuid", EmitDefaultValue = false)]
        public string LoanGuid { get; set; }
    }
}
