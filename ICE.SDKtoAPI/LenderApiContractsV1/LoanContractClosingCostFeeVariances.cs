using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostFeeVariances
	{
		[DataMember(Name = "cd")]
		public decimal? CD { get; set; } //= 0.00M;

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="feeVarianceChargeIndex")]
		public int? FeeVarianceChargeIndex { get; set; }

		[DataMember(Name="feeVarianceFeeType")]
		public string FeeVarianceFeeType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name = "initialLE")]
		public decimal? InitialLE { get; set; } //= 0.00M;

		[DataMember(Name = "itemization")]
		public decimal? Itemization { get; set; } //= 0.00M;

		[DataMember(Name = "le")]
		public decimal? LE { get; set; } //= 0.00M;

		[DataMember(Name="line")]
		public string Line { get; set; }

	}
}