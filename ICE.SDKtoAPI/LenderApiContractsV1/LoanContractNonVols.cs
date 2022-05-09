using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractNonVols
	{
		[DataMember(Name="adjustmentAmount", EmitDefaultValue=false)]
		public double? AdjustmentAmount { get; set; }

		[DataMember(Name="adjustmentDescription", EmitDefaultValue=false)]
		public string AdjustmentDescription { get; set; }

		[DataMember(Name="adjustmentOtherDescription", EmitDefaultValue=false)]
		public string AdjustmentOtherDescription { get; set; }

		[DataMember(Name="adjustmentType", EmitDefaultValue=false)]
		public string AdjustmentType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="includedIndicator", EmitDefaultValue=false)]
		public bool? IncludedIndicator { get; set; }

		[DataMember(Name="nonVolId", EmitDefaultValue=false)]
		public string NonVolId { get; set; }

		[DataMember(Name="nonVolIndex", EmitDefaultValue=false)]
		public int? NonVolIndex { get; set; }

		[DataMember(Name="paidBy", EmitDefaultValue=false)]
		public string PaidBy { get; set; }

		[DataMember(Name="paidTo", EmitDefaultValue=false)]
		public string PaidTo { get; set; }

		[DataMember(Name="pOCIndicator", EmitDefaultValue=false)]
		public bool? POCIndicator { get; set; }

		[DataMember(Name="principalCureAddendum", EmitDefaultValue=false)]
		public string PrincipalCureAddendum { get; set; }

	}
}