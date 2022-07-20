using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineFilterContract
    {
        [DataMember(Name = "operator")]
        public string Operator { get; set; }

        [DataMember(Name = "terms")]
        public List<LoanPipelineFilterContractTerms> Terms { get; set; }
    }
}
