using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class SecondaryFinancingProviderContract
    {
        [DataMember(Name = "secondaryFinancingProviderType")]
        public string SecondaryFinancingProviderType { get; set; }

        [DataMember(Name = "financingAmount")]
        public decimal? FinancingAmount { get; set; }

        [DataMember(Name = "sellerFundedDapIndicator")]
        public bool? SellerFundedDapIndicator { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "sourceFromFamilyIndicator")]
        public bool? SourceFromFamilyIndicator { get; set; }

        [DataMember(Name = "sourceFromGovernmentIndicator")]
        public bool? SourceFromGovernmentIndicator { get; set; }

        [DataMember(Name = "sourceFromNpIndicator")]
        public bool? SourceFromNpIndicator { get; set; }

        [DataMember(Name = "sourceFromOtherIndicator")]
        public bool? SourceFromOtherIndicator { get; set; }

        [DataMember(Name = "sourceOtherDetail")]
        public string SourceOtherDetail { get; set; }

    }
}
