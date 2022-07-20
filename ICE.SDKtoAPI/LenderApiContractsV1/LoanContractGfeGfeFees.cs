using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfeFees
	{
		[DataMember(Name="amountDescription")]
		public string AmountDescription { get; set; }

		[DataMember(Name="brokerAmount")]
		public decimal? BrokerAmount { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="gfeFeeIndex")]
		public int? GfeFeeIndex { get; set; }

		[DataMember(Name="gfeFeeType")]
		public string GfeFeeType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="otherAmount")]
		public decimal? OtherAmount { get; set; }

		[DataMember(Name="rate")]
		public string Rate { get; set; }

	}
}