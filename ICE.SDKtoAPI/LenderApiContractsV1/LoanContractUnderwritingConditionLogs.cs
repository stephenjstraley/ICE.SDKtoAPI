using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUnderwritingConditionLogs
	{
		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="allowToClearIndicator", EmitDefaultValue=false)]
		public bool? AllowToClearIndicator { get; set; }

		[DataMember(Name="category", EmitDefaultValue=false)]
		public string Category { get; set; }

		[DataMember(Name="cleared", EmitDefaultValue=false)]
		public bool? Cleared { get; set; }

		[DataMember(Name="clearedBy", EmitDefaultValue=false)]
		public string ClearedBy { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="dateAddedUtc", EmitDefaultValue=false)]
		public DateTime? DateAddedUtc { get; set; }

		[DataMember(Name="dateClearedUtc", EmitDefaultValue=false)]
		public DateTime? DateClearedUtc { get; set; }

		[DataMember(Name="dateExpected", EmitDefaultValue=false)]
		public DateTime? DateExpected { get; set; }

		[DataMember(Name="dateExpiredUtc", EmitDefaultValue=false)]
		public DateTime? DateExpiredUtc { get; set; }

		[DataMember(Name="dateFulfilledUtc", EmitDefaultValue=false)]
		public DateTime? DateFulfilledUtc { get; set; }

		[DataMember(Name="dateReceived", EmitDefaultValue=false)]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateReceivedUtc", EmitDefaultValue=false)]
		public DateTime? DateReceivedUtc { get; set; }

		[DataMember(Name="dateRejectedUtc", EmitDefaultValue=false)]
		public DateTime? DateRejectedUtc { get; set; }

		[DataMember(Name="dateRequestedUtc", EmitDefaultValue=false)]
		public DateTime? DateRequestedUtc { get; set; }

		[DataMember(Name="dateRerequestedUtc", EmitDefaultValue=false)]
		public DateTime? DateRerequestedUtc { get; set; }

		[DataMember(Name="dateReviewedUtc", EmitDefaultValue=false)]
		public DateTime? DateReviewedUtc { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="dateWaivedUtc", EmitDefaultValue=false)]
		public DateTime? DateWaivedUtc { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="details", EmitDefaultValue=false)]
		public string Details { get; set; }

		[DataMember(Name="expected", EmitDefaultValue=false)]
		public bool? Expected { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="forRoleId", EmitDefaultValue=false)]
		public int? ForRoleId { get; set; }

		[DataMember(Name="fulfilled", EmitDefaultValue=false)]
		public bool? Fulfilled { get; set; }

		[DataMember(Name="fulfilledBy", EmitDefaultValue=false)]
		public string FulfilledBy { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isExternalIndicator", EmitDefaultValue=false)]
		public bool? IsExternalIndicator { get; set; }

		[DataMember(Name="isInternalIndicator", EmitDefaultValue=false)]
		public bool? IsInternalIndicator { get; set; }

		[DataMember(Name="isPastDue", EmitDefaultValue=false)]
		public bool? IsPastDue { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="pairId", EmitDefaultValue=false)]
		public string PairId { get; set; }

		[DataMember(Name="priorTo", EmitDefaultValue=false)]
		public string PriorTo { get; set; }

		[DataMember(Name="received", EmitDefaultValue=false)]
		public bool? Received { get; set; }

		[DataMember(Name="receivedBy", EmitDefaultValue=false)]
		public string ReceivedBy { get; set; }

		[DataMember(Name="rejected", EmitDefaultValue=false)]
		public bool? Rejected { get; set; }

		[DataMember(Name="rejectedBy", EmitDefaultValue=false)]
		public string RejectedBy { get; set; }

		[DataMember(Name="requested", EmitDefaultValue=false)]
		public bool? Requested { get; set; }

		[DataMember(Name="requestedBy", EmitDefaultValue=false)]
		public string RequestedBy { get; set; }

		[DataMember(Name="rerequested", EmitDefaultValue=false)]
		public bool? Rerequested { get; set; }

		[DataMember(Name="rerequestedBy", EmitDefaultValue=false)]
		public string RerequestedBy { get; set; }

		[DataMember(Name="reviewed", EmitDefaultValue=false)]
		public bool? Reviewed { get; set; }

		[DataMember(Name="reviewedBy", EmitDefaultValue=false)]
		public string ReviewedBy { get; set; }

		[DataMember(Name="source", EmitDefaultValue=false)]
		public string Source { get; set; }

		[DataMember(Name="status", EmitDefaultValue=false)]
		public object Status { get; set; }

		[DataMember(Name="statusDescription", EmitDefaultValue=false)]
		public string StatusDescription { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

		[DataMember(Name="waived", EmitDefaultValue=false)]
		public bool? Waived { get; set; }

		[DataMember(Name="waivedBy", EmitDefaultValue=false)]
		public string WaivedBy { get; set; }

	}
}