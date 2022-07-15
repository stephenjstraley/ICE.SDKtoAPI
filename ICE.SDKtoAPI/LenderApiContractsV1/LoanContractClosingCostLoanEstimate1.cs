using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate1
	{
		[DataMember(Name="adjustsTermType", EmitDefaultValue=false)]
		public string AdjustsTermType { get; set; }

		[DataMember(Name="changedCircumstanceComments", EmitDefaultValue=false)]
		public string ChangedCircumstanceComments { get; set; }

		[DataMember(Name="closingCostEstimateExpirationDate", EmitDefaultValue=false)]
		public DateTime? ClosingCostEstimateExpirationDate { get; set; }

		[DataMember(Name="closingCostEstimateExpirationDateUI", EmitDefaultValue=false)]
		public string ClosingCostEstimateExpirationDateUI { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTime", EmitDefaultValue=false)]
		public string ClosingCostEstimateExpirationTime { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeUI", EmitDefaultValue=false)]
		public string ClosingCostEstimateExpirationTimeUI { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeZone", EmitDefaultValue=false)]
		public string ClosingCostEstimateExpirationTimeZone { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeZoneUI", EmitDefaultValue=false)]
		public string ClosingCostEstimateExpirationTimeZoneUI { get; set; }

		[DataMember(Name="conversionBegin", EmitDefaultValue=false)]
		public string ConversionBegin { get; set; }

		[DataMember(Name="conversionEnd", EmitDefaultValue=false)]
		public string ConversionEnd { get; set; }

		[DataMember(Name="disclosureBy", EmitDefaultValue=false)]
		public string DisclosureBy { get; set; }

		[DataMember(Name="disclosureClosingCostExpDate", EmitDefaultValue=false)]
		public DateTime? DisclosureClosingCostExpDate { get; set; }

		[DataMember(Name="disclosureClosingCostExpTime", EmitDefaultValue=false)]
		public string DisclosureClosingCostExpTime { get; set; }

		[DataMember(Name="disclosureClosingCostExpTimeZone", EmitDefaultValue=false)]
		public string DisclosureClosingCostExpTimeZone { get; set; }

		[DataMember(Name="disclosureComments", EmitDefaultValue=false)]
		public string DisclosureComments { get; set; }

		[DataMember(Name="disclosureLastSentDate", EmitDefaultValue=false)]
		public DateTime? DisclosureLastSentDate { get; set; }

		[DataMember(Name="disclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? DisclosureReceivedDate { get; set; }

		[DataMember(Name="disclosureSentMethod", EmitDefaultValue=false)]
		public string DisclosureSentMethod { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessments", EmitDefaultValue=false)]
		public double? EstimatedTaxesInsuranceAssessments { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessmentsUI", EmitDefaultValue=false)]
		public string EstimatedTaxesInsuranceAssessmentsUI { get; set; }

		[DataMember(Name="highestMonthlyPI", EmitDefaultValue=false)]
		public double? HighestMonthlyPI { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="inEscrowHomeownerInsurance", EmitDefaultValue=false)]
		public string InEscrowHomeownerInsurance { get; set; }

		[DataMember(Name="inEscrowOther", EmitDefaultValue=false)]
		public string InEscrowOther { get; set; }

		[DataMember(Name="inEscrowPropertyTaxes", EmitDefaultValue=false)]
		public string InEscrowPropertyTaxes { get; set; }

		[DataMember(Name="initialMonthlyPaymentFor10000Loan", EmitDefaultValue=false)]
		public double? InitialMonthlyPaymentFor10000Loan { get; set; }

		[DataMember(Name="initialMonthlyPaymentFor60000Loan", EmitDefaultValue=false)]
		public double? InitialMonthlyPaymentFor60000Loan { get; set; }

		[DataMember(Name="interestRateAdjustsEveryYears", EmitDefaultValue=false)]
		public string InterestRateAdjustsEveryYears { get; set; }

		[DataMember(Name="interestRateAdjustsInYear", EmitDefaultValue=false)]
		public int? InterestRateAdjustsInYear { get; set; }

		[DataMember(Name="interestRateAdjustsStartingInType", EmitDefaultValue=false)]
		public string InterestRateAdjustsStartingInType { get; set; }

		[DataMember(Name="interestRateAfterAdjustment", EmitDefaultValue=false)]
		public int? InterestRateAfterAdjustment { get; set; }

		[DataMember(Name="interestRateCanGoGoes", EmitDefaultValue=false)]
		public string InterestRateCanGoGoes { get; set; }

		[DataMember(Name="lEDateIssued", EmitDefaultValue=false)]
		public DateTime? LEDateIssued { get; set; }

		[DataMember(Name="loanAmountCanGoGoes", EmitDefaultValue=false)]
		public string LoanAmountCanGoGoes { get; set; }

		[DataMember(Name="loanAmountCanIncreaseOrIncreases", EmitDefaultValue=false)]
		public string LoanAmountCanIncreaseOrIncreases { get; set; }

		[DataMember(Name="loanProduct", EmitDefaultValue=false)]
		public string LoanProduct { get; set; }

		[DataMember(Name="loanPurpose", EmitDefaultValue=false)]
		public string LoanPurpose { get; set; }

		[DataMember(Name="loanTermMonths", EmitDefaultValue=false)]
		public int? LoanTermMonths { get; set; }

		[DataMember(Name="loanTermYears", EmitDefaultValue=false)]
		public int? LoanTermYears { get; set; }

		[DataMember(Name="maximumMonthlyPaymentFor10000Loan", EmitDefaultValue=false)]
		public double? MaximumMonthlyPaymentFor10000Loan { get; set; }

		[DataMember(Name="maximumPaymentMonth", EmitDefaultValue=false)]
		public int? MaximumPaymentMonth { get; set; }

		[DataMember(Name="monthlyPIAdjustedInDateType", EmitDefaultValue=false)]
		public string MonthlyPIAdjustedInDateType { get; set; }

		[DataMember(Name="monthlyPIAdjustsEveryYears", EmitDefaultValue=false)]
		public string MonthlyPIAdjustsEveryYears { get; set; }

		[DataMember(Name="monthlyPIAdjustsInYear", EmitDefaultValue=false)]
		public int? MonthlyPIAdjustsInYear { get; set; }

		[DataMember(Name="monthlyPIAdjustsStartingInType", EmitDefaultValue=false)]
		public string MonthlyPIAdjustsStartingInType { get; set; }

		[DataMember(Name="monthlyPIAdjustsTermType", EmitDefaultValue=false)]
		public string MonthlyPIAdjustsTermType { get; set; }

		[DataMember(Name="monthlyPIAfterAdjustment", EmitDefaultValue=false)]
		public int? MonthlyPIAfterAdjustment { get; set; }

		[DataMember(Name="monthlyPICanGoGoes", EmitDefaultValue=false)]
		public string MonthlyPICanGoGoes { get; set; }

		[DataMember(Name="monthlyPIInterestOnlyDateType", EmitDefaultValue=false)]
		public string MonthlyPIInterestOnlyDateType { get; set; }

		[DataMember(Name="monthlyPIInterestOnlyUntilYear", EmitDefaultValue=false)]
		public int? MonthlyPIInterestOnlyUntilYear { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmount", EmitDefaultValue=false)]
		public int? PPC1EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC1EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC1InterestOnly", EmitDefaultValue=false)]
		public bool? PPC1InterestOnly { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC1MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC1MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC1MaximumPIPayment { get; set; }

		[DataMember(Name="pPC1MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC1MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1MIAmount", EmitDefaultValue=false)]
		public int? PPC1MIAmount { get; set; }

		[DataMember(Name="pPC1MIAmountUI", EmitDefaultValue=false)]
		public string PPC1MIAmountUI { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPayment", EmitDefaultValue=false)]
		public int? PPC1MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC1MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC1MinimumPIPayment { get; set; }

		[DataMember(Name="pPC1MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC1MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1Year", EmitDefaultValue=false)]
		public int? PPC1Year { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmount", EmitDefaultValue=false)]
		public int? PPC2EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC2EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC2InterestOnly", EmitDefaultValue=false)]
		public bool? PPC2InterestOnly { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC2MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC2MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC2MaximumPIPayment { get; set; }

		[DataMember(Name="pPC2MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC2MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2MIAmount", EmitDefaultValue=false)]
		public int? PPC2MIAmount { get; set; }

		[DataMember(Name="pPC2MIAmountUI", EmitDefaultValue=false)]
		public string PPC2MIAmountUI { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPayment", EmitDefaultValue=false)]
		public int? PPC2MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC2MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC2MinimumPIPayment { get; set; }

		[DataMember(Name="pPC2MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC2MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2YearFrom", EmitDefaultValue=false)]
		public int? PPC2YearFrom { get; set; }

		[DataMember(Name="pPC2YearTo", EmitDefaultValue=false)]
		public int? PPC2YearTo { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmount", EmitDefaultValue=false)]
		public int? PPC3EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC3EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC3InterestOnly", EmitDefaultValue=false)]
		public bool? PPC3InterestOnly { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC3MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC3MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC3MaximumPIPayment { get; set; }

		[DataMember(Name="pPC3MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC3MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3MIAmount", EmitDefaultValue=false)]
		public int? PPC3MIAmount { get; set; }

		[DataMember(Name="pPC3MIAmountUI", EmitDefaultValue=false)]
		public string PPC3MIAmountUI { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPayment", EmitDefaultValue=false)]
		public int? PPC3MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC3MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC3MinimumPIPayment { get; set; }

		[DataMember(Name="pPC3MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC3MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3YearFrom", EmitDefaultValue=false)]
		public int? PPC3YearFrom { get; set; }

		[DataMember(Name="pPC3YearTo", EmitDefaultValue=false)]
		public int? PPC3YearTo { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmount", EmitDefaultValue=false)]
		public int? PPC4EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC4EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC4InterestOnly", EmitDefaultValue=false)]
		public bool? PPC4InterestOnly { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC4MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC4MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC4MaximumPIPayment { get; set; }

		[DataMember(Name="pPC4MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC4MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4MIAmount", EmitDefaultValue=false)]
		public int? PPC4MIAmount { get; set; }

		[DataMember(Name="pPC4MIAmountUI", EmitDefaultValue=false)]
		public string PPC4MIAmountUI { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPayment", EmitDefaultValue=false)]
		public int? PPC4MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC4MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC4MinimumPIPayment { get; set; }

		[DataMember(Name="pPC4MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC4MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4YearFrom", EmitDefaultValue=false)]
		public int? PPC4YearFrom { get; set; }

		[DataMember(Name="pPC4YearTo", EmitDefaultValue=false)]
		public int? PPC4YearTo { get; set; }

		[DataMember(Name="pPEstimatedEscrowIndicator", EmitDefaultValue=false)]
		public bool? PPEstimatedEscrowIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffDuringYear", EmitDefaultValue=false)]
		public int? PrepaymentPenaltyPayOffDuringYear { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffInDateType", EmitDefaultValue=false)]
		public string PrepaymentPenaltyPayOffInDateType { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffInFirstYear", EmitDefaultValue=false)]
		public string PrepaymentPenaltyPayOffInFirstYear { get; set; }

		[DataMember(Name="rangePaymentIndicatorC1", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC1 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC2", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC2 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC3", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC3 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC4", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC4 { get; set; }

		[DataMember(Name="rateLockExpirationTime", EmitDefaultValue=false)]
		public string RateLockExpirationTime { get; set; }

		[DataMember(Name="rateLockExpirationTimeZone", EmitDefaultValue=false)]
		public string RateLockExpirationTimeZone { get; set; }

		[DataMember(Name="reasonChangedCircumstanceFlags", EmitDefaultValue=false)]
		public string ReasonChangedCircumstanceFlags { get; set; }

		[DataMember(Name="reasonDelayedSettlement", EmitDefaultValue=false)]
		public bool? ReasonDelayedSettlement { get; set; }

		[DataMember(Name="reasonEligibility", EmitDefaultValue=false)]
		public bool? ReasonEligibility { get; set; }

		[DataMember(Name="reasonExpiration", EmitDefaultValue=false)]
		public bool? ReasonExpiration { get; set; }

		[DataMember(Name="reasonInterestRate", EmitDefaultValue=false)]
		public bool? ReasonInterestRate { get; set; }

		[DataMember(Name="reasonOther", EmitDefaultValue=false)]
		public bool? ReasonOther { get; set; }

		[DataMember(Name="reasonOtherDescription", EmitDefaultValue=false)]
		public string ReasonOtherDescription { get; set; }

		[DataMember(Name="reasonRevisions", EmitDefaultValue=false)]
		public bool? ReasonRevisions { get; set; }

		[DataMember(Name="reasonSettlementCharges", EmitDefaultValue=false)]
		public bool? ReasonSettlementCharges { get; set; }

		[DataMember(Name="totalEstimatedCashClose", EmitDefaultValue=false)]
		public double? TotalEstimatedCashClose { get; set; }

		[DataMember(Name="yearsToRecast", EmitDefaultValue=false)]
		public int? YearsToRecast { get; set; }

		[DataMember(Name = "interestRateAdjTermLabel", EmitDefaultValue = false)]
		public string InterestRateAdjTermLabel { get; set; }

	}
}