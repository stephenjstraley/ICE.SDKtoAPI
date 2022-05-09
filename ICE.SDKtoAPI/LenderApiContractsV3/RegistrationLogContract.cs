using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RegistrationLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "isCurrent")]
        public bool? IsCurrent { get; set; }

        [DataMember(Name = "registrationDate")]
        public string RegistrationDate { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember(Name = "investorName")]
        public string InvestorName { get; set; }

        [DataMember(Name = "referenceNumber")]
        public string ReferenceNumber { get; set; }

        [DataMember(Name = "registeredBy")]
        public string RegisteredBy { get; set; }

        [DataMember(Name = "createdDate")]
        public string CreatedDate { get; set; }

    }
}
