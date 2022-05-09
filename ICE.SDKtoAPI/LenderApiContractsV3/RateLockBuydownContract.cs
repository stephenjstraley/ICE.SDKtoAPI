using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RateLockBuydownContract
    {
        [DataMember(Name = "rateLockBuydownIndex")]
        public int RateLockBuydownIndex { get; set; }

        [DataMember(Name = "increaseRatePercent")]
        public decimal? IncreaseRatePercent { get; set; }

        [DataMember(Name = "changeFrequencyMonths")]
        public int? ChangeFrequencyMonths { get; set; }

    }
}
