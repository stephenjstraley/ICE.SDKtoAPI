using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class SettlementServiceChargeContract
    {
        [DataMember(Name = "settlementServiceChargeIndex")]
        public int SettlementServiceChargeIndex { get; set; }

        [DataMember(Name = "amount")]
        public string Amount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

    }
}
