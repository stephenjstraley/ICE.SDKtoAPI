using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AdditionalStateDisclosureContract
    {
        [DataMember(Name = "stateCode")]
        public string StateCode { get; set; }

        [DataMember(Name = "disclosureName")]
        public string DisclosureName { get; set; }

        [DataMember(Name = "disclosureValue")]
        public string DisclosureValue { get; set; }
    }
}
