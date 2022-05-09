using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PriceAdjustmentContract
    {
        [DataMember(Name = "priceAdjustmentType")]
        public string PriceAdjustmentType { get; set; }

        [DataMember(Name = "adjustmentType")]
        public string AdjustmentType { get; set; }

        [DataMember(Name = "priceAdjustmentTypeIndex")]
        public int PriceAdjustmentTypeIndex { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "rate")]
        public decimal? Rate { get; set; }

        [DataMember(Name = "rateLockAdjustmentType")]
        public string RateLockAdjustmentType { get; set; }

    }
}
