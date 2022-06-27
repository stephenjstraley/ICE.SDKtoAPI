using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class WebHookSubscription
    {
        [DataMember(Name = "endpoint")]
        public string Endpoint { get; set; }

        [DataMember(Name = "signingkey")]
        public string Signingkey { get; set; }

        [DataMember(Name = "subscriptionId")]
        public string SubscriptionId { get; set; }

        [DataMember(Name = "filters")]
        public List<string> Filters { get; set; }

        [DataMember(Name = "ClientId")]
        public string ClientId { get; set; }

        [DataMember(Name = "objectUrn")]
        public string ObjectUrn { get; set; }

        [DataMember(Name = "events")]
        public List<string> Events { get; set; }

        [DataMember(Name = "instanceId")]
        public string InstanceId { get; set; }

        [DataMember(Name = "resource")]
        public string Resource { get; set; }
    }
}
