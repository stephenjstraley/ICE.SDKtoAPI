using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserProfileContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "workingFolder")]
        public string WorkingFolder { get; set; }

        [DataMember(Name = "organization")]
        public EntityRefContract Organization { get; set; }

        [DataMember(Name = "subordinateLoanAccess")]
        public string SubordinateLoanAccess { get; set; }

        [DataMember(Name = "userIndicators")]
        public List<string> UserIndicators { get; set; }

        [DataMember(Name = "peerLoanAccess")]
        public string PeerLoanAccess { get; set; }

        [DataMember(Name = "lastLogin")]
        public string LastLogin { get; set; }

        [DataMember(Name = "personalStatusOnline")]
        public string PersonalStatusOnline { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "personas")]
        public List<EntityRefContract> Personas { get; set; }
    }
}
