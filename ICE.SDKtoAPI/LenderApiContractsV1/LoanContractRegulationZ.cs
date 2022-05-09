using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZ
	{
		[DataMember(Name="acknowledgedDay", EmitDefaultValue=false)]
		public string AcknowledgedDay { get; set; }

		[DataMember(Name="acknowledgedMonth", EmitDefaultValue=false)]
		public string AcknowledgedMonth { get; set; }

		[DataMember(Name="acknowledgedYear", EmitDefaultValue=false)]
		public string AcknowledgedYear { get; set; }

		[DataMember(Name="acquisition", EmitDefaultValue=false)]
		public bool? Acquisition { get; set; }

		[DataMember(Name="additionalArmInformation", EmitDefaultValue=false)]
		public string AdditionalArmInformation { get; set; }

		[DataMember(Name="allDateAndNumericalDisclosuresIndicator", EmitDefaultValue=false)]
		public bool? AllDateAndNumericalDisclosuresIndicator { get; set; }

		[DataMember(Name="amountFinanced", EmitDefaultValue=false)]
		public double? AmountFinanced { get; set; }

		[DataMember(Name="aprPercent", EmitDefaultValue=false)]
		public double? AprPercent { get; set; }

		[DataMember(Name="aprPercentUI", EmitDefaultValue=false)]
		public string AprPercentUI { get; set; }

		[DataMember(Name="armDisclosureDescription", EmitDefaultValue=false)]
		public string ArmDisclosureDescription { get; set; }

		[DataMember(Name="assumptionOnYourProperty", EmitDefaultValue=false)]
		public string AssumptionOnYourProperty { get; set; }

		[DataMember(Name="borrowerIntendToContinueDate", EmitDefaultValue=false)]
		public DateTime? BorrowerIntendToContinueDate { get; set; }

		[DataMember(Name="borrowerIntendToContinueIndicator", EmitDefaultValue=false)]
		public bool? BorrowerIntendToContinueIndicator { get; set; }

		[DataMember(Name="borrowerMiTerminationDate", EmitDefaultValue=false)]
		public string BorrowerMiTerminationDate { get; set; }

		[DataMember(Name="calculateBasedOnRemainingBalance", EmitDefaultValue=false)]
		public string CalculateBasedOnRemainingBalance { get; set; }

		[DataMember(Name="chargesAddedToPaymentsIndicator", EmitDefaultValue=false)]
		public bool? ChargesAddedToPaymentsIndicator { get; set; }

		[DataMember(Name="chargesAtLoanClosingIndicator", EmitDefaultValue=false)]
		public bool? ChargesAtLoanClosingIndicator { get; set; }

		[DataMember(Name="circumstanceChangeReason", EmitDefaultValue=false)]
		public string CircumstanceChangeReason { get; set; }

		[DataMember(Name="circumstanceChangeReceivedDate", EmitDefaultValue=false)]
		public DateTime? CircumstanceChangeReceivedDate { get; set; }

		[DataMember(Name="closingDisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? ClosingDisclosureReceivedDate { get; set; }

		[DataMember(Name="closingDisclosureSentDate", EmitDefaultValue=false)]
		public DateTime? ClosingDisclosureSentDate { get; set; }

		[DataMember(Name="constructionFirstIntChangeAdjType", EmitDefaultValue=false)]
		public string ConstructionFirstIntChangeAdjType { get; set; }

		[DataMember(Name="constructionLoanDescription", EmitDefaultValue=false)]
		public string ConstructionLoanDescription { get; set; }

		[DataMember(Name="constructionLoanMethod", EmitDefaultValue=false)]
		public string ConstructionLoanMethod { get; set; }

		[DataMember(Name="constructionPeriodMonths", EmitDefaultValue=false)]
		public int? ConstructionPeriodMonths { get; set; }

		[DataMember(Name="constructionRatePercent", EmitDefaultValue=false)]
		public double? ConstructionRatePercent { get; set; }

		[DataMember(Name="constructionRefinanceIndicator", EmitDefaultValue=false)]
		public bool? ConstructionRefinanceIndicator { get; set; }

		[DataMember(Name="creditDisability", EmitDefaultValue=false)]
		public double? CreditDisability { get; set; }

		[DataMember(Name="creditDisabilityIndicator", EmitDefaultValue=false)]
		public bool? CreditDisabilityIndicator { get; set; }

		[DataMember(Name="creditLife", EmitDefaultValue=false)]
		public double? CreditLife { get; set; }

		[DataMember(Name="creditLifeAndCreditDisability", EmitDefaultValue=false)]
		public double? CreditLifeAndCreditDisability { get; set; }

		[DataMember(Name="creditLifeInsuranceIndicator", EmitDefaultValue=false)]
		public bool? CreditLifeInsuranceIndicator { get; set; }

		[DataMember(Name="customizePaymentScheduleIndicator", EmitDefaultValue=false)]
		public bool? CustomizePaymentScheduleIndicator { get; set; }

		[DataMember(Name="demandFeatureIndicator", EmitDefaultValue=false)]
		public bool? DemandFeatureIndicator { get; set; }

		[DataMember(Name="disclosedAprPercent", EmitDefaultValue=false)]
		public double? DisclosedAprPercent { get; set; }

		[DataMember(Name="disclosedByBrokerIndicator", EmitDefaultValue=false)]
		public bool? DisclosedByBrokerIndicator { get; set; }

		[DataMember(Name="disclosedComments", EmitDefaultValue=false)]
		public string DisclosedComments { get; set; }

		[DataMember(Name="disclosedDailyInterestCharge", EmitDefaultValue=false)]
		public double? DisclosedDailyInterestCharge { get; set; }

		[DataMember(Name="disclosedFinanceCharge", EmitDefaultValue=false)]
		public double? DisclosedFinanceCharge { get; set; }

		[DataMember(Name="disclosedPrepayment", EmitDefaultValue=false)]
		public bool? DisclosedPrepayment { get; set; }

		[DataMember(Name="disclosedProduct", EmitDefaultValue=false)]
		public string DisclosedProduct { get; set; }

		[DataMember(Name="disclosureMethod", EmitDefaultValue=false)]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType", EmitDefaultValue=false)]
		public string DisclosureType { get; set; }

		[DataMember(Name="discountPeriod", EmitDefaultValue=false)]
		public int? DiscountPeriod { get; set; }

		[DataMember(Name="discountRatePercent", EmitDefaultValue=false)]
		public double? DiscountRatePercent { get; set; }

		[DataMember(Name="discountType", EmitDefaultValue=false)]
		public string DiscountType { get; set; }

		[DataMember(Name="dueDate", EmitDefaultValue=false)]
		public DateTime? DueDate { get; set; }

		[DataMember(Name="earliestClosingDate", EmitDefaultValue=false)]
		public DateTime? EarliestClosingDate { get; set; }

		[DataMember(Name="earliestFeeCollectionDate", EmitDefaultValue=false)]
		public DateTime? EarliestFeeCollectionDate { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted1", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted2", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted3", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted4", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted5", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerDateAccepted6", EmitDefaultValue=false)]
		public DateTime? ESignConsentBorrowerDateAccepted6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress1", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress2", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress3", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress4", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress5", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerIPAddress6", EmitDefaultValue=false)]
		public string ESignConsentBorrowerIPAddress6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource1", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource2", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource3", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource4", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource5", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerSource6", EmitDefaultValue=false)]
		public string ESignConsentBorrowerSource6 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus1", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus1 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus2", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus2 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus3", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus3 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus4", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus4 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus5", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus5 { get; set; }

		[DataMember(Name="eSignConsentBorrowerStatus6", EmitDefaultValue=false)]
		public string ESignConsentBorrowerStatus6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted1", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted2", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted3", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted4", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted5", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerDateAccepted6", EmitDefaultValue=false)]
		public DateTime? ESignConsentCoBorrowerDateAccepted6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress1", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress2", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress3", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress4", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress5", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerIPAddress6", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerIPAddress6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource1", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource2", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource3", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource4", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource5", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerSource6", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerSource6 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus1", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus1 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus2", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus2 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus3", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus3 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus4", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus4 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus5", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus5 { get; set; }

		[DataMember(Name="eSignConsentCoBorrowerStatus6", EmitDefaultValue=false)]
		public string ESignConsentCoBorrowerStatus6 { get; set; }

		[DataMember(Name="eSignConsentDate", EmitDefaultValue=false)]
		public DateTime? ESignConsentDate { get; set; }

		[DataMember(Name="externaleConsent", EmitDefaultValue=false)]
		public string ExternaleConsent { get; set; }

		[DataMember(Name="extraPaymentForEarlyPayOff", EmitDefaultValue=false)]
		public double? ExtraPaymentForEarlyPayOff { get; set; }

		[DataMember(Name="feeCollectedDate", EmitDefaultValue=false)]
		public DateTime? FeeCollectedDate { get; set; }

		[DataMember(Name="feeLevelDisclosuresIndicator", EmitDefaultValue=false)]
		public bool? FeeLevelDisclosuresIndicator { get; set; }

		[DataMember(Name="filingFees", EmitDefaultValue=false)]
		public double? FilingFees { get; set; }

		[DataMember(Name="finalPaymentDate", EmitDefaultValue=false)]
		public DateTime? FinalPaymentDate { get; set; }

		[DataMember(Name="financeCharge", EmitDefaultValue=false)]
		public double? FinanceCharge { get; set; }

		[DataMember(Name="financedAllGuaranteeFeeAmount", EmitDefaultValue=false)]
		public double? FinancedAllGuaranteeFeeAmount { get; set; }

		[DataMember(Name="financedAllGuaranteeFeePercent", EmitDefaultValue=false)]
		public double? FinancedAllGuaranteeFeePercent { get; set; }

		[DataMember(Name="financedAllTotalLoanAmount", EmitDefaultValue=false)]
		public double? FinancedAllTotalLoanAmount { get; set; }

		[DataMember(Name="financedPortionGuaranteeFeeAmount", EmitDefaultValue=false)]
		public double? FinancedPortionGuaranteeFeeAmount { get; set; }

		[DataMember(Name="financedPortionGuaranteeFeePercent", EmitDefaultValue=false)]
		public double? FinancedPortionGuaranteeFeePercent { get; set; }

		[DataMember(Name="financedPortionTotalLoanAmount", EmitDefaultValue=false)]
		public double? FinancedPortionTotalLoanAmount { get; set; }

		[DataMember(Name="financingType", EmitDefaultValue=false)]
		public string FinancingType { get; set; }

		[DataMember(Name="firstAmortizationPaymentDate", EmitDefaultValue=false)]
		public DateTime? FirstAmortizationPaymentDate { get; set; }

		[DataMember(Name="floodInsuranceIndicator", EmitDefaultValue=false)]
		public bool? FloodInsuranceIndicator { get; set; }

		[DataMember(Name="gfeApplicationDate", EmitDefaultValue=false)]
		public DateTime? GfeApplicationDate { get; set; }

		[DataMember(Name="gfeChangedCircumstanceIndicator", EmitDefaultValue=false)]
		public bool? GfeChangedCircumstanceIndicator { get; set; }

		[DataMember(Name="gfeChangedCircumstanceItem", EmitDefaultValue=false)]
		public string GfeChangedCircumstanceItem { get; set; }

		[DataMember(Name="gFEChangedCirsumstanceItemCode", EmitDefaultValue=false)]
		public string GFEChangedCirsumstanceItemCode { get; set; }

		[DataMember(Name="gfeDate", EmitDefaultValue=false)]
		public DateTime? GfeDate { get; set; }

		[DataMember(Name="gfeExpirationDate", EmitDefaultValue=false)]
		public DateTime? GfeExpirationDate { get; set; }

		[DataMember(Name="gfeExpirationPeriod", EmitDefaultValue=false)]
		public string GfeExpirationPeriod { get; set; }

		[DataMember(Name="gfeRateLockRedisclosureRequiredIndicator", EmitDefaultValue=false)]
		public bool? GfeRateLockRedisclosureRequiredIndicator { get; set; }

		[DataMember(Name="gfeRedisclosureProvidedDate", EmitDefaultValue=false)]
		public DateTime? GfeRedisclosureProvidedDate { get; set; }

		[DataMember(Name="gfeRedisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? GfeRedisclosureReceivedDate { get; set; }

		[DataMember(Name="helocTeaserRatePeriod", EmitDefaultValue=false)]
		public int? HelocTeaserRatePeriod { get; set; }

		[DataMember(Name="highCostDisclosure", EmitDefaultValue=false)]
		public DateTime? HighCostDisclosure { get; set; }

		[DataMember(Name="homeCounselingProvidedDate", EmitDefaultValue=false)]
		public DateTime? HomeCounselingProvidedDate { get; set; }

		[DataMember(Name="hud1ToleranceViolatedIndicator", EmitDefaultValue=false)]
		public bool? Hud1ToleranceViolatedIndicator { get; set; }

		[DataMember(Name="hudToleranceResolutionComments", EmitDefaultValue=false)]
		public string HudToleranceResolutionComments { get; set; }

		[DataMember(Name="hudToleranceResolutionDate", EmitDefaultValue=false)]
		public DateTime? HudToleranceResolutionDate { get; set; }

		[DataMember(Name="hudToleranceResolvedBy", EmitDefaultValue=false)]
		public string HudToleranceResolvedBy { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="ifYouPurchaseIndicator", EmitDefaultValue=false)]
		public bool? IfYouPurchaseIndicator { get; set; }

		[DataMember(Name="ifYouPurchaseType", EmitDefaultValue=false)]
		public string IfYouPurchaseType { get; set; }

		[DataMember(Name="includeMiIndicator", EmitDefaultValue=false)]
		public bool? IncludeMiIndicator { get; set; }

		[DataMember(Name="includePmiIndicator", EmitDefaultValue=false)]
		public bool? IncludePmiIndicator { get; set; }

		[DataMember(Name="includeTaxesInsuranceIndicator", EmitDefaultValue=false)]
		public bool? IncludeTaxesInsuranceIndicator { get; set; }

		[DataMember(Name="initialAVMProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialAVMProvidedDate { get; set; }

		[DataMember(Name="initialDisclosureDueDate", EmitDefaultValue=false)]
		public DateTime? InitialDisclosureDueDate { get; set; }

		[DataMember(Name="initialDisclosureProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialGfeAffiliatedBusinessProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeAffiliatedBusinessProvidedDate { get; set; }

		[DataMember(Name="initialGFEAppraisalProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGFEAppraisalProvidedDate { get; set; }

		[DataMember(Name="initialGfeCharmBookletProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeCharmBookletProvidedDate { get; set; }

		[DataMember(Name="initialGfeDisclosureProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialGfeDisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeDisclosureReceivedDate { get; set; }

		[DataMember(Name="initialGfeHelocBrochureProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeHelocBrochureProvidedDate { get; set; }

		[DataMember(Name="initialGfeHudSpecialBookletProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialGfeHudSpecialBookletProvidedDate { get; set; }

		[DataMember(Name="initialSubsequentAppraisalProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialSubsequentAppraisalProvidedDate { get; set; }

		[DataMember(Name="initialTilDisclosureProvidedDate", EmitDefaultValue=false)]
		public DateTime? InitialTilDisclosureProvidedDate { get; set; }

		[DataMember(Name="initialTilDisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? InitialTilDisclosureReceivedDate { get; set; }

		[DataMember(Name="insuranceRequiredDescription", EmitDefaultValue=false)]
		public string InsuranceRequiredDescription { get; set; }

		[DataMember(Name="interestInNameOf", EmitDefaultValue=false)]
		public string InterestInNameOf { get; set; }

		[DataMember(Name="interestOnly", EmitDefaultValue=false)]
		public bool? InterestOnly { get; set; }

		[DataMember(Name="interestOnlyIndicator", EmitDefaultValue=false)]
		public bool? InterestOnlyIndicator { get; set; }

		[DataMember(Name="interestOnlyMonths", EmitDefaultValue=false)]
		public int? InterestOnlyMonths { get; set; }

		[DataMember(Name="interestRateType", EmitDefaultValue=false)]
		public string InterestRateType { get; set; }

		[DataMember(Name="interestReserveAmount", EmitDefaultValue=false)]
		public double? InterestReserveAmount { get; set; }

		[DataMember(Name="lastDisclosedBy", EmitDefaultValue=false)]
		public string LastDisclosedBy { get; set; }

		[DataMember(Name="lastDisclosedDate", EmitDefaultValue=false)]
		public DateTime? LastDisclosedDate { get; set; }

		[DataMember(Name="lastDisclosedGfeReceivedDate", EmitDefaultValue=false)]
		public DateTime? LastDisclosedGfeReceivedDate { get; set; }

		[DataMember(Name="lateChargeBasis", EmitDefaultValue=false)]
		public double? LateChargeBasis { get; set; }

		[DataMember(Name="lateChargeComments", EmitDefaultValue=false)]
		public string LateChargeComments { get; set; }

		[DataMember(Name="lateChargeDays", EmitDefaultValue=false)]
		public int? LateChargeDays { get; set; }

		[DataMember(Name="lateChargePercent", EmitDefaultValue=false)]
		public double? LateChargePercent { get; set; }

		[DataMember(Name="lateChargeType", EmitDefaultValue=false)]
		public string LateChargeType { get; set; }

		[DataMember(Name="lateFee", EmitDefaultValue=false)]
		public double? LateFee { get; set; }

		[DataMember(Name="lEIntentToProceedComment", EmitDefaultValue=false)]
		public string LEIntentToProceedComment { get; set; }

		[DataMember(Name="lenderPaidMortgageInsuranceIndicator", EmitDefaultValue=false)]
		public bool? LenderPaidMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="lendersInspectionFee", EmitDefaultValue=false)]
		public double? LendersInspectionFee { get; set; }

		[DataMember(Name="lEReceivedBy", EmitDefaultValue=false)]
		public string LEReceivedBy { get; set; }

		[DataMember(Name="lEReceivedMethod", EmitDefaultValue=false)]
		public string LEReceivedMethod { get; set; }

		[DataMember(Name="lEReceivedMethodOther", EmitDefaultValue=false)]
		public string LEReceivedMethodOther { get; set; }

		[DataMember(Name="lESentOnDate", EmitDefaultValue=false)]
		public DateTime? LESentOnDate { get; set; }

		[DataMember(Name="marginPlusIndexPercent", EmitDefaultValue=false)]
		public double? MarginPlusIndexPercent { get; set; }

		[DataMember(Name="maximumLateCharge", EmitDefaultValue=false)]
		public double? MaximumLateCharge { get; set; }

		[DataMember(Name="maximumPayment", EmitDefaultValue=false)]
		public double? MaximumPayment { get; set; }

		[DataMember(Name="meansAnEstimateIndicator", EmitDefaultValue=false)]
		public bool? MeansAnEstimateIndicator { get; set; }

		[DataMember(Name="miAdjustmentFactorLevel2", EmitDefaultValue=false)]
		public double? MiAdjustmentFactorLevel2 { get; set; }

		[DataMember(Name="miDecliningRenewalsIndicator", EmitDefaultValue=false)]
		public bool? MiDecliningRenewalsIndicator { get; set; }

		[DataMember(Name="midpointCancellation", EmitDefaultValue=false)]
		public string MidpointCancellation { get; set; }

		[DataMember(Name="miMonthlyPaymentLevel1", EmitDefaultValue=false)]
		public double? MiMonthlyPaymentLevel1 { get; set; }

		[DataMember(Name="miMonthlyPaymentLevel2", EmitDefaultValue=false)]
		public double? MiMonthlyPaymentLevel2 { get; set; }

		[DataMember(Name="miMonthsOfAdjustmentLevel1", EmitDefaultValue=false)]
		public int? MiMonthsOfAdjustmentLevel1 { get; set; }

		[DataMember(Name="miMonthsOfAdjustmentLevel2", EmitDefaultValue=false)]
		public int? MiMonthsOfAdjustmentLevel2 { get; set; }

		[DataMember(Name="minimumLateCharge", EmitDefaultValue=false)]
		public double? MinimumLateCharge { get; set; }

		[DataMember(Name="minimumPayment", EmitDefaultValue=false)]
		public double? MinimumPayment { get; set; }

		[DataMember(Name="mIPFactorLocked", EmitDefaultValue=false)]
		public bool? MIPFactorLocked { get; set; }

		[DataMember(Name="mIPrepaidAmount", EmitDefaultValue=false)]
		public double? MIPrepaidAmount { get; set; }

		[DataMember(Name="miPrepaidIndicator", EmitDefaultValue=false)]
		public bool? MiPrepaidIndicator { get; set; }

		[DataMember(Name="miScheduledTerminationDate", EmitDefaultValue=false)]
		public string MiScheduledTerminationDate { get; set; }

		[DataMember(Name="mmiIndicator", EmitDefaultValue=false)]
		public bool? MmiIndicator { get; set; }

		[DataMember(Name="monthlyTerm", EmitDefaultValue=false)]
		public double? MonthlyTerm { get; set; }

		[DataMember(Name="monthsOfMiPrepaid", EmitDefaultValue=false)]
		public int? MonthsOfMiPrepaid { get; set; }

		[DataMember(Name="mortgageInsuranceCancelPercent", EmitDefaultValue=false)]
		public double? MortgageInsuranceCancelPercent { get; set; }

		[DataMember(Name="namePreparedBy", EmitDefaultValue=false)]
		public string NamePreparedBy { get; set; }

		[DataMember(Name="newConstructionIndicator", EmitDefaultValue=false)]
		public string NewConstructionIndicator { get; set; }

		[DataMember(Name="numberOfPayments", EmitDefaultValue=false)]
		public int? NumberOfPayments { get; set; }

		[DataMember(Name="occupancyCertDate", EmitDefaultValue=false)]
		public DateTime? OccupancyCertDate { get; set; }

		[DataMember(Name="originalContractDate", EmitDefaultValue=false)]
		public DateTime? OriginalContractDate { get; set; }

		[DataMember(Name="outstandingBalance", EmitDefaultValue=false)]
		public double? OutstandingBalance { get; set; }

		[DataMember(Name="paymentFrequencyType", EmitDefaultValue=false)]
		public string PaymentFrequencyType { get; set; }

		[DataMember(Name="paymentIncreasePercent", EmitDefaultValue=false)]
		public double? PaymentIncreasePercent { get; set; }

		[DataMember(Name="phonePreparedBy", EmitDefaultValue=false)]
		public string PhonePreparedBy { get; set; }

		[DataMember(Name="pmiIndicator", EmitDefaultValue=false)]
		public bool? PmiIndicator { get; set; }

		[DataMember(Name="pmiMidpointCancelationDate", EmitDefaultValue=false)]
		public DateTime? PmiMidpointCancelationDate { get; set; }

		[DataMember(Name="postConsummationDisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? PostConsummationDisclosureReceivedDate { get; set; }

		[DataMember(Name="postConsummationDisclosureSentDate", EmitDefaultValue=false)]
		public DateTime? PostConsummationDisclosureSentDate { get; set; }

		[DataMember(Name="prepaidFinanceCharge", EmitDefaultValue=false)]
		public double? PrepaidFinanceCharge { get; set; }

		[DataMember(Name="propertyInsuranceIndicator", EmitDefaultValue=false)]
		public bool? PropertyInsuranceIndicator { get; set; }

		[DataMember(Name="rateLockGfeDueDate", EmitDefaultValue=false)]
		public DateTime? RateLockGfeDueDate { get; set; }

		[DataMember(Name="ratePercent", EmitDefaultValue=false)]
		public double? RatePercent { get; set; }

		[DataMember(Name="recastPaidMonths", EmitDefaultValue=false)]
		public int? RecastPaidMonths { get; set; }

		[DataMember(Name="recastStopMonths", EmitDefaultValue=false)]
		public int? RecastStopMonths { get; set; }

		[DataMember(Name="refundPaymentIndicator", EmitDefaultValue=false)]
		public bool? RefundPaymentIndicator { get; set; }

		[DataMember(Name="refundUnearnedMipIndicator", EmitDefaultValue=false)]
		public bool? RefundUnearnedMipIndicator { get; set; }

		[DataMember(Name="regulationZInterestRatePeriods", EmitDefaultValue=false)]
		public List<LoanContractRegulationZRegulationZInterestRatePeriods> RegulationZInterestRatePeriods { get; set; }

		[DataMember(Name="regulationZPayments", EmitDefaultValue=false)]
		public List<LoanContractRegulationZRegulationZPayments> RegulationZPayments { get; set; }

		[DataMember(Name="regzTableType", EmitDefaultValue=false)]
		public string RegzTableType { get; set; }

		[DataMember(Name="requiredDepositIndicator", EmitDefaultValue=false)]
		public bool? RequiredDepositIndicator { get; set; }

		[DataMember(Name="revisedClosingDisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? RevisedClosingDisclosureReceivedDate { get; set; }

		[DataMember(Name="revisedClosingDisclosureSentDate", EmitDefaultValue=false)]
		public DateTime? RevisedClosingDisclosureSentDate { get; set; }

		[DataMember(Name="revisedGfeDueDate", EmitDefaultValue=false)]
		public DateTime? RevisedGfeDueDate { get; set; }

		[DataMember(Name="roundedMarginPlusIndexPercent", EmitDefaultValue=false)]
		public double? RoundedMarginPlusIndexPercent { get; set; }

		[DataMember(Name="safeHarborSentDate", EmitDefaultValue=false)]
		public DateTime? SafeHarborSentDate { get; set; }

		[DataMember(Name="samplePayments", EmitDefaultValue=false)]
		public double? SamplePayments { get; set; }

		[DataMember(Name="securityType", EmitDefaultValue=false)]
		public string SecurityType { get; set; }

		[DataMember(Name="sSPLSentDate", EmitDefaultValue=false)]
		public DateTime? SSPLSentDate { get; set; }

		[DataMember(Name="tilDate", EmitDefaultValue=false)]
		public DateTime? TilDate { get; set; }

		[DataMember(Name="tilDisclosedComments", EmitDefaultValue=false)]
		public string TilDisclosedComments { get; set; }

		[DataMember(Name="tilDisclosureMethod", EmitDefaultValue=false)]
		public string TilDisclosureMethod { get; set; }

		[DataMember(Name="tilLastDisclosedBorrowerReceivedDate", EmitDefaultValue=false)]
		public DateTime? TilLastDisclosedBorrowerReceivedDate { get; set; }

		[DataMember(Name="tilLastDisclosedBy", EmitDefaultValue=false)]
		public string TilLastDisclosedBy { get; set; }

		[DataMember(Name="tilLastDisclosedDate", EmitDefaultValue=false)]
		public DateTime? TilLastDisclosedDate { get; set; }

		[DataMember(Name="tilRedisclosureProvidedDate", EmitDefaultValue=false)]
		public DateTime? TilRedisclosureProvidedDate { get; set; }

		[DataMember(Name="tilRedisclosureReceivedDate", EmitDefaultValue=false)]
		public DateTime? TilRedisclosureReceivedDate { get; set; }

		[DataMember(Name="totalBrokerFees", EmitDefaultValue=false)]
		public double? TotalBrokerFees { get; set; }

		[DataMember(Name="totalLatePayment", EmitDefaultValue=false)]
		public double? TotalLatePayment { get; set; }

		[DataMember(Name="totalLenderFees", EmitDefaultValue=false)]
		public double? TotalLenderFees { get; set; }

		[DataMember(Name="totalOfPayments", EmitDefaultValue=false)]
		public double? TotalOfPayments { get; set; }

		[DataMember(Name="totalOfPrincipalAndInterest", EmitDefaultValue=false)]
		public double? TotalOfPrincipalAndInterest { get; set; }

		[DataMember(Name="useCustomLenderProfile", EmitDefaultValue=false)]
		public bool? UseCustomLenderProfile { get; set; }

		[DataMember(Name="useDaysInYears", EmitDefaultValue=false)]
		public string UseDaysInYears { get; set; }

		[DataMember(Name="usePitiForRatioIndicator", EmitDefaultValue=false)]
		public bool? UsePitiForRatioIndicator { get; set; }

		[DataMember(Name="variableRateFeatureIndicator", EmitDefaultValue=false)]
		public bool? VariableRateFeatureIndicator { get; set; }

		[DataMember(Name="yearlyTerm", EmitDefaultValue=false)]
		public double? YearlyTerm { get; set; }

		[DataMember(Name="yearOfMaximumPayment", EmitDefaultValue=false)]
		public string YearOfMaximumPayment { get; set; }

		[DataMember(Name="years", EmitDefaultValue=false)]
		public int? Years { get; set; }

	}
}