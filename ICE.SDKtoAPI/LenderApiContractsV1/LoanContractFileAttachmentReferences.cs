using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFileAttachmentReferences
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isActive")]
		public bool? IsActive { get; set; }

		[DataMember(Name="refId")]
		public string RefId { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

	}
}