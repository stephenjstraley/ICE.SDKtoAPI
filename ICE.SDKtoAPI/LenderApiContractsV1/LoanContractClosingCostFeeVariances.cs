using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostFeeVariances
	{
		[DataMember(Name = "cd", EmitDefaultValue = false)]
		public decimal? CD { get; set; } //= 0.00M;

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="feeVarianceChargeIndex", EmitDefaultValue=false)]
		public int? FeeVarianceChargeIndex { get; set; }

		[DataMember(Name="feeVarianceFeeType", EmitDefaultValue=false)]
		public string FeeVarianceFeeType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name = "initialLE", EmitDefaultValue = false)]
		public decimal? InitialLE { get; set; } //= 0.00M;

		[DataMember(Name = "itemization", EmitDefaultValue = false)]
		public decimal? Itemization { get; set; } //= 0.00M;

		[DataMember(Name = "le", EmitDefaultValue = false)]
		public decimal? LE { get; set; } //= 0.00M;

		[DataMember(Name="line", EmitDefaultValue=false)]
		public string Line { get; set; }

	}
}