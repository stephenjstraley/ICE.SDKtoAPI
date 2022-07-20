using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractAlerts
	{
		[DataMember(Name="dueDate")]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="followedUpDate")]
		public DateTime? FollowedUpDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="role")]
		public EntityRefContract Role { get; set; }

		[DataMember(Name="user")]
		public EntityRefContract User { get; set; }

	}
}