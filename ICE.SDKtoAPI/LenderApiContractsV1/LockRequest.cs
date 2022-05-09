using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class LockRequest
    {
        public double? UnDiscountedRate { get; set; }
        public double? StartingAdjustRate { get; set; }
        public double? StartingAdjustPrice { get; set; }
        public string ProgramNotes { get; set; }
        public double? ExpectedNetPrice { get; set; }
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
        public double? LockExtendPriceAdjustment { get; set; }
        public double? MarginSrpPaidOut { get; set; }
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
        public double? BaseRate { get; set; }
        public List<RateAdjustment> Adjustments { get; set; }
        public double? TotalRateAdjustments { get; set; }
        public double? NetRate { get; set; }
        public double? BasePrice { get; set; }
        public double? TotalPriceAdjustments { get; set; }
        public double? NetPrice { get; set; }
        public double? BaseMarginRate { get; set; }
        public double? TotalMarginAdjustments { get; set; }
        public double? NetMarginRate { get; set; }
        public string Comments { get; set; }
        public string OriginalLockExpirationDate { get; set; }
        public double? SrpPaidOut { get; set; }
        public string LoanProgram { get; set; }
    }
}
