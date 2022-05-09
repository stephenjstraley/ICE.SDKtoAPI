using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDisclosureTracking2015Logs
	{
		[DataMember(Name="actualFulfillmentDate", EmitDefaultValue=false)]
		public string ActualFulfillmentDate { get; set; }

		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public string ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec", EmitDefaultValue=false)]
		public string ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec", EmitDefaultValue=false)]
		public string ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public string ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="applicationDate", EmitDefaultValue=false)]
		public string ApplicationDate { get; set; }

		[DataMember(Name="appliedCureAmount", EmitDefaultValue=false)]
		public string AppliedCureAmount { get; set; }

		[DataMember(Name="automaticFullfillmentServiceName", EmitDefaultValue=false)]
		public string AutomaticFullfillmentServiceName { get; set; }

		[DataMember(Name="borrowerActualReceivedDate", EmitDefaultValue=false)]
		public string BorrowerActualReceivedDate { get; set; }

		[DataMember(Name="borrowerDisclosedMethod", EmitDefaultValue=false)]
		public string BorrowerDisclosedMethod { get; set; }

		[DataMember(Name="borrowerDisclosedMethodOther", EmitDefaultValue=false)]
		public string BorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="borrowerLoanLevelConsentMapForCC", EmitDefaultValue=false)]
		public bool? BorrowerLoanLevelConsentMapForCC { get; set; }

		[DataMember(Name="borrowerName", EmitDefaultValue=false)]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerPairId", EmitDefaultValue=false)]
		public string BorrowerPairId { get; set; }

		[DataMember(Name="borrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string BorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="borrowerType", EmitDefaultValue=false)]
		public string BorrowerType { get; set; }

		[DataMember(Name="brokerDisclosed", EmitDefaultValue=false)]
		public bool? BrokerDisclosed { get; set; }

		[DataMember(Name="cDDateIssued", EmitDefaultValue=false)]
		public string CDDateIssued { get; set; }

		[DataMember(Name="cDReasonIs24HourAdvancePreview", EmitDefaultValue=false)]
		public bool? CDReasonIs24HourAdvancePreview { get; set; }

		[DataMember(Name="cDReasonIsChangedCircumstanceEligibility", EmitDefaultValue=false)]
		public bool? CDReasonIsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="cDReasonIsChangeInAPR", EmitDefaultValue=false)]
		public bool? CDReasonIsChangeInAPR { get; set; }

		[DataMember(Name="cDReasonIsChangeInLoanProduct", EmitDefaultValue=false)]
		public bool? CDReasonIsChangeInLoanProduct { get; set; }

		[DataMember(Name="cDReasonIsChangeInSettlementCharges", EmitDefaultValue=false)]
		public bool? CDReasonIsChangeInSettlementCharges { get; set; }

		[DataMember(Name="cDReasonIsClericalErrorCorrection", EmitDefaultValue=false)]
		public bool? CDReasonIsClericalErrorCorrection { get; set; }

		[DataMember(Name="cDReasonIsInterestRateDependentCharges", EmitDefaultValue=false)]
		public bool? CDReasonIsInterestRateDependentCharges { get; set; }

		[DataMember(Name="cDReasonIsOther", EmitDefaultValue=false)]
		public bool? CDReasonIsOther { get; set; }

		[DataMember(Name="cDReasonIsPrepaymentPenaltyAdded", EmitDefaultValue=false)]
		public bool? CDReasonIsPrepaymentPenaltyAdded { get; set; }

		[DataMember(Name="cDReasonIsRevisionsRequestedByConsumer", EmitDefaultValue=false)]
		public bool? CDReasonIsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="cDReasonIsToleranceCure", EmitDefaultValue=false)]
		public bool? CDReasonIsToleranceCure { get; set; }

		[DataMember(Name="cDReasonOther", EmitDefaultValue=false)]
		public string CDReasonOther { get; set; }

		[DataMember(Name="changeInCircumstance", EmitDefaultValue=false)]
		public string ChangeInCircumstance { get; set; }

		[DataMember(Name="changeInCircumstanceComments", EmitDefaultValue=false)]
		public string ChangeInCircumstanceComments { get; set; }

		[DataMember(Name="changesReceivedDate", EmitDefaultValue=false)]
		public string ChangesReceivedDate { get; set; }

		[DataMember(Name="chargesCannotIncrease10Itemization34", EmitDefaultValue=false)]
		public string ChargesCannotIncrease10Itemization34 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseItemization9", EmitDefaultValue=false)]
		public string ChargesThatCannotDecreaseItemization9 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE7", EmitDefaultValue=false)]
		public string ChargesThatCannotDecreaseLE7 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseItemization13", EmitDefaultValue=false)]
		public string ChargesThatCannotIncreaseItemization13 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE11", EmitDefaultValue=false)]
		public string ChargesThatCannotIncreaseLE11 { get; set; }

		[DataMember(Name="closingDate", EmitDefaultValue=false)]
		public string ClosingDate { get; set; }

		[DataMember(Name="coBorrowerActualReceivedDate", EmitDefaultValue=false)]
		public string CoBorrowerActualReceivedDate { get; set; }

		[DataMember(Name="coBorrowerDisclosedMethod", EmitDefaultValue=false)]
		public string CoBorrowerDisclosedMethod { get; set; }

		[DataMember(Name="coBorrowerDisclosedMethodOther", EmitDefaultValue=false)]
		public string CoBorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="coBorrowerLoanLevelConsentMapForCC", EmitDefaultValue=false)]
		public bool? CoBorrowerLoanLevelConsentMapForCC { get; set; }

		[DataMember(Name="coBorrowerName", EmitDefaultValue=false)]
		public string CoBorrowerName { get; set; }

		[DataMember(Name="coBorrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string CoBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="coBorrowerType", EmitDefaultValue=false)]
		public string CoBorrowerType { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="containCD", EmitDefaultValue=false)]
		public bool? ContainCD { get; set; }

		[DataMember(Name="containLE", EmitDefaultValue=false)]
		public bool? ContainLE { get; set; }

		[DataMember(Name="containSafeHarbor", EmitDefaultValue=false)]
		public bool? ContainSafeHarbor { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit", EmitDefaultValue=false)]
		public string CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction", EmitDefaultValue=false)]
		public string CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="dateAdded", EmitDefaultValue=false)]
		public DateTime? DateAdded { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="disclosedAPR", EmitDefaultValue=false)]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy", EmitDefaultValue=false)]
		public string DisclosedBy { get; set; }

		[DataMember(Name="disclosedByFullName", EmitDefaultValue=false)]
		public string DisclosedByFullName { get; set; }

		[DataMember(Name="disclosedDailyInterest", EmitDefaultValue=false)]
		public string DisclosedDailyInterest { get; set; }

		[DataMember(Name="disclosedDate", EmitDefaultValue=false)]
		public string DisclosedDate { get; set; }

		[DataMember(Name="disclosedForCD", EmitDefaultValue=false)]
		public bool? DisclosedForCD { get; set; }

		[DataMember(Name="disclosedForLE", EmitDefaultValue=false)]
		public bool? DisclosedForLE { get; set; }

		[DataMember(Name="disclosedMethod", EmitDefaultValue=false)]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosedMethodName", EmitDefaultValue=false)]
		public string DisclosedMethodName { get; set; }

		[DataMember(Name="disclosedMethodOther", EmitDefaultValue=false)]
		public string DisclosedMethodOther { get; set; }

		[DataMember(Name="disclosedSalesPrice", EmitDefaultValue=false)]
		public string DisclosedSalesPrice { get; set; }

		[DataMember(Name="disclosureCreatedDttmUtc", EmitDefaultValue=false)]
		public DateTime? DisclosureCreatedDttmUtc { get; set; }

		[DataMember(Name="disclosureMethod", EmitDefaultValue=false)]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType", EmitDefaultValue=false)]
		public string DisclosureType { get; set; }

		[DataMember(Name="eDisclosureApplicationPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureApplicationPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureApprovalPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureApprovalPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentIP", EmitDefaultValue=false)]
		public string EDisclosureBorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerAuthenticatedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerAuthenticatedIP", EmitDefaultValue=false)]
		public string EDisclosureBorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerDocumentViewedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerEmail", EmitDefaultValue=false)]
		public string EDisclosureBorrowerEmail { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedIP", EmitDefaultValue=false)]
		public string EDisclosureBorrowereSignedIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerLoanLevelConsent", EmitDefaultValue=false)]
		public string EDisclosureBorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="eDisclosureBorrowerName", EmitDefaultValue=false)]
		public string EDisclosureBorrowerName { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentIP", EmitDefaultValue=false)]
		public string EDisclosureBorrowerRejectConsentIP { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewMessageDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerWetSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentIP", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAuthenticatedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAuthenticatedIP", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerDocumentViewedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerEmail", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerEmail { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedIP", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowereSignedIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerLoanLevelConsent", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerName", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerName { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentIP", EmitDefaultValue=false)]
		public string EDisclosureCoBorrowerRejectConsentIP { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerViewConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerViewMessageDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerWebSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerWebSignedDate { get; set; }

		[DataMember(Name="eDisclosureConsentPdf", EmitDefaultValue=false)]
		public string EDisclosureConsentPdf { get; set; }

		[DataMember(Name="eDisclosureDisclosedMessage", EmitDefaultValue=false)]
		public string EDisclosureDisclosedMessage { get; set; }

		[DataMember(Name="eDisclosureLockPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureLockPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureLOeSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureLOeSignedDate { get; set; }

		[DataMember(Name="eDisclosureLOeSignedIP", EmitDefaultValue=false)]
		public string EDisclosureLOeSignedIP { get; set; }

		[DataMember(Name="eDisclosureLOName", EmitDefaultValue=false)]
		public string EDisclosureLOName { get; set; }

		[DataMember(Name="eDisclosureLOViewMessageDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureLOViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentComment", EmitDefaultValue=false)]
		public string EDisclosureManualFulfillmentComment { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureManualFulfillmentDate { get; set; }

		[DataMember(Name="eDisclosureManualFulfillmentMethod", EmitDefaultValue=false)]
		public string EDisclosureManualFulfillmentMethod { get; set; }

		[DataMember(Name="eDisclosureManuallyFulfilledBy", EmitDefaultValue=false)]
		public string EDisclosureManuallyFulfilledBy { get; set; }

		[DataMember(Name="eDisclosurePackageCreatedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosurePackageCreatedDate { get; set; }

		[DataMember(Name="eDisclosurePackageId", EmitDefaultValue=false)]
		public string EDisclosurePackageId { get; set; }

		[DataMember(Name="eDisclosurePackageViewableFile", EmitDefaultValue=false)]
		public string EDisclosurePackageViewableFile { get; set; }

		[DataMember(Name="eDisclosureThreeDayPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureThreeDayPackageIndicator { get; set; }

		[DataMember(Name="eDSRequestGuid", EmitDefaultValue=false)]
		public string EDSRequestGuid { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="financeCharge", EmitDefaultValue=false)]
		public string FinanceCharge { get; set; }

		[DataMember(Name="forms", EmitDefaultValue=false)]
		public List<LoanContractForms> Forms { get; set; }

		[DataMember(Name="formsXml", EmitDefaultValue=false)]
		public string FormsXml { get; set; }

		[DataMember(Name="fulfillmentOrderedBy", EmitDefaultValue=false)]
		public string FulfillmentOrderedBy { get; set; }

		[DataMember(Name="fulfillmentOrderedByCoBorrower", EmitDefaultValue=false)]
		public string FulfillmentOrderedByCoBorrower { get; set; }

		[DataMember(Name="fullfillmentProcessedDate", EmitDefaultValue=false)]
		public string FullfillmentProcessedDate { get; set; }

		[DataMember(Name="fullfillmentProcessedDateCoBorrower", EmitDefaultValue=false)]
		public DateTime? FullfillmentProcessedDateCoBorrower { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="intentToProceed", EmitDefaultValue=false)]
		public bool? IntentToProceed { get; set; }

		[DataMember(Name="intentToProceedComments", EmitDefaultValue=false)]
		public string IntentToProceedComments { get; set; }

		[DataMember(Name="intentToProceedDate", EmitDefaultValue=false)]
		public string IntentToProceedDate { get; set; }

		[DataMember(Name="intentToProceedReceivedBy", EmitDefaultValue=false)]
		public string IntentToProceedReceivedBy { get; set; }

		[DataMember(Name="intentToProceedReceivedMethod", EmitDefaultValue=false)]
		public string IntentToProceedReceivedMethod { get; set; }

		[DataMember(Name="intentToProceedReceivedMethodOther", EmitDefaultValue=false)]
		public string IntentToProceedReceivedMethodOther { get; set; }

		[DataMember(Name="isBorrowerPresumedDateLocked", EmitDefaultValue=false)]
		public bool? IsBorrowerPresumedDateLocked { get; set; }

		[DataMember(Name="isBorrowerTypeLocked", EmitDefaultValue=false)]
		public bool? IsBorrowerTypeLocked { get; set; }

		[DataMember(Name="isCoBorrowerPresumedDateLocked", EmitDefaultValue=false)]
		public bool? IsCoBorrowerPresumedDateLocked { get; set; }

		[DataMember(Name="isCoBorrowerTypeLocked", EmitDefaultValue=false)]
		public bool? IsCoBorrowerTypeLocked { get; set; }

		[DataMember(Name="isDisclosed", EmitDefaultValue=false)]
		public string IsDisclosed { get; set; }

		[DataMember(Name="isDisclosedAprLocked", EmitDefaultValue=false)]
		public string IsDisclosedAprLocked { get; set; }

		[DataMember(Name="isDisclosedByLocked", EmitDefaultValue=false)]
		public string IsDisclosedByLocked { get; set; }

		[DataMember(Name="isDisclosedDailyInterestLocked", EmitDefaultValue=false)]
		public bool? IsDisclosedDailyInterestLocked { get; set; }

		[DataMember(Name="isDisclosedFinanceChargeLocked", EmitDefaultValue=false)]
		public string IsDisclosedFinanceChargeLocked { get; set; }

		[DataMember(Name="isDisclosedReceivedDateLocked", EmitDefaultValue=false)]
		public string IsDisclosedReceivedDateLocked { get; set; }

		[DataMember(Name="isIntentReceivedByLocked", EmitDefaultValue=false)]
		public bool? IsIntentReceivedByLocked { get; set; }

		[DataMember(Name="isLocked", EmitDefaultValue=false)]
		public string IsLocked { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isWetSignedIndicator", EmitDefaultValue=false)]
		public bool? IsWetSignedIndicator { get; set; }

		[DataMember(Name="lenderCompensationCreditAmount2", EmitDefaultValue=false)]
		public string LenderCompensationCreditAmount2 { get; set; }

		[DataMember(Name="lenderTotalPaidOriginatorAmount", EmitDefaultValue=false)]
		public string LenderTotalPaidOriginatorAmount { get; set; }

		[DataMember(Name="lEReasonIsChangedCircumstanceEligibility", EmitDefaultValue=false)]
		public bool? LEReasonIsChangedCircumstanceEligibility { get; set; }

		[DataMember(Name="lEReasonIsChangedCircumstanceSettlementCharges", EmitDefaultValue=false)]
		public bool? LEReasonIsChangedCircumstanceSettlementCharges { get; set; }

		[DataMember(Name="lEReasonIsDelayedSettlementOnConstructionLoans", EmitDefaultValue=false)]
		public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get; set; }

		[DataMember(Name="lEReasonIsExpiration", EmitDefaultValue=false)]
		public bool? LEReasonIsExpiration { get; set; }

		[DataMember(Name="lEReasonIsInterestRateDependentCharges", EmitDefaultValue=false)]
		public bool? LEReasonIsInterestRateDependentCharges { get; set; }

		[DataMember(Name="lEReasonIsOther", EmitDefaultValue=false)]
		public bool? LEReasonIsOther { get; set; }

		[DataMember(Name="lEReasonIsRevisionsRequestedByConsumer", EmitDefaultValue=false)]
		public bool? LEReasonIsRevisionsRequestedByConsumer { get; set; }

		[DataMember(Name="lEReasonOther", EmitDefaultValue=false)]
		public string LEReasonOther { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount1", EmitDefaultValue=false)]
		public string Line802LOCompAdditionalAmount1 { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount2", EmitDefaultValue=false)]
		public string Line802LOCompAdditionalAmount2 { get; set; }

		[DataMember(Name="line907InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line907InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line907PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line907PropertyIndicator2015 { get; set; }

		[DataMember(Name="line907TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line907TaxesIndicator2015 { get; set; }

		[DataMember(Name="line908InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line908InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line908PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line908PropertyIndicator2015 { get; set; }

		[DataMember(Name="line908TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line908TaxesIndicator2015 { get; set; }

		[DataMember(Name="line909InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line909InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line909PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line909PropertyIndicator2015 { get; set; }

		[DataMember(Name="line909TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line909TaxesIndicator2015 { get; set; }

		[DataMember(Name="line910InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line910InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line910PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line910PropertyIndicator2015 { get; set; }

		[DataMember(Name="line910TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line910TaxesIndicator2015 { get; set; }

		[DataMember(Name="line911InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line911InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line911PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line911PropertyIndicator2015 { get; set; }

		[DataMember(Name="line911TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line911TaxesIndicator2015 { get; set; }

		[DataMember(Name="line912InsuranceIndicator2015", EmitDefaultValue=false)]
		public string Line912InsuranceIndicator2015 { get; set; }

		[DataMember(Name="line912PropertyIndicator2015", EmitDefaultValue=false)]
		public string Line912PropertyIndicator2015 { get; set; }

		[DataMember(Name="line912TaxesIndicator2015", EmitDefaultValue=false)]
		public string Line912TaxesIndicator2015 { get; set; }

		[DataMember(Name="linkedGuid", EmitDefaultValue=false)]
		public string LinkedGuid { get; set; }

		[DataMember(Name="loanAdjustmentsOtherCredits", EmitDefaultValue=false)]
		public string LoanAdjustmentsOtherCredits { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public string LoanAmount { get; set; }

		[DataMember(Name="loanClosingCost2BorrowerClosingCostAtClosing", EmitDefaultValue=false)]
		public string LoanClosingCost2BorrowerClosingCostAtClosing { get; set; }

		[DataMember(Name="loanClosingCost2LenderCredits", EmitDefaultValue=false)]
		public string LoanClosingCost2LenderCredits { get; set; }

		[DataMember(Name="loanClosingCost2TotalLoanCost", EmitDefaultValue=false)]
		public string LoanClosingCost2TotalLoanCost { get; set; }

		[DataMember(Name="loanClosingCost2TotalOtherCost", EmitDefaultValue=false)]
		public string LoanClosingCost2TotalOtherCost { get; set; }

		[DataMember(Name="loanClosingCost3StdLegalLimit", EmitDefaultValue=false)]
		public string LoanClosingCost3StdLegalLimit { get; set; }

		[DataMember(Name="loanClosingCostGfe1200BorPaidAmount", EmitDefaultValue=false)]
		public string LoanClosingCostGfe1200BorPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostGfe800BorPaidAmount", EmitDefaultValue=false)]
		public string LoanClosingCostGfe800BorPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostLenderCredits", EmitDefaultValue=false)]
		public string LoanClosingCostLenderCredits { get; set; }

		[DataMember(Name="loanClosingCostSection1000BorrowerTotalPaidAmount", EmitDefaultValue=false)]
		public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get; set; }

		[DataMember(Name="loanClosingCostsFinanced", EmitDefaultValue=false)]
		public string LoanClosingCostsFinanced { get; set; }

		[DataMember(Name="loanClosingCostTotalFeeAmount2015", EmitDefaultValue=false)]
		public string LoanClosingCostTotalFeeAmount2015 { get; set; }

		[DataMember(Name="loanDownPayment", EmitDefaultValue=false)]
		public string LoanDownPayment { get; set; }

		[DataMember(Name="loanEstimate2TotalLoanAndOtherCosts", EmitDefaultValue=false)]
		public string LoanEstimate2TotalLoanAndOtherCosts { get; set; }

		[DataMember(Name="loanEstimate2TotalLoanCosts", EmitDefaultValue=false)]
		public string LoanEstimate2TotalLoanCosts { get; set; }

		[DataMember(Name="loanEstimate2TotalOtherCosts", EmitDefaultValue=false)]
		public string LoanEstimate2TotalOtherCosts { get; set; }

		[DataMember(Name="loanEstimate2UnroundedTotalLoanCosts", EmitDefaultValue=false)]
		public string LoanEstimate2UnroundedTotalLoanCosts { get; set; }

		[DataMember(Name="loanEstimate2UnroundedTotalOtherCosts", EmitDefaultValue=false)]
		public string LoanEstimate2UnroundedTotalOtherCosts { get; set; }

		[DataMember(Name="loanEstimateLoanProduct", EmitDefaultValue=false)]
		public string LoanEstimateLoanProduct { get; set; }

		[DataMember(Name="loanFeesCityTaxBorPaidAmount", EmitDefaultValue=false)]
		public string LoanFeesCityTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFeesStateTaxBorPaidAmount", EmitDefaultValue=false)]
		public string LoanFeesStateTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFundsForBorrower", EmitDefaultValue=false)]
		public string LoanFundsForBorrower { get; set; }

		[DataMember(Name="loanGfeAgregateAdjustment", EmitDefaultValue=false)]
		public string LoanGfeAgregateAdjustment { get; set; }

		[DataMember(Name="loanGfeGovermentRecordingCharges", EmitDefaultValue=false)]
		public string LoanGfeGovermentRecordingCharges { get; set; }

		[DataMember(Name="loanLineItemAmount", EmitDefaultValue=false)]
		public string LoanLineItemAmount { get; set; }

		[DataMember(Name="loanProgram", EmitDefaultValue=false)]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount1", EmitDefaultValue=false)]
		public string LoanPurchaseCreditAmount1 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount2", EmitDefaultValue=false)]
		public string LoanPurchaseCreditAmount2 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount3", EmitDefaultValue=false)]
		public string LoanPurchaseCreditAmount3 { get; set; }

		[DataMember(Name="loanPurchaseCreditAmount4", EmitDefaultValue=false)]
		public string LoanPurchaseCreditAmount4 { get; set; }

		[DataMember(Name="loanPurchaseCreditType1", EmitDefaultValue=false)]
		public string LoanPurchaseCreditType1 { get; set; }

		[DataMember(Name="loanPurchaseCreditType2", EmitDefaultValue=false)]
		public string LoanPurchaseCreditType2 { get; set; }

		[DataMember(Name="loanPurchaseCreditType3", EmitDefaultValue=false)]
		public string LoanPurchaseCreditType3 { get; set; }

		[DataMember(Name="loanPurchaseCreditType4", EmitDefaultValue=false)]
		public string LoanPurchaseCreditType4 { get; set; }

		[DataMember(Name="loanRefinanceIncludingDebtsToBePaidOffAmount", EmitDefaultValue=false)]
		public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="loanSection1000SellerPaidTotalAmount", EmitDefaultValue=false)]
		public string LoanSection1000SellerPaidTotalAmount { get; set; }

		[DataMember(Name="loanSellerCreditAmount", EmitDefaultValue=false)]
		public string LoanSellerCreditAmount { get; set; }

		[DataMember(Name="loanTotalClosingCosts", EmitDefaultValue=false)]
		public string LoanTotalClosingCosts { get; set; }

		[DataMember(Name="lockedBorrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string LockedBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedBorrowerType", EmitDefaultValue=false)]
		public string LockedBorrowerType { get; set; }

		[DataMember(Name="lockedCoBorrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string LockedCoBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedCoBorrowerType", EmitDefaultValue=false)]
		public string LockedCoBorrowerType { get; set; }

		[DataMember(Name="lockedDisclosedAprField", EmitDefaultValue=false)]
		public string LockedDisclosedAprField { get; set; }

		[DataMember(Name="lockedDisclosedByField", EmitDefaultValue=false)]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedDailyInterestField", EmitDefaultValue=false)]
		public string LockedDisclosedDailyInterestField { get; set; }

		[DataMember(Name="lockedDisclosedDateField", EmitDefaultValue=false)]
		public string LockedDisclosedDateField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField", EmitDefaultValue=false)]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate", EmitDefaultValue=false)]
		public string LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="lockedIntentReceivedByField", EmitDefaultValue=false)]
		public string LockedIntentReceivedByField { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="manuallyCreated", EmitDefaultValue=false)]
		public string ManuallyCreated { get; set; }

		[DataMember(Name="numberOfDisclosureDocs", EmitDefaultValue=false)]
		public int? NumberOfDisclosureDocs { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator", EmitDefaultValue=false)]
		public string PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="presumedFulfillmentDate", EmitDefaultValue=false)]
		public string PresumedFulfillmentDate { get; set; }

		[DataMember(Name="propertyAddress", EmitDefaultValue=false)]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity", EmitDefaultValue=false)]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyState", EmitDefaultValue=false)]
		public string PropertyState { get; set; }

		[DataMember(Name="propertyZip", EmitDefaultValue=false)]
		public string PropertyZip { get; set; }

		[DataMember(Name="providerListSent", EmitDefaultValue=false)]
		public bool? ProviderListSent { get; set; }

		[DataMember(Name="purchasePriceAmount", EmitDefaultValue=false)]
		public string PurchasePriceAmount { get; set; }

		[DataMember(Name="receivedDate", EmitDefaultValue=false)]
		public string ReceivedDate { get; set; }

		[DataMember(Name="revisedDueDate", EmitDefaultValue=false)]
		public string RevisedDueDate { get; set; }

		[DataMember(Name="snapshotFields", EmitDefaultValue=false)]
		public List<LoanContractSnapshotFields> SnapshotFields { get; set; }

		[DataMember(Name="snapshotXml", EmitDefaultValue=false)]
		public string SnapshotXml { get; set; }

		[DataMember(Name="sTDAdjustmentAndOtherCreditsRemark", EmitDefaultValue=false)]
		public string STDAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}