using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate1
	{
		[DataMember(Name="adjustsTermType")]
		public string AdjustsTermType { get; set; }

		[DataMember(Name="changedCircumstanceComments")]
		public string ChangedCircumstanceComments { get; set; }

		[DataMember(Name="closingCostEstimateExpirationDate")]
		public DateTime? ClosingCostEstimateExpirationDate { get; set; }

		[DataMember(Name="closingCostEstimateExpirationDateUI")]
		public string ClosingCostEstimateExpirationDateUI { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTime")]
		public string ClosingCostEstimateExpirationTime { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeUI")]
		public string ClosingCostEstimateExpirationTimeUI { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeZone")]
		public string ClosingCostEstimateExpirationTimeZone { get; set; }

		[DataMember(Name="closingCostEstimateExpirationTimeZoneUI")]
		public string ClosingCostEstimateExpirationTimeZoneUI { get; set; }

		[DataMember(Name="conversionBegin")]
		public string ConversionBegin { get; set; }

		[DataMember(Name="conversionEnd")]
		public string ConversionEnd { get; set; }

		[DataMember(Name="disclosureBy")]
		public string DisclosureBy { get; set; }

		[DataMember(Name="disclosureClosingCostExpDate")]
		public DateTime? DisclosureClosingCostExpDate { get; set; }

		[DataMember(Name="disclosureClosingCostExpTime")]
		public string DisclosureClosingCostExpTime { get; set; }

		[DataMember(Name="disclosureClosingCostExpTimeZone")]
		public string DisclosureClosingCostExpTimeZone { get; set; }

		[DataMember(Name="disclosureComments")]
		public string DisclosureComments { get; set; }

		[DataMember(Name="disclosureLastSentDate")]
		public DateTime? DisclosureLastSentDate { get; set; }

		[DataMember(Name="disclosureReceivedDate")]
		public DateTime? DisclosureReceivedDate { get; set; }

		[DataMember(Name="disclosureSentMethod")]
		public string DisclosureSentMethod { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessments")]
		public decimal? EstimatedTaxesInsuranceAssessments { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessmentsUI")]
		public string EstimatedTaxesInsuranceAssessmentsUI { get; set; }

		[DataMember(Name="highestMonthlyPI")]
		public decimal? HighestMonthlyPI { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="inEscrowHomeownerInsurance")]
		public string InEscrowHomeownerInsurance { get; set; }

		[DataMember(Name="inEscrowOther")]
		public string InEscrowOther { get; set; }

		[DataMember(Name="inEscrowPropertyTaxes")]
		public string InEscrowPropertyTaxes { get; set; }

		[DataMember(Name="initialMonthlyPaymentFor10000Loan")]
		public decimal? InitialMonthlyPaymentFor10000Loan { get; set; }

		[DataMember(Name="initialMonthlyPaymentFor60000Loan")]
		public decimal? InitialMonthlyPaymentFor60000Loan { get; set; }

		[DataMember(Name="interestRateAdjustsEveryYears")]
		public string InterestRateAdjustsEveryYears { get; set; }

		[DataMember(Name="interestRateAdjustsInYear")]
		public int? InterestRateAdjustsInYear { get; set; }

		[DataMember(Name="interestRateAdjustsStartingInType")]
		public string InterestRateAdjustsStartingInType { get; set; }

		[DataMember(Name="interestRateAfterAdjustment")]
		public int? InterestRateAfterAdjustment { get; set; }

		[DataMember(Name="interestRateCanGoGoes")]
		public string InterestRateCanGoGoes { get; set; }

		[DataMember(Name="lEDateIssued")]
		public DateTime? LEDateIssued { get; set; }

		[DataMember(Name="loanAmountCanGoGoes")]
		public string LoanAmountCanGoGoes { get; set; }

		[DataMember(Name="loanAmountCanIncreaseOrIncreases")]
		public string LoanAmountCanIncreaseOrIncreases { get; set; }

		[DataMember(Name="loanProduct")]
		public string LoanProduct { get; set; }

		[DataMember(Name="loanPurpose")]
		public string LoanPurpose { get; set; }

		[DataMember(Name="loanTermMonths")]
		public int? LoanTermMonths { get; set; }

		[DataMember(Name="loanTermYears")]
		public int? LoanTermYears { get; set; }

		[DataMember(Name="maximumMonthlyPaymentFor10000Loan")]
		public decimal? MaximumMonthlyPaymentFor10000Loan { get; set; }

		[DataMember(Name="maximumPaymentMonth")]
		public int? MaximumPaymentMonth { get; set; }

		[DataMember(Name="monthlyPIAdjustedInDateType")]
		public string MonthlyPIAdjustedInDateType { get; set; }

		[DataMember(Name="monthlyPIAdjustsEveryYears")]
		public string MonthlyPIAdjustsEveryYears { get; set; }

		[DataMember(Name="monthlyPIAdjustsInYear")]
		public int? MonthlyPIAdjustsInYear { get; set; }

		[DataMember(Name="monthlyPIAdjustsStartingInType")]
		public string MonthlyPIAdjustsStartingInType { get; set; }

		[DataMember(Name="monthlyPIAdjustsTermType")]
		public string MonthlyPIAdjustsTermType { get; set; }

		[DataMember(Name="monthlyPIAfterAdjustment")]
		public int? MonthlyPIAfterAdjustment { get; set; }

		[DataMember(Name="monthlyPICanGoGoes")]
		public string MonthlyPICanGoGoes { get; set; }

		[DataMember(Name="monthlyPIInterestOnlyDateType")]
		public string MonthlyPIInterestOnlyDateType { get; set; }

		[DataMember(Name="monthlyPIInterestOnlyUntilYear")]
		public int? MonthlyPIInterestOnlyUntilYear { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmount")]
		public int? PPC1EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmountUI")]
		public string PPC1EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC1InterestOnly")]
		public bool? PPC1InterestOnly { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPayment")]
		public decimal? PPC1MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPaymentUI")]
		public string PPC1MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MaximumPIPayment")]
		public decimal? PPC1MaximumPIPayment { get; set; }

		[DataMember(Name="pPC1MaximumPIPaymentUI")]
		public string PPC1MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1MIAmount")]
		public int? PPC1MIAmount { get; set; }

		[DataMember(Name="pPC1MIAmountUI")]
		public string PPC1MIAmountUI { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPayment")]
		public int? PPC1MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPaymentUI")]
		public string PPC1MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MinimumPIPayment")]
		public decimal? PPC1MinimumPIPayment { get; set; }

		[DataMember(Name="pPC1MinimumPIPaymentUI")]
		public string PPC1MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1Year")]
		public int? PPC1Year { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmount")]
		public int? PPC2EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmountUI")]
		public string PPC2EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC2InterestOnly")]
		public bool? PPC2InterestOnly { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPayment")]
		public decimal? PPC2MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPaymentUI")]
		public string PPC2MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MaximumPIPayment")]
		public decimal? PPC2MaximumPIPayment { get; set; }

		[DataMember(Name="pPC2MaximumPIPaymentUI")]
		public string PPC2MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2MIAmount")]
		public int? PPC2MIAmount { get; set; }

		[DataMember(Name="pPC2MIAmountUI")]
		public string PPC2MIAmountUI { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPayment")]
		public int? PPC2MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPaymentUI")]
		public string PPC2MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MinimumPIPayment")]
		public decimal? PPC2MinimumPIPayment { get; set; }

		[DataMember(Name="pPC2MinimumPIPaymentUI")]
		public string PPC2MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2YearFrom")]
		public int? PPC2YearFrom { get; set; }

		[DataMember(Name="pPC2YearTo")]
		public int? PPC2YearTo { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmount")]
		public int? PPC3EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmountUI")]
		public string PPC3EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC3InterestOnly")]
		public bool? PPC3InterestOnly { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPayment")]
		public decimal? PPC3MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPaymentUI")]
		public string PPC3MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MaximumPIPayment")]
		public decimal? PPC3MaximumPIPayment { get; set; }

		[DataMember(Name="pPC3MaximumPIPaymentUI")]
		public string PPC3MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3MIAmount")]
		public int? PPC3MIAmount { get; set; }

		[DataMember(Name="pPC3MIAmountUI")]
		public string PPC3MIAmountUI { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPayment")]
		public int? PPC3MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPaymentUI")]
		public string PPC3MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MinimumPIPayment")]
		public decimal? PPC3MinimumPIPayment { get; set; }

		[DataMember(Name="pPC3MinimumPIPaymentUI")]
		public string PPC3MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3YearFrom")]
		public int? PPC3YearFrom { get; set; }

		[DataMember(Name="pPC3YearTo")]
		public int? PPC3YearTo { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmount")]
		public int? PPC4EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmountUI")]
		public string PPC4EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC4InterestOnly")]
		public bool? PPC4InterestOnly { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPayment")]
		public decimal? PPC4MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPaymentUI")]
		public string PPC4MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MaximumPIPayment")]
		public decimal? PPC4MaximumPIPayment { get; set; }

		[DataMember(Name="pPC4MaximumPIPaymentUI")]
		public string PPC4MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4MIAmount")]
		public int? PPC4MIAmount { get; set; }

		[DataMember(Name="pPC4MIAmountUI")]
		public string PPC4MIAmountUI { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPayment")]
		public int? PPC4MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPaymentUI")]
		public string PPC4MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MinimumPIPayment")]
		public decimal? PPC4MinimumPIPayment { get; set; }

		[DataMember(Name="pPC4MinimumPIPaymentUI")]
		public string PPC4MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4YearFrom")]
		public int? PPC4YearFrom { get; set; }

		[DataMember(Name="pPC4YearTo")]
		public int? PPC4YearTo { get; set; }

		[DataMember(Name="pPEstimatedEscrowIndicator")]
		public bool? PPEstimatedEscrowIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffDuringYear")]
		public int? PrepaymentPenaltyPayOffDuringYear { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffInDateType")]
		public string PrepaymentPenaltyPayOffInDateType { get; set; }

		[DataMember(Name="prepaymentPenaltyPayOffInFirstYear")]
		public string PrepaymentPenaltyPayOffInFirstYear { get; set; }

		[DataMember(Name="rangePaymentIndicatorC1")]
		public bool? RangePaymentIndicatorC1 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC2")]
		public bool? RangePaymentIndicatorC2 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC3")]
		public bool? RangePaymentIndicatorC3 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC4")]
		public bool? RangePaymentIndicatorC4 { get; set; }

		[DataMember(Name="rateLockExpirationTime")]
		public string RateLockExpirationTime { get; set; }

		[DataMember(Name="rateLockExpirationTimeZone")]
		public string RateLockExpirationTimeZone { get; set; }

		[DataMember(Name="reasonChangedCircumstanceFlags")]
		public string ReasonChangedCircumstanceFlags { get; set; }

		[DataMember(Name="reasonDelayedSettlement")]
		public bool? ReasonDelayedSettlement { get; set; }

		[DataMember(Name="reasonEligibility")]
		public bool? ReasonEligibility { get; set; }

		[DataMember(Name="reasonExpiration")]
		public bool? ReasonExpiration { get; set; }

		[DataMember(Name="reasonInterestRate")]
		public bool? ReasonInterestRate { get; set; }

		[DataMember(Name="reasonOther")]
		public bool? ReasonOther { get; set; }

		[DataMember(Name="reasonOtherDescription")]
		public string ReasonOtherDescription { get; set; }

		[DataMember(Name="reasonRevisions")]
		public bool? ReasonRevisions { get; set; }

		[DataMember(Name="reasonSettlementCharges")]
		public bool? ReasonSettlementCharges { get; set; }

		[DataMember(Name="totalEstimatedCashClose")]
		public decimal? TotalEstimatedCashClose { get; set; }

		[DataMember(Name="yearsToRecast")]
		public int? YearsToRecast { get; set; }

		[DataMember(Name = "interestRateAdjTermLabel")]
		public string InterestRateAdjTermLabel { get; set; }

	}
}