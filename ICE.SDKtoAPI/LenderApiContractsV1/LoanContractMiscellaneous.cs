using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMiscellaneous
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="allRoles", EmitDefaultValue=false)]
		public string AllRoles { get; set; }

		[DataMember(Name="allUserInfo", EmitDefaultValue=false)]
		public string AllUserInfo { get; set; }

		[DataMember(Name="borrowerDescription1", EmitDefaultValue=false)]
		public string BorrowerDescription1 { get; set; }

		[DataMember(Name="borrowerDescription2", EmitDefaultValue=false)]
		public string BorrowerDescription2 { get; set; }

		[DataMember(Name="borrowerDescription3", EmitDefaultValue=false)]
		public string BorrowerDescription3 { get; set; }

		[DataMember(Name="borrowerDescription4", EmitDefaultValue=false)]
		public string BorrowerDescription4 { get; set; }

		[DataMember(Name="borrowerDescription5", EmitDefaultValue=false)]
		public string BorrowerDescription5 { get; set; }

		[DataMember(Name="borrowerDescription6", EmitDefaultValue=false)]
		public string BorrowerDescription6 { get; set; }

		[DataMember(Name="borrowerDescription7", EmitDefaultValue=false)]
		public string BorrowerDescription7 { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="closingCostProgramFile", EmitDefaultValue=false)]
		public string ClosingCostProgramFile { get; set; }

		[DataMember(Name="closingTaxYear", EmitDefaultValue=false)]
		public string ClosingTaxYear { get; set; }

		[DataMember(Name="closingTaxYearInterestReceived", EmitDefaultValue=false)]
		public double? ClosingTaxYearInterestReceived { get; set; }

		[DataMember(Name="complianceVersionCD3X1505", EmitDefaultValue=false)]
		public string ComplianceVersionCD3X1505 { get; set; }

		[DataMember(Name="contactFax", EmitDefaultValue=false)]
		public string ContactFax { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="contactPhone", EmitDefaultValue=false)]
		public string ContactPhone { get; set; }

		[DataMember(Name="contactTitle", EmitDefaultValue=false)]
		public string ContactTitle { get; set; }

		[DataMember(Name="copyFromSubjectProperty", EmitDefaultValue=false)]
		public bool? CopyFromSubjectProperty { get; set; }

		[DataMember(Name="dataTracLoanId", EmitDefaultValue=false)]
		public string DataTracLoanId { get; set; }

		[DataMember(Name="docSetFile", EmitDefaultValue=false)]
		public string DocSetFile { get; set; }

		[DataMember(Name="factorForRevolvingDebt", EmitDefaultValue=false)]
		public int? FactorForRevolvingDebt { get; set; }

		[DataMember(Name="fannieDuAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? FannieDuAutoOrderIndicator { get; set; }

		[DataMember(Name="fannieEcAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? FannieEcAutoOrderIndicator { get; set; }

		[DataMember(Name="floodInsuranceExcluded", EmitDefaultValue=false)]
		public string FloodInsuranceExcluded { get; set; }

		[DataMember(Name="formListFile", EmitDefaultValue=false)]
		public string FormListFile { get; set; }

		[DataMember(Name="freddieLPAAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? FreddieLPAAutoOrderIndicator { get; set; }

		[DataMember(Name="freddieLQAAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? FreddieLQAAutoOrderIndicator { get; set; }

		[DataMember(Name="housingExpenseIntRate1", EmitDefaultValue=false)]
		public double? HousingExpenseIntRate1 { get; set; }

		[DataMember(Name="housingExpenseIntRate2", EmitDefaultValue=false)]
		public double? HousingExpenseIntRate2 { get; set; }

		[DataMember(Name="housingExpenseLoanAmt1", EmitDefaultValue=false)]
		public double? HousingExpenseLoanAmt1 { get; set; }

		[DataMember(Name="housingExpenseLoanAmt2", EmitDefaultValue=false)]
		public double? HousingExpenseLoanAmt2 { get; set; }

		[DataMember(Name="housingExpensePayment1", EmitDefaultValue=false)]
		public double? HousingExpensePayment1 { get; set; }

		[DataMember(Name="housingExpensePayment2", EmitDefaultValue=false)]
		public double? HousingExpensePayment2 { get; set; }

		[DataMember(Name="housingExpenseTerm1", EmitDefaultValue=false)]
		public int? HousingExpenseTerm1 { get; set; }

		[DataMember(Name="housingExpenseTerm2", EmitDefaultValue=false)]
		public int? HousingExpenseTerm2 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isSameAddresswithPayer", EmitDefaultValue=false)]
		public bool? IsSameAddresswithPayer { get; set; }

		[DataMember(Name="lastFeeImportDate", EmitDefaultValue=false)]
		public DateTime? LastFeeImportDate { get; set; }

		[DataMember(Name="lenderFeeQuoteID", EmitDefaultValue=false)]
		public string LenderFeeQuoteID { get; set; }

		[DataMember(Name="line1006Excluded", EmitDefaultValue=false)]
		public string Line1006Excluded { get; set; }

		[DataMember(Name="line1007Excluded", EmitDefaultValue=false)]
		public string Line1007Excluded { get; set; }

		[DataMember(Name="line1008Excluded", EmitDefaultValue=false)]
		public string Line1008Excluded { get; set; }

		[DataMember(Name="line1010Excluded", EmitDefaultValue=false)]
		public string Line1010Excluded { get; set; }

		[DataMember(Name="loanFileSequenceNumber", EmitDefaultValue=false)]
		public int? LoanFileSequenceNumber { get; set; }

		[DataMember(Name="loanProgramFile", EmitDefaultValue=false)]
		public string LoanProgramFile { get; set; }

		[DataMember(Name="loanTemplateFile", EmitDefaultValue=false)]
		public string LoanTemplateFile { get; set; }

		[DataMember(Name="maventATRQMResult", EmitDefaultValue=false)]
		public string MaventATRQMResult { get; set; }

		[DataMember(Name="maventAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? MaventAutoOrderIndicator { get; set; }

		[DataMember(Name="maventCraxResult", EmitDefaultValue=false)]
		public string MaventCraxResult { get; set; }

		[DataMember(Name="maventEnterpriseResult", EmitDefaultValue=false)]
		public string MaventEnterpriseResult { get; set; }

		[DataMember(Name="maventGseResult", EmitDefaultValue=false)]
		public string MaventGseResult { get; set; }

		[DataMember(Name="maventHighCostResult", EmitDefaultValue=false)]
		public string MaventHighCostResult { get; set; }

		[DataMember(Name="maventHmdaResult", EmitDefaultValue=false)]
		public string MaventHmdaResult { get; set; }

		[DataMember(Name="maventHpmlResult", EmitDefaultValue=false)]
		public string MaventHpmlResult { get; set; }

		[DataMember(Name="maventLicenseResult", EmitDefaultValue=false)]
		public string MaventLicenseResult { get; set; }

		[DataMember(Name="maventNmlsResult", EmitDefaultValue=false)]
		public string MaventNmlsResult { get; set; }

		[DataMember(Name="maventOfacResult", EmitDefaultValue=false)]
		public string MaventOfacResult { get; set; }

		[DataMember(Name="maventOrderedBy", EmitDefaultValue=false)]
		public string MaventOrderedBy { get; set; }

		[DataMember(Name="maventOrderedDate", EmitDefaultValue=false)]
		public DateTime? MaventOrderedDate { get; set; }

		[DataMember(Name="maventOtherResult", EmitDefaultValue=false)]
		public string MaventOtherResult { get; set; }

		[DataMember(Name="maventReviewResult", EmitDefaultValue=false)]
		public string MaventReviewResult { get; set; }

		[DataMember(Name="maventStateResult", EmitDefaultValue=false)]
		public string MaventStateResult { get; set; }

		[DataMember(Name="maventTilaRorResult", EmitDefaultValue=false)]
		public string MaventTilaRorResult { get; set; }

		[DataMember(Name="maventTilaToleranceResult", EmitDefaultValue=false)]
		public string MaventTilaToleranceResult { get; set; }

		[DataMember(Name="mIPremiums", EmitDefaultValue=false)]
		public double? MIPremiums { get; set; }

		[DataMember(Name="miscDataFile", EmitDefaultValue=false)]
		public string MiscDataFile { get; set; }

		[DataMember(Name="monthsToExclude", EmitDefaultValue=false)]
		public int? MonthsToExclude { get; set; }

		[DataMember(Name="optimalBlueHistoryData", EmitDefaultValue=false)]
		public string OptimalBlueHistoryData { get; set; }

		[DataMember(Name="optimalBlueRequest", EmitDefaultValue=false)]
		public string OptimalBlueRequest { get; set; }

		[DataMember(Name="optimalBlueResponse", EmitDefaultValue=false)]
		public string OptimalBlueResponse { get; set; }

		[DataMember(Name="otherPresentHousingExpense", EmitDefaultValue=false)]
		public double? OtherPresentHousingExpense { get; set; }

		[DataMember(Name="outstandingMtgPrincipal", EmitDefaultValue=false)]
		public double? OutstandingMtgPrincipal { get; set; }

		[DataMember(Name="outstandingMtgPrincipalDate", EmitDefaultValue=false)]
		public DateTime? OutstandingMtgPrincipalDate { get; set; }

		[DataMember(Name="participateHomePoints", EmitDefaultValue=false)]
		public bool? ParticipateHomePoints { get; set; }

		[DataMember(Name="partnerEmail", EmitDefaultValue=false)]
		public string PartnerEmail { get; set; }

		[DataMember(Name="partnerFeeQuoteID", EmitDefaultValue=false)]
		public string PartnerFeeQuoteID { get; set; }

		[DataMember(Name="partnerName", EmitDefaultValue=false)]
		public string PartnerName { get; set; }

		[DataMember(Name="partnerPhone", EmitDefaultValue=false)]
		public string PartnerPhone { get; set; }

		[DataMember(Name="pointsPaid", EmitDefaultValue=false)]
		public double? PointsPaid { get; set; }

		[DataMember(Name="printStateLicenseOn1003", EmitDefaultValue=false)]
		public bool? PrintStateLicenseOn1003 { get; set; }

		[DataMember(Name="rateRegistrationExpirationDate", EmitDefaultValue=false)]
		public DateTime? RateRegistrationExpirationDate { get; set; }

		[DataMember(Name="rateRegistrationInvestorName", EmitDefaultValue=false)]
		public string RateRegistrationInvestorName { get; set; }

		[DataMember(Name="rateRegistrationLoanIsRegistered", EmitDefaultValue=false)]
		public bool? RateRegistrationLoanIsRegistered { get; set; }

		[DataMember(Name="rateRegistrationReference", EmitDefaultValue=false)]
		public string RateRegistrationReference { get; set; }

		[DataMember(Name="rateRegistrationRegisteredBy", EmitDefaultValue=false)]
		public string RateRegistrationRegisteredBy { get; set; }

		[DataMember(Name="rateRegistrationRegisteredUserId", EmitDefaultValue=false)]
		public string RateRegistrationRegisteredUserId { get; set; }

		[DataMember(Name="rateRegistrationRegistrationDate", EmitDefaultValue=false)]
		public DateTime? RateRegistrationRegistrationDate { get; set; }

		[DataMember(Name="refundOrOverpaidInterest", EmitDefaultValue=false)]
		public double? RefundOrOverpaidInterest { get; set; }

		[DataMember(Name="savedLogVersion", EmitDefaultValue=false)]
		public string SavedLogVersion { get; set; }

		[DataMember(Name="schoolTaxExcluded", EmitDefaultValue=false)]
		public string SchoolTaxExcluded { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="statusUrl", EmitDefaultValue=false)]
		public string StatusUrl { get; set; }

		[DataMember(Name="submitDate", EmitDefaultValue=false)]
		public DateTime? SubmitDate { get; set; }

		[DataMember(Name="subTaxYear", EmitDefaultValue=false)]
		public string SubTaxYear { get; set; }

		[DataMember(Name="subTaxYearInterestReceived", EmitDefaultValue=false)]
		public double? SubTaxYearInterestReceived { get; set; }

		[DataMember(Name="subTaxYearMIPremiums", EmitDefaultValue=false)]
		public double? SubTaxYearMIPremiums { get; set; }

		[DataMember(Name="subTaxYearPointsPaid", EmitDefaultValue=false)]
		public double? SubTaxYearPointsPaid { get; set; }

		[DataMember(Name="subTaxYearRefundOrOverpaidInterest", EmitDefaultValue=false)]
		public double? SubTaxYearRefundOrOverpaidInterest { get; set; }

		[DataMember(Name="taxId", EmitDefaultValue=false)]
		public string TaxId { get; set; }

		[DataMember(Name="totalBox4", EmitDefaultValue=false)]
		public double? TotalBox4 { get; set; }

		[DataMember(Name="totalYearlyMi", EmitDefaultValue=false)]
		public double? TotalYearlyMi { get; set; }

		[DataMember(Name="tPOConnectStatusUpdated", EmitDefaultValue=false)]
		public bool? TPOConnectStatusUpdated { get; set; }

		[DataMember(Name="useGfeTax", EmitDefaultValue=false)]
		public string UseGfeTax { get; set; }

		[DataMember(Name="useRegZMi", EmitDefaultValue=false)]
		public string UseRegZMi { get; set; }

		[DataMember(Name="zip", EmitDefaultValue=false)]
		public string Zip { get; set; }

		[DataMember(Name = "newBuydownEnabled", EmitDefaultValue = false)]
		public bool? NewBuydownEnabled { get; set; } = false;

	}
}