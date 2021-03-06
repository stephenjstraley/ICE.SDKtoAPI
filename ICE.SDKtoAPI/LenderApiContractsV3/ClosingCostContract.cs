using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingCostContract
    {
        [DataMember(Name = "adjustmentFactor")]
        public decimal? AdjustmentFactor { get; set; }

        [DataMember(Name = "aggregateAdjustmentFwbc")]
        public string AggregateAdjustmentFwbc { get; set; }

        [DataMember(Name = "borrowerPaidDiscountPointsTotalAmount")]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get; set; }

        [DataMember(Name = "brokerCommissionBasedPrice")]
        public decimal? BrokerCommissionBasedPrice { get; set; }

        [DataMember(Name = "brokerCommissionBasedUnitPercentage")]
        public decimal? BrokerCommissionBasedUnitPercentage { get; set; }

        [DataMember(Name = "brokerCommissionBasedUnitPrice")]
        public decimal? BrokerCommissionBasedUnitPrice { get; set; }

        [DataMember(Name = "closingCostProgram")]
        public string ClosingCostProgram { get; set; }

        [DataMember(Name = "disclosedSalesPrice")]
        public decimal? DisclosedSalesPrice { get; set; }

        [DataMember(Name = "escrowCompanyName")]
        public string EscrowCompanyName { get; set; }

        [DataMember(Name = "escrowTableDesc1")]
        public string EscrowTableDesc1 { get; set; }

        [DataMember(Name = "escrowTableDesc2")]
        public string EscrowTableDesc2 { get; set; }

        [DataMember(Name = "escrowTableDesc3")]
        public string EscrowTableDesc3 { get; set; }

        [DataMember(Name = "escrowTableDesc4")]
        public string EscrowTableDesc4 { get; set; }

        [DataMember(Name = "escrowTableDesc5")]
        public string EscrowTableDesc5 { get; set; }

        [DataMember(Name = "escrowTableFee")]
        public decimal? EscrowTableFee { get; set; }

        [DataMember(Name = "escrowTableFee1")]
        public decimal? EscrowTableFee1 { get; set; }

        [DataMember(Name = "escrowTableFee2")]
        public decimal? EscrowTableFee2 { get; set; }

        [DataMember(Name = "escrowTableFee3")]
        public decimal? EscrowTableFee3 { get; set; }

        [DataMember(Name = "escrowTableFee4")]
        public decimal? EscrowTableFee4 { get; set; }

        [DataMember(Name = "escrowTableFee5")]
        public decimal? EscrowTableFee5 { get; set; }

        [DataMember(Name = "escrowTableName")]
        public string EscrowTableName { get; set; }

        [DataMember(Name = "closingDisclosure5")]
        public ClosingDisclosure5Contract ClosingDisclosure5 { get; set; }

        [DataMember(Name = "gfe2010")]
        public Gfe2010Contract Gfe2010 { get; set; }

        [DataMember(Name = "gfe2010Page")]
        public Gfe2010PageContract Gfe2010Page { get; set; }

        [DataMember(Name = "gfe2010Section")]
        public Gfe2010SectionContract Gfe2010Section { get; set; }

        [DataMember(Name = "impoundHazInsRate")]
        public decimal? ImpoundHazInsRate { get; set; }

        [DataMember(Name = "impoundMortgInsPremRate")]
        public decimal? ImpoundMortgInsPremRate { get; set; }

        [DataMember(Name = "impoundMortgInsPremYearlyBasis")]
        public string ImpoundMortgInsPremYearlyBasis { get; set; }

        [DataMember(Name = "impoundTaxesRate")]
        public decimal? ImpoundTaxesRate { get; set; }

        [DataMember(Name = "impoundType1")]
        public string ImpoundType1 { get; set; }

        [DataMember(Name = "impoundType2")]
        public string ImpoundType2 { get; set; }

        [DataMember(Name = "impoundType3")]
        public string ImpoundType3 { get; set; }

        [DataMember(Name = "impoundType4")]
        public string ImpoundType4 { get; set; }

        [DataMember(Name = "proposedMonthlyHazardInsurance")]
        public decimal? ProposedMonthlyHazardInsurance { get; set; }

        [DataMember(Name = "proposedMonthlyMortgageInsurance")]
        public decimal? ProposedMonthlyMortgageInsurance { get; set; }

        [DataMember(Name = "section1000BorrowerPaidTotalAmount")]
        public decimal? Section1000BorrowerPaidTotalAmount { get; set; }

        [DataMember(Name = "section1000SellerPaidTotalAmount")]
        public decimal? Section1000SellerPaidTotalAmount { get; set; }

        [DataMember(Name = "settlementClosingFeeNewHudBorPaidAmount")]
        public decimal? SettlementClosingFeeNewHudBorPaidAmount { get; set; }

        [DataMember(Name = "settlementClosingFeeNewHudSelPaidAmount")]
        public decimal? SettlementClosingFeeNewHudSelPaidAmount { get; set; }

        [DataMember(Name = "titleCompanyName")]
        public string TitleCompanyName { get; set; }

        [DataMember(Name = "titleExaminationNewHudSelPaidAmount")]
        public decimal? TitleExaminationNewHudSelPaidAmount { get; set; }

        [DataMember(Name = "titleTable2010Name")]
        public string TitleTable2010Name { get; set; }

        [DataMember(Name = "titleTableName")]
        public string TitleTableName { get; set; }

        [DataMember(Name = "totalForBorPaid1")]
        public decimal? TotalForBorPaid1 { get; set; }

        [DataMember(Name = "totalForBorPaid2")]
        public decimal? TotalForBorPaid2 { get; set; }

        [DataMember(Name = "totalForBorPaid3")]
        public decimal? TotalForBorPaid3 { get; set; }

        [DataMember(Name = "totalForBorPaid4")]
        public decimal? TotalForBorPaid4 { get; set; }

        [DataMember(Name = "totalForBorPaid5")]
        public decimal? TotalForBorPaid5 { get; set; }

        [DataMember(Name = "totalForBorPaid6")]
        public decimal? TotalForBorPaid6 { get; set; }

        [DataMember(Name = "totalForSellerPaid1")]
        public decimal? TotalForSellerPaid1 { get; set; }

        [DataMember(Name = "totalForSellerPaid2")]
        public decimal? TotalForSellerPaid2 { get; set; }

        [DataMember(Name = "totalForSellerPaid3")]
        public decimal? TotalForSellerPaid3 { get; set; }

        [DataMember(Name = "totalForSellerPaid4")]
        public decimal? TotalForSellerPaid4 { get; set; }

        [DataMember(Name = "totalForSellerPaid5")]
        public decimal? TotalForSellerPaid5 { get; set; }

        [DataMember(Name = "totalForSellerPaid6")]
        public decimal? TotalForSellerPaid6 { get; set; }

        [DataMember(Name = "loanEstimate1")]
        public LoanEstimate1Contract LoanEstimate1 { get; set; }

        [DataMember(Name = "loanEstimate2")]
        public LoanEstimate2Contract LoanEstimate2 { get; set; }

        [DataMember(Name = "loanEstimate3")]
        public LoanEstimate3Contract LoanEstimate3 { get; set; }

        [DataMember(Name = "closingDisclosure1")]
        public ClosingDisclosure1Contract ClosingDisclosure1 { get; set; }

        [DataMember(Name = "closingDisclosure2")]
        public ClosingDisclosure2Contract ClosingDisclosure2 { get; set; }

        [DataMember(Name = "closingDisclosure3")]
        public ClosingDisclosure3Contract ClosingDisclosure3 { get; set; }

        [DataMember(Name = "closingDisclosure4")]
        public ClosingDisclosure4Contract ClosingDisclosure4 { get; set; }

        [DataMember(Name = "feeVarianceOther")]
        public FeeVarianceOtherContract FeeVarianceOther { get; set; }

        [DataMember(Name = "feeVariances")]
        public List<FeeVarianceContract> FeeVariances { get; set; }

    }
}
