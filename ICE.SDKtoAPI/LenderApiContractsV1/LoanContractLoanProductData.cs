using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductData
	{
		[DataMember(Name="amountApplyToDownPayment")]
		public decimal? AmountApplyToDownPayment { get; set; }

		[DataMember(Name="annualFeeNeededAmount")]
		public decimal? AnnualFeeNeededAmount { get; set; }

		[DataMember(Name="applyLifeCapLowIndicator")]
		public bool? ApplyLifeCapLowIndicator { get; set; }

		[DataMember(Name="armDisclosureType")]
		public string ArmDisclosureType { get; set; }

		[DataMember(Name="armIndexType")]
		public string ArmIndexType { get; set; }

		[DataMember(Name="balloonIndicator")]
		public bool? BalloonIndicator { get; set; }

		[DataMember(Name="balloonLoanMaturityTermMonthsCount")]
		public int? BalloonLoanMaturityTermMonthsCount { get; set; }

		[DataMember(Name="borrowerEstimatedClosingDate")]
		public DateTime? BorrowerEstimatedClosingDate { get; set; }

		[DataMember(Name="branchLocationNmlsId")]
		public string BranchLocationNmlsId { get; set; }

		[DataMember(Name="branchManagerNmlsId")]
		public string BranchManagerNmlsId { get; set; }

		[DataMember(Name="buydowns")]
		public List<LoanContractLoanProductDataBuydowns> Buydowns { get; set; }

		[DataMember(Name="convertibleIndicator")]
		public bool? ConvertibleIndicator { get; set; }

		[DataMember(Name="discounted")]
		public string Discounted { get; set; }

		[DataMember(Name="discountedRate")]
		public decimal? DiscountedRate { get; set; }

		[DataMember(Name="drawPeriodMonthsCount")]
		public int? DrawPeriodMonthsCount { get; set; }

		[DataMember(Name="escrowWaiverIndicator")]
		public bool? EscrowWaiverIndicator { get; set; }

		[DataMember(Name="excludeLoanFromNMLSReportIndicator")]
		public bool? ExcludeLoanFromNMLSReportIndicator { get; set; }

		[DataMember(Name="floorBasis")]
		public string FloorBasis { get; set; }

		[DataMember(Name="floorPercent")]
		public decimal? FloorPercent { get; set; }

		[DataMember(Name="floorPercentUI")]
		public string FloorPercentUI { get; set; }

		[DataMember(Name="floorVerbiage")]
		public string FloorVerbiage { get; set; }

		[DataMember(Name="fnmProductPlanIdentifier")]
		public string FnmProductPlanIdentifier { get; set; }

		[DataMember(Name="freddieMacArmIndexType")]
		public string FreddieMacArmIndexType { get; set; }

		[DataMember(Name="freOfferingIdentifier")]
		public string FreOfferingIdentifier { get; set; }

		[DataMember(Name="fullPrepaymentPenaltyOptionType")]
		public string FullPrepaymentPenaltyOptionType { get; set; }

		[DataMember(Name="gseProjectClassificationType")]
		public string GseProjectClassificationType { get; set; }

		[DataMember(Name="gsePropertyType")]
		public string GsePropertyType { get; set; }

		[DataMember(Name="hardPrepaymentPenaltyMonths")]
		public int? HardPrepaymentPenaltyMonths { get; set; }

		[DataMember(Name="helocCalcSign")]
		public string HelocCalcSign { get; set; }

		[DataMember(Name="helocForceMinimumPayment")]
		public bool? HelocForceMinimumPayment { get; set; }

		[DataMember(Name="helocFractionBalancedividend")]
		public int? HelocFractionBalancedividend { get; set; }

		[DataMember(Name="helocFractionBalancedivisor")]
		public int? HelocFractionBalancedivisor { get; set; }

		[DataMember(Name="helocInitialBalanceUsed")]
		public string HelocInitialBalanceUsed { get; set; }

		[DataMember(Name="helocInitialCalcSign")]
		public string HelocInitialCalcSign { get; set; }

		[DataMember(Name="helocInitialForceMinimumPayment")]
		public bool? HelocInitialForceMinimumPayment { get; set; }

		[DataMember(Name="helocInitialFractionBalancedividend")]
		public int? HelocInitialFractionBalancedividend { get; set; }

		[DataMember(Name="helocInitialFractionBalancedivisor")]
		public int? HelocInitialFractionBalancedivisor { get; set; }

		[DataMember(Name="helocInitialPaymentBasis")]
		public string HelocInitialPaymentBasis { get; set; }

		[DataMember(Name="helocInitialPercent")]
		public decimal? HelocInitialPercent { get; set; }

		[DataMember(Name="helocInitialPercentageofBalance")]
		public decimal? HelocInitialPercentageofBalance { get; set; }

		[DataMember(Name="helocInitialPI")]
		public bool? HelocInitialPI { get; set; }

		[DataMember(Name="helocInitialRate")]
		public string HelocInitialRate { get; set; }

		[DataMember(Name="helocInitialTerm")]
		public int? HelocInitialTerm { get; set; }

		[DataMember(Name="helocInitPerDiemCalculationMethodType")]
		public string HelocInitPerDiemCalculationMethodType { get; set; }

		[DataMember(Name="helocInterestOnly")]
		public bool? HelocInterestOnly { get; set; }

		[DataMember(Name="hELOCLienPosition")]
		public string HELOCLienPosition { get; set; }

		[DataMember(Name="helocNewFinancingNotLinkedCreditLimit")]
		public decimal? HelocNewFinancingNotLinkedCreditLimit { get; set; }

		[DataMember(Name="helocNewFinancingNotLinkedDrawAmount")]
		public decimal? HelocNewFinancingNotLinkedDrawAmount { get; set; }

		[DataMember(Name="helocPaymentBasis")]
		public string HelocPaymentBasis { get; set; }

		[DataMember(Name="helocPercent")]
		public decimal? HelocPercent { get; set; }

		[DataMember(Name="helocPercentageofBalance")]
		public decimal? HelocPercentageofBalance { get; set; }

		[DataMember(Name="helocPeriodTemplateName")]
		public string HelocPeriodTemplateName { get; set; }

		[DataMember(Name="helocQualifyingBalance")]
		public string HelocQualifyingBalance { get; set; }

		[DataMember(Name="helocQualifyingTerm")]
		public int? HelocQualifyingTerm { get; set; }

		[DataMember(Name="helocRate")]
		public string HelocRate { get; set; }

		[DataMember(Name="helocRepaymentDrawPeriods")]
		public List<LoanContractLoanProductDataHelocRepaymentDrawPeriods> HelocRepaymentDrawPeriods { get; set; }

		[DataMember(Name = "helocRepaymentBasis")]
		public bool? HelocRepaymentBasis { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="indexCurrentValuePercent")]
		public decimal? IndexCurrentValuePercent { get; set; }

		[DataMember(Name="indexLookbackPeriod")]
		public string IndexLookbackPeriod { get; set; }

		[DataMember(Name="indexMarginPercent")]
		public decimal? IndexMarginPercent { get; set; }

		[DataMember(Name="indexMarginPercentUI")]
		public string IndexMarginPercentUI { get; set; }

		[DataMember(Name="initialAdvanceAmount")]
		public decimal? InitialAdvanceAmount { get; set; }

		[DataMember(Name="initialApplicationAmount")]
		public decimal? InitialApplicationAmount { get; set; }

		[DataMember(Name="inquiryOrPreQualificationIndicator")]
		public bool? InquiryOrPreQualificationIndicator { get; set; }

		[DataMember(Name="lienPriorityType")]
		public string LienPriorityType { get; set; }

		[DataMember(Name="loanDocumentationType")]
		public string LoanDocumentationType { get; set; }

		[DataMember(Name="loanRepaymentType")]
		public string LoanRepaymentType { get; set; }

		[DataMember(Name="loanScheduledClosingDate")]
		public DateTime? LoanScheduledClosingDate { get; set; }

		[DataMember(Name="maximumMonthlyPayment")]
		public decimal? MaximumMonthlyPayment { get; set; }

		[DataMember(Name="maxLifeInterestCapPercent")]
		public decimal? MaxLifeInterestCapPercent { get; set; }

		[DataMember(Name="maxLifeInterestCapPercentUI")]
		public string MaxLifeInterestCapPercentUI { get; set; }

		[DataMember(Name="miCoveragePercent")]
		public decimal? MiCoveragePercent { get; set; }

		[DataMember(Name="minimumAdvanceAmount")]
		public decimal? MinimumAdvanceAmount { get; set; }

		[DataMember(Name="minimumAllowableApr")]
		public decimal? MinimumAllowableApr { get; set; }

		[DataMember(Name="minimumDrawPeroidPaymentPercent")]
		public decimal? MinimumDrawPeroidPaymentPercent { get; set; }

		[DataMember(Name="minimumPaymentAmount")]
		public decimal? MinimumPaymentAmount { get; set; }

		[DataMember(Name="minimumPaymentLessThanAmount")]
		public decimal? MinimumPaymentLessThanAmount { get; set; }

		[DataMember(Name="minimumPaymentPercent")]
		public decimal? MinimumPaymentPercent { get; set; }

		[DataMember(Name="minimumPaymentUpbAmount")]
		public decimal? MinimumPaymentUpbAmount { get; set; }

		[DataMember(Name="minimumPaymentUpbPercent")]
		public decimal? MinimumPaymentUpbPercent { get; set; }

		[DataMember(Name="minimumRepayPeriodPaymentPercent")]
		public decimal? MinimumRepayPeriodPaymentPercent { get; set; }

		[DataMember(Name="monthsAppliedToPrepaymentPenaltyFeeCount")]
		public int? MonthsAppliedToPrepaymentPenaltyFeeCount { get; set; }

		[DataMember(Name="negativeAmortizationLimitPercent")]
		public decimal? NegativeAmortizationLimitPercent { get; set; }

		[DataMember(Name="netInitialAndFinal")]
		public decimal? NetInitialAndFinal { get; set; }

		[DataMember(Name="nmlsDocumentationType")]
		public string NmlsDocumentationType { get; set; }

		[DataMember(Name="nmlsFirstMortgageType")]
		public string NmlsFirstMortgageType { get; set; }

		[DataMember(Name="nmlsLienStatus")]
		public string NmlsLienStatus { get; set; }

		[DataMember(Name="nmlsLoanType")]
		public string NmlsLoanType { get; set; }

		[DataMember(Name="nmlsOptionARMIndicator")]
		public bool? NmlsOptionARMIndicator { get; set; }

		[DataMember(Name="nmlsPiggyBackOrFundedHELOCIndicator")]
		public bool? NmlsPiggyBackOrFundedHELOCIndicator { get; set; }

		[DataMember(Name="nmlsProductionSoldToType")]
		public string NmlsProductionSoldToType { get; set; }

		[DataMember(Name="nmlsPropertyType")]
		public string NmlsPropertyType { get; set; }

		[DataMember(Name="nmlsRefinancePurposeType")]
		public string NmlsRefinancePurposeType { get; set; }

		[DataMember(Name="nmlsReverseMortgageType")]
		public string NmlsReverseMortgageType { get; set; }

		[DataMember(Name="oralRequestForExtensionOfCreditIndicator")]
		public bool? OralRequestForExtensionOfCreditIndicator { get; set; }

		[DataMember(Name="overLimitCharge")]
		public decimal? OverLimitCharge { get; set; }

		[DataMember(Name="overLimitReturnCharge")]
		public decimal? OverLimitReturnCharge { get; set; }

		[DataMember(Name="participationFees")]
		public decimal? ParticipationFees { get; set; }

		[DataMember(Name="paymentAdjustmentDurationMonthsCount")]
		public int? PaymentAdjustmentDurationMonthsCount { get; set; }

		[DataMember(Name="paymentAdjustmentPeriodicCapPercent")]
		public decimal? PaymentAdjustmentPeriodicCapPercent { get; set; }

		[DataMember(Name="paymentFrequencyType")]
		public string PaymentFrequencyType { get; set; }

		[DataMember(Name="prepaymentPenalties")]
		public List<LoanContractLoanProductDataPrepaymentPenalties> PrepaymentPenalties { get; set; }

		[DataMember(Name="prepaymentPenaltyBasedOn")]
		public string PrepaymentPenaltyBasedOn { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator")]
		public bool? PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyPercent")]
		public decimal? PrepaymentPenaltyPercent { get; set; }

		[DataMember(Name="prepaymentPenaltyTermMonthsCount")]
		public int? PrepaymentPenaltyTermMonthsCount { get; set; }

		[DataMember(Name="prepaymentPenaltyVerbiage")]
		public string PrepaymentPenaltyVerbiage { get; set; }

		[DataMember(Name="productName")]
		public string ProductName { get; set; }

		[DataMember(Name="qualifyingRatePercent")]
		public decimal? QualifyingRatePercent { get; set; }

		[DataMember(Name="rateAdjustmentDurationMonthsCount")]
		public int? RateAdjustmentDurationMonthsCount { get; set; }

		[DataMember(Name="rateAdjustmentLifetimeCapPercent")]
		public decimal? RateAdjustmentLifetimeCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentPercent")]
		public decimal? RateAdjustmentPercent { get; set; }

		[DataMember(Name="rateAdjustmentPercentUI")]
		public string RateAdjustmentPercentUI { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentCapPercent")]
		public decimal? RateAdjustmentSubsequentCapPercent { get; set; }

		[DataMember(Name="rateAdjustmentSubsequentCapPercentUI")]
		public string RateAdjustmentSubsequentCapPercentUI { get; set; }

		[DataMember(Name="releaseRecoringCharge")]
		public decimal? ReleaseRecoringCharge { get; set; }

		[DataMember(Name="remainingBuydownAmount")]
		public decimal? RemainingBuydownAmount { get; set; }

		[DataMember(Name="repayPeriodMonthsCount")]
		public int? RepayPeriodMonthsCount { get; set; }

		[DataMember(Name="returnedCheckCharge")]
		public decimal? ReturnedCheckCharge { get; set; }

		[DataMember(Name="returnedCheckChargeRatePercent")]
		public decimal? ReturnedCheckChargeRatePercent { get; set; }

		[DataMember(Name="returnedCheckMaxCharge")]
		public decimal? ReturnedCheckMaxCharge { get; set; }

		[DataMember(Name="returnedCheckMinCharge")]
		public decimal? ReturnedCheckMinCharge { get; set; }

		[DataMember(Name="roundPercent")]
		public decimal? RoundPercent { get; set; }

		[DataMember(Name="roundType")]
		public string RoundType { get; set; }

		[DataMember(Name="scheduledFirstPaymentAdjustmentDate")]
		public DateTime? ScheduledFirstPaymentAdjustmentDate { get; set; }

		[DataMember(Name="scheduledFirstPaymentDate")]
		public DateTime? ScheduledFirstPaymentDate { get; set; }

		[DataMember(Name="stopPaymentCharge")]
		public decimal? StopPaymentCharge { get; set; }

		[DataMember(Name="subsequentRateAdjustmentMonthsCount")]
		public int? SubsequentRateAdjustmentMonthsCount { get; set; }

		[DataMember(Name="terminationFeeAmount")]
		public decimal? TerminationFeeAmount { get; set; }

		[DataMember(Name="terminationPeriodMonthsCount")]
		public int? TerminationPeriodMonthsCount { get; set; }

		[DataMember(Name="thirdPartyFeeFromAmount")]
		public decimal? ThirdPartyFeeFromAmount { get; set; }

		[DataMember(Name="thirdPartyFeeToAmount")]
		public decimal? ThirdPartyFeeToAmount { get; set; }

		[DataMember(Name="timelyPaymentRateReductionPercent")]
		public decimal? TimelyPaymentRateReductionPercent { get; set; }

		[DataMember(Name="timelyPaymentRewards")]
		public string TimelyPaymentRewards { get; set; }

		[DataMember(Name="totalSubsidyAmount")]
		public decimal? TotalSubsidyAmount { get; set; }

		[DataMember(Name="transactionFees")]
		public decimal? TransactionFees { get; set; }

		[DataMember(Name="wireFee")]
		public decimal? WireFee { get; set; }

		[DataMember(Name = "helocEscrowAccountIndicator")]
		public bool? HelocEscrowAccountIndicator { get; set; }

		[DataMember(Name = "helocDrawPaymentBasis")]
		public bool? HelocDrawPaymentBasis { get; set; }

		[DataMember(Name = "helocDrawPaymentBasisType")]
		public string HelocDrawPaymentBasisType { get; set; }

		[DataMember(Name = "helocTaRepaymentTermEndBy")]
		public string HelocTaRepaymentTermEndBy { get; set; }

		[DataMember(Name = "helocTaAprCharged")]
		public decimal? HelocTaAprCharged { get; set; }

		[DataMember(Name = "helocTaFeesCharged")]
		public string HelocTaFeesCharged { get; set; }

		[DataMember(Name = "helocTaIntroRateAppliedOn")]
		public string HelocTaIntroRateAppliedOn { get; set; }

		[DataMember(Name = "helocTaOverLimitChargeOption")]
		public string HelocTaOverLimitChargeOption { get; set; }

		[DataMember(Name = "helocTaDrawCheckIndicator")]
		public string HelocTaDrawCheckIndicator { get; set; }

		[DataMember(Name = "helocTaRequestByPhoneIndicator")]
		public bool? HelocTaRequestByPhoneIndicator { get; set; }

		[DataMember(Name = "helocTaWrittenAuthorizationIndicator")]
		public bool? HelocTaWrittenAuthorizationIndicator { get; set; }

		[DataMember(Name = "helocTaCreditCardIndicator")]
		public bool? HelocTaCreditCardIndicator { get; set; }

		[DataMember(Name = "helocTaOverdraftProtectionIndicator")]
		public bool? HelocTaOverdraftProtectionIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceInPersonIndicator")]
		public bool? HelocTaRequestAdvanceInPersonIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceViaInternetIndicator")]
		public bool? HelocTaRequestAdvanceViaInternetIndicator { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceInPersonLocation")]
		public string HelocTaRequestAdvanceInPersonLocation { get; set; }

		[DataMember(Name = "helocTaRequestAdvanceViaInternetUrl")]
		public string HelocTaRequestAdvanceViaInternetUrl { get; set; }

		[DataMember(Name = "helocTaAppRoundingOption")]
		public string HelocTaAppRoundingOption { get; set; }

		[DataMember(Name = "helocTaDailyBalanceType")]
		public string HelocTaDailyBalanceType { get; set; }

		[DataMember(Name = "helocTaIndexRefDateOption")]
		public string HelocTaIndexRefDateOption { get; set; }

		[DataMember(Name = "helocTaPeriodicRateAdjDayOption")]
		public string HelocTaPeriodicRateAdjDayOption { get; set; }

		[DataMember(Name = "helocTaAppChangeOption")]
		public string HelocTaAppChangeOption { get; set; }

		[DataMember(Name = "helocTaPeriodicCapAppliedToAdvancePeriod")]
		public bool? HelocTaPeriodicCapAppliedToAdvancePeriod { get; set; }

		[DataMember(Name = "helocTaPeriodicCapAppliedToRepaymentPeriod")]
		public bool? HelocTaPeriodicCapAppliedToRepaymentPeriod { get; set; }

		[DataMember(Name = "helocTaDailyRateRoundingOption")]
		public string HelocTaDailyRateRoundingOption { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanPeriodicRateRoundingPercent")]
		public decimal? HelocTaInstallmentLoanPeriodicRateRoundingPercent { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanDiscountedAprIndicator")]
		public bool? HelocTaInstallmentLoanDiscountedAprIndicator { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanDiscountWord")]
		public string HelocTaInstallmentLoanDiscountWord { get; set; }

		[DataMember(Name = "helocTaInstallmentIndexRefDateOption")]
		public string HelocTaInstallmentIndexRefDateOption { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanTerminationMethod")]
		public string HelocTaInstallmentLoanTerminationMethod { get; set; }

		[DataMember(Name = "helocTaInstallmentLoanPaymentAppliedMethod")]
		public string HelocTaInstallmentLoanPaymentAppliedMethod { get; set; }

		[DataMember(Name = "helocTaRequireRepayIndicator")]
		public bool? HelocTaRequireRepayIndicator { get; set; }

		[DataMember(Name = "helocTaLenderToPay3rdPartyCost")]
		public string HelocTaLenderToPay3rdPartyCost { get; set; }

		[DataMember(Name = "helocTaRightToSetoffIndicator")]
		public bool? HelocTaRightToSetoffIndicator { get; set; }

		[DataMember(Name = "helocTaAlNonDepositoryIndicator")]
		public bool? HelocTaAlNonDepositoryIndicator { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationAddr")]
		public string HelocTaCreditCardMisuseNotificationAddr { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationPhoneNumber")]
		public string HelocTaCreditCardMisuseNotificationPhoneNumber { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationWebAddr")]
		public string HelocTaCreditCardMisuseNotificationWebAddr { get; set; }

		[DataMember(Name = "helocTaCreditCardMisuseNotificationEmailAddr")]
		public string HelocTaCreditCardMisuseNotificationEmailAddr { get; set; }

		[DataMember(Name = "helocHistoricalTableName")]
		public string HelocHistoricalTableName { get; set; }

		[DataMember(Name = "helocStandardHistoricalTableIndicator")]
		public bool? HelocStandardHistoricalTableIndicator { get; set; }

		[DataMember(Name = "lenderRepresentative")]
		public string LenderRepresentative { get; set; }

		[DataMember(Name = "lenderRepresentativeFirstLastName")]
		public string LenderRepresentativeFirstLastName { get; set; }

		[DataMember(Name = "lenderRepresentativeEmailAddress")]
		public string LenderRepresentativeEmailAddress { get; set; }

		[DataMember(Name = "lenderRepresentativeRoleId")]
		public string LenderRepresentativeRoleId { get; set; }

		[DataMember(Name = "lenderRepresentativeWorkPhone")]
		public string LenderRepresentativeWorkPhone { get; set; }

		[DataMember(Name = "lenderRepresentativeCellPhone")]
		public string LenderRepresentativeCellPhone { get; set; }

	}
}