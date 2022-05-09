using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class UrlaAlternateNameContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "suffix")]
        public string Suffix { get; set; }

        [DataMember(Name = "fullName")]
        public string FullName { get; set; }
    }

    [DataContract]
    public class UrlaAlternateNameContractFull : UrlaAlternateNameContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
