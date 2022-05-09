using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingDisclosure1Contract
    {
        [DataMember(Name = "rangePaymentIndicatorC1")]
        public bool? RangePaymentIndicatorC1 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC2")]
        public bool? RangePaymentIndicatorC2 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC3")]
        public bool? RangePaymentIndicatorC3 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC4")]
        public bool? RangePaymentIndicatorC4 { get; set; }

        [DataMember(Name = "cdDateIssued")]
        public string CdDateIssued { get; set; }

        [DataMember(Name = "sellerNames")]
        public string SellerNames { get; set; }

        [DataMember(Name = "estimatedTaxesInsuranceAssessments")]
        public decimal? EstimatedTaxesInsuranceAssessments { get; set; }

        [DataMember(Name = "inEscrowPropertyTaxes")]
        public string InEscrowPropertyTaxes { get; set; }

        [DataMember(Name = "inEscrowHomeownerInsurance")]
        public string InEscrowHomeownerInsurance { get; set; }

        [DataMember(Name = "inEscrowOther")]
        public string InEscrowOther { get; set; }

        [DataMember(Name = "ppc1Year")]
        public int? Ppc1Year { get; set; }

        [DataMember(Name = "ppc1MinimumPiPayment")]
        public decimal? Ppc1MinimumPiPayment { get; set; }

        [DataMember(Name = "ppc1MinimumPiPaymentUi")]
        public string Ppc1MinimumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc1MaximumPiPayment")]
        public decimal? Ppc1MaximumPiPayment { get; set; }

        [DataMember(Name = "ppc1MaximumPiPaymentUi")]
        public string Ppc1MaximumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc1InterestOnly")]
        public bool? Ppc1InterestOnly { get; set; }

        [DataMember(Name = "ppc1MiAmount")]
        public decimal? Ppc1MiAmount { get; set; }

        [DataMember(Name = "ppc1EstimatedEscrowAmount")]
        public decimal? Ppc1EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc1MinimumMonthlyPayment")]
        public decimal? Ppc1MinimumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc1MinimumMonthlyPaymentUi")]
        public string Ppc1MinimumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc1MaximumMonthlyPayment")]
        public decimal? Ppc1MaximumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc1MaximumMonthlyPaymentUi")]
        public string Ppc1MaximumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc2YearFrom")]
        public int? Ppc2YearFrom { get; set; }

        [DataMember(Name = "ppc2YearTo")]
        public int? Ppc2YearTo { get; set; }

        [DataMember(Name = "ppc2MinimumPiPayment")]
        public decimal? Ppc2MinimumPiPayment { get; set; }

        [DataMember(Name = "ppc2MinimumPiPaymentUi")]
        public string Ppc2MinimumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc2MaximumPiPayment")]
        public decimal? Ppc2MaximumPiPayment { get; set; }

        [DataMember(Name = "ppc2MaximumPiPaymentUi")]
        public string Ppc2MaximumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc2InterestOnly")]
        public bool? Ppc2InterestOnly { get; set; }

        [DataMember(Name = "ppc2MiAmount")]
        public decimal? Ppc2MiAmount { get; set; }

        [DataMember(Name = "ppc2EstimatedEscrowAmount")]
        public decimal? Ppc2EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc2MinimumMonthlyPayment")]
        public decimal? Ppc2MinimumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc2MinimumMonthlyPaymentUi")]
        public string Ppc2MinimumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc2MaximumMonthlyPayment")]
        public decimal? Ppc2MaximumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc2MaximumMonthlyPaymentUi")]
        public string Ppc2MaximumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc3YearFrom")]
        public int? Ppc3YearFrom { get; set; }

        [DataMember(Name = "ppc3YearTo")]
        public int? Ppc3YearTo { get; set; }

        [DataMember(Name = "ppc3MinimumPiPayment")]
        public decimal? Ppc3MinimumPiPayment { get; set; }

        [DataMember(Name = "ppc3MinimumPiPaymentUi")]
        public string Ppc3MinimumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc3MaximumPiPayment")]
        public decimal? Ppc3MaximumPiPayment { get; set; }

        [DataMember(Name = "ppc3MaximumPiPaymentUi")]
        public string Ppc3MaximumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc3InterestOnly")]
        public bool? Ppc3InterestOnly { get; set; }

        [DataMember(Name = "ppc3MiAmount")]
        public decimal? Ppc3MiAmount { get; set; }

        [DataMember(Name = "ppc3EstimatedEscrowAmount")]
        public decimal? Ppc3EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc3MinimumMonthlyPayment")]
        public decimal? Ppc3MinimumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc3MinimumMonthlyPaymentUi")]
        public string Ppc3MinimumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc3MaximumMonthlyPayment")]
        public decimal? Ppc3MaximumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc3MaximumMonthlyPaymentUi")]
        public string Ppc3MaximumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc4YearFrom")]
        public int? Ppc4YearFrom { get; set; }

        [DataMember(Name = "ppc4YearTo")]
        public int? Ppc4YearTo { get; set; }

        [DataMember(Name = "ppc4MinimumPiPayment")]
        public decimal? Ppc4MinimumPiPayment { get; set; }

        [DataMember(Name = "ppc4MinimumPiPaymentUi")]
        public string Ppc4MinimumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc4MaximumPiPayment")]
        public decimal? Ppc4MaximumPiPayment { get; set; }

        [DataMember(Name = "ppc4MaximumPiPaymentUi")]
        public string Ppc4MaximumPiPaymentUi { get; set; }

        [DataMember(Name = "ppc4InterestOnly")]
        public bool? Ppc4InterestOnly { get; set; }

        [DataMember(Name = "ppc4MiAmount")]
        public decimal? Ppc4MiAmount { get; set; }

        [DataMember(Name = "ppc4EstimatedEscrowAmount")]
        public decimal? Ppc4EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc4MinimumMonthlyPayment")]
        public decimal? Ppc4MinimumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc4MinimumMonthlyPaymentUi")]
        public string Ppc4MinimumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc4MaximumMonthlyPayment")]
        public decimal? Ppc4MaximumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc4MaximumMonthlyPaymentUi")]
        public string Ppc4MaximumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppcMortgageInsuranceIndicator")]
        public bool? PpcMortgageInsuranceIndicator { get; set; }

        [DataMember(Name = "ppcEstimatedEscrowIndicator")]
        public bool? PpcEstimatedEscrowIndicator { get; set; }

        [DataMember(Name = "disclosureLastSentDate")]
        public string DisclosureLastSentDate { get; set; }

        [DataMember(Name = "disclosureBy")]
        public string DisclosureBy { get; set; }

        [DataMember(Name = "disclosureSentMethod")]
        public string DisclosureSentMethod { get; set; }

        [DataMember(Name = "disclosureComments")]
        public string DisclosureComments { get; set; }

        [DataMember(Name = "disclosureReceivedDate")]
        public string DisclosureReceivedDate { get; set; }

        [DataMember(Name = "reasonChangeInApr")]
        public bool? ReasonChangeInApr { get; set; }

        [DataMember(Name = "reasonChangeInLoanProduct")]
        public bool? ReasonChangeInLoanProduct { get; set; }

        [DataMember(Name = "reasonPrepaymentPenalty")]
        public bool? ReasonPrepaymentPenalty { get; set; }

        [DataMember(Name = "reasonChangeSettlementCharges")]
        public bool? ReasonChangeSettlementCharges { get; set; }

        [DataMember(Name = "reasonAdvancedReview")]
        public bool? ReasonAdvancedReview { get; set; }

        [DataMember(Name = "reasonToleranceCure")]
        public bool? ReasonToleranceCure { get; set; }

        [DataMember(Name = "reasonClericalErrorCorrection")]
        public bool? ReasonClericalErrorCorrection { get; set; }

        [DataMember(Name = "reasonOther")]
        public bool? ReasonOther { get; set; }

        [DataMember(Name = "reasonOtherDescription")]
        public string ReasonOtherDescription { get; set; }

        [DataMember(Name = "changedCircumstanceFlag")]
        public bool? ChangedCircumstanceFlag { get; set; }

        [DataMember(Name = "changesReceivedDate")]
        public string ChangesReceivedDate { get; set; }

        [DataMember(Name = "revisedCdDueDate")]
        public string RevisedCdDueDate { get; set; }

        [DataMember(Name = "changedCircumstance")]
        public string ChangedCircumstance { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "reasonChangedCircumstanceElg")]
        public bool? ReasonChangedCircumstanceElg { get; set; }

        [DataMember(Name = "totalCashToClose")]
        public decimal? TotalCashToClose { get; set; }

        [DataMember(Name = "reasonChangedCircumstanceFlags")]
        public string ReasonChangedCircumstanceFlags { get; set; }

        [DataMember(Name = "ppc1MiAmountUi")]
        public string Ppc1MiAmountUi { get; set; }

        [DataMember(Name = "ppc1EstimatedEscrowAmountUi")]
        public string Ppc1EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc2MiAmountUi")]
        public string Ppc2MiAmountUi { get; set; }

        [DataMember(Name = "ppc2EstimatedEscrowAmountUi")]
        public string Ppc2EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc3MiAmountUi")]
        public string Ppc3MiAmountUi { get; set; }

        [DataMember(Name = "ppc3EstimatedEscrowAmountUi")]
        public string Ppc3EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc4MiAmountUi")]
        public string Ppc4MiAmountUi { get; set; }

        [DataMember(Name = "ppc4EstimatedEscrowAmountUi")]
        public string Ppc4EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "micReference")]
        public string MicReference { get; set; }

        [DataMember(Name = "notNaturalPersonFlag")]
        public bool? NotNaturalPersonFlag { get; set; }

        [DataMember(Name = "documentGuidFinalExecutedCopyofStandardCd")]
        public string DocumentGuidFinalExecutedCopyofStandardCd { get; set; }

        [DataMember(Name = "signatureTypeFinalExecutedCopyofStandardCd")]
        public string SignatureTypeFinalExecutedCopyofStandardCd { get; set; }

        [DataMember(Name = "documentGuidFinalExecutedCopyofAlternateCd")]
        public string DocumentGuidFinalExecutedCopyofAlternateCd { get; set; }

        [DataMember(Name = "signatureTypeFinalExecutedCopyofAlternateCd")]
        public string SignatureTypeFinalExecutedCopyofAlternateCd { get; set; }

        [DataMember(Name = "documentGuidFinalExecutedCopyofSellerCd")]
        public string DocumentGuidFinalExecutedCopyofSellerCd { get; set; }

        [DataMember(Name = "signatureTypeFinalExecutedCopyofSellerCd")]
        public string SignatureTypeFinalExecutedCopyofSellerCd { get; set; }

        [DataMember(Name = "initialReceivedDate")]
        public string InitialReceivedDate { get; set; }

        [DataMember(Name = "revisedReceivedDate")]
        public string RevisedReceivedDate { get; set; }


    }
}
