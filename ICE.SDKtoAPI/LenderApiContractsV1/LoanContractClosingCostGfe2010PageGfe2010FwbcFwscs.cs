using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs
	{
		[DataMember(Name="fwbc")]
		public string Fwbc { get; set; }

		[DataMember(Name="fwsc")]
		public string Fwsc { get; set; }

		[DataMember(Name="gfe2010FwbcFwscIndex")]
		public int? Gfe2010FwbcFwscIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineLetter")]
		public string LineLetter { get; set; }

		[DataMember(Name="lineNumber")]
		public int? LineNumber { get; set; }

	}
}