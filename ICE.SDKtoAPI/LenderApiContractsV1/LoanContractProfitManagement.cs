using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractProfitManagement
	{
		[DataMember(Name="commissionableGrossProfit", EmitDefaultValue=false)]
		public double? CommissionableGrossProfit { get; set; }

		[DataMember(Name="expenseAmount1", EmitDefaultValue=false)]
		public double? ExpenseAmount1 { get; set; }

		[DataMember(Name="expenseAmount2", EmitDefaultValue=false)]
		public double? ExpenseAmount2 { get; set; }

		[DataMember(Name="expenseAmount3", EmitDefaultValue=false)]
		public double? ExpenseAmount3 { get; set; }

		[DataMember(Name="expenseAmount4", EmitDefaultValue=false)]
		public double? ExpenseAmount4 { get; set; }

		[DataMember(Name="expenseDescription1", EmitDefaultValue=false)]
		public string ExpenseDescription1 { get; set; }

		[DataMember(Name="expenseDescription2", EmitDefaultValue=false)]
		public string ExpenseDescription2 { get; set; }

		[DataMember(Name="expenseDescription3", EmitDefaultValue=false)]
		public string ExpenseDescription3 { get; set; }

		[DataMember(Name="expenseDescription4", EmitDefaultValue=false)]
		public string ExpenseDescription4 { get; set; }

		[DataMember(Name="grossCheckAmount", EmitDefaultValue=false)]
		public double? GrossCheckAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="netProfit", EmitDefaultValue=false)]
		public double? NetProfit { get; set; }

		[DataMember(Name="profitManagementItems", EmitDefaultValue=false)]
		public List<LoanContractProfitManagementProfitManagementItems> ProfitManagementItems { get; set; }

	}
}