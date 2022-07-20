using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPreliminaryConditionLogs
	{
		[DataMember(Name="addedBy")]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="category")]
		public string Category { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="dateAddedUtc")]
		public DateTime? DateAddedUtc { get; set; }

		[DataMember(Name="dateExpected")]
		public DateTime? DateExpected { get; set; }

		[DataMember(Name="dateFulfilled")]
		public DateTime? DateFulfilled { get; set; }

		[DataMember(Name="dateReceived")]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateRequestedUtc")]
		public DateTime? DateRequestedUtc { get; set; }

		[DataMember(Name="dateRerequestedUtc")]
		public DateTime? DateRerequestedUtc { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="details")]
		public string Details { get; set; }

		[DataMember(Name="expected")]
		public bool? Expected { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="fulfilled")]
		public bool? Fulfilled { get; set; }

		[DataMember(Name="fulfilledBy")]
		public string FulfilledBy { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

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

		[DataMember(Name="requested")]
		public bool? Requested { get; set; }

		[DataMember(Name="requestedBy")]
		public string RequestedBy { get; set; }

		[DataMember(Name="rerequested")]
		public bool? Rerequested { get; set; }

		[DataMember(Name="rerequestedBy")]
		public string RerequestedBy { get; set; }

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

		[DataMember(Name="underwriterAccessIndicator")]
		public bool? UnderwriterAccessIndicator { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}