using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureRecipientContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "recipientType")]
        public string RecipientType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "disclosedMethod")]
        public string DisclosedMethod { get; set; }

        [DataMember(Name = "disclosedMethodDescription")]
        public string DisclosedMethodDescription { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }

        [DataMember(Name = "presumedReceivedDate")]
        public string PresumedReceivedDate { get; set; }

        [DataMember(Name = "actualReceivedDate")]
        public string ActualReceivedDate { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

        [DataMember(Name = "tracking")]
        public string Tracking { get; set; }

    }
}
