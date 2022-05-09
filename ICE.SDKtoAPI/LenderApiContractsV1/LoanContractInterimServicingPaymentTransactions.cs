using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicingPaymentTransactions
	{
		[DataMember(Name="accountHolder", EmitDefaultValue=false)]
		public string AccountHolder { get; set; }

		[DataMember(Name="accountNumber", EmitDefaultValue=false)]
		public string AccountNumber { get; set; }

		[DataMember(Name="additionalEscrow", EmitDefaultValue=false)]
		public double? AdditionalEscrow { get; set; }

		[DataMember(Name="additionalPrincipal", EmitDefaultValue=false)]
		public double? AdditionalPrincipal { get; set; }

		[DataMember(Name="buydownSubsidyAmount", EmitDefaultValue=false)]
		public double? BuydownSubsidyAmount { get; set; }

		[DataMember(Name="checkNumber", EmitDefaultValue=false)]
		public string CheckNumber { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="commonAmount", EmitDefaultValue=false)]
		public double? CommonAmount { get; set; }

		[DataMember(Name="commonDate", EmitDefaultValue=false)]
		public DateTime? CommonDate { get; set; }

		[DataMember(Name="createdById", EmitDefaultValue=false)]
		public string CreatedById { get; set; }

		[DataMember(Name="createdByName", EmitDefaultValue=false)]
		public string CreatedByName { get; set; }

		[DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? CreatedDateTimeUtc { get; set; }

		[DataMember(Name="escrow", EmitDefaultValue=false)]
		public double? Escrow { get; set; }

		[DataMember(Name="escrowCityPropertyTax", EmitDefaultValue=false)]
		public double? EscrowCityPropertyTax { get; set; }

		[DataMember(Name="escrowFloodInsurance", EmitDefaultValue=false)]
		public double? EscrowFloodInsurance { get; set; }

		[DataMember(Name="escrowHazardInsurance", EmitDefaultValue=false)]
		public double? EscrowHazardInsurance { get; set; }

		[DataMember(Name="escrowMortgageInsurance", EmitDefaultValue=false)]
		public double? EscrowMortgageInsurance { get; set; }

		[DataMember(Name="escrowOther1", EmitDefaultValue=false)]
		public double? EscrowOther1 { get; set; }

		[DataMember(Name="escrowOther2", EmitDefaultValue=false)]
		public double? EscrowOther2 { get; set; }

		[DataMember(Name="escrowOther3", EmitDefaultValue=false)]
		public double? EscrowOther3 { get; set; }

		[DataMember(Name="escrowTax", EmitDefaultValue=false)]
		public double? EscrowTax { get; set; }

		[DataMember(Name="escrowUSDAMonthlyPremium", EmitDefaultValue=false)]
		public double? EscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexRate", EmitDefaultValue=false)]
		public double? IndexRate { get; set; }

		[DataMember(Name="institutionName", EmitDefaultValue=false)]
		public string InstitutionName { get; set; }

		[DataMember(Name="institutionRouting", EmitDefaultValue=false)]
		public string InstitutionRouting { get; set; }

		[DataMember(Name="interest", EmitDefaultValue=false)]
		public double? Interest { get; set; }

		[DataMember(Name="interestRate", EmitDefaultValue=false)]
		public double? InterestRate { get; set; }

		[DataMember(Name="lateFee", EmitDefaultValue=false)]
		public double? LateFee { get; set; }

		[DataMember(Name="lateFeeIfLate", EmitDefaultValue=false)]
		public double? LateFeeIfLate { get; set; }

		[DataMember(Name="latePaymentDate", EmitDefaultValue=false)]
		public DateTime? LatePaymentDate { get; set; }

		[DataMember(Name="miscFee", EmitDefaultValue=false)]
		public double? MiscFee { get; set; }

		[DataMember(Name="modifiedById", EmitDefaultValue=false)]
		public string ModifiedById { get; set; }

		[DataMember(Name="modifiedByName", EmitDefaultValue=false)]
		public string ModifiedByName { get; set; }

		[DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? ModifiedDateTimeUtc { get; set; }

		[DataMember(Name="paymentDepositedDate", EmitDefaultValue=false)]
		public DateTime? PaymentDepositedDate { get; set; }

		[DataMember(Name="paymentDueDate", EmitDefaultValue=false)]
		public DateTime? PaymentDueDate { get; set; }

		[DataMember(Name="paymentIndexDate", EmitDefaultValue=false)]
		public DateTime? PaymentIndexDate { get; set; }

		[DataMember(Name="paymentNumber", EmitDefaultValue=false)]
		public int? PaymentNumber { get; set; }

		[DataMember(Name="paymentReceivedDate", EmitDefaultValue=false)]
		public DateTime? PaymentReceivedDate { get; set; }

		[DataMember(Name="principal", EmitDefaultValue=false)]
		public double? Principal { get; set; }

		[DataMember(Name="reference", EmitDefaultValue=false)]
		public string Reference { get; set; }

		[DataMember(Name="schedulePayLogMiscFee", EmitDefaultValue=false)]
		public double? SchedulePayLogMiscFee { get; set; }

		[DataMember(Name="servicingPaymentMethod", EmitDefaultValue=false)]
		public string ServicingPaymentMethod { get; set; }

		[DataMember(Name="servicingTransactionType", EmitDefaultValue=false)]
		public string ServicingTransactionType { get; set; }

		[DataMember(Name="statementDate", EmitDefaultValue=false)]
		public DateTime? StatementDate { get; set; }

		[DataMember(Name="totalAmountDue", EmitDefaultValue=false)]
		public double? TotalAmountDue { get; set; }

		[DataMember(Name="totalAmountReceived", EmitDefaultValue=false)]
		public double? TotalAmountReceived { get; set; }

		[DataMember(Name="transactionAmount", EmitDefaultValue=false)]
		public double? TransactionAmount { get; set; }

		[DataMember(Name="transactionDate", EmitDefaultValue=false)]
		public DateTime? TransactionDate { get; set; }

	}
}