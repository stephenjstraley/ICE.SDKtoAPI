using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanProgramContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "acquisition")]
        public string Acquisition { get; set; }

        [DataMember(Name = "additionalArmInformation")]
        public string AdditionalArmInformation { get; set; }

        [DataMember(Name = "allDateAndNumericalDisclosures")]
        public string AllDateAndNumericalDisclosures { get; set; }

        [DataMember(Name = "annualFeeNeeded")]
        public decimal? AnnualFeeNeeded { get; set; }

        [DataMember(Name = "armTypeDescription")]
        public string ArmTypeDescription { get; set; }

        [DataMember(Name = "assumptionOnYourProperty")]
        public string AssumptionOnYourProperty { get; set; }

        [DataMember(Name = "balloonLoanMaturityTermMonths")]
        public int? BalloonLoanMaturityTermMonths { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths1")]
        public int? BuydownChangeFrequencyMonths1 { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths2")]
        public int? BuydownChangeFrequencyMonths2 { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths3")]
        public int? BuydownChangeFrequencyMonths3 { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths4")]
        public int? BuydownChangeFrequencyMonths4 { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths5")]
        public int? BuydownChangeFrequencyMonths5 { get; set; }

        [DataMember(Name = "buydownChangeFrequencyMonths6")]
        public int? BuydownChangeFrequencyMonths6 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent1")]
        public decimal? BuydownIncreaseRatePercent1 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent2")]
        public decimal? BuydownIncreaseRatePercent2 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent3")]
        public decimal? BuydownIncreaseRatePercent3 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent4")]
        public decimal? BuydownIncreaseRatePercent4 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent5")]
        public decimal? BuydownIncreaseRatePercent5 { get; set; }

        [DataMember(Name = "buydownIncreaseRatePercent6")]
        public decimal? BuydownIncreaseRatePercent6 { get; set; }

        [DataMember(Name = "calculateBasedOnRemainingBalance")]
        public string CalculateBasedOnRemainingBalance { get; set; }

        [DataMember(Name = "closingCostProgram")]
        public string ClosingCostProgram { get; set; }

        [DataMember(Name = "constructionDescription")]
        public string ConstructionDescription { get; set; }

        [DataMember(Name = "constructionInterestReserveAmount")]
        public decimal? ConstructionInterestReserveAmount { get; set; }

        [DataMember(Name = "constructionLoanMethod")]
        public string ConstructionLoanMethod { get; set; }

        [DataMember(Name = "constructionPeriodMonths")]
        public int? ConstructionPeriodMonths { get; set; }

        [DataMember(Name = "constructionRate")]
        public decimal? ConstructionRate { get; set; }

        [DataMember(Name = "convertible")]
        public string Convertible { get; set; }

        [DataMember(Name = "creditDisability")]
        public string CreditDisability { get; set; }

        [DataMember(Name = "creditLifeInsurance")]
        public string CreditLifeInsurance { get; set; }

        [DataMember(Name = "demandFeature")]
        public string DemandFeature { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "disclosureType")]
        public string DisclosureType { get; set; }

        [DataMember(Name = "discounted")]
        public string Discounted { get; set; }

        [DataMember(Name = "discountedRate")]
        public decimal? DiscountedRate { get; set; }

        [DataMember(Name = "drawRepayPeriodTableName")]
        public string DrawRepayPeriodTableName { get; set; }

        [DataMember(Name = "fhaUpfrontMiPremiumPercent")]
        public decimal? FhaUpfrontMiPremiumPercent { get; set; }

        [DataMember(Name = "floodInsurance")]
        public string FloodInsurance { get; set; }

        [DataMember(Name = "floorPercent")]
        public decimal? FloorPercent { get; set; }

        [DataMember(Name = "fundingFeePaidInCash")]
        public decimal? FundingFeePaidInCash { get; set; }

        [DataMember(Name = "gpmExtraPaymentForEarlyPayOff")]
        public decimal? GpmExtraPaymentForEarlyPayOff { get; set; }

        [DataMember(Name = "gpmRate")]
        public decimal? GpmRate { get; set; }

        [DataMember(Name = "gpmYears")]
        public int? GpmYears { get; set; }

        [DataMember(Name = "ifYouPurchase")]
        public string IfYouPurchase { get; set; }

        [DataMember(Name = "ifYouPurchaseType")]
        public string IfYouPurchaseType { get; set; }

        [DataMember(Name = "indexCurrentValuePercent")]
        public decimal? IndexCurrentValuePercent { get; set; }

        [DataMember(Name = "indexMarginPercent")]
        public decimal? IndexMarginPercent { get; set; }

        [DataMember(Name = "initialAdvanceAmount")]
        public decimal? InitialAdvanceAmount { get; set; }

        [DataMember(Name = "interestOnlyMonths")]
        public int? InterestOnlyMonths { get; set; }

        [DataMember(Name = "lateChargeDays")]
        public int? LateChargeDays { get; set; }

        [DataMember(Name = "lateChargePercent")]
        public decimal? LateChargePercent { get; set; }

        [DataMember(Name = "lateChargeType")]
        public string LateChargeType { get; set; }

        [DataMember(Name = "lenderInvestorCode")]
        public string LenderInvestorCode { get; set; }

        [DataMember(Name = "lienPriorityType")]
        public string LienPriorityType { get; set; }

        [DataMember(Name = "loanAmortizationTermMonths")]
        public int? LoanAmortizationTermMonths { get; set; }

        [DataMember(Name = "loanAmortizationType")]
        public string LoanAmortizationType { get; set; }

        [DataMember(Name = "loanDocumentationType")]
        public string LoanDocumentationType { get; set; }

        [DataMember(Name = "loanFeaturesPaymentFrequencyType")]
        public string LoanFeaturesPaymentFrequencyType { get; set; }

        [DataMember(Name = "loanProgramName")]
        public string LoanProgramName { get; set; }

        [DataMember(Name = "lockField")]
        public bool? LockField { get; set; }

        [DataMember(Name = "maxBackRatio")]
        public decimal? MaxBackRatio { get; set; }

        [DataMember(Name = "maxCltv")]
        public decimal? MaxCltv { get; set; }

        [DataMember(Name = "maxFrontRatio")]
        public decimal? MaxFrontRatio { get; set; }

        [DataMember(Name = "maximumBalance")]
        public decimal? MaximumBalance { get; set; }

        [DataMember(Name = "maxLoanAmount")]
        public decimal? MaxLoanAmount { get; set; }

        [DataMember(Name = "maxLtv")]
        public decimal? MaxLtv { get; set; }

        [DataMember(Name = "meansAnEstimate")]
        public string MeansAnEstimate { get; set; }

        [DataMember(Name = "miCalculationType")]
        public string MiCalculationType { get; set; }

        [DataMember(Name = "midpointCancellation")]
        public string MidpointCancellation { get; set; }

        [DataMember(Name = "minCreditScore")]
        public string MinCreditScore { get; set; }

        [DataMember(Name = "minimumAdvanceAmount")]
        public decimal? MinimumAdvanceAmount { get; set; }

        [DataMember(Name = "minimumAllowableApr")]
        public decimal? MinimumAllowableApr { get; set; }

        [DataMember(Name = "minimumPaymentAmount")]
        public decimal? MinimumPaymentAmount { get; set; }

        [DataMember(Name = "minimumPaymentPercent")]
        public decimal? MinimumPaymentPercent { get; set; }

        [DataMember(Name = "mipPaidInCash")]
        public decimal? MipPaidInCash { get; set; }

        [DataMember(Name = "mmi")]
        public bool? Mmi { get; set; }

        [DataMember(Name = "mortgageInsuranceAdjustmentFactor1")]
        public decimal? MortgageInsuranceAdjustmentFactor1 { get; set; }

        [DataMember(Name = "mortgageInsuranceAdjustmentFactor2")]
        public decimal? MortgageInsuranceAdjustmentFactor2 { get; set; }

        [DataMember(Name = "mortgageInsuranceCancelPercent")]
        public decimal? MortgageInsuranceCancelPercent { get; set; }

        [DataMember(Name = "mortgageInsuranceMonthlyPayment1")]
        public decimal? MortgageInsuranceMonthlyPayment1 { get; set; }

        [DataMember(Name = "mortgageInsuranceMonthlyPayment2")]
        public decimal? MortgageInsuranceMonthlyPayment2 { get; set; }

        [DataMember(Name = "mortgageInsuranceMonthsOfAdjustment1")]
        public int? MortgageInsuranceMonthsOfAdjustment1 { get; set; }

        [DataMember(Name = "mortgageInsuranceMonthsOfAdjustment2")]
        public int? MortgageInsuranceMonthsOfAdjustment2 { get; set; }

        [DataMember(Name = "mortgageType")]
        public string MortgageType { get; set; }

        [DataMember(Name = "otherAmortizationTypeDescription")]
        public string OtherAmortizationTypeDescription { get; set; }

        [DataMember(Name = "otherLoanPurposeDescription")]
        public string OtherLoanPurposeDescription { get; set; }

        [DataMember(Name = "otherMortgageTypeDescription")]
        public string OtherMortgageTypeDescription { get; set; }

        [DataMember(Name = "paymentAdjustmentDurationMonths")]
        public int? PaymentAdjustmentDurationMonths { get; set; }

        [DataMember(Name = "paymentAdjustmentPeriodicCapPercent")]
        public decimal? PaymentAdjustmentPeriodicCapPercent { get; set; }

        [DataMember(Name = "paymentFactor")]
        public decimal? PaymentFactor { get; set; }

        [DataMember(Name = "percentageOfRental")]
        public decimal? PercentageOfRental { get; set; }

        [DataMember(Name = "perDiemCalculationMethodType")]
        public string PerDiemCalculationMethodType { get; set; }

        [DataMember(Name = "pmi")]
        public bool? Pmi { get; set; }

        [DataMember(Name = "prepaymentPenaltyIndicator")]
        public string PrepaymentPenaltyIndicator { get; set; }

        [DataMember(Name = "programCode")]
        public string ProgramCode { get; set; }

        [DataMember(Name = "propertyInsurance")]
        public string PropertyInsurance { get; set; }

        [DataMember(Name = "propertyUsageType")]
        public string PropertyUsageType { get; set; }

        [DataMember(Name = "qualifyingRatePercent")]
        public decimal? QualifyingRatePercent { get; set; }

        [DataMember(Name = "rateAdjustmentDurationMonths")]
        public int? RateAdjustmentDurationMonths { get; set; }

        [DataMember(Name = "rateAdjustmentLifetimeCapPercent")]
        public decimal? RateAdjustmentLifetimeCapPercent { get; set; }

        [DataMember(Name = "rateAdjustmentPercent")]
        public decimal? RateAdjustmentPercent { get; set; }

        [DataMember(Name = "rateAdjustmentSubsequentCapPercent")]
        public decimal? RateAdjustmentSubsequentCapPercent { get; set; }

        [DataMember(Name = "rateAdjustmentSubsequentRateAdjustmentMonths")]
        public int? RateAdjustmentSubsequentRateAdjustmentMonths { get; set; }

        [DataMember(Name = "recastPaidMonths")]
        public int? RecastPaidMonths { get; set; }

        [DataMember(Name = "recastStopMonths")]
        public int? RecastStopMonths { get; set; }

        [DataMember(Name = "refundPaymentIndicator")]
        public string RefundPaymentIndicator { get; set; }

        [DataMember(Name = "requestedInterestRatePercent")]
        public decimal? RequestedInterestRatePercent { get; set; }

        [DataMember(Name = "requiredDeposit")]
        public string RequiredDeposit { get; set; }

        [DataMember(Name = "roundPercent")]
        public decimal? RoundPercent { get; set; }

        [DataMember(Name = "roundType")]
        public string RoundType { get; set; }

        [DataMember(Name = "securityInterestInNameOf")]
        public string SecurityInterestInNameOf { get; set; }

        [DataMember(Name = "securityType")]
        public string SecurityType { get; set; }

        [DataMember(Name = "subjectPropertyGrossRentalIncome")]
        public decimal? SubjectPropertyGrossRentalIncome { get; set; }

        [DataMember(Name = "teaserRate")]
        public decimal? TeaserRate { get; set; }

        [DataMember(Name = "terminationFeeAmount")]
        public decimal? TerminationFeeAmount { get; set; }

        [DataMember(Name = "terminationPeriodMonthsCount")]
        public int? TerminationPeriodMonthsCount { get; set; }

        [DataMember(Name = "thirdPartyFeeFrom")]
        public decimal? ThirdPartyFeeFrom { get; set; }

        [DataMember(Name = "thirdPartyFeeTo")]
        public decimal? ThirdPartyFeeTo { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "useDaysInYears")]
        public string UseDaysInYears { get; set; }

        [DataMember(Name = "usePitiForRatio")]
        public string UsePitiForRatio { get; set; }

        [DataMember(Name = "variableRateFeature")]
        public string VariableRateFeature { get; set; }

        [DataMember(Name = "yearlyTerm")]
        public decimal? YearlyTerm { get; set; }

    }
}
