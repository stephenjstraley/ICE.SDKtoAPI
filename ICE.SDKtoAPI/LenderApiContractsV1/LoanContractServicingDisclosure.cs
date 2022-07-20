using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractServicingDisclosure
	{
		[DataMember(Name="disclosurePercent1")]
		public decimal? DisclosurePercent1 { get; set; }

		[DataMember(Name="disclosurePercent2")]
		public decimal? DisclosurePercent2 { get; set; }

		[DataMember(Name="disclosurePercent3")]
		public decimal? DisclosurePercent3 { get; set; }

		[DataMember(Name="disclosureYear1")]
		public string DisclosureYear1 { get; set; }

		[DataMember(Name="disclosureYear2")]
		public string DisclosureYear2 { get; set; }

		[DataMember(Name="disclosureYear3")]
		public string DisclosureYear3 { get; set; }

		[DataMember(Name="fiftyOneTo75Indicator")]
		public bool? FiftyOneTo75Indicator { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="seventySixTo100Indicator")]
		public bool? SeventySixTo100Indicator { get; set; }

		[DataMember(Name="thisEstimateType")]
		public string ThisEstimateType { get; set; }

		[DataMember(Name="thisInformationType")]
		public string ThisInformationType { get; set; }

		[DataMember(Name="thisIsOurRecordOfTransferingIndicator")]
		public bool? ThisIsOurRecordOfTransferingIndicator { get; set; }

		[DataMember(Name="twentySixTo50Indicator")]
		public bool? TwentySixTo50Indicator { get; set; }

		[DataMember(Name="weAreAbleType")]
		public string WeAreAbleType { get; set; }

		[DataMember(Name="weDoNotSellMortgageLoansIndicator")]
		public bool? WeDoNotSellMortgageLoansIndicator { get; set; }

		[DataMember(Name="weDoNotServiceMortgageLoansIndicator")]
		public bool? WeDoNotServiceMortgageLoansIndicator { get; set; }

		[DataMember(Name="weHaveNotServicedMortgLoansIn3YrsIndicator")]
		public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }

		[DataMember(Name="weHavePreviouslyAssignedIndicator")]
		public bool? WeHavePreviouslyAssignedIndicator { get; set; }

		[DataMember(Name="weMayAssignIndicator")]
		public bool? WeMayAssignIndicator { get; set; }

		[DataMember(Name="zeroTo25Indicator")]
		public bool? ZeroTo25Indicator { get; set; }

	}
}