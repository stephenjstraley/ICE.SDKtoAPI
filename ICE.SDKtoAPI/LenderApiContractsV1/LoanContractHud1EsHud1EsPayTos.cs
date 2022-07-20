using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsPayTos
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="amountLastPay")]
		public decimal? AmountLastPay { get; set; }

		[DataMember(Name="amountNextDue")]
		public decimal? AmountNextDue { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="contactName")]
		public string ContactName { get; set; }

		[DataMember(Name="coverageAmount")]
		public decimal? CoverageAmount { get; set; }

		[DataMember(Name="datePaid")]
		public DateTime? DatePaid { get; set; }

		[DataMember(Name="delinquentDate")]
		public DateTime? DelinquentDate { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="fax")]
		public string Fax { get; set; }

		[DataMember(Name="feeType")]
		public string FeeType { get; set; }

		[DataMember(Name="hud1EsPayToIndex")]
		public int? Hud1EsPayToIndex { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="maxDeductibleAmount")]
		public decimal? MaxDeductibleAmount { get; set; }

		[DataMember(Name="maxDeductiblePercentage")]
		public decimal? MaxDeductiblePercentage { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="nextDueDate")]
		public DateTime? NextDueDate { get; set; }

		[DataMember(Name="paymentSchedule")]
		public string PaymentSchedule { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="policyNumber")]
		public string PolicyNumber { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="premium")]
		public decimal? Premium { get; set; }

		[DataMember(Name="renewalDate")]
		public DateTime? RenewalDate { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

	}
}