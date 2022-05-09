using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLockRequestLogs
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml", EmitDefaultValue=false)]
		public string AlertsXml { get; set; }

		[DataMember(Name="buySideExpirationDate", EmitDefaultValue=false)]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="buySideNewLockExtensionDate", EmitDefaultValue=false)]
		public DateTime? BuySideNewLockExtensionDate { get; set; }

		[DataMember(Name="buySideNumDayExtended", EmitDefaultValue=false)]
		public int? BuySideNumDayExtended { get; set; }

		[DataMember(Name="buySideNumDayLocked", EmitDefaultValue=false)]
		public int? BuySideNumDayLocked { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml", EmitDefaultValue=false)]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="cumulatedDaystoExtend", EmitDefaultValue=false)]
		public int? CumulatedDaystoExtend { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="hideLogIndicator", EmitDefaultValue=false)]
		public bool? HideLogIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="investorCommitment", EmitDefaultValue=false)]
		public string InvestorCommitment { get; set; }

		[DataMember(Name="investorName", EmitDefaultValue=false)]
		public string InvestorName { get; set; }

		[DataMember(Name="isFakeRequestIndicator", EmitDefaultValue=false)]
		public bool? IsFakeRequestIndicator { get; set; }

		[DataMember(Name="isLockCancellationIndicator", EmitDefaultValue=false)]
		public bool? IsLockCancellationIndicator { get; set; }

		[DataMember(Name="isLockExtensionIndicator", EmitDefaultValue=false)]
		public bool? IsLockExtensionIndicator { get; set; }

		[DataMember(Name="isReLockIndicator", EmitDefaultValue=false)]
		public bool? IsReLockIndicator { get; set; }

		[DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="numDayLocked", EmitDefaultValue=false)]
		public int? NumDayLocked { get; set; }

		[DataMember(Name="parentLockGuid", EmitDefaultValue=false)]
		public string ParentLockGuid { get; set; }

		[DataMember(Name="rateLockAction", EmitDefaultValue=false)]
		public string RateLockAction { get; set; }

		[DataMember(Name="reLockSequenceNumberForInactiveLock", EmitDefaultValue=false)]
		public int? ReLockSequenceNumberForInactiveLock { get; set; }

		[DataMember(Name="requestedBy", EmitDefaultValue=false)]
		public string RequestedBy { get; set; }

		[DataMember(Name="requestedName", EmitDefaultValue=false)]
		public string RequestedName { get; set; }

		[DataMember(Name="requestedStatus", EmitDefaultValue=false)]
		public string RequestedStatus { get; set; }

		[DataMember(Name="reviseAction", EmitDefaultValue=false)]
		public string ReviseAction { get; set; }

		[DataMember(Name="sellSideDeliveredBy", EmitDefaultValue=false)]
		public string SellSideDeliveredBy { get; set; }

		[DataMember(Name="sellSideDeliveryDate", EmitDefaultValue=false)]
		public DateTime? SellSideDeliveryDate { get; set; }

		[DataMember(Name="sellSideExpirationDate", EmitDefaultValue=false)]
		public DateTime? SellSideExpirationDate { get; set; }

		[DataMember(Name="sellSideNewLockExtensionDate", EmitDefaultValue=false)]
		public DateTime? SellSideNewLockExtensionDate { get; set; }

		[DataMember(Name="sellSideNumDayExtended", EmitDefaultValue=false)]
		public int? SellSideNumDayExtended { get; set; }

		[DataMember(Name="snapshotXml", EmitDefaultValue=false)]
		public string SnapshotXml { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="timeRequested", EmitDefaultValue=false)]
		public string TimeRequested { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}