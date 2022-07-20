using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractOrderedDocuments
	{
		[DataMember(Name="category")]
		public string Category { get; set; }

		[DataMember(Name="dataKey")]
		public string DataKey { get; set; }

		[DataMember(Name="documentServiceId")]
		public string DocumentServiceId { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="overflowDataKey")]
		public string OverflowDataKey { get; set; }

		[DataMember(Name="overflows")]
		public List<LoanContractOverflows> Overflows { get; set; }

		[DataMember(Name="pairId")]
		public string PairId { get; set; }

		[DataMember(Name="signatureType")]
		public string SignatureType { get; set; }

		[DataMember(Name="size")]
		public long? Size { get; set; }

		[DataMember(Name="templateId")]
		public string TemplateId { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="type")]
		public string Type { get; set; }

	}
}