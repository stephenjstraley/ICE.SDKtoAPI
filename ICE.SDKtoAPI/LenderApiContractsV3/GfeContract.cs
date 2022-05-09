using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GfeContract
    {
        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "aggregateAdjustment")]
        public decimal? AggregateAdjustment { get; set; }

        [DataMember(Name = "brokerCommission")]
        public decimal? BrokerCommission { get; set; }

        [DataMember(Name = "brokerLicense")]
        public string BrokerLicense { get; set; }

        [DataMember(Name = "brokerName")]
        public string BrokerName { get; set; }

        [DataMember(Name = "brokerRepresentative")]
        public string BrokerRepresentative { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "compensationFromLenderAmount")]
        public decimal? CompensationFromLenderAmount { get; set; }

        [DataMember(Name = "compensationFromLenderPercentage")]
        public decimal? CompensationFromLenderPercentage { get; set; }

        [DataMember(Name = "compensationFromLenderTotalAmount")]
        public decimal? CompensationFromLenderTotalAmount { get; set; }

        [DataMember(Name = "creditLifeOrDisabilityPremium")]
        public decimal? CreditLifeOrDisabilityPremium { get; set; }

        [DataMember(Name = "creditToBorrowerAmount")]
        public decimal? CreditToBorrowerAmount { get; set; }

        [DataMember(Name = "estimatedCashAtClosing")]
        public decimal? EstimatedCashAtClosing { get; set; }

        [DataMember(Name = "estimatedCashToBorrower")]
        public decimal? EstimatedCashToBorrower { get; set; }

        [DataMember(Name = "estimatedDueDate")]
        public string EstimatedDueDate { get; set; }

        [DataMember(Name = "finalBalloonPayment")]
        public decimal? FinalBalloonPayment { get; set; }

        [DataMember(Name = "firstChangePayment")]
        public decimal? FirstChangePayment { get; set; }

        [DataMember(Name = "firstChangePercent")]
        public decimal? FirstChangePercent { get; set; }

        [DataMember(Name = "fundingAmount")]
        public decimal? FundingAmount { get; set; }

        [DataMember(Name = "gfeFees")]
        public List<GfeFeeContract> GfeFees { get; set; }

        [DataMember(Name = "gfeLiens")]
        public List<GfeLienContract> GfeLiens { get; set; }

        [DataMember(Name = "gfePayments")]
        public List<GfePaymentContract> GfePayments { get; set; }

        [DataMember(Name = "gfePayoffs")]
        public List<GfePayoffContract> GfePayoffs { get; set; }

        [DataMember(Name = "gfeProvidedByBrokerIndicator")]
        public bool? GfeProvidedByBrokerIndicator { get; set; }

        [DataMember(Name = "hasAdditionalCompensationIndicator")]
        public bool? HasAdditionalCompensationIndicator { get; set; }

        [DataMember(Name = "hasLateChargesIndicator")]
        public bool? HasLateChargesIndicator { get; set; }

        [DataMember(Name = "hasPrepaymentPenaltyIndicator")]
        public bool? HasPrepaymentPenaltyIndicator { get; set; }

        [DataMember(Name = "initialFixedOrArmType")]
        public string InitialFixedOrArmType { get; set; }

        [DataMember(Name = "lenderOriginationFee")]
        public decimal? LenderOriginationFee { get; set; }

        [DataMember(Name = "loanFromBrokerControlledFundsType")]
        public string LoanFromBrokerControlledFundsType { get; set; }

        [DataMember(Name = "lockField")]
        public bool? LockField { get; set; }

        [DataMember(Name = "maxLifePayment")]
        public decimal? MaxLifePayment { get; set; }

        [DataMember(Name = "maxPaymentAfterMonth")]
        public int? MaxPaymentAfterMonth { get; set; }

        [DataMember(Name = "monthlyPaymentAndEscrow")]
        public decimal? MonthlyPaymentAndEscrow { get; set; }

        [DataMember(Name = "mortgageBrokerComissionFee")]
        public decimal? MortgageBrokerComissionFee { get; set; }

        [DataMember(Name = "mortgageBrokerCommissionFeePaidToName")]
        public string MortgageBrokerCommissionFeePaidToName { get; set; }

        [DataMember(Name = "natureLien1Description")]
        public string NatureLien1Description { get; set; }

        [DataMember(Name = "natureLien1PayoffDescription")]
        public string NatureLien1PayoffDescription { get; set; }

        [DataMember(Name = "natureLien2Description")]
        public string NatureLien2Description { get; set; }

        [DataMember(Name = "natureLien2PayoffDescription")]
        public string NatureLien2PayoffDescription { get; set; }

        [DataMember(Name = "natureLien3Description")]
        public string NatureLien3Description { get; set; }

        [DataMember(Name = "natureLien3PayoffDescription")]
        public string NatureLien3PayoffDescription { get; set; }

        [DataMember(Name = "paymentOfPrincipleIndicator")]
        public bool? PaymentOfPrincipleIndicator { get; set; }

        [DataMember(Name = "paymentOfPrincipleType")]
        public string PaymentOfPrincipleType { get; set; }

        [DataMember(Name = "penaltyNotToExceedMonths")]
        public int? PenaltyNotToExceedMonths { get; set; }

        [DataMember(Name = "pocPaid1")]
        public string PocPaid1 { get; set; }

        [DataMember(Name = "pocPaid2")]
        public string PocPaid2 { get; set; }

        [DataMember(Name = "pocPaid3")]
        public string PocPaid3 { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "prepaymentOtherDescription")]
        public string PrepaymentOtherDescription { get; set; }

        [DataMember(Name = "prepaymentOtherTypeIndicator")]
        public bool? PrepaymentOtherTypeIndicator { get; set; }

        [DataMember(Name = "prepaymentPenaltyAmount")]
        public decimal? PrepaymentPenaltyAmount { get; set; }

        [DataMember(Name = "prepaymentPenaltyIndicator")]
        public bool? PrepaymentPenaltyIndicator { get; set; }

        [DataMember(Name = "prepaymentPenaltyPeriod")]
        public int? PrepaymentPenaltyPeriod { get; set; }

        [DataMember(Name = "principalAmount")]
        public decimal? PrincipalAmount { get; set; }

        [DataMember(Name = "purchasePayOff")]
        public decimal? PurchasePayOff { get; set; }

        [DataMember(Name = "re882AdditionalCompensation")]
        public decimal? Re882AdditionalCompensation { get; set; }

        [DataMember(Name = "receivedFromLenderAmount")]
        public decimal? ReceivedFromLenderAmount { get; set; }

        [DataMember(Name = "representativeLicense")]
        public string RepresentativeLicense { get; set; }

        [DataMember(Name = "sourcesDeemedReliableIndicator")]
        public bool? SourcesDeemedReliableIndicator { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "subtotalOfAllDeductions")]
        public decimal? SubtotalOfAllDeductions { get; set; }

        [DataMember(Name = "totalBrokerCompensationAmount")]
        public decimal? TotalBrokerCompensationAmount { get; set; }

        [DataMember(Name = "totalClosingCostWithDiscount")]
        public decimal? TotalClosingCostWithDiscount { get; set; }

        [DataMember(Name = "totalCostsExpenses")]
        public decimal? TotalCostsExpenses { get; set; }

        [DataMember(Name = "totalMaximumCostsExpenses")]
        public decimal? TotalMaximumCostsExpenses { get; set; }

        [DataMember(Name = "totalOfInitialFees")]
        public decimal? TotalOfInitialFees { get; set; }

        [DataMember(Name = "totalPrepaidClosingCost")]
        public decimal? TotalPrepaidClosingCost { get; set; }

        [DataMember(Name = "totalSettlementCharges")]
        public decimal? TotalSettlementCharges { get; set; }

        [DataMember(Name = "totalTaxAndInsurance")]
        public decimal? TotalTaxAndInsurance { get; set; }

        [DataMember(Name = "yearlyFloodInsurance")]
        public decimal? YearlyFloodInsurance { get; set; }

        [DataMember(Name = "yearlyInsurance")]
        public decimal? YearlyInsurance { get; set; }

        [DataMember(Name = "yearlyMortgageInsurance")]
        public decimal? YearlyMortgageInsurance { get; set; }

        [DataMember(Name = "yearlyOtherInsurance")]
        public decimal? YearlyOtherInsurance { get; set; }

        [DataMember(Name = "yearlyOtherInsuranceDescription")]
        public string YearlyOtherInsuranceDescription { get; set; }

        [DataMember(Name = "yearlyTax")]
        public decimal? YearlyTax { get; set; }
    }
}
