using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfePayments
	{
		[DataMember(Name="fixedRate", EmitDefaultValue=false)]
		public double? FixedRate { get; set; }

		[DataMember(Name="gfePaymentIndex", EmitDefaultValue=false)]
		public int? GfePaymentIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexRate", EmitDefaultValue=false)]
		public double? IndexRate { get; set; }

		[DataMember(Name="isBalanceReduced", EmitDefaultValue=false)]
		public string IsBalanceReduced { get; set; }

		[DataMember(Name="loanTypeExplanation", EmitDefaultValue=false)]
		public string LoanTypeExplanation { get; set; }

		[DataMember(Name="marginRate", EmitDefaultValue=false)]
		public double? MarginRate { get; set; }

		[DataMember(Name="maximumDifference", EmitDefaultValue=false)]
		public double? MaximumDifference { get; set; }

		[DataMember(Name="maximumRate", EmitDefaultValue=false)]
		public double? MaximumRate { get; set; }

		[DataMember(Name="minimumDifference", EmitDefaultValue=false)]
		public double? MinimumDifference { get; set; }

		[DataMember(Name="minimumMonthlyPayment", EmitDefaultValue=false)]
		public double? MinimumMonthlyPayment { get; set; }

		[DataMember(Name="monthlyPaymentYear1", EmitDefaultValue=false)]
		public double? MonthlyPaymentYear1 { get; set; }

		[DataMember(Name="monthlyPaymentYear6", EmitDefaultValue=false)]
		public double? MonthlyPaymentYear6 { get; set; }

		[DataMember(Name="monthlyPaymentYear6Change", EmitDefaultValue=false)]
		public double? MonthlyPaymentYear6Change { get; set; }

		[DataMember(Name="monthlyPaymentYear6MaxChange", EmitDefaultValue=false)]
		public double? MonthlyPaymentYear6MaxChange { get; set; }

		[DataMember(Name="notOfferedIndicator", EmitDefaultValue=false)]
		public bool? NotOfferedIndicator { get; set; }

		[DataMember(Name="owedAfter5Years", EmitDefaultValue=false)]
		public double? OwedAfter5Years { get; set; }

		[DataMember(Name="rateInMonth2", EmitDefaultValue=false)]
		public double? RateInMonth2 { get; set; }

		[DataMember(Name="reducedLoanBalance", EmitDefaultValue=false)]
		public double? ReducedLoanBalance { get; set; }

		[DataMember(Name="reducedStatus", EmitDefaultValue=false)]
		public string ReducedStatus { get; set; }

	}
}