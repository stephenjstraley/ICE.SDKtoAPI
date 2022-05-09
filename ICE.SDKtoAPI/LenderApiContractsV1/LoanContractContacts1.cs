using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractContacts1
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="contactId", EmitDefaultValue=false)]
		public string ContactId { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="role", EmitDefaultValue=false)]
		public string Role { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="zip", EmitDefaultValue=false)]
		public string Zip { get; set; }

	}
}