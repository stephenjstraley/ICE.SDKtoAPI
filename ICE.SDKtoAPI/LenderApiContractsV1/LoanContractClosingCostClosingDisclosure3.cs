using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure3
	{
		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec")]
		public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec")]
		public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec")]
		public decimal? ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualLenderCredits")]
		public decimal? ActualLenderCredits { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec")]
		public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec")]
		public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec")]
		public decimal? ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDownPaymentFromLatestRec")]
		public decimal? ActualSTDLEDownPaymentFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec")]
		public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCredits")]
		public decimal? ActualSTDLESellerCredits { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec")]
		public decimal? ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJ")]
		public decimal? ActualSTDLETotalClosingCostJ { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec")]
		public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="adjustments061")]
		public string Adjustments061 { get; set; }

		[DataMember(Name="adjustments062")]
		public decimal? Adjustments062 { get; set; }

		[DataMember(Name="adjustments071")]
		public string Adjustments071 { get; set; }

		[DataMember(Name="adjustments072")]
		public decimal? Adjustments072 { get; set; }

		[DataMember(Name="adjustments101")]
		public string Adjustments101 { get; set; }

		[DataMember(Name="adjustments102")]
		public decimal? Adjustments102 { get; set; }

		[DataMember(Name= "adjustments111")]
		public string Adjustments111 { get; set; }

		[DataMember(Name="adjustments112")]
		public decimal? Adjustments112 { get; set; }

		[DataMember(Name="adjustments151")]
		public string Adjustments151 { get; set; }

		[DataMember(Name="adjustments152")]
		public decimal? Adjustments152 { get; set; }

		[DataMember(Name="adjustments81")]
		public string Adjustments81 { get; set; }

		[DataMember(Name="adjustments82")]
		public decimal? Adjustments82 { get; set; }

		[DataMember(Name="adjustments91")]
		public string Adjustments91 { get; set; }

		[DataMember(Name="adjustments92")]
		public decimal? Adjustments92 { get; set; }

		[DataMember(Name="adjustmentsforItemsPaidbySellerinAdvance161")]
		public string AdjustmentsforItemsPaidbySellerinAdvance161 { get; set; }

		[DataMember(Name="adjustmentsforItemsPaidbySellerinAdvance162")]
		public decimal? AdjustmentsforItemsPaidbySellerinAdvance162 { get; set; }

		[DataMember(Name="aLTCashToCloseDidChangeCol")]
		public string ALTCashToCloseDidChangeCol { get; set; }

		[DataMember(Name="aLTCashToCloseRemark")]
		public decimal? ALTCashToCloseRemark { get; set; }

		[DataMember(Name="aLTClosingCostBeforeClosingDidChangeCol")]
		public string ALTClosingCostBeforeClosingDidChangeCol { get; set; }

		[DataMember(Name="aLTLegalLimit")]
		public decimal? ALTLegalLimit { get; set; }

		[DataMember(Name="aLTLoanAmountDidChangeCol")]
		public string ALTLoanAmountDidChangeCol { get; set; }

		[DataMember(Name="aLTLoanAmountIncDecRemark")]
		public string ALTLoanAmountIncDecRemark { get; set; }

		[DataMember(Name="aLTTotalClosingCostDidChangeCol")]
		public string ALTTotalClosingCostDidChangeCol { get; set; }

		[DataMember(Name="aLTTotalClosingCostRemark")]
		public string ALTTotalClosingCostRemark { get; set; }

		[DataMember(Name="aLTTotalPayoffsDidChangeCol")]
		public string ALTTotalPayoffsDidChangeCol { get; set; }

		[DataMember(Name="cash")]
		public decimal? Cash { get; set; }

		[DataMember(Name="cashToClose")]
		public decimal? CashToClose { get; set; }

		[DataMember(Name="cD3CashToClose")]
		public decimal? CD3CashToClose { get; set; }

		[DataMember(Name="cD3CashToCloseFromToBorrower")]
		public string CD3CashToCloseFromToBorrower { get; set; }

		[DataMember(Name="cD3ClosingCostsPaidBeforeClosing")]
		public decimal? CD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name= "cD3TotalClosingCostJ")]
		public decimal? CD3TotalClosingCostJ { get; set; }

		[DataMember(Name= "cD3TotalPayoffsAndPaymentsK")]
		public decimal? CD3TotalPayoffsAndPaymentsK { get; set; }

		[DataMember(Name="closingCostsPaidAtClosing")]
		public decimal? ClosingCostsPaidAtClosing { get; set; }

		[DataMember(Name= "closingCostsPaidatClosingJ")]
		public decimal? ClosingCostsPaidatClosingJ { get; set; }

		[DataMember(Name="duefromSelleratClosing111")]
		public string DuefromSelleratClosing111 { get; set; }

		[DataMember(Name="duefromSelleratClosing112")]
		public decimal? DuefromSelleratClosing112 { get; set; }

		[DataMember(Name="duefromSelleratClosing121")]
		public string DuefromSelleratClosing121 { get; set; }

		[DataMember(Name="duefromSelleratClosing122")]
		public decimal? DuefromSelleratClosing122 { get; set; }

		[DataMember(Name="duefromSelleratClosing131")]
		public string DuefromSelleratClosing131 { get; set; }

		[DataMember(Name="duefromSelleratClosing132")]
		public decimal? DuefromSelleratClosing132 { get; set; }

		[DataMember(Name="dueToSellerAtClosing61")]
		public string DueToSellerAtClosing61 { get; set; }

		[DataMember(Name="dueToSellerAtClosing62")]
		public decimal? DueToSellerAtClosing62 { get; set; }

		[DataMember(Name="dueToSellerAtClosing71")]
		public string DueToSellerAtClosing71 { get; set; }

		[DataMember(Name="dueToSellerAtClosing72")]
		public decimal? DueToSellerAtClosing72 { get; set; }

		[DataMember(Name="dueToSellerAtClosing81")]
		public string DueToSellerAtClosing81 { get; set; }

		[DataMember(Name="dueToSellerAtClosing82")]
		public decimal? DueToSellerAtClosing82 { get; set; }

		[DataMember(Name="excludeBorrowerClosingCosts")]
		public bool? ExcludeBorrowerClosingCosts { get; set; }

		[DataMember(Name="finalCashToClose")]
		public decimal? FinalCashToClose { get; set; }

		[DataMember(Name="fromToBorrower")]
		public string FromToBorrower { get; set; }

		[DataMember(Name="fromToSeller")]
		public string FromToSeller { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lECD3CashToClose")]
		public decimal? LECD3CashToClose { get; set; }

		[DataMember(Name="lECD3CashToCloseFromToBorrower")]
		public string LECD3CashToCloseFromToBorrower { get; set; }

		[DataMember(Name="lECD3ClosingCostsPaidBeforeClosing")]
		public decimal? LECD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name= "lECD3TotalClosingCostJ")]
		public decimal? LECD3TotalClosingCostJ { get; set; }

		[DataMember(Name = "lecd3TotalPayoffsAndPaymentsK")]
		public decimal? LECD3TotalPayoffsAndPaymentsK { get; set; } = 0.00M;

		[DataMember(Name="lELoanAmount")]
		public decimal? LELoanAmount { get; set; }

		[DataMember(Name="liabilityAmount1")]
		public decimal? LiabilityAmount1 { get; set; }

		[DataMember(Name="liabilityAmount10")]
		public decimal? LiabilityAmount10 { get; set; }

		[DataMember(Name="liabilityAmount11")]
		public decimal? LiabilityAmount11 { get; set; }

		[DataMember(Name="liabilityAmount12")]
		public decimal? LiabilityAmount12 { get; set; }

		[DataMember(Name="liabilityAmount13")]
		public decimal? LiabilityAmount13 { get; set; }

		[DataMember(Name="liabilityAmount14")]
		public decimal? LiabilityAmount14 { get; set; }

		[DataMember(Name="liabilityAmount15")]
		public decimal? LiabilityAmount15 { get; set; }

		[DataMember(Name="liabilityAmount2")]
		public decimal? LiabilityAmount2 { get; set; }

		[DataMember(Name="liabilityAmount3")]
		public decimal? LiabilityAmount3 { get; set; }

		[DataMember(Name="liabilityAmount4")]
		public decimal? LiabilityAmount4 { get; set; }

		[DataMember(Name="liabilityAmount5")]
		public decimal? LiabilityAmount5 { get; set; }

		[DataMember(Name="liabilityAmount6")]
		public decimal? LiabilityAmount6 { get; set; }

		[DataMember(Name="liabilityAmount7")]
		public decimal? LiabilityAmount7 { get; set; }

		[DataMember(Name="liabilityAmount8")]
		public decimal? LiabilityAmount8 { get; set; }

		[DataMember(Name="liabilityAmount9")]
		public decimal? LiabilityAmount9 { get; set; }

		[DataMember(Name="liabilityTo1")]
		public string LiabilityTo1 { get; set; }

		[DataMember(Name="liabilityTo10")]
		public string LiabilityTo10 { get; set; }

		[DataMember(Name="liabilityTo11")]
		public string LiabilityTo11 { get; set; }

		[DataMember(Name="liabilityTo12")]
		public string LiabilityTo12 { get; set; }

		[DataMember(Name="liabilityTo13")]
		public string LiabilityTo13 { get; set; }

		[DataMember(Name="liabilityTo14")]
		public string LiabilityTo14 { get; set; }

		[DataMember(Name="liabilityTo15")]
		public string LiabilityTo15 { get; set; }

		[DataMember(Name="liabilityTo2")]
		public string LiabilityTo2 { get; set; }

		[DataMember(Name="liabilityTo3")]
		public string LiabilityTo3 { get; set; }

		[DataMember(Name="liabilityTo4")]
		public string LiabilityTo4 { get; set; }

		[DataMember(Name="liabilityTo5")]
		public string LiabilityTo5 { get; set; }

		[DataMember(Name="liabilityTo6")]
		public string LiabilityTo6 { get; set; }

		[DataMember(Name="liabilityTo7")]
		public string LiabilityTo7 { get; set; }

		[DataMember(Name="liabilityTo8")]
		public string LiabilityTo8 { get; set; }

		[DataMember(Name="liabilityTo9")]
		public string LiabilityTo9 { get; set; }

		[DataMember(Name="liabilityTotal")]
		public decimal? LiabilityTotal { get; set; }

		[DataMember(Name="loanAmount")]
		public decimal? LoanAmount { get; set; }

		[DataMember(Name="nonUCDTotalAdjustmentsAndOtherCredits")]
		public decimal? NonUCDTotalAdjustmentsAndOtherCredits { get; set; }

		[DataMember(Name="omitFromPrintSellersTransaction")]
		public bool? OmitFromPrintSellersTransaction { get; set; }

		[DataMember(Name="otherCredits61")]
		public string OtherCredits61 { get; set; }

		[DataMember(Name="otherCredits62")]
		public decimal? OtherCredits62 { get; set; }

		[DataMember(Name="otherCredits71")]
		public string OtherCredits71 { get; set; }

		[DataMember(Name="otherCredits72")]
		public decimal? OtherCredits72 { get; set; }

		[DataMember(Name="priorToleranceCureAmount")]
		public decimal? PriorToleranceCureAmount { get; set; }

		[DataMember(Name="sTDAdjustmentAndOtherCreditsRemark")]
		public string STDAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="sTDAdjustmentsDidChangeCol")]
		public string STDAdjustmentsDidChangeCol { get; set; }

		[DataMember(Name="sTDClosingCostFinancedDidChangeCol")]
		public string STDClosingCostFinancedDidChangeCol { get; set; }

		[DataMember(Name="sTDDepositDidChangeCol")]
		public string STDDepositDidChangeCol { get; set; }

		[DataMember(Name="sTDDepositIncDecRemark")]
		public string STDDepositIncDecRemark { get; set; }

		[DataMember(Name="sTDDownPaymentDidChangeCol")]
		public string STDDownPaymentDidChangeCol { get; set; }

		[DataMember(Name="sTDDownPaymentIncDecRemark")]
		public string STDDownPaymentIncDecRemark { get; set; }

		[DataMember(Name="sTDDownPaymentSectionRemark")]
		public string STDDownPaymentSectionRemark { get; set; }

		[DataMember(Name="sTDFinalAdjustmentAndOtherCredits")]
		public decimal? STDFinalAdjustmentAndOtherCredits { get; set; }

		[DataMember(Name="sTDFinalCashToClose")]
		public decimal? STDFinalCashToClose { get; set; }

		[DataMember(Name="sTDFinalCD3ClosingCostsPaidBeforeClosing")]
		public decimal? STDFinalCD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="sTDFinalClosingCostFinanced")]
		public decimal? STDFinalClosingCostFinanced { get; set; }

		[DataMember(Name="sTDFinalDeposit")]
		public decimal? STDFinalDeposit { get; set; }

		[DataMember(Name="sTDFinalDownPayment")]
		public decimal? STDFinalDownPayment { get; set; }

		[DataMember(Name="sTDFinalFundForBorrower")]
		public decimal? STDFinalFundForBorrower { get; set; }

		[DataMember(Name="sTDFinalSellerCredits")]
		public decimal? STDFinalSellerCredits { get; set; }

		[DataMember(Name="sTDFinalTotalClosingCostJ")]
		public decimal? STDFinalTotalClosingCostJ { get; set; }

		[DataMember(Name="sTDFundsForBorrowerDidChangeCol")]
		public string STDFundsForBorrowerDidChangeCol { get; set; }

		[DataMember(Name="sTDFundsForBorrowerIncDecRemark")]
		public string STDFundsForBorrowerIncDecRemark { get; set; }

		[DataMember(Name="sTDLEAdjustmentAndOtherCredits")]
		public decimal? STDLEAdjustmentAndOtherCredits { get; set; }

		[DataMember(Name="sTDLECashToClose")]
		public decimal? STDLECashToClose { get; set; }

		[DataMember(Name="sTDLECD3ClosingCostsPaidBeforeClosing")]
		public decimal? STDLECD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="sTDLEClosingCostFinanced")]
		public decimal? STDLEClosingCostFinanced { get; set; }

		[DataMember(Name="sTDLEDeposit")]
		public decimal? STDLEDeposit { get; set; }

		[DataMember(Name="sTDLEDownPayment")]
		public decimal? STDLEDownPayment { get; set; }

		[DataMember(Name="sTDLEFundForBorrower")]
		public decimal? STDLEFundForBorrower { get; set; }

		[DataMember(Name="sTDLegalLimit")]
		public decimal? STDLegalLimit { get; set; }

		[DataMember(Name="sTDLESellerCredits")]
		public decimal? STDLESellerCredits { get; set; }

		[DataMember(Name="sTDLETotalClosingCostJ")]
		public decimal? STDLETotalClosingCostJ { get; set; }

		[DataMember(Name="sTDSellerCreditsDidChangeCol")]
		public string STDSellerCreditsDidChangeCol { get; set; }

		[DataMember(Name="sTDSellerCreditsIncDecRemark")]
		public string STDSellerCreditsIncDecRemark { get; set; }

		[DataMember(Name="sTDTotalClosingCostBeforeClosingDidChangeCol")]
		public string STDTotalClosingCostBeforeClosingDidChangeCol { get; set; }

		[DataMember(Name="sTDTotalClosingCostDidChangeCol")]
		public string STDTotalClosingCostDidChangeCol { get; set; }

		[DataMember(Name="sTDTotalClosingCostRemark")]
		public string STDTotalClosingCostRemark { get; set; }

		[DataMember(Name="totalAdjustmentsAndOtherCredits")]
		public decimal? TotalAdjustmentsAndOtherCredits { get; set; }

		[DataMember(Name="totalDuefromBorrowerAtClosing")]
		public decimal? TotalDuefromBorrowerAtClosing { get; set; }

		[DataMember(Name="totalDuefromSelleratClosingN")]
		public decimal? TotalDuefromSelleratClosingN { get; set; }

		[DataMember(Name= "totalDuetoSelleratClosingM")]
		public decimal? TotalDuetoSelleratClosingM { get; set; }

		[DataMember(Name="totalFromK")]
		public decimal? TotalFromK { get; set; }

		[DataMember(Name="totalFromL")]
		public decimal? TotalFromL { get; set; }

		[DataMember(Name="totalFromM")]
		public decimal? TotalFromM { get; set; }

		[DataMember(Name="totalFromN")]
		public decimal? TotalFromN { get; set; }

		[DataMember(Name="totalPaidAlreadybyoronBehalfofBoroweratClosing")]
		public decimal? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get; set; }

		[DataMember(Name="uCDDetails")]
		public List<LoanContractClosingCostClosingDisclosure3UCDDetails> UCDDetails { get; set; }

		[DataMember(Name="uCDKSubTotal")]
		public decimal? UCDKSubTotal { get; set; }

		[DataMember(Name="uCDLSubTotal")]
		public decimal? UCDLSubTotal { get; set; }

		[DataMember(Name="uCDTotalAdjustmentsAndOtherCredits")]
		public decimal? UCDTotalAdjustmentsAndOtherCredits { get; set; }

		[DataMember(Name = "newVerbiageDisclosed")]
		public bool? NewVerbiageDisclosed { get; set; } = false;

		[DataMember(Name = "totalPurchasePayoffsIncluded")]
		public decimal? TotalPurchasePayoffsIncluded { get; set; } = 0.00M;

		[DataMember(Name = "totalDuetoSelleratClosingN")]
		public decimal? TotalDuetoSelleratClosingN { get; set; }

	}
}