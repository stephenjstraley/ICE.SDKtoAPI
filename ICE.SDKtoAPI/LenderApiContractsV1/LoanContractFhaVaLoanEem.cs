using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFhaVaLoanEem
	{
		[DataMember(Name="appraisedValue", EmitDefaultValue=false)]
		public double? AppraisedValue { get; set; }

		[DataMember(Name="auditCost", EmitDefaultValue=false)]
		public double? AuditCost { get; set; }

		[DataMember(Name="backRatio", EmitDefaultValue=false)]
		public double? BackRatio { get; set; }

		[DataMember(Name="baseLoanAmtFromTsum", EmitDefaultValue=false)]
		public double? BaseLoanAmtFromTsum { get; set; }

		[DataMember(Name="costEffectiveEnergyPackage", EmitDefaultValue=false)]
		public double? CostEffectiveEnergyPackage { get; set; }

		[DataMember(Name="eeCostMaximumAmount", EmitDefaultValue=false)]
		public double? EeCostMaximumAmount { get; set; }

		[DataMember(Name="eeImprovementsInstalledCost", EmitDefaultValue=false)]
		public double? EeImprovementsInstalledCost { get; set; }

		[DataMember(Name="energyCost", EmitDefaultValue=false)]
		public double? EnergyCost { get; set; }

		[DataMember(Name="energySavings", EmitDefaultValue=false)]
		public double? EnergySavings { get; set; }

		[DataMember(Name="hoa", EmitDefaultValue=false)]
		public double? Hoa { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="improvementCostExceed2000", EmitDefaultValue=false)]
		public double? ImprovementCostExceed2000 { get; set; }

		[DataMember(Name="inspectionCost", EmitDefaultValue=false)]
		public double? InspectionCost { get; set; }

		[DataMember(Name="lesserC1ORC2", EmitDefaultValue=false)]
		public double? LesserC1ORC2 { get; set; }

		[DataMember(Name="monthlyHousingPayment", EmitDefaultValue=false)]
		public double? MonthlyHousingPayment { get; set; }

		[DataMember(Name="monthlyMI", EmitDefaultValue=false)]
		public double? MonthlyMI { get; set; }

		[DataMember(Name="mortgageAmountUsedForQualifyingRate", EmitDefaultValue=false)]
		public double? MortgageAmountUsedForQualifyingRate { get; set; }

		[DataMember(Name="mortgageAmountUsedForQualifyingRateD1", EmitDefaultValue=false)]
		public double? MortgageAmountUsedForQualifyingRateD1 { get; set; }

		[DataMember(Name="newOrExisting", EmitDefaultValue=false)]
		public bool? NewOrExisting { get; set; }

		[DataMember(Name="originalSalesPriceIfLess12Months", EmitDefaultValue=false)]
		public double? OriginalSalesPriceIfLess12Months { get; set; }

		[DataMember(Name="otherHousingPayment", EmitDefaultValue=false)]
		public double? OtherHousingPayment { get; set; }

		[DataMember(Name="solarNotIncluded", EmitDefaultValue=false)]
		public double? SolarNotIncluded { get; set; }

		[DataMember(Name="solarSystemCostAllowance", EmitDefaultValue=false)]
		public double? SolarSystemCostAllowance { get; set; }

		[DataMember(Name="totalActualAmount", EmitDefaultValue=false)]
		public double? TotalActualAmount { get; set; }

		[DataMember(Name="totalAllowedAmount", EmitDefaultValue=false)]
		public double? TotalAllowedAmount { get; set; }

		[DataMember(Name="totalBaseEemLoanAmount", EmitDefaultValue=false)]
		public double? TotalBaseEemLoanAmount { get; set; }

		[DataMember(Name="totalCombinedLoanAmount", EmitDefaultValue=false)]
		public double? TotalCombinedLoanAmount { get; set; }

		[DataMember(Name="totalMonthlyHousingPayment", EmitDefaultValue=false)]
		public double? TotalMonthlyHousingPayment { get; set; }

		[DataMember(Name="totalMonthlyObligations", EmitDefaultValue=false)]
		public double? TotalMonthlyObligations { get; set; }

		[DataMember(Name="ufmipBasedOn", EmitDefaultValue=false)]
		public double? UfmipBasedOn { get; set; }

		[DataMember(Name="ufmipFactor", EmitDefaultValue=false)]
		public double? UfmipFactor { get; set; }

	}
}