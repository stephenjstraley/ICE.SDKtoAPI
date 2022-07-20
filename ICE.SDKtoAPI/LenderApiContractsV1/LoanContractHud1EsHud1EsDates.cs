using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsDates
	{
		[DataMember(Name="aggrMthDisb")]
		public decimal? AggrMthDisb { get; set; }

		[DataMember(Name="annualFee")]
		public decimal? AnnualFee { get; set; }

		[DataMember(Name="balance")]
		public decimal? Balance { get; set; }

		[DataMember(Name="date")]
		public string Date { get; set; }

		[DataMember(Name="floodInsDisb")]
		public decimal? FloodInsDisb { get; set; }

		[DataMember(Name="hazInsDisb")]
		public decimal? HazInsDisb { get; set; }

		[DataMember(Name="hud1EsDateIndex")]
		public int? Hud1EsDateIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="mtgInsDisb")]
		public decimal? MtgInsDisb { get; set; }

		[DataMember(Name="schoolTaxes")]
		public decimal? SchoolTaxes { get; set; }

		[DataMember(Name="taxDisb")]
		public decimal? TaxDisb { get; set; }

		[DataMember(Name="userDefined1")]
		public decimal? UserDefined1 { get; set; }

		[DataMember(Name="userDefined2")]
		public decimal? UserDefined2 { get; set; }

		[DataMember(Name="userDefined3")]
		public decimal? UserDefined3 { get; set; }

	}
}