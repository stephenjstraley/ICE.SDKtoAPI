using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractATRQMCommon
	{
		[DataMember(Name="affiliatesFees", EmitDefaultValue=false)]
		public double? AffiliatesFees { get; set; }

		[DataMember(Name="aPORMaxBonaFideDiscountPoint", EmitDefaultValue=false)]
		public double? APORMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="aRMRecastDate", EmitDefaultValue=false)]
		public DateTime? ARMRecastDate { get; set; }

		[DataMember(Name="aRMRecastMonthlyPayment", EmitDefaultValue=false)]
		public double? ARMRecastMonthlyPayment { get; set; }

		[DataMember(Name="assetRepresentationAndWarrantyReliefEligibilityType", EmitDefaultValue=false)]
		public string AssetRepresentationAndWarrantyReliefEligibilityType { get; set; }

		[DataMember(Name="aTRLoanType", EmitDefaultValue=false)]
		public string ATRLoanType { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolutionComments", EmitDefaultValue=false)]
		public string AUSDataDiscrepencyResolutionComments { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolutionDate", EmitDefaultValue=false)]
		public DateTime? AUSDataDiscrepencyResolutionDate { get; set; }

		[DataMember(Name="aUSDataDiscrepencyResolvedBy", EmitDefaultValue=false)]
		public string AUSDataDiscrepencyResolvedBy { get; set; }

		[DataMember(Name="bonaFideDiscountPoint", EmitDefaultValue=false)]
		public double? BonaFideDiscountPoint { get; set; }

		[DataMember(Name="bonaFideDiscountPointAmount", EmitDefaultValue=false)]
		public double? BonaFideDiscountPointAmount { get; set; }

		[DataMember(Name="brokerCompensationWhenRateSet", EmitDefaultValue=false)]
		public bool? BrokerCompensationWhenRateSet { get; set; }

		[DataMember(Name="collateralRepandWarrReliefEligibilityType", EmitDefaultValue=false)]
		public string CollateralRepandWarrReliefEligibilityType { get; set; }

		[DataMember(Name="compensationPTBFees", EmitDefaultValue=false)]
		public double? CompensationPTBFees { get; set; }

		[DataMember(Name="creditInsPremiumFees", EmitDefaultValue=false)]
		public double? CreditInsPremiumFees { get; set; }

		[DataMember(Name="creditorType", EmitDefaultValue=false)]
		public bool? CreditorType { get; set; }

		[DataMember(Name="creditorTypeDescription", EmitDefaultValue=false)]
		public string CreditorTypeDescription { get; set; }

		[DataMember(Name="creditType", EmitDefaultValue=false)]
		public bool? CreditType { get; set; }

		[DataMember(Name="currentQMFeeThresholdAmt", EmitDefaultValue=false)]
		public double? CurrentQMFeeThresholdAmt { get; set; }

		[DataMember(Name="currentQMFeeThresholdPercent", EmitDefaultValue=false)]
		public double? CurrentQMFeeThresholdPercent { get; set; }

		[DataMember(Name="dateOfLastMonthlyPayment", EmitDefaultValue=false)]
		public DateTime? DateOfLastMonthlyPayment { get; set; }

		[DataMember(Name="discountPointAmount", EmitDefaultValue=false)]
		public double? DiscountPointAmount { get; set; }

		[DataMember(Name="discountPointFees", EmitDefaultValue=false)]
		public double? DiscountPointFees { get; set; }

		[DataMember(Name="discountPointPercentage", EmitDefaultValue=false)]
		public double? DiscountPointPercentage { get; set; }

		[DataMember(Name="documentationGuidelineMessages4V", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessages4V { get; set; }

		[DataMember(Name="documentationGuidelineMessages5C", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessages5C { get; set; }

		[DataMember(Name="documentationGuidelineMessages8Y", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessages8Y { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCN", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesCN { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCP", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesCP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCV", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesCV { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCY", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesCY { get; set; }

		[DataMember(Name="documentationGuidelineMessagesCZ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesCZ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesDP", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesDP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesDZ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesDZ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesE5", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesE5 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesIM", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesIM { get; set; }

		[DataMember(Name="documentationGuidelineMessagesIQ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesIQ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesJF", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesJF { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQJ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesQJ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQN", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesQN { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQQ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesQQ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesQS", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesQS { get; set; }

		[DataMember(Name="documentationGuidelineMessagesU7", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesU7 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX1", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesX1 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX3", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesX3 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX5", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesX5 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesX7", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesX7 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXA", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesXA { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXM", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesXM { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXP", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesXP { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXR", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesXR { get; set; }

		[DataMember(Name="documentationGuidelineMessagesXT", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesXT { get; set; }

		[DataMember(Name="documentationGuidelineMessagesY8", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesY8 { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYG", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesYG { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYJ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesYJ { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYY", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesYY { get; set; }

		[DataMember(Name="documentationGuidelineMessagesYZ", EmitDefaultValue=false)]
		public string DocumentationGuidelineMessagesYZ { get; set; }

		[DataMember(Name="eligibleNonStandardToStandard", EmitDefaultValue=false)]
		public string EligibleNonStandardToStandard { get; set; }

		[DataMember(Name="financeChargeFees", EmitDefaultValue=false)]
		public double? FinanceChargeFees { get; set; }

		[DataMember(Name="firstChangeRecase", EmitDefaultValue=false)]
		public int? FirstChangeRecase { get; set; }

		[DataMember(Name="firstPmtDateAfterRecast", EmitDefaultValue=false)]
		public DateTime? FirstPmtDateAfterRecast { get; set; }

		[DataMember(Name="fullPaymentAfterInterestOnly", EmitDefaultValue=false)]
		public double? FullPaymentAfterInterestOnly { get; set; }

		[DataMember(Name="fullyARMPaymentAfterNegAm", EmitDefaultValue=false)]
		public double? FullyARMPaymentAfterNegAm { get; set; }

		[DataMember(Name="fullyIndexRateHousingRatio", EmitDefaultValue=false)]
		public double? FullyIndexRateHousingRatio { get; set; }

		[DataMember(Name="fullyIndexRateMaxTotalPayment", EmitDefaultValue=false)]
		public double? FullyIndexRateMaxTotalPayment { get; set; }

		[DataMember(Name="fullyIndexRateMonthlyPayment", EmitDefaultValue=false)]
		public double? FullyIndexRateMonthlyPayment { get; set; }

		[DataMember(Name="fullyIndexRateTotalDebtRatio", EmitDefaultValue=false)]
		public double? FullyIndexRateTotalDebtRatio { get; set; }

		[DataMember(Name="generalATRStatusAlimony", EmitDefaultValue=false)]
		public string GeneralATRStatusAlimony { get; set; }

		[DataMember(Name="generalATRStatusAssets", EmitDefaultValue=false)]
		public string GeneralATRStatusAssets { get; set; }

		[DataMember(Name="generalATRStatusChildSupport", EmitDefaultValue=false)]
		public string GeneralATRStatusChildSupport { get; set; }

		[DataMember(Name="generalATRStatusCoveredLoan", EmitDefaultValue=false)]
		public string GeneralATRStatusCoveredLoan { get; set; }

		[DataMember(Name="generalATRStatusCreditHistory", EmitDefaultValue=false)]
		public string GeneralATRStatusCreditHistory { get; set; }

		[DataMember(Name="generalATRStatusDebtObligations", EmitDefaultValue=false)]
		public string GeneralATRStatusDebtObligations { get; set; }

		[DataMember(Name="generalATRStatusDTI", EmitDefaultValue=false)]
		public string GeneralATRStatusDTI { get; set; }

		[DataMember(Name="generalATRStatusEmployment", EmitDefaultValue=false)]
		public string GeneralATRStatusEmployment { get; set; }

		[DataMember(Name="generalATRStatusIncome", EmitDefaultValue=false)]
		public string GeneralATRStatusIncome { get; set; }

		[DataMember(Name="generalATRStatusMtgRelatedObligations", EmitDefaultValue=false)]
		public string GeneralATRStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="generalATRStatusOverall", EmitDefaultValue=false)]
		public string GeneralATRStatusOverall { get; set; }

		[DataMember(Name="generalATRStatusResidualIncome", EmitDefaultValue=false)]
		public string GeneralATRStatusResidualIncome { get; set; }

		[DataMember(Name="generalATRStatusSimultaneousLoan", EmitDefaultValue=false)]
		public string GeneralATRStatusSimultaneousLoan { get; set; }

		[DataMember(Name="gSEAgencyQMCalculatedThreshold", EmitDefaultValue=false)]
		public double? GSEAgencyQMCalculatedThreshold { get; set; }

		[DataMember(Name="gSEAgencyQMStatusAlimony", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusAlimony { get; set; }

		[DataMember(Name="gSEAgencyQMStatusAssets", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusAssets { get; set; }

		[DataMember(Name="gSEAgencyQMStatusBalloonPayment", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusBalloonPayment { get; set; }

		[DataMember(Name="gSEAgencyQMStatusChildSupport", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusChildSupport { get; set; }

		[DataMember(Name="gSEAgencyQMStatusCoveredLoan", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusCoveredLoan { get; set; }

		[DataMember(Name="gSEAgencyQMStatusCreditHistory", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusCreditHistory { get; set; }

		[DataMember(Name="gSEAgencyQMStatusDebtObligations", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusDebtObligations { get; set; }

		[DataMember(Name="gSEAgencyQMStatusDTI", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusDTI { get; set; }

		[DataMember(Name="gSEAgencyQMStatusEmployment", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusEmployment { get; set; }

		[DataMember(Name="gSEAgencyQMStatusIncome", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusIncome { get; set; }

		[DataMember(Name="gSEAgencyQMStatusInterestOnly", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusInterestOnly { get; set; }

		[DataMember(Name="gSEAgencyQMStatusLoanTerm", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusLoanTerm { get; set; }

		[DataMember(Name="gSEAgencyQMStatusMtgRelatedObligations", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="gSEAgencyQMStatusNegativeAmortization", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="gSEAgencyQMStatusOverall", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusOverall { get; set; }

		[DataMember(Name="gSEAgencyQMStatusPointsFeesLimit", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="gSEAgencyQMStatusPrepaymentPenalty", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="gSEAgencyQMStatusResidualIncome", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusResidualIncome { get; set; }

		[DataMember(Name="gSEAgencyQMStatusSafeHarborEligibility", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="gSEAgencyQMStatusSimultaneousLoan", EmitDefaultValue=false)]
		public string GSEAgencyQMStatusSimultaneousLoan { get; set; }

		[DataMember(Name="has30DayLatePayment", EmitDefaultValue=false)]
		public bool? Has30DayLatePayment { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialMaxTotalPayment", EmitDefaultValue=false)]
		public double? InitialMaxTotalPayment { get; set; }

		[DataMember(Name="initialRateHousingRatio", EmitDefaultValue=false)]
		public double? InitialRateHousingRatio { get; set; }

		[DataMember(Name="initialRateMonthlyPayment", EmitDefaultValue=false)]
		public double? InitialRateMonthlyPayment { get; set; }

		[DataMember(Name="initialRateTotalDebtRatio", EmitDefaultValue=false)]
		public double? InitialRateTotalDebtRatio { get; set; }

		[DataMember(Name="interestOnlyMonths", EmitDefaultValue=false)]
		public int? InterestOnlyMonths { get; set; }

		[DataMember(Name="interestOnlyRecastDate", EmitDefaultValue=false)]
		public DateTime? InterestOnlyRecastDate { get; set; }

		[DataMember(Name="isConsumerLiklyDefault", EmitDefaultValue=false)]
		public bool? IsConsumerLiklyDefault { get; set; }

		[DataMember(Name="isEligibleForSafeHarbor", EmitDefaultValue=false)]
		public string IsEligibleForSafeHarbor { get; set; }

		[DataMember(Name="isEvaluatedAlimonyObligations", EmitDefaultValue=false)]
		public bool? IsEvaluatedAlimonyObligations { get; set; }

		[DataMember(Name="isEvaluatedChildSupportObligations", EmitDefaultValue=false)]
		public bool? IsEvaluatedChildSupportObligations { get; set; }

		[DataMember(Name="isEvaluatedCreditHistory", EmitDefaultValue=false)]
		public bool? IsEvaluatedCreditHistory { get; set; }

		[DataMember(Name="isEvaluatedCurrentEmploymentStatus", EmitDefaultValue=false)]
		public bool? IsEvaluatedCurrentEmploymentStatus { get; set; }

		[DataMember(Name="isEvaluatedCurrentExpectedAssets", EmitDefaultValue=false)]
		public bool? IsEvaluatedCurrentExpectedAssets { get; set; }

		[DataMember(Name="isEvaluatedCurrentExpectedIncome", EmitDefaultValue=false)]
		public bool? IsEvaluatedCurrentExpectedIncome { get; set; }

		[DataMember(Name="isEvaluatedDebtObligations", EmitDefaultValue=false)]
		public bool? IsEvaluatedDebtObligations { get; set; }

		[DataMember(Name="isEvaluatedDebtToIncomeRatio", EmitDefaultValue=false)]
		public bool? IsEvaluatedDebtToIncomeRatio { get; set; }

		[DataMember(Name="isEvaluatedMonthlyCoveredLoanPayment", EmitDefaultValue=false)]
		public bool? IsEvaluatedMonthlyCoveredLoanPayment { get; set; }

		[DataMember(Name="isEvaluatedMonthlyMortgageRelatedObligations", EmitDefaultValue=false)]
		public bool? IsEvaluatedMonthlyMortgageRelatedObligations { get; set; }

		[DataMember(Name="isEvaluatedMonthlySimultaneousLoanPayment", EmitDefaultValue=false)]
		public bool? IsEvaluatedMonthlySimultaneousLoanPayment { get; set; }

		[DataMember(Name="isEvaluatedResidualIncome", EmitDefaultValue=false)]
		public bool? IsEvaluatedResidualIncome { get; set; }

		[DataMember(Name="isHigherPricedLoan", EmitDefaultValue=false)]
		public string IsHigherPricedLoan { get; set; }

		[DataMember(Name="loanProcessingInformationCode24", EmitDefaultValue=false)]
		public string LoanProcessingInformationCode24 { get; set; }

		[DataMember(Name="loanProcessingInformationCode31", EmitDefaultValue=false)]
		public string LoanProcessingInformationCode31 { get; set; }

		[DataMember(Name="loanProcessingInformationCode32", EmitDefaultValue=false)]
		public string LoanProcessingInformationCode32 { get; set; }

		[DataMember(Name="loanProcessingInformationCode33", EmitDefaultValue=false)]
		public string LoanProcessingInformationCode33 { get; set; }

		[DataMember(Name="loanProcessingInformationCode97", EmitDefaultValue=false)]
		public string LoanProcessingInformationCode97 { get; set; }

		[DataMember(Name="loanProcessingInformationCodeJr", EmitDefaultValue=false)]
		public string LoanProcessingInformationCodeJr { get; set; }

		[DataMember(Name="loanProcessingInformationCodeJt", EmitDefaultValue=false)]
		public string LoanProcessingInformationCodeJt { get; set; }

		[DataMember(Name="loanProcessingInformationD4", EmitDefaultValue=false)]
		public string LoanProcessingInformationD4 { get; set; }

		[DataMember(Name="loanProcessingInformationGO", EmitDefaultValue=false)]
		public string LoanProcessingInformationGO { get; set; }

		[DataMember(Name="loanProcessingInformationHA", EmitDefaultValue=false)]
		public string LoanProcessingInformationHA { get; set; }

		[DataMember(Name="loanProcessingInformationLE", EmitDefaultValue=false)]
		public string LoanProcessingInformationLE { get; set; }

		[DataMember(Name="loanProcessingInformationLF", EmitDefaultValue=false)]
		public string LoanProcessingInformationLF { get; set; }

		[DataMember(Name="loanProcessingInformationMA", EmitDefaultValue=false)]
		public string LoanProcessingInformationMA { get; set; }

		[DataMember(Name="loanProgram", EmitDefaultValue=false)]
		public bool? LoanProgram { get; set; }

		[DataMember(Name="loanProgramDescription", EmitDefaultValue=false)]
		public string LoanProgramDescription { get; set; }

		[DataMember(Name="loanRateFixedin5Years", EmitDefaultValue=false)]
		public bool? LoanRateFixedin5Years { get; set; }

		[DataMember(Name="lOBrokerCompensationAmount", EmitDefaultValue=false)]
		public double? LOBrokerCompensationAmount { get; set; }

		[DataMember(Name="max5YrsHousingRatio", EmitDefaultValue=false)]
		public double? Max5YrsHousingRatio { get; set; }

		[DataMember(Name="max5YrsPrincipleAndInterest", EmitDefaultValue=false)]
		public double? Max5YrsPrincipleAndInterest { get; set; }

		[DataMember(Name="max5YrsTotalDebtRatio", EmitDefaultValue=false)]
		public double? Max5YrsTotalDebtRatio { get; set; }

		[DataMember(Name="max5YrsTotalPayment", EmitDefaultValue=false)]
		public double? Max5YrsTotalPayment { get; set; }

		[DataMember(Name="maxPrepaymentPenaltyFees", EmitDefaultValue=false)]
		public double? MaxPrepaymentPenaltyFees { get; set; }

		[DataMember(Name="negAmRecastDate", EmitDefaultValue=false)]
		public DateTime? NegAmRecastDate { get; set; }

		[DataMember(Name="paymentDecreasedBy10Percent", EmitDefaultValue=false)]
		public bool? PaymentDecreasedBy10Percent { get; set; }

		[DataMember(Name="pointsFeesThresholdMet", EmitDefaultValue=false)]
		public bool? PointsFeesThresholdMet { get; set; }

		[DataMember(Name="prepaymentPenaltyPayoffFees", EmitDefaultValue=false)]
		public double? PrepaymentPenaltyPayoffFees { get; set; }

		[DataMember(Name="prepayPenaltyPercentage", EmitDefaultValue=false)]
		public double? PrepayPenaltyPercentage { get; set; }

		[DataMember(Name="preventConsumersDefault", EmitDefaultValue=false)]
		public bool? PreventConsumersDefault { get; set; }

		[DataMember(Name="principalBalanceIncreased", EmitDefaultValue=false)]
		public bool? PrincipalBalanceIncreased { get; set; }

		[DataMember(Name="principalHasDeferred", EmitDefaultValue=false)]
		public bool? PrincipalHasDeferred { get; set; }

		[DataMember(Name="qMLoanType", EmitDefaultValue=false)]
		public string QMLoanType { get; set; }

		[DataMember(Name="rateReductionBasisPoints", EmitDefaultValue=false)]
		public double? RateReductionBasisPoints { get; set; }

		[DataMember(Name="rateReductionDiscountPoints", EmitDefaultValue=false)]
		public double? RateReductionDiscountPoints { get; set; }

		[DataMember(Name="rateReductionMaxBonaFideDiscountPoint", EmitDefaultValue=false)]
		public double? RateReductionMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="realEstateFees", EmitDefaultValue=false)]
		public double? RealEstateFees { get; set; }

		[DataMember(Name="recastDifferencePayment", EmitDefaultValue=false)]
		public double? RecastDifferencePayment { get; set; }

		[DataMember(Name="regZTotalLoanAmount", EmitDefaultValue=false)]
		public double? RegZTotalLoanAmount { get; set; }

		[DataMember(Name="requiredServicesLenderSelectedAmt", EmitDefaultValue=false)]
		public double? RequiredServicesLenderSelectedAmt { get; set; }

		[DataMember(Name="smallCreditorQMCalculatedThreshold", EmitDefaultValue=false)]
		public double? SmallCreditorQMCalculatedThreshold { get; set; }

		[DataMember(Name="smallCreditorQMStatusAlimony", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusAlimony { get; set; }

		[DataMember(Name="smallCreditorQMStatusAssets", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusAssets { get; set; }

		[DataMember(Name="smallCreditorQMStatusBalloonPayment", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusBalloonPayment { get; set; }

		[DataMember(Name="smallCreditorQMStatusChildSupport", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusChildSupport { get; set; }

		[DataMember(Name="smallCreditorQMStatusCoveredLoan", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusCoveredLoan { get; set; }

		[DataMember(Name="smallCreditorQMStatusDebtObligations", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusDebtObligations { get; set; }

		[DataMember(Name="smallCreditorQMStatusDTI", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusDTI { get; set; }

		[DataMember(Name="smallCreditorQMStatusIncome", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusIncome { get; set; }

		[DataMember(Name="smallCreditorQMStatusInterestOnly", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusInterestOnly { get; set; }

		[DataMember(Name="smallCreditorQMStatusLoanTerm", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusLoanTerm { get; set; }

		[DataMember(Name="smallCreditorQMStatusMtgRelatedObligations", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="smallCreditorQMStatusNegativeAmortization", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="smallCreditorQMStatusOverall", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusOverall { get; set; }

		[DataMember(Name="smallCreditorQMStatusPointsFeesLimit", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="smallCreditorQMStatusPrepaymentPenalty", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="smallCreditorQMStatusResidualIncome", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusResidualIncome { get; set; }

		[DataMember(Name="smallCreditorQMStatusSafeHarborEligibility", EmitDefaultValue=false)]
		public string SmallCreditorQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="standardQMCalculatedThreshold", EmitDefaultValue=false)]
		public double? StandardQMCalculatedThreshold { get; set; }

		[DataMember(Name="standardQMStatusAlimony", EmitDefaultValue=false)]
		public string StandardQMStatusAlimony { get; set; }

		[DataMember(Name="standardQMStatusAssets", EmitDefaultValue=false)]
		public string StandardQMStatusAssets { get; set; }

		[DataMember(Name="standardQMStatusBalloonPayment", EmitDefaultValue=false)]
		public string StandardQMStatusBalloonPayment { get; set; }

		[DataMember(Name="standardQMStatusChildSupport", EmitDefaultValue=false)]
		public string StandardQMStatusChildSupport { get; set; }

		[DataMember(Name="standardQMStatusCoveredLoan", EmitDefaultValue=false)]
		public string StandardQMStatusCoveredLoan { get; set; }

		[DataMember(Name="standardQMStatusCreditHistory", EmitDefaultValue=false)]
		public string StandardQMStatusCreditHistory { get; set; }

		[DataMember(Name="standardQMStatusDebtObligations", EmitDefaultValue=false)]
		public string StandardQMStatusDebtObligations { get; set; }

		[DataMember(Name="standardQMStatusDTI", EmitDefaultValue=false)]
		public string StandardQMStatusDTI { get; set; }

		[DataMember(Name="standardQMStatusEmployment", EmitDefaultValue=false)]
		public string StandardQMStatusEmployment { get; set; }

		[DataMember(Name="standardQMStatusIncome", EmitDefaultValue=false)]
		public string StandardQMStatusIncome { get; set; }

		[DataMember(Name="standardQMStatusInterestOnly", EmitDefaultValue=false)]
		public string StandardQMStatusInterestOnly { get; set; }

		[DataMember(Name="standardQMStatusLoanTerm", EmitDefaultValue=false)]
		public string StandardQMStatusLoanTerm { get; set; }

		[DataMember(Name="standardQMStatusMtgRelatedObligations", EmitDefaultValue=false)]
		public string StandardQMStatusMtgRelatedObligations { get; set; }

		[DataMember(Name="standardQMStatusNegativeAmortization", EmitDefaultValue=false)]
		public string StandardQMStatusNegativeAmortization { get; set; }

		[DataMember(Name="standardQMStatusOverall", EmitDefaultValue=false)]
		public string StandardQMStatusOverall { get; set; }

		[DataMember(Name="standardQMStatusPointsFeesLimit", EmitDefaultValue=false)]
		public string StandardQMStatusPointsFeesLimit { get; set; }

		[DataMember(Name="standardQMStatusPrepaymentPenalty", EmitDefaultValue=false)]
		public string StandardQMStatusPrepaymentPenalty { get; set; }

		[DataMember(Name="standardQMStatusResidualIncome", EmitDefaultValue=false)]
		public string StandardQMStatusResidualIncome { get; set; }

		[DataMember(Name="standardQMStatusSafeHarborEligibility", EmitDefaultValue=false)]
		public string StandardQMStatusSafeHarborEligibility { get; set; }

		[DataMember(Name="standardQMStatusSimultaneousLoan", EmitDefaultValue=false)]
		public string StandardQMStatusSimultaneousLoan { get; set; }

		[DataMember(Name="startingAdjustedRateMaxBonaFideDiscountPoint", EmitDefaultValue=false)]
		public double? StartingAdjustedRateMaxBonaFideDiscountPoint { get; set; }

		[DataMember(Name="statusCreditHistory", EmitDefaultValue=false)]
		public string StatusCreditHistory { get; set; }

		[DataMember(Name="statusSimultaneousLoan", EmitDefaultValue=false)]
		public string StatusSimultaneousLoan { get; set; }

		[DataMember(Name="thresholdExceedsQM", EmitDefaultValue=false)]
		public string ThresholdExceedsQM { get; set; }

		[DataMember(Name="titleServicesLenderTitleinsuranceFee", EmitDefaultValue=false)]
		public double? TitleServicesLenderTitleinsuranceFee { get; set; }

		[DataMember(Name="totalCoMortgagorIncome", EmitDefaultValue=false)]
		public double? TotalCoMortgagorIncome { get; set; }

		[DataMember(Name="totalIncome", EmitDefaultValue=false)]
		public double? TotalIncome { get; set; }

		[DataMember(Name="totalPointsFeesSec32Percent", EmitDefaultValue=false)]
		public double? TotalPointsFeesSec32Percent { get; set; }

		[DataMember(Name="transactionExemptFromRegZ", EmitDefaultValue=false)]
		public bool? TransactionExemptFromRegZ { get; set; }

		[DataMember(Name="ucdRequirement", EmitDefaultValue=false)]
		public string UcdRequirement { get; set; }

		[DataMember(Name="unitCount", EmitDefaultValue=false)]
		public bool? UnitCount { get; set; }

		[DataMember(Name="upfrontPMIFees", EmitDefaultValue=false)]
		public double? UpfrontPMIFees { get; set; }

		[DataMember(Name="withOriginalCreditor", EmitDefaultValue=false)]
		public bool? WithOriginalCreditor { get; set; }

		[DataMember(Name="writtenApplicationDate", EmitDefaultValue=false)]
		public DateTime? WrittenApplicationDate { get; set; }

		[DataMember(Name = "gseagencyQmStatusQmAvailable", EmitDefaultValue = false)]
		public string GSEAgencyQMStatusQMAvailable { get; set; }

		[DataMember(Name = "qmAprPercentage", EmitDefaultValue = false)]
		public decimal? QmAprPercentage { get; set; }

		[DataMember(Name = "isQmHigherPricedLoan", EmitDefaultValue = false)]
		public string IsQmHigherPricedLoan { get; set; }

		[DataMember(Name = "standardQmStatusPriceLimit", EmitDefaultValue = false)]
		public string StandardQmStatusPriceLimit { get; set; }

	}
}