using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractCdReason
	{
		[DataMember(Name="is24HourAdvancePreview", EmitDefaultValue=false)]
		public bool? Is24HourAdvancePreview { get; set; }

		[DataMember(Name="isChangedCircumstanceEligibility", EmitDefaultValue=false)]
		public bool? IsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="isChangeInAPR", EmitDefaultValue=false)]
		public bool? IsChangeInAPR { get; set; }

		[DataMember(Name="isChangeInLoanProduct", EmitDefaultValue=false)]
		public bool? IsChangeInLoanProduct { get; set; }

		[DataMember(Name="isChangeInSettlementCharges", EmitDefaultValue=false)]
		public bool? IsChangeInSettlementCharges { get; set; }

		[DataMember(Name="isClericalErrorCorrection", EmitDefaultValue=false)]
		public bool? IsClericalErrorCorrection { get; set; }

		[DataMember(Name="isInterestRateDependentCharges", EmitDefaultValue=false)]
		public bool? IsInterestRateDependentCharges { get; set; }

		[DataMember(Name="isOther", EmitDefaultValue=false)]
		public bool? IsOther { get; set; }

		[DataMember(Name="isPrepaymentPenaltyAdded", EmitDefaultValue=false)]
		public bool? IsPrepaymentPenaltyAdded { get; set; }

		[DataMember(Name="isRevisionsRequestedByConsumer", EmitDefaultValue=false)]
		public bool? IsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="isToleranceCure", EmitDefaultValue=false)]
		public bool? IsToleranceCure { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

	}
}