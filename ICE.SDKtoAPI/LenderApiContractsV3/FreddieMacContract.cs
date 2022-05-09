using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FreddieMacContract
    {
        [DataMember(Name = "affordableProduct")]
        public string AffordableProduct { get; set; }

        [DataMember(Name = "alimonyAsIncomeReduction")]
        public decimal? AlimonyAsIncomeReduction { get; set; }

        [DataMember(Name = "allMonthlyPayments")]
        public decimal? AllMonthlyPayments { get; set; }

        [DataMember(Name = "allowsNegativeAmortizationIndicator")]
        public bool? AllowsNegativeAmortizationIndicator { get; set; }

        [DataMember(Name = "amountOfFinancedMi")]
        public string AmountOfFinancedMi { get; set; }

        [DataMember(Name = "apnCity")]
        public string ApnCity { get; set; }

        [DataMember(Name = "armsLengthTransactionIndicator")]
        public bool? ArmsLengthTransactionIndicator { get; set; }

        [DataMember(Name = "borrowerQualifiesAsVeteranIndicator")]
        public bool? BorrowerQualifiesAsVeteranIndicator { get; set; }

        [DataMember(Name = "brokerOriginated")]
        public string BrokerOriginated { get; set; }

        [DataMember(Name = "buydownContributor")]
        public string BuydownContributor { get; set; }

        [DataMember(Name = "condoClass")]
        public string CondoClass { get; set; }

        [DataMember(Name = "convertibleFeeAmount")]
        public decimal? ConvertibleFeeAmount { get; set; }

        [DataMember(Name = "convertibleFeePercent")]
        public decimal? ConvertibleFeePercent { get; set; }

        [DataMember(Name = "convertibleMaxRateAdjPercent")]
        public decimal? ConvertibleMaxRateAdjPercent { get; set; }

        [DataMember(Name = "convertibleMinRateAdjPercent")]
        public decimal? ConvertibleMinRateAdjPercent { get; set; }

        [DataMember(Name = "county")]
        public string County { get; set; }

        [DataMember(Name = "creditReportCompany")]
        public string CreditReportCompany { get; set; }

        [DataMember(Name = "financingConcessions")]
        public decimal? FinancingConcessions { get; set; }

        [DataMember(Name = "freddieFiel11")]
        public string FreddieFiel11 { get; set; }

        [DataMember(Name = "freddieFiel12")]
        public string FreddieFiel12 { get; set; }

        [DataMember(Name = "freddieFiel13")]
        public string FreddieFiel13 { get; set; }

        [DataMember(Name = "freddieFiel14")]
        public string FreddieFiel14 { get; set; }

        [DataMember(Name = "freddieFiel15")]
        public string FreddieFiel15 { get; set; }

        [DataMember(Name = "freddieField3")]
        public string FreddieField3 { get; set; }

        [DataMember(Name = "freddieField7")]
        public string FreddieField7 { get; set; }

        [DataMember(Name = "helocActualBalance")]
        public string HelocActualBalance { get; set; }

        [DataMember(Name = "helocCreditLimit")]
        public string HelocCreditLimit { get; set; }

        [DataMember(Name = "lenderAltPhone")]
        public string LenderAltPhone { get; set; }

        [DataMember(Name = "lenderRegistration")]
        public string LenderRegistration { get; set; }

        [DataMember(Name = "loanProspectorId")]
        public string LoanProspectorId { get; set; }

        [DataMember(Name = "loanToConduitCode")]
        public string LoanToConduitCode { get; set; }

        [DataMember(Name = "longLegalDescription")]
        public string LongLegalDescription { get; set; }

        [DataMember(Name = "lossCoverage")]
        public string LossCoverage { get; set; }

        [DataMember(Name = "lpKeyNumber")]
        public string LpKeyNumber { get; set; }

        [DataMember(Name = "miRefundOption")]
        public string MiRefundOption { get; set; }

        [DataMember(Name = "mortgageInsuranceCompany")]
        public string MortgageInsuranceCompany { get; set; }

        [DataMember(Name = "netPurchasePrice")]
        public decimal? NetPurchasePrice { get; set; }

        [DataMember(Name = "newConstructionType")]
        public string NewConstructionType { get; set; }

        [DataMember(Name = "noAppraisalMaf")]
        public string NoAppraisalMaf { get; set; }

        [DataMember(Name = "nonOccupantNonHousingDebt")]
        public decimal? NonOccupantNonHousingDebt { get; set; }

        [DataMember(Name = "nonOccupantPresentHe")]
        public decimal? NonOccupantPresentHe { get; set; }

        [DataMember(Name = "orderCreditEvaluationIndicator")]
        public bool? OrderCreditEvaluationIndicator { get; set; }

        [DataMember(Name = "orderMergedCreditReportIndicator")]
        public bool? OrderMergedCreditReportIndicator { get; set; }

        [DataMember(Name = "orderMortgageInsurance")]
        public string OrderMortgageInsurance { get; set; }

        [DataMember(Name = "orderRiskGradeEvaluationIndicator")]
        public bool? OrderRiskGradeEvaluationIndicator { get; set; }

        [DataMember(Name = "originalIntRate")]
        public decimal? OriginalIntRate { get; set; }

        [DataMember(Name = "originateId")]
        public string OriginateId { get; set; }

        [DataMember(Name = "paymentFrequency")]
        public string PaymentFrequency { get; set; }

        [DataMember(Name = "paymentOption")]
        public string PaymentOption { get; set; }

        [DataMember(Name = "personIncomeForSelfEmployment1")]
        public decimal? PersonIncomeForSelfEmployment1 { get; set; }

        [DataMember(Name = "personIncomeForSelfEmployment2")]
        public decimal? PersonIncomeForSelfEmployment2 { get; set; }

        [DataMember(Name = "personPercentOfBusinessOwned1")]
        public int? PersonPercentOfBusinessOwned1 { get; set; }

        [DataMember(Name = "personPercentOfBusinessOwned2")]
        public int? PersonPercentOfBusinessOwned2 { get; set; }

        [DataMember(Name = "premiumSource")]
        public string PremiumSource { get; set; }

        [DataMember(Name = "presentHousingExpense")]
        public decimal? PresentHousingExpense { get; set; }

        [DataMember(Name = "processingPoint")]
        public string ProcessingPoint { get; set; }

        [DataMember(Name = "propertyType")]
        public string PropertyType { get; set; }

        [DataMember(Name = "purposeOfLoan")]
        public string PurposeOfLoan { get; set; }

        [DataMember(Name = "renewalOption")]
        public string RenewalOption { get; set; }

        [DataMember(Name = "renewalType")]
        public string RenewalType { get; set; }

        [DataMember(Name = "requiredDocumentType")]
        public string RequiredDocumentType { get; set; }

        [DataMember(Name = "reserves")]
        public decimal? Reserves { get; set; }

        [DataMember(Name = "retailLoanIndicator")]
        public bool? RetailLoanIndicator { get; set; }

        [DataMember(Name = "riskClass")]
        public string RiskClass { get; set; }

        [DataMember(Name = "riskGradeEvaluationType")]
        public string RiskGradeEvaluationType { get; set; }

        [DataMember(Name = "salesConcessions")]
        public decimal? SalesConcessions { get; set; }

        [DataMember(Name = "secondaryFinancingType")]
        public string SecondaryFinancingType { get; set; }

        [DataMember(Name = "secondTrustRefiIndicator")]
        public bool? SecondTrustRefiIndicator { get; set; }

        [DataMember(Name = "simulatedPiti")]
        public decimal? SimulatedPiti { get; set; }

        [DataMember(Name = "sizeOfHousehold")]
        public string SizeOfHousehold { get; set; }

        [DataMember(Name = "specialInstruction1")]
        public string SpecialInstruction1 { get; set; }

        [DataMember(Name = "specialInstruction2")]
        public string SpecialInstruction2 { get; set; }

        [DataMember(Name = "specialInstruction3")]
        public string SpecialInstruction3 { get; set; }

        [DataMember(Name = "specialInstruction4")]
        public string SpecialInstruction4 { get; set; }

        [DataMember(Name = "specialInstruction5")]
        public string SpecialInstruction5 { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "transferLoanToConduitIndicator")]
        public bool? TransferLoanToConduitIndicator { get; set; }

        [DataMember(Name = "yearsOfCoverage")]
        public string YearsOfCoverage { get; set; }

        [DataMember(Name = "correspondentAssignmentId")]
        public string CorrespondentAssignmentId { get; set; }

        [DataMember(Name = "freddieMacOwnedMessage")]
        public string FreddieMacOwnedMessage { get; set; }

        [DataMember(Name = "freddieMacAppraisalHybrid")]
        public string FreddieMacAppraisalHybrid { get; set; }
    }
}
