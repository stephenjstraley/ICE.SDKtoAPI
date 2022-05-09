using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsItemizes
	{
		[DataMember(Name="date", EmitDefaultValue=false)]
		public string Date { get; set; }

		[DataMember(Name="escrowPaymentBalance", EmitDefaultValue=false)]
		public double? EscrowPaymentBalance { get; set; }

		[DataMember(Name="escrowPaymentDescription", EmitDefaultValue=false)]
		public string EscrowPaymentDescription { get; set; }

		[DataMember(Name="escrowPaymentFrom", EmitDefaultValue=false)]
		public double? EscrowPaymentFrom { get; set; }

		[DataMember(Name="escrowPaymentTo", EmitDefaultValue=false)]
		public double? EscrowPaymentTo { get; set; }

		[DataMember(Name="hud1EsItemizeIndex", EmitDefaultValue=false)]
		public int? Hud1EsItemizeIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}