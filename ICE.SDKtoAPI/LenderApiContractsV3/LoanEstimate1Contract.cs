using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanEstimate1Contract
    {
        [DataMember(Name = "rangePaymentIndicatorC1")]
        public bool? RangePaymentIndicatorC1 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC2")]
        public bool? RangePaymentIndicatorC2 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC3")]
        public bool? RangePaymentIndicatorC3 { get; set; }

        [DataMember(Name = "rangePaymentIndicatorC4")]
        public bool? RangePaymentIndicatorC4 { get; set; }

        [DataMember(Name = "leDateIssued")]
        public string LeDateIssued { get; set; }

        [DataMember(Name = "loanTermYears")]
        public int? LoanTermYears { get; set; }

        [DataMember(Name = "loanTermMonths")]
        public int? LoanTermMonths { get; set; }

        [DataMember(Name = "loanPurpose")]
        public string LoanPurpose { get; set; }

        [DataMember(Name = "loanProduct")]
        public string LoanProduct { get; set; }

        [DataMember(Name = "rateLockExpirationTime")]
        public string RateLockExpirationTime { get; set; }

        [DataMember(Name = "rateLockExpirationTimeZone")]
        public string RateLockExpirationTimeZone { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationTime")]
        public string ClosingCostEstimateExpirationTime { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationTimeZone")]
        public string ClosingCostEstimateExpirationTimeZone { get; set; }

        [DataMember(Name = "loanAmountCanGoGoes")]
        public string LoanAmountCanGoGoes { get; set; }

        [DataMember(Name = "loanAmountCanIncreaseOrIncreases")]
        public string LoanAmountCanIncreaseOrIncreases { get; set; }

        [DataMember(Name = "yearsToRecast")]
        public int? YearsToRecast { get; set; }

        [DataMember(Name = "interestRateAdjustsEveryYears")]
        public string InterestRateAdjustsEveryYears { get; set; }

        [DataMember(Name = "adjustsTermType")]
        public string AdjustsTermType { get; set; }

        [DataMember(Name = "interestRateAdjustsStartingInType")]
        public string InterestRateAdjustsStartingInType { get; set; }

        [DataMember(Name = "interestRateAfterAdjustment")]
        public int? InterestRateAfterAdjustment { get; set; }

        [DataMember(Name = "interestRateCanGoGoes")]
        public string InterestRateCanGoGoes { get; set; }

        [DataMember(Name = "interestRateAdjustsInYear")]
        public int? InterestRateAdjustsInYear { get; set; }

        [DataMember(Name = "monthlyPiAdjustsEveryYears")]
        public string MonthlyPiAdjustsEveryYears { get; set; }

        [DataMember(Name = "monthlyPiAdjustsTermType")]
        public string MonthlyPiAdjustsTermType { get; set; }

        [DataMember(Name = "monthlyPiAdjustsStartingInType")]
        public string MonthlyPiAdjustsStartingInType { get; set; }

        [DataMember(Name = "monthlyPiAfterAdjustment")]
        public int? MonthlyPiAfterAdjustment { get; set; }

        [DataMember(Name = "monthlyPiCanGoGoes")]
        public string MonthlyPiCanGoGoes { get; set; }

        [DataMember(Name = "highestMonthlyPi")]
        public decimal? HighestMonthlyPi { get; set; }

        [DataMember(Name = "monthlyPiAdjustsInYear")]
        public int? MonthlyPiAdjustsInYear { get; set; }

        [DataMember(Name = "monthlyPiInterestOnlyUntilYear")]
        public int? MonthlyPiInterestOnlyUntilYear { get; set; }

        [DataMember(Name = "prepaymentPenaltyPayOffDuringYear")]
        public int? PrepaymentPenaltyPayOffDuringYear { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationDate")]
        public string ClosingCostEstimateExpirationDate { get; set; }

        [DataMember(Name = "estimatedTaxesInsuranceAssessments")]
        public decimal? EstimatedTaxesInsuranceAssessments { get; set; }

        [DataMember(Name = "estimatedTaxesInsuranceAssessmentsUi")]
        public string EstimatedTaxesInsuranceAssessmentsUi { get; set; }

        [DataMember(Name = "inEscrowPropertyTaxes")]
        public string InEscrowPropertyTaxes { get; set; }

        [DataMember(Name = "inEscrowHomeownerInsurance")]
        public string InEscrowHomeownerInsurance { get; set; }

        [DataMember(Name = "inEscrowOther")]
        public string InEscrowOther { get; set; }

        [DataMember(Name = "disclosureLastSentDate")]
        public string DisclosureLastSentDate { get; set; }

        [DataMember(Name = "disclosureBy")]
        public string DisclosureBy { get; set; }

        [DataMember(Name = "disclosureSentMethod")]
        public string DisclosureSentMethod { get; set; }

        [DataMember(Name = "disclosureClosingCostExpDate")]
        public string DisclosureClosingCostExpDate { get; set; }

        [DataMember(Name = "disclosureClosingCostExpTime")]
        public string DisclosureClosingCostExpTime { get; set; }

        [DataMember(Name = "disclosureClosingCostExpTimeZone")]
        public string DisclosureClosingCostExpTimeZone { get; set; }

        [DataMember(Name = "disclosureReceivedDate")]
        public string DisclosureReceivedDate { get; set; }

        [DataMember(Name = "disclosureComments")]
        public string DisclosureComments { get; set; }

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
        public int? Ppc1MiAmount { get; set; }

        [DataMember(Name = "ppc1MiAmountUi")]
        public string Ppc1MiAmountUi { get; set; }

        [DataMember(Name = "ppc1EstimatedEscrowAmount")]
        public int? Ppc1EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc1EstimatedEscrowAmountUi")]
        public string Ppc1EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc1MinimumMonthlyPayment")]
        public int? Ppc1MinimumMonthlyPayment { get; set; }

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
        public int? Ppc2MiAmount { get; set; }

        [DataMember(Name = "ppc2MiAmountUi")]
        public string Ppc2MiAmountUi { get; set; }

        [DataMember(Name = "ppc2EstimatedEscrowAmount")]
        public int? Ppc2EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc2EstimatedEscrowAmountUi")]
        public string Ppc2EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc2MinimumMonthlyPayment")]
        public int? Ppc2MinimumMonthlyPayment { get; set; }

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
        public int? Ppc3MiAmount { get; set; }

        [DataMember(Name = "ppc3MiAmountUi")]
        public string Ppc3MiAmountUi { get; set; }

        [DataMember(Name = "ppc3EstimatedEscrowAmount")]
        public int? Ppc3EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc3EstimatedEscrowAmountUi")]
        public string Ppc3EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc3MinimumMonthlyPayment")]
        public int? Ppc3MinimumMonthlyPayment { get; set; }

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
        public int? Ppc4MiAmount { get; set; }

        [DataMember(Name = "ppc4MiAmountUi")]
        public string Ppc4MiAmountUi { get; set; }

        [DataMember(Name = "ppc4EstimatedEscrowAmount")]
        public int? Ppc4EstimatedEscrowAmount { get; set; }

        [DataMember(Name = "ppc4EstimatedEscrowAmountUi")]
        public string Ppc4EstimatedEscrowAmountUi { get; set; }

        [DataMember(Name = "ppc4MinimumMonthlyPayment")]
        public int? Ppc4MinimumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc4MinimumMonthlyPaymentUi")]
        public string Ppc4MinimumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppc4MaximumMonthlyPayment")]
        public decimal? Ppc4MaximumMonthlyPayment { get; set; }

        [DataMember(Name = "ppc4MaximumMonthlyPaymentUi")]
        public string Ppc4MaximumMonthlyPaymentUi { get; set; }

        [DataMember(Name = "ppestimatedEscrowIndicator")]
        public bool? PpestimatedEscrowIndicator { get; set; }

        [DataMember(Name = "reasonSettlementCharges")]
        public bool? ReasonSettlementCharges { get; set; }

        [DataMember(Name = "reasonEligibility")]
        public bool? ReasonEligibility { get; set; }

        [DataMember(Name = "reasonRevisions")]
        public bool? ReasonRevisions { get; set; }

        [DataMember(Name = "reasonInterestRate")]
        public bool? ReasonInterestRate { get; set; }

        [DataMember(Name = "reasonExpiration")]
        public bool? ReasonExpiration { get; set; }

        [DataMember(Name = "reasonDelayedSettlement")]
        public bool? ReasonDelayedSettlement { get; set; }

        [DataMember(Name = "reasonOther")]
        public bool? ReasonOther { get; set; }

        [DataMember(Name = "reasonOtherDescription")]
        public string ReasonOtherDescription { get; set; }

        [DataMember(Name = "changedCircumstanceComments")]
        public string ChangedCircumstanceComments { get; set; }

        [DataMember(Name = "totalEstimatedCashClose")]
        public decimal? TotalEstimatedCashClose { get; set; }

        [DataMember(Name = "monthlyPiAdjustedInDateType")]
        public string MonthlyPiAdjustedInDateType { get; set; }

        [DataMember(Name = "monthlyPiInterestOnlyDateType")]
        public string MonthlyPiInterestOnlyDateType { get; set; }

        [DataMember(Name = "reasonChangedCircumstanceFlags")]
        public string ReasonChangedCircumstanceFlags { get; set; }

        [DataMember(Name = "prepaymentPenaltyPayOffInDateType")]
        public string PrepaymentPenaltyPayOffInDateType { get; set; }

        [DataMember(Name = "prepaymentPenaltyPayOffInFirstYear")]
        public string PrepaymentPenaltyPayOffInFirstYear { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationTimeUi")]
        public string ClosingCostEstimateExpirationTimeUi { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationTimeZoneUi")]
        public string ClosingCostEstimateExpirationTimeZoneUi { get; set; }

        [DataMember(Name = "closingCostEstimateExpirationDateUi")]
        public string ClosingCostEstimateExpirationDateUi { get; set; }

        [DataMember(Name = "initialMonthlyPaymentFor10000Loan")]
        public decimal? InitialMonthlyPaymentFor10000Loan { get; set; }

        [DataMember(Name = "maximumMonthlyPaymentFor10000Loan")]
        public decimal? MaximumMonthlyPaymentFor10000Loan { get; set; }

        [DataMember(Name = "maximumPaymentMonth")]
        public int? MaximumPaymentMonth { get; set; }

        [DataMember(Name = "initialMonthlyPaymentFor60000Loan")]
        public decimal? InitialMonthlyPaymentFor60000Loan { get; set; }

        [DataMember(Name = "conversionBegin")]
        public string ConversionBegin { get; set; }

        [DataMember(Name = "conversionEnd")]
        public string ConversionEnd { get; set; }

        [DataMember(Name = "balloonPaymentDueInTermLabel")]
        public string BalloonPaymentDueInTermLabel { get; set; }

        [DataMember(Name = "interestRateAdjTermLabel")]
        public string InterestRateAdjTermLabel { get; set; }

        [DataMember(Name = "expirationGenericTimeZone")]
        public string ExpirationGenericTimeZone { get; set; }

    }
}
