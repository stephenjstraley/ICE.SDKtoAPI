using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentAuditAlerts
	{
		[DataMember(Name="fields", EmitDefaultValue=false)]
		public List<string> Fields { get; set; }

		[DataMember(Name="source", EmitDefaultValue=false)]
		public string Source { get; set; }

		[DataMember(Name="text", EmitDefaultValue=false)]
		public string Text { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

	}
}