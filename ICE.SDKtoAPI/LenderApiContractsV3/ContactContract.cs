using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ContactContract
    {
        [DataMember(Name = "contactType")]
        public string ContactType { get; set; }

        [DataMember(Name = "customContactIndex")]
        public int? CustomContactIndex { get; set; }

        [DataMember(Name = "aba")]
        public string Aba { get; set; }

        [DataMember(Name = "accountName")]
        public string AccountName { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "address2")]
        public string Address2 { get; set; }

        [DataMember(Name = "addToCdContactInfo")]
        public bool? AddToCdContactInfo { get; set; }

        [DataMember(Name = "bizLicenseNumber")]
        public string BizLicenseNumber { get; set; }

        [DataMember(Name = "bizLicenseAuthDate")]
        public string BizLicenseAuthDate { get; set; }

        [DataMember(Name = "bizLicenseAuthName")]
        public string BizLicenseAuthName { get; set; }

        [DataMember(Name = "bizLicenseAuthStateCode")]
        public string BizLicenseAuthStateCode { get; set; }

        [DataMember(Name = "bizLicenseAuthType")]
        public string BizLicenseAuthType { get; set; }

        [DataMember(Name = "businessPhone")]
        public string BusinessPhone { get; set; }

        [DataMember(Name = "categoryName")]
        public string CategoryName { get; set; }

        [DataMember(Name = "cell")]
        public string Cell { get; set; }

        [DataMember(Name = "checkConfirmedDate")]
        public string CheckConfirmedDate { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "clause")]
        public string Clause { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "companyId")]
        public string CompanyId { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "contactNmlsNo")]
        public string ContactNmlsNo { get; set; }

        [DataMember(Name = "contactTitle")]
        public string ContactTitle { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "fax2")]
        public string Fax2 { get; set; }

        [DataMember(Name = "fhaLenderId")]
        public string FhaLenderId { get; set; }

        [DataMember(Name = "insuranceCertNumber")]
        public string InsuranceCertNumber { get; set; }

        [DataMember(Name = "insuranceCoverageAmount")]
        public decimal? InsuranceCoverageAmount { get; set; }

        [DataMember(Name = "insuranceDeterminationDate")]
        public string InsuranceDeterminationDate { get; set; }

        [DataMember(Name = "insuranceDeterminationNumber")]
        public string InsuranceDeterminationNumber { get; set; }

        [DataMember(Name = "insuranceFloodZone")]
        public bool? InsuranceFloodZone { get; set; }

        [DataMember(Name = "insuranceMap")]
        public string InsuranceMap { get; set; }

        [DataMember(Name = "insuranceNoOfBedrooms")]
        public int? InsuranceNoOfBedrooms { get; set; }

        [DataMember(Name = "insurancePremium")]
        public decimal? InsurancePremium { get; set; }

        [DataMember(Name = "insuranceProjectType")]
        public string InsuranceProjectType { get; set; }

        [DataMember(Name = "insuranceRenewalDate")]
        public string InsuranceRenewalDate { get; set; }

        [DataMember(Name = "investorGrade1")]
        public string InvestorGrade1 { get; set; }

        [DataMember(Name = "investorGrade2")]
        public string InvestorGrade2 { get; set; }

        [DataMember(Name = "investorGrade3")]
        public string InvestorGrade3 { get; set; }

        [DataMember(Name = "investorName1")]
        public string InvestorName1 { get; set; }

        [DataMember(Name = "investorName2")]
        public string InvestorName2 { get; set; }

        [DataMember(Name = "investorName3")]
        public string InvestorName3 { get; set; }

        [DataMember(Name = "investorScore1")]
        public string InvestorScore1 { get; set; }

        [DataMember(Name = "investorScore2")]
        public string InvestorScore2 { get; set; }

        [DataMember(Name = "investorScore3")]
        public string InvestorScore3 { get; set; }

        [DataMember(Name = "license")]
        public string License { get; set; }

        [DataMember(Name = "lineItemNumber")]
        public string LineItemNumber { get; set; }

        [DataMember(Name = "loginId")]
        public string LoginId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "nmlsLicense")]
        public string NmlsLicense { get; set; }

        [DataMember(Name = "organizationState")]
        public string OrganizationState { get; set; }

        [DataMember(Name = "organizationType")]
        public string OrganizationType { get; set; }

        [DataMember(Name = "personalLicenseAuthDate")]
        public string PersonalLicenseAuthDate { get; set; }

        [DataMember(Name = "personalLicenseAuthName")]
        public string PersonalLicenseAuthName { get; set; }

        [DataMember(Name = "personalLicenseAuthStateCode")]
        public string PersonalLicenseAuthStateCode { get; set; }

        [DataMember(Name = "personalLicenseAuthType")]
        public string PersonalLicenseAuthType { get; set; }

        [DataMember(Name = "personalLicenseNumber")]
        public string PersonalLicenseNumber { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "phone2")]
        public string Phone2 { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "recCity")]
        public string RecCity { get; set; }

        [DataMember(Name = "referenceNumber")]
        public string ReferenceNumber { get; set; }

        [DataMember(Name = "warehouseLender")]
        public string WarehouseLender { get; set; }

        [DataMember(Name = "warehouseId")]
        public string WarehouseId { get; set; }

        [DataMember(Name = "warehouseUrl")]
        public string WarehouseUrl { get; set; }

        [DataMember(Name = "fundsToTitleDate")]
        public string FundsToTitleDate { get; set; }

        [DataMember(Name = "fedReferenceNumber")]
        public string FedReferenceNumber { get; set; }

        [DataMember(Name = "relationship")]
        public string Relationship { get; set; }

        [DataMember(Name = "settlementAgent")]
        public bool? SettlementAgent { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "taxId")]
        public string TaxId { get; set; }

        [DataMember(Name = "tqlCommentHistory")]
        public string TqlCommentHistory { get; set; }

        [DataMember(Name = "tqlConsentSelection")]
        public string TqlConsentSelection { get; set; }

        [DataMember(Name = "tqlId")]
        public int? TqlId { get; set; }

        [DataMember(Name = "tqlIsPublishingIndicator")]
        public bool? TqlIsPublishingIndicator { get; set; }

        [DataMember(Name = "tqlName")]
        public string TqlName { get; set; }

        [DataMember(Name = "lenderType")]
        public string LenderType { get; set; }

        [DataMember(Name = "licenseHomeState")]
        public string LicenseHomeState { get; set; }

        [DataMember(Name = "licenseType")]
        public string LicenseType { get; set; }

        [DataMember(Name = "licenseExempt")]
        public bool? LicenseExempt { get; set; }

        [DataMember(Name = "investorLicense")]
        public string InvestorLicense { get; set; }

        [DataMember(Name = "brokerLenderType")]
        public string BrokerLenderType { get; set; }

        [DataMember(Name = "brokerLicenseType")]
        public string BrokerLicenseType { get; set; }

        [DataMember(Name = "brokerLicenseExempt")]
        public bool? BrokerLicenseExempt { get; set; }

        [DataMember(Name = "investorLicenseType")]
        public string InvestorLicenseType { get; set; }

        [DataMember(Name = "borrowerActingAsContractorIndicator")]
        public bool? BorrowerActingAsContractorIndicator { get; set; }

        [DataMember(Name = "generalLiabilityInsuranceMin")]
        public decimal? GeneralLiabilityInsuranceMin { get; set; }

        [DataMember(Name = "employerLiabilityInsuranceMin")]
        public decimal? EmployerLiabilityInsuranceMin { get; set; }

        [DataMember(Name = "completionAffidavitPunchListTotal")]
        public decimal? CompletionAffidavitPunchListTotal { get; set; }

        [DataMember(Name = "designeeAcceptedDate")]
        public string DesigneeAcceptedDate { get; set; }

        [DataMember(Name = "appraisalMade")]
        public string AppraisalMade { get; set; }

        [DataMember(Name = "notNaturalPersonFlag")]
        public bool? NotNaturalPersonFlag { get; set; }

        [DataMember(Name = "mortgageLenderCompanyWebUrl")]
        public string MortgageLenderCompanyWebUrl { get; set; }

        [DataMember(Name = "mortgageLenderLoanOfficerWebUrl")]
        public string MortgageLenderLoanOfficerWebUrl { get; set; }

        [DataMember(Name = "mortgageBrokerCompanyWebUrl")]
        public string MortgageBrokerCompanyWebUrl { get; set; }

        [DataMember(Name = "mortgageBrokerLoanOfficerWebUrl")]
        public string MortgageBrokerLoanOfficerWebUrl { get; set; }

        [DataMember(Name = "realEstateAgencyWebUrl")]
        public string RealEstateAgencyWebUrl { get; set; }

        [DataMember(Name = "realEstateAgentWebUrl")]
        public string RealEstateAgentWebUrl { get; set; }

        [DataMember(Name = "closingCompanyWebUrl")]
        public string ClosingCompanyWebUrl { get; set; }

        [DataMember(Name = "closingAgentWebUrl")]
        public string ClosingAgentWebUrl { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "jobTitle")]
        public string JobTitle { get; set; }

        [DataMember(Name = "contactRef")]
        public string ContactRef { get; set; }
    }
}
