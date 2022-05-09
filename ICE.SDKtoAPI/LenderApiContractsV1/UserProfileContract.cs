using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserProfileContract
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        public string FullName { get; set; }

        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        [DataMember(Name = "workingFolder", EmitDefaultValue = false)]
        public string WorkingFolder { get; set; }

        [DataMember(Name = "organization", EmitDefaultValue = false)]
        public EntityRefContract Organization { get; set; }

        [DataMember(Name = "subordinateLoanAccess", EmitDefaultValue = false)]
        public string SubordinateLoanAccess { get; set; }

        [DataMember(Name = "userIndicators", EmitDefaultValue = false)]
        public List<string> UserIndicators { get; set; }

        [DataMember(Name = "peerLoanAccess", EmitDefaultValue = false)]
        public string PeerLoanAccess { get; set; }

        [DataMember(Name = "lastLogin", EmitDefaultValue = false)]
        public string LastLogin { get; set; }

        [DataMember(Name = "personalStatusOnline", EmitDefaultValue = false)]
        public string PersonalStatusOnline { get; set; }

        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        [DataMember(Name = "personas", EmitDefaultValue = false)]
        public List<EntityRefContract> Personas { get; set; }
    }
}
