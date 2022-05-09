using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLDocuments
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="tQLDocumentDeliveredDate", EmitDefaultValue=false)]
		public DateTime? TQLDocumentDeliveredDate { get; set; }

	}
}