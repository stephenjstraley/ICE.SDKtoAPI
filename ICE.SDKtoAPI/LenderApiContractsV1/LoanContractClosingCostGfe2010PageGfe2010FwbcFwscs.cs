using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010PageGfe2010FwbcFwscs
	{
		[DataMember(Name="fwbc", EmitDefaultValue=false)]
		public string Fwbc { get; set; }

		[DataMember(Name="fwsc", EmitDefaultValue=false)]
		public string Fwsc { get; set; }

		[DataMember(Name="gfe2010FwbcFwscIndex", EmitDefaultValue=false)]
		public int? Gfe2010FwbcFwscIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineLetter", EmitDefaultValue=false)]
		public string LineLetter { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

	}
}