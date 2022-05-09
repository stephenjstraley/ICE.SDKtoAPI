using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostClosingDisclosure1
	{
		[DataMember(Name="cDDateIssued", EmitDefaultValue=false)]
		public DateTime? CDDateIssued { get; set; }

		[DataMember(Name="changedCircumstance", EmitDefaultValue=false)]
		public string ChangedCircumstance { get; set; }

		[DataMember(Name="changedCircumstanceFlag", EmitDefaultValue=false)]
		public bool? ChangedCircumstanceFlag { get; set; }

		[DataMember(Name="changesReceivedDate", EmitDefaultValue=false)]
		public DateTime? ChangesReceivedDate { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="disclosureBy", EmitDefaultValue=false)]
		public string DisclosureBy { get; set; }

		[DataMember(Name="disclosureComments", EmitDefaultValue=false)]
		public string DisclosureComments { get; set; }

		[DataMember(Name="disclosureLastSentDate", EmitDefaultValue=false)]
		public DateTime? DisclosureLastSentDate { get; set; }

		[DataMember(Name="disclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? DisclosureReceivedDate { get; set; }

		[DataMember(Name="disclosureSentMethod", EmitDefaultValue=false)]
		public string DisclosureSentMethod { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofAlternateCD", EmitDefaultValue=false)]
		public string DocumentGUIDFinalExecutedCopyofAlternateCD { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofSellerCD", EmitDefaultValue=false)]
		public string DocumentGUIDFinalExecutedCopyofSellerCD { get; set; }

		[DataMember(Name="documentGUIDFinalExecutedCopyofStandardCD", EmitDefaultValue=false)]
		public string DocumentGUIDFinalExecutedCopyofStandardCD { get; set; }

		[DataMember(Name="estimatedTaxesInsuranceAssessments", EmitDefaultValue=false)]
		public double? EstimatedTaxesInsuranceAssessments { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="inEscrowHomeownerInsurance", EmitDefaultValue=false)]
		public string InEscrowHomeownerInsurance { get; set; }

		[DataMember(Name="inEscrowOther", EmitDefaultValue=false)]
		public string InEscrowOther { get; set; }

		[DataMember(Name="inEscrowPropertyTaxes", EmitDefaultValue=false)]
		public string InEscrowPropertyTaxes { get; set; }

		[DataMember(Name="mICReference", EmitDefaultValue=false)]
		public string MICReference { get; set; }

		[DataMember(Name="notNaturalPersonFlag", EmitDefaultValue=false)]
		public bool? NotNaturalPersonFlag { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmount", EmitDefaultValue=false)]
		public double? PPC1EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC1EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC1EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC1InterestOnly", EmitDefaultValue=false)]
		public bool? PPC1InterestOnly { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC1MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC1MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC1MaximumPIPayment { get; set; }

		[DataMember(Name="pPC1MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC1MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1MIAmount", EmitDefaultValue=false)]
		public double? PPC1MIAmount { get; set; }

		[DataMember(Name="pPC1MIAmountUI", EmitDefaultValue=false)]
		public string PPC1MIAmountUI { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC1MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC1MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC1MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC1MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC1MinimumPIPayment { get; set; }

		[DataMember(Name="pPC1MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC1MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC1Year", EmitDefaultValue=false)]
		public int? PPC1Year { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmount", EmitDefaultValue=false)]
		public double? PPC2EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC2EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC2EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC2InterestOnly", EmitDefaultValue=false)]
		public bool? PPC2InterestOnly { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC2MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC2MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC2MaximumPIPayment { get; set; }

		[DataMember(Name="pPC2MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC2MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2MIAmount", EmitDefaultValue=false)]
		public double? PPC2MIAmount { get; set; }

		[DataMember(Name="pPC2MIAmountUI", EmitDefaultValue=false)]
		public string PPC2MIAmountUI { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC2MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC2MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC2MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC2MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC2MinimumPIPayment { get; set; }

		[DataMember(Name="pPC2MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC2MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC2YearFrom", EmitDefaultValue=false)]
		public int? PPC2YearFrom { get; set; }

		[DataMember(Name="pPC2YearTo", EmitDefaultValue=false)]
		public int? PPC2YearTo { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmount", EmitDefaultValue=false)]
		public double? PPC3EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC3EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC3EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC3InterestOnly", EmitDefaultValue=false)]
		public bool? PPC3InterestOnly { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC3MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC3MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC3MaximumPIPayment { get; set; }

		[DataMember(Name="pPC3MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC3MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3MIAmount", EmitDefaultValue=false)]
		public double? PPC3MIAmount { get; set; }

		[DataMember(Name="pPC3MIAmountUI", EmitDefaultValue=false)]
		public string PPC3MIAmountUI { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC3MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC3MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC3MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC3MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC3MinimumPIPayment { get; set; }

		[DataMember(Name="pPC3MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC3MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC3YearFrom", EmitDefaultValue=false)]
		public int? PPC3YearFrom { get; set; }

		[DataMember(Name="pPC3YearTo", EmitDefaultValue=false)]
		public int? PPC3YearTo { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmount", EmitDefaultValue=false)]
		public double? PPC4EstimatedEscrowAmount { get; set; }

		[DataMember(Name="pPC4EstimatedEscrowAmountUI", EmitDefaultValue=false)]
		public string PPC4EstimatedEscrowAmountUI { get; set; }

		[DataMember(Name="pPC4InterestOnly", EmitDefaultValue=false)]
		public bool? PPC4InterestOnly { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC4MaximumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MaximumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC4MaximumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MaximumPIPayment", EmitDefaultValue=false)]
		public double? PPC4MaximumPIPayment { get; set; }

		[DataMember(Name="pPC4MaximumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC4MaximumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4MIAmount", EmitDefaultValue=false)]
		public double? PPC4MIAmount { get; set; }

		[DataMember(Name="pPC4MIAmountUI", EmitDefaultValue=false)]
		public string PPC4MIAmountUI { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPayment", EmitDefaultValue=false)]
		public double? PPC4MinimumMonthlyPayment { get; set; }

		[DataMember(Name="pPC4MinimumMonthlyPaymentUI", EmitDefaultValue=false)]
		public string PPC4MinimumMonthlyPaymentUI { get; set; }

		[DataMember(Name="pPC4MinimumPIPayment", EmitDefaultValue=false)]
		public double? PPC4MinimumPIPayment { get; set; }

		[DataMember(Name="pPC4MinimumPIPaymentUI", EmitDefaultValue=false)]
		public string PPC4MinimumPIPaymentUI { get; set; }

		[DataMember(Name="pPC4YearFrom", EmitDefaultValue=false)]
		public int? PPC4YearFrom { get; set; }

		[DataMember(Name="pPC4YearTo", EmitDefaultValue=false)]
		public int? PPC4YearTo { get; set; }

		[DataMember(Name="pPCEstimatedEscrowIndicator", EmitDefaultValue=false)]
		public bool? PPCEstimatedEscrowIndicator { get; set; }

		[DataMember(Name="pPCMortgageInsuranceIndicator", EmitDefaultValue=false)]
		public bool? PPCMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="rangePaymentIndicatorC1", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC1 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC2", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC2 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC3", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC3 { get; set; }

		[DataMember(Name="rangePaymentIndicatorC4", EmitDefaultValue=false)]
		public bool? RangePaymentIndicatorC4 { get; set; }

		[DataMember(Name="reasonAdvancedReview", EmitDefaultValue=false)]
		public bool? ReasonAdvancedReview { get; set; }

		[DataMember(Name="reasonChangedCircumstanceElg", EmitDefaultValue=false)]
		public bool? ReasonChangedCircumstanceElg { get; set; }

		[DataMember(Name="reasonChangedCircumstanceFlags", EmitDefaultValue=false)]
		public string ReasonChangedCircumstanceFlags { get; set; }

		[DataMember(Name="reasonChangeInAPR", EmitDefaultValue=false)]
		public bool? ReasonChangeInAPR { get; set; }

		[DataMember(Name="reasonChangeInLoanProduct", EmitDefaultValue=false)]
		public bool? ReasonChangeInLoanProduct { get; set; }

		[DataMember(Name="reasonChangeSettlementCharges", EmitDefaultValue=false)]
		public bool? ReasonChangeSettlementCharges { get; set; }

		[DataMember(Name="reasonClericalErrorCorrection", EmitDefaultValue=false)]
		public bool? ReasonClericalErrorCorrection { get; set; }

		[DataMember(Name="reasonInterestRatecharges", EmitDefaultValue=false)]
		public bool? ReasonInterestRatecharges { get; set; }

		[DataMember(Name="reasonOther", EmitDefaultValue=false)]
		public bool? ReasonOther { get; set; }

		[DataMember(Name="reasonOtherDescription", EmitDefaultValue=false)]
		public string ReasonOtherDescription { get; set; }

		[DataMember(Name="reasonPrepaymentPenalty", EmitDefaultValue=false)]
		public bool? ReasonPrepaymentPenalty { get; set; }

		[DataMember(Name="reasonRevisionsReqConsumer", EmitDefaultValue=false)]
		public bool? ReasonRevisionsReqConsumer { get; set; }

		[DataMember(Name="reasonToleranceCure", EmitDefaultValue=false)]
		public bool? ReasonToleranceCure { get; set; }

		[DataMember(Name="revisedCDDueDate", EmitDefaultValue=false)]
		public DateTime? RevisedCDDueDate { get; set; }

		[DataMember(Name="sellerNames", EmitDefaultValue=false)]
		public string SellerNames { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofAlternateCD", EmitDefaultValue=false)]
		public string SignatureTypeFinalExecutedCopyofAlternateCD { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofSellerCD", EmitDefaultValue=false)]
		public string SignatureTypeFinalExecutedCopyofSellerCD { get; set; }

		[DataMember(Name="signatureTypeFinalExecutedCopyofStandardCD", EmitDefaultValue=false)]
		public string SignatureTypeFinalExecutedCopyofStandardCD { get; set; }

		[DataMember(Name="totalCashToClose", EmitDefaultValue=false)]
		public double? TotalCashToClose { get; set; }

	}
}