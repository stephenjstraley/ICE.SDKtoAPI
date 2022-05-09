using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractIncome
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="currentIndicator", EmitDefaultValue=false)]
		public bool? CurrentIndicator { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="incomeType", EmitDefaultValue=false)]
		public string IncomeType { get; set; }

		[DataMember(Name="otherIncomeIndex", EmitDefaultValue=false)]
		public int? OtherIncomeIndex { get; set; }

		[DataMember(Name="owner", EmitDefaultValue=false)]
		public string Owner { get; set; }

	}
}