using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneLogs
	{
		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="days")]
		public int? Days { get; set; }

		[DataMember(Name="doneIndicator")]
		public bool? DoneIndicator { get; set; }

		[DataMember(Name="duration")]
		public int? Duration { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="loanAssociate")]
		public LoanContractLoanAssociate LoanAssociate { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="milestoneIdString")]
		public string MilestoneIdString { get; set; }

		[DataMember(Name="reviewedIndicator")]
		public bool? ReviewedIndicator { get; set; }

		[DataMember(Name="roleRequired")]
		public string RoleRequired { get; set; }

		[DataMember(Name="stage")]
		public string Stage { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="tPOConnectStatus")]
		public string TPOConnectStatus { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}