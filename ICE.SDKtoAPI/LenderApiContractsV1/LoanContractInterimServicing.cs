using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicing
	{
		[DataMember(Name="beginningBalance")]
		public decimal? BeginningBalance { get; set; }

		[DataMember(Name="borrCellPhoneNumber")]
		public string BorrCellPhoneNumber { get; set; }

		[DataMember(Name="borrHomeEmail")]
		public string BorrHomeEmail { get; set; }

		[DataMember(Name="borrHomePhoneNumber")]
		public string BorrHomePhoneNumber { get; set; }

		[DataMember(Name="borrowerFirstName")]
		public string BorrowerFirstName { get; set; }

		[DataMember(Name="borrowerLastName")]
		public string BorrowerLastName { get; set; }

		[DataMember(Name="borrWorkPhoneNumber")]
		public string BorrWorkPhoneNumber { get; set; }

		[DataMember(Name="calcTriggered")]
		public string CalcTriggered { get; set; }

		[DataMember(Name="cityInsurance")]
		public decimal? CityInsurance { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="currentPrincipalBalance")]
		public decimal? CurrentPrincipalBalance { get; set; }

		[DataMember(Name="escrowBalance")]
		public decimal? EscrowBalance { get; set; }

		[DataMember(Name="escrowDisbursementTransactions")]
		public List<LoanContractInterimServicingEscrowDisbursementTransactions> EscrowDisbursementTransactions { get; set; }

		[DataMember(Name="escrowInterestTransactions")]
		public List<LoanContractInterimServicingEscrowInterestTransactions> EscrowInterestTransactions { get; set; }

		[DataMember(Name="floodInsurance")]
		public decimal? FloodInsurance { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="interimServicingTransactions")]
		public List<LoanContractInterimServicingEscrowInterestTransactions> InterimServicingTransactions { get; set; }

		[DataMember(Name="lastPaymentAdditionalEscrow")]
		public decimal? LastPaymentAdditionalEscrow { get; set; }

		[DataMember(Name="lastPaymentAdditionalPrincipal")]
		public decimal? LastPaymentAdditionalPrincipal { get; set; }

		[DataMember(Name="lastPaymentBuydownSubsidyAmount")]
		public decimal? LastPaymentBuydownSubsidyAmount { get; set; }

		[DataMember(Name="lastPaymentEscrowAmount")]
		public decimal? LastPaymentEscrowAmount { get; set; }

		[DataMember(Name="lastPaymentEscrowCityPropertyTax")]
		public decimal? LastPaymentEscrowCityPropertyTax { get; set; }

		[DataMember(Name="lastPaymentEscrowFloodInsurance")]
		public decimal? LastPaymentEscrowFloodInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowHazardInsurance")]
		public decimal? LastPaymentEscrowHazardInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowMortgageInsurance")]
		public decimal? LastPaymentEscrowMortgageInsurance { get; set; }

		[DataMember(Name="lastPaymentEscrowOther1")]
		public decimal? LastPaymentEscrowOther1 { get; set; }

		[DataMember(Name="lastPaymentEscrowOther2")]
		public decimal? LastPaymentEscrowOther2 { get; set; }

		[DataMember(Name="lastPaymentEscrowOther3")]
		public decimal? LastPaymentEscrowOther3 { get; set; }

		[DataMember(Name="lastPaymentEscrowTax")]
		public decimal? LastPaymentEscrowTax { get; set; }

		[DataMember(Name="lastPaymentEscrowUSDAMonthlyPremium")]
		public decimal? LastPaymentEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="lastPaymentGuid")]
		public string LastPaymentGuid { get; set; }

		[DataMember(Name="lastPaymentInterest")]
		public decimal? LastPaymentInterest { get; set; }

		[DataMember(Name="lastPaymentLateFee")]
		public decimal? LastPaymentLateFee { get; set; }

		[DataMember(Name="lastPaymentMiscFee")]
		public decimal? LastPaymentMiscFee { get; set; }

		[DataMember(Name="lastPaymentNumber")]
		public int? LastPaymentNumber { get; set; }

		[DataMember(Name="lastPaymentPrincipal")]
		public decimal? LastPaymentPrincipal { get; set; }

		[DataMember(Name="lastPaymentPrincipalAndInterest")]
		public decimal? LastPaymentPrincipalAndInterest { get; set; }

		[DataMember(Name="lastPaymentReceivedDate")]
		public DateTime? LastPaymentReceivedDate { get; set; }

		[DataMember(Name="lastPaymentStatementDate")]
		public DateTime? LastPaymentStatementDate { get; set; }

		[DataMember(Name="lastPaymentTotalAmountReceived")]
		public decimal? LastPaymentTotalAmountReceived { get; set; }

		[DataMember(Name="lastScheduledPayment")]
		public LoanContractInterimServicingSchedulePaymentTransactions LastScheduledPayment { get; set; }

		[DataMember(Name="lastStatementPrintedDate")]
		public DateTime? LastStatementPrintedDate { get; set; }

		[DataMember(Name="loanPurchaseTransactions")]
		public List<LoanContractInterimServicingLoanPurchaseTransactions> LoanPurchaseTransactions { get; set; }

		[DataMember(Name="loanSnapshotXml")]
		public string LoanSnapshotXml { get; set; }

		[DataMember(Name="mailingCity")]
		public string MailingCity { get; set; }

		[DataMember(Name="mailingPostalCode")]
		public string MailingPostalCode { get; set; }

		[DataMember(Name="mailingState")]
		public string MailingState { get; set; }

		[DataMember(Name="mailingStreetAddress")]
		public string MailingStreetAddress { get; set; }

		[DataMember(Name="mortgageAccount")]
		public string MortgageAccount { get; set; }

		[DataMember(Name="nextEscrowTotalFloodInsurance")]
		public decimal? NextEscrowTotalFloodInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalFloodInsuranceDueDate")]
		public DateTime? NextEscrowTotalFloodInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalHazardInsurance")]
		public decimal? NextEscrowTotalHazardInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalHazardInsuranceDueDate")]
		public DateTime? NextEscrowTotalHazardInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalMortgageInsurance")]
		public decimal? NextEscrowTotalMortgageInsurance { get; set; }

		[DataMember(Name="nextEscrowTotalMortgageInsuranceDueDate")]
		public DateTime? NextEscrowTotalMortgageInsuranceDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax1")]
		public decimal? NextEscrowTotalOtherTax1 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax1DueDate")]
		public DateTime? NextEscrowTotalOtherTax1DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax2")]
		public decimal? NextEscrowTotalOtherTax2 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax2DueDate")]
		public DateTime? NextEscrowTotalOtherTax2DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax3")]
		public decimal? NextEscrowTotalOtherTax3 { get; set; }

		[DataMember(Name="nextEscrowTotalOtherTax3DueDate")]
		public DateTime? NextEscrowTotalOtherTax3DueDate { get; set; }

		[DataMember(Name="nextEscrowTotalPropertyTax")]
		public decimal? NextEscrowTotalPropertyTax { get; set; }

		[DataMember(Name="nextEscrowTotalPropertyTaxDueDate")]
		public DateTime? NextEscrowTotalPropertyTaxDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalTax")]
		public decimal? NextEscrowTotalTax { get; set; }

		[DataMember(Name="nextEscrowTotalTaxDueDate")]
		public DateTime? NextEscrowTotalTaxDueDate { get; set; }

		[DataMember(Name="nextEscrowTotalUsdaMonthlyPremium")]
		public decimal? NextEscrowTotalUsdaMonthlyPremium { get; set; }

		[DataMember(Name="nextEscrowTotalUsdaMonthlyPremiumDueDate")]
		public DateTime? NextEscrowTotalUsdaMonthlyPremiumDueDate { get; set; }

		[DataMember(Name="nextPaymentBuydownSubsidyAmount")]
		public decimal? NextPaymentBuydownSubsidyAmount { get; set; }

		[DataMember(Name="nextPaymentEscrowAmount")]
		public decimal? NextPaymentEscrowAmount { get; set; }

		[DataMember(Name="nextPaymentEscrowCityPropertyTax")]
		public decimal? NextPaymentEscrowCityPropertyTax { get; set; }

		[DataMember(Name="nextPaymentEscrowFloodInsurance")]
		public decimal? NextPaymentEscrowFloodInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowHazardInsurance")]
		public decimal? NextPaymentEscrowHazardInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowMortgageInsurance")]
		public decimal? NextPaymentEscrowMortgageInsurance { get; set; }

		[DataMember(Name="nextPaymentEscrowOther1")]
		public decimal? NextPaymentEscrowOther1 { get; set; }

		[DataMember(Name="nextPaymentEscrowOther2")]
		public decimal? NextPaymentEscrowOther2 { get; set; }

		[DataMember(Name="nextPaymentEscrowOther3")]
		public decimal? NextPaymentEscrowOther3 { get; set; }

		[DataMember(Name="nextPaymentEscrowTax")]
		public decimal? NextPaymentEscrowTax { get; set; }

		[DataMember(Name="nextPaymentEscrowUSDAMonthlyPremium")]
		public decimal? NextPaymentEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="nextPaymentIndexCurrentValuePercent")]
		public decimal? NextPaymentIndexCurrentValuePercent { get; set; }

		[DataMember(Name="nextPaymentInterest")]
		public decimal? NextPaymentInterest { get; set; }

		[DataMember(Name="nextPaymentLateFee")]
		public decimal? NextPaymentLateFee { get; set; }

		[DataMember(Name="nextPaymentLatePaymentDate")]
		public DateTime? NextPaymentLatePaymentDate { get; set; }

		[DataMember(Name="nextPaymentMiscFee")]
		public decimal? NextPaymentMiscFee { get; set; }

		[DataMember(Name="nextPaymentPastDueAmount")]
		public decimal? NextPaymentPastDueAmount { get; set; }

		[DataMember(Name="nextPaymentPaymentDueDate")]
		public DateTime? NextPaymentPaymentDueDate { get; set; }

		[DataMember(Name="nextPaymentPaymentIndexDate")]
		public DateTime? NextPaymentPaymentIndexDate { get; set; }

		[DataMember(Name="nextPaymentPrincipal")]
		public decimal? NextPaymentPrincipal { get; set; }

		[DataMember(Name="nextPaymentPrincipalAndInterest")]
		public decimal? NextPaymentPrincipalAndInterest { get; set; }

		[DataMember(Name="nextPaymentRequestedInterestRatePercent")]
		public decimal? NextPaymentRequestedInterestRatePercent { get; set; }

		[DataMember(Name="nextPaymentStatementDueDate")]
		public DateTime? NextPaymentStatementDueDate { get; set; }

		[DataMember(Name="nextPaymentTotalAmountDue")]
		public decimal? NextPaymentTotalAmountDue { get; set; }

		[DataMember(Name="nextPaymentTotalAmountWithLateFee")]
		public decimal? NextPaymentTotalAmountWithLateFee { get; set; }

		[DataMember(Name="nextPaymentUnpaidLateFee")]
		public decimal? NextPaymentUnpaidLateFee { get; set; }

		[DataMember(Name="nextScheduledPayment")]
		public LoanContractInterimServicingSchedulePaymentTransactions NextScheduledPayment { get; set; }

		[DataMember(Name="numberOfDisbursement")]
		public int? NumberOfDisbursement { get; set; }

		[DataMember(Name="otherTransactions")]
		public List<LoanContractInterimServicingOtherTransactions> OtherTransactions { get; set; }

		[DataMember(Name="paymentDueDatePrinted")]
		public DateTime? PaymentDueDatePrinted { get; set; }

		[DataMember(Name="paymentReversalTransactions")]
		public List<LoanContractInterimServicingPaymentReversalTransactions> PaymentReversalTransactions { get; set; }

		[DataMember(Name="paymentTransactions")]
		public List<LoanContractInterimServicingPaymentTransactions> PaymentTransactions { get; set; }

		[DataMember(Name="printedByUserId")]
		public string PrintedByUserId { get; set; }

		[DataMember(Name="printedByUserName")]
		public string PrintedByUserName { get; set; }

		[DataMember(Name="purchasedPrincipal")]
		public decimal? PurchasedPrincipal { get; set; }

		[DataMember(Name="scheduledPayments")]
		public List<LoanContractInterimServicingSchedulePaymentTransactions> ScheduledPayments { get; set; }

		[DataMember(Name="schedulePaymentTransactions")]
		public List<LoanContractInterimServicingSchedulePaymentTransactions> SchedulePaymentTransactions { get; set; }

		[DataMember(Name="servicerLoanNumber")]
		public string ServicerLoanNumber { get; set; }

		[DataMember(Name="servicingStatus")]
		public string ServicingStatus { get; set; }

		[DataMember(Name="servicingTransferDate")]
		public DateTime? ServicingTransferDate { get; set; }

		[DataMember(Name="subServicer")]
		public string SubServicer { get; set; }

		[DataMember(Name="subServicerLoanNumber")]
		public string SubServicerLoanNumber { get; set; }

		[DataMember(Name="totalAdditionalEscrow")]
		public decimal? TotalAdditionalEscrow { get; set; }

		[DataMember(Name="totalAdditionalEscrowYearToDate")]
		public decimal? TotalAdditionalEscrowYearToDate { get; set; }

		[DataMember(Name="totalAdditionalPrincipal")]
		public decimal? TotalAdditionalPrincipal { get; set; }

		[DataMember(Name="totalAdditionalPrincipalYearToDate")]
		public decimal? TotalAdditionalPrincipalYearToDate { get; set; }

		[DataMember(Name="totalAmountDisbursed")]
		public decimal? TotalAmountDisbursed { get; set; }

		[DataMember(Name="totalBuydownSubsidyAmount")]
		public decimal? TotalBuydownSubsidyAmount { get; set; }

		[DataMember(Name="totalBuydownSubsidyAmountYearToDate")]
		public decimal? TotalBuydownSubsidyAmountYearToDate { get; set; }

		[DataMember(Name="totalEscrow")]
		public decimal? TotalEscrow { get; set; }

		[DataMember(Name="totalEscrowYearToDate")]
		public decimal? TotalEscrowYearToDate { get; set; }

		[DataMember(Name="totalHazardInsurance")]
		public decimal? TotalHazardInsurance { get; set; }

		[DataMember(Name="totalInterest")]
		public decimal? TotalInterest { get; set; }

		[DataMember(Name="totalInterestYearToDate")]
		public decimal? TotalInterestYearToDate { get; set; }

		[DataMember(Name="totalLateFee")]
		public decimal? TotalLateFee { get; set; }

		[DataMember(Name="totalLateFeeYearToDate")]
		public decimal? TotalLateFeeYearToDate { get; set; }

		[DataMember(Name="totalMiscFee")]
		public decimal? TotalMiscFee { get; set; }

		[DataMember(Name="totalMiscFeeYearToDate")]
		public decimal? TotalMiscFeeYearToDate { get; set; }

		[DataMember(Name="totalMortgageInsurance")]
		public decimal? TotalMortgageInsurance { get; set; }

		[DataMember(Name="totalNumberOfLatePayment")]
		public int? TotalNumberOfLatePayment { get; set; }

		[DataMember(Name="totalNumberOfPayment")]
		public int? TotalNumberOfPayment { get; set; }

		[DataMember(Name="totalOtherTaxes")]
		public decimal? TotalOtherTaxes { get; set; }

		[DataMember(Name="totalPAndI")]
		public decimal? TotalPAndI { get; set; }

		[DataMember(Name="totalPAndIYearToDate")]
		public decimal? TotalPAndIYearToDate { get; set; }

		[DataMember(Name="totalPaymentCollected")]
		public decimal? TotalPaymentCollected { get; set; }

		[DataMember(Name="totalPaymentCollectedYearToDate")]
		public decimal? TotalPaymentCollectedYearToDate { get; set; }

		[DataMember(Name="totalPrincipal")]
		public decimal? TotalPrincipal { get; set; }

		[DataMember(Name="totalPrincipalYearToDate")]
		public decimal? TotalPrincipalYearToDate { get; set; }

		[DataMember(Name="totalTaxes")]
		public decimal? TotalTaxes { get; set; }

		[DataMember(Name="totalUsdaMonthlyPremium")]
		public decimal? TotalUsdaMonthlyPremium { get; set; }

		[DataMember(Name="unpaidBuydownSubsidyAmount")]
		public decimal? UnpaidBuydownSubsidyAmount { get; set; }

		[DataMember(Name="unpaidEscrow")]
		public decimal? UnpaidEscrow { get; set; }

		[DataMember(Name="unpaidEscrowCityPropertyTax")]
		public decimal? UnpaidEscrowCityPropertyTax { get; set; }

		[DataMember(Name="unpaidEscrowFloodInsurance")]
		public decimal? UnpaidEscrowFloodInsurance { get; set; }

		[DataMember(Name="unpaidEscrowHazardInsurance")]
		public decimal? UnpaidEscrowHazardInsurance { get; set; }

		[DataMember(Name="unpaidEscrowMortgageInsurance")]
		public decimal? UnpaidEscrowMortgageInsurance { get; set; }

		[DataMember(Name="unpaidEscrowOther1")]
		public decimal? UnpaidEscrowOther1 { get; set; }

		[DataMember(Name="unpaidEscrowOther2")]
		public decimal? UnpaidEscrowOther2 { get; set; }

		[DataMember(Name="unpaidEscrowOther3")]
		public decimal? UnpaidEscrowOther3 { get; set; }

		[DataMember(Name="unpaidEscrowTax")]
		public decimal? UnpaidEscrowTax { get; set; }

		[DataMember(Name="unpaidEscrowUSDAMonthlyPremium")]
		public decimal? UnpaidEscrowUSDAMonthlyPremium { get; set; }

		[DataMember(Name="unpaidInterest")]
		public decimal? UnpaidInterest { get; set; }

		[DataMember(Name="unpaidLateFee")]
		public decimal? UnpaidLateFee { get; set; }

		[DataMember(Name="unpaidMiscrFee")]
		public decimal? UnpaidMiscrFee { get; set; }

		[DataMember(Name="unpaidPrincipal")]
		public decimal? UnpaidPrincipal { get; set; }

	}
}