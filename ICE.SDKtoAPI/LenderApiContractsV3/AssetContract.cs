using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AssetContract
    {
        [DataMember(Name = "assetType")]
        public string AssetType { get; set; }

        [DataMember(Name = "assetTypeIndex")]
        public int? AssetTypeIndex { get; set; }

        [DataMember(Name = "accountIdentifier")]
        public string AccountIdentifier { get; set; }

        [DataMember(Name = "cashOrMarketValueAmount")]
        public decimal? CashOrMarketValueAmount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "holderName")]
        public string HolderName { get; set; }

        [DataMember(Name = "lifeInsuranceFaceValueAmount")]
        public decimal? LifeInsuranceFaceValueAmount { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }
}
