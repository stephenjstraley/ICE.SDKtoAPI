using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure3
	{
		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public double? ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec", EmitDefaultValue=false)]
		public double? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec", EmitDefaultValue=false)]
		public double? ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualLenderCredits", EmitDefaultValue=false)]
		public double? ActualLenderCredits { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDownPaymentFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLEDownPaymentFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCredits", EmitDefaultValue=false)]
		public double? ActualSTDLESellerCredits { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJ", EmitDefaultValue=false)]
		public double? ActualSTDLETotalClosingCostJ { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public double? ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="adjustments061", EmitDefaultValue=false)]
		public string Adjustments061 { get; set; }

		[DataMember(Name="adjustments062", EmitDefaultValue=false)]
		public double? Adjustments062 { get; set; }

		[DataMember(Name="adjustments071", EmitDefaultValue=false)]
		public string Adjustments071 { get; set; }

		[DataMember(Name="adjustments072", EmitDefaultValue=false)]
		public double? Adjustments072 { get; set; }

		[DataMember(Name="adjustments101", EmitDefaultValue=false)]
		public string Adjustments101 { get; set; }

		[DataMember(Name="adjustments102", EmitDefaultValue=false)]
		public double? Adjustments102 { get; set; }

		[DataMember(Name="adjustments111", EmitDefaultValue=false)]
		public string Adjustments111 { get; set; }

		[DataMember(Name="adjustments112", EmitDefaultValue=false)]
		public double? Adjustments112 { get; set; }

		[DataMember(Name="adjustments151", EmitDefaultValue=false)]
		public string Adjustments151 { get; set; }

		[DataMember(Name="adjustments152", EmitDefaultValue=false)]
		public double? Adjustments152 { get; set; }

		[DataMember(Name="adjustments81", EmitDefaultValue=false)]
		public string Adjustments81 { get; set; }

		[DataMember(Name="adjustments82", EmitDefaultValue=false)]
		public double? Adjustments82 { get; set; }

		[DataMember(Name="adjustments91", EmitDefaultValue=false)]
		public string Adjustments91 { get; set; }

		[DataMember(Name="adjustments92", EmitDefaultValue=false)]
		public double? Adjustments92 { get; set; }

		[DataMember(Name="adjustmentsforItemsPaidbySellerinAdvance161", EmitDefaultValue=false)]
		public string AdjustmentsforItemsPaidbySellerinAdvance161 { get; set; }

		[DataMember(Name="adjustmentsforItemsPaidbySellerinAdvance162", EmitDefaultValue=false)]
		public double? AdjustmentsforItemsPaidbySellerinAdvance162 { get; set; }

		[DataMember(Name="aLTCashToCloseDidChangeCol", EmitDefaultValue=false)]
		public string ALTCashToCloseDidChangeCol { get; set; }

		[DataMember(Name="aLTCashToCloseRemark", EmitDefaultValue=false)]
		public double? ALTCashToCloseRemark { get; set; }

		[DataMember(Name="aLTClosingCostBeforeClosingDidChangeCol", EmitDefaultValue=false)]
		public string ALTClosingCostBeforeClosingDidChangeCol { get; set; }

		[DataMember(Name="aLTLegalLimit", EmitDefaultValue=false)]
		public double? ALTLegalLimit { get; set; }

		[DataMember(Name="aLTLoanAmountDidChangeCol", EmitDefaultValue=false)]
		public string ALTLoanAmountDidChangeCol { get; set; }

		[DataMember(Name="aLTLoanAmountIncDecRemark", EmitDefaultValue=false)]
		public string ALTLoanAmountIncDecRemark { get; set; }

		[DataMember(Name="aLTTotalClosingCostDidChangeCol", EmitDefaultValue=false)]
		public string ALTTotalClosingCostDidChangeCol { get; set; }

		[DataMember(Name="aLTTotalClosingCostRemark", EmitDefaultValue=false)]
		public string ALTTotalClosingCostRemark { get; set; }

		[DataMember(Name="aLTTotalPayoffsDidChangeCol", EmitDefaultValue=false)]
		public string ALTTotalPayoffsDidChangeCol { get; set; }

		[DataMember(Name="cash", EmitDefaultValue=false)]
		public double? Cash { get; set; }

		[DataMember(Name="cashToClose", EmitDefaultValue=false)]
		public double? CashToClose { get; set; }

		[DataMember(Name="cD3CashToClose", EmitDefaultValue=false)]
		public double? CD3CashToClose { get; set; }

		[DataMember(Name="cD3CashToCloseFromToBorrower", EmitDefaultValue=false)]
		public string CD3CashToCloseFromToBorrower { get; set; }

		[DataMember(Name="cD3ClosingCostsPaidBeforeClosing", EmitDefaultValue=false)]
		public double? CD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="cD3TotalClosingCostJ", EmitDefaultValue=false)]
		public double? CD3TotalClosingCostJ { get; set; }

		[DataMember(Name="cD3TotalPayoffsAndPaymentsK", EmitDefaultValue=false)]
		public double? CD3TotalPayoffsAndPaymentsK { get; set; }

		[DataMember(Name="closingCostsPaidAtClosing", EmitDefaultValue=false)]
		public double? ClosingCostsPaidAtClosing { get; set; }

		[DataMember(Name="closingCostsPaidatClosingJ", EmitDefaultValue=false)]
		public double? ClosingCostsPaidatClosingJ { get; set; }

		[DataMember(Name="duefromSelleratClosing111", EmitDefaultValue=false)]
		public string DuefromSelleratClosing111 { get; set; }

		[DataMember(Name="duefromSelleratClosing112", EmitDefaultValue=false)]
		public double? DuefromSelleratClosing112 { get; set; }

		[DataMember(Name="duefromSelleratClosing121", EmitDefaultValue=false)]
		public string DuefromSelleratClosing121 { get; set; }

		[DataMember(Name="duefromSelleratClosing122", EmitDefaultValue=false)]
		public double? DuefromSelleratClosing122 { get; set; }

		[DataMember(Name="duefromSelleratClosing131", EmitDefaultValue=false)]
		public string DuefromSelleratClosing131 { get; set; }

		[DataMember(Name="duefromSelleratClosing132", EmitDefaultValue=false)]
		public double? DuefromSelleratClosing132 { get; set; }

		[DataMember(Name="dueToSellerAtClosing61", EmitDefaultValue=false)]
		public string DueToSellerAtClosing61 { get; set; }

		[DataMember(Name="dueToSellerAtClosing62", EmitDefaultValue=false)]
		public double? DueToSellerAtClosing62 { get; set; }

		[DataMember(Name="dueToSellerAtClosing71", EmitDefaultValue=false)]
		public string DueToSellerAtClosing71 { get; set; }

		[DataMember(Name="dueToSellerAtClosing72", EmitDefaultValue=false)]
		public double? DueToSellerAtClosing72 { get; set; }

		[DataMember(Name="dueToSellerAtClosing81", EmitDefaultValue=false)]
		public string DueToSellerAtClosing81 { get; set; }

		[DataMember(Name="dueToSellerAtClosing82", EmitDefaultValue=false)]
		public double? DueToSellerAtClosing82 { get; set; }

		[DataMember(Name="excludeBorrowerClosingCosts", EmitDefaultValue=false)]
		public bool? ExcludeBorrowerClosingCosts { get; set; }

		[DataMember(Name="finalCashToClose", EmitDefaultValue=false)]
		public double? FinalCashToClose { get; set; }

		[DataMember(Name="fromToBorrower", EmitDefaultValue=false)]
		public string FromToBorrower { get; set; }

		[DataMember(Name="fromToSeller", EmitDefaultValue=false)]
		public string FromToSeller { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lECD3CashToClose", EmitDefaultValue=false)]
		public double? LECD3CashToClose { get; set; }

		[DataMember(Name="lECD3CashToCloseFromToBorrower", EmitDefaultValue=false)]
		public string LECD3CashToCloseFromToBorrower { get; set; }

		[DataMember(Name="lECD3ClosingCostsPaidBeforeClosing", EmitDefaultValue=false)]
		public double? LECD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="lECD3TotalClosingCostJ", EmitDefaultValue=false)]
		public double? LECD3TotalClosingCostJ { get; set; }

		[DataMember(Name="lECD3TotalPayoffsAndPaymentsK", EmitDefaultValue=false)]
		public double? LECD3TotalPayoffsAndPaymentsK { get; set; }

		[DataMember(Name="lELoanAmount", EmitDefaultValue=false)]
		public double? LELoanAmount { get; set; }

		[DataMember(Name="liabilityAmount1", EmitDefaultValue=false)]
		public double? LiabilityAmount1 { get; set; }

		[DataMember(Name="liabilityAmount10", EmitDefaultValue=false)]
		public double? LiabilityAmount10 { get; set; }

		[DataMember(Name="liabilityAmount11", EmitDefaultValue=false)]
		public double? LiabilityAmount11 { get; set; }

		[DataMember(Name="liabilityAmount12", EmitDefaultValue=false)]
		public double? LiabilityAmount12 { get; set; }

		[DataMember(Name="liabilityAmount13", EmitDefaultValue=false)]
		public double? LiabilityAmount13 { get; set; }

		[DataMember(Name="liabilityAmount14", EmitDefaultValue=false)]
		public double? LiabilityAmount14 { get; set; }

		[DataMember(Name="liabilityAmount15", EmitDefaultValue=false)]
		public double? LiabilityAmount15 { get; set; }

		[DataMember(Name="liabilityAmount2", EmitDefaultValue=false)]
		public double? LiabilityAmount2 { get; set; }

		[DataMember(Name="liabilityAmount3", EmitDefaultValue=false)]
		public double? LiabilityAmount3 { get; set; }

		[DataMember(Name="liabilityAmount4", EmitDefaultValue=false)]
		public double? LiabilityAmount4 { get; set; }

		[DataMember(Name="liabilityAmount5", EmitDefaultValue=false)]
		public double? LiabilityAmount5 { get; set; }

		[DataMember(Name="liabilityAmount6", EmitDefaultValue=false)]
		public double? LiabilityAmount6 { get; set; }

		[DataMember(Name="liabilityAmount7", EmitDefaultValue=false)]
		public double? LiabilityAmount7 { get; set; }

		[DataMember(Name="liabilityAmount8", EmitDefaultValue=false)]
		public double? LiabilityAmount8 { get; set; }

		[DataMember(Name="liabilityAmount9", EmitDefaultValue=false)]
		public double? LiabilityAmount9 { get; set; }

		[DataMember(Name="liabilityTo1", EmitDefaultValue=false)]
		public string LiabilityTo1 { get; set; }

		[DataMember(Name="liabilityTo10", EmitDefaultValue=false)]
		public string LiabilityTo10 { get; set; }

		[DataMember(Name="liabilityTo11", EmitDefaultValue=false)]
		public string LiabilityTo11 { get; set; }

		[DataMember(Name="liabilityTo12", EmitDefaultValue=false)]
		public string LiabilityTo12 { get; set; }

		[DataMember(Name="liabilityTo13", EmitDefaultValue=false)]
		public string LiabilityTo13 { get; set; }

		[DataMember(Name="liabilityTo14", EmitDefaultValue=false)]
		public string LiabilityTo14 { get; set; }

		[DataMember(Name="liabilityTo15", EmitDefaultValue=false)]
		public string LiabilityTo15 { get; set; }

		[DataMember(Name="liabilityTo2", EmitDefaultValue=false)]
		public string LiabilityTo2 { get; set; }

		[DataMember(Name="liabilityTo3", EmitDefaultValue=false)]
		public string LiabilityTo3 { get; set; }

		[DataMember(Name="liabilityTo4", EmitDefaultValue=false)]
		public string LiabilityTo4 { get; set; }

		[DataMember(Name="liabilityTo5", EmitDefaultValue=false)]
		public string LiabilityTo5 { get; set; }

		[DataMember(Name="liabilityTo6", EmitDefaultValue=false)]
		public string LiabilityTo6 { get; set; }

		[DataMember(Name="liabilityTo7", EmitDefaultValue=false)]
		public string LiabilityTo7 { get; set; }

		[DataMember(Name="liabilityTo8", EmitDefaultValue=false)]
		public string LiabilityTo8 { get; set; }

		[DataMember(Name="liabilityTo9", EmitDefaultValue=false)]
		public string LiabilityTo9 { get; set; }

		[DataMember(Name="liabilityTotal", EmitDefaultValue=false)]
		public double? LiabilityTotal { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public double? LoanAmount { get; set; }

		[DataMember(Name="nonUCDTotalAdjustmentsAndOtherCredits", EmitDefaultValue=false)]
		public double? NonUCDTotalAdjustmentsAndOtherCredits { get; set; }

		[DataMember(Name="omitFromPrintSellersTransaction", EmitDefaultValue=false)]
		public bool? OmitFromPrintSellersTransaction { get; set; }

		[DataMember(Name="otherCredits61", EmitDefaultValue=false)]
		public string OtherCredits61 { get; set; }

		[DataMember(Name="otherCredits62", EmitDefaultValue=false)]
		public double? OtherCredits62 { get; set; }

		[DataMember(Name="otherCredits71", EmitDefaultValue=false)]
		public string OtherCredits71 { get; set; }

		[DataMember(Name="otherCredits72", EmitDefaultValue=false)]
		public double? OtherCredits72 { get; set; }

		[DataMember(Name="priorToleranceCureAmount", EmitDefaultValue=false)]
		public double? PriorToleranceCureAmount { get; set; }

		[DataMember(Name="sTDAdjustmentAndOtherCreditsRemark", EmitDefaultValue=false)]
		public string STDAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="sTDAdjustmentsDidChangeCol", EmitDefaultValue=false)]
		public string STDAdjustmentsDidChangeCol { get; set; }

		[DataMember(Name="sTDClosingCostFinancedDidChangeCol", EmitDefaultValue=false)]
		public string STDClosingCostFinancedDidChangeCol { get; set; }

		[DataMember(Name="sTDDepositDidChangeCol", EmitDefaultValue=false)]
		public string STDDepositDidChangeCol { get; set; }

		[DataMember(Name="sTDDepositIncDecRemark", EmitDefaultValue=false)]
		public string STDDepositIncDecRemark { get; set; }

		[DataMember(Name="sTDDownPaymentDidChangeCol", EmitDefaultValue=false)]
		public string STDDownPaymentDidChangeCol { get; set; }

		[DataMember(Name="sTDDownPaymentIncDecRemark", EmitDefaultValue=false)]
		public string STDDownPaymentIncDecRemark { get; set; }

		[DataMember(Name="sTDDownPaymentSectionRemark", EmitDefaultValue=false)]
		public string STDDownPaymentSectionRemark { get; set; }

		[DataMember(Name="sTDFinalAdjustmentAndOtherCredits", EmitDefaultValue=false)]
		public double? STDFinalAdjustmentAndOtherCredits { get; set; }

		[DataMember(Name="sTDFinalCashToClose", EmitDefaultValue=false)]
		public double? STDFinalCashToClose { get; set; }

		[DataMember(Name="sTDFinalCD3ClosingCostsPaidBeforeClosing", EmitDefaultValue=false)]
		public double? STDFinalCD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="sTDFinalClosingCostFinanced", EmitDefaultValue=false)]
		public double? STDFinalClosingCostFinanced { get; set; }

		[DataMember(Name="sTDFinalDeposit", EmitDefaultValue=false)]
		public double? STDFinalDeposit { get; set; }

		[DataMember(Name="sTDFinalDownPayment", EmitDefaultValue=false)]
		public double? STDFinalDownPayment { get; set; }

		[DataMember(Name="sTDFinalFundForBorrower", EmitDefaultValue=false)]
		public double? STDFinalFundForBorrower { get; set; }

		[DataMember(Name="sTDFinalSellerCredits", EmitDefaultValue=false)]
		public double? STDFinalSellerCredits { get; set; }

		[DataMember(Name="sTDFinalTotalClosingCostJ", EmitDefaultValue=false)]
		public double? STDFinalTotalClosingCostJ { get; set; }

		[DataMember(Name="sTDFundsForBorrowerDidChangeCol", EmitDefaultValue=false)]
		public string STDFundsForBorrowerDidChangeCol { get; set; }

		[DataMember(Name="sTDFundsForBorrowerIncDecRemark", EmitDefaultValue=false)]
		public string STDFundsForBorrowerIncDecRemark { get; set; }

		[DataMember(Name="sTDLEAdjustmentAndOtherCredits", EmitDefaultValue=false)]
		public double? STDLEAdjustmentAndOtherCredits { get; set; }

		[DataMember(Name="sTDLECashToClose", EmitDefaultValue=false)]
		public double? STDLECashToClose { get; set; }

		[DataMember(Name="sTDLECD3ClosingCostsPaidBeforeClosing", EmitDefaultValue=false)]
		public double? STDLECD3ClosingCostsPaidBeforeClosing { get; set; }

		[DataMember(Name="sTDLEClosingCostFinanced", EmitDefaultValue=false)]
		public double? STDLEClosingCostFinanced { get; set; }

		[DataMember(Name="sTDLEDeposit", EmitDefaultValue=false)]
		public double? STDLEDeposit { get; set; }

		[DataMember(Name="sTDLEDownPayment", EmitDefaultValue=false)]
		public double? STDLEDownPayment { get; set; }

		[DataMember(Name="sTDLEFundForBorrower", EmitDefaultValue=false)]
		public double? STDLEFundForBorrower { get; set; }

		[DataMember(Name="sTDLegalLimit", EmitDefaultValue=false)]
		public double? STDLegalLimit { get; set; }

		[DataMember(Name="sTDLESellerCredits", EmitDefaultValue=false)]
		public double? STDLESellerCredits { get; set; }

		[DataMember(Name="sTDLETotalClosingCostJ", EmitDefaultValue=false)]
		public double? STDLETotalClosingCostJ { get; set; }

		[DataMember(Name="sTDSellerCreditsDidChangeCol", EmitDefaultValue=false)]
		public string STDSellerCreditsDidChangeCol { get; set; }

		[DataMember(Name="sTDSellerCreditsIncDecRemark", EmitDefaultValue=false)]
		public string STDSellerCreditsIncDecRemark { get; set; }

		[DataMember(Name="sTDTotalClosingCostBeforeClosingDidChangeCol", EmitDefaultValue=false)]
		public string STDTotalClosingCostBeforeClosingDidChangeCol { get; set; }

		[DataMember(Name="sTDTotalClosingCostDidChangeCol", EmitDefaultValue=false)]
		public string STDTotalClosingCostDidChangeCol { get; set; }

		[DataMember(Name="sTDTotalClosingCostRemark", EmitDefaultValue=false)]
		public string STDTotalClosingCostRemark { get; set; }

		[DataMember(Name="totalAdjustmentsAndOtherCredits", EmitDefaultValue=false)]
		public double? TotalAdjustmentsAndOtherCredits { get; set; }

		[DataMember(Name="totalDuefromBorrowerAtClosing", EmitDefaultValue=false)]
		public double? TotalDuefromBorrowerAtClosing { get; set; }

		[DataMember(Name="totalDuefromSelleratClosingN", EmitDefaultValue=false)]
		public double? TotalDuefromSelleratClosingN { get; set; }

		[DataMember(Name="totalDuetoSelleratClosingM", EmitDefaultValue=false)]
		public double? TotalDuetoSelleratClosingM { get; set; }

		[DataMember(Name="totalFromK", EmitDefaultValue=false)]
		public double? TotalFromK { get; set; }

		[DataMember(Name="totalFromL", EmitDefaultValue=false)]
		public double? TotalFromL { get; set; }

		[DataMember(Name="totalFromM", EmitDefaultValue=false)]
		public double? TotalFromM { get; set; }

		[DataMember(Name="totalFromN", EmitDefaultValue=false)]
		public double? TotalFromN { get; set; }

		[DataMember(Name="totalPaidAlreadybyoronBehalfofBoroweratClosing", EmitDefaultValue=false)]
		public double? TotalPaidAlreadybyoronBehalfofBoroweratClosing { get; set; }

		[DataMember(Name="uCDDetails", EmitDefaultValue=false)]
		public List<LoanContractClosingCostClosingDisclosure3UCDDetails> UCDDetails { get; set; }

		[DataMember(Name="uCDKSubTotal", EmitDefaultValue=false)]
		public double? UCDKSubTotal { get; set; }

		[DataMember(Name="uCDLSubTotal", EmitDefaultValue=false)]
		public double? UCDLSubTotal { get; set; }

		[DataMember(Name="uCDTotalAdjustmentsAndOtherCredits", EmitDefaultValue=false)]
		public double? UCDTotalAdjustmentsAndOtherCredits { get; set; }

	}
}