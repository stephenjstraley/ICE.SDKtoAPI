using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentAuditAlerts
	{
		[DataMember(Name="fields")]
		public List<string> Fields { get; set; }

		[DataMember(Name="source")]
		public string Source { get; set; }

		[DataMember(Name="text")]
		public string Text { get; set; }

		[DataMember(Name="type")]
		public string Type { get; set; }

	}
}