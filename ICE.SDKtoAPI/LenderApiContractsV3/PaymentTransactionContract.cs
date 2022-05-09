using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PaymentTransactionContract
    {
        [DataMember(Name = "accountHolder")]
        public string AccountHolder { get; set; }

        [DataMember(Name = "accountNumber")]
        public string AccountNumber { get; set; }

        [DataMember(Name = "additionalEscrow")]
        public decimal? AdditionalEscrow { get; set; }

        [DataMember(Name = "additionalPrincipal")]
        public decimal? AdditionalPrincipal { get; set; }

        [DataMember(Name = "buydownSubsidyAmount")]
        public decimal? BuydownSubsidyAmount { get; set; }

        [DataMember(Name = "checkNumber")]
        public string CheckNumber { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "commonAmount")]
        public decimal? CommonAmount { get; set; }

        [DataMember(Name = "commonDate")]
        public string CommonDate { get; set; }

        [DataMember(Name = "createdById")]
        public string CreatedById { get; set; }

        [DataMember(Name = "createdByName")]
        public string CreatedByName { get; set; }

        [DataMember(Name = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        [DataMember(Name = "escrow")]
        public decimal? Escrow { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "indexRate")]
        public decimal? IndexRate { get; set; }

        [DataMember(Name = "institutionName")]
        public string InstitutionName { get; set; }

        [DataMember(Name = "institutionRouting")]
        public string InstitutionRouting { get; set; }

        [DataMember(Name = "interest")]
        public decimal? Interest { get; set; }

        [DataMember(Name = "interestRate")]
        public decimal? InterestRate { get; set; }

        [DataMember(Name = "lateFee")]
        public decimal? LateFee { get; set; }

        [DataMember(Name = "lateFeeIfLate")]
        public decimal? LateFeeIfLate { get; set; }

        [DataMember(Name = "latePaymentDate")]
        public string LatePaymentDate { get; set; }

        [DataMember(Name = "miscFee")]
        public decimal? MiscFee { get; set; }

        [DataMember(Name = "modifiedById")]
        public string ModifiedById { get; set; }

        [DataMember(Name = "modifiedByName")]
        public string ModifiedByName { get; set; }

        [DataMember(Name = "modifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [DataMember(Name = "paymentDepositedDate")]
        public string PaymentDepositedDate { get; set; }

        [DataMember(Name = "paymentDueDate")]
        public string PaymentDueDate { get; set; }

        [DataMember(Name = "paymentIndexDate")]
        public string PaymentIndexDate { get; set; }

        [DataMember(Name = "paymentNumber")]
        public int PaymentNumber { get; set; }

        [DataMember(Name = "paymentReceivedDate")]
        public string PaymentReceivedDate { get; set; }

        [DataMember(Name = "principal")]
        public decimal? Principal { get; set; }

        [DataMember(Name = "reference")]
        public string Reference { get; set; }

        [DataMember(Name = "servicingPaymentMethod")]
        public string ServicingPaymentMethod { get; set; }

        [DataMember(Name = "servicingTransactionType")]
        public string ServicingTransactionType { get; set; }

        [DataMember(Name = "statementDate")]
        public string StatementDate { get; set; }

        [DataMember(Name = "totalAmountDue")]
        public decimal? TotalAmountDue { get; set; }

        [DataMember(Name = "totalAmountReceived")]
        public decimal? TotalAmountReceived { get; set; }

        [DataMember(Name = "transactionAmount")]
        public decimal? TransactionAmount { get; set; }

        [DataMember(Name = "transactionDate")]
        public string TransactionDate { get; set; }

        [DataMember(Name = "escrowUsdaMonthlyPremium")]
        public decimal? EscrowUsdaMonthlyPremium { get; set; }

        [DataMember(Name = "schedulePayLogMiscFee")]
        public decimal? SchedulePayLogMiscFee { get; set; }

        [DataMember(Name = "escrowTax")]
        public decimal? EscrowTax { get; set; }

        [DataMember(Name = "escrowMortgageInsurance")]
        public decimal? EscrowMortgageInsurance { get; set; }

        [DataMember(Name = "escrowHazardInsurance")]
        public decimal? EscrowHazardInsurance { get; set; }

        [DataMember(Name = "escrowFloodInsurance")]
        public decimal? EscrowFloodInsurance { get; set; }

        [DataMember(Name = "escrowCityPropertyTax")]
        public decimal? EscrowCityPropertyTax { get; set; }

        [DataMember(Name = "escrowOther1")]
        public decimal? EscrowOther1 { get; set; }

        [DataMember(Name = "escrowOther2")]
        public decimal? EscrowOther2 { get; set; }

        [DataMember(Name = "escrowOther3")]
        public decimal? EscrowOther3 { get; set; }

    }
}
