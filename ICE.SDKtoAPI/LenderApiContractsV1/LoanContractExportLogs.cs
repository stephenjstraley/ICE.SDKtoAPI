using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractExportLogs
	{
		[DataMember(Name="category")]
		public string Category { get; set; }

		[DataMember(Name="exportedBy")]
		public string ExportedBy { get; set; }

		[DataMember(Name="exportedByFullName")]
		public string ExportedByFullName { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="serviceTypes")]
		public List<LoanContractServiceTypes> ServiceTypes { get; set; }

	}
}