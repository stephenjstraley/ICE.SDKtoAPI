using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFhaVaLoanEnergyEfficientMortgageItems
	{
		[DataMember(Name="actualAmount")]
		public decimal? ActualAmount { get; set; }

		[DataMember(Name="allowedAmount")]
		public decimal? AllowedAmount { get; set; }

		[DataMember(Name="energyEfficientMortgageItemIndex")]
		public int? EnergyEfficientMortgageItemIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="item")]
		public string Item { get; set; }

		[DataMember(Name="lineNumber")]
		public int? LineNumber { get; set; }

	}
}