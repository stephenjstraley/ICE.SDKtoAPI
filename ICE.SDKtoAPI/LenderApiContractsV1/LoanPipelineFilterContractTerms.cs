using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineFilterContractTerms
    {
        [DataMember(Name = "canonicalName")]
        public string CanonicalName { get; set; }

        [DataMember(Name = "include")]
        public bool? Include { get; set; }

        [DataMember(Name = "matchType")]
        public string MatchType { get; set; }

        [DataMember(Name = "precision")]
        public object Precision { get; set; }

        [DataMember(Name = "terms")]
        public List<LoanPipelineFilterContract> Terms { get; set; }

        [DataMember(Name = "value")]
        public object Value { get; set; }
    }
}
