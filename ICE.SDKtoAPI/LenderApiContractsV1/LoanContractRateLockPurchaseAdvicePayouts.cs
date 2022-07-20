using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockPurchaseAdvicePayouts
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="diffAmount")]
		public decimal? DiffAmount { get; set; }

		[DataMember(Name="expectedAmount")]
		public decimal? ExpectedAmount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}