using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TrustAccountItemContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "notes")]
        public string Notes { get; set; }

        [DataMember(Name = "paymentAmount")]
        public decimal? PaymentAmount { get; set; }

        [DataMember(Name = "paymentCheckNo")]
        public string PaymentCheckNo { get; set; }

        [DataMember(Name = "receiptAmount")]
        public decimal? ReceiptAmount { get; set; }

        [DataMember(Name = "receiptCheckNo")]
        public string ReceiptCheckNo { get; set; }

    }
}
