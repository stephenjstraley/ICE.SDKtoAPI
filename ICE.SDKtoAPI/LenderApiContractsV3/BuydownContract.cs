using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class BuydownContract
    {
        [DataMember(Name = "buydownIndex")]
        public int BuydownIndex { get; set; }

        [DataMember(Name = "buydownRatePercent")]
        public decimal? BuydownRatePercent { get; set; }

        [DataMember(Name = "changeFrequencyMonthsCount")]
        public int? ChangeFrequencyMonthsCount { get; set; }

        [DataMember(Name = "durationMonthsCount")]
        public string DurationMonthsCount { get; set; }

        [DataMember(Name = "fundBalanceAmount")]
        public decimal? FundBalanceAmount { get; set; }

        [DataMember(Name = "fundTotalAmount")]
        public decimal? FundTotalAmount { get; set; }

        [DataMember(Name = "increaseRatePercent")]
        public decimal? IncreaseRatePercent { get; set; }

        [DataMember(Name = "remainingMonthsCount")]
        public int? RemainingMonthsCount { get; set; }

        [DataMember(Name = "subsidyAmount")]
        public decimal? SubsidyAmount { get; set; }

        [DataMember(Name = "nonBorrowerChangeFrequencyMonthsCount")]
        public int? NonBorrowerChangeFrequencyMonthsCount { get; set; }

        [DataMember(Name = "nonBorrowerIncreaseRatePercent")]
        public decimal? NonBorrowerIncreaseRatePercent { get; set; }

    }
}
