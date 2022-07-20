using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLockConfirmLogs
	{
		[DataMember(Name="alertIndicator")]
		public bool? AlertIndicator { get; set; }

		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="buySideExpirationDate")]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="confirmedBy")]
		public string ConfirmedBy { get; set; }

		[DataMember(Name="confirmedById")]
		public string ConfirmedById { get; set; }

		[DataMember(Name="confirmedByIdIndicator")]
		public bool? ConfirmedByIdIndicator { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="requestGuid")]
		public string RequestGuid { get; set; }

		[DataMember(Name="sellSideDeliveredBy")]
		public string SellSideDeliveredBy { get; set; }

		[DataMember(Name="sellSideDeliveryDate")]
		public DateTime? SellSideDeliveryDate { get; set; }

		[DataMember(Name="sellSideExpirationDate")]
		public DateTime? SellSideExpirationDate { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="timeConfirmed")]
		public string TimeConfirmed { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}