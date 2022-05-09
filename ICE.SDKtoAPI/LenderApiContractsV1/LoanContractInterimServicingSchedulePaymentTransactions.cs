using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicingSchedulePaymentTransactions
	{
		[DataMember(Name="additionalEscrow", EmitDefaultValue=false)]
		public double? AdditionalEscrow { get; set; }

		[DataMember(Name="additionalPrincipal", EmitDefaultValue=false)]
		public double? AdditionalPrincipal { get; set; }

		[DataMember(Name="buydownSubsidyAmount", EmitDefaultValue=false)]
		public double? BuydownSubsidyAmount { get; set; }

		[DataMember(Name="buydownSubsidyAmountDue", EmitDefaultValue=false)]
		public double? BuydownSubsidyAmountDue { get; set; }

		[DataMember(Name="cityPropertyTax", EmitDefaultValue=false)]
		public double? CityPropertyTax { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="createdById", EmitDefaultValue=false)]
		public string CreatedById { get; set; }

		[DataMember(Name="createdByName", EmitDefaultValue=false)]
		public string CreatedByName { get; set; }

		[DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? CreatedDateTimeUtc { get; set; }

		[DataMember(Name="escrow", EmitDefaultValue=false)]
		public double? Escrow { get; set; }

		[DataMember(Name="escrowCityPropertyTaxDue", EmitDefaultValue=false)]
		public double? EscrowCityPropertyTaxDue { get; set; }

		[DataMember(Name="escrowDue", EmitDefaultValue=false)]
		public double? EscrowDue { get; set; }

		[DataMember(Name="escrowFloodInsuranceDue", EmitDefaultValue=false)]
		public double? EscrowFloodInsuranceDue { get; set; }

		[DataMember(Name="escrowHazardInsuranceDue", EmitDefaultValue=false)]
		public double? EscrowHazardInsuranceDue { get; set; }

		[DataMember(Name="escrowMortgageInsuranceDue", EmitDefaultValue=false)]
		public double? EscrowMortgageInsuranceDue { get; set; }

		[DataMember(Name="escrowOther1Due", EmitDefaultValue=false)]
		public double? EscrowOther1Due { get; set; }

		[DataMember(Name="escrowOther2Due", EmitDefaultValue=false)]
		public double? EscrowOther2Due { get; set; }

		[DataMember(Name="escrowOther3Due", EmitDefaultValue=false)]
		public double? EscrowOther3Due { get; set; }

		[DataMember(Name="escrowTaxDue", EmitDefaultValue=false)]
		public double? EscrowTaxDue { get; set; }

		[DataMember(Name="escrowUSDAMonthlyPremiumDue", EmitDefaultValue=false)]
		public double? EscrowUSDAMonthlyPremiumDue { get; set; }

		[DataMember(Name="floodInsurance", EmitDefaultValue=false)]
		public double? FloodInsurance { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="hazardInsurance", EmitDefaultValue=false)]
		public double? HazardInsurance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexRate", EmitDefaultValue=false)]
		public double? IndexRate { get; set; }

		[DataMember(Name="interest", EmitDefaultValue=false)]
		public double? Interest { get; set; }

		[DataMember(Name="interestDue", EmitDefaultValue=false)]
		public double? InterestDue { get; set; }

		[DataMember(Name="interestRate", EmitDefaultValue=false)]
		public double? InterestRate { get; set; }

		[DataMember(Name="lateFee", EmitDefaultValue=false)]
		public double? LateFee { get; set; }

		[DataMember(Name="latePaymentDate", EmitDefaultValue=false)]
		public DateTime? LatePaymentDate { get; set; }

		[DataMember(Name="miscFee", EmitDefaultValue=false)]
		public double? MiscFee { get; set; }

		[DataMember(Name="miscFeeDue", EmitDefaultValue=false)]
		public double? MiscFeeDue { get; set; }

		[DataMember(Name="modifiedById", EmitDefaultValue=false)]
		public string ModifiedById { get; set; }

		[DataMember(Name="modifiedByName", EmitDefaultValue=false)]
		public string ModifiedByName { get; set; }

		[DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? ModifiedDateTimeUtc { get; set; }

		[DataMember(Name="mortgageInsurance", EmitDefaultValue=false)]
		public double? MortgageInsurance { get; set; }

		[DataMember(Name="other1Escrow", EmitDefaultValue=false)]
		public double? Other1Escrow { get; set; }

		[DataMember(Name="other2Escrow", EmitDefaultValue=false)]
		public double? Other2Escrow { get; set; }

		[DataMember(Name="other3Escrow", EmitDefaultValue=false)]
		public double? Other3Escrow { get; set; }

		[DataMember(Name="paymentNumber", EmitDefaultValue=false)]
		public int? PaymentNumber { get; set; }

		[DataMember(Name="paymentReceiveDate", EmitDefaultValue=false)]
		public DateTime? PaymentReceiveDate { get; set; }

		[DataMember(Name="principal", EmitDefaultValue=false)]
		public double? Principal { get; set; }

		[DataMember(Name="principalDue", EmitDefaultValue=false)]
		public double? PrincipalDue { get; set; }

		[DataMember(Name="servicingPaymentMethod", EmitDefaultValue=false)]
		public string ServicingPaymentMethod { get; set; }

		[DataMember(Name="servicingTransactionType", EmitDefaultValue=false)]
		public string ServicingTransactionType { get; set; }

		[DataMember(Name="taxes", EmitDefaultValue=false)]
		public double? Taxes { get; set; }

		[DataMember(Name="totalPastDue", EmitDefaultValue=false)]
		public double? TotalPastDue { get; set; }

		[DataMember(Name="transactionAmount", EmitDefaultValue=false)]
		public double? TransactionAmount { get; set; }

		[DataMember(Name="transactionDate", EmitDefaultValue=false)]
		public DateTime? TransactionDate { get; set; }

		[DataMember(Name="unpaidLateFeeDue", EmitDefaultValue=false)]
		public double? UnpaidLateFeeDue { get; set; }

		[DataMember(Name="uSDAMonthlyPremium", EmitDefaultValue=false)]
		public double? USDAMonthlyPremium { get; set; }

	}
}