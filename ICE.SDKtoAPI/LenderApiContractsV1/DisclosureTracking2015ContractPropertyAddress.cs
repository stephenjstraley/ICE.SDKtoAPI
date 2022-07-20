using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractPropertyAddress
	{
		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="street1")]
		public string Street1 { get; set; }

		[DataMember(Name="street2")]
		public string Street2 { get; set; }

		[DataMember(Name="zip")]
		public string Zip { get; set; }

	}
}