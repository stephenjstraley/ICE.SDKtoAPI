using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneTaskLogs
	{
		[DataMember(Name="addDate", EmitDefaultValue=false)]
		public DateTime? AddDate { get; set; }

		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public string AddedBy { get; set; }

		[DataMember(Name="addedByUserId", EmitDefaultValue=false)]
		public string AddedByUserId { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="completed", EmitDefaultValue=false)]
		public bool? Completed { get; set; }

		[DataMember(Name="completedBy", EmitDefaultValue=false)]
		public string CompletedBy { get; set; }

		[DataMember(Name="completedByUserId", EmitDefaultValue=false)]
		public string CompletedByUserId { get; set; }

		[DataMember(Name="completedDateUtc", EmitDefaultValue=false)]
		public DateTime? CompletedDateUtc { get; set; }

		[DataMember(Name="contactCount", EmitDefaultValue=false)]
		public int? ContactCount { get; set; }

		[DataMember(Name="contacts", EmitDefaultValue=false)]
		public List<LoanContractContacts1> Contacts { get; set; }

		[DataMember(Name="contactsXml", EmitDefaultValue=false)]
		public string ContactsXml { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="daysToComplete", EmitDefaultValue=false)]
		public int? DaysToComplete { get; set; }

		[DataMember(Name="daysToCompleteFromSetting", EmitDefaultValue=false)]
		public int? DaysToCompleteFromSetting { get; set; }

		[DataMember(Name="expectedDate", EmitDefaultValue=false)]
		public DateTime? ExpectedDate { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isRequiredIndicator", EmitDefaultValue=false)]
		public bool? IsRequiredIndicator { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="milestoneTaskLogDateUtc", EmitDefaultValue=false)]
		public DateTime? MilestoneTaskLogDateUtc { get; set; }

		[DataMember(Name="priority", EmitDefaultValue=false)]
		public string Priority { get; set; }

		[DataMember(Name="stage", EmitDefaultValue=false)]
		public string Stage { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="taskDescription", EmitDefaultValue=false)]
		public string TaskDescription { get; set; }

		[DataMember(Name="taskGuid", EmitDefaultValue=false)]
		public string TaskGuid { get; set; }

		[DataMember(Name="taskName", EmitDefaultValue=false)]
		public string TaskName { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}