using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CorrespondentContract
    {
        [DataMember(Name = "correspondentStatus")]
        public string CorrespondentStatus { get; set; }

        [DataMember(Name = "correspondentCommitmentDate")]
        public string CorrespondentCommitmentDate { get; set; }

        [DataMember(Name = "correspondentCommitmentExpirationDate")]
        public string CorrespondentCommitmentExpirationDate { get; set; }

        [DataMember(Name = "correspondentCommitmentPeriod")]
        public int? CorrespondentCommitmentPeriod { get; set; }

        [DataMember(Name = "receivedDate")]
        public string ReceivedDate { get; set; }

        [DataMember(Name = "initialSuspenseDate")]
        public string InitialSuspenseDate { get; set; }

        [DataMember(Name = "latestConditionsDate")]
        public string LatestConditionsDate { get; set; }

        [DataMember(Name = "conditionsReceivedDate")]
        public string ConditionsReceivedDate { get; set; }

        [DataMember(Name = "approvedToFundDate")]
        public string ApprovedToFundDate { get; set; }

        [DataMember(Name = "fundedDate")]
        public string FundedDate { get; set; }

        [DataMember(Name = "ratesheet")]
        public string Ratesheet { get; set; }

        [DataMember(Name = "basePrice")]
        public decimal? BasePrice { get; set; }

        [DataMember(Name = "collateralTrackingNumber")]
        public string CollateralTrackingNumber { get; set; }

        [DataMember(Name = "alternateLoanNumber")]
        public string AlternateLoanNumber { get; set; }

        [DataMember(Name = "noteDate")]
        public string NoteDate { get; set; }

        [DataMember(Name = "deliveryExpirationDate")]
        public string DeliveryExpirationDate { get; set; }

        [DataMember(Name = "gracePeriodDays")]
        public int? GracePeriodDays { get; set; }

        [DataMember(Name = "lateDaysBegin")]
        public string LateDaysBegin { get; set; }

        [DataMember(Name = "lateDaysEnd")]
        public string LateDaysEnd { get; set; }

        [DataMember(Name = "totalLateDays")]
        public int? TotalLateDays { get; set; }

        [DataMember(Name = "lateFeePercentage")]
        public decimal? LateFeePercentage { get; set; }

        [DataMember(Name = "additionalLateFeeCharge")]
        public decimal? AdditionalLateFeeCharge { get; set; }

        [DataMember(Name = "lateFeeFrequency")]
        public string LateFeeFrequency { get; set; }

        [DataMember(Name = "lateFeeTotalPriceAdjustment")]
        public decimal? LateFeeTotalPriceAdjustment { get; set; }

        [DataMember(Name = "lateFeeNotes")]
        public string LateFeeNotes { get; set; }

        [DataMember(Name = "lateFeeChargeType")]
        public string LateFeeChargeType { get; set; }

        [DataMember(Name = "totalLateFee")]
        public decimal? TotalLateFee { get; set; }

        [DataMember(Name = "deliveryType")]
        public string DeliveryType { get; set; }

        [DataMember(Name = "rejectedDate")]
        public string RejectedDate { get; set; }

        [DataMember(Name = "lfsCalculateAs")]
        public int? LfsCalculateAs { get; set; }

        [DataMember(Name = "lfsFeeHandledAs")]
        public int? LfsFeeHandledAs { get; set; }

        [DataMember(Name = "lfsGracePeriodCalendar")]
        public int? LfsGracePeriodCalendar { get; set; }

        [DataMember(Name = "lfsGracePeriodLaterOf")]
        public int? LfsGracePeriodLaterOf { get; set; }

        [DataMember(Name = "lfsGracePeriodStarts")]
        public int? LfsGracePeriodStarts { get; set; }

        [DataMember(Name = "lfsIncludeDay")]
        public int? LfsIncludeDay { get; set; }

        [DataMember(Name = "lfsLateFeeBasedOn")]
        public int? LfsLateFeeBasedOn { get; set; }

        [DataMember(Name = "lfsMaxLateDays")]
        public int? LfsMaxLateDays { get; set; }

        [DataMember(Name = "lfsOtherDate")]
        public string LfsOtherDate { get; set; }

        [DataMember(Name = "lfsStartOnWeekend")]
        public int? LfsStartOnWeekend { get; set; }

        [DataMember(Name = "lfsGracePeriodDays")]
        public int? LfsGracePeriodDays { get; set; }

        [DataMember(Name = "lfsDayCleared")]
        public int? LfsDayCleared { get; set; }

        [DataMember(Name = "lfsDayClearedOtherDate")]
        public string LfsDayClearedOtherDate { get; set; }

        [DataMember(Name = "lfsDayClearedOtherDateDescription")]
        public string LfsDayClearedOtherDateDescription { get; set; }

        [DataMember(Name = "lfsOtherDateValue")]
        public string LfsOtherDateValue { get; set; }

        [DataMember(Name = "lfsDayClearedOtherDateValue")]
        public string LfsDayClearedOtherDateValue { get; set; }

        [DataMember(Name = "loanIsCommitted")]
        public bool? LoanIsCommitted { get; set; }

        [DataMember(Name = "commitmentType")]
        public string CommitmentType { get; set; }

        [DataMember(Name = "unpaidPrincipalBalance")]
        public decimal? UnpaidPrincipalBalance { get; set; }

        [DataMember(Name = "originalPrincipalBalance")]
        public decimal? OriginalPrincipalBalance { get; set; }

        [DataMember(Name = "gracePeriodStartDate")]
        public string GracePeriodStartDate { get; set; }

        [DataMember(Name = "gracePeriodStartTrigger")]
        public string GracePeriodStartTrigger { get; set; }

        [DataMember(Name = "lateDaysEndTrigger")]
        public string LateDaysEndTrigger { get; set; }

        [DataMember(Name = "submittedforPurchaseDate")]
        public string SubmittedforPurchaseDate { get; set; }

        [DataMember(Name = "withdrawnDate")]
        public string WithdrawnDate { get; set; }

        [DataMember(Name = "cancelledDate")]
        public string CancelledDate { get; set; }

        [DataMember(Name = "voidedDate")]
        public string VoidedDate { get; set; }

        [DataMember(Name = "withdrawalRequestedDate")]
        public string WithdrawalRequestedDate { get; set; }

        [DataMember(Name = "lfsLateFee")]
        public decimal? LfsLateFee { get; set; }

        [DataMember(Name = "lfsAmount")]
        public decimal? LfsAmount { get; set; }

        [DataMember(Name = "borrowerRequestedLoanAmount")]
        public decimal? BorrowerRequestedLoanAmount { get; set; }

        [DataMember(Name = "baseLoanAmount")]
        public decimal? BaseLoanAmount { get; set; }

        [DataMember(Name = "principalAndInterestMonthlyPaymentAmount")]
        public decimal? PrincipalAndInterestMonthlyPaymentAmount { get; set; }

        [DataMember(Name = "undiscountedRate")]
        public decimal? UndiscountedRate { get; set; }

        [DataMember(Name = "initialAdjustedRate")]
        public decimal? InitialAdjustedRate { get; set; }

        [DataMember(Name = "initialAdjustedRatePoint")]
        public decimal? InitialAdjustedRatePoint { get; set; }

        [DataMember(Name = "rateReductionBasisPoints")]
        public decimal? RateReductionBasisPoints { get; set; }

        [DataMember(Name = "lateChargePercent")]
        public decimal? LateChargePercent { get; set; }

        [DataMember(Name = "lateFee")]
        public decimal? LateFee { get; set; }

        [DataMember(Name = "lateChargeDays")]
        public int? LateChargeDays { get; set; }

        [DataMember(Name = "ltv")]
        public decimal? Ltv { get; set; }

        [DataMember(Name = "combinedLtv")]
        public decimal? CombinedLtv { get; set; }

        [DataMember(Name = "mortgageInsurancePremiumUpfrontFactorPercent")]
        public decimal? MortgageInsurancePremiumUpfrontFactorPercent { get; set; }

        [DataMember(Name = "monthsOfMiPrepaid")]
        public int? MonthsOfMiPrepaid { get; set; }

        [DataMember(Name = "refundUnearnedMipIndicator")]
        public bool? RefundUnearnedMipIndicator { get; set; }

        [DataMember(Name = "feeRate")]
        public decimal? FeeRate { get; set; }

        [DataMember(Name = "guaranteeFeeCollected")]
        public decimal? GuaranteeFeeCollected { get; set; }

        [DataMember(Name = "initialTilDisclosureProvidedDate")]
        public string InitialTilDisclosureProvidedDate { get; set; }

        [DataMember(Name = "disclosureLastSentDate")]
        public string DisclosureLastSentDate { get; set; }

        [DataMember(Name = "disclosureReceivedDate")]
        public string DisclosureReceivedDate { get; set; }

        [DataMember(Name = "totalOfPayments")]
        public decimal? TotalOfPayments { get; set; }

        [DataMember(Name = "initialTilDisclosureReceivedDate")]
        public string InitialTilDisclosureReceivedDate { get; set; }

        [DataMember(Name = "disclosedAprPercent")]
        public decimal? DisclosedAprPercent { get; set; }

        [DataMember(Name = "disclosedFinanceCharge")]
        public decimal? DisclosedFinanceCharge { get; set; }

        [DataMember(Name = "amountFinanced")]
        public decimal? AmountFinanced { get; set; }

        [DataMember(Name = "disclosedDailyInterestCharge")]
        public decimal? DisclosedDailyInterestCharge { get; set; }

        [DataMember(Name = "priorDisclosedDailyInterest")]
        public decimal? PriorDisclosedDailyInterest { get; set; }

        [DataMember(Name = "loanProduct")]
        public string LoanProduct { get; set; }

        [DataMember(Name = "prepaymentPenaltyIndicator")]
        public bool? PrepaymentPenaltyIndicator { get; set; }

        [DataMember(Name = "paymentAmount")]
        public decimal? PaymentAmount { get; set; }

        [DataMember(Name = "proposedHazardInsuranceAmount")]
        public string ProposedHazardInsuranceAmount { get; set; }

        [DataMember(Name = "proposedRealEstateTaxesAmount")]
        public string ProposedRealEstateTaxesAmount { get; set; }

        [DataMember(Name = "proposedMortgageInsuranceAmount")]
        public string ProposedMortgageInsuranceAmount { get; set; }

        [DataMember(Name = "proposedDuesAmount")]
        public string ProposedDuesAmount { get; set; }

        [DataMember(Name = "proposedOtherAmount")]
        public decimal? ProposedOtherAmount { get; set; }

        [DataMember(Name = "totalNetMonthlySalary")]
        public decimal? TotalNetMonthlySalary { get; set; }

        [DataMember(Name = "monthlyHousingExpense")]
        public decimal? MonthlyHousingExpense { get; set; }

        [DataMember(Name = "commitmentAmount")]
        public decimal? CommitmentAmount { get; set; }

        [DataMember(Name = "discountPointsApplied")]
        public decimal? DiscountPointsApplied { get; set; }

        [DataMember(Name = "scheduledFirstPaymentDate")]
        public string ScheduledFirstPaymentDate { get; set; }

        [DataMember(Name = "topRatioPercent")]
        public decimal? TopRatioPercent { get; set; }

        [DataMember(Name = "bottomRatioPercent")]
        public decimal? BottomRatioPercent { get; set; }

        [DataMember(Name = "loanStatus")]
        public string LoanStatus { get; set; }

        [DataMember(Name = "loanStatusLastUpdatedDateTime")]
        public string LoanStatusLastUpdatedDateTime { get; set; }

        [DataMember(Name = "autoPublishConditions")]
        public bool? AutoPublishConditions { get; set; }

        [DataMember(Name = "lastPublishedConditionsNotificationDateTime")]
        public string LastPublishedConditionsNotificationDateTime { get; set; }

        [DataMember(Name = "numberOfBedroomUnit3")]
        public int? NumberOfBedroomUnit3 { get; set; }

        [DataMember(Name = "numberOfBedroomUnit4")]
        public int? NumberOfBedroomUnit4 { get; set; }

        [DataMember(Name = "numberOfBuydownPeriods")]
        public int? NumberOfBuydownPeriods { get; set; }

        [DataMember(Name = "prepaidInterestDays")]
        public int? PrepaidInterestDays { get; set; }

        [DataMember(Name = "abaNumber")]
        public string AbaNumber { get; set; }

        [DataMember(Name = "accountNumber")]
        public string AccountNumber { get; set; }

        [DataMember(Name = "accountNumber2")]
        public string AccountNumber2 { get; set; }

        [DataMember(Name = "additionalInsuranceCoverage")]
        public decimal? AdditionalInsuranceCoverage { get; set; }

        [DataMember(Name = "additionalFloodCoverage")]
        public decimal? AdditionalFloodCoverage { get; set; }

        [DataMember(Name = "additionalHazardCoverage")]
        public decimal? AdditionalHazardCoverage { get; set; }

        [DataMember(Name = "additionalWindCoverage")]
        public decimal? AdditionalWindCoverage { get; set; }

        [DataMember(Name = "closingBorrowerAdjustments")]
        public decimal? ClosingBorrowerAdjustments { get; set; }

        [DataMember(Name = "aggregateAdjustment")]
        public decimal? AggregateAdjustment { get; set; }

        [DataMember(Name = "monthlyPremiumAmount")]
        public string MonthlyPremiumAmount { get; set; }

        [DataMember(Name = "annualMipRate")]
        public decimal? AnnualMipRate { get; set; }

        [DataMember(Name = "averagePrimeOfferRate")]
        public decimal? AveragePrimeOfferRate { get; set; }

        [DataMember(Name = "appraisalAddressCounty")]
        public string AppraisalAddressCounty { get; set; }

        [DataMember(Name = "appraisalApptDate")]
        public string AppraisalApptDate { get; set; }

        [DataMember(Name = "appraisalCountyName")]
        public string AppraisalCountyName { get; set; }

        [DataMember(Name = "appraisalFee")]
        public decimal? AppraisalFee { get; set; }

        [DataMember(Name = "appraisalFinalInspectionDate")]
        public string AppraisalFinalInspectionDate { get; set; }

        [DataMember(Name = "appraisalFinalInspectionFlag")]
        public bool? AppraisalFinalInspectionFlag { get; set; }

        [DataMember(Name = "appraisalFloodZone")]
        public string AppraisalFloodZone { get; set; }

        [DataMember(Name = "appraisalPropertyType")]
        public string AppraisalPropertyType { get; set; }

        [DataMember(Name = "appraisalWaiver")]
        public bool? AppraisalWaiver { get; set; }

        [DataMember(Name = "appraisedCondition")]
        public string AppraisedCondition { get; set; }

        [DataMember(Name = "appraisedValue")]
        public int? AppraisedValue { get; set; }

        [DataMember(Name = "appraiserName")]
        public string AppraiserName { get; set; }

        [DataMember(Name = "appraiserSupervisorsName")]
        public string AppraiserSupervisorsName { get; set; }

        [DataMember(Name = "appraisersLicenseNumber")]
        public string AppraisersLicenseNumber { get; set; }

        [DataMember(Name = "appraisersStateLicenseNumber")]
        public string AppraisersStateLicenseNumber { get; set; }

        [DataMember(Name = "appraisersPropertyAddress1")]
        public string AppraisersPropertyAddress1 { get; set; }

        [DataMember(Name = "appraisersPropertyAddress2")]
        public string AppraisersPropertyAddress2 { get; set; }

        [DataMember(Name = "aprPercent")]
        public decimal? AprPercent { get; set; }

        [DataMember(Name = "armIndex")]
        public decimal? ArmIndex { get; set; }

        [DataMember(Name = "armMargin")]
        public decimal? ArmMargin { get; set; }

        [DataMember(Name = "armMargin2")]
        public decimal? ArmMargin2 { get; set; }

        [DataMember(Name = "armRateFloor")]
        public decimal? ArmRateFloor { get; set; }

        [DataMember(Name = "armRateFloor2")]
        public decimal? ArmRateFloor2 { get; set; }

        [DataMember(Name = "ausAppraisedValue")]
        public int? AusAppraisedValue { get; set; }

        [DataMember(Name = "ausAssetsToBeVerified")]
        public decimal? AusAssetsToBeVerified { get; set; }

        [DataMember(Name = "priorDisclosureDate")]
        public string PriorDisclosureDate { get; set; }

        [DataMember(Name = "prepaymentPenalty")]
        public bool? PrepaymentPenalty { get; set; }

        [DataMember(Name = "leSectionjLenderCreditTotal")]
        public int? LeSectionjLenderCreditTotal { get; set; }

        [DataMember(Name = "cdSectionjLenderCreditTotal")]
        public decimal? CdSectionjLenderCreditTotal { get; set; }

        [DataMember(Name = "vaIrrrlStatutoryPAndIAmount")]
        public decimal? VaIrrrlStatutoryPAndIAmount { get; set; }

        [DataMember(Name = "priorApplicationDate")]
        public string PriorApplicationDate { get; set; }

        [DataMember(Name = "ausCreditReportCertNumber")]
        public string AusCreditReportCertNumber { get; set; }

        [DataMember(Name = "ausCreditReportDate")]
        public string AusCreditReportDate { get; set; }

        [DataMember(Name = "collateralUnderwriterScore")]
        public string CollateralUnderwriterScore { get; set; }

        [DataMember(Name = "ausFreeFormComments")]
        public string AusFreeFormComments { get; set; }

        [DataMember(Name = "ausInterestRate")]
        public decimal? AusInterestRate { get; set; }

        [DataMember(Name = "ausLoanAmount")]
        public decimal? AusLoanAmount { get; set; }

        [DataMember(Name = "ausPrimaryHousingExpense")]
        public decimal? AusPrimaryHousingExpense { get; set; }

        [DataMember(Name = "ausPropertyAddress1")]
        public string AusPropertyAddress1 { get; set; }

        [DataMember(Name = "ausPropertyAddress2")]
        public string AusPropertyAddress2 { get; set; }

        [DataMember(Name = "ausPropertyCity")]
        public string AusPropertyCity { get; set; }

        [DataMember(Name = "ausPropertyState")]
        public string AusPropertyState { get; set; }

        [DataMember(Name = "ausPropertyZip")]
        public string AusPropertyZip { get; set; }

        [DataMember(Name = "ausPurchasePrice")]
        public decimal? AusPurchasePrice { get; set; }

        [DataMember(Name = "ausReferenceNumber")]
        public string AusReferenceNumber { get; set; }

        [DataMember(Name = "ausTotalAvailableAssets")]
        public decimal? AusTotalAvailableAssets { get; set; }

        [DataMember(Name = "ausTotalDti")]
        public decimal? AusTotalDti { get; set; }

        [DataMember(Name = "ausTotalMonthlyDebt")]
        public decimal? AusTotalMonthlyDebt { get; set; }

        [DataMember(Name = "ausTotalMonthlyIncome")]
        public decimal? AusTotalMonthlyIncome { get; set; }

        [DataMember(Name = "avmAppraisedValue")]
        public decimal? AvmAppraisedValue { get; set; }

        [DataMember(Name = "avmConfidenceScore")]
        public string AvmConfidenceScore { get; set; }

        [DataMember(Name = "avmOrderNumber")]
        public string AvmOrderNumber { get; set; }

        [DataMember(Name = "avmOrderDate")]
        public string AvmOrderDate { get; set; }

        [DataMember(Name = "avmType")]
        public string AvmType { get; set; }

        [DataMember(Name = "bankAddress")]
        public string BankAddress { get; set; }

        [DataMember(Name = "bankAddress2")]
        public string BankAddress2 { get; set; }

        [DataMember(Name = "bankAddressCity")]
        public string BankAddressCity { get; set; }

        [DataMember(Name = "bankAddressState")]
        public string BankAddressState { get; set; }

        [DataMember(Name = "bankZip")]
        public string BankZip { get; set; }

        [DataMember(Name = "bankName")]
        public string BankName { get; set; }

        [DataMember(Name = "buildingStatus")]
        public string BuildingStatus { get; set; }

        [DataMember(Name = "cemaIndicator")]
        public bool? CemaIndicator { get; set; }

        [DataMember(Name = "censusTrack")]
        public string CensusTrack { get; set; }

        [DataMember(Name = "certOfEligibilityProvided")]
        public bool? CertOfEligibilityProvided { get; set; }

        [DataMember(Name = "closingCostsAmount")]
        public decimal? ClosingCostsAmount { get; set; }

        [DataMember(Name = "condoProjectClass")]
        public string CondoProjectClass { get; set; }

        [DataMember(Name = "condoProjectStatusType")]
        public string CondoProjectStatusType { get; set; }

        [DataMember(Name = "additionalInsuranceCoverageAmount")]
        public decimal? AdditionalInsuranceCoverageAmount { get; set; }

        [DataMember(Name = "masterCoverageAmount")]
        public decimal? MasterCoverageAmount { get; set; }

        [DataMember(Name = "windHailCoverageAmount")]
        public decimal? WindHailCoverageAmount { get; set; }

        [DataMember(Name = "additionalInsuranceCoverageTerm")]
        public int? AdditionalInsuranceCoverageTerm { get; set; }

        [DataMember(Name = "floodCoverageTerm")]
        public int? FloodCoverageTerm { get; set; }

        [DataMember(Name = "hazardCoverageTerm")]
        public int? HazardCoverageTerm { get; set; }

        [DataMember(Name = "masterCoverageTerm")]
        public int? MasterCoverageTerm { get; set; }

        [DataMember(Name = "windHailCoverageTerm")]
        public int? WindHailCoverageTerm { get; set; }

        [DataMember(Name = "creditReport")]
        public decimal? CreditReport { get; set; }

        [DataMember(Name = "customMinimumMi")]
        public string CustomMinimumMi { get; set; }

        [DataMember(Name = "dateOfSale")]
        public string DateOfSale { get; set; }

        [DataMember(Name = "additionalInsuranceDeductible")]
        public decimal? AdditionalInsuranceDeductible { get; set; }

        [DataMember(Name = "floodDeductible")]
        public decimal? FloodDeductible { get; set; }

        [DataMember(Name = "hazardDeductible")]
        public decimal? HazardDeductible { get; set; }

        [DataMember(Name = "windHailDeductible")]
        public decimal? WindHailDeductible { get; set; }

        [DataMember(Name = "disclosedTotalPayments")]
        public decimal? DisclosedTotalPayments { get; set; }

        [DataMember(Name = "prepaymentRiderIndicator")]
        public bool? PrepaymentRiderIndicator { get; set; }

        [DataMember(Name = "borrowerSignedIndicator")]
        public bool? BorrowerSignedIndicator { get; set; }

        [DataMember(Name = "ucdSubmissionResult")]
        public string UcdSubmissionResult { get; set; }

        [DataMember(Name = "eNoteIndicator")]
        public bool? ENoteIndicator { get; set; }

        [DataMember(Name = "effectivePropertyValue")]
        public decimal? EffectivePropertyValue { get; set; }

        [DataMember(Name = "energyEfficientIndicator")]
        public bool? EnergyEfficientIndicator { get; set; }

        [DataMember(Name = "escrowHoldback")]
        public decimal? EscrowHoldback { get; set; }

        [DataMember(Name = "estValueOfRepairs")]
        public decimal? EstValueOfRepairs { get; set; }

        [DataMember(Name = "additionalInsuranceExcludePitiPayment")]
        public bool? AdditionalInsuranceExcludePitiPayment { get; set; }

        [DataMember(Name = "cityTaxesExcludePitiPayment")]
        public bool? CityTaxesExcludePitiPayment { get; set; }

        [DataMember(Name = "countyTaxesExcludePitiPayment")]
        public bool? CountyTaxesExcludePitiPayment { get; set; }

        [DataMember(Name = "floodExcludePitiPayment")]
        public bool? FloodExcludePitiPayment { get; set; }

        [DataMember(Name = "hazardExcludePitiPayment")]
        public bool? HazardExcludePitiPayment { get; set; }

        [DataMember(Name = "otherTaxesExcludePitiPayment")]
        public bool? OtherTaxesExcludePitiPayment { get; set; }

        [DataMember(Name = "stateTaxesExcludePitiPayment")]
        public bool? StateTaxesExcludePitiPayment { get; set; }

        [DataMember(Name = "windHailExcludePitiPayment")]
        public bool? WindHailExcludePitiPayment { get; set; }

        [DataMember(Name = "fhlmcEnergyEfficientIndicator")]
        public bool? FhlmcEnergyEfficientIndicator { get; set; }

        [DataMember(Name = "fhlmcPurchaseEligibility")]
        public string FhlmcPurchaseEligibility { get; set; }

        [DataMember(Name = "fhlmcUcdCaseFileId")]
        public string FhlmcUcdCaseFileId { get; set; }

        [DataMember(Name = "ucdSubmissionDate")]
        public string UcdSubmissionDate { get; set; }

        [DataMember(Name = "fhlmcUcdSuccessFlag")]
        public bool? FhlmcUcdSuccessFlag { get; set; }

        [DataMember(Name = "finalInspectionReqIndicator")]
        public bool? FinalInspectionReqIndicator { get; set; }

        [DataMember(Name = "firstPaymentChangeDate")]
        public string FirstPaymentChangeDate { get; set; }

        [DataMember(Name = "prepaidFinance")]
        public decimal? PrepaidFinance { get; set; }

        [DataMember(Name = "projectClass")]
        public string ProjectClass { get; set; }

        [DataMember(Name = "projectName")]
        public string ProjectName { get; set; }

        [DataMember(Name = "propertyAcquiredLessThanOneYearAgo")]
        public bool? PropertyAcquiredLessThanOneYearAgo { get; set; }

        [DataMember(Name = "propertyAppraisalType")]
        public string PropertyAppraisalType { get; set; }

        [DataMember(Name = "propertyAttachmentType")]
        public string PropertyAttachmentType { get; set; }

        [DataMember(Name = "propertyUsageCode")]
        public string PropertyUsageCode { get; set; }

        [DataMember(Name = "propertyValue")]
        public decimal? PropertyValue { get; set; }

        [DataMember(Name = "purchaseContractSalesPrice")]
        public decimal? PurchaseContractSalesPrice { get; set; }

        [DataMember(Name = "rateAdjustmentPeriodicCap")]
        public decimal? RateAdjustmentPeriodicCap { get; set; }

        [DataMember(Name = "rateAdjustmentPeriodicCap2")]
        public decimal? RateAdjustmentPeriodicCap2 { get; set; }

        [DataMember(Name = "recoupmentNumberOfMonths")]
        public int? RecoupmentNumberOfMonths { get; set; }

        [DataMember(Name = "reducedMiIndicator")]
        public bool? ReducedMiIndicator { get; set; }

        [DataMember(Name = "renovationCompleteIndicator")]
        public bool? RenovationCompleteIndicator { get; set; }

        [DataMember(Name = "rentAmountUnit1")]
        public decimal? RentAmountUnit1 { get; set; }

        [DataMember(Name = "rentAmountUnit2")]
        public decimal? RentAmountUnit2 { get; set; }

        [DataMember(Name = "section32Apr")]
        public decimal? Section32Apr { get; set; }

        [DataMember(Name = "section32DisclosureDate")]
        public string Section32DisclosureDate { get; set; }

        [DataMember(Name = "section32Indicator")]
        public bool? Section32Indicator { get; set; }

        [DataMember(Name = "cdSellerCreditAmount")]
        public decimal? CdSellerCreditAmount { get; set; }

        [DataMember(Name = "cdShoppableServices")]
        public decimal? CdShoppableServices { get; set; }

        [DataMember(Name = "siteValue")]
        public decimal? SiteValue { get; set; }

        [DataMember(Name = "specialtyProduct")]
        public string SpecialtyProduct { get; set; }

        [DataMember(Name = "standardDeviation")]
        public string StandardDeviation { get; set; }

        [DataMember(Name = "subjectPropertyState")]
        public string SubjectPropertyState { get; set; }

        [DataMember(Name = "statedGrossRent")]
        public decimal? StatedGrossRent { get; set; }

        [DataMember(Name = "statedPropertyCondition")]
        public string StatedPropertyCondition { get; set; }

        [DataMember(Name = "statedPropertyType")]
        public string StatedPropertyType { get; set; }

        [DataMember(Name = "subjectAddressCity")]
        public string SubjectAddressCity { get; set; }

        [DataMember(Name = "subjectPropertyImproved")]
        public string SubjectPropertyImproved { get; set; }

        [DataMember(Name = "subjectPropertyUnitNumber")]
        public string SubjectPropertyUnitNumber { get; set; }

        [DataMember(Name = "subordinationType")]
        public string SubordinationType { get; set; }

        [DataMember(Name = "subsequentAdjustmentTerm")]
        public int? SubsequentAdjustmentTerm { get; set; }

        [DataMember(Name = "supervisoryAppraiserLicenseNumber")]
        public string SupervisoryAppraiserLicenseNumber { get; set; }

        [DataMember(Name = "cdTaxesAndGovtFeesE")]
        public decimal? CdTaxesAndGovtFeesE { get; set; }

        [DataMember(Name = "texasA6Indicator")]
        public bool? TexasA6Indicator { get; set; }

        [DataMember(Name = "texasA6Indicator2")]
        public bool? TexasA6Indicator2 { get; set; }

        [DataMember(Name = "cdTotalBorrowerClosingCosts")]
        public decimal? CdTotalBorrowerClosingCosts { get; set; }

        [DataMember(Name = "totalEscrowsCollectedAtClosing")]
        public decimal? TotalEscrowsCollectedAtClosing { get; set; }

        [DataMember(Name = "txPrecloseCdBorrDeliveryDate")]
        public string TxPrecloseCdBorrDeliveryDate { get; set; }

        [DataMember(Name = "txPrecloseCdBorrReceiptDate")]
        public string TxPrecloseCdBorrReceiptDate { get; set; }

        [DataMember(Name = "ucdpAppraisalEffectiveDate")]
        public string UcdpAppraisalEffectiveDate { get; set; }

        [DataMember(Name = "ucdpAppraisedValueAmount")]
        public int? UcdpAppraisedValueAmount { get; set; }

        [DataMember(Name = "ucdpDocFileId")]
        public string UcdpDocFileId { get; set; }

        [DataMember(Name = "ucdpOverValuation")]
        public string UcdpOverValuation { get; set; }

        [DataMember(Name = "underwritingMethod")]
        public string UnderwritingMethod { get; set; }

        [DataMember(Name = "propertyAppraisalUnitNumber")]
        public string PropertyAppraisalUnitNumber { get; set; }

        [DataMember(Name = "upfrontMipRate")]
        public decimal? UpfrontMipRate { get; set; }

        [DataMember(Name = "upfrontPremiumAmount")]
        public decimal? UpfrontPremiumAmount { get; set; }

        [DataMember(Name = "appraisalUsage")]
        public string AppraisalUsage { get; set; }

        [DataMember(Name = "vaCashOutNtbComparisonFormDate")]
        public string VaCashOutNtbComparisonFormDate { get; set; }

        [DataMember(Name = "valueUsedForAdditionalInsurance")]
        public decimal? ValueUsedForAdditionalInsurance { get; set; }

        [DataMember(Name = "valueUsedForFloodInsurance")]
        public decimal? ValueUsedForFloodInsurance { get; set; }

        [DataMember(Name = "valueUsedForHazardInsurance")]
        public decimal? ValueUsedForHazardInsurance { get; set; }

        [DataMember(Name = "valueUsedForWindHailInsurance")]
        public decimal? ValueUsedForWindHailInsurance { get; set; }

        [DataMember(Name = "yearBuilt")]
        public string YearBuilt { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "zoningCompliance")]
        public string ZoningCompliance { get; set; }

        [DataMember(Name = "additionalInsuranceMonthlyAmount")]
        public decimal? AdditionalInsuranceMonthlyAmount { get; set; }

        [DataMember(Name = "countyTaxesMonthlyAmount")]
        public decimal? CountyTaxesMonthlyAmount { get; set; }

        [DataMember(Name = "schoolTaxesMonthlyAmount")]
        public decimal? SchoolTaxesMonthlyAmount { get; set; }

        [DataMember(Name = "otherTaxesMonthlyAmount")]
        public decimal? OtherTaxesMonthlyAmount { get; set; }

        [DataMember(Name = "notePAndI2")]
        public decimal? NotePAndI2 { get; set; }

        [DataMember(Name = "propertyFlipIndicator")]
        public bool? PropertyFlipIndicator { get; set; }

        [DataMember(Name = "jumbo")]
        public bool? Jumbo { get; set; }

        [DataMember(Name = "firstPaymentLetterPiti")]
        public decimal? FirstPaymentLetterPiti { get; set; }

        [DataMember(Name = "firstPaymentPi")]
        public decimal? FirstPaymentPi { get; set; }

        [DataMember(Name = "floodInsuranceRequired")]
        public bool? FloodInsuranceRequired { get; set; }

        [DataMember(Name = "fnmCondominiumProjectManagerProjectIdentifier")]
        public string FnmCondominiumProjectManagerProjectIdentifier { get; set; }

        [DataMember(Name = "fnmaUcdCaseFileId")]
        public string FnmaUcdCaseFileId { get; set; }

        [DataMember(Name = "fnmaUcdSubmissionDate")]
        public string FnmaUcdSubmissionDate { get; set; }

        [DataMember(Name = "fnmaUcdSuccessFlag")]
        public string FnmaUcdSuccessFlag { get; set; }

        [DataMember(Name = "freddieProjectClass")]
        public string FreddieProjectClass { get; set; }

        [DataMember(Name = "cityTaxesFrequency")]
        public string CityTaxesFrequency { get; set; }

        [DataMember(Name = "countyTaxesFrequency")]
        public string CountyTaxesFrequency { get; set; }

        [DataMember(Name = "otherTaxesFrequency")]
        public string OtherTaxesFrequency { get; set; }

        [DataMember(Name = "stateTaxesFrequency")]
        public string StateTaxesFrequency { get; set; }

        [DataMember(Name = "additionalInsuranceGuaranteedReplacementCost")]
        public bool? AdditionalInsuranceGuaranteedReplacementCost { get; set; }

        [DataMember(Name = "floodInsuranceGuaranteedReplacementCost")]
        public bool? FloodInsuranceGuaranteedReplacementCost { get; set; }

        [DataMember(Name = "hazardInsuranceGuaranteedReplacementCost")]
        public bool? HazardInsuranceGuaranteedReplacementCost { get; set; }

        [DataMember(Name = "windHailInsuranceGuaranteedReplacementCost")]
        public bool? WindHailInsuranceGuaranteedReplacementCost { get; set; }

        [DataMember(Name = "highPricedMortageLoanIndicator")]
        public string HighPricedMortageLoanIndicator { get; set; }

        [DataMember(Name = "hoaBudgetedAssessmentIncome")]
        public decimal? HoaBudgetedAssessmentIncome { get; set; }

        [DataMember(Name = "hoaBudgetedReplacementReserves")]
        public decimal? HoaBudgetedReplacementReserves { get; set; }

        [DataMember(Name = "hoaLitigationStatus")]
        public bool? HoaLitigationStatus { get; set; }

        [DataMember(Name = "homeOneIndicator")]
        public bool? HomeOneIndicator { get; set; }

        [DataMember(Name = "homePossibleIndicator")]
        public bool? HomePossibleIndicator { get; set; }

        [DataMember(Name = "homePossibleAdvIndicator")]
        public bool? HomePossibleAdvIndicator { get; set; }

        [DataMember(Name = "homeReadyIndicator")]
        public bool? HomeReadyIndicator { get; set; }

        [DataMember(Name = "homeStyleIndicator")]
        public bool? HomeStyleIndicator { get; set; }

        [DataMember(Name = "ieadInitialDeposit")]
        public decimal? IeadInitialDeposit { get; set; }

        [DataMember(Name = "isAdditionalInsurance")]
        public bool? IsAdditionalInsurance { get; set; }

        [DataMember(Name = "isFloodInsurance")]
        public bool? IsFloodInsurance { get; set; }

        [DataMember(Name = "isWindHailInsurance")]
        public bool? IsWindHailInsurance { get; set; }

        [DataMember(Name = "incomeType")]
        public string IncomeType { get; set; }

        [DataMember(Name = "indexType")]
        public string IndexType { get; set; }

        [DataMember(Name = "additionalInsuranceCompanyName")]
        public string AdditionalInsuranceCompanyName { get; set; }

        [DataMember(Name = "masterInsuranceCompanyName")]
        public string MasterInsuranceCompanyName { get; set; }

        [DataMember(Name = "windHailInsuranceCompanyName")]
        public string WindHailInsuranceCompanyName { get; set; }

        [DataMember(Name = "additionalInsuranceEstimator")]
        public string AdditionalInsuranceEstimator { get; set; }

        [DataMember(Name = "floodInsuranceEstimator")]
        public string FloodInsuranceEstimator { get; set; }

        [DataMember(Name = "hazardInsuranceEstimator")]
        public string HazardInsuranceEstimator { get; set; }

        [DataMember(Name = "windHailInsuranceEstimator")]
        public string WindHailInsuranceEstimator { get; set; }

        [DataMember(Name = "additionalInsuranceType")]
        public string AdditionalInsuranceType { get; set; }

        [DataMember(Name = "isSubjectPropertyImproved")]
        public bool? IsSubjectPropertyImproved { get; set; }

        [DataMember(Name = "lastAusResult")]
        public string LastAusResult { get; set; }

        [DataMember(Name = "lastAusRunDate")]
        public string LastAusRunDate { get; set; }

        [DataMember(Name = "lastAusType")]
        public string LastAusType { get; set; }

        [DataMember(Name = "appraisalLegalDescription1")]
        public string AppraisalLegalDescription1 { get; set; }

        [DataMember(Name = "appraisalLegalDescription2")]
        public string AppraisalLegalDescription2 { get; set; }

        [DataMember(Name = "closingDisclosureLenderCreditAmount")]
        public decimal? ClosingDisclosureLenderCreditAmount { get; set; }

        [DataMember(Name = "closingDisclosureLenderPocAmount")]
        public decimal? ClosingDisclosureLenderPocAmount { get; set; }

        [DataMember(Name = "lifeOfLoan")]
        public bool? LifeOfLoan { get; set; }

        [DataMember(Name = "lifeTimeCap1")]
        public decimal? LifeTimeCap1 { get; set; }

        [DataMember(Name = "lifeTimeCap2")]
        public decimal? LifeTimeCap2 { get; set; }

        [DataMember(Name = "livingArea")]
        public decimal? LivingArea { get; set; }

        [DataMember(Name = "loanDiscountFee")]
        public decimal? LoanDiscountFee { get; set; }

        [DataMember(Name = "loanStatusOcr")]
        public string LoanStatusOcr { get; set; }

        [DataMember(Name = "loanStatusChangeUserName")]
        public string LoanStatusChangeUserName { get; set; }

        [DataMember(Name = "loanStatusDateTimeStamp")]
        public string LoanStatusDateTimeStamp { get; set; }

        [DataMember(Name = "lomaLomr")]
        public string LomaLomr { get; set; }

        [DataMember(Name = "lookbackPeriod1")]
        public string LookbackPeriod1 { get; set; }

        [DataMember(Name = "lookbackPeriod2")]
        public string LookbackPeriod2 { get; set; }

        [DataMember(Name = "maxFirstChangeRate1")]
        public decimal? MaxFirstChangeRate1 { get; set; }

        [DataMember(Name = "maxFirstChangeRate2")]
        public decimal? MaxFirstChangeRate2 { get; set; }

        [DataMember(Name = "miPremiumPaymentType")]
        public string MiPremiumPaymentType { get; set; }

        [DataMember(Name = "minFirstChangeRate1")]
        public decimal? MinFirstChangeRate1 { get; set; }

        [DataMember(Name = "minFirstChangeRate2")]
        public decimal? MinFirstChangeRate2 { get; set; }

        [DataMember(Name = "momIndicator")]
        public bool? MomIndicator { get; set; }

        [DataMember(Name = "monthlyRentAmountUnit3")]
        public decimal? MonthlyRentAmountUnit3 { get; set; }

        [DataMember(Name = "monthlyRentAmountUnit4")]
        public decimal? MonthlyRentAmountUnit4 { get; set; }

        [DataMember(Name = "cityTaxesNextPaymentDueDate")]
        public string CityTaxesNextPaymentDueDate { get; set; }

        [DataMember(Name = "countyTaxesNextPaymentDueDate")]
        public string CountyTaxesNextPaymentDueDate { get; set; }

        [DataMember(Name = "otherTaxesNextPaymentDueDate")]
        public string OtherTaxesNextPaymentDueDate { get; set; }

        [DataMember(Name = "stateTaxesNextPaymentDueDate")]
        public string StateTaxesNextPaymentDueDate { get; set; }

        [DataMember(Name = "nfipPaneldate")]
        public string NfipPaneldate { get; set; }

        [DataMember(Name = "nfipPanelNumber")]
        public string NfipPanelNumber { get; set; }

        [DataMember(Name = "nonMortgagePayoffAmount")]
        public decimal? NonMortgagePayoffAmount { get; set; }

        [DataMember(Name = "nonShoppableServicesB")]
        public decimal? NonShoppableServicesB { get; set; }

        [DataMember(Name = "nonTraditionalCredit")]
        public bool? NonTraditionalCredit { get; set; }

        [DataMember(Name = "notaryAcknowledgementDate")]
        public string NotaryAcknowledgementDate { get; set; }

        [DataMember(Name = "notePi")]
        public decimal? NotePi { get; set; }

        [DataMember(Name = "numberofBedrooms")]
        public int? NumberofBedrooms { get; set; }

        [DataMember(Name = "numberofBedroomsUnit1")]
        public int? NumberofBedroomsUnit1 { get; set; }

        [DataMember(Name = "numberofBedroomsUnit2")]
        public int? NumberofBedroomsUnit2 { get; set; }

        [DataMember(Name = "numberOfUnits")]
        public int? NumberOfUnits { get; set; }

        [DataMember(Name = "originationChargedA")]
        public decimal? OriginationChargedA { get; set; }

        [DataMember(Name = "panelNumber")]
        public string PanelNumber { get; set; }

        [DataMember(Name = "periodicChangePercent1")]
        public decimal? PeriodicChangePercent1 { get; set; }

        [DataMember(Name = "periodicChangePercent2")]
        public decimal? PeriodicChangePercent2 { get; set; }

        [DataMember(Name = "additionalInsurancePolicyEffectiveDate")]
        public string AdditionalInsurancePolicyEffectiveDate { get; set; }

        [DataMember(Name = "floodPolicyEffectiveDate")]
        public string FloodPolicyEffectiveDate { get; set; }

        [DataMember(Name = "hazardPolicyEffectiveDate")]
        public string HazardPolicyEffectiveDate { get; set; }

        [DataMember(Name = "masterPolicyEffectiveDate")]
        public string MasterPolicyEffectiveDate { get; set; }

        [DataMember(Name = "windHailPolicyEffectiveDate")]
        public string WindHailPolicyEffectiveDate { get; set; }

        [DataMember(Name = "additionalInsurancePolicyExpirationDate")]
        public string AdditionalInsurancePolicyExpirationDate { get; set; }

        [DataMember(Name = "masterPolicyExpirationDate")]
        public string MasterPolicyExpirationDate { get; set; }

        [DataMember(Name = "windHailPolicyExpirationDate")]
        public string WindHailPolicyExpirationDate { get; set; }

        [DataMember(Name = "additionalInsurancePolicyNumber")]
        public string AdditionalInsurancePolicyNumber { get; set; }

        [DataMember(Name = "masterPolicyNumber")]
        public string MasterPolicyNumber { get; set; }

        [DataMember(Name = "windHailPolicyNumber")]
        public string WindHailPolicyNumber { get; set; }

        [DataMember(Name = "additionalInsurancePolicyPremium")]
        public decimal? AdditionalInsurancePolicyPremium { get; set; }

        [DataMember(Name = "windHailPolicyPremium")]
        public decimal? WindHailPolicyPremium { get; set; }

        [DataMember(Name = "additionalInsurancePolicyType")]
        public string AdditionalInsurancePolicyType { get; set; }

        [DataMember(Name = "floodPolicyType")]
        public string FloodPolicyType { get; set; }

        [DataMember(Name = "hazardPolicyType")]
        public string HazardPolicyType { get; set; }

        [DataMember(Name = "windHailPolicyType")]
        public string WindHailPolicyType { get; set; }

        [DataMember(Name = "powerofAttorneyIndicator")]
        public bool? PowerofAttorneyIndicator { get; set; }

        [DataMember(Name = "additionalInsurancePremiumDueDate")]
        public string AdditionalInsurancePremiumDueDate { get; set; }

        [DataMember(Name = "floodPremiumDueDate")]
        public string FloodPremiumDueDate { get; set; }

        [DataMember(Name = "hazardPremiumDueDate")]
        public string HazardPremiumDueDate { get; set; }

        [DataMember(Name = "windHailPremiumDueDate")]
        public string WindHailPremiumDueDate { get; set; }

        [DataMember(Name = "premiumTerm")]
        public string PremiumTerm { get; set; }

        [DataMember(Name = "firstPaymentLetterHazardAmount")]
        public decimal? FirstPaymentLetterHazardAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterFloodAmount")]
        public decimal? FirstPaymentLetterFloodAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterWindHailAmount")]
        public decimal? FirstPaymentLetterWindHailAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterAdditionalInsuranceAmount")]
        public decimal? FirstPaymentLetterAdditionalInsuranceAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterCityTaxes")]
        public decimal? FirstPaymentLetterCityTaxes { get; set; }

        [DataMember(Name = "firstPaymentLetterCountyTaxes")]
        public decimal? FirstPaymentLetterCountyTaxes { get; set; }

        [DataMember(Name = "firstPaymentLetterSchoolTaxes")]
        public decimal? FirstPaymentLetterSchoolTaxes { get; set; }

        [DataMember(Name = "firstPaymentLetterHoaAmount")]
        public decimal? FirstPaymentLetterHoaAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterPmiMipAmount")]
        public decimal? FirstPaymentLetterPmiMipAmount { get; set; }

        [DataMember(Name = "firstPaymentLetterOtherTaxes")]
        public decimal? FirstPaymentLetterOtherTaxes { get; set; }

        [DataMember(Name = "afterImprovedLtv")]
        public decimal? AfterImprovedLtv { get; set; }

        [DataMember(Name = "lastDisclosureDate")]
        public string LastDisclosureDate { get; set; }

        [DataMember(Name = "lastDisclosureReceivedDate")]
        public string LastDisclosureReceivedDate { get; set; }

        [DataMember(Name = "estimatedEscrow")]
        public decimal? EstimatedEscrow { get; set; }

        [DataMember(Name = "currentFinanceCharge")]
        public decimal? CurrentFinanceCharge { get; set; }

        [DataMember(Name = "masterPolicyHazardCompanyName")]
        public string MasterPolicyHazardCompanyName { get; set; }

        [DataMember(Name = "masterPolicyHazardPolicyNumber")]
        public string MasterPolicyHazardPolicyNumber { get; set; }

        [DataMember(Name = "masterPolicyHazardPolicyEffectiveDate")]
        public string MasterPolicyHazardPolicyEffectiveDate { get; set; }

        [DataMember(Name = "masterPolicyHazardPolicyExpirationDate")]
        public string MasterPolicyHazardPolicyExpirationDate { get; set; }

        [DataMember(Name = "masterPolicyHazardPaymentType")]
        public string MasterPolicyHazardPaymentType { get; set; }

        [DataMember(Name = "masterPolicyHazardCoverageAmount")]
        public decimal? MasterPolicyHazardCoverageAmount { get; set; }

        [DataMember(Name = "masterPolicyFloodCompanyName")]
        public string MasterPolicyFloodCompanyName { get; set; }

        [DataMember(Name = "masterPolicyFloodPolicyNumber")]
        public string MasterPolicyFloodPolicyNumber { get; set; }

        [DataMember(Name = "masterPolicyFloodPolicyEffectiveDate")]
        public string MasterPolicyFloodPolicyEffectiveDate { get; set; }

        [DataMember(Name = "masterPolicyFloodPolicyExpirationDate")]
        public string MasterPolicyFloodPolicyExpirationDate { get; set; }

        [DataMember(Name = "masterPolicyFloodPaymentType")]
        public string MasterPolicyFloodPaymentType { get; set; }

        [DataMember(Name = "masterPolicyFloodCoverageAmount")]
        public decimal? MasterPolicyFloodCoverageAmount { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailCompanyName")]
        public string MasterPolicyWindOrHailCompanyName { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailPolicyNumber")]
        public string MasterPolicyWindOrHailPolicyNumber { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailPolicyEffectiveDate")]
        public string MasterPolicyWindOrHailPolicyEffectiveDate { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailPolicyExpirationDate")]
        public string MasterPolicyWindOrHailPolicyExpirationDate { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailPaymentType")]
        public string MasterPolicyWindOrHailPaymentType { get; set; }

        [DataMember(Name = "masterPolicyWindOrHailCoverageAmount")]
        public decimal? MasterPolicyWindOrHailCoverageAmount { get; set; }

        [DataMember(Name = "masterPolicyOtherInsuranceTypeDescription")]
        public string MasterPolicyOtherInsuranceTypeDescription { get; set; }

        [DataMember(Name = "masterPolicyOtherCompanyName")]
        public string MasterPolicyOtherCompanyName { get; set; }

        [DataMember(Name = "masterPolicyOtherPolicyNumber")]
        public string MasterPolicyOtherPolicyNumber { get; set; }

        [DataMember(Name = "masterPolicyOtherPolicyEffectiveDate")]
        public string MasterPolicyOtherPolicyEffectiveDate { get; set; }

        [DataMember(Name = "masterPolicyOtherPolicyExpirationDate")]
        public string MasterPolicyOtherPolicyExpirationDate { get; set; }

        [DataMember(Name = "masterPolicyOtherPaymentType")]
        public string MasterPolicyOtherPaymentType { get; set; }

        [DataMember(Name = "masterPolicyOtherCoverageAmount")]
        public decimal? MasterPolicyOtherCoverageAmount { get; set; }

        [DataMember(Name = "cashOutNtbComparisonFormIndicator")]
        public bool? CashOutNtbComparisonFormIndicator { get; set; }

        [DataMember(Name = "isTheHighestAndTheBestUseOfSubjectPropertyAsImproved")]
        public string IsTheHighestAndTheBestUseOfSubjectPropertyAsImproved { get; set; }

        [DataMember(Name = "fhaVaCaseNumber")]
        public string FhaVaCaseNumber { get; set; }

        [DataMember(Name = "novAmount")]
        public decimal? NovAmount { get; set; }

        [DataMember(Name = "sarExpirationDate")]
        public string SarExpirationDate { get; set; }

        [DataMember(Name = "conversionModificationDate")]
        public string ConversionModificationDate { get; set; }

        [DataMember(Name = "avmCheckbox")]
        public bool? AvmCheckbox { get; set; }

        [DataMember(Name = "appraisalCheckbox")]
        public bool? AppraisalCheckbox { get; set; }

        [DataMember(Name = "negativeCashFlow")]
        public decimal? NegativeCashFlow { get; set; }

        [DataMember(Name = "usdaOneTimeClose")]
        public bool? UsdaOneTimeClose { get; set; }

        [DataMember(Name = "monthlyAmount")]
        public decimal? MonthlyAmount { get; set; }

        [DataMember(Name = "borPaidDiscountPoints")]
        public decimal? BorPaidDiscountPoints { get; set; }

        [DataMember(Name = "firstRateChangeDate")]
        public string FirstRateChangeDate { get; set; }

        [DataMember(Name = "armIndicator")]
        public bool? ArmIndicator { get; set; }

        [DataMember(Name = "housingRatio")]
        public decimal? HousingRatio { get; set; }

        [DataMember(Name = "otherInsuranceType")]
        public string OtherInsuranceType { get; set; }

        [DataMember(Name = "additionalInsurancePaymentType")]
        public string AdditionalInsurancePaymentType { get; set; }

        [DataMember(Name = "floodPaymentType")]
        public string FloodPaymentType { get; set; }

        [DataMember(Name = "hazardPaymentType")]
        public string HazardPaymentType { get; set; }

        [DataMember(Name = "masterPaymentType")]
        public string MasterPaymentType { get; set; }

        [DataMember(Name = "windHailPaymentType")]
        public string WindHailPaymentType { get; set; }

        [DataMember(Name = "escrowReservesCollectedAtClosing")]
        public decimal? EscrowReservesCollectedAtClosing { get; set; }

        [DataMember(Name = "ausSubmissionNumber")]
        public string AusSubmissionNumber { get; set; }

        [DataMember(Name = "ausLtv")]
        public decimal? AusLtv { get; set; }

        [DataMember(Name = "ausCltv")]
        public decimal? AusCltv { get; set; }

        [DataMember(Name = "ausHcltv")]
        public decimal? AusHcltv { get; set; }

        [DataMember(Name = "ausLoanNumber")]
        public string AusLoanNumber { get; set; }

        [DataMember(Name = "disclosedUpfrontMipFinanced")]
        public decimal? DisclosedUpfrontMipFinanced { get; set; }

        [DataMember(Name = "disclosedTemporaryBuydownFund")]
        public decimal? DisclosedTemporaryBuydownFund { get; set; }

        [DataMember(Name = "highPricedLoanIndicator")]
        public bool? HighPricedLoanIndicator { get; set; }

        [DataMember(Name = "miTerminationDate")]
        public string MiTerminationDate { get; set; }

        [DataMember(Name = "assignmentType")]
        public string AssignmentType { get; set; }

        [DataMember(Name = "cashToOrFromBorrowerAmount")]
        public decimal? CashToOrFromBorrowerAmount { get; set; }

        [DataMember(Name = "includesWindOrHail")]
        public bool? IncludesWindOrHail { get; set; }

        [DataMember(Name = "renovation")]
        public bool? Renovation { get; set; }

        [DataMember(Name = "modification")]
        public bool? Modification { get; set; }

        [DataMember(Name = "modificationDate")]
        public string ModificationDate { get; set; }

        [DataMember(Name = "cashToOrFromBorrowerIndicator")]
        public bool? CashToOrFromBorrowerIndicator { get; set; }

        [DataMember(Name = "documentReceiptDate")]
        public string DocumentReceiptDate { get; set; }

        [DataMember(Name = "sellerPaidDiscountFees")]
        public decimal? SellerPaidDiscountFees { get; set; }

        [DataMember(Name = "discountPointsPaidbyOther")]
        public decimal? DiscountPointsPaidbyOther { get; set; }

        [DataMember(Name = "fhaInsuredDate")]
        public string FhaInsuredDate { get; set; }

        [DataMember(Name = "vaInsuredDate")]
        public string VaInsuredDate { get; set; }

        [DataMember(Name = "renovationProgramIndicator")]
        public bool? RenovationProgramIndicator { get; set; }

        [DataMember(Name = "correspondentLoanMiIndicator")]
        public bool? CorrespondentLoanMiIndicator { get; set; }

        [DataMember(Name = "miPremiumTerm")]
        public int? MiPremiumTerm { get; set; }

        [DataMember(Name = "lenderPaidMiRate")]
        public decimal? LenderPaidMiRate { get; set; }

        [DataMember(Name = "lenderPaidPremiumAmount")]
        public decimal? LenderPaidPremiumAmount { get; set; }

        [DataMember(Name = "miOrderedBy")]
        public string MiOrderedBy { get; set; }

        [DataMember(Name = "activatedDate")]
        public string ActivatedDate { get; set; }

        [DataMember(Name = "activatedBy")]
        public string ActivatedBy { get; set; }

        [DataMember(Name = "nfipProgramType")]
        public string NfipProgramType { get; set; }

        [DataMember(Name = "floodInsuranceCoverageIndicator")]
        public bool? FloodInsuranceCoverageIndicator { get; set; }

        [DataMember(Name = "floodInsuranceIndicator")]
        public bool? FloodInsuranceIndicator { get; set; }

        [DataMember(Name = "hazardInsuranceIndicator")]
        public bool? HazardInsuranceIndicator { get; set; }

        [DataMember(Name = "isHazardIncludedMasterPolicy")]
        public bool? IsHazardIncludedMasterPolicy { get; set; }

        [DataMember(Name = "insuranceType")]
        public string InsuranceType { get; set; }

        [DataMember(Name = "includesWallsIn")]
        public bool? IncludesWallsIn { get; set; }

        [DataMember(Name = "refinanceType")]
        public string RefinanceType { get; set; }

        [DataMember(Name = "interestRateExportationIndicator")]
        public bool? InterestRateExportationIndicator { get; set; }

        [DataMember(Name = "pointsInInitialAdjustedRate")]
        public decimal? PointsInInitialAdjustedRate { get; set; }

        [DataMember(Name = "valuations")]
        public List<ValuationContract> Valuations { get; set; }

        [DataMember(Name = "earlyChecks")]
        public List<EarlyCheckContract> EarlyChecks { get; set; }

        [DataMember(Name = "corrOtherInsurances")]
        public List<CorrOtherInsuranceContract> CorrOtherInsurances { get; set; }

        [DataMember(Name = "riders")]
        public List<RiderContract> Riders { get; set; }

        [DataMember(Name = "scenarios")]
        public List<ScenarioContract> Scenarios { get; set; }

        [DataMember(Name = "disclosures")]
        public List<DisclosureContract> Disclosures { get; set; }
    }
}
