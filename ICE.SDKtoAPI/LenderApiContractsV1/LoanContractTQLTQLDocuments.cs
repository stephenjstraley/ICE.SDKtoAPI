using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLDocuments
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="tQLDocumentDeliveredDate")]
		public DateTime? TQLDocumentDeliveredDate { get; set; }

	}
}