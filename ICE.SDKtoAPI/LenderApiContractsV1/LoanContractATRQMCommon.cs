using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractATRQMCommon
	{
		[DataMember(Name="affiliatesFees")]
		public decimal? AffiliatesFees { get; set; }

		[DataMember(Name="aPORMaxBonaFideDiscountPoint")]
		public decimal? APORMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="aRMRecastDate")]
		public DateTime? ARMRecastDate { get; set; }

		[DataMember(Name="aRMRecastMonthlyPayment")]
		public decimal? ARMRecastMonthlyPayment { get; set; }

		[DataMember(Name="assetRepresentationAndWarrantyReliefEligibilityType")]
		public string AssetRepresentationAndWarrantyReliefEligibilityType { get; set; }

		[DataMember(Name="aTRLoanType")]
		public string ATRLoanType { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolutionComments")]
		public string AUSDataDiscrepencyResolutionComments { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolutionDate")]
		public DateTime? AUSDataDiscrepencyResolutionDate { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolvedBy")]
		public string AUSDataDiscrepencyResolvedBy { get; set; }

		[DataMember(Name="bonaFideDiscountPoint")]
		public decimal? BonaFideDiscountPoint { get; set; }

		[DataMember(Name="bonaFideDiscountPointAmount")]
		public decimal? BonaFideDiscountPointAmount { get; set; }

		[DataMember(Name="brokerCompensationWhenRateSet")]
		public bool? BrokerCompensationWhenRateSet { get; set; }

		[DataMember(Name="collateralRepandWarrReliefEligibilityType")]
		public string CollateralRepandWarrReliefEligibilityType { get; set; }

		[DataMember(Name="compensationPTBFees")]
		public decimal? CompensationPTBFees { get; set; }

		[DataMember(Name="creditInsPremiumFees")]
		public decimal? CreditInsPremiumFees { get; set; }

		[DataMember(Name="creditorType")]
		public bool? CreditorType { get; set; }

		[DataMember(Name="creditorTypeDescription")]
		public string CreditorTypeDescription { get; set; }

		[DataMember(Name="creditType")]
		public bool? CreditType { get; set; }

		[DataMember(Name="currentQMFeeThresholdAmt")]
		public decimal? CurrentQMFeeThresholdAmt { get; set; }

		[DataMember(Name="currentQMFeeThresholdPercent")]
		public decimal? CurrentQMFeeThresholdPercent { get; set; }

		[DataMember(Name="dateOfLastMonthlyPayment")]
		public DateTime? DateOfLastMonthlyPayment { get; set; }

		[DataMember(Name="discountPointAmount")]
		public decimal? DiscountPointAmount { get; set; }

		[DataMember(Name="discountPointFees")]
		public decimal? DiscountPointFees { get; set; }

		[DataMember(Name="discountPointPercentage")]
		public decimal? DiscountPointPercentage { get; set; }

		[DataMember(Name="documentationGuidelineMessages4V")]
		public string DocumentationGuidelineMessages4V { get; set; }

		[DataMember(Name="documentationGuidelineMessages5C")]
		public string DocumentationGuidelineMessages5C { get; set; }

		[DataMember(Name="documentationGuidelineMessages8Y")]
		public string DocumentationGuidelineMessages8Y { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCN")]
		public string DocumentationGuidelineMessagesCN { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCP")]
		public string DocumentationGuidelineMessagesCP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCV")]
		public string DocumentationGuidelineMessagesCV { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCY")]
		public string DocumentationGuidelineMessagesCY { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCZ")]
		public string DocumentationGuidelineMessagesCZ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesDP")]
		public string DocumentationGuidelineMessagesDP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesDZ")]
		public string DocumentationGuidelineMessagesDZ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesE5")]
		public string DocumentationGuidelineMessagesE5 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesIM")]
		public string DocumentationGuidelineMessagesIM { get; set; }

		[DataMember(Name="documentationGuidelineMessagesIQ")]
		public string DocumentationGuidelineMessagesIQ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesJF")]
		public string DocumentationGuidelineMessagesJF { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQJ")]
		public string DocumentationGuidelineMessagesQJ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQN")]
		public string DocumentationGuidelineMessagesQN { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQQ")]
		public string DocumentationGuidelineMessagesQQ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQS")]
		public string DocumentationGuidelineMessagesQS { get; set; }

		[DataMember(Name="documentationGuidelineMessagesU7")]
		public string DocumentationGuidelineMessagesU7 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX1")]
		public string DocumentationGuidelineMessagesX1 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX3")]
		public string DocumentationGuidelineMessagesX3 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX5")]
		public string DocumentationGuidelineMessagesX5 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX7")]
		public string DocumentationGuidelineMessagesX7 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXA")]
		public string DocumentationGuidelineMessagesXA { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXM")]
		public string DocumentationGuidelineMessagesXM { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXP")]
		public string DocumentationGuidelineMessagesXP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXR")]
		public string DocumentationGuidelineMessagesXR { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXT")]
		public string DocumentationGuidelineMessagesXT { get; set; }

		[DataMember(Name="documentationGuidelineMessagesY8")]
		public string DocumentationGuidelineMessagesY8 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYG")]
		public string DocumentationGuidelineMessagesYG { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYJ")]
		public string DocumentationGuidelineMessagesYJ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYY")]
		public string DocumentationGuidelineMessagesYY { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYZ")]
		public string DocumentationGuidelineMessagesYZ { get; set; }

		[DataMember(Name="eligibleNonStandardToStandard")]
		public string EligibleNonStandardToStandard { get; set; }

		[DataMember(Name="financeChargeFees")]
		public decimal? FinanceChargeFees { get; set; }

		[DataMember(Name="firstChangeRecase")]
		public int? FirstChangeRecase { get; set; }

		[DataMember(Name="firstPmtDateAfterRecast")]
		public DateTime? FirstPmtDateAfterRecast { get; set; }

		[DataMember(Name="fullPaymentAfterInterestOnly")]
		public decimal? FullPaymentAfterInterestOnly { get; set; }

		[DataMember(Name="fullyARMPaymentAfterNegAm")]
		public decimal? FullyARMPaymentAfterNegAm { get; set; }

		[DataMember(Name="fullyIndexRateHousingRatio")]
		public decimal? FullyIndexRateHousingRatio { get; set; }

		[DataMember(Name="fullyIndexRateMaxTotalPayment")]
		public decimal? FullyIndexRateMaxTotalPayment { get; set; }

		[DataMember(Name="fullyIndexRateMonthlyPayment")]
		public decimal? FullyIndexRateMonthlyPayment { get; set; }

		[DataMember(Name="fullyIndexRateTotalDebtRatio")]
		public decimal? FullyIndexRateTotalDebtRatio { get; set; }

		[DataMember(Name="generalATRStatusAlimony")]
		public string GeneralATRStatusAlimony { get; set; }

		[DataMember(Name="generalATRStatusAssets")]
		public string GeneralATRStatusAssets { get; set; }

		[DataMember(Name="generalATRStatusChildSupport")]
		public string GeneralATRStatusChildSupport { get; set; }

		[DataMember(Name="generalATRStatusCoveredLoan")]
		public string GeneralATRStatusCoveredLoan { get; set; }

		[DataMember(Name="generalATRStatusCreditHistory")]
		public string GeneralATRStatusCreditHistory { get; set; }

		[DataMember(Name="generalATRStatusDebtObligations")]
		public string GeneralATRStatusDebtObligations { get; set; }

		[DataMember(Name="generalATRStatusDTI")]
		public string GeneralATRStatusDTI { get; set; }

		[DataMember(Name="generalATRStatusEmployment")]
		public string GeneralATRStatusEmployment { get; set; }

		[DataMember(Name="generalATRStatusIncome")]
		public string GeneralATRStatusIncome { get; set; }

		[DataMember(Name="generalATRStatusMtgRelatedObligations")]
		public string GeneralATRStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="generalATRStatusOverall")]
		public string GeneralATRStatusOverall { get; set; }

		[DataMember(Name="generalATRStatusResidualIncome")]
		public string GeneralATRStatusResidualIncome { get; set; }

		[DataMember(Name="generalATRStatusSimultaneousLoan")]
		public string GeneralATRStatusSimultaneousLoan { get; set; }

		[DataMember(Name="gSEAgencyQMCalculatedThreshold")]
		public decimal? GSEAgencyQMCalculatedThreshold { get; set; }

		[DataMember(Name="gSEAgencyQMStatusAlimony")]
		public string GSEAgencyQMStatusAlimony { get; set; }

		[DataMember(Name="gSEAgencyQMStatusAssets")]
		public string GSEAgencyQMStatusAssets { get; set; }

		[DataMember(Name="gSEAgencyQMStatusBalloonPayment")]
		public string GSEAgencyQMStatusBalloonPayment { get; set; }

		[DataMember(Name="gSEAgencyQMStatusChildSupport")]
		public string GSEAgencyQMStatusChildSupport { get; set; }

		[DataMember(Name="gSEAgencyQMStatusCoveredLoan")]
		public string GSEAgencyQMStatusCoveredLoan { get; set; }

		[DataMember(Name="gSEAgencyQMStatusCreditHistory")]
		public string GSEAgencyQMStatusCreditHistory { get; set; }

		[DataMember(Name="gSEAgencyQMStatusDebtObligations")]
		public string GSEAgencyQMStatusDebtObligations { get; set; }

		[DataMember(Name="gSEAgencyQMStatusDTI")]
		public string GSEAgencyQMStatusDTI { get; set; }

		[DataMember(Name="gSEAgencyQMStatusEmployment")]
		public string GSEAgencyQMStatusEmployment { get; set; }

		[DataMember(Name="gSEAgencyQMStatusIncome")]
		public string GSEAgencyQMStatusIncome { get; set; }

		[DataMember(Name="gSEAgencyQMStatusInterestOnly")]
		public string GSEAgencyQMStatusInterestOnly { get; set; }

		[DataMember(Name="gSEAgencyQMStatusLoanTerm")]
		public string GSEAgencyQMStatusLoanTerm { get; set; }

		[DataMember(Name="gSEAgencyQMStatusMtgRelatedObligations")]
		public string GSEAgencyQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="gSEAgencyQMStatusNegativeAmortization")]
		public string GSEAgencyQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="gSEAgencyQMStatusOverall")]
		public string GSEAgencyQMStatusOverall { get; set; }

		[DataMember(Name="gSEAgencyQMStatusPointsFeesLimit")]
		public string GSEAgencyQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="gSEAgencyQMStatusPrepaymentPenalty")]
		public string GSEAgencyQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="gSEAgencyQMStatusResidualIncome")]
		public string GSEAgencyQMStatusResidualIncome { get; set; }

		[DataMember(Name="gSEAgencyQMStatusSafeHarborEligibility")]
		public string GSEAgencyQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="gSEAgencyQMStatusSimultaneousLoan")]
		public string GSEAgencyQMStatusSimultaneousLoan { get; set; }

		[DataMember(Name="has30DayLatePayment")]
		public bool? Has30DayLatePayment { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="initialMaxTotalPayment")]
		public decimal? InitialMaxTotalPayment { get; set; }

		[DataMember(Name="initialRateHousingRatio")]
		public decimal? InitialRateHousingRatio { get; set; }

		[DataMember(Name="initialRateMonthlyPayment")]
		public decimal? InitialRateMonthlyPayment { get; set; }

		[DataMember(Name="initialRateTotalDebtRatio")]
		public decimal? InitialRateTotalDebtRatio { get; set; }

		[DataMember(Name="interestOnlyMonths")]
		public int? InterestOnlyMonths { get; set; }

		[DataMember(Name="interestOnlyRecastDate")]
		public DateTime? InterestOnlyRecastDate { get; set; }

		[DataMember(Name="isConsumerLiklyDefault")]
		public bool? IsConsumerLiklyDefault { get; set; }

		[DataMember(Name="isEligibleForSafeHarbor")]
		public string IsEligibleForSafeHarbor { get; set; }

		[DataMember(Name="isEvaluatedAlimonyObligations")]
		public bool? IsEvaluatedAlimonyObligations { get; set; }

		[DataMember(Name="isEvaluatedChildSupportObligations")]
		public bool? IsEvaluatedChildSupportObligations { get; set; }

		[DataMember(Name="isEvaluatedCreditHistory")]
		public bool? IsEvaluatedCreditHistory { get; set; }

		[DataMember(Name="isEvaluatedCurrentEmploymentStatus")]
		public bool? IsEvaluatedCurrentEmploymentStatus { get; set; }

		[DataMember(Name="isEvaluatedCurrentExpectedAssets")]
		public bool? IsEvaluatedCurrentExpectedAssets { get; set; }

		[DataMember(Name="isEvaluatedCurrentExpectedIncome")]
		public bool? IsEvaluatedCurrentExpectedIncome { get; set; }

		[DataMember(Name="isEvaluatedDebtObligations")]
		public bool? IsEvaluatedDebtObligations { get; set; }

		[DataMember(Name="isEvaluatedDebtToIncomeRatio")]
		public bool? IsEvaluatedDebtToIncomeRatio { get; set; }

		[DataMember(Name="isEvaluatedMonthlyCoveredLoanPayment")]
		public bool? IsEvaluatedMonthlyCoveredLoanPayment { get; set; }

		[DataMember(Name="isEvaluatedMonthlyMortgageRelatedObligations")]
		public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get; set; }

		[DataMember(Name="isEvaluatedMonthlySimultaneousLoanPayment")]
		public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get; set; }

		[DataMember(Name="isEvaluatedResidualIncome")]
		public bool? IsEvaluatedResidualIncome { get; set; }

		[DataMember(Name="isHigherPricedLoan")]
		public string IsHigherPricedLoan { get; set; }

		[DataMember(Name="loanProcessingInformationCode24")]
		public string LoanProcessingInformationCode24 { get; set; }

		[DataMember(Name="loanProcessingInformationCode31")]
		public string LoanProcessingInformationCode31 { get; set; }

		[DataMember(Name="loanProcessingInformationCode32")]
		public string LoanProcessingInformationCode32 { get; set; }

		[DataMember(Name="loanProcessingInformationCode33")]
		public string LoanProcessingInformationCode33 { get; set; }

		[DataMember(Name="loanProcessingInformationCode97")]
		public string LoanProcessingInformationCode97 { get; set; }

		[DataMember(Name="loanProcessingInformationCodeJr")]
		public string LoanProcessingInformationCodeJr { get; set; }

		[DataMember(Name="loanProcessingInformationCodeJt")]
		public string LoanProcessingInformationCodeJt { get; set; }

		[DataMember(Name="loanProcessingInformationD4")]
		public string LoanProcessingInformationD4 { get; set; }

		[DataMember(Name="loanProcessingInformationGO")]
		public string LoanProcessingInformationGO { get; set; }

		[DataMember(Name="loanProcessingInformationHA")]
		public string LoanProcessingInformationHA { get; set; }

		[DataMember(Name="loanProcessingInformationLE")]
		public string LoanProcessingInformationLE { get; set; }

		[DataMember(Name="loanProcessingInformationLF")]
		public string LoanProcessingInformationLF { get; set; }

		[DataMember(Name="loanProcessingInformationMA")]
		public string LoanProcessingInformationMA { get; set; }

		[DataMember(Name="loanProgram")]
		public bool? LoanProgram { get; set; }

		[DataMember(Name="loanProgramDescription")]
		public string LoanProgramDescription { get; set; }

		[DataMember(Name="loanRateFixedin5Years")]
		public bool? LoanRateFixedin5Years { get; set; }

		[DataMember(Name="lOBrokerCompensationAmount")]
		public decimal? LOBrokerCompensationAmount { get; set; }

		[DataMember(Name="max5YrsHousingRatio")]
		public decimal? Max5YrsHousingRatio { get; set; }

		[DataMember(Name="max5YrsPrincipleAndInterest")]
		public decimal? Max5YrsPrincipleAndInterest { get; set; }

		[DataMember(Name="max5YrsTotalDebtRatio")]
		public decimal? Max5YrsTotalDebtRatio { get; set; }

		[DataMember(Name="max5YrsTotalPayment")]
		public decimal? Max5YrsTotalPayment { get; set; }

		[DataMember(Name="maxPrepaymentPenaltyFees")]
		public decimal? MaxPrepaymentPenaltyFees { get; set; }

		[DataMember(Name="negAmRecastDate")]
		public DateTime? NegAmRecastDate { get; set; }

		[DataMember(Name="paymentDecreasedBy10Percent")]
		public bool? PaymentDecreasedBy10Percent { get; set; }

		[DataMember(Name="pointsFeesThresholdMet")]
		public bool? PointsFeesThresholdMet { get; set; }

		[DataMember(Name="prepaymentPenaltyPayoffFees")]
		public decimal? PrepaymentPenaltyPayoffFees { get; set; }

		[DataMember(Name="prepayPenaltyPercentage")]
		public decimal? PrepayPenaltyPercentage { get; set; }

		[DataMember(Name="preventConsumersDefault")]
		public bool? PreventConsumersDefault { get; set; }

		[DataMember(Name="principalBalanceIncreased")]
		public bool? PrincipalBalanceIncreased { get; set; }

		[DataMember(Name="principalHasDeferred")]
		public bool? PrincipalHasDeferred { get; set; }

		[DataMember(Name="qMLoanType")]
		public string QMLoanType { get; set; }

		[DataMember(Name="rateReductionBasisPoints")]
		public decimal? RateReductionBasisPoints { get; set; }

		[DataMember(Name="rateReductionDiscountPoints")]
		public decimal? RateReductionDiscountPoints { get; set; }

		[DataMember(Name="rateReductionMaxBonaFideDiscountPoint")]
		public decimal? RateReductionMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="realEstateFees")]
		public decimal? RealEstateFees { get; set; }

		[DataMember(Name="recastDifferencePayment")]
		public decimal? RecastDifferencePayment { get; set; }

		[DataMember(Name="regZTotalLoanAmount")]
		public decimal? RegZTotalLoanAmount { get; set; }

		[DataMember(Name="requiredServicesLenderSelectedAmt")]
		public decimal? RequiredServicesLenderSelectedAmt { get; set; }

		[DataMember(Name="smallCreditorQMCalculatedThreshold")]
		public decimal? SmallCreditorQMCalculatedThreshold { get; set; }

		[DataMember(Name="smallCreditorQMStatusAlimony")]
		public string SmallCreditorQMStatusAlimony { get; set; }

		[DataMember(Name="smallCreditorQMStatusAssets")]
		public string SmallCreditorQMStatusAssets { get; set; }

		[DataMember(Name="smallCreditorQMStatusBalloonPayment")]
		public string SmallCreditorQMStatusBalloonPayment { get; set; }

		[DataMember(Name="smallCreditorQMStatusChildSupport")]
		public string SmallCreditorQMStatusChildSupport { get; set; }

		[DataMember(Name="smallCreditorQMStatusCoveredLoan")]
		public string SmallCreditorQMStatusCoveredLoan { get; set; }

		[DataMember(Name="smallCreditorQMStatusDebtObligations")]
		public string SmallCreditorQMStatusDebtObligations { get; set; }

		[DataMember(Name="smallCreditorQMStatusDTI")]
		public string SmallCreditorQMStatusDTI { get; set; }

		[DataMember(Name="smallCreditorQMStatusIncome")]
		public string SmallCreditorQMStatusIncome { get; set; }

		[DataMember(Name="smallCreditorQMStatusInterestOnly")]
		public string SmallCreditorQMStatusInterestOnly { get; set; }

		[DataMember(Name="smallCreditorQMStatusLoanTerm")]
		public string SmallCreditorQMStatusLoanTerm { get; set; }

		[DataMember(Name="smallCreditorQMStatusMtgRelatedObligations")]
		public string SmallCreditorQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="smallCreditorQMStatusNegativeAmortization")]
		public string SmallCreditorQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="smallCreditorQMStatusOverall")]
		public string SmallCreditorQMStatusOverall { get; set; }

		[DataMember(Name="smallCreditorQMStatusPointsFeesLimit")]
		public string SmallCreditorQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="smallCreditorQMStatusPrepaymentPenalty")]
		public string SmallCreditorQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="smallCreditorQMStatusResidualIncome")]
		public string SmallCreditorQMStatusResidualIncome { get; set; }

		[DataMember(Name="smallCreditorQMStatusSafeHarborEligibility")]
		public string SmallCreditorQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="standardQMCalculatedThreshold")]
		public decimal? StandardQMCalculatedThreshold { get; set; }

		[DataMember(Name="standardQMStatusAlimony")]
		public string StandardQMStatusAlimony { get; set; }

		[DataMember(Name="standardQMStatusAssets")]
		public string StandardQMStatusAssets { get; set; }

		[DataMember(Name="standardQMStatusBalloonPayment")]
		public string StandardQMStatusBalloonPayment { get; set; }

		[DataMember(Name="standardQMStatusChildSupport")]
		public string StandardQMStatusChildSupport { get; set; }

		[DataMember(Name="standardQMStatusCoveredLoan")]
		public string StandardQMStatusCoveredLoan { get; set; }

		[DataMember(Name="standardQMStatusCreditHistory")]
		public string StandardQMStatusCreditHistory { get; set; }

		[DataMember(Name="standardQMStatusDebtObligations")]
		public string StandardQMStatusDebtObligations { get; set; }

		[DataMember(Name="standardQMStatusDTI")]
		public string StandardQMStatusDTI { get; set; }

		[DataMember(Name="standardQMStatusEmployment")]
		public string StandardQMStatusEmployment { get; set; }

		[DataMember(Name="standardQMStatusIncome")]
		public string StandardQMStatusIncome { get; set; }

		[DataMember(Name="standardQMStatusInterestOnly")]
		public string StandardQMStatusInterestOnly { get; set; }

		[DataMember(Name="standardQMStatusLoanTerm")]
		public string StandardQMStatusLoanTerm { get; set; }

		[DataMember(Name="standardQMStatusMtgRelatedObligations")]
		public string StandardQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="standardQMStatusNegativeAmortization")]
		public string StandardQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="standardQMStatusOverall")]
		public string StandardQMStatusOverall { get; set; }

		[DataMember(Name="standardQMStatusPointsFeesLimit")]
		public string StandardQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="standardQMStatusPrepaymentPenalty")]
		public string StandardQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="standardQMStatusResidualIncome")]
		public string StandardQMStatusResidualIncome { get; set; }

		[DataMember(Name="standardQMStatusSafeHarborEligibility")]
		public string StandardQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="standardQMStatusSimultaneousLoan")]
		public string StandardQMStatusSimultaneousLoan { get; set; }

		[DataMember(Name="startingAdjustedRateMaxBonaFideDiscountPoint")]
		public decimal? StartingAdjustedRateMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="statusCreditHistory")]
		public string StatusCreditHistory { get; set; }

		[DataMember(Name="statusSimultaneousLoan")]
		public string StatusSimultaneousLoan { get; set; }

		[DataMember(Name="thresholdExceedsQM")]
		public string ThresholdExceedsQM { get; set; }

		[DataMember(Name="titleServicesLenderTitleinsuranceFee")]
		public decimal? TitleServicesLenderTitleinsuranceFee { get; set; }

		[DataMember(Name="totalCoMortgagorIncome")]
		public decimal? TotalCoMortgagorIncome { get; set; }

		[DataMember(Name="totalIncome")]
		public decimal? TotalIncome { get; set; }

		[DataMember(Name="totalPointsFeesSec32Percent")]
		public decimal? TotalPointsFeesSec32Percent { get; set; }

		[DataMember(Name="transactionExemptFromRegZ")]
		public bool? TransactionExemptFromRegZ { get; set; }

		[DataMember(Name="ucdRequirement")]
		public string UcdRequirement { get; set; }

		[DataMember(Name="unitCount")]
		public bool? UnitCount { get; set; }

		[DataMember(Name="upfrontPMIFees")]
		public decimal? UpfrontPMIFees { get; set; }

		[DataMember(Name="withOriginalCreditor")]
		public bool? WithOriginalCreditor { get; set; }

		[DataMember(Name="writtenApplicationDate")]
		public DateTime? WrittenApplicationDate { get; set; }

		[DataMember(Name = "gseagencyQmStatusQmAvailable")]
		public string GSEAgencyQMStatusQMAvailable { get; set; }

		[DataMember(Name = "qmAprPercentage")]
		public decimal? QmAprPercentage { get; set; }

		[DataMember(Name = "isQmHigherPricedLoan")]
		public string IsQmHigherPricedLoan { get; set; }

		[DataMember(Name = "standardQmStatusPriceLimit")]
		public string StandardQmStatusPriceLimit { get; set; }

	}
}