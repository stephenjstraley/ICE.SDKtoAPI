using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFileAttachmentReferences
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isActive", EmitDefaultValue=false)]
		public bool? IsActive { get; set; }

		[DataMember(Name="refId", EmitDefaultValue=false)]
		public string RefId { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

	}
}