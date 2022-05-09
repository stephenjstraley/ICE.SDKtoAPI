using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLeReason
	{
		[DataMember(Name="isChangedCircumstanceEligibility", EmitDefaultValue=false)]
		public bool? IsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="isChangedCircumstanceSettlementCharges", EmitDefaultValue=false)]
		public bool? IsChangedCircumstanceSettlementCharges { get; set; }

		[DataMember(Name="isDelayedSettlementOnConstructionLoans", EmitDefaultValue=false)]
		public bool? IsDelayedSettlementOnConstructionLoans { get; set; }

		[DataMember(Name="isExpiration", EmitDefaultValue=false)]
		public bool? IsExpiration { get; set; }

		[DataMember(Name="isInterestRateDependentCharges", EmitDefaultValue=false)]
		public bool? IsInterestRateDependentCharges { get; set; }

		[DataMember(Name="isOther", EmitDefaultValue=false)]
		public bool? IsOther { get; set; }

		[DataMember(Name="isRevisionsRequestedByConsumer", EmitDefaultValue=false)]
		public bool? IsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

	}
}