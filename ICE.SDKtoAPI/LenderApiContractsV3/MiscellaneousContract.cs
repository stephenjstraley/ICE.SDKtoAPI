using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MiscellaneousContract
    {
        [DataMember(Name = "borrowerDescription1")]
        public string BorrowerDescription1 { get; set; }

        [DataMember(Name = "borrowerDescription2")]
        public string BorrowerDescription2 { get; set; }

        [DataMember(Name = "borrowerDescription3")]
        public string BorrowerDescription3 { get; set; }

        [DataMember(Name = "borrowerDescription4")]
        public string BorrowerDescription4 { get; set; }

        [DataMember(Name = "borrowerDescription5")]
        public string BorrowerDescription5 { get; set; }

        [DataMember(Name = "closingCostProgramFile")]
        public string ClosingCostProgramFile { get; set; }

        [DataMember(Name = "closingTaxYear")]
        public string ClosingTaxYear { get; set; }

        [DataMember(Name = "closingTaxYearInterestReceived")]
        public decimal? ClosingTaxYearInterestReceived { get; set; }

        [DataMember(Name = "complianceVersionCd3X1505")]
        public string ComplianceVersionCd3X1505 { get; set; }

        [DataMember(Name = "dataTracLoanId")]
        public string DataTracLoanId { get; set; }

        [DataMember(Name = "docSetFile")]
        public string DocSetFile { get; set; }

        [DataMember(Name = "factorForRevolvingDebt")]
        public int? FactorForRevolvingDebt { get; set; }

        [DataMember(Name = "floodInsuranceExcluded")]
        public string FloodInsuranceExcluded { get; set; }

        [DataMember(Name = "formListFile")]
        public string FormListFile { get; set; }

        [DataMember(Name = "housingExpenseIntRate1")]
        public decimal? HousingExpenseIntRate1 { get; set; }

        [DataMember(Name = "housingExpenseLoanAmt1")]
        public decimal? HousingExpenseLoanAmt1 { get; set; }

        [DataMember(Name = "housingExpensePayment1")]
        public decimal? HousingExpensePayment1 { get; set; }

        [DataMember(Name = "housingExpenseTerm1")]
        public int? HousingExpenseTerm1 { get; set; }

        [DataMember(Name = "housingExpenseIntRate2")]
        public decimal? HousingExpenseIntRate2 { get; set; }

        [DataMember(Name = "housingExpenseLoanAmt2")]
        public decimal? HousingExpenseLoanAmt2 { get; set; }

        [DataMember(Name = "housingExpensePayment2")]
        public decimal? HousingExpensePayment2 { get; set; }

        [DataMember(Name = "housingExpenseTerm2")]
        public int? HousingExpenseTerm2 { get; set; }

        [DataMember(Name = "line1006Excluded")]
        public string Line1006Excluded { get; set; }

        [DataMember(Name = "line1007Excluded")]
        public string Line1007Excluded { get; set; }

        [DataMember(Name = "line1008Excluded")]
        public string Line1008Excluded { get; set; }

        [DataMember(Name = "line1010Excluded")]
        public string Line1010Excluded { get; set; }

        [DataMember(Name = "loanProgramFile")]
        public string LoanProgramFile { get; set; }

        [DataMember(Name = "loanTemplateFile")]
        public string LoanTemplateFile { get; set; }

        [DataMember(Name = "maventAutoOrderIndicator")]
        public bool? MaventAutoOrderIndicator { get; set; }

        [DataMember(Name = "maventCraxResult")]
        public string MaventCraxResult { get; set; }

        [DataMember(Name = "maventEnterpriseResult")]
        public string MaventEnterpriseResult { get; set; }

        [DataMember(Name = "maventGseResult")]
        public string MaventGseResult { get; set; }

        [DataMember(Name = "maventHighCostResult")]
        public string MaventHighCostResult { get; set; }

        [DataMember(Name = "maventHmdaResult")]
        public string MaventHmdaResult { get; set; }

        [DataMember(Name = "useOldBuydownUiAndLogic")]
        public bool? UseOldBuydownUiAndLogic { get; set; }

        [DataMember(Name = "maventHpmlResult")]
        public string MaventHpmlResult { get; set; }

        [DataMember(Name = "maventLicenseResult")]
        public string MaventLicenseResult { get; set; }

        [DataMember(Name = "maventNmlsResult")]
        public string MaventNmlsResult { get; set; }

        [DataMember(Name = "maventOfacResult")]
        public string MaventOfacResult { get; set; }

        [DataMember(Name = "maventOrderedBy")]
        public string MaventOrderedBy { get; set; }

        [DataMember(Name = "maventOrderedDate")]
        public string MaventOrderedDate { get; set; }

        [DataMember(Name = "maventOtherResult")]
        public string MaventOtherResult { get; set; }

        [DataMember(Name = "maventReviewResult")]
        public string MaventReviewResult { get; set; }

        [DataMember(Name = "maventStateResult")]
        public string MaventStateResult { get; set; }

        [DataMember(Name = "maventTilaRorResult")]
        public string MaventTilaRorResult { get; set; }

        [DataMember(Name = "maventTilaToleranceResult")]
        public string MaventTilaToleranceResult { get; set; }

        [DataMember(Name = "miscDataFile")]
        public string MiscDataFile { get; set; }

        [DataMember(Name = "monthsToExclude")]
        public int? MonthsToExclude { get; set; }

        [DataMember(Name = "newBuyDownEnabled")]
        public bool? NewBuyDownEnabled { get; set; }

        [DataMember(Name = "optimalBlueHistoryData")]
        public string OptimalBlueHistoryData { get; set; }

        [DataMember(Name = "optimalBlueRequest")]
        public string OptimalBlueRequest { get; set; }

        [DataMember(Name = "optimalBlueResponse")]
        public string OptimalBlueResponse { get; set; }

        [DataMember(Name = "otherPresentHousingExpense")]
        public decimal? OtherPresentHousingExpense { get; set; }

        [DataMember(Name = "participateHomePoints")]
        public bool? ParticipateHomePoints { get; set; }

        [DataMember(Name = "partnerEmail")]
        public string PartnerEmail { get; set; }

        [DataMember(Name = "partnerName")]
        public string PartnerName { get; set; }

        [DataMember(Name = "partnerPhone")]
        public string PartnerPhone { get; set; }

        [DataMember(Name = "pointsPaid")]
        public decimal? PointsPaid { get; set; }

        [DataMember(Name = "rateRegistrationExpirationDate")]
        public string RateRegistrationExpirationDate { get; set; }

        [DataMember(Name = "rateRegistrationInvestorName")]
        public string RateRegistrationInvestorName { get; set; }

        [DataMember(Name = "rateRegistrationLoanIsRegistered")]
        public bool? RateRegistrationLoanIsRegistered { get; set; }

        [DataMember(Name = "rateRegistrationReference")]
        public string RateRegistrationReference { get; set; }

        [DataMember(Name = "rateRegistrationRegisteredBy")]
        public string RateRegistrationRegisteredBy { get; set; }

        [DataMember(Name = "rateRegistrationRegisteredUserId")]
        public string RateRegistrationRegisteredUserId { get; set; }

        [DataMember(Name = "rateRegistrationRegistrationDate")]
        public string RateRegistrationRegistrationDate { get; set; }

        [DataMember(Name = "refundOrOverpaidInterest")]
        public decimal? RefundOrOverpaidInterest { get; set; }

        [DataMember(Name = "schoolTaxExcluded")]
        public string SchoolTaxExcluded { get; set; }

        [DataMember(Name = "statusUrl")]
        public string StatusUrl { get; set; }

        [DataMember(Name = "submitDate")]
        public string SubmitDate { get; set; }

        [DataMember(Name = "subTaxYear")]
        public string SubTaxYear { get; set; }

        [DataMember(Name = "subTaxYearInterestReceived")]
        public decimal? SubTaxYearInterestReceived { get; set; }

        [DataMember(Name = "subTaxYearPointsPaid")]
        public decimal? SubTaxYearPointsPaid { get; set; }

        [DataMember(Name = "subTaxYearRefundOrOverpaidInterest")]
        public decimal? SubTaxYearRefundOrOverpaidInterest { get; set; }

        [DataMember(Name = "taxId")]
        public string TaxId { get; set; }

        [DataMember(Name = "totalBox4")]
        public decimal? TotalBox4 { get; set; }

        [DataMember(Name = "totalYearlyMi")]
        public decimal? TotalYearlyMi { get; set; }

        [DataMember(Name = "useGfeTax")]
        public string UseGfeTax { get; set; }

        [DataMember(Name = "useRegZMi")]
        public string UseRegZMi { get; set; }

        [DataMember(Name = "fannieDuAutoOrderIndicator")]
        public bool? FannieDuAutoOrderIndicator { get; set; }

        [DataMember(Name = "fannieEcAutoOrderIndicator")]
        public bool? FannieEcAutoOrderIndicator { get; set; }

        [DataMember(Name = "outstandingMtgPrincipal")]
        public decimal? OutstandingMtgPrincipal { get; set; }

        [DataMember(Name = "outstandingMtgPrincipalDate")]
        public string OutstandingMtgPrincipalDate { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "borrowerDescription6")]
        public string BorrowerDescription6 { get; set; }

        [DataMember(Name = "borrowerDescription7")]
        public string BorrowerDescription7 { get; set; }

        [DataMember(Name = "isSameAddresswithPayer")]
        public bool? IsSameAddresswithPayer { get; set; }

        [DataMember(Name = "copyFromSubjectProperty")]
        public bool? CopyFromSubjectProperty { get; set; }

        [DataMember(Name = "freddieLpaAutoOrderIndicator")]
        public bool? FreddieLpaAutoOrderIndicator { get; set; }

        [DataMember(Name = "freddieLqaAutoOrderIndicator")]
        public bool? FreddieLqaAutoOrderIndicator { get; set; }

        [DataMember(Name = "contactTitle")]
        public string ContactTitle { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "contactFax")]
        public string ContactFax { get; set; }

        [DataMember(Name = "contactPhone")]
        public string ContactPhone { get; set; }

        [DataMember(Name = "maventAtrqmResult")]
        public string MaventAtrqmResult { get; set; }

        [DataMember(Name = "miPremiums")]
        public decimal? MiPremiums { get; set; }

        [DataMember(Name = "subTaxYearMiPremiums")]
        public decimal? SubTaxYearMiPremiums { get; set; }

        [DataMember(Name = "printStateLicenseOn1003")]
        public bool? PrintStateLicenseOn1003 { get; set; }

        [DataMember(Name = "loanFileSequenceNumber")]
        public int? LoanFileSequenceNumber { get; set; }

        [DataMember(Name = "tpoConnectStatusUpdated")]
        public bool? TpoConnectStatusUpdated { get; set; }

        [DataMember(Name = "savedLogVersion")]
        public string SavedLogVersion { get; set; }

        [DataMember(Name = "allRoles")]
        public string AllRoles { get; set; }

        [DataMember(Name = "allUserInfo")]
        public string AllUserInfo { get; set; }

        [DataMember(Name = "lenderFeeQuoteId")]
        public string LenderFeeQuoteId { get; set; }

        [DataMember(Name = "partnerFeeQuoteId")]
        public string PartnerFeeQuoteId { get; set; }

        [DataMember(Name = "lastFeeImportDate")]
        public string LastFeeImportDate { get; set; }

        [DataMember(Name = "fannieEcUcdpLastSubmissionDateTime")]
        public string FannieEcUcdpLastSubmissionDateTime { get; set; }

        [DataMember(Name = "fannieEcDocumentFileId")]
        public string FannieEcDocumentFileId { get; set; }

        [DataMember(Name = "fannieEcAppraisalValue")]
        public string FannieEcAppraisalValue { get; set; }

        [DataMember(Name = "fannieEcDuUnderwritingRecommendationCode")]
        public string FannieEcDuUnderwritingRecommendationCode { get; set; }

        [DataMember(Name = "fannieEcDuLatestSubmissionDateTime")]
        public string FannieEcDuLatestSubmissionDateTime { get; set; }

        [DataMember(Name = "fannieEcDuLatestSubmissionNumber")]
        public string FannieEcDuLatestSubmissionNumber { get; set; }

        [DataMember(Name = "fannieEcDuCaseFileId")]
        public string FannieEcDuCaseFileId { get; set; }

        [DataMember(Name = "earlyCheckUcdPassFail")]
        public string EarlyCheckUcdPassFail { get; set; }

    }
}
