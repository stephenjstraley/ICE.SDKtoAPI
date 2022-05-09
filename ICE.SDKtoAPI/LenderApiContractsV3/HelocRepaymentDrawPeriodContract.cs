using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class HelocRepaymentDrawPeriodContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "apr")]
        public decimal? Apr { get; set; }

        [DataMember(Name = "drawIndicator")]
        public bool DrawIndicator { get; set; }

        [DataMember(Name = "indexRatePercent")]
        public decimal? IndexRatePercent { get; set; }

        [DataMember(Name = "marginRatePercent")]
        public decimal? MarginRatePercent { get; set; }

        [DataMember(Name = "minimumMonthlyPaymentAmount")]
        public decimal? MinimumMonthlyPaymentAmount { get; set; }

        [DataMember(Name = "year")]
        public int? Year { get; set; }
    }
}
