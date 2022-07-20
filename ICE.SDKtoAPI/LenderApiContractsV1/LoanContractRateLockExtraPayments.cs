using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockExtraPayments
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="extraPaymentIndex")]
		public int? ExtraPaymentIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineNumber")]
		public int? LineNumber { get; set; }

	}
}