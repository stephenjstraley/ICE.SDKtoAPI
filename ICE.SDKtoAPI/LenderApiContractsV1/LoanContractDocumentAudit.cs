using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentAudit
	{
		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<LoanContractDocumentAuditAlerts> Alerts { get; set; }

		[DataMember(Name="reportKey", EmitDefaultValue=false)]
		public string ReportKey { get; set; }

		[DataMember(Name="timeStamp", EmitDefaultValue=false)]
		public DateTime? TimeStamp { get; set; }

	}
}