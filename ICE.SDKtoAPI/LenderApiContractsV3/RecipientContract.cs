using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RecipientContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "contactType")]
        public string ContactType { get; set; }

        [DataMember(Name = "loanAccessToken")]
        public string LoanAccessToken { get; set; }

        [DataMember(Name = "applicationType")]
        public string ApplicationType { get; set; }

        [DataMember(Name = "authenticationCode")]
        public string AuthenticationCode { get; set; }

        [DataMember(Name = "isAuthenticated")]
        public bool? IsAuthenticated { get; set; }

        [DataMember(Name = "uuid")]
        public string Uuid { get; set; }

        [DataMember(Name = "enabled")]
        public bool? Enabled { get; set; }
    }
}
