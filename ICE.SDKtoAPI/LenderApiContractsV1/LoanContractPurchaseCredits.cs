using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractPurchaseCredits
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="purchaseCreditType", EmitDefaultValue=false)]
		public string PurchaseCreditType { get; set; }

	}
}