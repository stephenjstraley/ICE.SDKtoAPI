using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicing
	{
		[DataMember(Name="beginningBalance", EmitDefaultValue=false)]
		public double? BeginningBalance { get; set; }

		[DataMember(Name="borrCellPhoneNumber", EmitDefaultValue=false)]
		public string BorrCellPhoneNumber { get; set; }

		[DataMember(Name="borrHomeEmail", EmitDefaultValue=false)]
		public string BorrHomeEmail { get; set; }

		[DataMember(Name="borrHomePhoneNumber", EmitDefaultValue=false)]
		public string BorrHomePhoneNumber { get; set; }

		[DataMember(Name="borrowerFirstName", EmitDefaultValue=false)]
		public string BorrowerFirstName { get; set; }

		[DataMember(Name="borrowerLastName", EmitDefaultValue=false)]
		public string BorrowerLastName { get; set; }

		[DataMember(Name="borrWorkPhoneNumber", EmitDefaultValue=false)]
		public string BorrWorkPhoneNumber { get; set; }

		[DataMember(Name="calcTriggered", EmitDefaultValue=false)]
		public string CalcTriggered { get; set; }

		[DataMember(Name="cityInsurance", EmitDefaultValue=false)]
		public double? CityInsurance { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="currentPrincipalBalance", EmitDefaultValue=false)]
		public double? CurrentPrincipalBalance { get; set; }

		[DataMember(Name="escrowBalance", EmitDefaultValue=false)]
		public double? EscrowBalance { get; set; }

		[DataMember(Name="escrowDisbursementTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingEscrowDisbursementTransactions> EscrowDisbursementTransactions { get; set; }

		[DataMember(Name="escrowInterestTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingEscrowInterestTransactions> EscrowInterestTransactions { get; set; }

		[DataMember(Name="floodInsurance", EmitDefaultValue=false)]
		public double? FloodInsurance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="interimServicingTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingEscrowInterestTransactions> InterimServicingTransactions { get; set; }

		[DataMember(Name="lastPaymentAdditionalEscrow", EmitDefaultValue=false)]
		public double? LastPaymentAdditionalEscrow { get; set; }

		[DataMember(Name="lastPaymentAdditionalPrincipal", EmitDefaultValue=false)]
		public double? LastPaymentAdditionalPrincipal { get; set; }

		[DataMember(Name="lastPaymentBuydownSubsidyAmount", EmitDefaultValue=false)]
		public double? LastPaymentBuydownSubsidyAmount { get; set; }

		[DataMember(Name="lastPaymentEscrowAmount", EmitDefaultValue=false)]
		public double? LastPaymentEscrowAmount { get; set; }

		[DataMember(Name="lastPaymentEscrowCityPropertyTax", EmitDefaultValue=false)]
		public double? LastPaymentEscrowCityPropertyTax { get; set; }

		[DataMember(Name="lastPaymentEscrowFloodInsurance", EmitDefaultValue=false)]
		public double? LastPaymentEscrowFloodInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowHazardInsurance", EmitDefaultValue=false)]
		public double? LastPaymentEscrowHazardInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowMortgageInsurance", EmitDefaultValue=false)]
		public double? LastPaymentEscrowMortgageInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowOther1", EmitDefaultValue=false)]
		public double? LastPaymentEscrowOther1 { get; set; }

		[DataMember(Name="lastPaymentEscrowOther2", EmitDefaultValue=false)]
		public double? LastPaymentEscrowOther2 { get; set; }

		[DataMember(Name="lastPaymentEscrowOther3", EmitDefaultValue=false)]
		public double? LastPaymentEscrowOther3 { get; set; }

		[DataMember(Name="lastPaymentEscrowTax", EmitDefaultValue=false)]
		public double? LastPaymentEscrowTax { get; set; }

		[DataMember(Name="lastPaymentEscrowUSDAMonthlyPremium", EmitDefaultValue=false)]
		public double? LastPaymentEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="lastPaymentGuid", EmitDefaultValue=false)]
		public string LastPaymentGuid { get; set; }

		[DataMember(Name="lastPaymentInterest", EmitDefaultValue=false)]
		public double? LastPaymentInterest { get; set; }

		[DataMember(Name="lastPaymentLateFee", EmitDefaultValue=false)]
		public double? LastPaymentLateFee { get; set; }

		[DataMember(Name="lastPaymentMiscFee", EmitDefaultValue=false)]
		public double? LastPaymentMiscFee { get; set; }

		[DataMember(Name="lastPaymentNumber", EmitDefaultValue=false)]
		public int? LastPaymentNumber { get; set; }

		[DataMember(Name="lastPaymentPrincipal", EmitDefaultValue=false)]
		public double? LastPaymentPrincipal { get; set; }

		[DataMember(Name="lastPaymentPrincipalAndInterest", EmitDefaultValue=false)]
		public double? LastPaymentPrincipalAndInterest { get; set; }

		[DataMember(Name="lastPaymentReceivedDate", EmitDefaultValue=false)]
		public DateTime? LastPaymentReceivedDate { get; set; }

		[DataMember(Name="lastPaymentStatementDate", EmitDefaultValue=false)]
		public DateTime? LastPaymentStatementDate { get; set; }

		[DataMember(Name="lastPaymentTotalAmountReceived", EmitDefaultValue=false)]
		public double? LastPaymentTotalAmountReceived { get; set; }

		[DataMember(Name="lastScheduledPayment", EmitDefaultValue=false)]
		public LoanContractInterimServicingSchedulePaymentTransactions LastScheduledPayment { get; set; }

		[DataMember(Name="lastStatementPrintedDate", EmitDefaultValue=false)]
		public DateTime? LastStatementPrintedDate { get; set; }

		[DataMember(Name="loanPurchaseTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingLoanPurchaseTransactions> LoanPurchaseTransactions { get; set; }

		[DataMember(Name="loanSnapshotXml", EmitDefaultValue=false)]
		public string LoanSnapshotXml { get; set; }

		[DataMember(Name="mailingCity", EmitDefaultValue=false)]
		public string MailingCity { get; set; }

		[DataMember(Name="mailingPostalCode", EmitDefaultValue=false)]
		public string MailingPostalCode { get; set; }

		[DataMember(Name="mailingState", EmitDefaultValue=false)]
		public string MailingState { get; set; }

		[DataMember(Name="mailingStreetAddress", EmitDefaultValue=false)]
		public string MailingStreetAddress { get; set; }

		[DataMember(Name="mortgageAccount", EmitDefaultValue=false)]
		public string MortgageAccount { get; set; }

		[DataMember(Name="nextEscrowTotalFloodInsurance", EmitDefaultValue=false)]
		public double? NextEscrowTotalFloodInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalFloodInsuranceDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalFloodInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalHazardInsurance", EmitDefaultValue=false)]
		public double? NextEscrowTotalHazardInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalHazardInsuranceDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalHazardInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalMortgageInsurance", EmitDefaultValue=false)]
		public double? NextEscrowTotalMortgageInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalMortgageInsuranceDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax1", EmitDefaultValue=false)]
		public double? NextEscrowTotalOtherTax1 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax1DueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalOtherTax1DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax2", EmitDefaultValue=false)]
		public double? NextEscrowTotalOtherTax2 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax2DueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalOtherTax2DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax3", EmitDefaultValue=false)]
		public double? NextEscrowTotalOtherTax3 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax3DueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalOtherTax3DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalPropertyTax", EmitDefaultValue=false)]
		public double? NextEscrowTotalPropertyTax { get; set; }

		[DataMember(Name="nextEscrowTotalPropertyTaxDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalPropertyTaxDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalTax", EmitDefaultValue=false)]
		public double? NextEscrowTotalTax { get; set; }

		[DataMember(Name="nextEscrowTotalTaxDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalTaxDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalUsdaMonthlyPremium", EmitDefaultValue=false)]
		public double? NextEscrowTotalUsdaMonthlyPremium { get; set; }

		[DataMember(Name="nextEscrowTotalUsdaMonthlyPremiumDueDate", EmitDefaultValue=false)]
		public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get; set; }

		[DataMember(Name="nextPaymentBuydownSubsidyAmount", EmitDefaultValue=false)]
		public double? NextPaymentBuydownSubsidyAmount { get; set; }

		[DataMember(Name="nextPaymentEscrowAmount", EmitDefaultValue=false)]
		public double? NextPaymentEscrowAmount { get; set; }

		[DataMember(Name="nextPaymentEscrowCityPropertyTax", EmitDefaultValue=false)]
		public double? NextPaymentEscrowCityPropertyTax { get; set; }

		[DataMember(Name="nextPaymentEscrowFloodInsurance", EmitDefaultValue=false)]
		public double? NextPaymentEscrowFloodInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowHazardInsurance", EmitDefaultValue=false)]
		public double? NextPaymentEscrowHazardInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowMortgageInsurance", EmitDefaultValue=false)]
		public double? NextPaymentEscrowMortgageInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowOther1", EmitDefaultValue=false)]
		public double? NextPaymentEscrowOther1 { get; set; }

		[DataMember(Name="nextPaymentEscrowOther2", EmitDefaultValue=false)]
		public double? NextPaymentEscrowOther2 { get; set; }

		[DataMember(Name="nextPaymentEscrowOther3", EmitDefaultValue=false)]
		public double? NextPaymentEscrowOther3 { get; set; }

		[DataMember(Name="nextPaymentEscrowTax", EmitDefaultValue=false)]
		public double? NextPaymentEscrowTax { get; set; }

		[DataMember(Name="nextPaymentEscrowUSDAMonthlyPremium", EmitDefaultValue=false)]
		public double? NextPaymentEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="nextPaymentIndexCurrentValuePercent", EmitDefaultValue=false)]
		public double? NextPaymentIndexCurrentValuePercent { get; set; }

		[DataMember(Name="nextPaymentInterest", EmitDefaultValue=false)]
		public double? NextPaymentInterest { get; set; }

		[DataMember(Name="nextPaymentLateFee", EmitDefaultValue=false)]
		public double? NextPaymentLateFee { get; set; }

		[DataMember(Name="nextPaymentLatePaymentDate", EmitDefaultValue=false)]
		public DateTime? NextPaymentLatePaymentDate { get; set; }

		[DataMember(Name="nextPaymentMiscFee", EmitDefaultValue=false)]
		public double? NextPaymentMiscFee { get; set; }

		[DataMember(Name="nextPaymentPastDueAmount", EmitDefaultValue=false)]
		public double? NextPaymentPastDueAmount { get; set; }

		[DataMember(Name="nextPaymentPaymentDueDate", EmitDefaultValue=false)]
		public DateTime? NextPaymentPaymentDueDate { get; set; }

		[DataMember(Name="nextPaymentPaymentIndexDate", EmitDefaultValue=false)]
		public DateTime? NextPaymentPaymentIndexDate { get; set; }

		[DataMember(Name="nextPaymentPrincipal", EmitDefaultValue=false)]
		public double? NextPaymentPrincipal { get; set; }

		[DataMember(Name="nextPaymentPrincipalAndInterest", EmitDefaultValue=false)]
		public double? NextPaymentPrincipalAndInterest { get; set; }

		[DataMember(Name="nextPaymentRequestedInterestRatePercent", EmitDefaultValue=false)]
		public double? NextPaymentRequestedInterestRatePercent { get; set; }

		[DataMember(Name="nextPaymentStatementDueDate", EmitDefaultValue=false)]
		public DateTime? NextPaymentStatementDueDate { get; set; }

		[DataMember(Name="nextPaymentTotalAmountDue", EmitDefaultValue=false)]
		public double? NextPaymentTotalAmountDue { get; set; }

		[DataMember(Name="nextPaymentTotalAmountWithLateFee", EmitDefaultValue=false)]
		public double? NextPaymentTotalAmountWithLateFee { get; set; }

		[DataMember(Name="nextPaymentUnpaidLateFee", EmitDefaultValue=false)]
		public double? NextPaymentUnpaidLateFee { get; set; }

		[DataMember(Name="nextScheduledPayment", EmitDefaultValue=false)]
		public LoanContractInterimServicingSchedulePaymentTransactions NextScheduledPayment { get; set; }

		[DataMember(Name="numberOfDisbursement", EmitDefaultValue=false)]
		public int? NumberOfDisbursement { get; set; }

		[DataMember(Name="otherTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingOtherTransactions> OtherTransactions { get; set; }

		[DataMember(Name="paymentDueDatePrinted", EmitDefaultValue=false)]
		public DateTime? PaymentDueDatePrinted { get; set; }

		[DataMember(Name="paymentReversalTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingPaymentReversalTransactions> PaymentReversalTransactions { get; set; }

		[DataMember(Name="paymentTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingPaymentTransactions> PaymentTransactions { get; set; }

		[DataMember(Name="printedByUserId", EmitDefaultValue=false)]
		public string PrintedByUserId { get; set; }

		[DataMember(Name="printedByUserName", EmitDefaultValue=false)]
		public string PrintedByUserName { get; set; }

		[DataMember(Name="purchasedPrincipal", EmitDefaultValue=false)]
		public double? PurchasedPrincipal { get; set; }

		[DataMember(Name="scheduledPayments", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingSchedulePaymentTransactions> ScheduledPayments { get; set; }

		[DataMember(Name="schedulePaymentTransactions", EmitDefaultValue=false)]
		public List<LoanContractInterimServicingSchedulePaymentTransactions> SchedulePaymentTransactions { get; set; }

		[DataMember(Name="servicerLoanNumber", EmitDefaultValue=false)]
		public string ServicerLoanNumber { get; set; }

		[DataMember(Name="servicingStatus", EmitDefaultValue=false)]
		public string ServicingStatus { get; set; }

		[DataMember(Name="servicingTransferDate", EmitDefaultValue=false)]
		public DateTime? ServicingTransferDate { get; set; }

		[DataMember(Name="subServicer", EmitDefaultValue=false)]
		public string SubServicer { get; set; }

		[DataMember(Name="subServicerLoanNumber", EmitDefaultValue=false)]
		public string SubServicerLoanNumber { get; set; }

		[DataMember(Name="totalAdditionalEscrow", EmitDefaultValue=false)]
		public double? TotalAdditionalEscrow { get; set; }

		[DataMember(Name="totalAdditionalEscrowYearToDate", EmitDefaultValue=false)]
		public double? TotalAdditionalEscrowYearToDate { get; set; }

		[DataMember(Name="totalAdditionalPrincipal", EmitDefaultValue=false)]
		public double? TotalAdditionalPrincipal { get; set; }

		[DataMember(Name="totalAdditionalPrincipalYearToDate", EmitDefaultValue=false)]
		public double? TotalAdditionalPrincipalYearToDate { get; set; }

		[DataMember(Name="totalAmountDisbursed", EmitDefaultValue=false)]
		public double? TotalAmountDisbursed { get; set; }

		[DataMember(Name="totalBuydownSubsidyAmount", EmitDefaultValue=false)]
		public double? TotalBuydownSubsidyAmount { get; set; }

		[DataMember(Name="totalBuydownSubsidyAmountYearToDate", EmitDefaultValue=false)]
		public double? TotalBuydownSubsidyAmountYearToDate { get; set; }

		[DataMember(Name="totalEscrow", EmitDefaultValue=false)]
		public double? TotalEscrow { get; set; }

		[DataMember(Name="totalEscrowYearToDate", EmitDefaultValue=false)]
		public double? TotalEscrowYearToDate { get; set; }

		[DataMember(Name="totalHazardInsurance", EmitDefaultValue=false)]
		public double? TotalHazardInsurance { get; set; }

		[DataMember(Name="totalInterest", EmitDefaultValue=false)]
		public double? TotalInterest { get; set; }

		[DataMember(Name="totalInterestYearToDate", EmitDefaultValue=false)]
		public double? TotalInterestYearToDate { get; set; }

		[DataMember(Name="totalLateFee", EmitDefaultValue=false)]
		public double? TotalLateFee { get; set; }

		[DataMember(Name="totalLateFeeYearToDate", EmitDefaultValue=false)]
		public double? TotalLateFeeYearToDate { get; set; }

		[DataMember(Name="totalMiscFee", EmitDefaultValue=false)]
		public double? TotalMiscFee { get; set; }

		[DataMember(Name="totalMiscFeeYearToDate", EmitDefaultValue=false)]
		public double? TotalMiscFeeYearToDate { get; set; }

		[DataMember(Name="totalMortgageInsurance", EmitDefaultValue=false)]
		public double? TotalMortgageInsurance { get; set; }

		[DataMember(Name="totalNumberOfLatePayment", EmitDefaultValue=false)]
		public int? TotalNumberOfLatePayment { get; set; }

		[DataMember(Name="totalNumberOfPayment", EmitDefaultValue=false)]
		public int? TotalNumberOfPayment { get; set; }

		[DataMember(Name="totalOtherTaxes", EmitDefaultValue=false)]
		public double? TotalOtherTaxes { get; set; }

		[DataMember(Name="totalPAndI", EmitDefaultValue=false)]
		public double? TotalPAndI { get; set; }

		[DataMember(Name="totalPAndIYearToDate", EmitDefaultValue=false)]
		public double? TotalPAndIYearToDate { get; set; }

		[DataMember(Name="totalPaymentCollected", EmitDefaultValue=false)]
		public double? TotalPaymentCollected { get; set; }

		[DataMember(Name="totalPaymentCollectedYearToDate", EmitDefaultValue=false)]
		public double? TotalPaymentCollectedYearToDate { get; set; }

		[DataMember(Name="totalPrincipal", EmitDefaultValue=false)]
		public double? TotalPrincipal { get; set; }

		[DataMember(Name="totalPrincipalYearToDate", EmitDefaultValue=false)]
		public double? TotalPrincipalYearToDate { get; set; }

		[DataMember(Name="totalTaxes", EmitDefaultValue=false)]
		public double? TotalTaxes { get; set; }

		[DataMember(Name="totalUsdaMonthlyPremium", EmitDefaultValue=false)]
		public double? TotalUsdaMonthlyPremium { get; set; }

		[DataMember(Name="unpaidBuydownSubsidyAmount", EmitDefaultValue=false)]
		public double? UnpaidBuydownSubsidyAmount { get; set; }

		[DataMember(Name="unpaidEscrow", EmitDefaultValue=false)]
		public double? UnpaidEscrow { get; set; }

		[DataMember(Name="unpaidEscrowCityPropertyTax", EmitDefaultValue=false)]
		public double? UnpaidEscrowCityPropertyTax { get; set; }

		[DataMember(Name="unpaidEscrowFloodInsurance", EmitDefaultValue=false)]
		public double? UnpaidEscrowFloodInsurance { get; set; }

		[DataMember(Name="unpaidEscrowHazardInsurance", EmitDefaultValue=false)]
		public double? UnpaidEscrowHazardInsurance { get; set; }

		[DataMember(Name="unpaidEscrowMortgageInsurance", EmitDefaultValue=false)]
		public double? UnpaidEscrowMortgageInsurance { get; set; }

		[DataMember(Name="unpaidEscrowOther1", EmitDefaultValue=false)]
		public double? UnpaidEscrowOther1 { get; set; }

		[DataMember(Name="unpaidEscrowOther2", EmitDefaultValue=false)]
		public double? UnpaidEscrowOther2 { get; set; }

		[DataMember(Name="unpaidEscrowOther3", EmitDefaultValue=false)]
		public double? UnpaidEscrowOther3 { get; set; }

		[DataMember(Name="unpaidEscrowTax", EmitDefaultValue=false)]
		public double? UnpaidEscrowTax { get; set; }

		[DataMember(Name="unpaidEscrowUSDAMonthlyPremium", EmitDefaultValue=false)]
		public double? UnpaidEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="unpaidInterest", EmitDefaultValue=false)]
		public double? UnpaidInterest { get; set; }

		[DataMember(Name="unpaidLateFee", EmitDefaultValue=false)]
		public double? UnpaidLateFee { get; set; }

		[DataMember(Name="unpaidMiscrFee", EmitDefaultValue=false)]
		public double? UnpaidMiscrFee { get; set; }

		[DataMember(Name="unpaidPrincipal", EmitDefaultValue=false)]
		public double? UnpaidPrincipal { get; set; }

	}
}