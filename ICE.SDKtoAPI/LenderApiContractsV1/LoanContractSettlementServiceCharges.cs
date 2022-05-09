using System.Runtime.Serialization;


namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractSettlementServiceCharges
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public string Amount { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}