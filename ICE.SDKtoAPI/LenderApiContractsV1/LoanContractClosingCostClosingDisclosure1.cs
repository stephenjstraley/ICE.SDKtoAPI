using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure1
	{
		[DataMember(Name="cDDateIssued")]
		public DateTime? CDDateIssued { get; set; }

		[DataMember(Name="changedCircumstance")]
		public string ChangedCircumstance { get; set; }

		[DataMember(Name="changedCircumstanceFlag")]
		public bool? ChangedCircumstanceFlag { get; set; }

		[DataMember(Name="changesReceivedDate")]
		public DateTime? ChangesReceivedDate { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="disclosureBy")]
		public string DisclosureBy { get; set; }

		[DataMember(Name="disclosureComments")]
		public string DisclosureComments { get; set; }

		[DataMember(Name="disclosureLastSentDate")]
		public DateTime? DisclosureLastSentDate { get; set; }

		[DataMember(Name="disclosureReceivedDate")]
		public DateTime? DisclosureReceivedDate { get; set; }

		[DataMember(Name="disclosureSentMethod")]
		public string DisclosureSentMethod { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofAlternateCD")]
		public string DocumentGUIDFinalExecutedCopyofAlternateCD { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofSellerCD")]
		public string DocumentGUIDFinalExecutedCopyofSellerCD { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofStandardCD")]
		public string DocumentGUIDFinalExecutedCopyofStandardCD { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessments")]
		public decimal? EstimatedTaxesInsuranceAssessments { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="inEscrowHomeownerInsurance")]
		public string InEscrowHomeownerInsurance { get; set; }

		[DataMember(Name="inEscrowOther")]
		public string InEscrowOther { get; set; }

		[DataMember(Name="inEscrowPropertyTaxes")]
		public string InEscrowPropertyTaxes { get; set; }

		[DataMember(Name="mICReference")]
		public string MICReference { get; set; }

		[DataMember(Name="notNaturalPersonFlag")]
		public bool? NotNaturalPersonFlag { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmount")]
		public decimal? PPC1EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmountUI")]
		public string PPC1EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC1InterestOnly")]
		public bool? PPC1InterestOnly { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPayment")]
		public decimal? PPC1MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPaymentUI")]
		public string PPC1MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MaximumPIPayment")]
		public decimal? PPC1MaximumPIPayment { get; set; }

		[DataMember(Name="pPC1MaximumPIPaymentUI")]
		public string PPC1MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1MIAmount")]
		public decimal? PPC1MIAmount { get; set; }

		[DataMember(Name="pPC1MIAmountUI")]
		public string PPC1MIAmountUI { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPayment")]
		public decimal? PPC1MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPaymentUI")]
		public string PPC1MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MinimumPIPayment")]
		public decimal? PPC1MinimumPIPayment { get; set; }

		[DataMember(Name="pPC1MinimumPIPaymentUI")]
		public string PPC1MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1Year")]
		public int? PPC1Year { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmount")]
		public decimal? PPC2EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmountUI")]
		public string PPC2EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC2InterestOnly")]
		public bool? PPC2InterestOnly { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPayment")]
		public decimal? PPC2MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPaymentUI")]
		public string PPC2MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MaximumPIPayment")]
		public decimal? PPC2MaximumPIPayment { get; set; }

		[DataMember(Name="pPC2MaximumPIPaymentUI")]
		public string PPC2MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2MIAmount")]
		public decimal? PPC2MIAmount { get; set; }

		[DataMember(Name="pPC2MIAmountUI")]
		public string PPC2MIAmountUI { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPayment")]
		public decimal? PPC2MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPaymentUI")]
		public string PPC2MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MinimumPIPayment")]
		public decimal? PPC2MinimumPIPayment { get; set; }

		[DataMember(Name="pPC2MinimumPIPaymentUI")]
		public string PPC2MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2YearFrom")]
		public int? PPC2YearFrom { get; set; }

		[DataMember(Name="pPC2YearTo")]
		public int? PPC2YearTo { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmount")]
		public decimal? PPC3EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmountUI")]
		public string PPC3EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC3InterestOnly")]
		public bool? PPC3InterestOnly { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPayment")]
		public decimal? PPC3MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPaymentUI")]
		public string PPC3MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MaximumPIPayment")]
		public decimal? PPC3MaximumPIPayment { get; set; }

		[DataMember(Name="pPC3MaximumPIPaymentUI")]
		public string PPC3MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3MIAmount")]
		public decimal? PPC3MIAmount { get; set; }

		[DataMember(Name="pPC3MIAmountUI")]
		public string PPC3MIAmountUI { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPayment")]
		public decimal? PPC3MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPaymentUI")]
		public string PPC3MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MinimumPIPayment")]
		public decimal? PPC3MinimumPIPayment { get; set; }

		[DataMember(Name="pPC3MinimumPIPaymentUI")]
		public string PPC3MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3YearFrom")]
		public int? PPC3YearFrom { get; set; }

		[DataMember(Name="pPC3YearTo")]
		public int? PPC3YearTo { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmount")]
		public decimal? PPC4EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmountUI")]
		public string PPC4EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC4InterestOnly")]
		public bool? PPC4InterestOnly { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPayment")]
		public decimal? PPC4MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPaymentUI")]
		public string PPC4MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MaximumPIPayment")]
		public decimal? PPC4MaximumPIPayment { get; set; }

		[DataMember(Name="pPC4MaximumPIPaymentUI")]
		public string PPC4MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4MIAmount")]
		public decimal? PPC4MIAmount { get; set; }

		[DataMember(Name="pPC4MIAmountUI")]
		public string PPC4MIAmountUI { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPayment")]
		public decimal? PPC4MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPaymentUI")]
		public string PPC4MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MinimumPIPayment")]
		public decimal? PPC4MinimumPIPayment { get; set; }

		[DataMember(Name="pPC4MinimumPIPaymentUI")]
		public string PPC4MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4YearFrom")]
		public int? PPC4YearFrom { get; set; }

		[DataMember(Name="pPC4YearTo")]
		public int? PPC4YearTo { get; set; }

		[DataMember(Name="pPCEstimatedEscrowIndicator")]
		public bool? PPCEstimatedEscrowIndicator { get; set; }

		[DataMember(Name="pPCMortgageInsuranceIndicator")]
		public bool? PPCMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="rangePaymentIndicatorC1")]
		public bool? RangePaymentIndicatorC1 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC2")]
		public bool? RangePaymentIndicatorC2 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC3")]
		public bool? RangePaymentIndicatorC3 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC4")]
		public bool? RangePaymentIndicatorC4 { get; set; }

		[DataMember(Name="reasonAdvancedReview")]
		public bool? ReasonAdvancedReview { get; set; }

		[DataMember(Name="reasonChangedCircumstanceElg")]
		public bool? ReasonChangedCircumstanceElg { get; set; }

		[DataMember(Name="reasonChangedCircumstanceFlags")]
		public string ReasonChangedCircumstanceFlags { get; set; }

		[DataMember(Name="reasonChangeInAPR")]
		public bool? ReasonChangeInAPR { get; set; }

		[DataMember(Name="reasonChangeInLoanProduct")]
		public bool? ReasonChangeInLoanProduct { get; set; }

		[DataMember(Name="reasonChangeSettlementCharges")]
		public bool? ReasonChangeSettlementCharges { get; set; }

		[DataMember(Name="reasonClericalErrorCorrection")]
		public bool? ReasonClericalErrorCorrection { get; set; }

		[DataMember(Name="reasonInterestRatecharges")]
		public bool? ReasonInterestRatecharges { get; set; }

		[DataMember(Name="reasonOther")]
		public bool? ReasonOther { get; set; }

		[DataMember(Name="reasonOtherDescription")]
		public string ReasonOtherDescription { get; set; }

		[DataMember(Name="reasonPrepaymentPenalty")]
		public bool? ReasonPrepaymentPenalty { get; set; }

		[DataMember(Name="reasonRevisionsReqConsumer")]
		public bool? ReasonRevisionsReqConsumer { get; set; }

		[DataMember(Name="reasonToleranceCure")]
		public bool? ReasonToleranceCure { get; set; }

		[DataMember(Name="revisedCDDueDate")]
		public DateTime? RevisedCDDueDate { get; set; }

		[DataMember(Name="sellerNames")]
		public string SellerNames { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofAlternateCD")]
		public string SignatureTypeFinalExecutedCopyofAlternateCD { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofSellerCD")]
		public string SignatureTypeFinalExecutedCopyofSellerCD { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofStandardCD")]
		public string SignatureTypeFinalExecutedCopyofStandardCD { get; set; }

		[DataMember(Name="totalCashToClose")]
		public decimal? TotalCashToClose { get; set; }

	}
}