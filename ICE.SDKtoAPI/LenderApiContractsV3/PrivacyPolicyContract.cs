using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PrivacyPolicyContract
    {
        [DataMember(Name = "additionalRightsDescription")]
        public string AdditionalRightsDescription { get; set; }

        [DataMember(Name = "affiliateType")]
        public string AffiliateType { get; set; }

        [DataMember(Name = "affiliateTypeExample1")]
        public string AffiliateTypeExample1 { get; set; }

        [DataMember(Name = "affiliateTypeExample2")]
        public string AffiliateTypeExample2 { get; set; }

        [DataMember(Name = "affiliateTypeExample3")]
        public string AffiliateTypeExample3 { get; set; }

        [DataMember(Name = "alsoCollectFrom")]
        public string AlsoCollectFrom { get; set; }

        [DataMember(Name = "daysToUse")]
        public int? DaysToUse { get; set; }

        [DataMember(Name = "howToShare")]
        public string HowToShare { get; set; }

        [DataMember(Name = "informationShare1")]
        public string InformationShare1 { get; set; }

        [DataMember(Name = "informationShare2")]
        public string InformationShare2 { get; set; }

        [DataMember(Name = "informationShare3")]
        public string InformationShare3 { get; set; }

        [DataMember(Name = "informationShare4")]
        public string InformationShare4 { get; set; }

        [DataMember(Name = "informationShare5")]
        public string InformationShare5 { get; set; }

        [DataMember(Name = "informationShare6")]
        public string InformationShare6 { get; set; }

        [DataMember(Name = "informationShare7")]
        public string InformationShare7 { get; set; }

        [DataMember(Name = "informationTypesWeCollect1")]
        public string InformationTypesWeCollect1 { get; set; }

        [DataMember(Name = "informationTypesWeCollect2")]
        public string InformationTypesWeCollect2 { get; set; }

        [DataMember(Name = "informationTypesWeCollect3")]
        public string InformationTypesWeCollect3 { get; set; }

        [DataMember(Name = "informationTypesWeCollect4")]
        public string InformationTypesWeCollect4 { get; set; }

        [DataMember(Name = "informationTypesWeCollect5")]
        public string InformationTypesWeCollect5 { get; set; }

        [DataMember(Name = "jointMarketType")]
        public string JointMarketType { get; set; }

        [DataMember(Name = "jointMarketTypeExample1")]
        public string JointMarketTypeExample1 { get; set; }

        [DataMember(Name = "limitSharing1")]
        public string LimitSharing1 { get; set; }

        [DataMember(Name = "limitSharing2")]
        public string LimitSharing2 { get; set; }

        [DataMember(Name = "limitSharing3")]
        public string LimitSharing3 { get; set; }

        [DataMember(Name = "limitSharing4")]
        public string LimitSharing4 { get; set; }

        [DataMember(Name = "limitSharing5")]
        public string LimitSharing5 { get; set; }

        [DataMember(Name = "limitSharing6")]
        public string LimitSharing6 { get; set; }

        [DataMember(Name = "limitSharing7")]
        public string LimitSharing7 { get; set; }

        [DataMember(Name = "nonaffiliateType")]
        public string NonaffiliateType { get; set; }

        [DataMember(Name = "nonAffiliateTypeExample1")]
        public string NonAffiliateTypeExample1 { get; set; }

        [DataMember(Name = "notesForProtectPrivacy")]
        public string NotesForProtectPrivacy { get; set; }

        [DataMember(Name = "otherInformation")]
        public string OtherInformation { get; set; }

        [DataMember(Name = "phoneForQuestion")]
        public string PhoneForQuestion { get; set; }

        [DataMember(Name = "phoneToLimit")]
        public string PhoneToLimit { get; set; }

        [DataMember(Name = "printSelection")]
        public string PrintSelection { get; set; }

        [DataMember(Name = "shareInfoWithJointMarketing")]
        public string ShareInfoWithJointMarketing { get; set; }

        [DataMember(Name = "timesToCollect1")]
        public string TimesToCollect1 { get; set; }

        [DataMember(Name = "timesToCollect2")]
        public string TimesToCollect2 { get; set; }

        [DataMember(Name = "timesToCollect3")]
        public string TimesToCollect3 { get; set; }

        [DataMember(Name = "timesToCollect4")]
        public string TimesToCollect4 { get; set; }

        [DataMember(Name = "timesToCollect5")]
        public string TimesToCollect5 { get; set; }

        [DataMember(Name = "websiteForQuestion")]
        public string WebsiteForQuestion { get; set; }

        [DataMember(Name = "websiteToLimit")]
        public string WebsiteToLimit { get; set; }

        [DataMember(Name = "month")]
        public string Month { get; set; }

        [DataMember(Name = "year")]
        public int? Year { get; set; }

    }
}
