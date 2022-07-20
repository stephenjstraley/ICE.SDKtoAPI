using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPrequalificationPrequalificationScenarios
	{
		[DataMember(Name="appraisedValue")]
		public int? AppraisedValue { get; set; }

		[DataMember(Name="apr")]
		public decimal? Apr { get; set; }

		[DataMember(Name="cashToClose")]
		public decimal? CashToClose { get; set; }

		[DataMember(Name="closingCost")]
		public decimal? ClosingCost { get; set; }

		[DataMember(Name="cltv")]
		public decimal? Cltv { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="creditScore")]
		public string CreditScore { get; set; }

		[DataMember(Name="currentStatus")]
		public string CurrentStatus { get; set; }

		[DataMember(Name="downPaymentAmount")]
		public decimal? DownPaymentAmount { get; set; }

		[DataMember(Name="downPaymentPercent")]
		public decimal? DownPaymentPercent { get; set; }

		[DataMember(Name="fhaUpfrontMIPremiumPercent")]
		public decimal? FhaUpfrontMIPremiumPercent { get; set; }

		[DataMember(Name="grossNegativeCashFlow")]
		public decimal? GrossNegativeCashFlow { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanAmount")]
		public decimal? LoanAmount { get; set; }

		[DataMember(Name="ltv")]
		public decimal? Ltv { get; set; }

		[DataMember(Name="maximumDebt")]
		public decimal? MaximumDebt { get; set; }

		[DataMember(Name="maximumLoanAmount")]
		public decimal? MaximumLoanAmount { get; set; }

		[DataMember(Name="miAndFundingFeeFinancedAmount")]
		public decimal? MiAndFundingFeeFinancedAmount { get; set; }

		[DataMember(Name="minimumIncome")]
		public decimal? MinimumIncome { get; set; }

		[DataMember(Name="monthlyPayment")]
		public decimal? MonthlyPayment { get; set; }

		[DataMember(Name="prepaidItemsEstimatedAmount")]
		public decimal? PrepaidItemsEstimatedAmount { get; set; }

		[DataMember(Name="prequalificationScenarioIndex")]
		public int? PrequalificationScenarioIndex { get; set; }

		[DataMember(Name="qualBottomRatioPercent")]
		public decimal? QualBottomRatioPercent { get; set; }

		[DataMember(Name="qualTopRatioPercent")]
		public decimal? QualTopRatioPercent { get; set; }

		[DataMember(Name="salesPrice")]
		public decimal? SalesPrice { get; set; }

		[DataMember(Name="subordinateFin")]
		public decimal? SubordinateFin { get; set; }

		[DataMember(Name="totalBaseCost")]
		public decimal? TotalBaseCost { get; set; }

		[DataMember(Name="totalCashAvailable")]
		public decimal? TotalCashAvailable { get; set; }

		[DataMember(Name="totalCashLeft")]
		public decimal? TotalCashLeft { get; set; }

		[DataMember(Name="totalCosts")]
		public decimal? TotalCosts { get; set; }

		[DataMember(Name="totalFinancing")]
		public decimal? TotalFinancing { get; set; }

		[DataMember(Name="totalHe")]
		public decimal? TotalHe { get; set; }

		[DataMember(Name="totalIncome")]
		public decimal? TotalIncome { get; set; }

		[DataMember(Name="totalLoanAmount")]
		public decimal? TotalLoanAmount { get; set; }

		[DataMember(Name="totalOtherExpense")]
		public decimal? TotalOtherExpense { get; set; }

		[DataMember(Name="totalPaidOffMortgage")]
		public decimal? TotalPaidOffMortgage { get; set; }

		[DataMember(Name="totalPaidOffOthers")]
		public decimal? TotalPaidOffOthers { get; set; }

		[DataMember(Name="totalPayments")]
		public decimal? TotalPayments { get; set; }

	}
}