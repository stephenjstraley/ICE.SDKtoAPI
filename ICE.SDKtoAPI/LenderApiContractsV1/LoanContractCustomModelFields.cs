using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCustomModelFields
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="provideAmortizationScenario", EmitDefaultValue=false)]
		public bool? ProvideAmortizationScenario { get; set; }

		[DataMember(Name="provideBestCaseScenario", EmitDefaultValue=false)]
		public bool? ProvideBestCaseScenario { get; set; }

		[DataMember(Name="provideFHAScenario", EmitDefaultValue=false)]
		public bool? ProvideFHAScenario { get; set; }

		[DataMember(Name="provideWorstCaseScenario", EmitDefaultValue=false)]
		public bool? ProvideWorstCaseScenario { get; set; }

	}
}