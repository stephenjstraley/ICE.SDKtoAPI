using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "loanIdNumber")]
        public string LoanIdNumber { get; set; }

        [DataMember(Name = "additionalRequests")]
        public AdditionalRequestsContract AdditionalRequests { get; set; }

        [DataMember(Name = "adverseActionDate")]
        public string AdverseActionDate { get; set; }

        [DataMember(Name = "affiliatedBusinessArrangements")]
        public List<AffiliatedBusinessArrangementContract> AffiliatedBusinessArrangements { get; set; }

        [DataMember(Name = "agencyCaseIdentifier")]
        public string AgencyCaseIdentifier { get; set; }

        [DataMember(Name = "alertChangeCircumstances")]
        public List<AlertChangeCircumstanceContract> AlertChangeCircumstances { get; set; }

        [DataMember(Name = "alterationsImprovementsOrRepairsAmount")]
        public decimal? AlterationsImprovementsOrRepairsAmount  { get; set; }

        [DataMember(Name = "applications")]
        public List<ApplicationContract> Applications { get; set; }

        [DataMember(Name = "applicationTakenMethodType")]
        public string ApplicationTakenMethodType { get; set; }

        [DataMember(Name = "aprDisclosureDate")]
        public string AprDisclosureDate { get; set; }

        [DataMember(Name = "armTypeDescription")]
        public string ArmTypeDescription { get; set; }

        [DataMember(Name = "atrqmCommon")]
        public ATRQMCommonContract AtrqmCommon { get; set; }

        [DataMember(Name = "averageRepresentativeCreditScore", EmitDefaultValue = false)]
        public int? AverageRepresentativeCreditScore { get; set; }

        [DataMember(Name = "baseLoanAmount")]
        public decimal? BaseLoanAmount  { get; set; }

        [DataMember(Name = "belowMarketSubordinateFinancingIndicator")]
        public bool? BelowMarketSubordinateFinancingIndicator { get; set; }

        [DataMember(Name = "billingCategory")]
        public string BillingCategory { get; set; }

        [DataMember(Name = "biweeklyPaymentAmount")]
        public decimal? BiweeklyPaymentAmount  { get; set; }

        [DataMember(Name = "bltv")]
        public int? Bltv  { get; set; }

        [DataMember(Name = "borrowerCoBorrowerMarriedIndicator")]
        public bool? BorrowerCoBorrowerMarriedIndicator { get; set; }

        [DataMember(Name = "borrowerCount")]
        public string BorrowerCount { get; set; }

        [DataMember(Name = "borrowerPaidClosingCostsAmount")]
        public decimal? BorrowerPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "borrowerPaidDiscountPointsAmount")]
        public decimal? BorrowerPaidDiscountPointsAmount  { get; set; }

        [DataMember(Name = "borrowerPaidFhavaClosingCostsAmount")]
        public decimal? BorrowerPaidFhavaClosingCostsAmount  { get; set; }

        [DataMember(Name = "borrowerPairCount")]
        public int? BorrowerPairCount  { get; set; }

        [DataMember(Name = "tpoMigrationDone")]
        public bool? TpoMigrationDone { get; set; }

        [DataMember(Name = "borrowerRequestedLoanAmount")]
        public decimal? BorrowerRequestedLoanAmount  { get; set; }

        [DataMember(Name = "borrowerRequestedLoanAmountUrla")]
        public decimal? BorrowerRequestedLoanAmountUrla  { get; set; }

        [DataMember(Name = "brokerPaidClosingCostsAmount")]
        public decimal? BrokerPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "buydownIndicator")]
        public bool? BuydownIndicator { get; set; }

        [DataMember(Name = "buydownMonthlyPaymentAmount")]
        public decimal? BuydownMonthlyPaymentAmount  { get; set; }

        [DataMember(Name = "buydownRatePercent")]
        public decimal? BuydownRatePercent  { get; set; }

        [DataMember(Name = "calculatedDrawAmount")]
        public decimal? CalculatedDrawAmount  { get; set; }

        [DataMember(Name = "calculatedLoanAmount")]
        public decimal? CalculatedLoanAmount  { get; set; }

        [DataMember(Name = "cashFromToBorrowerAmount")]
        public decimal? CashFromToBorrowerAmount  { get; set; }

        [DataMember(Name = "channel")]
        public string Channel { get; set; }

        [DataMember(Name = "closingBillingDate")]
        public string ClosingBillingDate { get; set; }

        [DataMember(Name = "closingCost")]
        public ClosingCostContract ClosingCost { get; set; }

        [DataMember(Name = "closingCostProgram")]
        public string ClosingCostProgram { get; set; }

        [DataMember(Name = "closingCostsAndPrepaidsFromOtherLienAmount")]
        public decimal? ClosingCostsAndPrepaidsFromOtherLienAmount  { get; set; }

        [DataMember(Name = "closingCostsPaidByOthersAmount")]
        public decimal? ClosingCostsPaidByOthersAmount  { get; set; }

        [DataMember(Name = "closingDocsStackingOrder")]
        public string ClosingDocsStackingOrder { get; set; }

        [DataMember(Name = "closingDocument")]
        public ClosingDocumentContract ClosingDocument { get; set; }

        [DataMember(Name = "collateralManagerScore")]
        public int? CollateralManagerScore  { get; set; }

        [DataMember(Name = "combinedLtv")]
        public decimal? CombinedLtv  { get; set; }

        [DataMember(Name = "commitmentNumber")]
        public string CommitmentNumber { get; set; }

        [DataMember(Name = "commitmentTerms")]
        public CommitmentTermsContract CommitmentTerms { get; set; }

        [DataMember(Name = "complianceTestLogs")]
        public List<ComplianceTestLogContract> ComplianceTestLogs { get; set; }

        [DataMember(Name = "conformingJumbo")]
        public string ConformingJumbo { get; set; }

        [DataMember(Name = "constructionManagement")]
        public ConstructionManagementContract ConstructionManagement { get; set; }

        [DataMember(Name = "consumerConnectSiteId")]
        public string ConsumerConnectSiteId { get; set; }

        [DataMember(Name = "consumerHomeInsuranceOrderEligible")]
        public bool? ConsumerHomeInsuranceOrderEligible { get; set; }        

        [DataMember(Name = "contacts")]
        public List<ContactContract> Contacts { get; set; }

        [DataMember(Name = "contactUpdatedIndicator")]
        public bool? ContactUpdatedIndicator { get; set; }

        [DataMember(Name = "contractSellerCreditAmount")]
        public decimal? ContractSellerCreditAmount  { get; set; }

        [DataMember(Name = "conversationLogs")]
        public List<ConversationLogContract> ConversationLogs { get; set; }

        [DataMember(Name = "copyBrokerToLenderIndicator")]
        public bool? CopyBrokerToLenderIndicator { get; set; }

        [DataMember(Name = "copyLoanNumLenderCaseNum")]
        public string CopyLoanNumLenderCaseNum { get; set; }

        [DataMember(Name = "correspondent")]
        public CorrespondentContract Correspondent { get; set; }

        [DataMember(Name = "creditScoreToUse")]
        public string CreditScoreToUse { get; set; }

        [DataMember(Name = "currentApplicationIndex")]
        public int? CurrentApplicationIndex  { get; set; }

        [DataMember(Name = "currentApplicationIsPrimary")]
        public bool? CurrentApplicationIsPrimary { get; set; }

        [DataMember(Name = "currentFirstMortgageHolderType")]
        public string CurrentFirstMortgageHolderType { get; set; }

        [DataMember(Name = "customFields")]
        public List<CustomFieldContract> CustomFields { get; set; }

        [DataMember(Name = "customModelFields")]
        public CustomModelFieldsContract CustomModelFields { get; set; }

        [DataMember(Name = "deductOverwireAmountIndicator")]
        public bool? DeductOverwireAmountIndicator { get; set; }

        [DataMember(Name = "disableESignConsentAlert")]
        public bool? DisableESignConsentAlert { get; set; }

        [DataMember(Name = "disableKeyPricingAlert")]
        public bool? DisableKeyPricingAlert { get; set; }

        [DataMember(Name = "disclosureNotices")]
        public DisclosureNoticesContract DisclosureNotices { get; set; }

        [DataMember(Name = "disclosureTrackingLogs")]
        public List<DisclosureTrackingLogContract> DisclosureTrackingLogs { get; set; }

        [DataMember(Name = "disclosureTracking2015Logs")]
        public List<EnhancedDisclosureTracking2015LogContract> DisclosureTracking2015Logs { get; set; }

        [DataMember(Name = "discountPoint")]
        public decimal? DiscountPoint  { get; set; }

        [DataMember(Name = "docEngine")]
        public string DocEngine { get; set; }

        [DataMember(Name = "doNotCheckEmail")]
        public string DoNotCheckEmail { get; set; }

        [DataMember(Name = "doNotPrintCompensationFees")]
        public bool? DoNotPrintCompensationFees { get; set; }

        [DataMember(Name = "downloadLogs")]
        public List<DownloadLogContract> DownloadLogs { get; set; }

        [DataMember(Name = "downPaymentPercent")]
        public decimal? DownPaymentPercent  { get; set; }

        [DataMember(Name = "downPayment")]
        public DownPaymentContract DownPayment { get; set; }

        [DataMember(Name = "eDeliveryVersion")]
        public int? EDeliveryVersion  { get; set; }

        [DataMember(Name = "edmLogs")]
        public List<EdmLogContract> EdmLogs { get; set; }

        [DataMember(Name = "loCompensation")]
        public LoCompensationContract LoCompensation { get; set; }

        [DataMember(Name = "emailTriggerLogs")]
        public List<EmailTriggerLogContract> EmailTriggerLogs { get; set; }

        [DataMember(Name = "emDocument")]
        public EmDocumentContract EmDocument { get; set; }

        [DataMember(Name = "emDocumentInvestor")]
        public EmDocumentInvestorContract EmDocumentInvestor { get; set; }

        [DataMember(Name = "emDocumentLender")]
        public EmDocumentLenderContract EmDocumentLender { get; set; }

        [DataMember(Name = "encompassVersion")]
        public string EncompassVersion { get; set; }

        [DataMember(Name = "energyImprovementAmount")]
        public decimal? energyImprovementAmount { get; set; }

        [DataMember(Name = "enforceCountyLoanLimit")]
        public bool? EnforceCountyLoanLimit { get; set; }

        [DataMember(Name = "emXmlVersionId")]
        public string EmXmlVersionId { get; set; }

        [DataMember(Name = "estimatedClosingCostsAmount")]
        public decimal? EstimatedClosingCostsAmount  { get; set; }

        [DataMember(Name = "estimatedConstructionInterest")]
        public decimal? EstimatedConstructionInterest  { get; set; }

        [DataMember(Name = "estimatedPrepaidItemsAmount")]
        public decimal? EstimatedPrepaidItemsAmount  { get; set; }

        [DataMember(Name = "existingLiensAndDrawUsed")]
        public decimal? ExistingLiensAndDrawUsed  { get; set; }

        [DataMember(Name = "existingLiensUsed")]
        public decimal? ExistingLiensUsed  { get; set; }

        [DataMember(Name = "exportLoanNumber")]
        public string ExportLoanNumber { get; set; }

        [DataMember(Name = "fannieMae")]
        public FannieMaeContract FannieMae { get; set; }

        [DataMember(Name = "fees")]
        public List<FeeContract> Fees { get; set; }

        [DataMember(Name = "fhaMiPremiumRefundAmount")]
        public decimal? FhaMiPremiumRefundAmount  { get; set; }

        [DataMember(Name = "fhaVaLoan")]
        public FhaVaLoanContract FhaVaLoan { get; set; }

        [DataMember(Name = "fhavaLoanOriginatorIdentifier")]
        public string FhavaLoanOriginatorIdentifier { get; set; }

        [DataMember(Name = "fieldLockData")]
        public List<object> FieldLockData { get; set; }

        [DataMember(Name = "firstAdjustmentMinimum")]
        public decimal? FirstAdjustmentMinimum  { get; set; }

        [DataMember(Name = "firstSubordinateLienAmount")]
        public decimal? FirstSubordinateLienAmount  { get; set; }

        [DataMember(Name = "firstTimeHomebuyersIndicator")]
        public bool? FirstTimeHomebuyersIndicator { get; set; }

        [DataMember(Name = "fnmCommunityLendingProductName")]
        public string FnmCommunityLendingProductName { get; set; }

        [DataMember(Name = "fnmCommunitySecondsIndicator")]
        public bool? FnmCommunitySecondsIndicator { get; set; }

        [DataMember(Name = "fnmNeighborsMortgageEligibilityIndicator")]
        public bool? FnmNeighborsMortgageEligibilityIndicator { get; set; }

        [DataMember(Name = "forms")]
        public List<FormContract> Forms { get; set; }

        [DataMember(Name = "fraudScore")]
        public int? FraudScore  { get; set; }

        [DataMember(Name = "freddieMac")]
        public FreddieMacContract FreddieMac { get; set; }

        [DataMember(Name = "funding")]
        public FundingContract Funding { get; set; }

        [DataMember(Name = "fundingDeductionList")]
        public string FundingDeductionList { get; set; }

        [DataMember(Name = "fundingFeeList")]
        public string FundingFeeList { get; set; }

        [DataMember(Name = "fundingFees")]
        public List<FundingFeeContract> FundingFees { get; set; }

        [DataMember(Name = "gfe")]
        public GfeContract Gfe { get; set; }

        [DataMember(Name = "goodFaithFeeVarianceCureLogs")]
        public List<GoodFaithFeeVarianceCureLogContract> GoodFaithFeeVarianceCureLogs { get; set; }

        [DataMember(Name = "governmentLoanLenderIdentifier")]
        public string GovernmentLoanLenderIdentifier { get; set; }

        [DataMember(Name = "governmentLoanSponsorIdentifier")]
        public string GovernmentLoanSponsorIdentifier { get; set; }

        [DataMember(Name = "governmentMortgageCreditCertificateAmount")]
        public decimal? GovernmentMortgageCreditCertificateAmount  { get; set; }

        [DataMember(Name = "hasAbusinessRelationshipWith")]
        public string HasAbusinessRelationshipWith { get; set; }

        [DataMember(Name = "hcltvHtltv")]
        public decimal? HcltvHtltv  { get; set; }

        [DataMember(Name = "helocTeaserRate")]
        public decimal? HelocTeaserRate  { get; set; }

        [DataMember(Name = "hmda")]
        public HmdaContract Hmda { get; set; }

        [DataMember(Name = "homeCounselingProviders")]
        public List<HomeCounselingProviderContract> HomeCounselingProviders { get; set; }

        [DataMember(Name = "homeCounselingProvidersServiceNames")]
        public string HomeCounselingProvidersServiceNames { get; set; }

        [DataMember(Name = "homeCounselingProvidersLanguageNames")]
        public string HomeCounselingProvidersLanguageNames { get; set; }

        [DataMember(Name = "homeCounselingProvidersDistance")]
        public string HomeCounselingProvidersDistance { get; set; }

        [DataMember(Name = "householdSizeCount")]
        public int? HouseholdSizeCount  { get; set; }

        [DataMember(Name = "hud1Es")]
        public Hud1EsContract Hud1Es { get; set; }

        [DataMember(Name = "hudIncomeLimitAdjustmentFactor")]
        public decimal? HudIncomeLimitAdjustmentFactor  { get; set; }

        [DataMember(Name = "hudLendingIncomeLimitAmount")]
        public decimal? HudLendingIncomeLimitAmount  { get; set; }

        [DataMember(Name = "hudLoanData")]
        public HudLoanDataContract HudLoanData { get; set; }

        [DataMember(Name = "hudMedianIncomeAmount")]
        public decimal? HudMedianIncomeAmount  { get; set; }

        [DataMember(Name = "includeUsdaFeeInClosing")]
        public bool? IncludeUsdaFeeInClosing { get; set; }

        [DataMember(Name = "initialInterestRate")]
        public decimal? InitialInterestRate  { get; set; }

        [DataMember(Name = "initialInterestRateUi")]
        public string InitialInterestRateUi { get; set; }

        [DataMember(Name = "insuranceAuthorizationIndicator")]
        public string InsuranceAuthorizationIndicator { get; set; }

        [DataMember(Name = "interimServicing")]
        public InterimServicingContract InterimServicing { get; set; }

        [DataMember(Name = "interviewerApplicationSignedDate")]
        public string InterviewerApplicationSignedDate { get; set; }

        [DataMember(Name = "interviewerEmail")]
        public string InterviewerEmail { get; set; }

        [DataMember(Name = "interviewerLicenseIdentifier")]
        public string InterviewerLicenseIdentifier { get; set; }

        [DataMember(Name = "interviewerPhoneNumber")]
        public string InterviewerPhoneNumber { get; set; }

        [DataMember(Name = "interviewersCompanyStateLicense")]
        public string InterviewersCompanyStateLicense { get; set; }

        [DataMember(Name = "interviewersId")]
        public string InterviewersId { get; set; }

        [DataMember(Name = "interviewerName")]
        public string InterviewerName { get; set; }

        [DataMember(Name = "isCreditorProhibitsBorrower")]
        public bool? IsCreditorProhibitsBorrower { get; set; }

        [DataMember(Name = "isEmployeeLoan")]
        public bool? IsEmployeeLoan { get; set; }

        [DataMember(Name = "isLsSecondaryFile")]
        public bool? IsLsSecondaryFile { get; set; }

        [DataMember(Name = "isRequiredInterestReserveCompoundInterest")]
        public bool? IsRequiredInterestReserveCompoundInterest { get; set; }

        [DataMember(Name = "landIfAcquiredSeparatelyAmount")]
        public decimal? LandIfAcquiredSeparatelyAmount  { get; set; }

        [DataMember(Name = "leadSource")]
        public string LeadSource { get; set; }

        [DataMember(Name = "leadSourceId")]
        public string LeadSourceId { get; set; }

        [DataMember(Name = "lenderCaseIdentifier")]
        public string LenderCaseIdentifier { get; set; }

        [DataMember(Name = "lenderChannel")]
        public string LenderChannel { get; set; }

        [DataMember(Name = "lenderCreditsInFunding")]
        public decimal? LenderCreditsInFunding  { get; set; }

        [DataMember(Name = "lenderInvestorCode")]
        public string LenderInvestorCode { get; set; }

        [DataMember(Name = "lenderPaidClosignCostsDotAmount")]
        public decimal? LenderPaidClosignCostsDotAmount  { get; set; }

        [DataMember(Name = "lenderPaidClosingCostsAmount")]
        public decimal? LenderPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "lesserAppraisedValueOrSalesPrice")]
        public decimal? LesserAppraisedValueOrSalesPrice  { get; set; }

        [DataMember(Name = "lifeInsuranceCoverageAmount")]
        public decimal? LifeInsuranceCoverageAmount  { get; set; }

        [DataMember(Name = "lifeInsuranceEstimatedMonthlyAmount")]
        public decimal? LifeInsuranceEstimatedMonthlyAmount  { get; set; }

        [DataMember(Name = "lifeInsuranceTotalProtectedMonthlyAmount")]
        public decimal? LifeInsuranceTotalProtectedMonthlyAmount  { get; set; }

        [DataMember(Name = "linkedBorrowerRequestedLoanAmount")]
        public decimal? LinkedBorrowerRequestedLoanAmount  { get; set; }

        [DataMember(Name = "loanActionLogs")]
        public List<LoanActionLogContract> LoanActionLogs { get; set; }

        [DataMember(Name = "linkId")]
        public string LinkId { get; set; }

        [DataMember(Name = "loanAmortizationTermMonths")]
        public int? LoanAmortizationTermMonths  { get; set; }

        [DataMember(Name = "loanAmortizationType")]
        public string LoanAmortizationType { get; set; }

        [DataMember(Name = "loanCreationDate")]
        public string LoanCreationDate { get; set; }

        [DataMember(Name = "loanImportStatusIndicator")]
        public bool? LoanImportStatusIndicator { get; set; }

        [DataMember(Name = "loanLinkSyncType")]
        public string LoanLinkSyncType { get; set; }

        [DataMember(Name = "loanNumber")]
        public string LoanNumber { get; set; }

        [DataMember(Name = "loanProductData")]
        public LoanProductDataContract LoanProductData { get; set; }

        [DataMember(Name = "loanProgramName")]
        public string LoanProgramName { get; set; }

        [DataMember(Name = "loanPrograms")]
        public List<LoanProgramContract> LoanPrograms { get; set; }

        [DataMember(Name = "propertyValuations")]
        public List<PropertyValuationContract> PropertyValuations { get; set; }

        [DataMember(Name = "specialFeatureCodes")]
        public List<SpecialFeatureCodeContract> SpecialFeatureCodes { get; set; }

        [DataMember(Name = "loanPurposeOfRefinanceType")]
        public string LoanPurposeOfRefinanceType { get; set; }

        [DataMember(Name = "loanSource")]
        public string LoanSource { get; set; }

        [DataMember(Name = "loanSubmission")]
        public LoanSubmissionContract LoanSubmission { get; set; }

        [DataMember(Name = "loanTotalProposedMonthlyMaintenanceAmount")]
        public decimal? LoanTotalProposedMonthlyMaintenanceAmount  { get; set; }

        [DataMember(Name = "loanTotalProposedMonthlyUtilitiesAmount")]
        public decimal? LoanTotalProposedMonthlyUtilitiesAmount  { get; set; }

        [DataMember(Name = "loanUnderwriterChumsIdentifier")]
        public string LoanUnderwriterChumsIdentifier { get; set; }

        [DataMember(Name = "loanVaLoanProcedureType")]
        public string LoanVaLoanProcedureType { get; set; }

        [DataMember(Name = "loanVaRateReductionInitialComputationTotalAmount")]
        public decimal? LoanVaRateReductionInitialComputationTotalAmount  { get; set; }

        [DataMember(Name = "loanVaResidualIncomeAmount")]
        public decimal? LoanVaResidualIncomeAmount  { get; set; }

        [DataMember(Name = "lockConfirms")]
        public List<LockConfirmContract> LockConfirms { get; set; }

        [DataMember(Name = "lockDenials")]
        public List<LockDenialContract> LockDenials { get; set; }

        [DataMember(Name = "lockRequests")]
        public List<LockRequestContract> LockRequests { get; set; }

        [DataMember(Name = "logEntryLogs")]
        public List<LogEntryLogContract> LogEntryLogs { get; set; }

        [DataMember(Name = "ltv")]
        public decimal? Ltv  { get; set; }

        [DataMember(Name = "ltvPropertyValue")]
        public decimal? LtvPropertyValue  { get; set; }

        [DataMember(Name = "masterCommitmentNumber")]
        public string MasterCommitmentNumber { get; set; }

        [DataMember(Name = "maturityDate")]
        public string MaturityDate { get; set; }

        [DataMember(Name = "maxBackRatio")]
        public decimal? MaxBackRatio  { get; set; }

        [DataMember(Name = "maxFrontRatio")]
        public decimal? MaxFrontRatio  { get; set; }

        [DataMember(Name = "mcaw")]
        public McawContract Mcaw { get; set; }

        [DataMember(Name = "mersNumber")]
        public string MersNumber { get; set; }

        [DataMember(Name = "mersNumberRegistrationDate")]
        public string MersNumberRegistrationDate { get; set; }

        [DataMember(Name = "miAndFundingFeeFinancedAmount")]
        public decimal? MiAndFundingFeeFinancedAmount  { get; set; }

        [DataMember(Name = "miAndFundingFeeTotalAmount")]
        public decimal? MiAndFundingFeeTotalAmount  { get; set; }

        [DataMember(Name = "milestoneApprovedDate")]
        public string MilestoneApprovedDate { get; set; }

        [DataMember(Name = "milestoneApprovedDueDate")]
        public string MilestoneApprovedDueDate { get; set; }

        [DataMember(Name = "milestoneCompletedDate")]
        public string MilestoneCompletedDate { get; set; }

        [DataMember(Name = "milestoneCompletedDueDate")]
        public string MilestoneCompletedDueDate { get; set; }

        [DataMember(Name = "milestoneCurrentDate")]
        public string MilestoneCurrentDate { get; set; }

        [DataMember(Name = "milestoneCurrentName")]
        public string MilestoneCurrentName { get; set; }

        [DataMember(Name = "milestoneDocSignedDate")]
        public string MilestoneDocSignedDate { get; set; }

        [DataMember(Name = "milestoneDocSignedDueDate")]
        public string MilestoneDocSignedDueDate { get; set; }

        [DataMember(Name = "milestoneDuration")]
        public int? MilestoneDuration  { get; set; }

        [DataMember(Name = "milestoneFileStartedDate")]
        public string MilestoneFileStartedDate { get; set; }

        [DataMember(Name = "milestoneFreeRoles")]
        public List<MilestoneFreeRoleContract> MilestoneFreeRoles { get; set; }

        [DataMember(Name = "milestoneFundedDate")]
        public string MilestoneFundedDate { get; set; }

        [DataMember(Name = "milestoneFundedDueDate")]
        public string MilestoneFundedDueDate { get; set; }

        [DataMember(Name = "milestoneHistoryLogs")]
        public List<MilestoneHistoryLogContract> MilestoneHistoryLogs { get; set; }

        [DataMember(Name = "milestones")]
        public List<MilestoneContract> Milestones { get; set; }

        [DataMember(Name = "milestoneProcessedDate")]
        public string MilestoneProcessedDate { get; set; }

        [DataMember(Name = "milestoneStage")]
        public string MilestoneStage { get; set; }

        [DataMember(Name = "milestoneSubmittedDate")]
        public string MilestoneSubmittedDate { get; set; }

        [DataMember(Name = "milestoneSubmittedDueDate")]
        public string MilestoneSubmittedDueDate { get; set; }

        [DataMember(Name = "milestoneTasks")]
        public List<MilestoneTaskContract> MilestoneTasks { get; set; }

        [DataMember(Name = "milestoneTemplateLogs")]
        public List<MilestoneTemplateLogContract> MilestoneTemplateLogs { get; set; }

        [DataMember(Name = "documentOrders")]
        public List<DocumentOrderContract> DocumentOrders { get; set; }

        [DataMember(Name = "mipBorrowerPaidInCashAmount")]
        public decimal? MipBorrowerPaidInCashAmount  { get; set; }

        [DataMember(Name = "mipPaidInCashAmount")]
        public decimal? MipPaidInCashAmount  { get; set; }

        [DataMember(Name = "miscellaneous")]
        public MiscellaneousContract Miscellaneous { get; set; }

        [DataMember(Name = "monthlyPiPaymentAmountForLe1andCd1")]
        public decimal? MonthlyPiPaymentAmountForLe1andCd1  { get; set; }

        [DataMember(Name = "mortgageInsurancePremiumFhaRefundAmount")]
        public decimal? MortgageInsurancePremiumFhaRefundAmount  { get; set; }

        [DataMember(Name = "mortgageInsurancePremiumUpfrontFactorPercent")]
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent  { get; set; }

        [DataMember(Name = "mortgageType")]
        public string MortgageType { get; set; }

        [DataMember(Name = "msaIdentifier")]
        public string MsaIdentifier { get; set; }

        [DataMember(Name = "netTangibleBenefit")]
        public NetTangibleBenefitContract NetTangibleBenefit { get; set; }

        [DataMember(Name = "newFirstMortgageAmount")]
        public decimal? NewFirstMortgageAmount  { get; set; }

        [DataMember(Name = "newHelocCreditorName")]
        public string NewHelocCreditorName { get; set; }

        [DataMember(Name = "newVestingNboAlert", EmitDefaultValue = false)]
        public bool? NewVestingNboAlert { get; set; }

        [DataMember(Name = "newHelocMonthlyPayment")]
        public decimal? NewHelocMonthlyPayment  { get; set; }

        [DataMember(Name = "newMortgageCreditorName")]
        public string NewMortgageCreditorName { get; set; }

        [DataMember(Name = "newMortgageMonthlyPayment")]
        public decimal? NewMortgageMonthlyPayment  { get; set; }

        [DataMember(Name = "newSubordinateCreditorName")]
        public string NewSubordinateCreditorName { get; set; }

        [DataMember(Name = "newSubordinateMonthlyPayment")]
        public decimal? NewSubordinateMonthlyPayment  { get; set; }

        [DataMember(Name = "nmlsLoanOriginatorId")]
        public string NmlsLoanOriginatorId { get; set; }

        [DataMember(Name = "noClosingCostOption")]
        public bool? NoClosingCostOption { get; set; }

        [DataMember(Name = "nonBorrowingOwners")]
        public List<NonBorrowingOwnerContract> NonBorrowingOwners { get; set; }

        [DataMember(Name = "nonVols")]
        public List<NonVolContract> NonVols { get; set; }

        [DataMember(Name = "investorDeliveryLogs")]
        public List<InvestorDeliveryLogContract> InvestorDeliveryLogs { get; set; }

        [DataMember(Name = "notRequiredForPurchaseSaleOrRefinance")]
        public bool? NotRequiredForPurchaseSaleOrRefinance { get; set; }

        [DataMember(Name = "notRequiredForSettlementOfYourLoan")]
        public bool? NotRequiredForSettlementOfYourLoan { get; set; }

        [DataMember(Name = "occupancyType")]
        public string OccupancyType { get; set; }

        [DataMember(Name = "openingDocsInvestorCode")]
        public string OpeningDocsInvestorCode { get; set; }

        [DataMember(Name = "openingDocsLoanProgramType")]
        public string OpeningDocsLoanProgramType { get; set; }

        [DataMember(Name = "openingDocsPlanDescription")]
        public string OpeningDocsPlanDescription { get; set; }

        [DataMember(Name = "openingDocsPlanId")]
        public string OpeningDocsPlanId { get; set; }

        [DataMember(Name = "openingDocsProgramCode")]
        public string OpeningDocsProgramCode { get; set; }

        [DataMember(Name = "openingDocsStackingOrder")]
        public string OpeningDocsStackingOrder { get; set; }

        [DataMember(Name = "organizationCode")]
        public string OrganizationCode { get; set; }

        [DataMember(Name = "originationDate")]
        public string OriginationDate { get; set; }

        [DataMember(Name = "originatorAddressLineText")]
        public string OriginatorAddressLineText { get; set; }

        [DataMember(Name = "paymentDeferredFirstFiveYears")]
        public bool? PaymentDeferredFirstFiveYears { get; set; }

        [DataMember(Name = "affordableLoan")]
        public bool? AffordableLoan { get; set; }

        [DataMember(Name = "totalAdditionalMortgages")]
        public decimal? TotalAdditionalMortgages  { get; set; }

        [DataMember(Name = "originatorAddressUnitDesignatorType")]
        public string OriginatorAddressUnitDesignatorType { get; set; }

        [DataMember(Name = "originatorAddressUnitIdentifier")]
        public string OriginatorAddressUnitIdentifier { get; set; }

        [DataMember(Name = "originatorFirstName")]
        public string OriginatorFirstName { get; set; }

        [DataMember(Name = "originatorLastName")]
        public string OriginatorLastName { get; set; }

        [DataMember(Name = "originatorMiddleName")]
        public string OriginatorMiddleName { get; set; }

        [DataMember(Name = "originatorSuffixName")]
        public string OriginatorSuffixName { get; set; }

        [DataMember(Name = "otherAmortizationTypeDescription")]
        public string OtherAmortizationTypeDescription { get; set; }

        [DataMember(Name = "otherMortgageTypeDescription")]
        public string OtherMortgageTypeDescription { get; set; }

        [DataMember(Name = "otherPaidClosingCostsAmount")]
        public decimal? OtherPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "overwireAmount")]
        public decimal? OverwireAmount  { get; set; }

        [DataMember(Name = "paceLoanPayoffAmount", EmitDefaultValue = false)]
        public double? PaceLoanPayoffAmount { get; set; }

        [DataMember(Name = "paymentScheduleCalcRequiredIndicator")]
        public bool? PaymentScheduleCalcRequiredIndicator { get; set; }

        [DataMember(Name = "percentageOfOwnership")]
        public string PercentageOfOwnership { get; set; }

        [DataMember(Name = "percentageOwnershipInterest")]
        public decimal? PercentageOwnershipInterest  { get; set; }

        [DataMember(Name = "pmiIndicator")]
        public bool? PmiIndicator { get; set; }

        [DataMember(Name = "postClosingConditions")]
        public List<PostClosingConditionContract> PostClosingConditions { get; set; }

        [DataMember(Name = "preliminaryConditions")]
        public List<PreliminaryConditionContract> PreliminaryConditions { get; set; }

        [DataMember(Name = "prequalification")]
        public PrequalificationContract Prequalification { get; set; }

        [DataMember(Name = "principalAndInterestMonthlyPaymentAmount")]
        public decimal? PrincipalAndInterestMonthlyPaymentAmount  { get; set; }

        [DataMember(Name = "print2003Application")]
        public string Print2003Application { get; set; }

        [DataMember(Name = "printLogs")]
        public List<PrintLogContract> PrintLogs { get; set; }

        [DataMember(Name = "printUliOnUrla")]
        public bool? PrintUliOnUrla { get; set; }

        [DataMember(Name = "privacyPolicy")]
        public PrivacyPolicyContract PrivacyPolicy { get; set; }

        [DataMember(Name = "profitManagement")]
        public ProfitManagementContract ProfitManagement { get; set; }

        [DataMember(Name = "property")]
        public PropertyContract Property { get; set; }

        [DataMember(Name = "propertyAppraisedValueAmount")]
        public int? PropertyAppraisedValueAmount  { get; set; }

        [DataMember(Name = "propertyEnergyEfficientHomeIndicator")]
        public bool? PropertyEnergyEfficientHomeIndicator { get; set; }

        [DataMember(Name = "propertyEstimatedValueAmount")]
        public int? PropertyEstimatedValueAmount  { get; set; }

        [DataMember(Name = "proposedDuesAmount")]
        public string ProposedDuesAmount { get; set; }

        [DataMember(Name = "proposedFirstMortgageAmount")]
        public decimal? ProposedFirstMortgageAmount  { get; set; }

        [DataMember(Name = "proposedGroundRentAmount")]
        public decimal? ProposedGroundRentAmount  { get; set; }

        [DataMember(Name = "proposedHazardInsuranceAmount")]
        public string ProposedHazardInsuranceAmount { get; set; }

        [DataMember(Name = "proposedMortgageInsuranceAmount")]
        public string ProposedMortgageInsuranceAmount { get; set; }

        [DataMember(Name = "proposedOtherAmount")]
        public decimal? ProposedOtherAmount  { get; set; }

        [DataMember(Name = "proposedOtherMortgagesAmount")]
        public decimal? ProposedOtherMortgagesAmount  { get; set; }

        [DataMember(Name = "proposedRealEstateTaxesAmount")]
        public string ProposedRealEstateTaxesAmount { get; set; }

        [DataMember(Name = "purchaseCredits")]
        public List<PurchaseCreditContract> PurchaseCredits { get; set; }

        [DataMember(Name = "purchasePriceAmount")]
        public decimal? PurchasePriceAmount  { get; set; }

        [DataMember(Name = "rateLock")]
        public RateLockContract RateLock { get; set; }

        [DataMember(Name = "referralAddress")]
        public string ReferralAddress { get; set; }

        [DataMember(Name = "referralCity")]
        public string ReferralCity { get; set; }

        [DataMember(Name = "referralFeeAmount")]
        public decimal? ReferralFeeAmount  { get; set; }

        [DataMember(Name = "referralPostalCode")]
        public string ReferralPostalCode { get; set; }

        [DataMember(Name = "referralSource")]
        public string ReferralSource { get; set; }

        [DataMember(Name = "referralState")]
        public string ReferralState { get; set; }

        [DataMember(Name = "refinanceIncludingDebtsToBePaidOffAmount")]
        public decimal? RefinanceIncludingDebtsToBePaidOffAmount  { get; set; }

        [DataMember(Name = "registrationLogs")]
        public List<RegistrationLogContract> RegistrationLogs { get; set; }

        [DataMember(Name = "regulationZ")]
        public RegulationZContract RegulationZ { get; set; }

        [DataMember(Name = "rentalEstimatedNetMonthlyRentAmount")]
        public decimal? RentalEstimatedNetMonthlyRentAmount  { get; set; }

        [DataMember(Name = "rentalIncomeSectionIndicator")]
        public bool? RentalIncomeSectionIndicator { get; set; }

        [DataMember(Name = "repurchaseCostAmount")]
        public decimal? RepurchaseCostAmount  { get; set; }

        [DataMember(Name = "repurchaseDate")]
        public string RepurchaseDate { get; set; }

        [DataMember(Name = "requestedInterestRatePercent")]
        public decimal? RequestedInterestRatePercent  { get; set; }

        [DataMember(Name = "requestedInterestRatePercentUi")]
        public string RequestedInterestRatePercentUi { get; set; }

        [DataMember(Name = "salesConcessionAmount")]
        public decimal? SalesConcessionAmount  { get; set; }

        [DataMember(Name = "secondSubordinateAmount")]
        public decimal? SecondSubordinateAmount  { get; set; }

        [DataMember(Name = "section32")]
        public Section32Contract Section32 { get; set; }

        [DataMember(Name = "selectedHomeCounselingProvider")]
        public SelectedHomeCounselingProviderContract SelectedHomeCounselingProvider { get; set; }

        [DataMember(Name = "sectionOfActType")]
        public string SectionOfActType { get; set; }

        [DataMember(Name = "sellerPaidClosingCostsAmount")]
        public decimal? SellerPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "serviceProviderAdditionalInfo")]
        public string ServiceProviderAdditionalInfo { get; set; }

        [DataMember(Name = "serviceProviderContacts")]
        public List<ServiceProviderContract> ServiceProviderContacts { get; set; }

        [DataMember(Name = "serviceProviderDateIssued")]
        public string ServiceProviderDateIssued { get; set; }

        [DataMember(Name = "servicingDisclosure")]
        public ServicingDisclosureContract ServicingDisclosure { get; set; }

        [DataMember(Name = "setForSettlementServicesOfAnAttorney")]
        public bool? SetForSettlementServicesOfAnAttorney { get; set; }

        [DataMember(Name = "setForTheSettlementServicesListed")]
        public bool? SetForTheSettlementServicesListed { get; set; }

        [DataMember(Name = "settlementServiceCharges")]
        public List<SettlementServiceChargeContract> SettlementServiceCharges { get; set; }

        [DataMember(Name = "shipping")]
        public ShippingContract Shipping { get; set; }

        [DataMember(Name = "simpleRefinanceType")]
        public bool? SimpleRefinanceType { get; set; }

        [DataMember(Name = "startingAdjPrice")]
        public decimal? StartingAdjPrice  { get; set; }

        [DataMember(Name = "startingAdjRate")]
        public decimal? StartingAdjRate  { get; set; }

        [DataMember(Name = "stateDisclosure")]
        public StateDisclosureContract StateDisclosure { get; set; }

        [DataMember(Name = "statementCreditDenial")]
        public StatementCreditDenialContract StatementCreditDenial { get; set; }

        [DataMember(Name = "statusOnlineLogs")]
        public List<StatusOnlineLogContract> StatusOnlineLogs { get; set; }

        [DataMember(Name = "subjectPropertyGrossRentalIncomeAmount")]
        public decimal? SubjectPropertyGrossRentalIncomeAmount  { get; set; }

        [DataMember(Name = "subjectPropertyOccupancyPercent")]
        public decimal? SubjectPropertyOccupancyPercent  { get; set; }

        [DataMember(Name = "subordinateLienAmount")]
        public decimal? SubordinateLienAmount  { get; set; }

        [DataMember(Name = "systemIdGuid")]
        public string SystemIdGuid { get; set; }

        [DataMember(Name = "targetCltv")]
        public decimal? TargetCltv  { get; set; }

        [DataMember(Name = "targetHcltv")]
        public decimal? TargetHcltv  { get; set; }

        [DataMember(Name = "tilApplicationDate")]
        public string TilApplicationDate { get; set; }

        [DataMember(Name = "titleHolderName1")]
        public string TitleHolderName1 { get; set; }

        [DataMember(Name = "titleHolderName2")]
        public string TitleHolderName2 { get; set; }

        [DataMember(Name = "tltv")]
        public decimal? Tltv  { get; set; }

        [DataMember(Name = "totalClosingCostsAmount")]
        public decimal? TotalClosingCostsAmount  { get; set; }

        [DataMember(Name = "totalDeductionsAmount")]
        public decimal? TotalDeductionsAmount  { get; set; }

        [DataMember(Name = "totalFeesCostAmount")]
        public decimal? TotalFeesCostAmount  { get; set; }

        [DataMember(Name = "totalFeesCreditAmount")]
        public decimal? TotalFeesCreditAmount  { get; set; }

        [DataMember(Name = "totalNonborrowerPaidClosingCostsAmount")]
        public decimal? TotalNonborrowerPaidClosingCostsAmount  { get; set; }

        [DataMember(Name = "totalPaidOutsideClosingAmount")]
        public decimal? TotalPaidOutsideClosingAmount  { get; set; }

        [DataMember(Name = "totalPaidToBrokerAmount")]
        public decimal? TotalPaidToBrokerAmount  { get; set; }

        [DataMember(Name = "totalWireTransferAmount")]
        public decimal? TotalWireTransferAmount  { get; set; }

        [DataMember(Name = "tpo")]
        public TpoContract Tpo { get; set; }

        [DataMember(Name = "tql")]
        public TqlContract Tql { get; set; }

        [DataMember(Name = "trustAccount")]
        public TrustAccountContract TrustAccount { get; set; }

        [DataMember(Name = "tsum")]
        public TsumContract Tsum { get; set; }

        [DataMember(Name = "twelveMonthMortgageRentalHistoryIndicator")]
        public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }

        [DataMember(Name = "ucdFnmaCasefileStatusType")]
        public string UcdFnmaCasefileStatusType { get; set; }

        [DataMember(Name = "ucdFnmaCasefileWarningIndicator")]
        public string UcdFnmaCasefileWarningIndicator { get; set; }

        [DataMember(Name = "ucdLoanClsMatchStatusType")]
        public string UcdLoanClsMatchStatusType { get; set; }

        [DataMember(Name = "ucdOrigSubmissionDate")]
        public string UcdOrigSubmissionDate { get; set; }

        [DataMember(Name = "ucdSubmissionDate")]
        public string UcdSubmissionDate { get; set; }

        [DataMember(Name = "uldd")]
        public UlddContract Uldd { get; set; }

        [DataMember(Name = "underwriterSummary")]
        public UnderwriterSummaryContract UnderwriterSummary { get; set; }

        [DataMember(Name = "underwritingConditions")]
        public List<UnderwritingConditionContract> UnderwritingConditions { get; set; }

        [DataMember(Name = "underwritingEscrowIndicator")]
        public bool? UnderwritingEscrowIndicator { get; set; }

        [DataMember(Name = "undiscountedRate")]
        public decimal? UndiscountedRate  { get; set; }

        [DataMember(Name = "urlaLoanIdentifier")]
        public string UrlaLoanIdentifier { get; set; }

        [DataMember(Name = "urlPage4Comments")]
        public string UrlPage4Comments { get; set; }

        [DataMember(Name = "usda")]
        public UsdaContract Usda { get; set; }

        [DataMember(Name = "usdaGovernmentLoanType")]
        public string UsdaGovernmentLoanType { get; set; }

        [DataMember(Name = "use2018DiIndicator")]
        public bool? Use2018DiIndicator { get; set; }

        [DataMember(Name = "useNewHudIndicator")]
        public bool? UseNewHudIndicator { get; set; }

        [DataMember(Name = "useNew2015FormsIndicator")]
        public string UseNew2015FormsIndicator { get; set; }

        [DataMember(Name = "vaEntitlementAmount")]
        public decimal? VaEntitlementAmount  { get; set; }

        [DataMember(Name = "vaLoanData")]
        public VaLoanDataContract VaLoanData { get; set; }

        [DataMember(Name = "valuationUsed")]
        public decimal? ValuationUsed  { get; set; }

        [DataMember(Name = "virtualFields")]
        public object VirtualFields { get; set; }

        [DataMember(Name = "websiteId")]
        public string WebsiteId { get; set; }

        [DataMember(Name = "alertChangeCircumstanceApplyLecd")]
        public string AlertChangeCircumstanceApplyLecd { get; set; }

        [DataMember(Name = "serverDateTimeDdmApplied")]
        public string ServerDateTimeDdmApplied { get; set; }

        [DataMember(Name = "proposedHousingExpenseTotal")]
        public decimal? ProposedHousingExpenseTotal  { get; set; }

        [DataMember(Name = "unimprovedEstimatedValue")]
        public int? UnimprovedEstimatedValue  { get; set; }

        [DataMember(Name = "unimprovedAppraisedValue")]
        public int? UnimprovedAppraisedValue  { get; set; }

        [DataMember(Name = "closedEndPrimaryMortgageLoanAmount")]
        public decimal? ClosedEndPrimaryMortgageLoanAmount  { get; set; }

        [DataMember(Name = "closedEndSubordinateMortgageLoanAmount")]
        public decimal? ClosedEndSubordinateMortgageLoanAmount  { get; set; }

        [DataMember(Name = "ucdCaseFileId")]
        public string UcdCaseFileId { get; set; }

        [DataMember(Name = "collateralTracking")]
        public CollateralTrackingContract CollateralTracking { get; set; }

        [DataMember(Name = "borrCommunityPropertyStateResidentIndicator")]
        public bool? BorrCommunityPropertyStateResidentIndicator { get; set; }

        [DataMember(Name = "communityPropertyStateResidentIndicator")]
        public bool? CommunityPropertyStateResidentIndicator { get; set; }

        [DataMember(Name = "conversionOfContractForDeedIndicator")]
        public bool? ConversionOfContractForDeedIndicator { get; set; }

        [DataMember(Name = "renovationLoanIndicator")]
        public bool? RenovationLoanIndicator { get; set; }

        [DataMember(Name = "constructionLoanIndicator")]
        public bool? ConstructionLoanIndicator { get; set; }

        [DataMember(Name = "constructionToPermanentClosingType")]
        public string ConstructionToPermanentClosingType { get; set; }

        [DataMember(Name = "propertyExistingCleanEnergyLienIndicator")]
        public bool? PropertyExistingCleanEnergyLienIndicator { get; set; }

        [DataMember(Name = "titleWillBeFullName")]
        public string TitleWillBeFullName { get; set; }

        [DataMember(Name = "titleHolderFullName")]
        public string TitleHolderFullName { get; set; }

        [DataMember(Name = "relationshipVestingType")]
        public string RelationshipVestingType { get; set; }

        [DataMember(Name = "relationshipVestingTypeOtherDescription")]
        public string RelationshipVestingTypeOtherDescription { get; set; }

        [DataMember(Name = "trustClassificationType")]
        public string TrustClassificationType { get; set; }

        [DataMember(Name = "nativeAmericanLandsType")]
        public string NativeAmericanLandsType { get; set; }

        [DataMember(Name = "nativeAmericanLandsTypeOtherDescription")]
        public string NativeAmericanLandsTypeOtherDescription { get; set; }

        [DataMember(Name = "productDescription")]
        public string ProductDescription { get; set; }

        [DataMember(Name = "supplementalPropertyInsuranceAmount")]
        public decimal? SupplementalPropertyInsuranceAmount  { get; set; }

        [DataMember(Name = "totalNonSubjectPropertyDebtsToBePaidOffAmount")]
        public decimal? TotalNonSubjectPropertyDebtsToBePaidOffAmount  { get; set; }

        [DataMember(Name = "borrEstimatedClosingCostsAmount")]
        public decimal? BorrEstimatedClosingCostsAmount  { get; set; }

        [DataMember(Name = "totalSubordinateFinancingAmount")]
        public decimal? TotalSubordinateFinancingAmount  { get; set; }

        [DataMember(Name = "urlaTotalMortgageLoansAmount")]
        public decimal? UrlaTotalMortgageLoansAmount  { get; set; }

        [DataMember(Name = "urlaTotalOtherCreditsAmount")]
        public decimal? UrlaTotalOtherCreditsAmount  { get; set; }

        [DataMember(Name = "totalOfGiftsGrants")]
        public decimal? TotalOfGiftsGrants  { get; set; }

        [DataMember(Name = "totalOtherAssetToLoan")]
        public decimal? TotalOtherAssetToLoan  { get; set; }

        [DataMember(Name = "urlaTotalCreditsAmount")]
        public decimal? UrlaTotalCreditsAmount  { get; set; }

        [DataMember(Name = "housingCounselingAgency")]
        public string HousingCounselingAgency { get; set; }

        [DataMember(Name = "ownershipCompletedDate")]
        public string OwnershipCompletedDate { get; set; }

        [DataMember(Name = "borrowerFullName")]
        public string BorrowerFullName { get; set; }

        [DataMember(Name = "housingCounselingAgencyFullName")]
        public string HousingCounselingAgencyFullName { get; set; }

        [DataMember(Name = "counselingCompletedDate")]
        public string CounselingCompletedDate { get; set; }

        [DataMember(Name = "counselingBorrowerFullName")]
        public string CounselingBorrowerFullName { get; set; }

        [DataMember(Name = "refinanceCashOutDeterminationType")]
        public string RefinanceCashOutDeterminationType { get; set; }

        [DataMember(Name = "governmentRefinanceType")]
        public string GovernmentRefinanceType { get; set; }

        [DataMember(Name = "governmentRefinanceTypeOtherDescription")]
        public string GovernmentRefinanceTypeOtherDescription { get; set; }

        [DataMember(Name = "projectLegalStructureType")]
        public string ProjectLegalStructureType { get; set; }

        [DataMember(Name = "condominiumIndicator")]
        public bool? CondominiumIndicator { get; set; }

        [DataMember(Name = "cooperativeIndicator")]
        public bool? CooperativeIndicator { get; set; }

        [DataMember(Name = "pudIndicator")]
        public bool? PudIndicator { get; set; }

        [DataMember(Name = "notInProjectIndicator")]
        public bool? NotInProjectIndicator { get; set; }

        [DataMember(Name = "printLenderPages")]
        public bool? PrintLenderPages { get; set; }

        [DataMember(Name = "lotAcquiredDate")]
        public string LotAcquiredDate { get; set; }

        [DataMember(Name = "additionalLoanDoesNotApply")]
        public bool? AdditionalLoanDoesNotApply { get; set; }

        [DataMember(Name = "printUliAndLoanNoUrla")]
        public bool? PrintUliAndLoanNoUrla { get; set; }

        [DataMember(Name = "negativeAmortization")]
        public bool? NegativeAmortization { get; set; }

        [DataMember(Name = "prepaymentPenaltyTerm")]
        public bool? PrepaymentPenaltyTerm { get; set; }

        [DataMember(Name = "temporaryOrInitialInterestRateBuydown")]
        public bool? TemporaryOrInitialInterestRateBuydown { get; set; }

        [DataMember(Name = "loanFeaturesOtherIndicator")]
        public bool? LoanFeaturesOtherIndicator { get; set; }

        [DataMember(Name = "temporaryBuydown")]
        public string TemporaryBuydown { get; set; }

        [DataMember(Name = "expectedBorrowerCount")]
        public int? ExpectedBorrowerCount  { get; set; }

        [DataMember(Name = "useEnhancedConditionIndicator")]
        public bool? UseEnhancedConditionIndicator { get; set; }

        [DataMember(Name = "workFlowId")]
        public string WorkFlowId { get; set; }

        [DataMember(Name = "complianceReviewType")]
        public bool? ComplianceReviewType { get; set; }

        [DataMember(Name = "mersOrgId")]
        public string MersOrgId { get; set; }

        [DataMember(Name = "mom")]
        public bool? Mom { get; set; }

        [DataMember(Name = "settlementAgentDisbursedFundsDate")]
        public string SettlementAgentDisbursedFundsDate { get; set; }

        [DataMember(Name = "enoteLenderName")]
        public string EnoteLenderName { get; set; }

        [DataMember(Name = "enoteMersMinNumber")]
        public string EnoteMersMinNumber { get; set; }

        [DataMember(Name = "enoteRegisteredDateTime")]
        public string EnoteRegisteredDateTime { get; set; }

        [DataMember(Name = "enoteAuthoritativeCopy")]
        public bool? EnoteAuthoritativeCopy { get; set; }

        [DataMember(Name = "enoteControllerOrgId")]
        public string EnoteControllerOrgId { get; set; }

        [DataMember(Name = "enoteControllerOrgName")]
        public string EnoteControllerOrgName { get; set; }

        [DataMember(Name = "enoteLocationOrgId")]
        public string EnoteLocationOrgId { get; set; }

        [DataMember(Name = "enoteLocationOrgName")]
        public string EnoteLocationOrgName { get; set; }

        [DataMember(Name = "enoteMasterServiceOrgId")]
        public string EnoteMasterServiceOrgId { get; set; }

        [DataMember(Name = "enoteMasterServiceOrgName")]
        public string EnoteMasterServiceOrgName { get; set; }

        [DataMember(Name = "enoteSubservicerOrgId")]
        public string EnoteSubservicerOrgId { get; set; }

        [DataMember(Name = "enoteSubservicerOrgName")]
        public string EnoteSubservicerOrgName { get; set; }

        [DataMember(Name = "enoteSecuredPartyOrgId")]
        public string EnoteSecuredPartyOrgId { get; set; }

        [DataMember(Name = "enoteSecuredPartyOrgName")]
        public string EnoteSecuredPartyOrgName { get; set; }

        [DataMember(Name = "enoteSecuredPartyDelagateeOrgId")]
        public string EnoteSecuredPartyDelagateeOrgId { get; set; }

        [DataMember(Name = "enoteSecuredPartyDelagateeOrgName")]
        public string EnoteSecuredPartyDelagateeOrgName { get; set; }

        [DataMember(Name = "enoteDelagateeForTransferOrgId")]
        public string EnoteDelagateeForTransferOrgId { get; set; }

        [DataMember(Name = "enoteDelagateeForTransferOrgName")]
        public string EnoteDelagateeForTransferOrgName { get; set; }

        [DataMember(Name = "enoteTransferEffectiveDate")]
        public string EnoteTransferEffectiveDate { get; set; }

        [DataMember(Name = "enoteTransferStatus")]
        public string EnoteTransferStatus { get; set; }

        [DataMember(Name = "isLoanAmountRounding")]
        public bool? IsLoanAmountRounding { get; set; }

        [DataMember(Name = "conditions")]
        public List<EnhancedConditionContract> Conditions { get; set; }

        [DataMember(Name = "documents")]
        public List<DocumentContract> Documents { get; set; }

        [DataMember(Name = "aiq")]
        public AiqContract Aiq { get; set; }

        [DataMember(Name = "prequalCreditReportIndicator")]
        public bool? PrequalCreditReportIndicator { get; set; }

    }
}
