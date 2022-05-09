using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTrustAccount
	{
		[DataMember(Name="balance", EmitDefaultValue=false)]
		public double? Balance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="total1", EmitDefaultValue=false)]
		public double? Total1 { get; set; }

		[DataMember(Name="total2", EmitDefaultValue=false)]
		public double? Total2 { get; set; }

		[DataMember(Name="trustAccountItems", EmitDefaultValue=false)]
		public List<LoanContractTrustAccountTrustAccountItems> TrustAccountItems { get; set; }

	}
}