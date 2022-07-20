using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsDueDates
	{
		[DataMember(Name="annualFee")]
		public DateTime? AnnualFee { get; set; }

		[DataMember(Name="floodInsDisb")]
		public DateTime? FloodInsDisb { get; set; }

		[DataMember(Name="hazInsDisb")]
		public DateTime? HazInsDisb { get; set; }

		[DataMember(Name="hud1EsDueDateIndex")]
		public int? Hud1EsDueDateIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb")]
		public DateTime? MtgInsDisb { get; set; }

		[DataMember(Name="schoolTaxes")]
		public DateTime? SchoolTaxes { get; set; }

		[DataMember(Name="taxDisb")]
		public DateTime? TaxDisb { get; set; }

		[DataMember(Name="userDefined1")]
		public DateTime? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2")]
		public DateTime? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3")]
		public DateTime? UserDefined3 { get; set; }

	}
}