using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure2
	{
		[DataMember(Name="borrowerClosingCostAtClosing", EmitDefaultValue=false)]
		public double? BorrowerClosingCostAtClosing { get; set; }

		[DataMember(Name="borrowerClosingCostBeforeClosing", EmitDefaultValue=false)]
		public double? BorrowerClosingCostBeforeClosing { get; set; }

		[DataMember(Name="closingCostLenderCredits", EmitDefaultValue=false)]
		public double? ClosingCostLenderCredits { get; set; }

		[DataMember(Name="closingCostPaidByOthers", EmitDefaultValue=false)]
		public double? ClosingCostPaidByOthers { get; set; }

		[DataMember(Name="discloseLenderCredits", EmitDefaultValue=false)]
		public double? DiscloseLenderCredits { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialEscrowSubTotal", EmitDefaultValue=false)]
		public double? InitialEscrowSubTotal { get; set; }

		[DataMember(Name="lastDisclosedLenderCredits", EmitDefaultValue=false)]
		public double? LastDisclosedLenderCredits { get; set; }

		[DataMember(Name="lastDisclosedLoanCosts", EmitDefaultValue=false)]
		public double? LastDisclosedLoanCosts { get; set; }

		[DataMember(Name="lastDisclosedOtherCosts", EmitDefaultValue=false)]
		public double? LastDisclosedOtherCosts { get; set; }

		[DataMember(Name="lCAtClosing", EmitDefaultValue=false)]
		public double? LCAtClosing { get; set; }

		[DataMember(Name="originationChargesSubTotal", EmitDefaultValue=false)]
		public double? OriginationChargesSubTotal { get; set; }

		[DataMember(Name="otherSubTotal", EmitDefaultValue=false)]
		public double? OtherSubTotal { get; set; }

		[DataMember(Name="prepaidsSubTotal", EmitDefaultValue=false)]
		public double? PrepaidsSubTotal { get; set; }

		[DataMember(Name="sellerClosingCostAtClosing", EmitDefaultValue=false)]
		public double? SellerClosingCostAtClosing { get; set; }

		[DataMember(Name="sellerClosingCostBeforeClosing", EmitDefaultValue=false)]
		public double? SellerClosingCostBeforeClosing { get; set; }

		[DataMember(Name="servicesDidNotShopSubTotal", EmitDefaultValue=false)]
		public double? ServicesDidNotShopSubTotal { get; set; }

		[DataMember(Name="servicesDidShopSubTotal", EmitDefaultValue=false)]
		public double? ServicesDidShopSubTotal { get; set; }

		[DataMember(Name="taxesGovermentFeesSubTotal", EmitDefaultValue=false)]
		public double? TaxesGovermentFeesSubTotal { get; set; }

		[DataMember(Name="totalBorrowerPaidAtClosing", EmitDefaultValue=false)]
		public double? TotalBorrowerPaidAtClosing { get; set; }

		[DataMember(Name="totalBorrowerPaidBeforeClosing", EmitDefaultValue=false)]
		public double? TotalBorrowerPaidBeforeClosing { get; set; }

		[DataMember(Name="totalClosingCost", EmitDefaultValue=false)]
		public double? TotalClosingCost { get; set; }

		[DataMember(Name="totalLoanCost", EmitDefaultValue=false)]
		public double? TotalLoanCost { get; set; }

		[DataMember(Name="totalOtherCost", EmitDefaultValue=false)]
		public double? TotalOtherCost { get; set; }

		[DataMember(Name="totalOtherCostAtClosing", EmitDefaultValue=false)]
		public double? TotalOtherCostAtClosing { get; set; }

		[DataMember(Name="totalOtherCostBeforeClosing", EmitDefaultValue=false)]
		public double? TotalOtherCostBeforeClosing { get; set; }

	}
}