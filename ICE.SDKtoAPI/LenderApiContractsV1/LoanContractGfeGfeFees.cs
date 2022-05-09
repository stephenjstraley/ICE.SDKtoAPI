using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfeFees
	{
		[DataMember(Name="amountDescription", EmitDefaultValue=false)]
		public string AmountDescription { get; set; }

		[DataMember(Name="brokerAmount", EmitDefaultValue=false)]
		public double? BrokerAmount { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="gfeFeeIndex", EmitDefaultValue=false)]
		public int? GfeFeeIndex { get; set; }

		[DataMember(Name="gfeFeeType", EmitDefaultValue=false)]
		public string GfeFeeType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="otherAmount", EmitDefaultValue=false)]
		public double? OtherAmount { get; set; }

		[DataMember(Name="rate", EmitDefaultValue=false)]
		public string Rate { get; set; }

	}
}