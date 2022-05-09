using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure4
	{
		[DataMember(Name="demandFeature", EmitDefaultValue=false)]
		public string DemandFeature { get; set; }

		[DataMember(Name="escrowedPropertyCostsBasis", EmitDefaultValue=false)]
		public string EscrowedPropertyCostsBasis { get; set; }

		[DataMember(Name="escrowIndicator", EmitDefaultValue=false)]
		public bool? EscrowIndicator { get; set; }

		[DataMember(Name="estimatedPropertyCosts", EmitDefaultValue=false)]
		public double? EstimatedPropertyCosts { get; set; }

		[DataMember(Name="firstChangeAmt", EmitDefaultValue=false)]
		public string FirstChangeAmt { get; set; }

		[DataMember(Name="firstChangeMaxAmt", EmitDefaultValue=false)]
		public double? FirstChangeMaxAmt { get; set; }

		[DataMember(Name="firstChangeMinAmt", EmitDefaultValue=false)]
		public double? FirstChangeMinAmt { get; set; }

		[DataMember(Name="firstChangePayment", EmitDefaultValue=false)]
		public string FirstChangePayment { get; set; }

		[DataMember(Name="hOADuesIsEscrow", EmitDefaultValue=false)]
		public bool? HOADuesIsEscrow { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="ignoreARMAdj", EmitDefaultValue=false)]
		public bool? IgnoreARMAdj { get; set; }

		[DataMember(Name="initialEscrowPayment", EmitDefaultValue=false)]
		public double? InitialEscrowPayment { get; set; }

		[DataMember(Name="interestOnlyPaymentMonths", EmitDefaultValue=false)]
		public int? InterestOnlyPaymentMonths { get; set; }

		[DataMember(Name="interestOnlyPayments", EmitDefaultValue=false)]
		public bool? InterestOnlyPayments { get; set; }

		[DataMember(Name="interestRateAdjustments", EmitDefaultValue=false)]
		public int? InterestRateAdjustments { get; set; }

		[DataMember(Name="lender", EmitDefaultValue=false)]
		public bool? Lender { get; set; }

		[DataMember(Name="maximumARMPaymentAmount", EmitDefaultValue=false)]
		public int? MaximumARMPaymentAmount { get; set; }

		[DataMember(Name="maximumARMPaymentMonthReached", EmitDefaultValue=false)]
		public int? MaximumARMPaymentMonthReached { get; set; }

		[DataMember(Name="maximumPaymentAmt", EmitDefaultValue=false)]
		public string MaximumPaymentAmt { get; set; }

		[DataMember(Name="maxPayment", EmitDefaultValue=false)]
		public string MaxPayment { get; set; }

		[DataMember(Name="maxPaymentAmt", EmitDefaultValue=false)]
		public double? MaxPaymentAmt { get; set; }

		[DataMember(Name="monthlyEscrowPayment", EmitDefaultValue=false)]
		public double? MonthlyEscrowPayment { get; set; }

		[DataMember(Name="negativeAmortization", EmitDefaultValue=false)]
		public string NegativeAmortization { get; set; }

		[DataMember(Name="nonEscrowedPropertyCosts1YearConsummation", EmitDefaultValue=false)]
		public double? NonEscrowedPropertyCosts1YearConsummation { get; set; }

		[DataMember(Name="other1", EmitDefaultValue=false)]
		public bool? Other1 { get; set; }

		[DataMember(Name="other2", EmitDefaultValue=false)]
		public bool? Other2 { get; set; }

		[DataMember(Name="other3", EmitDefaultValue=false)]
		public bool? Other3 { get; set; }

		[DataMember(Name="partialPayment", EmitDefaultValue=false)]
		public string PartialPayment { get; set; }

		[DataMember(Name="partialPaymentHoldUntilComplete", EmitDefaultValue=false)]
		public string PartialPaymentHoldUntilComplete { get; set; }

		[DataMember(Name="partialPaymentNone", EmitDefaultValue=false)]
		public string PartialPaymentNone { get; set; }

		[DataMember(Name="seasonalPaymentFromYr", EmitDefaultValue=false)]
		public string SeasonalPaymentFromYr { get; set; }

		[DataMember(Name="seasonalPayments", EmitDefaultValue=false)]
		public bool? SeasonalPayments { get; set; }

		[DataMember(Name="stepPayment", EmitDefaultValue=false)]
		public int? StepPayment { get; set; }

		[DataMember(Name="stepPayments", EmitDefaultValue=false)]
		public bool? StepPayments { get; set; }

		[DataMember(Name="stepRateFirstChange", EmitDefaultValue=false)]
		public double? StepRateFirstChange { get; set; }

		[DataMember(Name="subsequentChanges", EmitDefaultValue=false)]
		public string SubsequentChanges { get; set; }

		[DataMember(Name="totalDisbursed1YearConsummation", EmitDefaultValue=false)]
		public double? TotalDisbursed1YearConsummation { get; set; }

	}
}