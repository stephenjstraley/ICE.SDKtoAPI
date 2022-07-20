using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class MilestoneFreeRoleContract
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanAssociate")]
		public MilestoneFreeRoleContractLoanAssociate LoanAssociate { get; set; }

	}
}