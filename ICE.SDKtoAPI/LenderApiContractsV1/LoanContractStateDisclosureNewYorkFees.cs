using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStateDisclosureNewYorkFees
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="feeType")]
		public string FeeType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="newYorkFeeIndex")]
		public int? NewYorkFeeIndex { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

	}
}