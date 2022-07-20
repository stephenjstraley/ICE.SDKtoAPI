using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTrustAccount
	{
		[DataMember(Name="balance")]
		public decimal? Balance { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="total1")]
		public decimal? Total1 { get; set; }

		[DataMember(Name="total2")]
		public decimal? Total2 { get; set; }

		[DataMember(Name="trustAccountItems")]
		public List<LoanContractTrustAccountTrustAccountItems> TrustAccountItems { get; set; }

	}
}