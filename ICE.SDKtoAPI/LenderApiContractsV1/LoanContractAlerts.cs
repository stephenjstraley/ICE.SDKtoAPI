using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAlerts
	{
		[DataMember(Name="dueDate", EmitDefaultValue=false)]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="followedUpDate", EmitDefaultValue=false)]
		public DateTime? FollowedUpDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="logRecord", EmitDefaultValue=false)]
		public LoanContractLogRecord LogRecord { get; set; }

		[DataMember(Name="roleId", EmitDefaultValue=false)]
		public int? RoleId { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

		[DataMember(Name="userId", EmitDefaultValue=false)]
		public string UserId { get; set; }

	}
}