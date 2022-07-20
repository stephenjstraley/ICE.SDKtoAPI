using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockBuySideAdjustments
	{
		[DataMember(Name="adjustmentType")]
		public string AdjustmentType { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="priceAdjustmentType")]
		public string PriceAdjustmentType { get; set; }

		[DataMember(Name="rate")]
		public decimal? Rate { get; set; }

		[DataMember(Name="rateLockAdjustmentType")]
		public string RateLockAdjustmentType { get; set; }

	}
}