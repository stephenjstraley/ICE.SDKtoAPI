using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserContractCcSite
    {
        [DataMember(Name = "siteId")]
        public string SiteId { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        [DataMember(Name = "useParentInformation")]
        public bool? UseParentInformation { get; set; }

    }
}
