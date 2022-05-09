using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFannieMae
	{
		[DataMember(Name="caseIDAssignedByUCDIndicator", EmitDefaultValue=false)]
		public bool? CaseIDAssignedByUCDIndicator { get; set; }

		[DataMember(Name="cltv", EmitDefaultValue=false)]
		public double? Cltv { get; set; }

		[DataMember(Name="collateralUnderwriterScore", EmitDefaultValue=false)]
		public string CollateralUnderwriterScore { get; set; }

		[DataMember(Name="community2ndRepaymentStructure", EmitDefaultValue=false)]
		public string Community2ndRepaymentStructure { get; set; }

		[DataMember(Name="communityLending", EmitDefaultValue=false)]
		public bool? CommunityLending { get; set; }

		[DataMember(Name="correspondentAssignmentID", EmitDefaultValue=false)]
		public string CorrespondentAssignmentID { get; set; }

		[DataMember(Name="duVersion", EmitDefaultValue=false)]
		public string DuVersion { get; set; }

		[DataMember(Name="eCStatus1003", EmitDefaultValue=false)]
		public string ECStatus1003 { get; set; }

		[DataMember(Name="hcltv", EmitDefaultValue=false)]
		public double? Hcltv { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="interestedPartyContribution", EmitDefaultValue=false)]
		public double? InterestedPartyContribution { get; set; }

		[DataMember(Name="ltv", EmitDefaultValue=false)]
		public double? Ltv { get; set; }

		[DataMember(Name="mornetPlusCaseFileId", EmitDefaultValue=false)]
		public string MornetPlusCaseFileId { get; set; }

		[DataMember(Name="propertyInspectionWaiverMessage", EmitDefaultValue=false)]
		public string PropertyInspectionWaiverMessage { get; set; }

		[DataMember(Name="startUpMortgage", EmitDefaultValue=false)]
		public bool? StartUpMortgage { get; set; }

		[DataMember(Name="uCDCollectionStatus", EmitDefaultValue=false)]
		public string UCDCollectionStatus { get; set; }

		[DataMember(Name="uCDPStatus", EmitDefaultValue=false)]
		public string UCDPStatus { get; set; }

		[DataMember(Name="uLDDECStatus", EmitDefaultValue=false)]
		public string ULDDECStatus { get; set; }

	}
}