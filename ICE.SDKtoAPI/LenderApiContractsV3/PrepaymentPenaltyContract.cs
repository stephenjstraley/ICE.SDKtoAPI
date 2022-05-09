using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PrepaymentPenaltyContract
    {
        [DataMember(Name = "prepaymentPenaltyIndex")]
        public int PrepaymentPenaltyIndex { get; set; }

        [DataMember(Name = "fullPrepaymentPenaltyOptionType")]
        public string FullPrepaymentPenaltyOptionType { get; set; }

        [DataMember(Name = "prepaymentPenaltyPercent")]
        public decimal? PrepaymentPenaltyPercent { get; set; }

        [DataMember(Name = "termMonthsCount")]
        public int? TermMonthsCount { get; set; }

    }
}
