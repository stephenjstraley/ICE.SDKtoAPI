using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate2
	{
		[DataMember(Name="actualLenderCredits")]
		public decimal? ActualLenderCredits { get; set; }

		[DataMember(Name="actualSTDLESellerCredits")]
		public decimal? ActualSTDLESellerCredits { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJ")]
		public decimal? ActualSTDLETotalClosingCostJ { get; set; }

		[DataMember(Name="adjustmentsOtherCredits")]
		public decimal? AdjustmentsOtherCredits { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt1")]
		public decimal? AdjustmentsOtherCreditsAmt1 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt10")]
		public decimal? AdjustmentsOtherCreditsAmt10 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt2")]
		public decimal? AdjustmentsOtherCreditsAmt2 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt3")]
		public decimal? AdjustmentsOtherCreditsAmt3 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt4")]
		public decimal? AdjustmentsOtherCreditsAmt4 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt5")]
		public decimal? AdjustmentsOtherCreditsAmt5 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt6")]
		public decimal? AdjustmentsOtherCreditsAmt6 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt7")]
		public decimal? AdjustmentsOtherCreditsAmt7 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt8")]
		public decimal? AdjustmentsOtherCreditsAmt8 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt9")]
		public decimal? AdjustmentsOtherCreditsAmt9 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc1")]
		public string AdjustmentsOtherCreditsDesc1 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc10")]
		public string AdjustmentsOtherCreditsDesc10 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc2")]
		public string AdjustmentsOtherCreditsDesc2 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc3")]
		public string AdjustmentsOtherCreditsDesc3 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc4")]
		public string AdjustmentsOtherCreditsDesc4 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc5")]
		public string AdjustmentsOtherCreditsDesc5 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc6")]
		public string AdjustmentsOtherCreditsDesc6 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc7")]
		public string AdjustmentsOtherCreditsDesc7 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc8")]
		public string AdjustmentsOtherCreditsDesc8 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc9")]
		public string AdjustmentsOtherCreditsDesc9 { get; set; }

		[DataMember(Name="closingCostsFinanced")]
		public decimal? ClosingCostsFinanced { get; set; }

		[DataMember(Name="downPayment")]
		public decimal? DownPayment { get; set; }

		[DataMember(Name="estimatedCashToCloseAV")]
		public decimal? EstimatedCashToCloseAV { get; set; }

		[DataMember(Name="estimatedCashToCloseSV")]
		public decimal? EstimatedCashToCloseSV { get; set; }

		[DataMember(Name="estimatedTotalPayoffsAndPaymentsAmount")]
		public int? EstimatedTotalPayoffsAndPaymentsAmount { get; set; }

		[DataMember(Name="firstChangeFrequencyMonth")]
		public int? FirstChangeFrequencyMonth { get; set; }

		[DataMember(Name="firstChangeMonthSuffix")]
		public string FirstChangeMonthSuffix { get; set; }

		[DataMember(Name="fromOrToBorrower")]
		public string FromOrToBorrower { get; set; }

		[DataMember(Name="fundsForBorrower")]
		public decimal? FundsForBorrower { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="indexMargin")]
		public string IndexMargin { get; set; }

		[DataMember(Name="initialEscrowPaymentClosingSubTotal")]
		public int? InitialEscrowPaymentClosingSubTotal { get; set; }

		[DataMember(Name="itemizeServiceSectionCType")]
		public bool? ItemizeServiceSectionCType { get; set; }

		[DataMember(Name="lenderCredits")]
		public int? LenderCredits { get; set; }

		[DataMember(Name="originationChargesSubTotal")]
		public int? OriginationChargesSubTotal { get; set; }

		[DataMember(Name="otherSubTotal")]
		public int? OtherSubTotal { get; set; }

		[DataMember(Name="prepaidsSubTotal")]
		public int? PrepaidsSubTotal { get; set; }

		[DataMember(Name="sellerCreditAmount")]
		public int? SellerCreditAmount { get; set; }

		[DataMember(Name="servicesYouNotShopSubTotal")]
		public int? ServicesYouNotShopSubTotal { get; set; }

		[DataMember(Name="servicesYouShopSubTotal")]
		public int? ServicesYouShopSubTotal { get; set; }

		[DataMember(Name="subseqChangeMonthSuffix")]
		public string SubseqChangeMonthSuffix { get; set; }

		[DataMember(Name="taxesGovFeesSubTotal")]
		public int? TaxesGovFeesSubTotal { get; set; }

		[DataMember(Name="thirdPartyPaymentsNotOtherwiseDisclosed")]
		public decimal? ThirdPartyPaymentsNotOtherwiseDisclosed { get; set; }

		[DataMember(Name="totalClosingCosts")]
		public int? TotalClosingCosts { get; set; }

		[DataMember(Name="totalLoanAndOtherCosts")]
		public int? TotalLoanAndOtherCosts { get; set; }

		[DataMember(Name="totalLoanCosts")]
		public int? TotalLoanCosts { get; set; }

		[DataMember(Name="totalOtherCosts")]
		public int? TotalOtherCosts { get; set; }

		[DataMember(Name="unroundedTotalLoanCosts")]
		public decimal? UnroundedTotalLoanCosts { get; set; }

		[DataMember(Name="unroundedTotalOtherCosts")]
		public decimal? UnroundedTotalOtherCosts { get; set; }

		[DataMember(Name="useActualDownPaymentAndClosingCostsFinancedIndicator")]
		public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get; set; }

		[DataMember(Name="useAlternate")]
		public bool? UseAlternate { get; set; }

	}
}