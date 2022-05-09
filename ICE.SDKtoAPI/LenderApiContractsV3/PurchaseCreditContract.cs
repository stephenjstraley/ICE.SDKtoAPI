using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PurchaseCreditContract
    {
        [DataMember(Name = "purchaseCreditIndex")]
        public int PurchaseCreditIndex { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "purchaseCreditType")]
        public string PurchaseCreditType { get; set; }

        [DataMember(Name = "purchaseCreditSource")]
        public string PurchaseCreditSource { get; set; }

    }
}
