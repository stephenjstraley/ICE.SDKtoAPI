using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractProfitManagement
	{
		[DataMember(Name="commissionableGrossProfit")]
		public decimal? CommissionableGrossProfit { get; set; }

		[DataMember(Name="expenseAmount1")]
		public decimal? ExpenseAmount1 { get; set; }

		[DataMember(Name="expenseAmount2")]
		public decimal? ExpenseAmount2 { get; set; }

		[DataMember(Name="expenseAmount3")]
		public decimal? ExpenseAmount3 { get; set; }

		[DataMember(Name="expenseAmount4")]
		public decimal? ExpenseAmount4 { get; set; }

		[DataMember(Name="expenseDescription1")]
		public string ExpenseDescription1 { get; set; }

		[DataMember(Name="expenseDescription2")]
		public string ExpenseDescription2 { get; set; }

		[DataMember(Name="expenseDescription3")]
		public string ExpenseDescription3 { get; set; }

		[DataMember(Name="expenseDescription4")]
		public string ExpenseDescription4 { get; set; }

		[DataMember(Name="grossCheckAmount")]
		public decimal? GrossCheckAmount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="netProfit")]
		public decimal? NetProfit { get; set; }

		[DataMember(Name="profitManagementItems")]
		public List<LoanContractProfitManagementProfitManagementItems> ProfitManagementItems { get; set; }

	}
}