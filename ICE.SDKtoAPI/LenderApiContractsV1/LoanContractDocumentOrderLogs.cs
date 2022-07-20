using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocumentOrderLogs
	{
		[DataMember(Name="dateFilesPurged")]
		public DateTime? DateFilesPurged { get; set; }

		[DataMember(Name="dateUtc")]
		public DateTime? DateUtc { get; set; }

		[DataMember(Name="documentAudit")]
		public LoanContractDocumentAudit DocumentAudit { get; set; }

		[DataMember(Name="documentFields")]
		public object DocumentFields { get; set; }

		[DataMember(Name="orderedDocuments")]
		public List<LoanContractOrderedDocuments> OrderedDocuments { get; set; }

		[DataMember(Name="orderId")]
		public string OrderId { get; set; }

		[DataMember(Name="orderType")]
		public string OrderType { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

		[DataMember(Name="userId")]
		public string UserId { get; set; }

	}
}