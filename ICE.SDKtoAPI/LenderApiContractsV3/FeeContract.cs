using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FeeContract
    {
        [DataMember(Name = "feeType")]
        public string FeeType { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "amountPerDay")]
        public decimal? AmountPerDay { get; set; }

        [DataMember(Name = "truncatedAmountPerDay")]
        public decimal? TruncatedAmountPerDay { get; set; }

        [DataMember(Name = "borPaidAmount")]
        public decimal? BorPaidAmount { get; set; }

        [DataMember(Name = "fromDate")]
        public string FromDate { get; set; }

        [DataMember(Name = "toDate")]
        public string ToDate { get; set; }

        [DataMember(Name = "days")]
        public int? Days { get; set; }

        [DataMember(Name = "deedAmount")]
        public decimal? DeedAmount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "fha")]
        public bool? Fha { get; set; }

        [DataMember(Name = "fwbc")]
        public string Fwbc { get; set; }

        [DataMember(Name = "fwsc")]
        public string Fwsc { get; set; }

        [DataMember(Name = "includeAboveNumber")]
        public string IncludeAboveNumber { get; set; }

        [DataMember(Name = "lenderCoverage")]
        public decimal? LenderCoverage { get; set; }

        [DataMember(Name = "monthlyPayment")]
        public decimal? MonthlyPayment { get; set; }

        [DataMember(Name = "mortgageAmount")]
        public decimal? MortgageAmount { get; set; }

        [DataMember(Name = "newHudBorPaidAmount")]
        public string NewHudBorPaidAmount { get; set; }

        [DataMember(Name = "numberOfMonths")]
        public int? NumberOfMonths { get; set; }

        [DataMember(Name = "ownerCoverage")]
        public decimal? OwnerCoverage { get; set; }

        [DataMember(Name = "paidBy")]
        public string PaidBy { get; set; }

        [DataMember(Name = "paidInAdvance")]
        public decimal? PaidInAdvance { get; set; }

        [DataMember(Name = "paidToBroker")]
        public decimal? PaidToBroker { get; set; }

        [DataMember(Name = "paidToName")]
        public string PaidToName { get; set; }

        [DataMember(Name = "paidToOthers")]
        public decimal? PaidToOthers { get; set; }

        [DataMember(Name = "percentage")]
        public decimal? Percentage { get; set; }

        [DataMember(Name = "pfc")]
        public bool? Pfc { get; set; }

        [DataMember(Name = "poc")]
        public bool? Poc { get; set; }

        [DataMember(Name = "ptb")]
        public string Ptb { get; set; }

        [DataMember(Name = "releasesAmount")]
        public decimal? ReleasesAmount { get; set; }

        [DataMember(Name = "sellerPaidAmount")]
        public decimal? SellerPaidAmount { get; set; }

        [DataMember(Name = "use4Decimals")]
        public bool? Use4Decimals { get; set; }
    }
}
