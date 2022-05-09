using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class IntentToProceedContract
    {
        [DataMember(Name = "intent")]
        public bool? Intent { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "receivedBy")]
        public string ReceivedBy { get; set; }

        [DataMember(Name = "receivedMethod")]
        public string ReceivedMethod { get; set; }

        [DataMember(Name = "receivedMethodOther")]
        public string ReceivedMethodOther { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

    }
}
