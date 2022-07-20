using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanPipelineViewContract
    {
        [DataMember(Name = "fields")]
        public List<string> Fields { get; set; }

        [DataMember(Name = "filter")]
        public LoanPipelineFilterContract Filter { get; set; }

        [DataMember(Name = "loanGuids")]
        public List<string> LoanGuids { get; set; }

        [DataMember(Name = "sortOrder")]
        public List<LoanPipelineViewContractSortOrder> SortOrder { get; set; }
    }
}
