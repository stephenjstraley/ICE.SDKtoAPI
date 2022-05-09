using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostLoanEstimate2
	{
		[DataMember(Name="actualLenderCredits", EmitDefaultValue=false)]
		public double? ActualLenderCredits { get; set; }

		[DataMember(Name="actualSTDLESellerCredits", EmitDefaultValue=false)]
		public double? ActualSTDLESellerCredits { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJ", EmitDefaultValue=false)]
		public double? ActualSTDLETotalClosingCostJ { get; set; }

		[DataMember(Name="adjustmentsOtherCredits", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCredits { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt1", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt1 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt10", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt10 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt2", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt2 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt3", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt3 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt4", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt4 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt5", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt5 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt6", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt6 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt7", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt7 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt8", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt8 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsAmt9", EmitDefaultValue=false)]
		public double? AdjustmentsOtherCreditsAmt9 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc1", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc1 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc10", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc10 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc2", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc2 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc3", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc3 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc4", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc4 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc5", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc5 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc6", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc6 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc7", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc7 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc8", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc8 { get; set; }

		[DataMember(Name="adjustmentsOtherCreditsDesc9", EmitDefaultValue=false)]
		public string AdjustmentsOtherCreditsDesc9 { get; set; }

		[DataMember(Name="closingCostsFinanced", EmitDefaultValue=false)]
		public double? ClosingCostsFinanced { get; set; }

		[DataMember(Name="downPayment", EmitDefaultValue=false)]
		public double? DownPayment { get; set; }

		[DataMember(Name="estimatedCashToCloseAV", EmitDefaultValue=false)]
		public double? EstimatedCashToCloseAV { get; set; }

		[DataMember(Name="estimatedCashToCloseSV", EmitDefaultValue=false)]
		public double? EstimatedCashToCloseSV { get; set; }

		[DataMember(Name="estimatedTotalPayoffsAndPaymentsAmount", EmitDefaultValue=false)]
		public int? EstimatedTotalPayoffsAndPaymentsAmount { get; set; }

		[DataMember(Name="firstChangeFrequencyMonth", EmitDefaultValue=false)]
		public int? FirstChangeFrequencyMonth { get; set; }

		[DataMember(Name="firstChangeMonthSuffix", EmitDefaultValue=false)]
		public string FirstChangeMonthSuffix { get; set; }

		[DataMember(Name="fromOrToBorrower", EmitDefaultValue=false)]
		public string FromOrToBorrower { get; set; }

		[DataMember(Name="fundsForBorrower", EmitDefaultValue=false)]
		public double? FundsForBorrower { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexMargin", EmitDefaultValue=false)]
		public string IndexMargin { get; set; }

		[DataMember(Name="initialEscrowPaymentClosingSubTotal", EmitDefaultValue=false)]
		public int? InitialEscrowPaymentClosingSubTotal { get; set; }

		[DataMember(Name="itemizeServiceSectionCType", EmitDefaultValue=false)]
		public bool? ItemizeServiceSectionCType { get; set; }

		[DataMember(Name="lenderCredits", EmitDefaultValue=false)]
		public int? LenderCredits { get; set; }

		[DataMember(Name="originationChargesSubTotal", EmitDefaultValue=false)]
		public int? OriginationChargesSubTotal { get; set; }

		[DataMember(Name="otherSubTotal", EmitDefaultValue=false)]
		public int? OtherSubTotal { get; set; }

		[DataMember(Name="prepaidsSubTotal", EmitDefaultValue=false)]
		public int? PrepaidsSubTotal { get; set; }

		[DataMember(Name="sellerCreditAmount", EmitDefaultValue=false)]
		public int? SellerCreditAmount { get; set; }

		[DataMember(Name="servicesYouNotShopSubTotal", EmitDefaultValue=false)]
		public int? ServicesYouNotShopSubTotal { get; set; }

		[DataMember(Name="servicesYouShopSubTotal", EmitDefaultValue=false)]
		public int? ServicesYouShopSubTotal { get; set; }

		[DataMember(Name="subseqChangeMonthSuffix", EmitDefaultValue=false)]
		public string SubseqChangeMonthSuffix { get; set; }

		[DataMember(Name="taxesGovFeesSubTotal", EmitDefaultValue=false)]
		public int? TaxesGovFeesSubTotal { get; set; }

		[DataMember(Name="thirdPartyPaymentsNotOtherwiseDisclosed", EmitDefaultValue=false)]
		public double? ThirdPartyPaymentsNotOtherwiseDisclosed { get; set; }

		[DataMember(Name="totalClosingCosts", EmitDefaultValue=false)]
		public int? TotalClosingCosts { get; set; }

		[DataMember(Name="totalLoanAndOtherCosts", EmitDefaultValue=false)]
		public int? TotalLoanAndOtherCosts { get; set; }

		[DataMember(Name="totalLoanCosts", EmitDefaultValue=false)]
		public int? TotalLoanCosts { get; set; }

		[DataMember(Name="totalOtherCosts", EmitDefaultValue=false)]
		public int? TotalOtherCosts { get; set; }

		[DataMember(Name="unroundedTotalLoanCosts", EmitDefaultValue=false)]
		public double? UnroundedTotalLoanCosts { get; set; }

		[DataMember(Name="unroundedTotalOtherCosts", EmitDefaultValue=false)]
		public double? UnroundedTotalOtherCosts { get; set; }

		[DataMember(Name="useActualDownPaymentAndClosingCostsFinancedIndicator", EmitDefaultValue=false)]
		public bool? UseActualDownPaymentAndClosingCostsFinancedIndicator { get; set; }

		[DataMember(Name="useAlternate", EmitDefaultValue=false)]
		public bool? UseAlternate { get; set; }

	}
}