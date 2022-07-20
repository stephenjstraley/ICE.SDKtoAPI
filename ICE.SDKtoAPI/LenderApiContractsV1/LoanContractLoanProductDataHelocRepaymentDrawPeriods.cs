using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataHelocRepaymentDrawPeriods
	{
		[DataMember(Name="apr")]
		public decimal? Apr { get; set; }

		[DataMember(Name="drawIndicator")]
		public bool? DrawIndicator { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="indexRatePercent")]
		public decimal? IndexRatePercent { get; set; }

		[DataMember(Name="marginRatePercent")]
		public decimal? MarginRatePercent { get; set; }

		[DataMember(Name="minimumMonthlyPaymentAmount")]
		public decimal? MinimumMonthlyPaymentAmount { get; set; }

		[DataMember(Name="year")]
		public int? Year { get; set; }

	}
}