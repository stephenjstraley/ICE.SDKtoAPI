using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractContacts
	{
		[DataMember(Name="aBA", EmitDefaultValue=false)]
		public string ABA { get; set; }

		[DataMember(Name="accountName", EmitDefaultValue=false)]
		public string AccountName { get; set; }

		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="address2", EmitDefaultValue=false)]
		public string Address2 { get; set; }

		[DataMember(Name= "addToCdContactInfo", EmitDefaultValue=false)]
		public bool? AddToCdContactInfo { get; set; }

		[DataMember(Name="appraisalMade", EmitDefaultValue=false)]
		public string AppraisalMade { get; set; }

		[DataMember(Name="bizLicenseAuthDate", EmitDefaultValue=false)]
		public DateTime? BizLicenseAuthDate { get; set; }

		[DataMember(Name="bizLicenseAuthName", EmitDefaultValue=false)]
		public string BizLicenseAuthName { get; set; }

		[DataMember(Name="bizLicenseAuthStateCode", EmitDefaultValue=false)]
		public string BizLicenseAuthStateCode { get; set; }

		[DataMember(Name="bizLicenseAuthType", EmitDefaultValue=false)]
		public string BizLicenseAuthType { get; set; }

		[DataMember(Name="bizLicenseNumber", EmitDefaultValue=false)]
		public string BizLicenseNumber { get; set; }

		[DataMember(Name="borrowerActingAsContractorIndicator", EmitDefaultValue=false)]
		public bool? BorrowerActingAsContractorIndicator { get; set; }

		[DataMember(Name="brokerLenderType", EmitDefaultValue=false)]
		public string BrokerLenderType { get; set; }

		[DataMember(Name="brokerLicenseExempt", EmitDefaultValue=false)]
		public bool? BrokerLicenseExempt { get; set; }

		[DataMember(Name="brokerLicenseType", EmitDefaultValue=false)]
		public string BrokerLicenseType { get; set; }

		[DataMember(Name="businessPhone", EmitDefaultValue=false)]
		public string BusinessPhone { get; set; }

		[DataMember(Name="categoryName", EmitDefaultValue=false)]
		public string CategoryName { get; set; }

		[DataMember(Name="cell", EmitDefaultValue=false)]
		public string Cell { get; set; }

		[DataMember(Name="checkConfirmedDate", EmitDefaultValue=false)]
		public DateTime? CheckConfirmedDate { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="clause", EmitDefaultValue=false)]
		public string Clause { get; set; }

		[DataMember(Name="closingAgentWebURL", EmitDefaultValue=false)]
		public string ClosingAgentWebURL { get; set; }

		[DataMember(Name="closingCompanyWebURL", EmitDefaultValue=false)]
		public string ClosingCompanyWebURL { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="companyId", EmitDefaultValue=false)]
		public string CompanyId { get; set; }

		[DataMember(Name="completionAffidavitPunchListTotal", EmitDefaultValue=false)]
		public double? CompletionAffidavitPunchListTotal { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public EntityRefContract Contact { get; set; }

		[DataMember(Name="contactIndex", EmitDefaultValue=false)]
		public int? ContactIndex { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="contactNMLSNo", EmitDefaultValue=false)]
		public string ContactNMLSNo { get; set; }

		[DataMember(Name="contactTitle", EmitDefaultValue=false)]
		public string ContactTitle { get; set; }

		[DataMember(Name="contactType", EmitDefaultValue=false)]
		public string ContactType { get; set; }

		[DataMember(Name="designeeAcceptedDate", EmitDefaultValue=false)]
		public DateTime? DesigneeAcceptedDate { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="employerLiabilityInsuranceMin", EmitDefaultValue=false)]
		public double? EmployerLiabilityInsuranceMin { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="fax2", EmitDefaultValue=false)]
		public string Fax2 { get; set; }

		[DataMember(Name="fhaLenderId", EmitDefaultValue=false)]
		public string FhaLenderId { get; set; }

		[DataMember(Name="generalLiabilityInsuranceMin", EmitDefaultValue=false)]
		public double? GeneralLiabilityInsuranceMin { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="insuranceCertNumber", EmitDefaultValue=false)]
		public string InsuranceCertNumber { get; set; }

		[DataMember(Name="insuranceCoverageAmount", EmitDefaultValue=false)]
		public double? InsuranceCoverageAmount { get; set; }

		[DataMember(Name="insuranceDeterminationDate", EmitDefaultValue=false)]
		public DateTime? InsuranceDeterminationDate { get; set; }

		[DataMember(Name="insuranceDeterminationNumber", EmitDefaultValue=false)]
		public string InsuranceDeterminationNumber { get; set; }

		[DataMember(Name="insuranceFloodZone", EmitDefaultValue=false)]
		public bool? InsuranceFloodZone { get; set; }

		[DataMember(Name="insuranceMap", EmitDefaultValue=false)]
		public string InsuranceMap { get; set; }

		[DataMember(Name="insuranceNoOfBedrooms", EmitDefaultValue=false)]
		public int? InsuranceNoOfBedrooms { get; set; }

		[DataMember(Name="insurancePremium", EmitDefaultValue=false)]
		public double? InsurancePremium { get; set; }

		[DataMember(Name="insuranceProjectType", EmitDefaultValue=false)]
		public string InsuranceProjectType { get; set; }

		[DataMember(Name="insuranceRenewalDate", EmitDefaultValue=false)]
		public DateTime? InsuranceRenewalDate { get; set; }

		[DataMember(Name="investorGrade1", EmitDefaultValue=false)]
		public string InvestorGrade1 { get; set; }

		[DataMember(Name="investorGrade2", EmitDefaultValue=false)]
		public string InvestorGrade2 { get; set; }

		[DataMember(Name="investorGrade3", EmitDefaultValue=false)]
		public string InvestorGrade3 { get; set; }

		[DataMember(Name="investorLicense", EmitDefaultValue=false)]
		public string InvestorLicense { get; set; }

		[DataMember(Name="investorLicenseType", EmitDefaultValue=false)]
		public string InvestorLicenseType { get; set; }

		[DataMember(Name="investorName1", EmitDefaultValue=false)]
		public string InvestorName1 { get; set; }

		[DataMember(Name="investorName2", EmitDefaultValue=false)]
		public string InvestorName2 { get; set; }

		[DataMember(Name="investorName3", EmitDefaultValue=false)]
		public string InvestorName3 { get; set; }

		[DataMember(Name="investorScore1", EmitDefaultValue=false)]
		public string InvestorScore1 { get; set; }

		[DataMember(Name="investorScore2", EmitDefaultValue=false)]
		public string InvestorScore2 { get; set; }

		[DataMember(Name="investorScore3", EmitDefaultValue=false)]
		public string InvestorScore3 { get; set; }

		[DataMember(Name="lenderType", EmitDefaultValue=false)]
		public string LenderType { get; set; }

		[DataMember(Name="license", EmitDefaultValue=false)]
		public string License { get; set; }

		[DataMember(Name="licenseExempt", EmitDefaultValue=false)]
		public bool? LicenseExempt { get; set; }

		[DataMember(Name="licenseHomeState", EmitDefaultValue=false)]
		public string LicenseHomeState { get; set; }

		[DataMember(Name="licenseType", EmitDefaultValue=false)]
		public string LicenseType { get; set; }

		[DataMember(Name="lineItemNumber", EmitDefaultValue=false)]
		public string LineItemNumber { get; set; }

		[DataMember(Name="loginId", EmitDefaultValue=false)]
		public string LoginId { get; set; }

		[DataMember(Name="mortgageBrokerCompanyWebURL", EmitDefaultValue=false)]
		public string MortgageBrokerCompanyWebURL { get; set; }

		[DataMember(Name="mortgageBrokerLoanOfficerWebURL", EmitDefaultValue=false)]
		public string MortgageBrokerLoanOfficerWebURL { get; set; }

		[DataMember(Name="mortgageLenderCompanyWebURL", EmitDefaultValue=false)]
		public string MortgageLenderCompanyWebURL { get; set; }

		[DataMember(Name="mortgageLenderLoanOfficerWebURL", EmitDefaultValue=false)]
		public string MortgageLenderLoanOfficerWebURL { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="nmlsLicense", EmitDefaultValue=false)]
		public string NmlsLicense { get; set; }

		[DataMember(Name="notNaturalPersonFlag", EmitDefaultValue=false)]
		public bool? NotNaturalPersonFlag { get; set; }

		[DataMember(Name="organizationState", EmitDefaultValue=false)]
		public string OrganizationState { get; set; }

		[DataMember(Name="organizationType", EmitDefaultValue=false)]
		public string OrganizationType { get; set; }

		[DataMember(Name="personalLicenseAuthDate", EmitDefaultValue=false)]
		public DateTime? PersonalLicenseAuthDate { get; set; }

		[DataMember(Name="personalLicenseAuthName", EmitDefaultValue=false)]
		public string PersonalLicenseAuthName { get; set; }

		[DataMember(Name="personalLicenseAuthStateCode", EmitDefaultValue=false)]
		public string PersonalLicenseAuthStateCode { get; set; }

		[DataMember(Name="personalLicenseAuthType", EmitDefaultValue=false)]
		public string PersonalLicenseAuthType { get; set; }

		[DataMember(Name="personalLicenseNumber", EmitDefaultValue=false)]
		public string PersonalLicenseNumber { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="phone2", EmitDefaultValue=false)]
		public string Phone2 { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="realEstateAgencyWebURL", EmitDefaultValue=false)]
		public string RealEstateAgencyWebURL { get; set; }

		[DataMember(Name="realEstateAgentWebURL", EmitDefaultValue=false)]
		public string RealEstateAgentWebURL { get; set; }

		[DataMember(Name="recCity", EmitDefaultValue=false)]
		public string RecCity { get; set; }

		[DataMember(Name="referenceNumber", EmitDefaultValue=false)]
		public string ReferenceNumber { get; set; }

		[DataMember(Name="relationship", EmitDefaultValue=false)]
		public string Relationship { get; set; }

		[DataMember(Name="settlementAgent", EmitDefaultValue=false)]
		public bool? SettlementAgent { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="taxID", EmitDefaultValue=false)]
		public string TaxID { get; set; }

		[DataMember(Name="tqlCommentHistory", EmitDefaultValue=false)]
		public string TqlCommentHistory { get; set; }

		[DataMember(Name="tQLConsentSelection", EmitDefaultValue=false)]
		public string TQLConsentSelection { get; set; }

		[DataMember(Name="tqlId", EmitDefaultValue=false)]
		public int? TqlId { get; set; }

		[DataMember(Name="tqlIsPublishingIndicator", EmitDefaultValue=false)]
		public bool? TqlIsPublishingIndicator { get; set; }

		[DataMember(Name="tqlName", EmitDefaultValue=false)]
		public string TqlName { get; set; }

		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }

	}
}