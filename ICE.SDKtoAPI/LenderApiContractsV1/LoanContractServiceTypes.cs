using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractServiceTypes
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

	}
}