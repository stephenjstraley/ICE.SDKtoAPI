using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocument
	{
		[DataMember(Name="additionalLienHolderAddress")]
		public string AdditionalLienHolderAddress { get; set; }

		[DataMember(Name="additionalLienHolderAddressCity")]
		public string AdditionalLienHolderAddressCity { get; set; }

		[DataMember(Name="additionalLienHolderAddressPostalCode")]
		public string AdditionalLienHolderAddressPostalCode { get; set; }

		[DataMember(Name="additionalLienHolderAddressState")]
		public string AdditionalLienHolderAddressState { get; set; }

		[DataMember(Name="additionalLienHolderName")]
		public string AdditionalLienHolderName { get; set; }

		[DataMember(Name="additionalOriginalPincipalAmountSecured")]
		public decimal? AdditionalOriginalPincipalAmountSecured { get; set; }

		[DataMember(Name="additionalSigVerbiageType")]
		public string AdditionalSigVerbiageType { get; set; }

		[DataMember(Name="additionalStateDisclosures")]
		public List<LoanContractClosingDocumentAdditionalStateDisclosures> AdditionalStateDisclosures { get; set; }

		[DataMember(Name="affectedByInterest")]
		public bool? AffectedByInterest { get; set; }

		[DataMember(Name="alternateLender")]
		public string AlternateLender { get; set; }

		[DataMember(Name="altLenderId")]
		public string AltLenderId { get; set; }

		[DataMember(Name="antiSteeringLoanOptions")]
		public List<LoanContractClosingDocumentAntiSteeringLoanOptions> AntiSteeringLoanOptions { get; set; }

		[DataMember(Name="areAbleToServiceIndicator")]
		public string AreAbleToServiceIndicator { get; set; }

		[DataMember(Name="associatedDocumentNumber")]
		public string AssociatedDocumentNumber { get; set; }

		[DataMember(Name="beneficiaries")]
		public string Beneficiaries { get; set; }

		[DataMember(Name="borrowerConsentType1")]
		public bool? BorrowerConsentType1 { get; set; }

		[DataMember(Name="borrowerConsentType2")]
		public bool? BorrowerConsentType2 { get; set; }

		[DataMember(Name="borrowerOrganizationType1")]
		public string BorrowerOrganizationType1 { get; set; }

		[DataMember(Name="borrowerOrganizationType2")]
		public string BorrowerOrganizationType2 { get; set; }

		[DataMember(Name="borrowerOrganizedUnderTheLawsOfJurisdictionName1")]
		public string BorrowerOrganizedUnderTheLawsOfJurisdictionName1 { get; set; }

		[DataMember(Name="borrowerOrganizedUnderTheLawsOfJurisdictionName2")]
		public string BorrowerOrganizedUnderTheLawsOfJurisdictionName2 { get; set; }

		[DataMember(Name="borrowerTaxIdentificationNumberIdentifier1")]
		public string BorrowerTaxIdentificationNumberIdentifier1 { get; set; }

		[DataMember(Name="borrowerTaxIdentificationNumberIdentifier2")]
		public string BorrowerTaxIdentificationNumberIdentifier2 { get; set; }

		[DataMember(Name="borrowerTrustAmendedDateOrYear1")]
		public string BorrowerTrustAmendedDateOrYear1 { get; set; }

		[DataMember(Name="borrowerTrustAmendedDateOrYear2")]
		public string BorrowerTrustAmendedDateOrYear2 { get; set; }

		[DataMember(Name="borrowerTrustDateOrYear1")]
		public string BorrowerTrustDateOrYear1 { get; set; }

		[DataMember(Name="borrowerTrustDateOrYear2")]
		public string BorrowerTrustDateOrYear2 { get; set; }

		[DataMember(Name="borrowerUnparsedName1")]
		public string BorrowerUnparsedName1 { get; set; }

		[DataMember(Name="borrowerUnparsedName2")]
		public string BorrowerUnparsedName2 { get; set; }

		[DataMember(Name="brokerAuthorizedRepresentativeTitle")]
		public string BrokerAuthorizedRepresentativeTitle { get; set; }

		[DataMember(Name="brokerCompensationMethod")]
		public string BrokerCompensationMethod { get; set; }

		[DataMember(Name="brokerFeeRefundConditions1")]
		public string BrokerFeeRefundConditions1 { get; set; }

		[DataMember(Name="brokerFeeRefundConditions2")]
		public string BrokerFeeRefundConditions2 { get; set; }

		[DataMember(Name="brokerFeeRefundConditions3")]
		public string BrokerFeeRefundConditions3 { get; set; }

		[DataMember(Name="brokerForPlacingLoan")]
		public string BrokerForPlacingLoan { get; set; }

		[DataMember(Name="brokerInterestRateEffect")]
		public string BrokerInterestRateEffect { get; set; }

		[DataMember(Name="brokerLenderRelationship")]
		public string BrokerLenderRelationship { get; set; }

		[DataMember(Name="brokerLicenseNumberIdentifier")]
		public string BrokerLicenseNumberIdentifier { get; set; }

		[DataMember(Name="brokerNameAsLicensed")]
		public string BrokerNameAsLicensed { get; set; }

		[DataMember(Name="brokerTaxIdentificationNumberIdentifier")]
		public string BrokerTaxIdentificationNumberIdentifier { get; set; }

		[DataMember(Name="brokerWithLenders")]
		public string BrokerWithLenders { get; set; }

		[DataMember(Name="cashCheckFromBorrower")]
		public decimal? CashCheckFromBorrower { get; set; }

		[DataMember(Name="cLClearCloseStatusReceivedByLenderDateTime")]
		public DateTime? CLClearCloseStatusReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLClosingEscrowOrderAcceptedDateTime")]
		public DateTime? CLClosingEscrowOrderAcceptedDateTime { get; set; }

		[DataMember(Name="cLClosingEscrowOrderSentDateTime")]
		public DateTime? CLClosingEscrowOrderSentDateTime { get; set; }

		[DataMember(Name="cLDraftClosingDisclosureReceivedByLenderDateTime")]
		public DateTime? CLDraftClosingDisclosureReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLFinalCDSentDateTime")]
		public DateTime? CLFinalCDSentDateTime { get; set; }

		[DataMember(Name="cLFinalTitlePolicyDateTime")]
		public DateTime? CLFinalTitlePolicyDateTime { get; set; }

		[DataMember(Name="cLLastFeeQuoteReceivedDateTime")]
		public DateTime? CLLastFeeQuoteReceivedDateTime { get; set; }

		[DataMember(Name="cLLastFeeQuoteRequestedDateTime")]
		public DateTime? CLLastFeeQuoteRequestedDateTime { get; set; }

		[DataMember(Name="closingDocsLoanProgramType")]
		public string ClosingDocsLoanProgramType { get; set; }

		[DataMember(Name="closingEntities")]
		public List<LoanContractClosingDocumentClosingEntities> ClosingEntities { get; set; }

		[DataMember(Name="closingProvider")]
		public string ClosingProvider { get; set; }

		[DataMember(Name="closingState")]
		public string ClosingState { get; set; }

		[DataMember(Name="cLPayoffsRequestedDateTime")]
		public DateTime? CLPayoffsRequestedDateTime { get; set; }

		[DataMember(Name="cLPrelimCommitmentReceivedByLenderDateTime")]
		public DateTime? CLPrelimCommitmentReceivedByLenderDateTime { get; set; }

		[DataMember(Name="cLProviderDisburseFundsDateTime")]
		public DateTime? CLProviderDisburseFundsDateTime { get; set; }

		[DataMember(Name="cLTitleOrderAcceptedDateTime")]
		public DateTime? CLTitleOrderAcceptedDateTime { get; set; }

		[DataMember(Name="cLTitleOrderSentDateTime")]
		public DateTime? CLTitleOrderSentDateTime { get; set; }

		[DataMember(Name="complianceJurisdictionCounty")]
		public string ComplianceJurisdictionCounty { get; set; }

		[DataMember(Name="compliancePropertyIdentifiedDate")]
		public DateTime? CompliancePropertyIdentifiedDate { get; set; }

		[DataMember(Name="conditionDescription")]
		public string ConditionDescription { get; set; }

		[DataMember(Name="conflictofInterestCheck1")]
		public bool? ConflictofInterestCheck1 { get; set; }

		[DataMember(Name="conflictofInterestCheck2")]
		public bool? ConflictofInterestCheck2 { get; set; }

		[DataMember(Name="conflictofInterestCheck3")]
		public bool? ConflictofInterestCheck3 { get; set; }

		[DataMember(Name="conflictofInterestCheck4")]
		public bool? ConflictofInterestCheck4 { get; set; }

		[DataMember(Name="conflictofInterestCheck5")]
		public bool? ConflictofInterestCheck5 { get; set; }

		[DataMember(Name="conflictofInterestCheck6")]
		public bool? ConflictofInterestCheck6 { get; set; }

		[DataMember(Name="coopApartmentNumber")]
		public string CoopApartmentNumber { get; set; }

		[DataMember(Name="coopAssignmentLeaseDate")]
		public DateTime? CoopAssignmentLeaseDate { get; set; }

		[DataMember(Name="coopAttorneyInFact")]
		public string CoopAttorneyInFact { get; set; }

		[DataMember(Name="coopBuildingName")]
		public string CoopBuildingName { get; set; }

		[DataMember(Name="coopCompanyExistsUnderTHeLawsOf")]
		public string CoopCompanyExistsUnderTHeLawsOf { get; set; }

		[DataMember(Name="coopCompanyName")]
		public string CoopCompanyName { get; set; }

		[DataMember(Name="coopProprietaryLeaseDate")]
		public DateTime? CoopProprietaryLeaseDate { get; set; }

		[DataMember(Name="coopSharesOwned")]
		public decimal? CoopSharesOwned { get; set; }

		[DataMember(Name="coopStockCertificationNumber")]
		public string CoopStockCertificationNumber { get; set; }

		[DataMember(Name="coopVacancyPercentNotification")]
		public decimal? CoopVacancyPercentNotification { get; set; }

		[DataMember(Name="customOtherRiderDescription")]
		public string CustomOtherRiderDescription { get; set; }

		[DataMember(Name="disbursementDate")]
		public DateTime? DisbursementDate { get; set; }

		[DataMember(Name="disbursementsToBorrower")]
		public decimal? DisbursementsToBorrower { get; set; }

		[DataMember(Name="disclosureAlternateLender")]
		public string DisclosureAlternateLender { get; set; }

		[DataMember(Name="disclosureCompanyFunction")]
		public string DisclosureCompanyFunction { get; set; }

		[DataMember(Name="disclosurePlanCode")]
		public string DisclosurePlanCode { get; set; }

		[DataMember(Name="docReportGUID")]
		public string DocReportGUID { get; set; }

		[DataMember(Name="documentPreparationDate")]
		public DateTime? DocumentPreparationDate { get; set; }

		[DataMember(Name="documentSigningDate")]
		public DateTime? DocumentSigningDate { get; set; }

		[DataMember(Name="drawCity")]
		public string DrawCity { get; set; }

		[DataMember(Name="drawCounty")]
		public string DrawCounty { get; set; }

		[DataMember(Name="drawState")]
		public string DrawState { get; set; }

		[DataMember(Name="employeeofMortgageLender")]
		public string EmployeeofMortgageLender { get; set; }

		[DataMember(Name="expectToAssignSellOrTransferPercent")]
		public string ExpectToAssignSellOrTransferPercent { get; set; }

		[DataMember(Name="finalVestingDescription")]
		public string FinalVestingDescription { get; set; }

		[DataMember(Name="firstTransferYear")]
		public string FirstTransferYear { get; set; }

		[DataMember(Name="firstTransferYearValue")]
		public decimal? FirstTransferYearValue { get; set; }

		[DataMember(Name="hoursDocumentsNeededPriorToDisbursementCount")]
		public string HoursDocumentsNeededPriorToDisbursementCount { get; set; }

		[DataMember(Name="housingIndicator")]
		public bool? HousingIndicator { get; set; }

		[DataMember(Name="housingProgramName")]
		public string HousingProgramName { get; set; }

		[DataMember(Name="hUD1FileNumberIdentifier")]
		public string HUD1FileNumberIdentifier { get; set; }

		[DataMember(Name="hUD1SettlementAgentUnparsedAddress")]
		public string HUD1SettlementAgentUnparsedAddress { get; set; }

		[DataMember(Name="hUD1SettlementAgentUnparsedName")]
		public string HUD1SettlementAgentUnparsedName { get; set; }

		[DataMember(Name="hUD1SettlementDate")]
		public DateTime? HUD1SettlementDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="includeSafeHaborDisclosure")]
		public decimal? IncludeSafeHaborDisclosure { get; set; }

		[DataMember(Name="investorCode")]
		public string InvestorCode { get; set; }

		[DataMember(Name="lastAuditDate")]
		public string LastAuditDate { get; set; }

		[DataMember(Name="lastDocumentOrdered")]
		public string LastDocumentOrdered { get; set; }

		[DataMember(Name="legalAttached")]
		public bool? LegalAttached { get; set; }

		[DataMember(Name="lenderAuthorizedRepresentativeTitle")]
		public string LenderAuthorizedRepresentativeTitle { get; set; }

		[DataMember(Name="lenderBrokerRepresents")]
		public string LenderBrokerRepresents { get; set; }

		[DataMember(Name="lienHolderAddress")]
		public string LienHolderAddress { get; set; }

		[DataMember(Name="lienHolderAddressCity")]
		public string LienHolderAddressCity { get; set; }

		[DataMember(Name="lienHolderAddressPostalCode")]
		public string LienHolderAddressPostalCode { get; set; }

		[DataMember(Name="lienHolderAddressState")]
		public string LienHolderAddressState { get; set; }

		[DataMember(Name="lienHolderName")]
		public string LienHolderName { get; set; }

		[DataMember(Name="loanIsLocked")]
		public bool? LoanIsLocked { get; set; }

		[DataMember(Name="loanOption")]
		public string LoanOption { get; set; }

		[DataMember(Name="lockInFeeType")]
		public string LockInFeeType { get; set; }

		[DataMember(Name="mfgHomeAnchored")]
		public string MfgHomeAnchored { get; set; }

		[DataMember(Name="mfgHomeCertificateOfTitleIdentifier")]
		public string MfgHomeCertificateOfTitleIdentifier { get; set; }

		[DataMember(Name="mfgHomeCertificateOfTitleType")]
		public string MfgHomeCertificateOfTitleType { get; set; }

		[DataMember(Name="mfgHomeDescription")]
		public string MfgHomeDescription { get; set; }

		[DataMember(Name="mfgHomeHUDCertificationLabelIdentifier")]
		public string MfgHomeHUDCertificationLabelIdentifier { get; set; }

		[DataMember(Name="mfgHomeLengthFeetCount")]
		public int? MfgHomeLengthFeetCount { get; set; }

		[DataMember(Name="mfgHomeMakeIdentifier")]
		public string MfgHomeMakeIdentifier { get; set; }

		[DataMember(Name="mfgHomeManufacturer")]
		public string MfgHomeManufacturer { get; set; }

		[DataMember(Name="mfgHomeManufacturerAddress")]
		public string MfgHomeManufacturerAddress { get; set; }

		[DataMember(Name="mfgHomeManufacturerCity")]
		public string MfgHomeManufacturerCity { get; set; }

		[DataMember(Name="mfgHomeManufacturerPhoneNumber")]
		public string MfgHomeManufacturerPhoneNumber { get; set; }

		[DataMember(Name="mfgHomeManufacturerPostalCode")]
		public string MfgHomeManufacturerPostalCode { get; set; }

		[DataMember(Name="mfgHomeManufacturerState")]
		public string MfgHomeManufacturerState { get; set; }

		[DataMember(Name="mfgHomeManufactureYear")]
		public int? MfgHomeManufactureYear { get; set; }

		[DataMember(Name="mfgHomeModelIdentifier")]
		public string MfgHomeModelIdentifier { get; set; }

		[DataMember(Name="mfgHomeNewOrUsed")]
		public string MfgHomeNewOrUsed { get; set; }

		[DataMember(Name="mfgHomeSerialNumberIdentifier")]
		public string MfgHomeSerialNumberIdentifier { get; set; }

		[DataMember(Name="mfgHomeWidthFeetCount")]
		public int? MfgHomeWidthFeetCount { get; set; }

		[DataMember(Name="mineralRightsDescription")]
		public string MineralRightsDescription { get; set; }

		[DataMember(Name="mortgageType")]
		public string MortgageType { get; set; }

		[DataMember(Name="numberBrokerAgreements")]
		public int? NumberBrokerAgreements { get; set; }

		[DataMember(Name="numberSuccessfulBrokerAgreements")]
		public int? NumberSuccessfulBrokerAgreements { get; set; }

		[DataMember(Name="officeOfRecordationName")]
		public string OfficeOfRecordationName { get; set; }

		[DataMember(Name="onlyOneEntity")]
		public bool? OnlyOneEntity { get; set; }

		[DataMember(Name="optionSelectedReason")]
		public string OptionSelectedReason { get; set; }

		[DataMember(Name="originalPincipalAmountSecured")]
		public decimal? OriginalPincipalAmountSecured { get; set; }

		[DataMember(Name="otherOptionDescription")]
		public string OtherOptionDescription { get; set; }

		[DataMember(Name="parentAffiliatedCoName")]
		public string ParentAffiliatedCoName { get; set; }

		[DataMember(Name="payToTheOrderOfDescription")]
		public string PayToTheOrderOfDescription { get; set; }

		[DataMember(Name="perDiemCalculationMethodType")]
		public string PerDiemCalculationMethodType { get; set; }

		[DataMember(Name="planCode")]
		public string PlanCode { get; set; }

		[DataMember(Name="planCodeDescription")]
		public string PlanCodeDescription { get; set; }

		[DataMember(Name="planCodeId")]
		public string PlanCodeId { get; set; }

		[DataMember(Name="preliminaryTitleReportDate")]
		public DateTime? PreliminaryTitleReportDate { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions1")]
		public string PrepaymentPenaltyDescriptions1 { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions2")]
		public string PrepaymentPenaltyDescriptions2 { get; set; }

		[DataMember(Name="prepaymentPenaltyDescriptions3")]
		public string PrepaymentPenaltyDescriptions3 { get; set; }

		[DataMember(Name="processingNumberDays")]
		public int? ProcessingNumberDays { get; set; }

		[DataMember(Name="programCode")]
		public string ProgramCode { get; set; }

		[DataMember(Name="programSponsor")]
		public string ProgramSponsor { get; set; }

		[DataMember(Name="propertyIsLandTrust")]
		public bool? PropertyIsLandTrust { get; set; }

		[DataMember(Name="propertyTaxMessageDescription")]
		public string PropertyTaxMessageDescription { get; set; }

		[DataMember(Name="rateLockRefundConditions1")]
		public string RateLockRefundConditions1 { get; set; }

		[DataMember(Name="rateLockRefundConditions2")]
		public string RateLockRefundConditions2 { get; set; }

		[DataMember(Name="rateLockRefundConditions3")]
		public string RateLockRefundConditions3 { get; set; }

		[DataMember(Name="recordingJurisdictionName")]
		public string RecordingJurisdictionName { get; set; }

		[DataMember(Name="refinanceBalloonMortgageGuarantee")]
		public bool? RefinanceBalloonMortgageGuarantee { get; set; }

		[DataMember(Name="refinanceRightOfRescissionExemptFlag")]
		public bool? RefinanceRightOfRescissionExemptFlag { get; set; }

		[DataMember(Name="renewalExtensionDescription")]
		public string RenewalExtensionDescription { get; set; }

		[DataMember(Name="rescissionDate")]
		public DateTime? RescissionDate { get; set; }

		[DataMember(Name="respaHudDetails")]
		public List<LoanContractClosingDocumentRespaHudDetails> RespaHudDetails { get; set; }

		[DataMember(Name="rMLANamePreceding10Years")]
		public string RMLANamePreceding10Years { get; set; }

		[DataMember(Name="rmlLenderBrokerRepresents")]
		public string RmlLenderBrokerRepresents { get; set; }

		[DataMember(Name="secondTransferYear")]
		public string SecondTransferYear { get; set; }

		[DataMember(Name="secondTransferYearValue")]
		public decimal? SecondTransferYearValue { get; set; }

		[DataMember(Name="signatureDateFor1003")]
		public DateTime? SignatureDateFor1003 { get; set; }

		[DataMember(Name="specialFloodHazardAreaIndictor")]
		public string SpecialFloodHazardAreaIndictor { get; set; }

		[DataMember(Name="stateLicenses")]
		public List<LoanContractClosingDocumentStateLicenses> StateLicenses { get; set; }

		[DataMember(Name="suretyCompanyName")]
		public string SuretyCompanyName { get; set; }

		[DataMember(Name="syncInterestDateDisbursementDate")]
		public bool? SyncInterestDateDisbursementDate { get; set; }

		[DataMember(Name="termiteReportRequiredIndicator")]
		public string TermiteReportRequiredIndicator { get; set; }

		[DataMember(Name="textDescription")]
		public string TextDescription { get; set; }

		[DataMember(Name="thirdTransferYear")]
		public string ThirdTransferYear { get; set; }

		[DataMember(Name="thirdTransferYearValue")]
		public decimal? ThirdTransferYearValue { get; set; }

		[DataMember(Name="titleReportItemsDescription")]
		public string TitleReportItemsDescription { get; set; }

		[DataMember(Name="titleReportRequiredEndorsementsDescription")]
		public string TitleReportRequiredEndorsementsDescription { get; set; }

		[DataMember(Name="totalDisbursed")]
		public decimal? TotalDisbursed { get; set; }

		[DataMember(Name="trust2Beneficiaries")]
		public string Trust2Beneficiaries { get; set; }

		[DataMember(Name="weConductBusiness")]
		public string WeConductBusiness { get; set; }

		[DataMember(Name = "Print2001UniformInstrumentsIndicator")]
		public bool? Print2001UniformInstrumentsIndicator { get; set; }
	}
}