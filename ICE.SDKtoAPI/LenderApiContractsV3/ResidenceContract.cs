using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ResidenceContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "residencyType")]
        public string ResidencyType { get; set; }

        [DataMember(Name = "accountName")]
        public string AccountName { get; set; }

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

        [DataMember(Name = "doesNotApplyIndicator")]
        public bool? DoesNotApplyIndicator { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "county")]
        public string County { get; set; }

        [DataMember(Name = "durationTermMonths")]
        public int? DurationTermMonths { get; set; }

        [DataMember(Name = "durationTermYears")]
        public int? DurationTermYears { get; set; }

        [DataMember(Name = "landlordAttention")]
        public string LandlordAttention { get; set; }

        [DataMember(Name = "landlordCity")]
        public string LandlordCity { get; set; }

        [DataMember(Name = "landlordComments")]
        public string LandlordComments { get; set; }

        [DataMember(Name = "landlordFax")]
        public string LandlordFax { get; set; }

        [DataMember(Name = "landlordName")]
        public string LandlordName { get; set; }

        [DataMember(Name = "landlordPhone")]
        public string LandlordPhone { get; set; }

        [DataMember(Name = "landlordPostalCode")]
        public string LandlordPostalCode { get; set; }

        [DataMember(Name = "landlordState")]
        public string LandlordState { get; set; }

        [DataMember(Name = "landlordStreet")]
        public string LandlordStreet { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "rent")]
        public int? Rent { get; set; }

        [DataMember(Name = "requestDate")]
        public string RequestDate { get; set; }

        [DataMember(Name = "residencyBasisType")]
        public string ResidencyBasisType { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "urla2020StreetAddress")]
        public string Urla2020StreetAddress { get; set; }

        [DataMember(Name = "landlordCountry")]
        public string LandlordCountry { get; set; }

        [DataMember(Name = "landlordForeignAddressIndicator")]
        public bool? LandlordForeignAddressIndicator { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }

    [DataContract]
    public class ResidenceContractFull : ResidenceContract
    {
        [DataMember(Name = "noLinkToDocTrackIndicator")]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
