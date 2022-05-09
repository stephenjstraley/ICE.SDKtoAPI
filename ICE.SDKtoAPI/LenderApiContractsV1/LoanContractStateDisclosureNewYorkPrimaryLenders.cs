using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStateDisclosureNewYorkPrimaryLenders
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="newYorkPrimaryLenderIndex", EmitDefaultValue=false)]
		public int? NewYorkPrimaryLenderIndex { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

	}
}