using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContract
	{
		[DataMember(Name="additionalRequests")]
		public LoanContractAdditionalRequests AdditionalRequests { get; set; }

		[DataMember(Name="adverseActionDate")]
		public DateTime? AdverseActionDate { get; set; }

		[DataMember(Name="affiliatedBusinessArrangements")]
		public List<LoanContractAffiliatedBusinessArrangements> AffiliatedBusinessArrangements { get; set; }

		[DataMember(Name="agencyCaseIdentifier")]
		public string AgencyCaseIdentifier { get; set; }

		[DataMember(Name="alertChangeCircumstanceApplyLECD")]
		public string AlertChangeCircumstanceApplyLECD { get; set; }

		[DataMember(Name="alertChangeCircumstances")]
		public List<LoanContractAlertChangeCircumstances> AlertChangeCircumstances { get; set; }

		[DataMember(Name="alterationsImprovementsOrRepairsAmount")]
		public decimal? AlterationsImprovementsOrRepairsAmount { get; set; }

		[DataMember(Name="applications")]
		public List<LoanContractApplications> Applications { get; set; }

		[DataMember(Name="applicationTakenMethodType")]
		public string ApplicationTakenMethodType { get; set; }

		[DataMember(Name="aprDisclosureDate")]
		public DateTime? AprDisclosureDate { get; set; }

		[DataMember(Name="armTypeDescription")]
		public string ArmTypeDescription { get; set; }

		[DataMember(Name= "aTRQMCommon")]
		public LoanContractATRQMCommon ATRQMCommon { get; set; }

		[DataMember(Name = "averageRepresentativeCreditScore")]
		public int? AverageRepresentativeCreditScore { get; set; }

		[DataMember(Name="baseLoanAmount")]
		public decimal? BaseLoanAmount { get; set; }

		[DataMember(Name="belowMarketSubordinateFinancingIndicator")]
		public bool? BelowMarketSubordinateFinancingIndicator { get; set; }

		[DataMember(Name="billingCategory")]
		public string BillingCategory { get; set; }

		[DataMember(Name="biweeklyPaymentAmount")]
		public decimal? BiweeklyPaymentAmount { get; set; }

		[DataMember(Name="bLTV")]
		public int? BLTV { get; set; }

		[DataMember(Name="borrowerCoBorrowerMarriedIndicator")]
		public bool? BorrowerCoBorrowerMarriedIndicator { get; set; }

		[DataMember(Name="borrowerPaidClosingCostsAmount")]
		public decimal? BorrowerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="borrowerPaidDiscountPointsAmount")]
		public decimal? BorrowerPaidDiscountPointsAmount { get; set; }

		[DataMember(Name="borrowerPaidFHAVAClosingCostsAmount")]
		public decimal? BorrowerPaidFHAVAClosingCostsAmount { get; set; }

		[DataMember(Name="borrowerPairCount")]
		public int? BorrowerPairCount { get; set; }

		[DataMember(Name="borrowerRequestedLoanAmount")]
		public decimal? BorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="brokerPaidClosingCostsAmount")]
		public decimal? BrokerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="buydownIndicator")]
		public bool? BuydownIndicator { get; set; }

		[DataMember(Name="buydownMonthlyPaymentAmount")]
		public decimal? BuydownMonthlyPaymentAmount { get; set; }

		[DataMember(Name="buydownRatePercent")]
		public decimal? BuydownRatePercent { get; set; }

		[DataMember(Name="cashFromToBorrowerAmount")]
		public decimal? CashFromToBorrowerAmount { get; set; }

		[DataMember(Name="channel")]
		public string Channel { get; set; }

		[DataMember(Name="closedEndPrimaryMortgageLoanAmount")]
		public decimal? ClosedEndPrimaryMortgageLoanAmount { get; set; }

		[DataMember(Name="closedEndSubordinateMortgageLoanAmount")]
		public decimal? ClosedEndSubordinateMortgageLoanAmount { get; set; }

		[DataMember(Name="closingBillingDate")]
		public DateTime? ClosingBillingDate { get; set; }

		[DataMember(Name="closingCost")]
		public LoanContractClosingCost ClosingCost { get; set; }

		[DataMember(Name="closingCostProgram")]
		public string ClosingCostProgram { get; set; }

		[DataMember(Name="closingCostsAndPrepaidsFromOtherLienAmount")]
		public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount { get; set; }

		[DataMember(Name="closingCostsPaidByOthersAmount")]
		public decimal? ClosingCostsPaidByOthersAmount { get; set; }

		[DataMember(Name="closingDocsStackingOrder")]
		public string ClosingDocsStackingOrder { get; set; }

		[DataMember(Name="closingDocument")]
		public LoanContractClosingDocument ClosingDocument { get; set; }

		[DataMember(Name="collateralManagerScore")]
		public int? CollateralManagerScore { get; set; }

		[DataMember(Name="collateralTracking")]
		public LoanContractCollateralTracking CollateralTracking { get; set; }

		[DataMember(Name="combinedLtv")]
		public decimal? CombinedLtv { get; set; }

		[DataMember(Name = "consumerHomeInsuranceOrderEligible")]
		public bool? ConsumerHomeInsuranceOrderEligible { get; set; }

		[DataMember(Name="commitmentNumber")]
		public string CommitmentNumber { get; set; }

		[DataMember(Name="commitmentTerms")]
		public LoanContractCommitmentTerms CommitmentTerms { get; set; }

		[DataMember(Name="complianceTestLogs")]
		public List<LoanContractComplianceTestLogs> ComplianceTestLogs { get; set; }

		[DataMember(Name="conformingJumbo")]
		public string ConformingJumbo { get; set; }

		[DataMember(Name="constructionManagement")]
		public LoanContractConstructionManagement ConstructionManagement { get; set; }

		[DataMember(Name="consumerConnectSiteID")]
		public string ConsumerConnectSiteID { get; set; }

		[DataMember(Name="contacts")]
		public List<LoanContractContacts> Contacts { get; set; }

		[DataMember(Name="contactUpdatedIndicator")]
		public bool? ContactUpdatedIndicator { get; set; }

		[DataMember(Name="contractSellerCreditAmount")]
		public decimal? ContractSellerCreditAmount { get; set; }

		[DataMember(Name="conversationLogs")]
		public List<LoanContractConversationLogs> ConversationLogs { get; set; }

		[DataMember(Name="copyBrokerToLenderIndicator")]
		public bool? CopyBrokerToLenderIndicator { get; set; }

		[DataMember(Name="copyLoanNumLenderCaseNum")]
		public string CopyLoanNumLenderCaseNum { get; set; }

		[DataMember(Name="correspondent")]
		public LoanContractCorrespondent Correspondent { get; set; }

		[DataMember(Name="creditScoreToUse")]
		public string CreditScoreToUse { get; set; }

		[DataMember(Name="crmLogs")]
		public List<LoanContractCrmLogs> CrmLogs { get; set; }

		[DataMember(Name="currentApplicationIndex")]
		public int? CurrentApplicationIndex { get; set; }

		[DataMember(Name="currentApplicationIsPrimary")]
		public bool? CurrentApplicationIsPrimary { get; set; }

		[DataMember(Name="currentFirstMortgageHolderType")]
		public string CurrentFirstMortgageHolderType { get; set; }

		[DataMember(Name="customFields")]
		public List<LoanContractCustomFields> CustomFields { get; set; }

		[DataMember(Name="customModelFields")]
		public LoanContractCustomModelFields CustomModelFields { get; set; }

		[DataMember(Name="dataTracLogs")]
		public List<LoanContractDataTracLogs> DataTracLogs { get; set; }

		[DataMember(Name="dBIndicator")]
		public bool? DBIndicator { get; set; }

		[DataMember(Name="deductOverwireAmountIndicator")]
		public bool? DeductOverwireAmountIndicator { get; set; }

		[DataMember(Name="disableESignConsentAlert")]
		public bool? DisableESignConsentAlert { get; set; }

		[DataMember(Name="disableKeyPricingAlert")]
		public bool? DisableKeyPricingAlert { get; set; }

		[DataMember(Name="disclosureNotices")]
		public LoanContractDisclosureNotices DisclosureNotices { get; set; }

		[DataMember(Name="disclosureTracking2015Logs")]
		public List<LoanContractDisclosureTracking2015Logs> DisclosureTracking2015Logs { get; set; }

		[DataMember(Name="disclosureTrackingLogs")]
		public List<LoanContractDisclosureTrackingLogs> DisclosureTrackingLogs { get; set; }

		[DataMember(Name="discountPoint")]
		public decimal? DiscountPoint { get; set; }

		[DataMember(Name="docEngine")]
		public string DocEngine { get; set; }

		[DataMember(Name="documentLogs")]
		public List<LoanContractDocumentLogs> DocumentLogs { get; set; }

		[DataMember(Name="documentOrderLogs")]
		public List<LoanContractDocumentOrderLogs> DocumentOrderLogs { get; set; }

		[DataMember(Name="doNotCheckEmail")]
		public string DoNotCheckEmail { get; set; }

		[DataMember(Name="doNotPrintCompensationFees")]
		public bool? DoNotPrintCompensationFees { get; set; }

		[DataMember(Name="downloadLogs")]
		public List<LoanContractDownloadLogs> DownloadLogs { get; set; }

		[DataMember(Name="downPayment")]
		public LoanContractDownPayment DownPayment { get; set; }

		[DataMember(Name="downPaymentPercent")]
		public decimal? DownPaymentPercent { get; set; }

		[DataMember(Name="edmLogs")]
		public List<LoanContractEdmLogs> EdmLogs { get; set; }

		[DataMember(Name="elliUCDFields")]
		public LoanContractElliUCDFields ElliUCDFields { get; set; }

		[DataMember(Name="emailTriggerLogs")]
		public List<LoanContractEmailTriggerLogs> EmailTriggerLogs { get; set; }

		[DataMember(Name="emDocument")]
		public LoanContractEmDocument EmDocument { get; set; }

		[DataMember(Name="emDocumentInvestor")]
		public LoanContractEmDocumentInvestor EmDocumentInvestor { get; set; }

		[DataMember(Name="emDocumentLender")]
		public LoanContractEmDocumentLender EmDocumentLender { get; set; }

		[DataMember(Name="emXmlVersionId")]
		public string EmXmlVersionId { get; set; }

		[DataMember(Name="encompassId")]
		public string EncompassId { get; set; }

		[DataMember(Name="encompassVersion")]
		public string EncompassVersion { get; set; }

		[DataMember(Name="enforceCountyLoanLimit")]
		public bool? EnforceCountyLoanLimit { get; set; }

		[DataMember(Name="estimatedClosingCostsAmount")]
		public decimal? EstimatedClosingCostsAmount { get; set; }

		[DataMember(Name="estimatedConstructionInterest")]
		public decimal? EstimatedConstructionInterest { get; set; }

		[DataMember(Name="estimatedPrepaidItemsAmount")]
		public decimal? EstimatedPrepaidItemsAmount { get; set; }

		[DataMember(Name="exportLoanNumber")]
		public string ExportLoanNumber { get; set; }

		[DataMember(Name="exportLogs")]
		public List<LoanContractExportLogs> ExportLogs { get; set; }

		[DataMember(Name="fannieMae")]
		public LoanContractFannieMae FannieMae { get; set; }

		[DataMember(Name="fees")]
		public List<LoanContractFees> Fees { get; set; }

		[DataMember(Name="fhaMiPremiumRefundAmount")]
		public decimal? FhaMiPremiumRefundAmount { get; set; }

		[DataMember(Name="fhaVaLoan")]
		public LoanContractFhaVaLoan FhaVaLoan { get; set; }

		[DataMember(Name="fHAVALoanOriginatorIdentifier")]
		public string FHAVALoanOriginatorIdentifier { get; set; }

		[DataMember(Name="fieldLockData")]
		public List<LoanContractFieldLockData> FieldLockData { get; set; }

		[DataMember(Name="firstAdjustmentMinimum")]
		public decimal? FirstAdjustmentMinimum { get; set; }

		[DataMember(Name="firstSubordinateLienAmount")]
		public decimal? FirstSubordinateLienAmount { get; set; }

		[DataMember(Name="firstTimeHomebuyersIndicator")]
		public bool? FirstTimeHomebuyersIndicator { get; set; }

		[DataMember(Name="fnmCommunityLendingProductName")]
		public string FnmCommunityLendingProductName { get; set; }

		[DataMember(Name="fnmCommunitySecondsIndicator")]
		public bool? FnmCommunitySecondsIndicator { get; set; }

		[DataMember(Name="fnmNeighborsMortgageEligibilityIndicator")]
		public bool? FnmNeighborsMortgageEligibilityIndicator { get; set; }

		[DataMember(Name="forms")]
		public List<LoanContractForms1> Forms { get; set; }

		[DataMember(Name="fraudScore")]
		public int? FraudScore { get; set; }

		[DataMember(Name="freddieMac")]
		public LoanContractFreddieMac FreddieMac { get; set; }

		[DataMember(Name="funding")]
		public LoanContractFunding Funding { get; set; }

		[DataMember(Name="fundingDeductionList")]
		public string FundingDeductionList { get; set; }

		[DataMember(Name="fundingFeeList")]
		public string FundingFeeList { get; set; }

		[DataMember(Name="fundingFees")]
		public List<LoanContractFundingFees> FundingFees { get; set; }

		[DataMember(Name="gfe")]
		public LoanContractGfe Gfe { get; set; }

		[DataMember(Name="governmentLoanLenderIdentifier")]
		public string GovernmentLoanLenderIdentifier { get; set; }

		[DataMember(Name="governmentLoanSponsorIdentifier")]
		public string GovernmentLoanSponsorIdentifier { get; set; }

		[DataMember(Name="governmentMortgageCreditCertificateAmount")]
		public decimal? GovernmentMortgageCreditCertificateAmount { get; set; }

		[DataMember(Name="hasAbusinessRelationshipWith")]
		public string HasAbusinessRelationshipWith { get; set; }

		[DataMember(Name="hcltvHtltv")]
		public decimal? HcltvHtltv { get; set; }

		[DataMember(Name="helocTeaserRate")]
		public decimal? HelocTeaserRate { get; set; }

		[DataMember(Name="hmda")]
		public LoanContractHmda Hmda { get; set; }

		[DataMember(Name="homeCounselingProviders")]
		public List<LoanContractHomeCounselingProviders> HomeCounselingProviders { get; set; }

		[DataMember(Name="homeCounselingProvidersDistance")]
		public string HomeCounselingProvidersDistance { get; set; }

		[DataMember(Name="homeCounselingProvidersLanguageNames")]
		public string HomeCounselingProvidersLanguageNames { get; set; }

		[DataMember(Name="homeCounselingProvidersServiceNames")]
		public string HomeCounselingProvidersServiceNames { get; set; }

		[DataMember(Name="householdSizeCount")]
		public int? HouseholdSizeCount { get; set; }

		[DataMember(Name="htmlEmailLogs")]
		public List<LoanContractHtmlEmailLogs> HtmlEmailLogs { get; set; }

		[DataMember(Name="hud1Es")]
		public LoanContractHud1Es Hud1Es { get; set; }

		[DataMember(Name="hudIncomeLimitAdjustmentFactor")]
		public decimal? HudIncomeLimitAdjustmentFactor { get; set; }

		[DataMember(Name="hudLendingIncomeLimitAmount")]
		public decimal? HudLendingIncomeLimitAmount { get; set; }

		[DataMember(Name="hudLoanData")]
		public LoanContractHudLoanData HudLoanData { get; set; }

		[DataMember(Name="hudMedianIncomeAmount")]
		public decimal? HudMedianIncomeAmount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="includeUSDAFeeInClosing")]
		public bool? IncludeUSDAFeeInClosing { get; set; }

		[DataMember(Name="initialInterestRate")]
		public decimal? InitialInterestRate { get; set; }

		[DataMember(Name="initialInterestRateUI")]
		public string InitialInterestRateUI { get; set; }

		[DataMember(Name="insuranceAuthorizationIndicator")]
		public string InsuranceAuthorizationIndicator { get; set; }

		[DataMember(Name="interimServicing")]
		public LoanContractInterimServicing InterimServicing { get; set; }

		[DataMember(Name="interviewerApplicationSignedDate")]
		public DateTime? InterviewerApplicationSignedDate { get; set; }

		[DataMember(Name="interviewerEmail")]
		public string InterviewerEmail { get; set; }

		[DataMember(Name="interviewerLicenseIdentifier")]
		public string InterviewerLicenseIdentifier { get; set; }

		[DataMember(Name="interviewerPhoneNumber")]
		public string InterviewerPhoneNumber { get; set; }

		[DataMember(Name="interviewersCompanyStateLicense")]
		public string InterviewersCompanyStateLicense { get; set; }

		[DataMember(Name="interviewersId")]
		public string InterviewersId { get; set; }

		[DataMember(Name="inverviewerName")]
		public string InverviewerName { get; set; }

		[DataMember(Name="isCreditorProhibitsBorrower")]
		public bool? IsCreditorProhibitsBorrower { get; set; }

		[DataMember(Name="isEmployeeLoan")]
		public bool? IsEmployeeLoan { get; set; }

		[DataMember(Name="isLSSecondaryFile")]
		public bool? IsLSSecondaryFile { get; set; }

		[DataMember(Name="isRequiredInterestReserveCompoundInterest")]
		public bool? IsRequiredInterestReserveCompoundInterest { get; set; }

		[DataMember(Name="landIfAcquiredSeperatelyAmount")]
		public decimal? LandIfAcquiredSeperatelyAmount { get; set; }

		[DataMember(Name="leadSource")]
		public string LeadSource { get; set; }

		[DataMember(Name="leadSourceID")]
		public string LeadSourceID { get; set; }

		[DataMember(Name="lenderCaseIdentifier")]
		public string LenderCaseIdentifier { get; set; }

		[DataMember(Name="lenderChannel")]
		public string LenderChannel { get; set; }

		[DataMember(Name="lenderCreditsInFunding")]
		public decimal? LenderCreditsInFunding { get; set; }

		[DataMember(Name="lenderInvestorCode")]
		public string LenderInvestorCode { get; set; }

		[DataMember(Name="lenderPaidClosignCostsDotAmount")]
		public decimal? LenderPaidClosignCostsDotAmount { get; set; }

		[DataMember(Name="lenderPaidClosingCostsAmount")]
		public decimal? LenderPaidClosingCostsAmount { get; set; }

		[DataMember(Name="lesserAppraisedValueOrSalesPrice")]
		public decimal? LesserAppraisedValueOrSalesPrice { get; set; }

		[DataMember(Name="lifeInsuranceCoverageAmount")]
		public decimal? LifeInsuranceCoverageAmount { get; set; }

		[DataMember(Name="lifeInsuranceEstimatedMonthlyAmount")]
		public decimal? LifeInsuranceEstimatedMonthlyAmount { get; set; }

		[DataMember(Name="lifeInsuranceTotalProtectedMonthlyAmount")]
		public decimal? LifeInsuranceTotalProtectedMonthlyAmount { get; set; }

		[DataMember(Name="linkedBorrowerRequestedLoanAmount")]
		public decimal? LinkedBorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="linkId")]
		public string LinkId { get; set; }

		[DataMember(Name="loanActionLogs")]
		public List<LoanContractLoanActionLogs> LoanActionLogs { get; set; }

		[DataMember(Name="loanAmortizationTermMonths")]
		public int? LoanAmortizationTermMonths { get; set; }

		[DataMember(Name="loanAmortizationType")]
		public string LoanAmortizationType { get; set; }

		[DataMember(Name="loanCreatedDate")]
		public string LoanCreatedDate { get; set; }

		[DataMember(Name="loanCreatedDateUtc")]
		public DateTime? LoanCreatedDateUtc { get; set; }

		[DataMember(Name="loanIdNumber")]
		public string LoanIdNumber { get; set; }

		[DataMember(Name="loanImportStatusIndicator")]
		public bool? LoanImportStatusIndicator { get; set; }

		[DataMember(Name="loanLinkSyncType")]
		public string LoanLinkSyncType { get; set; }

		[DataMember(Name="loanNumber")]
		public string LoanNumber { get; set; }

		[DataMember(Name="loanProductData")]
		public LoanContractLoanProductData LoanProductData { get; set; }

		[DataMember(Name="loanProgramName")]
		public string LoanProgramName { get; set; }

		[DataMember(Name="loanPrograms")]
		public List<LoanContractLoanPrograms> LoanPrograms { get; set; }

		[DataMember(Name="loanPurposeOfRefinanceType")]
		public string LoanPurposeOfRefinanceType { get; set; }

		[DataMember(Name="loanSource")]
		public string LoanSource { get; set; }

		[DataMember(Name="loanSubmission")]
		public LoanContractLoanSubmission LoanSubmission { get; set; }

		[DataMember(Name="loanTotalProposedMonthlyMaintenanceAmount")]
		public decimal? LoanTotalProposedMonthlyMaintenanceAmount { get; set; }

		[DataMember(Name="loanTotalProposedMonthlyUtilitiesAmount")]
		public decimal? LoanTotalProposedMonthlyUtilitiesAmount { get; set; }

		[DataMember(Name="loanUnderwriterCHUMSIdentifier")]
		public string LoanUnderwriterCHUMSIdentifier { get; set; }

		[DataMember(Name="loanVALoanProcedureType")]
		public string LoanVALoanProcedureType { get; set; }

		[DataMember(Name="loanVARateReductionInitialComputationTotalAmount")]
		public decimal? LoanVARateReductionInitialComputationTotalAmount { get; set; }

		[DataMember(Name="loanVAResidualIncomeAmount")]
		public decimal? LoanVAResidualIncomeAmount { get; set; }

		[DataMember(Name="loanVersionId")]
		public int? LoanVersionId { get; set; }

		[DataMember(Name="lockConfirmLogs")]
		public List<LoanContractLockConfirmLogs> LockConfirmLogs { get; set; }

		[DataMember(Name="lockDenialLogs")]
		public List<LoanContractLockDenialLogs> LockDenialLogs { get; set; }

		[DataMember(Name="lockRequestLogs")]
		public List<LoanContractLockRequestLogs> LockRequestLogs { get; set; }

		[DataMember(Name="lOCompensation")]
		public LoanContractLOCompensation LOCompensation { get; set; }

		[DataMember(Name="logEntryLogs")]
		public List<LoanContractLogEntryLogs> LogEntryLogs { get; set; }

		[DataMember(Name="ltv")]
		public decimal? Ltv { get; set; }

		[DataMember(Name="ltvPropertyValue")]
		public decimal? LtvPropertyValue { get; set; }

		[DataMember(Name="masterCommitmentNumber")]
		public string MasterCommitmentNumber { get; set; }

		[DataMember(Name="maturityDate")]
		public DateTime? MaturityDate { get; set; }

		[DataMember(Name="maxBackRatio")]
		public decimal? MaxBackRatio { get; set; }

		[DataMember(Name="maxFrontRatio")]
		public decimal? MaxFrontRatio { get; set; }

		[DataMember(Name="mcaw")]
		public LoanContractMcaw Mcaw { get; set; }

		[DataMember(Name="mersNumber")]
		public string MersNumber { get; set; }

		[DataMember(Name="mersNumberRegistrationDate")]
		public DateTime? MersNumberRegistrationDate { get; set; }

		[DataMember(Name="miAndFundingFeeFinancedAmount")]
		public decimal? MiAndFundingFeeFinancedAmount { get; set; }

		[DataMember(Name="miAndFundingFeeTotalAmount")]
		public decimal? MiAndFundingFeeTotalAmount { get; set; }

		[DataMember(Name="milestoneApprovedDate")]
		public DateTime? MilestoneApprovedDate { get; set; }

		[DataMember(Name="milestoneApprovedDueDate")]
		public DateTime? MilestoneApprovedDueDate { get; set; }

		[DataMember(Name="milestoneCompletedDate")]
		public DateTime? MilestoneCompletedDate { get; set; }

		[DataMember(Name="milestoneCompletedDueDate")]
		public DateTime? MilestoneCompletedDueDate { get; set; }

		[DataMember(Name="milestoneCurrentDateUtc")]
		public DateTime? MilestoneCurrentDateUtc { get; set; }

		[DataMember(Name="milestoneCurrentName")]
		public string MilestoneCurrentName { get; set; }

		[DataMember(Name="milestoneDocSignedDate")]
		public DateTime? MilestoneDocSignedDate { get; set; }

		[DataMember(Name="milestoneDocSignedDueDate")]
		public DateTime? MilestoneDocSignedDueDate { get; set; }

		[DataMember(Name="milestoneDuration")]
		public int? MilestoneDuration { get; set; }

		[DataMember(Name="milestoneFileStartedDate")]
		public DateTime? MilestoneFileStartedDate { get; set; }

		[DataMember(Name="milestoneFreeRoleLogs")]
		public List<LoanContractMilestoneFreeRoleLogs> MilestoneFreeRoleLogs { get; set; }

		[DataMember(Name="milestoneFundedDate")]
		public DateTime? MilestoneFundedDate { get; set; }

		[DataMember(Name="milestoneFundedDueDate")]
		public DateTime? MilestoneFundedDueDate { get; set; }

		[DataMember(Name="milestoneHistoryLogs")]
		public List<object> MilestoneHistoryLogs { get; set; }

		[DataMember(Name="milestoneLogs")]
		public List<LoanContractMilestoneLogs> MilestoneLogs { get; set; }

		[DataMember(Name="milestoneProcessedDate")]
		public DateTime? MilestoneProcessedDate { get; set; }

		[DataMember(Name="milestoneStage")]
		public string MilestoneStage { get; set; }

		[DataMember(Name="milestoneSubmittedDate")]
		public DateTime? MilestoneSubmittedDate { get; set; }

		[DataMember(Name="milestoneSubmittedDueDate")]
		public DateTime? MilestoneSubmittedDueDate { get; set; }

		[DataMember(Name="milestoneTaskLogs")]
		public List<LoanContractMilestoneTaskLogs> MilestoneTaskLogs { get; set; }

		[DataMember(Name="milestoneTemplateLogs")]
		public List<LoanContractMilestoneTemplateLogs> MilestoneTemplateLogs { get; set; }

		[DataMember(Name="mipBorrowerPaidInCashAmount")]
		public decimal? MipBorrowerPaidInCashAmount { get; set; }

		[DataMember(Name="mipPaidInCashAmount")]
		public decimal? MipPaidInCashAmount { get; set; }

		[DataMember(Name="miscellaneous")]
		public LoanContractMiscellaneous Miscellaneous { get; set; }

		[DataMember(Name="monthlyPIPaymentAmountForLE1andCD1")]
		public decimal? MonthlyPIPaymentAmountForLE1andCD1 { get; set; }

		[DataMember(Name="mortgageInsurancePremiumFHARefundAmount")]
		public decimal? MortgageInsurancePremiumFHARefundAmount { get; set; }

		[DataMember(Name="mortgageInsurancePremiumUpfrontFactorPercent")]
		public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get; set; }

		[DataMember(Name="mortgageType")]
		public string MortgageType { get; set; }

		[DataMember(Name="msaIdentifier")]
		public string MsaIdentifier { get; set; }

		[DataMember(Name="netTangibleBenefit")]
		public LoanContractNetTangibleBenefit NetTangibleBenefit { get; set; }

		[DataMember(Name="newFirstMortgageAmount")]
		public decimal? NewFirstMortgageAmount { get; set; }

		[DataMember(Name="nmlsLoanOriginatorId")]
		public string NmlsLoanOriginatorId { get; set; }

		[DataMember(Name="noClosingCostOption")]
		public bool? NoClosingCostOption { get; set; }

		[DataMember(Name="nonBorrowingOwners")]
		public List<LoanContractNonBorrowingOwners> NonBorrowingOwners { get; set; }

		[DataMember(Name="nonVols")]
		public List<LoanContractNonVols> NonVols { get; set; }

		[DataMember(Name="notRequiredForPurchaseSaleOrRefinance")]
		public bool? NotRequiredForPurchaseSaleOrRefinance { get; set; }

		[DataMember(Name="notRequiredForSettlementOfYourLoan")]
		public bool? NotRequiredForSettlementOfYourLoan { get; set; }

		[DataMember(Name = "newVestingNboAlert")]
		public bool? NewVestingNboAlert { get; set; }

		[DataMember(Name="occupancyType")]
		public string OccupancyType { get; set; }

		[DataMember(Name="openingDocsInvestorCode")]
		public string OpeningDocsInvestorCode { get; set; }

		[DataMember(Name="openingDocsLoanProgramType")]
		public string OpeningDocsLoanProgramType { get; set; }

		[DataMember(Name="openingDocsPlanDescription")]
		public string OpeningDocsPlanDescription { get; set; }

		[DataMember(Name="openingDocsPlanId")]
		public string OpeningDocsPlanId { get; set; }

		[DataMember(Name="openingDocsProgramCode")]
		public string OpeningDocsProgramCode { get; set; }

		[DataMember(Name="openingDocsStackingOrder")]
		public string OpeningDocsStackingOrder { get; set; }

		[DataMember(Name="organizationCode")]
		public string OrganizationCode { get; set; }

		[DataMember(Name="originationDate")]
		public DateTime? OriginationDate { get; set; }

		[DataMember(Name="otherAmortizationTypeDescription")]
		public string OtherAmortizationTypeDescription { get; set; }

		[DataMember(Name="otherMortgageTypeDescription")]
		public string OtherMortgageTypeDescription { get; set; }

		[DataMember(Name="otherPaidClosingCostsAmount")]
		public decimal? OtherPaidClosingCostsAmount { get; set; }

		[DataMember(Name="overwireAmount")]
		public decimal? OverwireAmount { get; set; }

		[DataMember(Name = "paceLoanPayoffAmount")]
		public decimal? PaceLoanPayoffAmount { get; set; }

		[DataMember(Name="paymentScheduleCalcRequiredIndicator")]
		public bool? PaymentScheduleCalcRequiredIndicator { get; set; }

		[DataMember(Name="percentageOfOwnership")]
		public string PercentageOfOwnership { get; set; }

		[DataMember(Name="percentageOwnershipInterest")]
		public decimal? PercentageOwnershipInterest { get; set; }

		[DataMember(Name="pmiIndicator")]
		public bool? PmiIndicator { get; set; }

		[DataMember(Name="postClosingConditionLogs")]
		public List<LoanContractPostClosingConditionLogs> PostClosingConditionLogs { get; set; }

		[DataMember(Name="preliminaryConditionLogs")]
		public List<LoanContractPreliminaryConditionLogs> PreliminaryConditionLogs { get; set; }

		[DataMember(Name="prequalification")]
		public LoanContractPrequalification Prequalification { get; set; }

		[DataMember(Name="principalAndInterestMonthlyPaymentAmount")]
		public decimal? PrincipalAndInterestMonthlyPaymentAmount { get; set; }

		[DataMember(Name="print2003Application")]
		public string Print2003Application { get; set; }

		[DataMember(Name="printLogs")]
		public List<LoanContractPrintLogs> PrintLogs { get; set; }

		[DataMember(Name="privacyPolicy")]
		public LoanContractPrivacyPolicy PrivacyPolicy { get; set; }

		[DataMember(Name="profitManagement")]
		public LoanContractProfitManagement ProfitManagement { get; set; }

		[DataMember(Name="property")]
		public LoanContractProperty Property { get; set; }

		[DataMember(Name="propertyAppraisedValueAmount")]
		public int? PropertyAppraisedValueAmount { get; set; }

		[DataMember(Name="propertyEnergyEfficientHomeIndicator")]
		public bool? PropertyEnergyEfficientHomeIndicator { get; set; }

		[DataMember(Name="propertyEstimatedValueAmount")]
		public int? PropertyEstimatedValueAmount { get; set; }

		[DataMember(Name="proposedDuesAmount")]
		public string ProposedDuesAmount { get; set; }

		[DataMember(Name="proposedFirstMortgageAmount")]
		public decimal? ProposedFirstMortgageAmount { get; set; }

		[DataMember(Name="proposedGroundRentAmount")]
		public decimal? ProposedGroundRentAmount { get; set; }

		[DataMember(Name="proposedHazardInsuranceAmount")]
		public string ProposedHazardInsuranceAmount { get; set; }

		[DataMember(Name="proposedHousingExpenseTotal")]
		public decimal? ProposedHousingExpenseTotal { get; set; }

		[DataMember(Name="proposedMortgageInsuranceAmount")]
		public string ProposedMortgageInsuranceAmount { get; set; }

		[DataMember(Name="proposedOtherAmount")]
		public decimal? ProposedOtherAmount { get; set; }

		[DataMember(Name="proposedOtherMortgagesAmount")]
		public decimal? ProposedOtherMortgagesAmount { get; set; }

		[DataMember(Name="proposedRealEstateTaxesAmount")]
		public string ProposedRealEstateTaxesAmount { get; set; }

		[DataMember(Name="purchaseCredits")]
		public List<LoanContractPurchaseCredits> PurchaseCredits { get; set; }

		[DataMember(Name="purchasePriceAmount")]
		public decimal? PurchasePriceAmount { get; set; }

		[DataMember(Name="rateLock")]
		public LoanContractRateLock RateLock { get; set; }

		[DataMember(Name="referralAddress")]
		public string ReferralAddress { get; set; }

		[DataMember(Name="referralCity")]
		public string ReferralCity { get; set; }

		[DataMember(Name="referralFeeAmount")]
		public decimal? ReferralFeeAmount { get; set; }

		[DataMember(Name="referralPostalCode")]
		public string ReferralPostalCode { get; set; }

		[DataMember(Name="referralSource")]
		public string ReferralSource { get; set; }

		[DataMember(Name="referralSourceContact")]
		public EntityRefContract ReferralSourceContact { get; set; }

		[DataMember(Name="referralState")]
		public string ReferralState { get; set; }

		[DataMember(Name="refinanceIncludingDebtsToBePaidOffAmount")]
		public decimal? RefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="registrationLogs")]
		public List<LoanContractRegistrationLogs> RegistrationLogs { get; set; }

		[DataMember(Name="regulationZ")]
		public LoanContractRegulationZ RegulationZ { get; set; }

		[DataMember(Name="removedLogRecords")]
		public List<LoanContractLogRecord> RemovedLogRecords { get; set; }

		[DataMember(Name="repurchaseCostAmount")]
		public decimal? RepurchaseCostAmount { get; set; }

		[DataMember(Name="repurchaseDate")]
		public DateTime? RepurchaseDate { get; set; }

		[DataMember(Name="requestedInterestRatePercent")]
		public decimal? RequestedInterestRatePercent { get; set; }

		[DataMember(Name="requestedInterestRatePercentUI")]
		public string RequestedInterestRatePercentUI { get; set; }

		[DataMember(Name="salesConcessionAmount")]
		public decimal? SalesConcessionAmount { get; set; }

		[DataMember(Name="secondSubordinateAmount")]
		public decimal? SecondSubordinateAmount { get; set; }

		[DataMember(Name="section32")]
		public LoanContractSection32 Section32 { get; set; }

		[DataMember(Name="sectionOfActType")]
		public string SectionOfActType { get; set; }

		[DataMember(Name="selectedHomeCounselingProvider")]
		public LoanContractSelectedHomeCounselingProvider SelectedHomeCounselingProvider { get; set; }

		[DataMember(Name="sellerPaidClosingCostsAmount")]
		public decimal? SellerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="serviceProviderAdditionalInfo")]
		public string ServiceProviderAdditionalInfo { get; set; }

		[DataMember(Name="serviceProviderContacts")]
		public List<LoanContractServiceProviderContacts> ServiceProviderContacts { get; set; }

		[DataMember(Name="serviceProviderDateIssued")]
		public DateTime? ServiceProviderDateIssued { get; set; }

		[DataMember(Name="servicingDisclosure")]
		public LoanContractServicingDisclosure ServicingDisclosure { get; set; }

		[DataMember(Name="setForSettlementServicesOfAnAttorney")]
		public bool? SetForSettlementServicesOfAnAttorney { get; set; }

		[DataMember(Name="setForTheSettlementServicesListed")]
		public bool? SetForTheSettlementServicesListed { get; set; }

		[DataMember(Name="settlementServiceCharges")]
		public List<LoanContractSettlementServiceCharges> SettlementServiceCharges { get; set; }

		[DataMember(Name="shipping")]
		public LoanContractShipping Shipping { get; set; }

		[DataMember(Name="simpleRefinanceType")]
		public bool? SimpleRefinanceType { get; set; }

		[DataMember(Name="startingAdjPrice")]
		public decimal? StartingAdjPrice { get; set; }

		[DataMember(Name="startingAdjRate")]
		public decimal? StartingAdjRate { get; set; }

		[DataMember(Name="stateDisclosure")]
		public LoanContractStateDisclosure StateDisclosure { get; set; }

		[DataMember(Name="statementCreditDenial")]
		public LoanContractStatementCreditDenial StatementCreditDenial { get; set; }

		[DataMember(Name="statusOnlineLogs")]
		public List<LoanContractStatusOnlineLogs> StatusOnlineLogs { get; set; }

		[DataMember(Name="subjectPropertyGrossRentalIncomeAmount")]
		public decimal? SubjectPropertyGrossRentalIncomeAmount { get; set; }

		[DataMember(Name="subjectPropertyOccupancyPercent")]
		public decimal? SubjectPropertyOccupancyPercent { get; set; }

		[DataMember(Name="subordinateLienAmount")]
		public decimal? SubordinateLienAmount { get; set; }

		[DataMember(Name="systemIdGuid")]
		public string SystemIdGuid { get; set; }

		[DataMember(Name="tilApplicationDate")]
		public DateTime? TilApplicationDate { get; set; }

		[DataMember(Name="titleHolderName1")]
		public string TitleHolderName1 { get; set; }

		[DataMember(Name="titleHolderName2")]
		public string TitleHolderName2 { get; set; }

		[DataMember(Name="tltv")]
		public decimal? Tltv { get; set; }

		[DataMember(Name="totalClosingCostsAmount")]
		public decimal? TotalClosingCostsAmount { get; set; }

		[DataMember(Name="totalDeductionsAmount")]
		public decimal? TotalDeductionsAmount { get; set; }

		[DataMember(Name="totalFeesCostAmount")]
		public decimal? TotalFeesCostAmount { get; set; }

		[DataMember(Name="totalFeesCreditAmount")]
		public decimal? TotalFeesCreditAmount { get; set; }

		[DataMember(Name="totalNonborrowerPaidClosingCostsAmount")]
		public decimal? TotalNonborrowerPaidClosingCostsAmount { get; set; }

		[DataMember(Name="totalPaidOutsideClosingAmount")]
		public decimal? TotalPaidOutsideClosingAmount { get; set; }

		[DataMember(Name="totalPaidToBrokerAmount")]
		public decimal? TotalPaidToBrokerAmount { get; set; }

		[DataMember(Name="totalWireTransferAmount")]
		public decimal? TotalWireTransferAmount { get; set; }

		[DataMember(Name="tPO")]
		public LoanContractTPO TPO { get; set; }

		[DataMember(Name="tQL")]
		public LoanContractTQL TQL { get; set; }

		[DataMember(Name="trustAccount")]
		public LoanContractTrustAccount TrustAccount { get; set; }

		[DataMember(Name="tsum")]
		public LoanContractTsum Tsum { get; set; }

		[DataMember(Name="twelveMonthMortgageRentalHistoryIndicator")]
		public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }

		[DataMember(Name="uCDCaseFileID")]
		public string UCDCaseFileID { get; set; }

		[DataMember(Name="uldd")]
		public LoanContractUldd Uldd { get; set; }

		[DataMember(Name="underwriterSummary")]
		public LoanContractUnderwriterSummary UnderwriterSummary { get; set; }

		[DataMember(Name="underwritingConditionLogs")]
		public List<LoanContractUnderwritingConditionLogs> UnderwritingConditionLogs { get; set; }

		[DataMember(Name="underwritingEscrowIndicator")]
		public bool? UnderwritingEscrowIndicator { get; set; }

		[DataMember(Name="undiscountedRate")]
		public decimal? UndiscountedRate { get; set; }

		[DataMember(Name="urlPage4Comments")]
		public string UrlPage4Comments { get; set; }

		[DataMember(Name="usda")]
		public LoanContractUsda Usda { get; set; }

		[DataMember(Name="usdaGovernmentLoanType")]
		public string UsdaGovernmentLoanType { get; set; }

		[DataMember(Name="use2018DiIndicator")]
		public bool? Use2018DiIndicator { get; set; }

		[DataMember(Name="useNew2015FormsIndicator")]
		public string UseNew2015FormsIndicator { get; set; }

		[DataMember(Name="useNewHudIndicator")]
		public bool? UseNewHudIndicator { get; set; }

		[DataMember(Name="vAEntitlementAmount")]
		public decimal? VAEntitlementAmount { get; set; }

		[DataMember(Name="vaLoanData")]
		public LoanContractVaLoanData VaLoanData { get; set; }

		[DataMember(Name="verificationLogs")]
		public List<LoanContractVerificationLogs> VerificationLogs { get; set; }

		[DataMember(Name="virtualFields")]
		public object VirtualFields { get; set; }

		[DataMember(Name="websiteId")]
		public string WebsiteId { get; set; }

		[DataMember(Name = "mersOrgId")]
		public string MersOrgId { get; set; }

		[DataMember(Name = "mom")]
		public bool? Mom { get; set; }

		[DataMember(Name = "isLoanAmountRounding")]
		public bool? IsLoanAmountRounding { get; set; }

		[DataMember(Name = "printULIonURLA")]
		public bool? PrintULIonURLA { get; set; }

		[DataMember(Name = "renovationLoanIndicator")]
		public bool? RenovationLoanIndicator { get; set; } = false;

		[DataMember(Name = "constructionLoanIndicator")]
		public bool? ConstructionLoanIndicator { get; set; } = false;

		[DataMember(Name = "titleWillBeFullName")]
		public string TitleWillBeFullName { get; set; }

		[DataMember(Name = "titleHolderFullName")]
		public string TitleHolderFullName { get; set; }

		[DataMember(Name = "borrEstimatedClosingCostsAmount")]
		public decimal? BorrEstimatedClosingCostsAmount { get; set; }

		[DataMember(Name = "urlaTotalMortgageLoansAmount")]
		public decimal? URLATotalMortgageLoansAmount { get; set; }

		[DataMember(Name = "urlaTotalOtherCreditsAmount")]
		public decimal? URLATotalOtherCreditsAmount { get; set; }

		[DataMember(Name = "totalOfGiftsGrants")]
		public decimal? TotalOfGiftsGrants { get; set; }

		[DataMember(Name = "totalOtherAssetToLoan")]
		public decimal? TotalOtherAssetToLoan { get; set; }

		[DataMember(Name = "urlaTotalCreditsAmount")]
		public decimal? URLATotalCreditsAmount { get; set; }

		[DataMember(Name = "originatorFirstName")]
		public string OriginatorFirstName { get; set; }

		[DataMember(Name = "originatorMiddleName")]
		public string OriginatorMiddleName { get; set; }

		[DataMember(Name = "originatorLastName")]
		public string OriginatorLastName { get; set; }

		[DataMember(Name = "originatorSuffixName")]
		public string OriginatorSuffixName { get; set; }

		[DataMember(Name = "newMortgageCreditorName")]
		public string NewMortgageCreditorName { get; set; }

		[DataMember(Name = "newMortgageMonthlyPayment")]
		public string NewMortgageMonthlyPayment { get; set; }

		[DataMember(Name = "newSubordinateCreditorName")]
		public string NewSubordinateCreditorName { get; set; }

		[DataMember(Name = "newSubordinateMonthlyPayment")]
		public string NewSubordinateMonthlyPayment { get; set; }

		[DataMember(Name = "newHelocCreditorName")]
		public string NewHELOCCreditorName { get; set; }

		[DataMember(Name = "newHelocMonthlyPayment")]
		public decimal? NewHELOCMonthlyPayment { get; set; }

		[DataMember(Name = "originatorAddressLineText")]
		public string OriginatorAddressLineText { get; set; }

		[DataMember(Name = "originatorAddressUnitDesignatorType")]
		public string OriginatorAddressUnitDesignatorType { get; set; }

		[DataMember(Name = "originatorAddressUnitIdentifier")]
		public string OriginatorAddressUnitIdentifier { get; set; }

		[DataMember(Name = "condominiumIndicator")]
		public bool? CondominiumIndicator { get; set; }

		[DataMember(Name = "cooperativeIndicator")]
		public bool? CooperativeIndicator { get; set; }

		[DataMember(Name = "pudIndicator")]
		public bool? PUDIndicator { get; set; }

		[DataMember(Name = "notInProjectIndicator")]
		public bool? NotInProjectIndicator { get; set; }

		[DataMember(Name = "paymentDeferredFirstFiveYears")]
		public bool? PaymentDeferredFirstFiveYears { get; set; }

		[DataMember(Name = "affordableLoan")]
		public bool? AffordableLoan { get; set; }

		[DataMember(Name = "totalAdditionalMortgages")]
		public decimal? TotalAdditionalMortgages { get; set; }

		[DataMember(Name = "borrowerCount")]
		public string BorrowerCount { get; set; }

		[DataMember(Name = "printLenderPages")]
		public bool? PrintLenderPages { get; set; }

		[DataMember(Name = "printULIAndLoanNoURLA")]
		public bool? PrintULIAndLoanNoURLA { get; set; } = false;

		[DataMember(Name = "negativeAmortization")]
		public bool? NegativeAmortization { get; set; } = false;

		[DataMember(Name = "urlaLoanIdentifier")]
		public string URLALoanIdentifier { get; set; }

		[DataMember(Name = "valuationUsed")]
		public decimal? ValuationUsed { get; set; }

		[DataMember(Name = "existingLiensAndDrawUsed")]
		public decimal? ExistingLiensAndDrawUsed { get; set; }

		[DataMember(Name = "serverDateTimeDdmApplied")]
		public DateTime? ServerDateTimeDDMApplied { get; set; }

		[DataMember(Name = "useEnhancedConditionIndicator")]
		public bool? UseEnhancedConditionIndicator { get; set; } = false;

		[DataMember(Name = "existingLiensUsed")]
		public decimal? ExistingLiensUsed { get; set; }

		[DataMember(Name = "calculatedLoanAmount")]
		public decimal? CalculatedLoanAmount { get; set; }

		[DataMember(Name = "refinanceCashOutDeterminationType")]
		public string RefinanceCashOutDeterminationType { get; set; }
	}
}