using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractBorrower
	{
		[DataMember(Name="acountChekAssetId")]
		public string AcountChekAssetId { get; set; }

		[DataMember(Name="additionalIncomeFromPrimaryEmployment")]
		public decimal? AdditionalIncomeFromPrimaryEmployment { get; set; }

		[DataMember(Name="adjustedAnnualIncome")]
		public decimal? AdjustedAnnualIncome { get; set; }

		[DataMember(Name="ageAtApplicationYearsCount")]
		public int? AgeAtApplicationYearsCount { get; set; }

		[DataMember(Name="aliasName")]
		public string AliasName { get; set; }

		[DataMember(Name="alimonyChildSupportObligationIndicator")]
		public bool? AlimonyChildSupportObligationIndicator { get; set; }

		[DataMember(Name="altId")]
		public string AltId { get; set; }

		[DataMember(Name="annualIncome")]
		public decimal? AnnualIncome { get; set; }

		[DataMember(Name="applicantType")]
		public string ApplicantType { get; set; }

		[DataMember(Name="applicationTakenMethodType")]
		public string ApplicationTakenMethodType { get; set; }

		[DataMember(Name="assetIncome")]
		public decimal? AssetIncome { get; set; }

		[DataMember(Name="assetRepAndWarrantyMessage")]
		public string AssetRepAndWarrantyMessage { get; set; }

		[DataMember(Name="assetRepAndWarrantyReliefAvailable")]
		public bool? AssetRepAndWarrantyReliefAvailable { get; set; }

		[DataMember(Name="authorizedCreditReportIndicator")]
		public bool? AuthorizedCreditReportIndicator { get; set; }

		[DataMember(Name="authorizedToSignIndicator")]
		public bool? AuthorizedToSignIndicator { get; set; }

		[DataMember(Name="bankAccountNumber")]
		public string BankAccountNumber { get; set; }

		[DataMember(Name="bankAccountType")]
		public string BankAccountType { get; set; }

		[DataMember(Name="bankContactAddress")]
		public string BankContactAddress { get; set; }

		[DataMember(Name="bankContactCity")]
		public string BankContactCity { get; set; }

		[DataMember(Name="bankContactName")]
		public string BankContactName { get; set; }

		[DataMember(Name="bankContactPostalCode")]
		public string BankContactPostalCode { get; set; }

		[DataMember(Name="bankContactState")]
		public string BankContactState { get; set; }

		[DataMember(Name="bankruptcyIndicator")]
		public bool? BankruptcyIndicator { get; set; }

		[DataMember(Name="bankruptcyStatus")]
		public string BankruptcyStatus { get; set; }

		[DataMember(Name="baseIncome")]
		public decimal? BaseIncome { get; set; }

		[DataMember(Name="baseIncomeValidationMessage")]
		public string BaseIncomeValidationMessage { get; set; }

		[DataMember(Name="baseMonthlyIncomeAmount")]
		public decimal? BaseMonthlyIncomeAmount { get; set; }

		[DataMember(Name="birthDate")]
		public DateTime? BirthDate { get; set; }

		[DataMember(Name="bonusValidationMessage")]
		public string BonusValidationMessage { get; set; }

		[DataMember(Name="borrowedDownPaymentIndicator")]
		public bool? BorrowedDownPaymentIndicator { get; set; }

		[DataMember(Name="borrowerConsentRequestDate")]
		public DateTime? BorrowerConsentRequestDate { get; set; }

		[DataMember(Name="borrowerIndex")]
		public int? BorrowerIndex { get; set; }

		[DataMember(Name="borrowerType")]
		public string BorrowerType { get; set; }

		[DataMember(Name="borrowerTypeInSummary")]
		public string BorrowerTypeInSummary { get; set; }

		[DataMember(Name="caivrsIdentifier")]
		public string CaivrsIdentifier { get; set; }

		[DataMember(Name= "citizenshipResidencyType")]
		public string CitizenshipResidencyType { get; set; }

		[DataMember(Name="coMakerEndorserOfNoteIndicator")]
		public bool? CoMakerEndorserOfNoteIndicator { get; set; }

		[DataMember(Name="commentOfCreditReport")]
		public string CommentOfCreditReport { get; set; }

		[DataMember(Name="commissionValidationMessage")]
		public string CommissionValidationMessage { get; set; }

		[DataMember(Name="confirmedCRBKEC")]
		public bool? ConfirmedCRBKEC { get; set; }

		[DataMember(Name="confirmedCRBKIncorrect")]
		public bool? ConfirmedCRBKIncorrect { get; set; }

		[DataMember(Name="confirmedCRDIL")]
		public bool? ConfirmedCRDIL { get; set; }

		[DataMember(Name="confirmedCRFCEC")]
		public bool? ConfirmedCRFCEC { get; set; }

		[DataMember(Name="confirmedCRFCIncorrect")]
		public bool? ConfirmedCRFCIncorrect { get; set; }

		[DataMember(Name="confirmedCRPFS")]
		public bool? ConfirmedCRPFS { get; set; }

		[DataMember(Name="confirmedMtgDelIncorrect")]
		public bool? ConfirmedMtgDelIncorrect { get; set; }

		[DataMember(Name="confirmedOther")]
		public bool? ConfirmedOther { get; set; }

		[DataMember(Name="confirmedOtherDescription")]
		public string ConfirmedOtherDescription { get; set; }

		[DataMember(Name="contact")]
		public EntityRefContract Contact { get; set; }

		[DataMember(Name="creditCounseling")]
		public bool? CreditCounseling { get; set; }

		[DataMember(Name="creditReceivedDate")]
		public DateTime? CreditReceivedDate { get; set; }

		[DataMember(Name="creditReportAuthorizationMethod")]
		public string CreditReportAuthorizationMethod { get; set; }

		[DataMember(Name="creditScoreIndicator")]
		public bool? CreditScoreIndicator { get; set; }

		[DataMember(Name="dateAuthorizedCreditReport")]
		public DateTime? DateAuthorizedCreditReport { get; set; }

		[DataMember(Name="dateOfBankruptcy")]
		public DateTime? DateOfBankruptcy { get; set; }

		[DataMember(Name="dateOfForeclosure")]
		public DateTime? DateOfForeclosure { get; set; }

		[DataMember(Name="declarationsJIndicator")]
		public bool? DeclarationsJIndicator { get; set; }

		[DataMember(Name="declarationsKIndicator")]
		public bool? DeclarationsKIndicator { get; set; }

		[DataMember(Name="dependentCount")]
		public int? DependentCount { get; set; }

		[DataMember(Name="dependentsAgesDescription")]
		public string DependentsAgesDescription { get; set; }

		[DataMember(Name="disabledIndicator")]
		public bool? DisabledIndicator { get; set; }

		[DataMember(Name="emailAddressText")]
		public string EmailAddressText { get; set; }

		[DataMember(Name="employmentVerificationAvailable")]
		public bool? EmploymentVerificationAvailable { get; set; }

		[DataMember(Name="employmentVerificationMessage")]
		public string EmploymentVerificationMessage { get; set; }

		[DataMember(Name="equifax120Days")]
		public int? Equifax120Days { get; set; }

		[DataMember(Name="equifax150Days")]
		public int? Equifax150Days { get; set; }

		[DataMember(Name="equifax30Days")]
		public int? Equifax30Days { get; set; }

		[DataMember(Name="equifax60Days")]
		public int? Equifax60Days { get; set; }

		[DataMember(Name="equifax90Days")]
		public int? Equifax90Days { get; set; }

		[DataMember(Name="equifaxCreditScoreForDisclosure")]
		public bool? EquifaxCreditScoreForDisclosure { get; set; }

		[DataMember(Name="equifaxCreditScoreRanksPercent")]
		public int? EquifaxCreditScoreRanksPercent { get; set; }

		[DataMember(Name="equifaxDatePulled")]
		public DateTime? EquifaxDatePulled { get; set; }

		[DataMember(Name="equifaxFactorCode1")]
		public string EquifaxFactorCode1 { get; set; }

		[DataMember(Name="equifaxFactorCode2")]
		public string EquifaxFactorCode2 { get; set; }

		[DataMember(Name="equifaxFactorCode3")]
		public string EquifaxFactorCode3 { get; set; }

		[DataMember(Name="equifaxFactorCode4")]
		public string EquifaxFactorCode4 { get; set; }

		[DataMember(Name="equifaxFactorCode5")]
		public string EquifaxFactorCode5 { get; set; }

		[DataMember(Name="equifaxKeyFactor1")]
		public string EquifaxKeyFactor1 { get; set; }

		[DataMember(Name="equifaxKeyFactor2")]
		public string EquifaxKeyFactor2 { get; set; }

		[DataMember(Name="equifaxKeyFactor3")]
		public string EquifaxKeyFactor3 { get; set; }

		[DataMember(Name="equifaxKeyFactor4")]
		public string EquifaxKeyFactor4 { get; set; }

		[DataMember(Name="equifaxKeyFactor5")]
		public string EquifaxKeyFactor5 { get; set; }

		[DataMember(Name="equifaxMaterialTermsCreditByScore")]
		public bool? EquifaxMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="equifaxScore")]
		public string EquifaxScore { get; set; }

		[DataMember(Name="experian120Days")]
		public int? Experian120Days { get; set; }

		[DataMember(Name="experian150Days")]
		public int? Experian150Days { get; set; }

		[DataMember(Name="experian30Days")]
		public int? Experian30Days { get; set; }

		[DataMember(Name="experian60Days")]
		public int? Experian60Days { get; set; }

		[DataMember(Name="experian90Days")]
		public int? Experian90Days { get; set; }

		[DataMember(Name="experianCreditScore")]
		public string ExperianCreditScore { get; set; }

		[DataMember(Name="experianCreditScoreForDisclosure")]
		public bool? ExperianCreditScoreForDisclosure { get; set; }

		[DataMember(Name="experianCreditScoreRanksPercent")]
		public int? ExperianCreditScoreRanksPercent { get; set; }

		[DataMember(Name="experianDatePulled")]
		public DateTime? ExperianDatePulled { get; set; }

		[DataMember(Name="experianFactorCode1")]
		public string ExperianFactorCode1 { get; set; }

		[DataMember(Name="experianFactorCode2")]
		public string ExperianFactorCode2 { get; set; }

		[DataMember(Name="experianFactorCode3")]
		public string ExperianFactorCode3 { get; set; }

		[DataMember(Name="experianFactorCode4")]
		public string ExperianFactorCode4 { get; set; }

		[DataMember(Name="experianFactorCode5")]
		public string ExperianFactorCode5 { get; set; }

		[DataMember(Name="experianKeyFactor1")]
		public string ExperianKeyFactor1 { get; set; }

		[DataMember(Name="experianKeyFactor2")]
		public string ExperianKeyFactor2 { get; set; }

		[DataMember(Name="experianKeyFactor3")]
		public string ExperianKeyFactor3 { get; set; }

		[DataMember(Name="experianKeyFactor4")]
		public string ExperianKeyFactor4 { get; set; }

		[DataMember(Name="experianKeyFactor5")]
		public string ExperianKeyFactor5 { get; set; }

		[DataMember(Name="experianMaterialTermsCreditByScore")]
		public bool? ExperianMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="fannieFirstName")]
		public string FannieFirstName { get; set; }

		[DataMember(Name="fannieMiddleName")]
		public string FannieMiddleName { get; set; }

		[DataMember(Name="firstName")]
		public string FirstName { get; set; }

		[DataMember(Name="firstNameWithMiddleName")]
		public string FirstNameWithMiddleName { get; set; }

		[DataMember(Name="firstTimeHomeBuyer")]
		public bool? FirstTimeHomeBuyer { get; set; }

		[DataMember(Name="foreclosureSatisfied")]
		public DateTime? ForeclosureSatisfied { get; set; }

		[DataMember(Name="foreclosureStatus")]
		public string ForeclosureStatus { get; set; }

		[DataMember(Name="freddieMacPerson1")]
		public string FreddieMacPerson1 { get; set; }

		[DataMember(Name="freddieMacPerson2")]
		public string FreddieMacPerson2 { get; set; }

		[DataMember(Name="fullName")]
		public string FullName { get; set; }

		[DataMember(Name="fullNameWithSuffix")]
		public string FullNameWithSuffix { get; set; }

		[DataMember(Name="highestCreditLimit")]
		public decimal? HighestCreditLimit { get; set; }

		[DataMember(Name="hmda2003OtherRaceNationalOriginDescription")]
		public string Hmda2003OtherRaceNationalOriginDescription { get; set; }

		[DataMember(Name="hmda2003RaceNationalOriginType")]
		public string Hmda2003RaceNationalOriginType { get; set; }

		[DataMember(Name="hmdaAfricanAmericanIndicator")]
		public bool? HmdaAfricanAmericanIndicator { get; set; }

		[DataMember(Name="hmdaAge")]
		public string HmdaAge { get; set; }

		[DataMember(Name="hmdaAmericanIndianIndicator")]
		public bool? HmdaAmericanIndianIndicator { get; set; }

		[DataMember(Name="hmdaAmericanIndianTribe")]
		public string HmdaAmericanIndianTribe { get; set; }

		[DataMember(Name="hmdaAsianIndianIndicator")]
		public bool? HmdaAsianIndianIndicator { get; set; }

		[DataMember(Name="hmdaAsianIndicator")]
		public bool? HmdaAsianIndicator { get; set; }

		[DataMember(Name="hmdaAsianOtherRaceIndicator")]
		public bool? HmdaAsianOtherRaceIndicator { get; set; }

		[DataMember(Name="hmdaChineseIndicator")]
		public bool? HmdaChineseIndicator { get; set; }

		[DataMember(Name="hmdaCreditScoreForDecisionMaking")]
		public string HmdaCreditScoreForDecisionMaking { get; set; }

		[DataMember(Name="hmdaCreditScoringModel")]
		public string HmdaCreditScoringModel { get; set; }

		[DataMember(Name="hmdaCubanIndicator")]
		public bool? HmdaCubanIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityDoNotWishIndicator")]
		public bool? HmdaEthnicityDoNotWishIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityHispanicLatinoIndicator")]
		public bool? HmdaEthnicityHispanicLatinoIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityInfoNotProvided")]
		public bool? HmdaEthnicityInfoNotProvided { get; set; }

		[DataMember(Name="hmdaEthnicityNotApplicableIndicator")]
		public bool? HmdaEthnicityNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityNotHispanicLatinoIndicator")]
		public bool? HmdaEthnicityNotHispanicLatinoIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField1")]
		public string HmdaEthnicityReportedField1 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField2")]
		public string HmdaEthnicityReportedField2 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField3")]
		public string HmdaEthnicityReportedField3 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField4")]
		public string HmdaEthnicityReportedField4 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField5")]
		public string HmdaEthnicityReportedField5 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedFields")]
		public string HmdaEthnicityReportedFields { get; set; }

		[DataMember(Name="hmdaEthnicityType")]
		public string HmdaEthnicityType { get; set; }

		[DataMember(Name="hmdaFilipinoIndicator")]
		public bool? HmdaFilipinoIndicator { get; set; }

		[DataMember(Name="hmdaGenderType")]
		public string HmdaGenderType { get; set; }

		[DataMember(Name="hmdaGendertypeDoNotWishIndicator")]
		public bool? HmdaGendertypeDoNotWishIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeFemaleIndicator")]
		public bool? HmdaGendertypeFemaleIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeMaleIndicator")]
		public bool? HmdaGendertypeMaleIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeNotApplicableIndicator")]
		public bool? HmdaGendertypeNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaGuamanianOrChamorroIndicator")]
		public bool? HmdaGuamanianOrChamorroIndicator { get; set; }

		[DataMember(Name="hmdaHispanicLatinoOtherOriginIndicator")]
		public bool? HmdaHispanicLatinoOtherOriginIndicator { get; set; }

		[DataMember(Name="hmdaJapaneseIndicator")]
		public bool? HmdaJapaneseIndicator { get; set; }

		[DataMember(Name="hmdaKoreanIndicator")]
		public bool? HmdaKoreanIndicator { get; set; }

		[DataMember(Name="hmdaMexicanIndicator")]
		public bool? HmdaMexicanIndicator { get; set; }

		[DataMember(Name="hmdaNativeHawaiianIndicator")]
		public bool? HmdaNativeHawaiianIndicator { get; set; }

		[DataMember(Name="hmdaNoCoApplicantIndicator")]
		public bool? HmdaNoCoApplicantIndicator { get; set; }

		[DataMember(Name="hmdaNotApplicableIndicator")]
		public bool? HmdaNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaNotProvidedIndicator")]
		public bool? HmdaNotProvidedIndicator { get; set; }

		[DataMember(Name="hmdaOtherAsianRace")]
		public string HmdaOtherAsianRace { get; set; }

		[DataMember(Name="hmdaOtherHispanicLatinoOrigin")]
		public string HmdaOtherHispanicLatinoOrigin { get; set; }

		[DataMember(Name="hmdaOtherPacificIslanderRace")]
		public string HmdaOtherPacificIslanderRace { get; set; }

		[DataMember(Name="hmdaOtherScoringModel")]
		public string HmdaOtherScoringModel { get; set; }

		[DataMember(Name="hmdaPacificIslanderIndicator")]
		public bool? HmdaPacificIslanderIndicator { get; set; }

		[DataMember(Name="hmdaPacificIslanderOtherIndicator")]
		public bool? HmdaPacificIslanderOtherIndicator { get; set; }

		[DataMember(Name="hmdaPuertoRicanIndicator")]
		public bool? HmdaPuertoRicanIndicator { get; set; }

		[DataMember(Name="hmdaRaceDoNotWishProvideIndicator")]
		public bool? HmdaRaceDoNotWishProvideIndicator { get; set; }

		[DataMember(Name="hmdaRaceInfoNotProvided")]
		public bool? HmdaRaceInfoNotProvided { get; set; }

		[DataMember(Name="hmdaRaceReportedField1")]
		public string HmdaRaceReportedField1 { get; set; }

		[DataMember(Name="hmdaRaceReportedField2")]
		public string HmdaRaceReportedField2 { get; set; }

		[DataMember(Name="hmdaRaceReportedField3")]
		public string HmdaRaceReportedField3 { get; set; }

		[DataMember(Name="hmdaRaceReportedField4")]
		public string HmdaRaceReportedField4 { get; set; }

		[DataMember(Name="hmdaRaceReportedField5")]
		public string HmdaRaceReportedField5 { get; set; }

		[DataMember(Name="hmdaRaceReportedFields")]
		public string HmdaRaceReportedFields { get; set; }

		[DataMember(Name="hmdaRefusalIndicator")]
		public bool? HmdaRefusalIndicator { get; set; }

		[DataMember(Name="hmdaSamoanIndicator")]
		public bool? HmdaSamoanIndicator { get; set; }

		[DataMember(Name="hmdaSexInfoNotProvided")]
		public bool? HmdaSexInfoNotProvided { get; set; }

		[DataMember(Name="hmdaVietnameseIndicator")]
		public bool? HmdaVietnameseIndicator { get; set; }

		[DataMember(Name="hmdaWhiteIndicator")]
		public bool? HmdaWhiteIndicator { get; set; }

		[DataMember(Name="homeownerPastThreeYearsIndicator")]
		public bool? HomeownerPastThreeYearsIndicator { get; set; }

		[DataMember(Name="homePhoneNumber")]
		public string HomePhoneNumber { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="incomeRepAndWarrantyMessage")]
		public string IncomeRepAndWarrantyMessage { get; set; }

		[DataMember(Name="incomeRepAndWarrantyReliefAvailable")]
		public bool? IncomeRepAndWarrantyReliefAvailable { get; set; }

		[DataMember(Name="intentToOccupyIndicator")]
		public bool? IntentToOccupyIndicator { get; set; }

		[DataMember(Name="intuitReportId")]
		public string IntuitReportId { get; set; }

		[DataMember(Name="isBaseIncomeAvailable")]
		public bool? IsBaseIncomeAvailable { get; set; }

		[DataMember(Name="isBonusAvailable")]
		public bool? IsBonusAvailable { get; set; }

		[DataMember(Name="isBorrower")]
		public bool? IsBorrower { get; set; }

		[DataMember(Name="isCommissionAvailable")]
		public bool? IsCommissionAvailable { get; set; }

		[DataMember(Name="isEthnicityBasedOnVisual")]
		public string IsEthnicityBasedOnVisual { get; set; }

		[DataMember(Name="isOvertimeAvailable")]
		public bool? IsOvertimeAvailable { get; set; }

		[DataMember(Name="isRaceBasedOnVisual")]
		public string IsRaceBasedOnVisual { get; set; }

		[DataMember(Name="isSelfEmployed")]
		public bool? IsSelfEmployed { get; set; }

		[DataMember(Name="isSexBasedOnVisual")]
		public string IsSexBasedOnVisual { get; set; }

		[DataMember(Name="isSocialSecurityAvailable")]
		public bool? IsSocialSecurityAvailable { get; set; }

		[DataMember(Name="isTaxReturnAvailable")]
		public bool? IsTaxReturnAvailable { get; set; }

		[DataMember(Name="lastName")]
		public string LastName { get; set; }

		[DataMember(Name="lastNameWithSuffix")]
		public string LastNameWithSuffix { get; set; }

		[DataMember(Name="loanForeclosureOrJudgementIndicator")]
		public bool? LoanForeclosureOrJudgementIndicator { get; set; }

		[DataMember(Name="lpdGsa")]
		public string LpdGsa { get; set; }

		[DataMember(Name="mailingAddressSameAsPresentIndicator")]
		public bool? MailingAddressSameAsPresentIndicator { get; set; }

		[DataMember(Name="maritalStatusType")]
		public string MaritalStatusType { get; set; }

		[DataMember(Name="middleCreditScore")]
		public int? MiddleCreditScore { get; set; }

		[DataMember(Name="middleFicoScore")]
		public string MiddleFicoScore { get; set; }

		[DataMember(Name="middleName")]
		public string MiddleName { get; set; }

		[DataMember(Name="minFicoScore")]
		public string MinFicoScore { get; set; }

		[DataMember(Name="mobilePhone")]
		public string MobilePhone { get; set; }

		[DataMember(Name="mortgageOnCredit")]
		public bool? MortgageOnCredit { get; set; }

		[DataMember(Name="nameToObtainLoanFromRHS")]
		public string NameToObtainLoanFromRHS { get; set; }

		[DataMember(Name="nearestRelativeAddress")]
		public string NearestRelativeAddress { get; set; }

		[DataMember(Name="nearestRelativeCity")]
		public string NearestRelativeCity { get; set; }

		[DataMember(Name="nearestRelativeName")]
		public string NearestRelativeName { get; set; }

		[DataMember(Name="nearestRelativePhone")]
		public string NearestRelativePhone { get; set; }

		[DataMember(Name="nearestRelativePostalCode")]
		public string NearestRelativePostalCode { get; set; }

		[DataMember(Name="nearestRelativeRelationship")]
		public string NearestRelativeRelationship { get; set; }

		[DataMember(Name="nearestRelativeState")]
		public string NearestRelativeState { get; set; }

		[DataMember(Name="no3rdPartyEmailIndicator")]
		public bool? No3rdPartyEmailIndicator { get; set; }

		[DataMember(Name="noCoApplicantEthnicityIndicator")]
		public bool? NoCoApplicantEthnicityIndicator { get; set; }

		[DataMember(Name="noCoApplicantIndicator")]
		public bool? NoCoApplicantIndicator { get; set; }

		[DataMember(Name="noCoApplicantSexIndicator")]
		public bool? NoCoApplicantSexIndicator { get; set; }

		[DataMember(Name="numberofTradelines")]
		public int? NumberofTradelines { get; set; }

		[DataMember(Name="obtainLoanFromRHSIndicator")]
		public bool? ObtainLoanFromRHSIndicator { get; set; }

		[DataMember(Name="openBankruptcy2")]
		public string OpenBankruptcy2 { get; set; }

		[DataMember(Name="otherMonthlyIncomeAmount")]
		public decimal? OtherMonthlyIncomeAmount { get; set; }

		[DataMember(Name="otherSumAmount")]
		public decimal? OtherSumAmount { get; set; }

		[DataMember(Name="outstandingJudgementsIndicator")]
		public bool? OutstandingJudgementsIndicator { get; set; }

		[DataMember(Name="overtimeValidationMessage")]
		public string OvertimeValidationMessage { get; set; }

		[DataMember(Name="partyToLawsuitIndicator")]
		public bool? PartyToLawsuitIndicator { get; set; }

		[DataMember(Name="pass120Days")]
		public int? Pass120Days { get; set; }

		[DataMember(Name="pass150Days")]
		public int? Pass150Days { get; set; }

		[DataMember(Name="pass30Days")]
		public int? Pass30Days { get; set; }

		[DataMember(Name="pass60Days")]
		public int? Pass60Days { get; set; }

		[DataMember(Name="pass90Days")]
		public int? Pass90Days { get; set; }

		[DataMember(Name="pensionRetireIncomeMessage")]
		public string PensionRetireIncomeMessage { get; set; }

		[DataMember(Name="personFaxNumber")]
		public string PersonFaxNumber { get; set; }

		[DataMember(Name="personHoursPerWeek")]
		public decimal? PersonHoursPerWeek { get; set; }

		[DataMember(Name="personIncomeAmount")]
		public decimal? PersonIncomeAmount { get; set; }

		[DataMember(Name="personIncomeFrequencyType")]
		public string PersonIncomeFrequencyType { get; set; }

		[DataMember(Name="personMonthlyIncome")]
		public decimal? PersonMonthlyIncome { get; set; }

		[DataMember(Name="pIWAccepted")]
		public bool? PIWAccepted { get; set; }

		[DataMember(Name="pIWMessage")]
		public string PIWMessage { get; set; }

		[DataMember(Name="poaOccupancyIntent")]
		public string PoaOccupancyIntent { get; set; }

		[DataMember(Name="poaSignatureText")]
		public string PoaSignatureText { get; set; }

		[DataMember(Name="positiveCashFlow")]
		public decimal? PositiveCashFlow { get; set; }

		[DataMember(Name="powerOfAttorneyName")]
		public string PowerOfAttorneyName { get; set; }

		[DataMember(Name="powerOfAttorneyTitleDescription")]
		public string PowerOfAttorneyTitleDescription { get; set; }

		[DataMember(Name="presentlyDelinquentIndicator")]
		public bool? PresentlyDelinquentIndicator { get; set; }

		[DataMember(Name="priorBankruptcy2")]
		public DateTime? PriorBankruptcy2 { get; set; }

		[DataMember(Name="priorForeclosure")]
		public bool? PriorForeclosure { get; set; }

		[DataMember(Name="priorPropertyTitleType")]
		public string PriorPropertyTitleType { get; set; }

		[DataMember(Name="priorPropertyUsageType")]
		public string PriorPropertyUsageType { get; set; }

		[DataMember(Name="propertyForeclosedPastSevenYearsIndicator")]
		public bool? PropertyForeclosedPastSevenYearsIndicator { get; set; }

		[DataMember(Name="relationshipDescription")]
		public string RelationshipDescription { get; set; }

		[DataMember(Name="relationshipWithRDEmployeeIndicator")]
		public bool? RelationshipWithRDEmployeeIndicator { get; set; }

		[DataMember(Name="retirementPensionIncomeAvailable")]
		public bool? RetirementPensionIncomeAvailable { get; set; }

		[DataMember(Name="schoolingTermYears")]
		public int? SchoolingTermYears { get; set; }

		[DataMember(Name="selfEmployedValidationMessage")]
		public string SelfEmployedValidationMessage { get; set; }

		[DataMember(Name = "sectionAExplanation")]
		public bool? SectionAExplanation { get; set; }

		[DataMember(Name = "sectionBExplanation")]
		public bool? SectionBExplanation { get; set; }

		[DataMember(Name = "sectionCExplanation")]
		public bool? SectionCExplanation { get; set; }

		[DataMember(Name = "sectionDExplanation")]
		public bool? SectionDExplanation { get; set; }

		[DataMember(Name = "sectionD2Explanation")]
		public bool? SectionD2Explanation { get; set; }

		[DataMember(Name = "sectionEExplanation")]
		public bool? SectionEExplanation { get; set; }

		[DataMember(Name = "sectionFExplanation")]
		public bool? SectionFExplanation { get; set; }

		[DataMember(Name = "sectionGExplanation")]
		public bool? SectionGExplanation { get; set; }

		[DataMember(Name = "sectionHExplanation")]
		public bool? SectionHExplanation { get; set; }

		[DataMember(Name = "sectionIExplanation")]
		public bool? SectionIExplanation { get; set; }

		[DataMember(Name = "sectionJExplanation")]
		public bool? SectionJExplanation { get; set; }

		[DataMember(Name = "sectionKExplanation")]
		public bool? SectionKExplanation { get; set; }

		[DataMember(Name = "sectionLExplanation")]
		public bool? SectionLExplanation { get; set; }

		[DataMember(Name = "sectionMExplanation")]
		public bool? SectionMExplanation { get; set; }

		[DataMember(Name="sSA89BackgroundCheckIndicator")]
		public bool? SSA89BackgroundCheckIndicator { get; set; }

		[DataMember(Name="sSA89BankingServiceIndicator")]
		public bool? SSA89BankingServiceIndicator { get; set; }

		[DataMember(Name="sSA89CreditCheckIndicator")]
		public bool? SSA89CreditCheckIndicator { get; set; }

		[DataMember(Name="sSA89LicenseRequirementIndicator")]
		public bool? SSA89LicenseRequirementIndicator { get; set; }

		[DataMember(Name="sSA89MortgageServiceIndicator")]
		public bool? SSA89MortgageServiceIndicator { get; set; }

		[DataMember(Name="sSA89OtherIndicator")]
		public bool? SSA89OtherIndicator { get; set; }

		[DataMember(Name="sSNValidationMessage")]
		public string SSNValidationMessage { get; set; }

		[DataMember(Name="subtotalLiquidAssetsMinusGiftAmount")]
		public decimal? SubtotalLiquidAssetsMinusGiftAmount { get; set; }

		[DataMember(Name="suffixToName")]
		public string SuffixToName { get; set; }

		[DataMember(Name="tax4506LastInvestor")]
		public string Tax4506LastInvestor { get; set; }

		[DataMember(Name="tax4506LastOrderNumber")]
		public string Tax4506LastOrderNumber { get; set; }

		[DataMember(Name="tax4506LastOrderYear1")]
		public int? Tax4506LastOrderYear1 { get; set; }

		[DataMember(Name="tax4506LastOrderYear2")]
		public int? Tax4506LastOrderYear2 { get; set; }

		[DataMember(Name="tax4506LastOrderYear3")]
		public int? Tax4506LastOrderYear3 { get; set; }

		[DataMember(Name="tax4506LastOrderYear4")]
		public int? Tax4506LastOrderYear4 { get; set; }

		[DataMember(Name="tax4506LastProductsOrdered")]
		public string Tax4506LastProductsOrdered { get; set; }

		[DataMember(Name="tax4506LastStatus")]
		public string Tax4506LastStatus { get; set; }

		[DataMember(Name="tax4506LastTranscriptType")]
		public string Tax4506LastTranscriptType { get; set; }

		[DataMember(Name="tax4506LastUserIDWhoOrdered")]
		public string Tax4506LastUserIDWhoOrdered { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome1")]
		public decimal? Tax4506TotalYearlyIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome2")]
		public decimal? Tax4506TotalYearlyIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome3")]
		public decimal? Tax4506TotalYearlyIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome4")]
		public decimal? Tax4506TotalYearlyIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome1")]
		public decimal? Tax4506TotalYearlyJointIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome2")]
		public decimal? Tax4506TotalYearlyJointIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome3")]
		public decimal? Tax4506TotalYearlyJointIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome4")]
		public decimal? Tax4506TotalYearlyJointIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome1")]
		public decimal? Tax4506TotalYearlyVarianceIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome2")]
		public decimal? Tax4506TotalYearlyVarianceIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome3")]
		public decimal? Tax4506TotalYearlyVarianceIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome4")]
		public decimal? Tax4506TotalYearlyVarianceIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome1")]
		public decimal? Tax4506TotalYearlyVarianceJointIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome2")]
		public decimal? Tax4506TotalYearlyVarianceJointIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome3")]
		public decimal? Tax4506TotalYearlyVarianceJointIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome4")]
		public decimal? Tax4506TotalYearlyVarianceJointIncome4 { get; set; }

		[DataMember(Name="taxIdentificationIdentifier")]
		public string TaxIdentificationIdentifier { get; set; }

		[DataMember(Name="taxReturnValidationMessage")]
		public string TaxReturnValidationMessage { get; set; }

		[DataMember(Name="totalLiabilitiesBalanceAmount")]
		public decimal? TotalLiabilitiesBalanceAmount { get; set; }

		[DataMember(Name="totalMonthlyIncomeAmount")]
		public decimal? TotalMonthlyIncomeAmount { get; set; }

		[DataMember(Name="totalMonthlyIncomeMinusNetRentalAmount")]
		public decimal? TotalMonthlyIncomeMinusNetRentalAmount { get; set; }

		[DataMember(Name="totalPresentHousingExpenseAmount")]
		public decimal? TotalPresentHousingExpenseAmount { get; set; }

		[DataMember(Name="transactionPurposeDescription")]
		public string TransactionPurposeDescription { get; set; }

		[DataMember(Name="transUnion120Days")]
		public int? TransUnion120Days { get; set; }

		[DataMember(Name="transUnion150Days")]
		public int? TransUnion150Days { get; set; }

		[DataMember(Name="transUnion30Days")]
		public int? TransUnion30Days { get; set; }

		[DataMember(Name="transUnion60Days")]
		public int? TransUnion60Days { get; set; }

		[DataMember(Name="transUnion90Days")]
		public int? TransUnion90Days { get; set; }

		[DataMember(Name="transUnionCreditScoreForDisclosure")]
		public bool? TransUnionCreditScoreForDisclosure { get; set; }

		[DataMember(Name="transUnionCreditScoreRanksPercent")]
		public int? TransUnionCreditScoreRanksPercent { get; set; }

		[DataMember(Name="transUnionDatePulled")]
		public DateTime? TransUnionDatePulled { get; set; }

		[DataMember(Name="transUnionFactorCode1")]
		public string TransUnionFactorCode1 { get; set; }

		[DataMember(Name="transUnionFactorCode2")]
		public string TransUnionFactorCode2 { get; set; }

		[DataMember(Name="transUnionFactorCode3")]
		public string TransUnionFactorCode3 { get; set; }

		[DataMember(Name="transUnionFactorCode4")]
		public string TransUnionFactorCode4 { get; set; }

		[DataMember(Name="transUnionFactorCode5")]
		public string TransUnionFactorCode5 { get; set; }

		[DataMember(Name="transUnionKeyFactor1")]
		public string TransUnionKeyFactor1 { get; set; }

		[DataMember(Name="transUnionKeyFactor2")]
		public string TransUnionKeyFactor2 { get; set; }

		[DataMember(Name="transUnionKeyFactor3")]
		public string TransUnionKeyFactor3 { get; set; }

		[DataMember(Name="transUnionKeyFactor4")]
		public string TransUnionKeyFactor4 { get; set; }

		[DataMember(Name="transUnionKeyFactor5")]
		public string TransUnionKeyFactor5 { get; set; }

		[DataMember(Name="transUnionMaterialTermsCreditByScore")]
		public bool? TransUnionMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="transUnionScore")]
		public string TransUnionScore { get; set; }

		[DataMember(Name="userDefinedIncome")]
		public decimal? UserDefinedIncome { get; set; }

		[DataMember(Name="vaFederalTaxAmount")]
		public decimal? VaFederalTaxAmount { get; set; }

		[DataMember(Name="validDaysForConsentCount")]
		public int? ValidDaysForConsentCount { get; set; }

		[DataMember(Name="valueRepAndWarrantyAvailable")]
		public bool? ValueRepAndWarrantyAvailable { get; set; }

		[DataMember(Name="valueRepAndWarrantyMessage")]
		public string ValueRepAndWarrantyMessage { get; set; }

		[DataMember(Name="vaNetTakeHomePayAmount")]
		public decimal? VaNetTakeHomePayAmount { get; set; }

		[DataMember(Name="vaOtherAmount")]
		public decimal? VaOtherAmount { get; set; }

		[DataMember(Name="vaOtherNetIncomeAmount")]
		public decimal? VaOtherNetIncomeAmount { get; set; }

		[DataMember(Name="vaRetirementAmount")]
		public decimal? VaRetirementAmount { get; set; }

		[DataMember(Name="vaStateTaxAmount")]
		public decimal? VaStateTaxAmount { get; set; }

		[DataMember(Name="vaTotalIncomeDeductionsAmount")]
		public decimal? VaTotalIncomeDeductionsAmount { get; set; }

		[DataMember(Name="vaTotalNetIncomeAmount")]
		public decimal? VaTotalNetIncomeAmount { get; set; }

		[DataMember(Name="vendor1")]
		public string Vendor1 { get; set; }

		[DataMember(Name="vendor10")]
		public string Vendor10 { get; set; }

		[DataMember(Name="vendor11")]
		public string Vendor11 { get; set; }

		[DataMember(Name="vendor12")]
		public string Vendor12 { get; set; }

		[DataMember(Name="vendor13")]
		public string Vendor13 { get; set; }

		[DataMember(Name="vendor14")]
		public string Vendor14 { get; set; }

		[DataMember(Name="vendor15")]
		public string Vendor15 { get; set; }

		[DataMember(Name="vendor16")]
		public string Vendor16 { get; set; }

		[DataMember(Name="vendor17")]
		public string Vendor17 { get; set; }

		[DataMember(Name="vendor18")]
		public string Vendor18 { get; set; }

		[DataMember(Name="vendor19")]
		public string Vendor19 { get; set; }

		[DataMember(Name="vendor2")]
		public string Vendor2 { get; set; }

		[DataMember(Name="vendor20")]
		public string Vendor20 { get; set; }

		[DataMember(Name="vendor21")]
		public string Vendor21 { get; set; }

		[DataMember(Name="vendor22")]
		public string Vendor22 { get; set; }

		[DataMember(Name="vendor23")]
		public string Vendor23 { get; set; }

		[DataMember(Name="vendor24")]
		public string Vendor24 { get; set; }

		[DataMember(Name="vendor25")]
		public string Vendor25 { get; set; }

		[DataMember(Name="vendor26")]
		public string Vendor26 { get; set; }

		[DataMember(Name="vendor27")]
		public string Vendor27 { get; set; }

		[DataMember(Name="vendor28")]
		public string Vendor28 { get; set; }

		[DataMember(Name="vendor29")]
		public string Vendor29 { get; set; }

		[DataMember(Name="vendor3")]
		public string Vendor3 { get; set; }

		[DataMember(Name="vendor30")]
		public string Vendor30 { get; set; }

		[DataMember(Name="vendor31")]
		public string Vendor31 { get; set; }

		[DataMember(Name="vendor32")]
		public string Vendor32 { get; set; }

		[DataMember(Name="vendor33")]
		public string Vendor33 { get; set; }

		[DataMember(Name="vendor34")]
		public string Vendor34 { get; set; }

		[DataMember(Name="vendor35")]
		public string Vendor35 { get; set; }

		[DataMember(Name="vendor36")]
		public string Vendor36 { get; set; }

		[DataMember(Name="vendor4")]
		public string Vendor4 { get; set; }

		[DataMember(Name="vendor5")]
		public string Vendor5 { get; set; }

		[DataMember(Name="vendor6")]
		public string Vendor6 { get; set; }

		[DataMember(Name="vendor7")]
		public string Vendor7 { get; set; }

		[DataMember(Name="vendor8")]
		public string Vendor8 { get; set; }

		[DataMember(Name="vendor9")]
		public string Vendor9 { get; set; }

		[DataMember(Name="vestingTrusteeOfType")]
		public string VestingTrusteeOfType { get; set; }

		[DataMember(Name="veteranIndicator")]
		public bool? VeteranIndicator { get; set; }

		[DataMember(Name="workEmailAddress")]
		public string WorkEmailAddress { get; set; }

		[DataMember(Name="yearsofCreditOnFile")]
		public int? YearsofCreditOnFile { get; set; }

		[DataMember(Name = "urla2020CitizenshipResidencyType")]
		public string Urla2020CitizenshipResidencyType { get; set; }

		[DataMember(Name = "presentlyDelinquentIndicatorURLA")]
		public bool? PresentlyDelinquentIndicatorURLA { get; set; } = false;

		[DataMember(Name = "partyToLawsuitIndicatorURLA")]
		public bool? PartyToLawsuitIndicatorURLA { get; set; } = false;

		[DataMember(Name = "priorPropertyDeedInLieuConveyedIndicator")]
		public bool? PriorPropertyDeedInLieuConveyedIndicator { get; set; } = false;

		[DataMember(Name = "priorPropertyShortSaleCompletedIndicator")]
		public bool? PriorPropertyShortSaleCompletedIndicator { get; set; } = false;

		[DataMember(Name = "priorPropertyForeclosureCompletedIndicator")]
		public bool? PriorPropertyForeclosureCompletedIndicator { get; set; } = false;

		[DataMember(Name = "realEstateDoesNotApply")]
		public bool? RealEstateDoesNotApply { get; set; } = false;

		[DataMember(Name = "legalOtherThanSpouse")]
		public bool? LegalOtherThanSpouse { get; set; } = false;

		[DataMember(Name = "SelfDeclaredMilitaryServiceIndicator")]
		public bool? SelfDeclaredMilitaryServiceIndicator { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterSeven")]
		public bool? BankruptcyIndicatorChapterSeven { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterEleven")]
		public bool? BankruptcyIndicatorChapterEleven { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterTwelve")]
		public bool? BankruptcyIndicatorChapterTwelve { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterThirteen")]
		public bool? BankruptcyIndicatorChapterThirteen { get; set; } = false;

		[DataMember(Name = "currentEmploymentDoesNotApply")]
		public bool? CurrentEmploymentDoesNotApply { get; set; } = false;

		[DataMember(Name = "previousEmploymentDoesNotApply")]
		public bool? PreviousEmploymentDoesNotApply { get; set; } = false;

		[DataMember(Name = "languagePreference")]
		public string LanguagePreference { get; set; }

		[DataMember(Name = "jointAssetLiabilityReportingIndicator1")]
		public string JointAssetLiabilityReportingIndicator1 { get; set; }

		[DataMember(Name = "previousGrossMonthlyIncome")]
		public decimal? PreviousGrossMonthlyIncome { get; set; }

		[DataMember(Name = "priorResidenceDoesNotApply")]
		public bool? PriorResidenceDoesNotApply { get; set; } = false;

		[DataMember(Name = "hmda2CreditScoreForDecisionMaking")]
		public string Hmda2CreditScoreForDecisionMaking { get; set; }

		[DataMember(Name = "hmda2CreditScoringModel")]
		public string Hmda2CreditScoringModel { get; set; }

		[DataMember(Name = "topRatioPercent")]
		public decimal? TopRatioPercent { get; set; }

		[DataMember(Name = "bottomRatioPercent")]
		public decimal? BottomRatioPercent { get; set; }

		[DataMember(Name = "totalGrossMonthlyIncomeAmount")]
		public decimal? TotalGrossMonthlyIncomeAmount { get; set; }

		[DataMember(Name = "otherAssetsDoesNotApply")]
		public bool? OtherAssetsDoesNotApply { get; set; } = false;

		[DataMember(Name = "liabilitiesDoesNotApply")]
		public bool? LiabilitiesDoesNotApply { get; set; } = false;

		[DataMember(Name = "giftsAndGrantsIndicatorBor")]
		public bool? GiftsAndGrantsIndicatorBor { get; set; } = false;

		[DataMember(Name = "specialBorrowerSellerRelationshipIndicator")]
		public bool? SpecialBorrowerSellerRelationshipIndicator { get; set; } = false;

		[DataMember(Name = "undisclosedBorrowedFundsIndicator")]
		public bool? UndisclosedBorrowedFundsIndicator { get; set; } = false;

		[DataMember(Name = "undisclosedBorrowedFundsAmount")]
		public decimal? UndisclosedBorrowedFundsAmount { get; set; }

		[DataMember(Name = "undisclosedMortgageApplicationIndicator")]
		public bool? UndisclosedMortgageApplicationIndicator { get; set; } = false;

		[DataMember(Name = "undisclosedCreditApplicationIndicator")]
		public bool? UndisclosedCreditApplicationIndicator { get; set; } = false;

		[DataMember(Name = "propertyProposedCleanEnergyLienIndicator")]
		public bool? PropertyProposedCleanEnergyLienIndicator { get; set; } = false;

		[DataMember(Name = "undisclosedComakerOfNoteIndicator")]
		public bool? UndisclosedComakerOfNoteIndicator { get; set; } = false;
	}
}