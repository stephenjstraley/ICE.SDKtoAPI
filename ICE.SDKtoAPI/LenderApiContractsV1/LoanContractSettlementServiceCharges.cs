using System.Runtime.Serialization;


namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSettlementServiceCharges
	{
		[DataMember(Name="amount")]
		public string Amount { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}