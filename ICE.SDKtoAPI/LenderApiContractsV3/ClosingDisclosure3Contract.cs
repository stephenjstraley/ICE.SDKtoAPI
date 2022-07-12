using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingDisclosure3Contract
    {
        [DataMember(Name = "closingCostsPaidAtClosing")]
        public decimal? ClosingCostsPaidAtClosing { get; set; }

        [DataMember(Name = "adjustments061")]
        public string Adjustments061 { get; set; }

        [DataMember(Name = "adjustments062")]
        public decimal? Adjustments062 { get; set; }

        [DataMember(Name = "adjustments071")]
        public string Adjustments071 { get; set; }

        [DataMember(Name = "adjustments072")]
        public decimal? Adjustments072 { get; set; }

        [DataMember(Name = "adjustments151")]
        public string Adjustments151 { get; set; }

        [DataMember(Name = "adjustments152")]
        public decimal? Adjustments152 { get; set; }

        [DataMember(Name = "otherCredits61")]
        public string OtherCredits61 { get; set; }

        [DataMember(Name = "otherCredits62")]
        public decimal? OtherCredits62 { get; set; }

        [DataMember(Name = "otherCredits71")]
        public string OtherCredits71 { get; set; }

        [DataMember(Name = "otherCredits72")]
        public decimal? OtherCredits72 { get; set; }

        [DataMember(Name = "adjustments81")]
        public string Adjustments81 { get; set; }

        [DataMember(Name = "adjustments82")]
        public decimal? Adjustments82 { get; set; }

        [DataMember(Name = "adjustments91")]
        public string Adjustments91 { get; set; }

        [DataMember(Name = "adjustments92")]
        public decimal? Adjustments92 { get; set; }

        [DataMember(Name = "adjustments101")]
        public string Adjustments101 { get; set; }

        [DataMember(Name = "adjustments102")]
        public decimal? Adjustments102 { get; set; }

        [DataMember(Name = "adjustments111")]
        public string Adjustments111 { get; set; }

        [DataMember(Name = "adjustments112")]
        public decimal? Adjustments112 { get; set; }

        [DataMember(Name = "totalDuefromBorrowerAtClosing")]
        public decimal? TotalDuefromBorrowerAtClosing { get; set; }

        [DataMember(Name = "totalPaidAlreadybyoronBehalfofBoroweratClosing")]
        public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get; set; }

        [DataMember(Name = "cashToClose")]
        public decimal? CashToClose { get; set; }

        [DataMember(Name = "dueToSellerAtClosing61")]
        public string DueToSellerAtClosing61 { get; set; }

        [DataMember(Name = "dueToSellerAtClosing62")]
        public decimal? DueToSellerAtClosing62 { get; set; }

        [DataMember(Name = "dueToSellerAtClosing71")]
        public string DueToSellerAtClosing71 { get; set; }

        [DataMember(Name = "dueToSellerAtClosing72")]
        public decimal? DueToSellerAtClosing72 { get; set; }

        [DataMember(Name = "dueToSellerAtClosing81")]
        public string DueToSellerAtClosing81 { get; set; }

        [DataMember(Name = "dueToSellerAtClosing82")]
        public decimal? DueToSellerAtClosing82 { get; set; }

        [DataMember(Name = "adjustmentsforItemsPaidbySellerinAdvance161")]
        public string AdjustmentsforItemsPaidbySellerinAdvance161 { get; set; }

        [DataMember(Name = "adjustmentsforItemsPaidbySellerinAdvance162")]
        public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get; set; }

        [DataMember(Name = "duefromSelleratClosing111")]
        public string DuefromSelleratClosing111 { get; set; }

        [DataMember(Name = "duefromSelleratClosing112")]
        public decimal? DuefromSelleratClosing112 { get; set; }

        [DataMember(Name = "duefromSelleratClosing121")]
        public string DuefromSelleratClosing121 { get; set; }

        [DataMember(Name = "duefromSelleratClosing122")]
        public decimal? DuefromSelleratClosing122 { get; set; }

        [DataMember(Name = "duefromSelleratClosing131")]
        public string DuefromSelleratClosing131 { get; set; }

        [DataMember(Name = "duefromSelleratClosing132")]
        public decimal? DuefromSelleratClosing132 { get; set; }

        [DataMember(Name = "totalDuetoSelleratClosingM")]
        public decimal? TotalDuetoSelleratClosingM { get; set; }

        [DataMember(Name = "totalDuefromSelleratClosingN")]
        public decimal? TotalDuefromSelleratClosingN { get; set; }

        [DataMember(Name = "cash")]
        public decimal? Cash { get; set; }

        [DataMember(Name = "totalFromK")]
        public decimal? TotalFromK { get; set; }

        [DataMember(Name = "totalFromL")]
        public decimal? TotalFromL { get; set; }

        [DataMember(Name = "totalFromM")]
        public decimal? TotalFromM { get; set; }

        [DataMember(Name = "totalFromN")]
        public decimal? TotalFromN { get; set; }

        [DataMember(Name = "finalCashToClose")]
        public decimal? FinalCashToClose { get; set; }

        [DataMember(Name = "closingCostsPaidatClosingJ")]
        public decimal? ClosingCostsPaidatClosingJ { get; set; }

        [DataMember(Name = "fromToBorrower")]
        public string FromToBorrower { get; set; }

        [DataMember(Name = "fromToSeller")]
        public string FromToSeller { get; set; }

        [DataMember(Name = "liabilityTo1")]
        public string LiabilityTo1 { get; set; }

        [DataMember(Name = "liabilityTo2")]
        public string LiabilityTo2 { get; set; }

        [DataMember(Name = "liabilityTo3")]
        public string LiabilityTo3 { get; set; }

        [DataMember(Name = "liabilityTo4")]
        public string LiabilityTo4 { get; set; }

        [DataMember(Name = "liabilityTo5")]
        public string LiabilityTo5 { get; set; }

        [DataMember(Name = "liabilityTo6")]
        public string LiabilityTo6 { get; set; }

        [DataMember(Name = "liabilityTo7")]
        public string LiabilityTo7 { get; set; }

        [DataMember(Name = "liabilityTo8")]
        public string LiabilityTo8 { get; set; }

        [DataMember(Name = "liabilityTo9")]
        public string LiabilityTo9 { get; set; }

        [DataMember(Name = "liabilityTo10")]
        public string LiabilityTo10 { get; set; }

        [DataMember(Name = "liabilityTo11")]
        public string LiabilityTo11 { get; set; }

        [DataMember(Name = "liabilityTo12")]
        public string LiabilityTo12 { get; set; }

        [DataMember(Name = "liabilityTo13")]
        public string LiabilityTo13 { get; set; }

        [DataMember(Name = "liabilityTo14")]
        public string LiabilityTo14 { get; set; }

        [DataMember(Name = "liabilityTo15")]
        public string LiabilityTo15 { get; set; }

        [DataMember(Name = "liabilityAmount1")]
        public decimal? LiabilityAmount1 { get; set; }

        [DataMember(Name = "liabilityAmount2")]
        public decimal? LiabilityAmount2 { get; set; }

        [DataMember(Name = "liabilityAmount3")]
        public decimal? LiabilityAmount3 { get; set; }

        [DataMember(Name = "liabilityAmount4")]
        public decimal? LiabilityAmount4 { get; set; }

        [DataMember(Name = "liabilityAmount5")]
        public decimal? LiabilityAmount5 { get; set; }

        [DataMember(Name = "liabilityAmount6")]
        public decimal? LiabilityAmount6 { get; set; }

        [DataMember(Name = "liabilityAmount7")]
        public decimal? LiabilityAmount7 { get; set; }

        [DataMember(Name = "liabilityAmount8")]
        public decimal? LiabilityAmount8 { get; set; }

        [DataMember(Name = "liabilityAmount9")]
        public decimal? LiabilityAmount9 { get; set; }

        [DataMember(Name = "liabilityAmount10")]
        public decimal? LiabilityAmount10 { get; set; }

        [DataMember(Name = "liabilityAmount11")]
        public decimal? LiabilityAmount11 { get; set; }

        [DataMember(Name = "liabilityAmount12")]
        public decimal? LiabilityAmount12 { get; set; }

        [DataMember(Name = "liabilityAmount13")]
        public decimal? LiabilityAmount13 { get; set; }

        [DataMember(Name = "liabilityAmount14")]
        public decimal? LiabilityAmount14 { get; set; }

        [DataMember(Name = "liabilityAmount15")]
        public decimal? LiabilityAmount15 { get; set; }

        [DataMember(Name = "liabilityTotal")]
        public decimal? LiabilityTotal { get; set; }

        [DataMember(Name = "loanAmount")]
        public decimal? LoanAmount { get; set; }

        [DataMember(Name = "cd3TotalClosingCostJ")]
        public decimal? Cd3TotalClosingCostJ { get; set; }

        [DataMember(Name = "cd3ClosingCostsPaidBeforeClosing")]
        public decimal? Cd3ClosingCostsPaidBeforeClosing { get; set; }

        [DataMember(Name = "cd3TotalPayoffsAndPaymentsK")]
        public decimal? Cd3TotalPayoffsAndPaymentsK { get; set; }

        [DataMember(Name = "cd3CashToClose")]
        public decimal? Cd3CashToClose { get; set; }

        [DataMember(Name = "cd3CashToCloseFromToBorrower")]
        public string Cd3CashToCloseFromToBorrower { get; set; }

        [DataMember(Name = "leLoanAmount")]
        public decimal? LeLoanAmount { get; set; }

        [DataMember(Name = "lecd3TotalClosingCostJ")]
        public decimal? Lecd3TotalClosingCostJ { get; set; }

        [DataMember(Name = "lecd3ClosingCostsPaidBeforeClosing")]
        public decimal? Lecd3ClosingCostsPaidBeforeClosing { get; set; }

        [DataMember(Name = "lecd3TotalPayoffsAndPaymentsK")]
        public decimal? Lecd3TotalPayoffsAndPaymentsK { get; set; }

        [DataMember(Name = "lecd3CashToClose")]
        public decimal? Lecd3CashToClose { get; set; }

        [DataMember(Name = "lecd3CashToCloseFromToBorrower")]
        public string Lecd3CashToCloseFromToBorrower { get; set; }

        [DataMember(Name = "stdleTotalClosingCostJ")]
        public decimal? StdleTotalClosingCostJ { get; set; }

        [DataMember(Name = "stdleCd3ClosingCostsPaidBeforeClosing")]
        public decimal? StdleCd3ClosingCostsPaidBeforeClosing { get; set; }

        [DataMember(Name = "stdleClosingCostFinanced")]
        public decimal? StdleClosingCostFinanced { get; set; }

        [DataMember(Name = "stdleDownPayment")]
        public decimal? StdleDownPayment { get; set; }

        [DataMember(Name = "stdleDeposit")]
        public decimal? StdleDeposit { get; set; }

        [DataMember(Name = "stdleFundForBorrower")]
        public decimal? StdleFundForBorrower { get; set; }

        [DataMember(Name = "stdleSellerCredits")]
        public decimal? StdleSellerCredits { get; set; }

        [DataMember(Name = "stdleAdjustmentAndOtherCredits")]
        public decimal? StdleAdjustmentAndOtherCredits { get; set; }

        [DataMember(Name = "stdleCashToClose")]
        public decimal? StdleCashToClose { get; set; }

        [DataMember(Name = "stdFinalTotalClosingCostJ")]
        public decimal? StdFinalTotalClosingCostJ { get; set; }

        [DataMember(Name = "stdFinalCd3ClosingCostsPaidBeforeClosing")]
        public decimal? StdFinalCd3ClosingCostsPaidBeforeClosing { get; set; }

        [DataMember(Name = "stdFinalClosingCostFinanced")]
        public decimal? StdFinalClosingCostFinanced { get; set; }

        [DataMember(Name = "stdFinalDownPayment")]
        public decimal? StdFinalDownPayment { get; set; }

        [DataMember(Name = "stdFinalDeposit")]
        public decimal? StdFinalDeposit { get; set; }

        [DataMember(Name = "stdFinalFundForBorrower")]
        public decimal? StdFinalFundForBorrower { get; set; }

        [DataMember(Name = "stdFinalSellerCredits")]
        public decimal? StdFinalSellerCredits { get; set; }

        [DataMember(Name = "stdFinalAdjustmentAndOtherCredits")]
        public decimal? StdFinalAdjustmentAndOtherCredits { get; set; }

        [DataMember(Name = "stdFinalCashToClose")]
        public decimal? StdFinalCashToClose { get; set; }

        [DataMember(Name = "stdTotalClosingCostDidChangeCol")]
        public string StdTotalClosingCostDidChangeCol { get; set; }

        [DataMember(Name = "stdTotalClosingCostBeforeClosingDidChangeCol")]
        public string StdTotalClosingCostBeforeClosingDidChangeCol { get; set; }

        [DataMember(Name = "stdDownPaymentDidChangeCol")]
        public string StdDownPaymentDidChangeCol { get; set; }

        [DataMember(Name = "stdDepositDidChangeCol")]
        public string StdDepositDidChangeCol { get; set; }

        [DataMember(Name = "stdFundsForBorrowerDidChangeCol")]
        public string StdFundsForBorrowerDidChangeCol { get; set; }

        [DataMember(Name = "stdSellerCreditsDidChangeCol")]
        public string StdSellerCreditsDidChangeCol { get; set; }

        [DataMember(Name = "stdAdjustmentsDidChangeCol")]
        public string StdAdjustmentsDidChangeCol { get; set; }

        [DataMember(Name = "altLoanAmountDidChangeCol")]
        public string AltLoanAmountDidChangeCol { get; set; }

        [DataMember(Name = "altTotalClosingCostDidChangeCol")]
        public string AltTotalClosingCostDidChangeCol { get; set; }

        [DataMember(Name = "altClosingCostBeforeClosingDidChangeCol")]
        public string AltClosingCostBeforeClosingDidChangeCol { get; set; }

        [DataMember(Name = "altTotalPayoffsDidChangeCol")]
        public string AltTotalPayoffsDidChangeCol { get; set; }

        [DataMember(Name = "altCashToCloseDidChangeCol")]
        public string AltCashToCloseDidChangeCol { get; set; }

        [DataMember(Name = "stdTotalClosingCostRemark")]
        public string StdTotalClosingCostRemark { get; set; }

        [DataMember(Name = "stdDownPaymentIncDecRemark")]
        public string StdDownPaymentIncDecRemark { get; set; }

        [DataMember(Name = "stdClosingCostFinancedDidChangeCol")]
        public string StdClosingCostFinancedDidChangeCol { get; set; }

        [DataMember(Name = "stdDownPaymentSectionRemark")]
        public string StdDownPaymentSectionRemark { get; set; }

        [DataMember(Name = "stdDepositIncDecRemark")]
        public string StdDepositIncDecRemark { get; set; }

        [DataMember(Name = "stdFundsForBorrowerIncDecRemark")]
        public string StdFundsForBorrowerIncDecRemark { get; set; }

        [DataMember(Name = "stdSellerCreditsIncDecRemark")]
        public string StdSellerCreditsIncDecRemark { get; set; }

        [DataMember(Name = "stdLegalLimit")]
        public decimal? StdLegalLimit { get; set; }

        [DataMember(Name = "altLoanAmountIncDecRemark")]
        public string AltLoanAmountIncDecRemark { get; set; }

        [DataMember(Name = "altTotalClosingCostRemark")]
        public string AltTotalClosingCostRemark { get; set; }

        [DataMember(Name = "altLegalLimit")]
        public decimal? AltLegalLimit { get; set; }

        [DataMember(Name = "altCashToCloseRemark")]
        public decimal? AltCashToCloseRemark { get; set; }

        [DataMember(Name = "priorToleranceCureAmount")]
        public decimal? PriorToleranceCureAmount { get; set; }

        [DataMember(Name = "actualLeLoanAmountFromLatestRec")]
        public decimal? ActualLeLoanAmountFromLatestRec { get; set; }

        [DataMember(Name = "actualLecd3TotalClosingCostJFromLatestRec")]
        public decimal? ActualLecd3TotalClosingCostJFromLatestRec { get; set; }

        [DataMember(Name = "actualLecd3TotalPayoffsAndPaymentsKFromLatestRec")]
        public decimal? ActualLecd3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleTotalClosingCostJFromLatestRec")]
        public decimal? ActualStdleTotalClosingCostJFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleClosingCostFinancedFromLatestRec")]
        public decimal? ActualStdleClosingCostFinancedFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleDownPaymentFromLatestRec")]
        public decimal? ActualStdleDownPaymentFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleDepositFromLatestRec")]
        public decimal? ActualStdleDepositFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleFundForBorrowerFromLatestRec")]
        public decimal? ActualStdleFundForBorrowerFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleSellerCreditsFromLatestRec")]
        public decimal? ActualStdleSellerCreditsFromLatestRec { get; set; }

        [DataMember(Name = "actualStdleAdjustmentAndOtherCreditsFromLatestRec")]
        public decimal? ActualStdleAdjustmentAndOtherCreditsFromLatestRec { get; set; }

        [DataMember(Name = "actualLenderCredits")]
        public decimal? ActualLenderCredits { get; set; }

        [DataMember(Name = "actualStdleTotalClosingCostJ")]
        public decimal? ActualStdleTotalClosingCostJ { get; set; }

        [DataMember(Name = "actualStdleSellerCredits")]
        public decimal? ActualStdleSellerCredits { get; set; }

        [DataMember(Name = "stdAdjustmentAndOtherCreditsRemark")]
        public string StdAdjustmentAndOtherCreditsRemark { get; set; }

        [DataMember(Name = "excludeBorrowerClosingCosts")]
        public bool? ExcludeBorrowerClosingCosts { get; set; }

        [DataMember(Name = "omitFromPrintSellersTransaction")]
        public bool? OmitFromPrintSellersTransaction { get; set; }

        [DataMember(Name = "ucdDetails")]
        public List<UcdDetailContract> UCDDetails { get; set; }

        [DataMember(Name = "ucdkSubTotal")]
        public decimal? UcdkSubTotal { get; set; }

        [DataMember(Name = "ucdlSubTotal")]
        public decimal? UcdlSubTotal { get; set; }

        [DataMember(Name = "ucdTotalAdjustmentsAndOtherCredits")]
        public decimal? UcdTotalAdjustmentsAndOtherCredits { get; set; }

        [DataMember(Name = "nonUcdTotalAdjustmentsAndOtherCredits")]
        public decimal? NonUcdTotalAdjustmentsAndOtherCredits { get; set; }

        [DataMember(Name = "totalAdjustmentsAndOtherCredits")]
        public decimal? TotalAdjustmentsAndOtherCredits { get; set; }

        [DataMember(Name = "newVerbiageDisclosed")]
        public bool? NewVerbiageDisclosed { get; set; }

        [DataMember(Name = "totalPurchasePayoffsIncluded")]
        public decimal? TotalPurchasePayoffsIncluded { get; set; }


    }
}
