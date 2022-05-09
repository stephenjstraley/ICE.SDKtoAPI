using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockDenialContract
    {
        [DataMember(Name = "alertIndicator")]
        public bool? AlertIndicator { get; set; }

        [DataMember(Name = "deniedBy")]
        public string DeniedBy { get; set; }

        [DataMember(Name = "deniedById")]
        public string DeniedById { get; set; }

        [DataMember(Name = "requestGuid")]
        public string RequestGuid { get; set; }

        [DataMember(Name = "timeDenied")]
        public string TimeDenied { get; set; }

    }
}
