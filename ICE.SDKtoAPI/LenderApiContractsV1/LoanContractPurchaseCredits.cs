using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPurchaseCredits
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="purchaseCreditType")]
		public string PurchaseCreditType { get; set; }

		[DataMember(Name = "purchaseCreditSource")]
		public string PurchaseCreditSource { get; set; }
	}
}