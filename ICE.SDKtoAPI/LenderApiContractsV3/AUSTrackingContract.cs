using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AUSTrackingContract
    {
        [DataMember(Name = "createdOn")]
        public string CreatedOn { get; set; }

        [DataMember(Name = "recordType")]
        public string RecordType { get; set; }

        [DataMember(Name = "underwritingRiskAssessType")]
        public string UnderwritingRiskAssessType { get; set; }

        [DataMember(Name = "underwritingRiskAssessOther")]
        public string UnderwritingRiskAssessOther { get; set; }

        [DataMember(Name = "submissionDate")]
        public string SubmissionDate { get; set; }

        [DataMember(Name = "firstSubmissionDate")]
        public string FirstSubmissionDate { get; set; }

        [DataMember(Name = "submissionNumber")]
        public string SubmissionNumber { get; set; }

        [DataMember(Name = "ausRecommendation")]
        public string AusRecommendation { get; set; }

        [DataMember(Name = "duCaseIdorLpausKey")]
        public string DuCaseIdorLpausKey { get; set; }

        [DataMember(Name = "submittedBy")]
        public string SubmittedBy { get; set; }

        [DataMember(Name = "ausVersion")]
        public string AusVersion { get; set; }

        [DataMember(Name = "freddieDocClass")]
        public string FreddieDocClass { get; set; }

        [DataMember(Name = "ltv")]
        public decimal? Ltv { get; set; }

        [DataMember(Name = "curedLtv")]
        public decimal? CuredLtv { get; set; }

        [DataMember(Name = "cltv")]
        public decimal? Cltv { get; set; }

        [DataMember(Name = "curedCltv")]
        public decimal? CuredCltv { get; set; }

        [DataMember(Name = "hlctv")]
        public decimal? Hlctv { get; set; }

        [DataMember(Name = "housingExpenseRatio")]
        public decimal? HousingExpenseRatio { get; set; }

        [DataMember(Name = "curedHousingExpenseRatio")]
        public decimal? CuredHousingExpenseRatio { get; set; }

        [DataMember(Name = "totalExpenseRatio")]
        public decimal? TotalExpenseRatio { get; set; }

        [DataMember(Name = "curedTotalExpenseRatio")]
        public decimal? CuredTotalExpenseRatio { get; set; }

        [DataMember(Name = "totalLoanAmount")]
        public decimal? TotalLoanAmount { get; set; }

        [DataMember(Name = "curedTotalLoanAmount")]
        public decimal? CuredTotalLoanAmount { get; set; }

        [DataMember(Name = "salesPrice")]
        public decimal? SalesPrice { get; set; }

        [DataMember(Name = "appraisedValue")]
        public int? AppraisedValue { get; set; }

        [DataMember(Name = "curedAppraisedValue")]
        public int? CuredAppraisedValue { get; set; }

        [DataMember(Name = "noteRate")]
        public decimal? NoteRate { get; set; }

        [DataMember(Name = "curedNoteRate")]
        public decimal? CuredNoteRate { get; set; }

        [DataMember(Name = "loanType")]
        public string LoanType { get; set; }

        [DataMember(Name = "curedLoanType")]
        public string CuredLoanType { get; set; }

        [DataMember(Name = "loanTerm")]
        public int? LoanTerm { get; set; }

        [DataMember(Name = "curedLoanTerm")]
        public int? CuredLoanTerm { get; set; }

        [DataMember(Name = "amortizationType")]
        public string AmortizationType { get; set; }

        [DataMember(Name = "curedAmortizationType")]
        public string CuredAmortizationType { get; set; }

        [DataMember(Name = "loanPurpose")]
        public string LoanPurpose { get; set; }

        [DataMember(Name = "curedLoanPurpose")]
        public string CuredLoanPurpose { get; set; }

        [DataMember(Name = "refinancePurpose")]
        public string RefinancePurpose { get; set; }

        [DataMember(Name = "curedRefinancePurpose")]
        public string CuredRefinancePurpose { get; set; }

        [DataMember(Name = "firstPandI")]
        public decimal? FirstPandI { get; set; }

        [DataMember(Name = "secondPandI")]
        public decimal? SecondPandI { get; set; }

        [DataMember(Name = "proposedHazardInsurance")]
        public decimal? ProposedHazardInsurance { get; set; }

        [DataMember(Name = "proposedTaxes")]
        public decimal? ProposedTaxes { get; set; }

        [DataMember(Name = "proposedMortgageInsurance")]
        public decimal? ProposedMortgageInsurance { get; set; }

        [DataMember(Name = "proposedHoaFees")]
        public decimal? ProposedHoaFees { get; set; }

        [DataMember(Name = "proposedOtherPayment")]
        public decimal? ProposedOtherPayment { get; set; }

        [DataMember(Name = "proposedTotalHousingPayment")]
        public decimal? ProposedTotalHousingPayment { get; set; }

        [DataMember(Name = "curedProposedTotalHousingPayment")]
        public decimal? CuredProposedTotalHousingPayment { get; set; }

        [DataMember(Name = "proposedTotalMonthlyDebt")]
        public decimal? ProposedTotalMonthlyDebt { get; set; }

        [DataMember(Name = "incomeAssetBase")]
        public decimal? IncomeAssetBase { get; set; }

        [DataMember(Name = "incomeAssetCommission")]
        public decimal? IncomeAssetCommission { get; set; }

        [DataMember(Name = "incomeAssetBonus")]
        public decimal? IncomeAssetBonus { get; set; }

        [DataMember(Name = "incomeAssetOvertime")]
        public decimal? IncomeAssetOvertime { get; set; }

        [DataMember(Name = "incomeAssetOther")]
        public decimal? IncomeAssetOther { get; set; }

        [DataMember(Name = "incomeAssetPositiveNetRental")]
        public decimal? IncomeAssetPositiveNetRental { get; set; }

        [DataMember(Name = "incomeAssetPosCashFlow")]
        public decimal? IncomeAssetPosCashFlow { get; set; }

        [DataMember(Name = "totalMonthlyIncome")]
        public decimal? TotalMonthlyIncome { get; set; }

        [DataMember(Name = "curedTotalMonthlyIncome")]
        public decimal? CuredTotalMonthlyIncome { get; set; }

        [DataMember(Name = "totalAsset")]
        public decimal? TotalAsset { get; set; }

        [DataMember(Name = "borrowerName")]
        public string BorrowerName { get; set; }

        [DataMember(Name = "lenderLoan")]
        public string LenderLoan { get; set; }

        [DataMember(Name = "coborrowerName")]
        public string CoborrowerName { get; set; }

        [DataMember(Name = "propertyAddress")]
        public string PropertyAddress { get; set; }

        [DataMember(Name = "propertyCity")]
        public string PropertyCity { get; set; }

        [DataMember(Name = "propertyState")]
        public string PropertyState { get; set; }

        [DataMember(Name = "propertyZipcode")]
        public string PropertyZipcode { get; set; }

        [DataMember(Name = "duPropertyType")]
        public string DuPropertyType { get; set; }

        [DataMember(Name = "noUnits")]
        public int? NoUnits { get; set; }

        [DataMember(Name = "occupancyStatus")]
        public string OccupancyStatus { get; set; }

        [DataMember(Name = "balloon")]
        public string Balloon { get; set; }

        [DataMember(Name = "communityLending")]
        public string CommunityLending { get; set; }

        [DataMember(Name = "paymentFrequency")]
        public int? PaymentFrequency { get; set; }

        [DataMember(Name = "lienType")]
        public string LienType { get; set; }

        [DataMember(Name = "amtSubordinateFin")]
        public decimal? AmtSubordinateFin { get; set; }

        [DataMember(Name = "ownerExistingMtg")]
        public decimal? OwnerExistingMtg { get; set; }

        [DataMember(Name = "buydown")]
        public string Buydown { get; set; }

        [DataMember(Name = "loanAmount")]
        public decimal? LoanAmount { get; set; }

        [DataMember(Name = "financedMiAmount")]
        public decimal? FinancedMiAmount { get; set; }

        [DataMember(Name = "pandI")]
        public decimal? PandI { get; set; }

        [DataMember(Name = "qualifyingRate")]
        public decimal? QualifyingRate { get; set; }

        [DataMember(Name = "boughtDownRate")]
        public decimal? BoughtDownRate { get; set; }

        [DataMember(Name = "housingExpense")]
        public decimal? HousingExpense { get; set; }

        [DataMember(Name = "totalExpense")]
        public decimal? TotalExpense { get; set; }

        [DataMember(Name = "includingLess10Mos")]
        public string IncludingLess10Mos { get; set; }

        [DataMember(Name = "withUndisclosedDebt")]
        public string WithUndisclosedDebt { get; set; }

        [DataMember(Name = "negativeNetRental")]
        public decimal? NegativeNetRental { get; set; }

        [DataMember(Name = "subjNegCashFlow")]
        public decimal? SubjNegCashFlow { get; set; }

        [DataMember(Name = "allOtherPayments")]
        public decimal? AllOtherPayments { get; set; }

        [DataMember(Name = "totalExpensePmt")]
        public decimal? TotalExpensePmt { get; set; }

        [DataMember(Name = "presentPrincipalHousingPayment")]
        public decimal? PresentPrincipalHousingPayment { get; set; }

        [DataMember(Name = "fundsRequiredClose")]
        public decimal? FundsRequiredClose { get; set; }

        [DataMember(Name = "reservesRequiredVerified")]
        public decimal? ReservesRequiredVerified { get; set; }

        [DataMember(Name = "totalFundsVerified")]
        public decimal? TotalFundsVerified { get; set; }

        [DataMember(Name = "cashBack")]
        public decimal? CashBack { get; set; }

        [DataMember(Name = "netCashBack")]
        public decimal? NetCashBack { get; set; }

        [DataMember(Name = "excessAvailableAssetsNoVerified")]
        public decimal? ExcessAvailableAssetsNoVerified { get; set; }

        [DataMember(Name = "code1")]
        public string Code1 { get; set; }

        [DataMember(Name = "codeDescription1")]
        public string CodeDescription1 { get; set; }

        [DataMember(Name = "code2")]
        public string Code2 { get; set; }

        [DataMember(Name = "codeDescription2")]
        public string CodeDescription2 { get; set; }

        [DataMember(Name = "borrowerType1")]
        public string BorrowerType1 { get; set; }

        [DataMember(Name = "creditAgency1")]
        public string CreditAgency1 { get; set; }

        [DataMember(Name = "creditReportId1")]
        public string CreditReportId1 { get; set; }

        [DataMember(Name = "creditReportDate1")]
        public string CreditReportDate1 { get; set; }

        [DataMember(Name = "borrowerType2")]
        public string BorrowerType2 { get; set; }

        [DataMember(Name = "creditAgency2")]
        public string CreditAgency2 { get; set; }

        [DataMember(Name = "creditReportId2")]
        public string CreditReportId2 { get; set; }

        [DataMember(Name = "creditReportDate2")]
        public string CreditReportDate2 { get; set; }

        [DataMember(Name = "borrowerScoreName")]
        public string BorrowerScoreName { get; set; }

        [DataMember(Name = "borrowerCreditScore1")]
        public string BorrowerCreditScore1 { get; set; }

        [DataMember(Name = "borrowerCreditScore2")]
        public string BorrowerCreditScore2 { get; set; }

        [DataMember(Name = "borrowerCreditScore3")]
        public string BorrowerCreditScore3 { get; set; }

        [DataMember(Name = "coBorrowerScoreName")]
        public string CoBorrowerScoreName { get; set; }

        [DataMember(Name = "coBorrowerCreditScore1")]
        public string CoBorrowerCreditScore1 { get; set; }

        [DataMember(Name = "coBorrowerCreditScore2")]
        public string CoBorrowerCreditScore2 { get; set; }

        [DataMember(Name = "coBorrowerCreditScore3")]
        public string CoBorrowerCreditScore3 { get; set; }

        [DataMember(Name = "borrowerIncomeName")]
        public string BorrowerIncomeName { get; set; }

        [DataMember(Name = "borrowerIncomeType")]
        public string BorrowerIncomeType { get; set; }

        [DataMember(Name = "borrowerIncomeAmount")]
        public decimal? BorrowerIncomeAmount { get; set; }

        [DataMember(Name = "coBorrowerIncomeName")]
        public string CoBorrowerIncomeName { get; set; }

        [DataMember(Name = "coBorrowerIncomeType")]
        public string CoBorrowerIncomeType { get; set; }

        [DataMember(Name = "coBorrowerIncomeAmount")]
        public decimal? CoBorrowerIncomeAmount { get; set; }

        [DataMember(Name = "borrowerAssetName")]
        public string BorrowerAssetName { get; set; }

        [DataMember(Name = "borrowerAssetType")]
        public string BorrowerAssetType { get; set; }

        [DataMember(Name = "borrowerInstitutionName")]
        public string BorrowerInstitutionName { get; set; }

        [DataMember(Name = "borrowerAssetAmount")]
        public decimal? BorrowerAssetAmount { get; set; }

        [DataMember(Name = "coBorrowerAssetName")]
        public string CoBorrowerAssetName { get; set; }

        [DataMember(Name = "coBorrowerAssetType")]
        public string CoBorrowerAssetType { get; set; }

        [DataMember(Name = "coBorrowerInstitutionName")]
        public string CoBorrowerInstitutionName { get; set; }

        [DataMember(Name = "coBorrowerAssetAmount")]
        public decimal? CoBorrowerAssetAmount { get; set; }

        [DataMember(Name = "ausTransactionId")]
        public string AusTransactionId { get; set; }

        [DataMember(Name = "loanProspectorId")]
        public string LoanProspectorId { get; set; }

        [DataMember(Name = "transactionId")]
        public string TransactionId { get; set; }

        [DataMember(Name = "riskClass")]
        public string RiskClass { get; set; }

        [DataMember(Name = "documentationLevel")]
        public string DocumentationLevel { get; set; }

        [DataMember(Name = "mortgageType")]
        public string MortgageType { get; set; }

        [DataMember(Name = "purchaseEligibility")]
        public string PurchaseEligibility { get; set; }

        [DataMember(Name = "ausStatus")]
        public string AusStatus { get; set; }

        [DataMember(Name = "loanProcessingStage")]
        public string LoanProcessingStage { get; set; }

        [DataMember(Name = "assessmentType")]
        public string AssessmentType { get; set; }

        [DataMember(Name = "lpVersion")]
        public string LpVersion { get; set; }

        [DataMember(Name = "appraisalTypeMaf")]
        public string AppraisalTypeMaf { get; set; }

        [DataMember(Name = "miDecision")]
        public string MiDecision { get; set; }

        [DataMember(Name = "acceptPlusEligible")]
        public string AcceptPlusEligible { get; set; }

        [DataMember(Name = "indicatorScore")]
        public string IndicatorScore { get; set; }

        [DataMember(Name = "selectedRepository")]
        public string SelectedRepository { get; set; }

        [DataMember(Name = "selectedBorrower")]
        public string SelectedBorrower { get; set; }

        [DataMember(Name = "lpAssmtExpDate")]
        public string LpAssmtExpDate { get; set; }

        [DataMember(Name = "borrowerExperianFico")]
        public string BorrowerExperianFico { get; set; }

        [DataMember(Name = "borrowerTransUnionEmpirica")]
        public string BorrowerTransUnionEmpirica { get; set; }

        [DataMember(Name = "borrowerEquifaxBeacon")]
        public string BorrowerEquifaxBeacon { get; set; }

        [DataMember(Name = "coBorrowerExperianFico")]
        public string CoBorrowerExperianFico { get; set; }

        [DataMember(Name = "coBorrowerTransUnionEmpirica")]
        public string CoBorrowerTransUnionEmpirica { get; set; }

        [DataMember(Name = "coBorrowerEquifaxBeacon")]
        public string CoBorrowerEquifaxBeacon { get; set; }

        [DataMember(Name = "presentAddress")]
        public string PresentAddress { get; set; }

        [DataMember(Name = "presentAddressCity")]
        public string PresentAddressCity { get; set; }

        [DataMember(Name = "presentAddressState")]
        public string PresentAddressState { get; set; }

        [DataMember(Name = "presentAddressZipCode")]
        public string PresentAddressZipCode { get; set; }

        [DataMember(Name = "loanApplicationId")]
        public string LoanApplicationId { get; set; }

        [DataMember(Name = "balloonTerm")]
        public int? BalloonTerm { get; set; }

        [DataMember(Name = "amortizationMonths")]
        public int? AmortizationMonths { get; set; }

        [DataMember(Name = "armQualifyingRate")]
        public decimal? ArmQualifyingRate { get; set; }

        [DataMember(Name = "tltv")]
        public decimal? Tltv { get; set; }

        [DataMember(Name = "htltv")]
        public decimal? Htltv { get; set; }

        [DataMember(Name = "housingRatio")]
        public decimal? HousingRatio { get; set; }

        [DataMember(Name = "debtRatio")]
        public decimal? DebtRatio { get; set; }

        [DataMember(Name = "occupantHousingRatio")]
        public decimal? OccupantHousingRatio { get; set; }

        [DataMember(Name = "occupantDebtRatio")]
        public decimal? OccupantDebtRatio { get; set; }

        [DataMember(Name = "negAmortizationType")]
        public string NegAmortizationType { get; set; }

        [DataMember(Name = "temporarySubsidyBuydown")]
        public string TemporarySubsidyBuydown { get; set; }

        [DataMember(Name = "newConstruction")]
        public string NewConstruction { get; set; }

        [DataMember(Name = "affordableProductType")]
        public string AffordableProductType { get; set; }

        [DataMember(Name = "offeringIdentifier")]
        public string OfferingIdentifier { get; set; }

        [DataMember(Name = "intendedUseofProperty")]
        public string IntendedUseofProperty { get; set; }

        [DataMember(Name = "cashOutAmount")]
        public decimal? CashOutAmount { get; set; }

        [DataMember(Name = "reserves")]
        public decimal? Reserves { get; set; }

        [DataMember(Name = "proposedHousingPiti")]
        public decimal? ProposedHousingPiti { get; set; }

        [DataMember(Name = "presentHousingExpense")]
        public decimal? PresentHousingExpense { get; set; }

        [DataMember(Name = "maxMortgageLimit")]
        public decimal? MaxMortgageLimit { get; set; }

        [DataMember(Name = "salesConcessions")]
        public string SalesConcessions { get; set; }

        [DataMember(Name = "originatingCompany")]
        public string OriginatingCompany { get; set; }

        [DataMember(Name = "submittingCompany")]
        public string SubmittingCompany { get; set; }

        [DataMember(Name = "sellerNumber")]
        public string SellerNumber { get; set; }

        [DataMember(Name = "tpoNumber")]
        public string TpoNumber { get; set; }

        [DataMember(Name = "requestedDateTime")]
        public string RequestedDateTime { get; set; }

        [DataMember(Name = "assessedDateTime")]
        public string AssessedDateTime { get; set; }

        [DataMember(Name = "numberOfSubmissions")]
        public string NumberOfSubmissions { get; set; }

        [DataMember(Name = "notpNumber")]
        public string NotpNumber { get; set; }

        [DataMember(Name = "lpPropertyType")]
        public string LpPropertyType { get; set; }

        [DataMember(Name = "submissionTime")]
        public string SubmissionTime { get; set; }

        [DataMember(Name = "firstSubmissionTime")]
        public string FirstSubmissionTime { get; set; }

        [DataMember(Name = "ausTrackingType")]
        public string AusTrackingType { get; set; }

        [DataMember(Name = "eFolderGuid")]
        public string EFolderGuid { get; set; }

        [DataMember(Name = "lqaDataCompareResult")]
        public string LqaDataCompareResult { get; set; }

        [DataMember(Name = "lqalpKey")]
        public string LqalpKey { get; set; }

        [DataMember(Name = "lqaSubmissionDateTime")]
        public string LqaSubmissionDateTime { get; set; }

        [DataMember(Name = "lqaDataCompareFieldName")]
        public string LqaDataCompareFieldName { get; set; }

        [DataMember(Name = "lqaDataCompareFieldConclusion")]
        public string LqaDataCompareFieldConclusion { get; set; }

        [DataMember(Name = "lqaRiskAssessmentKey")]
        public string LqaRiskAssessmentKey { get; set; }

        [DataMember(Name = "lqaCreditRiskAssessmentConclusion")]
        public string LqaCreditRiskAssessmentConclusion { get; set; }

        [DataMember(Name = "lqaPurchaseEligibilityResult")]
        public string LqaPurchaseEligibilityResult { get; set; }

        [DataMember(Name = "lqaCollateralRepWarrantyServiceConclusion")]
        public string LqaCollateralRepWarrantyServiceConclusion { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceType1")]
        public string LclaEvaluatedServiceType1 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceConclusion1")]
        public string LclaEvaluatedServiceConclusion1 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceType2")]
        public string LclaEvaluatedServiceType2 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceConclusion2")]
        public string LclaEvaluatedServiceConclusion2 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceType3")]
        public string LclaEvaluatedServiceType3 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceConclusion3")]
        public string LclaEvaluatedServiceConclusion3 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceType4")]
        public string LclaEvaluatedServiceType4 { get; set; }

        [DataMember(Name = "lclaEvaluatedServiceConclusion4")]
        public string LclaEvaluatedServiceConclusion4 { get; set; }

        [DataMember(Name = "fileType")]
        public string FileType { get; set; }

        [DataMember(Name = "fatalEditInfo")]
        public string FatalEditInfo { get; set; }

        [DataMember(Name = "orderStatus")]
        public string OrderStatus { get; set; }

        [DataMember(Name = "errorInfo")]
        public string ErrorInfo { get; set; }

        [DataMember(Name = "ausOrderLinkId")]
        public string AusOrderLinkId { get; set; }
    }
}
