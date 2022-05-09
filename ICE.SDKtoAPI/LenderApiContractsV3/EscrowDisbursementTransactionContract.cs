using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EscrowDisbursementTransactionContract
    {
        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "createdById")]
        public string CreatedById { get; set; }

        [DataMember(Name = "createdByName")]
        public string CreatedByName { get; set; }

        [DataMember(Name = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        [DataMember(Name = "disbursementDueDate")]
        public string DisbursementDueDate { get; set; }

        [DataMember(Name = "disbursementNumber")]
        public int? DisbursementNumber { get; set; }

        [DataMember(Name = "disbursementType")]
        public string DisbursementType { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "institutionName")]
        public string InstitutionName { get; set; }

        [DataMember(Name = "modifiedById")]
        public string ModifiedById { get; set; }

        [DataMember(Name = "modifiedByName")]
        public string ModifiedByName { get; set; }

        [DataMember(Name = "modifiedDateTime")]
        public string ModifiedDateTime { get; set; }

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
