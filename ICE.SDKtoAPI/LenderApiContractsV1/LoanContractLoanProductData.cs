using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductData
	{
		[DataMember(Name="amountApplyToDownPayment", EmitDefaultValue=false)]
		public double? AmountApplyToDownPayment { get; set; }

		[DataMember(Name="annualFeeNeededAmount", EmitDefaultValue=false)]
		public double? AnnualFeeNeededAmount { get; set; }

		[DataMember(Name="applyLifeCapLowIndicator", EmitDefaultValue=false)]
		public bool? ApplyLifeCapLowIndicator { get; set; }

		[DataMember(Name="armDisclosureType", EmitDefaultValue=false)]
		public string ArmDisclosureType { get; set; }

		[DataMember(Name="armIndexType", EmitDefaultValue=false)]
		public string ArmIndexType { get; set; }

		[DataMember(Name="balloonIndicator", EmitDefaultValue=false)]
		public bool? BalloonIndicator { get; set; }

		[DataMember(Name="balloonLoanMaturityTermMonthsCount", EmitDefaultValue=false)]
		public int? BalloonLoanMaturityTermMonthsCount { get; set; }

		[DataMember(Name="borrowerEstimatedClosingDate", EmitDefaultValue=false)]
		public DateTime? BorrowerEstimatedClosingDate { get; set; }

		[DataMember(Name="branchLocationNmlsId", EmitDefaultValue=false)]
		public string BranchLocationNmlsId { get; set; }

		[DataMember(Name="branchManagerNmlsId", EmitDefaultValue=false)]
		public string BranchManagerNmlsId { get; set; }

		[DataMember(Name="buydowns", EmitDefaultValue=false)]
		public List<LoanContractLoanProductDataBuydowns> Buydowns { get; set; }

		[DataMember(Name="convertibleIndicator", EmitDefaultValue=false)]
		public bool? ConvertibleIndicator { get; set; }

		[DataMember(Name="discounted", EmitDefaultValue=false)]
		public string Discounted { get; set; }

		[DataMember(Name="discountedRate", EmitDefaultValue=false)]
		public double? DiscountedRate { get; set; }

		[DataMember(Name="drawPeriodMonthsCount", EmitDefaultValue=false)]
		public int? DrawPeriodMonthsCount { get; set; }

		[DataMember(Name="escrowWaiverIndicator", EmitDefaultValue=false)]
		public bool? EscrowWaiverIndicator { get; set; }

		[DataMember(Name="excludeLoanFromNMLSReportIndicator", EmitDefaultValue=false)]
		public bool? ExcludeLoanFromNMLSReportIndicator { get; set; }

		[DataMember(Name="floorBasis", EmitDefaultValue=false)]
		public string FloorBasis { get; set; }

		[DataMember(Name="floorPercent", EmitDefaultValue=false)]
		public double? FloorPercent { get; set; }

		[DataMember(Name="floorPercentUI", EmitDefaultValue=false)]
		public string FloorPercentUI { get; set; }

		[DataMember(Name="floorVerbiage", EmitDefaultValue=false)]
		public string FloorVerbiage { get; set; }

		[DataMember(Name="fnmProductPlanIdentifier", EmitDefaultValue=false)]
		public string FnmProductPlanIdentifier { get; set; }

		[DataMember(Name="freddieMacArmIndexType", EmitDefaultValue=false)]
		public string FreddieMacArmIndexType { get; set; }

		[DataMember(Name="freOfferingIdentifier", EmitDefaultValue=false)]
		public string FreOfferingIdentifier { get; set; }

		[DataMember(Name="fullPrepaymentPenaltyOptionType", EmitDefaultValue=false)]
		public string FullPrepaymentPenaltyOptionType { get; set; }

		[DataMember(Name="gseProjectClassificationType", EmitDefaultValue=false)]
		public string GseProjectClassificationType { get; set; }

		[DataMember(Name="gsePropertyType", EmitDefaultValue=false)]
		public string GsePropertyType { get; set; }

		[DataMember(Name="hardPrepaymentPenaltyMonths", EmitDefaultValue=false)]
		public int? HardPrepaymentPenaltyMonths { get; set; }

		[DataMember(Name="helocCalcSign", EmitDefaultValue=false)]
		public string HelocCalcSign { get; set; }

		[DataMember(Name="helocForceMinimumPayment", EmitDefaultValue=false)]
		public bool? HelocForceMinimumPayment { get; set; }

		[DataMember(Name="helocFractionBalancedividend", EmitDefaultValue=false)]
		public int? HelocFractionBalancedividend { get; set; }

		[DataMember(Name="helocFractionBalancedivisor", EmitDefaultValue=false)]
		public int? HelocFractionBalancedivisor { get; set; }

		[DataMember(Name="helocInitialBalanceUsed", EmitDefaultValue=false)]
		public string HelocInitialBalanceUsed { get; set; }

		[DataMember(Name="helocInitialCalcSign", EmitDefaultValue=false)]
		public string HelocInitialCalcSign { get; set; }

		[DataMember(Name="helocInitialForceMinimumPayment", EmitDefaultValue=false)]
		public bool? HelocInitialForceMinimumPayment { get; set; }

		[DataMember(Name="helocInitialFractionBalancedividend", EmitDefaultValue=false)]
		public int? HelocInitialFractionBalancedividend { get; set; }

		[DataMember(Name="helocInitialFractionBalancedivisor", EmitDefaultValue=false)]
		public int? HelocInitialFractionBalancedivisor { get; set; }

		[DataMember(Name="helocInitialPaymentBasis", EmitDefaultValue=false)]
		public string HelocInitialPaymentBasis { get; set; }

		[DataMember(Name="helocInitialPercent", EmitDefaultValue=false)]
		public double? HelocInitialPercent { get; set; }

		[DataMember(Name="helocInitialPercentageofBalance", EmitDefaultValue=false)]
		public double? HelocInitialPercentageofBalance { get; set; }

		[DataMember(Name="helocInitialPI", EmitDefaultValue=false)]
		public bool? HelocInitialPI { get; set; }

		[DataMember(Name="helocInitialRate", EmitDefaultValue=false)]
		public string HelocInitialRate { get; set; }

		[DataMember(Name="helocInitialTerm", EmitDefaultValue=false)]
		public int? HelocInitialTerm { get; set; }

		[DataMember(Name="helocInitPerDiemCalculationMethodType", EmitDefaultValue=false)]
		public string HelocInitPerDiemCalculationMethodType { get; set; }

		[DataMember(Name="helocInterestOnly", EmitDefaultValue=false)]
		public bool? HelocInterestOnly { get; set; }

		[DataMember(Name="hELOCLienPosition", EmitDefaultValue=false)]
		public string HELOCLienPosition { get; set; }

		[DataMember(Name="helocNewFinancingNotLinkedCreditLimit", EmitDefaultValue=false)]
		public double? HelocNewFinancingNotLinkedCreditLimit { get; set; }

		[DataMember(Name="helocNewFinancingNotLinkedDrawAmount", EmitDefaultValue=false)]
		public double? HelocNewFinancingNotLinkedDrawAmount { get; set; }

		[DataMember(Name="helocPaymentBasis", EmitDefaultValue=false)]
		public string HelocPaymentBasis { get; set; }

		[DataMember(Name="helocPercent", EmitDefaultValue=false)]
		public double? HelocPercent { get; set; }

		[DataMember(Name="helocPercentageofBalance", EmitDefaultValue=false)]
		public double? HelocPercentageofBalance { get; set; }

		[DataMember(Name="helocPeriodTemplateName", EmitDefaultValue=false)]
		public string HelocPeriodTemplateName { get; set; }

		[DataMember(Name="helocQualifyingBalance", EmitDefaultValue=false)]
		public string HelocQualifyingBalance { get; set; }

		[DataMember(Name="helocQualifyingTerm", EmitDefaultValue=false)]
		public int? HelocQualifyingTerm { get; set; }

		[DataMember(Name="helocRate", EmitDefaultValue=false)]
		public string HelocRate { get; set; }

		[DataMember(Name="helocRepaymentDrawPeriods", EmitDefaultValue=false)]
		public List<LoanContractLoanProductDataHelocRepaymentDrawPeriods> HelocRepaymentDrawPeriods { get; set; }

		[DataMember(Name = "helocRepaymentBasis", EmitDefaultValue = false)]
		public bool? HelocRepaymentBasis { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexCurrentValuePercent", EmitDefaultValue=false)]
		public double? IndexCurrentValuePercent { get; set; }

		[DataMember(Name="indexLookbackPeriod", EmitDefaultValue=false)]
		public string IndexLookbackPeriod { get; set; }

		[DataMember(Name="indexMarginPercent", EmitDefaultValue=false)]
		public double? IndexMarginPercent { get; set; }

		[DataMember(Name="indexMarginPercentUI", EmitDefaultValue=false)]
		public string IndexMarginPercentUI { get; set; }

		[DataMember(Name="initialAdvanceAmount", EmitDefaultValue=false)]
		public double? InitialAdvanceAmount { get; set; }

		[DataMember(Name="initialApplicationAmount", EmitDefaultValue=false)]
		public double? InitialApplicationAmount { get; set; }

		[DataMember(Name="inquiryOrPreQualificationIndicator", EmitDefaultValue=false)]
		public bool? InquiryOrPreQualificationIndicator { get; set; }

		[DataMember(Name="lienPriorityType", EmitDefaultValue=false)]
		public string LienPriorityType { get; set; }

		[DataMember(Name="loanDocumentationType", EmitDefaultValue=false)]
		public string LoanDocumentationType { get; set; }

		[DataMember(Name="loanRepaymentType", EmitDefaultValue=false)]
		public string LoanRepaymentType { get; set; }

		[DataMember(Name="loanScheduledClosingDate", EmitDefaultValue=false)]
		public DateTime? LoanScheduledClosingDate { get; set; }

		[DataMember(Name="maximumMonthlyPayment", EmitDefaultValue=false)]
		public double? MaximumMonthlyPayment { get; set; }

		[DataMember(Name="maxLifeInterestCapPercent", EmitDefaultValue=false)]
		public double? MaxLifeInterestCapPercent { get; set; }

		[DataMember(Name="maxLifeInterestCapPercentUI", EmitDefaultValue=false)]
		public string MaxLifeInterestCapPercentUI { get; set; }

		[DataMember(Name="miCoveragePercent", EmitDefaultValue=false)]
		public double? MiCoveragePercent { get; set; }

		[DataMember(Name="minimumAdvanceAmount", EmitDefaultValue=false)]
		public double? MinimumAdvanceAmount { get; set; }

		[DataMember(Name="minimumAllowableApr", EmitDefaultValue=false)]
		public double? MinimumAllowableApr { get; set; }

		[DataMember(Name="minimumDrawPeroidPaymentPercent", EmitDefaultValue=false)]
		public double? MinimumDrawPeroidPaymentPercent { get; set; }

		[DataMember(Name="minimumPaymentAmount", EmitDefaultValue=false)]
		public double? MinimumPaymentAmount { get; set; }

		[DataMember(Name="minimumPaymentLessThanAmount", EmitDefaultValue=false)]
		public double? MinimumPaymentLessThanAmount { get; set; }

		[DataMember(Name="minimumPaymentPercent", EmitDefaultValue=false)]
		public double? MinimumPaymentPercent { get; set; }

		[DataMember(Name="minimumPaymentUpbAmount", EmitDefaultValue=false)]
		public double? MinimumPaymentUpbAmount { get; set; }

		[DataMember(Name="minimumPaymentUpbPercent", EmitDefaultValue=false)]
		public double? MinimumPaymentUpbPercent { get; set; }

		[DataMember(Name="minimumRepayPeriodPaymentPercent", EmitDefaultValue=false)]
		public double? MinimumRepayPeriodPaymentPercent { get; set; }

		[DataMember(Name="monthsAppliedToPrepaymentPenaltyFeeCount", EmitDefaultValue=false)]
		public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get; set; }

		[DataMember(Name="negativeAmortizationLimitPercent", EmitDefaultValue=false)]
		public double? NegativeAmortizationLimitPercent { get; set; }

		[DataMember(Name="netInitialAndFinal", EmitDefaultValue=false)]
		public double? NetInitialAndFinal { get; set; }

		[DataMember(Name="nmlsDocumentationType", EmitDefaultValue=false)]
		public string NmlsDocumentationType { get; set; }

		[DataMember(Name="nmlsFirstMortgageType", EmitDefaultValue=false)]
		public string NmlsFirstMortgageType { get; set; }

		[DataMember(Name="nmlsLienStatus", EmitDefaultValue=false)]
		public string NmlsLienStatus { get; set; }

		[DataMember(Name="nmlsLoanType", EmitDefaultValue=false)]
		public string NmlsLoanType { get; set; }

		[DataMember(Name="nmlsOptionARMIndicator", EmitDefaultValue=false)]
		public bool? NmlsOptionARMIndicator { get; set; }

		[DataMember(Name="nmlsPiggyBackOrFundedHELOCIndicator", EmitDefaultValue=false)]
		public bool? NmlsPiggyBackOrFundedHELOCIndicator { get; set; }

		[DataMember(Name="nmlsProductionSoldToType", EmitDefaultValue=false)]
		public string NmlsProductionSoldToType { get; set; }

		[DataMember(Name="nmlsPropertyType", EmitDefaultValue=false)]
		public string NmlsPropertyType { get; set; }

		[DataMember(Name="nmlsRefinancePurposeType", EmitDefaultValue=false)]
		public string NmlsRefinancePurposeType { get; set; }

		[DataMember(Name="nmlsReverseMortgageType", EmitDefaultValue=false)]
		public string NmlsReverseMortgageType { get; set; }

		[DataMember(Name="oralRequestForExtensionOfCreditIndicator", EmitDefaultValue=false)]
		public bool? OralRequestForExtensionOfCreditIndicator { get; set; }

		[DataMember(Name="overLimitCharge", EmitDefaultValue=false)]
		public double? OverLimitCharge { get; set; }

		[DataMember(Name="overLimitReturnCharge", EmitDefaultValue=false)]
		public double? OverLimitReturnCharge { get; set; }

		[DataMember(Name="participationFees", EmitDefaultValue=false)]
		public double? ParticipationFees { get; set; }

		[DataMember(Name="paymentAdjustmentDurationMonthsCount", EmitDefaultValue=false)]
		public int? PaymentAdjustmentDurationMonthsCount { get; set; }

		[DataMember(Name="paymentAdjustmentPeriodicCapPercent", EmitDefaultValue=false)]
		public double? PaymentAdjustmentPeriodicCapPercent { get; set; }

		[DataMember(Name="paymentFrequencyType", EmitDefaultValue=false)]
		public string PaymentFrequencyType { get; set; }

		[DataMember(Name="prepaymentPenalties", EmitDefaultValue=false)]
		public List<LoanContractLoanProductDataPrepaymentPenalties> PrepaymentPenalties { get; set; }

		[DataMember(Name="prepaymentPenaltyBasedOn", EmitDefaultValue=false)]
		public string PrepaymentPenaltyBasedOn { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator", EmitDefaultValue=false)]
		public bool? PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyPercent", EmitDefaultValue=false)]
		public double? PrepaymentPenaltyPercent { get; set; }

		[DataMember(Name="prepaymentPenaltyTermMonthsCount", EmitDefaultValue=false)]
		public int? PrepaymentPenaltyTermMonthsCount { get; set; }

		[DataMember(Name="prepaymentPenaltyVerbiage", EmitDefaultValue=false)]
		public string PrepaymentPenaltyVerbiage { get; set; }

		[DataMember(Name="productName", EmitDefaultValue=false)]
		public string ProductName { get; set; }

		[DataMember(Name="qualifyingRatePercent", EmitDefaultValue=false)]
		public double? QualifyingRatePercent { get; set; }

		[DataMember(Name="rateAdjustmentDurationMonthsCount", EmitDefaultValue=false)]
		public int? RateAdjustmentDurationMonthsCount { get; set; }

		[DataMember(Name="rateAdjustmentLifetimeCapPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentLifetimeCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentPercent { get; set; }

		[DataMember(Name="rateAdjustmentPercentUI", EmitDefaultValue=false)]
		public string RateAdjustmentPercentUI { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentCapPercent", EmitDefaultValue=false)]
		public double? RateAdjustmentSubsequentCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentCapPercentUI", EmitDefaultValue=false)]
		public string RateAdjustmentSubsequentCapPercentUI { get; set; }

		[DataMember(Name="releaseRecoringCharge", EmitDefaultValue=false)]
		public double? ReleaseRecoringCharge { get; set; }

		[DataMember(Name="remainingBuydownAmount", EmitDefaultValue=false)]
		public double? RemainingBuydownAmount { get; set; }

		[DataMember(Name="repayPeriodMonthsCount", EmitDefaultValue=false)]
		public int? RepayPeriodMonthsCount { get; set; }

		[DataMember(Name="returnedCheckCharge", EmitDefaultValue=false)]
		public double? ReturnedCheckCharge { get; set; }

		[DataMember(Name="returnedCheckChargeRatePercent", EmitDefaultValue=false)]
		public double? ReturnedCheckChargeRatePercent { get; set; }

		[DataMember(Name="returnedCheckMaxCharge", EmitDefaultValue=false)]
		public double? ReturnedCheckMaxCharge { get; set; }

		[DataMember(Name="returnedCheckMinCharge", EmitDefaultValue=false)]
		public double? ReturnedCheckMinCharge { get; set; }

		[DataMember(Name="roundPercent", EmitDefaultValue=false)]
		public double? RoundPercent { get; set; }

		[DataMember(Name="roundType", EmitDefaultValue=false)]
		public string RoundType { get; set; }

		[DataMember(Name="scheduledFirstPaymentAdjustmentDate", EmitDefaultValue=false)]
		public DateTime? ScheduledFirstPaymentAdjustmentDate { get; set; }

		[DataMember(Name="scheduledFirstPaymentDate", EmitDefaultValue=false)]
		public DateTime? ScheduledFirstPaymentDate { get; set; }

		[DataMember(Name="stopPaymentCharge", EmitDefaultValue=false)]
		public double? StopPaymentCharge { get; set; }

		[DataMember(Name="subsequentRateAdjustmentMonthsCount", EmitDefaultValue=false)]
		public int? SubsequentRateAdjustmentMonthsCount { get; set; }

		[DataMember(Name="terminationFeeAmount", EmitDefaultValue=false)]
		public double? TerminationFeeAmount { get; set; }

		[DataMember(Name="terminationPeriodMonthsCount", EmitDefaultValue=false)]
		public int? TerminationPeriodMonthsCount { get; set; }

		[DataMember(Name="thirdPartyFeeFromAmount", EmitDefaultValue=false)]
		public double? ThirdPartyFeeFromAmount { get; set; }

		[DataMember(Name="thirdPartyFeeToAmount", EmitDefaultValue=false)]
		public double? ThirdPartyFeeToAmount { get; set; }

		[DataMember(Name="timelyPaymentRateReductionPercent", EmitDefaultValue=false)]
		public double? TimelyPaymentRateReductionPercent { get; set; }

		[DataMember(Name="timelyPaymentRewards", EmitDefaultValue=false)]
		public string TimelyPaymentRewards { get; set; }

		[DataMember(Name="totalSubsidyAmount", EmitDefaultValue=false)]
		public double? TotalSubsidyAmount { get; set; }

		[DataMember(Name="transactionFees", EmitDefaultValue=false)]
		public double? TransactionFees { get; set; }

		[DataMember(Name="wireFee", EmitDefaultValue=false)]
		public double? WireFee { get; set; }

		[DataMember(Name = "helocEscrowAccountIndicator", EmitDefaultValue = false)]
		public bool? HelocEscrowAccountIndicator { get; set; }

		[DataMember(Name = "helocDrawPaymentBasis", EmitDefaultValue = false)]
		public bool? HelocDrawPaymentBasis { get; set; }

		[DataMember(Name = "helocDrawPaymentBasisType", EmitDefaultValue = false)]
		public string HelocDrawPaymentBasisType { get; set; }

		[DataMember(Name = "helocTaRepaymentTermEndBy", EmitDefaultValue = false)]
		public string HelocTaRepaymentTermEndBy { get; set; }

		[DataMember(Name = "helocTaAprCharged", EmitDefaultValue = false)]
		public decimal? HelocTaAprCharged { get; set; }

		[DataMember(Name = "helocTaFeesCharged", EmitDefaultValue = false)]
		public string HelocTaFeesCharged { get; set; }

		[DataMember(Name = "helocTaIntroRateAppliedOn", EmitDefaultValue = false)]
		public string HelocTaIntroRateAppliedOn { get; set; }

		[DataMember(Name = "helocTaOverLimitChargeOption", EmitDefaultValue = false)]
		public string HelocTaOverLimitChargeOption { get; set; }

		[DataMember(Name = "helocTaDrawCheckIndicator", EmitDefaultValue = false)]
		public string HelocTaDrawCheckIndicator { get; set; }

		[DataMember(Name = "helocTaRequestByPhoneIndicator", EmitDefaultValue = false)]
		public bool? HelocTaRequestByPhoneIndicator { get; set; }

		[DataMember(Name = "helocTaWrittenAuthorizationIndicator", EmitDefaultValue = false)]
		public bool? HelocTaWrittenAuthorizationIndicator { get; set; }

		[DataMember(Name = "helocTaCreditCardIndicator", EmitDefaultValue = false)]
		public bool? HelocTaCreditCardIndicator { get; set; }

		[DataMember(Name = "helocTaOverdraftProtectionIndicator", EmitDefaultValue = false)]
		public bool? HelocTaOverdraftProtectionIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceInPersonIndicator", EmitDefaultValue = false)]
		public bool? HelocTaRequestAdvanceInPersonIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceViaInternetIndicator", EmitDefaultValue = false)]
		public bool? HelocTaRequestAdvanceViaInternetIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceInPersonLocation", EmitDefaultValue = false)]
		public string HelocTaRequestAdvanceInPersonLocation { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceViaInternetUrl", EmitDefaultValue = false)]
		public string HelocTaRequestAdvanceViaInternetUrl { get; set; }

		[DataMember(Name = "helocTaAppRoundingOption", EmitDefaultValue = false)]
		public string HelocTaAppRoundingOption { get; set; }

		[DataMember(Name = "helocTaDailyBalanceType", EmitDefaultValue = false)]
		public string HelocTaDailyBalanceType { get; set; }

		[DataMember(Name = "helocTaIndexRefDateOption", EmitDefaultValue = false)]
		public string HelocTaIndexRefDateOption { get; set; }

		[DataMember(Name = "helocTaPeriodicRateAdjDayOption", EmitDefaultValue = false)]
		public string HelocTaPeriodicRateAdjDayOption { get; set; }

		[DataMember(Name = "helocTaAppChangeOption", EmitDefaultValue = false)]
		public string HelocTaAppChangeOption { get; set; }

		[DataMember(Name = "helocTaPeriodicCapAppliedToAdvancePeriod", EmitDefaultValue = false)]
		public bool? HelocTaPeriodicCapAppliedToAdvancePeriod { get; set; }

		[DataMember(Name = "helocTaPeriodicCapAppliedToRepaymentPeriod", EmitDefaultValue = false)]
		public bool? HelocTaPeriodicCapAppliedToRepaymentPeriod { get; set; }

		[DataMember(Name = "helocTaDailyRateRoundingOption", EmitDefaultValue = false)]
		public string HelocTaDailyRateRoundingOption { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanPeriodicRateRoundingPercent", EmitDefaultValue = false)]
		public decimal? HelocTaInstallmentLoanPeriodicRateRoundingPercent { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanDiscountedAprIndicator", EmitDefaultValue = false)]
		public bool? HelocTaInstallmentLoanDiscountedAprIndicator { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanDiscountWord", EmitDefaultValue = false)]
		public string HelocTaInstallmentLoanDiscountWord { get; set; }

		[DataMember(Name = "helocTaInstallmentIndexRefDateOption", EmitDefaultValue = false)]
		public string HelocTaInstallmentIndexRefDateOption { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanTerminationMethod", EmitDefaultValue = false)]
		public string HelocTaInstallmentLoanTerminationMethod { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanPaymentAppliedMethod", EmitDefaultValue = false)]
		public string HelocTaInstallmentLoanPaymentAppliedMethod { get; set; }

		[DataMember(Name = "helocTaRequireRepayIndicator", EmitDefaultValue = false)]
		public bool? HelocTaRequireRepayIndicator { get; set; }

		[DataMember(Name = "helocTaLenderToPay3rdPartyCost", EmitDefaultValue = false)]
		public string HelocTaLenderToPay3rdPartyCost { get; set; }

		[DataMember(Name = "helocTaRightToSetoffIndicator", EmitDefaultValue = false)]
		public bool? HelocTaRightToSetoffIndicator { get; set; }

		[DataMember(Name = "helocTaAlNonDepositoryIndicator", EmitDefaultValue = false)]
		public bool? HelocTaAlNonDepositoryIndicator { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationAddr", EmitDefaultValue = false)]
		public string HelocTaCreditCardMisuseNotificationAddr { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationPhoneNumber", EmitDefaultValue = false)]
		public string HelocTaCreditCardMisuseNotificationPhoneNumber { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationWebAddr", EmitDefaultValue = false)]
		public string HelocTaCreditCardMisuseNotificationWebAddr { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationEmailAddr", EmitDefaultValue = false)]
		public string HelocTaCreditCardMisuseNotificationEmailAddr { get; set; }

		[DataMember(Name = "helocHistoricalTableName", EmitDefaultValue = false)]
		public string HelocHistoricalTableName { get; set; }

		[DataMember(Name = "helocStandardHistoricalTableIndicator", EmitDefaultValue = false)]
		public bool? HelocStandardHistoricalTableIndicator { get; set; }

	}
}