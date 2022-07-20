using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCrmLogs
	{
		[DataMember(Name="contactGuid")]
		public string ContactGuid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="mappingId")]
		public string MappingId { get; set; }

		[DataMember(Name="mappingType")]
		public int? MappingType { get; set; }

		[DataMember(Name="roleType")]
		public int? RoleType { get; set; }

		[DataMember(Name="systemId")]
		public string SystemId { get; set; }

	}
}