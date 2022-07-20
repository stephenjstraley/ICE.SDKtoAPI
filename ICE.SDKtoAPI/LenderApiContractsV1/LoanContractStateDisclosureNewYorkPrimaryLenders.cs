using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStateDisclosureNewYorkPrimaryLenders
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="newYorkPrimaryLenderIndex")]
		public int? NewYorkPrimaryLenderIndex { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

	}
}