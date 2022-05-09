using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PaymentReversalTransactionContract
    {
        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "createdById")]
        public string CreatedById { get; set; }

        [DataMember(Name = "createdByName")]
        public string CreatedByName { get; set; }

        [DataMember(Name = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "modifiedById")]
        public string ModifiedById { get; set; }

        [DataMember(Name = "modifiedByName")]
        public string ModifiedByName { get; set; }

        [DataMember(Name = "modifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [DataMember(Name = "paymentId")]
        public string PaymentId { get; set; }

        [DataMember(Name = "reversalType")]
        public string ReversalType { get; set; }

        [DataMember(Name = "servicingPaymentMethod")]
        public string ServicingPaymentMethod { get; set; }

        [DataMember(Name = "servicingTransactionType")]
        public string ServicingTransactionType { get; set; }

        [DataMember(Name = "transactionAmount")]
        public decimal? TransactionAmount { get; set; }

        [DataMember(Name = "transactionDate")]
        public string TransactionDate { get; set; }

    }
}
