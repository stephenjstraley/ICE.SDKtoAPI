using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ATRQMCommonContract
    {
        [DataMember(Name = "eligibleNonStandardToStandard")]
        public string EligibleNonStandardToStandard { get; set; }

        [DataMember(Name = "withOriginalCreditor")]
        public bool? WithOriginalCreditor { get; set; }

        [DataMember(Name = "has30DayLatePayment")]
        public bool? Has30DayLatePayment { get; set; }

        [DataMember(Name = "lastMonthlyPaymentDate")]
        public string LastMonthlyPaymentDate { get; set; }

        [DataMember(Name = "writtenApplicationDate")]
        public string WrittenApplicationDate { get; set; }

        [DataMember(Name = "principalBalanceIncreased")]
        public bool? PrincipalBalanceIncreased { get; set; }

        [DataMember(Name = "firstChangeRecase")]
        public int? FirstChangeRecase { get; set; }

        [DataMember(Name = "armRecastDate")]
        public string ArmRecastDate { get; set; }

        [DataMember(Name = "armRecastMonthlyPayment")]
        public decimal? ArmRecastMonthlyPayment { get; set; }

        [DataMember(Name = "interestOnlyMonths")]
        public int? InterestOnlyMonths { get; set; }

        [DataMember(Name = "interestOnlyRecastDate")]
        public string InterestOnlyRecastDate { get; set; }

        [DataMember(Name = "fullPaymentAfterInterestOnly")]
        public decimal? FullPaymentAfterInterestOnly { get; set; }

        [DataMember(Name = "negAmRecastDate")]
        public string NegAmRecastDate { get; set; }

        [DataMember(Name = "fullyArmPaymentAfterNegAm")]
        public decimal? FullyArmPaymentAfterNegAm { get; set; }

        [DataMember(Name = "firstPmtDateAfterRecast")]
        public string FirstPmtDateAfterRecast { get; set; }

        [DataMember(Name = "isConsumerLikelyDefault")]
        public bool? IsConsumerLikelyDefault { get; set; }

        [DataMember(Name = "loanRateFixedin5Years")]
        public bool? LoanRateFixedin5Years { get; set; }

        [DataMember(Name = "paymentDecreasedBy10Percent")]
        public bool? PaymentDecreasedBy10Percent { get; set; }

        [DataMember(Name = "recastDifferencePayment")]
        public decimal? RecastDifferencePayment { get; set; }

        [DataMember(Name = "principalHasDeferred")]
        public bool? PrincipalHasDeferred { get; set; }

        [DataMember(Name = "pointsFeesThresholdMet")]
        public bool? PointsFeesThresholdMet { get; set; }

        [DataMember(Name = "preventConsumersDefault")]
        public bool? PreventConsumersDefault { get; set; }

        [DataMember(Name = "atrLoanType")]
        public string AtrLoanType { get; set; }

        [DataMember(Name = "qmLoanType")]
        public string QmLoanType { get; set; }

        [DataMember(Name = "isEligibleForSafeHarbor")]
        public string IsEligibleForSafeHarbor { get; set; }

        [DataMember(Name = "generalAtrStatusOverall")]
        public string GeneralAtrStatusOverall { get; set; }

        [DataMember(Name = "generalAtrStatusDti")]
        public string GeneralAtrStatusDti { get; set; }

        [DataMember(Name = "generalAtrStatusResidualIncome")]
        public string GeneralAtrStatusResidualIncome { get; set; }

        [DataMember(Name = "generalAtrStatusCoveredLoan")]
        public string GeneralAtrStatusCoveredLoan { get; set; }

        [DataMember(Name = "generalAtrStatusSimultaneousLoan")]
        public string GeneralAtrStatusSimultaneousLoan { get; set; }

        [DataMember(Name = "generalAtrStatusMtgRelatedObligations")]
        public string GeneralAtrStatusMtgRelatedObligations { get; set; }

        [DataMember(Name = "generalAtrStatusEmployment")]
        public string GeneralAtrStatusEmployment { get; set; }

        [DataMember(Name = "generalAtrStatusIncome")]
        public string GeneralAtrStatusIncome { get; set; }

        [DataMember(Name = "generalAtrStatusAssets")]
        public string GeneralAtrStatusAssets { get; set; }

        [DataMember(Name = "generalAtrStatusDebtObligations")]
        public string GeneralAtrStatusDebtObligations { get; set; }

        [DataMember(Name = "generalAtrStatusAlimony")]
        public string GeneralAtrStatusAlimony { get; set; }

        [DataMember(Name = "generalAtrStatusChildSupport")]
        public string GeneralAtrStatusChildSupport { get; set; }

        [DataMember(Name = "generalAtrStatusCreditHistory")]
        public string GeneralAtrStatusCreditHistory { get; set; }

        [DataMember(Name = "standardQmStatusOverall")]
        public string StandardQmStatusOverall { get; set; }

        [DataMember(Name = "standardQmStatusLoanTerm")]
        public string StandardQmStatusLoanTerm { get; set; }

        [DataMember(Name = "standardQmStatusInterestOnly")]
        public string StandardQmStatusInterestOnly { get; set; }

        [DataMember(Name = "standardQmStatusNegativeAmortization")]
        public string StandardQmStatusNegativeAmortization { get; set; }

        [DataMember(Name = "standardQmStatusBalloonPayment")]
        public string StandardQmStatusBalloonPayment { get; set; }

        [DataMember(Name = "standardQmStatusPrepaymentPenalty")]
        public string StandardQmStatusPrepaymentPenalty { get; set; }

        [DataMember(Name = "standardQmStatusPointsFeesLimit")]
        public string StandardQmStatusPointsFeesLimit { get; set; }

        [DataMember(Name = "standardQmStatusDti")]
        public string StandardQmStatusDti { get; set; }

        [DataMember(Name = "standardQmStatusResidualIncome")]
        public string StandardQmStatusResidualIncome { get; set; }

        [DataMember(Name = "standardQmStatusCoveredLoan")]
        public string StandardQmStatusCoveredLoan { get; set; }

        [DataMember(Name = "standardQmStatusSimultaneousLoan")]
        public string StandardQmStatusSimultaneousLoan { get; set; }

        [DataMember(Name = "standardQmStatusMtgRelatedObligations")]
        public string StandardQmStatusMtgRelatedObligations { get; set; }

        [DataMember(Name = "standardQmStatusEmployment")]
        public string StandardQmStatusEmployment { get; set; }

        [DataMember(Name = "standardQmStatusIncome")]
        public string StandardQmStatusIncome { get; set; }

        [DataMember(Name = "standardQmStatusAssets")]
        public string StandardQmStatusAssets { get; set; }

        [DataMember(Name = "standardQmStatusDebtObligations")]
        public string StandardQmStatusDebtObligations { get; set; }

        [DataMember(Name = "standardQmStatusAlimony")]
        public string StandardQmStatusAlimony { get; set; }

        [DataMember(Name = "standardQmStatusChildSupport")]
        public string StandardQmStatusChildSupport { get; set; }

        [DataMember(Name = "standardQmStatusCreditHistory")]
        public string StandardQmStatusCreditHistory { get; set; }

        [DataMember(Name = "standardQmStatusSafeHarborEligibility")]
        public string StandardQmStatusSafeHarborEligibility { get; set; }

        [DataMember(Name = "standardQmCalculatedThreshold")]
        public decimal? StandardQmCalculatedThreshold { get; set; }

        [DataMember(Name = "gseagencyQmStatusOverall")]
        public string GseagencyQmStatusOverall { get; set; }

        [DataMember(Name = "gseagencyQmStatusLoanTerm")]
        public string GseagencyQmStatusLoanTerm { get; set; }

        [DataMember(Name = "gseagencyQmStatusInterestOnly")]
        public string GseagencyQmStatusInterestOnly { get; set; }

        [DataMember(Name = "gseagencyQmStatusNegativeAmortization")]
        public string GseagencyQmStatusNegativeAmortization { get; set; }

        [DataMember(Name = "gseagencyQmStatusBalloonPayment")]
        public string GseagencyQmStatusBalloonPayment { get; set; }

        [DataMember(Name = "gseagencyQmStatusPrepaymentPenalty")]
        public string GseagencyQmStatusPrepaymentPenalty { get; set; }

        [DataMember(Name = "gseagencyQmStatusPointsFeesLimit")]
        public string GseagencyQmStatusPointsFeesLimit { get; set; }

        [DataMember(Name = "gseagencyQmStatusDti")]
        public string GseagencyQmStatusDti { get; set; }

        [DataMember(Name = "gseagencyQmStatusResidualIncome")]
        public string GseagencyQmStatusResidualIncome { get; set; }

        [DataMember(Name = "gseagencyQmStatusCoveredLoan")]
        public string GseagencyQmStatusCoveredLoan { get; set; }

        [DataMember(Name = "gseagencyQmStatusSimultaneousLoan")]
        public string GseagencyQmStatusSimultaneousLoan { get; set; }

        [DataMember(Name = "gseagencyQmStatusMtgRelatedObligations")]
        public string GseagencyQmStatusMtgRelatedObligations { get; set; }

        [DataMember(Name = "gseagencyQmStatusEmployment")]
        public string GseagencyQmStatusEmployment { get; set; }

        [DataMember(Name = "gseagencyQmStatusIncome")]
        public string GseagencyQmStatusIncome { get; set; }

        [DataMember(Name = "gseagencyQmStatusAssets")]
        public string GseagencyQmStatusAssets { get; set; }

        [DataMember(Name = "gseagencyQmStatusDebtObligations")]
        public string GseagencyQmStatusDebtObligations { get; set; }

        [DataMember(Name = "gseagencyQmStatusAlimony")]
        public string GseagencyQmStatusAlimony { get; set; }

        [DataMember(Name = "gseagencyQmStatusChildSupport")]
        public string GseagencyQmStatusChildSupport { get; set; }

        [DataMember(Name = "gseagencyQmStatusCreditHistory")]
        public string GseagencyQmStatusCreditHistory { get; set; }

        [DataMember(Name = "gseagencyQmStatusSafeHarborEligibility")]
        public string GseagencyQmStatusSafeHarborEligibility { get; set; }

        [DataMember(Name = "gseagencyQmCalculatedThreshold")]
        public decimal? GseagencyQmCalculatedThreshold { get; set; }

        [DataMember(Name = "smallCreditorQmStatusOverall")]
        public string SmallCreditorQmStatusOverall { get; set; }

        [DataMember(Name = "smallCreditorQmStatusLoanTerm")]
        public string SmallCreditorQmStatusLoanTerm { get; set; }

        [DataMember(Name = "smallCreditorQmStatusInterestOnly")]
        public string SmallCreditorQmStatusInterestOnly { get; set; }

        [DataMember(Name = "smallCreditorQmStatusNegativeAmortization")]
        public string SmallCreditorQmStatusNegativeAmortization { get; set; }

        [DataMember(Name = "smallCreditorQmStatusBalloonPayment")]
        public string SmallCreditorQmStatusBalloonPayment { get; set; }

        [DataMember(Name = "smallCreditorQmStatusPrepaymentPenalty")]
        public string SmallCreditorQmStatusPrepaymentPenalty { get; set; }

        [DataMember(Name = "smallCreditorQmStatusPointsFeesLimit")]
        public string SmallCreditorQmStatusPointsFeesLimit { get; set; }

        [DataMember(Name = "smallCreditorQmStatusDti")]
        public string SmallCreditorQmStatusDti { get; set; }

        [DataMember(Name = "smallCreditorQmStatusResidualIncome")]
        public string SmallCreditorQmStatusResidualIncome { get; set; }

        [DataMember(Name = "smallCreditorQmStatusCoveredLoan")]
        public string SmallCreditorQmStatusCoveredLoan { get; set; }

        [DataMember(Name = "smallCreditorQmStatusMtgRelatedObligations")]
        public string SmallCreditorQmStatusMtgRelatedObligations { get; set; }

        [DataMember(Name = "smallCreditorQmStatusIncome")]
        public string SmallCreditorQmStatusIncome { get; set; }

        [DataMember(Name = "smallCreditorQmStatusAssets")]
        public string SmallCreditorQmStatusAssets { get; set; }

        [DataMember(Name = "smallCreditorQmStatusDebtObligations")]
        public string SmallCreditorQmStatusDebtObligations { get; set; }

        [DataMember(Name = "smallCreditorQmStatusAlimony")]
        public string SmallCreditorQmStatusAlimony { get; set; }

        [DataMember(Name = "smallCreditorQmStatusChildSupport")]
        public string SmallCreditorQmStatusChildSupport { get; set; }

        [DataMember(Name = "smallCreditorQmStatusSafeHarborEligibility")]
        public string SmallCreditorQmStatusSafeHarborEligibility { get; set; }

        [DataMember(Name = "smallCreditorQmCalculatedThreshold")]
        public decimal? SmallCreditorQmCalculatedThreshold { get; set; }

        [DataMember(Name = "transactionExemptFromRegZ")]
        public bool? TransactionExemptFromRegZ { get; set; }

        [DataMember(Name = "creditorType")]
        public bool? CreditorType { get; set; }

        [DataMember(Name = "creditorTypeDescription")]
        public string CreditorTypeDescription { get; set; }

        [DataMember(Name = "loanProgram")]
        public bool? LoanProgram { get; set; }

        [DataMember(Name = "loanProgramDescription")]
        public string LoanProgramDescription { get; set; }

        [DataMember(Name = "unitCount")]
        public bool? UnitCount { get; set; }

        [DataMember(Name = "creditType")]
        public bool? CreditType { get; set; }

        [DataMember(Name = "discountPointAmount")]
        public decimal? DiscountPointAmount { get; set; }

        [DataMember(Name = "prepayPenaltyPercentage")]
        public decimal? PrepayPenaltyPercentage { get; set; }

        [DataMember(Name = "initialMaxTotalPayment")]
        public decimal? InitialMaxTotalPayment { get; set; }

        [DataMember(Name = "fullyIndexRateMaxTotalPayment")]
        public decimal? FullyIndexRateMaxTotalPayment { get; set; }

        [DataMember(Name = "fullyIndexRateHousingRatio")]
        public decimal? FullyIndexRateHousingRatio { get; set; }

        [DataMember(Name = "fullyIndexRateTotalDebtRatio")]
        public decimal? FullyIndexRateTotalDebtRatio { get; set; }

        [DataMember(Name = "max5YrsTotalPayment")]
        public decimal? Max5YrsTotalPayment { get; set; }

        [DataMember(Name = "max5YrsHousingRatio")]
        public decimal? Max5YrsHousingRatio { get; set; }

        [DataMember(Name = "max5YrsTotalDebtRatio")]
        public decimal? Max5YrsTotalDebtRatio { get; set; }

        [DataMember(Name = "regZTotalLoanAmount")]
        public decimal? RegZTotalLoanAmount { get; set; }

        [DataMember(Name = "currentQmFeeThresholdAmt")]
        public decimal? CurrentQmFeeThresholdAmt { get; set; }

        [DataMember(Name = "currentQmFeeThresholdPercent")]
        public decimal? CurrentQmFeeThresholdPercent { get; set; }

        [DataMember(Name = "totalPointsFeesSec32Percent")]
        public decimal? TotalPointsFeesSec32Percent { get; set; }

        [DataMember(Name = "thresholdExceedsQm")]
        public string ThresholdExceedsQm { get; set; }

        [DataMember(Name = "requiredServicesLenderSelectedAmt")]
        public decimal? RequiredServicesLenderSelectedAmt { get; set; }

        [DataMember(Name = "financeChargeFees")]
        public decimal? FinanceChargeFees { get; set; }

        [DataMember(Name = "realEstateFees")]
        public decimal? RealEstateFees { get; set; }

        [DataMember(Name = "discountPointFees")]
        public decimal? DiscountPointFees { get; set; }

        [DataMember(Name = "upfrontPmiFees")]
        public decimal? UpfrontPmiFees { get; set; }

        [DataMember(Name = "maxPrepaymentPenaltyFees")]
        public decimal? MaxPrepaymentPenaltyFees { get; set; }

        [DataMember(Name = "prepaymentPenaltyPayoffFees")]
        public decimal? PrepaymentPenaltyPayoffFees { get; set; }

        [DataMember(Name = "creditInsPremiumFees")]
        public decimal? CreditInsPremiumFees { get; set; }

        [DataMember(Name = "compensationPtbFees")]
        public decimal? CompensationPtbFees { get; set; }

        [DataMember(Name = "affiliatesFees")]
        public decimal? AffiliatesFees { get; set; }

        [DataMember(Name = "isHigherPricedLoan")]
        public string IsHigherPricedLoan { get; set; }

        [DataMember(Name = "discountPointPercentage")]
        public decimal? DiscountPointPercentage { get; set; }

        [DataMember(Name = "totalCoMortgagorIncome")]
        public decimal? TotalCoMortgagorIncome { get; set; }

        [DataMember(Name = "totalIncome")]
        public decimal? TotalIncome { get; set; }

        [DataMember(Name = "max5YrsPrincipleAndInterest")]
        public decimal? Max5YrsPrincipleAndInterest { get; set; }

        [DataMember(Name = "isEvaluatedMonthlyCoveredLoanPayment")]
        public bool? IsEvaluatedMonthlyCoveredLoanPayment { get; set; }

        [DataMember(Name = "isEvaluatedMonthlySimultaneousLoanPayment")]
        public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get; set; }

        [DataMember(Name = "isEvaluatedMonthlyMortgageRelatedObligations")]
        public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get; set; }

        [DataMember(Name = "isEvaluatedDebtObligations")]
        public bool? IsEvaluatedDebtObligations { get; set; }

        [DataMember(Name = "isEvaluatedChildSupportObligations")]
        public bool? IsEvaluatedChildSupportObligations { get; set; }

        [DataMember(Name = "isEvaluatedAlimonyObligations")]
        public bool? IsEvaluatedAlimonyObligations { get; set; }

        [DataMember(Name = "isEvaluatedCurrentEmploymentStatus")]
        public bool? IsEvaluatedCurrentEmploymentStatus { get; set; }

        [DataMember(Name = "isEvaluatedCurrentExpectedIncome")]
        public bool? IsEvaluatedCurrentExpectedIncome { get; set; }

        [DataMember(Name = "isEvaluatedCurrentExpectedAssets")]
        public bool? IsEvaluatedCurrentExpectedAssets { get; set; }

        [DataMember(Name = "isEvaluatedCreditHistory")]
        public bool? IsEvaluatedCreditHistory { get; set; }

        [DataMember(Name = "isEvaluatedDebtToIncomeRatio")]
        public bool? IsEvaluatedDebtToIncomeRatio { get; set; }

        [DataMember(Name = "isEvaluatedResidualIncome")]
        public bool? IsEvaluatedResidualIncome { get; set; }

        [DataMember(Name = "statusSimultaneousLoan")]
        public string StatusSimultaneousLoan { get; set; }

        [DataMember(Name = "statusCreditHistory")]
        public string StatusCreditHistory { get; set; }

        [DataMember(Name = "aporMaxBonaFideDiscountPoint")]
        public decimal? AporMaxBonaFideDiscountPoint { get; set; }

        [DataMember(Name = "rateReductionBasisPoints")]
        public decimal? RateReductionBasisPoints { get; set; }

        [DataMember(Name = "rateReductionDiscountPoints")]
        public decimal? RateReductionDiscountPoints { get; set; }

        [DataMember(Name = "rateReductionMaxBonaFideDiscountPoint")]
        public decimal? RateReductionMaxBonaFideDiscountPoint { get; set; }

        [DataMember(Name = "startingAdjustedRateMaxBonaFideDiscountPoint")]
        public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get; set; }

        [DataMember(Name = "bonaFideDiscountPoint")]
        public decimal? BonaFideDiscountPoint { get; set; }

        [DataMember(Name = "bonaFideDiscountPointAmount")]
        public decimal? BonaFideDiscountPointAmount { get; set; }

        [DataMember(Name = "loBrokerCompensationAmount")]
        public decimal? LoBrokerCompensationAmount { get; set; }

        [DataMember(Name = "brokerCompensationWhenRateSet")]
        public bool? BrokerCompensationWhenRateSet { get; set; }

        [DataMember(Name = "fullyIndexRateMonthlyPayment")]
        public decimal? FullyIndexRateMonthlyPayment { get; set; }

        [DataMember(Name = "initialRateMonthlyPayment")]
        public decimal? InitialRateMonthlyPayment { get; set; }

        [DataMember(Name = "initialRateHousingRatio")]
        public decimal? InitialRateHousingRatio { get; set; }

        [DataMember(Name = "initialRateTotalDebtRatio")]
        public decimal? InitialRateTotalDebtRatio { get; set; }

        [DataMember(Name = "ausDataDiscrepancyResolutionDate")]
        public string AusDataDiscrepancyResolutionDate { get; set; }

        [DataMember(Name = "ausDataDiscrepancyResolutionComments")]
        public string AusDataDiscrepancyResolutionComments { get; set; }

        [DataMember(Name = "ausDataDiscrepancyResolvedBy")]
        public string AusDataDiscrepancyResolvedBy { get; set; }

        [DataMember(Name = "titleServicesLenderTitleinsuranceFee")]
        public decimal? TitleServicesLenderTitleinsuranceFee { get; set; }

        [DataMember(Name = "loanProcessingInformationHa")]
        public string LoanProcessingInformationHa { get; set; }

        [DataMember(Name = "loanProcessingInformationGo")]
        public string LoanProcessingInformationGo { get; set; }

        [DataMember(Name = "loanProcessingInformationD4")]
        public string LoanProcessingInformationD4 { get; set; }

        [DataMember(Name = "documentationGuidelineMessages8Y")]
        public string DocumentationGuidelineMessages8Y { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesCn")]
        public string DocumentationGuidelineMessagesCn { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesCp")]
        public string DocumentationGuidelineMessagesCp { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesCv")]
        public string DocumentationGuidelineMessagesCv { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesCz")]
        public string DocumentationGuidelineMessagesCz { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesX1")]
        public string DocumentationGuidelineMessagesX1 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesX3")]
        public string DocumentationGuidelineMessagesX3 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesX5")]
        public string DocumentationGuidelineMessagesX5 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesX7")]
        public string DocumentationGuidelineMessagesX7 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesXa")]
        public string DocumentationGuidelineMessagesXa { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesXm")]
        public string DocumentationGuidelineMessagesXm { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesXp")]
        public string DocumentationGuidelineMessagesXp { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesXr")]
        public string DocumentationGuidelineMessagesXr { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesXt")]
        public string DocumentationGuidelineMessagesXt { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesY8")]
        public string DocumentationGuidelineMessagesY8 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesYg")]
        public string DocumentationGuidelineMessagesYg { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesYj")]
        public string DocumentationGuidelineMessagesYj { get; set; }

        [DataMember(Name = "loanProcessingInformationMa")]
        public string LoanProcessingInformationMa { get; set; }

        [DataMember(Name = "loanProcessingInformationLe")]
        public string LoanProcessingInformationLe { get; set; }

        [DataMember(Name = "loanProcessingInformationLf")]
        public string LoanProcessingInformationLf { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesDz")]
        public string DocumentationGuidelineMessagesDz { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesQj")]
        public string DocumentationGuidelineMessagesQj { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesJf")]
        public string DocumentationGuidelineMessagesJf { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesQn")]
        public string DocumentationGuidelineMessagesQn { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesU7")]
        public string DocumentationGuidelineMessagesU7 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesQq")]
        public string DocumentationGuidelineMessagesQq { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesE5")]
        public string DocumentationGuidelineMessagesE5 { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesQs")]
        public string DocumentationGuidelineMessagesQs { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesIm")]
        public string DocumentationGuidelineMessagesIm { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesIq")]
        public string DocumentationGuidelineMessagesIq { get; set; }

        [DataMember(Name = "documentationGuidelineMessages4V")]
        public string DocumentationGuidelineMessages4V { get; set; }

        [DataMember(Name = "documentationGuidelineMessages5C")]
        public string DocumentationGuidelineMessages5C { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesCy")]
        public string DocumentationGuidelineMessagesCy { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesDp")]
        public string DocumentationGuidelineMessagesDp { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesYy")]
        public string DocumentationGuidelineMessagesYy { get; set; }

        [DataMember(Name = "documentationGuidelineMessagesYz")]
        public string DocumentationGuidelineMessagesYz { get; set; }

        [DataMember(Name = "collateralRepandWarrReliefEligibilityType")]
        public string CollateralRepandWarrReliefEligibilityType { get; set; }

        [DataMember(Name = "assetRepresentationAndWarrantyReliefEligibilityType")]
        public string AssetRepresentationAndWarrantyReliefEligibilityType { get; set; }

        [DataMember(Name = "loanProcessingInformationCode24")]
        public string LoanProcessingInformationCode24 { get; set; }

        [DataMember(Name = "loanProcessingInformationCode31")]
        public string LoanProcessingInformationCode31 { get; set; }

        [DataMember(Name = "loanProcessingInformationCode32")]
        public string LoanProcessingInformationCode32 { get; set; }

        [DataMember(Name = "loanProcessingInformationCode33")]
        public string LoanProcessingInformationCode33 { get; set; }

        [DataMember(Name = "loanProcessingInformationCode97")]
        public string LoanProcessingInformationCode97 { get; set; }

        [DataMember(Name = "loanProcessingInformationCodeJr")]
        public string LoanProcessingInformationCodeJr { get; set; }

        [DataMember(Name = "loanProcessingInformationCodeJt")]
        public string LoanProcessingInformationCodeJt { get; set; }

        [DataMember(Name = "ucdRequirement")]
        public string UcdRequirement { get; set; }

        [DataMember(Name = "buydownSellerPaidSec32PointsFees")]
        public decimal? BuydownSellerPaidSec32PointsFees { get; set; }

        [DataMember(Name = "isCurrentHolderOrServicer")]
        public bool? IsCurrentHolderOrServicer { get; set; }

        [DataMember(Name = "gseagencyQmStatusQmAvailable")]
        public string GseagencyQmStatusQmAvailable { get; set; }

        [DataMember(Name = "qmAprPercentage")]
        public decimal? QmAprPercentage { get; set; }

        [DataMember(Name = "isQmHigherPricedLoan")]
        public string IsQmHigherPricedLoan { get; set; }

        [DataMember(Name = "usePriceBasedLimitTest")]
        public bool? UsePriceBasedLimitTest { get; set; }

        [DataMember(Name = "standardQmStatusPriceLimit")]
        public string StandardQmStatusPriceLimit { get; set; }

        [DataMember(Name = "primaryAusId")]
        public string PrimaryAusId { get; set; }
    }
}
