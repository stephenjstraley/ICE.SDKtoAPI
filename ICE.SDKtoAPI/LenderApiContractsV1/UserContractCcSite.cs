using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserContractCcSite
    {
        [DataMember(Name = "siteId", EmitDefaultValue = false)]
        public string SiteId { get; set; }

        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        [DataMember(Name = "useParentInformation", EmitDefaultValue = false)]
        public bool? UseParentInformation { get; set; }

    }
}
