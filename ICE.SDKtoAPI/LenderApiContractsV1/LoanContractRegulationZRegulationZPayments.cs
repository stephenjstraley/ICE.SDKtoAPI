using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZRegulationZPayments
	{
		[DataMember(Name="balance")]
		public decimal? Balance { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="interestRatePercent")]
		public decimal? InterestRatePercent { get; set; }

		[DataMember(Name="monthlyPayment")]
		public decimal? MonthlyPayment { get; set; }

		[DataMember(Name="numberOfPayments")]
		public int? NumberOfPayments { get; set; }

		[DataMember(Name="paymentDate")]
		public DateTime? PaymentDate { get; set; }

		[DataMember(Name="regulationZPaymentIndex")]
		public int? RegulationZPaymentIndex { get; set; }

	}
}