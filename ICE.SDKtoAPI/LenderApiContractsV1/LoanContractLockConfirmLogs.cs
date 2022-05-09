using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLockConfirmLogs
	{
		[DataMember(Name="alertIndicator", EmitDefaultValue=false)]
		public bool? AlertIndicator { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="buySideExpirationDate", EmitDefaultValue=false)]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="confirmedBy", EmitDefaultValue=false)]
		public string ConfirmedBy { get; set; }

		[DataMember(Name="confirmedById", EmitDefaultValue=false)]
		public string ConfirmedById { get; set; }

		[DataMember(Name="confirmedByIdIndicator", EmitDefaultValue=false)]
		public bool? ConfirmedByIdIndicator { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="requestGuid", EmitDefaultValue=false)]
		public string RequestGuid { get; set; }

		[DataMember(Name="sellSideDeliveredBy", EmitDefaultValue=false)]
		public string SellSideDeliveredBy { get; set; }

		[DataMember(Name="sellSideDeliveryDate", EmitDefaultValue=false)]
		public DateTime? SellSideDeliveryDate { get; set; }

		[DataMember(Name="sellSideExpirationDate", EmitDefaultValue=false)]
		public DateTime? SellSideExpirationDate { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="timeConfirmed", EmitDefaultValue=false)]
		public string TimeConfirmed { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}