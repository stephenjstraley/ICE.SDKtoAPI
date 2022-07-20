using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ApplicationContractContact
	{
		[DataMember(Name="entityId")]
		public string EntityId { get; set; }

		[DataMember(Name="entityName")]
		public string EntityName { get; set; }

		[DataMember(Name="entityType")]
		public string EntityType { get; set; }

		[DataMember(Name="entityUri")]
		public string EntityUri { get; set; }

	}
}