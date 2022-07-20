using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsSetups
	{
		[DataMember(Name="annualFeePrepaid")]
		public bool? AnnualFeePrepaid { get; set; }

		[DataMember(Name="annualFees")]
		public int? AnnualFees { get; set; }

		[DataMember(Name="date")]
		public string Date { get; set; }

		[DataMember(Name="floodInsDisb")]
		public int? FloodInsDisb { get; set; }

		[DataMember(Name="floodInsPrepaid")]
		public bool? FloodInsPrepaid { get; set; }

		[DataMember(Name="hazInsDisb")]
		public int? HazInsDisb { get; set; }

		[DataMember(Name="hazInsPrepaid")]
		public bool? HazInsPrepaid { get; set; }

		[DataMember(Name="hud1EsSetupIndex")]
		public int? Hud1EsSetupIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb")]
		public int? MtgInsDisb { get; set; }

		[DataMember(Name="mtgInsPrepaid")]
		public bool? MtgInsPrepaid { get; set; }

		[DataMember(Name="schoolTaxes")]
		public int? SchoolTaxes { get; set; }

		[DataMember(Name="schoolTaxesPrepaid")]
		public bool? SchoolTaxesPrepaid { get; set; }

		[DataMember(Name="taxDisb")]
		public int? TaxDisb { get; set; }

		[DataMember(Name="taxPrepaid")]
		public bool? TaxPrepaid { get; set; }

		[DataMember(Name="userDefined1")]
		public int? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2")]
		public int? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3")]
		public int? UserDefined3 { get; set; }

		[DataMember(Name="userDefinedPrepaid1")]
		public bool? UserDefinedPrepaid1 { get; set; }

		[DataMember(Name="userDefinedPrepaid2")]
		public bool? UserDefinedPrepaid2 { get; set; }

		[DataMember(Name="userDefinedPrepaid3")]
		public bool? UserDefinedPrepaid3 { get; set; }

	}
}