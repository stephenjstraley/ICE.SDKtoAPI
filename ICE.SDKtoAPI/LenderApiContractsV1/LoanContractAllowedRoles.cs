using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAllowedRoles
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="refId")]
		public string RefId { get; set; }

	}
}