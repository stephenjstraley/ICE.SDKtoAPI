using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractNonVols
	{
		[DataMember(Name="adjustmentAmount")]
		public decimal? AdjustmentAmount { get; set; }

		[DataMember(Name="adjustmentDescription")]
		public string AdjustmentDescription { get; set; }

		[DataMember(Name="adjustmentOtherDescription")]
		public string AdjustmentOtherDescription { get; set; }

		[DataMember(Name="adjustmentType")]
		public string AdjustmentType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="includedIndicator")]
		public bool? IncludedIndicator { get; set; }

		[DataMember(Name="nonVolId")]
		public string NonVolId { get; set; }

		[DataMember(Name="nonVolIndex")]
		public int? NonVolIndex { get; set; }

		[DataMember(Name="paidBy")]
		public string PaidBy { get; set; }

		[DataMember(Name="paidTo")]
		public string PaidTo { get; set; }

		[DataMember(Name="pOCIndicator")]
		public bool? POCIndicator { get; set; }

		[DataMember(Name="principalCureAddendum")]
		public string PrincipalCureAddendum { get; set; }

	}
}