using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FulfillmentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "isManual")]
        public bool? IsManual { get; set; }

        [DataMember(Name = "disclosedMethod")]
        public string DisclosedMethod { get; set; }

        [DataMember(Name = "orderedBy")]
        public string OrderedBy { get; set; }

        [DataMember(Name = "processedDate")]
        public string ProcessedDate { get; set; }

        [DataMember(Name = "recipients")]
        public List<FulfillmentRecipientContract> Recipients { get; set; }
    }
}
