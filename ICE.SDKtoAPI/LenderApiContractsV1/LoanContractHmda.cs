using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHmda
	{
		[DataMember(Name="actionTaken", EmitDefaultValue=false)]
		public string ActionTaken { get; set; }

		[DataMember(Name="applicationDate", EmitDefaultValue=false)]
		public string ApplicationDate { get; set; }

		[DataMember(Name="aUS1", EmitDefaultValue=false)]
		public string AUS1 { get; set; }

		[DataMember(Name="aUS2", EmitDefaultValue=false)]
		public string AUS2 { get; set; }

		[DataMember(Name="aUS3", EmitDefaultValue=false)]
		public string AUS3 { get; set; }

		[DataMember(Name="aUS4", EmitDefaultValue=false)]
		public string AUS4 { get; set; }

		[DataMember(Name="aUS5", EmitDefaultValue=false)]
		public string AUS5 { get; set; }

		[DataMember(Name="aUSRecommendation1", EmitDefaultValue=false)]
		public string AUSRecommendation1 { get; set; }

		[DataMember(Name="aUSRecommendation2", EmitDefaultValue=false)]
		public string AUSRecommendation2 { get; set; }

		[DataMember(Name="aUSRecommendation3", EmitDefaultValue=false)]
		public string AUSRecommendation3 { get; set; }

		[DataMember(Name="aUSRecommendation4", EmitDefaultValue=false)]
		public string AUSRecommendation4 { get; set; }

		[DataMember(Name="aUSRecommendation5", EmitDefaultValue=false)]
		public string AUSRecommendation5 { get; set; }

		[DataMember(Name="businessOrCommercialPurpose", EmitDefaultValue=false)]
		public string BusinessOrCommercialPurpose { get; set; }

		[DataMember(Name="censusTrack", EmitDefaultValue=false)]
		public string CensusTrack { get; set; }

		[DataMember(Name="cLTV", EmitDefaultValue=false)]
		public string CLTV { get; set; }

		[DataMember(Name="contactEmailAddress", EmitDefaultValue=false)]
		public string ContactEmailAddress { get; set; }

		[DataMember(Name="contactFaxNumber", EmitDefaultValue=false)]
		public string ContactFaxNumber { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="contactOfficeCity", EmitDefaultValue=false)]
		public string ContactOfficeCity { get; set; }

		[DataMember(Name="contactOfficeState", EmitDefaultValue=false)]
		public string ContactOfficeState { get; set; }

		[DataMember(Name="contactOfficeStreetAddress", EmitDefaultValue=false)]
		public string ContactOfficeStreetAddress { get; set; }

		[DataMember(Name="contactOfficeZIPCode", EmitDefaultValue=false)]
		public string ContactOfficeZIPCode { get; set; }

		[DataMember(Name="contactPhoneNumber", EmitDefaultValue=false)]
		public string ContactPhoneNumber { get; set; }

		[DataMember(Name="countyCode", EmitDefaultValue=false)]
		public string CountyCode { get; set; }

		[DataMember(Name="debtToIncomeRatio", EmitDefaultValue=false)]
		public string DebtToIncomeRatio { get; set; }

		[DataMember(Name="denialReason1", EmitDefaultValue=false)]
		public string DenialReason1 { get; set; }

		[DataMember(Name="denialReason2", EmitDefaultValue=false)]
		public string DenialReason2 { get; set; }

		[DataMember(Name="denialReason3", EmitDefaultValue=false)]
		public string DenialReason3 { get; set; }

		[DataMember(Name="denialReason4", EmitDefaultValue=false)]
		public string DenialReason4 { get; set; }

		[DataMember(Name="discountPoints", EmitDefaultValue=false)]
		public string DiscountPoints { get; set; }

		[DataMember(Name="excludeLoanFromHMDAReportIndicator", EmitDefaultValue=false)]
		public bool? ExcludeLoanFromHMDAReportIndicator { get; set; }

		[DataMember(Name="federalAgency", EmitDefaultValue=false)]
		public string FederalAgency { get; set; }

		[DataMember(Name="federalTaxpayerIdNumber", EmitDefaultValue=false)]
		public string FederalTaxpayerIdNumber { get; set; }

		[DataMember(Name="financialInstitutionName", EmitDefaultValue=false)]
		public string FinancialInstitutionName { get; set; }

		[DataMember(Name="hMDACensusTrack", EmitDefaultValue=false)]
		public string HMDACensusTrack { get; set; }

		[DataMember(Name="hmdaCltvIndicator", EmitDefaultValue=false)]
		public bool? HmdaCltvIndicator { get; set; }

		[DataMember(Name="hMDACountyCode", EmitDefaultValue=false)]
		public string HMDACountyCode { get; set; }

		[DataMember(Name="hmdaDtiIndicator", EmitDefaultValue=false)]
		public bool? HmdaDtiIndicator { get; set; }

		[DataMember(Name="hmdaIncomeIndicator", EmitDefaultValue=false)]
		public bool? HmdaIncomeIndicator { get; set; }

		[DataMember(Name="hmdaInterestOnlyIndicator", EmitDefaultValue=false)]
		public bool? HmdaInterestOnlyIndicator { get; set; }

		[DataMember(Name="hMDALoanPurpose", EmitDefaultValue=false)]
		public string HMDALoanPurpose { get; set; }

		[DataMember(Name="hMDAProfileApplicationDateValue", EmitDefaultValue=false)]
		public string HMDAProfileApplicationDateValue { get; set; }

		[DataMember(Name="hMDAProfileCLTVValue", EmitDefaultValue=false)]
		public string HMDAProfileCLTVValue { get; set; }

		[DataMember(Name="hMDAProfileDTIValue", EmitDefaultValue=false)]
		public string HMDAProfileDTIValue { get; set; }

		[DataMember(Name="hMDAProfileID", EmitDefaultValue=false)]
		public string HMDAProfileID { get; set; }

		[DataMember(Name="hMDAProfileIncomeValue", EmitDefaultValue=false)]
		public string HMDAProfileIncomeValue { get; set; }

		[DataMember(Name="hmdaPropertyAddress", EmitDefaultValue=false)]
		public string HmdaPropertyAddress { get; set; }

		[DataMember(Name="hmdaPropertyCity", EmitDefaultValue=false)]
		public string HmdaPropertyCity { get; set; }

		[DataMember(Name="hmdaPropertyState", EmitDefaultValue=false)]
		public string HmdaPropertyState { get; set; }

		[DataMember(Name="hmdaPropertyValueNotReliedUponIndicator", EmitDefaultValue=false)]
		public bool? HmdaPropertyValueNotReliedUponIndicator { get; set; }

		[DataMember(Name="hmdaPropertyZipCode", EmitDefaultValue=false)]
		public string HmdaPropertyZipCode { get; set; }

		[DataMember(Name="hmdaSyncAddressIndicator", EmitDefaultValue=false)]
		public bool? HmdaSyncAddressIndicator { get; set; }

		[DataMember(Name="hOEPAStatus", EmitDefaultValue=false)]
		public string HOEPAStatus { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="income", EmitDefaultValue=false)]
		public string Income { get; set; }

		[DataMember(Name="incomeExcludedFromHmda", EmitDefaultValue=false)]
		public double? IncomeExcludedFromHmda { get; set; }

		[DataMember(Name="initiallyPayableToYourInstitution", EmitDefaultValue=false)]
		public string InitiallyPayableToYourInstitution { get; set; }

		[DataMember(Name="interestRate", EmitDefaultValue=false)]
		public string InterestRate { get; set; }

		[DataMember(Name="introRatePeriod", EmitDefaultValue=false)]
		public string IntroRatePeriod { get; set; }

		[DataMember(Name="legalEntityIdentifier", EmitDefaultValue=false)]
		public string LegalEntityIdentifier { get; set; }

		[DataMember(Name="legalEntityIdentifierReporting", EmitDefaultValue=false)]
		public string LegalEntityIdentifierReporting { get; set; }

		[DataMember(Name="legalEntityIdentifierUsed", EmitDefaultValue=false)]
		public string LegalEntityIdentifierUsed { get; set; }

		[DataMember(Name="lenderCredits", EmitDefaultValue=false)]
		public string LenderCredits { get; set; }

		[DataMember(Name="lienStatus", EmitDefaultValue=false)]
		public string LienStatus { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public double? LoanAmount { get; set; }

		[DataMember(Name="loanPurpose", EmitDefaultValue=false)]
		public string LoanPurpose { get; set; }

		[DataMember(Name="loanTerm", EmitDefaultValue=false)]
		public string LoanTerm { get; set; }

		[DataMember(Name="loanType", EmitDefaultValue=false)]
		public string LoanType { get; set; }

		[DataMember(Name="manufacturedHomeLandPropertyInterest", EmitDefaultValue=false)]
		public string ManufacturedHomeLandPropertyInterest { get; set; }

		[DataMember(Name="manufacturedSecuredProperyType", EmitDefaultValue=false)]
		public string ManufacturedSecuredProperyType { get; set; }

		[DataMember(Name="mSANumber", EmitDefaultValue=false)]
		public string MSANumber { get; set; }

		[DataMember(Name="multifamilyNoUnits", EmitDefaultValue=false)]
		public string MultifamilyNoUnits { get; set; }

		[DataMember(Name="nMLSLoanOriginatorID", EmitDefaultValue=false)]
		public string NMLSLoanOriginatorID { get; set; }

		[DataMember(Name="openEndLineOfCredit", EmitDefaultValue=false)]
		public string OpenEndLineOfCredit { get; set; }

		[DataMember(Name="originationCharges", EmitDefaultValue=false)]
		public string OriginationCharges { get; set; }

		[DataMember(Name="otherAUS", EmitDefaultValue=false)]
		public string OtherAUS { get; set; }

		[DataMember(Name="otherAUSRecommendations", EmitDefaultValue=false)]
		public string OtherAUSRecommendations { get; set; }

		[DataMember(Name="otherDenialReason", EmitDefaultValue=false)]
		public string OtherDenialReason { get; set; }

		[DataMember(Name="otherNonAmortization", EmitDefaultValue=false)]
		public string OtherNonAmortization { get; set; }

		[DataMember(Name="parentAddress", EmitDefaultValue=false)]
		public string ParentAddress { get; set; }

		[DataMember(Name="parentCity", EmitDefaultValue=false)]
		public string ParentCity { get; set; }

		[DataMember(Name="parentName", EmitDefaultValue=false)]
		public string ParentName { get; set; }

		[DataMember(Name="parentState", EmitDefaultValue=false)]
		public string ParentState { get; set; }

		[DataMember(Name="parentZip", EmitDefaultValue=false)]
		public string ParentZip { get; set; }

		[DataMember(Name="preapprovals", EmitDefaultValue=false)]
		public string Preapprovals { get; set; }

		[DataMember(Name="prepaymentPenaltyPeriod", EmitDefaultValue=false)]
		public string PrepaymentPenaltyPeriod { get; set; }

		[DataMember(Name="propertyType", EmitDefaultValue=false)]
		public string PropertyType { get; set; }

		[DataMember(Name="propertyValue", EmitDefaultValue=false)]
		public string PropertyValue { get; set; }

		[DataMember(Name="qMStatus", EmitDefaultValue=false)]
		public string QMStatus { get; set; }

		[DataMember(Name="rateSpread", EmitDefaultValue=false)]
		public string RateSpread { get; set; }

		[DataMember(Name="reportingYear", EmitDefaultValue=false)]
		public int? ReportingYear { get; set; }

		[DataMember(Name="reportPurposeOfLoanIndicator", EmitDefaultValue=false)]
		public bool? ReportPurposeOfLoanIndicator { get; set; }

		[DataMember(Name="repurchasedActionDate", EmitDefaultValue=false)]
		public string RepurchasedActionDate { get; set; }

		[DataMember(Name="repurchasedActionTaken", EmitDefaultValue=false)]
		public string RepurchasedActionTaken { get; set; }

		[DataMember(Name="repurchasedLoanAmount", EmitDefaultValue=false)]
		public double? RepurchasedLoanAmount { get; set; }

		[DataMember(Name="repurchasedReportingYear", EmitDefaultValue=false)]
		public int? RepurchasedReportingYear { get; set; }

		[DataMember(Name="repurchasedTypeOfPurchaser", EmitDefaultValue=false)]
		public string RepurchasedTypeOfPurchaser { get; set; }

		[DataMember(Name="respondentID", EmitDefaultValue=false)]
		public string RespondentID { get; set; }

		[DataMember(Name="reverseMortgage", EmitDefaultValue=false)]
		public string ReverseMortgage { get; set; }

		[DataMember(Name="stateCode", EmitDefaultValue=false)]
		public string StateCode { get; set; }

		[DataMember(Name="submissionOfApplication", EmitDefaultValue=false)]
		public string SubmissionOfApplication { get; set; }

		[DataMember(Name="totalLoanCosts", EmitDefaultValue=false)]
		public string TotalLoanCosts { get; set; }

		[DataMember(Name="totalPointsAndFees", EmitDefaultValue=false)]
		public string TotalPointsAndFees { get; set; }

		[DataMember(Name="typeOfPurchaser", EmitDefaultValue=false)]
		public string TypeOfPurchaser { get; set; }

		[DataMember(Name="universalLoanId", EmitDefaultValue=false)]
		public string UniversalLoanId { get; set; }

	}
}