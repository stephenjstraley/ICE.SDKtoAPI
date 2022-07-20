using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUnderwritingConditionLogs
	{
		[DataMember(Name="addedBy")]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="allowToClearIndicator")]
		public bool? AllowToClearIndicator { get; set; }

		[DataMember(Name="category")]
		public string Category { get; set; }

		[DataMember(Name="cleared")]
		public bool? Cleared { get; set; }

		[DataMember(Name="clearedBy")]
		public string ClearedBy { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="dateAddedUtc")]
		public DateTime? DateAddedUtc { get; set; }

		[DataMember(Name="dateClearedUtc")]
		public DateTime? DateClearedUtc { get; set; }

		[DataMember(Name="dateExpected")]
		public DateTime? DateExpected { get; set; }

		[DataMember(Name="dateExpiredUtc")]
		public DateTime? DateExpiredUtc { get; set; }

		[DataMember(Name="dateFulfilledUtc")]
		public DateTime? DateFulfilledUtc { get; set; }

		[DataMember(Name="dateReceived")]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateReceivedUtc")]
		public DateTime? DateReceivedUtc { get; set; }

		[DataMember(Name="dateRejectedUtc")]
		public DateTime? DateRejectedUtc { get; set; }

		[DataMember(Name="dateRequestedUtc")]
		public DateTime? DateRequestedUtc { get; set; }

		[DataMember(Name="dateRerequestedUtc")]
		public DateTime? DateRerequestedUtc { get; set; }

		[DataMember(Name="dateReviewedUtc")]
		public DateTime? DateReviewedUtc { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="dateWaivedUtc")]
		public DateTime? DateWaivedUtc { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="details")]
		public string Details { get; set; }

		[DataMember(Name="expected")]
		public bool? Expected { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="forRoleId")]
		public int? ForRoleId { get; set; }

		[DataMember(Name="fulfilled")]
		public bool? Fulfilled { get; set; }

		[DataMember(Name="fulfilledBy")]
		public string FulfilledBy { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isExternalIndicator")]
		public bool? IsExternalIndicator { get; set; }

		[DataMember(Name="isInternalIndicator")]
		public bool? IsInternalIndicator { get; set; }

		[DataMember(Name="isPastDue")]
		public bool? IsPastDue { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="pairId")]
		public string PairId { get; set; }

		[DataMember(Name="priorTo")]
		public string PriorTo { get; set; }

		[DataMember(Name="received")]
		public bool? Received { get; set; }

		[DataMember(Name="receivedBy")]
		public string ReceivedBy { get; set; }

		[DataMember(Name="rejected")]
		public bool? Rejected { get; set; }

		[DataMember(Name="rejectedBy")]
		public string RejectedBy { get; set; }

		[DataMember(Name="requested")]
		public bool? Requested { get; set; }

		[DataMember(Name="requestedBy")]
		public string RequestedBy { get; set; }

		[DataMember(Name="rerequested")]
		public bool? Rerequested { get; set; }

		[DataMember(Name="rerequestedBy")]
		public string RerequestedBy { get; set; }

		[DataMember(Name="reviewed")]
		public bool? Reviewed { get; set; }

		[DataMember(Name="reviewedBy")]
		public string ReviewedBy { get; set; }

		[DataMember(Name="source")]
		public string Source { get; set; }

		[DataMember(Name="status")]
		public object Status { get; set; }

		[DataMember(Name="statusDescription")]
		public string StatusDescription { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

		[DataMember(Name="waived")]
		public bool? Waived { get; set; }

		[DataMember(Name="waivedBy")]
		public string WaivedBy { get; set; }

	}
}