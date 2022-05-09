using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPrequalificationPrequalificationScenarios
	{
		[DataMember(Name="appraisedValue", EmitDefaultValue=false)]
		public int? AppraisedValue { get; set; }

		[DataMember(Name="apr", EmitDefaultValue=false)]
		public double? Apr { get; set; }

		[DataMember(Name="cashToClose", EmitDefaultValue=false)]
		public double? CashToClose { get; set; }

		[DataMember(Name="closingCost", EmitDefaultValue=false)]
		public double? ClosingCost { get; set; }

		[DataMember(Name="cltv", EmitDefaultValue=false)]
		public double? Cltv { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="creditScore", EmitDefaultValue=false)]
		public string CreditScore { get; set; }

		[DataMember(Name="currentStatus", EmitDefaultValue=false)]
		public string CurrentStatus { get; set; }

		[DataMember(Name="downPaymentAmount", EmitDefaultValue=false)]
		public double? DownPaymentAmount { get; set; }

		[DataMember(Name="downPaymentPercent", EmitDefaultValue=false)]
		public double? DownPaymentPercent { get; set; }

		[DataMember(Name="fhaUpfrontMIPremiumPercent", EmitDefaultValue=false)]
		public double? FhaUpfrontMIPremiumPercent { get; set; }

		[DataMember(Name="grossNegativeCashFlow", EmitDefaultValue=false)]
		public double? GrossNegativeCashFlow { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public double? LoanAmount { get; set; }

		[DataMember(Name="ltv", EmitDefaultValue=false)]
		public double? Ltv { get; set; }

		[DataMember(Name="maximumDebt", EmitDefaultValue=false)]
		public double? MaximumDebt { get; set; }

		[DataMember(Name="maximumLoanAmount", EmitDefaultValue=false)]
		public double? MaximumLoanAmount { get; set; }

		[DataMember(Name="miAndFundingFeeFinancedAmount", EmitDefaultValue=false)]
		public double? MiAndFundingFeeFinancedAmount { get; set; }

		[DataMember(Name="minimumIncome", EmitDefaultValue=false)]
		public double? MinimumIncome { get; set; }

		[DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
		public double? MonthlyPayment { get; set; }

		[DataMember(Name="prepaidItemsEstimatedAmount", EmitDefaultValue=false)]
		public double? PrepaidItemsEstimatedAmount { get; set; }

		[DataMember(Name="prequalificationScenarioIndex", EmitDefaultValue=false)]
		public int? PrequalificationScenarioIndex { get; set; }

		[DataMember(Name="qualBottomRatioPercent", EmitDefaultValue=false)]
		public double? QualBottomRatioPercent { get; set; }

		[DataMember(Name="qualTopRatioPercent", EmitDefaultValue=false)]
		public double? QualTopRatioPercent { get; set; }

		[DataMember(Name="salesPrice", EmitDefaultValue=false)]
		public double? SalesPrice { get; set; }

		[DataMember(Name="subordinateFin", EmitDefaultValue=false)]
		public double? SubordinateFin { get; set; }

		[DataMember(Name="totalBaseCost", EmitDefaultValue=false)]
		public double? TotalBaseCost { get; set; }

		[DataMember(Name="totalCashAvailable", EmitDefaultValue=false)]
		public double? TotalCashAvailable { get; set; }

		[DataMember(Name="totalCashLeft", EmitDefaultValue=false)]
		public double? TotalCashLeft { get; set; }

		[DataMember(Name="totalCosts", EmitDefaultValue=false)]
		public double? TotalCosts { get; set; }

		[DataMember(Name="totalFinancing", EmitDefaultValue=false)]
		public double? TotalFinancing { get; set; }

		[DataMember(Name="totalHe", EmitDefaultValue=false)]
		public double? TotalHe { get; set; }

		[DataMember(Name="totalIncome", EmitDefaultValue=false)]
		public double? TotalIncome { get; set; }

		[DataMember(Name="totalLoanAmount", EmitDefaultValue=false)]
		public double? TotalLoanAmount { get; set; }

		[DataMember(Name="totalOtherExpense", EmitDefaultValue=false)]
		public double? TotalOtherExpense { get; set; }

		[DataMember(Name="totalPaidOffMortgage", EmitDefaultValue=false)]
		public double? TotalPaidOffMortgage { get; set; }

		[DataMember(Name="totalPaidOffOthers", EmitDefaultValue=false)]
		public double? TotalPaidOffOthers { get; set; }

		[DataMember(Name="totalPayments", EmitDefaultValue=false)]
		public double? TotalPayments { get; set; }

	}
}