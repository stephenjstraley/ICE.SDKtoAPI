using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractDownPayment
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="downPaymentType")]
		public string DownPaymentType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="sourceDescription")]
		public string SourceDescription { get; set; }

	}
}