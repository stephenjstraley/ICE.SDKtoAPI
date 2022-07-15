using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUldd
	{
		[DataMember(Name="aCHABARoutingAndTransitIdentifier", EmitDefaultValue=false)]
		public string ACHABARoutingAndTransitIdentifier { get; set; }

		[DataMember(Name="aCHABARoutingAndTransitNumber", EmitDefaultValue=false)]
		public string ACHABARoutingAndTransitNumber { get; set; }

		[DataMember(Name="aCHBankAccountDescription", EmitDefaultValue=false)]
		public string ACHBankAccountDescription { get; set; }

		[DataMember(Name="aCHBankAccountIdentifier", EmitDefaultValue=false)]
		public string ACHBankAccountIdentifier { get; set; }

		[DataMember(Name="aCHBankAccountPurposeTransitIdentifier", EmitDefaultValue=false)]
		public string ACHBankAccountPurposeTransitIdentifier { get; set; }

		[DataMember(Name="aCHBankAccountPurposeType", EmitDefaultValue=false)]
		public string ACHBankAccountPurposeType { get; set; }

		[DataMember(Name="aCHInstitutionTelegraphicAbbreviationName", EmitDefaultValue=false)]
		public string ACHInstitutionTelegraphicAbbreviationName { get; set; }

		[DataMember(Name="aCHReceiverSubaccountName", EmitDefaultValue=false)]
		public string ACHReceiverSubaccountName { get; set; }

		[DataMember(Name="additionalPrincipalAmountIndicator", EmitDefaultValue=false)]
		public bool? AdditionalPrincipalAmountIndicator { get; set; }

		[DataMember(Name="aggregateLoanCurtailmentAmount", EmitDefaultValue=false)]
		public double? AggregateLoanCurtailmentAmount { get; set; }

		[DataMember(Name="appraisalIdentifier", EmitDefaultValue=false)]
		public string AppraisalIdentifier { get; set; }

		[DataMember(Name="attachmentType", EmitDefaultValue=false)]
		public string AttachmentType { get; set; }

		[DataMember(Name="aVMModelNameType", EmitDefaultValue=false)]
		public string AVMModelNameType { get; set; }

		[DataMember(Name="balloonResetIndicator", EmitDefaultValue=false)]
		public bool? BalloonResetIndicator { get; set; }

		[DataMember(Name="baseGuarantyFeePercent", EmitDefaultValue=false)]
		public double? BaseGuarantyFeePercent { get; set; }

		[DataMember(Name="bondFinancePool", EmitDefaultValue=false)]
		public string BondFinancePool { get; set; }

		[DataMember(Name="bondFinanceProgramName", EmitDefaultValue=false)]
		public string BondFinanceProgramName { get; set; }

		[DataMember(Name="bondFinanceProgramType", EmitDefaultValue=false)]
		public string BondFinanceProgramType { get; set; }

		[DataMember(Name="borrowerMailToAddressSameasPropertyIndicator", EmitDefaultValue=false)]
		public bool? BorrowerMailToAddressSameasPropertyIndicator { get; set; }

		[DataMember(Name="borrowerType", EmitDefaultValue=false)]
		public string BorrowerType { get; set; }

		[DataMember(Name="capitalizedLoanIndicator", EmitDefaultValue=false)]
		public bool? CapitalizedLoanIndicator { get; set; }

		[DataMember(Name="certificateIdentifier", EmitDefaultValue=false)]
		public string CertificateIdentifier { get; set; }

		[DataMember(Name="certificateMaturityDate", EmitDefaultValue=false)]
		public DateTime? CertificateMaturityDate { get; set; }

		[DataMember(Name="certificatePrincipalBalanceAmount", EmitDefaultValue=false)]
		public double? CertificatePrincipalBalanceAmount { get; set; }

		[DataMember(Name="certificateType", EmitDefaultValue=false)]
		public string CertificateType { get; set; }

		[DataMember(Name="closingCost2ContributionAmount", EmitDefaultValue=false)]
		public double? ClosingCost2ContributionAmount { get; set; }

		[DataMember(Name="closingCost2FundsType", EmitDefaultValue=false)]
		public string ClosingCost2FundsType { get; set; }

		[DataMember(Name="closingCost2FundsTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost2FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost2SourceType", EmitDefaultValue=false)]
		public string ClosingCost2SourceType { get; set; }

		[DataMember(Name="closingCost2SourceTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost2SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost3ContributionAmount", EmitDefaultValue=false)]
		public double? ClosingCost3ContributionAmount { get; set; }

		[DataMember(Name="closingCost3FundsType", EmitDefaultValue=false)]
		public string ClosingCost3FundsType { get; set; }

		[DataMember(Name="closingCost3FundsTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost3FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost3SourceType", EmitDefaultValue=false)]
		public string ClosingCost3SourceType { get; set; }

		[DataMember(Name="closingCost3SourceTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost3SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost4ContributionAmount", EmitDefaultValue=false)]
		public double? ClosingCost4ContributionAmount { get; set; }

		[DataMember(Name="closingCost4FundsType", EmitDefaultValue=false)]
		public string ClosingCost4FundsType { get; set; }

		[DataMember(Name="closingCost4FundsTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost4FundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCost4SourceType", EmitDefaultValue=false)]
		public string ClosingCost4SourceType { get; set; }

		[DataMember(Name="closingCost4SourceTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCost4SourceTypeOtherDescription { get; set; }

		[DataMember(Name="closingCostContributionAmount", EmitDefaultValue=false)]
		public double? ClosingCostContributionAmount { get; set; }

		[DataMember(Name="closingCostFundsType", EmitDefaultValue=false)]
		public string ClosingCostFundsType { get; set; }

		[DataMember(Name="closingCostFundsTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCostFundsTypeOtherDescription { get; set; }

		[DataMember(Name="closingCostSourceType", EmitDefaultValue=false)]
		public string ClosingCostSourceType { get; set; }

		[DataMember(Name="closingCostSourceTypeOtherDescription", EmitDefaultValue=false)]
		public string ClosingCostSourceTypeOtherDescription { get; set; }

		[DataMember(Name="coBorrowerCountryCode", EmitDefaultValue=false)]
		public string CoBorrowerCountryCode { get; set; }

		[DataMember(Name="coBorrowerMailToAddressSameasPropertyIndicator", EmitDefaultValue=false)]
		public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get; set; }

		[DataMember(Name="coBorrowerType", EmitDefaultValue=false)]
		public string CoBorrowerType { get; set; }

		[DataMember(Name="condominiumProjectStatusType", EmitDefaultValue=false)]
		public string CondominiumProjectStatusType { get; set; }

		[DataMember(Name="constructionMethodType", EmitDefaultValue=false)]
		public string ConstructionMethodType { get; set; }

		[DataMember(Name="constructionMethodTypeOtherDescription", EmitDefaultValue=false)]
		public string ConstructionMethodTypeOtherDescription { get; set; }

		[DataMember(Name="constructionToPermanentClosingFeatureType", EmitDefaultValue=false)]
		public string ConstructionToPermanentClosingFeatureType { get; set; }

		[DataMember(Name="constructionToPermanentClosingType", EmitDefaultValue=false)]
		public string ConstructionToPermanentClosingType { get; set; }

		[DataMember(Name="convertibleStatusType", EmitDefaultValue=false)]
		public string ConvertibleStatusType { get; set; }

		[DataMember(Name="counselingFormatType", EmitDefaultValue=false)]
		public string CounselingFormatType { get; set; }

		[DataMember(Name="counselingFormatTypeOtherDescription", EmitDefaultValue=false)]
		public string CounselingFormatTypeOtherDescription { get; set; }

		[DataMember(Name="counselTypeOther", EmitDefaultValue=false)]
		public string CounselTypeOther { get; set; }

		[DataMember(Name="countryCode", EmitDefaultValue=false)]
		public string CountryCode { get; set; }

		[DataMember(Name="creditScoreImpairmentType", EmitDefaultValue=false)]
		public string CreditScoreImpairmentType { get; set; }

		[DataMember(Name="currentAccruedInterestAmount", EmitDefaultValue=false)]
		public double? CurrentAccruedInterestAmount { get; set; }

		[DataMember(Name="delinquentPaymentsOverPastTwelveMonthsCount", EmitDefaultValue=false)]
		public int? DelinquentPaymentsOverPastTwelveMonthsCount { get; set; }

		[DataMember(Name="documentCustodianID", EmitDefaultValue=false)]
		public string DocumentCustodianID { get; set; }

		[DataMember(Name="documentRequiredIndicator", EmitDefaultValue=false)]
		public string DocumentRequiredIndicator { get; set; }

		[DataMember(Name="documentSubmissionIndicator", EmitDefaultValue=false)]
		public string DocumentSubmissionIndicator { get; set; }

		[DataMember(Name="downPaymentFundsType", EmitDefaultValue=false)]
		public string DownPaymentFundsType { get; set; }

		[DataMember(Name="downPaymentOtherTypeDescription", EmitDefaultValue=false)]
		public string DownPaymentOtherTypeDescription { get; set; }

		[DataMember(Name="downPaymentSourceType", EmitDefaultValue=false)]
		public string DownPaymentSourceType { get; set; }

		[DataMember(Name="downPaymentSourceTypeOtherDescription", EmitDefaultValue=false)]
		public string DownPaymentSourceTypeOtherDescription { get; set; }

		[DataMember(Name="fannieARMIndexType", EmitDefaultValue=false)]
		public string FannieARMIndexType { get; set; }

		[DataMember(Name="fannieAutoUWDec", EmitDefaultValue=false)]
		public string FannieAutoUWDec { get; set; }

		[DataMember(Name="fannieBLTV", EmitDefaultValue=false)]
		public int? FannieBLTV { get; set; }

		[DataMember(Name="fannieBorrowerFirstName", EmitDefaultValue=false)]
		public string FannieBorrowerFirstName { get; set; }

		[DataMember(Name="fannieBorrowerMiddleName", EmitDefaultValue=false)]
		public string FannieBorrowerMiddleName { get; set; }

		[DataMember(Name="fannieBuydownContributer", EmitDefaultValue=false)]
		public string FannieBuydownContributer { get; set; }

		[DataMember(Name="fannieCLTV", EmitDefaultValue=false)]
		public int? FannieCLTV { get; set; }

		[DataMember(Name="fannieCoBorrowerFirstName", EmitDefaultValue=false)]
		public string FannieCoBorrowerFirstName { get; set; }

		[DataMember(Name="fannieCoBorrowerMiddleName", EmitDefaultValue=false)]
		public string FannieCoBorrowerMiddleName { get; set; }

		[DataMember(Name="fannieCreditScoreProviderName", EmitDefaultValue=false)]
		public string FannieCreditScoreProviderName { get; set; }

		[DataMember(Name="fannieFloodSpecialFeatureCode", EmitDefaultValue=false)]
		public string FannieFloodSpecialFeatureCode { get; set; }

		[DataMember(Name="fannieHCLTV", EmitDefaultValue=false)]
		public int? FannieHCLTV { get; set; }

		[DataMember(Name="fannieInvestorOwnershipPercent", EmitDefaultValue=false)]
		public int? FannieInvestorOwnershipPercent { get; set; }

		[DataMember(Name="fannieLegalEntityType", EmitDefaultValue=false)]
		public string FannieLegalEntityType { get; set; }

		[DataMember(Name="fannieLegalEntityTypeOther", EmitDefaultValue=false)]
		public string FannieLegalEntityTypeOther { get; set; }

		[DataMember(Name="fannieLenderPaidMIInterestRateAdjustmentPercent", EmitDefaultValue=false)]
		public double? FannieLenderPaidMIInterestRateAdjustmentPercent { get; set; }

		[DataMember(Name="fannieLoanProgramIdentifier", EmitDefaultValue=false)]
		public string FannieLoanProgramIdentifier { get; set; }

		[DataMember(Name="fannieLTV", EmitDefaultValue=false)]
		public int? FannieLTV { get; set; }

		[DataMember(Name="fannieMICompanyNameTypeOther", EmitDefaultValue=false)]
		public string FannieMICompanyNameTypeOther { get; set; }

		[DataMember(Name="fannieMICoveragePercent", EmitDefaultValue=false)]
		public int? FannieMICoveragePercent { get; set; }

		[DataMember(Name="fanniePoolOwnershipPercent", EmitDefaultValue=false)]
		public int? FanniePoolOwnershipPercent { get; set; }

		[DataMember(Name="fannieProjectClassificationType", EmitDefaultValue=false)]
		public string FannieProjectClassificationType { get; set; }

		[DataMember(Name="fanniePropertyFormType", EmitDefaultValue=false)]
		public string FanniePropertyFormType { get; set; }

		[DataMember(Name="fannieRateSpread", EmitDefaultValue=false)]
		public double? FannieRateSpread { get; set; }

		[DataMember(Name="fannieRefinanceType", EmitDefaultValue=false)]
		public string FannieRefinanceType { get; set; }

		[DataMember(Name="fannieRelatedInvestorLoanID", EmitDefaultValue=false)]
		public string FannieRelatedInvestorLoanID { get; set; }

		[DataMember(Name="fannieRelatedLoanAmortizationType", EmitDefaultValue=false)]
		public string FannieRelatedLoanAmortizationType { get; set; }

		[DataMember(Name="fannieRelatedLoanLienPosition", EmitDefaultValue=false)]
		public string FannieRelatedLoanLienPosition { get; set; }

		[DataMember(Name="fannieRelatedLoanType", EmitDefaultValue=false)]
		public string FannieRelatedLoanType { get; set; }

		[DataMember(Name="fannieSectionOfAct", EmitDefaultValue=false)]
		public string FannieSectionOfAct { get; set; }

		[DataMember(Name="fannieTLTV", EmitDefaultValue=false)]
		public int? FannieTLTV { get; set; }

		[DataMember(Name="fannieTrustName", EmitDefaultValue=false)]
		public string FannieTrustName { get; set; }

		[DataMember(Name="fannnieMortgageType", EmitDefaultValue=false)]
		public string FannnieMortgageType { get; set; }

		[DataMember(Name="financedUnitCount", EmitDefaultValue=false)]
		public int? FinancedUnitCount { get; set; }

		[DataMember(Name="firstRateChangePaymentEffectiveDate", EmitDefaultValue=false)]
		public DateTime? FirstRateChangePaymentEffectiveDate { get; set; }

		[DataMember(Name="fNMHomeImprovementProductType", EmitDefaultValue=false)]
		public string FNMHomeImprovementProductType { get; set; }

		[DataMember(Name="freddieARMIndexType", EmitDefaultValue=false)]
		public string FreddieARMIndexType { get; set; }

		[DataMember(Name="freddieAutoUWDec", EmitDefaultValue=false)]
		public string FreddieAutoUWDec { get; set; }

		[DataMember(Name="freddieAVMModelNameTypeExpl", EmitDefaultValue=false)]
		public string FreddieAVMModelNameTypeExpl { get; set; }

		[DataMember(Name="freddieBorrowerAlienStatus", EmitDefaultValue=false)]
		public string FreddieBorrowerAlienStatus { get; set; }

		[DataMember(Name="freddieCoBorrowerAlienStatus", EmitDefaultValue=false)]
		public string FreddieCoBorrowerAlienStatus { get; set; }

		[DataMember(Name="freddieCreditScoreProviderName", EmitDefaultValue=false)]
		public string FreddieCreditScoreProviderName { get; set; }

		[DataMember(Name="freddieDownPaymentType", EmitDefaultValue=false)]
		public string FreddieDownPaymentType { get; set; }

		[DataMember(Name="freddieDownPmt2SourceType", EmitDefaultValue=false)]
		public string FreddieDownPmt2SourceType { get; set; }

		[DataMember(Name="freddieDownPmt2SourceTypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt2SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt2Type", EmitDefaultValue=false)]
		public string FreddieDownPmt2Type { get; set; }

		[DataMember(Name="freddieDownPmt2TypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt2TypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt3Amt", EmitDefaultValue=false)]
		public string FreddieDownPmt3Amt { get; set; }

		[DataMember(Name="freddieDownPmt3SourceType", EmitDefaultValue=false)]
		public string FreddieDownPmt3SourceType { get; set; }

		[DataMember(Name="freddieDownPmt3SourceTypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt3SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt3Type", EmitDefaultValue=false)]
		public string FreddieDownPmt3Type { get; set; }

		[DataMember(Name="freddieDownPmt3TypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt3TypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt4Amt", EmitDefaultValue=false)]
		public string FreddieDownPmt4Amt { get; set; }

		[DataMember(Name="freddieDownPmt4SourceType", EmitDefaultValue=false)]
		public string FreddieDownPmt4SourceType { get; set; }

		[DataMember(Name="freddieDownPmt4SourceTypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt4SourceTypeExpl { get; set; }

		[DataMember(Name="freddieDownPmt4Type", EmitDefaultValue=false)]
		public string FreddieDownPmt4Type { get; set; }

		[DataMember(Name="freddieDownPmt4TypeExpl", EmitDefaultValue=false)]
		public string FreddieDownPmt4TypeExpl { get; set; }

		[DataMember(Name="freddieExplanationOfDownPayment", EmitDefaultValue=false)]
		public string FreddieExplanationOfDownPayment { get; set; }

		[DataMember(Name="freddieInvestorCollateralProgramIdentifier", EmitDefaultValue=false)]
		public string FreddieInvestorCollateralProgramIdentifier { get; set; }

		[DataMember(Name="freddieInvestorFeatureIdentifier", EmitDefaultValue=false)]
		public string FreddieInvestorFeatureIdentifier { get; set; }

		[DataMember(Name="freddieLegalEntityType", EmitDefaultValue=false)]
		public string FreddieLegalEntityType { get; set; }

		[DataMember(Name="freddieLegalEntityTypeOther", EmitDefaultValue=false)]
		public string FreddieLegalEntityTypeOther { get; set; }

		[DataMember(Name="freddieLoanProgramIdentifier", EmitDefaultValue=false)]
		public string FreddieLoanProgramIdentifier { get; set; }

		[DataMember(Name="freddieLoanTypePublicAndIndianHousingIndicator", EmitDefaultValue=false)]
		public string FreddieLoanTypePublicAndIndianHousingIndicator { get; set; }

		[DataMember(Name="freddieMICompanyNameTypeOther", EmitDefaultValue=false)]
		public string FreddieMICompanyNameTypeOther { get; set; }

		[DataMember(Name="freddieMortgageType", EmitDefaultValue=false)]
		public string FreddieMortgageType { get; set; }

		[DataMember(Name="freddieProjectClassificationType", EmitDefaultValue=false)]
		public string FreddieProjectClassificationType { get; set; }

		[DataMember(Name="freddiePropertyFormType", EmitDefaultValue=false)]
		public string FreddiePropertyFormType { get; set; }

		[DataMember(Name="freddieRefinanceCashOutDeterminationType", EmitDefaultValue=false)]
		public string FreddieRefinanceCashOutDeterminationType { get; set; }

		[DataMember(Name="freddieRefinanceType", EmitDefaultValue=false)]
		public string FreddieRefinanceType { get; set; }

		[DataMember(Name="freddieRelatedClosedEndSecondIndicator", EmitDefaultValue=false)]
		public bool? FreddieRelatedClosedEndSecondIndicator { get; set; }

		[DataMember(Name="freddieRelatedInvestorLoanID", EmitDefaultValue=false)]
		public string FreddieRelatedInvestorLoanID { get; set; }

		[DataMember(Name="freddieRelatedLoanInvestorType", EmitDefaultValue=false)]
		public string FreddieRelatedLoanInvestorType { get; set; }

		[DataMember(Name="freddieRelatedLoanLienPosition", EmitDefaultValue=false)]
		public string FreddieRelatedLoanLienPosition { get; set; }

		[DataMember(Name="freddieRelatedLoanType", EmitDefaultValue=false)]
		public string FreddieRelatedLoanType { get; set; }

		[DataMember(Name="freddieSectionOfAct", EmitDefaultValue=false)]
		public string FreddieSectionOfAct { get; set; }

		[DataMember(Name="freddieUnderwritingTypeOther", EmitDefaultValue=false)]
		public string FreddieUnderwritingTypeOther { get; set; }

		[DataMember(Name="ginnieConstructionMethodType", EmitDefaultValue=false)]
		public string GinnieConstructionMethodType { get; set; }

		[DataMember(Name="ginnieGovernmentAnnualPremiumAmount", EmitDefaultValue=false)]
		public double? GinnieGovernmentAnnualPremiumAmount { get; set; }

		[DataMember(Name="ginnieMortgageType", EmitDefaultValue=false)]
		public string GinnieMortgageType { get; set; }

		[DataMember(Name="ginnieOtherConstructionMethodType", EmitDefaultValue=false)]
		public string GinnieOtherConstructionMethodType { get; set; }

		[DataMember(Name="governmentAnnualPremiumPercent", EmitDefaultValue=false)]
		public double? GovernmentAnnualPremiumPercent { get; set; }

		[DataMember(Name="governmentRefinanceType", EmitDefaultValue=false)]
		public string GovernmentRefinanceType { get; set; }

		[DataMember(Name="governmentUpfrontPremiumAmount", EmitDefaultValue=false)]
		public double? GovernmentUpfrontPremiumAmount { get; set; }

		[DataMember(Name="governmentUpfrontPremiumPercent", EmitDefaultValue=false)]
		public double? GovernmentUpfrontPremiumPercent { get; set; }

		[DataMember(Name="gSEProjectType", EmitDefaultValue=false)]
		public string GSEProjectType { get; set; }

		[DataMember(Name="guaranteeFeeAddOnIndicator", EmitDefaultValue=false)]
		public bool? GuaranteeFeeAddOnIndicator { get; set; }

		[DataMember(Name="guarantyFeeAfterAlternatePaymentMethodPercent", EmitDefaultValue=false)]
		public double? GuarantyFeeAfterAlternatePaymentMethodPercent { get; set; }

		[DataMember(Name="guarantyFeePercent", EmitDefaultValue=false)]
		public double? GuarantyFeePercent { get; set; }

		[DataMember(Name="guarantyPercent", EmitDefaultValue=false)]
		public double? GuarantyPercent { get; set; }

		[DataMember(Name="homeOwnerAssociationEin", EmitDefaultValue=false)]
		public string HomeOwnerAssociationEin { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexType", EmitDefaultValue=false)]
		public string IndexType { get; set; }

		[DataMember(Name="initialFixedPeriodEffectiveMonthsCount", EmitDefaultValue=false)]
		public int? InitialFixedPeriodEffectiveMonthsCount { get; set; }

		[DataMember(Name="interestAccrualType", EmitDefaultValue=false)]
		public string InterestAccrualType { get; set; }

		[DataMember(Name="interestAndPaymentAdjustmentIndexLeadDaysCount", EmitDefaultValue=false)]
		public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="interestCalculationBasisType", EmitDefaultValue=false)]
		public string InterestCalculationBasisType { get; set; }

		[DataMember(Name="interestCalculationEffectiveMonthsCount", EmitDefaultValue=false)]
		public int? InterestCalculationEffectiveMonthsCount { get; set; }

		[DataMember(Name="interestCalculationType", EmitDefaultValue=false)]
		public string InterestCalculationType { get; set; }

		[DataMember(Name="investorCollateralProgramIdentifier", EmitDefaultValue=false)]
		public string InvestorCollateralProgramIdentifier { get; set; }

		[DataMember(Name="investorCommitmentIdentifier", EmitDefaultValue=false)]
		public string InvestorCommitmentIdentifier { get; set; }

		[DataMember(Name="investorFeatureIdentifier", EmitDefaultValue=false)]
		public string InvestorFeatureIdentifier { get; set; }

		[DataMember(Name="investorFeatureIdPool", EmitDefaultValue=false)]
		public string InvestorFeatureIdPool { get; set; }

		[DataMember(Name="investorOwnershipPercent", EmitDefaultValue=false)]
		public double? InvestorOwnershipPercent { get; set; }

		[DataMember(Name="investorProductPlanIdentifier", EmitDefaultValue=false)]
		public string InvestorProductPlanIdentifier { get; set; }

		[DataMember(Name="investorRemittanceDay", EmitDefaultValue=false)]
		public int? InvestorRemittanceDay { get; set; }

		[DataMember(Name="investorRemittanceType", EmitDefaultValue=false)]
		public string InvestorRemittanceType { get; set; }

		[DataMember(Name="issuerIdentifier", EmitDefaultValue=false)]
		public string IssuerIdentifier { get; set; }

		[DataMember(Name="lastPaidInstallmentDueDate", EmitDefaultValue=false)]
		public DateTime? LastPaidInstallmentDueDate { get; set; }

		[DataMember(Name="lastPaymentReceivedDate", EmitDefaultValue=false)]
		public DateTime? LastPaymentReceivedDate { get; set; }

		[DataMember(Name="latestConversionEffectiveDate", EmitDefaultValue=false)]
		public DateTime? LatestConversionEffectiveDate { get; set; }

		[DataMember(Name= "lenderPaidMiInterestRateAdjustmentPercent", EmitDefaultValue=false)]
		public double? LenderPaidMIInterestRateAdjustmentPercent { get; set; }

		[DataMember(Name="lendersDeliveryDate", EmitDefaultValue=false)]
		public DateTime? LendersDeliveryDate { get; set; }

		[DataMember(Name="loanAcquisitionScheduledUPBAmount", EmitDefaultValue=false)]
		public double? LoanAcquisitionScheduledUPBAmount { get; set; }

		[DataMember(Name="loanAmortizationMaximumTermMonthsCount", EmitDefaultValue=false)]
		public int? LoanAmortizationMaximumTermMonthsCount { get; set; }

		[DataMember(Name="loanBuyupBuydownBasisPointNumber", EmitDefaultValue=false)]
		public int? LoanBuyupBuydownBasisPointNumber { get; set; }

		[DataMember(Name="loanBuyupBuydownType", EmitDefaultValue=false)]
		public string LoanBuyupBuydownType { get; set; }

		[DataMember(Name="loanDefaultLossPartyType", EmitDefaultValue=false)]
		public string LoanDefaultLossPartyType { get; set; }

		[DataMember(Name="loanDeliveredThroughServicingReleasedProcessIndicator", EmitDefaultValue=false)]
		public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get; set; }

		[DataMember(Name="loanIdentifierValueType", EmitDefaultValue=false)]
		public string LoanIdentifierValueType { get; set; }

		[DataMember(Name="loanInterestAccrualStartDate", EmitDefaultValue=false)]
		public DateTime? LoanInterestAccrualStartDate { get; set; }

		[DataMember(Name="loanLevelCreditScoreSelectionMethodSellerSpecificIndicator", EmitDefaultValue=false)]
		public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get; set; }

		[DataMember(Name="loanLevelCreditScoreSelectionMethodType", EmitDefaultValue=false)]
		public string LoanLevelCreditScoreSelectionMethodType { get; set; }

		[DataMember(Name="loanLevelCreditScoreValue", EmitDefaultValue=false)]
		public int? LoanLevelCreditScoreValue { get; set; }

		[DataMember(Name="loanModificationEffectiveDate", EmitDefaultValue=false)]
		public DateTime? LoanModificationEffectiveDate { get; set; }

		[DataMember(Name="loanStateDate", EmitDefaultValue=false)]
		public DateTime? LoanStateDate { get; set; }

		[DataMember(Name="manufacturedHomeWidthType", EmitDefaultValue=false)]
		public string ManufacturedHomeWidthType { get; set; }

		[DataMember(Name="mBSWeightedMarginIndicator", EmitDefaultValue=false)]
		public bool? MBSWeightedMarginIndicator { get; set; }

		[DataMember(Name="mERSOriginalMortgageeOfRecordIndicator", EmitDefaultValue=false)]
		public string MERSOriginalMortgageeOfRecordIndicator { get; set; }

		[DataMember(Name="mICompanyNameType", EmitDefaultValue=false)]
		public string MICompanyNameType { get; set; }

		[DataMember(Name="mIPremiumSourceType", EmitDefaultValue=false)]
		public string MIPremiumSourceType { get; set; }

		[DataMember(Name="monetaryEventAppliedDate", EmitDefaultValue=false)]
		public DateTime? MonetaryEventAppliedDate { get; set; }

		[DataMember(Name="monetaryEventGrossPrincipalAmount", EmitDefaultValue=false)]
		public double? MonetaryEventGrossPrincipalAmount { get; set; }

		[DataMember(Name="monetaryEventType", EmitDefaultValue=false)]
		public string MonetaryEventType { get; set; }

		[DataMember(Name="mortgageBackedSecurityIndicator", EmitDefaultValue=false)]
		public bool? MortgageBackedSecurityIndicator { get; set; }

		[DataMember(Name="mortgageModificationIndicator", EmitDefaultValue=false)]
		public bool? MortgageModificationIndicator { get; set; }

		[DataMember(Name="mortgageOriginator", EmitDefaultValue=false)]
		public string MortgageOriginator { get; set; }

		[DataMember(Name="mortgageProgramType", EmitDefaultValue=false)]
		public string MortgageProgramType { get; set; }

		[DataMember(Name="multipleConcurrentlyClosingLienOnSubjectPropertyIndicator", EmitDefaultValue=false)]
		public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get; set; }

		[DataMember(Name="nextRateAdjustmentEffectiveDate", EmitDefaultValue=false)]
		public DateTime? NextRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="notePayToName", EmitDefaultValue=false)]
		public string NotePayToName { get; set; }

		[DataMember(Name="numberOfUnitsSold", EmitDefaultValue=false)]
		public int? NumberOfUnitsSold { get; set; }

		[DataMember(Name="otherDownPaymentFundsType", EmitDefaultValue=false)]
		public string OtherDownPaymentFundsType { get; set; }

		[DataMember(Name="otherFundsCollectedAtClosingAmount", EmitDefaultValue=false)]
		public double? OtherFundsCollectedAtClosingAmount { get; set; }

		[DataMember(Name="otherFundsCollectedAtClosingType", EmitDefaultValue=false)]
		public string OtherFundsCollectedAtClosingType { get; set; }

		[DataMember(Name="payeeID", EmitDefaultValue=false)]
		public string PayeeID { get; set; }

		[DataMember(Name="paymentBillingStatementLeadDaysCount", EmitDefaultValue=false)]
		public int? PaymentBillingStatementLeadDaysCount { get; set; }

		[DataMember(Name="perChangeMaximumDecreaseRatePercent", EmitDefaultValue=false)]
		public double? PerChangeMaximumDecreaseRatePercent { get; set; }

		[DataMember(Name="perChangeMaximumIncreaseRatePercent", EmitDefaultValue=false)]
		public double? PerChangeMaximumIncreaseRatePercent { get; set; }

		[DataMember(Name="perChangePrincipalAndInterestPaymentAdjustmentPercent", EmitDefaultValue=false)]
		public double? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get; set; }

		[DataMember(Name="perChangeRateAdjustmentEffectiveDate", EmitDefaultValue=false)]
		public DateTime? PerChangeRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name = "perChangeRateAdjustmentFrequencyMonthsCount", EmitDefaultValue = false)]
		public int? PerChangeRateAdjustmentFrequencyMonthsCount { get; set; } = 0;

		[DataMember(Name="poolAccrualRateStructureType", EmitDefaultValue=false)]
		public string PoolAccrualRateStructureType { get; set; }

		[DataMember(Name="poolAmortizationType", EmitDefaultValue=false)]
		public string PoolAmortizationType { get; set; }

		[DataMember(Name="poolAssumabilityIndicator", EmitDefaultValue=false)]
		public bool? PoolAssumabilityIndicator { get; set; }

		[DataMember(Name="poolBalloonIndicator", EmitDefaultValue=false)]
		public bool? PoolBalloonIndicator { get; set; }

		[DataMember(Name="poolCertificatePaymentDate", EmitDefaultValue=false)]
		public DateTime? PoolCertificatePaymentDate { get; set; }

		[DataMember(Name="poolClassType", EmitDefaultValue=false)]
		public string PoolClassType { get; set; }

		[DataMember(Name="poolConcurrentTransferIndicator", EmitDefaultValue=false)]
		public string PoolConcurrentTransferIndicator { get; set; }

		[DataMember(Name="poolCurrentLoanCount", EmitDefaultValue=false)]
		public int? PoolCurrentLoanCount { get; set; }

		[DataMember(Name="poolCurrentPrincipalBalanceAmount", EmitDefaultValue=false)]
		public double? PoolCurrentPrincipalBalanceAmount { get; set; }

		[DataMember(Name="poolDocumentCustodianID", EmitDefaultValue=false)]
		public string PoolDocumentCustodianID { get; set; }

		[DataMember(Name="poolFixedServicingFeePercent", EmitDefaultValue=false)]
		public double? PoolFixedServicingFeePercent { get; set; }

		[DataMember(Name="poolIdentifier", EmitDefaultValue=false)]
		public string PoolIdentifier { get; set; }

		[DataMember(Name="poolingMethodType", EmitDefaultValue=false)]
		public string PoolingMethodType { get; set; }

		[DataMember(Name="poolInterestAdjustmentEffectiveDate", EmitDefaultValue=false)]
		public DateTime? PoolInterestAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="poolInterestAdjustmentIndexLeadDaysCount", EmitDefaultValue=false)]
		public int? PoolInterestAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="poolInterestAndPaymentAdjustmentIndexLeadDaysCount", EmitDefaultValue=false)]
		public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get; set; }

		[DataMember(Name="poolInterestOnlyIndicator", EmitDefaultValue=false)]
		public bool? PoolInterestOnlyIndicator { get; set; }

		[DataMember(Name="poolInterestRateRoundingPercent", EmitDefaultValue=false)]
		public double? PoolInterestRateRoundingPercent { get; set; }

		[DataMember(Name="poolInterestRateRoundingType", EmitDefaultValue=false)]
		public string PoolInterestRateRoundingType { get; set; }

		[DataMember(Name="poolInvestorProductPlanIdentifier", EmitDefaultValue=false)]
		public string PoolInvestorProductPlanIdentifier { get; set; }

		[DataMember(Name="poolIssueDate", EmitDefaultValue=false)]
		public DateTime? PoolIssueDate { get; set; }

		[DataMember(Name="poolIssuerTransferee", EmitDefaultValue=false)]
		public string PoolIssuerTransferee { get; set; }

		[DataMember(Name="poolMarginRatePercent", EmitDefaultValue=false)]
		public double? PoolMarginRatePercent { get; set; }

		[DataMember(Name="poolMaturityDate", EmitDefaultValue=false)]
		public DateTime? PoolMaturityDate { get; set; }

		[DataMember(Name="poolMaturityPeriodCount", EmitDefaultValue=false)]
		public int? PoolMaturityPeriodCount { get; set; }

		[DataMember(Name="poolMaximumAccrualRatePercent", EmitDefaultValue=false)]
		public double? PoolMaximumAccrualRatePercent { get; set; }

		[DataMember(Name="poolMinimumAccrualRatePercent", EmitDefaultValue=false)]
		public double? PoolMinimumAccrualRatePercent { get; set; }

		[DataMember(Name="poolMortgageType", EmitDefaultValue=false)]
		public string PoolMortgageType { get; set; }

		[DataMember(Name="poolScheduledRemittancePaymentDay", EmitDefaultValue=false)]
		public int? PoolScheduledRemittancePaymentDay { get; set; }

		[DataMember(Name="poolSecurityIssueDateInterestRatePercent", EmitDefaultValue=false)]
		public double? PoolSecurityIssueDateInterestRatePercent { get; set; }

		[DataMember(Name="poolSellerID", EmitDefaultValue=false)]
		public string PoolSellerID { get; set; }

		[DataMember(Name="poolServicerID", EmitDefaultValue=false)]
		public string PoolServicerID { get; set; }

		[DataMember(Name= "poolStructureType", EmitDefaultValue=false)]
		public string PoolStructureType { get; set; }

		[DataMember(Name="poolSuffixIdentifier", EmitDefaultValue=false)]
		public string PoolSuffixIdentifier { get; set; }

		[DataMember(Name="priceLockDatetime", EmitDefaultValue=false)]
		public DateTime? PriceLockDatetime { get; set; }

		[DataMember(Name="primaryMIAbsenceReasonType", EmitDefaultValue=false)]
		public string PrimaryMIAbsenceReasonType { get; set; }

		[DataMember(Name="primaryMIAbsenceReasonTypeOtherDescription", EmitDefaultValue=false)]
		public string PrimaryMIAbsenceReasonTypeOtherDescription { get; set; }

		[DataMember(Name="projectAttachmentType", EmitDefaultValue=false)]
		public string ProjectAttachmentType { get; set; }

		[DataMember(Name="projectDesignType", EmitDefaultValue=false)]
		public string ProjectDesignType { get; set; }

		[DataMember(Name="projectUnitCount", EmitDefaultValue=false)]
		public int? ProjectUnitCount { get; set; }

		[DataMember(Name="propertyValuationEffectiveDate", EmitDefaultValue=false)]
		public DateTime? PropertyValuationEffectiveDate { get; set; }

		[DataMember(Name="propertyValuationMethodType", EmitDefaultValue=false)]
		public string PropertyValuationMethodType { get; set; }

		[DataMember(Name="propertyValuationOther", EmitDefaultValue=false)]
		public string PropertyValuationOther { get; set; }

		[DataMember(Name="refinanceCashOutAmount", EmitDefaultValue=false)]
		public double? RefinanceCashOutAmount { get; set; }

		[DataMember(Name="refinanceCashOutDeterminationType", EmitDefaultValue=false)]
		public string RefinanceCashOutDeterminationType { get; set; }

		[DataMember(Name="relatedLoanAffordableIndicator", EmitDefaultValue=false)]
		public bool? RelatedLoanAffordableIndicator { get; set; }

		[DataMember(Name="relatedLoanBalloonIndicator", EmitDefaultValue=false)]
		public bool? RelatedLoanBalloonIndicator { get; set; }

		[DataMember(Name="relatedLoanHELOCIndicator", EmitDefaultValue=false)]
		public bool? RelatedLoanHELOCIndicator { get; set; }

		[DataMember(Name="relatedLoanIndicator", EmitDefaultValue=false)]
		public bool? RelatedLoanIndicator { get; set; }

		[DataMember(Name="relatedLoanInvestorType", EmitDefaultValue=false)]
		public string RelatedLoanInvestorType { get; set; }

		[DataMember(Name="relatedLoanMaturityPeriodCount", EmitDefaultValue=false)]
		public int? RelatedLoanMaturityPeriodCount { get; set; }

		[DataMember(Name="relatedLoanNoteDate", EmitDefaultValue=false)]
		public DateTime? RelatedLoanNoteDate { get; set; }

		[DataMember(Name="relatedLoanScheduledFirstPaymentDate", EmitDefaultValue=false)]
		public DateTime? RelatedLoanScheduledFirstPaymentDate { get; set; }

		[DataMember(Name="relatedLoanStateDateAtClosing", EmitDefaultValue=false)]
		public DateTime? RelatedLoanStateDateAtClosing { get; set; }

		[DataMember(Name="relatedLoanUnpaidPrincipalBalanceAmount", EmitDefaultValue=false)]
		public double? RelatedLoanUnpaidPrincipalBalanceAmount { get; set; }

		[DataMember(Name="relocationLoanIndicator", EmitDefaultValue=false)]
		public bool? RelocationLoanIndicator { get; set; }

		[DataMember(Name="rEOMarketingPartyType", EmitDefaultValue=false)]
		public string REOMarketingPartyType { get; set; }

		[DataMember(Name="secondLienIsDeliveredIndicator", EmitDefaultValue=false)]
		public bool? SecondLienIsDeliveredIndicator { get; set; }

		[DataMember(Name="securityOriginalSubscriptionAmount", EmitDefaultValue=false)]
		public double? SecurityOriginalSubscriptionAmount { get; set; }

		[DataMember(Name="securityTradeBookEntryDate", EmitDefaultValue=false)]
		public DateTime? SecurityTradeBookEntryDate { get; set; }

		[DataMember(Name="sellerID", EmitDefaultValue=false)]
		public string SellerID { get; set; }

		[DataMember(Name="sellerLoanIdentifier", EmitDefaultValue=false)]
		public string SellerLoanIdentifier { get; set; }

		[DataMember(Name="servicerID", EmitDefaultValue=false)]
		public string ServicerID { get; set; }

		[DataMember(Name="servicerLoanIdentifier", EmitDefaultValue=false)]
		public string ServicerLoanIdentifier { get; set; }

		[DataMember(Name="sharedEquityIndicator", EmitDefaultValue=false)]
		public bool? SharedEquityIndicator { get; set; }

		[DataMember(Name="siteBuiltIndicator", EmitDefaultValue=false)]
		public bool? SiteBuiltIndicator { get; set; }

		[DataMember(Name="specialFloodHazardAreaIndicator", EmitDefaultValue=false)]
		public bool? SpecialFloodHazardAreaIndicator { get; set; }

		[DataMember(Name="subsequentPerChangeMaximumDecreaseRatePercent", EmitDefaultValue=false)]
		public double? SubsequentPerChangeMaximumDecreaseRatePercent { get; set; }

		[DataMember(Name="subsequentPerChangeMaximumIncreaseRatePercent", EmitDefaultValue=false)]
		public double? SubsequentPerChangeMaximumIncreaseRatePercent { get; set; }

		[DataMember(Name="subsequentPerChangeRateAdjustmentEffectiveDate", EmitDefaultValue=false)]
		public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get; set; }

		[DataMember(Name="subsequentPerChangeRateAdjustmentFrequencyMonthsCount", EmitDefaultValue=false)]
		public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get; set; }

		[DataMember(Name="temporaryBuydownIndicator", EmitDefaultValue=false)]
		public bool? TemporaryBuydownIndicator { get; set; }

		[DataMember(Name="totalMortgagedPropertiesCount", EmitDefaultValue=false)]
		public int? TotalMortgagedPropertiesCount { get; set; }

		[DataMember(Name="unit1SubjectPropertyGrossRentalIncome", EmitDefaultValue=false)]
		public double? Unit1SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit1TotalBedrooms", EmitDefaultValue=false)]
		public int? Unit1TotalBedrooms { get; set; }

		[DataMember(Name="unit2SubjectPropertyGrossRentalIncome", EmitDefaultValue=false)]
		public double? Unit2SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit2TotalBedrooms", EmitDefaultValue=false)]
		public int? Unit2TotalBedrooms { get; set; }

		[DataMember(Name="unit3SubjectPropertyGrossRentalIncome", EmitDefaultValue=false)]
		public double? Unit3SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit3TotalBedrooms", EmitDefaultValue=false)]
		public int? Unit3TotalBedrooms { get; set; }

		[DataMember(Name="unit4SubjectPropertyGrossRentalIncome", EmitDefaultValue=false)]
		public double? Unit4SubjectPropertyGrossRentalIncome { get; set; }

		[DataMember(Name="unit4TotalBedrooms", EmitDefaultValue=false)]
		public int? Unit4TotalBedrooms { get; set; }

		[DataMember(Name="uPBAmount", EmitDefaultValue=false)]
		public double? UPBAmount { get; set; }

		[DataMember(Name="wareHouseLenderId", EmitDefaultValue=false)]
		public string WareHouseLenderId { get; set; }

		[DataMember(Name="wareHouseLenderIndicator", EmitDefaultValue=false)]
		public bool? WareHouseLenderIndicator { get; set; }

	}
}