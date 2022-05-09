using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractExportLogs
	{
		[DataMember(Name="category", EmitDefaultValue=false)]
		public string Category { get; set; }

		[DataMember(Name="exportedBy", EmitDefaultValue=false)]
		public string ExportedBy { get; set; }

		[DataMember(Name="exportedByFullName", EmitDefaultValue=false)]
		public string ExportedByFullName { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="serviceTypes", EmitDefaultValue=false)]
		public List<LoanContractServiceTypes> ServiceTypes { get; set; }

	}
}