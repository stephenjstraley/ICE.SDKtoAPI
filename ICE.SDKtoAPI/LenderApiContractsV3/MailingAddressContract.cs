using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MailingAddressContract
    {
        [DataMember(Name = "addressCity")]
        public string AddressCity { get; set; }

        [DataMember(Name = "addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [DataMember(Name = "addressState")]
        public string AddressState { get; set; }

        [DataMember(Name = "addressStreetLine1")]
        public string AddressStreetLine1 { get; set; }

        [DataMember(Name = "addressCounty")]
        public string AddressCounty { get; set; }

        [DataMember(Name = "addressUnitDesignatorType")]
        public string AddressUnitDesignatorType { get; set; }

        [DataMember(Name = "addressUnitIdentifier")]
        public string AddressUnitIdentifier { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "urla2020StreetAddress")]
        public string Urla2020StreetAddress { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

    }
}
