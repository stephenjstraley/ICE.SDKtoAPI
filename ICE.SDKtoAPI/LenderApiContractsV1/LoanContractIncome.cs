using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractIncome
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="currentIndicator")]
		public bool? CurrentIndicator { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="incomeType")]
		public string IncomeType { get; set; }

		[DataMember(Name="otherIncomeIndex")]
		public int? OtherIncomeIndex { get; set; }

		[DataMember(Name="owner")]
		public string Owner { get; set; }

	}
}