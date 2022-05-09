using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockRequestContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "buySideExpirationDate")]
        public string BuySideExpirationDate { get; set; }

        [DataMember(Name = "buySideNewLockExtensionDate")]
        public string BuySideNewLockExtensionDate { get; set; }

        [DataMember(Name = "buySideNumDayExtended")]
        public int? BuySideNumDayExtended { get; set; }

        [DataMember(Name = "buySideNumDayLocked")]
        public int? BuySideNumDayLocked { get; set; }

        [DataMember(Name = "hideLogIndicator")]
        public bool? HideLogIndicator { get; set; }

        [DataMember(Name = "isFakeRequestIndicator")]
        public bool? IsFakeRequestIndicator { get; set; }

        [DataMember(Name = "isLockCancellationIndicator")]
        public bool? IsLockCancellationIndicator { get; set; }

        [DataMember(Name = "isLockExtensionIndicator")]
        public bool? IsLockExtensionIndicator { get; set; }

        [DataMember(Name = "isReLockIndicator")]
        public bool? IsReLockIndicator { get; set; }

        [DataMember(Name = "legacyId")]
        public string LegacyId { get; set; }

        [DataMember(Name = "numDayLocked")]
        public int? NumDayLocked { get; set; }

        [DataMember(Name = "parentLockGuid")]
        public string ParentLockGuid { get; set; }

        [DataMember(Name = "requestedBy")]
        public string RequestedBy { get; set; }

        [DataMember(Name = "requestedDate")]
        public string RequestedDate { get; set; }

        [DataMember(Name = "requestedName")]
        public string RequestedName { get; set; }

        [DataMember(Name = "requestedStatus")]
        public string RequestedStatus { get; set; }

        [DataMember(Name = "requestedOldStatus")]
        public string RequestedOldStatus { get; set; }

        [DataMember(Name = "sellSideDeliveredBy")]
        public string SellSideDeliveredBy { get; set; }

        [DataMember(Name = "sellSideDeliveryDate")]
        public string SellSideDeliveryDate { get; set; }

        [DataMember(Name = "sellSideExpirationDate")]
        public string SellSideExpirationDate { get; set; }

        [DataMember(Name = "sellSideNewLockExtensionDate")]
        public string SellSideNewLockExtensionDate { get; set; }

        [DataMember(Name = "sellSideNumDayExtended")]
        public int? SellSideNumDayExtended { get; set; }

        [DataMember(Name = "timeRequested")]
        public string TimeRequested { get; set; }

        [DataMember(Name = "investorCommitment")]
        public string InvestorCommitment { get; set; }

        [DataMember(Name = "cumulatedDaystoExtend")]
        public int? CumulatedDaystoExtend { get; set; }

        [DataMember(Name = "investorName")]
        public string InvestorName { get; set; }

        [DataMember(Name = "rateLockAction")]
        public string RateLockAction { get; set; }

        [DataMember(Name = "reviseAction")]
        public string ReviseAction { get; set; }

        [DataMember(Name = "reLockSequenceNumberForInactiveLock")]
        public int? ReLockSequenceNumberForInactiveLock { get; set; }

        [DataMember(Name = "snapshotFields")]
        public List<LogSnapshotField> SnapshotFields { get; set; }

        [DataMember(Name = "voided")]
        public bool? Voided { get; set; }

    }
}
