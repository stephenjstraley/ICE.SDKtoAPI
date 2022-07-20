using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure3UCDDetails
	{
		[DataMember(Name="feeAccountType")]
		public string FeeAccountType { get; set; }

		[DataMember(Name="feeAmount")]
		public decimal? FeeAmount { get; set; }

		[DataMember(Name="feeDateFrom")]
		public DateTime? FeeDateFrom { get; set; }

		[DataMember(Name="feeDateTo")]
		public DateTime? FeeDateTo { get; set; }

		[DataMember(Name="feeDesc")]
		public string FeeDesc { get; set; }

		[DataMember(Name="feeIndex")]
		public int? FeeIndex { get; set; }

		[DataMember(Name="feePaidBy")]
		public string FeePaidBy { get; set; }

		[DataMember(Name="feePaidTo")]
		public string FeePaidTo { get; set; }

		[DataMember(Name="feePOC")]
		public bool? FeePOC { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineNumber")]
		public int? LineNumber { get; set; }

		[DataMember(Name="section")]
		public string Section { get; set; }

	}
}