using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractBorrower
	{
		[DataMember(Name="acountChekAssetId", EmitDefaultValue=false)]
		public string AcountChekAssetId { get; set; }

		[DataMember(Name="additionalIncomeFromPrimaryEmployment", EmitDefaultValue=false)]
		public double? AdditionalIncomeFromPrimaryEmployment { get; set; }

		[DataMember(Name="adjustedAnnualIncome", EmitDefaultValue=false)]
		public double? AdjustedAnnualIncome { get; set; }

		[DataMember(Name="ageAtApplicationYearsCount", EmitDefaultValue=false)]
		public int? AgeAtApplicationYearsCount { get; set; }

		[DataMember(Name="aliasName", EmitDefaultValue=false)]
		public string AliasName { get; set; }

		[DataMember(Name="alimonyChildSupportObligationIndicator", EmitDefaultValue=false)]
		public bool? AlimonyChildSupportObligationIndicator { get; set; }

		[DataMember(Name="altId", EmitDefaultValue=false)]
		public string AltId { get; set; }

		[DataMember(Name="annualIncome", EmitDefaultValue=false)]
		public double? AnnualIncome { get; set; }

		[DataMember(Name="applicantType", EmitDefaultValue=false)]
		public string ApplicantType { get; set; }

		[DataMember(Name="applicationTakenMethodType", EmitDefaultValue=false)]
		public string ApplicationTakenMethodType { get; set; }

		[DataMember(Name="assetIncome", EmitDefaultValue=false)]
		public double? AssetIncome { get; set; }

		[DataMember(Name="assetRepAndWarrantyMessage", EmitDefaultValue=false)]
		public string AssetRepAndWarrantyMessage { get; set; }

		[DataMember(Name="assetRepAndWarrantyReliefAvailable", EmitDefaultValue=false)]
		public bool? AssetRepAndWarrantyReliefAvailable { get; set; }

		[DataMember(Name="authorizedCreditReportIndicator", EmitDefaultValue=false)]
		public bool? AuthorizedCreditReportIndicator { get; set; }

		[DataMember(Name="authorizedToSignIndicator", EmitDefaultValue=false)]
		public bool? AuthorizedToSignIndicator { get; set; }

		[DataMember(Name="bankAccountNumber", EmitDefaultValue=false)]
		public string BankAccountNumber { get; set; }

		[DataMember(Name="bankAccountType", EmitDefaultValue=false)]
		public string BankAccountType { get; set; }

		[DataMember(Name="bankContactAddress", EmitDefaultValue=false)]
		public string BankContactAddress { get; set; }

		[DataMember(Name="bankContactCity", EmitDefaultValue=false)]
		public string BankContactCity { get; set; }

		[DataMember(Name="bankContactName", EmitDefaultValue=false)]
		public string BankContactName { get; set; }

		[DataMember(Name="bankContactPostalCode", EmitDefaultValue=false)]
		public string BankContactPostalCode { get; set; }

		[DataMember(Name="bankContactState", EmitDefaultValue=false)]
		public string BankContactState { get; set; }

		[DataMember(Name="bankruptcyIndicator", EmitDefaultValue=false)]
		public bool? BankruptcyIndicator { get; set; }

		[DataMember(Name="bankruptcyStatus", EmitDefaultValue=false)]
		public string BankruptcyStatus { get; set; }

		[DataMember(Name="baseIncome", EmitDefaultValue=false)]
		public double? BaseIncome { get; set; }

		[DataMember(Name="baseIncomeValidationMessage", EmitDefaultValue=false)]
		public string BaseIncomeValidationMessage { get; set; }

		[DataMember(Name="baseMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? BaseMonthlyIncomeAmount { get; set; }

		[DataMember(Name="birthDate", EmitDefaultValue=false)]
		public DateTime? BirthDate { get; set; }

		[DataMember(Name="bonusValidationMessage", EmitDefaultValue=false)]
		public string BonusValidationMessage { get; set; }

		[DataMember(Name="borrowedDownPaymentIndicator", EmitDefaultValue=false)]
		public bool? BorrowedDownPaymentIndicator { get; set; }

		[DataMember(Name="borrowerConsentRequestDate", EmitDefaultValue=false)]
		public DateTime? BorrowerConsentRequestDate { get; set; }

		[DataMember(Name="borrowerIndex", EmitDefaultValue=false)]
		public int? BorrowerIndex { get; set; }

		[DataMember(Name="borrowerType", EmitDefaultValue=false)]
		public string BorrowerType { get; set; }

		[DataMember(Name="borrowerTypeInSummary", EmitDefaultValue=false)]
		public string BorrowerTypeInSummary { get; set; }

		[DataMember(Name="caivrsIdentifier", EmitDefaultValue=false)]
		public string CaivrsIdentifier { get; set; }

		[DataMember(Name="citizenshipResidencyType", EmitDefaultValue=false)]
		public string CitizenshipResidencyType { get; set; }

		[DataMember(Name="coMakerEndorserOfNoteIndicator", EmitDefaultValue=false)]
		public bool? CoMakerEndorserOfNoteIndicator { get; set; }

		[DataMember(Name="commentOfCreditReport", EmitDefaultValue=false)]
		public string CommentOfCreditReport { get; set; }

		[DataMember(Name="commissionValidationMessage", EmitDefaultValue=false)]
		public string CommissionValidationMessage { get; set; }

		[DataMember(Name="confirmedCRBKEC", EmitDefaultValue=false)]
		public bool? ConfirmedCRBKEC { get; set; }

		[DataMember(Name="confirmedCRBKIncorrect", EmitDefaultValue=false)]
		public bool? ConfirmedCRBKIncorrect { get; set; }

		[DataMember(Name="confirmedCRDIL", EmitDefaultValue=false)]
		public bool? ConfirmedCRDIL { get; set; }

		[DataMember(Name="confirmedCRFCEC", EmitDefaultValue=false)]
		public bool? ConfirmedCRFCEC { get; set; }

		[DataMember(Name="confirmedCRFCIncorrect", EmitDefaultValue=false)]
		public bool? ConfirmedCRFCIncorrect { get; set; }

		[DataMember(Name="confirmedCRPFS", EmitDefaultValue=false)]
		public bool? ConfirmedCRPFS { get; set; }

		[DataMember(Name="confirmedMtgDelIncorrect", EmitDefaultValue=false)]
		public bool? ConfirmedMtgDelIncorrect { get; set; }

		[DataMember(Name="confirmedOther", EmitDefaultValue=false)]
		public bool? ConfirmedOther { get; set; }

		[DataMember(Name="confirmedOtherDescription", EmitDefaultValue=false)]
		public string ConfirmedOtherDescription { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public EntityRefContract Contact { get; set; }

		[DataMember(Name="creditCounseling", EmitDefaultValue=false)]
		public bool? CreditCounseling { get; set; }

		[DataMember(Name="creditReceivedDate", EmitDefaultValue=false)]
		public DateTime? CreditReceivedDate { get; set; }

		[DataMember(Name="creditReportAuthorizationMethod", EmitDefaultValue=false)]
		public string CreditReportAuthorizationMethod { get; set; }

		[DataMember(Name="creditScoreIndicator", EmitDefaultValue=false)]
		public bool? CreditScoreIndicator { get; set; }

		[DataMember(Name="dateAuthorizedCreditReport", EmitDefaultValue=false)]
		public DateTime? DateAuthorizedCreditReport { get; set; }

		[DataMember(Name="dateOfBankruptcy", EmitDefaultValue=false)]
		public DateTime? DateOfBankruptcy { get; set; }

		[DataMember(Name="dateOfForeclosure", EmitDefaultValue=false)]
		public DateTime? DateOfForeclosure { get; set; }

		[DataMember(Name="declarationsJIndicator", EmitDefaultValue=false)]
		public bool? DeclarationsJIndicator { get; set; }

		[DataMember(Name="declarationsKIndicator", EmitDefaultValue=false)]
		public bool? DeclarationsKIndicator { get; set; }

		[DataMember(Name="dependentCount", EmitDefaultValue=false)]
		public int? DependentCount { get; set; }

		[DataMember(Name="dependentsAgesDescription", EmitDefaultValue=false)]
		public string DependentsAgesDescription { get; set; }

		[DataMember(Name="disabledIndicator", EmitDefaultValue=false)]
		public bool? DisabledIndicator { get; set; }

		[DataMember(Name="emailAddressText", EmitDefaultValue=false)]
		public string EmailAddressText { get; set; }

		[DataMember(Name="employmentVerificationAvailable", EmitDefaultValue=false)]
		public bool? EmploymentVerificationAvailable { get; set; }

		[DataMember(Name="employmentVerificationMessage", EmitDefaultValue=false)]
		public string EmploymentVerificationMessage { get; set; }

		[DataMember(Name="equifax120Days", EmitDefaultValue=false)]
		public int? Equifax120Days { get; set; }

		[DataMember(Name="equifax150Days", EmitDefaultValue=false)]
		public int? Equifax150Days { get; set; }

		[DataMember(Name="equifax30Days", EmitDefaultValue=false)]
		public int? Equifax30Days { get; set; }

		[DataMember(Name="equifax60Days", EmitDefaultValue=false)]
		public int? Equifax60Days { get; set; }

		[DataMember(Name="equifax90Days", EmitDefaultValue=false)]
		public int? Equifax90Days { get; set; }

		[DataMember(Name="equifaxCreditScoreForDisclosure", EmitDefaultValue=false)]
		public bool? EquifaxCreditScoreForDisclosure { get; set; }

		[DataMember(Name="equifaxCreditScoreRanksPercent", EmitDefaultValue=false)]
		public int? EquifaxCreditScoreRanksPercent { get; set; }

		[DataMember(Name="equifaxDatePulled", EmitDefaultValue=false)]
		public DateTime? EquifaxDatePulled { get; set; }

		[DataMember(Name="equifaxFactorCode1", EmitDefaultValue=false)]
		public string EquifaxFactorCode1 { get; set; }

		[DataMember(Name="equifaxFactorCode2", EmitDefaultValue=false)]
		public string EquifaxFactorCode2 { get; set; }

		[DataMember(Name="equifaxFactorCode3", EmitDefaultValue=false)]
		public string EquifaxFactorCode3 { get; set; }

		[DataMember(Name="equifaxFactorCode4", EmitDefaultValue=false)]
		public string EquifaxFactorCode4 { get; set; }

		[DataMember(Name="equifaxFactorCode5", EmitDefaultValue=false)]
		public string EquifaxFactorCode5 { get; set; }

		[DataMember(Name="equifaxKeyFactor1", EmitDefaultValue=false)]
		public string EquifaxKeyFactor1 { get; set; }

		[DataMember(Name="equifaxKeyFactor2", EmitDefaultValue=false)]
		public string EquifaxKeyFactor2 { get; set; }

		[DataMember(Name="equifaxKeyFactor3", EmitDefaultValue=false)]
		public string EquifaxKeyFactor3 { get; set; }

		[DataMember(Name="equifaxKeyFactor4", EmitDefaultValue=false)]
		public string EquifaxKeyFactor4 { get; set; }

		[DataMember(Name="equifaxKeyFactor5", EmitDefaultValue=false)]
		public string EquifaxKeyFactor5 { get; set; }

		[DataMember(Name="equifaxMaterialTermsCreditByScore", EmitDefaultValue=false)]
		public bool? EquifaxMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="equifaxScore", EmitDefaultValue=false)]
		public string EquifaxScore { get; set; }

		[DataMember(Name="experian120Days", EmitDefaultValue=false)]
		public int? Experian120Days { get; set; }

		[DataMember(Name="experian150Days", EmitDefaultValue=false)]
		public int? Experian150Days { get; set; }

		[DataMember(Name="experian30Days", EmitDefaultValue=false)]
		public int? Experian30Days { get; set; }

		[DataMember(Name="experian60Days", EmitDefaultValue=false)]
		public int? Experian60Days { get; set; }

		[DataMember(Name="experian90Days", EmitDefaultValue=false)]
		public int? Experian90Days { get; set; }

		[DataMember(Name="experianCreditScore", EmitDefaultValue=false)]
		public string ExperianCreditScore { get; set; }

		[DataMember(Name="experianCreditScoreForDisclosure", EmitDefaultValue=false)]
		public bool? ExperianCreditScoreForDisclosure { get; set; }

		[DataMember(Name="experianCreditScoreRanksPercent", EmitDefaultValue=false)]
		public int? ExperianCreditScoreRanksPercent { get; set; }

		[DataMember(Name="experianDatePulled", EmitDefaultValue=false)]
		public DateTime? ExperianDatePulled { get; set; }

		[DataMember(Name="experianFactorCode1", EmitDefaultValue=false)]
		public string ExperianFactorCode1 { get; set; }

		[DataMember(Name="experianFactorCode2", EmitDefaultValue=false)]
		public string ExperianFactorCode2 { get; set; }

		[DataMember(Name="experianFactorCode3", EmitDefaultValue=false)]
		public string ExperianFactorCode3 { get; set; }

		[DataMember(Name="experianFactorCode4", EmitDefaultValue=false)]
		public string ExperianFactorCode4 { get; set; }

		[DataMember(Name="experianFactorCode5", EmitDefaultValue=false)]
		public string ExperianFactorCode5 { get; set; }

		[DataMember(Name="experianKeyFactor1", EmitDefaultValue=false)]
		public string ExperianKeyFactor1 { get; set; }

		[DataMember(Name="experianKeyFactor2", EmitDefaultValue=false)]
		public string ExperianKeyFactor2 { get; set; }

		[DataMember(Name="experianKeyFactor3", EmitDefaultValue=false)]
		public string ExperianKeyFactor3 { get; set; }

		[DataMember(Name="experianKeyFactor4", EmitDefaultValue=false)]
		public string ExperianKeyFactor4 { get; set; }

		[DataMember(Name="experianKeyFactor5", EmitDefaultValue=false)]
		public string ExperianKeyFactor5 { get; set; }

		[DataMember(Name="experianMaterialTermsCreditByScore", EmitDefaultValue=false)]
		public bool? ExperianMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="fannieFirstName", EmitDefaultValue=false)]
		public string FannieFirstName { get; set; }

		[DataMember(Name="fannieMiddleName", EmitDefaultValue=false)]
		public string FannieMiddleName { get; set; }

		[DataMember(Name="firstName", EmitDefaultValue=false)]
		public string FirstName { get; set; }

		[DataMember(Name="firstNameWithMiddleName", EmitDefaultValue=false)]
		public string FirstNameWithMiddleName { get; set; }

		[DataMember(Name="firstTimeHomeBuyer", EmitDefaultValue=false)]
		public bool? FirstTimeHomeBuyer { get; set; }

		[DataMember(Name="foreclosureSatisfied", EmitDefaultValue=false)]
		public DateTime? ForeclosureSatisfied { get; set; }

		[DataMember(Name="foreclosureStatus", EmitDefaultValue=false)]
		public string ForeclosureStatus { get; set; }

		[DataMember(Name="freddieMacPerson1", EmitDefaultValue=false)]
		public string FreddieMacPerson1 { get; set; }

		[DataMember(Name="freddieMacPerson2", EmitDefaultValue=false)]
		public string FreddieMacPerson2 { get; set; }

		[DataMember(Name="fullName", EmitDefaultValue=false)]
		public string FullName { get; set; }

		[DataMember(Name="fullNameWithSuffix", EmitDefaultValue=false)]
		public string FullNameWithSuffix { get; set; }

		[DataMember(Name="highestCreditLimit", EmitDefaultValue=false)]
		public double? HighestCreditLimit { get; set; }

		[DataMember(Name="hmda2003OtherRaceNationalOriginDescription", EmitDefaultValue=false)]
		public string Hmda2003OtherRaceNationalOriginDescription { get; set; }

		[DataMember(Name="hmda2003RaceNationalOriginType", EmitDefaultValue=false)]
		public string Hmda2003RaceNationalOriginType { get; set; }

		[DataMember(Name="hmdaAfricanAmericanIndicator", EmitDefaultValue=false)]
		public bool? HmdaAfricanAmericanIndicator { get; set; }

		[DataMember(Name="hmdaAge", EmitDefaultValue=false)]
		public string HmdaAge { get; set; }

		[DataMember(Name="hmdaAmericanIndianIndicator", EmitDefaultValue=false)]
		public bool? HmdaAmericanIndianIndicator { get; set; }

		[DataMember(Name="hmdaAmericanIndianTribe", EmitDefaultValue=false)]
		public string HmdaAmericanIndianTribe { get; set; }

		[DataMember(Name="hmdaAsianIndianIndicator", EmitDefaultValue=false)]
		public bool? HmdaAsianIndianIndicator { get; set; }

		[DataMember(Name="hmdaAsianIndicator", EmitDefaultValue=false)]
		public bool? HmdaAsianIndicator { get; set; }

		[DataMember(Name="hmdaAsianOtherRaceIndicator", EmitDefaultValue=false)]
		public bool? HmdaAsianOtherRaceIndicator { get; set; }

		[DataMember(Name="hmdaChineseIndicator", EmitDefaultValue=false)]
		public bool? HmdaChineseIndicator { get; set; }

		[DataMember(Name="hmdaCreditScoreForDecisionMaking", EmitDefaultValue=false)]
		public string HmdaCreditScoreForDecisionMaking { get; set; }

		[DataMember(Name="hmdaCreditScoringModel", EmitDefaultValue=false)]
		public string HmdaCreditScoringModel { get; set; }

		[DataMember(Name="hmdaCubanIndicator", EmitDefaultValue=false)]
		public bool? HmdaCubanIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityDoNotWishIndicator", EmitDefaultValue=false)]
		public bool? HmdaEthnicityDoNotWishIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityHispanicLatinoIndicator", EmitDefaultValue=false)]
		public bool? HmdaEthnicityHispanicLatinoIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityInfoNotProvided", EmitDefaultValue=false)]
		public bool? HmdaEthnicityInfoNotProvided { get; set; }

		[DataMember(Name="hmdaEthnicityNotApplicableIndicator", EmitDefaultValue=false)]
		public bool? HmdaEthnicityNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityNotHispanicLatinoIndicator", EmitDefaultValue=false)]
		public bool? HmdaEthnicityNotHispanicLatinoIndicator { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField1", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedField1 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField2", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedField2 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField3", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedField3 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField4", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedField4 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedField5", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedField5 { get; set; }

		[DataMember(Name="hmdaEthnicityReportedFields", EmitDefaultValue=false)]
		public string HmdaEthnicityReportedFields { get; set; }

		[DataMember(Name="hmdaEthnicityType", EmitDefaultValue=false)]
		public string HmdaEthnicityType { get; set; }

		[DataMember(Name="hmdaFilipinoIndicator", EmitDefaultValue=false)]
		public bool? HmdaFilipinoIndicator { get; set; }

		[DataMember(Name="hmdaGenderType", EmitDefaultValue=false)]
		public string HmdaGenderType { get; set; }

		[DataMember(Name="hmdaGendertypeDoNotWishIndicator", EmitDefaultValue=false)]
		public bool? HmdaGendertypeDoNotWishIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeFemaleIndicator", EmitDefaultValue=false)]
		public bool? HmdaGendertypeFemaleIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeMaleIndicator", EmitDefaultValue=false)]
		public bool? HmdaGendertypeMaleIndicator { get; set; }

		[DataMember(Name="hmdaGendertypeNotApplicableIndicator", EmitDefaultValue=false)]
		public bool? HmdaGendertypeNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaGuamanianOrChamorroIndicator", EmitDefaultValue=false)]
		public bool? HmdaGuamanianOrChamorroIndicator { get; set; }

		[DataMember(Name="hmdaHispanicLatinoOtherOriginIndicator", EmitDefaultValue=false)]
		public bool? HmdaHispanicLatinoOtherOriginIndicator { get; set; }

		[DataMember(Name="hmdaJapaneseIndicator", EmitDefaultValue=false)]
		public bool? HmdaJapaneseIndicator { get; set; }

		[DataMember(Name="hmdaKoreanIndicator", EmitDefaultValue=false)]
		public bool? HmdaKoreanIndicator { get; set; }

		[DataMember(Name="hmdaMexicanIndicator", EmitDefaultValue=false)]
		public bool? HmdaMexicanIndicator { get; set; }

		[DataMember(Name="hmdaNativeHawaiianIndicator", EmitDefaultValue=false)]
		public bool? HmdaNativeHawaiianIndicator { get; set; }

		[DataMember(Name="hmdaNoCoApplicantIndicator", EmitDefaultValue=false)]
		public bool? HmdaNoCoApplicantIndicator { get; set; }

		[DataMember(Name="hmdaNotApplicableIndicator", EmitDefaultValue=false)]
		public bool? HmdaNotApplicableIndicator { get; set; }

		[DataMember(Name="hmdaNotProvidedIndicator", EmitDefaultValue=false)]
		public bool? HmdaNotProvidedIndicator { get; set; }

		[DataMember(Name="hmdaOtherAsianRace", EmitDefaultValue=false)]
		public string HmdaOtherAsianRace { get; set; }

		[DataMember(Name="hmdaOtherHispanicLatinoOrigin", EmitDefaultValue=false)]
		public string HmdaOtherHispanicLatinoOrigin { get; set; }

		[DataMember(Name="hmdaOtherPacificIslanderRace", EmitDefaultValue=false)]
		public string HmdaOtherPacificIslanderRace { get; set; }

		[DataMember(Name="hmdaOtherScoringModel", EmitDefaultValue=false)]
		public string HmdaOtherScoringModel { get; set; }

		[DataMember(Name="hmdaPacificIslanderIndicator", EmitDefaultValue=false)]
		public bool? HmdaPacificIslanderIndicator { get; set; }

		[DataMember(Name="hmdaPacificIslanderOtherIndicator", EmitDefaultValue=false)]
		public bool? HmdaPacificIslanderOtherIndicator { get; set; }

		[DataMember(Name="hmdaPuertoRicanIndicator", EmitDefaultValue=false)]
		public bool? HmdaPuertoRicanIndicator { get; set; }

		[DataMember(Name="hmdaRaceDoNotWishProvideIndicator", EmitDefaultValue=false)]
		public bool? HmdaRaceDoNotWishProvideIndicator { get; set; }

		[DataMember(Name="hmdaRaceInfoNotProvided", EmitDefaultValue=false)]
		public bool? HmdaRaceInfoNotProvided { get; set; }

		[DataMember(Name="hmdaRaceReportedField1", EmitDefaultValue=false)]
		public string HmdaRaceReportedField1 { get; set; }

		[DataMember(Name="hmdaRaceReportedField2", EmitDefaultValue=false)]
		public string HmdaRaceReportedField2 { get; set; }

		[DataMember(Name="hmdaRaceReportedField3", EmitDefaultValue=false)]
		public string HmdaRaceReportedField3 { get; set; }

		[DataMember(Name="hmdaRaceReportedField4", EmitDefaultValue=false)]
		public string HmdaRaceReportedField4 { get; set; }

		[DataMember(Name="hmdaRaceReportedField5", EmitDefaultValue=false)]
		public string HmdaRaceReportedField5 { get; set; }

		[DataMember(Name="hmdaRaceReportedFields", EmitDefaultValue=false)]
		public string HmdaRaceReportedFields { get; set; }

		[DataMember(Name="hmdaRefusalIndicator", EmitDefaultValue=false)]
		public bool? HmdaRefusalIndicator { get; set; }

		[DataMember(Name="hmdaSamoanIndicator", EmitDefaultValue=false)]
		public bool? HmdaSamoanIndicator { get; set; }

		[DataMember(Name="hmdaSexInfoNotProvided", EmitDefaultValue=false)]
		public bool? HmdaSexInfoNotProvided { get; set; }

		[DataMember(Name="hmdaVietnameseIndicator", EmitDefaultValue=false)]
		public bool? HmdaVietnameseIndicator { get; set; }

		[DataMember(Name="hmdaWhiteIndicator", EmitDefaultValue=false)]
		public bool? HmdaWhiteIndicator { get; set; }

		[DataMember(Name="homeownerPastThreeYearsIndicator", EmitDefaultValue=false)]
		public bool? HomeownerPastThreeYearsIndicator { get; set; }

		[DataMember(Name="homePhoneNumber", EmitDefaultValue=false)]
		public string HomePhoneNumber { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="incomeRepAndWarrantyMessage", EmitDefaultValue=false)]
		public string IncomeRepAndWarrantyMessage { get; set; }

		[DataMember(Name="incomeRepAndWarrantyReliefAvailable", EmitDefaultValue=false)]
		public bool? IncomeRepAndWarrantyReliefAvailable { get; set; }

		[DataMember(Name="intentToOccupyIndicator", EmitDefaultValue=false)]
		public bool? IntentToOccupyIndicator { get; set; }

		[DataMember(Name="intuitReportId", EmitDefaultValue=false)]
		public string IntuitReportId { get; set; }

		[DataMember(Name="isBaseIncomeAvailable", EmitDefaultValue=false)]
		public bool? IsBaseIncomeAvailable { get; set; }

		[DataMember(Name="isBonusAvailable", EmitDefaultValue=false)]
		public bool? IsBonusAvailable { get; set; }

		[DataMember(Name="isBorrower", EmitDefaultValue=false)]
		public bool? IsBorrower { get; set; }

		[DataMember(Name="isCommissionAvailable", EmitDefaultValue=false)]
		public bool? IsCommissionAvailable { get; set; }

		[DataMember(Name="isEthnicityBasedOnVisual", EmitDefaultValue=false)]
		public string IsEthnicityBasedOnVisual { get; set; }

		[DataMember(Name="isOvertimeAvailable", EmitDefaultValue=false)]
		public bool? IsOvertimeAvailable { get; set; }

		[DataMember(Name="isRaceBasedOnVisual", EmitDefaultValue=false)]
		public string IsRaceBasedOnVisual { get; set; }

		[DataMember(Name="isSelfEmployed", EmitDefaultValue=false)]
		public bool? IsSelfEmployed { get; set; }

		[DataMember(Name="isSexBasedOnVisual", EmitDefaultValue=false)]
		public string IsSexBasedOnVisual { get; set; }

		[DataMember(Name="isSocialSecurityAvailable", EmitDefaultValue=false)]
		public bool? IsSocialSecurityAvailable { get; set; }

		[DataMember(Name="isTaxReturnAvailable", EmitDefaultValue=false)]
		public bool? IsTaxReturnAvailable { get; set; }

		[DataMember(Name="lastName", EmitDefaultValue=false)]
		public string LastName { get; set; }

		[DataMember(Name="lastNameWithSuffix", EmitDefaultValue=false)]
		public string LastNameWithSuffix { get; set; }

		[DataMember(Name="loanForeclosureOrJudgementIndicator", EmitDefaultValue=false)]
		public bool? LoanForeclosureOrJudgementIndicator { get; set; }

		[DataMember(Name="lpdGsa", EmitDefaultValue=false)]
		public string LpdGsa { get; set; }

		[DataMember(Name="mailingAddressSameAsPresentIndicator", EmitDefaultValue=false)]
		public bool? MailingAddressSameAsPresentIndicator { get; set; }

		[DataMember(Name="maritalStatusType", EmitDefaultValue=false)]
		public string MaritalStatusType { get; set; }

		[DataMember(Name="middleCreditScore", EmitDefaultValue=false)]
		public int? MiddleCreditScore { get; set; }

		[DataMember(Name="middleFicoScore", EmitDefaultValue=false)]
		public string MiddleFicoScore { get; set; }

		[DataMember(Name="middleName", EmitDefaultValue=false)]
		public string MiddleName { get; set; }

		[DataMember(Name="minFicoScore", EmitDefaultValue=false)]
		public string MinFicoScore { get; set; }

		[DataMember(Name="mobilePhone", EmitDefaultValue=false)]
		public string MobilePhone { get; set; }

		[DataMember(Name="mortgageOnCredit", EmitDefaultValue=false)]
		public bool? MortgageOnCredit { get; set; }

		[DataMember(Name="nameToObtainLoanFromRHS", EmitDefaultValue=false)]
		public string NameToObtainLoanFromRHS { get; set; }

		[DataMember(Name="nearestRelativeAddress", EmitDefaultValue=false)]
		public string NearestRelativeAddress { get; set; }

		[DataMember(Name="nearestRelativeCity", EmitDefaultValue=false)]
		public string NearestRelativeCity { get; set; }

		[DataMember(Name="nearestRelativeName", EmitDefaultValue=false)]
		public string NearestRelativeName { get; set; }

		[DataMember(Name="nearestRelativePhone", EmitDefaultValue=false)]
		public string NearestRelativePhone { get; set; }

		[DataMember(Name="nearestRelativePostalCode", EmitDefaultValue=false)]
		public string NearestRelativePostalCode { get; set; }

		[DataMember(Name="nearestRelativeRelationship", EmitDefaultValue=false)]
		public string NearestRelativeRelationship { get; set; }

		[DataMember(Name="nearestRelativeState", EmitDefaultValue=false)]
		public string NearestRelativeState { get; set; }

		[DataMember(Name="no3rdPartyEmailIndicator", EmitDefaultValue=false)]
		public bool? No3rdPartyEmailIndicator { get; set; }

		[DataMember(Name="noCoApplicantEthnicityIndicator", EmitDefaultValue=false)]
		public bool? NoCoApplicantEthnicityIndicator { get; set; }

		[DataMember(Name="noCoApplicantIndicator", EmitDefaultValue=false)]
		public bool? NoCoApplicantIndicator { get; set; }

		[DataMember(Name="noCoApplicantSexIndicator", EmitDefaultValue=false)]
		public bool? NoCoApplicantSexIndicator { get; set; }

		[DataMember(Name="numberofTradelines", EmitDefaultValue=false)]
		public int? NumberofTradelines { get; set; }

		[DataMember(Name="obtainLoanFromRHSIndicator", EmitDefaultValue=false)]
		public bool? ObtainLoanFromRHSIndicator { get; set; }

		[DataMember(Name="openBankruptcy2", EmitDefaultValue=false)]
		public string OpenBankruptcy2 { get; set; }

		[DataMember(Name="otherMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? OtherMonthlyIncomeAmount { get; set; }

		[DataMember(Name="otherSumAmount", EmitDefaultValue=false)]
		public double? OtherSumAmount { get; set; }

		[DataMember(Name="outstandingJudgementsIndicator", EmitDefaultValue=false)]
		public bool? OutstandingJudgementsIndicator { get; set; }

		[DataMember(Name="overtimeValidationMessage", EmitDefaultValue=false)]
		public string OvertimeValidationMessage { get; set; }

		[DataMember(Name="partyToLawsuitIndicator", EmitDefaultValue=false)]
		public bool? PartyToLawsuitIndicator { get; set; }

		[DataMember(Name="pass120Days", EmitDefaultValue=false)]
		public int? Pass120Days { get; set; }

		[DataMember(Name="pass150Days", EmitDefaultValue=false)]
		public int? Pass150Days { get; set; }

		[DataMember(Name="pass30Days", EmitDefaultValue=false)]
		public int? Pass30Days { get; set; }

		[DataMember(Name="pass60Days", EmitDefaultValue=false)]
		public int? Pass60Days { get; set; }

		[DataMember(Name="pass90Days", EmitDefaultValue=false)]
		public int? Pass90Days { get; set; }

		[DataMember(Name="pensionRetireIncomeMessage", EmitDefaultValue=false)]
		public string PensionRetireIncomeMessage { get; set; }

		[DataMember(Name="personFaxNumber", EmitDefaultValue=false)]
		public string PersonFaxNumber { get; set; }

		[DataMember(Name="personHoursPerWeek", EmitDefaultValue=false)]
		public double? PersonHoursPerWeek { get; set; }

		[DataMember(Name="personIncomeAmount", EmitDefaultValue=false)]
		public double? PersonIncomeAmount { get; set; }

		[DataMember(Name="personIncomeFrequencyType", EmitDefaultValue=false)]
		public string PersonIncomeFrequencyType { get; set; }

		[DataMember(Name="personMonthlyIncome", EmitDefaultValue=false)]
		public double? PersonMonthlyIncome { get; set; }

		[DataMember(Name="pIWAccepted", EmitDefaultValue=false)]
		public bool? PIWAccepted { get; set; }

		[DataMember(Name="pIWMessage", EmitDefaultValue=false)]
		public string PIWMessage { get; set; }

		[DataMember(Name="poaOccupancyIntent", EmitDefaultValue=false)]
		public string PoaOccupancyIntent { get; set; }

		[DataMember(Name="poaSignatureText", EmitDefaultValue=false)]
		public string PoaSignatureText { get; set; }

		[DataMember(Name="positiveCashFlow", EmitDefaultValue=false)]
		public double? PositiveCashFlow { get; set; }

		[DataMember(Name="powerOfAttorneyName", EmitDefaultValue=false)]
		public string PowerOfAttorneyName { get; set; }

		[DataMember(Name="powerOfAttorneyTitleDescription", EmitDefaultValue=false)]
		public string PowerOfAttorneyTitleDescription { get; set; }

		[DataMember(Name="presentlyDelinquentIndicator", EmitDefaultValue=false)]
		public bool? PresentlyDelinquentIndicator { get; set; }

		[DataMember(Name="priorBankruptcy2", EmitDefaultValue=false)]
		public DateTime? PriorBankruptcy2 { get; set; }

		[DataMember(Name="priorForeclosure", EmitDefaultValue=false)]
		public bool? PriorForeclosure { get; set; }

		[DataMember(Name="priorPropertyTitleType", EmitDefaultValue=false)]
		public string PriorPropertyTitleType { get; set; }

		[DataMember(Name="priorPropertyUsageType", EmitDefaultValue=false)]
		public string PriorPropertyUsageType { get; set; }

		[DataMember(Name="propertyForeclosedPastSevenYearsIndicator", EmitDefaultValue=false)]
		public bool? PropertyForeclosedPastSevenYearsIndicator { get; set; }

		[DataMember(Name="relationshipDescription", EmitDefaultValue=false)]
		public string RelationshipDescription { get; set; }

		[DataMember(Name="relationshipWithRDEmployeeIndicator", EmitDefaultValue=false)]
		public bool? RelationshipWithRDEmployeeIndicator { get; set; }

		[DataMember(Name="retirementPensionIncomeAvailable", EmitDefaultValue=false)]
		public bool? RetirementPensionIncomeAvailable { get; set; }

		[DataMember(Name="schoolingTermYears", EmitDefaultValue=false)]
		public int? SchoolingTermYears { get; set; }

		[DataMember(Name="selfEmployedValidationMessage", EmitDefaultValue=false)]
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

		[DataMember(Name="sSA89BackgroundCheckIndicator", EmitDefaultValue=false)]
		public bool? SSA89BackgroundCheckIndicator { get; set; }

		[DataMember(Name="sSA89BankingServiceIndicator", EmitDefaultValue=false)]
		public bool? SSA89BankingServiceIndicator { get; set; }

		[DataMember(Name="sSA89CreditCheckIndicator", EmitDefaultValue=false)]
		public bool? SSA89CreditCheckIndicator { get; set; }

		[DataMember(Name="sSA89LicenseRequirementIndicator", EmitDefaultValue=false)]
		public bool? SSA89LicenseRequirementIndicator { get; set; }

		[DataMember(Name="sSA89MortgageServiceIndicator", EmitDefaultValue=false)]
		public bool? SSA89MortgageServiceIndicator { get; set; }

		[DataMember(Name="sSA89OtherIndicator", EmitDefaultValue=false)]
		public bool? SSA89OtherIndicator { get; set; }

		[DataMember(Name="sSNValidationMessage", EmitDefaultValue=false)]
		public string SSNValidationMessage { get; set; }

		[DataMember(Name="subtotalLiquidAssetsMinusGiftAmount", EmitDefaultValue=false)]
		public double? SubtotalLiquidAssetsMinusGiftAmount { get; set; }

		[DataMember(Name="suffixToName", EmitDefaultValue=false)]
		public string SuffixToName { get; set; }

		[DataMember(Name="tax4506LastInvestor", EmitDefaultValue=false)]
		public string Tax4506LastInvestor { get; set; }

		[DataMember(Name="tax4506LastOrderNumber", EmitDefaultValue=false)]
		public string Tax4506LastOrderNumber { get; set; }

		[DataMember(Name="tax4506LastOrderYear1", EmitDefaultValue=false)]
		public int? Tax4506LastOrderYear1 { get; set; }

		[DataMember(Name="tax4506LastOrderYear2", EmitDefaultValue=false)]
		public int? Tax4506LastOrderYear2 { get; set; }

		[DataMember(Name="tax4506LastOrderYear3", EmitDefaultValue=false)]
		public int? Tax4506LastOrderYear3 { get; set; }

		[DataMember(Name="tax4506LastOrderYear4", EmitDefaultValue=false)]
		public int? Tax4506LastOrderYear4 { get; set; }

		[DataMember(Name="tax4506LastProductsOrdered", EmitDefaultValue=false)]
		public string Tax4506LastProductsOrdered { get; set; }

		[DataMember(Name="tax4506LastStatus", EmitDefaultValue=false)]
		public string Tax4506LastStatus { get; set; }

		[DataMember(Name="tax4506LastTranscriptType", EmitDefaultValue=false)]
		public string Tax4506LastTranscriptType { get; set; }

		[DataMember(Name="tax4506LastUserIDWhoOrdered", EmitDefaultValue=false)]
		public string Tax4506LastUserIDWhoOrdered { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome1", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome2", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome3", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyIncome4", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome1", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyJointIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome2", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyJointIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome3", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyJointIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyJointIncome4", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyJointIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome1", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome2", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome3", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceIncome4", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceIncome4 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome1", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceJointIncome1 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome2", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceJointIncome2 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome3", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceJointIncome3 { get; set; }

		[DataMember(Name="tax4506TotalYearlyVarianceJointIncome4", EmitDefaultValue=false)]
		public double? Tax4506TotalYearlyVarianceJointIncome4 { get; set; }

		[DataMember(Name="taxIdentificationIdentifier", EmitDefaultValue=false)]
		public string TaxIdentificationIdentifier { get; set; }

		[DataMember(Name="taxReturnValidationMessage", EmitDefaultValue=false)]
		public string TaxReturnValidationMessage { get; set; }

		[DataMember(Name="totalLiabilitiesBalanceAmount", EmitDefaultValue=false)]
		public double? TotalLiabilitiesBalanceAmount { get; set; }

		[DataMember(Name="totalMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? TotalMonthlyIncomeAmount { get; set; }

		[DataMember(Name="totalMonthlyIncomeMinusNetRentalAmount", EmitDefaultValue=false)]
		public double? TotalMonthlyIncomeMinusNetRentalAmount { get; set; }

		[DataMember(Name="totalPresentHousingExpenseAmount", EmitDefaultValue=false)]
		public double? TotalPresentHousingExpenseAmount { get; set; }

		[DataMember(Name="transactionPurposeDescription", EmitDefaultValue=false)]
		public string TransactionPurposeDescription { get; set; }

		[DataMember(Name="transUnion120Days", EmitDefaultValue=false)]
		public int? TransUnion120Days { get; set; }

		[DataMember(Name="transUnion150Days", EmitDefaultValue=false)]
		public int? TransUnion150Days { get; set; }

		[DataMember(Name="transUnion30Days", EmitDefaultValue=false)]
		public int? TransUnion30Days { get; set; }

		[DataMember(Name="transUnion60Days", EmitDefaultValue=false)]
		public int? TransUnion60Days { get; set; }

		[DataMember(Name="transUnion90Days", EmitDefaultValue=false)]
		public int? TransUnion90Days { get; set; }

		[DataMember(Name="transUnionCreditScoreForDisclosure", EmitDefaultValue=false)]
		public bool? TransUnionCreditScoreForDisclosure { get; set; }

		[DataMember(Name="transUnionCreditScoreRanksPercent", EmitDefaultValue=false)]
		public int? TransUnionCreditScoreRanksPercent { get; set; }

		[DataMember(Name="transUnionDatePulled", EmitDefaultValue=false)]
		public DateTime? TransUnionDatePulled { get; set; }

		[DataMember(Name="transUnionFactorCode1", EmitDefaultValue=false)]
		public string TransUnionFactorCode1 { get; set; }

		[DataMember(Name="transUnionFactorCode2", EmitDefaultValue=false)]
		public string TransUnionFactorCode2 { get; set; }

		[DataMember(Name="transUnionFactorCode3", EmitDefaultValue=false)]
		public string TransUnionFactorCode3 { get; set; }

		[DataMember(Name="transUnionFactorCode4", EmitDefaultValue=false)]
		public string TransUnionFactorCode4 { get; set; }

		[DataMember(Name="transUnionFactorCode5", EmitDefaultValue=false)]
		public string TransUnionFactorCode5 { get; set; }

		[DataMember(Name="transUnionKeyFactor1", EmitDefaultValue=false)]
		public string TransUnionKeyFactor1 { get; set; }

		[DataMember(Name="transUnionKeyFactor2", EmitDefaultValue=false)]
		public string TransUnionKeyFactor2 { get; set; }

		[DataMember(Name="transUnionKeyFactor3", EmitDefaultValue=false)]
		public string TransUnionKeyFactor3 { get; set; }

		[DataMember(Name="transUnionKeyFactor4", EmitDefaultValue=false)]
		public string TransUnionKeyFactor4 { get; set; }

		[DataMember(Name="transUnionKeyFactor5", EmitDefaultValue=false)]
		public string TransUnionKeyFactor5 { get; set; }

		[DataMember(Name="transUnionMaterialTermsCreditByScore", EmitDefaultValue=false)]
		public bool? TransUnionMaterialTermsCreditByScore { get; set; }

		[DataMember(Name="transUnionScore", EmitDefaultValue=false)]
		public string TransUnionScore { get; set; }

		[DataMember(Name="userDefinedIncome", EmitDefaultValue=false)]
		public double? UserDefinedIncome { get; set; }

		[DataMember(Name="vaFederalTaxAmount", EmitDefaultValue=false)]
		public double? VaFederalTaxAmount { get; set; }

		[DataMember(Name="validDaysForConsentCount", EmitDefaultValue=false)]
		public int? ValidDaysForConsentCount { get; set; }

		[DataMember(Name="valueRepAndWarrantyAvailable", EmitDefaultValue=false)]
		public bool? ValueRepAndWarrantyAvailable { get; set; }

		[DataMember(Name="valueRepAndWarrantyMessage", EmitDefaultValue=false)]
		public string ValueRepAndWarrantyMessage { get; set; }

		[DataMember(Name="vaNetTakeHomePayAmount", EmitDefaultValue=false)]
		public double? VaNetTakeHomePayAmount { get; set; }

		[DataMember(Name="vaOtherAmount", EmitDefaultValue=false)]
		public double? VaOtherAmount { get; set; }

		[DataMember(Name="vaOtherNetIncomeAmount", EmitDefaultValue=false)]
		public double? VaOtherNetIncomeAmount { get; set; }

		[DataMember(Name="vaRetirementAmount", EmitDefaultValue=false)]
		public double? VaRetirementAmount { get; set; }

		[DataMember(Name="vaStateTaxAmount", EmitDefaultValue=false)]
		public double? VaStateTaxAmount { get; set; }

		[DataMember(Name="vaTotalIncomeDeductionsAmount", EmitDefaultValue=false)]
		public double? VaTotalIncomeDeductionsAmount { get; set; }

		[DataMember(Name="vaTotalNetIncomeAmount", EmitDefaultValue=false)]
		public double? VaTotalNetIncomeAmount { get; set; }

		[DataMember(Name="vendor1", EmitDefaultValue=false)]
		public string Vendor1 { get; set; }

		[DataMember(Name="vendor10", EmitDefaultValue=false)]
		public string Vendor10 { get; set; }

		[DataMember(Name="vendor11", EmitDefaultValue=false)]
		public string Vendor11 { get; set; }

		[DataMember(Name="vendor12", EmitDefaultValue=false)]
		public string Vendor12 { get; set; }

		[DataMember(Name="vendor13", EmitDefaultValue=false)]
		public string Vendor13 { get; set; }

		[DataMember(Name="vendor14", EmitDefaultValue=false)]
		public string Vendor14 { get; set; }

		[DataMember(Name="vendor15", EmitDefaultValue=false)]
		public string Vendor15 { get; set; }

		[DataMember(Name="vendor16", EmitDefaultValue=false)]
		public string Vendor16 { get; set; }

		[DataMember(Name="vendor17", EmitDefaultValue=false)]
		public string Vendor17 { get; set; }

		[DataMember(Name="vendor18", EmitDefaultValue=false)]
		public string Vendor18 { get; set; }

		[DataMember(Name="vendor19", EmitDefaultValue=false)]
		public string Vendor19 { get; set; }

		[DataMember(Name="vendor2", EmitDefaultValue=false)]
		public string Vendor2 { get; set; }

		[DataMember(Name="vendor20", EmitDefaultValue=false)]
		public string Vendor20 { get; set; }

		[DataMember(Name="vendor21", EmitDefaultValue=false)]
		public string Vendor21 { get; set; }

		[DataMember(Name="vendor22", EmitDefaultValue=false)]
		public string Vendor22 { get; set; }

		[DataMember(Name="vendor23", EmitDefaultValue=false)]
		public string Vendor23 { get; set; }

		[DataMember(Name="vendor24", EmitDefaultValue=false)]
		public string Vendor24 { get; set; }

		[DataMember(Name="vendor25", EmitDefaultValue=false)]
		public string Vendor25 { get; set; }

		[DataMember(Name="vendor26", EmitDefaultValue=false)]
		public string Vendor26 { get; set; }

		[DataMember(Name="vendor27", EmitDefaultValue=false)]
		public string Vendor27 { get; set; }

		[DataMember(Name="vendor28", EmitDefaultValue=false)]
		public string Vendor28 { get; set; }

		[DataMember(Name="vendor29", EmitDefaultValue=false)]
		public string Vendor29 { get; set; }

		[DataMember(Name="vendor3", EmitDefaultValue=false)]
		public string Vendor3 { get; set; }

		[DataMember(Name="vendor30", EmitDefaultValue=false)]
		public string Vendor30 { get; set; }

		[DataMember(Name="vendor31", EmitDefaultValue=false)]
		public string Vendor31 { get; set; }

		[DataMember(Name="vendor32", EmitDefaultValue=false)]
		public string Vendor32 { get; set; }

		[DataMember(Name="vendor33", EmitDefaultValue=false)]
		public string Vendor33 { get; set; }

		[DataMember(Name="vendor34", EmitDefaultValue=false)]
		public string Vendor34 { get; set; }

		[DataMember(Name="vendor35", EmitDefaultValue=false)]
		public string Vendor35 { get; set; }

		[DataMember(Name="vendor36", EmitDefaultValue=false)]
		public string Vendor36 { get; set; }

		[DataMember(Name="vendor4", EmitDefaultValue=false)]
		public string Vendor4 { get; set; }

		[DataMember(Name="vendor5", EmitDefaultValue=false)]
		public string Vendor5 { get; set; }

		[DataMember(Name="vendor6", EmitDefaultValue=false)]
		public string Vendor6 { get; set; }

		[DataMember(Name="vendor7", EmitDefaultValue=false)]
		public string Vendor7 { get; set; }

		[DataMember(Name="vendor8", EmitDefaultValue=false)]
		public string Vendor8 { get; set; }

		[DataMember(Name="vendor9", EmitDefaultValue=false)]
		public string Vendor9 { get; set; }

		[DataMember(Name="vestingTrusteeOfType", EmitDefaultValue=false)]
		public string VestingTrusteeOfType { get; set; }

		[DataMember(Name="veteranIndicator", EmitDefaultValue=false)]
		public bool? VeteranIndicator { get; set; }

		[DataMember(Name="workEmailAddress", EmitDefaultValue=false)]
		public string WorkEmailAddress { get; set; }

		[DataMember(Name="yearsofCreditOnFile", EmitDefaultValue=false)]
		public int? YearsofCreditOnFile { get; set; }

		[DataMember(Name = "urla2020CitizenshipResidencyType", EmitDefaultValue = false)]
		public string Urla2020CitizenshipResidencyType { get; set; }

		[DataMember(Name = "presentlyDelinquentIndicatorURLA", EmitDefaultValue = false)]
		public bool? PresentlyDelinquentIndicatorURLA { get; set; } = false;

		[DataMember(Name = "partyToLawsuitIndicatorURLA", EmitDefaultValue = false)]
		public bool? PartyToLawsuitIndicatorURLA { get; set; } = false;

		[DataMember(Name = "priorPropertyDeedInLieuConveyedIndicator", EmitDefaultValue = false)]
		public bool? PriorPropertyDeedInLieuConveyedIndicator { get; set; } = false;

		[DataMember(Name = "priorPropertyShortSaleCompletedIndicator", EmitDefaultValue = false)]
		public bool? PriorPropertyShortSaleCompletedIndicator { get; set; } = false;

		[DataMember(Name = "priorPropertyForeclosureCompletedIndicator", EmitDefaultValue = false)]
		public bool? PriorPropertyForeclosureCompletedIndicator { get; set; } = false;

		[DataMember(Name = "realEstateDoesNotApply", EmitDefaultValue = false)]
		public bool? RealEstateDoesNotApply { get; set; } = false;

		[DataMember(Name = "legalOtherThanSpouse", EmitDefaultValue = false)]
		public bool? LegalOtherThanSpouse { get; set; } = false;

		[DataMember(Name = "SelfDeclaredMilitaryServiceIndicator", EmitDefaultValue = false)]
		public bool? SelfDeclaredMilitaryServiceIndicator { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterSeven", EmitDefaultValue = false)]
		public bool? BankruptcyIndicatorChapterSeven { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterEleven", EmitDefaultValue = false)]
		public bool? BankruptcyIndicatorChapterEleven { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterTwelve", EmitDefaultValue = false)]
		public bool? BankruptcyIndicatorChapterTwelve { get; set; } = false;

		[DataMember(Name = "bankruptcyIndicatorChapterThirteen", EmitDefaultValue = false)]
		public bool? BankruptcyIndicatorChapterThirteen { get; set; } = false;

		[DataMember(Name = "currentEmploymentDoesNotApply", EmitDefaultValue = false)]
		public bool? CurrentEmploymentDoesNotApply { get; set; } = false;

		[DataMember(Name = "previousEmploymentDoesNotApply", EmitDefaultValue = false)]
		public bool? PreviousEmploymentDoesNotApply { get; set; } = false;

		[DataMember(Name = "languagePreference", EmitDefaultValue = false)]
		public string LanguagePreference { get; set; }

		[DataMember(Name = "jointAssetLiabilityReportingIndicator1", EmitDefaultValue = false)]
		public string JointAssetLiabilityReportingIndicator1 { get; set; }

		[DataMember(Name = "previousGrossMonthlyIncome", EmitDefaultValue = false)]
		public decimal? PreviousGrossMonthlyIncome { get; set; }

		[DataMember(Name = "priorResidenceDoesNotApply", EmitDefaultValue = false)]
		public bool? PriorResidenceDoesNotApply { get; set; } = false;

		[DataMember(Name = "hmda2CreditScoreForDecisionMaking", EmitDefaultValue = false)]
		public string Hmda2CreditScoreForDecisionMaking { get; set; }

		[DataMember(Name = "hmda2CreditScoringModel", EmitDefaultValue = false)]
		public string Hmda2CreditScoringModel { get; set; }

	}
}