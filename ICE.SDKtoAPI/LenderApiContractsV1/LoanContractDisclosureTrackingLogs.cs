using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDisclosureTrackingLogs
	{
		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="applicationDate")]
		public DateTime? ApplicationDate { get; set; }

		[DataMember(Name="borrowerName")]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerPairId")]
		public string BorrowerPairId { get; set; }

		[DataMember(Name="coBorrowerName")]
		public string CoBorrowerName { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="containGfe")]
		public bool? ContainGfe { get; set; }

		[DataMember(Name="containSafeHarbor")]
		public bool? ContainSafeHarbor { get; set; }

		[DataMember(Name="containTil")]
		public bool? ContainTil { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="disclosedAPR")]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy")]
		public string DisclosedBy { get; set; }

		[DataMember(Name="disclosedByFullName")]
		public string DisclosedByFullName { get; set; }

		[DataMember(Name="disclosedMethod")]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosureCreatedDttmUtc")]
		public DateTime? DisclosureCreatedDttmUtc { get; set; }

		[DataMember(Name="eDisclosureApplicationPackageIndicator")]
		public bool? EDisclosureApplicationPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureApprovalPackageIndicator")]
		public bool? EDisclosureApprovalPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentDate")]
		public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedDate")]
		public DateTime? EDisclosureBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentDate")]
		public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewConsentDate")]
		public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewMessageDate")]
		public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerWetSignedDate")]
		public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentDate")]
		public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedDate")]
		public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentDate")]
		public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }

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

		[DataMember(Name="fullfillmentProcessedDate")]
		public string FullfillmentProcessedDate { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isDisclosed")]
		public string IsDisclosed { get; set; }

		[DataMember(Name="isDisclosedAprLocked")]
		public string IsDisclosedAprLocked { get; set; }

		[DataMember(Name="isDisclosedByLocked")]
		public string IsDisclosedByLocked { get; set; }

		[DataMember(Name="isDisclosedFinanceChargeLocked")]
		public string IsDisclosedFinanceChargeLocked { get; set; }

		[DataMember(Name="isDisclosedReceivedDateLocked")]
		public string IsDisclosedReceivedDateLocked { get; set; }

		[DataMember(Name="isLocked")]
		public string IsLocked { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isWetSignedIndicator")]
		public bool? IsWetSignedIndicator { get; set; }

		[DataMember(Name="loanAmount")]
		public string LoanAmount { get; set; }

		[DataMember(Name="loanProgram")]
		public string LoanProgram { get; set; }

		[DataMember(Name="lockedDisclosedAprField")]
		public string LockedDisclosedAprField { get; set; }

		[DataMember(Name="lockedDisclosedByField")]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField")]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate")]
		public DateTime? LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="manuallyCreated")]
		public string ManuallyCreated { get; set; }

		[DataMember(Name="propertyAddress")]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity")]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyState")]
		public string PropertyState { get; set; }

		[DataMember(Name="propertyZip")]
		public string PropertyZip { get; set; }

		[DataMember(Name="receivedDate")]
		public DateTime? ReceivedDate { get; set; }

		[DataMember(Name="snapshotFields")]
		public List<LoanContractSnapshotFields> SnapshotFields { get; set; }

		[DataMember(Name="snapshotXml")]
		public string SnapshotXml { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}