using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class McawContract
    {
        [DataMember(Name = "adequacyOfAvailableAssetsType")]
        public string AdequacyOfAvailableAssetsType { get; set; }

        [DataMember(Name = "adequacyOfEffectiveIncomeType")]
        public string AdequacyOfEffectiveIncomeType { get; set; }

        [DataMember(Name = "adjustedPurchasePrice")]
        public decimal? AdjustedPurchasePrice { get; set; }

        [DataMember(Name = "appraisedValue1")]
        public decimal? AppraisedValue1 { get; set; }

        [DataMember(Name = "appraisedValue2")]
        public decimal? AppraisedValue2 { get; set; }

        [DataMember(Name = "borrowerPaidClosingCost")]
        public decimal? BorrowerPaidClosingCost { get; set; }

        [DataMember(Name = "calculatedMortgageAmount")]
        public decimal? CalculatedMortgageAmount { get; set; }

        [DataMember(Name = "cashReserves")]
        public decimal? CashReserves { get; set; }

        [DataMember(Name = "constructionType")]
        public string ConstructionType { get; set; }

        [DataMember(Name = "contractSalesPrice")]
        public decimal? ContractSalesPrice { get; set; }

        [DataMember(Name = "creditCharacteristicsType")]
        public string CreditCharacteristicsType { get; set; }

        [DataMember(Name = "equityToExSpouse")]
        public decimal? EquityToExSpouse { get; set; }

        [DataMember(Name = "fhaMaxLoanAmount")]
        public decimal? FhaMaxLoanAmount { get; set; }

        [DataMember(Name = "fhaUnderwriterChumsId")]
        public string FhaUnderwriterChumsId { get; set; }

        [DataMember(Name = "giftFundsSource")]
        public string GiftFundsSource { get; set; }

        [DataMember(Name = "lesserSalesPrice")]
        public decimal? LesserSalesPrice { get; set; }

        [DataMember(Name = "ltv1")]
        public decimal? Ltv1 { get; set; }

        [DataMember(Name = "ltv2")]
        public decimal? Ltv2 { get; set; }

        [DataMember(Name = "mortgageAmount")]
        public decimal? MortgageAmount { get; set; }

        [DataMember(Name = "mortgageAmountPercent")]
        public decimal? MortgageAmountPercent { get; set; }

        [DataMember(Name = "mortgageBasisPurchase")]
        public decimal? MortgageBasisPurchase { get; set; }

        [DataMember(Name = "mortgageBasisRefinance")]
        public decimal? MortgageBasisRefinance { get; set; }

        [DataMember(Name = "paidType1")]
        public string PaidType1 { get; set; }

        [DataMember(Name = "paidType2")]
        public string PaidType2 { get; set; }

        [DataMember(Name = "principalBalance")]
        public decimal? PrincipalBalance { get; set; }

        [DataMember(Name = "refinanceType")]
        public string RefinanceType { get; set; }

        [DataMember(Name = "remarks")]
        public string Remarks { get; set; }

        [DataMember(Name = "repairsAndImprovements")]
        public decimal? RepairsAndImprovements { get; set; }

        [DataMember(Name = "repairsAndImprovementsDescription")]
        public string RepairsAndImprovementsDescription { get; set; }

        [DataMember(Name = "repairsRequiredByAppraiser")]
        public decimal? RepairsRequiredByAppraiser { get; set; }

        [DataMember(Name = "requiredInvestment")]
        public decimal? RequiredInvestment { get; set; }

        [DataMember(Name = "requirementAdjustment")]
        public decimal? RequirementAdjustment { get; set; }

        [DataMember(Name = "roundTo50Indicator")]
        public bool? RoundTo50Indicator { get; set; }

        [DataMember(Name = "seasonedSubordinateLiens")]
        public decimal? SeasonedSubordinateLiens { get; set; }

        [DataMember(Name = "secondMortgageSource")]
        public string SecondMortgageSource { get; set; }

        [DataMember(Name = "sixPercentOfLineA1")]
        public decimal? SixPercentOfLineA1 { get; set; }

        [DataMember(Name = "maximumSellerContribution4Percent")]
        public decimal? MaximumSellerContribution4Percent { get; set; }

        [DataMember(Name = "stabilityOfEffectiveIncomeType")]
        public string StabilityOfEffectiveIncomeType { get; set; }

        [DataMember(Name = "statutoryInvestment")]
        public decimal? StatutoryInvestment { get; set; }

        [DataMember(Name = "toBePaidAmount")]
        public decimal? ToBePaidAmount { get; set; }

        [DataMember(Name = "totalCashToClose")]
        public decimal? TotalCashToClose { get; set; }

        [DataMember(Name = "totalRequirements")]
        public decimal? TotalRequirements { get; set; }

        [DataMember(Name = "totalSellerContribution")]
        public decimal? TotalSellerContribution { get; set; }

        [DataMember(Name = "unadjustedAcquisition")]
        public decimal? UnadjustedAcquisition { get; set; }

        [DataMember(Name = "use85PercentRuleIndicator")]
        public bool? Use85PercentRuleIndicator { get; set; }

        [DataMember(Name = "repairsImprovementAmount")]
        public decimal? RepairsImprovementAmount { get; set; }

    }
}
