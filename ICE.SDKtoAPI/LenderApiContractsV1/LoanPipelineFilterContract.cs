using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineFilterContract
    {
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        [DataMember(Name = "terms", EmitDefaultValue = false)]
        public List<LoanPipelineFilterContractTerms> Terms { get; set; }
    }
}
