using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVerificationLogs
	{
		[DataMember(Name="accessedBy", EmitDefaultValue=false)]
		public string AccessedBy { get; set; }

		[DataMember(Name="accessedDateUtc", EmitDefaultValue=false)]
		public DateTime? AccessedDateUtc { get; set; }

		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="allowedRoleDelimitedList", EmitDefaultValue=false)]
		public string AllowedRoleDelimitedList { get; set; }

		[DataMember(Name="allowedRoles", EmitDefaultValue=false)]
		public List<LoanContractAllowedRoles> AllowedRoles { get; set; }

		[DataMember(Name="allowedRolesXml", EmitDefaultValue=false)]
		public string AllowedRolesXml { get; set; }

		[DataMember(Name="archiveDateUtc", EmitDefaultValue=false)]
		public DateTime? ArchiveDateUtc { get; set; }

		[DataMember(Name="archivedBy", EmitDefaultValue=false)]
		public string ArchivedBy { get; set; }

		[DataMember(Name="closingDocumentIndicator", EmitDefaultValue=false)]
		public bool? ClosingDocumentIndicator { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="company", EmitDefaultValue=false)]
		public string Company { get; set; }

		[DataMember(Name="conditions", EmitDefaultValue=false)]
		public List<LoanContractAllowedRoles> Conditions { get; set; }

		[DataMember(Name="conditionsXml", EmitDefaultValue=false)]
		public string ConditionsXml { get; set; }

		[DataMember(Name="dateAddedUtc", EmitDefaultValue=false)]
		public DateTime? DateAddedUtc { get; set; }

		[DataMember(Name="dateExpected", EmitDefaultValue=false)]
		public DateTime? DateExpected { get; set; }

		[DataMember(Name="dateExpires", EmitDefaultValue=false)]
		public DateTime? DateExpires { get; set; }

		[DataMember(Name="dateReceived", EmitDefaultValue=false)]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateRequested", EmitDefaultValue=false)]
		public DateTime? DateRequested { get; set; }

		[DataMember(Name="dateRerequested", EmitDefaultValue=false)]
		public DateTime? DateRerequested { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="daysDue", EmitDefaultValue=false)]
		public int? DaysDue { get; set; }

		[DataMember(Name="daysTillExpire", EmitDefaultValue=false)]
		public int? DaysTillExpire { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="documentDateTimeType", EmitDefaultValue=false)]
		public object DocumentDateTimeType { get; set; }

		[DataMember(Name="docVerificationsXml", EmitDefaultValue=false)]
		public string DocVerificationsXml { get; set; }

		[DataMember(Name="eDisclosureIndicator", EmitDefaultValue=false)]
		public bool? EDisclosureIndicator { get; set; }

		[DataMember(Name="ePassSignature", EmitDefaultValue=false)]
		public string EPassSignature { get; set; }

		[DataMember(Name="expected", EmitDefaultValue=false)]
		public bool? Expected { get; set; }

		[DataMember(Name="expires", EmitDefaultValue=false)]
		public bool? Expires { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="fileAttachmentsXml", EmitDefaultValue=false)]
		public string FileAttachmentsXml { get; set; }

		[DataMember(Name="groupName", EmitDefaultValue=false)]
		public string GroupName { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isAssetVerification", EmitDefaultValue=false)]
		public bool? IsAssetVerification { get; set; }

		[DataMember(Name="isEmploymentVerification", EmitDefaultValue=false)]
		public bool? IsEmploymentVerification { get; set; }

		[DataMember(Name="isEPassIndicator", EmitDefaultValue=false)]
		public bool? IsEPassIndicator { get; set; }

		[DataMember(Name="isExpired", EmitDefaultValue=false)]
		public bool? IsExpired { get; set; }

		[DataMember(Name="isExternalIndicator", EmitDefaultValue=false)]
		public bool? IsExternalIndicator { get; set; }

		[DataMember(Name="isIncomeVerification", EmitDefaultValue=false)]
		public bool? IsIncomeVerification { get; set; }

		[DataMember(Name="isObligationVerification", EmitDefaultValue=false)]
		public bool? IsObligationVerification { get; set; }

		[DataMember(Name="isPastDue", EmitDefaultValue=false)]
		public bool? IsPastDue { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isThirdPartyDocIndicator", EmitDefaultValue=false)]
		public bool? IsThirdPartyDocIndicator { get; set; }

		[DataMember(Name="isTPOWebcenterPortalIndicator", EmitDefaultValue=false)]
		public bool? IsTPOWebcenterPortalIndicator { get; set; }

		[DataMember(Name="isWebCenterIndicator", EmitDefaultValue=false)]
		public bool? IsWebCenterIndicator { get; set; }

		[DataMember(Name="lastAttachmentDateUtc", EmitDefaultValue=false)]
		public DateTime? LastAttachmentDateUtc { get; set; }

		[DataMember(Name="logId", EmitDefaultValue=false)]
		public string LogId { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="orderDateUtc", EmitDefaultValue=false)]
		public DateTime? OrderDateUtc { get; set; }

		[DataMember(Name="pairId", EmitDefaultValue=false)]
		public string PairId { get; set; }

		[DataMember(Name="preClosingDocumentIndicator", EmitDefaultValue=false)]
		public bool? PreClosingDocumentIndicator { get; set; }

		[DataMember(Name="received", EmitDefaultValue=false)]
		public bool? Received { get; set; }

		[DataMember(Name="receiveDateUtc", EmitDefaultValue=false)]
		public DateTime? ReceiveDateUtc { get; set; }

		[DataMember(Name="receivedBy", EmitDefaultValue=false)]
		public string ReceivedBy { get; set; }

		[DataMember(Name="reorderDateUtc", EmitDefaultValue=false)]
		public DateTime? ReorderDateUtc { get; set; }

		[DataMember(Name="requested", EmitDefaultValue=false)]
		public bool? Requested { get; set; }

		[DataMember(Name="requestedBy", EmitDefaultValue=false)]
		public string RequestedBy { get; set; }

		[DataMember(Name="requestedFrom", EmitDefaultValue=false)]
		public string RequestedFrom { get; set; }

		[DataMember(Name="rerequested", EmitDefaultValue=false)]
		public bool? Rerequested { get; set; }

		[DataMember(Name="rerequestedBy", EmitDefaultValue=false)]
		public string RerequestedBy { get; set; }

		[DataMember(Name="reviewed", EmitDefaultValue=false)]
		public bool? Reviewed { get; set; }

		[DataMember(Name="reviewedBy", EmitDefaultValue=false)]
		public string ReviewedBy { get; set; }

		[DataMember(Name="reviewedDateUtc", EmitDefaultValue=false)]
		public DateTime? ReviewedDateUtc { get; set; }

		[DataMember(Name="shippingReady", EmitDefaultValue=false)]
		public bool? ShippingReady { get; set; }

		[DataMember(Name="shippingReadyBy", EmitDefaultValue=false)]
		public string ShippingReadyBy { get; set; }

		[DataMember(Name="shippingReadyDateUtc", EmitDefaultValue=false)]
		public DateTime? ShippingReadyDateUtc { get; set; }

		[DataMember(Name="stage", EmitDefaultValue=false)]
		public string Stage { get; set; }

		[DataMember(Name="status", EmitDefaultValue=false)]
		public string Status { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="underwritingReady", EmitDefaultValue=false)]
		public bool? UnderwritingReady { get; set; }

		[DataMember(Name="underwritingReadyBy", EmitDefaultValue=false)]
		public string UnderwritingReadyBy { get; set; }

		[DataMember(Name="underwritingReadyDateUtc", EmitDefaultValue=false)]
		public DateTime? UnderwritingReadyDateUtc { get; set; }

	}
}