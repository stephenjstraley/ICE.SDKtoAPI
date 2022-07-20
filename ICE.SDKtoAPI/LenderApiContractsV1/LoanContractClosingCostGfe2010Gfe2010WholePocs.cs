using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010Gfe2010WholePocs
	{
		[DataMember(Name="gfe2010WholePocIndex")]
		public int? Gfe2010WholePocIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineNumber")]
		public int? LineNumber { get; set; }

		[DataMember(Name="wholePoc")]
		public decimal? WholePoc { get; set; }

		[DataMember(Name="wholePocPaidByType")]
		public string WholePocPaidByType { get; set; }

	}
}