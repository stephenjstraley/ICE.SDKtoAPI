using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPrequalification
	{
		[DataMember(Name="afterTaxOwnMoSavings")]
		public decimal? AfterTaxOwnMoSavings { get; set; }

		[DataMember(Name="afterTaxRentMoSavings")]
		public decimal? AfterTaxRentMoSavings { get; set; }

		[DataMember(Name="annualHomeMaintenance")]
		public decimal? AnnualHomeMaintenance { get; set; }

		[DataMember(Name="avgMoPmtSavings")]
		public decimal? AvgMoPmtSavings { get; set; }

		[DataMember(Name="beforeTaxOwnMoPmt")]
		public decimal? BeforeTaxOwnMoPmt { get; set; }

		[DataMember(Name="beforeTaxRentMoPmt")]
		public decimal? BeforeTaxRentMoPmt { get; set; }

		[DataMember(Name="cashOutBalance")]
		public int? CashOutBalance { get; set; }

		[DataMember(Name="combinedGain")]
		public decimal? CombinedGain { get; set; }

		[DataMember(Name="costIncreasePerYear")]
		public decimal? CostIncreasePerYear { get; set; }

		[DataMember(Name="downPaymentAmount")]
		public decimal? DownPaymentAmount { get; set; }

		[DataMember(Name="favorableOption")]
		public string FavorableOption { get; set; }

		[DataMember(Name="homeSellingPriceAfterYears")]
		public decimal? HomeSellingPriceAfterYears { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="investmentGain")]
		public decimal? InvestmentGain { get; set; }

		[DataMember(Name="maxLoanLimit")]
		public decimal? MaxLoanLimit { get; set; }

		[DataMember(Name="maxPropValue")]
		public decimal? MaxPropValue { get; set; }

		[DataMember(Name="minusDownPmtAndClosingCosts")]
		public decimal? MinusDownPmtAndClosingCosts { get; set; }

		[DataMember(Name="minusLoanBalance")]
		public decimal? MinusLoanBalance { get; set; }

		[DataMember(Name="monthlyBenefit")]
		public decimal? MonthlyBenefit { get; set; }

		[DataMember(Name="monthlyHomeAppreciation")]
		public decimal? MonthlyHomeAppreciation { get; set; }

		[DataMember(Name="monthlyHomeEquity")]
		public decimal? MonthlyHomeEquity { get; set; }

		[DataMember(Name="monthlyIncomeTax")]
		public decimal? MonthlyIncomeTax { get; set; }

		[DataMember(Name="monthlyInvestmentInterest")]
		public decimal? MonthlyInvestmentInterest { get; set; }

		[DataMember(Name="monthlySavings")]
		public int? MonthlySavings { get; set; }

		[DataMember(Name="numberOfMonths")]
		public string NumberOfMonths { get; set; }

		[DataMember(Name="percentAnnualHomeMaint")]
		public decimal? PercentAnnualHomeMaint { get; set; }

		[DataMember(Name="percentOfHomeAppreciation")]
		public decimal? PercentOfHomeAppreciation { get; set; }

		[DataMember(Name="percentOfIncomeTax")]
		public decimal? PercentOfIncomeTax { get; set; }

		[DataMember(Name="percentOfInvestmentInterest")]
		public decimal? PercentOfInvestmentInterest { get; set; }

		[DataMember(Name="prequalificationScenarios")]
		public List<LoanContractPrequalificationPrequalificationScenarios> PrequalificationScenarios { get; set; }

		[DataMember(Name="qualificationStatus")]
		public string QualificationStatus { get; set; }

		[DataMember(Name="rentalCost")]
		public decimal? RentalCost { get; set; }

		[DataMember(Name="rentersInsurance")]
		public decimal? RentersInsurance { get; set; }

		[DataMember(Name="totalBenefit")]
		public decimal? TotalBenefit { get; set; }

		[DataMember(Name="totalCashFlow")]
		public decimal? TotalCashFlow { get; set; }

		[DataMember(Name="totalGain")]
		public decimal? TotalGain { get; set; }

		[DataMember(Name="totalHomeAppreciation")]
		public decimal? TotalHomeAppreciation { get; set; }

		[DataMember(Name="totalHomeEquity")]
		public decimal? TotalHomeEquity { get; set; }

		[DataMember(Name="totalHousingExpense")]
		public decimal? TotalHousingExpense { get; set; }

		[DataMember(Name="totalIncomeTax")]
		public decimal? TotalIncomeTax { get; set; }

		[DataMember(Name="totalInvestmentInterest")]
		public decimal? TotalInvestmentInterest { get; set; }

		[DataMember(Name="totalLiabilityPayment")]
		public int? TotalLiabilityPayment { get; set; }

		[DataMember(Name="totalLiabilityUnpaid")]
		public int? TotalLiabilityUnpaid { get; set; }

		[DataMember(Name="totalLoanSavings")]
		public int? TotalLoanSavings { get; set; }

		[DataMember(Name="totalOtherExpenses")]
		public decimal? TotalOtherExpenses { get; set; }

		[DataMember(Name="totalOwnPmtOverYears")]
		public decimal? TotalOwnPmtOverYears { get; set; }

		[DataMember(Name="totalOwnTaxSavings")]
		public decimal? TotalOwnTaxSavings { get; set; }

		[DataMember(Name="totalPaidOffBalance")]
		public int? TotalPaidOffBalance { get; set; }

		[DataMember(Name="totalPaidOffMonthly")]
		public int? TotalPaidOffMonthly { get; set; }

		[DataMember(Name="totalPmtSavings")]
		public decimal? TotalPmtSavings { get; set; }

		[DataMember(Name="totalRentPmtOverYears")]
		public decimal? TotalRentPmtOverYears { get; set; }

		[DataMember(Name="withinLimits1")]
		public string WithinLimits1 { get; set; }

		[DataMember(Name="withinLimits2")]
		public string WithinLimits2 { get; set; }

		[DataMember(Name="withinLimits3")]
		public string WithinLimits3 { get; set; }

		[DataMember(Name="withinLimits4")]
		public string WithinLimits4 { get; set; }

		[DataMember(Name="withinLimits5")]
		public string WithinLimits5 { get; set; }

		[DataMember(Name="withinLimits6")]
		public string WithinLimits6 { get; set; }

		[DataMember(Name="withinLimits7")]
		public string WithinLimits7 { get; set; }

		[DataMember(Name="withinLimits8")]
		public string WithinLimits8 { get; set; }

		[DataMember(Name="withinLimits9")]
		public string WithinLimits9 { get; set; }

		[DataMember(Name="yearsForComparison")]
		public int? YearsForComparison { get; set; }

	}
}