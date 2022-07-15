using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCost
	{
		[DataMember(Name="adjustmentFactor", EmitDefaultValue=false)]
		public double? AdjustmentFactor { get; set; }

		[DataMember(Name="aggregateAdjustmentFwbc", EmitDefaultValue=false)]
		public string AggregateAdjustmentFwbc { get; set; }

		[DataMember(Name="borrowerPaidDiscountPointsTotalAmount", EmitDefaultValue=false)]
		public double? BorrowerPaidDiscountPointsTotalAmount { get; set; }

		[DataMember(Name="brokerCommissionBasedPrice", EmitDefaultValue=false)]
		public double? BrokerCommissionBasedPrice { get; set; }

		[DataMember(Name="brokerCommissionBasedUnitPercentage", EmitDefaultValue=false)]
		public double? BrokerCommissionBasedUnitPercentage { get; set; }

		[DataMember(Name="brokerCommissionBasedUnitPrice", EmitDefaultValue=false)]
		public double? BrokerCommissionBasedUnitPrice { get; set; }

		[DataMember(Name="closingCostProgram", EmitDefaultValue=false)]
		public string ClosingCostProgram { get; set; }

		[DataMember(Name="closingCostScenarioXml", EmitDefaultValue=false)]
		public string ClosingCostScenarioXml { get; set; }

		[DataMember(Name="closingDisclosure1", EmitDefaultValue=false)]
		public LoanContractClosingCostClosingDisclosure1 ClosingDisclosure1 { get; set; }

		[DataMember(Name="closingDisclosure2", EmitDefaultValue=false)]
		public LoanContractClosingCostClosingDisclosure2 ClosingDisclosure2 { get; set; }

		[DataMember(Name="closingDisclosure3", EmitDefaultValue=false)]
		public LoanContractClosingCostClosingDisclosure3 ClosingDisclosure3 { get; set; }

		[DataMember(Name="closingDisclosure4", EmitDefaultValue=false)]
		public LoanContractClosingCostClosingDisclosure4 ClosingDisclosure4 { get; set; }

		[DataMember(Name="closingDisclosure5", EmitDefaultValue=false)]
		public LoanContractClosingCostClosingDisclosure5 ClosingDisclosure5 { get; set; }

		[DataMember(Name="escrowCompanyName", EmitDefaultValue=false)]
		public string EscrowCompanyName { get; set; }

		[DataMember(Name="escrowTableDesc1", EmitDefaultValue=false)]
		public string EscrowTableDesc1 { get; set; }

		[DataMember(Name="escrowTableDesc2", EmitDefaultValue=false)]
		public string EscrowTableDesc2 { get; set; }

		[DataMember(Name="escrowTableDesc3", EmitDefaultValue=false)]
		public string EscrowTableDesc3 { get; set; }

		[DataMember(Name="escrowTableDesc4", EmitDefaultValue=false)]
		public string EscrowTableDesc4 { get; set; }

		[DataMember(Name="escrowTableDesc5", EmitDefaultValue=false)]
		public string EscrowTableDesc5 { get; set; }

		[DataMember(Name="escrowTableFee", EmitDefaultValue=false)]
		public double? EscrowTableFee { get; set; }

		[DataMember(Name="escrowTableFee1", EmitDefaultValue=false)]
		public double? EscrowTableFee1 { get; set; }

		[DataMember(Name="escrowTableFee2", EmitDefaultValue=false)]
		public double? EscrowTableFee2 { get; set; }

		[DataMember(Name="escrowTableFee3", EmitDefaultValue=false)]
		public double? EscrowTableFee3 { get; set; }

		[DataMember(Name="escrowTableFee4", EmitDefaultValue=false)]
		public double? EscrowTableFee4 { get; set; }

		[DataMember(Name="escrowTableFee5", EmitDefaultValue=false)]
		public double? EscrowTableFee5 { get; set; }

		[DataMember(Name="escrowTableName", EmitDefaultValue=false)]
		public string EscrowTableName { get; set; }

		[DataMember(Name="feeVarianceOther", EmitDefaultValue=false)]
		public LoanContractClosingCostFeeVarianceOther FeeVarianceOther { get; set; }

		[DataMember(Name="feeVariances", EmitDefaultValue=false)]
		public List<LoanContractClosingCostFeeVariances> FeeVariances { get; set; }

		[DataMember(Name="gfe2010", EmitDefaultValue=false)]
		public LoanContractClosingCostGfe2010 Gfe2010 { get; set; }

		[DataMember(Name="gfe2010Page", EmitDefaultValue=false)]
		public LoanContractClosingCostGfe2010Page Gfe2010Page { get; set; }

		[DataMember(Name="gfe2010Section", EmitDefaultValue=false)]
		public LoanContractClosingCostGfe2010Section Gfe2010Section { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="impoundHazInsRate", EmitDefaultValue=false)]
		public double? ImpoundHazInsRate { get; set; }

		[DataMember(Name="impoundMortgInsPremRate", EmitDefaultValue=false)]
		public double? ImpoundMortgInsPremRate { get; set; }

		[DataMember(Name="impoundMortgInsPremYearlyBasis", EmitDefaultValue=false)]
		public string ImpoundMortgInsPremYearlyBasis { get; set; }

		[DataMember(Name="impoundTaxesRate", EmitDefaultValue=false)]
		public double? ImpoundTaxesRate { get; set; }

		[DataMember(Name="impoundType1", EmitDefaultValue=false)]
		public string ImpoundType1 { get; set; }

		[DataMember(Name="impoundType2", EmitDefaultValue=false)]
		public string ImpoundType2 { get; set; }

		[DataMember(Name="impoundType3", EmitDefaultValue=false)]
		public string ImpoundType3 { get; set; }

		[DataMember(Name="impoundType4", EmitDefaultValue=false)]
		public string ImpoundType4 { get; set; }

		[DataMember(Name="loanEstimate1", EmitDefaultValue=false)]
		public LoanContractClosingCostLoanEstimate1 LoanEstimate1 { get; set; }

		[DataMember(Name="loanEstimate2", EmitDefaultValue=false)]
		public LoanContractClosingCostLoanEstimate2 LoanEstimate2 { get; set; }

		[DataMember(Name="loanEstimate3", EmitDefaultValue=false)]
		public LoanContractClosingCostLoanEstimate3 LoanEstimate3 { get; set; }

		[DataMember(Name="proposedMonthlyHazardInsurance", EmitDefaultValue=false)]
		public double? ProposedMonthlyHazardInsurance { get; set; }

		[DataMember(Name="proposedMonthlyMortgageInsurance", EmitDefaultValue=false)]
		public double? ProposedMonthlyMortgageInsurance { get; set; }

		[DataMember(Name="section1000BorrowerPaidTotalAmount", EmitDefaultValue=false)]
		public double? Section1000BorrowerPaidTotalAmount { get; set; }

		[DataMember(Name="section1000SellerPaidTotalAmount", EmitDefaultValue=false)]
		public double? Section1000SellerPaidTotalAmount { get; set; }

		[DataMember(Name="settlementClosingFeeNewHudBorPaidAmount", EmitDefaultValue=false)]
		public double? SettlementClosingFeeNewHudBorPaidAmount { get; set; }

		[DataMember(Name="settlementClosingFeeNewHudSelPaidAmount", EmitDefaultValue=false)]
		public double? SettlementClosingFeeNewHudSelPaidAmount { get; set; }

		[DataMember(Name="titleCompanyName", EmitDefaultValue=false)]
		public string TitleCompanyName { get; set; }

		[DataMember(Name="titleExaminationNewHudSelPaidAmount", EmitDefaultValue=false)]
		public double? TitleExaminationNewHudSelPaidAmount { get; set; }

		[DataMember(Name="titleTable2010Name", EmitDefaultValue=false)]
		public string TitleTable2010Name { get; set; }

		[DataMember(Name="titleTableName", EmitDefaultValue=false)]
		public string TitleTableName { get; set; }

		[DataMember(Name="totalForBorPaid1", EmitDefaultValue=false)]
		public double? TotalForBorPaid1 { get; set; }

		[DataMember(Name="totalForBorPaid2", EmitDefaultValue=false)]
		public double? TotalForBorPaid2 { get; set; }

		[DataMember(Name="totalForBorPaid3", EmitDefaultValue=false)]
		public double? TotalForBorPaid3 { get; set; }

		[DataMember(Name="totalForBorPaid4", EmitDefaultValue=false)]
		public double? TotalForBorPaid4 { get; set; }

		[DataMember(Name="totalForBorPaid5", EmitDefaultValue=false)]
		public double? TotalForBorPaid5 { get; set; }

		[DataMember(Name="totalForBorPaid6", EmitDefaultValue=false)]
		public double? TotalForBorPaid6 { get; set; }

		[DataMember(Name="totalForSellerPaid1", EmitDefaultValue=false)]
		public double? TotalForSellerPaid1 { get; set; }

		[DataMember(Name="totalForSellerPaid2", EmitDefaultValue=false)]
		public double? TotalForSellerPaid2 { get; set; }

		[DataMember(Name="totalForSellerPaid3", EmitDefaultValue=false)]
		public double? TotalForSellerPaid3 { get; set; }

		[DataMember(Name="totalForSellerPaid4", EmitDefaultValue=false)]
		public double? TotalForSellerPaid4 { get; set; }

		[DataMember(Name="totalForSellerPaid5", EmitDefaultValue=false)]
		public double? TotalForSellerPaid5 { get; set; }

		[DataMember(Name="totalForSellerPaid6", EmitDefaultValue=false)]
		public double? TotalForSellerPaid6 { get; set; }

		[DataMember(Name = "disclosedSalesPrice")]
		public decimal? DisclosedSalesPrice { get; set; }

	}
}