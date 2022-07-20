using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataBuydowns
	{
		[DataMember(Name="buydownIndex")]
		public int? BuydownIndex { get; set; }

		[DataMember(Name="buydownRatePercent")]
		public decimal? BuydownRatePercent { get; set; }

		[DataMember(Name="changeFrequencyMonthsCount")]
		public int? ChangeFrequencyMonthsCount { get; set; }

		[DataMember(Name="durationMonthsCount")]
		public int? DurationMonthsCount { get; set; }

		[DataMember(Name="fundBalanceAmount")]
		public decimal? FundBalanceAmount { get; set; }

		[DataMember(Name="fundTotalAmount")]
		public decimal? FundTotalAmount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="increaseRatePercent")]
		public decimal? IncreaseRatePercent { get; set; }

		[DataMember(Name="remainingMonthsCount")]
		public int? RemainingMonthsCount { get; set; }

		[DataMember(Name="subsidyAmount")]
		public decimal? SubsidyAmount { get; set; }

	}
}