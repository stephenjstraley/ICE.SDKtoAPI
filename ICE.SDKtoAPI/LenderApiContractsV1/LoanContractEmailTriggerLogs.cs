using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmailTriggerLogs
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="body", EmitDefaultValue=false)]
		public string Body { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="inLogIndicator", EmitDefaultValue=false)]
		public bool? InLogIndicator { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="recipients", EmitDefaultValue=false)]
		public string Recipients { get; set; }

		[DataMember(Name="sender", EmitDefaultValue=false)]
		public string Sender { get; set; }

		[DataMember(Name="subject", EmitDefaultValue=false)]
		public string Subject { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}