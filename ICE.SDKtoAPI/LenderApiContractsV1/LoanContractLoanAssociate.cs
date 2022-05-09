using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanAssociate
	{
		[DataMember(Name="cellPhone", EmitDefaultValue=false)]
		public string CellPhone { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="enableWriteAccess", EmitDefaultValue=false)]
		public string EnableWriteAccess { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="idString", EmitDefaultValue=false)]
		public string IdString { get; set; }

		[DataMember(Name="loanAssociateType", EmitDefaultValue=false)]
		public string LoanAssociateType { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="roleId", EmitDefaultValue=false)]
		public int? RoleId { get; set; }

		[DataMember(Name="roleName", EmitDefaultValue=false)]
		public string RoleName { get; set; }

		[DataMember(Name="writeAccess", EmitDefaultValue=false)]
		public string WriteAccess { get; set; }

	}
}