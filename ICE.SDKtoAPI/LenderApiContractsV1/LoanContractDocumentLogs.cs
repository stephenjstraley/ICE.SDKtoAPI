using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentLogs
	{
		[DataMember(Name="accessedBy")]
		public string AccessedBy { get; set; }

		[DataMember(Name="accessedDateUtc")]
		public DateTime? AccessedDateUtc { get; set; }

		[DataMember(Name="addedBy")]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="allowedRoleDelimitedList")]
		public string AllowedRoleDelimitedList { get; set; }

		[DataMember(Name="allowedRoles")]
		public List<LoanContractAllowedRoles> AllowedRoles { get; set; }

		[DataMember(Name="allowedRolesXml")]
		public string AllowedRolesXml { get; set; }

		[DataMember(Name="archiveDateUtc")]
		public DateTime? ArchiveDateUtc { get; set; }

		[DataMember(Name="archivedBy")]
		public string ArchivedBy { get; set; }

		[DataMember(Name="closingDocumentIndicator")]
		public bool? ClosingDocumentIndicator { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="company")]
		public string Company { get; set; }

		[DataMember(Name="conditions")]
		public List<LoanContractAllowedRoles> Conditions { get; set; }

		[DataMember(Name="conditionsXml")]
		public string ConditionsXml { get; set; }

		[DataMember(Name="dateAddedUtc")]
		public DateTime? DateAddedUtc { get; set; }

		[DataMember(Name="dateExpected")]
		public DateTime? DateExpected { get; set; }

		[DataMember(Name="dateExpires")]
		public DateTime? DateExpires { get; set; }

		[DataMember(Name="dateReceived")]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateRequested")]
		public DateTime? DateRequested { get; set; }

		[DataMember(Name="dateRerequested")]
		public DateTime? DateRerequested { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="daysDue")]
		public int? DaysDue { get; set; }

		[DataMember(Name="daysTillExpire")]
		public int? DaysTillExpire { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="documentDateTimeType")]
		public object DocumentDateTimeType { get; set; }

		[DataMember(Name="docVerificationsXml")]
		public string DocVerificationsXml { get; set; }

		[DataMember(Name="eDisclosureIndicator")]
		public bool? EDisclosureIndicator { get; set; }

		[DataMember(Name="ePassSignature")]
		public string EPassSignature { get; set; }

		[DataMember(Name="expected")]
		public bool? Expected { get; set; }

		[DataMember(Name="expires")]
		public bool? Expires { get; set; }

		[DataMember(Name="fileAttachmentReferences")]
		public List<LoanContractFileAttachmentReferences> FileAttachmentReferences { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="fileAttachmentsXml")]
		public string FileAttachmentsXml { get; set; }

		[DataMember(Name="groupName")]
		public string GroupName { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isAssetVerification")]
		public bool? IsAssetVerification { get; set; }

		[DataMember(Name="isEmploymentVerification")]
		public bool? IsEmploymentVerification { get; set; }

		[DataMember(Name="isEPassIndicator")]
		public bool? IsEPassIndicator { get; set; }

		[DataMember(Name="isExpired")]
		public bool? IsExpired { get; set; }

		[DataMember(Name="isExternalIndicator")]
		public bool? IsExternalIndicator { get; set; }

		[DataMember(Name="isIncomeVerification")]
		public bool? IsIncomeVerification { get; set; }

		[DataMember(Name="isObligationVerification")]
		public bool? IsObligationVerification { get; set; }

		[DataMember(Name="isPastDue")]
		public bool? IsPastDue { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="isThirdPartyDocIndicator")]
		public bool? IsThirdPartyDocIndicator { get; set; }

		[DataMember(Name="isTPOWebcenterPortalIndicator")]
		public bool? IsTPOWebcenterPortalIndicator { get; set; }

		[DataMember(Name="isWebCenterIndicator")]
		public bool? IsWebCenterIndicator { get; set; }

		[DataMember(Name="lastAttachmentDateUtc")]
		public DateTime? LastAttachmentDateUtc { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="orderDateUtc")]
		public DateTime? OrderDateUtc { get; set; }

		[DataMember(Name="pairId")]
		public string PairId { get; set; }

		[DataMember(Name="preClosingDocumentIndicator")]
		public bool? PreClosingDocumentIndicator { get; set; }

		[DataMember(Name="received")]
		public bool? Received { get; set; }

		[DataMember(Name="receiveDateUtc")]
		public DateTime? ReceiveDateUtc { get; set; }

		[DataMember(Name="receivedBy")]
		public string ReceivedBy { get; set; }

		[DataMember(Name="reorderDateUtc")]
		public DateTime? ReorderDateUtc { get; set; }

		[DataMember(Name="requested")]
		public bool? Requested { get; set; }

		[DataMember(Name="requestedBy")]
		public string RequestedBy { get; set; }

		[DataMember(Name="requestedFrom")]
		public string RequestedFrom { get; set; }

		[DataMember(Name="rerequested")]
		public bool? Rerequested { get; set; }

		[DataMember(Name="rerequestedBy")]
		public string RerequestedBy { get; set; }

		[DataMember(Name="reviewed")]
		public bool? Reviewed { get; set; }

		[DataMember(Name="reviewedBy")]
		public string ReviewedBy { get; set; }

		[DataMember(Name="reviewedDateUtc")]
		public DateTime? ReviewedDateUtc { get; set; }

		[DataMember(Name="shippingReady")]
		public bool? ShippingReady { get; set; }

		[DataMember(Name="shippingReadyBy")]
		public string ShippingReadyBy { get; set; }

		[DataMember(Name="shippingReadyDateUtc")]
		public DateTime? ShippingReadyDateUtc { get; set; }

		[DataMember(Name="stage")]
		public string Stage { get; set; }

		[DataMember(Name="status")]
		public string Status { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="underwritingReady")]
		public bool? UnderwritingReady { get; set; }

		[DataMember(Name="underwritingReadyBy")]
		public string UnderwritingReadyBy { get; set; }

		[DataMember(Name="underwritingReadyDateUtc")]
		public DateTime? UnderwritingReadyDateUtc { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}