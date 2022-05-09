using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsDueDates
	{
		[DataMember(Name="annualFee", EmitDefaultValue=false)]
		public DateTime? AnnualFee { get; set; }

		[DataMember(Name="floodInsDisb", EmitDefaultValue=false)]
		public DateTime? FloodInsDisb { get; set; }

		[DataMember(Name="hazInsDisb", EmitDefaultValue=false)]
		public DateTime? HazInsDisb { get; set; }

		[DataMember(Name="hud1EsDueDateIndex", EmitDefaultValue=false)]
		public int? Hud1EsDueDateIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb", EmitDefaultValue=false)]
		public DateTime? MtgInsDisb { get; set; }

		[DataMember(Name="schoolTaxes", EmitDefaultValue=false)]
		public DateTime? SchoolTaxes { get; set; }

		[DataMember(Name="taxDisb", EmitDefaultValue=false)]
		public DateTime? TaxDisb { get; set; }

		[DataMember(Name="userDefined1", EmitDefaultValue=false)]
		public DateTime? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2", EmitDefaultValue=false)]
		public DateTime? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3", EmitDefaultValue=false)]
		public DateTime? UserDefined3 { get; set; }

	}
}