using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure4
	{
		[DataMember(Name="demandFeature")]
		public string DemandFeature { get; set; }

		[DataMember(Name="escrowedPropertyCostsBasis")]
		public string EscrowedPropertyCostsBasis { get; set; }

		[DataMember(Name="escrowIndicator")]
		public bool? EscrowIndicator { get; set; }

		[DataMember(Name="estimatedPropertyCosts")]
		public decimal? EstimatedPropertyCosts { get; set; }

		[DataMember(Name="firstChangeAmt")]
		public string FirstChangeAmt { get; set; }

		[DataMember(Name="firstChangeMaxAmt")]
		public decimal? FirstChangeMaxAmt { get; set; }

		[DataMember(Name="firstChangeMinAmt")]
		public decimal? FirstChangeMinAmt { get; set; }

		[DataMember(Name="firstChangePayment")]
		public string FirstChangePayment { get; set; }

		[DataMember(Name="hOADuesIsEscrow")]
		public bool? HOADuesIsEscrow { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="ignoreARMAdj")]
		public bool? IgnoreARMAdj { get; set; }

		[DataMember(Name="initialEscrowPayment")]
		public decimal? InitialEscrowPayment { get; set; }

		[DataMember(Name="interestOnlyPaymentMonths")]
		public int? InterestOnlyPaymentMonths { get; set; }

		[DataMember(Name="interestOnlyPayments")]
		public bool? InterestOnlyPayments { get; set; }

		[DataMember(Name="interestRateAdjustments")]
		public int? InterestRateAdjustments { get; set; }

		[DataMember(Name="lender")]
		public bool? Lender { get; set; }

		[DataMember(Name="maximumARMPaymentAmount")]
		public int? MaximumARMPaymentAmount { get; set; }

		[DataMember(Name="maximumARMPaymentMonthReached")]
		public int? MaximumARMPaymentMonthReached { get; set; }

		[DataMember(Name="maximumPaymentAmt")]
		public string MaximumPaymentAmt { get; set; }

		[DataMember(Name="maxPayment")]
		public string MaxPayment { get; set; }

		[DataMember(Name="maxPaymentAmt")]
		public decimal? MaxPaymentAmt { get; set; }

		[DataMember(Name="monthlyEscrowPayment")]
		public decimal? MonthlyEscrowPayment { get; set; }

		[DataMember(Name="negativeAmortization")]
		public string NegativeAmortization { get; set; }

		[DataMember(Name="nonEscrowedPropertyCosts1YearConsummation")]
		public decimal? NonEscrowedPropertyCosts1YearConsummation { get; set; }

		[DataMember(Name="other1")]
		public bool? Other1 { get; set; }

		[DataMember(Name="other2")]
		public bool? Other2 { get; set; }

		[DataMember(Name="other3")]
		public bool? Other3 { get; set; }

		[DataMember(Name="partialPayment")]
		public string PartialPayment { get; set; }

		[DataMember(Name="partialPaymentHoldUntilComplete")]
		public string PartialPaymentHoldUntilComplete { get; set; }

		[DataMember(Name="partialPaymentNone")]
		public string PartialPaymentNone { get; set; }

		[DataMember(Name="seasonalPaymentFromYr")]
		public string SeasonalPaymentFromYr { get; set; }

		[DataMember(Name="seasonalPayments")]
		public bool? SeasonalPayments { get; set; }

		[DataMember(Name="stepPayment")]
		public int? StepPayment { get; set; }

		[DataMember(Name="stepPayments")]
		public bool? StepPayments { get; set; }

		[DataMember(Name="stepRateFirstChange")]
		public decimal? StepRateFirstChange { get; set; }

		[DataMember(Name="subsequentChanges")]
		public string SubsequentChanges { get; set; }

		[DataMember(Name="totalDisbursed1YearConsummation")]
		public decimal? TotalDisbursed1YearConsummation { get; set; }

	}
}