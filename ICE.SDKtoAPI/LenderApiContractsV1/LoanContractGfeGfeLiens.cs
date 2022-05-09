using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfeLiens
	{
		[DataMember(Name="amountOwing", EmitDefaultValue=false)]
		public double? AmountOwing { get; set; }

		[DataMember(Name="gfeLienIndex", EmitDefaultValue=false)]
		public int? GfeLienIndex { get; set; }

		[DataMember(Name="gfeLienType", EmitDefaultValue=false)]
		public string GfeLienType { get; set; }

		[DataMember(Name="holderName", EmitDefaultValue=false)]
		public string HolderName { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="priority", EmitDefaultValue=false)]
		public string Priority { get; set; }

	}
}