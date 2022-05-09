using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class HmdaContract
    {
        [DataMember(Name = "actionTaken")]
        public string ActionTaken { get; set; }

        [DataMember(Name = "balloonIndicator")]
        public string BalloonIndicator { get; set; }

        [DataMember(Name = "cdRequired")]
        public bool? CdRequired { get; set; }

        [DataMember(Name = "censusTrack")]
        public string CensusTrack { get; set; }

        [DataMember(Name = "countyCode")]
        public string CountyCode { get; set; }

        [DataMember(Name = "denialReason1")]
        public string DenialReason1 { get; set; }

        [DataMember(Name = "denialReason2")]
        public string DenialReason2 { get; set; }

        [DataMember(Name = "denialReason3")]
        public string DenialReason3 { get; set; }

        [DataMember(Name = "excludeLoanFromHmdaReportIndicator")]
        public bool? ExcludeLoanFromHmdaReportIndicator { get; set; }

        [DataMember(Name = "hoepaStatus")]
        public string HoepaStatus { get; set; }

        [DataMember(Name = "hmda2InterestOnlyIndicator")]
        public string Hmda2InterestOnlyIndicator { get; set; }

        [DataMember(Name = "incomeExcludedFromHmda")]
        public decimal? IncomeExcludedFromHmda { get; set; }

        [DataMember(Name = "lienStatus")]
        public string LienStatus { get; set; }

        [DataMember(Name = "loanBalanceRiseIndicator")]
        public string LoanBalanceRiseIndicator { get; set; }

        [DataMember(Name = "loanPurpose")]
        public string LoanPurpose { get; set; }

        [DataMember(Name = "msaNumber")]
        public string MsaNumber { get; set; }

        [DataMember(Name = "preapprovals")]
        public string Preapprovals { get; set; }

        [DataMember(Name = "propertyType")]
        public string PropertyType { get; set; }

        [DataMember(Name = "rateSpread")]
        public string RateSpread { get; set; }

        [DataMember(Name = "reportPurposeOfLoanIndicator")]
        public bool? ReportPurposeOfLoanIndicator { get; set; }

        [DataMember(Name = "stateCode")]
        public string StateCode { get; set; }

        [DataMember(Name = "typeOfPurchaser")]
        public string TypeOfPurchaser { get; set; }

        [DataMember(Name = "qmStatus")]
        public string QmStatus { get; set; }

        [DataMember(Name = "reportingYear")]
        public int? ReportingYear { get; set; }

        [DataMember(Name = "universalLoanId")]
        public string UniversalLoanId { get; set; }

        [DataMember(Name = "applicationDate")]
        public string ApplicationDate { get; set; }

        [DataMember(Name = "loanType")]
        public string LoanType { get; set; }

        [DataMember(Name = "loanAmount")]
        public decimal? LoanAmount { get; set; }

        [DataMember(Name = "income")]
        public string Income { get; set; }

        [DataMember(Name = "denialReason4")]
        public string DenialReason4 { get; set; }

        [DataMember(Name = "otherDenialReason")]
        public string OtherDenialReason { get; set; }

        [DataMember(Name = "discountPoints")]
        public string DiscountPoints { get; set; }

        [DataMember(Name = "debtToIncomeRatio")]
        public string DebtToIncomeRatio { get; set; }

        [DataMember(Name = "cltv")]
        public string Cltv { get; set; }

        [DataMember(Name = "otherNonAmortization")]
        public string OtherNonAmortization { get; set; }

        [DataMember(Name = "manufacturedSecuredPropertyType")]
        public string ManufacturedSecuredPropertyType { get; set; }

        [DataMember(Name = "manufacturedHomeLandPropertyInterest")]
        public string ManufacturedHomeLandPropertyInterest { get; set; }

        [DataMember(Name = "multifamilyNoUnits")]
        public string MultifamilyNoUnits { get; set; }

        [DataMember(Name = "submissionOfApplication")]
        public string SubmissionOfApplication { get; set; }

        [DataMember(Name = "initiallyPayableToYourInstitution")]
        public string InitiallyPayableToYourInstitution { get; set; }

        [DataMember(Name = "aus1")]
        public string Aus1 { get; set; }

        [DataMember(Name = "aus2")]
        public string Aus2 { get; set; }

        [DataMember(Name = "aus3")]
        public string Aus3 { get; set; }

        [DataMember(Name = "aus4")]
        public string Aus4 { get; set; }

        [DataMember(Name = "aus5")]
        public string Aus5 { get; set; }

        [DataMember(Name = "otherAus")]
        public string OtherAus { get; set; }

        [DataMember(Name = "ausRecommendation1")]
        public string AusRecommendation1 { get; set; }

        [DataMember(Name = "ausRecommendation2")]
        public string AusRecommendation2 { get; set; }

        [DataMember(Name = "ausRecommendation3")]
        public string AusRecommendation3 { get; set; }

        [DataMember(Name = "ausRecommendation4")]
        public string AusRecommendation4 { get; set; }

        [DataMember(Name = "ausRecommendation5")]
        public string AusRecommendation5 { get; set; }

        [DataMember(Name = "otherAusRecommendations")]
        public string OtherAusRecommendations { get; set; }

        [DataMember(Name = "reverseMortgage")]
        public string ReverseMortgage { get; set; }

        [DataMember(Name = "openEndLineOfCredit")]
        public string OpenEndLineOfCredit { get; set; }

        [DataMember(Name = "businessOrCommercialPurpose")]
        public string BusinessOrCommercialPurpose { get; set; }

        [DataMember(Name = "financialInstitutionName")]
        public string FinancialInstitutionName { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "contactPhoneNumber")]
        public string ContactPhoneNumber { get; set; }

        [DataMember(Name = "contactEmailAddress")]
        public string ContactEmailAddress { get; set; }

        [DataMember(Name = "contactOfficeStreetAddress")]
        public string ContactOfficeStreetAddress { get; set; }

        [DataMember(Name = "contactOfficeCity")]
        public string ContactOfficeCity { get; set; }

        [DataMember(Name = "contactOfficeState")]
        public string ContactOfficeState { get; set; }

        [DataMember(Name = "contactOfficeZipCode")]
        public string ContactOfficeZipCode { get; set; }

        [DataMember(Name = "contactFaxNumber")]
        public string ContactFaxNumber { get; set; }

        [DataMember(Name = "federalAgency")]
        public string FederalAgency { get; set; }

        [DataMember(Name = "federalTaxpayerIdNumber")]
        public string FederalTaxpayerIdNumber { get; set; }

        [DataMember(Name = "legalEntityIdentifier")]
        public string LegalEntityIdentifier { get; set; }

        [DataMember(Name = "legalEntityIdentifierReporting")]
        public string LegalEntityIdentifierReporting { get; set; }

        [DataMember(Name = "legalEntityIdentifierUsed")]
        public string LegalEntityIdentifierUsed { get; set; }

        [DataMember(Name = "respondentId")]
        public string RespondentId { get; set; }

        [DataMember(Name = "parentName")]
        public string ParentName { get; set; }

        [DataMember(Name = "parentAddress")]
        public string ParentAddress { get; set; }

        [DataMember(Name = "parentCity")]
        public string ParentCity { get; set; }

        [DataMember(Name = "parentState")]
        public string ParentState { get; set; }

        [DataMember(Name = "parentZip")]
        public string ParentZip { get; set; }

        [DataMember(Name = "partiallyExemptLoanIndicator")]
        public bool? PartiallyExemptLoanIndicator { get; set; }

        [DataMember(Name = "totalLoanCosts")]
        public string TotalLoanCosts { get; set; }

        [DataMember(Name = "totalPointsAndFees")]
        public string TotalPointsAndFees { get; set; }

        [DataMember(Name = "originationCharges")]
        public string OriginationCharges { get; set; }

        [DataMember(Name = "lenderCredits")]
        public string LenderCredits { get; set; }

        [DataMember(Name = "interestRate")]
        public string InterestRate { get; set; }

        [DataMember(Name = "prepaymentPenaltyPeriod")]
        public string PrepaymentPenaltyPeriod { get; set; }

        [DataMember(Name = "loanTerm")]
        public string LoanTerm { get; set; }

        [DataMember(Name = "introRatePeriod")]
        public string IntroRatePeriod { get; set; }

        [DataMember(Name = "propertyValue")]
        public string PropertyValue { get; set; }

        [DataMember(Name = "nmlsLoanOriginatorId")]
        public string NmlsLoanOriginatorId { get; set; }

        [DataMember(Name = "hmdaPropertyZipCode")]
        public string HmdaPropertyZipCode { get; set; }

        [DataMember(Name = "hmdaPropertyAddress")]
        public string HmdaPropertyAddress { get; set; }

        [DataMember(Name = "hmdaPropertyCity")]
        public string HmdaPropertyCity { get; set; }

        [DataMember(Name = "hmdaPropertyState")]
        public string HmdaPropertyState { get; set; }

        [DataMember(Name = "hmdaSyncAddressIndicator")]
        public bool? HmdaSyncAddressIndicator { get; set; }

        [DataMember(Name = "repurchasedReportingYear")]
        public int? RepurchasedReportingYear { get; set; }

        [DataMember(Name = "repurchasedLoanAmount")]
        public decimal? RepurchasedLoanAmount { get; set; }

        [DataMember(Name = "repurchasedTypeOfPurchaser")]
        public string RepurchasedTypeOfPurchaser { get; set; }

        [DataMember(Name = "repurchasedActionTaken")]
        public string RepurchasedActionTaken { get; set; }

        [DataMember(Name = "repurchasedActionDate")]
        public string RepurchasedActionDate { get; set; }

        [DataMember(Name = "hmdaDtiIndicator")]
        public bool? HmdaDtiIndicator { get; set; }

        [DataMember(Name = "hmdaCltvIndicator")]
        public bool? HmdaCltvIndicator { get; set; }

        [DataMember(Name = "hmdaIncomeIndicator")]
        public bool? HmdaIncomeIndicator { get; set; }

        [DataMember(Name = "hmdaProfileId")]
        public string HmdaProfileId { get; set; }

        [DataMember(Name = "hmdaProfileDtiValue")]
        public string HmdaProfileDtiValue { get; set; }

        [DataMember(Name = "hmdaProfileCltvValue")]
        public string HmdaProfileCltvValue { get; set; }

        [DataMember(Name = "hmdaProfileIncomeValue")]
        public string HmdaProfileIncomeValue { get; set; }

        [DataMember(Name = "hmdaProfileApplicationDateValue")]
        public string HmdaProfileApplicationDateValue { get; set; }

        [DataMember(Name = "hmdaLoanPurpose")]
        public string HmdaLoanPurpose { get; set; }

        [DataMember(Name = "hmdaPropertyValueNotReliedUponIndicator")]
        public bool? HmdaPropertyValueNotReliedUponIndicator { get; set; }

        [DataMember(Name = "hmdaInterestOnlyIndicator")]
        public bool? HmdaInterestOnlyIndicator { get; set; }

        [DataMember(Name = "hmdaCensusTrack")]
        public string HmdaCensusTrack { get; set; }

        [DataMember(Name = "hmdaCountyCode")]
        public string HmdaCountyCode { get; set; }
    }
}
