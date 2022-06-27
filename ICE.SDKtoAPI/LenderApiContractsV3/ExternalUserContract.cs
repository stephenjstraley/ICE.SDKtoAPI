using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ExternalUserContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "useCompanyAddress")]
        public bool? UseCompanyAddress { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "suffix")]
        public string Suffix { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zipCode")]
        public string ZipCode { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "cellPhone")]
        public string CellPhone { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "nmlsId")]
        public string NmlsId { get; set; }

        [DataMember(Name = "nmlsCurrent")]
        public bool? NmlsCurrent { get; set; }

        [DataMember(Name = "ssn")]
        public string Ssn { get; set; }

        [DataMember(Name = "useParentInfoForRateLock")]
        public bool? UseParentInfoForRateLock { get; set; }

        [DataMember(Name = "emailForRateSheet")]
        public string EmailForRateSheet { get; set; }

        [DataMember(Name = "faxForRateSheet")]
        public string FaxForRateSheet { get; set; }

        [DataMember(Name = "emailForLockInfo")]
        public string EmailForLockInfo { get; set; }

        [DataMember(Name = "faxForLockInfo")]
        public string FaxForLockInfo { get; set; }

        [DataMember(Name = "disabledLogin")]
        public bool? DisabledLogin { get; set; }

        [DataMember(Name = "emailForLogin")]
        public string EmailForLogin { get; set; }

        [DataMember(Name = "passwordChangedDate")]
        public string PasswordChangedDate { get; set; }

        [DataMember(Name = "welcomeEmailSent")]
        public string WelcomeEmailSent { get; set; }

        [DataMember(Name = "welcomeEmailDate")]
        public string WelcomeEmailDate { get; set; }

        [DataMember(Name = "siteUrls")]
        List<string> SiteUrls { get; set; }

        [DataMember(Name = "approvalCurrentStatus")]
        public string ApprovalCurrentStatus { get; set; }

        [DataMember(Name = "addToWatchlist")]
        public bool? AddToWatchlist { get; set; }

        [DataMember(Name = "approvalCurrentStatusDate")]
        public string ApprovalCurrentStatusDate { get; set; }

        [DataMember(Name = "approvalDate")]
        public string ApprovalDate { get; set; }

        [DataMember(Name = "salesRep")]
        public EntityReferenceContract SalesRep { get; set; }

        [DataMember(Name = "personas")]
        public List<EntityReferenceContract> Personas { get; set; }

        [DataMember(Name = "roles")]
        public List<EntityReferenceContract> Roles { get; set; }

        [DataMember(Name = "groups")]
        public List<EntityReferenceContract> Groups { get; set; }

        [DataMember(Name = "peerLoanAccess")]
        public string PeerLoanAccess { get; set; }

        [DataMember(Name = "accessMode")]
        public string AccessMode { get; set; }

        [DataMember(Name = "licenses")]
        public List<StateLicenseTypeContract> Licenses { get; set; }

        [DataMember(Name = "roleTypes")]
        public List<string> RoleTypes { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "requirePasswordChange")]
        public bool? RequirePasswordChange { get; set; }

        [DataMember(Name = "lastLogin")]
        public string LastLogin { get; set; }

        [DataMember(Name = "updatedBy")]
        public EntityReferenceContract UpdatedBy { get; set; }

        [DataMember(Name = "updatedDateTime")]
        public string UpdatedDateTime { get; set; }

        [DataMember(Name = "organization")]
        public EntityReferenceContract Organization { get; set; }
    }
}
