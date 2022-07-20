using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanSubmissionLoanSubmissionFees
	{
		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="dueBroker")]
		public decimal? DueBroker { get; set; }

		[DataMember(Name="dueLender")]
		public decimal? DueLender { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanSubmissionFeeType")]
		public string LoanSubmissionFeeType { get; set; }

		[DataMember(Name="total")]
		public decimal? Total { get; set; }

	}
}