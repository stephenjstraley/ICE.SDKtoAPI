using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLockRequestLogs
	{
		[DataMember(Name="alerts")]
		public List<LoanContractAlerts> Alerts { get; set; }

		[DataMember(Name="alertsXml")]
		public string AlertsXml { get; set; }

		[DataMember(Name="buySideExpirationDate")]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="buySideNewLockExtensionDate")]
		public DateTime? BuySideNewLockExtensionDate { get; set; }

		[DataMember(Name="buySideNumDayExtended")]
		public int? BuySideNumDayExtended { get; set; }

		[DataMember(Name="buySideNumDayLocked")]
		public int? BuySideNumDayLocked { get; set; }

		[DataMember(Name="commentList")]
		public List<LoanContractLogRecordCommentList> CommentList { get; set; }

		[DataMember(Name="commentListXml")]
		public string CommentListXml { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="cumulatedDaystoExtend")]
		public int? CumulatedDaystoExtend { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="fileAttachmentsMigrated")]
		public bool? FileAttachmentsMigrated { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="hideLogIndicator")]
		public bool? HideLogIndicator { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="investorCommitment")]
		public string InvestorCommitment { get; set; }

		[DataMember(Name="investorName")]
		public string InvestorName { get; set; }

		[DataMember(Name="isFakeRequestIndicator")]
		public bool? IsFakeRequestIndicator { get; set; }

		[DataMember(Name="isLockCancellationIndicator")]
		public bool? IsLockCancellationIndicator { get; set; }

		[DataMember(Name="isLockExtensionIndicator")]
		public bool? IsLockExtensionIndicator { get; set; }

		[DataMember(Name="isReLockIndicator")]
		public bool? IsReLockIndicator { get; set; }

		[DataMember(Name="isSystemSpecificIndicator")]
		public bool? IsSystemSpecificIndicator { get; set; }

		[DataMember(Name="logRecordIndex")]
		public int? LogRecordIndex { get; set; }

		[DataMember(Name="numDayLocked")]
		public int? NumDayLocked { get; set; }

		[DataMember(Name="parentLockGuid")]
		public string ParentLockGuid { get; set; }

		[DataMember(Name="rateLockAction")]
		public string RateLockAction { get; set; }

		[DataMember(Name="reLockSequenceNumberForInactiveLock")]
		public int? ReLockSequenceNumberForInactiveLock { get; set; }

		[DataMember(Name="requestedBy")]
		public string RequestedBy { get; set; }

		[DataMember(Name="requestedName")]
		public string RequestedName { get; set; }

		[DataMember(Name="requestedStatus")]
		public string RequestedStatus { get; set; }

		[DataMember(Name="reviseAction")]
		public string ReviseAction { get; set; }

		[DataMember(Name="sellSideDeliveredBy")]
		public string SellSideDeliveredBy { get; set; }

		[DataMember(Name="sellSideDeliveryDate")]
		public DateTime? SellSideDeliveryDate { get; set; }

		[DataMember(Name="sellSideExpirationDate")]
		public DateTime? SellSideExpirationDate { get; set; }

		[DataMember(Name="sellSideNewLockExtensionDate")]
		public DateTime? SellSideNewLockExtensionDate { get; set; }

		[DataMember(Name="sellSideNumDayExtended")]
		public int? SellSideNumDayExtended { get; set; }

		[DataMember(Name="snapshotXml")]
		public string SnapshotXml { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="timeRequested")]
		public string TimeRequested { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}