using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class MilestoneFreeRoleContract
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanAssociate", EmitDefaultValue=false)]
		public MilestoneFreeRoleContractLoanAssociate LoanAssociate { get; set; }

	}
}