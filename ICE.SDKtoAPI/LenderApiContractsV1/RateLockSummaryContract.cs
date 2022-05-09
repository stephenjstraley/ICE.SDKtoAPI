using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class RateLockSummaryContract
    {
        public string Id { get; set; }
        public string RequestType { get; set; }
        public string RequestStatus { get; set; }
        public string LockStatus { get; set; }
        public int LockNumberOfDays { get; set; }
        public string LockExpirationDate { get; set; }
        public EntityRefContract RequestedBy { get; set; }
        public string RequestedDate { get; set; }
        public string FulfilledDate { get; set; }
        public EntityRefContract FulFilledBy { get; set; }
        public string Investor { get; set; }
        public string InvestorDeliveryDate { get; set; }
        public string InvestorCommitment { get; set; }
        public List<string> RequestIndicators { get; set; }
        public ParentLockRequest ParentLockRequest { get; set; }
    }
}
