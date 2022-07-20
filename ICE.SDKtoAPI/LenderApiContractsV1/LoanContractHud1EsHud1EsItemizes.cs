using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsItemizes
	{
		[DataMember(Name="date")]
		public string Date { get; set; }

		[DataMember(Name="escrowPaymentBalance")]
		public decimal? EscrowPaymentBalance { get; set; }

		[DataMember(Name="escrowPaymentDescription")]
		public string EscrowPaymentDescription { get; set; }

		[DataMember(Name="escrowPaymentFrom")]
		public decimal? EscrowPaymentFrom { get; set; }

		[DataMember(Name="escrowPaymentTo")]
		public decimal? EscrowPaymentTo { get; set; }

		[DataMember(Name="hud1EsItemizeIndex")]
		public int? Hud1EsItemizeIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}