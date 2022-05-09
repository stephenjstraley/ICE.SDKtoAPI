using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsDates
	{
		[DataMember(Name="aggrMthDisb", EmitDefaultValue=false)]
		public double? AggrMthDisb { get; set; }

		[DataMember(Name="annualFee", EmitDefaultValue=false)]
		public double? AnnualFee { get; set; }

		[DataMember(Name="balance", EmitDefaultValue=false)]
		public double? Balance { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public string Date { get; set; }

		[DataMember(Name="floodInsDisb", EmitDefaultValue=false)]
		public double? FloodInsDisb { get; set; }

		[DataMember(Name="hazInsDisb", EmitDefaultValue=false)]
		public double? HazInsDisb { get; set; }

		[DataMember(Name="hud1EsDateIndex", EmitDefaultValue=false)]
		public int? Hud1EsDateIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb", EmitDefaultValue=false)]
		public double? MtgInsDisb { get; set; }

		[DataMember(Name="schoolTaxes", EmitDefaultValue=false)]
		public double? SchoolTaxes { get; set; }

		[DataMember(Name="taxDisb", EmitDefaultValue=false)]
		public double? TaxDisb { get; set; }

		[DataMember(Name="userDefined1", EmitDefaultValue=false)]
		public double? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2", EmitDefaultValue=false)]
		public double? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3", EmitDefaultValue=false)]
		public double? UserDefined3 { get; set; }

	}
}