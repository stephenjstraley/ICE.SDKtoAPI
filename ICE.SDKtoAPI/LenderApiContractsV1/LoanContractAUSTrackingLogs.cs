using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAUSTrackingLogs
	{
		[DataMember(Name="aUSTrackingLogIndex")]
		public int? AUSTrackingLogIndex { get; set; }

		[DataMember(Name="batchDocumentRefId")]
		public string BatchDocumentRefId { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name = "logAusLogExtensionId")]
		public string LogAusLogExtensionId { get; set; }

		[DataMember(Name = "logAusResponseFileName")]
		public string LogAusResponseFileName { get; set; }		

		[DataMember(Name="isEmpty")]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="isHistory")]
		public bool? IsHistory { get; set; }

		[DataMember(Name="logAcceptPlusEligible")]
		public string LogAcceptPlusEligible { get; set; }

		[DataMember(Name="logAffordableProductType")]
		public string LogAffordableProductType { get; set; }

		[DataMember(Name="logAllOtherPayments")]
		public decimal? LogAllOtherPayments { get; set; }

		[DataMember(Name="logAmortizationMonths")]
		public int? LogAmortizationMonths { get; set; }

		[DataMember(Name="logAmortizationType")]
		public string LogAmortizationType { get; set; }

		[DataMember(Name="logAmtSubordinateFin")]
		public decimal? LogAmtSubordinateFin { get; set; }

		[DataMember(Name="logAppraisalTypeMAF")]
		public string LogAppraisalTypeMAF { get; set; }

		[DataMember(Name="logAppraisedValue")]
		public int? LogAppraisedValue { get; set; }

		[DataMember(Name="logARMQualifyingRate")]
		public decimal? LogARMQualifyingRate { get; set; }

		[DataMember(Name="logAssessmentType")]
		public string LogAssessmentType { get; set; }

		[DataMember(Name="logAUSRecommendation")]
		public string LogAUSRecommendation { get; set; }

		[DataMember(Name="logAUSStatus")]
		public string LogAUSStatus { get; set; }

		[DataMember(Name="logAUSTrackingType")]
		public string LogAUSTrackingType { get; set; }

		[DataMember(Name="logAUSTransactionID")]
		public string LogAUSTransactionID { get; set; }

		[DataMember(Name="logAUSVersion")]
		public string LogAUSVersion { get; set; }

		[DataMember(Name="logBalloon")]
		public string LogBalloon { get; set; }

		[DataMember(Name="logBalloonTerm")]
		public int? LogBalloonTerm { get; set; }

		[DataMember(Name="logBorrowerAssetAmount")]
		public decimal? LogBorrowerAssetAmount { get; set; }

		[DataMember(Name="logBorrowerAssetName")]
		public string LogBorrowerAssetName { get; set; }

		[DataMember(Name="logBorrowerAssetType")]
		public string LogBorrowerAssetType { get; set; }

		[DataMember(Name="logBorrowerCreditScore1")]
		public string LogBorrowerCreditScore1 { get; set; }

		[DataMember(Name="logBorrowerCreditScore2")]
		public string LogBorrowerCreditScore2 { get; set; }

		[DataMember(Name="logBorrowerCreditScore3")]
		public string LogBorrowerCreditScore3 { get; set; }

		[DataMember(Name="logBorrowerEquifaxBEACON")]
		public string LogBorrowerEquifaxBEACON { get; set; }

		[DataMember(Name="logBorrowerExperianFICO")]
		public string LogBorrowerExperianFICO { get; set; }

		[DataMember(Name="logBorrowerIncomeAmount")]
		public decimal? LogBorrowerIncomeAmount { get; set; }

		[DataMember(Name="logBorrowerIncomeName")]
		public string LogBorrowerIncomeName { get; set; }

		[DataMember(Name="logBorrowerIncomeType")]
		public string LogBorrowerIncomeType { get; set; }

		[DataMember(Name="logBorrowerInstitutionName")]
		public string LogBorrowerInstitutionName { get; set; }

		[DataMember(Name="logBorrowerName")]
		public string LogBorrowerName { get; set; }

		[DataMember(Name="logBorrowerScoreName")]
		public string LogBorrowerScoreName { get; set; }

		[DataMember(Name="logBorrowerTransUnionEmpirica")]
		public string LogBorrowerTransUnionEmpirica { get; set; }

		[DataMember(Name="logBorrowerType1")]
		public string LogBorrowerType1 { get; set; }

		[DataMember(Name="logBorrowerType2")]
		public string LogBorrowerType2 { get; set; }

		[DataMember(Name="logBoughtDownRate")]
		public decimal? LogBoughtDownRate { get; set; }

		[DataMember(Name="logBuydown")]
		public string LogBuydown { get; set; }

		[DataMember(Name="logCashBack")]
		public decimal? LogCashBack { get; set; }

		[DataMember(Name="logCashOutAmount")]
		public decimal? LogCashOutAmount { get; set; }

		[DataMember(Name="logCLTV")]
		public decimal? LogCLTV { get; set; }

		[DataMember(Name="logCoBorrowerAssetAmount")]
		public decimal? LogCoBorrowerAssetAmount { get; set; }

		[DataMember(Name="logCoBorrowerAssetName")]
		public string LogCoBorrowerAssetName { get; set; }

		[DataMember(Name="logCoBorrowerAssetType")]
		public string LogCoBorrowerAssetType { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore1")]
		public string LogCoBorrowerCreditScore1 { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore2")]
		public string LogCoBorrowerCreditScore2 { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore3")]
		public string LogCoBorrowerCreditScore3 { get; set; }

		[DataMember(Name="logCoBorrowerEquifaxBEACON")]
		public string LogCoBorrowerEquifaxBEACON { get; set; }

		[DataMember(Name="logCoBorrowerExperianFICO")]
		public string LogCoBorrowerExperianFICO { get; set; }

		[DataMember(Name="logCoBorrowerIncomeAmount")]
		public decimal? LogCoBorrowerIncomeAmount { get; set; }

		[DataMember(Name="logCoBorrowerIncomeName")]
		public string LogCoBorrowerIncomeName { get; set; }

		[DataMember(Name="logCoBorrowerIncomeType")]
		public string LogCoBorrowerIncomeType { get; set; }

		[DataMember(Name="logCoBorrowerInstitutionName")]
		public string LogCoBorrowerInstitutionName { get; set; }

		[DataMember(Name="logCoborrowerName")]
		public string LogCoborrowerName { get; set; }

		[DataMember(Name="logCoBorrowerScoreName")]
		public string LogCoBorrowerScoreName { get; set; }

		[DataMember(Name="logCoBorrowerTransUnionEmpirica")]
		public string LogCoBorrowerTransUnionEmpirica { get; set; }

		[DataMember(Name="logCode1")]
		public string LogCode1 { get; set; }

		[DataMember(Name="logCode2")]
		public string LogCode2 { get; set; }

		[DataMember(Name="logCodeDescription1")]
		public string LogCodeDescription1 { get; set; }

		[DataMember(Name="logCodeDescription2")]
		public string LogCodeDescription2 { get; set; }

		[DataMember(Name="logCommunityLending")]
		public string LogCommunityLending { get; set; }

		[DataMember(Name="logCreatedOn")]
		public DateTime? LogCreatedOn { get; set; }

		[DataMember(Name="logCreditAgency1")]
		public string LogCreditAgency1 { get; set; }

		[DataMember(Name="logCreditAgency2")]
		public string LogCreditAgency2 { get; set; }

		[DataMember(Name="logCreditReportDate1")]
		public DateTime? LogCreditReportDate1 { get; set; }

		[DataMember(Name="logCreditReportDate2")]
		public DateTime? LogCreditReportDate2 { get; set; }

		[DataMember(Name="logCreditReportID1")]
		public string LogCreditReportID1 { get; set; }

		[DataMember(Name="logCreditReportID2")]
		public string LogCreditReportID2 { get; set; }

		[DataMember(Name="logCuredAmortizationType")]
		public string LogCuredAmortizationType { get; set; }

		[DataMember(Name="logCuredAppraisedValue")]
		public int? LogCuredAppraisedValue { get; set; }

		[DataMember(Name="logCuredCLTV")]
		public decimal? LogCuredCLTV { get; set; }

		[DataMember(Name="logCuredHousingExpenseRatio")]
		public decimal? LogCuredHousingExpenseRatio { get; set; }

		[DataMember(Name="logCuredLoanPurpose")]
		public string LogCuredLoanPurpose { get; set; }

		[DataMember(Name="logCuredLoanTerm")]
		public int? LogCuredLoanTerm { get; set; }

		[DataMember(Name="logCuredLoanType")]
		public string LogCuredLoanType { get; set; }

		[DataMember(Name="logCuredLTV")]
		public decimal? LogCuredLTV { get; set; }

		[DataMember(Name="logCuredNoteRate")]
		public decimal? LogCuredNoteRate { get; set; }

		[DataMember(Name="logCuredProposedTotalHousingPayment")]
		public decimal? LogCuredProposedTotalHousingPayment { get; set; }

		[DataMember(Name="logCuredRefinancePurpose")]
		public string LogCuredRefinancePurpose { get; set; }

		[DataMember(Name="logCuredTotalExpenseRatio")]
		public decimal? LogCuredTotalExpenseRatio { get; set; }

		[DataMember(Name="logCuredTotalLoanAmount")]
		public decimal? LogCuredTotalLoanAmount { get; set; }

		[DataMember(Name="logCuredTotalMonthlyIncome")]
		public decimal? LogCuredTotalMonthlyIncome { get; set; }

		[DataMember(Name="logDateTimeAssessed")]
		public string LogDateTimeAssessed { get; set; }

		[DataMember(Name="logDateTimeRequested")]
		public string LogDateTimeRequested { get; set; }

		[DataMember(Name="logDebtRatio")]
		public decimal? LogDebtRatio { get; set; }

		[DataMember(Name="logDocumentationLevel")]
		public string LogDocumentationLevel { get; set; }

		[DataMember(Name="logDUCaseIDorLPAUSKey")]
		public string LogDUCaseIDorLPAUSKey { get; set; }

		[DataMember(Name="logDUPropertyType")]
		public string LogDUPropertyType { get; set; }

		[DataMember(Name="logEFolderGUID")]
		public string LogEFolderGUID { get; set; }

		[DataMember(Name="logExcessAvailableAssetsNoVerified")]
		public decimal? LogExcessAvailableAssetsNoVerified { get; set; }

		[DataMember(Name="logFinancedMIAmount")]
		public decimal? LogFinancedMIAmount { get; set; }

		[DataMember(Name="logFirstPandI")]
		public decimal? LogFirstPandI { get; set; }

		[DataMember(Name="logFirstSubmissionDate")]
		public DateTime? LogFirstSubmissionDate { get; set; }

		[DataMember(Name="logFirstSubmissionTime")]
		public string LogFirstSubmissionTime { get; set; }

		[DataMember(Name="logFreddieDocClass")]
		public string LogFreddieDocClass { get; set; }

		[DataMember(Name="logFundsRequiredClose")]
		public decimal? LogFundsRequiredClose { get; set; }

		[DataMember(Name="logGUID")]
		public string LogGUID { get; set; }

		[DataMember(Name="logHLCTV")]
		public decimal? LogHLCTV { get; set; }

		[DataMember(Name="logHousingExpense")]
		public decimal? LogHousingExpense { get; set; }

		[DataMember(Name="logHousingExpenseRatio")]
		public decimal? LogHousingExpenseRatio { get; set; }

		[DataMember(Name="logHousingRatio")]
		public decimal? LogHousingRatio { get; set; }

		[DataMember(Name="logHTLTV")]
		public decimal? LogHTLTV { get; set; }

		[DataMember(Name="logIncludingLess10Mos")]
		public string LogIncludingLess10Mos { get; set; }

		[DataMember(Name="logIncomeAssetBase")]
		public decimal? LogIncomeAssetBase { get; set; }

		[DataMember(Name="logIncomeAssetBonus")]
		public decimal? LogIncomeAssetBonus { get; set; }

		[DataMember(Name="logIncomeAssetCommission")]
		public decimal? LogIncomeAssetCommission { get; set; }

		[DataMember(Name="logIncomeAssetOther")]
		public decimal? LogIncomeAssetOther { get; set; }

		[DataMember(Name="logIncomeAssetOvertime")]
		public decimal? LogIncomeAssetOvertime { get; set; }

		[DataMember(Name="logIncomeAssetPosCashFlow")]
		public decimal? LogIncomeAssetPosCashFlow { get; set; }

		[DataMember(Name="logIncomeAssetPositiveNetRental")]
		public decimal? LogIncomeAssetPositiveNetRental { get; set; }

		[DataMember(Name="logIndicatorScore")]
		public string LogIndicatorScore { get; set; }

		[DataMember(Name="logIntendedUseofProperty")]
		public string LogIntendedUseofProperty { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion1")]
		public string LogLCLAEvaluatedServiceConclusion1 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion2")]
		public string LogLCLAEvaluatedServiceConclusion2 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion3")]
		public string LogLCLAEvaluatedServiceConclusion3 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion4")]
		public string LogLCLAEvaluatedServiceConclusion4 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType1")]
		public string LogLCLAEvaluatedServiceType1 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType2")]
		public string LogLCLAEvaluatedServiceType2 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType3")]
		public string LogLCLAEvaluatedServiceType3 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType4")]
		public string LogLCLAEvaluatedServiceType4 { get; set; }

		[DataMember(Name="logLenderLoan")]
		public string LogLenderLoan { get; set; }

		[DataMember(Name="logLienType")]
		public string LogLienType { get; set; }

		[DataMember(Name="logLoanAmount")]
		public decimal? LogLoanAmount { get; set; }

		[DataMember(Name="logLoanApplicationID")]
		public string LogLoanApplicationID { get; set; }

		[DataMember(Name="logLoanProcessingStage")]
		public string LogLoanProcessingStage { get; set; }

		[DataMember(Name="logLoanProspectorID")]
		public string LogLoanProspectorID { get; set; }

		[DataMember(Name="logLoanPurpose")]
		public string LogLoanPurpose { get; set; }

		[DataMember(Name="logLoanTerm")]
		public int? LogLoanTerm { get; set; }

		[DataMember(Name="logLoanType")]
		public string LogLoanType { get; set; }

		[DataMember(Name="logLPAssmtExpDate")]
		public DateTime? LogLPAssmtExpDate { get; set; }

		[DataMember(Name="logLPPropertyType")]
		public string LogLPPropertyType { get; set; }

		[DataMember(Name="logLPVersion")]
		public string LogLPVersion { get; set; }

		[DataMember(Name="logLQACollateralRepWarrantyServiceConclusion")]
		public string LogLQACollateralRepWarrantyServiceConclusion { get; set; }

		[DataMember(Name="logLQACreditRiskAssessmentConclusion")]
		public string LogLQACreditRiskAssessmentConclusion { get; set; }

		[DataMember(Name="logLQADataCompareFieldConclusion")]
		public string LogLQADataCompareFieldConclusion { get; set; }

		[DataMember(Name="logLQADataCompareFieldName")]
		public string LogLQADataCompareFieldName { get; set; }

		[DataMember(Name="logLQADataCompareResult")]
		public string LogLQADataCompareResult { get; set; }

		[DataMember(Name="logLQALPKey")]
		public string LogLQALPKey { get; set; }

		[DataMember(Name="logLQAPurchaseEligibilityResult")]
		public string LogLQAPurchaseEligibilityResult { get; set; }

		[DataMember(Name="logLQARiskAssessmentKey")]
		public string LogLQARiskAssessmentKey { get; set; }

		[DataMember(Name="logLQASubmissionDateTime")]
		public DateTime? LogLQASubmissionDateTime { get; set; }

		[DataMember(Name="logLTV")]
		public decimal? LogLTV { get; set; }

		[DataMember(Name="logMaxMortgageLimit")]
		public decimal? LogMaxMortgageLimit { get; set; }

		[DataMember(Name="logMIDecision")]
		public string LogMIDecision { get; set; }

		[DataMember(Name="logMortgageType")]
		public string LogMortgageType { get; set; }

		[DataMember(Name="logNegAmortizationType")]
		public string LogNegAmortizationType { get; set; }

		[DataMember(Name="logNegativeNetRental")]
		public decimal? LogNegativeNetRental { get; set; }

		[DataMember(Name="logNetCashBack")]
		public decimal? LogNetCashBack { get; set; }

		[DataMember(Name="logNewConstruction")]
		public string LogNewConstruction { get; set; }

		[DataMember(Name="logNoteRate")]
		public decimal? LogNoteRate { get; set; }

		[DataMember(Name="logNOTPNumber")]
		public string LogNOTPNumber { get; set; }

		[DataMember(Name="logNoUnits")]
		public int? LogNoUnits { get; set; }

		[DataMember(Name="logNumberOfSubmissions")]
		public string LogNumberOfSubmissions { get; set; }

		[DataMember(Name="logOccupancyStatus")]
		public string LogOccupancyStatus { get; set; }

		[DataMember(Name="logOccupantDebtRatio")]
		public decimal? LogOccupantDebtRatio { get; set; }

		[DataMember(Name="logOccupantHousingRatio")]
		public decimal? LogOccupantHousingRatio { get; set; }

		[DataMember(Name="logOfferingIdentifier")]
		public string LogOfferingIdentifier { get; set; }

		[DataMember(Name="logOriginatingCompany")]
		public string LogOriginatingCompany { get; set; }

		[DataMember(Name="logOwnerExistingMtg")]
		public decimal? LogOwnerExistingMtg { get; set; }

		[DataMember(Name="logPandI")]
		public decimal? LogPandI { get; set; }

		[DataMember(Name="logPaymentFrequency")]
		public int? LogPaymentFrequency { get; set; }

		[DataMember(Name="logPresentAddress")]
		public string LogPresentAddress { get; set; }

		[DataMember(Name="logPresentAddressCity")]
		public string LogPresentAddressCity { get; set; }

		[DataMember(Name="logPresentAddressState")]
		public string LogPresentAddressState { get; set; }

		[DataMember(Name="logPresentAddressZipCode")]
		public string LogPresentAddressZipCode { get; set; }

		[DataMember(Name="logPresentHousingExpense")]
		public decimal? LogPresentHousingExpense { get; set; }

		[DataMember(Name="logPresentPrincipalHousingPayment")]
		public decimal? LogPresentPrincipalHousingPayment { get; set; }

		[DataMember(Name="logPropertyAddress")]
		public string LogPropertyAddress { get; set; }

		[DataMember(Name="logPropertyCity")]
		public string LogPropertyCity { get; set; }

		[DataMember(Name="logPropertyState")]
		public string LogPropertyState { get; set; }

		[DataMember(Name="logPropertyZipcode")]
		public string LogPropertyZipcode { get; set; }

		[DataMember(Name="logProposedHazardInsurance")]
		public decimal? LogProposedHazardInsurance { get; set; }

		[DataMember(Name="logProposedHOAFees")]
		public decimal? LogProposedHOAFees { get; set; }

		[DataMember(Name="logProposedHousingPITI")]
		public decimal? LogProposedHousingPITI { get; set; }

		[DataMember(Name="logProposedMortgageInsurance")]
		public decimal? LogProposedMortgageInsurance { get; set; }

		[DataMember(Name="logProposedOtherPayment")]
		public decimal? LogProposedOtherPayment { get; set; }

		[DataMember(Name="logProposedTaxes")]
		public decimal? LogProposedTaxes { get; set; }

		[DataMember(Name="logProposedTotalHousingPayment")]
		public decimal? LogProposedTotalHousingPayment { get; set; }

		[DataMember(Name="logProposedTotalMonthlyDebt")]
		public decimal? LogProposedTotalMonthlyDebt { get; set; }

		[DataMember(Name="logPurchaseEligibility")]
		public string LogPurchaseEligibility { get; set; }

		[DataMember(Name="logQualifyingRate")]
		public decimal? LogQualifyingRate { get; set; }

		[DataMember(Name="logRecordType")]
		public string LogRecordType { get; set; }

		[DataMember(Name="logRefinancePurpose")]
		public string LogRefinancePurpose { get; set; }

		[DataMember(Name="logReserves")]
		public decimal? LogReserves { get; set; }

		[DataMember(Name="logReservesRequiredVerified")]
		public decimal? LogReservesRequiredVerified { get; set; }

		[DataMember(Name="logRiskClass")]
		public string LogRiskClass { get; set; }

		[DataMember(Name="logSalesConcessions")]
		public string LogSalesConcessions { get; set; }

		[DataMember(Name="logSalesPrice")]
		public decimal? LogSalesPrice { get; set; }

		[DataMember(Name="logSecondPandI")]
		public decimal? LogSecondPandI { get; set; }

		[DataMember(Name="logSelectedBorrower")]
		public string LogSelectedBorrower { get; set; }

		[DataMember(Name="logSelectedRepository")]
		public string LogSelectedRepository { get; set; }

		[DataMember(Name="logSellerNumber")]
		public string LogSellerNumber { get; set; }

		[DataMember(Name="logSubjNegCashFlow")]
		public decimal? LogSubjNegCashFlow { get; set; }

		[DataMember(Name="logSubmissionDate")]
		public DateTime? LogSubmissionDate { get; set; }

		[DataMember(Name="logSubmissionNumber")]
		public string LogSubmissionNumber { get; set; }

		[DataMember(Name="logSubmissionTime")]
		public string LogSubmissionTime { get; set; }

		[DataMember(Name="logSubmittedBy")]
		public string LogSubmittedBy { get; set; }

		[DataMember(Name="logSubmittingCompany")]
		public string LogSubmittingCompany { get; set; }

		[DataMember(Name="logTemporarySubsidyBuydown")]
		public string LogTemporarySubsidyBuydown { get; set; }

		[DataMember(Name="logTLTV")]
		public decimal? LogTLTV { get; set; }

		[DataMember(Name="logTotalAsset")]
		public decimal? LogTotalAsset { get; set; }

		[DataMember(Name="logTotalExpense")]
		public decimal? LogTotalExpense { get; set; }

		[DataMember(Name="logTotalExpensePmt")]
		public decimal? LogTotalExpensePmt { get; set; }

		[DataMember(Name="logTotalExpenseRatio")]
		public decimal? LogTotalExpenseRatio { get; set; }

		[DataMember(Name="logTotalFundsVerified")]
		public decimal? LogTotalFundsVerified { get; set; }

		[DataMember(Name="logTotalLoanAmount")]
		public decimal? LogTotalLoanAmount { get; set; }

		[DataMember(Name="logTotalMonthlyIncome")]
		public decimal? LogTotalMonthlyIncome { get; set; }

		[DataMember(Name="logTPONumber")]
		public string LogTPONumber { get; set; }

		[DataMember(Name="logTransactionID")]
		public string LogTransactionID { get; set; }

		[DataMember(Name="logUnderwritingRiskAssessOther")]
		public string LogUnderwritingRiskAssessOther { get; set; }

		[DataMember(Name="logUnderwritingRiskAssessType")]
		public string LogUnderwritingRiskAssessType { get; set; }

		[DataMember(Name="logWithUndisclosedDebt")]
		public string LogWithUndisclosedDebt { get; set; }

		[DataMember(Name = "LogCuredAusAverageMedianCreditScore")]
		public string LogCuredAusAverageMedianCreditScore { get; set; }

		[DataMember(Name = "ausAverageMedianCreditScore")]
		public string LogAusAverageMedianCreditScore { get; set; }
	}
}