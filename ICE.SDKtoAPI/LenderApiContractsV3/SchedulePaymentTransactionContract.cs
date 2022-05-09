using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class SchedulePaymentTransactionContract
    {
        [DataMember(Name = "buydownSubsidyAmountDue")]
        public decimal? BuydownSubsidyAmountDue { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "createdById")]
        public string CreatedById { get; set; }

        [DataMember(Name = "createdByName")]
        public string CreatedByName { get; set; }

        [DataMember(Name = "createdDateTime")]
        public string CreatedDateTime { get; set; }

        [DataMember(Name = "escrowDue")]
        public decimal? EscrowDue { get; set; }

        [DataMember(Name = "guid")]
        public string Guid { get; set; }

        [DataMember(Name = "indexRate")]
        public decimal? IndexRate { get; set; }

        [DataMember(Name = "interestDue")]
        public decimal? InterestDue { get; set; }

        [DataMember(Name = "interestRate")]
        public decimal? InterestRate { get; set; }

        [DataMember(Name = "latePaymentDate")]
        public string LatePaymentDate { get; set; }

        [DataMember(Name = "miscFeeDue")]
        public decimal? MiscFeeDue { get; set; }

        [DataMember(Name = "modifiedById")]
        public string ModifiedById { get; set; }

        [DataMember(Name = "modifiedByName")]
        public string ModifiedByName { get; set; }

        [DataMember(Name = "modifiedDateTime")]
        public string ModifiedDateTime { get; set; }

        [DataMember(Name = "paymentNumber")]
        public int PaymentNumber { get; set; }

        [DataMember(Name = "principalDue")]
        public decimal? PrincipalDue { get; set; }

        [DataMember(Name = "servicingPaymentMethod")]
        public string ServicingPaymentMethod { get; set; }

        [DataMember(Name = "servicingTransactionType")]
        public string ServicingTransactionType { get; set; }

        [DataMember(Name = "totalPastDue")]
        public decimal? TotalPastDue { get; set; }

        [DataMember(Name = "transactionAmount")]
        public decimal? TransactionAmount { get; set; }

        [DataMember(Name = "transactionDate")]
        public string TransactionDate { get; set; }

        [DataMember(Name = "unpaidLateFeeDue")]
        public decimal? UnpaidLateFeeDue { get; set; }

        [DataMember(Name = "paymentReceiveDate")]
        public string PaymentReceiveDate { get; set; }

        [DataMember(Name = "escrowTaxDue")]
        public decimal? EscrowTaxDue { get; set; }

        [DataMember(Name = "escrowHazardInsuranceDue")]
        public decimal? EscrowHazardInsuranceDue { get; set; }

        [DataMember(Name = "escrowMortgageInsuranceDue")]
        public decimal? EscrowMortgageInsuranceDue { get; set; }

        [DataMember(Name = "escrowFloodInsuranceDue")]
        public decimal? EscrowFloodInsuranceDue { get; set; }

        [DataMember(Name = "escrowCityPropertyTaxDue")]
        public decimal? EscrowCityPropertyTaxDue { get; set; }

        [DataMember(Name = "escrowOther1Due")]
        public decimal? EscrowOther1Due { get; set; }

        [DataMember(Name = "escrowOther2Due")]
        public decimal? EscrowOther2Due { get; set; }

        [DataMember(Name = "escrowOther3Due")]
        public decimal? EscrowOther3Due { get; set; }

        [DataMember(Name = "escrowUsdaMonthlyPremiumDue")]
        public decimal? EscrowUsdaMonthlyPremiumDue { get; set; }

        [DataMember(Name = "principal")]
        public decimal? Principal { get; set; }

        [DataMember(Name = "interest")]
        public decimal? Interest { get; set; }

        [DataMember(Name = "escrow")]
        public decimal? Escrow { get; set; }

        [DataMember(Name = "miscFee")]
        public decimal? MiscFee { get; set; }

        [DataMember(Name = "lateFee")]
        public decimal? LateFee { get; set; }

        [DataMember(Name = "additionalPrincipal")]
        public decimal? AdditionalPrincipal { get; set; }

        [DataMember(Name = "additionalEscrow")]
        public decimal? AdditionalEscrow { get; set; }

        [DataMember(Name = "taxes")]
        public decimal? Taxes { get; set; }

        [DataMember(Name = "hazardInsurance")]
        public decimal? HazardInsurance { get; set; }

        [DataMember(Name = "mortgageInsurance")]
        public decimal? MortgageInsurance { get; set; }

        [DataMember(Name = "floodInsurance")]
        public decimal? FloodInsurance { get; set; }

        [DataMember(Name = "cityPropertyTax")]
        public decimal? CityPropertyTax { get; set; }

        [DataMember(Name = "other1Escrow")]
        public decimal? Other1Escrow { get; set; }

        [DataMember(Name = "other2Escrow")]
        public decimal? Other2Escrow { get; set; }

        [DataMember(Name = "other3Escrow")]
        public decimal? Other3Escrow { get; set; }

        [DataMember(Name = "usdaMonthlyPremium")]
        public decimal? UsdaMonthlyPremium { get; set; }

        [DataMember(Name = "buydownSubsidyAmount")]
        public decimal? BuydownSubsidyAmount { get; set; }

    }
}
