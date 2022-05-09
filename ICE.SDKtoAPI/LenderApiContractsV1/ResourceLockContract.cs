using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceLockContract
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lockTime", EmitDefaultValue=false)]
		public string LockTime { get; set; }

		[DataMember(Name="lockType", EmitDefaultValue=false)]
		public string LockType { get; set; }

		[DataMember(Name="resource", EmitDefaultValue=false)]
		public ResourceLockContractResource Resource { get; set; }

		[DataMember(Name="userid", EmitDefaultValue=false)]
		public string Userid { get; set; }

	}
}