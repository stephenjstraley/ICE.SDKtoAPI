using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCrmLogs
	{
		[DataMember(Name="contactGuid", EmitDefaultValue=false)]
		public string ContactGuid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="mappingId", EmitDefaultValue=false)]
		public string MappingId { get; set; }

		[DataMember(Name="mappingType", EmitDefaultValue=false)]
		public int? MappingType { get; set; }

		[DataMember(Name="roleType", EmitDefaultValue=false)]
		public int? RoleType { get; set; }

		[DataMember(Name="systemId", EmitDefaultValue=false)]
		public string SystemId { get; set; }

	}
}