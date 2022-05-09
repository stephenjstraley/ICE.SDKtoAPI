using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDocuments
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name = "applicationId")]
		public string ApplicationId { get; set; }

		[DataMember(Name = "dateRequested")]
		public string DateRequested { get; set; }

		[DataMember(Name = "dateReceived")]
		public string DateReceived { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

		[DataMember(Name = "requestedFrom")]
		public string RequestedFrom { get; set; }
	}
}