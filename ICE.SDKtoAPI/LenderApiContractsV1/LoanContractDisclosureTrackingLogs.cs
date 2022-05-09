using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDisclosureTrackingLogs
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="applicationDate", EmitDefaultValue=false)]
		public DateTime? ApplicationDate { get; set; }

		[DataMember(Name="borrowerName", EmitDefaultValue=false)]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerPairId", EmitDefaultValue=false)]
		public string BorrowerPairId { get; set; }

		[DataMember(Name="coBorrowerName", EmitDefaultValue=false)]
		public string CoBorrowerName { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="containGfe", EmitDefaultValue=false)]
		public bool? ContainGfe { get; set; }

		[DataMember(Name="containSafeHarbor", EmitDefaultValue=false)]
		public bool? ContainSafeHarbor { get; set; }

		[DataMember(Name="containTil", EmitDefaultValue=false)]
		public bool? ContainTil { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="disclosedAPR", EmitDefaultValue=false)]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy", EmitDefaultValue=false)]
		public string DisclosedBy { get; set; }

		[DataMember(Name="disclosedByFullName", EmitDefaultValue=false)]
		public string DisclosedByFullName { get; set; }

		[DataMember(Name="disclosedMethod", EmitDefaultValue=false)]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosureCreatedDttmUtc", EmitDefaultValue=false)]
		public DateTime? DisclosureCreatedDttmUtc { get; set; }

		[DataMember(Name="eDisclosureApplicationPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureApplicationPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureApprovalPackageIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureApprovalPackageIndicator { get; set; }

		[DataMember(Name="eDisclosureBorrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowereSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerViewMessageDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }

		[DataMember(Name="eDisclosureBorrowerWetSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowereSignedDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }

		[DataMember(Name="eDisclosureCoBorrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }

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

		[DataMember(Name="fullfillmentProcessedDate", EmitDefaultValue=false)]
		public string FullfillmentProcessedDate { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isDisclosed", EmitDefaultValue=false)]
		public string IsDisclosed { get; set; }

		[DataMember(Name="isDisclosedAprLocked", EmitDefaultValue=false)]
		public string IsDisclosedAprLocked { get; set; }

		[DataMember(Name="isDisclosedByLocked", EmitDefaultValue=false)]
		public string IsDisclosedByLocked { get; set; }

		[DataMember(Name="isDisclosedFinanceChargeLocked", EmitDefaultValue=false)]
		public string IsDisclosedFinanceChargeLocked { get; set; }

		[DataMember(Name="isDisclosedReceivedDateLocked", EmitDefaultValue=false)]
		public string IsDisclosedReceivedDateLocked { get; set; }

		[DataMember(Name="isLocked", EmitDefaultValue=false)]
		public string IsLocked { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isWetSignedIndicator", EmitDefaultValue=false)]
		public bool? IsWetSignedIndicator { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public string LoanAmount { get; set; }

		[DataMember(Name="loanProgram", EmitDefaultValue=false)]
		public string LoanProgram { get; set; }

		[DataMember(Name="lockedDisclosedAprField", EmitDefaultValue=false)]
		public string LockedDisclosedAprField { get; set; }

		[DataMember(Name="lockedDisclosedByField", EmitDefaultValue=false)]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField", EmitDefaultValue=false)]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate", EmitDefaultValue=false)]
		public DateTime? LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="manuallyCreated", EmitDefaultValue=false)]
		public string ManuallyCreated { get; set; }

		[DataMember(Name="propertyAddress", EmitDefaultValue=false)]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity", EmitDefaultValue=false)]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyState", EmitDefaultValue=false)]
		public string PropertyState { get; set; }

		[DataMember(Name="propertyZip", EmitDefaultValue=false)]
		public string PropertyZip { get; set; }

		[DataMember(Name="receivedDate", EmitDefaultValue=false)]
		public DateTime? ReceivedDate { get; set; }

		[DataMember(Name="snapshotFields", EmitDefaultValue=false)]
		public List<LoanContractSnapshotFields> SnapshotFields { get; set; }

		[DataMember(Name="snapshotXml", EmitDefaultValue=false)]
		public string SnapshotXml { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}