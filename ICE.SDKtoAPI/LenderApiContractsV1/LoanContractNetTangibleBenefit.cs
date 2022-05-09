using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractNetTangibleBenefit
	{
		[DataMember(Name="aprNotExceedIndicator", EmitDefaultValue=false)]
		public bool? AprNotExceedIndicator { get; set; }

		[DataMember(Name="avoidingForeclosureIndicator", EmitDefaultValue=false)]
		public bool? AvoidingForeclosureIndicator { get; set; }

		[DataMember(Name="beneficialChangedForBorrowerIndicator", EmitDefaultValue=false)]
		public bool? BeneficialChangedForBorrowerIndicator { get; set; }

		[DataMember(Name="bonaFideFinancialEmergency", EmitDefaultValue=false)]
		public string BonaFideFinancialEmergency { get; set; }

		[DataMember(Name="borrowerCanRecoupCostofRefinancingIndicator", EmitDefaultValue=false)]
		public bool? BorrowerCanRecoupCostofRefinancingIndicator { get; set; }

		[DataMember(Name="borrowerCanRecoupIndicator", EmitDefaultValue=false)]
		public bool? BorrowerCanRecoupIndicator { get; set; }

		[DataMember(Name="borrowerMonthlyPaymentLowerThan20Indicator", EmitDefaultValue=false)]
		public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get; set; }

		[DataMember(Name="borrowerReceivedReasonable", EmitDefaultValue=false)]
		public string BorrowerReceivedReasonable { get; set; }

		[DataMember(Name="borrowerReceivesAmountExcessCostAndFeesIndicator", EmitDefaultValue=false)]
		public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }

		[DataMember(Name="changeLoanFromArmtoFixedIndicator", EmitDefaultValue=false)]
		public bool? ChangeLoanFromArmtoFixedIndicator { get; set; }

		[DataMember(Name="changingLoanToFixedRateIndicator", EmitDefaultValue=false)]
		public bool? ChangingLoanToFixedRateIndicator { get; set; }

		[DataMember(Name="consolidatingOtherExistingLoansIntoNewLoanIndicator", EmitDefaultValue=false)]
		public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }

		[DataMember(Name="eliminatingBalloonPaymentIndicator", EmitDefaultValue=false)]
		public bool? EliminatingBalloonPaymentIndicator { get; set; }

		[DataMember(Name="eliminatingNegArmIndicator", EmitDefaultValue=false)]
		public bool? EliminatingNegArmIndicator { get; set; }

		[DataMember(Name="eliminatingPrivateMortgageInsuranceIndicator", EmitDefaultValue=false)]
		public bool? EliminatingPrivateMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="existingLoanAprPercent", EmitDefaultValue=false)]
		public double? ExistingLoanAprPercent { get; set; }

		[DataMember(Name="existingLoanBalloonIndicator", EmitDefaultValue=false)]
		public bool? ExistingLoanBalloonIndicator { get; set; }

		[DataMember(Name="existingLoanBorrowerReceivesCashOutAmount", EmitDefaultValue=false)]
		public double? ExistingLoanBorrowerReceivesCashOutAmount { get; set; }

		[DataMember(Name="existingLoanBorrowerReceivesCashOutIndicator", EmitDefaultValue=false)]
		public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get; set; }

		[DataMember(Name="existingLoanBottomRatioPercent", EmitDefaultValue=false)]
		public double? ExistingLoanBottomRatioPercent { get; set; }

		[DataMember(Name="existingLoanDateLoanClosed", EmitDefaultValue=false)]
		public DateTime? ExistingLoanDateLoanClosed { get; set; }

		[DataMember(Name="existingLoanFullyIndexRatePercent", EmitDefaultValue=false)]
		public double? ExistingLoanFullyIndexRatePercent { get; set; }

		[DataMember(Name="existingLoanInterestRatePercent", EmitDefaultValue=false)]
		public double? ExistingLoanInterestRatePercent { get; set; }

		[DataMember(Name="existingLoanIsGuaranteedIndicator", EmitDefaultValue=false)]
		public bool? ExistingLoanIsGuaranteedIndicator { get; set; }

		[DataMember(Name="existingLoanIsLoanRefinancedAsSpecial", EmitDefaultValue=false)]
		public bool? ExistingLoanIsLoanRefinancedAsSpecial { get; set; }

		[DataMember(Name="existingLoanIsNegativeAmortizationFeatureIndicator", EmitDefaultValue=false)]
		public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get; set; }

		[DataMember(Name="existingLoanIsPrepaymentPenalty", EmitDefaultValue=false)]
		public bool? ExistingLoanIsPrepaymentPenalty { get; set; }

		[DataMember(Name="existingLoanLoanAmortizationType", EmitDefaultValue=false)]
		public string ExistingLoanLoanAmortizationType { get; set; }

		[DataMember(Name="existingLoanLoanAmount", EmitDefaultValue=false)]
		public double? ExistingLoanLoanAmount { get; set; }

		[DataMember(Name="existingLoanLoanTerm", EmitDefaultValue=false)]
		public int? ExistingLoanLoanTerm { get; set; }

		[DataMember(Name="existingLoanLtvPercent", EmitDefaultValue=false)]
		public double? ExistingLoanLtvPercent { get; set; }

		[DataMember(Name="existingLoanMaximumRatePercent", EmitDefaultValue=false)]
		public double? ExistingLoanMaximumRatePercent { get; set; }

		[DataMember(Name="existingLoanMonthsRemaining", EmitDefaultValue=false)]
		public int? ExistingLoanMonthsRemaining { get; set; }

		[DataMember(Name="existingLoanPaymentAmount", EmitDefaultValue=false)]
		public double? ExistingLoanPaymentAmount { get; set; }

		[DataMember(Name="existingLoanPaymentDifference", EmitDefaultValue=false)]
		public double? ExistingLoanPaymentDifference { get; set; }

		[DataMember(Name="existingLoanPaymentIncludeMiObligation", EmitDefaultValue=false)]
		public double? ExistingLoanPaymentIncludeMiObligation { get; set; }

		[DataMember(Name="existingLoanPaymentIncludeMortgageInsurance", EmitDefaultValue=false)]
		public double? ExistingLoanPaymentIncludeMortgageInsurance { get; set; }

		[DataMember(Name="existingLoanPrepaymentPenaltyAmountIncludedInNewLoan", EmitDefaultValue=false)]
		public double? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }

		[DataMember(Name="existingLoanPrepaymentPenaltyBasedOn", EmitDefaultValue=false)]
		public string ExistingLoanPrepaymentPenaltyBasedOn { get; set; }

		[DataMember(Name="existingLoanPrepaymentPenaltyPercentage", EmitDefaultValue=false)]
		public double? ExistingLoanPrepaymentPenaltyPercentage { get; set; }

		[DataMember(Name="existingLoanPrepaymentPenaltyTerm", EmitDefaultValue=false)]
		public int? ExistingLoanPrepaymentPenaltyTerm { get; set; }

		[DataMember(Name="existingLoanProvidedByLicenseeType", EmitDefaultValue=false)]
		public string ExistingLoanProvidedByLicenseeType { get; set; }

		[DataMember(Name="existingLoanPurposeType", EmitDefaultValue=false)]
		public string ExistingLoanPurposeType { get; set; }

		[DataMember(Name="existingLoanRecoupCostsYears", EmitDefaultValue=false)]
		public int? ExistingLoanRecoupCostsYears { get; set; }

		[DataMember(Name="existingLoanSavingsAmount", EmitDefaultValue=false)]
		public double? ExistingLoanSavingsAmount { get; set; }

		[DataMember(Name="existingLoanTotalDebtPayoff", EmitDefaultValue=false)]
		public double? ExistingLoanTotalDebtPayoff { get; set; }

		[DataMember(Name="existingLoanWeightedAverageInterestRatePercent", EmitDefaultValue=false)]
		public double? ExistingLoanWeightedAverageInterestRatePercent { get; set; }

		[DataMember(Name="homeLoanComplianceWith209", EmitDefaultValue=false)]
		public bool? HomeLoanComplianceWith209 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lenderDeterminedBorrowersInterest", EmitDefaultValue=false)]
		public bool? LenderDeterminedBorrowersInterest { get; set; }

		[DataMember(Name="newLoanIsGuaranteedIndicator", EmitDefaultValue=false)]
		public bool? NewLoanIsGuaranteedIndicator { get; set; }

		[DataMember(Name="newLoanIsNegativeAmortizationFeatureIndicator", EmitDefaultValue=false)]
		public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get; set; }

		[DataMember(Name="newLoanIsSafeHarborQM", EmitDefaultValue=false)]
		public bool? NewLoanIsSafeHarborQM { get; set; }

		[DataMember(Name="newLoanIsSpecialMortgageOriginatedIndicator", EmitDefaultValue=false)]
		public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get; set; }

		[DataMember(Name="newLoanPaymentWithMiDifference", EmitDefaultValue=false)]
		public double? NewLoanPaymentWithMiDifference { get; set; }

		[DataMember(Name="newLoanPaymentWithObligationDifference", EmitDefaultValue=false)]
		public double? NewLoanPaymentWithObligationDifference { get; set; }

		[DataMember(Name="newLoanPayOffConsolidateDebtIndicator", EmitDefaultValue=false)]
		public bool? NewLoanPayOffConsolidateDebtIndicator { get; set; }

		[DataMember(Name="newLoanWeightedAverageInterestRatePercent", EmitDefaultValue=false)]
		public double? NewLoanWeightedAverageInterestRatePercent { get; set; }

		[DataMember(Name="obtainingLowerIntMonthlyPaymentIndicator", EmitDefaultValue=false)]
		public bool? ObtainingLowerIntMonthlyPaymentIndicator { get; set; }

		[DataMember(Name="obtainingLowerIntRateIndicator", EmitDefaultValue=false)]
		public bool? ObtainingLowerIntRateIndicator { get; set; }

		[DataMember(Name="obtainingShortAmortScheduleIndicator", EmitDefaultValue=false)]
		public bool? ObtainingShortAmortScheduleIndicator { get; set; }

		[DataMember(Name="otherReason", EmitDefaultValue=false)]
		public bool? OtherReason { get; set; }

		[DataMember(Name="otherReasonDescription", EmitDefaultValue=false)]
		public string OtherReasonDescription { get; set; }

		[DataMember(Name="printBorrowerInitialLinesIndicator", EmitDefaultValue=false)]
		public bool? PrintBorrowerInitialLinesIndicator { get; set; }

		[DataMember(Name="proceedsOfNewLoanWillBeUsedIndicator", EmitDefaultValue=false)]
		public bool? ProceedsOfNewLoanWillBeUsedIndicator { get; set; }

		[DataMember(Name="receivingCashOutFromNewLoanGreaterThanClosingCostIndicator", EmitDefaultValue=false)]
		public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }

		[DataMember(Name="refinancingLoanIsHomeEquityIndicator", EmitDefaultValue=false)]
		public bool? RefinancingLoanIsHomeEquityIndicator { get; set; }

		[DataMember(Name="refinancingRespondBonaFide", EmitDefaultValue=false)]
		public bool? RefinancingRespondBonaFide { get; set; }

	}
}