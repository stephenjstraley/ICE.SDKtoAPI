using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserContract : BaseEncompassModel
    {
        [DataMember(Name = "apiUser")]
        public string ApiUser { get; set; }

        [DataMember(Name = "ccSite")]
        public UserContractCcSite CcSite { get; set; }

        [DataMember(Name = "cellPhone")]
        public string CellPhone { get; set; }

        [DataMember(Name = "chumID")]
        public string ChumID { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "emailSignature")]
        public string EmailSignature { get; set; }

        [DataMember(Name = "employeeID")]
        public string EmployeeID { get; set; }

        [DataMember(Name = "encompassVersion")]
        public string EncompassVersion { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "lastLogin")]
        public DateTime? LastLogin { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "nmlsExpirationDate")]
        public string NmlsExpirationDate { get; set; }

        [DataMember(Name = "nmlsOriginatorID")]
        public string NmlsOriginatorID { get; set; }

        [DataMember(Name = "oAuthClientId")]
        public string OAuthClientId { get; set; }

        [DataMember(Name = "organization")]
        public EntityRefContract Organization { get; set; }

        [DataMember(Name = "peerLoanAccess")]
        public string PeerLoanAccess { get; set; }

        [DataMember(Name = "personalStatusOnline")]
        public bool? PersonalStatusOnline { get; set; }

        [DataMember(Name = "personas")]
        public List<EntityRefContract> Personas { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "subordinateLoanAccess")]
        public string SubordinateLoanAccess { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "userIndicators")]
        public List<string> UserIndicators { get; set; }

        [DataMember(Name = "workingFolder")]
        public string WorkingFolder { get; set; }





    }
}
