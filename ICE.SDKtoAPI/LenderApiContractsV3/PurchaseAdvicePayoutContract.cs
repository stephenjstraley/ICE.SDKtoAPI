using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PurchaseAdvicePayoutContract
    {
        [DataMember(Name = "purchaseAdvicePayoutIndex")]
        public int PurchaseAdvicePayoutIndex { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "diffAmount")]
        public decimal? DiffAmount { get; set; }

        [DataMember(Name = "expectedAmount")]
        public decimal? ExpectedAmount { get; set; }

    }
}
