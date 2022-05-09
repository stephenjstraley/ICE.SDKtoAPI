using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataPrepaymentPenalties
	{
		[DataMember(Name="fullPrepaymentPenaltyOptionType", EmitDefaultValue=false)]
		public string FullPrepaymentPenaltyOptionType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="prepaymentPenaltyPercent", EmitDefaultValue=false)]
		public double? PrepaymentPenaltyPercent { get; set; }

		[DataMember(Name="termMonthsCount", EmitDefaultValue=false)]
		public int? TermMonthsCount { get; set; }

	}
}