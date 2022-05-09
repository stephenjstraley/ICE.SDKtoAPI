using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostFeeVariances
	{
		[DataMember(Name="cD", EmitDefaultValue=false)]
		public double? CD { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="feeVarianceChargeIndex", EmitDefaultValue=false)]
		public int? FeeVarianceChargeIndex { get; set; }

		[DataMember(Name="feeVarianceFeeType", EmitDefaultValue=false)]
		public string FeeVarianceFeeType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialLE", EmitDefaultValue=false)]
		public double? InitialLE { get; set; }

		[DataMember(Name="itemization", EmitDefaultValue=false)]
		public double? Itemization { get; set; }

		[DataMember(Name="lE", EmitDefaultValue=false)]
		public double? LE { get; set; }

		[DataMember(Name="line", EmitDefaultValue=false)]
		public string Line { get; set; }

	}
}