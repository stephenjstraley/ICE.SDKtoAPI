using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLoanPurchaseCredit
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public decimal? Amount { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

	}
}