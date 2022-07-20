using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractContacts1
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="contactId")]
		public string ContactId { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="role")]
		public string Role { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="zip")]
		public string Zip { get; set; }

	}
}