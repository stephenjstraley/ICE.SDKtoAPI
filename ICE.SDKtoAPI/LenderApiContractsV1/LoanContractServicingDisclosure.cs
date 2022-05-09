using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractServicingDisclosure
	{
		[DataMember(Name="disclosurePercent1", EmitDefaultValue=false)]
		public double? DisclosurePercent1 { get; set; }

		[DataMember(Name="disclosurePercent2", EmitDefaultValue=false)]
		public double? DisclosurePercent2 { get; set; }

		[DataMember(Name="disclosurePercent3", EmitDefaultValue=false)]
		public double? DisclosurePercent3 { get; set; }

		[DataMember(Name="disclosureYear1", EmitDefaultValue=false)]
		public string DisclosureYear1 { get; set; }

		[DataMember(Name="disclosureYear2", EmitDefaultValue=false)]
		public string DisclosureYear2 { get; set; }

		[DataMember(Name="disclosureYear3", EmitDefaultValue=false)]
		public string DisclosureYear3 { get; set; }

		[DataMember(Name="fiftyOneTo75Indicator", EmitDefaultValue=false)]
		public bool? FiftyOneTo75Indicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="seventySixTo100Indicator", EmitDefaultValue=false)]
		public bool? SeventySixTo100Indicator { get; set; }

		[DataMember(Name="thisEstimateType", EmitDefaultValue=false)]
		public string ThisEstimateType { get; set; }

		[DataMember(Name="thisInformationType", EmitDefaultValue=false)]
		public string ThisInformationType { get; set; }

		[DataMember(Name="thisIsOurRecordOfTransferingIndicator", EmitDefaultValue=false)]
		public bool? ThisIsOurRecordOfTransferingIndicator { get; set; }

		[DataMember(Name="twentySixTo50Indicator", EmitDefaultValue=false)]
		public bool? TwentySixTo50Indicator { get; set; }

		[DataMember(Name="weAreAbleType", EmitDefaultValue=false)]
		public string WeAreAbleType { get; set; }

		[DataMember(Name="weDoNotSellMortgageLoansIndicator", EmitDefaultValue=false)]
		public bool? WeDoNotSellMortgageLoansIndicator { get; set; }

		[DataMember(Name="weDoNotServiceMortgageLoansIndicator", EmitDefaultValue=false)]
		public bool? WeDoNotServiceMortgageLoansIndicator { get; set; }

		[DataMember(Name="weHaveNotServicedMortgLoansIn3YrsIndicator", EmitDefaultValue=false)]
		public bool? WeHaveNotServicedMortgLoansIn3YrsIndicator { get; set; }

		[DataMember(Name="weHavePreviouslyAssignedIndicator", EmitDefaultValue=false)]
		public bool? WeHavePreviouslyAssignedIndicator { get; set; }

		[DataMember(Name="weMayAssignIndicator", EmitDefaultValue=false)]
		public bool? WeMayAssignIndicator { get; set; }

		[DataMember(Name="zeroTo25Indicator", EmitDefaultValue=false)]
		public bool? ZeroTo25Indicator { get; set; }

	}
}