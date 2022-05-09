using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockPurchaseAdvicePayouts
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="diffAmount", EmitDefaultValue=false)]
		public double? DiffAmount { get; set; }

		[DataMember(Name="expectedAmount", EmitDefaultValue=false)]
		public double? ExpectedAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}