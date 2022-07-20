using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfePayoffs
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="gfePayoffIndex")]
		public int? GfePayoffIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}