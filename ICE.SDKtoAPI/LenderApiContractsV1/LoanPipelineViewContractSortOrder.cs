using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineViewContractSortOrder
    {
        [DataMember(Name = "canonicalName", EmitDefaultValue = false)]
        public string CanonicalName { get; set; }

        [DataMember(Name = "order", EmitDefaultValue = false)]
        public object Order { get; set; }
    }
}
