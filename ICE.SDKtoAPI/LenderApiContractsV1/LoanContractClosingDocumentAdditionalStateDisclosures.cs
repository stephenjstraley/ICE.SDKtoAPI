using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentAdditionalStateDisclosures
	{
		[DataMember(Name="disclosureName")]
		public string DisclosureName { get; set; }

		[DataMember(Name="disclosureValue")]
		public string DisclosureValue { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="stateCode")]
		public string StateCode { get; set; }

	}
}