using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractAlerts
	{
		[DataMember(Name="dueDate", EmitDefaultValue=false)]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="followedUpDate", EmitDefaultValue=false)]
		public DateTime? FollowedUpDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="role", EmitDefaultValue=false)]
		public EntityRefContract Role { get; set; }

		[DataMember(Name="user", EmitDefaultValue=false)]
		public EntityRefContract User { get; set; }

	}
}