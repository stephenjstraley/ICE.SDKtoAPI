using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUldd
	{
		[DataMember(Name="aCHABARoutingAndTransitIdentifier")]
		public string ACHABARoutingAndTransitIdentifier { get; set; }

		[DataMember(Name="aCHABARoutingAndTransitNumber")]
		public string ACHABARoutingAndTransitNumber { get; set; }

		[DataMember(Name="aCHBankAccountDescription")]
		public string ACHBankAccountDescription { get; set; }

		[DataMember(Name="aCHBankAccountIdentifier")]
		public string ACHBankAccountIdentifier { get; set; }

		[DataMember(Name="aCHBankAccountPurposeTransitIdentifier")]
		public string ACHBankAccountPurposeTransitIdentifier { get; set; }

		[DataMember(Name="aCHBankAccountPurposeType")]
		public string ACHBankAccountPurposeType { get; set; }

		[DataMember(Name="aCHInstitutionTelegraphicAbbreviationName")]
		public string ACHInstitutionTelegraphicAbbreviationName { get; set; }

		[DataMember(Name="aCHReceiverSubaccountName")]
		public string ACHReceiverSubaccountName { get; set; }

		[DataMember(Name="additionalPrincipalAmountIndicator")]
		public bool? AdditionalPrincipalAmountIndicator { get; set; }

		[DataMember(Name="aggregateLoanCurtailmentAmount")]
		public decimal? AggregateLoanCurtailmentAmount { get; set; }

		[DataMember(Name="appraisalIdentifier")]
		public string AppraisalIdentifier { get; set; }

		[DataMember(Name="attachmentType")]
		public string AttachmentType { get; set; }

		[DataMember(Name="aVMModelNameType")]
		public string AVMModelNameType { get; set; }

		[DataMember(Name="balloonResetIndicator")]
		public bool? BalloonResetIndicator { get; set; }

		[DataMember(Name="baseGuarantyFeePercent")]
		public decimal? BaseGuarantyFeePercent { get; set; }

		[DataMember(Name="bondFinancePool")]
		public string BondFinancePool { get; set; }

		[DataMember(Name="bondFinanceProgramName")]
		public string BondFinanceProgramName { get; set; }

		[DataMember(Name="bondFinanceProgramType")]
		public string BondFinanceProgramType { get; set; }

		[DataMember(Name="borrowerMailToAddressSameasPropertyIndicator")]
		public bool? BorrowerMailToAddressSameasPropertyIndicator { get; set; }

		[DataMember(Name="borrowerType")]
		public string BorrowerType { get; set; }

		[DataMember(Name="capitalizedLoanIndicator")]
		public bool? CapitalizedLoanIndicator { get; set; }

		[DataMember(Name="certificateIdentifier")]
		public string CertificateIdentifier { get; set; }

		[DataMember(Name="certificateMaturityDate")]
		public DateTime? CertificateMaturityDate { get; set; }

		[DataMember(Name="certificatePrincipalBalanceAmount")]
		public decimal? CertificatePrincipalBalanceAmount { get; set; }

		[DataMember(Name="certificateType")]
		public string CertificateType { get; set; }

		[DataMember(Name="closingCost2ContributionAmount")]
		public decimal? ClosingCost2ContributionAmount { get; set; }

		[DataMember(Name="closingCost2FundsType")]
		public string ClosingCost2FundsType { get; set; }

		[DataMember(Name="closingCost2FundsTypeOtherDescription")]
		public string ClosingCost2FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost2SourceType")]
		public string ClosingCost2SourceType { get; set; }

		[DataMember(Name="closingCost2SourceTypeOtherDescription")]
		public string ClosingCost2SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost3ContributionAmount")]
		public decimal? ClosingCost3ContributionAmount { get; set; }

		[DataMember(Name="closingCost3FundsType")]
		public string ClosingCost3FundsType { get; set; }

		[DataMember(Name="closingCost3FundsTypeOtherDescription")]
		public string ClosingCost3FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost3SourceType")]
		public string ClosingCost3SourceType { get; set; }

		[DataMember(Name="closingCost3SourceTypeOtherDescription")]
		public string ClosingCost3SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost4ContributionAmount")]
		public decimal? ClosingCost4ContributionAmount { get; set; }

		[DataMember(Name="closingCost4FundsType")]
		public string ClosingCost4FundsType { get; set; }

		[DataMember(Name="closingCost4FundsTypeOtherDescription")]
		public string ClosingCost4FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost4SourceType")]
		public string ClosingCost4SourceType { get; set; }

		[DataMember(Name="closingCost4SourceTypeOtherDescription")]
		public string ClosingCost4SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCostContributionAmount")]
		public decimal? ClosingCostContributionAmount { get; set; }

		[DataMember(Name="closingCostFundsType")]
		public string ClosingCostFundsType { get; set; }

		[DataMember(Name="closingCostFundsTypeOtherDescription")]
		public string ClosingCostFundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCostSourceType")]
		public string ClosingCostSourceType { get; set; }

		[DataMember(Name="closingCostSourceTypeOtherDescription")]
		public string ClosingCostSourceTypeOtherDescription { get; set; }

		[DataMember(Name="coBorrowerCountryCode")]
		public string CoBorrowerCountryCode { get; set; }

		[DataMember(Name="coBorrowerMailToAddressSameasPropertyIndicator")]
		public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get; set; }

		[DataMember(Name="coBorrowerType")]
		public string CoBorrowerType { get; set; }

		[DataMember(Name="condominiumProjectStatusType")]
		public string CondominiumProjectStatusType { get; set; }

		[DataMember(Name="constructionMethodType")]
		public string ConstructionMethodType { get; set; }

		[DataMember(Name="constructionMethodTypeOtherDescription")]
		public string ConstructionMethodTypeOtherDescription { get; set; }

		[DataMember(Name="constructionToPermanentClosingFeatureType")]
		public string ConstructionToPermanentClosingFeatureType { get; set; }

		[DataMember(Name="constructionToPermanentClosingType")]
		public string ConstructionToPermanentClosingType { get; set; }

		[DataMember(Name="convertibleStatusType")]
		public string ConvertibleStatusType { get; set; }

		[DataMember(Name="counselingFormatType")]
		public string CounselingFormatType { get; set; }

		[DataMember(Name="counselingFormatTypeOtherDescription")]
		public string CounselingFormatTypeOtherDescription { get; set; }

		[DataMember(Name="counselTypeOther")]
		public string CounselTypeOther { get; set; }

		[DataMember(Name="countryCode")]
		public string CountryCode { get; set; }

		[DataMember(Name="creditScoreImpairmentType")]
		public string CreditScoreImpairmentType { get; set; }

		[DataMember(Name="currentAccruedInterestAmount")]
		public decimal? CurrentAccruedInterestAmount { get; set; }

		[DataMember(Name="delinquentPaymentsOverPastTwelveMonthsCount")]
		public int? DelinquentPaymentsOverPastTwelveMonthsCount { get; set; }

		[DataMember(Name="documentCustodianID")]
		public string DocumentCustodianID { get; set; }

		[DataMember(Name="documentRequiredIndicator")]
		public string DocumentRequiredIndicator { get; set; }

		[DataMember(Name="documentSubmissionIndicator")]
		public string DocumentSubmissionIndicator { get; set; }

		[DataMember(Name="downPaymentFundsType")]
		public string DownPaymentFundsType { get; set; }

		[DataMember(Name="downPaymentOtherTypeDescription")]
		public string DownPaymentOtherTypeDescription { get; set; }

		[DataMember(Name="downPaymentSourceType")]
		public string DownPaymentSourceType { get; set; }

		[DataMember(Name="downPaymentSourceTypeOtherDescription")]
		public string DownPaymentSourceTypeOtherDescription { get; set; }

		[DataMember(Name="fannieARMIndexType")]
		public string FannieARMIndexType { get; set; }

		[DataMember(Name="fannieAutoUWDec")]
		public string FannieAutoUWDec { get; set; }

		[DataMember(Name="fannieBLTV")]
		public int? FannieBLTV { get; set; }

		[DataMember(Name="fannieBorrowerFirstName")]
		public string FannieBorrowerFirstName { get; set; }

		[DataMember(Name="fannieBorrowerMiddleName")]
		public string FannieBorrowerMiddleName { get; set; }

		[DataMember(Name="fannieBuydownContributer")]
		public string FannieBuydownContributer { get; set; }

		[DataMember(Name="fannieCLTV")]
		public int? FannieCLTV { get; set; }

		[DataMember(Name="fannieCoBorrowerFirstName")]
		public string FannieCoBorrowerFirstName { get; set; }

		[DataMember(Name="fannieCoBorrowerMiddleName")]
		public string FannieCoBorrowerMiddleName { get; set; }

		[DataMember(Name="fannieCreditScoreProviderName")]
		public string FannieCreditScoreProviderName { get; set; }

		[DataMember(Name="fannieFloodSpecialFeatureCode")]
		public string FannieFloodSpecialFeatureCode { get; set; }

		[DataMember(Name="fannieHCLTV")]
		public int? FannieHCLTV { get; set; }

		[DataMember(Name="fannieInvestorOwnershipPercent")]
		public int? FannieInvestorOwnershipPercent { get; set; }

		[DataMember(Name="fannieLegalEntityType")]
		public string FannieLegalEntityType { get; set; }

		[DataMember(Name="fannieLegalEntityTypeOther")]
		public string FannieLegalEntityTypeOther { get; set; }

		[DataMember(Name="fannieLenderPaidMIInterestRateAdjustmentPercent")]
		public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get; set; }

		[DataMember(Name="fannieLoanProgramIdentifier")]
		public string FannieLoanProgramIdentifier { get; set; }

		[DataMember(Name="fannieLTV")]
		public int? FannieLTV { get; set; }

		[DataMember(Name="fannieMICompanyNameTypeOther")]
		public string FannieMICompanyNameTypeOther { get; set; }

		[DataMember(Name="fannieMICoveragePercent")]
		public int? FannieMICoveragePercent { get; set; }

		[DataMember(Name="fanniePoolOwnershipPercent")]
		public int? FanniePoolOwnershipPercent { get; set; }

		[DataMember(Name="fannieProjectClassificationType")]
		public string FannieProjectClassificationType { get; set; }

		[DataMember(Name="fanniePropertyFormType")]
		public string FanniePropertyFormType { get; set; }

		[DataMember(Name="fannieRateSpread")]
		public decimal? FannieRateSpread { get; set; }

		[DataMember(Name="fannieRefinanceType")]
		public string FannieRefinanceType { get; set; }

		[DataMember(Name="fannieRelatedInvestorLoanID")]
		public string FannieRelatedInvestorLoanID { get; set; }

		[DataMember(Name="fannieRelatedLoanAmortizationType")]
		public string FannieRelatedLoanAmortizationType { get; set; }

		[DataMember(Name="fannieRelatedLoanLienPosition")]
		public string FannieRelatedLoanLienPosition { get; set; }

		[DataMember(Name="fannieRelatedLoanType")]
		public string FannieRelatedLoanType { get; set; }

		[DataMember(Name="fannieSectionOfAct")]
		public string FannieSectionOfAct { get; set; }

		[DataMember(Name="fannieTLTV")]
		public int? FannieTLTV { get; set; }

		[DataMember(Name="fannieTrustName")]
		public string FannieTrustName { get; set; }

		[DataMember(Name="fannnieMortgageType")]
		public string FannnieMortgageType { get; set; }

		[DataMember(Name="financedUnitCount")]
		public int? FinancedUnitCount { get; set; }

		[DataMember(Name="firstRateChangePaymentEffectiveDate")]
		public DateTime? FirstRateChangePaymentEffectiveDate { get; set; }

		[DataMember(Name="fNMHomeImprovementProductType")]
		public string FNMHomeImprovementProductType { get; set; }

		[DataMember(Name="freddieARMIndexType")]
		public string FreddieARMIndexType { get; set; }

		[DataMember(Name="freddieAutoUWDec")]
		public string FreddieAutoUWDec { get; set; }

		[DataMember(Name="freddieAVMModelNameTypeExpl")]
		public string FreddieAVMModelNameTypeExpl { get; set; }

		[DataMember(Name="freddieBorrowerAlienStatus")]
		public string FreddieBorrowerAlienStatus { get; set; }

		[DataMember(Name="freddieCoBorrowerAlienStatus")]
		public string FreddieCoBorrowerAlienStatus { get; set; }

		[DataMember(Name="freddieCreditScoreProviderName")]
		public string FreddieCreditScoreProviderName { get; set; }

		[DataMember(Name="freddieDownPaymentType")]
		public string FreddieDownPaymentType { get; set; }

		[DataMember(Name="freddieDownPmt2SourceType")]
		public string FreddieDownPmt2SourceType { get; set; }

		[DataMember(Name="freddieDownPmt2SourceTypeExpl")]
		public string FreddieDownPmt2SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt2Type")]
		public string FreddieDownPmt2Type { get; set; }

		[DataMember(Name="freddieDownPmt2TypeExpl")]
		public string FreddieDownPmt2TypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt3Amt")]
		public string FreddieDownPmt3Amt { get; set; }

		[DataMember(Name="freddieDownPmt3SourceType")]
		public string FreddieDownPmt3SourceType { get; set; }

		[DataMember(Name="freddieDownPmt3SourceTypeExpl")]
		public string FreddieDownPmt3SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt3Type")]
		public string FreddieDownPmt3Type { get; set; }

		[DataMember(Name="freddieDownPmt3TypeExpl")]
		public string FreddieDownPmt3TypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt4Amt")]
		public string FreddieDownPmt4Amt { get; set; }

		[DataMember(Name="freddieDownPmt4SourceType")]
		public string FreddieDownPmt4SourceType { get; set; }

		[DataMember(Name="freddieDownPmt4SourceTypeExpl")]
		public string FreddieDownPmt4SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt4Type")]
		public string FreddieDownPmt4Type { get; set; }

		[DataMember(Name="freddieDownPmt4TypeExpl")]
		public string FreddieDownPmt4TypeExpl { get; set; }

		[DataMember(Name="freddieExplanationOfDownPayment")]
		public string FreddieExplanationOfDownPayment { get; set; }

		[DataMember(Name="freddieInvestorCollateralProgramIdentifier")]
		public string FreddieInvestorCollateralProgramIdentifier { get; set; }

		[DataMember(Name="freddieInvestorFeatureIdentifier")]
		public string FreddieInvestorFeatureIdentifier { get; set; }

		[DataMember(Name="freddieLegalEntityType")]
		public string FreddieLegalEntityType { get; set; }

		[DataMember(Name="freddieLegalEntityTypeOther")]
		public string FreddieLegalEntityTypeOther { get; set; }

		[DataMember(Name="freddieLoanProgramIdentifier")]
		public string FreddieLoanProgramIdentifier { get; set; }

		[DataMember(Name="freddieLoanTypePublicAndIndianHousingIndicator")]
		public string FreddieLoanTypePublicAndIndianHousingIndicator { get; set; }

		[DataMember(Name="freddieMICompanyNameTypeOther")]
		public string FreddieMICompanyNameTypeOther { get; set; }

		[DataMember(Name="freddieMortgageType")]
		public string FreddieMortgageType { get; set; }

		[DataMember(Name="freddieProjectClassificationType")]
		public string FreddieProjectClassificationType { get; set; }

		[DataMember(Name="freddiePropertyFormType")]
		public string FreddiePropertyFormType { get; set; }

		[DataMember(Name="freddieRefinanceCashOutDeterminationType")]
		public string FreddieRefinanceCashOutDeterminationType { get; set; }

		[DataMember(Name="freddieRefinanceType")]
		public string FreddieRefinanceType { get; set; }

		[DataMember(Name="freddieRelatedClosedEndSecondIndicator")]
		public bool? FreddieRelatedClosedEndSecondIndicator { get; set; }

		[DataMember(Name="freddieRelatedInvestorLoanID")]
		public string FreddieRelatedInvestorLoanID { get; set; }

		[DataMember(Name="freddieRelatedLoanInvestorType")]
		public string FreddieRelatedLoanInvestorType { get; set; }

		[DataMember(Name="freddieRelatedLoanLienPosition")]
		public string FreddieRelatedLoanLienPosition { get; set; }

		[DataMember(Name="freddieRelatedLoanType")]
		public string FreddieRelatedLoanType { get; set; }

		[DataMember(Name="freddieSectionOfAct")]
		public string FreddieSectionOfAct { get; set; }

		[DataMember(Name="freddieUnderwritingTypeOther")]
		public string FreddieUnderwritingTypeOther { get; set; }

		[DataMember(Name="ginnieConstructionMethodType")]
		public string GinnieConstructionMethodType { get; set; }

		[DataMember(Name="ginnieGovernmentAnnualPremiumAmount")]
		public decimal? GinnieGovernmentAnnualPremiumAmount { get; set; }

		[DataMember(Name="ginnieMortgageType")]
		public string GinnieMortgageType { get; set; }

		[DataMember(Name="ginnieOtherConstructionMethodType")]
		public string GinnieOtherConstructionMethodType { get; set; }

		[DataMember(Name="governmentAnnualPremiumPercent")]
		public decimal? GovernmentAnnualPremiumPercent { get; set; }

		[DataMember(Name="governmentRefinanceType")]
		public string GovernmentRefinanceType { get; set; }

		[DataMember(Name="governmentUpfrontPremiumAmount")]
		public decimal? GovernmentUpfrontPremiumAmount { get; set; }

		[DataMember(Name="governmentUpfrontPremiumPercent")]
		public decimal? GovernmentUpfrontPremiumPercent { get; set; }

		[DataMember(Name="gSEProjectType")]
		public string GSEProjectType { get; set; }

		[DataMember(Name="guaranteeFeeAddOnIndicator")]
		public bool? GuaranteeFeeAddOnIndicator { get; set; }

		[DataMember(Name="guarantyFeeAfterAlternatePaymentMethodPercent")]
		public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get; set; }

		[DataMember(Name="guarantyFeePercent")]
		public decimal? GuarantyFeePercent { get; set; }

		[DataMember(Name="guarantyPercent")]
		public decimal? GuarantyPercent { get; set; }

		[DataMember(Name="homeOwnerAssociationEin")]
		public string HomeOwnerAssociationEin { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="indexType")]
		public string IndexType { get; set; }

		[DataMember(Name="initialFixedPeriodEffectiveMonthsCount")]
		public int? InitialFixedPeriodEffectiveMonthsCount { get; set; }

		[DataMember(Name="interestAccrualType")]
		public string InterestAccrualType { get; set; }

		[DataMember(Name="interestAndPaymentAdjustmentIndexLeadDaysCount")]
		public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="interestCalculationBasisType")]
		public string InterestCalculationBasisType { get; set; }

		[DataMember(Name="interestCalculationEffectiveMonthsCount")]
		public int? InterestCalculationEffectiveMonthsCount { get; set; }

		[DataMember(Name="interestCalculationType")]
		public string InterestCalculationType { get; set; }

		[DataMember(Name="investorCollateralProgramIdentifier")]
		public string InvestorCollateralProgramIdentifier { get; set; }

		[DataMember(Name="investorCommitmentIdentifier")]
		public string InvestorCommitmentIdentifier { get; set; }

		[DataMember(Name="investorFeatureIdentifier")]
		public string InvestorFeatureIdentifier { get; set; }

		[DataMember(Name="investorFeatureIdPool")]
		public string InvestorFeatureIdPool { get; set; }

		[DataMember(Name="investorOwnershipPercent")]
		public decimal? InvestorOwnershipPercent { get; set; }

		[DataMember(Name="investorProductPlanIdentifier")]
		public string InvestorProductPlanIdentifier { get; set; }

		[DataMember(Name="investorRemittanceDay")]
		public int? InvestorRemittanceDay { get; set; }

		[DataMember(Name="investorRemittanceType")]
		public string InvestorRemittanceType { get; set; }

		[DataMember(Name="issuerIdentifier")]
		public string IssuerIdentifier { get; set; }

		[DataMember(Name="lastPaidInstallmentDueDate")]
		public DateTime? LastPaidInstallmentDueDate { get; set; }

		[DataMember(Name="lastPaymentReceivedDate")]
		public DateTime? LastPaymentReceivedDate { get; set; }

		[DataMember(Name="latestConversionEffectiveDate")]
		public DateTime? LatestConversionEffectiveDate { get; set; }

		[DataMember(Name= "lenderPaidMiInterestRateAdjustmentPercent")]
		public decimal? LenderPaidMIInterestRateAdjustmentPercent { get; set; }

		[DataMember(Name="lendersDeliveryDate")]
		public DateTime? LendersDeliveryDate { get; set; }

		[DataMember(Name="loanAcquisitionScheduledUPBAmount")]
		public decimal? LoanAcquisitionScheduledUPBAmount { get; set; }

		[DataMember(Name="loanAmortizationMaximumTermMonthsCount")]
		public int? LoanAmortizationMaximumTermMonthsCount { get; set; }

		[DataMember(Name="loanBuyupBuydownBasisPointNumber")]
		public int? LoanBuyupBuydownBasisPointNumber { get; set; }

		[DataMember(Name="loanBuyupBuydownType")]
		public string LoanBuyupBuydownType { get; set; }

		[DataMember(Name="loanDefaultLossPartyType")]
		public string LoanDefaultLossPartyType { get; set; }

		[DataMember(Name="loanDeliveredThroughServicingReleasedProcessIndicator")]
		public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get; set; }

		[DataMember(Name="loanIdentifierValueType")]
		public string LoanIdentifierValueType { get; set; }

		[DataMember(Name="loanInterestAccrualStartDate")]
		public DateTime? LoanInterestAccrualStartDate { get; set; }

		[DataMember(Name="loanLevelCreditScoreSelectionMethodSellerSpecificIndicator")]
		public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get; set; }

		[DataMember(Name="loanLevelCreditScoreSelectionMethodType")]
		public string LoanLevelCreditScoreSelectionMethodType { get; set; }

		[DataMember(Name="loanLevelCreditScoreValue")]
		public int? LoanLevelCreditScoreValue { get; set; }

		[DataMember(Name="loanModificationEffectiveDate")]
		public DateTime? LoanModificationEffectiveDate { get; set; }

		[DataMember(Name="loanStateDate")]
		public DateTime? LoanStateDate { get; set; }

		[DataMember(Name="manufacturedHomeWidthType")]
		public string ManufacturedHomeWidthType { get; set; }

		[DataMember(Name="mBSWeightedMarginIndicator")]
		public bool? MBSWeightedMarginIndicator { get; set; }

		[DataMember(Name="mERSOriginalMortgageeOfRecordIndicator")]
		public string MERSOriginalMortgageeOfRecordIndicator { get; set; }

		[DataMember(Name="mICompanyNameType")]
		public string MICompanyNameType { get; set; }

		[DataMember(Name="mIPremiumSourceType")]
		public string MIPremiumSourceType { get; set; }

		[DataMember(Name="monetaryEventAppliedDate")]
		public DateTime? MonetaryEventAppliedDate { get; set; }

		[DataMember(Name="monetaryEventGrossPrincipalAmount")]
		public decimal? MonetaryEventGrossPrincipalAmount { get; set; }

		[DataMember(Name="monetaryEventType")]
		public string MonetaryEventType { get; set; }

		[DataMember(Name="mortgageBackedSecurityIndicator")]
		public bool? MortgageBackedSecurityIndicator { get; set; }

		[DataMember(Name="mortgageModificationIndicator")]
		public bool? MortgageModificationIndicator { get; set; }

		[DataMember(Name="mortgageOriginator")]
		public string MortgageOriginator { get; set; }

		[DataMember(Name="mortgageProgramType")]
		public string MortgageProgramType { get; set; }

		[DataMember(Name="multipleConcurrentlyClosingLienOnSubjectPropertyIndicator")]
		public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get; set; }

		[DataMember(Name="nextRateAdjustmentEffectiveDate")]
		public DateTime? NextRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="notePayToName")]
		public string NotePayToName { get; set; }

		[DataMember(Name="numberOfUnitsSold")]
		public int? NumberOfUnitsSold { get; set; }

		[DataMember(Name="otherDownPaymentFundsType")]
		public string OtherDownPaymentFundsType { get; set; }

		[DataMember(Name="otherFundsCollectedAtClosingAmount")]
		public decimal? OtherFundsCollectedAtClosingAmount { get; set; }

		[DataMember(Name="otherFundsCollectedAtClosingType")]
		public string OtherFundsCollectedAtClosingType { get; set; }

		[DataMember(Name="payeeID")]
		public string PayeeID { get; set; }

		[DataMember(Name="paymentBillingStatementLeadDaysCount")]
		public int? PaymentBillingStatementLeadDaysCount { get; set; }

		[DataMember(Name="perChangeMaximumDecreaseRatePercent")]
		public decimal? PerChangeMaximumDecreaseRatePercent { get; set; }

		[DataMember(Name="perChangeMaximumIncreaseRatePercent")]
		public decimal? PerChangeMaximumIncreaseRatePercent { get; set; }

		[DataMember(Name="perChangePrincipalAndInterestPaymentAdjustmentPercent")]
		public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get; set; }

		[DataMember(Name="perChangeRateAdjustmentEffectiveDate")]
		public DateTime? PerChangeRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name = "perChangeRateAdjustmentFrequencyMonthsCount")]
		public int? PerChangeRateAdjustmentFrequencyMonthsCount { get; set; } = 0;

		[DataMember(Name="poolAccrualRateStructureType")]
		public string PoolAccrualRateStructureType { get; set; }

		[DataMember(Name="poolAmortizationType")]
		public string PoolAmortizationType { get; set; }

		[DataMember(Name="poolAssumabilityIndicator")]
		public bool? PoolAssumabilityIndicator { get; set; }

		[DataMember(Name="poolBalloonIndicator")]
		public bool? PoolBalloonIndicator { get; set; }

		[DataMember(Name="poolCertificatePaymentDate")]
		public DateTime? PoolCertificatePaymentDate { get; set; }

		[DataMember(Name="poolClassType")]
		public string PoolClassType { get; set; }

		[DataMember(Name="poolConcurrentTransferIndicator")]
		public string PoolConcurrentTransferIndicator { get; set; }

		[DataMember(Name="poolCurrentLoanCount")]
		public int? PoolCurrentLoanCount { get; set; }

		[DataMember(Name="poolCurrentPrincipalBalanceAmount")]
		public decimal? PoolCurrentPrincipalBalanceAmount { get; set; }

		[DataMember(Name="poolDocumentCustodianID")]
		public string PoolDocumentCustodianID { get; set; }

		[DataMember(Name="poolFixedServicingFeePercent")]
		public decimal? PoolFixedServicingFeePercent { get; set; }

		[DataMember(Name="poolIdentifier")]
		public string PoolIdentifier { get; set; }

		[DataMember(Name="poolingMethodType")]
		public string PoolingMethodType { get; set; }

		[DataMember(Name="poolInterestAdjustmentEffectiveDate")]
		public DateTime? PoolInterestAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="poolInterestAdjustmentIndexLeadDaysCount")]
		public int? PoolInterestAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="poolInterestAndPaymentAdjustmentIndexLeadDaysCount")]
		public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="poolInterestOnlyIndicator")]
		public bool? PoolInterestOnlyIndicator { get; set; }

		[DataMember(Name="poolInterestRateRoundingPercent")]
		public decimal? PoolInterestRateRoundingPercent { get; set; }

		[DataMember(Name="poolInterestRateRoundingType")]
		public string PoolInterestRateRoundingType { get; set; }

		[DataMember(Name="poolInvestorProductPlanIdentifier")]
		public string PoolInvestorProductPlanIdentifier { get; set; }

		[DataMember(Name="poolIssueDate")]
		public DateTime? PoolIssueDate { get; set; }

		[DataMember(Name="poolIssuerTransferee")]
		public string PoolIssuerTransferee { get; set; }

		[DataMember(Name="poolMarginRatePercent")]
		public decimal? PoolMarginRatePercent { get; set; }

		[DataMember(Name="poolMaturityDate")]
		public DateTime? PoolMaturityDate { get; set; }

		[DataMember(Name="poolMaturityPeriodCount")]
		public int? PoolMaturityPeriodCount { get; set; }

		[DataMember(Name="poolMaximumAccrualRatePercent")]
		public decimal? PoolMaximumAccrualRatePercent { get; set; }

		[DataMember(Name="poolMinimumAccrualRatePercent")]
		public decimal? PoolMinimumAccrualRatePercent { get; set; }

		[DataMember(Name="poolMortgageType")]
		public string PoolMortgageType { get; set; }

		[DataMember(Name="poolScheduledRemittancePaymentDay")]
		public int? PoolScheduledRemittancePaymentDay { get; set; }

		[DataMember(Name="poolSecurityIssueDateInterestRatePercent")]
		public decimal? PoolSecurityIssueDateInterestRatePercent { get; set; }

		[DataMember(Name="poolSellerID")]
		public string PoolSellerID { get; set; }

		[DataMember(Name="poolServicerID")]
		public string PoolServicerID { get; set; }

		[DataMember(Name= "poolStructureType")]
		public string PoolStructureType { get; set; }

		[DataMember(Name="poolSuffixIdentifier")]
		public string PoolSuffixIdentifier { get; set; }

		[DataMember(Name="priceLockDatetime")]
		public DateTime? PriceLockDatetime { get; set; }

		[DataMember(Name="primaryMIAbsenceReasonType")]
		public string PrimaryMIAbsenceReasonType { get; set; }

		[DataMember(Name="primaryMIAbsenceReasonTypeOtherDescription")]
		public string PrimaryMIAbsenceReasonTypeOtherDescription { get; set; }

		[DataMember(Name="projectAttachmentType")]
		public string ProjectAttachmentType { get; set; }

		[DataMember(Name="projectDesignType")]
		public string ProjectDesignType { get; set; }

		[DataMember(Name="projectUnitCount")]
		public int? ProjectUnitCount { get; set; }

		[DataMember(Name="propertyValuationEffectiveDate")]
		public DateTime? PropertyValuationEffectiveDate { get; set; }

		[DataMember(Name="propertyValuationMethodType")]
		public string PropertyValuationMethodType { get; set; }

		[DataMember(Name="propertyValuationOther")]
		public string PropertyValuationOther { get; set; }

		[DataMember(Name="refinanceCashOutAmount")]
		public decimal? RefinanceCashOutAmount { get; set; }

		[DataMember(Name="refinanceCashOutDeterminationType")]
		public string RefinanceCashOutDeterminationType { get; set; }

		[DataMember(Name="relatedLoanAffordableIndicator")]
		public bool? RelatedLoanAffordableIndicator { get; set; }

		[DataMember(Name="relatedLoanBalloonIndicator")]
		public bool? RelatedLoanBalloonIndicator { get; set; }

		[DataMember(Name="relatedLoanHELOCIndicator")]
		public bool? RelatedLoanHELOCIndicator { get; set; }

		[DataMember(Name="relatedLoanIndicator")]
		public bool? RelatedLoanIndicator { get; set; }

		[DataMember(Name="relatedLoanInvestorType")]
		public string RelatedLoanInvestorType { get; set; }

		[DataMember(Name="relatedLoanMaturityPeriodCount")]
		public int? RelatedLoanMaturityPeriodCount { get; set; }

		[DataMember(Name="relatedLoanNoteDate")]
		public DateTime? RelatedLoanNoteDate { get; set; }

		[DataMember(Name="relatedLoanScheduledFirstPaymentDate")]
		public DateTime? RelatedLoanScheduledFirstPaymentDate { get; set; }

		[DataMember(Name="relatedLoanStateDateAtClosing")]
		public DateTime? RelatedLoanStateDateAtClosing { get; set; }

		[DataMember(Name="relatedLoanUnpaidPrincipalBalanceAmount")]
		public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get; set; }

		[DataMember(Name="relocationLoanIndicator")]
		public bool? RelocationLoanIndicator { get; set; }

		[DataMember(Name="rEOMarketingPartyType")]
		public string REOMarketingPartyType { get; set; }

		[DataMember(Name="secondLienIsDeliveredIndicator")]
		public bool? SecondLienIsDeliveredIndicator { get; set; }

		[DataMember(Name="securityOriginalSubscriptionAmount")]
		public decimal? SecurityOriginalSubscriptionAmount { get; set; }

		[DataMember(Name="securityTradeBookEntryDate")]
		public DateTime? SecurityTradeBookEntryDate { get; set; }

		[DataMember(Name="sellerID")]
		public string SellerID { get; set; }

		[DataMember(Name="sellerLoanIdentifier")]
		public string SellerLoanIdentifier { get; set; }

		[DataMember(Name="servicerID")]
		public string ServicerID { get; set; }

		[DataMember(Name="servicerLoanIdentifier")]
		public string ServicerLoanIdentifier { get; set; }

		[DataMember(Name="sharedEquityIndicator")]
		public bool? SharedEquityIndicator { get; set; }

		[DataMember(Name="siteBuiltIndicator")]
		public bool? SiteBuiltIndicator { get; set; }

		[DataMember(Name="specialFloodHazardAreaIndicator")]
		public bool? SpecialFloodHazardAreaIndicator { get; set; }

		[DataMember(Name="subsequentPerChangeMaximumDecreaseRatePercent")]
		public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get; set; }

		[DataMember(Name="subsequentPerChangeMaximumIncreaseRatePercent")]
		public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get; set; }

		[DataMember(Name="subsequentPerChangeRateAdjustmentEffectiveDate")]
		public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="subsequentPerChangeRateAdjustmentFrequencyMonthsCount")]
		public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get; set; }

		[DataMember(Name="temporaryBuydownIndicator")]
		public bool? TemporaryBuydownIndicator { get; set; }

		[DataMember(Name="totalMortgagedPropertiesCount")]
		public int? TotalMortgagedPropertiesCount { get; set; }

		[DataMember(Name="unit1SubjectPropertyGrossRentalIncome")]
		public decimal? Unit1SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit1TotalBedrooms")]
		public int? Unit1TotalBedrooms { get; set; }

		[DataMember(Name="unit2SubjectPropertyGrossRentalIncome")]
		public decimal? Unit2SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit2TotalBedrooms")]
		public int? Unit2TotalBedrooms { get; set; }

		[DataMember(Name="unit3SubjectPropertyGrossRentalIncome")]
		public decimal? Unit3SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit3TotalBedrooms")]
		public int? Unit3TotalBedrooms { get; set; }

		[DataMember(Name="unit4SubjectPropertyGrossRentalIncome")]
		public decimal? Unit4SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit4TotalBedrooms")]
		public int? Unit4TotalBedrooms { get; set; }

		[DataMember(Name="uPBAmount")]
		public decimal? UPBAmount { get; set; }

		[DataMember(Name="wareHouseLenderId")]
		public string WareHouseLenderId { get; set; }

		[DataMember(Name="wareHouseLenderIndicator")]
		public bool? WareHouseLenderIndicator { get; set; }

		[DataMember(Name = "propertyEstateType")]
		public string PropertyEstateType { get; set; }

	}
}