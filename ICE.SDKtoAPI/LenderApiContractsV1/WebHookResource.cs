using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class WebHookResource
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "events")]
        public List<WebHookResourceEvent> Events { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }
    }

    [DataContract]
    public class WebHookResourceEvent
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "extraPayload")]
        public bool ExtraPayload { get; set; } = false;
    }
}
