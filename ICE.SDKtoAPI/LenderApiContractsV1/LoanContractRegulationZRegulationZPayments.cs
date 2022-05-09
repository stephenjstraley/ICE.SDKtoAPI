using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZRegulationZPayments
	{
		[DataMember(Name="balance", EmitDefaultValue=false)]
		public double? Balance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="interestRatePercent", EmitDefaultValue=false)]
		public double? InterestRatePercent { get; set; }

		[DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
		public double? MonthlyPayment { get; set; }

		[DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
		public int? NumberOfPayments { get; set; }

		[DataMember(Name="paymentDate", EmitDefaultValue=false)]
		public DateTime? PaymentDate { get; set; }

		[DataMember(Name="regulationZPaymentIndex", EmitDefaultValue=false)]
		public int? RegulationZPaymentIndex { get; set; }

	}
}