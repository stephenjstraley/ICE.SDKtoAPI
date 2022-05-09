using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPostClosingConditionLogs
	{
		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public string AddedBy { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

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

		[DataMember(Name="dateReceived", EmitDefaultValue=false)]
		public DateTime? DateReceived { get; set; }

		[DataMember(Name="dateRequestedUtc", EmitDefaultValue=false)]
		public DateTime? DateRequestedUtc { get; set; }

		[DataMember(Name="dateRerequestedUtc", EmitDefaultValue=false)]
		public DateTime? DateRerequestedUtc { get; set; }

		[DataMember(Name="dateSentUtc", EmitDefaultValue=false)]
		public DateTime? DateSentUtc { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="daysTillDue", EmitDefaultValue=false)]
		public int? DaysTillDue { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="details", EmitDefaultValue=false)]
		public string Details { get; set; }

		[DataMember(Name="expected", EmitDefaultValue=false)]
		public bool? Expected { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isPastDue", EmitDefaultValue=false)]
		public bool? IsPastDue { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="pairId", EmitDefaultValue=false)]
		public string PairId { get; set; }

		[DataMember(Name="received", EmitDefaultValue=false)]
		public bool? Received { get; set; }

		[DataMember(Name="receivedBy", EmitDefaultValue=false)]
		public string ReceivedBy { get; set; }

		[DataMember(Name="recipient", EmitDefaultValue=false)]
		public string Recipient { get; set; }

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

		[DataMember(Name="sent", EmitDefaultValue=false)]
		public bool? Sent { get; set; }

		[DataMember(Name="sentBy", EmitDefaultValue=false)]
		public string SentBy { get; set; }

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


	}
}