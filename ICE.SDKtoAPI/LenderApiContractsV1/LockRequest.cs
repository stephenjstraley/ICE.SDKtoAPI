using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class LockRequest
    {
        public decimal? UnDiscountedRate { get; set; }
        public decimal? StartingAdjustRate { get; set; }
        public decimal? StartingAdjustPrice { get; set; }
        public string ProgramNotes { get; set; }
        public decimal? ExpectedNetPrice { get; set; }
        public string OnrpDate { get; set; }
        public bool OnrpEligible { get; set; }
        public string CorrespondentCommitmentType { get; set; }
        public string CorrespondentDeliveryType { get; set; }
        public int? CumulatedDaystoExtend { get; set; }
        public int? ExtensionSequenceNumber { get; set; }
        public bool OnrpLock { get; set; }
        public bool Hedging { get; set; }
        public string PenaltyTerm { get; set; }
        public string PrepayPenalty { get; set; }
        public int? DaystoExtend { get; set; }
        public string ExtendedLockExpirationDate { get; set; }
        public string FulfilledDate { get; set; }
        public string LockCancellationComment { get; set; }
        public string LockCancellationDate { get; set; }
        public string LockExtendComment { get; set; }
        public decimal? LockExtendPriceAdjustment { get; set; }
        public decimal? MarginSrpPaidOut { get; set; }
        public bool IsDeliveryType { get; set; }
        public bool IsCancelled { get; set; }
        public string RateStatus { get; set; }
        public bool RequestPending { get; set; }
        public bool ExtensionRequestPending { get; set; }
        public bool CancellationRequestPending { get; set; }
        public bool ReLockRequestPending { get; set; }
        public string RateSheetId { get; set; }
        public string LastRateSetDate { get; set; }
        public int? LockNumberOfDays { get; set; }
        public string LockDate { get; set; }
        public string LockExpirationDate { get; set; }
        public decimal? BaseRate { get; set; }
        public List<RateAdjustment> Adjustments { get; set; }
        public decimal? TotalRateAdjustments { get; set; }
        public decimal? NetRate { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? TotalPriceAdjustments { get; set; }
        public decimal? NetPrice { get; set; }
        public decimal? BaseMarginRate { get; set; }
        public decimal? TotalMarginAdjustments { get; set; }
        public decimal? NetMarginRate { get; set; }
        public string Comments { get; set; }
        public string OriginalLockExpirationDate { get; set; }
        public decimal? SrpPaidOut { get; set; }
        public string LoanProgram { get; set; }
    }
}
