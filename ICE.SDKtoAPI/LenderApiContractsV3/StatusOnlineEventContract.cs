using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class StatusOnlineEventContract
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

    }
}
