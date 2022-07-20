using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanDataPreviousVaLoans
	{
		[DataMember(Name="dateOfLoan")]
		public DateTime? DateOfLoan { get; set; }

		[DataMember(Name="dateSold")]
		public DateTime? DateSold { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanType")]
		public string LoanType { get; set; }

		[DataMember(Name="previousVaLoanIndex")]
		public int? PreviousVaLoanIndex { get; set; }

		[DataMember(Name="propertyAddress")]
		public string PropertyAddress { get; set; }

		[DataMember(Name="propertyCity")]
		public string PropertyCity { get; set; }

		[DataMember(Name="propertyOwned")]
		public bool? PropertyOwned { get; set; }

		[DataMember(Name="propertyPostalCode")]
		public string PropertyPostalCode { get; set; }

		[DataMember(Name="propertyState")]
		public string PropertyState { get; set; }

		[DataMember(Name="vALoanNumber")]
		public string VALoanNumber { get; set; }

	}
}