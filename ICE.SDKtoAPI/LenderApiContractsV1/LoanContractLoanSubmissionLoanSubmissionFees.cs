using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanSubmissionLoanSubmissionFees
	{
		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="dueBroker", EmitDefaultValue=false)]
		public double? DueBroker { get; set; }

		[DataMember(Name="dueLender", EmitDefaultValue=false)]
		public double? DueLender { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanSubmissionFeeType", EmitDefaultValue=false)]
		public string LoanSubmissionFeeType { get; set; }

		[DataMember(Name="total", EmitDefaultValue=false)]
		public double? Total { get; set; }

	}
}