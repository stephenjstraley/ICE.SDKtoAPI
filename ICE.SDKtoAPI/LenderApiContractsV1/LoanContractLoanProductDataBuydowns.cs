using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataBuydowns
	{
		[DataMember(Name="buydownIndex", EmitDefaultValue=false)]
		public int? BuydownIndex { get; set; }

		[DataMember(Name="buydownRatePercent", EmitDefaultValue=false)]
		public double? BuydownRatePercent { get; set; }

		[DataMember(Name="changeFrequencyMonthsCount", EmitDefaultValue=false)]
		public int? ChangeFrequencyMonthsCount { get; set; }

		[DataMember(Name="durationMonthsCount", EmitDefaultValue=false)]
		public int? DurationMonthsCount { get; set; }

		[DataMember(Name="fundBalanceAmount", EmitDefaultValue=false)]
		public double? FundBalanceAmount { get; set; }

		[DataMember(Name="fundTotalAmount", EmitDefaultValue=false)]
		public double? FundTotalAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="increaseRatePercent", EmitDefaultValue=false)]
		public double? IncreaseRatePercent { get; set; }

		[DataMember(Name="remainingMonthsCount", EmitDefaultValue=false)]
		public int? RemainingMonthsCount { get; set; }

		[DataMember(Name="subsidyAmount", EmitDefaultValue=false)]
		public double? SubsidyAmount { get; set; }

	}
}