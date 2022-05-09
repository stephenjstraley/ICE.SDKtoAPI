using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFhaVaLoanEnergyEfficientMortgageItems
	{
		[DataMember(Name="actualAmount", EmitDefaultValue=false)]
		public double? ActualAmount { get; set; }

		[DataMember(Name="allowedAmount", EmitDefaultValue=false)]
		public double? AllowedAmount { get; set; }

		[DataMember(Name="energyEfficientMortgageItemIndex", EmitDefaultValue=false)]
		public int? EnergyEfficientMortgageItemIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="item", EmitDefaultValue=false)]
		public string Item { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

	}
}