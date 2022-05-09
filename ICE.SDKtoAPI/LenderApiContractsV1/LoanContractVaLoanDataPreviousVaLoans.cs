using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanDataPreviousVaLoans
	{
		[DataMember(Name="dateOfLoan", EmitDefaultValue=false)]
		public DateTime? DateOfLoan { get; set; }

		[DataMember(Name="dateSold", EmitDefaultValue=false)]
		public DateTime? DateSold { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanType", EmitDefaultValue=false)]
		public string LoanType { get; set; }

		[DataMember(Name="previousVaLoanIndex", EmitDefaultValue=false)]
		public int? PreviousVaLoanIndex { get; set; }

		[DataMember(Name="propertyAddress", EmitDefaultValue=false)]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity", EmitDefaultValue=false)]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyOwned", EmitDefaultValue=false)]
		public bool? PropertyOwned { get; set; }

		[DataMember(Name="propertyPostalCode", EmitDefaultValue=false)]
		public string PropertyPostalCode { get; set; }

		[DataMember(Name="propertyState", EmitDefaultValue=false)]
		public string PropertyState { get; set; }

		[DataMember(Name="vALoanNumber", EmitDefaultValue=false)]
		public string VALoanNumber { get; set; }

	}
}