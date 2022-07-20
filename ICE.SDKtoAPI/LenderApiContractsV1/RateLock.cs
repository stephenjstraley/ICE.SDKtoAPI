using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class RateLock
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "corporatePrice2")]
        public decimal? CorporatePrice2 { get; set; }

        [JsonProperty(PropertyName = "requestType")]
        public string RequestType { get; set; }

        [JsonProperty(PropertyName = "requestStatus")]
        public string RequestStatus { get; set; }

        [JsonProperty(PropertyName = "lockStatus")]
        public string LockStatus { get; set; }

        [JsonProperty(PropertyName = "lockNumberOfDays")]
        public int? LockNumberOfDays { get; set; }

        [JsonProperty(PropertyName = "lockExpirationDate")]
        public string LockExpirationDate { get; set; }

        [JsonProperty(PropertyName = "requestedBy")]
        public EntityRefContract RequestedBy { get; set; }

        [JsonProperty(PropertyName = "requestedDate")]
        public DateTime? RequestedDate { get; set; }

        [JsonProperty(PropertyName = "fulfilledDate")]
        public DateTime? FulFilledDate { get; set; }

        [JsonProperty(PropertyName = "fulFilledBy")]
        public EntityRefContract FulFilledBy { get; set; }

        [JsonProperty(PropertyName = "lockRequest")]
        public RateLockRequest LockRequest { get; set; }

        [JsonProperty(PropertyName = "buySideInvestor")]
        public string BuySideInvestor { get; set; }

    }

    public class RateLockRequest : RateLockSheet
    {
        [JsonProperty(PropertyName = "requestedBy")]
        public EntityRefContract RequestedBy { get; set; }
    }

    public class RateLockSheet
    {
        [JsonProperty(PropertyName = "rateSheetId")]
        public string RateSheetId { get; set; }

        [JsonProperty(PropertyName = "lockNumberOfDays")]
        public int? LockNumberOfDays { get; set; }

        [JsonProperty(PropertyName = "lockDate")]
        public string LockDate { get; set; }

        [JsonProperty(PropertyName = "lockExprationDate")]
        public string LockExpirationDate { get; set; }
    }

    public class RateLockDetail
    {
        [JsonProperty(PropertyName = "timeRequested")]
        public string TimeRequested { get; set; }

        [JsonProperty(PropertyName = "requestedBy")]
        public string RequestedBy { get; set; }

        [JsonProperty(PropertyName = "requestedName")]
        public string RequestedName { get; set; }

        [JsonProperty(PropertyName = "requestedStatus")]
        public string RequestedStatus { get; set; }

        [JsonProperty(PropertyName = "buySideExpirationDate")]
        public DateTime? BuySideExpirationDate { get; set; }

        [JsonProperty(PropertyName = "hideLogIndicator")]
        public bool? HideLogIndicator { get; set; }

        [JsonProperty(PropertyName = "isFakeRequestIndicator")]
        public bool? IsFakeRequestIndicator { get; set; }

        [JsonProperty(PropertyName = "isLockCancellationIndicator")]
        public bool? IsLockCancellationIndicator { get; set; }

        [JsonProperty(PropertyName = "isReLockIndicator")]
        public bool? IsReLockIndicator { get; set; }

        [JsonProperty(PropertyName = "numDayLocked")]
        public int? NumberOfDaysLocked { get; set; }

        [JsonProperty(PropertyName = "buySideNumDayExtended")]
        public int? BuySideNumberOfDaysExtended { get; set; }

        [JsonProperty(PropertyName = "buySideNumDayLocked")]
        public int? BuySideNumberOfDaysLocked { get; set; }

        [JsonProperty(PropertyName = "sellSideNumDayExtended")]
        public int? SellSideNumberOfDaysExtended { get; set; }

        [JsonProperty(PropertyName = "sellSideNumDayLocked")]
        public int? SellSideNumberOfDaysLocked { get; set; }

        [JsonProperty(PropertyName = "snapshotFields")]
        public List<LoanContractSnapshotFields> SnapShotFields { get; set; }
    }
    public class ExtendRateLock
    {
        [JsonProperty(PropertyName = "lockRequest")]
        public LockRequest LockReqest { get; set; }
    }
    public class ExtendRateLockDetail
    {
        [JsonProperty(PropertyName = "daysToExtend")]
        public int DaysToExtend { get; set; }

        [JsonProperty(PropertyName = "lockExtendedPriceAdjustment")]
        public decimal LockExtendedPriceAdjustment { get; set; }

        [JsonProperty(PropertyName = "comments")]
        public string comments { get; set; }
    }
    public class ConfirmRateLock
    {
        [JsonProperty(PropertyName = "lockRequest")]
        public ConfirmLockDetail LockReqest { get; set; }
    }

    public class ConfirmLockDetail
    {
        [JsonProperty(PropertyName = "correspondentDeliveryType")]
        public string CorrespondentDeliveryType { get; set; }

        [JsonProperty(PropertyName = "programNotes")]
        public string ProgramNotes { get; set; }

        [JsonProperty(PropertyName = "comment")]
        public string Comments { get; set; }

        [JsonProperty(PropertyName = "baseRate")]
        public decimal BaseRate { get; set; }

        [JsonProperty(PropertyName = "lockDate")]
        public string LockDate { get; set; }

        [JsonProperty(PropertyName = "lockNumberOfDays")]
        public int LockNumberOfDays { get; set; }
    }
}
