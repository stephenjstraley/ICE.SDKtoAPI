using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContract
	{
		[DataMember(Name="additionalRequests", EmitDefaultValue=false)]
		public LoanContractAdditionalRequests AdditionalRequests { get; set; }

		[DataMember(Name="adverseActionDate", EmitDefaultValue=false)]
		public DateTime? AdverseActionDate { get; set; }

		[DataMember(Name="affiliatedBusinessArrangements", EmitDefaultValue=false)]
		public List<LoanContractAffiliatedBusinessArrangements> AffiliatedBusinessArrangements { get; set; }

		[DataMember(Name="agencyCaseIdentifier", EmitDefaultValue=false)]
		public string AgencyCaseIdentifier { get; set; }

		[DataMember(Name="alertChangeCircumstanceApplyLECD", EmitDefaultValue=false)]
		public string AlertChangeCircumstanceApplyLECD { get; set; }

		[DataMember(Name="alertChangeCircumstances", EmitDefaultValue=false)]
		public List<LoanContractAlertChangeCircumstances> AlertChangeCircumstances { get; set; }

		[DataMember(Name="alterationsImprovementsOrRepairsAmount", EmitDefaultValue=false)]
		public double? AlterationsImprovementsOrRepairsAmount { get; set; }

		[DataMember(Name="applications", EmitDefaultValue=false)]
		public List<LoanContractApplications> Applications { get; set; }

		[DataMember(Name="applicationTakenMethodType", EmitDefaultValue=false)]
		public string ApplicationTakenMethodType { get; set; }

		[DataMember(Name="aprDisclosureDate", EmitDefaultValue=false)]
		public DateTime? AprDisclosureDate { get; set; }

		[DataMember(Name="armTypeDescription", EmitDefaultValue=false)]
		public string ArmTypeDescription { get; set; }

		[DataMember(Name="aTRQMCommon", EmitDefaultValue=false)]
		public LoanContractATRQMCommon ATRQMCommon { get; set; }

		[DataMember(Name = "averageRepresentativeCreditScore", EmitDefaultValue = false)]
		public int? AverageRepresentativeCreditScore { get; set; }

		[DataMember(Name="baseLoanAmount", EmitDefaultValue=false)]
		public double? BaseLoanAmount { get; set; }

		[DataMember(Name="belowMarketSubordinateFinancingIndicator", EmitDefaultValue=false)]
		public bool? BelowMarketSubordinateFinancingIndicator { get; set; }

		[DataMember(Name="billingCategory", EmitDefaultValue=false)]
		public string BillingCategory { get; set; }

		[DataMember(Name="biweeklyPaymentAmount", EmitDefaultValue=false)]
		public double? BiweeklyPaymentAmount { get; set; }

		[DataMember(Name="bLTV", EmitDefaultValue=false)]
		public int? BLTV { get; set; }

		[DataMember(Name="borrowerCoBorrowerMarriedIndicator", EmitDefaultValue=false)]
		public bool? BorrowerCoBorrowerMarriedIndicator { get; set; }

		[DataMember(Name="borrowerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? BorrowerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="borrowerPaidDiscountPointsAmount", EmitDefaultValue=false)]
		public double? BorrowerPaidDiscountPointsAmount { get; set; }

		[DataMember(Name="borrowerPaidFHAVAClosingCostsAmount", EmitDefaultValue=false)]
		public double? BorrowerPaidFHAVAClosingCostsAmount { get; set; }

		[DataMember(Name="borrowerPairCount", EmitDefaultValue=false)]
		public int? BorrowerPairCount { get; set; }

		[DataMember(Name="borrowerRequestedLoanAmount", EmitDefaultValue=false)]
		public double? BorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="brokerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? BrokerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="buydownIndicator", EmitDefaultValue=false)]
		public bool? BuydownIndicator { get; set; }

		[DataMember(Name="buydownMonthlyPaymentAmount", EmitDefaultValue=false)]
		public double? BuydownMonthlyPaymentAmount { get; set; }

		[DataMember(Name="buydownRatePercent", EmitDefaultValue=false)]
		public double? BuydownRatePercent { get; set; }

		[DataMember(Name="cashFromToBorrowerAmount", EmitDefaultValue=false)]
		public double? CashFromToBorrowerAmount { get; set; }

		[DataMember(Name="channel", EmitDefaultValue=false)]
		public string Channel { get; set; }

		[DataMember(Name="closedEndPrimaryMortgageLoanAmount", EmitDefaultValue=false)]
		public double? ClosedEndPrimaryMortgageLoanAmount { get; set; }

		[DataMember(Name="closedEndSubordinateMortgageLoanAmount", EmitDefaultValue=false)]
		public double? ClosedEndSubordinateMortgageLoanAmount { get; set; }

		[DataMember(Name="closingBillingDate", EmitDefaultValue=false)]
		public DateTime? ClosingBillingDate { get; set; }

		[DataMember(Name="closingCost", EmitDefaultValue=false)]
		public LoanContractClosingCost ClosingCost { get; set; }

		[DataMember(Name="closingCostProgram", EmitDefaultValue=false)]
		public string ClosingCostProgram { get; set; }

		[DataMember(Name="closingCostsAndPrepaidsFromOtherLienAmount", EmitDefaultValue=false)]
		public double? ClosingCostsAndPrepaidsFromOtherLienAmount { get; set; }

		[DataMember(Name="closingCostsPaidByOthersAmount", EmitDefaultValue=false)]
		public double? ClosingCostsPaidByOthersAmount { get; set; }

		[DataMember(Name="closingDocsStackingOrder", EmitDefaultValue=false)]
		public string ClosingDocsStackingOrder { get; set; }

		[DataMember(Name="closingDocument", EmitDefaultValue=false)]
		public LoanContractClosingDocument ClosingDocument { get; set; }

		[DataMember(Name="collateralManagerScore", EmitDefaultValue=false)]
		public int? CollateralManagerScore { get; set; }

		[DataMember(Name="collateralTracking", EmitDefaultValue=false)]
		public LoanContractCollateralTracking CollateralTracking { get; set; }

		[DataMember(Name="combinedLtv", EmitDefaultValue=false)]
		public double? CombinedLtv { get; set; }

		[DataMember(Name = "consumerHomeInsuranceOrderEligible")]
		public bool? ConsumerHomeInsuranceOrderEligible { get; set; }

		[DataMember(Name="commitmentNumber", EmitDefaultValue=false)]
		public string CommitmentNumber { get; set; }

		[DataMember(Name="commitmentTerms", EmitDefaultValue=false)]
		public LoanContractCommitmentTerms CommitmentTerms { get; set; }

		[DataMember(Name="complianceTestLogs", EmitDefaultValue=false)]
		public List<LoanContractComplianceTestLogs> ComplianceTestLogs { get; set; }

		[DataMember(Name="conformingJumbo", EmitDefaultValue=false)]
		public string ConformingJumbo { get; set; }

		[DataMember(Name="constructionManagement", EmitDefaultValue=false)]
		public LoanContractConstructionManagement ConstructionManagement { get; set; }

		[DataMember(Name="consumerConnectSiteID", EmitDefaultValue=false)]
		public string ConsumerConnectSiteID { get; set; }

		[DataMember(Name="contacts", EmitDefaultValue=false)]
		public List<LoanContractContacts> Contacts { get; set; }

		[DataMember(Name="contactUpdatedIndicator", EmitDefaultValue=false)]
		public bool? ContactUpdatedIndicator { get; set; }

		[DataMember(Name="contractSellerCreditAmount", EmitDefaultValue=false)]
		public double? ContractSellerCreditAmount { get; set; }

		[DataMember(Name="conversationLogs", EmitDefaultValue=false)]
		public List<LoanContractConversationLogs> ConversationLogs { get; set; }

		[DataMember(Name="copyBrokerToLenderIndicator", EmitDefaultValue=false)]
		public bool? CopyBrokerToLenderIndicator { get; set; }

		[DataMember(Name="copyLoanNumLenderCaseNum", EmitDefaultValue=false)]
		public string CopyLoanNumLenderCaseNum { get; set; }

		[DataMember(Name="correspondent", EmitDefaultValue=false)]
		public LoanContractCorrespondent Correspondent { get; set; }

		[DataMember(Name="creditScoreToUse", EmitDefaultValue=false)]
		public string CreditScoreToUse { get; set; }

		[DataMember(Name="crmLogs", EmitDefaultValue=false)]
		public List<LoanContractCrmLogs> CrmLogs { get; set; }

		[DataMember(Name="currentApplicationIndex", EmitDefaultValue=false)]
		public int? CurrentApplicationIndex { get; set; }

		[DataMember(Name="currentApplicationIsPrimary", EmitDefaultValue=false)]
		public bool? CurrentApplicationIsPrimary { get; set; }

		[DataMember(Name="currentFirstMortgageHolderType", EmitDefaultValue=false)]
		public string CurrentFirstMortgageHolderType { get; set; }

		[DataMember(Name="customFields", EmitDefaultValue=false)]
		public List<LoanContractCustomFields> CustomFields { get; set; }

		[DataMember(Name="customModelFields", EmitDefaultValue=false)]
		public LoanContractCustomModelFields CustomModelFields { get; set; }

		[DataMember(Name="dataTracLogs", EmitDefaultValue=false)]
		public List<LoanContractDataTracLogs> DataTracLogs { get; set; }

		[DataMember(Name="dBIndicator", EmitDefaultValue=false)]
		public bool? DBIndicator { get; set; }

		[DataMember(Name="deductOverwireAmountIndicator", EmitDefaultValue=false)]
		public bool? DeductOverwireAmountIndicator { get; set; }

		[DataMember(Name="disableESignConsentAlert", EmitDefaultValue=false)]
		public bool? DisableESignConsentAlert { get; set; }

		[DataMember(Name="disableKeyPricingAlert", EmitDefaultValue=false)]
		public bool? DisableKeyPricingAlert { get; set; }

		[DataMember(Name="disclosureNotices", EmitDefaultValue=false)]
		public LoanContractDisclosureNotices DisclosureNotices { get; set; }

		[DataMember(Name="disclosureTracking2015Logs", EmitDefaultValue=false)]
		public List<LoanContractDisclosureTracking2015Logs> DisclosureTracking2015Logs { get; set; }

		[DataMember(Name="disclosureTrackingLogs", EmitDefaultValue=false)]
		public List<LoanContractDisclosureTrackingLogs> DisclosureTrackingLogs { get; set; }

		[DataMember(Name="discountPoint", EmitDefaultValue=false)]
		public double? DiscountPoint { get; set; }

		[DataMember(Name="docEngine", EmitDefaultValue=false)]
		public string DocEngine { get; set; }

		[DataMember(Name="documentLogs", EmitDefaultValue=false)]
		public List<LoanContractDocumentLogs> DocumentLogs { get; set; }

		[DataMember(Name="documentOrderLogs", EmitDefaultValue=false)]
		public List<LoanContractDocumentOrderLogs> DocumentOrderLogs { get; set; }

		[DataMember(Name="doNotCheckEmail", EmitDefaultValue=false)]
		public string DoNotCheckEmail { get; set; }

		[DataMember(Name="doNotPrintCompensationFees", EmitDefaultValue=false)]
		public bool? DoNotPrintCompensationFees { get; set; }

		[DataMember(Name="downloadLogs", EmitDefaultValue=false)]
		public List<LoanContractDownloadLogs> DownloadLogs { get; set; }

		[DataMember(Name="downPayment", EmitDefaultValue=false)]
		public LoanContractDownPayment DownPayment { get; set; }

		[DataMember(Name="downPaymentPercent", EmitDefaultValue=false)]
		public double? DownPaymentPercent { get; set; }

		[DataMember(Name="edmLogs", EmitDefaultValue=false)]
		public List<LoanContractEdmLogs> EdmLogs { get; set; }

		[DataMember(Name="elliUCDFields", EmitDefaultValue=false)]
		public LoanContractElliUCDFields ElliUCDFields { get; set; }

		[DataMember(Name="emailTriggerLogs", EmitDefaultValue=false)]
		public List<LoanContractEmailTriggerLogs> EmailTriggerLogs { get; set; }

		[DataMember(Name="emDocument", EmitDefaultValue=false)]
		public LoanContractEmDocument EmDocument { get; set; }

		[DataMember(Name="emDocumentInvestor", EmitDefaultValue=false)]
		public LoanContractEmDocumentInvestor EmDocumentInvestor { get; set; }

		[DataMember(Name="emDocumentLender", EmitDefaultValue=false)]
		public LoanContractEmDocumentLender EmDocumentLender { get; set; }

		[DataMember(Name="emXmlVersionId", EmitDefaultValue=false)]
		public string EmXmlVersionId { get; set; }

		[DataMember(Name="encompassId", EmitDefaultValue=false)]
		public string EncompassId { get; set; }

		[DataMember(Name="encompassVersion", EmitDefaultValue=false)]
		public string EncompassVersion { get; set; }

		[DataMember(Name="enforceCountyLoanLimit", EmitDefaultValue=false)]
		public bool? EnforceCountyLoanLimit { get; set; }

		[DataMember(Name="estimatedClosingCostsAmount", EmitDefaultValue=false)]
		public double? EstimatedClosingCostsAmount { get; set; }

		[DataMember(Name="estimatedConstructionInterest", EmitDefaultValue=false)]
		public double? EstimatedConstructionInterest { get; set; }

		[DataMember(Name="estimatedPrepaidItemsAmount", EmitDefaultValue=false)]
		public double? EstimatedPrepaidItemsAmount { get; set; }

		[DataMember(Name="exportLoanNumber", EmitDefaultValue=false)]
		public string ExportLoanNumber { get; set; }

		[DataMember(Name="exportLogs", EmitDefaultValue=false)]
		public List<LoanContractExportLogs> ExportLogs { get; set; }

		[DataMember(Name="fannieMae", EmitDefaultValue=false)]
		public LoanContractFannieMae FannieMae { get; set; }

		[DataMember(Name="fees", EmitDefaultValue=false)]
		public List<LoanContractFees> Fees { get; set; }

		[DataMember(Name="fhaMiPremiumRefundAmount", EmitDefaultValue=false)]
		public double? FhaMiPremiumRefundAmount { get; set; }

		[DataMember(Name="fhaVaLoan", EmitDefaultValue=false)]
		public LoanContractFhaVaLoan FhaVaLoan { get; set; }

		[DataMember(Name="fHAVALoanOriginatorIdentifier", EmitDefaultValue=false)]
		public string FHAVALoanOriginatorIdentifier { get; set; }

		[DataMember(Name="fieldLockData", EmitDefaultValue=false)]
		public List<LoanContractFieldLockData> FieldLockData { get; set; }

		[DataMember(Name="firstAdjustmentMinimum", EmitDefaultValue=false)]
		public double? FirstAdjustmentMinimum { get; set; }

		[DataMember(Name="firstSubordinateLienAmount", EmitDefaultValue=false)]
		public double? FirstSubordinateLienAmount { get; set; }

		[DataMember(Name="firstTimeHomebuyersIndicator", EmitDefaultValue=false)]
		public bool? FirstTimeHomebuyersIndicator { get; set; }

		[DataMember(Name="fnmCommunityLendingProductName", EmitDefaultValue=false)]
		public string FnmCommunityLendingProductName { get; set; }

		[DataMember(Name="fnmCommunitySecondsIndicator", EmitDefaultValue=false)]
		public bool? FnmCommunitySecondsIndicator { get; set; }

		[DataMember(Name="fnmNeighborsMortgageEligibilityIndicator", EmitDefaultValue=false)]
		public bool? FnmNeighborsMortgageEligibilityIndicator { get; set; }

		[DataMember(Name="forms", EmitDefaultValue=false)]
		public List<LoanContractForms1> Forms { get; set; }

		[DataMember(Name="fraudScore", EmitDefaultValue=false)]
		public int? FraudScore { get; set; }

		[DataMember(Name="freddieMac", EmitDefaultValue=false)]
		public LoanContractFreddieMac FreddieMac { get; set; }

		[DataMember(Name="funding", EmitDefaultValue=false)]
		public LoanContractFunding Funding { get; set; }

		[DataMember(Name="fundingDeductionList", EmitDefaultValue=false)]
		public string FundingDeductionList { get; set; }

		[DataMember(Name="fundingFeeList", EmitDefaultValue=false)]
		public string FundingFeeList { get; set; }

		[DataMember(Name="fundingFees", EmitDefaultValue=false)]
		public List<LoanContractFundingFees> FundingFees { get; set; }

		[DataMember(Name="gfe", EmitDefaultValue=false)]
		public LoanContractGfe Gfe { get; set; }

		[DataMember(Name="governmentLoanLenderIdentifier", EmitDefaultValue=false)]
		public string GovernmentLoanLenderIdentifier { get; set; }

		[DataMember(Name="governmentLoanSponsorIdentifier", EmitDefaultValue=false)]
		public string GovernmentLoanSponsorIdentifier { get; set; }

		[DataMember(Name="governmentMortgageCreditCertificateAmount", EmitDefaultValue=false)]
		public double? GovernmentMortgageCreditCertificateAmount { get; set; }

		[DataMember(Name="hasAbusinessRelationshipWith", EmitDefaultValue=false)]
		public string HasAbusinessRelationshipWith { get; set; }

		[DataMember(Name="hcltvHtltv", EmitDefaultValue=false)]
		public double? HcltvHtltv { get; set; }

		[DataMember(Name="helocTeaserRate", EmitDefaultValue=false)]
		public double? HelocTeaserRate { get; set; }

		[DataMember(Name="hmda", EmitDefaultValue=false)]
		public LoanContractHmda Hmda { get; set; }

		[DataMember(Name="homeCounselingProviders", EmitDefaultValue=false)]
		public List<LoanContractHomeCounselingProviders> HomeCounselingProviders { get; set; }

		[DataMember(Name="homeCounselingProvidersDistance", EmitDefaultValue=false)]
		public string HomeCounselingProvidersDistance { get; set; }

		[DataMember(Name="homeCounselingProvidersLanguageNames", EmitDefaultValue=false)]
		public string HomeCounselingProvidersLanguageNames { get; set; }

		[DataMember(Name="homeCounselingProvidersServiceNames", EmitDefaultValue=false)]
		public string HomeCounselingProvidersServiceNames { get; set; }

		[DataMember(Name="householdSizeCount", EmitDefaultValue=false)]
		public int? HouseholdSizeCount { get; set; }

		[DataMember(Name="htmlEmailLogs", EmitDefaultValue=false)]
		public List<LoanContractHtmlEmailLogs> HtmlEmailLogs { get; set; }

		[DataMember(Name="hud1Es", EmitDefaultValue=false)]
		public LoanContractHud1Es Hud1Es { get; set; }

		[DataMember(Name="hudIncomeLimitAdjustmentFactor", EmitDefaultValue=false)]
		public double? HudIncomeLimitAdjustmentFactor { get; set; }

		[DataMember(Name="hudLendingIncomeLimitAmount", EmitDefaultValue=false)]
		public double? HudLendingIncomeLimitAmount { get; set; }

		[DataMember(Name="hudLoanData", EmitDefaultValue=false)]
		public LoanContractHudLoanData HudLoanData { get; set; }

		[DataMember(Name="hudMedianIncomeAmount", EmitDefaultValue=false)]
		public double? HudMedianIncomeAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="includeUSDAFeeInClosing", EmitDefaultValue=false)]
		public bool? IncludeUSDAFeeInClosing { get; set; }

		[DataMember(Name="initialInterestRate", EmitDefaultValue=false)]
		public double? InitialInterestRate { get; set; }

		[DataMember(Name="initialInterestRateUI", EmitDefaultValue=false)]
		public string InitialInterestRateUI { get; set; }

		[DataMember(Name="insuranceAuthorizationIndicator", EmitDefaultValue=false)]
		public string InsuranceAuthorizationIndicator { get; set; }

		[DataMember(Name="interimServicing", EmitDefaultValue=false)]
		public LoanContractInterimServicing InterimServicing { get; set; }

		[DataMember(Name="interviewerApplicationSignedDate", EmitDefaultValue=false)]
		public DateTime? InterviewerApplicationSignedDate { get; set; }

		[DataMember(Name="interviewerEmail", EmitDefaultValue=false)]
		public string InterviewerEmail { get; set; }

		[DataMember(Name="interviewerLicenseIdentifier", EmitDefaultValue=false)]
		public string InterviewerLicenseIdentifier { get; set; }

		[DataMember(Name="interviewerPhoneNumber", EmitDefaultValue=false)]
		public string InterviewerPhoneNumber { get; set; }

		[DataMember(Name="interviewersCompanyStateLicense", EmitDefaultValue=false)]
		public string InterviewersCompanyStateLicense { get; set; }

		[DataMember(Name="interviewersId", EmitDefaultValue=false)]
		public string InterviewersId { get; set; }

		[DataMember(Name="inverviewerName", EmitDefaultValue=false)]
		public string InverviewerName { get; set; }

		[DataMember(Name="isCreditorProhibitsBorrower", EmitDefaultValue=false)]
		public bool? IsCreditorProhibitsBorrower { get; set; }

		[DataMember(Name="isEmployeeLoan", EmitDefaultValue=false)]
		public bool? IsEmployeeLoan { get; set; }

		[DataMember(Name="isLSSecondaryFile", EmitDefaultValue=false)]
		public bool? IsLSSecondaryFile { get; set; }

		[DataMember(Name="isRequiredInterestReserveCompoundInterest", EmitDefaultValue=false)]
		public bool? IsRequiredInterestReserveCompoundInterest { get; set; }

		[DataMember(Name="landIfAcquiredSeperatelyAmount", EmitDefaultValue=false)]
		public double? LandIfAcquiredSeperatelyAmount { get; set; }

		[DataMember(Name="leadSource", EmitDefaultValue=false)]
		public string LeadSource { get; set; }

		[DataMember(Name="leadSourceID", EmitDefaultValue=false)]
		public string LeadSourceID { get; set; }

		[DataMember(Name="lenderCaseIdentifier", EmitDefaultValue=false)]
		public string LenderCaseIdentifier { get; set; }

		[DataMember(Name="lenderChannel", EmitDefaultValue=false)]
		public string LenderChannel { get; set; }

		[DataMember(Name="lenderCreditsInFunding", EmitDefaultValue=false)]
		public double? LenderCreditsInFunding { get; set; }

		[DataMember(Name="lenderInvestorCode", EmitDefaultValue=false)]
		public string LenderInvestorCode { get; set; }

		[DataMember(Name="lenderPaidClosignCostsDotAmount", EmitDefaultValue=false)]
		public double? LenderPaidClosignCostsDotAmount { get; set; }

		[DataMember(Name="lenderPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? LenderPaidClosingCostsAmount { get; set; }

		[DataMember(Name="lesserAppraisedValueOrSalesPrice", EmitDefaultValue=false)]
		public double? LesserAppraisedValueOrSalesPrice { get; set; }

		[DataMember(Name="lifeInsuranceCoverageAmount", EmitDefaultValue=false)]
		public double? LifeInsuranceCoverageAmount { get; set; }

		[DataMember(Name="lifeInsuranceEstimatedMonthlyAmount", EmitDefaultValue=false)]
		public double? LifeInsuranceEstimatedMonthlyAmount { get; set; }

		[DataMember(Name="lifeInsuranceTotalProtectedMonthlyAmount", EmitDefaultValue=false)]
		public double? LifeInsuranceTotalProtectedMonthlyAmount { get; set; }

		[DataMember(Name="linkedBorrowerRequestedLoanAmount", EmitDefaultValue=false)]
		public double? LinkedBorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="linkId", EmitDefaultValue=false)]
		public string LinkId { get; set; }

		[DataMember(Name="loanActionLogs", EmitDefaultValue=false)]
		public List<LoanContractLoanActionLogs> LoanActionLogs { get; set; }

		[DataMember(Name="loanAmortizationTermMonths", EmitDefaultValue=false)]
		public int? LoanAmortizationTermMonths { get; set; }

		[DataMember(Name="loanAmortizationType", EmitDefaultValue=false)]
		public string LoanAmortizationType { get; set; }

		[DataMember(Name="loanCreatedDate", EmitDefaultValue=false)]
		public string LoanCreatedDate { get; set; }

		[DataMember(Name="loanCreatedDateUtc", EmitDefaultValue=false)]
		public DateTime? LoanCreatedDateUtc { get; set; }

		[DataMember(Name="loanIdNumber", EmitDefaultValue=false)]
		public string LoanIdNumber { get; set; }

		[DataMember(Name="loanImportStatusIndicator", EmitDefaultValue=false)]
		public bool? LoanImportStatusIndicator { get; set; }

		[DataMember(Name="loanLinkSyncType", EmitDefaultValue=false)]
		public string LoanLinkSyncType { get; set; }

		[DataMember(Name="loanNumber", EmitDefaultValue=false)]
		public string LoanNumber { get; set; }

		[DataMember(Name="loanProductData", EmitDefaultValue=false)]
		public LoanContractLoanProductData LoanProductData { get; set; }

		[DataMember(Name="loanProgramName", EmitDefaultValue=false)]
		public string LoanProgramName { get; set; }

		[DataMember(Name="loanPrograms", EmitDefaultValue=false)]
		public List<LoanContractLoanPrograms> LoanPrograms { get; set; }

		[DataMember(Name="loanPurposeOfRefinanceType", EmitDefaultValue=false)]
		public string LoanPurposeOfRefinanceType { get; set; }

		[DataMember(Name="loanSource", EmitDefaultValue=false)]
		public string LoanSource { get; set; }

		[DataMember(Name="loanSubmission", EmitDefaultValue=false)]
		public LoanContractLoanSubmission LoanSubmission { get; set; }

		[DataMember(Name="loanTotalProposedMonthlyMaintenanceAmount", EmitDefaultValue=false)]
		public double? LoanTotalProposedMonthlyMaintenanceAmount { get; set; }

		[DataMember(Name="loanTotalProposedMonthlyUtilitiesAmount", EmitDefaultValue=false)]
		public double? LoanTotalProposedMonthlyUtilitiesAmount { get; set; }

		[DataMember(Name="loanUnderwriterCHUMSIdentifier", EmitDefaultValue=false)]
		public string LoanUnderwriterCHUMSIdentifier { get; set; }

		[DataMember(Name="loanVALoanProcedureType", EmitDefaultValue=false)]
		public string LoanVALoanProcedureType { get; set; }

		[DataMember(Name="loanVARateReductionInitialComputationTotalAmount", EmitDefaultValue=false)]
		public double? LoanVARateReductionInitialComputationTotalAmount { get; set; }

		[DataMember(Name="loanVAResidualIncomeAmount", EmitDefaultValue=false)]
		public double? LoanVAResidualIncomeAmount { get; set; }

		[DataMember(Name="loanVersionId", EmitDefaultValue=false)]
		public int? LoanVersionId { get; set; }

		[DataMember(Name="lockConfirmLogs", EmitDefaultValue=false)]
		public List<LoanContractLockConfirmLogs> LockConfirmLogs { get; set; }

		[DataMember(Name="lockDenialLogs", EmitDefaultValue=false)]
		public List<LoanContractLockDenialLogs> LockDenialLogs { get; set; }

		[DataMember(Name="lockRequestLogs", EmitDefaultValue=false)]
		public List<LoanContractLockRequestLogs> LockRequestLogs { get; set; }

		[DataMember(Name="lOCompensation", EmitDefaultValue=false)]
		public LoanContractLOCompensation LOCompensation { get; set; }

		[DataMember(Name="logEntryLogs", EmitDefaultValue=false)]
		public List<LoanContractLogEntryLogs> LogEntryLogs { get; set; }

		[DataMember(Name="ltv", EmitDefaultValue=false)]
		public double? Ltv { get; set; }

		[DataMember(Name="ltvPropertyValue", EmitDefaultValue=false)]
		public double? LtvPropertyValue { get; set; }

		[DataMember(Name="masterCommitmentNumber", EmitDefaultValue=false)]
		public string MasterCommitmentNumber { get; set; }

		[DataMember(Name="maturityDate", EmitDefaultValue=false)]
		public DateTime? MaturityDate { get; set; }

		[DataMember(Name="maxBackRatio", EmitDefaultValue=false)]
		public double? MaxBackRatio { get; set; }

		[DataMember(Name="maxFrontRatio", EmitDefaultValue=false)]
		public double? MaxFrontRatio { get; set; }

		[DataMember(Name="mcaw", EmitDefaultValue=false)]
		public LoanContractMcaw Mcaw { get; set; }

		[DataMember(Name="mersNumber", EmitDefaultValue=false)]
		public string MersNumber { get; set; }

		[DataMember(Name="mersNumberRegistrationDate", EmitDefaultValue=false)]
		public DateTime? MersNumberRegistrationDate { get; set; }

		[DataMember(Name="miAndFundingFeeFinancedAmount", EmitDefaultValue=false)]
		public double? MiAndFundingFeeFinancedAmount { get; set; }

		[DataMember(Name="miAndFundingFeeTotalAmount", EmitDefaultValue=false)]
		public double? MiAndFundingFeeTotalAmount { get; set; }

		[DataMember(Name="milestoneApprovedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneApprovedDate { get; set; }

		[DataMember(Name="milestoneApprovedDueDate", EmitDefaultValue=false)]
		public DateTime? MilestoneApprovedDueDate { get; set; }

		[DataMember(Name="milestoneCompletedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneCompletedDate { get; set; }

		[DataMember(Name="milestoneCompletedDueDate", EmitDefaultValue=false)]
		public DateTime? MilestoneCompletedDueDate { get; set; }

		[DataMember(Name="milestoneCurrentDateUtc", EmitDefaultValue=false)]
		public DateTime? MilestoneCurrentDateUtc { get; set; }

		[DataMember(Name="milestoneCurrentName", EmitDefaultValue=false)]
		public string MilestoneCurrentName { get; set; }

		[DataMember(Name="milestoneDocSignedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneDocSignedDate { get; set; }

		[DataMember(Name="milestoneDocSignedDueDate", EmitDefaultValue=false)]
		public DateTime? MilestoneDocSignedDueDate { get; set; }

		[DataMember(Name="milestoneDuration", EmitDefaultValue=false)]
		public int? MilestoneDuration { get; set; }

		[DataMember(Name="milestoneFileStartedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneFileStartedDate { get; set; }

		[DataMember(Name="milestoneFreeRoleLogs", EmitDefaultValue=false)]
		public List<LoanContractMilestoneFreeRoleLogs> MilestoneFreeRoleLogs { get; set; }

		[DataMember(Name="milestoneFundedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneFundedDate { get; set; }

		[DataMember(Name="milestoneFundedDueDate", EmitDefaultValue=false)]
		public DateTime? MilestoneFundedDueDate { get; set; }

		[DataMember(Name="milestoneHistoryLogs", EmitDefaultValue=false)]
		public List<object> MilestoneHistoryLogs { get; set; }

		[DataMember(Name="milestoneLogs", EmitDefaultValue=false)]
		public List<LoanContractMilestoneLogs> MilestoneLogs { get; set; }

		[DataMember(Name="milestoneProcessedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneProcessedDate { get; set; }

		[DataMember(Name="milestoneStage", EmitDefaultValue=false)]
		public string MilestoneStage { get; set; }

		[DataMember(Name="milestoneSubmittedDate", EmitDefaultValue=false)]
		public DateTime? MilestoneSubmittedDate { get; set; }

		[DataMember(Name="milestoneSubmittedDueDate", EmitDefaultValue=false)]
		public DateTime? MilestoneSubmittedDueDate { get; set; }

		[DataMember(Name="milestoneTaskLogs", EmitDefaultValue=false)]
		public List<LoanContractMilestoneTaskLogs> MilestoneTaskLogs { get; set; }

		[DataMember(Name="milestoneTemplateLogs", EmitDefaultValue=false)]
		public List<LoanContractMilestoneTemplateLogs> MilestoneTemplateLogs { get; set; }

		[DataMember(Name="mipBorrowerPaidInCashAmount", EmitDefaultValue=false)]
		public double? MipBorrowerPaidInCashAmount { get; set; }

		[DataMember(Name="mipPaidInCashAmount", EmitDefaultValue=false)]
		public double? MipPaidInCashAmount { get; set; }

		[DataMember(Name="miscellaneous", EmitDefaultValue=false)]
		public LoanContractMiscellaneous Miscellaneous { get; set; }

		[DataMember(Name="monthlyPIPaymentAmountForLE1andCD1", EmitDefaultValue=false)]
		public double? MonthlyPIPaymentAmountForLE1andCD1 { get; set; }

		[DataMember(Name="mortgageInsurancePremiumFHARefundAmount", EmitDefaultValue=false)]
		public double? MortgageInsurancePremiumFHARefundAmount { get; set; }

		[DataMember(Name="mortgageInsurancePremiumUpfrontFactorPercent", EmitDefaultValue=false)]
		public double? MortgageInsurancePremiumUpfrontFactorPercent { get; set; }

		[DataMember(Name="mortgageType", EmitDefaultValue=false)]
		public string MortgageType { get; set; }

		[DataMember(Name="msaIdentifier", EmitDefaultValue=false)]
		public string MsaIdentifier { get; set; }

		[DataMember(Name="netTangibleBenefit", EmitDefaultValue=false)]
		public LoanContractNetTangibleBenefit NetTangibleBenefit { get; set; }

		[DataMember(Name="newFirstMortgageAmount", EmitDefaultValue=false)]
		public double? NewFirstMortgageAmount { get; set; }

		[DataMember(Name="nmlsLoanOriginatorId", EmitDefaultValue=false)]
		public string NmlsLoanOriginatorId { get; set; }

		[DataMember(Name="noClosingCostOption", EmitDefaultValue=false)]
		public bool? NoClosingCostOption { get; set; }

		[DataMember(Name="nonBorrowingOwners", EmitDefaultValue=false)]
		public List<LoanContractNonBorrowingOwners> NonBorrowingOwners { get; set; }

		[DataMember(Name="nonVols", EmitDefaultValue=false)]
		public List<LoanContractNonVols> NonVols { get; set; }

		[DataMember(Name="notRequiredForPurchaseSaleOrRefinance", EmitDefaultValue=false)]
		public bool? NotRequiredForPurchaseSaleOrRefinance { get; set; }

		[DataMember(Name="notRequiredForSettlementOfYourLoan", EmitDefaultValue=false)]
		public bool? NotRequiredForSettlementOfYourLoan { get; set; }

		[DataMember(Name = "newVestingNboAlert", EmitDefaultValue = false)]
		public bool? NewVestingNboAlert { get; set; }

		[DataMember(Name="occupancyType", EmitDefaultValue=false)]
		public string OccupancyType { get; set; }

		[DataMember(Name="openingDocsInvestorCode", EmitDefaultValue=false)]
		public string OpeningDocsInvestorCode { get; set; }

		[DataMember(Name="openingDocsLoanProgramType", EmitDefaultValue=false)]
		public string OpeningDocsLoanProgramType { get; set; }

		[DataMember(Name="openingDocsPlanDescription", EmitDefaultValue=false)]
		public string OpeningDocsPlanDescription { get; set; }

		[DataMember(Name="openingDocsPlanId", EmitDefaultValue=false)]
		public string OpeningDocsPlanId { get; set; }

		[DataMember(Name="openingDocsProgramCode", EmitDefaultValue=false)]
		public string OpeningDocsProgramCode { get; set; }

		[DataMember(Name="openingDocsStackingOrder", EmitDefaultValue=false)]
		public string OpeningDocsStackingOrder { get; set; }

		[DataMember(Name="organizationCode", EmitDefaultValue=false)]
		public string OrganizationCode { get; set; }

		[DataMember(Name="originationDate", EmitDefaultValue=false)]
		public DateTime? OriginationDate { get; set; }

		[DataMember(Name="otherAmortizationTypeDescription", EmitDefaultValue=false)]
		public string OtherAmortizationTypeDescription { get; set; }

		[DataMember(Name="otherMortgageTypeDescription", EmitDefaultValue=false)]
		public string OtherMortgageTypeDescription { get; set; }

		[DataMember(Name="otherPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? OtherPaidClosingCostsAmount { get; set; }

		[DataMember(Name="overwireAmount", EmitDefaultValue=false)]
		public double? OverwireAmount { get; set; }

		[DataMember(Name = "paceLoanPayoffAmount", EmitDefaultValue = false)]
		public double? PaceLoanPayoffAmount { get; set; }

		[DataMember(Name="paymentScheduleCalcRequiredIndicator", EmitDefaultValue=false)]
		public bool? PaymentScheduleCalcRequiredIndicator { get; set; }

		[DataMember(Name="percentageOfOwnership", EmitDefaultValue=false)]
		public string PercentageOfOwnership { get; set; }

		[DataMember(Name="percentageOwnershipInterest", EmitDefaultValue=false)]
		public double? PercentageOwnershipInterest { get; set; }

		[DataMember(Name="pmiIndicator", EmitDefaultValue=false)]
		public bool? PmiIndicator { get; set; }

		[DataMember(Name="postClosingConditionLogs", EmitDefaultValue=false)]
		public List<LoanContractPostClosingConditionLogs> PostClosingConditionLogs { get; set; }

		[DataMember(Name="preliminaryConditionLogs", EmitDefaultValue=false)]
		public List<LoanContractPreliminaryConditionLogs> PreliminaryConditionLogs { get; set; }

		[DataMember(Name="prequalification", EmitDefaultValue=false)]
		public LoanContractPrequalification Prequalification { get; set; }

		[DataMember(Name="principalAndInterestMonthlyPaymentAmount", EmitDefaultValue=false)]
		public double? PrincipalAndInterestMonthlyPaymentAmount { get; set; }

		[DataMember(Name="print2003Application", EmitDefaultValue=false)]
		public string Print2003Application { get; set; }

		[DataMember(Name="printLogs", EmitDefaultValue=false)]
		public List<LoanContractPrintLogs> PrintLogs { get; set; }

		[DataMember(Name="privacyPolicy", EmitDefaultValue=false)]
		public LoanContractPrivacyPolicy PrivacyPolicy { get; set; }

		[DataMember(Name="profitManagement", EmitDefaultValue=false)]
		public LoanContractProfitManagement ProfitManagement { get; set; }

		[DataMember(Name="property", EmitDefaultValue=false)]
		public LoanContractProperty Property { get; set; }

		[DataMember(Name="propertyAppraisedValueAmount", EmitDefaultValue=false)]
		public int? PropertyAppraisedValueAmount { get; set; }

		[DataMember(Name="propertyEnergyEfficientHomeIndicator", EmitDefaultValue=false)]
		public bool? PropertyEnergyEfficientHomeIndicator { get; set; }

		[DataMember(Name="propertyEstimatedValueAmount", EmitDefaultValue=false)]
		public int? PropertyEstimatedValueAmount { get; set; }

		[DataMember(Name="proposedDuesAmount", EmitDefaultValue=false)]
		public string ProposedDuesAmount { get; set; }

		[DataMember(Name="proposedFirstMortgageAmount", EmitDefaultValue=false)]
		public double? ProposedFirstMortgageAmount { get; set; }

		[DataMember(Name="proposedGroundRentAmount", EmitDefaultValue=false)]
		public double? ProposedGroundRentAmount { get; set; }

		[DataMember(Name="proposedHazardInsuranceAmount", EmitDefaultValue=false)]
		public string ProposedHazardInsuranceAmount { get; set; }

		[DataMember(Name="proposedHousingExpenseTotal", EmitDefaultValue=false)]
		public double? ProposedHousingExpenseTotal { get; set; }

		[DataMember(Name="proposedMortgageInsuranceAmount", EmitDefaultValue=false)]
		public string ProposedMortgageInsuranceAmount { get; set; }

		[DataMember(Name="proposedOtherAmount", EmitDefaultValue=false)]
		public double? ProposedOtherAmount { get; set; }

		[DataMember(Name="proposedOtherMortgagesAmount", EmitDefaultValue=false)]
		public double? ProposedOtherMortgagesAmount { get; set; }

		[DataMember(Name="proposedRealEstateTaxesAmount", EmitDefaultValue=false)]
		public string ProposedRealEstateTaxesAmount { get; set; }

		[DataMember(Name="purchaseCredits", EmitDefaultValue=false)]
		public List<LoanContractPurchaseCredits> PurchaseCredits { get; set; }

		[DataMember(Name="purchasePriceAmount", EmitDefaultValue=false)]
		public double? PurchasePriceAmount { get; set; }

		[DataMember(Name="rateLock", EmitDefaultValue=false)]
		public LoanContractRateLock RateLock { get; set; }

		[DataMember(Name="referralAddress", EmitDefaultValue=false)]
		public string ReferralAddress { get; set; }

		[DataMember(Name="referralCity", EmitDefaultValue=false)]
		public string ReferralCity { get; set; }

		[DataMember(Name="referralFeeAmount", EmitDefaultValue=false)]
		public double? ReferralFeeAmount { get; set; }

		[DataMember(Name="referralPostalCode", EmitDefaultValue=false)]
		public string ReferralPostalCode { get; set; }

		[DataMember(Name="referralSource", EmitDefaultValue=false)]
		public string ReferralSource { get; set; }

		[DataMember(Name="referralSourceContact", EmitDefaultValue=false)]
		public EntityRefContract ReferralSourceContact { get; set; }

		[DataMember(Name="referralState", EmitDefaultValue=false)]
		public string ReferralState { get; set; }

		[DataMember(Name="refinanceIncludingDebtsToBePaidOffAmount", EmitDefaultValue=false)]
		public double? RefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="registrationLogs", EmitDefaultValue=false)]
		public List<LoanContractRegistrationLogs> RegistrationLogs { get; set; }

		[DataMember(Name="regulationZ", EmitDefaultValue=false)]
		public LoanContractRegulationZ RegulationZ { get; set; }

		[DataMember(Name="removedLogRecords", EmitDefaultValue=false)]
		public List<LoanContractLogRecord> RemovedLogRecords { get; set; }

		[DataMember(Name="repurchaseCostAmount", EmitDefaultValue=false)]
		public double? RepurchaseCostAmount { get; set; }

		[DataMember(Name="repurchaseDate", EmitDefaultValue=false)]
		public DateTime? RepurchaseDate { get; set; }

		[DataMember(Name="requestedInterestRatePercent", EmitDefaultValue=false)]
		public double? RequestedInterestRatePercent { get; set; }

		[DataMember(Name="requestedInterestRatePercentUI", EmitDefaultValue=false)]
		public string RequestedInterestRatePercentUI { get; set; }

		[DataMember(Name="salesConcessionAmount", EmitDefaultValue=false)]
		public double? SalesConcessionAmount { get; set; }

		[DataMember(Name="secondSubordinateAmount", EmitDefaultValue=false)]
		public double? SecondSubordinateAmount { get; set; }

		[DataMember(Name="section32", EmitDefaultValue=false)]
		public LoanContractSection32 Section32 { get; set; }

		[DataMember(Name="sectionOfActType", EmitDefaultValue=false)]
		public string SectionOfActType { get; set; }

		[DataMember(Name="selectedHomeCounselingProvider", EmitDefaultValue=false)]
		public LoanContractSelectedHomeCounselingProvider SelectedHomeCounselingProvider { get; set; }

		[DataMember(Name="sellerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="serviceProviderAdditionalInfo", EmitDefaultValue=false)]
		public string ServiceProviderAdditionalInfo { get; set; }

		[DataMember(Name="serviceProviderContacts", EmitDefaultValue=false)]
		public List<LoanContractServiceProviderContacts> ServiceProviderContacts { get; set; }

		[DataMember(Name="serviceProviderDateIssued", EmitDefaultValue=false)]
		public DateTime? ServiceProviderDateIssued { get; set; }

		[DataMember(Name="servicingDisclosure", EmitDefaultValue=false)]
		public LoanContractServicingDisclosure ServicingDisclosure { get; set; }

		[DataMember(Name="setForSettlementServicesOfAnAttorney", EmitDefaultValue=false)]
		public bool? SetForSettlementServicesOfAnAttorney { get; set; }

		[DataMember(Name="setForTheSettlementServicesListed", EmitDefaultValue=false)]
		public bool? SetForTheSettlementServicesListed { get; set; }

		[DataMember(Name="settlementServiceCharges", EmitDefaultValue=false)]
		public List<LoanContractSettlementServiceCharges> SettlementServiceCharges { get; set; }

		[DataMember(Name="shipping", EmitDefaultValue=false)]
		public LoanContractShipping Shipping { get; set; }

		[DataMember(Name="simpleRefinanceType", EmitDefaultValue=false)]
		public bool? SimpleRefinanceType { get; set; }

		[DataMember(Name="startingAdjPrice", EmitDefaultValue=false)]
		public double? StartingAdjPrice { get; set; }

		[DataMember(Name="startingAdjRate", EmitDefaultValue=false)]
		public double? StartingAdjRate { get; set; }

		[DataMember(Name="stateDisclosure", EmitDefaultValue=false)]
		public LoanContractStateDisclosure StateDisclosure { get; set; }

		[DataMember(Name="statementCreditDenial", EmitDefaultValue=false)]
		public LoanContractStatementCreditDenial StatementCreditDenial { get; set; }

		[DataMember(Name="statusOnlineLogs", EmitDefaultValue=false)]
		public List<LoanContractStatusOnlineLogs> StatusOnlineLogs { get; set; }

		[DataMember(Name="subjectPropertyGrossRentalIncomeAmount", EmitDefaultValue=false)]
		public double? SubjectPropertyGrossRentalIncomeAmount { get; set; }

		[DataMember(Name="subjectPropertyOccupancyPercent", EmitDefaultValue=false)]
		public double? SubjectPropertyOccupancyPercent { get; set; }

		[DataMember(Name="subordinateLienAmount", EmitDefaultValue=false)]
		public double? SubordinateLienAmount { get; set; }

		[DataMember(Name="systemIdGuid", EmitDefaultValue=false)]
		public string SystemIdGuid { get; set; }

		[DataMember(Name="tilApplicationDate", EmitDefaultValue=false)]
		public DateTime? TilApplicationDate { get; set; }

		[DataMember(Name="titleHolderName1", EmitDefaultValue=false)]
		public string TitleHolderName1 { get; set; }

		[DataMember(Name="titleHolderName2", EmitDefaultValue=false)]
		public string TitleHolderName2 { get; set; }

		[DataMember(Name="tltv", EmitDefaultValue=false)]
		public double? Tltv { get; set; }

		[DataMember(Name="totalClosingCostsAmount", EmitDefaultValue=false)]
		public double? TotalClosingCostsAmount { get; set; }

		[DataMember(Name="totalDeductionsAmount", EmitDefaultValue=false)]
		public double? TotalDeductionsAmount { get; set; }

		[DataMember(Name="totalFeesCostAmount", EmitDefaultValue=false)]
		public double? TotalFeesCostAmount { get; set; }

		[DataMember(Name="totalFeesCreditAmount", EmitDefaultValue=false)]
		public double? TotalFeesCreditAmount { get; set; }

		[DataMember(Name="totalNonborrowerPaidClosingCostsAmount", EmitDefaultValue=false)]
		public double? TotalNonborrowerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="totalPaidOutsideClosingAmount", EmitDefaultValue=false)]
		public double? TotalPaidOutsideClosingAmount { get; set; }

		[DataMember(Name="totalPaidToBrokerAmount", EmitDefaultValue=false)]
		public double? TotalPaidToBrokerAmount { get; set; }

		[DataMember(Name="totalWireTransferAmount", EmitDefaultValue=false)]
		public double? TotalWireTransferAmount { get; set; }

		[DataMember(Name="tPO", EmitDefaultValue=false)]
		public LoanContractTPO TPO { get; set; }

		[DataMember(Name="tQL", EmitDefaultValue=false)]
		public LoanContractTQL TQL { get; set; }

		[DataMember(Name="trustAccount", EmitDefaultValue=false)]
		public LoanContractTrustAccount TrustAccount { get; set; }

		[DataMember(Name="tsum", EmitDefaultValue=false)]
		public LoanContractTsum Tsum { get; set; }

		[DataMember(Name="twelveMonthMortgageRentalHistoryIndicator", EmitDefaultValue=false)]
		public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }

		[DataMember(Name="uCDCaseFileID", EmitDefaultValue=false)]
		public string UCDCaseFileID { get; set; }

		[DataMember(Name="uldd", EmitDefaultValue=false)]
		public LoanContractUldd Uldd { get; set; }

		[DataMember(Name="underwriterSummary", EmitDefaultValue=false)]
		public LoanContractUnderwriterSummary UnderwriterSummary { get; set; }

		[DataMember(Name="underwritingConditionLogs", EmitDefaultValue=false)]
		public List<LoanContractUnderwritingConditionLogs> UnderwritingConditionLogs { get; set; }

		[DataMember(Name="underwritingEscrowIndicator", EmitDefaultValue=false)]
		public bool? UnderwritingEscrowIndicator { get; set; }

		[DataMember(Name="undiscountedRate", EmitDefaultValue=false)]
		public double? UndiscountedRate { get; set; }

		[DataMember(Name="urlPage4Comments", EmitDefaultValue=false)]
		public string UrlPage4Comments { get; set; }

		[DataMember(Name="usda", EmitDefaultValue=false)]
		public LoanContractUsda Usda { get; set; }

		[DataMember(Name="usdaGovernmentLoanType", EmitDefaultValue=false)]
		public string UsdaGovernmentLoanType { get; set; }

		[DataMember(Name="use2018DiIndicator", EmitDefaultValue=false)]
		public bool? Use2018DiIndicator { get; set; }

		[DataMember(Name="useNew2015FormsIndicator", EmitDefaultValue=false)]
		public string UseNew2015FormsIndicator { get; set; }

		[DataMember(Name="useNewHudIndicator", EmitDefaultValue=false)]
		public bool? UseNewHudIndicator { get; set; }

		[DataMember(Name="vAEntitlementAmount", EmitDefaultValue=false)]
		public double? VAEntitlementAmount { get; set; }

		[DataMember(Name="vaLoanData", EmitDefaultValue=false)]
		public LoanContractVaLoanData VaLoanData { get; set; }

		[DataMember(Name="verificationLogs", EmitDefaultValue=false)]
		public List<LoanContractVerificationLogs> VerificationLogs { get; set; }

		[DataMember(Name="virtualFields", EmitDefaultValue=false)]
		public object VirtualFields { get; set; }

		[DataMember(Name="websiteId", EmitDefaultValue=false)]
		public string WebsiteId { get; set; }

	}
}