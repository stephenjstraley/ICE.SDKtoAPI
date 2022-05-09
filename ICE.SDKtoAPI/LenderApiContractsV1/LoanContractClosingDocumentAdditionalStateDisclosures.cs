using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentAdditionalStateDisclosures
	{
		[DataMember(Name="disclosureName", EmitDefaultValue=false)]
		public string DisclosureName { get; set; }

		[DataMember(Name="disclosureValue", EmitDefaultValue=false)]
		public string DisclosureValue { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="stateCode", EmitDefaultValue=false)]
		public string StateCode { get; set; }

	}
}