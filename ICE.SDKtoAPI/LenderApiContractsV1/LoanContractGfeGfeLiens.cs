using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfeGfeLiens
	{
		[DataMember(Name="amountOwing")]
		public decimal? AmountOwing { get; set; }

		[DataMember(Name="gfeLienIndex")]
		public int? GfeLienIndex { get; set; }

		[DataMember(Name="gfeLienType")]
		public string GfeLienType { get; set; }

		[DataMember(Name="holderName")]
		public string HolderName { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="priority")]
		public string Priority { get; set; }

	}
}