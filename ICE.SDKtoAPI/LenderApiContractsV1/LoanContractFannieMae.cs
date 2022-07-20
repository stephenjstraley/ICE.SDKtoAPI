using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFannieMae
	{
		[DataMember(Name="caseIDAssignedByUCDIndicator")]
		public bool? CaseIDAssignedByUCDIndicator { get; set; }

		[DataMember(Name="cltv")]
		public decimal? Cltv { get; set; }

		[DataMember(Name="collateralUnderwriterScore")]
		public string CollateralUnderwriterScore { get; set; }

		[DataMember(Name="community2ndRepaymentStructure")]
		public string Community2ndRepaymentStructure { get; set; }

		[DataMember(Name="communityLending")]
		public bool? CommunityLending { get; set; }

		[DataMember(Name="correspondentAssignmentID")]
		public string CorrespondentAssignmentID { get; set; }

		[DataMember(Name="duVersion")]
		public string DuVersion { get; set; }

		[DataMember(Name="eCStatus1003")]
		public string ECStatus1003 { get; set; }

		[DataMember(Name="hcltv")]
		public decimal? Hcltv { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="interestedPartyContribution")]
		public decimal? InterestedPartyContribution { get; set; }

		[DataMember(Name="ltv")]
		public decimal? Ltv { get; set; }

		[DataMember(Name="mornetPlusCaseFileId")]
		public string MornetPlusCaseFileId { get; set; }

		[DataMember(Name="propertyInspectionWaiverMessage")]
		public string PropertyInspectionWaiverMessage { get; set; }

		[DataMember(Name="startUpMortgage")]
		public bool? StartUpMortgage { get; set; }

		[DataMember(Name="uCDCollectionStatus")]
		public string UCDCollectionStatus { get; set; }

		[DataMember(Name="uCDPStatus")]
		public string UCDPStatus { get; set; }

		[DataMember(Name="uLDDECStatus")]
		public string ULDDECStatus { get; set; }

	}
}