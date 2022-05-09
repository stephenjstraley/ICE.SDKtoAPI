using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure3UCDDetails
	{
		[DataMember(Name="feeAccountType", EmitDefaultValue=false)]
		public string FeeAccountType { get; set; }

		[DataMember(Name="feeAmount", EmitDefaultValue=false)]
		public double? FeeAmount { get; set; }

		[DataMember(Name="feeDateFrom", EmitDefaultValue=false)]
		public DateTime? FeeDateFrom { get; set; }

		[DataMember(Name="feeDateTo", EmitDefaultValue=false)]
		public DateTime? FeeDateTo { get; set; }

		[DataMember(Name="feeDesc", EmitDefaultValue=false)]
		public string FeeDesc { get; set; }

		[DataMember(Name="feeIndex", EmitDefaultValue=false)]
		public int? FeeIndex { get; set; }

		[DataMember(Name="feePaidBy", EmitDefaultValue=false)]
		public string FeePaidBy { get; set; }

		[DataMember(Name="feePaidTo", EmitDefaultValue=false)]
		public string FeePaidTo { get; set; }

		[DataMember(Name="feePOC", EmitDefaultValue=false)]
		public bool? FeePOC { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

		[DataMember(Name="section", EmitDefaultValue=false)]
		public string Section { get; set; }

	}
}