using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanSubmissionFeeContract
    {
        [DataMember(Name = "loanSubmissionFeeType")]
        public string LoanSubmissionFeeType { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "dueBroker")]
        public decimal? DueBroker { get; set; }

        [DataMember(Name = "dueLender")]
        public decimal? DueLender { get; set; }

        [DataMember(Name = "total")]
        public decimal? Total { get; set; }

    }
}
