using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class BorrowerContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "accountCheckAssetId")]
        public string AccountCheckAssetId { get; set; }

        [DataMember(Name = "activeDuty")]
        public bool? ActiveDuty { get; set; }

        [DataMember(Name = "additionalEmploymentDoesNotApply")]
        public bool? AdditionalEmploymentDoesNotApply { get; set; }

        [DataMember(Name = "additionalIncomeFromPrimaryEmployment")]
        public decimal? AdditionalIncomeFromPrimaryEmployment { get; set; }

        [DataMember(Name = "additionalOtherIncome")]
        public decimal? AdditionalOtherIncome { get; set; }

        [DataMember(Name = "adjustedAnnualIncome")]
        public decimal? AdjustedAnnualIncome { get; set; }

        [DataMember(Name = "ageAtApplicationYearsCount")]
        public int? AgeAtApplicationYearsCount { get; set; }

        [DataMember(Name = "aliasName")]
        public string AliasName { get; set; }

        [DataMember(Name = "alimonyChildSupportObligationIndicator")]
        public bool? AlimonyChildSupportObligationIndicator { get; set; }

        [DataMember(Name = "annualIncome")]
        public decimal? AnnualIncome { get; set; }

        [DataMember(Name = "assetIncome")]
        public decimal? AssetIncome { get; set; }

        [DataMember(Name = "assetRepAndWarrantyMessage")]
        public string AssetRepAndWarrantyMessage { get; set; }

        [DataMember(Name = "assetRepAndWarrantyReliefAvailable")]
        public bool? AssetRepAndWarrantyReliefAvailable { get; set; }

        [DataMember(Name = "applicantType")]
        public string ApplicantType { get; set; }

        [DataMember(Name = "applicationTakenMethodType")]
        public string ApplicationTakenMethodType { get; set; }

        [DataMember(Name = "authorizedCreditReportIndicator")]
        public bool? AuthorizedCreditReportIndicator { get; set; }

        [DataMember(Name = "authorizedCreditReportDate")]
        public string AuthorizedCreditReportDate { get; set; }

        [DataMember(Name = "authorizedToSignIndicator")]
        public bool? AuthorizedToSignIndicator { get; set; }

        [DataMember(Name = "bankAccountNumber")]
        public string BankAccountNumber { get; set; }

        [DataMember(Name = "bankAccountType")]
        public string BankAccountType { get; set; }

        [DataMember(Name = "bankContactAddress")]
        public string BankContactAddress { get; set; }

        [DataMember(Name = "bankContactCity")]
        public string BankContactCity { get; set; }

        [DataMember(Name = "bankContactName")]
        public string BankContactName { get; set; }

        [DataMember(Name = "bankContactPostalCode")]
        public string BankContactPostalCode { get; set; }

        [DataMember(Name = "bankContactState")]
        public string BankContactState { get; set; }

        [DataMember(Name = "bankruptcyDate")]
        public string BankruptcyDate { get; set; }

        [DataMember(Name = "bankruptcyIndicator")]
        public bool? BankruptcyIndicator { get; set; }

        [DataMember(Name = "bankruptcyIndicatorChapterSeven")]
        public bool? BankruptcyIndicatorChapterSeven { get; set; }

        [DataMember(Name = "bankruptcyIndicatorChapterEleven")]
        public bool? BankruptcyIndicatorChapterEleven { get; set; }

        [DataMember(Name = "bankruptcyIndicatorChapterTwelve")]
        public bool? BankruptcyIndicatorChapterTwelve { get; set; }

        [DataMember(Name = "bankruptcyIndicatorChapterThirteen")]
        public bool? BankruptcyIndicatorChapterThirteen { get; set; }

        [DataMember(Name = "bankruptcyStatus")]
        public string BankruptcyStatus { get; set; }

        [DataMember(Name = "baseIncome")]
        public decimal? BaseIncome { get; set; }

        [DataMember(Name = "baseIncomeValidationMessage")]
        public string BaseIncomeValidationMessage { get; set; }

        [DataMember(Name = "baseMonthlyIncomeAmount")]
        public decimal? BaseMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "birthDate")]
        public string BirthDate { get; set; }

        [DataMember(Name = "bonusValidationMessage")]
        public string BonusValidationMessage { get; set; }

        [DataMember(Name = "borrowedDownPaymentIndicator")]
        public bool? BorrowedDownPaymentIndicator { get; set; }

        [DataMember(Name = "borrowerConsentRequestDate")]
        public string BorrowerConsentRequestDate { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

        [DataMember(Name = "borrowerTypeInSummary")]
        public string BorrowerTypeInSummary { get; set; }

        [DataMember(Name = "caivrsIdentifier")]
        public string CaivrsIdentifier { get; set; }

        [DataMember(Name = "coBorrAttendedSameCounselingIndicator")]
        public bool? CoBorrAttendedSameCounselingIndicator { get; set; }

        [DataMember(Name = "citizenshipResidencyType")]
        public string CitizenshipResidencyType { get; set; }

        [DataMember(Name = "coMakerEndorserOfNoteIndicator")]
        public bool? CoMakerEndorserOfNoteIndicator { get; set; }

        [DataMember(Name = "commentOfCreditReport")]
        public string CommentOfCreditReport { get; set; }

        [DataMember(Name = "commissionValidationMessage")]
        public string CommissionValidationMessage { get; set; }

        [DataMember(Name = "confirmedCrbkIncorrect")]
        public bool? ConfirmedCrbkIncorrect { get; set; }

        [DataMember(Name = "confirmedCrbkec")]
        public bool? ConfirmedCrbkec { get; set; }

        [DataMember(Name = "confirmedMtgDelIncorrect")]
        public bool? ConfirmedMtgDelIncorrect { get; set; }

        [DataMember(Name = "topRatioPercent")]
        public decimal? TopRatioPercent { get; set; }

        [DataMember(Name = "bottomRatioPercent")]
        public decimal? BottomRatioPercent { get; set; }

        [DataMember(Name = "totalGrossMonthlyIncomeAmount")]
        public decimal? TotalGrossMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "confirmedCrfcIncorrect")]
        public bool? ConfirmedCrfcIncorrect { get; set; }

        [DataMember(Name = "confirmedCrfcec")]
        public bool? ConfirmedCrfcec { get; set; }

        [DataMember(Name = "confirmedCrdil")]
        public bool? ConfirmedCrdil { get; set; }

        [DataMember(Name = "confirmedCrpfs")]
        public bool? ConfirmedCrpfs { get; set; }

        [DataMember(Name = "confirmedOther")]
        public bool? ConfirmedOther { get; set; }

        [DataMember(Name = "confirmedOtherDescription")]
        public string ConfirmedOtherDescription { get; set; }

        [DataMember(Name = "contactRef")]
        public EntityReferenceContract ContactRef { get; set; }

        [DataMember(Name = "creditCounseling")]
        public bool? CreditCounseling { get; set; }

        [DataMember(Name = "creditReports")]
        public List<CreditReportContract> CreditReports { get; set; }

        [DataMember(Name = "creditReceivedDate")]
        public string CreditReceivedDate { get; set; }

        [DataMember(Name = "creditReportAuthorizationMethod")]
        public string CreditReportAuthorizationMethod { get; set; }

        [DataMember(Name = "creditScoreIndicator")]
        public bool? CreditScoreIndicator { get; set; }

        [DataMember(Name = "currentEmploymentDoesNotApply")]
        public bool? CurrentEmploymentDoesNotApply { get; set; }

        [DataMember(Name = "declarationsJIndicator")]
        public bool? DeclarationsJIndicator { get; set; }

        [DataMember(Name = "declarationsKIndicator")]
        public bool? DeclarationsKIndicator { get; set; }

        [DataMember(Name = "dependentCount")]
        public int? DependentCount { get; set; }

        [DataMember(Name = "dependentsAgesDescription")]
        public string DependentsAgesDescription { get; set; }

        [DataMember(Name = "disabledIndicator")]
        public bool? DisabledIndicator { get; set; }

        [DataMember(Name = "domesticRelationshipType")]
        public string DomesticRelationshipType { get; set; }

        [DataMember(Name = "duVerificationEmploymentIncomeIndicator")]
        public bool? DuVerificationEmploymentIncomeIndicator { get; set; }

        [DataMember(Name = "duVerificationEmploymentIncomeMessage")]
        public string DuVerificationEmploymentIncomeMessage { get; set; }

        [DataMember(Name = "emailAddressText")]
        public string EmailAddressText { get; set; }

        [DataMember(Name = "employment")]
        public List<EmploymentContract> Employment { get; set; }

        [DataMember(Name = "employmentVerificationAvailable")]
        public bool? EmploymentVerificationAvailable { get; set; }

        [DataMember(Name = "employmentVerificationMessage")]
        public string EmploymentVerificationMessage { get; set; }

        [DataMember(Name = "freddieAlienStatus")]
        public string FreddieAlienStatus { get; set; }

        [DataMember(Name = "equifax120Days")]
        public int? Equifax120Days { get; set; }

        [DataMember(Name = "equifax150Days")]
        public int? Equifax150Days { get; set; }

        [DataMember(Name = "equifax30Days")]
        public int? Equifax30Days { get; set; }

        [DataMember(Name = "equifax60Days")]
        public int? Equifax60Days { get; set; }

        [DataMember(Name = "equifax90Days")]
        public int? Equifax90Days { get; set; }

        [DataMember(Name = "equifaxCreditScoreForDisclosure")]
        public bool? EquifaxCreditScoreForDisclosure { get; set; }

        [DataMember(Name = "equifaxCreditScoreRanksPercent")]
        public int? EquifaxCreditScoreRanksPercent { get; set; }

        [DataMember(Name = "equifaxDatePulled")]
        public string EquifaxDatePulled { get; set; }

        [DataMember(Name = "equifaxFactorCode1")]
        public string EquifaxFactorCode1 { get; set; }

        [DataMember(Name = "equifaxFactorCode2")]
        public string EquifaxFactorCode2 { get; set; }

        [DataMember(Name = "equifaxFactorCode3")]
        public string EquifaxFactorCode3 { get; set; }

        [DataMember(Name = "equifaxFactorCode4")]
        public string EquifaxFactorCode4 { get; set; }

        [DataMember(Name = "equifaxFactorCode5")]
        public string EquifaxFactorCode5 { get; set; }

        [DataMember(Name = "equifaxKeyFactor1")]
        public string EquifaxKeyFactor1 { get; set; }

        [DataMember(Name = "equifaxKeyFactor2")]
        public string EquifaxKeyFactor2 { get; set; }

        [DataMember(Name = "equifaxKeyFactor3")]
        public string EquifaxKeyFactor3 { get; set; }

        [DataMember(Name = "equifaxKeyFactor4")]
        public string EquifaxKeyFactor4 { get; set; }

        [DataMember(Name = "equifaxKeyFactor5")]
        public bool? EquifaxKeyFactor5 { get; set; }

        [DataMember(Name = "equifaxMaterialTermsCreditByScore")]
        public bool? EquifaxMaterialTermsCreditByScore { get; set; }

        [DataMember(Name = "equifaxScore")]
        public string EquifaxScore { get; set; }

        [DataMember(Name = "experian120Days")]
        public int? Experian120Days { get; set; }

        [DataMember(Name = "experian150Days")]
        public int? Experian150Days { get; set; }

        [DataMember(Name = "experian30Days")]
        public int? Experian30Days { get; set; }

        [DataMember(Name = "experian60Days")]
        public int? Experian60Days { get; set; }

        [DataMember(Name = "experian90Days")]
        public int? Experian90Days { get; set; }

        [DataMember(Name = "experianCreditScore")]
        public string ExperianCreditScore { get; set; }

        [DataMember(Name = "experianCreditScoreForDisclosure")]
        public bool? ExperianCreditScoreForDisclosure { get; set; }

        [DataMember(Name = "experianCreditScoreRanksPercent")]
        public int? ExperianCreditScoreRanksPercent { get; set; }

        [DataMember(Name = "experianDatePulled")]
        public string ExperianDatePulled { get; set; }

        [DataMember(Name = "experianFactorCode1")]
        public string ExperianFactorCode1 { get; set; }

        [DataMember(Name = "experianFactorCode2")]
        public string ExperianFactorCode2 { get; set; }

        [DataMember(Name = "experianFactorCode3")]
        public string ExperianFactorCode3 { get; set; }

        [DataMember(Name = "experianFactorCode4")]
        public string ExperianFactorCode4 { get; set; }

        [DataMember(Name = "experianFactorCode5")]
        public string ExperianFactorCode5 { get; set; }

        [DataMember(Name = "experianKeyFactor1")]
        public string ExperianKeyFactor1 { get; set; }

        [DataMember(Name = "experianKeyFactor2")]
        public string ExperianKeyFactor2 { get; set; }

        [DataMember(Name = "experianKeyFactor3")]
        public string ExperianKeyFactor3 { get; set; }

        [DataMember(Name = "experianKeyFactor4")]
        public string ExperianKeyFactor4 { get; set; }

        [DataMember(Name = "experianKeyFactor5")]
        public bool? ExperianKeyFactor5 { get; set; }

        [DataMember(Name = "experianMaterialTermsCreditByScore")]
        public bool? ExperianMaterialTermsCreditByScore { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "firstNameWithMiddleName")]
        public string FirstNameWithMiddleName { get; set; }

        [DataMember(Name = "firstTimeHomeBuyer")]
        public bool? FirstTimeHomeBuyer { get; set; }

        [DataMember(Name = "foreclosureDate")]
        public string ForeclosureDate { get; set; }

        [DataMember(Name = "foreclosureSatisfied")]
        public string ForeclosureSatisfied { get; set; }

        [DataMember(Name = "foreclosureStatus")]
        public string ForeclosureStatus { get; set; }

        [DataMember(Name = "freddieMacPerson1")]
        public string FreddieMacPerson1 { get; set; }

        [DataMember(Name = "freddieMacPerson2")]
        public string FreddieMacPerson2 { get; set; }

        [DataMember(Name = "fullName")]
        public string FullName { get; set; }

        [DataMember(Name = "fullNameWithSuffix")]
        public string FullNameWithSuffix { get; set; }

        [DataMember(Name = "fannieFirstName")]
        public string FannieFirstName { get; set; }

        [DataMember(Name = "fannieMiddleName")]
        public string FannieMiddleName { get; set; }

        [DataMember(Name = "giftsAndGrantsIndicatorBor")]
        public bool? GiftsAndGrantsIndicatorBor { get; set; }

        [DataMember(Name = "highestCreditLimit")]
        public decimal? HighestCreditLimit { get; set; }

        [DataMember(Name = "hmda2003OtherRaceNationalOriginDescription")]
        public string Hmda2003OtherRaceNationalOriginDescription { get; set; }

        [DataMember(Name = "hmda2003RaceNationalOriginType")]
        public string Hmda2003RaceNationalOriginType { get; set; }

        [DataMember(Name = "hmda2CreditScoreForDecisionMaking")]
        public string Hmda2CreditScoreForDecisionMaking { get; set; }

        [DataMember(Name = "hmda2CreditScoringModel")]
        public string Hmda2CreditScoringModel { get; set; }

        [DataMember(Name = "hmdaAfricanAmericanIndicator")]
        public bool? HmdaAfricanAmericanIndicator { get; set; }

        [DataMember(Name = "hmdaAge")]
        public string HmdaAge { get; set; }

        [DataMember(Name = "hmdaAmericanIndianIndicator")]
        public bool? HmdaAmericanIndianIndicator { get; set; }

        [DataMember(Name = "hmdaAmericanIndianTribe")]
        public string HmdaAmericanIndianTribe { get; set; }

        [DataMember(Name = "hmdaAsianIndianIndicator")]
        public bool? HmdaAsianIndianIndicator { get; set; }

        [DataMember(Name = "hmdaAsianIndicator")]
        public bool? HmdaAsianIndicator { get; set; }

        [DataMember(Name = "hmdaAsianOtherRaceIndicator")]
        public bool? HmdaAsianOtherRaceIndicator { get; set; }

        [DataMember(Name = "hmdaChineseIndicator")]
        public bool? HmdaChineseIndicator { get; set; }

        [DataMember(Name = "hmdaCreditScoreForDecisionMaking")]
        public string HmdaCreditScoreForDecisionMaking { get; set; }

        [DataMember(Name = "hmdaCreditScoringModel")]
        public string HmdaCreditScoringModel { get; set; }

        [DataMember(Name = "hmdaCubanIndicator")]
        public bool? HmdaCubanIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedField1")]
        public string HmdaEthnicityReportedField1 { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedField2")]
        public string HmdaEthnicityReportedField2 { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedField3")]
        public string HmdaEthnicityReportedField3 { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedField4")]
        public string HmdaEthnicityReportedField4 { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedField5")]
        public string HmdaEthnicityReportedField5 { get; set; }

        [DataMember(Name = "hmdaEthnicityReportedFields")]
        public string HmdaEthnicityReportedFields { get; set; }

        [DataMember(Name = "hmdaEthnicityType")]
        public string HmdaEthnicityType { get; set; }

        [DataMember(Name = "hmdaFilipinoIndicator")]
        public bool? HmdaFilipinoIndicator { get; set; }

        [DataMember(Name = "hmdaGenderType")]
        public string HmdaGenderType { get; set; }

        [DataMember(Name = "hmdaGuamanianOrChamorroIndicator")]
        public bool? HmdaGuamanianOrChamorroIndicator { get; set; }

        [DataMember(Name = "hmdaHispanicLatinoOtherOriginIndicator")]
        public bool? HmdaHispanicLatinoOtherOriginIndicator { get; set; }

        [DataMember(Name = "hmdaJapaneseIndicator")]
        public bool? HmdaJapaneseIndicator { get; set; }

        [DataMember(Name = "hmdaKoreanIndicator")]
        public bool? HmdaKoreanIndicator { get; set; }

        [DataMember(Name = "hmdaMexicanIndicator")]
        public bool? HmdaMexicanIndicator { get; set; }

        [DataMember(Name = "hmdaNativeHawaiianIndicator")]
        public bool? HmdaNativeHawaiianIndicator { get; set; }

        [DataMember(Name = "hmdaNoCoApplicantIndicator")]
        public bool? HmdaNoCoApplicantIndicator { get; set; }

        [DataMember(Name = "hmdaNotApplicableIndicator")]
        public bool? HmdaNotApplicableIndicator { get; set; }

        [DataMember(Name = "hmdaNotProvidedIndicator")]
        public bool? HmdaNotProvidedIndicator { get; set; }

        [DataMember(Name = "hmdaOtherAsianRace")]
        public string HmdaOtherAsianRace { get; set; }

        [DataMember(Name = "hmdaOtherHispanicLatinoOrigin")]
        public string HmdaOtherHispanicLatinoOrigin { get; set; }

        [DataMember(Name = "hmdaOtherPacificIslanderRace")]
        public string HmdaOtherPacificIslanderRace { get; set; }

        [DataMember(Name = "hmdaOtherScoringModel")]
        public string HmdaOtherScoringModel { get; set; }

        [DataMember(Name = "hmdaPacificIslanderIndicator")]
        public bool? HmdaPacificIslanderIndicator { get; set; }

        [DataMember(Name = "hmdaPacificIslanderOtherIndicator")]
        public bool? HmdaPacificIslanderOtherIndicator { get; set; }

        [DataMember(Name = "hmdaPuertoRicanIndicator")]
        public bool? HmdaPuertoRicanIndicator { get; set; }

        [DataMember(Name = "hmdaRaceReportedField1")]
        public string HmdaRaceReportedField1 { get; set; }

        [DataMember(Name = "hmdaRaceReportedField2")]
        public string HmdaRaceReportedField2 { get; set; }

        [DataMember(Name = "hmdaRaceReportedField3")]
        public string HmdaRaceReportedField3 { get; set; }

        [DataMember(Name = "hmdaRaceReportedField4")]
        public string HmdaRaceReportedField4 { get; set; }

        [DataMember(Name = "hmdaRaceReportedField5")]
        public string HmdaRaceReportedField5 { get; set; }

        [DataMember(Name = "hmdaRaceReportedFields")]
        public string HmdaRaceReportedFields { get; set; }

        [DataMember(Name = "hmdaRefusalIndicator")]
        public bool? HmdaRefusalIndicator { get; set; }

        [DataMember(Name = "hmdaSamoanIndicator")]
        public bool? HmdaSamoanIndicator { get; set; }

        [DataMember(Name = "hmdaVietnameseIndicator")]
        public bool? HmdaVietnameseIndicator { get; set; }

        [DataMember(Name = "hmdaWhiteIndicator")]
        public bool? HmdaWhiteIndicator { get; set; }

        [DataMember(Name = "hmdaGendertypeFemaleIndicator")]
        public bool? HmdaGendertypeFemaleIndicator { get; set; }

        [DataMember(Name = "hmdaGendertypeMaleIndicator")]
        public bool? HmdaGendertypeMaleIndicator { get; set; }

        [DataMember(Name = "hmdaGendertypeDoNotWishIndicator")]
        public bool? HmdaGendertypeDoNotWishIndicator { get; set; }

        [DataMember(Name = "hmdaGendertypeNotApplicableIndicator")]
        public bool? HmdaGendertypeNotApplicableIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityDoNotWishIndicator")]
        public bool? HmdaEthnicityDoNotWishIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityHispanicLatinoIndicator")]
        public bool? HmdaEthnicityHispanicLatinoIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityNotHispanicLatinoIndicator")]
        public bool? HmdaEthnicityNotHispanicLatinoIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityNotApplicableIndicator")]
        public bool? HmdaEthnicityNotApplicableIndicator { get; set; }

        [DataMember(Name = "hmdaEthnicityInfoNotProvided")]
        public bool? HmdaEthnicityInfoNotProvided { get; set; }

        [DataMember(Name = "hmdaRaceInfoNotProvided")]
        public bool? HmdaRaceInfoNotProvided { get; set; }

        [DataMember(Name = "hmdaSexInfoNotProvided")]
        public bool? HmdaSexInfoNotProvided { get; set; }

        [DataMember(Name = "hmdaRaceDoNotWishProvideIndicator")]
        public bool? HmdaRaceDoNotWishProvideIndicator { get; set; }

        [DataMember(Name = "homeownerPastThreeYearsIndicator")]
        public bool? HomeownerPastThreeYearsIndicator { get; set; }

        [DataMember(Name = "homePhoneNumber")]
        public string HomePhoneNumber { get; set; }

        [DataMember(Name = "homeCounselingAgencyName")]
        public string HomeCounselingAgencyName { get; set; }

        [DataMember(Name = "homeCounselingCompletionDate")]
        public string HomeCounselingCompletionDate { get; set; }

        [DataMember(Name = "incomeRepAndWarrantyMessage")]
        public string IncomeRepAndWarrantyMessage { get; set; }

        [DataMember(Name = "incomeRepAndWarrantyReliefAvailable")]
        public bool? IncomeRepAndWarrantyReliefAvailable { get; set; }

        [DataMember(Name = "intentToOccupyIndicator")]
        public bool? IntentToOccupyIndicator { get; set; }

        [DataMember(Name = "intuitReportId")]
        public string IntuitReportId { get; set; }

        [DataMember(Name = "isBaseIncomeAvailable")]
        public bool? IsBaseIncomeAvailable { get; set; }

        [DataMember(Name = "isBorrower")]
        public bool IsBorrower { get; set; }

        [DataMember(Name = "isBonusAvailable")]
        public bool? IsBonusAvailable { get; set; }

        [DataMember(Name = "isCommissionAvailable")]
        public bool? IsCommissionAvailable { get; set; }

        [DataMember(Name = "isEthnicityBasedOnVisual")]
        public string IsEthnicityBasedOnVisual { get; set; }

        [DataMember(Name = "isOvertimeAvailable")]
        public bool? IsOvertimeAvailable { get; set; }

        [DataMember(Name = "isRaceBasedOnVisual")]
        public string IsRaceBasedOnVisual { get; set; }

        [DataMember(Name = "isSocialSecurityAvailable")]
        public bool? IsSocialSecurityAvailable { get; set; }

        [DataMember(Name = "isSelfEmployed")]
        public bool? IsSelfEmployed { get; set; }

        [DataMember(Name = "isSexBasedOnVisual")]
        public string IsSexBasedOnVisual { get; set; }

        [DataMember(Name = "isTaxReturnAvailable")]
        public bool? IsTaxReturnAvailable { get; set; }

        [DataMember(Name = "jointAssetLiabilityReportingIndicator")]
        public string JointAssetLiabilityReportingIndicator { get; set; }

        [DataMember(Name = "jointAssetLiabilityReportingIndicator1")]
        public string JointAssetLiabilityReportingIndicator1 { get; set; }

        [DataMember(Name = "languageCodeOtherDescription")]
        public string LanguageCodeOtherDescription { get; set; }

        [DataMember(Name = "languagePreference")]
        public string LanguagePreference { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "lastNameWithSuffix")]
        public string LastNameWithSuffix { get; set; }

        [DataMember(Name = "legacyId")]
        public string LegacyId { get; set; }

        [DataMember(Name = "legalOtherThanSpouse")]
        public bool? LegalOtherThanSpouse { get; set; }

        [DataMember(Name = "liabilitiesDoesNotApply")]
        public bool? LiabilitiesDoesNotApply { get; set; }

        [DataMember(Name = "loanForeclosureOrJudgementIndicator")]
        public bool? LoanForeclosureOrJudgementIndicator { get; set; }

        [DataMember(Name = "lpdGsa")]
        public string LpdGsa { get; set; }

        [DataMember(Name = "mailingAddress")]
        public MailingAddressContract MailingAddress { get; set; }

        [DataMember(Name = "mailingAddressSameAsPresentIndicator")]
        public bool? MailingAddressSameAsPresentIndicator { get; set; }

        [DataMember(Name = "maritalStatusType")]
        public string MaritalStatusType { get; set; }

        [DataMember(Name = "middleCreditScore")]
        public int? MiddleCreditScore { get; set; }

        [DataMember(Name = "middleFicoScore")]
        public string MiddleFicoScore { get; set; }

        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }

        [DataMember(Name = "militaryServiceExpectedCompletionDate")]
        public string MilitaryServiceExpectedCompletionDate { get; set; }

        [DataMember(Name = "minFicoScore")]
        public string MinFicoScore { get; set; }

        [DataMember(Name = "mobilePhone")]
        public string MobilePhone { get; set; }

        [DataMember(Name = "mortgageOnCredit")]
        public bool? MortgageOnCredit { get; set; }

        [DataMember(Name = "nameToObtainLoanFromRhs")]
        public string NameToObtainLoanFromRhs { get; set; }

        [DataMember(Name = "nearestRelativeAddress")]
        public string NearestRelativeAddress { get; set; }

        [DataMember(Name = "nearestRelativeCity")]
        public string NearestRelativeCity { get; set; }

        [DataMember(Name = "nearestRelativeName")]
        public string NearestRelativeName { get; set; }

        [DataMember(Name = "nearestRelativePhone")]
        public string NearestRelativePhone { get; set; }

        [DataMember(Name = "nearestRelativePostalCode")]
        public string NearestRelativePostalCode { get; set; }

        [DataMember(Name = "nearestRelativeRelationship")]
        public string NearestRelativeRelationship { get; set; }

        [DataMember(Name = "nearestRelativeState")]
        public string NearestRelativeState { get; set; }

        [DataMember(Name = "nearestRelativeCountry")]
        public string NearestRelativeCountry { get; set; }

        [DataMember(Name = "nearestRelativeForeignAddressIndicator")]
        public bool? NearestRelativeForeignAddressIndicator { get; set; }

        [DataMember(Name = "netRentalIncome")]
        public decimal? NetRentalIncome { get; set; }

        [DataMember(Name = "noCoApplicantEthnicityIndicator")]
        public bool? NoCoApplicantEthnicityIndicator { get; set; }

        [DataMember(Name = "noCoApplicantIndicator")]
        public bool? NoCoApplicantIndicator { get; set; }

        [DataMember(Name = "noCoApplicantSexIndicator")]
        public bool? NoCoApplicantSexIndicator { get; set; }

        [DataMember(Name = "no3rdPartyEmailIndicator")]
        public bool? No3rdPartyEmailIndicator { get; set; }

        [DataMember(Name = "numberofTradelines")]
        public int? NumberofTradelines { get; set; }

        [DataMember(Name = "obtainLoanFromRhsIndicator")]
        public bool? ObtainLoanFromRhsIndicator { get; set; }

        [DataMember(Name = "openBankruptcy2")]
        public string OpenBankruptcy2 { get; set; }

        [DataMember(Name = "otherAssetsDoesNotApply")]
        public bool? OtherAssetsDoesNotApply { get; set; }

        [DataMember(Name = "otherLiabilitiesDoesNotApply")]
        public bool? OtherLiabilitiesDoesNotApply { get; set; }

        [DataMember(Name = "otherMonthlyIncomeAmount")]
        public decimal? OtherMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "otherRelationshipTypeDescription")]
        public string OtherRelationshipTypeDescription { get; set; }

        [DataMember(Name = "otherSrcIncomeDoesNotApply")]
        public bool? OtherSrcIncomeDoesNotApply { get; set; }

        [DataMember(Name = "otherSumAmount")]
        public decimal? OtherSumAmount { get; set; }

        [DataMember(Name = "outstandingJudgementsIndicator")]
        public bool? OutstandingJudgementsIndicator { get; set; }

        [DataMember(Name = "overtimeValidationMessage")]
        public string OvertimeValidationMessage { get; set; }

        [DataMember(Name = "ownershipConfirmationIndicator")]
        public bool? OwnershipConfirmationIndicator { get; set; }

        [DataMember(Name = "ownershipFormatType")]
        public string OwnershipFormatType { get; set; }

        [DataMember(Name = "ownershipPartyRoleIdentifier")]
        public string OwnershipPartyRoleIdentifier { get; set; }

        [DataMember(Name = "urla2020CountryOfCitizenship")]
        public string Urla2020CountryOfCitizenship { get; set; }

        [DataMember(Name = "priorResidenceDoesNotApply")]
        public bool? PriorResidenceDoesNotApply { get; set; }

        [DataMember(Name = "partyToLawsuitIndicator")]
        public bool? PartyToLawsuitIndicator { get; set; }

        [DataMember(Name = "partyToLawsuitIndicatorUrla")]
        public bool? PartyToLawsuitIndicatorUrla { get; set; }

        [DataMember(Name = "pass120Days")]
        public int? Pass120Days { get; set; }

        [DataMember(Name = "pass150Days")]
        public int? Pass150Days { get; set; }

        [DataMember(Name = "pass30Days")]
        public int? Pass30Days { get; set; }

        [DataMember(Name = "pass60Days")]
        public int? Pass60Days { get; set; }

        [DataMember(Name = "pass90Days")]
        public int? Pass90Days { get; set; }

        [DataMember(Name = "pensionRetireIncomeMessage")]
        public string PensionRetireIncomeMessage { get; set; }

        [DataMember(Name = "personFaxNumber")]
        public string PersonFaxNumber { get; set; }

        [DataMember(Name = "personHoursPerWeek")]
        public decimal? PersonHoursPerWeek { get; set; }

        [DataMember(Name = "personIncomeAmount")]
        public decimal? PersonIncomeAmount { get; set; }

        [DataMember(Name = "personIncomeFrequencyType")]
        public string PersonIncomeFrequencyType { get; set; }

        [DataMember(Name = "personMonthlyIncome")]
        public decimal? PersonMonthlyIncome { get; set; }

        [DataMember(Name = "piwAccepted")]
        public bool? PiwAccepted { get; set; }

        [DataMember(Name = "piwMessage")]
        public string PiwMessage { get; set; }

        [DataMember(Name = "poaOccupancyIntent")]
        public string PoaOccupancyIntent { get; set; }

        [DataMember(Name = "poaSignatureText")]
        public string PoaSignatureText { get; set; }

        [DataMember(Name = "positiveCashFlow")]
        public decimal? PositiveCashFlow { get; set; }

        [DataMember(Name = "powerOfAttorneyName")]
        public string PowerOfAttorneyName { get; set; }

        [DataMember(Name = "powerOfAttorneyTitleDescription")]
        public string PowerOfAttorneyTitleDescription { get; set; }

        [DataMember(Name = "presentlyDelinquentIndicator")]
        public bool? PresentlyDelinquentIndicator { get; set; }

        [DataMember(Name = "presentlyDelinquentIndicatorUrla")]
        public bool? PresentlyDelinquentIndicatorUrla { get; set; }

        [DataMember(Name = "previousEmploymentDoesNotApply")]
        public bool? PreviousEmploymentDoesNotApply { get; set; }

        [DataMember(Name = "previousGrossMonthlyIncome")]
        public decimal? PreviousGrossMonthlyIncome { get; set; }

        [DataMember(Name = "additionalInformation")]
        public string AdditionalInformation { get; set; }

        [DataMember(Name = "printOnAdditionalBorrowerPage")]
        public bool? PrintOnAdditionalBorrowerPage { get; set; }

        [DataMember(Name = "priorBankruptcy2")]
        public string PriorBankruptcy2 { get; set; }

        [DataMember(Name = "priorForeclosure")]
        public bool? PriorForeclosure { get; set; }

        [DataMember(Name = "priorPropertyDeedInLieuConveyedIndicator")]
        public bool? PriorPropertyDeedInLieuConveyedIndicator { get; set; }

        [DataMember(Name = "priorPropertyForeclosureCompletedIndicator")]
        public bool? PriorPropertyForeclosureCompletedIndicator { get; set; }

        [DataMember(Name = "priorPropertyShortSaleCompletedIndicator")]
        public bool? PriorPropertyShortSaleCompletedIndicator { get; set; }

        [DataMember(Name = "priorPropertyTitleType")]
        public string PriorPropertyTitleType { get; set; }

        [DataMember(Name = "priorPropertyUsageType")]
        public string PriorPropertyUsageType { get; set; }

        [DataMember(Name = "propertyForeclosedPastSevenYearsIndicator")]
        public bool? PropertyForeclosedPastSevenYearsIndicator { get; set; }

        [DataMember(Name = "propertyProposedCleanEnergyLienIndicator")]
        public bool? PropertyProposedCleanEnergyLienIndicator { get; set; }

        [DataMember(Name = "realEstateDoesNotApply")]
        public bool? RealEstateDoesNotApply { get; set; }

        [DataMember(Name = "relationshipDescription")]
        public string RelationshipDescription { get; set; }

        [DataMember(Name = "relationshipWithRdEmployeeIndicator")]
        public bool? RelationshipWithRdEmployeeIndicator { get; set; }

        [DataMember(Name = "reserveNationalGuardReserveActivated")]
        public bool? ReserveNationalGuardReserveActivated { get; set; }

        [DataMember(Name = "residences")]
        public List<ResidenceContract> Residences { get; set; }

        [DataMember(Name = "retirementPensionIncomeAvailable")]
        public bool? RetirementPensionIncomeAvailable { get; set; }

        [DataMember(Name = "schoolingTermYears")]
        public int? SchoolingTermYears { get; set; }

        [DataMember(Name = "selfDeclaredMilitaryServiceIndicator")]
        public bool? SelfDeclaredMilitaryServiceIndicator { get; set; }

        [DataMember(Name = "selfEmployedValidationMessage")]
        public string SelfEmployedValidationMessage { get; set; }

        [DataMember(Name = "sectionAExplanation")]
        public string SectionAExplanation { get; set; }

        [DataMember(Name = "sectionBExplanation")]
        public string SectionBExplanation { get; set; }

        [DataMember(Name = "sectionCExplanation")]
        public string SectionCExplanation { get; set; }

        [DataMember(Name = "sectionDExplanation")]
        public string SectionDExplanation { get; set; }

        [DataMember(Name = "sectionD2Explanation")]
        public string SectionD2Explanation { get; set; }

        [DataMember(Name = "sectionEExplanation")]
        public string SectionEExplanation { get; set; }

        [DataMember(Name = "sectionFExplanation")]
        public string SectionFExplanation { get; set; }

        [DataMember(Name = "sectionGExplanation")]
        public string SectionGExplanation { get; set; }

        [DataMember(Name = "sectionHExplanation")]
        public string SectionHExplanation { get; set; }

        [DataMember(Name = "sectionIExplanation")]
        public string SectionIExplanation { get; set; }

        [DataMember(Name = "sectionJExplanation")]
        public string SectionJExplanation { get; set; }

        [DataMember(Name = "sectionKExplanation")]
        public string SectionKExplanation { get; set; }

        [DataMember(Name = "sectionLExplanation")]
        public string SectionLExplanation { get; set; }

        [DataMember(Name = "sectionMExplanation")]
        public string SectionMExplanation { get; set; }

        [DataMember(Name = "specialBorrowerSellerRelationshipIndicator")]
        public bool? SpecialBorrowerSellerRelationshipIndicator { get; set; }

        [DataMember(Name = "spousalVaBenefitsEligibilityIndicator")]
        public bool? SpousalVaBenefitsEligibilityIndicator { get; set; }

        [DataMember(Name = "ssa89MortgageServiceIndicator")]
        public bool? Ssa89MortgageServiceIndicator { get; set; }

        [DataMember(Name = "ssa89BankingServiceIndicator")]
        public bool? Ssa89BankingServiceIndicator { get; set; }

        [DataMember(Name = "ssa89BackgroundCheckIndicator")]
        public bool? Ssa89BackgroundCheckIndicator { get; set; }

        [DataMember(Name = "ssa89LicenseRequirementIndicator")]
        public bool? Ssa89LicenseRequirementIndicator { get; set; }

        [DataMember(Name = "ssa89CreditCheckIndicator")]
        public bool? Ssa89CreditCheckIndicator { get; set; }

        [DataMember(Name = "ssa89OtherIndicator")]
        public bool? Ssa89OtherIndicator { get; set; }

        [DataMember(Name = "ssa89OpenRetirementAcct")]
        public bool? Ssa89OpenRetirementAcct { get; set; }

        [DataMember(Name = "ssa89ApplyForLoan")]
        public bool? Ssa89ApplyForLoan { get; set; }

        [DataMember(Name = "ssa89DescriptionForOther")]
        public string Ssa89DescriptionForOther { get; set; }

        [DataMember(Name = "ssnValidationMessage")]
        public string SsnValidationMessage { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "subtotalLiquidAssetsMinusGiftAmount")]
        public decimal? SubtotalLiquidAssetsMinusGiftAmount { get; set; }

        [DataMember(Name = "suffixToName")]
        public string SuffixToName { get; set; }

        [DataMember(Name = "sectionAprintexplanation")]
        public bool? SectionAprintexplanation { get; set; }

        [DataMember(Name = "sectionBprintexplanation")]
        public bool? SectionBprintexplanation { get; set; }

        [DataMember(Name = "sectionCprintexplanation")]
        public bool? SectionCprintexplanation { get; set; }

        [DataMember(Name = "sectionD1printexplanation")]
        public bool? SectionD1printexplanation { get; set; }

        [DataMember(Name = "sectionD2printexplanation")]
        public bool? SectionD2printexplanation { get; set; }

        [DataMember(Name = "sectionEprintexplanation")]
        public bool? SectionEprintexplanation { get; set; }

        [DataMember(Name = "sectionFprintexplanation")]
        public bool? SectionFprintexplanation { get; set; }

        [DataMember(Name = "sectionGprintexplanation")]
        public bool? SectionGprintexplanation { get; set; }

        [DataMember(Name = "sectionHprintexplanation")]
        public bool? SectionHprintexplanation { get; set; }

        [DataMember(Name = "sectionIprintexplanation")]
        public bool? SectionIprintexplanation { get; set; }

        [DataMember(Name = "sectionJprintexplanation")]
        public bool? SectionJprintexplanation { get; set; }

        [DataMember(Name = "sectionKprintexplanation")]
        public bool? SectionKprintexplanation { get; set; }

        [DataMember(Name = "sectionLprintexplanation")]
        public bool? SectionLprintexplanation { get; set; }

        [DataMember(Name = "sectionMprintexplanation")]
        public bool? SectionMprintexplanation { get; set; }

        [DataMember(Name = "tax4506LastInvestor")]
        public string Tax4506LastInvestor { get; set; }

        [DataMember(Name = "tax4506LastOrderNumber")]
        public string Tax4506LastOrderNumber { get; set; }

        [DataMember(Name = "tax4506LastOrderYear1")]
        public int? Tax4506LastOrderYear1 { get; set; }

        [DataMember(Name = "tax4506LastOrderYear2")]
        public int? Tax4506LastOrderYear2 { get; set; }

        [DataMember(Name = "tax4506LastOrderYear3")]
        public int? Tax4506LastOrderYear3 { get; set; }

        [DataMember(Name = "tax4506LastOrderYear4")]
        public int? Tax4506LastOrderYear4 { get; set; }

        [DataMember(Name = "tax4506LastProductsOrdered")]
        public string Tax4506LastProductsOrdered { get; set; }

        [DataMember(Name = "tax4506LastStatus")]
        public string Tax4506LastStatus { get; set; }

        [DataMember(Name = "tax4506LastTranscriptType")]
        public string Tax4506LastTranscriptType { get; set; }

        [DataMember(Name = "tax4506LastUserIdWhoOrdered")]
        public string Tax4506LastUserIdWhoOrdered { get; set; }

        [DataMember(Name = "tax4506TotalYearlyIncome1")]
        public decimal? Tax4506TotalYearlyIncome1 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyIncome2")]
        public decimal? Tax4506TotalYearlyIncome2 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyIncome3")]
        public decimal? Tax4506TotalYearlyIncome3 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyIncome4")]
        public decimal? Tax4506TotalYearlyIncome4 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyJointIncome1")]
        public decimal? Tax4506TotalYearlyJointIncome1 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyJointIncome2")]
        public decimal? Tax4506TotalYearlyJointIncome2 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyJointIncome3")]
        public decimal? Tax4506TotalYearlyJointIncome3 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyJointIncome4")]
        public decimal? Tax4506TotalYearlyJointIncome4 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceIncome1")]
        public decimal? Tax4506TotalYearlyVarianceIncome1 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceIncome2")]
        public decimal? Tax4506TotalYearlyVarianceIncome2 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceIncome3")]
        public decimal? Tax4506TotalYearlyVarianceIncome3 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceIncome4")]
        public decimal? Tax4506TotalYearlyVarianceIncome4 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceJointIncome1")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceJointIncome2")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceJointIncome3")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get; set; }

        [DataMember(Name = "tax4506TotalYearlyVarianceJointIncome4")]
        public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get; set; }

        [DataMember(Name = "taxIdentificationIdentifier")]
        public string TaxIdentificationIdentifier { get; set; }

        [DataMember(Name = "taxReturnValidationMessage")]
        public string TaxReturnValidationMessage { get; set; }

        [DataMember(Name = "totalAdditionalLiabilitiesAmount")]
        public decimal? TotalAdditionalLiabilitiesAmount { get; set; }

        [DataMember(Name = "totalAdditionalOtherLiabilitiesAmount")]
        public decimal? TotalAdditionalOtherLiabilitiesAmount { get; set; }

        [DataMember(Name = "totalAnnualIncome")]
        public decimal? TotalAnnualIncome { get; set; }

        [DataMember(Name = "totalAssets")]
        public decimal? TotalAssets { get; set; }

        [DataMember(Name = "totalGrossMonthlySalary")]
        public decimal? TotalGrossMonthlySalary { get; set; }

        [DataMember(Name = "totalLiabilitiesAmount")]
        public decimal? TotalLiabilitiesAmount { get; set; }

        [DataMember(Name = "totalLiabilitiesBalanceAmount")]
        public decimal? TotalLiabilitiesBalanceAmount { get; set; }

        [DataMember(Name = "totalMonthlyIncomeAmount")]
        public decimal? TotalMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "totalMonthlyIncomeMinusNetRentalAmount")]
        public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get; set; }

        [DataMember(Name = "totalOtherAssets")]
        public decimal? TotalOtherAssets { get; set; }

        [DataMember(Name = "totalOtherIncome")]
        public decimal? TotalOtherIncome { get; set; }

        [DataMember(Name = "totalOtherLiabilities")]
        public decimal? TotalOtherLiabilities { get; set; }

        [DataMember(Name = "totalOtherLiabilitiesAmount")]
        public decimal? TotalOtherLiabilitiesAmount { get; set; }

        [DataMember(Name = "totalOtherMonthlyLiability")]
        public decimal? TotalOtherMonthlyLiability { get; set; }

        [DataMember(Name = "totalPresentHousingExpenseAmount")]
        public decimal? TotalPresentHousingExpenseAmount { get; set; }

        [DataMember(Name = "transactionPurposeDescription")]
        public string TransactionPurposeDescription { get; set; }

        [DataMember(Name = "transUnion120Days")]
        public int? TransUnion120Days { get; set; }

        [DataMember(Name = "transUnion150Days")]
        public int? TransUnion150Days { get; set; }

        [DataMember(Name = "transUnion30Days")]
        public int? TransUnion30Days { get; set; }

        [DataMember(Name = "transUnion60Days")]
        public int? TransUnion60Days { get; set; }

        [DataMember(Name = "transUnion90Days")]
        public int? TransUnion90Days { get; set; }

        [DataMember(Name = "transUnionCreditScoreForDisclosure")]
        public bool? TransUnionCreditScoreForDisclosure { get; set; }

        [DataMember(Name = "transUnionCreditScoreRanksPercent")]
        public int? TransUnionCreditScoreRanksPercent { get; set; }

        [DataMember(Name = "transUnionDatePulled")]
        public string TransUnionDatePulled { get; set; }

        [DataMember(Name = "transUnionFactorCode1")]
        public string TransUnionFactorCode1 { get; set; }

        [DataMember(Name = "transUnionFactorCode2")]
        public string TransUnionFactorCode2 { get; set; }

        [DataMember(Name = "transUnionFactorCode3")]
        public string TransUnionFactorCode3 { get; set; }

        [DataMember(Name = "transUnionFactorCode4")]
        public string TransUnionFactorCode4 { get; set; }

        [DataMember(Name = "transUnionFactorCode5")]
        public string TransUnionFactorCode5 { get; set; }

        [DataMember(Name = "transUnionKeyFactor1")]
        public string TransUnionKeyFactor1 { get; set; }

        [DataMember(Name = "transUnionKeyFactor2")]
        public string TransUnionKeyFactor2 { get; set; }

        [DataMember(Name = "transUnionKeyFactor3")]
        public string TransUnionKeyFactor3 { get; set; }

        [DataMember(Name = "transUnionKeyFactor4")]
        public string TransUnionKeyFactor4 { get; set; }

        [DataMember(Name = "transUnionKeyFactor5")]
        public bool? TransUnionKeyFactor5 { get; set; }

        [DataMember(Name = "transUnionMaterialTermsCreditByScore")]
        public bool? TransUnionMaterialTermsCreditByScore { get; set; }

        [DataMember(Name = "transUnionScore")]
        public string TransUnionScore { get; set; }

        [DataMember(Name = "undisclosedBorrowedFundsAmount")]
        public decimal? UndisclosedBorrowedFundsAmount { get; set; }

        [DataMember(Name = "undisclosedBorrowedFundsIndicator")]
        public bool? UndisclosedBorrowedFundsIndicator { get; set; }

        [DataMember(Name = "undisclosedCreditApplicationIndicator")]
        public bool? UndisclosedCreditApplicationIndicator { get; set; }

        [DataMember(Name = "undisclosedComakerOfNoteIndicator")]
        public bool? UndisclosedComakerOfNoteIndicator { get; set; }

        [DataMember(Name = "undisclosedMortgageApplicationIndicator")]
        public bool? UndisclosedMortgageApplicationIndicator { get; set; }

        [DataMember(Name = "urlaAliasName")]
        public string UrlaAliasName { get; set; }

        [DataMember(Name = "urlaAlternateNames")]
        public List<UrlaAlternateNameContract> UrlaAlternateNames { get; set; }

        [DataMember(Name = "urla2020CitizenshipResidencyType")]
        public string Urla2020CitizenshipResidencyType { get; set; }

        [DataMember(Name = "userDefinedIncome")]
        public decimal? UserDefinedIncome { get; set; }

        [DataMember(Name = "vaFederalTaxAmount")]
        public decimal? VaFederalTaxAmount { get; set; }

        [DataMember(Name = "validDaysForConsentCount")]
        public int? ValidDaysForConsentCount { get; set; }

        [DataMember(Name = "valueRepAndWarrantyAvailable")]
        public bool? ValueRepAndWarrantyAvailable { get; set; }

        [DataMember(Name = "valueRepAndWarrantyMessage")]
        public string ValueRepAndWarrantyMessage { get; set; }

        [DataMember(Name = "vaNetTakeHomePayAmount")]
        public decimal? VaNetTakeHomePayAmount { get; set; }

        [DataMember(Name = "vaOtherAmount")]
        public decimal? VaOtherAmount { get; set; }

        [DataMember(Name = "vaOtherNetIncomeAmount")]
        public decimal? VaOtherNetIncomeAmount { get; set; }

        [DataMember(Name = "vaRetirementAmount")]
        public decimal? VaRetirementAmount { get; set; }

        [DataMember(Name = "vaStateTaxAmount")]
        public decimal? VaStateTaxAmount { get; set; }

        [DataMember(Name = "vaTotalIncomeDeductionsAmount")]
        public decimal? VaTotalIncomeDeductionsAmount { get; set; }

        [DataMember(Name = "vaTotalNetIncomeAmount")]
        public decimal? VaTotalNetIncomeAmount { get; set; }

        [DataMember(Name = "vendor1")]
        public string Vendor1 { get; set; }

        [DataMember(Name = "vendor2")]
        public string Vendor2 { get; set; }

        [DataMember(Name = "vendor3")]
        public string Vendor3 { get; set; }

        [DataMember(Name = "vendor4")]
        public string Vendor4 { get; set; }

        [DataMember(Name = "vendor5")]
        public string Vendor5 { get; set; }

        [DataMember(Name = "vendor6")]
        public string Vendor6 { get; set; }

        [DataMember(Name = "vendor7")]
        public string Vendor7 { get; set; }

        [DataMember(Name = "vendor8")]
        public string Vendor8 { get; set; }

        [DataMember(Name = "vendor9")]
        public string Vendor9 { get; set; }

        [DataMember(Name = "vendor10")]
        public string Vendor10 { get; set; }

        [DataMember(Name = "vendor11")]
        public string Vendor11 { get; set; }

        [DataMember(Name = "vendor12")]
        public string Vendor12 { get; set; }

        [DataMember(Name = "vendor13")]
        public string Vendor13 { get; set; }

        [DataMember(Name = "vendor14")]
        public string Vendor14 { get; set; }

        [DataMember(Name = "vendor15")]
        public string Vendor15 { get; set; }

        [DataMember(Name = "vendor16")]
        public string Vendor16 { get; set; }

        [DataMember(Name = "vendor17")]
        public string Vendor17 { get; set; }

        [DataMember(Name = "vendor18")]
        public string Vendor18 { get; set; }

        [DataMember(Name = "vendor19")]
        public string Vendor19 { get; set; }

        [DataMember(Name = "vendor20")]
        public string Vendor20 { get; set; }

        [DataMember(Name = "vendor21")]
        public string Vendor21 { get; set; }

        [DataMember(Name = "vendor22")]
        public string Vendor22 { get; set; }

        [DataMember(Name = "vendor23")]
        public string Vendor23 { get; set; }

        [DataMember(Name = "vendor24")]
        public string Vendor24 { get; set; }

        [DataMember(Name = "vendor25")]
        public string Vendor25 { get; set; }

        [DataMember(Name = "vendor26")]
        public string Vendor26 { get; set; }

        [DataMember(Name = "vendor27")]
        public string Vendor27 { get; set; }

        [DataMember(Name = "vendor28")]
        public string Vendor28 { get; set; }

        [DataMember(Name = "vendor29")]
        public string Vendor29 { get; set; }

        [DataMember(Name = "vendor30")]
        public string Vendor30 { get; set; }

        [DataMember(Name = "vendor31")]
        public string Vendor31 { get; set; }

        [DataMember(Name = "vendor32")]
        public string Vendor32 { get; set; }

        [DataMember(Name = "vendor33")]
        public string Vendor33 { get; set; }

        [DataMember(Name = "vendor34")]
        public string Vendor34 { get; set; }

        [DataMember(Name = "vendor35")]
        public string Vendor35 { get; set; }

        [DataMember(Name = "vendor36")]
        public string Vendor36 { get; set; }

        [DataMember(Name = "vendor37")]
        public string Vendor37 { get; set; }

        [DataMember(Name = "vendor38")]
        public string Vendor38 { get; set; }

        [DataMember(Name = "vendor39")]
        public string Vendor39 { get; set; }

        [DataMember(Name = "vendor40")]
        public string Vendor40 { get; set; }

        [DataMember(Name = "dataVerify")]
        public string DataVerify { get; set; }

        [DataMember(Name = "vestingTrusteeOfType")]
        public string VestingTrusteeOfType { get; set; }

        [DataMember(Name = "veteran")]
        public bool? Veteran { get; set; }

        [DataMember(Name = "veteranIndicator")]
        public bool? VeteranIndicator { get; set; }

        [DataMember(Name = "workEmailAddress")]
        public string WorkEmailAddress { get; set; }

        [DataMember(Name = "yearsofCreditOnFile")]
        public int? YearsofCreditOnFile { get; set; }

        [DataMember(Name = "workPhoneNumber")]
        public string WorkPhoneNumber { get; set; }

        [DataMember(Name = "leDeliveryMethod")]
        public string LeDeliveryMethod { get; set; }

        [DataMember(Name = "cdDeliveryMethod")]
        public string CdDeliveryMethod { get; set; }

        [DataMember(Name = "counselingConfirmationType")]
        public string CounselingConfirmationType { get; set; }

        [DataMember(Name = "counselingConfirmationTypeDescription")]
        public string CounselingConfirmationTypeDescription { get; set; }

        [DataMember(Name = "counselingFormatTypeDescription")]
        public string CounselingFormatTypeDescription { get; set; }

        [DataMember(Name = "initial1003Provided")]
        public bool? Initial1003Provided { get; set; }

        [DataMember(Name = "final1003Provided")]
        public bool? Final1003Provided { get; set; }

        [DataMember(Name = "leaveAndEarningsStatement")]
        public bool? LeaveAndEarningsStatement { get; set; }

        [DataMember(Name = "vvoeWorkNumberDate")]
        public string VvoeWorkNumberDate { get; set; }

        [DataMember(Name = "rwtFannieVoe1Description")]
        public string RwtFannieVoe1Description { get; set; }

        [DataMember(Name = "rwtFannieVoe2Description")]
        public string RwtFannieVoe2Description { get; set; }

        [DataMember(Name = "rwtFannieVoe3Description")]
        public string RwtFannieVoe3Description { get; set; }

        [DataMember(Name = "rwtFannieVoe2Status")]
        public string RwtFannieVoe2Status { get; set; }

        [DataMember(Name = "rwtFannieVoe3Status")]
        public string RwtFannieVoe3Status { get; set; }

        [DataMember(Name = "rwtFannieVoe1Date")]
        public string RwtFannieVoe1Date { get; set; }

        [DataMember(Name = "rwtFannieVoe2Date")]
        public string RwtFannieVoe2Date { get; set; }

        [DataMember(Name = "rwtFannieVoe3Date")]
        public string RwtFannieVoe3Date { get; set; }

        [DataMember(Name = "rwtFannieVoe2Message")]
        public string RwtFannieVoe2Message { get; set; }

        [DataMember(Name = "rwtFannieVoe3Message")]
        public string RwtFannieVoe3Message { get; set; }

        [DataMember(Name = "rwtFreddieVoe1Description")]
        public string RwtFreddieVoe1Description { get; set; }

        [DataMember(Name = "rwtFreddieVoe2Description")]
        public string RwtFreddieVoe2Description { get; set; }

        [DataMember(Name = "rwtFreddieVoe3Description")]
        public string RwtFreddieVoe3Description { get; set; }

        [DataMember(Name = "rwtFreddieVoe1Status")]
        public string RwtFreddieVoe1Status { get; set; }

        [DataMember(Name = "rwtFreddieVoe2Status")]
        public string RwtFreddieVoe2Status { get; set; }

        [DataMember(Name = "rwtFreddieVoe3Status")]
        public string RwtFreddieVoe3Status { get; set; }

        [DataMember(Name = "rwtFreddieVoe1Date")]
        public string RwtFreddieVoe1Date { get; set; }

        [DataMember(Name = "rwtFreddieVoe2Date")]
        public string RwtFreddieVoe2Date { get; set; }

        [DataMember(Name = "rwtFreddieVoe3Date")]
        public string RwtFreddieVoe3Date { get; set; }

        [DataMember(Name = "rwtFreddieVoe1Message")]
        public string RwtFreddieVoe1Message { get; set; }

        [DataMember(Name = "rwtFreddieVoe2Message")]
        public string RwtFreddieVoe2Message { get; set; }

        [DataMember(Name = "rwtFreddieVoe3Message")]
        public string RwtFreddieVoe3Message { get; set; }

        [DataMember(Name = "rwtFannieVoiBaseIncomeDate")]
        public string RwtFannieVoiBaseIncomeDate { get; set; }

        [DataMember(Name = "rwtFannieVoiBonusDate")]
        public string RwtFannieVoiBonusDate { get; set; }

        [DataMember(Name = "rwtFannieVoiOvertimeDate")]
        public string RwtFannieVoiOvertimeDate { get; set; }

        [DataMember(Name = "rwtFannieVoiCommissionDate")]
        public string RwtFannieVoiCommissionDate { get; set; }

        [DataMember(Name = "rwtFannieVoiSocialSecurityDate")]
        public string RwtFannieVoiSocialSecurityDate { get; set; }

        [DataMember(Name = "rwtFannieVoiRetirementDate")]
        public string RwtFannieVoiRetirementDate { get; set; }

        [DataMember(Name = "rwtFannieVoiSelfEmployedDate")]
        public string RwtFannieVoiSelfEmployedDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiPayrollStatus")]
        public string RwtFreddieVoiPayrollStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiPensionStatus")]
        public string RwtFreddieVoiPensionStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiSocialSecurityStatus")]
        public string RwtFreddieVoiSocialSecurityStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiVaBenefitsStatus")]
        public string RwtFreddieVoiVaBenefitsStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiMilitaryStatus")]
        public string RwtFreddieVoiMilitaryStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiChildSupportStatus")]
        public string RwtFreddieVoiChildSupportStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiSelfEmployedStatus")]
        public string RwtFreddieVoiSelfEmployedStatus { get; set; }

        [DataMember(Name = "rwtFreddieVoiPayrollDate")]
        public string RwtFreddieVoiPayrollDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiPensionDate")]
        public string RwtFreddieVoiPensionDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiSocialSecurityDate")]
        public string RwtFreddieVoiSocialSecurityDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiVaBenefitsDate")]
        public string RwtFreddieVoiVaBenefitsDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiMilitaryDate")]
        public string RwtFreddieVoiMilitaryDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiChildSupportDate")]
        public string RwtFreddieVoiChildSupportDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiSelfEmployedDate")]
        public string RwtFreddieVoiSelfEmployedDate { get; set; }

        [DataMember(Name = "rwtFreddieVoiPayrollMessage")]
        public string RwtFreddieVoiPayrollMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiPensionMessage")]
        public string RwtFreddieVoiPensionMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiSocialSecurityMessage")]
        public string RwtFreddieVoiSocialSecurityMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiVaBenefitsMessage")]
        public string RwtFreddieVoiVaBenefitsMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiMilitaryMessage")]
        public string RwtFreddieVoiMilitaryMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiChildSupportMessage")]
        public string RwtFreddieVoiChildSupportMessage { get; set; }

        [DataMember(Name = "rwtFreddieVoiSelfEmployedMessage")]
        public string RwtFreddieVoiSelfEmployedMessage { get; set; }
    }
}
