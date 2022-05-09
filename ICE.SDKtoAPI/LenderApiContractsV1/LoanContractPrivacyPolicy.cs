using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPrivacyPolicy
	{
		[DataMember(Name="additionalRightsDescription", EmitDefaultValue=false)]
		public string AdditionalRightsDescription { get; set; }

		[DataMember(Name="affiliateType", EmitDefaultValue=false)]
		public string AffiliateType { get; set; }

		[DataMember(Name="affiliateTypeExample1", EmitDefaultValue=false)]
		public string AffiliateTypeExample1 { get; set; }

		[DataMember(Name="affiliateTypeExample2", EmitDefaultValue=false)]
		public string AffiliateTypeExample2 { get; set; }

		[DataMember(Name="affiliateTypeExample3", EmitDefaultValue=false)]
		public string AffiliateTypeExample3 { get; set; }

		[DataMember(Name="alsoCollectFrom", EmitDefaultValue=false)]
		public string AlsoCollectFrom { get; set; }

		[DataMember(Name="daysToUse", EmitDefaultValue=false)]
		public int? DaysToUse { get; set; }

		[DataMember(Name="howToShare", EmitDefaultValue=false)]
		public string HowToShare { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="informationShare1", EmitDefaultValue=false)]
		public string InformationShare1 { get; set; }

		[DataMember(Name="informationShare2", EmitDefaultValue=false)]
		public string InformationShare2 { get; set; }

		[DataMember(Name="informationShare3", EmitDefaultValue=false)]
		public string InformationShare3 { get; set; }

		[DataMember(Name="informationShare4", EmitDefaultValue=false)]
		public string InformationShare4 { get; set; }

		[DataMember(Name="informationShare5", EmitDefaultValue=false)]
		public string InformationShare5 { get; set; }

		[DataMember(Name="informationShare6", EmitDefaultValue=false)]
		public string InformationShare6 { get; set; }

		[DataMember(Name="informationShare7", EmitDefaultValue=false)]
		public string InformationShare7 { get; set; }

		[DataMember(Name="informationTypesWeCollect1", EmitDefaultValue=false)]
		public string InformationTypesWeCollect1 { get; set; }

		[DataMember(Name="informationTypesWeCollect2", EmitDefaultValue=false)]
		public string InformationTypesWeCollect2 { get; set; }

		[DataMember(Name="informationTypesWeCollect3", EmitDefaultValue=false)]
		public string InformationTypesWeCollect3 { get; set; }

		[DataMember(Name="informationTypesWeCollect4", EmitDefaultValue=false)]
		public string InformationTypesWeCollect4 { get; set; }

		[DataMember(Name="informationTypesWeCollect5", EmitDefaultValue=false)]
		public string InformationTypesWeCollect5 { get; set; }

		[DataMember(Name="jointMarketType", EmitDefaultValue=false)]
		public string JointMarketType { get; set; }

		[DataMember(Name="jointMarketTypeExample1", EmitDefaultValue=false)]
		public string JointMarketTypeExample1 { get; set; }

		[DataMember(Name="limitSharing1", EmitDefaultValue=false)]
		public string LimitSharing1 { get; set; }

		[DataMember(Name="limitSharing2", EmitDefaultValue=false)]
		public string LimitSharing2 { get; set; }

		[DataMember(Name="limitSharing3", EmitDefaultValue=false)]
		public string LimitSharing3 { get; set; }

		[DataMember(Name="limitSharing4", EmitDefaultValue=false)]
		public string LimitSharing4 { get; set; }

		[DataMember(Name="limitSharing5", EmitDefaultValue=false)]
		public string LimitSharing5 { get; set; }

		[DataMember(Name="limitSharing6", EmitDefaultValue=false)]
		public string LimitSharing6 { get; set; }

		[DataMember(Name="limitSharing7", EmitDefaultValue=false)]
		public string LimitSharing7 { get; set; }

		[DataMember(Name="month", EmitDefaultValue=false)]
		public string Month { get; set; }

		[DataMember(Name="nonaffiliateType", EmitDefaultValue=false)]
		public string NonaffiliateType { get; set; }

		[DataMember(Name="nonaffiliateTypeExample1", EmitDefaultValue=false)]
		public string NonaffiliateTypeExample1 { get; set; }

		[DataMember(Name="notesForProtectPrivacy", EmitDefaultValue=false)]
		public string NotesForProtectPrivacy { get; set; }

		[DataMember(Name="otherInformation", EmitDefaultValue=false)]
		public string OtherInformation { get; set; }

		[DataMember(Name="phoneForQuestion", EmitDefaultValue=false)]
		public string PhoneForQuestion { get; set; }

		[DataMember(Name="phoneToLimit", EmitDefaultValue=false)]
		public string PhoneToLimit { get; set; }

		[DataMember(Name="printSelection", EmitDefaultValue=false)]
		public string PrintSelection { get; set; }

		[DataMember(Name="shareInfoWithJointMarketing", EmitDefaultValue=false)]
		public string ShareInfoWithJointMarketing { get; set; }

		[DataMember(Name="timesToCollect1", EmitDefaultValue=false)]
		public string TimesToCollect1 { get; set; }

		[DataMember(Name="timesToCollect2", EmitDefaultValue=false)]
		public string TimesToCollect2 { get; set; }

		[DataMember(Name="timesToCollect3", EmitDefaultValue=false)]
		public string TimesToCollect3 { get; set; }

		[DataMember(Name="timesToCollect4", EmitDefaultValue=false)]
		public string TimesToCollect4 { get; set; }

		[DataMember(Name="timesToCollect5", EmitDefaultValue=false)]
		public string TimesToCollect5 { get; set; }

		[DataMember(Name="websiteForQuestion", EmitDefaultValue=false)]
		public string WebsiteForQuestion { get; set; }

		[DataMember(Name="websiteToLimit", EmitDefaultValue=false)]
		public string WebsiteToLimit { get; set; }

		[DataMember(Name="year", EmitDefaultValue=false)]
		public int? Year { get; set; }

	}
}