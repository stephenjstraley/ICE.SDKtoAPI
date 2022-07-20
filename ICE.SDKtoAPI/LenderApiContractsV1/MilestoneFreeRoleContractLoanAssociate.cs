using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class MilestoneFreeRoleContractLoanAssociate
	{
		[DataMember(Name="cellPhone")]
		public string CellPhone { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="fax")]
		public string Fax { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanAssociateType")]
		public string LoanAssociateType { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="roleId")]
		public string RoleId { get; set; }

		[DataMember(Name="roleName")]
		public string RoleName { get; set; }

		[DataMember(Name="writeAccess")]
		public bool? WriteAccess { get; set; }

	}
}