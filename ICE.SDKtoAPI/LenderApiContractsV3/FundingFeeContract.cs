using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FundingFeeContract
    {
        [DataMember(Name = "cdLineId")]
        public string CdLineId { get; set; }

        [DataMember(Name = "lineId")]
        public string LineId { get; set; }

        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "balanceChecked")]
        public bool BalanceChecked { get; set; }

        [DataMember(Name = "feeDescription")]
        public string FeeDescription { get; set; }

        [DataMember(Name = "feeDescription2015")]
        public string FeeDescription2015 { get; set; }

        [DataMember(Name = "payee")]
        public string Payee { get; set; }

        [DataMember(Name = "paidBy")]
        public string PaidBy { get; set; }

        [DataMember(Name = "paidTo")]
        public string PaidTo { get; set; }

        [DataMember(Name = "amount")]
        public decimal Amount { get; set; }

        [DataMember(Name = "pocAmount")]
        public decimal PocAmount { get; set; }

        [DataMember(Name = "pocPaidBy")]
        public string PocPaidBy { get; set; }

        [DataMember(Name = "ptcAmount")]
        public decimal PtcAmount { get; set; }

        [DataMember(Name = "ptcPaidBy")]
        public string PtcPaidBy { get; set; }

        [DataMember(Name = "tag")]
        public string Tag { get; set; }

        [DataMember(Name = "pocBorrower2015")]
        public decimal PocBorrower2015 { get; set; }

        [DataMember(Name = "pocSeller2015")]
        public decimal PocSeller2015 { get; set; }

        [DataMember(Name = "pocBroker2015")]
        public decimal PocBroker2015 { get; set; }

        [DataMember(Name = "pocOther2015")]
        public decimal PocOther2015 { get; set; }

        [DataMember(Name = "pacBroker2015")]
        public decimal PacBroker2015 { get; set; }

        [DataMember(Name = "pacLender2015")]
        public decimal PacLender2015 { get; set; }

        [DataMember(Name = "pacOther2015")]
        public decimal PacOther2015 { get; set; }

        [DataMember(Name = "pocLender2015")]
        public decimal PocLender2015 { get; set; }
    }
}
