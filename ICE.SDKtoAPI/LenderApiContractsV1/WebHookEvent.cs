using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class WebHookEvent
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "time")]
        public DateTime Time { get; set; }

        [DataMember(Name = "event")]
        public WebHookEventDetail Event { get; set; }
    }

    [DataContract]
    public class WebHookEventDetail
    {
        [DataMember(Name = "instanceId")]
        public string InstanceId { get; set; }

        [DataMember(Name = "clientId")]
        public string ClientId { get; set; }

        [DataMember(Name = "eventId")]
        public string EventId { get; set; }

        [DataMember(Name = "eventTime")]
        public DateTime EventTime { get; set; }

        [DataMember(Name = "eventType")]
        public string EventType { get; set; }

        [DataMember(Name = "resourceId")]
        public string ResourceId { get; set; }

        [DataMember(Name = "resourceType")]
        public string ResourceType { get; set; }

        [DataMember(Name = "ingressTime")]
        public DateTime IngressTime { get; set; }

        [DataMember(Name = "subscriptionId")]
        public string SubscriptionId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusDetails")]
        public string StatusDetails { get; set; }
    }
}
