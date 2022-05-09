using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractShippingShippingContacts
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="address2", EmitDefaultValue=false)]
		public string Address2 { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="shippingContactType", EmitDefaultValue=false)]
		public string ShippingContactType { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

	}
}