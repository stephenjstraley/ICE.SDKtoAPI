using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDisclosureTracking2015Logs
	{
		[DataMember(Name="actualFulfillmentDate")]
		public string ActualFulfillmentDate { get; set; }

		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec")]
		public string ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec")]
		public string ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec")]
		public string ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec")]
		public string ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec")]
		public string ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec")]
		public string ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec")]
		public string ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec")]
		public string ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec")]
		public string ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="applicationDate")]
		public string ApplicationDate { get; set; }

		[DataMember(Name="appliedCureAmount")]
		public string AppliedCureAmount { get; set; }

		[DataMember(Name="automaticFullfillmentServiceName")]
		public string AutomaticFullfillmentServiceName { get; set; }

		[DataMember(Name="borrowerActualReceivedDate")]
		public string BorrowerActualReceivedDate { get; set; }

		[DataMember(Name="borrowerDisclosedMethod")]
		public string BorrowerDisclosedMethod { get; set; }

		[DataMember(Name="borrowerDisclosedMethodOther")]
		public string BorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="borrowerLoanLevelConsentMapForCC")]
		public bool? BorrowerLoanLevelConsentMapForCC { get; set; }

		[DataMember(Name="borrowerName")]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerPairId")]
		public string BorrowerPairId { get; set; }

		[DataMember(Name="borrowerPresumedReceivedDate")]
		public string BorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="borrowerType")]
		public string BorrowerType { get; set; }

		[DataMember(Name="brokerDisclosed")]
		public bool? BrokerDisclosed { get; set; }

		[DataMember(Name="cDDateIssued")]
		public string CDDateIssued { get; set; }

		[DataMember(Name="cDReasonIs24HourAdvancePreview")]
		public bool? CDReasonIs24HourAdvancePreview { get; set; }

		[DataMember(Name="cDReasonIsChangedCircumstanceEligibility")]
		public bool? CDReasonIsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="cDReasonIsChangeInAPR")]
		public bool? CDReasonIsChangeInAPR { get; set; }

		[DataMember(Name="cDReasonIsChangeInLoanProduct")]
		public bool? CDReasonIsChangeInLoanProduct { get; set; }

		[DataMember(Name="cDReasonIsChangeInSettlementCharges")]
		public bool? CDReasonIsChangeInSettlementCharges { get; set; }

		[DataMember(Name="cDReasonIsClericalErrorCorrection")]
		public bool? CDReasonIsClericalErrorCorrection { get; set; }

		[DataMember(Name="cDReasonIsInterestRateDependentCharges")]
		public bool? CDReasonIsInterestRateDependentCharges { get; set; }

		[DataMember(Name="cDReasonIsOther")]
		public bool? CDReasonIsOther { get; set; }

		[DataMember(Name="cDReasonIsPrepaymentPenaltyAdded")]
		public bool? CDReasonIsPrepaymentPenaltyAdded { get; set; }

		[DataMember(Name="cDReasonIsRevisionsRequestedByConsumer")]
		public bool? CDReasonIsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="cDReasonIsToleranceCure")]
		public bool? CDReasonIsToleranceCure { get; set; }

		[DataMember(Name="cDReasonOther")]
		public string CDReasonOther { get; set; }

		[DataMember(Name="changeInCircumstance")]
		public string ChangeInCircumstance { get; set; }

		[DataMember(Name="changeInCircumstanceComments")]
		public string ChangeInCircumstanceComments { get; set; }

		[DataMember(Name="changesReceivedDate")]
		public string ChangesReceivedDate { get; set; }

		[DataMember(Name="chargesCannotIncrease10Itemization34")]
		public string ChargesCannotIncrease10Itemization34 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseItemization9")]
		public string ChargesThatCannotDecreaseItemization9 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE7")]
		public string ChargesThatCannotDecreaseLE7 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseItemization13")]
		public string ChargesThatCannotIncreaseItemization13 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE11")]
		public string ChargesThatCannotIncreaseLE11 { get; set; }

		[DataMember(Name="closingDate")]
		public string ClosingDate { get; set; }

		[DataMember(Name="coBorrowerActualReceivedDate")]
		public string CoBorrowerActualReceivedDate { get; set; }

		[DataMember(Name="coBorrowerDisclosedMethod")]
		public string CoBorrowerDisclosedMethod { get; set; }

		[DataMember(Name="coBorrowerDisclosedMethodOther")]
		public string CoBorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="coBorrowerLoanLevelConsentMapForCC")]
		public bool? CoBorrowerLoanLevelConsentMapForCC { get; set; }

		[DataMember(Name="coBorrowerName")]
		public string CoBorrowerName { get; set; }

		[DataMember(Name="coBorrowerPresumedReceivedDate")]
		public string CoBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="coBorrowerType")]
		public string CoBorrowerType { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="containCD")]
		public bool? ContainCD { get; set; }

		[DataMember(Name="containLE")]
		public bool? ContainLE { get; set; }

		[DataMember(Name="containSafeHarbor")]
		public bool? ContainSafeHarbor { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit")]
		public string CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction")]
		public string CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="dateAdded")]
		public DateTime? DateAdded { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="disclosedAPR")]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy")]
		public string DisclosedBy { get; set; }

		[DataMember(Name="disclosedByFullName")]
		public string DisclosedByFullName { get; set; }

		[DataMember(Name="disclosedDailyInterest")]
		public string DisclosedDailyInterest { get; set; }

		[DataMember(Name="disclosedDate")]
		public string DisclosedDate { get; set; }

		[DataMember(Name="disclosedForCD")]
		public bool? DisclosedForCD { get; set; }

		[DataMember(Name="disclosedForLE")]
		public bool? DisclosedForLE { get; set; }

		[DataMember(Name="disclosedMethod")]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosedMethodName")]
		public string DisclosedMethodName { get; set; }

		[DataMember(Name="disclosedMethodOther")]
		public string DisclosedMethodOther { get; set; }

		[DataMember(Name="disclosedSalesPrice")]
		public string DisclosedSalesPrice { get; set; }

		[DataMember(Name="disclosureCreatedDttmUtc")]
		public DateTime? DisclosureCreatedDttmUtc { get; set; }

		[DataMember(Name="disclosureMethod")]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType")]
		public string DisclosureType { get; set; }

		[DataMember(Name="eDisclosureApplicationPackageIndicator")]
		public bool? EDisclosureApplicationPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureApprovalPackageIndicator")]
		public bool? EDisclosureApprovalPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentDate")]
		public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentIP")]
		public string EDisclosureBorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerAuthenticatedDate")]
		public DateTime? EDisclosureBorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerAuthenticatedIP")]
		public string EDisclosureBorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerDocumentViewedDate")]
		public DateTime? EDisclosureBorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerEmail")]
		public string EDisclosureBorrowerEmail { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedDate")]
		public DateTime? EDisclosureBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedIP")]
		public string EDisclosureBorrowereSignedIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerLoanLevelConsent")]
		public string EDisclosureBorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="eDisclosureBorrowerName")]
		public string EDisclosureBorrowerName { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentDate")]
		public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentIP")]
		public string EDisclosureBorrowerRejectConsentIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewConsentDate")]
		public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewMessageDate")]
		public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerWetSignedDate")]
		public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentDate")]
		public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentIP")]
		public string EDisclosureCoBorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAuthenticatedDate")]
		public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAuthenticatedIP")]
		public string EDisclosureCoBorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerDocumentViewedDate")]
		public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerEmail")]
		public string EDisclosureCoBorrowerEmail { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedDate")]
		public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedIP")]
		public string EDisclosureCoBorrowereSignedIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerLoanLevelConsent")]
		public string EDisclosureCoBorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerName")]
		public string EDisclosureCoBorrowerName { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentDate")]
		public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentIP")]
		public string EDisclosureCoBorrowerRejectConsentIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerViewConsentDate")]
		public DateTime? EDisclosureCoBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerViewMessageDate")]
		public DateTime? EDisclosureCoBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerWebSignedDate")]
		public DateTime? EDisclosureCoBorrowerWebSignedDate { get; set; }

		[DataMember(Name="eDisclosureConsentPdf")]
		public string EDisclosureConsentPdf { get; set; }

		[DataMember(Name="eDisclosureDisclosedMessage")]
		public string EDisclosureDisclosedMessage { get; set; }

		[DataMember(Name="eDisclosureLockPackageIndicator")]
		public bool? EDisclosureLockPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureLOeSignedDate")]
		public DateTime? EDisclosureLOeSignedDate { get; set; }

		[DataMember(Name="eDisclosureLOeSignedIP")]
		public string EDisclosureLOeSignedIP { get; set; }

		[DataMember(Name="eDisclosureLOName")]
		public string EDisclosureLOName { get; set; }

		[DataMember(Name="eDisclosureLOViewMessageDate")]
		public DateTime? EDisclosureLOViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentComment")]
		public string EDisclosureManualFulfillmentComment { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentDate")]
		public DateTime? EDisclosureManualFulfillmentDate { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentMethod")]
		public string EDisclosureManualFulfillmentMethod { get; set; }

		[DataMember(Name="eDisclosureManuallyFulfilledBy")]
		public string EDisclosureManuallyFulfilledBy { get; set; }

		[DataMember(Name="eDisclosurePackageCreatedDate")]
		public DateTime? EDisclosurePackageCreatedDate { get; set; }

		[DataMember(Name="eDisclosurePackageId")]
		public string EDisclosurePackageId { get; set; }

		[DataMember(Name="eDisclosurePackageViewableFile")]
		public string EDisclosurePackageViewableFile { get; set; }

		[DataMember(Name="eDisclosureThreeDayPackageIndicator")]
		public bool? EDisclosureThreeDayPackageIndicator { get; set; }

		[DataMember(Name="eDSRequestGuid")]
		public string EDSRequestGuid { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="financeCharge")]
		public string FinanceCharge { get; set; }

		[DataMember(Name="forms")]
		public List<LoanContractForms> Forms { get; set; }

		[DataMember(Name="formsXml")]
		public string FormsXml { get; set; }

		[DataMember(Name="fulfillmentOrderedBy")]
		public string FulfillmentOrderedBy { get; set; }

		[DataMember(Name="fulfillmentOrderedByCoBorrower")]
		public string FulfillmentOrderedByCoBorrower { get; set; }

		[DataMember(Name="fullfillmentProcessedDate")]
		public string FullfillmentProcessedDate { get; set; }

		[DataMember(Name="fullfillmentProcessedDateCoBorrower")]
		public DateTime? FullfillmentProcessedDateCoBorrower { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="intentToProceed")]
		public bool? IntentToProceed { get; set; }

		[DataMember(Name="intentToProceedComments")]
		public string IntentToProceedComments { get; set; }

		[DataMember(Name="intentToProceedDate")]
		public string IntentToProceedDate { get; set; }

		[DataMember(Name="intentToProceedReceivedBy")]
		public string IntentToProceedReceivedBy { get; set; }

		[DataMember(Name="intentToProceedReceivedMethod")]
		public string IntentToProceedReceivedMethod { get; set; }

		[DataMember(Name="intentToProceedReceivedMethodOther")]
		public string IntentToProceedReceivedMethodOther { get; set; }

		[DataMember(Name="isBorrowerPresumedDateLocked")]
		public bool? IsBorrowerPresumedDateLocked { get; set; }

		[DataMember(Name="isBorrowerTypeLocked")]
		public bool? IsBorrowerTypeLocked { get; set; }

		[DataMember(Name="isCoBorrowerPresumedDateLocked")]
		public bool? IsCoBorrowerPresumedDateLocked { get; set; }

		[DataMember(Name="isCoBorrowerTypeLocked")]
		public bool? IsCoBorrowerTypeLocked { get; set; }

		[DataMember(Name="isDisclosed")]
		public string IsDisclosed { get; set; }

		[DataMember(Name="isDisclosedAprLocked")]
		public string IsDisclosedAprLocked { get; set; }

		[DataMember(Name="isDisclosedByLocked")]
		public string IsDisclosedByLocked { get; set; }

		[DataMember(Name="isDisclosedDailyInterestLocked")]
		public bool? IsDisclosedDailyInterestLocked { get; set; }

		[DataMember(Name="isDisclosedFinanceChargeLocked")]
		public string IsDisclosedFinanceChargeLocked { get; set; }

		[DataMember(Name="isDisclosedReceivedDateLocked")]
		public string IsDisclosedReceivedDateLocked { get; set; }

		[DataMember(Name="isIntentReceivedByLocked")]
		public bool? IsIntentReceivedByLocked { get; set; }

		[DataMember(Name="isLocked")]
		public string IsLocked { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isWetSignedIndicator")]
		public bool? IsWetSignedIndicator { get; set; }

		[DataMember(Name="lenderCompensationCreditAmount2")]
		public string LenderCompensationCreditAmount2 { get; set; }

		[DataMember(Name="lenderTotalPaidOriginatorAmount")]
		public string LenderTotalPaidOriginatorAmount { get; set; }

		[DataMember(Name="lEReasonIsChangedCircumstanceEligibility")]
		public bool? LEReasonIsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="lEReasonIsChangedCircumstanceSettlementCharges")]
		public bool? LEReasonIsChangedCircumstanceSettlementCharges { get; set; }

		[DataMember(Name="lEReasonIsDelayedSettlementOnConstructionLoans")]
		public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get; set; }

		[DataMember(Name="lEReasonIsExpiration")]
		public bool? LEReasonIsExpiration { get; set; }

		[DataMember(Name="lEReasonIsInterestRateDependentCharges")]
		public bool? LEReasonIsInterestRateDependentCharges { get; set; }

		[DataMember(Name="lEReasonIsOther")]
		public bool? LEReasonIsOther { get; set; }

		[DataMember(Name="lEReasonIsRevisionsRequestedByConsumer")]
		public bool? LEReasonIsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="lEReasonOther")]
		public string LEReasonOther { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount1")]
		public string Line802LOCompAdditionalAmount1 { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount2")]
		public string Line802LOCompAdditionalAmount2 { get; set; }

		[DataMember(Name="line907InsuranceIndicator2015")]
		public string Line907InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line907PropertyIndicator2015")]
		public string Line907PropertyIndicator2015 { get; set; }

		[DataMember(Name="line907TaxesIndicator2015")]
		public string Line907TaxesIndicator2015 { get; set; }

		[DataMember(Name="line908InsuranceIndicator2015")]
		public string Line908InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line908PropertyIndicator2015")]
		public string Line908PropertyIndicator2015 { get; set; }

		[DataMember(Name="line908TaxesIndicator2015")]
		public string Line908TaxesIndicator2015 { get; set; }

		[DataMember(Name="line909InsuranceIndicator2015")]
		public string Line909InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line909PropertyIndicator2015")]
		public string Line909PropertyIndicator2015 { get; set; }

		[DataMember(Name="line909TaxesIndicator2015")]
		public string Line909TaxesIndicator2015 { get; set; }

		[DataMember(Name="line910InsuranceIndicator2015")]
		public string Line910InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line910PropertyIndicator2015")]
		public string Line910PropertyIndicator2015 { get; set; }

		[DataMember(Name="line910TaxesIndicator2015")]
		public string Line910TaxesIndicator2015 { get; set; }

		[DataMember(Name="line911InsuranceIndicator2015")]
		public string Line911InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line911PropertyIndicator2015")]
		public string Line911PropertyIndicator2015 { get; set; }

		[DataMember(Name="line911TaxesIndicator2015")]
		public string Line911TaxesIndicator2015 { get; set; }

		[DataMember(Name="line912InsuranceIndicator2015")]
		public string Line912InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line912PropertyIndicator2015")]
		public string Line912PropertyIndicator2015 { get; set; }

		[DataMember(Name="line912TaxesIndicator2015")]
		public string Line912TaxesIndicator2015 { get; set; }

		[DataMember(Name="linkedGuid")]
		public string LinkedGuid { get; set; }

		[DataMember(Name="loanAdjustmentsOtherCredits")]
		public string LoanAdjustmentsOtherCredits { get; set; }

		[DataMember(Name="loanAmount")]
		public string LoanAmount { get; set; }

		[DataMember(Name="loanClosingCost2BorrowerClosingCostAtClosing")]
		public string LoanClosingCost2BorrowerClosingCostAtClosing { get; set; }

		[DataMember(Name="loanClosingCost2LenderCredits")]
		public string LoanClosingCost2LenderCredits { get; set; }

		[DataMember(Name="loanClosingCost2TotalLoanCost")]
		public string LoanClosingCost2TotalLoanCost { get; set; }

		[DataMember(Name="loanClosingCost2TotalOtherCost")]
		public string LoanClosingCost2TotalOtherCost { get; set; }

		[DataMember(Name="loanClosingCost3StdLegalLimit")]
		public string LoanClosingCost3StdLegalLimit { get; set; }

		[DataMember(Name="loanClosingCostGfe1200BorPaidAmount")]
		public string LoanClosingCostGfe1200BorPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostGfe800BorPaidAmount")]
		public string LoanClosingCostGfe800BorPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostLenderCredits")]
		public string LoanClosingCostLenderCredits { get; set; }

		[DataMember(Name="loanClosingCostSection1000BorrowerTotalPaidAmount")]
		public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostsFinanced")]
		public string LoanClosingCostsFinanced { get; set; }

		[DataMember(Name="loanClosingCostTotalFeeAmount2015")]
		public string LoanClosingCostTotalFeeAmount2015 { get; set; }

		[DataMember(Name="loanDownPayment")]
		public string LoanDownPayment { get; set; }

		[DataMember(Name="loanEstimate2TotalLoanAndOtherCosts")]
		public string LoanEstimate2TotalLoanAndOtherCosts { get; set; }

		[DataMember(Name="loanEstimate2TotalLoanCosts")]
		public string LoanEstimate2TotalLoanCosts { get; set; }

		[DataMember(Name="loanEstimate2TotalOtherCosts")]
		public string LoanEstimate2TotalOtherCosts { get; set; }

		[DataMember(Name="loanEstimate2UnroundedTotalLoanCosts")]
		public string LoanEstimate2UnroundedTotalLoanCosts { get; set; }

		[DataMember(Name="loanEstimate2UnroundedTotalOtherCosts")]
		public string LoanEstimate2UnroundedTotalOtherCosts { get; set; }

		[DataMember(Name="loanEstimateLoanProduct")]
		public string LoanEstimateLoanProduct { get; set; }

		[DataMember(Name="loanFeesCityTaxBorPaidAmount")]
		public string LoanFeesCityTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFeesStateTaxBorPaidAmount")]
		public string LoanFeesStateTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFundsForBorrower")]
		public string LoanFundsForBorrower { get; set; }

		[DataMember(Name="loanGfeAgregateAdjustment")]
		public string LoanGfeAgregateAdjustment { get; set; }

		[DataMember(Name="loanGfeGovermentRecordingCharges")]
		public string LoanGfeGovermentRecordingCharges { get; set; }

		[DataMember(Name="loanLineItemAmount")]
		public string LoanLineItemAmount { get; set; }

		[DataMember(Name="loanProgram")]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount1")]
		public string LoanPurchaseCreditAmount1 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount2")]
		public string LoanPurchaseCreditAmount2 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount3")]
		public string LoanPurchaseCreditAmount3 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount4")]
		public string LoanPurchaseCreditAmount4 { get; set; }

		[DataMember(Name="loanPurchaseCreditType1")]
		public string LoanPurchaseCreditType1 { get; set; }

		[DataMember(Name="loanPurchaseCreditType2")]
		public string LoanPurchaseCreditType2 { get; set; }

		[DataMember(Name="loanPurchaseCreditType3")]
		public string LoanPurchaseCreditType3 { get; set; }

		[DataMember(Name="loanPurchaseCreditType4")]
		public string LoanPurchaseCreditType4 { get; set; }

		[DataMember(Name="loanRefinanceIncludingDebtsToBePaidOffAmount")]
		public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="loanSection1000SellerPaidTotalAmount")]
		public string LoanSection1000SellerPaidTotalAmount { get; set; }

		[DataMember(Name="loanSellerCreditAmount")]
		public string LoanSellerCreditAmount { get; set; }

		[DataMember(Name="loanTotalClosingCosts")]
		public string LoanTotalClosingCosts { get; set; }

		[DataMember(Name="lockedBorrowerPresumedReceivedDate")]
		public string LockedBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedBorrowerType")]
		public string LockedBorrowerType { get; set; }

		[DataMember(Name="lockedCoBorrowerPresumedReceivedDate")]
		public string LockedCoBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedCoBorrowerType")]
		public string LockedCoBorrowerType { get; set; }

		[DataMember(Name="lockedDisclosedAprField")]
		public string LockedDisclosedAprField { get; set; }

		[DataMember(Name="lockedDisclosedByField")]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedDailyInterestField")]
		public string LockedDisclosedDailyInterestField { get; set; }

		[DataMember(Name="lockedDisclosedDateField")]
		public string LockedDisclosedDateField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField")]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate")]
		public string LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="lockedIntentReceivedByField")]
		public string LockedIntentReceivedByField { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="manuallyCreated")]
		public string ManuallyCreated { get; set; }

		[DataMember(Name="numberOfDisclosureDocs")]
		public int? NumberOfDisclosureDocs { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator")]
		public string PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="presumedFulfillmentDate")]
		public string PresumedFulfillmentDate { get; set; }

		[DataMember(Name="propertyAddress")]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity")]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyState")]
		public string PropertyState { get; set; }

		[DataMember(Name="propertyZip")]
		public string PropertyZip { get; set; }

		[DataMember(Name="providerListSent")]
		public bool? ProviderListSent { get; set; }

		[DataMember(Name="purchasePriceAmount")]
		public string PurchasePriceAmount { get; set; }

		[DataMember(Name="receivedDate")]
		public string ReceivedDate { get; set; }

		[DataMember(Name="revisedDueDate")]
		public string RevisedDueDate { get; set; }

		[DataMember(Name="snapshotFields")]
		public List<LoanContractSnapshotFields> SnapshotFields { get; set; }

		[DataMember(Name="snapshotXml")]
		public string SnapshotXml { get; set; }

		[DataMember(Name="sTDAdjustmentAndOtherCreditsRemark")]
		public string STDAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}