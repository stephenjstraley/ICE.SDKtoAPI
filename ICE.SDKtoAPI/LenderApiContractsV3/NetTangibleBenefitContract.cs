using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class NetTangibleBenefitContract
    {
        [DataMember(Name = "aprNotExceedIndicator")]
        public bool? AprNotExceedIndicator { get; set; }

        [DataMember(Name = "avoidingForeclosureIndicator")]
        public bool? AvoidingForeclosureIndicator { get; set; }

        [DataMember(Name = "beneficialChangedForBorrowerIndicator")]
        public bool? BeneficialChangedForBorrowerIndicator { get; set; }

        [DataMember(Name = "bonaFideFinancialEmergency")]
        public string BonaFideFinancialEmergency { get; set; }

        [DataMember(Name = "borrowerCanRecoupCostofRefinancingIndicator")]
        public bool? BorrowerCanRecoupCostofRefinancingIndicator { get; set; }

        [DataMember(Name = "borrowerCanRecoupIndicator")]
        public bool? BorrowerCanRecoupIndicator { get; set; }

        [DataMember(Name = "borrowerMonthlyPaymentLowerThan20Indicator")]
        public bool? BorrowerMonthlyPaymentLowerThan20Indicator { get; set; }

        [DataMember(Name = "borrowerReceivedReasonable")]
        public string BorrowerReceivedReasonable { get; set; }

        [DataMember(Name = "borrowerReceivesAmountExcessCostAndFeesIndicator")]
        public bool? BorrowerReceivesAmountExcessCostAndFeesIndicator { get; set; }

        [DataMember(Name = "changeLoanFromArmtoFixedIndicator")]
        public bool? ChangeLoanFromArmtoFixedIndicator { get; set; }

        [DataMember(Name = "changingLoanToFixedRateIndicator")]
        public bool? ChangingLoanToFixedRateIndicator { get; set; }

        [DataMember(Name = "consolidatingOtherExistingLoansIntoNewLoanIndicator")]
        public bool? ConsolidatingOtherExistingLoansIntoNewLoanIndicator { get; set; }

        [DataMember(Name = "eliminatingBalloonPaymentIndicator")]
        public bool? EliminatingBalloonPaymentIndicator { get; set; }

        [DataMember(Name = "eliminatingNegArmIndicator")]
        public bool? EliminatingNegArmIndicator { get; set; }

        [DataMember(Name = "eliminatingPrivateMortgageInsuranceIndicator")]
        public bool? EliminatingPrivateMortgageInsuranceIndicator { get; set; }

        [DataMember(Name = "existingLoanAprPercent")]
        public decimal? ExistingLoanAprPercent { get; set; }

        [DataMember(Name = "existingLoanBalloonIndicator")]
        public bool? ExistingLoanBalloonIndicator { get; set; }

        [DataMember(Name = "existingLoanBorrowerReceivesCashOutAmount")]
        public decimal? ExistingLoanBorrowerReceivesCashOutAmount { get; set; }

        [DataMember(Name = "existingLoanBorrowerReceivesCashOutIndicator")]
        public bool? ExistingLoanBorrowerReceivesCashOutIndicator { get; set; }

        [DataMember(Name = "existingLoanBottomRatioPercent")]
        public decimal? ExistingLoanBottomRatioPercent { get; set; }

        [DataMember(Name = "existingLoanDateLoanClosed")]
        public string ExistingLoanDateLoanClosed { get; set; }

        [DataMember(Name = "existingLoanFullyIndexRatePercent")]
        public decimal? ExistingLoanFullyIndexRatePercent { get; set; }

        [DataMember(Name = "existingLoanInterestRatePercent")]
        public decimal? ExistingLoanInterestRatePercent { get; set; }

        [DataMember(Name = "existingLoanIsGuaranteedIndicator")]
        public bool? ExistingLoanIsGuaranteedIndicator { get; set; }

        [DataMember(Name = "existingLoanIsLoanRefinancedAsSpecial")]
        public bool? ExistingLoanIsLoanRefinancedAsSpecial { get; set; }

        [DataMember(Name = "existingLoanIsNegativeAmortizationFeatureIndicator")]
        public bool? ExistingLoanIsNegativeAmortizationFeatureIndicator { get; set; }

        [DataMember(Name = "existingLoanIsPrepaymentPenalty")]
        public bool? ExistingLoanIsPrepaymentPenalty { get; set; }

        [DataMember(Name = "existingLoanLoanAmortizationType")]
        public string ExistingLoanLoanAmortizationType { get; set; }

        [DataMember(Name = "existingLoanLoanAmount")]
        public decimal? ExistingLoanLoanAmount { get; set; }

        [DataMember(Name = "existingLoanLoanTerm")]
        public int? ExistingLoanLoanTerm { get; set; }

        [DataMember(Name = "existingLoanLtvPercent")]
        public decimal? ExistingLoanLtvPercent { get; set; }

        [DataMember(Name = "existingLoanMaximumRatePercent")]
        public decimal? ExistingLoanMaximumRatePercent { get; set; }

        [DataMember(Name = "existingLoanMonthsRemaining")]
        public int? ExistingLoanMonthsRemaining { get; set; }

        [DataMember(Name = "existingLoanPaymentAmount")]
        public decimal? ExistingLoanPaymentAmount { get; set; }

        [DataMember(Name = "existingLoanPaymentDifference")]
        public decimal? ExistingLoanPaymentDifference { get; set; }

        [DataMember(Name = "existingLoanPaymentIncludeMiObligation")]
        public decimal? ExistingLoanPaymentIncludeMiObligation { get; set; }

        [DataMember(Name = "existingLoanPaymentIncludeMortgageInsurance")]
        public decimal? ExistingLoanPaymentIncludeMortgageInsurance { get; set; }

        [DataMember(Name = "existingLoanPrepaymentPenaltyAmountIncludedInNewLoan")]
        public decimal? ExistingLoanPrepaymentPenaltyAmountIncludedInNewLoan { get; set; }

        [DataMember(Name = "existingLoanPrepaymentPenaltyBasedOn")]
        public string ExistingLoanPrepaymentPenaltyBasedOn { get; set; }

        [DataMember(Name = "existingLoanPrepaymentPenaltyPercentage")]
        public decimal? ExistingLoanPrepaymentPenaltyPercentage { get; set; }

        [DataMember(Name = "existingLoanPrepaymentPenaltyTerm")]
        public int? ExistingLoanPrepaymentPenaltyTerm { get; set; }

        [DataMember(Name = "existingLoanProvidedByLicenseeType")]
        public string ExistingLoanProvidedByLicenseeType { get; set; }

        [DataMember(Name = "existingLoanPurposeType")]
        public string ExistingLoanPurposeType { get; set; }

        [DataMember(Name = "existingLoanRecoupCostsYears")]
        public int? ExistingLoanRecoupCostsYears { get; set; }

        [DataMember(Name = "existingLoanSavingsAmount")]
        public decimal? ExistingLoanSavingsAmount { get; set; }

        [DataMember(Name = "existingLoanTotalDebtPayoff")]
        public decimal? ExistingLoanTotalDebtPayoff { get; set; }

        [DataMember(Name = "existingLoanWeightedAverageInterestRatePercent")]
        public decimal? ExistingLoanWeightedAverageInterestRatePercent { get; set; }

        [DataMember(Name = "homeLoanComplianceWith209")]
        public bool? HomeLoanComplianceWith209 { get; set; }

        [DataMember(Name = "lenderDeterminedBorrowersInterest")]
        public bool? LenderDeterminedBorrowersInterest { get; set; }

        [DataMember(Name = "newLoanIsGuaranteedIndicator")]
        public bool? NewLoanIsGuaranteedIndicator { get; set; }

        [DataMember(Name = "newLoanIsNegativeAmortizationFeatureIndicator")]
        public bool? NewLoanIsNegativeAmortizationFeatureIndicator { get; set; }

        [DataMember(Name = "newLoanIsSpecialMortgageOriginatedIndicator")]
        public bool? NewLoanIsSpecialMortgageOriginatedIndicator { get; set; }

        [DataMember(Name = "newLoanPaymentWithMiDifference")]
        public decimal? NewLoanPaymentWithMiDifference { get; set; }

        [DataMember(Name = "newLoanPaymentWithObligationDifference")]
        public decimal? NewLoanPaymentWithObligationDifference { get; set; }

        [DataMember(Name = "newLoanPayOffConsolidateDebtIndicator")]
        public bool? NewLoanPayOffConsolidateDebtIndicator { get; set; }

        [DataMember(Name = "newLoanWeightedAverageInterestRatePercent")]
        public decimal? NewLoanWeightedAverageInterestRatePercent { get; set; }

        [DataMember(Name = "obtainingLowerIntMonthlyPaymentIndicator")]
        public bool? ObtainingLowerIntMonthlyPaymentIndicator { get; set; }

        [DataMember(Name = "obtainingLowerIntRateIndicator")]
        public bool? ObtainingLowerIntRateIndicator { get; set; }

        [DataMember(Name = "obtainingShortAmortScheduleIndicator")]
        public bool? ObtainingShortAmortScheduleIndicator { get; set; }

        [DataMember(Name = "otherReason")]
        public bool? OtherReason { get; set; }

        [DataMember(Name = "otherReasonDescription")]
        public string OtherReasonDescription { get; set; }

        [DataMember(Name = "printBorrowerInitialLinesIndicator")]
        public bool? PrintBorrowerInitialLinesIndicator { get; set; }

        [DataMember(Name = "proceedsOfNewLoanWillBeUsedIndicator")]
        public bool? ProceedsOfNewLoanWillBeUsedIndicator { get; set; }

        [DataMember(Name = "receivingCashOutFromNewLoanGreaterThanClosingCostIndicator")]
        public bool? ReceivingCashOutFromNewLoanGreaterThanClosingCostIndicator { get; set; }

        [DataMember(Name = "refinancingLoanIsHomeEquityIndicator")]
        public bool? RefinancingLoanIsHomeEquityIndicator { get; set; }

        [DataMember(Name = "refinancingRespondBonaFide")]
        public bool? RefinancingRespondBonaFide { get; set; }

        [DataMember(Name = "newLoanIsSafeHarborQm")]
        public bool? NewLoanIsSafeHarborQm { get; set; }

        [DataMember(Name = "vaTermShorterThanRefinancedLoanIndicator")]
        public bool? VaTermShorterThanRefinancedLoanIndicator { get; set; }

        [DataMember(Name = "vaBorrowerIncomeIncreasedIndicator")]
        public bool? VaBorrowerIncomeIncreasedIndicator { get; set; }

        [DataMember(Name = "vaNewLoanAlterPrimaryHomeIndicator")]
        public bool? VaNewLoanAlterPrimaryHomeIndicator { get; set; }

        [DataMember(Name = "vaNewLoanEqualorLess90Indicator")]
        public bool? VaNewLoanEqualorLess90Indicator { get; set; }

    }
}
