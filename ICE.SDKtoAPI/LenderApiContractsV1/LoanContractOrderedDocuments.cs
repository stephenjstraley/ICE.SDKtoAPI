using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractOrderedDocuments
	{
		[DataMember(Name="category", EmitDefaultValue=false)]
		public string Category { get; set; }

		[DataMember(Name="dataKey", EmitDefaultValue=false)]
		public string DataKey { get; set; }

		[DataMember(Name="documentServiceId", EmitDefaultValue=false)]
		public string DocumentServiceId { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="overflowDataKey", EmitDefaultValue=false)]
		public string OverflowDataKey { get; set; }

		[DataMember(Name="overflows", EmitDefaultValue=false)]
		public List<LoanContractOverflows> Overflows { get; set; }

		[DataMember(Name="pairId", EmitDefaultValue=false)]
		public string PairId { get; set; }

		[DataMember(Name="signatureType", EmitDefaultValue=false)]
		public string SignatureType { get; set; }

		[DataMember(Name="size", EmitDefaultValue=false)]
		public long? Size { get; set; }

		[DataMember(Name="templateId", EmitDefaultValue=false)]
		public string TemplateId { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

	}
}