using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocument
	{
		[DataMember(Name="additionalLienHolderAddress", EmitDefaultValue=false)]
		public string AdditionalLienHolderAddress { get; set; }

		[DataMember(Name="additionalLienHolderAddressCity", EmitDefaultValue=false)]
		public string AdditionalLienHolderAddressCity { get; set; }

		[DataMember(Name="additionalLienHolderAddressPostalCode", EmitDefaultValue=false)]
		public string AdditionalLienHolderAddressPostalCode { get; set; }

		[DataMember(Name="additionalLienHolderAddressState", EmitDefaultValue=false)]
		public string AdditionalLienHolderAddressState { get; set; }

		[DataMember(Name="additionalLienHolderName", EmitDefaultValue=false)]
		public string AdditionalLienHolderName { get; set; }

		[DataMember(Name="additionalOriginalPincipalAmountSecured", EmitDefaultValue=false)]
		public double? AdditionalOriginalPincipalAmountSecured { get; set; }

		[DataMember(Name="additionalSigVerbiageType", EmitDefaultValue=false)]
		public string AdditionalSigVerbiageType { get; set; }

		[DataMember(Name="additionalStateDisclosures", EmitDefaultValue=false)]
		public List<LoanContractClosingDocumentAdditionalStateDisclosures> AdditionalStateDisclosures { get; set; }

		[DataMember(Name="affectedByInterest", EmitDefaultValue=false)]
		public bool? AffectedByInterest { get; set; }

		[DataMember(Name="alternateLender", EmitDefaultValue=false)]
		public string AlternateLender { get; set; }

		[DataMember(Name="altLenderId", EmitDefaultValue=false)]
		public string AltLenderId { get; set; }

		[DataMember(Name="antiSteeringLoanOptions", EmitDefaultValue=false)]
		public List<LoanContractClosingDocumentAntiSteeringLoanOptions> AntiSteeringLoanOptions { get; set; }

		[DataMember(Name="areAbleToServiceIndicator", EmitDefaultValue=false)]
		public string AreAbleToServiceIndicator { get; set; }

		[DataMember(Name="associatedDocumentNumber", EmitDefaultValue=false)]
		public string AssociatedDocumentNumber { get; set; }

		[DataMember(Name="beneficiaries", EmitDefaultValue=false)]
		public string Beneficiaries { get; set; }

		[DataMember(Name="borrowerConsentType1", EmitDefaultValue=false)]
		public bool? BorrowerConsentType1 { get; set; }

		[DataMember(Name="borrowerConsentType2", EmitDefaultValue=false)]
		public bool? BorrowerConsentType2 { get; set; }

		[DataMember(Name="borrowerOrganizationType1", EmitDefaultValue=false)]
		public string BorrowerOrganizationType1 { get; set; }

		[DataMember(Name="borrowerOrganizationType2", EmitDefaultValue=false)]
		public string BorrowerOrganizationType2 { get; set; }

		[DataMember(Name="borrowerOrganizedUnderTheLawsOfJurisdictionName1", EmitDefaultValue=false)]
		public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get; set; }

		[DataMember(Name="borrowerOrganizedUnderTheLawsOfJurisdictionName2", EmitDefaultValue=false)]
		public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get; set; }

		[DataMember(Name="borrowerTaxIdentificationNumberIdentifier1", EmitDefaultValue=false)]
		public string BorrowerTaxIdentificationNumberIdentifier1 { get; set; }

		[DataMember(Name="borrowerTaxIdentificationNumberIdentifier2", EmitDefaultValue=false)]
		public string BorrowerTaxIdentificationNumberIdentifier2 { get; set; }

		[DataMember(Name="borrowerTrustAmendedDateOrYear1", EmitDefaultValue=false)]
		public string BorrowerTrustAmendedDateOrYear1 { get; set; }

		[DataMember(Name="borrowerTrustAmendedDateOrYear2", EmitDefaultValue=false)]
		public string BorrowerTrustAmendedDateOrYear2 { get; set; }

		[DataMember(Name="borrowerTrustDateOrYear1", EmitDefaultValue=false)]
		public string BorrowerTrustDateOrYear1 { get; set; }

		[DataMember(Name="borrowerTrustDateOrYear2", EmitDefaultValue=false)]
		public string BorrowerTrustDateOrYear2 { get; set; }

		[DataMember(Name="borrowerUnparsedName1", EmitDefaultValue=false)]
		public string BorrowerUnparsedName1 { get; set; }

		[DataMember(Name="borrowerUnparsedName2", EmitDefaultValue=false)]
		public string BorrowerUnparsedName2 { get; set; }

		[DataMember(Name="brokerAuthorizedRepresentativeTitle", EmitDefaultValue=false)]
		public string BrokerAuthorizedRepresentativeTitle { get; set; }

		[DataMember(Name="brokerCompensationMethod", EmitDefaultValue=false)]
		public string BrokerCompensationMethod { get; set; }

		[DataMember(Name="brokerFeeRefundConditions1", EmitDefaultValue=false)]
		public string BrokerFeeRefundConditions1 { get; set; }

		[DataMember(Name="brokerFeeRefundConditions2", EmitDefaultValue=false)]
		public string BrokerFeeRefundConditions2 { get; set; }

		[DataMember(Name="brokerFeeRefundConditions3", EmitDefaultValue=false)]
		public string BrokerFeeRefundConditions3 { get; set; }

		[DataMember(Name="brokerForPlacingLoan", EmitDefaultValue=false)]
		public string BrokerForPlacingLoan { get; set; }

		[DataMember(Name="brokerInterestRateEffect", EmitDefaultValue=false)]
		public string BrokerInterestRateEffect { get; set; }

		[DataMember(Name="brokerLenderRelationship", EmitDefaultValue=false)]
		public string BrokerLenderRelationship { get; set; }

		[DataMember(Name="brokerLicenseNumberIdentifier", EmitDefaultValue=false)]
		public string BrokerLicenseNumberIdentifier { get; set; }

		[DataMember(Name="brokerNameAsLicensed", EmitDefaultValue=false)]
		public string BrokerNameAsLicensed { get; set; }

		[DataMember(Name="brokerTaxIdentificationNumberIdentifier", EmitDefaultValue=false)]
		public string BrokerTaxIdentificationNumberIdentifier { get; set; }

		[DataMember(Name="brokerWithLenders", EmitDefaultValue=false)]
		public string BrokerWithLenders { get; set; }

		[DataMember(Name="cashCheckFromBorrower", EmitDefaultValue=false)]
		public double? CashCheckFromBorrower { get; set; }

		[DataMember(Name="cLClearCloseStatusReceivedByLenderDateTime", EmitDefaultValue=false)]
		public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLClosingEscrowOrderAcceptedDateTime", EmitDefaultValue=false)]
		public DateTime? CLClosingEscrowOrderAcceptedDateTime { get; set; }

		[DataMember(Name="cLClosingEscrowOrderSentDateTime", EmitDefaultValue=false)]
		public DateTime? CLClosingEscrowOrderSentDateTime { get; set; }

		[DataMember(Name="cLDraftClosingDisclosureReceivedByLenderDateTime", EmitDefaultValue=false)]
		public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLFinalCDSentDateTime", EmitDefaultValue=false)]
		public DateTime? CLFinalCDSentDateTime { get; set; }

		[DataMember(Name="cLFinalTitlePolicyDateTime", EmitDefaultValue=false)]
		public DateTime? CLFinalTitlePolicyDateTime { get; set; }

		[DataMember(Name="cLLastFeeQuoteReceivedDateTime", EmitDefaultValue=false)]
		public DateTime? CLLastFeeQuoteReceivedDateTime { get; set; }

		[DataMember(Name="cLLastFeeQuoteRequestedDateTime", EmitDefaultValue=false)]
		public DateTime? CLLastFeeQuoteRequestedDateTime { get; set; }

		[DataMember(Name="closingDocsLoanProgramType", EmitDefaultValue=false)]
		public string ClosingDocsLoanProgramType { get; set; }

		[DataMember(Name="closingEntities", EmitDefaultValue=false)]
		public List<LoanContractClosingDocumentClosingEntities> ClosingEntities { get; set; }

		[DataMember(Name="closingProvider", EmitDefaultValue=false)]
		public string ClosingProvider { get; set; }

		[DataMember(Name="closingState", EmitDefaultValue=false)]
		public string ClosingState { get; set; }

		[DataMember(Name="cLPayoffsRequestedDateTime", EmitDefaultValue=false)]
		public DateTime? CLPayoffsRequestedDateTime { get; set; }

		[DataMember(Name="cLPrelimCommitmentReceivedByLenderDateTime", EmitDefaultValue=false)]
		public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLProviderDisburseFundsDateTime", EmitDefaultValue=false)]
		public DateTime? CLProviderDisburseFundsDateTime { get; set; }

		[DataMember(Name="cLTitleOrderAcceptedDateTime", EmitDefaultValue=false)]
		public DateTime? CLTitleOrderAcceptedDateTime { get; set; }

		[DataMember(Name="cLTitleOrderSentDateTime", EmitDefaultValue=false)]
		public DateTime? CLTitleOrderSentDateTime { get; set; }

		[DataMember(Name="complianceJurisdictionCounty", EmitDefaultValue=false)]
		public string ComplianceJurisdictionCounty { get; set; }

		[DataMember(Name="compliancePropertyIdentifiedDate", EmitDefaultValue=false)]
		public DateTime? CompliancePropertyIdentifiedDate { get; set; }

		[DataMember(Name="conditionDescription", EmitDefaultValue=false)]
		public string ConditionDescription { get; set; }

		[DataMember(Name="conflictofInterestCheck1", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck1 { get; set; }

		[DataMember(Name="conflictofInterestCheck2", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck2 { get; set; }

		[DataMember(Name="conflictofInterestCheck3", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck3 { get; set; }

		[DataMember(Name="conflictofInterestCheck4", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck4 { get; set; }

		[DataMember(Name="conflictofInterestCheck5", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck5 { get; set; }

		[DataMember(Name="conflictofInterestCheck6", EmitDefaultValue=false)]
		public bool? ConflictofInterestCheck6 { get; set; }

		[DataMember(Name="coopApartmentNumber", EmitDefaultValue=false)]
		public string CoopApartmentNumber { get; set; }

		[DataMember(Name="coopAssignmentLeaseDate", EmitDefaultValue=false)]
		public DateTime? CoopAssignmentLeaseDate { get; set; }

		[DataMember(Name="coopAttorneyInFact", EmitDefaultValue=false)]
		public string CoopAttorneyInFact { get; set; }

		[DataMember(Name="coopBuildingName", EmitDefaultValue=false)]
		public string CoopBuildingName { get; set; }

		[DataMember(Name="coopCompanyExistsUnderTHeLawsOf", EmitDefaultValue=false)]
		public string CoopCompanyExistsUnderTHeLawsOf { get; set; }

		[DataMember(Name="coopCompanyName", EmitDefaultValue=false)]
		public string CoopCompanyName { get; set; }

		[DataMember(Name="coopProprietaryLeaseDate", EmitDefaultValue=false)]
		public DateTime? CoopProprietaryLeaseDate { get; set; }

		[DataMember(Name="coopSharesOwned", EmitDefaultValue=false)]
		public double? CoopSharesOwned { get; set; }

		[DataMember(Name="coopStockCertificationNumber", EmitDefaultValue=false)]
		public string CoopStockCertificationNumber { get; set; }

		[DataMember(Name="coopVacancyPercentNotification", EmitDefaultValue=false)]
		public double? CoopVacancyPercentNotification { get; set; }

		[DataMember(Name="customOtherRiderDescription", EmitDefaultValue=false)]
		public string CustomOtherRiderDescription { get; set; }

		[DataMember(Name="disbursementDate", EmitDefaultValue=false)]
		public DateTime? DisbursementDate { get; set; }

		[DataMember(Name="disbursementsToBorrower", EmitDefaultValue=false)]
		public double? DisbursementsToBorrower { get; set; }

		[DataMember(Name="disclosureAlternateLender", EmitDefaultValue=false)]
		public string DisclosureAlternateLender { get; set; }

		[DataMember(Name="disclosureCompanyFunction", EmitDefaultValue=false)]
		public string DisclosureCompanyFunction { get; set; }

		[DataMember(Name="disclosurePlanCode", EmitDefaultValue=false)]
		public string DisclosurePlanCode { get; set; }

		[DataMember(Name="docReportGUID", EmitDefaultValue=false)]
		public string DocReportGUID { get; set; }

		[DataMember(Name="documentPreparationDate", EmitDefaultValue=false)]
		public DateTime? DocumentPreparationDate { get; set; }

		[DataMember(Name="documentSigningDate", EmitDefaultValue=false)]
		public DateTime? DocumentSigningDate { get; set; }

		[DataMember(Name="drawCity", EmitDefaultValue=false)]
		public string DrawCity { get; set; }

		[DataMember(Name="drawCounty", EmitDefaultValue=false)]
		public string DrawCounty { get; set; }

		[DataMember(Name="drawState", EmitDefaultValue=false)]
		public string DrawState { get; set; }

		[DataMember(Name="employeeofMortgageLender", EmitDefaultValue=false)]
		public string EmployeeofMortgageLender { get; set; }

		[DataMember(Name="expectToAssignSellOrTransferPercent", EmitDefaultValue=false)]
		public string ExpectToAssignSellOrTransferPercent { get; set; }

		[DataMember(Name="finalVestingDescription", EmitDefaultValue=false)]
		public string FinalVestingDescription { get; set; }

		[DataMember(Name="firstTransferYear", EmitDefaultValue=false)]
		public string FirstTransferYear { get; set; }

		[DataMember(Name="firstTransferYearValue", EmitDefaultValue=false)]
		public double? FirstTransferYearValue { get; set; }

		[DataMember(Name="hoursDocumentsNeededPriorToDisbursementCount", EmitDefaultValue=false)]
		public string HoursDocumentsNeededPriorToDisbursementCount { get; set; }

		[DataMember(Name="housingIndicator", EmitDefaultValue=false)]
		public bool? HousingIndicator { get; set; }

		[DataMember(Name="housingProgramName", EmitDefaultValue=false)]
		public string HousingProgramName { get; set; }

		[DataMember(Name="hUD1FileNumberIdentifier", EmitDefaultValue=false)]
		public string HUD1FileNumberIdentifier { get; set; }

		[DataMember(Name="hUD1SettlementAgentUnparsedAddress", EmitDefaultValue=false)]
		public string HUD1SettlementAgentUnparsedAddress { get; set; }

		[DataMember(Name="hUD1SettlementAgentUnparsedName", EmitDefaultValue=false)]
		public string HUD1SettlementAgentUnparsedName { get; set; }

		[DataMember(Name="hUD1SettlementDate", EmitDefaultValue=false)]
		public DateTime? HUD1SettlementDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="includeSafeHaborDisclosure", EmitDefaultValue=false)]
		public double? IncludeSafeHaborDisclosure { get; set; }

		[DataMember(Name="investorCode", EmitDefaultValue=false)]
		public string InvestorCode { get; set; }

		[DataMember(Name="lastAuditDate", EmitDefaultValue=false)]
		public string LastAuditDate { get; set; }

		[DataMember(Name="lastDocumentOrdered", EmitDefaultValue=false)]
		public string LastDocumentOrdered { get; set; }

		[DataMember(Name="legalAttached", EmitDefaultValue=false)]
		public bool? LegalAttached { get; set; }

		[DataMember(Name="lenderAuthorizedRepresentativeTitle", EmitDefaultValue=false)]
		public string LenderAuthorizedRepresentativeTitle { get; set; }

		[DataMember(Name="lenderBrokerRepresents", EmitDefaultValue=false)]
		public string LenderBrokerRepresents { get; set; }

		[DataMember(Name="lienHolderAddress", EmitDefaultValue=false)]
		public string LienHolderAddress { get; set; }

		[DataMember(Name="lienHolderAddressCity", EmitDefaultValue=false)]
		public string LienHolderAddressCity { get; set; }

		[DataMember(Name="lienHolderAddressPostalCode", EmitDefaultValue=false)]
		public string LienHolderAddressPostalCode { get; set; }

		[DataMember(Name="lienHolderAddressState", EmitDefaultValue=false)]
		public string LienHolderAddressState { get; set; }

		[DataMember(Name="lienHolderName", EmitDefaultValue=false)]
		public string LienHolderName { get; set; }

		[DataMember(Name="loanIsLocked", EmitDefaultValue=false)]
		public bool? LoanIsLocked { get; set; }

		[DataMember(Name="loanOption", EmitDefaultValue=false)]
		public string LoanOption { get; set; }

		[DataMember(Name="lockInFeeType", EmitDefaultValue=false)]
		public string LockInFeeType { get; set; }

		[DataMember(Name="mfgHomeAnchored", EmitDefaultValue=false)]
		public string MfgHomeAnchored { get; set; }

		[DataMember(Name="mfgHomeCertificateOfTitleIdentifier", EmitDefaultValue=false)]
		public string MfgHomeCertificateOfTitleIdentifier { get; set; }

		[DataMember(Name="mfgHomeCertificateOfTitleType", EmitDefaultValue=false)]
		public string MfgHomeCertificateOfTitleType { get; set; }

		[DataMember(Name="mfgHomeDescription", EmitDefaultValue=false)]
		public string MfgHomeDescription { get; set; }

		[DataMember(Name="mfgHomeHUDCertificationLabelIdentifier", EmitDefaultValue=false)]
		public string MfgHomeHUDCertificationLabelIdentifier { get; set; }

		[DataMember(Name="mfgHomeLengthFeetCount", EmitDefaultValue=false)]
		public int? MfgHomeLengthFeetCount { get; set; }

		[DataMember(Name="mfgHomeMakeIdentifier", EmitDefaultValue=false)]
		public string MfgHomeMakeIdentifier { get; set; }

		[DataMember(Name="mfgHomeManufacturer", EmitDefaultValue=false)]
		public string MfgHomeManufacturer { get; set; }

		[DataMember(Name="mfgHomeManufacturerAddress", EmitDefaultValue=false)]
		public string MfgHomeManufacturerAddress { get; set; }

		[DataMember(Name="mfgHomeManufacturerCity", EmitDefaultValue=false)]
		public string MfgHomeManufacturerCity { get; set; }

		[DataMember(Name="mfgHomeManufacturerPhoneNumber", EmitDefaultValue=false)]
		public string MfgHomeManufacturerPhoneNumber { get; set; }

		[DataMember(Name="mfgHomeManufacturerPostalCode", EmitDefaultValue=false)]
		public string MfgHomeManufacturerPostalCode { get; set; }

		[DataMember(Name="mfgHomeManufacturerState", EmitDefaultValue=false)]
		public string MfgHomeManufacturerState { get; set; }

		[DataMember(Name="mfgHomeManufactureYear", EmitDefaultValue=false)]
		public int? MfgHomeManufactureYear { get; set; }

		[DataMember(Name="mfgHomeModelIdentifier", EmitDefaultValue=false)]
		public string MfgHomeModelIdentifier { get; set; }

		[DataMember(Name="mfgHomeNewOrUsed", EmitDefaultValue=false)]
		public string MfgHomeNewOrUsed { get; set; }

		[DataMember(Name="mfgHomeSerialNumberIdentifier", EmitDefaultValue=false)]
		public string MfgHomeSerialNumberIdentifier { get; set; }

		[DataMember(Name="mfgHomeWidthFeetCount", EmitDefaultValue=false)]
		public int? MfgHomeWidthFeetCount { get; set; }

		[DataMember(Name="mineralRightsDescription", EmitDefaultValue=false)]
		public string MineralRightsDescription { get; set; }

		[DataMember(Name="mortgageType", EmitDefaultValue=false)]
		public string MortgageType { get; set; }

		[DataMember(Name="numberBrokerAgreements", EmitDefaultValue=false)]
		public int? NumberBrokerAgreements { get; set; }

		[DataMember(Name="numberSuccessfulBrokerAgreements", EmitDefaultValue=false)]
		public int? NumberSuccessfulBrokerAgreements { get; set; }

		[DataMember(Name="officeOfRecordationName", EmitDefaultValue=false)]
		public string OfficeOfRecordationName { get; set; }

		[DataMember(Name="onlyOneEntity", EmitDefaultValue=false)]
		public bool? OnlyOneEntity { get; set; }

		[DataMember(Name="optionSelectedReason", EmitDefaultValue=false)]
		public string OptionSelectedReason { get; set; }

		[DataMember(Name="originalPincipalAmountSecured", EmitDefaultValue=false)]
		public double? OriginalPincipalAmountSecured { get; set; }

		[DataMember(Name="otherOptionDescription", EmitDefaultValue=false)]
		public string OtherOptionDescription { get; set; }

		[DataMember(Name="parentAffiliatedCoName", EmitDefaultValue=false)]
		public string ParentAffiliatedCoName { get; set; }

		[DataMember(Name="payToTheOrderOfDescription", EmitDefaultValue=false)]
		public string PayToTheOrderOfDescription { get; set; }

		[DataMember(Name="perDiemCalculationMethodType", EmitDefaultValue=false)]
		public string PerDiemCalculationMethodType { get; set; }

		[DataMember(Name="planCode", EmitDefaultValue=false)]
		public string PlanCode { get; set; }

		[DataMember(Name="planCodeDescription", EmitDefaultValue=false)]
		public string PlanCodeDescription { get; set; }

		[DataMember(Name="planCodeId", EmitDefaultValue=false)]
		public string PlanCodeId { get; set; }

		[DataMember(Name="preliminaryTitleReportDate", EmitDefaultValue=false)]
		public DateTime? PreliminaryTitleReportDate { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions1", EmitDefaultValue=false)]
		public string PrepaymentPenaltyDescriptions1 { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions2", EmitDefaultValue=false)]
		public string PrepaymentPenaltyDescriptions2 { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions3", EmitDefaultValue=false)]
		public string PrepaymentPenaltyDescriptions3 { get; set; }

		[DataMember(Name="processingNumberDays", EmitDefaultValue=false)]
		public int? ProcessingNumberDays { get; set; }

		[DataMember(Name="programCode", EmitDefaultValue=false)]
		public string ProgramCode { get; set; }

		[DataMember(Name="programSponsor", EmitDefaultValue=false)]
		public string ProgramSponsor { get; set; }

		[DataMember(Name="propertyIsLandTrust", EmitDefaultValue=false)]
		public bool? PropertyIsLandTrust { get; set; }

		[DataMember(Name="propertyTaxMessageDescription", EmitDefaultValue=false)]
		public string PropertyTaxMessageDescription { get; set; }

		[DataMember(Name="rateLockRefundConditions1", EmitDefaultValue=false)]
		public string RateLockRefundConditions1 { get; set; }

		[DataMember(Name="rateLockRefundConditions2", EmitDefaultValue=false)]
		public string RateLockRefundConditions2 { get; set; }

		[DataMember(Name="rateLockRefundConditions3", EmitDefaultValue=false)]
		public string RateLockRefundConditions3 { get; set; }

		[DataMember(Name="recordingJurisdictionName", EmitDefaultValue=false)]
		public string RecordingJurisdictionName { get; set; }

		[DataMember(Name="refinanceBalloonMortgageGuarantee", EmitDefaultValue=false)]
		public bool? RefinanceBalloonMortgageGuarantee { get; set; }

		[DataMember(Name="refinanceRightOfRescissionExemptFlag", EmitDefaultValue=false)]
		public bool? RefinanceRightOfRescissionExemptFlag { get; set; }

		[DataMember(Name="renewalExtensionDescription", EmitDefaultValue=false)]
		public string RenewalExtensionDescription { get; set; }

		[DataMember(Name="rescissionDate", EmitDefaultValue=false)]
		public DateTime? RescissionDate { get; set; }

		[DataMember(Name="respaHudDetails", EmitDefaultValue=false)]
		public List<LoanContractClosingDocumentRespaHudDetails> RespaHudDetails { get; set; }

		[DataMember(Name="rMLANamePreceding10Years", EmitDefaultValue=false)]
		public string RMLANamePreceding10Years { get; set; }

		[DataMember(Name="rmlLenderBrokerRepresents", EmitDefaultValue=false)]
		public string RmlLenderBrokerRepresents { get; set; }

		[DataMember(Name="secondTransferYear", EmitDefaultValue=false)]
		public string SecondTransferYear { get; set; }

		[DataMember(Name="secondTransferYearValue", EmitDefaultValue=false)]
		public double? SecondTransferYearValue { get; set; }

		[DataMember(Name="signatureDateFor1003", EmitDefaultValue=false)]
		public DateTime? SignatureDateFor1003 { get; set; }

		[DataMember(Name="specialFloodHazardAreaIndictor", EmitDefaultValue=false)]
		public string SpecialFloodHazardAreaIndictor { get; set; }

		[DataMember(Name="stateLicenses", EmitDefaultValue=false)]
		public List<LoanContractClosingDocumentStateLicenses> StateLicenses { get; set; }

		[DataMember(Name="suretyCompanyName", EmitDefaultValue=false)]
		public string SuretyCompanyName { get; set; }

		[DataMember(Name="syncInterestDateDisbursementDate", EmitDefaultValue=false)]
		public bool? SyncInterestDateDisbursementDate { get; set; }

		[DataMember(Name="termiteReportRequiredIndicator", EmitDefaultValue=false)]
		public string TermiteReportRequiredIndicator { get; set; }

		[DataMember(Name="textDescription", EmitDefaultValue=false)]
		public string TextDescription { get; set; }

		[DataMember(Name="thirdTransferYear", EmitDefaultValue=false)]
		public string ThirdTransferYear { get; set; }

		[DataMember(Name="thirdTransferYearValue", EmitDefaultValue=false)]
		public double? ThirdTransferYearValue { get; set; }

		[DataMember(Name="titleReportItemsDescription", EmitDefaultValue=false)]
		public string TitleReportItemsDescription { get; set; }

		[DataMember(Name="titleReportRequiredEndorsementsDescription", EmitDefaultValue=false)]
		public string TitleReportRequiredEndorsementsDescription { get; set; }

		[DataMember(Name="totalDisbursed", EmitDefaultValue=false)]
		public double? TotalDisbursed { get; set; }

		[DataMember(Name="trust2Beneficiaries", EmitDefaultValue=false)]
		public string Trust2Beneficiaries { get; set; }

		[DataMember(Name="weConductBusiness", EmitDefaultValue=false)]
		public string WeConductBusiness { get; set; }

		[DataMember(Name = "Print2001UniformInstrumentsIndicator")]
		public bool? Print2001UniformInstrumentsIndicator { get; set; }
	}
}