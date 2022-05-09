using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TqlDocumentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "tqlDocumentDeliveredDate")]
        public string TqlDocumentDeliveredDate { get; set; }

    }
}
