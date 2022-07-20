using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLeReason
	{
		[DataMember(Name="isChangedCircumstanceEligibility")]
		public bool? IsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="isChangedCircumstanceSettlementCharges")]
		public bool? IsChangedCircumstanceSettlementCharges { get; set; }

		[DataMember(Name="isDelayedSettlementOnConstructionLoans")]
		public bool? IsDelayedSettlementOnConstructionLoans { get; set; }

		[DataMember(Name="isExpiration")]
		public bool? IsExpiration { get; set; }

		[DataMember(Name="isInterestRateDependentCharges")]
		public bool? IsInterestRateDependentCharges { get; set; }

		[DataMember(Name="isOther")]
		public bool? IsOther { get; set; }

		[DataMember(Name="isRevisionsRequestedByConsumer")]
		public bool? IsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="otherDescription")]
		public string OtherDescription { get; set; }

	}
}