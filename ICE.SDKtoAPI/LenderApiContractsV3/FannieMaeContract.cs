using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FannieMaeContract
    {
        [DataMember(Name = "cltv")]
        public decimal? Cltv { get; set; }

        [DataMember(Name = "community2ndRepaymentStructure")]
        public string Community2ndRepaymentStructure { get; set; }

        [DataMember(Name = "communityLending")]
        public bool? CommunityLending { get; set; }

        [DataMember(Name = "duVersion")]
        public string DuVersion { get; set; }

        [DataMember(Name = "hcltv")]
        public decimal? Hcltv { get; set; }

        [DataMember(Name = "interestedPartyContribution")]
        public decimal? InterestedPartyContribution { get; set; }

        [DataMember(Name = "ltv")]
        public decimal? Ltv { get; set; }

        [DataMember(Name = "mornetPlusCaseFileId")]
        public string MornetPlusCaseFileId { get; set; }

        [DataMember(Name = "startUpMortgage")]
        public bool? StartUpMortgage { get; set; }

        [DataMember(Name = "propertyInspectionWaiverMessage")]
        public string PropertyInspectionWaiverMessage { get; set; }

        [DataMember(Name = "collateralUnderwriterScore")]
        public string CollateralUnderwriterScore { get; set; }

        [DataMember(Name = "ucdpStatus")]
        public string UcdpStatus { get; set; }

        [DataMember(Name = "ecStatus1003")]
        public string EcStatus1003 { get; set; }

        [DataMember(Name = "ulddecStatus")]
        public string UlddecStatus { get; set; }

        [DataMember(Name = "ucdCollectionStatus")]
        public string UcdCollectionStatus { get; set; }

        [DataMember(Name = "caseIdAssignedByUcdIndicator")]
        public bool? CaseIdAssignedByUcdIndicator { get; set; }

        [DataMember(Name = "correspondentAssignmentId")]
        public string CorrespondentAssignmentId { get; set; }

        [DataMember(Name = "fannieMaeOwnedMessage")]
        public string FannieMaeOwnedMessage { get; set; }

        [DataMember(Name = "piwMessage")]
        public string PiwMessage { get; set; }

        [DataMember(Name = "valueRepAndWarrantyMessage")]
        public string ValueRepAndWarrantyMessage { get; set; }

        [DataMember(Name = "assetRepAndWarrantyMessage")]
        public string AssetRepAndWarrantyMessage { get; set; }

        [DataMember(Name = "valueRepAndWarrantyAvailable")]
        public bool? ValueRepAndWarrantyAvailable { get; set; }

        [DataMember(Name = "assetRepAndWarrantyReliefAvailable")]
        public bool? AssetRepAndWarrantyReliefAvailable { get; set; }
    }
}
