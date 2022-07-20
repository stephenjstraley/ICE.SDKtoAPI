using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataPrepaymentPenalties
	{
		[DataMember(Name="fullPrepaymentPenaltyOptionType")]
		public string FullPrepaymentPenaltyOptionType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="prepaymentPenaltyPercent")]
		public decimal? PrepaymentPenaltyPercent { get; set; }

		[DataMember(Name="termMonthsCount")]
		public int? TermMonthsCount { get; set; }

	}
}