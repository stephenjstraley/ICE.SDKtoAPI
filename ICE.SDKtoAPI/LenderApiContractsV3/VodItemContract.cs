using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class VodItemContract
    {
        [DataMember(Name = "itemNumber")]
        public int ItemNumber { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "accountIdentifier")]
        public string AccountIdentifier { get; set; }

        [DataMember(Name = "cashOrMarketValueAmount")]
        public decimal? CashOrMarketValueAmount { get; set; }

        [DataMember(Name = "urla2020CashOrMarketValueAmount")]
        public decimal? Urla2020CashOrMarketValueAmount { get; set; }

        [DataMember(Name = "depositoryAccountName")]
        public string DepositoryAccountName { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }
}
