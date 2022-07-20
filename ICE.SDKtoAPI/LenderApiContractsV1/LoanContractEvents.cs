using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEvents
	{
		[DataMember(Name="dateText")]
		public string DateText { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}