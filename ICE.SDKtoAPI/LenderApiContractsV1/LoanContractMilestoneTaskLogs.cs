using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneTaskLogs
	{
		[DataMember(Name="addDate")]
		public DateTime? AddDate { get; set; }

		[DataMember(Name="addedBy")]
		public string AddedBy { get; set; }

		[DataMember(Name="addedByUserId")]
		public string AddedByUserId { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="completed")]
		public bool? Completed { get; set; }

		[DataMember(Name="completedBy")]
		public string CompletedBy { get; set; }

		[DataMember(Name="completedByUserId")]
		public string CompletedByUserId { get; set; }

		[DataMember(Name="completedDateUtc")]
		public DateTime? CompletedDateUtc { get; set; }

		[DataMember(Name="contactCount")]
		public int? ContactCount { get; set; }

		[DataMember(Name="contacts")]
		public List<LoanContractContacts1> Contacts { get; set; }

		[DataMember(Name="contactsXml")]
		public string ContactsXml { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="daysToComplete")]
		public int? DaysToComplete { get; set; }

		[DataMember(Name="daysToCompleteFromSetting")]
		public int? DaysToCompleteFromSetting { get; set; }

		[DataMember(Name="expectedDate")]
		public DateTime? ExpectedDate { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isRequiredIndicator")]
		public bool? IsRequiredIndicator { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="milestoneTaskLogDateUtc")]
		public DateTime? MilestoneTaskLogDateUtc { get; set; }

		[DataMember(Name="priority")]
		public string Priority { get; set; }

		[DataMember(Name="stage")]
		public string Stage { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="taskDescription")]
		public string TaskDescription { get; set; }

		[DataMember(Name="taskGuid")]
		public string TaskGuid { get; set; }

		[DataMember(Name="taskName")]
		public string TaskName { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}