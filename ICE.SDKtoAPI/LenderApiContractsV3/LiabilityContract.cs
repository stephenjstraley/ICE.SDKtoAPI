using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LiabilityContract
    {
        [DataMember(Name = "liabilityType")]
        public string LiabilityType { get; set; }

        [DataMember(Name = "liabilityTypeIndex")]
        public int? LiabilityTypeIndex { get; set; }

        [DataMember(Name = "accountIdentifier")]
        public string AccountIdentifier { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "monthlyPaymentAmount")]
        public decimal? MonthlyPaymentAmount { get; set; }

        [DataMember(Name = "remainingTermMonths")]
        public int? RemainingTermMonths { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

    }
}
