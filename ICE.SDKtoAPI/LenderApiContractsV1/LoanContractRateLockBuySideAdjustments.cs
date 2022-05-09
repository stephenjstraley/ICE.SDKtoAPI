using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockBuySideAdjustments
	{
		[DataMember(Name="adjustmentType", EmitDefaultValue=false)]
		public string AdjustmentType { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="priceAdjustmentType", EmitDefaultValue=false)]
		public string PriceAdjustmentType { get; set; }

		[DataMember(Name="rate", EmitDefaultValue=false)]
		public double? Rate { get; set; }

		[DataMember(Name="rateLockAdjustmentType", EmitDefaultValue=false)]
		public string RateLockAdjustmentType { get; set; }

	}
}