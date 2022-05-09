using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class NonBorrowingOwnerContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "legacyId")]
        public string LegacyId { get; set; }

        [DataMember(Name = "nonBorrowingOwnerIndex")]
        public int NonBorrowingOwnerIndex { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "suffixName")]
        public string SuffixName { get; set; }

        [DataMember(Name = "addressStreet")]
        public string AddressStreet { get; set; }

        [DataMember(Name = "addressCity")]
        public string AddressCity { get; set; }

        [DataMember(Name = "addressState")]
        public string AddressState { get; set; }

        [DataMember(Name = "addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

        [DataMember(Name = "homePhoneNumber")]
        public string HomePhoneNumber { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "no3rdPartyEmailIndicator")]
        public bool? No3rdPartyEmailIndicator { get; set; }

        [DataMember(Name = "businessPhoneNumber")]
        public string BusinessPhoneNumber { get; set; }

        [DataMember(Name = "cellPhoneNumber")]
        public string CellPhoneNumber { get; set; }

        [DataMember(Name = "faxNumber")]
        public string FaxNumber { get; set; }

        [DataMember(Name = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        [DataMember(Name = "borrowerVestingRecordId")]
        public string BorrowerVestingRecordId { get; set; }

        [DataMember(Name = "eSignConsentNbocStatus")]
        public string ESignConsentNbocStatus { get; set; }

        [DataMember(Name = "eSignConsentNbocDateAccepted")]
        public string ESignConsentNbocDateAccepted { get; set; }

        [DataMember(Name = "eSignConsentNbocIpAddress")]
        public string ESignConsentNbocIpAddress { get; set; }

        [DataMember(Name = "eSignConsentNbocSource")]
        public string ESignConsentNbocSource { get; set; }

        [DataMember(Name = "eSignConsentNbocDateSent")]
        public string ESignConsentNbocDateSent { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

    }
}
