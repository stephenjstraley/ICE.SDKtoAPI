using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentAudit
	{
		[DataMember(Name="alerts")]
		public List<LoanContractDocumentAuditAlerts> Alerts { get; set; }

		[DataMember(Name="reportKey")]
		public string ReportKey { get; set; }

		[DataMember(Name="timeStamp")]
		public DateTime? TimeStamp { get; set; }

	}
}