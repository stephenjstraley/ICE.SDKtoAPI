using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfePayments
	{
		[DataMember(Name="fixedRate")]
		public decimal? FixedRate { get; set; }

		[DataMember(Name="gfePaymentIndex")]
		public int? GfePaymentIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="indexRate")]
		public decimal? IndexRate { get; set; }

		[DataMember(Name="isBalanceReduced")]
		public string IsBalanceReduced { get; set; }

		[DataMember(Name="loanTypeExplanation")]
		public string LoanTypeExplanation { get; set; }

		[DataMember(Name="marginRate")]
		public decimal? MarginRate { get; set; }

		[DataMember(Name="maximumDifference")]
		public decimal? MaximumDifference { get; set; }

		[DataMember(Name="maximumRate")]
		public decimal? MaximumRate { get; set; }

		[DataMember(Name="minimumDifference")]
		public decimal? MinimumDifference { get; set; }

		[DataMember(Name="minimumMonthlyPayment")]
		public decimal? MinimumMonthlyPayment { get; set; }

		[DataMember(Name="monthlyPaymentYear1")]
		public decimal? MonthlyPaymentYear1 { get; set; }

		[DataMember(Name="monthlyPaymentYear6")]
		public decimal? MonthlyPaymentYear6 { get; set; }

		[DataMember(Name="monthlyPaymentYear6Change")]
		public decimal? MonthlyPaymentYear6Change { get; set; }

		[DataMember(Name="monthlyPaymentYear6MaxChange")]
		public decimal? MonthlyPaymentYear6MaxChange { get; set; }

		[DataMember(Name="notOfferedIndicator")]
		public bool? NotOfferedIndicator { get; set; }

		[DataMember(Name="owedAfter5Years")]
		public decimal? OwedAfter5Years { get; set; }

		[DataMember(Name="rateInMonth2")]
		public decimal? RateInMonth2 { get; set; }

		[DataMember(Name="reducedLoanBalance")]
		public decimal? ReducedLoanBalance { get; set; }

		[DataMember(Name="reducedStatus")]
		public string ReducedStatus { get; set; }

	}
}