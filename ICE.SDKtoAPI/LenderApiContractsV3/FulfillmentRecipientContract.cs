using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FulfillmentRecipientContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "presumedDate")]
        public string PresumedDate { get; set; }

        [DataMember(Name = "actualDate")]
        public string ActualDate { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }
    }
}
