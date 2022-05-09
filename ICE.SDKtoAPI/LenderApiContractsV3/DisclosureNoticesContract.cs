using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureNoticesContract
    {
        [DataMember(Name = "antiCoercionStatementIndicator")]
        public bool? AntiCoercionStatementIndicator { get; set; }

        [DataMember(Name = "commitmentIssuedByAddress")]
        public string CommitmentIssuedByAddress { get; set; }

        [DataMember(Name = "commitmentIssuedByCity")]
        public string CommitmentIssuedByCity { get; set; }

        [DataMember(Name = "commitmentIssuedByContactName")]
        public string CommitmentIssuedByContactName { get; set; }

        [DataMember(Name = "commitmentIssuedByName")]
        public string CommitmentIssuedByName { get; set; }

        [DataMember(Name = "commitmentIssuedByPhone")]
        public string CommitmentIssuedByPhone { get; set; }

        [DataMember(Name = "commitmentIssuedByPostalCode")]
        public string CommitmentIssuedByPostalCode { get; set; }

        [DataMember(Name = "commitmentIssuedByState")]
        public string CommitmentIssuedByState { get; set; }

        [DataMember(Name = "consumerHandbookOnAdjustableRateMortgages")]
        public string ConsumerHandbookOnAdjustableRateMortgages { get; set; }

        [DataMember(Name = "daysToReceiveWrittenRequest")]
        public string DaysToReceiveWrittenRequest { get; set; }

        [DataMember(Name = "daysToReturnToLender")]
        public int? DaysToReturnToLender { get; set; }

        [DataMember(Name = "discloseNonPublicPersonalInformation")]
        public string DiscloseNonPublicPersonalInformation { get; set; }

        [DataMember(Name = "ecoaAddress")]
        public string EcoaAddress { get; set; }

        [DataMember(Name = "ecoaAddress2")]
        public string EcoaAddress2 { get; set; }

        [DataMember(Name = "ecoaCity")]
        public string EcoaCity { get; set; }

        [DataMember(Name = "ecoaName")]
        public string EcoaName { get; set; }

        [DataMember(Name = "ecoaPhone")]
        public string EcoaPhone { get; set; }

        [DataMember(Name = "ecoaPostalCode")]
        public string EcoaPostalCode { get; set; }

        [DataMember(Name = "ecoaState")]
        public string EcoaState { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription1")]
        public string FairLendingNoticeDescription1 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription2")]
        public string FairLendingNoticeDescription2 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription3")]
        public string FairLendingNoticeDescription3 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription4")]
        public string FairLendingNoticeDescription4 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription5")]
        public string FairLendingNoticeDescription5 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription6")]
        public string FairLendingNoticeDescription6 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription7")]
        public string FairLendingNoticeDescription7 { get; set; }

        [DataMember(Name = "fairLendingNoticeDescription8")]
        public string FairLendingNoticeDescription8 { get; set; }

        [DataMember(Name = "femaCommunityName")]
        public string FemaCommunityName { get; set; }

        [DataMember(Name = "floodInsuranceNotificationIndicator")]
        public bool? FloodInsuranceNotificationIndicator { get; set; }

        [DataMember(Name = "informationDisclosureAuthorizationIndicator")]
        public bool? InformationDisclosureAuthorizationIndicator { get; set; }

        [DataMember(Name = "licensedMortgageBrokerUnder")]
        public string LicensedMortgageBrokerUnder { get; set; }

        [DataMember(Name = "locatedInNfipIndicator")]
        public bool? LocatedInNfipIndicator { get; set; }

        [DataMember(Name = "lossPayeeClause")]
        public string LossPayeeClause { get; set; }

        [DataMember(Name = "nfipParticipationStatus")]
        public string NfipParticipationStatus { get; set; }

        [DataMember(Name = "nonFinancialCompaniesDescription1")]
        public string NonFinancialCompaniesDescription1 { get; set; }

        [DataMember(Name = "nonFinancialCompaniesDescription2")]
        public string NonFinancialCompaniesDescription2 { get; set; }

        [DataMember(Name = "nonFinancialCompaniesDescription3")]
        public string NonFinancialCompaniesDescription3 { get; set; }

        [DataMember(Name = "nonFinancialCompaniesDescription4")]
        public string NonFinancialCompaniesDescription4 { get; set; }

        [DataMember(Name = "notLocatedInNfipIndicator")]
        public bool? NotLocatedInNfipIndicator { get; set; }

        [DataMember(Name = "occupancyStatementIndicator")]
        public bool? OccupancyStatementIndicator { get; set; }

        [DataMember(Name = "optOut")]
        public string OptOut { get; set; }

        [DataMember(Name = "optOutPhone")]
        public string OptOutPhone { get; set; }

        [DataMember(Name = "releaseBankingInformationIndicator")]
        public bool? ReleaseBankingInformationIndicator { get; set; }

        [DataMember(Name = "releaseEmploymentInformationIndicator")]
        public bool? ReleaseEmploymentInformationIndicator { get; set; }

        [DataMember(Name = "releaseInformationInConnectionWithCreditReportIndicator")]
        public bool? ReleaseInformationInConnectionWithCreditReportIndicator { get; set; }

        [DataMember(Name = "releaseMortgageInformationIndicator")]
        public bool? ReleaseMortgageInformationIndicator { get; set; }

        [DataMember(Name = "rightToFinancialPrivacyActIndicator")]
        public bool? RightToFinancialPrivacyActIndicator { get; set; }

        [DataMember(Name = "nfipCommunityNumber")]
        public string NfipCommunityNumber { get; set; }

        [DataMember(Name = "nfipMapEffectiveRevisedDate")]
        public string NfipMapEffectiveRevisedDate { get; set; }

        [DataMember(Name = "mapPanelNumber")]
        public string MapPanelNumber { get; set; }
    }
}
