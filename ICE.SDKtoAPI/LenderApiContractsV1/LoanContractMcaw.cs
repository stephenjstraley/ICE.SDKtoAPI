using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMcaw
	{
		[DataMember(Name="adequacyOfAvailableAssetsType", EmitDefaultValue=false)]
		public string AdequacyOfAvailableAssetsType { get; set; }

		[DataMember(Name="adequacyOfEffectiveIncomeType", EmitDefaultValue=false)]
		public string AdequacyOfEffectiveIncomeType { get; set; }

		[DataMember(Name="adjustedPurchasePrice", EmitDefaultValue=false)]
		public double? AdjustedPurchasePrice { get; set; }

		[DataMember(Name="appraisedValue1", EmitDefaultValue=false)]
		public double? AppraisedValue1 { get; set; }

		[DataMember(Name="appraisedValue2", EmitDefaultValue=false)]
		public double? AppraisedValue2 { get; set; }

		[DataMember(Name="borrowerPaidClosingCost", EmitDefaultValue=false)]
		public double? BorrowerPaidClosingCost { get; set; }

		[DataMember(Name="calculatedMortgageAmount", EmitDefaultValue=false)]
		public double? CalculatedMortgageAmount { get; set; }

		[DataMember(Name="cashReserves", EmitDefaultValue=false)]
		public double? CashReserves { get; set; }

		[DataMember(Name="constructionType", EmitDefaultValue=false)]
		public string ConstructionType { get; set; }

		[DataMember(Name="contractSalesPrice", EmitDefaultValue=false)]
		public double? ContractSalesPrice { get; set; }

		[DataMember(Name="creditCharacteristicsType", EmitDefaultValue=false)]
		public string CreditCharacteristicsType { get; set; }

		[DataMember(Name="equityToExSpouse", EmitDefaultValue=false)]
		public double? EquityToExSpouse { get; set; }

		[DataMember(Name="fhaMaxLoanAmount", EmitDefaultValue=false)]
		public double? FhaMaxLoanAmount { get; set; }

		[DataMember(Name="fhaUnderwriterChumsId", EmitDefaultValue=false)]
		public string FhaUnderwriterChumsId { get; set; }

		[DataMember(Name="giftFundsSource", EmitDefaultValue=false)]
		public string GiftFundsSource { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lesserSalesPrice", EmitDefaultValue=false)]
		public double? LesserSalesPrice { get; set; }

		[DataMember(Name="ltv1", EmitDefaultValue=false)]
		public double? Ltv1 { get; set; }

		[DataMember(Name="ltv2", EmitDefaultValue=false)]
		public double? Ltv2 { get; set; }

		[DataMember(Name="maximumSellerContribution4Percent", EmitDefaultValue=false)]
		public double? MaximumSellerContribution4Percent { get; set; }

		[DataMember(Name="mortgageAmount", EmitDefaultValue=false)]
		public double? MortgageAmount { get; set; }

		[DataMember(Name="mortgageAmountPercent", EmitDefaultValue=false)]
		public double? MortgageAmountPercent { get; set; }

		[DataMember(Name="mortgageBasisPurchase", EmitDefaultValue=false)]
		public double? MortgageBasisPurchase { get; set; }

		[DataMember(Name="mortgageBasisRefinance", EmitDefaultValue=false)]
		public double? MortgageBasisRefinance { get; set; }

		[DataMember(Name="paidType1", EmitDefaultValue=false)]
		public string PaidType1 { get; set; }

		[DataMember(Name="paidType2", EmitDefaultValue=false)]
		public string PaidType2 { get; set; }

		[DataMember(Name="principalBalance", EmitDefaultValue=false)]
		public double? PrincipalBalance { get; set; }

		[DataMember(Name="refinanceType", EmitDefaultValue=false)]
		public string RefinanceType { get; set; }

		[DataMember(Name="remarks", EmitDefaultValue=false)]
		public string Remarks { get; set; }

		[DataMember(Name="repairsAndImprovements", EmitDefaultValue=false)]
		public double? RepairsAndImprovements { get; set; }

		[DataMember(Name="repairsAndImprovementsDescription", EmitDefaultValue=false)]
		public string RepairsAndImprovementsDescription { get; set; }

		[DataMember(Name="repairsImprovementAmount", EmitDefaultValue=false)]
		public double? RepairsImprovementAmount { get; set; }

		[DataMember(Name="repairsRequiredByAppraiser", EmitDefaultValue=false)]
		public double? RepairsRequiredByAppraiser { get; set; }

		[DataMember(Name="requiredInvestment", EmitDefaultValue=false)]
		public double? RequiredInvestment { get; set; }

		[DataMember(Name="requirementAdjustment", EmitDefaultValue=false)]
		public double? RequirementAdjustment { get; set; }

		[DataMember(Name="roundTo50Indicator", EmitDefaultValue=false)]
		public bool? RoundTo50Indicator { get; set; }

		[DataMember(Name="seasonedSubordinateLiens", EmitDefaultValue=false)]
		public double? SeasonedSubordinateLiens { get; set; }

		[DataMember(Name="secondMortgageSource", EmitDefaultValue=false)]
		public string SecondMortgageSource { get; set; }

		[DataMember(Name="sixPercentOfLineA1", EmitDefaultValue=false)]
		public double? SixPercentOfLineA1 { get; set; }

		[DataMember(Name="stabilityOfEffectiveIncomeType", EmitDefaultValue=false)]
		public string StabilityOfEffectiveIncomeType { get; set; }

		[DataMember(Name="statutoryInvestment", EmitDefaultValue=false)]
		public double? StatutoryInvestment { get; set; }

		[DataMember(Name="toBePaidAmount", EmitDefaultValue=false)]
		public double? ToBePaidAmount { get; set; }

		[DataMember(Name="totalCashToClose", EmitDefaultValue=false)]
		public double? TotalCashToClose { get; set; }

		[DataMember(Name="totalRequirements", EmitDefaultValue=false)]
		public double? TotalRequirements { get; set; }

		[DataMember(Name="totalSellerContribution", EmitDefaultValue=false)]
		public double? TotalSellerContribution { get; set; }

		[DataMember(Name="unadjustedAcquisition", EmitDefaultValue=false)]
		public double? UnadjustedAcquisition { get; set; }

		[DataMember(Name="use85PercentRuleIndicator", EmitDefaultValue=false)]
		public bool? Use85PercentRuleIndicator { get; set; }

	}
}