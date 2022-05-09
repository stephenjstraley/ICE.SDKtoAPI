using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TsumContract
    {
        [DataMember(Name = "aboveOrBelowRatePercent")]
        public decimal? AboveOrBelowRatePercent { get; set; }

        [DataMember(Name = "adjustorCoverage")]
        public string AdjustorCoverage { get; set; }

        [DataMember(Name = "ausRecommendation")]
        public string AusRecommendation { get; set; }

        [DataMember(Name = "bedroomsUnit1")]
        public int? BedroomsUnit1 { get; set; }

        [DataMember(Name = "bedroomsUnit2")]
        public int? BedroomsUnit2 { get; set; }

        [DataMember(Name = "bedroomsUnit3")]
        public int? BedroomsUnit3 { get; set; }

        [DataMember(Name = "bedroomsUnit4")]
        public int? BedroomsUnit4 { get; set; }

        [DataMember(Name = "certificateNumber")]
        public string CertificateNumber { get; set; }

        [DataMember(Name = "commitmentNumber")]
        public string CommitmentNumber { get; set; }

        [DataMember(Name = "contactTitle")]
        public string ContactTitle { get; set; }

        [DataMember(Name = "contractNumber")]
        public string ContractNumber { get; set; }

        [DataMember(Name = "cpmProjectId")]
        public string CpmProjectId { get; set; }

        [DataMember(Name = "duCaseIdLpAusKey")]
        public string DuCaseIdLpAusKey { get; set; }

        [DataMember(Name = "formNumber")]
        public string FormNumber { get; set; }

        [DataMember(Name = "grossRentUnit1")]
        public int? GrossRentUnit1 { get; set; }

        [DataMember(Name = "grossRentUnit2")]
        public int? GrossRentUnit2 { get; set; }

        [DataMember(Name = "grossRentUnit3")]
        public int? GrossRentUnit3 { get; set; }

        [DataMember(Name = "grossRentUnit4")]
        public int? GrossRentUnit4 { get; set; }

        [DataMember(Name = "homeBuyersOwnershipEducationCertificateInFile")]
        public string HomeBuyersOwnershipEducationCertificateInFile { get; set; }

        [DataMember(Name = "insurerCode")]
        public string InsurerCode { get; set; }

        [DataMember(Name = "interestedPartyContributions")]
        public decimal? InterestedPartyContributions { get; set; }

        [DataMember(Name = "investorLoanNumber")]
        public string InvestorLoanNumber { get; set; }

        [DataMember(Name = "levelOfPropertyReviewType")]
        public string LevelOfPropertyReviewType { get; set; }

        [DataMember(Name = "lpDocClass")]
        public string LpDocClass { get; set; }

        [DataMember(Name = "mortgageOriginator")]
        public string MortgageOriginator { get; set; }

        [DataMember(Name = "noteDate")]
        public string NoteDate { get; set; }

        [DataMember(Name = "noteRateType")]
        public string NoteRateType { get; set; }

        [DataMember(Name = "numberOfBorrowers")]
        public int? NumberOfBorrowers { get; set; }

        [DataMember(Name = "numberOfMonthsReserves")]
        public int? NumberOfMonthsReserves { get; set; }

        [DataMember(Name = "originalAmountOfFirstMortgage")]
        public decimal? OriginalAmountOfFirstMortgage { get; set; }

        [DataMember(Name = "otherTypeDescription")]
        public string OtherTypeDescription { get; set; }

        [DataMember(Name = "percentageofCoverage")]
        public string PercentageofCoverage { get; set; }

        [DataMember(Name = "projectName")]
        public string ProjectName { get; set; }

        [DataMember(Name = "propertyType")]
        public string PropertyType { get; set; }

        [DataMember(Name = "required")]
        public decimal? Required { get; set; }

        [DataMember(Name = "riskAssessmentType")]
        public string RiskAssessmentType { get; set; }

        [DataMember(Name = "sellerAddress")]
        public string SellerAddress { get; set; }

        [DataMember(Name = "sellerCity")]
        public string SellerCity { get; set; }

        [DataMember(Name = "sellerContactName")]
        public string SellerContactName { get; set; }

        [DataMember(Name = "sellerName")]
        public string SellerName { get; set; }

        [DataMember(Name = "sellerNumber")]
        public string SellerNumber { get; set; }

        [DataMember(Name = "sellerPhone")]
        public string SellerPhone { get; set; }

        [DataMember(Name = "sellerPostalCode")]
        public string SellerPostalCode { get; set; }

        [DataMember(Name = "sellerState")]
        public string SellerState { get; set; }

        [DataMember(Name = "sellerCountry")]
        public string SellerCountry { get; set; }

        [DataMember(Name = "sellerForeignAddressIndicator")]
        public bool? SellerForeignAddressIndicator { get; set; }

        [DataMember(Name = "specialFeatureCode1")]
        public string SpecialFeatureCode1 { get; set; }

        [DataMember(Name = "specialFeatureCode2")]
        public string SpecialFeatureCode2 { get; set; }

        [DataMember(Name = "specialFeatureCode3")]
        public string SpecialFeatureCode3 { get; set; }

        [DataMember(Name = "specialFeatureCode4")]
        public string SpecialFeatureCode4 { get; set; }

        [DataMember(Name = "specialFeatureCode5")]
        public string SpecialFeatureCode5 { get; set; }

        [DataMember(Name = "specialFeatureCode6")]
        public string SpecialFeatureCode6 { get; set; }

        [DataMember(Name = "thirdPartyName1")]
        public string ThirdPartyName1 { get; set; }

        [DataMember(Name = "thirdPartyName2")]
        public string ThirdPartyName2 { get; set; }

        [DataMember(Name = "typeOfCommitment")]
        public string TypeOfCommitment { get; set; }

        [DataMember(Name = "underwritingComment1")]
        public string UnderwritingComment1 { get; set; }

        [DataMember(Name = "underwritingComment2")]
        public string UnderwritingComment2 { get; set; }

        [DataMember(Name = "underwritingComment3")]
        public string UnderwritingComment3 { get; set; }

        [DataMember(Name = "underwritingComment4")]
        public string UnderwritingComment4 { get; set; }

        [DataMember(Name = "underwritingComment5")]
        public string UnderwritingComment5 { get; set; }

        [DataMember(Name = "underwritingComment6")]
        public string UnderwritingComment6 { get; set; }

        [DataMember(Name = "underwritingComment7")]
        public string UnderwritingComment7 { get; set; }

        [DataMember(Name = "underwritingComment8")]
        public string UnderwritingComment8 { get; set; }

        [DataMember(Name = "unpaidBalance")]
        public decimal? UnpaidBalance { get; set; }

        [DataMember(Name = "verified")]
        public decimal? Verified { get; set; }

        [DataMember(Name = "propertyFormType")]
        public string PropertyFormType { get; set; }

        [DataMember(Name = "communityLendingAffordableHousingInitiative")]
        public bool? CommunityLendingAffordableHousingInitiative { get; set; }

    }
}
