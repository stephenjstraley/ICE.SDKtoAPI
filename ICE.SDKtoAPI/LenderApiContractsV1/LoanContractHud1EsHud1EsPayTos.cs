using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHud1EsHud1EsPayTos
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="amountLastPay", EmitDefaultValue=false)]
		public double? AmountLastPay { get; set; }

		[DataMember(Name="amountNextDue", EmitDefaultValue=false)]
		public double? AmountNextDue { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="coverageAmount", EmitDefaultValue=false)]
		public double? CoverageAmount { get; set; }

		[DataMember(Name="datePaid", EmitDefaultValue=false)]
		public DateTime? DatePaid { get; set; }

		[DataMember(Name="delinquentDate", EmitDefaultValue=false)]
		public DateTime? DelinquentDate { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="feeType", EmitDefaultValue=false)]
		public string FeeType { get; set; }

		[DataMember(Name="hud1EsPayToIndex", EmitDefaultValue=false)]
		public int? Hud1EsPayToIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="maxDeductibleAmount", EmitDefaultValue=false)]
		public double? MaxDeductibleAmount { get; set; }

		[DataMember(Name="maxDeductiblePercentage", EmitDefaultValue=false)]
		public double? MaxDeductiblePercentage { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="nextDueDate", EmitDefaultValue=false)]
		public DateTime? NextDueDate { get; set; }

		[DataMember(Name="paymentSchedule", EmitDefaultValue=false)]
		public string PaymentSchedule { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="policyNumber", EmitDefaultValue=false)]
		public string PolicyNumber { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="premium", EmitDefaultValue=false)]
		public double? Premium { get; set; }

		[DataMember(Name="renewalDate", EmitDefaultValue=false)]
		public DateTime? RenewalDate { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

	}
}