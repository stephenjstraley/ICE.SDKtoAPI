using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAUSTrackingLogs
	{
		[DataMember(Name="aUSTrackingLogIndex", EmitDefaultValue=false)]
		public int? AUSTrackingLogIndex { get; set; }

		[DataMember(Name="batchDocumentRefId", EmitDefaultValue=false)]
		public string BatchDocumentRefId { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isEmpty", EmitDefaultValue=false)]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="isHistory", EmitDefaultValue=false)]
		public bool? IsHistory { get; set; }

		[DataMember(Name="logAcceptPlusEligible", EmitDefaultValue=false)]
		public string LogAcceptPlusEligible { get; set; }

		[DataMember(Name="logAffordableProductType", EmitDefaultValue=false)]
		public string LogAffordableProductType { get; set; }

		[DataMember(Name="logAllOtherPayments", EmitDefaultValue=false)]
		public double? LogAllOtherPayments { get; set; }

		[DataMember(Name="logAmortizationMonths", EmitDefaultValue=false)]
		public int? LogAmortizationMonths { get; set; }

		[DataMember(Name="logAmortizationType", EmitDefaultValue=false)]
		public string LogAmortizationType { get; set; }

		[DataMember(Name="logAmtSubordinateFin", EmitDefaultValue=false)]
		public double? LogAmtSubordinateFin { get; set; }

		[DataMember(Name="logAppraisalTypeMAF", EmitDefaultValue=false)]
		public string LogAppraisalTypeMAF { get; set; }

		[DataMember(Name="logAppraisedValue", EmitDefaultValue=false)]
		public int? LogAppraisedValue { get; set; }

		[DataMember(Name="logARMQualifyingRate", EmitDefaultValue=false)]
		public double? LogARMQualifyingRate { get; set; }

		[DataMember(Name="logAssessmentType", EmitDefaultValue=false)]
		public string LogAssessmentType { get; set; }

		[DataMember(Name="logAUSRecommendation", EmitDefaultValue=false)]
		public string LogAUSRecommendation { get; set; }

		[DataMember(Name="logAUSStatus", EmitDefaultValue=false)]
		public string LogAUSStatus { get; set; }

		[DataMember(Name="logAUSTrackingType", EmitDefaultValue=false)]
		public string LogAUSTrackingType { get; set; }

		[DataMember(Name="logAUSTransactionID", EmitDefaultValue=false)]
		public string LogAUSTransactionID { get; set; }

		[DataMember(Name="logAUSVersion", EmitDefaultValue=false)]
		public string LogAUSVersion { get; set; }

		[DataMember(Name="logBalloon", EmitDefaultValue=false)]
		public string LogBalloon { get; set; }

		[DataMember(Name="logBalloonTerm", EmitDefaultValue=false)]
		public int? LogBalloonTerm { get; set; }

		[DataMember(Name="logBorrowerAssetAmount", EmitDefaultValue=false)]
		public double? LogBorrowerAssetAmount { get; set; }

		[DataMember(Name="logBorrowerAssetName", EmitDefaultValue=false)]
		public string LogBorrowerAssetName { get; set; }

		[DataMember(Name="logBorrowerAssetType", EmitDefaultValue=false)]
		public string LogBorrowerAssetType { get; set; }

		[DataMember(Name="logBorrowerCreditScore1", EmitDefaultValue=false)]
		public string LogBorrowerCreditScore1 { get; set; }

		[DataMember(Name="logBorrowerCreditScore2", EmitDefaultValue=false)]
		public string LogBorrowerCreditScore2 { get; set; }

		[DataMember(Name="logBorrowerCreditScore3", EmitDefaultValue=false)]
		public string LogBorrowerCreditScore3 { get; set; }

		[DataMember(Name="logBorrowerEquifaxBEACON", EmitDefaultValue=false)]
		public string LogBorrowerEquifaxBEACON { get; set; }

		[DataMember(Name="logBorrowerExperianFICO", EmitDefaultValue=false)]
		public string LogBorrowerExperianFICO { get; set; }

		[DataMember(Name="logBorrowerIncomeAmount", EmitDefaultValue=false)]
		public double? LogBorrowerIncomeAmount { get; set; }

		[DataMember(Name="logBorrowerIncomeName", EmitDefaultValue=false)]
		public string LogBorrowerIncomeName { get; set; }

		[DataMember(Name="logBorrowerIncomeType", EmitDefaultValue=false)]
		public string LogBorrowerIncomeType { get; set; }

		[DataMember(Name="logBorrowerInstitutionName", EmitDefaultValue=false)]
		public string LogBorrowerInstitutionName { get; set; }

		[DataMember(Name="logBorrowerName", EmitDefaultValue=false)]
		public string LogBorrowerName { get; set; }

		[DataMember(Name="logBorrowerScoreName", EmitDefaultValue=false)]
		public string LogBorrowerScoreName { get; set; }

		[DataMember(Name="logBorrowerTransUnionEmpirica", EmitDefaultValue=false)]
		public string LogBorrowerTransUnionEmpirica { get; set; }

		[DataMember(Name="logBorrowerType1", EmitDefaultValue=false)]
		public string LogBorrowerType1 { get; set; }

		[DataMember(Name="logBorrowerType2", EmitDefaultValue=false)]
		public string LogBorrowerType2 { get; set; }

		[DataMember(Name="logBoughtDownRate", EmitDefaultValue=false)]
		public double? LogBoughtDownRate { get; set; }

		[DataMember(Name="logBuydown", EmitDefaultValue=false)]
		public string LogBuydown { get; set; }

		[DataMember(Name="logCashBack", EmitDefaultValue=false)]
		public double? LogCashBack { get; set; }

		[DataMember(Name="logCashOutAmount", EmitDefaultValue=false)]
		public double? LogCashOutAmount { get; set; }

		[DataMember(Name="logCLTV", EmitDefaultValue=false)]
		public double? LogCLTV { get; set; }

		[DataMember(Name="logCoBorrowerAssetAmount", EmitDefaultValue=false)]
		public double? LogCoBorrowerAssetAmount { get; set; }

		[DataMember(Name="logCoBorrowerAssetName", EmitDefaultValue=false)]
		public string LogCoBorrowerAssetName { get; set; }

		[DataMember(Name="logCoBorrowerAssetType", EmitDefaultValue=false)]
		public string LogCoBorrowerAssetType { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore1", EmitDefaultValue=false)]
		public string LogCoBorrowerCreditScore1 { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore2", EmitDefaultValue=false)]
		public string LogCoBorrowerCreditScore2 { get; set; }

		[DataMember(Name="logCoBorrowerCreditScore3", EmitDefaultValue=false)]
		public string LogCoBorrowerCreditScore3 { get; set; }

		[DataMember(Name="logCoBorrowerEquifaxBEACON", EmitDefaultValue=false)]
		public string LogCoBorrowerEquifaxBEACON { get; set; }

		[DataMember(Name="logCoBorrowerExperianFICO", EmitDefaultValue=false)]
		public string LogCoBorrowerExperianFICO { get; set; }

		[DataMember(Name="logCoBorrowerIncomeAmount", EmitDefaultValue=false)]
		public double? LogCoBorrowerIncomeAmount { get; set; }

		[DataMember(Name="logCoBorrowerIncomeName", EmitDefaultValue=false)]
		public string LogCoBorrowerIncomeName { get; set; }

		[DataMember(Name="logCoBorrowerIncomeType", EmitDefaultValue=false)]
		public string LogCoBorrowerIncomeType { get; set; }

		[DataMember(Name="logCoBorrowerInstitutionName", EmitDefaultValue=false)]
		public string LogCoBorrowerInstitutionName { get; set; }

		[DataMember(Name="logCoborrowerName", EmitDefaultValue=false)]
		public string LogCoborrowerName { get; set; }

		[DataMember(Name="logCoBorrowerScoreName", EmitDefaultValue=false)]
		public string LogCoBorrowerScoreName { get; set; }

		[DataMember(Name="logCoBorrowerTransUnionEmpirica", EmitDefaultValue=false)]
		public string LogCoBorrowerTransUnionEmpirica { get; set; }

		[DataMember(Name="logCode1", EmitDefaultValue=false)]
		public string LogCode1 { get; set; }

		[DataMember(Name="logCode2", EmitDefaultValue=false)]
		public string LogCode2 { get; set; }

		[DataMember(Name="logCodeDescription1", EmitDefaultValue=false)]
		public string LogCodeDescription1 { get; set; }

		[DataMember(Name="logCodeDescription2", EmitDefaultValue=false)]
		public string LogCodeDescription2 { get; set; }

		[DataMember(Name="logCommunityLending", EmitDefaultValue=false)]
		public string LogCommunityLending { get; set; }

		[DataMember(Name="logCreatedOn", EmitDefaultValue=false)]
		public DateTime? LogCreatedOn { get; set; }

		[DataMember(Name="logCreditAgency1", EmitDefaultValue=false)]
		public string LogCreditAgency1 { get; set; }

		[DataMember(Name="logCreditAgency2", EmitDefaultValue=false)]
		public string LogCreditAgency2 { get; set; }

		[DataMember(Name="logCreditReportDate1", EmitDefaultValue=false)]
		public DateTime? LogCreditReportDate1 { get; set; }

		[DataMember(Name="logCreditReportDate2", EmitDefaultValue=false)]
		public DateTime? LogCreditReportDate2 { get; set; }

		[DataMember(Name="logCreditReportID1", EmitDefaultValue=false)]
		public string LogCreditReportID1 { get; set; }

		[DataMember(Name="logCreditReportID2", EmitDefaultValue=false)]
		public string LogCreditReportID2 { get; set; }

		[DataMember(Name="logCuredAmortizationType", EmitDefaultValue=false)]
		public string LogCuredAmortizationType { get; set; }

		[DataMember(Name="logCuredAppraisedValue", EmitDefaultValue=false)]
		public int? LogCuredAppraisedValue { get; set; }

		[DataMember(Name="logCuredCLTV", EmitDefaultValue=false)]
		public double? LogCuredCLTV { get; set; }

		[DataMember(Name="logCuredHousingExpenseRatio", EmitDefaultValue=false)]
		public double? LogCuredHousingExpenseRatio { get; set; }

		[DataMember(Name="logCuredLoanPurpose", EmitDefaultValue=false)]
		public string LogCuredLoanPurpose { get; set; }

		[DataMember(Name="logCuredLoanTerm", EmitDefaultValue=false)]
		public int? LogCuredLoanTerm { get; set; }

		[DataMember(Name="logCuredLoanType", EmitDefaultValue=false)]
		public string LogCuredLoanType { get; set; }

		[DataMember(Name="logCuredLTV", EmitDefaultValue=false)]
		public double? LogCuredLTV { get; set; }

		[DataMember(Name="logCuredNoteRate", EmitDefaultValue=false)]
		public double? LogCuredNoteRate { get; set; }

		[DataMember(Name="logCuredProposedTotalHousingPayment", EmitDefaultValue=false)]
		public double? LogCuredProposedTotalHousingPayment { get; set; }

		[DataMember(Name="logCuredRefinancePurpose", EmitDefaultValue=false)]
		public string LogCuredRefinancePurpose { get; set; }

		[DataMember(Name="logCuredTotalExpenseRatio", EmitDefaultValue=false)]
		public double? LogCuredTotalExpenseRatio { get; set; }

		[DataMember(Name="logCuredTotalLoanAmount", EmitDefaultValue=false)]
		public double? LogCuredTotalLoanAmount { get; set; }

		[DataMember(Name="logCuredTotalMonthlyIncome", EmitDefaultValue=false)]
		public double? LogCuredTotalMonthlyIncome { get; set; }

		[DataMember(Name="logDateTimeAssessed", EmitDefaultValue=false)]
		public string LogDateTimeAssessed { get; set; }

		[DataMember(Name="logDateTimeRequested", EmitDefaultValue=false)]
		public string LogDateTimeRequested { get; set; }

		[DataMember(Name="logDebtRatio", EmitDefaultValue=false)]
		public double? LogDebtRatio { get; set; }

		[DataMember(Name="logDocumentationLevel", EmitDefaultValue=false)]
		public string LogDocumentationLevel { get; set; }

		[DataMember(Name="logDUCaseIDorLPAUSKey", EmitDefaultValue=false)]
		public string LogDUCaseIDorLPAUSKey { get; set; }

		[DataMember(Name="logDUPropertyType", EmitDefaultValue=false)]
		public string LogDUPropertyType { get; set; }

		[DataMember(Name="logEFolderGUID", EmitDefaultValue=false)]
		public string LogEFolderGUID { get; set; }

		[DataMember(Name="logExcessAvailableAssetsNoVerified", EmitDefaultValue=false)]
		public double? LogExcessAvailableAssetsNoVerified { get; set; }

		[DataMember(Name="logFinancedMIAmount", EmitDefaultValue=false)]
		public double? LogFinancedMIAmount { get; set; }

		[DataMember(Name="logFirstPandI", EmitDefaultValue=false)]
		public double? LogFirstPandI { get; set; }

		[DataMember(Name="logFirstSubmissionDate", EmitDefaultValue=false)]
		public DateTime? LogFirstSubmissionDate { get; set; }

		[DataMember(Name="logFirstSubmissionTime", EmitDefaultValue=false)]
		public string LogFirstSubmissionTime { get; set; }

		[DataMember(Name="logFreddieDocClass", EmitDefaultValue=false)]
		public string LogFreddieDocClass { get; set; }

		[DataMember(Name="logFundsRequiredClose", EmitDefaultValue=false)]
		public double? LogFundsRequiredClose { get; set; }

		[DataMember(Name="logGUID", EmitDefaultValue=false)]
		public string LogGUID { get; set; }

		[DataMember(Name="logHLCTV", EmitDefaultValue=false)]
		public double? LogHLCTV { get; set; }

		[DataMember(Name="logHousingExpense", EmitDefaultValue=false)]
		public double? LogHousingExpense { get; set; }

		[DataMember(Name="logHousingExpenseRatio", EmitDefaultValue=false)]
		public double? LogHousingExpenseRatio { get; set; }

		[DataMember(Name="logHousingRatio", EmitDefaultValue=false)]
		public double? LogHousingRatio { get; set; }

		[DataMember(Name="logHTLTV", EmitDefaultValue=false)]
		public double? LogHTLTV { get; set; }

		[DataMember(Name="logIncludingLess10Mos", EmitDefaultValue=false)]
		public string LogIncludingLess10Mos { get; set; }

		[DataMember(Name="logIncomeAssetBase", EmitDefaultValue=false)]
		public double? LogIncomeAssetBase { get; set; }

		[DataMember(Name="logIncomeAssetBonus", EmitDefaultValue=false)]
		public double? LogIncomeAssetBonus { get; set; }

		[DataMember(Name="logIncomeAssetCommission", EmitDefaultValue=false)]
		public double? LogIncomeAssetCommission { get; set; }

		[DataMember(Name="logIncomeAssetOther", EmitDefaultValue=false)]
		public double? LogIncomeAssetOther { get; set; }

		[DataMember(Name="logIncomeAssetOvertime", EmitDefaultValue=false)]
		public double? LogIncomeAssetOvertime { get; set; }

		[DataMember(Name="logIncomeAssetPosCashFlow", EmitDefaultValue=false)]
		public double? LogIncomeAssetPosCashFlow { get; set; }

		[DataMember(Name="logIncomeAssetPositiveNetRental", EmitDefaultValue=false)]
		public double? LogIncomeAssetPositiveNetRental { get; set; }

		[DataMember(Name="logIndicatorScore", EmitDefaultValue=false)]
		public string LogIndicatorScore { get; set; }

		[DataMember(Name="logIntendedUseofProperty", EmitDefaultValue=false)]
		public string LogIntendedUseofProperty { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion1", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceConclusion1 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion2", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceConclusion2 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion3", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceConclusion3 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceConclusion4", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceConclusion4 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType1", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceType1 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType2", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceType2 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType3", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceType3 { get; set; }

		[DataMember(Name="logLCLAEvaluatedServiceType4", EmitDefaultValue=false)]
		public string LogLCLAEvaluatedServiceType4 { get; set; }

		[DataMember(Name="logLenderLoan", EmitDefaultValue=false)]
		public string LogLenderLoan { get; set; }

		[DataMember(Name="logLienType", EmitDefaultValue=false)]
		public string LogLienType { get; set; }

		[DataMember(Name="logLoanAmount", EmitDefaultValue=false)]
		public double? LogLoanAmount { get; set; }

		[DataMember(Name="logLoanApplicationID", EmitDefaultValue=false)]
		public string LogLoanApplicationID { get; set; }

		[DataMember(Name="logLoanProcessingStage", EmitDefaultValue=false)]
		public string LogLoanProcessingStage { get; set; }

		[DataMember(Name="logLoanProspectorID", EmitDefaultValue=false)]
		public string LogLoanProspectorID { get; set; }

		[DataMember(Name="logLoanPurpose", EmitDefaultValue=false)]
		public string LogLoanPurpose { get; set; }

		[DataMember(Name="logLoanTerm", EmitDefaultValue=false)]
		public int? LogLoanTerm { get; set; }

		[DataMember(Name="logLoanType", EmitDefaultValue=false)]
		public string LogLoanType { get; set; }

		[DataMember(Name="logLPAssmtExpDate", EmitDefaultValue=false)]
		public DateTime? LogLPAssmtExpDate { get; set; }

		[DataMember(Name="logLPPropertyType", EmitDefaultValue=false)]
		public string LogLPPropertyType { get; set; }

		[DataMember(Name="logLPVersion", EmitDefaultValue=false)]
		public string LogLPVersion { get; set; }

		[DataMember(Name="logLQACollateralRepWarrantyServiceConclusion", EmitDefaultValue=false)]
		public string LogLQACollateralRepWarrantyServiceConclusion { get; set; }

		[DataMember(Name="logLQACreditRiskAssessmentConclusion", EmitDefaultValue=false)]
		public string LogLQACreditRiskAssessmentConclusion { get; set; }

		[DataMember(Name="logLQADataCompareFieldConclusion", EmitDefaultValue=false)]
		public string LogLQADataCompareFieldConclusion { get; set; }

		[DataMember(Name="logLQADataCompareFieldName", EmitDefaultValue=false)]
		public string LogLQADataCompareFieldName { get; set; }

		[DataMember(Name="logLQADataCompareResult", EmitDefaultValue=false)]
		public string LogLQADataCompareResult { get; set; }

		[DataMember(Name="logLQALPKey", EmitDefaultValue=false)]
		public string LogLQALPKey { get; set; }

		[DataMember(Name="logLQAPurchaseEligibilityResult", EmitDefaultValue=false)]
		public string LogLQAPurchaseEligibilityResult { get; set; }

		[DataMember(Name="logLQARiskAssessmentKey", EmitDefaultValue=false)]
		public string LogLQARiskAssessmentKey { get; set; }

		[DataMember(Name="logLQASubmissionDateTime", EmitDefaultValue=false)]
		public DateTime? LogLQASubmissionDateTime { get; set; }

		[DataMember(Name="logLTV", EmitDefaultValue=false)]
		public double? LogLTV { get; set; }

		[DataMember(Name="logMaxMortgageLimit", EmitDefaultValue=false)]
		public double? LogMaxMortgageLimit { get; set; }

		[DataMember(Name="logMIDecision", EmitDefaultValue=false)]
		public string LogMIDecision { get; set; }

		[DataMember(Name="logMortgageType", EmitDefaultValue=false)]
		public string LogMortgageType { get; set; }

		[DataMember(Name="logNegAmortizationType", EmitDefaultValue=false)]
		public string LogNegAmortizationType { get; set; }

		[DataMember(Name="logNegativeNetRental", EmitDefaultValue=false)]
		public double? LogNegativeNetRental { get; set; }

		[DataMember(Name="logNetCashBack", EmitDefaultValue=false)]
		public double? LogNetCashBack { get; set; }

		[DataMember(Name="logNewConstruction", EmitDefaultValue=false)]
		public string LogNewConstruction { get; set; }

		[DataMember(Name="logNoteRate", EmitDefaultValue=false)]
		public double? LogNoteRate { get; set; }

		[DataMember(Name="logNOTPNumber", EmitDefaultValue=false)]
		public string LogNOTPNumber { get; set; }

		[DataMember(Name="logNoUnits", EmitDefaultValue=false)]
		public int? LogNoUnits { get; set; }

		[DataMember(Name="logNumberOfSubmissions", EmitDefaultValue=false)]
		public string LogNumberOfSubmissions { get; set; }

		[DataMember(Name="logOccupancyStatus", EmitDefaultValue=false)]
		public string LogOccupancyStatus { get; set; }

		[DataMember(Name="logOccupantDebtRatio", EmitDefaultValue=false)]
		public double? LogOccupantDebtRatio { get; set; }

		[DataMember(Name="logOccupantHousingRatio", EmitDefaultValue=false)]
		public double? LogOccupantHousingRatio { get; set; }

		[DataMember(Name="logOfferingIdentifier", EmitDefaultValue=false)]
		public string LogOfferingIdentifier { get; set; }

		[DataMember(Name="logOriginatingCompany", EmitDefaultValue=false)]
		public string LogOriginatingCompany { get; set; }

		[DataMember(Name="logOwnerExistingMtg", EmitDefaultValue=false)]
		public double? LogOwnerExistingMtg { get; set; }

		[DataMember(Name="logPandI", EmitDefaultValue=false)]
		public double? LogPandI { get; set; }

		[DataMember(Name="logPaymentFrequency", EmitDefaultValue=false)]
		public int? LogPaymentFrequency { get; set; }

		[DataMember(Name="logPresentAddress", EmitDefaultValue=false)]
		public string LogPresentAddress { get; set; }

		[DataMember(Name="logPresentAddressCity", EmitDefaultValue=false)]
		public string LogPresentAddressCity { get; set; }

		[DataMember(Name="logPresentAddressState", EmitDefaultValue=false)]
		public string LogPresentAddressState { get; set; }

		[DataMember(Name="logPresentAddressZipCode", EmitDefaultValue=false)]
		public string LogPresentAddressZipCode { get; set; }

		[DataMember(Name="logPresentHousingExpense", EmitDefaultValue=false)]
		public double? LogPresentHousingExpense { get; set; }

		[DataMember(Name="logPresentPrincipalHousingPayment", EmitDefaultValue=false)]
		public double? LogPresentPrincipalHousingPayment { get; set; }

		[DataMember(Name="logPropertyAddress", EmitDefaultValue=false)]
		public string LogPropertyAddress { get; set; }

		[DataMember(Name="logPropertyCity", EmitDefaultValue=false)]
		public string LogPropertyCity { get; set; }

		[DataMember(Name="logPropertyState", EmitDefaultValue=false)]
		public string LogPropertyState { get; set; }

		[DataMember(Name="logPropertyZipcode", EmitDefaultValue=false)]
		public string LogPropertyZipcode { get; set; }

		[DataMember(Name="logProposedHazardInsurance", EmitDefaultValue=false)]
		public double? LogProposedHazardInsurance { get; set; }

		[DataMember(Name="logProposedHOAFees", EmitDefaultValue=false)]
		public double? LogProposedHOAFees { get; set; }

		[DataMember(Name="logProposedHousingPITI", EmitDefaultValue=false)]
		public double? LogProposedHousingPITI { get; set; }

		[DataMember(Name="logProposedMortgageInsurance", EmitDefaultValue=false)]
		public double? LogProposedMortgageInsurance { get; set; }

		[DataMember(Name="logProposedOtherPayment", EmitDefaultValue=false)]
		public double? LogProposedOtherPayment { get; set; }

		[DataMember(Name="logProposedTaxes", EmitDefaultValue=false)]
		public double? LogProposedTaxes { get; set; }

		[DataMember(Name="logProposedTotalHousingPayment", EmitDefaultValue=false)]
		public double? LogProposedTotalHousingPayment { get; set; }

		[DataMember(Name="logProposedTotalMonthlyDebt", EmitDefaultValue=false)]
		public double? LogProposedTotalMonthlyDebt { get; set; }

		[DataMember(Name="logPurchaseEligibility", EmitDefaultValue=false)]
		public string LogPurchaseEligibility { get; set; }

		[DataMember(Name="logQualifyingRate", EmitDefaultValue=false)]
		public double? LogQualifyingRate { get; set; }

		[DataMember(Name="logRecordType", EmitDefaultValue=false)]
		public string LogRecordType { get; set; }

		[DataMember(Name="logRefinancePurpose", EmitDefaultValue=false)]
		public string LogRefinancePurpose { get; set; }

		[DataMember(Name="logReserves", EmitDefaultValue=false)]
		public double? LogReserves { get; set; }

		[DataMember(Name="logReservesRequiredVerified", EmitDefaultValue=false)]
		public double? LogReservesRequiredVerified { get; set; }

		[DataMember(Name="logRiskClass", EmitDefaultValue=false)]
		public string LogRiskClass { get; set; }

		[DataMember(Name="logSalesConcessions", EmitDefaultValue=false)]
		public string LogSalesConcessions { get; set; }

		[DataMember(Name="logSalesPrice", EmitDefaultValue=false)]
		public double? LogSalesPrice { get; set; }

		[DataMember(Name="logSecondPandI", EmitDefaultValue=false)]
		public double? LogSecondPandI { get; set; }

		[DataMember(Name="logSelectedBorrower", EmitDefaultValue=false)]
		public string LogSelectedBorrower { get; set; }

		[DataMember(Name="logSelectedRepository", EmitDefaultValue=false)]
		public string LogSelectedRepository { get; set; }

		[DataMember(Name="logSellerNumber", EmitDefaultValue=false)]
		public string LogSellerNumber { get; set; }

		[DataMember(Name="logSubjNegCashFlow", EmitDefaultValue=false)]
		public double? LogSubjNegCashFlow { get; set; }

		[DataMember(Name="logSubmissionDate", EmitDefaultValue=false)]
		public DateTime? LogSubmissionDate { get; set; }

		[DataMember(Name="logSubmissionNumber", EmitDefaultValue=false)]
		public string LogSubmissionNumber { get; set; }

		[DataMember(Name="logSubmissionTime", EmitDefaultValue=false)]
		public string LogSubmissionTime { get; set; }

		[DataMember(Name="logSubmittedBy", EmitDefaultValue=false)]
		public string LogSubmittedBy { get; set; }

		[DataMember(Name="logSubmittingCompany", EmitDefaultValue=false)]
		public string LogSubmittingCompany { get; set; }

		[DataMember(Name="logTemporarySubsidyBuydown", EmitDefaultValue=false)]
		public string LogTemporarySubsidyBuydown { get; set; }

		[DataMember(Name="logTLTV", EmitDefaultValue=false)]
		public double? LogTLTV { get; set; }

		[DataMember(Name="logTotalAsset", EmitDefaultValue=false)]
		public double? LogTotalAsset { get; set; }

		[DataMember(Name="logTotalExpense", EmitDefaultValue=false)]
		public double? LogTotalExpense { get; set; }

		[DataMember(Name="logTotalExpensePmt", EmitDefaultValue=false)]
		public double? LogTotalExpensePmt { get; set; }

		[DataMember(Name="logTotalExpenseRatio", EmitDefaultValue=false)]
		public double? LogTotalExpenseRatio { get; set; }

		[DataMember(Name="logTotalFundsVerified", EmitDefaultValue=false)]
		public double? LogTotalFundsVerified { get; set; }

		[DataMember(Name="logTotalLoanAmount", EmitDefaultValue=false)]
		public double? LogTotalLoanAmount { get; set; }

		[DataMember(Name="logTotalMonthlyIncome", EmitDefaultValue=false)]
		public double? LogTotalMonthlyIncome { get; set; }

		[DataMember(Name="logTPONumber", EmitDefaultValue=false)]
		public string LogTPONumber { get; set; }

		[DataMember(Name="logTransactionID", EmitDefaultValue=false)]
		public string LogTransactionID { get; set; }

		[DataMember(Name="logUnderwritingRiskAssessOther", EmitDefaultValue=false)]
		public string LogUnderwritingRiskAssessOther { get; set; }

		[DataMember(Name="logUnderwritingRiskAssessType", EmitDefaultValue=false)]
		public string LogUnderwritingRiskAssessType { get; set; }

		[DataMember(Name="logWithUndisclosedDebt", EmitDefaultValue=false)]
		public string LogWithUndisclosedDebt { get; set; }

	}
}