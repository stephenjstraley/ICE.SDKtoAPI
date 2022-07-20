using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAlerts
	{
		[DataMember(Name="dueDate")]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="followedUpDate")]
		public DateTime? FollowedUpDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="logRecord")]
		public LoanContractLogRecord LogRecord { get; set; }

		[DataMember(Name="roleId")]
		public int? RoleId { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

		[DataMember(Name="userId")]
		public string UserId { get; set; }

	}
}