using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineViewContract
    {
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<string> Fields { get; set; }

        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public LoanPipelineFilterContract Filter { get; set; }

        [DataMember(Name = "loanGuids", EmitDefaultValue = false)]
        public List<string> LoanGuids { get; set; }

        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public List<LoanPipelineViewContractSortOrder> SortOrder { get; set; }
    }
}
