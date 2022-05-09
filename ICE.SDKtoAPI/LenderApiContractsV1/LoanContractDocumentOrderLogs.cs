using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentOrderLogs
	{
		[DataMember(Name="dateFilesPurged", EmitDefaultValue=false)]
		public DateTime? DateFilesPurged { get; set; }

		[DataMember(Name="dateUtc", EmitDefaultValue=false)]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="documentAudit", EmitDefaultValue=false)]
		public LoanContractDocumentAudit DocumentAudit { get; set; }

		[DataMember(Name="documentFields", EmitDefaultValue=false)]
		public object DocumentFields { get; set; }

		[DataMember(Name="orderedDocuments", EmitDefaultValue=false)]
		public List<LoanContractOrderedDocuments> OrderedDocuments { get; set; }

		[DataMember(Name="orderId", EmitDefaultValue=false)]
		public string OrderId { get; set; }

		[DataMember(Name="orderType", EmitDefaultValue=false)]
		public string OrderType { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

		[DataMember(Name="userId", EmitDefaultValue=false)]
		public string UserId { get; set; }

	}
}