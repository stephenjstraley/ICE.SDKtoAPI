using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStateDisclosureNewYorkFees
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="feeType", EmitDefaultValue=false)]
		public string FeeType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="newYorkFeeIndex", EmitDefaultValue=false)]
		public int? NewYorkFeeIndex { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

	}
}