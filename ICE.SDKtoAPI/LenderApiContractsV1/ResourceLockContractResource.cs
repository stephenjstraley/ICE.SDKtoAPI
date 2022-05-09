using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceLockContractResource
	{
		[DataMember(Name="entityId", EmitDefaultValue=false)]
		public string EntityId { get; set; }

		[DataMember(Name="entityType", EmitDefaultValue=false)]
		public string EntityType { get; set; }

	}
}