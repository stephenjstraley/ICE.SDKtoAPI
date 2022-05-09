using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010PageGfe2010GfeCharges
	{
		[DataMember(Name="chargeBelow10Indicator", EmitDefaultValue=false)]
		public bool? ChargeBelow10Indicator { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="gfe2010GfeChargeIndex", EmitDefaultValue=false)]
		public int? Gfe2010GfeChargeIndex { get; set; }

		[DataMember(Name="gfeCharge", EmitDefaultValue=false)]
		public double? GfeCharge { get; set; }

		[DataMember(Name="hudCharge", EmitDefaultValue=false)]
		public double? HudCharge { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="line", EmitDefaultValue=false)]
		public string Line { get; set; }

	}
}