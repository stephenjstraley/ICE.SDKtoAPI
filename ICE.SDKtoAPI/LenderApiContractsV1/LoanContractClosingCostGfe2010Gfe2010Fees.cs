using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010Gfe2010Fees
	{
		[DataMember(Name="additionalAmount", EmitDefaultValue=false)]
		public double? AdditionalAmount { get; set; }

		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="aprIndicator", EmitDefaultValue=false)]
		public bool? AprIndicator { get; set; }

		[DataMember(Name="borPaidAmount", EmitDefaultValue=false)]
		public double? BorPaidAmount { get; set; }

		[DataMember(Name="borrowerAmountPaid2015", EmitDefaultValue=false)]
		public double? BorrowerAmountPaid2015 { get; set; }

		[DataMember(Name="borrowerCanShopForIndicator2015", EmitDefaultValue=false)]
		public bool? BorrowerCanShopForIndicator2015 { get; set; }

		[DataMember(Name="borrowerDidShopForIndicator2015", EmitDefaultValue=false)]
		public bool? BorrowerDidShopForIndicator2015 { get; set; }

		[DataMember(Name="borrowerFinanced2015", EmitDefaultValue=false)]
		public double? BorrowerFinanced2015 { get; set; }

		[DataMember(Name="borrowerPAC2015", EmitDefaultValue=false)]
		public double? BorrowerPAC2015 { get; set; }

		[DataMember(Name="borrowerPOC2015", EmitDefaultValue=false)]
		public double? BorrowerPOC2015 { get; set; }

		[DataMember(Name="borrowerPTC2015", EmitDefaultValue=false)]
		public double? BorrowerPTC2015 { get; set; }

		[DataMember(Name="borrowerSelectIndicator", EmitDefaultValue=false)]
		public bool? BorrowerSelectIndicator { get; set; }

		[DataMember(Name="brokerAmountPaid2015", EmitDefaultValue=false)]
		public double? BrokerAmountPaid2015 { get; set; }

		[DataMember(Name="brokerPAC2015", EmitDefaultValue=false)]
		public double? BrokerPAC2015 { get; set; }

		[DataMember(Name="brokerPOC2015", EmitDefaultValue=false)]
		public double? BrokerPOC2015 { get; set; }

		[DataMember(Name="collectedPostConsummationIndicator2015", EmitDefaultValue=false)]
		public bool? CollectedPostConsummationIndicator2015 { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="escrowedIndicator2015", EmitDefaultValue=false)]
		public bool? EscrowedIndicator2015 { get; set; }

		[DataMember(Name = "financedIndicator", EmitDefaultValue = false)]
		public bool? FinancedIndicator { get; set; } = false;

		[DataMember(Name="gfe2010FeeIndex", EmitDefaultValue=false)]
		public int? Gfe2010FeeIndex { get; set; }

		[DataMember(Name="gfe2010FeeParentType", EmitDefaultValue=false)]
		public string Gfe2010FeeParentType { get; set; }

		[DataMember(Name="gfe2010FeeType", EmitDefaultValue=false)]
		public string Gfe2010FeeType { get; set; }

		[DataMember(Name="gfeAmount", EmitDefaultValue=false)]
		public double? GfeAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="insuranceIndicator2015", EmitDefaultValue=false)]
		public bool? InsuranceIndicator2015 { get; set; }

		[DataMember(Name="lastDisclosedClosingDisclosure2015", EmitDefaultValue=false)]
		public double? LastDisclosedClosingDisclosure2015 { get; set; }

		[DataMember(Name="lastDisclosedLoanEstimate2015", EmitDefaultValue=false)]
		public int? LastDisclosedLoanEstimate2015 { get; set; }

		[DataMember(Name="lenderAmountPaid2015", EmitDefaultValue=false)]
		public double? LenderAmountPaid2015 { get; set; }

		[DataMember(Name="lenderPAC2015", EmitDefaultValue=false)]
		public double? LenderPAC2015 { get; set; }

		[DataMember(Name="lenderPOC2015", EmitDefaultValue=false)]
		public double? LenderPOC2015 { get; set; }

		[DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
		public double? MonthlyPayment { get; set; }

		[DataMember(Name="numberOfMonths", EmitDefaultValue=false)]
		public int? NumberOfMonths { get; set; }

		[DataMember(Name="optionalIndicator2015", EmitDefaultValue=false)]
		public bool? OptionalIndicator2015 { get; set; }

		[DataMember(Name="otherAmountPaid2015", EmitDefaultValue=false)]
		public double? OtherAmountPaid2015 { get; set; }

		[DataMember(Name="otherPAC2015", EmitDefaultValue=false)]
		public double? OtherPAC2015 { get; set; }

		[DataMember(Name="otherPOC2015", EmitDefaultValue=false)]
		public double? OtherPOC2015 { get; set; }

		[DataMember(Name="paidByType", EmitDefaultValue=false)]
		public string PaidByType { get; set; }

		[DataMember(Name="paidToName", EmitDefaultValue=false)]
		public string PaidToName { get; set; }

		[DataMember(Name = "pocPtcIndicator", EmitDefaultValue = false)]
		public bool? PocPtcIndicator { get; set; } = false;

		[DataMember(Name="propertyIndicator2015", EmitDefaultValue=false)]
		public bool? PropertyIndicator2015 { get; set; }

		[DataMember(Name="ptbType", EmitDefaultValue=false)]
		public string PtbType { get; set; }

		[DataMember(Name="rate", EmitDefaultValue=false)]
		public double? Rate { get; set; }

		[DataMember(Name="retainedAmount2015", EmitDefaultValue=false)]
		public double? RetainedAmount2015 { get; set; }

		[DataMember(Name="sec32PointsAndFees2015", EmitDefaultValue=false)]
		public double? Sec32PointsAndFees2015 { get; set; }

		[DataMember(Name="sellerAmountPaid2015", EmitDefaultValue=false)]
		public double? SellerAmountPaid2015 { get; set; }

		[DataMember(Name = "sellerCreditIndicator2015", EmitDefaultValue = false)]
		public bool? SellerCreditIndicator2015 { get; set; } = false;

		[DataMember(Name="sellerObligatedAmount2015", EmitDefaultValue=false)]
		public double? SellerObligatedAmount2015 { get; set; }

		[DataMember(Name="sellerObligatedIndicator2015", EmitDefaultValue=false)]
		public bool? SellerObligatedIndicator2015 { get; set; }

		[DataMember(Name="sellerPAC2015", EmitDefaultValue=false)]
		public double? SellerPAC2015 { get; set; }

		[DataMember(Name="sellerPOC2015", EmitDefaultValue=false)]
		public double? SellerPOC2015 { get; set; }

		[DataMember(Name="selPaidAmount", EmitDefaultValue=false)]
		public double? SelPaidAmount { get; set; }

		[DataMember(Name="simultaneousIssuanceIndicator2015", EmitDefaultValue=false)]
		public bool? SimultaneousIssuanceIndicator2015 { get; set; }

		[DataMember(Name="taxesIndicator2015", EmitDefaultValue=false)]
		public bool? TaxesIndicator2015 { get; set; }

		[DataMember(Name="titleServiceSelectIndicator", EmitDefaultValue=false)]
		public bool? TitleServiceSelectIndicator { get; set; }

		[DataMember(Name="totalFeeAmount2015", EmitDefaultValue=false)]
		public double? TotalFeeAmount2015 { get; set; }

		[DataMember(Name="totalFeePercentage2015", EmitDefaultValue=false)]
		public double? TotalFeePercentage2015 { get; set; }

		[DataMember(Name="totalPaidByBLO2015", EmitDefaultValue=false)]
		public double? TotalPaidByBLO2015 { get; set; }

		[DataMember(Name="undiscountedInsurance2015", EmitDefaultValue=false)]
		public double? UndiscountedInsurance2015 { get; set; }

		[DataMember(Name="wholePoc", EmitDefaultValue=false)]
		public double? WholePoc { get; set; }

		[DataMember(Name="wholePocPaidByType", EmitDefaultValue=false)]
		public string WholePocPaidByType { get; set; }

	}
}