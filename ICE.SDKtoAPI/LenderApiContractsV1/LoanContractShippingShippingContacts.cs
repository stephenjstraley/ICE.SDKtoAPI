using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractShippingShippingContacts
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="address2")]
		public string Address2 { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="contactName")]
		public string ContactName { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="fax")]
		public string Fax { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="shippingContactType")]
		public string ShippingContactType { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

	}
}