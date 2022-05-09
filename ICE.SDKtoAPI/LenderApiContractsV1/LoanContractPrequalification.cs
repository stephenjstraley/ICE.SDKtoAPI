using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPrequalification
	{
		[DataMember(Name="afterTaxOwnMoSavings", EmitDefaultValue=false)]
		public double? AfterTaxOwnMoSavings { get; set; }

		[DataMember(Name="afterTaxRentMoSavings", EmitDefaultValue=false)]
		public double? AfterTaxRentMoSavings { get; set; }

		[DataMember(Name="annualHomeMaintenance", EmitDefaultValue=false)]
		public double? AnnualHomeMaintenance { get; set; }

		[DataMember(Name="avgMoPmtSavings", EmitDefaultValue=false)]
		public double? AvgMoPmtSavings { get; set; }

		[DataMember(Name="beforeTaxOwnMoPmt", EmitDefaultValue=false)]
		public double? BeforeTaxOwnMoPmt { get; set; }

		[DataMember(Name="beforeTaxRentMoPmt", EmitDefaultValue=false)]
		public double? BeforeTaxRentMoPmt { get; set; }

		[DataMember(Name="cashOutBalance", EmitDefaultValue=false)]
		public int? CashOutBalance { get; set; }

		[DataMember(Name="combinedGain", EmitDefaultValue=false)]
		public double? CombinedGain { get; set; }

		[DataMember(Name="costIncreasePerYear", EmitDefaultValue=false)]
		public double? CostIncreasePerYear { get; set; }

		[DataMember(Name="downPaymentAmount", EmitDefaultValue=false)]
		public double? DownPaymentAmount { get; set; }

		[DataMember(Name="favorableOption", EmitDefaultValue=false)]
		public string FavorableOption { get; set; }

		[DataMember(Name="homeSellingPriceAfterYears", EmitDefaultValue=false)]
		public double? HomeSellingPriceAfterYears { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="investmentGain", EmitDefaultValue=false)]
		public double? InvestmentGain { get; set; }

		[DataMember(Name="maxLoanLimit", EmitDefaultValue=false)]
		public double? MaxLoanLimit { get; set; }

		[DataMember(Name="maxPropValue", EmitDefaultValue=false)]
		public double? MaxPropValue { get; set; }

		[DataMember(Name="minusDownPmtAndClosingCosts", EmitDefaultValue=false)]
		public double? MinusDownPmtAndClosingCosts { get; set; }

		[DataMember(Name="minusLoanBalance", EmitDefaultValue=false)]
		public double? MinusLoanBalance { get; set; }

		[DataMember(Name="monthlyBenefit", EmitDefaultValue=false)]
		public double? MonthlyBenefit { get; set; }

		[DataMember(Name="monthlyHomeAppreciation", EmitDefaultValue=false)]
		public double? MonthlyHomeAppreciation { get; set; }

		[DataMember(Name="monthlyHomeEquity", EmitDefaultValue=false)]
		public double? MonthlyHomeEquity { get; set; }

		[DataMember(Name="monthlyIncomeTax", EmitDefaultValue=false)]
		public double? MonthlyIncomeTax { get; set; }

		[DataMember(Name="monthlyInvestmentInterest", EmitDefaultValue=false)]
		public double? MonthlyInvestmentInterest { get; set; }

		[DataMember(Name="monthlySavings", EmitDefaultValue=false)]
		public int? MonthlySavings { get; set; }

		[DataMember(Name="numberOfMonths", EmitDefaultValue=false)]
		public string NumberOfMonths { get; set; }

		[DataMember(Name="percentAnnualHomeMaint", EmitDefaultValue=false)]
		public double? PercentAnnualHomeMaint { get; set; }

		[DataMember(Name="percentOfHomeAppreciation", EmitDefaultValue=false)]
		public double? PercentOfHomeAppreciation { get; set; }

		[DataMember(Name="percentOfIncomeTax", EmitDefaultValue=false)]
		public double? PercentOfIncomeTax { get; set; }

		[DataMember(Name="percentOfInvestmentInterest", EmitDefaultValue=false)]
		public double? PercentOfInvestmentInterest { get; set; }

		[DataMember(Name="prequalificationScenarios", EmitDefaultValue=false)]
		public List<LoanContractPrequalificationPrequalificationScenarios> PrequalificationScenarios { get; set; }

		[DataMember(Name="qualificationStatus", EmitDefaultValue=false)]
		public string QualificationStatus { get; set; }

		[DataMember(Name="rentalCost", EmitDefaultValue=false)]
		public double? RentalCost { get; set; }

		[DataMember(Name="rentersInsurance", EmitDefaultValue=false)]
		public double? RentersInsurance { get; set; }

		[DataMember(Name="totalBenefit", EmitDefaultValue=false)]
		public double? TotalBenefit { get; set; }

		[DataMember(Name="totalCashFlow", EmitDefaultValue=false)]
		public double? TotalCashFlow { get; set; }

		[DataMember(Name="totalGain", EmitDefaultValue=false)]
		public double? TotalGain { get; set; }

		[DataMember(Name="totalHomeAppreciation", EmitDefaultValue=false)]
		public double? TotalHomeAppreciation { get; set; }

		[DataMember(Name="totalHomeEquity", EmitDefaultValue=false)]
		public double? TotalHomeEquity { get; set; }

		[DataMember(Name="totalHousingExpense", EmitDefaultValue=false)]
		public double? TotalHousingExpense { get; set; }

		[DataMember(Name="totalIncomeTax", EmitDefaultValue=false)]
		public double? TotalIncomeTax { get; set; }

		[DataMember(Name="totalInvestmentInterest", EmitDefaultValue=false)]
		public double? TotalInvestmentInterest { get; set; }

		[DataMember(Name="totalLiabilityPayment", EmitDefaultValue=false)]
		public int? TotalLiabilityPayment { get; set; }

		[DataMember(Name="totalLiabilityUnpaid", EmitDefaultValue=false)]
		public int? TotalLiabilityUnpaid { get; set; }

		[DataMember(Name="totalLoanSavings", EmitDefaultValue=false)]
		public int? TotalLoanSavings { get; set; }

		[DataMember(Name="totalOtherExpenses", EmitDefaultValue=false)]
		public double? TotalOtherExpenses { get; set; }

		[DataMember(Name="totalOwnPmtOverYears", EmitDefaultValue=false)]
		public double? TotalOwnPmtOverYears { get; set; }

		[DataMember(Name="totalOwnTaxSavings", EmitDefaultValue=false)]
		public double? TotalOwnTaxSavings { get; set; }

		[DataMember(Name="totalPaidOffBalance", EmitDefaultValue=false)]
		public int? TotalPaidOffBalance { get; set; }

		[DataMember(Name="totalPaidOffMonthly", EmitDefaultValue=false)]
		public int? TotalPaidOffMonthly { get; set; }

		[DataMember(Name="totalPmtSavings", EmitDefaultValue=false)]
		public double? TotalPmtSavings { get; set; }

		[DataMember(Name="totalRentPmtOverYears", EmitDefaultValue=false)]
		public double? TotalRentPmtOverYears { get; set; }

		[DataMember(Name="withinLimits1", EmitDefaultValue=false)]
		public string WithinLimits1 { get; set; }

		[DataMember(Name="withinLimits2", EmitDefaultValue=false)]
		public string WithinLimits2 { get; set; }

		[DataMember(Name="withinLimits3", EmitDefaultValue=false)]
		public string WithinLimits3 { get; set; }

		[DataMember(Name="withinLimits4", EmitDefaultValue=false)]
		public string WithinLimits4 { get; set; }

		[DataMember(Name="withinLimits5", EmitDefaultValue=false)]
		public string WithinLimits5 { get; set; }

		[DataMember(Name="withinLimits6", EmitDefaultValue=false)]
		public string WithinLimits6 { get; set; }

		[DataMember(Name="withinLimits7", EmitDefaultValue=false)]
		public string WithinLimits7 { get; set; }

		[DataMember(Name="withinLimits8", EmitDefaultValue=false)]
		public string WithinLimits8 { get; set; }

		[DataMember(Name="withinLimits9", EmitDefaultValue=false)]
		public string WithinLimits9 { get; set; }

		[DataMember(Name="yearsForComparison", EmitDefaultValue=false)]
		public int? YearsForComparison { get; set; }

	}
}