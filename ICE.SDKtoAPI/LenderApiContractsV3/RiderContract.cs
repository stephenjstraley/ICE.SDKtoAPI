using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RiderContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "riderName")]
        public string RiderName { get; set; }

        [DataMember(Name = "required")]
        public bool? Required { get; set; }

        [DataMember(Name = "received")]
        public bool? Received { get; set; }

        [DataMember(Name = "riderDate")]
        public string RiderDate { get; set; }

    }
}
