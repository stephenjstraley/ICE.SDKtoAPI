using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceLockContractResource
	{
		[DataMember(Name="entityId")]
		public string EntityId { get; set; }

		[DataMember(Name="entityType")]
		public string EntityType { get; set; }

	}
}