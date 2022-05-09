using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanPrograms
	{
		[DataMember(Name="acquisition", EmitDefaultValue=false)]
		public string Acquisition { get; set; }

		[DataMember(Name="additionalArmInformation", EmitDefaultValue=false)]
		public string AdditionalArmInformation { get; set; }

		[DataMember(Name="allDateAndNumericalDisclosures", EmitDefaultValue=false)]
		public string AllDateAndNumericalDisclosures { get; set; }

		[DataMember(Name="annualFeeNeeded", EmitDefaultValue=false)]
		public double? AnnualFeeNeeded { get; set; }

		[DataMember(Name="armTypeDescription", EmitDefaultValue=false)]
		public string ArmTypeDescription { get; set; }

		[DataMember(Name="assumptionOnYourProperty", EmitDefaultValue=false)]
		public string AssumptionOnYourProperty { get; set; }

		[DataMember(Name="balloonLoanMaturityTermMonths", EmitDefaultValue=false)]
		public int? BalloonLoanMaturityTermMonths { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths1", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths1 { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths2", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths2 { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths3", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths3 { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths4", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths4 { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths5", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths5 { get; set; }

		[DataMember(Name="buydownChangeFrequencyMonths6", EmitDefaultValue=false)]
		public int? BuydownChangeFrequencyMonths6 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent1", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent1 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent2", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent2 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent3", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent3 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent4", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent4 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent5", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent5 { get; set; }

		[DataMember(Name="buydownIncreaseRatePercent6", EmitDefaultValue=false)]
		public double? BuydownIncreaseRatePercent6 { get; set; }

		[DataMember(Name="calculateBasedOnRemainingBalance", EmitDefaultValue=false)]
		public string CalculateBasedOnRemainingBalance { get; set; }

		[DataMember(Name="closingCostProgram", EmitDefaultValue=false)]
		public string ClosingCostProgram { get; set; }

		[DataMember(Name="constructionDescription", EmitDefaultValue=false)]
		public string ConstructionDescription { get; set; }

		[DataMember(Name="constructionInterestReserveAmount", EmitDefaultValue=false)]
		public double? ConstructionInterestReserveAmount { get; set; }

		[DataMember(Name="constructionLoanMethod", EmitDefaultValue=false)]
		public string ConstructionLoanMethod { get; set; }

		[DataMember(Name="constructionPeriodMonths", EmitDefaultValue=false)]
		public int? ConstructionPeriodMonths { get; set; }

		[DataMember(Name="constructionRate", EmitDefaultValue=false)]
		public double? ConstructionRate { get; set; }

		[DataMember(Name="convertible", EmitDefaultValue=false)]
		public string Convertible { get; set; }

		[DataMember(Name="creditDisability", EmitDefaultValue=false)]
		public string CreditDisability { get; set; }

		[DataMember(Name="creditLifeInsurance", EmitDefaultValue=false)]
		public string CreditLifeInsurance { get; set; }

		[DataMember(Name="demandFeature", EmitDefaultValue=false)]
		public string DemandFeature { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="disclosureType", EmitDefaultValue=false)]
		public string DisclosureType { get; set; }

		[DataMember(Name="discounted", EmitDefaultValue=false)]
		public string Discounted { get; set; }

		[DataMember(Name="discountedRate", EmitDefaultValue=false)]
		public double? DiscountedRate { get; set; }

		[DataMember(Name="drawRepayPeriodTableName", EmitDefaultValue=false)]
		public string DrawRepayPeriodTableName { get; set; }

		[DataMember(Name="fhaUpfrontMiPremiumPercent", EmitDefaultValue=false)]
		public double? FhaUpfrontMiPremiumPercent { get; set; }

		[DataMember(Name="floodInsurance", EmitDefaultValue=false)]
		public string FloodInsurance { get; set; }

		[DataMember(Name="floorPercent", EmitDefaultValue=false)]
		public double? FloorPercent { get; set; }

		[DataMember(Name="fundingFeePaidInCash", EmitDefaultValue=false)]
		public double? FundingFeePaidInCash { get; set; }

		[DataMember(Name="gpmExtraPaymentForEarlyPayOff", EmitDefaultValue=false)]
		public double? GpmExtraPaymentForEarlyPayOff { get; set; }

		[DataMember(Name="gpmRate", EmitDefaultValue=false)]
		public double? GpmRate { get; set; }

		[DataMember(Name="gpmYears", EmitDefaultValue=false)]
		public int? GpmYears { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="ifYouPurchase", EmitDefaultValue=false)]
		public string IfYouPurchase { get; set; }

		[DataMember(Name="ifYouPurchaseType", EmitDefaultValue=false)]
		public string IfYouPurchaseType { get; set; }

		[DataMember(Name="indexCurrentValuePercent", EmitDefaultValue=false)]
		public double? IndexCurrentValuePercent { get; set; }

		[DataMember(Name="indexMarginPercent", EmitDefaultValue=false)]
		public double? IndexMarginPercent { get; set; }

		[DataMember(Name="initialAdvanceAmount", EmitDefaultValue=false)]
		public double? InitialAdvanceAmount { get; set; }

		[DataMember(Name="interestOnlyMonths", EmitDefaultValue=false)]
		public int? InterestOnlyMonths { get; set; }

		[DataMember(Name="lateChargeDays", EmitDefaultValue=false)]
		public int? LateChargeDays { get; set; }

		[DataMember(Name="lateChargePercent", EmitDefaultValue=false)]
		public double? LateChargePercent { get; set; }

		[DataMember(Name="lateChargeType", EmitDefaultValue=false)]
		public string LateChargeType { get; set; }

		[DataMember(Name="lenderInvestorCode", EmitDefaultValue=false)]
		public string LenderInvestorCode { get; set; }

		[DataMember(Name="lienPriorityType", EmitDefaultValue=false)]
		public string LienPriorityType { get; set; }

		[DataMember(Name="loanAmortizationTermMonths", EmitDefaultValue=false)]
		public int? LoanAmortizationTermMonths { get; set; }

		[DataMember(Name="loanAmortizationType", EmitDefaultValue=false)]
		public string LoanAmortizationType { get; set; }

		[DataMember(Name="loanDocumentationType", EmitDefaultValue=false)]
		public string LoanDocumentationType { get; set; }

		[DataMember(Name="loanFeaturesPaymentFrequencyType", EmitDefaultValue=false)]
		public string LoanFeaturesPaymentFrequencyType { get; set; }

		[DataMember(Name="loanProgramName", EmitDefaultValue=false)]
		public string LoanProgramName { get; set; }

		[DataMember(Name="lockField", EmitDefaultValue=false)]
		public string LockField { get; set; }

		[DataMember(Name="maxBackRatio", EmitDefaultValue=false)]
		public double? MaxBackRatio { get; set; }

		[DataMember(Name="maxCltv", EmitDefaultValue=false)]
		public double? MaxCltv { get; set; }

		[DataMember(Name="maxFrontRatio", EmitDefaultValue=false)]
		public double? MaxFrontRatio { get; set; }

		[DataMember(Name="maximumBalance", EmitDefaultValue=false)]
		public double? MaximumBalance { get; set; }

		[DataMember(Name="maxLoanAmount", EmitDefaultValue=false)]
		public double? MaxLoanAmount { get; set; }

		[DataMember(Name="maxLtv", EmitDefaultValue=false)]
		public double? MaxLtv { get; set; }

		[DataMember(Name="meansAnEstimate", EmitDefaultValue=false)]
		public string MeansAnEstimate { get; set; }

		[DataMember(Name="miCalculationType", EmitDefaultValue=false)]
		public string MiCalculationType { get; set; }

		[DataMember(Name="midpointCancellation", EmitDefaultValue=false)]
		public string MidpointCancellation { get; set; }

		[DataMember(Name="minCreditScore", EmitDefaultValue=false)]
		public string MinCreditScore { get; set; }

		[DataMember(Name="minimumAdvanceAmount", EmitDefaultValue=false)]
		public double? MinimumAdvanceAmount { get; set; }

		[DataMember(Name="minimumAllowableApr", EmitDefaultValue=false)]
		public double? MinimumAllowableApr { get; set; }

		[DataMember(Name="minimumPaymentAmount", EmitDefaultValue=false)]
		public double? MinimumPaymentAmount { get; set; }

		[DataMember(Name="minimumPaymentPercent", EmitDefaultValue=false)]
		public double? MinimumPaymentPercent { get; set; }

		[DataMember(Name="mipPaidInCash", EmitDefaultValue=false)]
		public double? MipPaidInCash { get; set; }

		[DataMember(Name="mmi", EmitDefaultValue=false)]
		public string Mmi { get; set; }

		[DataMember(Name="mortgageInsuranceAdjustmentFactor1", EmitDefaultValue=false)]
		public double? MortgageInsuranceAdjustmentFactor1 { get; set; }

		[DataMember(Name="mortgageInsuranceAdjustmentFactor2", EmitDefaultValue=false)]
		public double? MortgageInsuranceAdjustmentFactor2 { get; set; }

		[DataMember(Name="mortgageInsuranceCancelPercent", EmitDefaultValue=false)]
		public double? MortgageInsuranceCancelPercent { get; set; }

		[DataMember(Name="mortgageInsuranceMonthlyPayment1", EmitDefaultValue=false)]
		public double? MortgageInsuranceMonthlyPayment1 { get; set; }

		[DataMember(Name="mortgageInsuranceMonthlyPayment2", EmitDefaultValue=false)]
		public double? MortgageInsuranceMonthlyPayment2 { get; set; }

		[DataMember(Name="mortgageInsuranceMonthsOfAdjustment1", EmitDefaultValue=false)]
		public int? MortgageInsuranceMonthsOfAdjustment1 { get; set; }

		[DataMember(Name="mortgageInsuranceMonthsOfAdjustment2", EmitDefaultValue=false)]
		public int? MortgageInsuranceMonthsOfAdjustment2 { get; set; }

		[DataMember(Name="mortgageType", EmitDefaultValue=false)]
		public string MortgageType { get; set; }

		[DataMember(Name="otherAmortizationTypeDescription", EmitDefaultValue=false)]
		public string OtherAmortizationTypeDescription { get; set; }

		[DataMember(Name="otherLoanPurposeDescription", EmitDefaultValue=false)]
		public string OtherLoanPurposeDescription { get; set; }

		[DataMember(Name="otherMortgageTypeDescription", EmitDefaultValue=false)]
		public string OtherMortgageTypeDescription { get; set; }

		[DataMember(Name="paymentAdjustmentDurationMonths", EmitDefaultValue=false)]
		public int? PaymentAdjustmentDurationMonths { get; set; }

		[DataMember(Name="paymentAdjustmentPeriodicCapPercent", EmitDefaultValue=false)]
		public double? PaymentAdjustmentPeriodicCapPercent { get; set; }

		[DataMember(Name="paymentFactor", EmitDefaultValue=false)]
		public double? PaymentFactor { get; set; }

		[DataMember(Name="percentageOfRental", EmitDefaultValue=false)]
		public double? PercentageOfRental { get; set; }

		[DataMember(Name="perDiemCalculationMethodType", EmitDefaultValue=false)]
		public string PerDiemCalculationMethodType { get; set; }

		[DataMember(Name="pmi", EmitDefaultValue=false)]
		public string Pmi { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator", EmitDefaultValue=false)]
		public string PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="programCode", EmitDefaultValue=false)]
		public string ProgramCode { get; set; }

		[DataMember(Name="propertyInsurance", EmitDefaultValue=false)]
		public string PropertyInsurance { get; set; }

		[DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="qualifyingRatePercent", EmitDefaultValue=false)]
		public double? QualifyingRatePercent { get; set; }

		[DataMember(Name="rateAdjustmentDurationMonths", EmitDefaultValue=false)]
		public int? RateAdjustmentDurationMonths { get; set; }

		[DataMember(Name="rateAdjustmentLifetimeCapPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentLifetimeCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentPercent { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentCapPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentSubsequentCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentRateAdjustmentMonths", EmitDefaultValue=false)]
		public int? RateAdjustmentSubsequentRateAdjustmentMonths { get; set; }

		[DataMember(Name="recastPaidMonths", EmitDefaultValue=false)]
		public int? RecastPaidMonths { get; set; }

		[DataMember(Name="recastStopMonths", EmitDefaultValue=false)]
		public int? RecastStopMonths { get; set; }

		[DataMember(Name="refundPaymentIndicator", EmitDefaultValue=false)]
		public string RefundPaymentIndicator { get; set; }

		[DataMember(Name="requestedInterestRatePercent", EmitDefaultValue=false)]
		public double? RequestedInterestRatePercent { get; set; }

		[DataMember(Name="requiredDeposit", EmitDefaultValue=false)]
		public string RequiredDeposit { get; set; }

		[DataMember(Name="roundPercent", EmitDefaultValue=false)]
		public double? RoundPercent { get; set; }

		[DataMember(Name="roundType", EmitDefaultValue=false)]
		public string RoundType { get; set; }

		[DataMember(Name="securityInterestInNameOf", EmitDefaultValue=false)]
		public string SecurityInterestInNameOf { get; set; }

		[DataMember(Name="securityType", EmitDefaultValue=false)]
		public string SecurityType { get; set; }

		[DataMember(Name="subjectPropertyGrossRentalIncome", EmitDefaultValue=false)]
		public double? SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="teaserRate", EmitDefaultValue=false)]
		public double? TeaserRate { get; set; }

		[DataMember(Name="terminationFeeAmount", EmitDefaultValue=false)]
		public double? TerminationFeeAmount { get; set; }

		[DataMember(Name="terminationPeriodMonthsCount", EmitDefaultValue=false)]
		public int? TerminationPeriodMonthsCount { get; set; }

		[DataMember(Name="thirdPartyFeeFrom", EmitDefaultValue=false)]
		public double? ThirdPartyFeeFrom { get; set; }

		[DataMember(Name="thirdPartyFeeTo", EmitDefaultValue=false)]
		public double? ThirdPartyFeeTo { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

		[DataMember(Name="useDaysInYears", EmitDefaultValue=false)]
		public string UseDaysInYears { get; set; }

		[DataMember(Name="usePitiForRatio", EmitDefaultValue=false)]
		public string UsePitiForRatio { get; set; }

		[DataMember(Name="variableRateFeature", EmitDefaultValue=false)]
		public string VariableRateFeature { get; set; }

		[DataMember(Name="yearlyTerm", EmitDefaultValue=false)]
		public double? YearlyTerm { get; set; }

	}
}