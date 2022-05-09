using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserContract : BaseEncompassModel
    {
        [DataMember(Name = "apiUser", EmitDefaultValue = false)]
        public string ApiUser { get; set; }

        [DataMember(Name = "ccSite", EmitDefaultValue = false)]
        public UserContractCcSite CcSite { get; set; }

        [DataMember(Name = "cellPhone", EmitDefaultValue = false)]
        public string CellPhone { get; set; }

        [DataMember(Name = "chumID", EmitDefaultValue = false)]
        public string ChumID { get; set; }

        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(Name = "emailSignature", EmitDefaultValue = false)]
        public string EmailSignature { get; set; }

        [DataMember(Name = "employeeID", EmitDefaultValue = false)]
        public string EmployeeID { get; set; }

        [DataMember(Name = "encompassVersion", EmitDefaultValue = false)]
        public string EncompassVersion { get; set; }

        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "lastLogin", EmitDefaultValue = false)]
        public DateTime? LastLogin { get; set; }

        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(Name = "nmlsExpirationDate", EmitDefaultValue = false)]
        public string NmlsExpirationDate { get; set; }

        [DataMember(Name = "nmlsOriginatorID", EmitDefaultValue = false)]
        public string NmlsOriginatorID { get; set; }

        [DataMember(Name = "oAuthClientId", EmitDefaultValue = false)]
        public string OAuthClientId { get; set; }

        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public EntityRefContract Organization { get; set; }

        [DataMember(Name = "peerLoanAccess", EmitDefaultValue = false)]
        public string PeerLoanAccess { get; set; }

        [DataMember(Name = "personalStatusOnline", EmitDefaultValue = false)]
        public bool? PersonalStatusOnline { get; set; }

        [DataMember(Name = "personas", EmitDefaultValue = false)]
        public List<EntityRefContract> Personas { get; set; }

        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        [DataMember(Name = "subordinateLoanAccess", EmitDefaultValue = false)]
        public string SubordinateLoanAccess { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "userIndicators", EmitDefaultValue = false)]
        public List<string> UserIndicators { get; set; }

        [DataMember(Name = "workingFolder", EmitDefaultValue = false)]
        public string WorkingFolder { get; set; }





    }
}
