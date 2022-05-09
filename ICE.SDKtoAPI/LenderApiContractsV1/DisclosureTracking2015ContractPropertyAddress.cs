using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractPropertyAddress
	{
		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="street1", EmitDefaultValue=false)]
		public string Street1 { get; set; }

		[DataMember(Name="street2", EmitDefaultValue=false)]
		public string Street2 { get; set; }

		[DataMember(Name="zip", EmitDefaultValue=false)]
		public string Zip { get; set; }

	}
}