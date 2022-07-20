using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ResourceLockContract
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lockTime")]
		public string LockTime { get; set; }

		[DataMember(Name="lockType")]
		public string LockType { get; set; }

		[DataMember(Name="resource")]
		public ResourceLockContractResource Resource { get; set; }

		[DataMember(Name="userid")]
		public string Userid { get; set; }

	}
}