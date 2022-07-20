using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCustomModelFields
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="provideAmortizationScenario")]
		public bool? ProvideAmortizationScenario { get; set; }

		[DataMember(Name="provideBestCaseScenario")]
		public bool? ProvideBestCaseScenario { get; set; }

		[DataMember(Name="provideFHAScenario")]
		public bool? ProvideFHAScenario { get; set; }

		[DataMember(Name="provideWorstCaseScenario")]
		public bool? ProvideWorstCaseScenario { get; set; }

	}
}