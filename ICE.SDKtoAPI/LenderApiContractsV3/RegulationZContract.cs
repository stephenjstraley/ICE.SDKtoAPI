using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RegulationZContract
    {
        [DataMember(Name = "acknowledgedDay")]
        public string AcknowledgedDay { get; set; }

        [DataMember(Name = "acknowledgedMonth")]
        public string AcknowledgedMonth { get; set; }

        [DataMember(Name = "acknowledgedYear")]
        public string AcknowledgedYear { get; set; }

        [DataMember(Name = "acquisition")]
        public bool? Acquisition { get; set; }

        [DataMember(Name = "additionalArmInformation")]
        public string AdditionalArmInformation { get; set; }

        [DataMember(Name = "allDateAndNumericalDisclosuresIndicator")]
        public bool? AllDateAndNumericalDisclosuresIndicator { get; set; }

        [DataMember(Name = "amountFinanced")]
        public decimal? AmountFinanced { get; set; }

        [DataMember(Name = "aprPercent")]
        public decimal? AprPercent { get; set; }

        [DataMember(Name = "aprPercentUi")]
        public string AprPercentUi { get; set; }

        [DataMember(Name = "armDisclosureDescription")]
        public string ArmDisclosureDescription { get; set; }

        [DataMember(Name = "assumptionOnYourProperty")]
        public string AssumptionOnYourProperty { get; set; }

        [DataMember(Name = "borrowerIntendToContinueDate")]
        public string BorrowerIntendToContinueDate { get; set; }

        [DataMember(Name = "borrowerIntendToContinueIndicator")]
        public bool? BorrowerIntendToContinueIndicator { get; set; }

        [DataMember(Name = "borrowerMiTerminationDate")]
        public string BorrowerMiTerminationDate { get; set; }

        [DataMember(Name = "calculateBasedOnRemainingBalance")]
        public string CalculateBasedOnRemainingBalance { get; set; }

        [DataMember(Name = "chargesAddedToPaymentsIndicator")]
        public bool? ChargesAddedToPaymentsIndicator { get; set; }

        [DataMember(Name = "chargesAtLoanClosingIndicator")]
        public bool? ChargesAtLoanClosingIndicator { get; set; }

        [DataMember(Name = "circumstanceChangeReason")]
        public string CircumstanceChangeReason { get; set; }

        [DataMember(Name = "circumstanceChangeReceivedDate")]
        public string CircumstanceChangeReceivedDate { get; set; }

        [DataMember(Name = "constructionFirstIntChangeAdjType")]
        public string ConstructionFirstIntChangeAdjType { get; set; }

        [DataMember(Name = "constructionLoanDescription")]
        public string ConstructionLoanDescription { get; set; }

        [DataMember(Name = "constructionLoanMethod")]
        public string ConstructionLoanMethod { get; set; }

        [DataMember(Name = "constructionPeriodMonths")]
        public int? ConstructionPeriodMonths { get; set; }

        [DataMember(Name = "constructionRatePercent")]
        public decimal? ConstructionRatePercent { get; set; }

        [DataMember(Name = "constructionRefinanceIndicator")]
        public bool? ConstructionRefinanceIndicator { get; set; }

        [DataMember(Name = "creditDisability")]
        public decimal? CreditDisability { get; set; }

        [DataMember(Name = "creditDisabilityIndicator")]
        public bool? CreditDisabilityIndicator { get; set; }

        [DataMember(Name = "creditLife")]
        public decimal? CreditLife { get; set; }

        [DataMember(Name = "creditLifeAndCreditDisability")]
        public decimal? CreditLifeAndCreditDisability { get; set; }

        [DataMember(Name = "creditLifeInsuranceIndicator")]
        public bool? CreditLifeInsuranceIndicator { get; set; }

        [DataMember(Name = "customizePaymentScheduleIndicator")]
        public bool? CustomizePaymentScheduleIndicator { get; set; }

        [DataMember(Name = "demandFeatureIndicator")]
        public bool? DemandFeatureIndicator { get; set; }

        [DataMember(Name = "disclosedAprPercent")]
        public decimal? DisclosedAprPercent { get; set; }

        [DataMember(Name = "disclosedByBrokerIndicator")]
        public bool? DisclosedByBrokerIndicator { get; set; }

        [DataMember(Name = "disclosedComments")]
        public string DisclosedComments { get; set; }

        [DataMember(Name = "disclosedFinanceCharge")]
        public decimal? DisclosedFinanceCharge { get; set; }

        [DataMember(Name = "disclosureMethod")]
        public string DisclosureMethod { get; set; }

        [DataMember(Name = "disclosureType")]
        public string DisclosureType { get; set; }

        [DataMember(Name = "discountPeriod")]
        public int? DiscountPeriod { get; set; }

        [DataMember(Name = "discountRatePercent")]
        public decimal? DiscountRatePercent { get; set; }

        [DataMember(Name = "discountType")]
        public string DiscountType { get; set; }

        [DataMember(Name = "dueDate")]
        public string DueDate { get; set; }

        [DataMember(Name = "earliestClosingDate")]
        public string EarliestClosingDate { get; set; }

        [DataMember(Name = "earliestFeeCollectionDate")]
        public string EarliestFeeCollectionDate { get; set; }

        [DataMember(Name = "extraPaymentForEarlyPayOff")]
        public decimal? ExtraPaymentForEarlyPayOff { get; set; }

        [DataMember(Name = "feeCollectedDate")]
        public string FeeCollectedDate { get; set; }

        [DataMember(Name = "filingFees")]
        public decimal? FilingFees { get; set; }

        [DataMember(Name = "finalPaymentDate")]
        public string FinalPaymentDate { get; set; }

        [DataMember(Name = "financeCharge")]
        public decimal? FinanceCharge { get; set; }

        [DataMember(Name = "financedAllGuaranteeFeeAmount")]
        public decimal? FinancedAllGuaranteeFeeAmount { get; set; }

        [DataMember(Name = "financedAllGuaranteeFeePercent")]
        public decimal? FinancedAllGuaranteeFeePercent { get; set; }

        [DataMember(Name = "financedAllTotalLoanAmount")]
        public decimal? FinancedAllTotalLoanAmount { get; set; }

        [DataMember(Name = "financedPortionGuaranteeFeeAmount")]
        public decimal? FinancedPortionGuaranteeFeeAmount { get; set; }

        [DataMember(Name = "financedPortionGuaranteeFeePercent")]
        public decimal? FinancedPortionGuaranteeFeePercent { get; set; }

        [DataMember(Name = "financedPortionTotalLoanAmount")]
        public decimal? FinancedPortionTotalLoanAmount { get; set; }

        [DataMember(Name = "financingType")]
        public string FinancingType { get; set; }

        [DataMember(Name = "firstAmortizationPaymentDate")]
        public string FirstAmortizationPaymentDate { get; set; }

        [DataMember(Name = "floodInsuranceIndicator")]
        public bool? FloodInsuranceIndicator { get; set; }

        [DataMember(Name = "gfeApplicationDate")]
        public string GfeApplicationDate { get; set; }

        [DataMember(Name = "gfeChangedCircumstanceIndicator")]
        public bool? GfeChangedCircumstanceIndicator { get; set; }

        [DataMember(Name = "gfeChangedCircumstanceItem")]
        public string GfeChangedCircumstanceItem { get; set; }

        [DataMember(Name = "gfeChangedCirsumstanceItemCode")]
        public string GfeChangedCirsumstanceItemCode { get; set; }

        [DataMember(Name = "gfeDate")]
        public string GfeDate { get; set; }

        [DataMember(Name = "gfeExpirationDate")]
        public string GfeExpirationDate { get; set; }

        [DataMember(Name = "gfeExpirationPeriod")]
        public string GfeExpirationPeriod { get; set; }

        [DataMember(Name = "gfeRateLockRedisclosureRequiredIndicator")]
        public bool? GfeRateLockRedisclosureRequiredIndicator { get; set; }

        [DataMember(Name = "gfeRedisclosureProvidedDate")]
        public string GfeRedisclosureProvidedDate { get; set; }

        [DataMember(Name = "gfeRedisclosureReceivedDate")]
        public string GfeRedisclosureReceivedDate { get; set; }

        [DataMember(Name = "hud1ToleranceViolatedIndicator")]
        public bool? Hud1ToleranceViolatedIndicator { get; set; }

        [DataMember(Name = "hudToleranceResolutionComments")]
        public string HudToleranceResolutionComments { get; set; }

        [DataMember(Name = "hudToleranceResolutionDate")]
        public string HudToleranceResolutionDate { get; set; }

        [DataMember(Name = "hudToleranceResolvedBy")]
        public string HudToleranceResolvedBy { get; set; }

        [DataMember(Name = "ifYouPurchaseIndicator")]
        public bool? IfYouPurchaseIndicator { get; set; }

        [DataMember(Name = "ifYouPurchaseType")]
        public string IfYouPurchaseType { get; set; }

        [DataMember(Name = "includeMiIndicator")]
        public bool? IncludeMiIndicator { get; set; }

        [DataMember(Name = "includePmiIndicator")]
        public bool? IncludePmiIndicator { get; set; }

        [DataMember(Name = "includeTaxesInsuranceIndicator")]
        public bool? IncludeTaxesInsuranceIndicator { get; set; }

        [DataMember(Name = "initialDisclosureDueDate")]
        public string InitialDisclosureDueDate { get; set; }

        [DataMember(Name = "initialDisclosureProvidedDate")]
        public string InitialDisclosureProvidedDate { get; set; }

        [DataMember(Name = "initialGfeAffiliatedBusinessProvidedDate")]
        public string InitialGfeAffiliatedBusinessProvidedDate { get; set; }

        [DataMember(Name = "initialGfeAppraisalProvidedDate")]
        public string InitialGfeAppraisalProvidedDate { get; set; }

        [DataMember(Name = "initialGfeCharmBookletProvidedDate")]
        public string InitialGfeCharmBookletProvidedDate { get; set; }

        [DataMember(Name = "initialGfeDisclosureProvidedDate")]
        public string InitialGfeDisclosureProvidedDate { get; set; }

        [DataMember(Name = "initialGfeDisclosureReceivedDate")]
        public string InitialGfeDisclosureReceivedDate { get; set; }

        [DataMember(Name = "initialGfeHelocBrochureProvidedDate")]
        public string InitialGfeHelocBrochureProvidedDate { get; set; }

        [DataMember(Name = "initialGfeHudSpecialBookletProvidedDate")]
        public string InitialGfeHudSpecialBookletProvidedDate { get; set; }

        [DataMember(Name = "initialTilDisclosureProvidedDate")]
        public string InitialTilDisclosureProvidedDate { get; set; }

        [DataMember(Name = "initialTilDisclosureReceivedDate")]
        public string InitialTilDisclosureReceivedDate { get; set; }

        [DataMember(Name = "insuranceRequiredDescription")]
        public string InsuranceRequiredDescription { get; set; }

        [DataMember(Name = "interestInNameOf")]
        public string InterestInNameOf { get; set; }

        [DataMember(Name = "interestOnly")]
        public bool? InterestOnly { get; set; }

        [DataMember(Name = "interestOnlyIndicator")]
        public bool? InterestOnlyIndicator { get; set; }

        [DataMember(Name = "interestOnlyMonths")]
        public int? InterestOnlyMonths { get; set; }

        [DataMember(Name = "interestRateType")]
        public string InterestRateType { get; set; }

        [DataMember(Name = "interestReserveAmount")]
        public decimal? InterestReserveAmount { get; set; }

        [DataMember(Name = "lendersInspectionFee")]
        public decimal? LendersInspectionFee { get; set; }

        [DataMember(Name = "lastDisclosedBy")]
        public string LastDisclosedBy { get; set; }

        [DataMember(Name = "lastDisclosedDate")]
        public string LastDisclosedDate { get; set; }

        [DataMember(Name = "lastDisclosedGfeReceivedDate")]
        public string LastDisclosedGfeReceivedDate { get; set; }

        [DataMember(Name = "lateChargeComments")]
        public string LateChargeComments { get; set; }

        [DataMember(Name = "lateChargeDays")]
        public int? LateChargeDays { get; set; }

        [DataMember(Name = "lateChargePercent")]
        public decimal? LateChargePercent { get; set; }

        [DataMember(Name = "lateChargeBasis")]
        public decimal? LateChargeBasis { get; set; }

        [DataMember(Name = "lateChargeType")]
        public string LateChargeType { get; set; }

        [DataMember(Name = "lenderPaidMortgageInsuranceIndicator")]
        public bool? LenderPaidMortgageInsuranceIndicator { get; set; }

        [DataMember(Name = "marginPlusIndexPercent")]
        public decimal? MarginPlusIndexPercent { get; set; }

        [DataMember(Name = "maximumLateCharge")]
        public decimal? MaximumLateCharge { get; set; }

        [DataMember(Name = "maximumPayment")]
        public decimal? MaximumPayment { get; set; }

        [DataMember(Name = "meansAnEstimateIndicator")]
        public bool? MeansAnEstimateIndicator { get; set; }

        [DataMember(Name = "miAdjustmentFactorLevel2")]
        public decimal? MiAdjustmentFactorLevel2 { get; set; }

        [DataMember(Name = "miDecliningRenewalsIndicator")]
        public bool? MiDecliningRenewalsIndicator { get; set; }

        [DataMember(Name = "midpointCancellation")]
        public string MidpointCancellation { get; set; }

        [DataMember(Name = "miMonthlyPaymentLevel1")]
        public decimal? MiMonthlyPaymentLevel1 { get; set; }

        [DataMember(Name = "miMonthlyPaymentLevel2")]
        public decimal? MiMonthlyPaymentLevel2 { get; set; }

        [DataMember(Name = "miMonthsOfAdjustmentLevel1")]
        public int? MiMonthsOfAdjustmentLevel1 { get; set; }

        [DataMember(Name = "miMonthsOfAdjustmentLevel2")]
        public int? MiMonthsOfAdjustmentLevel2 { get; set; }

        [DataMember(Name = "minimumLateCharge")]
        public decimal? MinimumLateCharge { get; set; }

        [DataMember(Name = "minimumPayment")]
        public decimal? MinimumPayment { get; set; }

        [DataMember(Name = "mipFactorLocked")]
        public bool? MipFactorLocked { get; set; }

        [DataMember(Name = "miPrepaidIndicator")]
        public bool? MiPrepaidIndicator { get; set; }

        [DataMember(Name = "miScheduledTerminationDate")]
        public string MiScheduledTerminationDate { get; set; }

        [DataMember(Name = "mmiIndicator")]
        public bool? MmiIndicator { get; set; }

        [DataMember(Name = "monthsOfMiPrepaid")]
        public int? MonthsOfMiPrepaid { get; set; }

        [DataMember(Name = "mortgageInsuranceCancelPercent")]
        public decimal? MortgageInsuranceCancelPercent { get; set; }

        [DataMember(Name = "namePreparedBy")]
        public string NamePreparedBy { get; set; }

        [DataMember(Name = "newConstructionIndicator")]
        public string NewConstructionIndicator { get; set; }

        [DataMember(Name = "numberOfPayments")]
        public int? NumberOfPayments { get; set; }

        [DataMember(Name = "originalContractDate")]
        public string OriginalContractDate { get; set; }

        [DataMember(Name = "outstandingBalance")]
        public decimal? OutstandingBalance { get; set; }

        [DataMember(Name = "paymentFrequencyType")]
        public string PaymentFrequencyType { get; set; }

        [DataMember(Name = "paymentIncreasePercent")]
        public decimal? PaymentIncreasePercent { get; set; }

        [DataMember(Name = "phonePreparedBy")]
        public string PhonePreparedBy { get; set; }

        [DataMember(Name = "pmiIndicator")]
        public bool? PmiIndicator { get; set; }

        [DataMember(Name = "pmiMidpointCancelationDate")]
        public string PmiMidpointCancelationDate { get; set; }

        [DataMember(Name = "prepaidFinanceCharge")]
        public decimal? PrepaidFinanceCharge { get; set; }

        [DataMember(Name = "propertyInsuranceIndicator")]
        public bool? PropertyInsuranceIndicator { get; set; }

        [DataMember(Name = "rateLockGfeDueDate")]
        public string RateLockGfeDueDate { get; set; }

        [DataMember(Name = "ratePercent")]
        public decimal? RatePercent { get; set; }

        [DataMember(Name = "recastPaidMonths")]
        public int? RecastPaidMonths { get; set; }

        [DataMember(Name = "recastStopMonths")]
        public int? RecastStopMonths { get; set; }

        [DataMember(Name = "refundPaymentIndicator")]
        public bool? RefundPaymentIndicator { get; set; }

        [DataMember(Name = "refundUnearnedMipIndicator")]
        public bool? RefundUnearnedMipIndicator { get; set; }

        [DataMember(Name = "regulationZInterestRatePeriods")]
        public List<RegulationZInterestRatePeriodContract> RegulationZInterestRatePeriods { get; set; }

        [DataMember(Name = "regulationZPayments")]
        public List<RegulationZPaymentContract> RegulationZPayments { get; set; }

        [DataMember(Name = "regzTableType")]
        public string RegzTableType { get; set; }

        [DataMember(Name = "requiredDepositIndicator")]
        public bool? RequiredDepositIndicator { get; set; }

        [DataMember(Name = "revisedGfeDueDate")]
        public string RevisedGfeDueDate { get; set; }

        [DataMember(Name = "roundedMarginPlusIndexPercent")]
        public decimal? RoundedMarginPlusIndexPercent { get; set; }

        [DataMember(Name = "samplePayments")]
        public decimal? SamplePayments { get; set; }

        [DataMember(Name = "securityType")]
        public string SecurityType { get; set; }

        [DataMember(Name = "tilDate")]
        public string TilDate { get; set; }

        [DataMember(Name = "tilDisclosedComments")]
        public string TilDisclosedComments { get; set; }

        [DataMember(Name = "tilDisclosureMethod")]
        public string TilDisclosureMethod { get; set; }

        [DataMember(Name = "tilLastDisclosedBorrowerReceivedDate")]
        public string TilLastDisclosedBorrowerReceivedDate { get; set; }

        [DataMember(Name = "tilLastDisclosedBy")]
        public string TilLastDisclosedBy { get; set; }

        [DataMember(Name = "tilLastDisclosedDate")]
        public string TilLastDisclosedDate { get; set; }

        [DataMember(Name = "tilRedisclosureProvidedDate")]
        public string TilRedisclosureProvidedDate { get; set; }

        [DataMember(Name = "tilRedisclosureReceivedDate")]
        public string TilRedisclosureReceivedDate { get; set; }

        [DataMember(Name = "totalBrokerFees")]
        public decimal? TotalBrokerFees { get; set; }

        [DataMember(Name = "totalLenderFees")]
        public decimal? TotalLenderFees { get; set; }

        [DataMember(Name = "totalOfPayments")]
        public decimal? TotalOfPayments { get; set; }

        [DataMember(Name = "useCustomLenderProfile")]
        public bool? UseCustomLenderProfile { get; set; }

        [DataMember(Name = "useDaysInYears")]
        public string UseDaysInYears { get; set; }

        [DataMember(Name = "usePitiForRatioIndicator")]
        public bool? UsePitiForRatioIndicator { get; set; }

        [DataMember(Name = "variableRateFeatureIndicator")]
        public bool? VariableRateFeatureIndicator { get; set; }

        [DataMember(Name = "yearlyTerm")]
        public decimal? YearlyTerm { get; set; }

        [DataMember(Name = "monthlyTerm")]
        public decimal? MonthlyTerm { get; set; }

        [DataMember(Name = "yearOfMaximumPayment")]
        public string YearOfMaximumPayment { get; set; }

        [DataMember(Name = "years")]
        public int? Years { get; set; }

        [DataMember(Name = "miPrepaidAmount")]
        public decimal? MiPrepaidAmount { get; set; }

        [DataMember(Name = "leSentOnDate")]
        public string LeSentOnDate { get; set; }

        [DataMember(Name = "leReceivedBy")]
        public string LeReceivedBy { get; set; }

        [DataMember(Name = "leReceivedMethod")]
        public string LeReceivedMethod { get; set; }

        [DataMember(Name = "leReceivedMethodOther")]
        public string LeReceivedMethodOther { get; set; }

        [DataMember(Name = "leIntentToProceedComment")]
        public string LeIntentToProceedComment { get; set; }

        [DataMember(Name = "closingDisclosureSentDate")]
        public string ClosingDisclosureSentDate { get; set; }

        [DataMember(Name = "closingDisclosureReceivedDate")]
        public string ClosingDisclosureReceivedDate { get; set; }

        [DataMember(Name = "revisedClosingDisclosureSentDate")]
        public string RevisedClosingDisclosureSentDate { get; set; }

        [DataMember(Name = "revisedClosingDisclosureReceivedDate")]
        public string RevisedClosingDisclosureReceivedDate { get; set; }

        [DataMember(Name = "postConsummationDisclosureSentDate")]
        public string PostConsummationDisclosureSentDate { get; set; }

        [DataMember(Name = "postConsummationDisclosureReceivedDate")]
        public string PostConsummationDisclosureReceivedDate { get; set; }

        [DataMember(Name = "eSignConsentDate")]
        public string ESignConsentDate { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus1")]
        public string ESignConsentBorrowerStatus1 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted1")]
        public string ESignConsentBorrowerDateAccepted1 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress1")]
        public string ESignConsentBorrowerIpAddress1 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource1")]
        public string ESignConsentBorrowerSource1 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus1")]
        public string ESignConsentCoBorrowerStatus1 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted1")]
        public string ESignConsentCoBorrowerDateAccepted1 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress1")]
        public string ESignConsentCoBorrowerIpAddress1 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource1")]
        public string ESignConsentCoBorrowerSource1 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus2")]
        public string ESignConsentBorrowerStatus2 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted2")]
        public string ESignConsentBorrowerDateAccepted2 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress2")]
        public string ESignConsentBorrowerIpAddress2 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource2")]
        public string ESignConsentBorrowerSource2 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus2")]
        public string ESignConsentCoBorrowerStatus2 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted2")]
        public string ESignConsentCoBorrowerDateAccepted2 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress2")]
        public string ESignConsentCoBorrowerIpAddress2 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource2")]
        public string ESignConsentCoBorrowerSource2 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus3")]
        public string ESignConsentBorrowerStatus3 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted3")]
        public string ESignConsentBorrowerDateAccepted3 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress3")]
        public string ESignConsentBorrowerIpAddress3 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource3")]
        public string ESignConsentBorrowerSource3 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus3")]
        public string ESignConsentCoBorrowerStatus3 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted3")]
        public string ESignConsentCoBorrowerDateAccepted3 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress3")]
        public string ESignConsentCoBorrowerIpAddress3 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource3")]
        public string ESignConsentCoBorrowerSource3 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus4")]
        public string ESignConsentBorrowerStatus4 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted4")]
        public string ESignConsentBorrowerDateAccepted4 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress4")]
        public string ESignConsentBorrowerIpAddress4 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource4")]
        public string ESignConsentBorrowerSource4 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus4")]
        public string ESignConsentCoBorrowerStatus4 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted4")]
        public string ESignConsentCoBorrowerDateAccepted4 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress4")]
        public string ESignConsentCoBorrowerIpAddress4 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource4")]
        public string ESignConsentCoBorrowerSource4 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus5")]
        public string ESignConsentBorrowerStatus5 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted5")]
        public string ESignConsentBorrowerDateAccepted5 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress5")]
        public string ESignConsentBorrowerIpAddress5 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource5")]
        public string ESignConsentBorrowerSource5 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus5")]
        public string ESignConsentCoBorrowerStatus5 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted5")]
        public string ESignConsentCoBorrowerDateAccepted5 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress5")]
        public string ESignConsentCoBorrowerIpAddress5 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource5")]
        public string ESignConsentCoBorrowerSource5 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerStatus6")]
        public string ESignConsentBorrowerStatus6 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerDateAccepted6")]
        public string ESignConsentBorrowerDateAccepted6 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerIpAddress6")]
        public string ESignConsentBorrowerIpAddress6 { get; set; }

        [DataMember(Name = "eSignConsentBorrowerSource6")]
        public string ESignConsentBorrowerSource6 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerStatus6")]
        public string ESignConsentCoBorrowerStatus6 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerDateAccepted6")]
        public string ESignConsentCoBorrowerDateAccepted6 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerIpAddress6")]
        public string ESignConsentCoBorrowerIpAddress6 { get; set; }

        [DataMember(Name = "eSignConsentCoBorrowerSource6")]
        public string ESignConsentCoBorrowerSource6 { get; set; }

        [DataMember(Name = "ssplSentDate")]
        public string SsplSentDate { get; set; }

        [DataMember(Name = "safeHarborSentDate")]
        public string SafeHarborSentDate { get; set; }

        [DataMember(Name = "disclosedProduct")]
        public string DisclosedProduct { get; set; }

        [DataMember(Name = "disclosedPrepayment")]
        public bool? DisclosedPrepayment { get; set; }

        [DataMember(Name = "highCostDisclosure")]
        public string HighCostDisclosure { get; set; }

        [DataMember(Name = "totalOfPrincipalAndInterest")]
        public decimal? TotalOfPrincipalAndInterest { get; set; }

        [DataMember(Name = "occupancyCertDate")]
        public string OccupancyCertDate { get; set; }

        [DataMember(Name = "lateFee")]
        public decimal? LateFee { get; set; }

        [DataMember(Name = "totalLatePayment")]
        public decimal? TotalLatePayment { get; set; }

        [DataMember(Name = "initialSubsequentAppraisalProvidedDate")]
        public string InitialSubsequentAppraisalProvidedDate { get; set; }

        [DataMember(Name = "initialAvmProvidedDate")]
        public string InitialAvmProvidedDate { get; set; }

        [DataMember(Name = "homeCounselingProvidedDate")]
        public string HomeCounselingProvidedDate { get; set; }

        [DataMember(Name = "disclosedDailyInterestCharge")]
        public decimal? DisclosedDailyInterestCharge { get; set; }

        [DataMember(Name = "feeLevelDisclosuresIndicator")]
        public bool? FeeLevelDisclosuresIndicator { get; set; }

        [DataMember(Name = "helocTeaserRatePeriod")]
        public int? HelocTeaserRatePeriod { get; set; }

        [DataMember(Name = "externaleConsent")]
        public string ExternaleConsent { get; set; }

        [DataMember(Name = "landValueType")]
        public string LandValueType { get; set; }

        [DataMember(Name = "zeroPercentPaymentOption")]
        public string ZeroPercentPaymentOption { get; set; }

        [DataMember(Name = "interestAccrual")]
        public string InterestAccrual { get; set; }

        [DataMember(Name = "simpleInterestLeapYearIndicator")]
        public bool? SimpleInterestLeapYearIndicator { get; set; }

        [DataMember(Name = "simpleInterestAccrualIndicator")]
        public bool? SimpleInterestAccrualIndicator { get; set; }

    }
}
