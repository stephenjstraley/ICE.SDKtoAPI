using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostGfe2010PageGfe2010GfeCharges
	{
		[DataMember(Name="chargeBelow10Indicator")]
		public bool? ChargeBelow10Indicator { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="gfe2010GfeChargeIndex")]
		public int? Gfe2010GfeChargeIndex { get; set; }

		[DataMember(Name="gfeCharge")]
		public decimal? GfeCharge { get; set; }

		[DataMember(Name="hudCharge")]
		public decimal? HudCharge { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="line")]
		public string Line { get; set; }

	}
}