using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010Gfe2010WholePocs
	{
		[DataMember(Name="gfe2010WholePocIndex", EmitDefaultValue=false)]
		public int? Gfe2010WholePocIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

		[DataMember(Name="wholePoc", EmitDefaultValue=false)]
		public double? WholePoc { get; set; }

		[DataMember(Name="wholePocPaidByType", EmitDefaultValue=false)]
		public string WholePocPaidByType { get; set; }

	}
}