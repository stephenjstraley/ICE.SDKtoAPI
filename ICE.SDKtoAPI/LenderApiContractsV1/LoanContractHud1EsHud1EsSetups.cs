using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsSetups
	{
		[DataMember(Name="annualFeePrepaid", EmitDefaultValue=false)]
		public bool? AnnualFeePrepaid { get; set; }

		[DataMember(Name="annualFees", EmitDefaultValue=false)]
		public int? AnnualFees { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public string Date { get; set; }

		[DataMember(Name="floodInsDisb", EmitDefaultValue=false)]
		public int? FloodInsDisb { get; set; }

		[DataMember(Name="floodInsPrepaid", EmitDefaultValue=false)]
		public bool? FloodInsPrepaid { get; set; }

		[DataMember(Name="hazInsDisb", EmitDefaultValue=false)]
		public int? HazInsDisb { get; set; }

		[DataMember(Name="hazInsPrepaid", EmitDefaultValue=false)]
		public bool? HazInsPrepaid { get; set; }

		[DataMember(Name="hud1EsSetupIndex", EmitDefaultValue=false)]
		public int? Hud1EsSetupIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb", EmitDefaultValue=false)]
		public int? MtgInsDisb { get; set; }

		[DataMember(Name="mtgInsPrepaid", EmitDefaultValue=false)]
		public bool? MtgInsPrepaid { get; set; }

		[DataMember(Name="schoolTaxes", EmitDefaultValue=false)]
		public int? SchoolTaxes { get; set; }

		[DataMember(Name="schoolTaxesPrepaid", EmitDefaultValue=false)]
		public bool? SchoolTaxesPrepaid { get; set; }

		[DataMember(Name="taxDisb", EmitDefaultValue=false)]
		public int? TaxDisb { get; set; }

		[DataMember(Name="taxPrepaid", EmitDefaultValue=false)]
		public bool? TaxPrepaid { get; set; }

		[DataMember(Name="userDefined1", EmitDefaultValue=false)]
		public int? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2", EmitDefaultValue=false)]
		public int? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3", EmitDefaultValue=false)]
		public int? UserDefined3 { get; set; }

		[DataMember(Name="userDefinedPrepaid1", EmitDefaultValue=false)]
		public bool? UserDefinedPrepaid1 { get; set; }

		[DataMember(Name="userDefinedPrepaid2", EmitDefaultValue=false)]
		public bool? UserDefinedPrepaid2 { get; set; }

		[DataMember(Name="userDefinedPrepaid3", EmitDefaultValue=false)]
		public bool? UserDefinedPrepaid3 { get; set; }

	}
}