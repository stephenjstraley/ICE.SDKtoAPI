using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZ
	{
		[DataMember(Name="acknowledgedDay")]
		public string AcknowledgedDay { get; set; }

		[DataMember(Name="acknowledgedMonth")]
		public string AcknowledgedMonth { get; set; }

		[DataMember(Name="acknowledgedYear")]
		public string AcknowledgedYear { get; set; }

		[DataMember(Name="acquisition")]
		public bool? Acquisition { get; set; }

		[DataMember(Name="additionalArmInformation")]
		public string AdditionalArmInformation { get; set; }

		[DataMember(Name="allDateAndNumericalDisclosuresIndicator")]
		public bool? AllDateAndNumericalDisclosuresIndicator { get; set; }

		[DataMember(Name="amountFinanced")]
		public decimal? AmountFinanced { get; set; }

		[DataMember(Name="aprPercent")]
		public decimal? AprPercent { get; set; }

		[DataMember(Name="aprPercentUI")]
		public string AprPercentUI { get; set; }

		[DataMember(Name="armDisclosureDescription")]
		public string ArmDisclosureDescription { get; set; }

		[DataMember(Name="assumptionOnYourProperty")]
		public string AssumptionOnYourProperty { get; set; }

		[DataMember(Name="borrowerIntendToContinueDate")]
		public DateTime? BorrowerIntendToContinueDate { get; set; }

		[DataMember(Name="borrowerIntendToContinueIndicator")]
		public bool? BorrowerIntendToContinueIndicator { get; set; }

		[DataMember(Name="borrowerMiTerminationDate")]
		public string BorrowerMiTerminationDate { get; set; }

		[DataMember(Name="calculateBasedOnRemainingBalance")]
		public string CalculateBasedOnRemainingBalance { get; set; }

		[DataMember(Name="chargesAddedToPaymentsIndicator")]
		public bool? ChargesAddedToPaymentsIndicator { get; set; }

		[DataMember(Name="chargesAtLoanClosingIndicator")]
		public bool? ChargesAtLoanClosingIndicator { get; set; }

		[DataMember(Name="circumstanceChangeReason")]
		public string CircumstanceChangeReason { get; set; }

		[DataMember(Name="circumstanceChangeReceivedDate")]
		public DateTime? CircumstanceChangeReceivedDate { get; set; }

		[DataMember(Name="closingDisclosureReceivedDate")]
		public DateTime? ClosingDisclosureReceivedDate { get; set; }

		[DataMember(Name="closingDisclosureSentDate")]
		public DateTime? ClosingDisclosureSentDate { get; set; }

		[DataMember(Name="constructionFirstIntChangeAdjType")]
		public string ConstructionFirstIntChangeAdjType { get; set; }

		[DataMember(Name="constructionLoanDescription")]
		public string ConstructionLoanDescription { get; set; }

		[DataMember(Name="constructionLoanMethod")]
		public string ConstructionLoanMethod { get; set; }

		[DataMember(Name="constructionPeriodMonths")]
		public int? ConstructionPeriodMonths { get; set; }

		[DataMember(Name="constructionRatePercent")]
		public decimal? ConstructionRatePercent { get; set; }

		[DataMember(Name="constructionRefinanceIndicator")]
		public bool? ConstructionRefinanceIndicator { get; set; }

		[DataMember(Name="creditDisability")]
		public decimal? CreditDisability { get; set; }

		[DataMember(Name="creditDisabilityIndicator")]
		public bool? CreditDisabilityIndicator { get; set; }

		[DataMember(Name="creditLife")]
		public decimal? CreditLife { get; set; }

		[DataMember(Name="creditLifeAndCreditDisability")]
		public decimal? CreditLifeAndCreditDisability { get; set; }

		[DataMember(Name="creditLifeInsuranceIndicator")]
		public bool? CreditLifeInsuranceIndicator { get; set; }

		[DataMember(Name="customizePaymentScheduleIndicator")]
		public bool? CustomizePaymentScheduleIndicator { get; set; }

		[DataMember(Name="demandFeatureIndicator")]
		public bool? DemandFeatureIndicator { get; set; }

		[DataMember(Name="disclosedAprPercent")]
		public decimal? DisclosedAprPercent { get; set; }

		[DataMember(Name="disclosedByBrokerIndicator")]
		public bool? DisclosedByBrokerIndicator { get; set; }

		[DataMember(Name="disclosedComments")]
		public string DisclosedComments { get; set; }

		[DataMember(Name="disclosedDailyInterestCharge")]
		public decimal? DisclosedDailyInterestCharge { get; set; }

		[DataMember(Name="disclosedFinanceCharge")]
		public decimal? DisclosedFinanceCharge { get; set; }

		[DataMember(Name="disclosedPrepayment")]
		public bool? DisclosedPrepayment { get; set; }

		[DataMember(Name="disclosedProduct")]
		public string DisclosedProduct { get; set; }

		[DataMember(Name="disclosureMethod")]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType")]
		public string DisclosureType { get; set; }

		[DataMember(Name="discountPeriod")]
		public int? DiscountPeriod { get; set; }

		[DataMember(Name="discountRatePercent")]
		public decimal? DiscountRatePercent { get; set; }

		[DataMember(Name="discountType")]
		public string DiscountType { get; set; }

		[DataMember(Name="dueDate")]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="earliestClosingDate")]
		public DateTime? EarliestClosingDate { get; set; }

		[DataMember(Name="earliestFeeCollectionDate")]
		public DateTime? EarliestFeeCollectionDate { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted1")]
		public DateTime? ESignConsentBorrowerDateAccepted1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted2")]
		public DateTime? ESignConsentBorrowerDateAccepted2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted3")]
		public DateTime? ESignConsentBorrowerDateAccepted3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted4")]
		public DateTime? ESignConsentBorrowerDateAccepted4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted5")]
		public DateTime? ESignConsentBorrowerDateAccepted5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted6")]
		public DateTime? ESignConsentBorrowerDateAccepted6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress1")]
		public string ESignConsentBorrowerIPAddress1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress2")]
		public string ESignConsentBorrowerIPAddress2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress3")]
		public string ESignConsentBorrowerIPAddress3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress4")]
		public string ESignConsentBorrowerIPAddress4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress5")]
		public string ESignConsentBorrowerIPAddress5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress6")]
		public string ESignConsentBorrowerIPAddress6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource1")]
		public string ESignConsentBorrowerSource1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource2")]
		public string ESignConsentBorrowerSource2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource3")]
		public string ESignConsentBorrowerSource3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource4")]
		public string ESignConsentBorrowerSource4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource5")]
		public string ESignConsentBorrowerSource5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource6")]
		public string ESignConsentBorrowerSource6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus1")]
		public string ESignConsentBorrowerStatus1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus2")]
		public string ESignConsentBorrowerStatus2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus3")]
		public string ESignConsentBorrowerStatus3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus4")]
		public string ESignConsentBorrowerStatus4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus5")]
		public string ESignConsentBorrowerStatus5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus6")]
		public string ESignConsentBorrowerStatus6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted1")]
		public DateTime? ESignConsentCoBorrowerDateAccepted1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted2")]
		public DateTime? ESignConsentCoBorrowerDateAccepted2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted3")]
		public DateTime? ESignConsentCoBorrowerDateAccepted3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted4")]
		public DateTime? ESignConsentCoBorrowerDateAccepted4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted5")]
		public DateTime? ESignConsentCoBorrowerDateAccepted5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted6")]
		public DateTime? ESignConsentCoBorrowerDateAccepted6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress1")]
		public string ESignConsentCoBorrowerIPAddress1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress2")]
		public string ESignConsentCoBorrowerIPAddress2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress3")]
		public string ESignConsentCoBorrowerIPAddress3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress4")]
		public string ESignConsentCoBorrowerIPAddress4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress5")]
		public string ESignConsentCoBorrowerIPAddress5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress6")]
		public string ESignConsentCoBorrowerIPAddress6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource1")]
		public string ESignConsentCoBorrowerSource1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource2")]
		public string ESignConsentCoBorrowerSource2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource3")]
		public string ESignConsentCoBorrowerSource3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource4")]
		public string ESignConsentCoBorrowerSource4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource5")]
		public string ESignConsentCoBorrowerSource5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource6")]
		public string ESignConsentCoBorrowerSource6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus1")]
		public string ESignConsentCoBorrowerStatus1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus2")]
		public string ESignConsentCoBorrowerStatus2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus3")]
		public string ESignConsentCoBorrowerStatus3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus4")]
		public string ESignConsentCoBorrowerStatus4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus5")]
		public string ESignConsentCoBorrowerStatus5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus6")]
		public string ESignConsentCoBorrowerStatus6 { get; set; }

		[DataMember(Name="eSignConsentDate")]
		public DateTime? ESignConsentDate { get; set; }

		[DataMember(Name="externaleConsent")]
		public string ExternaleConsent { get; set; }

		[DataMember(Name="extraPaymentForEarlyPayOff")]
		public decimal? ExtraPaymentForEarlyPayOff { get; set; }

		[DataMember(Name="feeCollectedDate")]
		public DateTime? FeeCollectedDate { get; set; }

		[DataMember(Name="feeLevelDisclosuresIndicator")]
		public bool? FeeLevelDisclosuresIndicator { get; set; }

		[DataMember(Name="filingFees")]
		public decimal? FilingFees { get; set; }

		[DataMember(Name="finalPaymentDate")]
		public DateTime? FinalPaymentDate { get; set; }

		[DataMember(Name="financeCharge")]
		public decimal? FinanceCharge { get; set; }

		[DataMember(Name="financedAllGuaranteeFeeAmount")]
		public decimal? FinancedAllGuaranteeFeeAmount { get; set; }

		[DataMember(Name="financedAllGuaranteeFeePercent")]
		public decimal? FinancedAllGuaranteeFeePercent { get; set; }

		[DataMember(Name="financedAllTotalLoanAmount")]
		public decimal? FinancedAllTotalLoanAmount { get; set; }

		[DataMember(Name="financedPortionGuaranteeFeeAmount")]
		public decimal? FinancedPortionGuaranteeFeeAmount { get; set; }

		[DataMember(Name="financedPortionGuaranteeFeePercent")]
		public decimal? FinancedPortionGuaranteeFeePercent { get; set; }

		[DataMember(Name="financedPortionTotalLoanAmount")]
		public decimal? FinancedPortionTotalLoanAmount { get; set; }

		[DataMember(Name="financingType")]
		public string FinancingType { get; set; }

		[DataMember(Name="firstAmortizationPaymentDate")]
		public DateTime? FirstAmortizationPaymentDate { get; set; }

		[DataMember(Name="floodInsuranceIndicator")]
		public bool? FloodInsuranceIndicator { get; set; }

		[DataMember(Name="gfeApplicationDate")]
		public DateTime? GfeApplicationDate { get; set; }

		[DataMember(Name="gfeChangedCircumstanceIndicator")]
		public bool? GfeChangedCircumstanceIndicator { get; set; }

		[DataMember(Name="gfeChangedCircumstanceItem")]
		public string GfeChangedCircumstanceItem { get; set; }

		[DataMember(Name="gFEChangedCirsumstanceItemCode")]
		public string GFEChangedCirsumstanceItemCode { get; set; }

		[DataMember(Name="gfeDate")]
		public DateTime? GfeDate { get; set; }

		[DataMember(Name="gfeExpirationDate")]
		public DateTime? GfeExpirationDate { get; set; }

		[DataMember(Name="gfeExpirationPeriod")]
		public string GfeExpirationPeriod { get; set; }

		[DataMember(Name="gfeRateLockRedisclosureRequiredIndicator")]
		public bool? GfeRateLockRedisclosureRequiredIndicator { get; set; }

		[DataMember(Name="gfeRedisclosureProvidedDate")]
		public DateTime? GfeRedisclosureProvidedDate { get; set; }

		[DataMember(Name="gfeRedisclosureReceivedDate")]
		public DateTime? GfeRedisclosureReceivedDate { get; set; }

		[DataMember(Name="helocTeaserRatePeriod")]
		public int? HelocTeaserRatePeriod { get; set; }

		[DataMember(Name="highCostDisclosure")]
		public DateTime? HighCostDisclosure { get; set; }

		[DataMember(Name="homeCounselingProvidedDate")]
		public DateTime? HomeCounselingProvidedDate { get; set; }

		[DataMember(Name="hud1ToleranceViolatedIndicator")]
		public bool? Hud1ToleranceViolatedIndicator { get; set; }

		[DataMember(Name="hudToleranceResolutionComments")]
		public string HudToleranceResolutionComments { get; set; }

		[DataMember(Name="hudToleranceResolutionDate")]
		public DateTime? HudToleranceResolutionDate { get; set; }

		[DataMember(Name="hudToleranceResolvedBy")]
		public string HudToleranceResolvedBy { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="ifYouPurchaseIndicator")]
		public bool? IfYouPurchaseIndicator { get; set; }

		[DataMember(Name="ifYouPurchaseType")]
		public string IfYouPurchaseType { get; set; }

		[DataMember(Name="includeMiIndicator")]
		public bool? IncludeMiIndicator { get; set; }

		[DataMember(Name="includePmiIndicator")]
		public bool? IncludePmiIndicator { get; set; }

		[DataMember(Name="includeTaxesInsuranceIndicator")]
		public bool? IncludeTaxesInsuranceIndicator { get; set; }

		[DataMember(Name="initialAVMProvidedDate")]
		public DateTime? InitialAVMProvidedDate { get; set; }

		[DataMember(Name="initialDisclosureDueDate")]
		public DateTime? InitialDisclosureDueDate { get; set; }

		[DataMember(Name="initialDisclosureProvidedDate")]
		public DateTime? InitialDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialGfeAffiliatedBusinessProvidedDate")]
		public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get; set; }

		[DataMember(Name="initialGFEAppraisalProvidedDate")]
		public DateTime? InitialGFEAppraisalProvidedDate { get; set; }

		[DataMember(Name="initialGfeCharmBookletProvidedDate")]
		public DateTime? InitialGfeCharmBookletProvidedDate { get; set; }

		[DataMember(Name="initialGfeDisclosureProvidedDate")]
		public DateTime? InitialGfeDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialGfeDisclosureReceivedDate")]
		public DateTime? InitialGfeDisclosureReceivedDate { get; set; }

		[DataMember(Name="initialGfeHelocBrochureProvidedDate")]
		public DateTime? InitialGfeHelocBrochureProvidedDate { get; set; }

		[DataMember(Name="initialGfeHudSpecialBookletProvidedDate")]
		public DateTime? InitialGfeHudSpecialBookletProvidedDate { get; set; }

		[DataMember(Name="initialSubsequentAppraisalProvidedDate")]
		public DateTime? InitialSubsequentAppraisalProvidedDate { get; set; }

		[DataMember(Name="initialTilDisclosureProvidedDate")]
		public DateTime? InitialTilDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialTilDisclosureReceivedDate")]
		public DateTime? InitialTilDisclosureReceivedDate { get; set; }

		[DataMember(Name="insuranceRequiredDescription")]
		public string InsuranceRequiredDescription { get; set; }

		[DataMember(Name="interestInNameOf")]
		public string InterestInNameOf { get; set; }

		[DataMember(Name="interestOnly")]
		public bool? InterestOnly { get; set; }

		[DataMember(Name="interestOnlyIndicator")]
		public bool? InterestOnlyIndicator { get; set; }

		[DataMember(Name="interestOnlyMonths")]
		public int? InterestOnlyMonths { get; set; }

		[DataMember(Name="interestRateType")]
		public string InterestRateType { get; set; }

		[DataMember(Name="interestReserveAmount")]
		public decimal? InterestReserveAmount { get; set; }

		[DataMember(Name="lastDisclosedBy")]
		public string LastDisclosedBy { get; set; }

		[DataMember(Name="lastDisclosedDate")]
		public DateTime? LastDisclosedDate { get; set; }

		[DataMember(Name="lastDisclosedGfeReceivedDate")]
		public DateTime? LastDisclosedGfeReceivedDate { get; set; }

		[DataMember(Name="lateChargeBasis")]
		public decimal? LateChargeBasis { get; set; }

		[DataMember(Name="lateChargeComments")]
		public string LateChargeComments { get; set; }

		[DataMember(Name="lateChargeDays")]
		public int? LateChargeDays { get; set; }

		[DataMember(Name="lateChargePercent")]
		public decimal? LateChargePercent { get; set; }

		[DataMember(Name="lateChargeType")]
		public string LateChargeType { get; set; }

		[DataMember(Name="lateFee")]
		public decimal? LateFee { get; set; }

		[DataMember(Name="lEIntentToProceedComment")]
		public string LEIntentToProceedComment { get; set; }

		[DataMember(Name="lenderPaidMortgageInsuranceIndicator")]
		public bool? LenderPaidMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="lendersInspectionFee")]
		public decimal? LendersInspectionFee { get; set; }

		[DataMember(Name="lEReceivedBy")]
		public string LEReceivedBy { get; set; }

		[DataMember(Name="lEReceivedMethod")]
		public string LEReceivedMethod { get; set; }

		[DataMember(Name="lEReceivedMethodOther")]
		public string LEReceivedMethodOther { get; set; }

		[DataMember(Name="lESentOnDate")]
		public DateTime? LESentOnDate { get; set; }

		[DataMember(Name="marginPlusIndexPercent")]
		public decimal? MarginPlusIndexPercent { get; set; }

		[DataMember(Name="maximumLateCharge")]
		public decimal? MaximumLateCharge { get; set; }

		[DataMember(Name="maximumPayment")]
		public decimal? MaximumPayment { get; set; }

		[DataMember(Name="meansAnEstimateIndicator")]
		public bool? MeansAnEstimateIndicator { get; set; }

		[DataMember(Name="miAdjustmentFactorLevel2")]
		public decimal? MiAdjustmentFactorLevel2 { get; set; }

		[DataMember(Name="miDecliningRenewalsIndicator")]
		public bool? MiDecliningRenewalsIndicator { get; set; }

		[DataMember(Name="midpointCancellation")]
		public string MidpointCancellation { get; set; }

		[DataMember(Name="miMonthlyPaymentLevel1")]
		public decimal? MiMonthlyPaymentLevel1 { get; set; }

		[DataMember(Name="miMonthlyPaymentLevel2")]
		public decimal? MiMonthlyPaymentLevel2 { get; set; }

		[DataMember(Name="miMonthsOfAdjustmentLevel1")]
		public int? MiMonthsOfAdjustmentLevel1 { get; set; }

		[DataMember(Name="miMonthsOfAdjustmentLevel2")]
		public int? MiMonthsOfAdjustmentLevel2 { get; set; }

		[DataMember(Name="minimumLateCharge")]
		public decimal? MinimumLateCharge { get; set; }

		[DataMember(Name="minimumPayment")]
		public decimal? MinimumPayment { get; set; }

		[DataMember(Name="mIPFactorLocked")]
		public bool? MIPFactorLocked { get; set; }

		[DataMember(Name="mIPrepaidAmount")]
		public decimal? MIPrepaidAmount { get; set; }

		[DataMember(Name="miPrepaidIndicator")]
		public bool? MiPrepaidIndicator { get; set; }

		[DataMember(Name="miScheduledTerminationDate")]
		public string MiScheduledTerminationDate { get; set; }

		[DataMember(Name="mmiIndicator")]
		public bool? MmiIndicator { get; set; }

		[DataMember(Name="monthlyTerm")]
		public decimal? MonthlyTerm { get; set; }

		[DataMember(Name="monthsOfMiPrepaid")]
		public int? MonthsOfMiPrepaid { get; set; }

		[DataMember(Name="mortgageInsuranceCancelPercent")]
		public decimal? MortgageInsuranceCancelPercent { get; set; }

		[DataMember(Name="namePreparedBy")]
		public string NamePreparedBy { get; set; }

		[DataMember(Name="newConstructionIndicator")]
		public string NewConstructionIndicator { get; set; }

		[DataMember(Name="numberOfPayments")]
		public int? NumberOfPayments { get; set; }

		[DataMember(Name="occupancyCertDate")]
		public DateTime? OccupancyCertDate { get; set; }

		[DataMember(Name="originalContractDate")]
		public DateTime? OriginalContractDate { get; set; }

		[DataMember(Name="outstandingBalance")]
		public decimal? OutstandingBalance { get; set; }

		[DataMember(Name="paymentFrequencyType")]
		public string PaymentFrequencyType { get; set; }

		[DataMember(Name="paymentIncreasePercent")]
		public decimal? PaymentIncreasePercent { get; set; }

		[DataMember(Name="phonePreparedBy")]
		public string PhonePreparedBy { get; set; }

		[DataMember(Name="pmiIndicator")]
		public bool? PmiIndicator { get; set; }

		[DataMember(Name="pmiMidpointCancelationDate")]
		public DateTime? PmiMidpointCancelationDate { get; set; }

		[DataMember(Name="postConsummationDisclosureReceivedDate")]
		public DateTime? PostConsummationDisclosureReceivedDate { get; set; }

		[DataMember(Name="postConsummationDisclosureSentDate")]
		public DateTime? PostConsummationDisclosureSentDate { get; set; }

		[DataMember(Name="prepaidFinanceCharge")]
		public decimal? PrepaidFinanceCharge { get; set; }

		[DataMember(Name="propertyInsuranceIndicator")]
		public bool? PropertyInsuranceIndicator { get; set; }

		[DataMember(Name="rateLockGfeDueDate")]
		public DateTime? RateLockGfeDueDate { get; set; }

		[DataMember(Name="ratePercent")]
		public decimal? RatePercent { get; set; }

		[DataMember(Name="recastPaidMonths")]
		public int? RecastPaidMonths { get; set; }

		[DataMember(Name="recastStopMonths")]
		public int? RecastStopMonths { get; set; }

		[DataMember(Name="refundPaymentIndicator")]
		public bool? RefundPaymentIndicator { get; set; }

		[DataMember(Name="refundUnearnedMipIndicator")]
		public bool? RefundUnearnedMipIndicator { get; set; }

		[DataMember(Name="regulationZInterestRatePeriods")]
		public List<LoanContractRegulationZRegulationZInterestRatePeriods> RegulationZInterestRatePeriods { get; set; }

		[DataMember(Name="regulationZPayments")]
		public List<LoanContractRegulationZRegulationZPayments> RegulationZPayments { get; set; }

		[DataMember(Name="regzTableType")]
		public string RegzTableType { get; set; }

		[DataMember(Name="requiredDepositIndicator")]
		public bool? RequiredDepositIndicator { get; set; }

		[DataMember(Name="revisedClosingDisclosureReceivedDate")]
		public DateTime? RevisedClosingDisclosureReceivedDate { get; set; }

		[DataMember(Name="revisedClosingDisclosureSentDate")]
		public DateTime? RevisedClosingDisclosureSentDate { get; set; }

		[DataMember(Name="revisedGfeDueDate")]
		public DateTime? RevisedGfeDueDate { get; set; }

		[DataMember(Name="roundedMarginPlusIndexPercent")]
		public decimal? RoundedMarginPlusIndexPercent { get; set; }

		[DataMember(Name="safeHarborSentDate")]
		public DateTime? SafeHarborSentDate { get; set; }

		[DataMember(Name="samplePayments")]
		public decimal? SamplePayments { get; set; }

		[DataMember(Name="securityType")]
		public string SecurityType { get; set; }

		[DataMember(Name="sSPLSentDate")]
		public DateTime? SSPLSentDate { get; set; }

		[DataMember(Name="tilDate")]
		public DateTime? TilDate { get; set; }

		[DataMember(Name="tilDisclosedComments")]
		public string TilDisclosedComments { get; set; }

		[DataMember(Name="tilDisclosureMethod")]
		public string TilDisclosureMethod { get; set; }

		[DataMember(Name="tilLastDisclosedBorrowerReceivedDate")]
		public DateTime? TilLastDisclosedBorrowerReceivedDate { get; set; }

		[DataMember(Name="tilLastDisclosedBy")]
		public string TilLastDisclosedBy { get; set; }

		[DataMember(Name="tilLastDisclosedDate")]
		public DateTime? TilLastDisclosedDate { get; set; }

		[DataMember(Name="tilRedisclosureProvidedDate")]
		public DateTime? TilRedisclosureProvidedDate { get; set; }

		[DataMember(Name="tilRedisclosureReceivedDate")]
		public DateTime? TilRedisclosureReceivedDate { get; set; }

		[DataMember(Name="totalBrokerFees")]
		public decimal? TotalBrokerFees { get; set; }

		[DataMember(Name="totalLatePayment")]
		public decimal? TotalLatePayment { get; set; }

		[DataMember(Name="totalLenderFees")]
		public decimal? TotalLenderFees { get; set; }

		[DataMember(Name="totalOfPayments")]
		public decimal? TotalOfPayments { get; set; }

		[DataMember(Name="totalOfPrincipalAndInterest")]
		public decimal? TotalOfPrincipalAndInterest { get; set; }

		[DataMember(Name="useCustomLenderProfile")]
		public bool? UseCustomLenderProfile { get; set; }

		[DataMember(Name="useDaysInYears")]
		public string UseDaysInYears { get; set; }

		[DataMember(Name="usePitiForRatioIndicator")]
		public bool? UsePitiForRatioIndicator { get; set; }

		[DataMember(Name="variableRateFeatureIndicator")]
		public bool? VariableRateFeatureIndicator { get; set; }

		[DataMember(Name="yearlyTerm")]
		public decimal? YearlyTerm { get; set; }

		[DataMember(Name="yearOfMaximumPayment")]
		public string YearOfMaximumPayment { get; set; }

		[DataMember(Name="years")]
		public int? Years { get; set; }

		[DataMember(Name = "interestAccrual")]
		public string InterestAccrual { get; set; }

	}
}