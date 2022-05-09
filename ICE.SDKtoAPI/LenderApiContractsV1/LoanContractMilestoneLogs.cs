using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneLogs
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="days", EmitDefaultValue=false)]
		public int? Days { get; set; }

		[DataMember(Name="doneIndicator", EmitDefaultValue=false)]
		public bool? DoneIndicator { get; set; }

		[DataMember(Name="duration", EmitDefaultValue=false)]
		public int? Duration { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="loanAssociate", EmitDefaultValue=false)]
		public LoanContractLoanAssociate LoanAssociate { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="milestoneIdString", EmitDefaultValue=false)]
		public string MilestoneIdString { get; set; }

		[DataMember(Name="reviewedIndicator", EmitDefaultValue=false)]
		public bool? ReviewedIndicator { get; set; }

		[DataMember(Name="roleRequired", EmitDefaultValue=false)]
		public string RoleRequired { get; set; }

		[DataMember(Name="stage", EmitDefaultValue=false)]
		public string Stage { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="tPOConnectStatus", EmitDefaultValue=false)]
		public string TPOConnectStatus { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}