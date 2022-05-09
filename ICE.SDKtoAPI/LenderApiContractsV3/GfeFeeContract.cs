using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GfeFeeContract
    {
        [DataMember(Name = "gfeFeeType")]
        public string GfeFeeType { get; set; }

        [DataMember(Name = "gfeFeeIndex")]
        public int? GfeFeeIndex { get; set; }

        [DataMember(Name = "amountDescription")]
        public string AmountDescription { get; set; }

        [DataMember(Name = "brokerAmount")]
        public decimal? BrokerAmount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "otherAmount")]
        public decimal? OtherAmount { get; set; }

        [DataMember(Name = "rate")]
        public string Rate { get; set; }
    }
}
