using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDownloadLogs
	{
		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="barcodePage")]
		public string BarcodePage { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="dateReceived")]
		public string DateReceived { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="documentId")]
		public string DocumentId { get; set; }

		[DataMember(Name="downloadId")]
		public string DownloadId { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="fileSource")]
		public string FileSource { get; set; }

		[DataMember(Name="fileType")]
		public string FileType { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="receivedBy")]
		public string ReceivedBy { get; set; }

		[DataMember(Name="sender")]
		public string Sender { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}