using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractApplications
	{
		[DataMember(Name="accountNumber1", EmitDefaultValue=false)]
		public string AccountNumber1 { get; set; }

		[DataMember(Name="accountNumber2", EmitDefaultValue=false)]
		public string AccountNumber2 { get; set; }

		[DataMember(Name = "additionalLoans", EmitDefaultValue = false)]
		public List<LoanContractAdditionalLoan> AdditionalLoans { get; set; }

		[DataMember(Name="allOtherPaymentsAmount", EmitDefaultValue=false)]
		public double? AllOtherPaymentsAmount { get; set; }

		[DataMember(Name="applicationId", EmitDefaultValue=false)]
		public string ApplicationId { get; set; }

		[DataMember(Name="applicationIndex", EmitDefaultValue=false)]
		public int? ApplicationIndex { get; set; }

		[DataMember(Name="applicationSignedDate", EmitDefaultValue=false)]
		public DateTime? ApplicationSignedDate { get; set; }

		[DataMember(Name="assets", EmitDefaultValue=false)]
		public List<LoanContractAssets> Assets { get; set; }

		[DataMember(Name="assetsAvailableAmount", EmitDefaultValue=false)]
		public double? AssetsAvailableAmount { get; set; }

		[DataMember(Name="aTRQMBorrower", EmitDefaultValue=false)]
		public LoanContractATRQMBorrower ATRQMBorrower { get; set; }

		[DataMember(Name="aTRQMBorrowers", EmitDefaultValue=false)]
		public List<LoanContractATRQMBorrower> ATRQMBorrowers { get; set; }

		[DataMember(Name="aUSTrackingLogs", EmitDefaultValue=false)]
		public List<LoanContractAUSTrackingLogs> AUSTrackingLogs { get; set; }

		[DataMember(Name="balanceAvailableFamilySupportGuideline", EmitDefaultValue=false)]
		public double? BalanceAvailableFamilySupportGuideline { get; set; }

		[DataMember(Name="borrower", EmitDefaultValue=false)]
		public LoanContractBorrower Borrower { get; set; }

		[DataMember(Name="bottomRatioPercent", EmitDefaultValue=false)]
		public double? BottomRatioPercent { get; set; }

		[DataMember(Name="brwCoBrwTotalTaxDeductions", EmitDefaultValue=false)]
		public double? BrwCoBrwTotalTaxDeductions { get; set; }

		[DataMember(Name="coborrower", EmitDefaultValue=false)]
		public LoanContractBorrower Coborrower { get; set; }

		[DataMember(Name="creditAliasName1", EmitDefaultValue=false)]
		public string CreditAliasName1 { get; set; }

		[DataMember(Name="creditAliasName2", EmitDefaultValue=false)]
		public string CreditAliasName2 { get; set; }

		[DataMember(Name="creditorName1", EmitDefaultValue=false)]
		public string CreditorName1 { get; set; }

		[DataMember(Name="creditorName2", EmitDefaultValue=false)]
		public string CreditorName2 { get; set; }

		[DataMember(Name="creditReportReferenceIdentifier", EmitDefaultValue=false)]
		public string CreditReportReferenceIdentifier { get; set; }

		[DataMember(Name="employment", EmitDefaultValue=false)]
		public List<LoanContractEmployment> Employment { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="equifaxAddress", EmitDefaultValue=false)]
		public string EquifaxAddress { get; set; }

		[DataMember(Name="equifaxCity", EmitDefaultValue=false)]
		public string EquifaxCity { get; set; }

		[DataMember(Name="equifaxFax", EmitDefaultValue=false)]
		public string EquifaxFax { get; set; }

		[DataMember(Name="equifaxModel", EmitDefaultValue=false)]
		public string EquifaxModel { get; set; }

		[DataMember(Name="equifaxName", EmitDefaultValue=false)]
		public string EquifaxName { get; set; }

		[DataMember(Name="equifaxPhone", EmitDefaultValue=false)]
		public string EquifaxPhone { get; set; }

		[DataMember(Name="equifaxPostalCode", EmitDefaultValue=false)]
		public string EquifaxPostalCode { get; set; }

		[DataMember(Name="equifaxScoreRangeFrom", EmitDefaultValue=false)]
		public string EquifaxScoreRangeFrom { get; set; }

		[DataMember(Name="equifaxScoreRangeTo", EmitDefaultValue=false)]
		public string EquifaxScoreRangeTo { get; set; }

		[DataMember(Name="equifaxState", EmitDefaultValue=false)]
		public string EquifaxState { get; set; }

		[DataMember(Name="equifaxWebsite", EmitDefaultValue=false)]
		public string EquifaxWebsite { get; set; }

		[DataMember(Name="experianAddress", EmitDefaultValue=false)]
		public string ExperianAddress { get; set; }

		[DataMember(Name="experianCity", EmitDefaultValue=false)]
		public string ExperianCity { get; set; }

		[DataMember(Name="experianFax", EmitDefaultValue=false)]
		public string ExperianFax { get; set; }

		[DataMember(Name="experianModel", EmitDefaultValue=false)]
		public string ExperianModel { get; set; }

		[DataMember(Name="experianName", EmitDefaultValue=false)]
		public string ExperianName { get; set; }

		[DataMember(Name="experianPhone", EmitDefaultValue=false)]
		public string ExperianPhone { get; set; }

		[DataMember(Name="experianPostalCode", EmitDefaultValue=false)]
		public string ExperianPostalCode { get; set; }

		[DataMember(Name="experianScoreRangeFrom", EmitDefaultValue=false)]
		public string ExperianScoreRangeFrom { get; set; }

		[DataMember(Name="experianScoreRangeTo", EmitDefaultValue=false)]
		public string ExperianScoreRangeTo { get; set; }

		[DataMember(Name="experianState", EmitDefaultValue=false)]
		public string ExperianState { get; set; }

		[DataMember(Name="experianWebsite", EmitDefaultValue=false)]
		public string ExperianWebsite { get; set; }

		[DataMember(Name="fhaVaDebtIncomeRatio", EmitDefaultValue=false)]
		public double? FhaVaDebtIncomeRatio { get; set; }

		[DataMember(Name="fhaVaFamilySupportAmount", EmitDefaultValue=false)]
		public double? FhaVaFamilySupportAmount { get; set; }

		[DataMember(Name="fhaVaTotalEstimatedMonthlyShelterExpenseAmount", EmitDefaultValue=false)]
		public double? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get; set; }

		[DataMember(Name="fhaVaTotalNetEffectiveIncomeAmount", EmitDefaultValue=false)]
		public double? FhaVaTotalNetEffectiveIncomeAmount { get; set; }

		[DataMember(Name="fhaVaTotalNetIncomeAmount", EmitDefaultValue=false)]
		public double? FhaVaTotalNetIncomeAmount { get; set; }

		[DataMember(Name="fhaVaTotalNetTakeHomePayAmount", EmitDefaultValue=false)]
		public double? FhaVaTotalNetTakeHomePayAmount { get; set; }

		[DataMember(Name="fhaVaTotalOtherNetIncome", EmitDefaultValue=false)]
		public double? FhaVaTotalOtherNetIncome { get; set; }

		[DataMember(Name="firstMortgagePrincipalAndInterestAmount", EmitDefaultValue=false)]
		public double? FirstMortgagePrincipalAndInterestAmount { get; set; }

		[DataMember(Name="freddieMacCreditReportReferenceIdentifier", EmitDefaultValue=false)]
		public string FreddieMacCreditReportReferenceIdentifier { get; set; }

		[DataMember(Name="freddieMacOccupantDebtRatio", EmitDefaultValue=false)]
		public double? FreddieMacOccupantDebtRatio { get; set; }

		[DataMember(Name="freddieMacOccupantHousingRatio", EmitDefaultValue=false)]
		public double? FreddieMacOccupantHousingRatio { get; set; }

		[DataMember(Name="freDebtToHousingGapRatio", EmitDefaultValue=false)]
		public double? FreDebtToHousingGapRatio { get; set; }

		[DataMember(Name = "giftsGrants", EmitDefaultValue = false)]
		public List<LoanContractApplicationGiftGrant> GiftsGrants { get; set; }

		[DataMember(Name="grossBaseIncomeAmount", EmitDefaultValue=false)]
		public double? GrossBaseIncomeAmount { get; set; }

		[DataMember(Name="grossIncomeForComortSet", EmitDefaultValue=false)]
		public double? GrossIncomeForComortSet { get; set; }

		[DataMember(Name="grossNegativeCashFlow", EmitDefaultValue=false)]
		public double? GrossNegativeCashFlow { get; set; }

		[DataMember(Name="grossOtherIncomeAmount", EmitDefaultValue=false)]
		public double? GrossOtherIncomeAmount { get; set; }

		[DataMember(Name="grossPositiveCashFlow", EmitDefaultValue=false)]
		public double? GrossPositiveCashFlow { get; set; }

		[DataMember(Name="hazardInsuranceAmount", EmitDefaultValue=false)]
		public string HazardInsuranceAmount { get; set; }

		[DataMember(Name="homeownersAssociationDuesAndCondoFeesAmount", EmitDefaultValue=false)]
		public string HomeownersAssociationDuesAndCondoFeesAmount { get; set; }

		[DataMember(Name="hudAutoLienHolderName1", EmitDefaultValue=false)]
		public string HudAutoLienHolderName1 { get; set; }

		[DataMember(Name="hudAutoLienHolderName2", EmitDefaultValue=false)]
		public string HudAutoLienHolderName2 { get; set; }

		[DataMember(Name="hudAutoLoanAmount1", EmitDefaultValue=false)]
		public double? HudAutoLoanAmount1 { get; set; }

		[DataMember(Name="hudAutoLoanAmount2", EmitDefaultValue=false)]
		public double? HudAutoLoanAmount2 { get; set; }

		[DataMember(Name="hudAutoMonthlyPayment1", EmitDefaultValue=false)]
		public double? HudAutoMonthlyPayment1 { get; set; }

		[DataMember(Name="hudAutoMonthlyPayment2", EmitDefaultValue=false)]
		public double? HudAutoMonthlyPayment2 { get; set; }

		[DataMember(Name="hudAutoPresentBalance1", EmitDefaultValue=false)]
		public double? HudAutoPresentBalance1 { get; set; }

		[DataMember(Name="hudAutoPresentBalance2", EmitDefaultValue=false)]
		public double? HudAutoPresentBalance2 { get; set; }

		[DataMember(Name="hudAutoYearAndMake1", EmitDefaultValue=false)]
		public string HudAutoYearAndMake1 { get; set; }

		[DataMember(Name="hudAutoYearAndMake2", EmitDefaultValue=false)]
		public string HudAutoYearAndMake2 { get; set; }

		[DataMember(Name="hudLoanAmount1", EmitDefaultValue=false)]
		public double? HudLoanAmount1 { get; set; }

		[DataMember(Name="hudLoanAmount10", EmitDefaultValue=false)]
		public double? HudLoanAmount10 { get; set; }

		[DataMember(Name="hudLoanAmount11", EmitDefaultValue=false)]
		public double? HudLoanAmount11 { get; set; }

		[DataMember(Name="hudLoanAmount2", EmitDefaultValue=false)]
		public double? HudLoanAmount2 { get; set; }

		[DataMember(Name="hudLoanAmount3", EmitDefaultValue=false)]
		public double? HudLoanAmount3 { get; set; }

		[DataMember(Name="hudLoanAmount4", EmitDefaultValue=false)]
		public double? HudLoanAmount4 { get; set; }

		[DataMember(Name="hudLoanAmount5", EmitDefaultValue=false)]
		public double? HudLoanAmount5 { get; set; }

		[DataMember(Name="hudLoanAmount6", EmitDefaultValue=false)]
		public double? HudLoanAmount6 { get; set; }

		[DataMember(Name="hudLoanAmount7", EmitDefaultValue=false)]
		public double? HudLoanAmount7 { get; set; }

		[DataMember(Name="hudLoanAmount8", EmitDefaultValue=false)]
		public double? HudLoanAmount8 { get; set; }

		[DataMember(Name="hudLoanAmount9", EmitDefaultValue=false)]
		public double? HudLoanAmount9 { get; set; }

		[DataMember(Name="hudRealEstateFhaInsured1", EmitDefaultValue=false)]
		public bool? HudRealEstateFhaInsured1 { get; set; }

		[DataMember(Name="hudRealEstateFhaInsured2", EmitDefaultValue=false)]
		public bool? HudRealEstateFhaInsured2 { get; set; }

		[DataMember(Name="hudRealEstateLienHolder1", EmitDefaultValue=false)]
		public string HudRealEstateLienHolder1 { get; set; }

		[DataMember(Name="hudRealEstateLienHolder2", EmitDefaultValue=false)]
		public string HudRealEstateLienHolder2 { get; set; }

		[DataMember(Name="hudRealEstateLoanAmount1", EmitDefaultValue=false)]
		public double? HudRealEstateLoanAmount1 { get; set; }

		[DataMember(Name="hudRealEstateLoanAmount2", EmitDefaultValue=false)]
		public double? HudRealEstateLoanAmount2 { get; set; }

		[DataMember(Name="hudRealEstateMonthlyPayment1", EmitDefaultValue=false)]
		public double? HudRealEstateMonthlyPayment1 { get; set; }

		[DataMember(Name="hudRealEstateMonthlyPayment2", EmitDefaultValue=false)]
		public double? HudRealEstateMonthlyPayment2 { get; set; }

		[DataMember(Name="hudRealEstatePresentBalance1", EmitDefaultValue=false)]
		public double? HudRealEstatePresentBalance1 { get; set; }

		[DataMember(Name="hudRealEstatePresentBalance2", EmitDefaultValue=false)]
		public double? HudRealEstatePresentBalance2 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="income", EmitDefaultValue=false)]
		public List<LoanContractIncome> Income { get; set; }

		[DataMember(Name="incomeOfBorrowersSpouseUsedIndicator", EmitDefaultValue=false)]
		public bool? IncomeOfBorrowersSpouseUsedIndicator { get; set; }

		[DataMember(Name="incomeOtherThanBorrowerUsedIndicator", EmitDefaultValue=false)]
		public bool? IncomeOtherThanBorrowerUsedIndicator { get; set; }

		[DataMember(Name="jointAssetLiabilityReportingIndicator", EmitDefaultValue=false)]
		public bool? JointAssetLiabilityReportingIndicator { get; set; }

		[DataMember(Name="lastModified", EmitDefaultValue=false)]
		public string LastModified { get; set; }

		[DataMember(Name="liabilities", EmitDefaultValue=false)]
		public List<LoanContractLiabilities> Liabilities { get; set; }

		[DataMember(Name="liquidAssetsComortSet", EmitDefaultValue=false)]
		public double? LiquidAssetsComortSet { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public string LoanAmount { get; set; }

		[DataMember(Name="loanOfficerId", EmitDefaultValue=false)]
		public string LoanOfficerId { get; set; }

		[DataMember(Name="loanOfficerName", EmitDefaultValue=false)]
		public string LoanOfficerName { get; set; }

		[DataMember(Name="mcawBorrowerOtherMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? McawBorrowerOtherMonthlyIncomeAmount { get; set; }

		[DataMember(Name="mcawCoborrowerOtherMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? McawCoborrowerOtherMonthlyIncomeAmount { get; set; }

		[DataMember(Name="mcawGrossMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? McawGrossMonthlyIncomeAmount { get; set; }

		[DataMember(Name="mcawMortgagePaymentToIncome1Amount", EmitDefaultValue=false)]
		public double? McawMortgagePaymentToIncome1Amount { get; set; }

		[DataMember(Name="mcawMortgagePaymentToIncome2Amount", EmitDefaultValue=false)]
		public double? McawMortgagePaymentToIncome2Amount { get; set; }

		[DataMember(Name="mcawOtherAmount", EmitDefaultValue=false)]
		public double? McawOtherAmount { get; set; }

		[DataMember(Name="mcawOtherDebtsAndObligationsAmount", EmitDefaultValue=false)]
		public double? McawOtherDebtsAndObligationsAmount { get; set; }

		[DataMember(Name="mcawTotalFixedPaymentForPurchaseAmount", EmitDefaultValue=false)]
		public double? McawTotalFixedPaymentForPurchaseAmount { get; set; }

		[DataMember(Name="mcawTotalFixedPaymentForRefinanceAmount", EmitDefaultValue=false)]
		public double? McawTotalFixedPaymentForRefinanceAmount { get; set; }

		[DataMember(Name="mcawTotalFixedPaymentToIncome1Amount", EmitDefaultValue=false)]
		public double? McawTotalFixedPaymentToIncome1Amount { get; set; }

		[DataMember(Name="mcawTotalFixedPaymentToIncome2Amount", EmitDefaultValue=false)]
		public double? McawTotalFixedPaymentToIncome2Amount { get; set; }

		[DataMember(Name="mcawTotalMonthlyPaymentsAmount", EmitDefaultValue=false)]
		public double? McawTotalMonthlyPaymentsAmount { get; set; }

		[DataMember(Name="mcawTotalMortgagePaymentAmount", EmitDefaultValue=false)]
		public double? McawTotalMortgagePaymentAmount { get; set; }

		[DataMember(Name="monthlyExpenseComortSet", EmitDefaultValue=false)]
		public double? MonthlyExpenseComortSet { get; set; }

		[DataMember(Name="monthlyHousingExpenseAmount", EmitDefaultValue=false)]
		public double? MonthlyHousingExpenseAmount { get; set; }

		[DataMember(Name="monthlyInstallmentExpenseAmount", EmitDefaultValue=false)]
		public double? MonthlyInstallmentExpenseAmount { get; set; }

		[DataMember(Name="monthlyNegativeRealEstateAmount", EmitDefaultValue=false)]
		public double? MonthlyNegativeRealEstateAmount { get; set; }

		[DataMember(Name="monthlySecondHomeAmount", EmitDefaultValue=false)]
		public double? MonthlySecondHomeAmount { get; set; }

		[DataMember(Name="mortgageInsuranceAmount", EmitDefaultValue=false)]
		public string MortgageInsuranceAmount { get; set; }

		[DataMember(Name="netWorthAmount", EmitDefaultValue=false)]
		public double? NetWorthAmount { get; set; }

		[DataMember(Name="otherHousingExpenseAmount", EmitDefaultValue=false)]
		public double? OtherHousingExpenseAmount { get; set; }

		[DataMember(Name="otherItemsDeducted", EmitDefaultValue=false)]
		public double? OtherItemsDeducted { get; set; }

		[DataMember(Name="otherMortgagePrincipalAndInterestAmount", EmitDefaultValue=false)]
		public double? OtherMortgagePrincipalAndInterestAmount { get; set; }

		[DataMember(Name="pastCreditRecord", EmitDefaultValue=false)]
		public string PastCreditRecord { get; set; }

		[DataMember(Name="presentHousingExpComortSet", EmitDefaultValue=false)]
		public double? PresentHousingExpComortSet { get; set; }

		[DataMember(Name="primaryResidenceComortSet", EmitDefaultValue=false)]
		public double? PrimaryResidenceComortSet { get; set; }

		[DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="proposedDuesAmount", EmitDefaultValue=false)]
		public string ProposedDuesAmount { get; set; }

		[DataMember(Name="proposedFirstMortgageAmount", EmitDefaultValue=false)]
		public double? ProposedFirstMortgageAmount { get; set; }

		[DataMember(Name="proposedGroundRentAmount", EmitDefaultValue=false)]
		public double? ProposedGroundRentAmount { get; set; }

		[DataMember(Name="proposedHazardInsuranceAmount", EmitDefaultValue=false)]
		public string ProposedHazardInsuranceAmount { get; set; }

		[DataMember(Name="proposedMortgageInsuranceAmount", EmitDefaultValue=false)]
		public string ProposedMortgageInsuranceAmount { get; set; }

		[DataMember(Name="proposedOtherAmount", EmitDefaultValue=false)]
		public double? ProposedOtherAmount { get; set; }

		[DataMember(Name="proposedOtherMortgagesAmount", EmitDefaultValue=false)]
		public double? ProposedOtherMortgagesAmount { get; set; }

		[DataMember(Name="proposedRealEstateTaxesAmount", EmitDefaultValue=false)]
		public string ProposedRealEstateTaxesAmount { get; set; }

		[DataMember(Name="realEstateTaxAmount", EmitDefaultValue=false)]
		public string RealEstateTaxAmount { get; set; }

		[DataMember(Name="rentAmount", EmitDefaultValue=false)]
		public double? RentAmount { get; set; }

		[DataMember(Name="reoProperties", EmitDefaultValue=false)]
		public List<LoanContractReoProperties> ReoProperties { get; set; }

		[DataMember(Name="reoTotalGrossRentalIncomeAmount", EmitDefaultValue=false)]
		public double? ReoTotalGrossRentalIncomeAmount { get; set; }

		[DataMember(Name="reoTotalMaintenanceAmount", EmitDefaultValue=false)]
		public double? ReoTotalMaintenanceAmount { get; set; }

		[DataMember(Name="reoTotalMarketValueAmount", EmitDefaultValue=false)]
		public double? ReoTotalMarketValueAmount { get; set; }

		[DataMember(Name="reoTotalMortgagePaymentsAmount", EmitDefaultValue=false)]
		public double? ReoTotalMortgagePaymentsAmount { get; set; }

		[DataMember(Name="reoTotalMortgagesAndLiensAmount", EmitDefaultValue=false)]
		public double? ReoTotalMortgagesAndLiensAmount { get; set; }

		[DataMember(Name="reoTotalNetRentalIncomeAmount", EmitDefaultValue=false)]
		public int? ReoTotalNetRentalIncomeAmount { get; set; }

		[DataMember(Name="residences", EmitDefaultValue=false)]
		public List<LoanContractResidences> Residences { get; set; }

		[DataMember(Name="respa6", EmitDefaultValue=false)]
		public string Respa6 { get; set; }

		[DataMember(Name="selfEmployedIncomes", EmitDefaultValue=false)]
		public List<LoanContractSelfEmployedIncomes> SelfEmployedIncomes { get; set; }

		[DataMember(Name="sofDBorrowerAddress", EmitDefaultValue=false)]
		public string SofDBorrowerAddress { get; set; }

		[DataMember(Name="sofDBorrowerAddressCity", EmitDefaultValue=false)]
		public string SofDBorrowerAddressCity { get; set; }

		[DataMember(Name="sofDBorrowerAddressState", EmitDefaultValue=false)]
		public string SofDBorrowerAddressState { get; set; }

		[DataMember(Name="sofDBorrowerAddressType", EmitDefaultValue=false)]
		public string SofDBorrowerAddressType { get; set; }

		[DataMember(Name="sofDBorrowerAddressZipcode", EmitDefaultValue=false)]
		public string SofDBorrowerAddressZipcode { get; set; }

		[DataMember(Name="sofDCoBorrowerAddress", EmitDefaultValue=false)]
		public string SofDCoBorrowerAddress { get; set; }

		[DataMember(Name="sofDCoBorrowerAddressCity", EmitDefaultValue=false)]
		public string SofDCoBorrowerAddressCity { get; set; }

		[DataMember(Name="sofDCoBorrowerAddressState", EmitDefaultValue=false)]
		public string SofDCoBorrowerAddressState { get; set; }

		[DataMember(Name="sofDCoBorrowerAddressType", EmitDefaultValue=false)]
		public string SofDCoBorrowerAddressType { get; set; }

		[DataMember(Name="sofDCoBorrowerAddressZipcode", EmitDefaultValue=false)]
		public string SofDCoBorrowerAddressZipcode { get; set; }

		[DataMember(Name="spouseIncomeConsider", EmitDefaultValue=false)]
		public bool? SpouseIncomeConsider { get; set; }

		[DataMember(Name="tax4506s", EmitDefaultValue=false)]
		public List<LoanContractTax4506s> Tax4506s { get; set; }

		[DataMember(Name="topRatioPercent", EmitDefaultValue=false)]
		public double? TopRatioPercent { get; set; }

		[DataMember(Name="totalAssetsAmount", EmitDefaultValue=false)]
		public double? TotalAssetsAmount { get; set; }

		[DataMember(Name="totalBaseIncomeAmount", EmitDefaultValue=false)]
		public double? TotalBaseIncomeAmount { get; set; }

		[DataMember(Name="totalBonusAmount", EmitDefaultValue=false)]
		public double? TotalBonusAmount { get; set; }

		[DataMember(Name="totalCommissionsAmount", EmitDefaultValue=false)]
		public double? TotalCommissionsAmount { get; set; }

		[DataMember(Name="totalDeposit", EmitDefaultValue=false)]
		public double? TotalDeposit { get; set; }

		[DataMember(Name="totalDividendsInterestAmount", EmitDefaultValue=false)]
		public double? TotalDividendsInterestAmount { get; set; }

		[DataMember(Name="totalEmploymentAmount", EmitDefaultValue=false)]
		public double? TotalEmploymentAmount { get; set; }

		[DataMember(Name="totalFixedPaymentAmount", EmitDefaultValue=false)]
		public double? TotalFixedPaymentAmount { get; set; }

		[DataMember(Name="totalGrossMonthlyIncomeAmount", EmitDefaultValue=false)]
		public double? TotalGrossMonthlyIncomeAmount { get; set; }

		[DataMember(Name="totalIncomeAmount", EmitDefaultValue=false)]
		public double? TotalIncomeAmount { get; set; }

		[DataMember(Name="totalMonthlyPaymentAmount", EmitDefaultValue=false)]
		public double? TotalMonthlyPaymentAmount { get; set; }

		[DataMember(Name="totalMortgagesBalanceAmount", EmitDefaultValue=false)]
		public double? TotalMortgagesBalanceAmount { get; set; }

		[DataMember(Name="totalMortgagesMonthlyPaymentAmount", EmitDefaultValue=false)]
		public double? TotalMortgagesMonthlyPaymentAmount { get; set; }

		[DataMember(Name="totalNetRentalIncomeAmount", EmitDefaultValue=false)]
		public double? TotalNetRentalIncomeAmount { get; set; }

		[DataMember(Name="totalOther1Amount", EmitDefaultValue=false)]
		public double? TotalOther1Amount { get; set; }

		[DataMember(Name="totalOther2Amount", EmitDefaultValue=false)]
		public double? TotalOther2Amount { get; set; }

		[DataMember(Name="totalOvertimeAmount", EmitDefaultValue=false)]
		public double? TotalOvertimeAmount { get; set; }

		[DataMember(Name="totalPaymentsAmount", EmitDefaultValue=false)]
		public double? TotalPaymentsAmount { get; set; }

		[DataMember(Name="totalPrimaryHousingExpenseAmount", EmitDefaultValue=false)]
		public double? TotalPrimaryHousingExpenseAmount { get; set; }

		[DataMember(Name="totalReoMarketValueAmount", EmitDefaultValue=false)]
		public double? TotalReoMarketValueAmount { get; set; }

		[DataMember(Name="totalUserDefinedIncome", EmitDefaultValue=false)]
		public double? TotalUserDefinedIncome { get; set; }

		[DataMember(Name="tQLReports", EmitDefaultValue=false)]
		public List<LoanContractTQLReports> TQLReports { get; set; }

		[DataMember(Name="transUnionAddress", EmitDefaultValue=false)]
		public string TransUnionAddress { get; set; }

		[DataMember(Name="transUnionCity", EmitDefaultValue=false)]
		public string TransUnionCity { get; set; }

		[DataMember(Name="transUnionFax", EmitDefaultValue=false)]
		public string TransUnionFax { get; set; }

		[DataMember(Name="transUnionModel", EmitDefaultValue=false)]
		public string TransUnionModel { get; set; }

		[DataMember(Name="transUnionName", EmitDefaultValue=false)]
		public string TransUnionName { get; set; }

		[DataMember(Name="transUnionPhone", EmitDefaultValue=false)]
		public string TransUnionPhone { get; set; }

		[DataMember(Name="transUnionPostalCode", EmitDefaultValue=false)]
		public string TransUnionPostalCode { get; set; }

		[DataMember(Name="transUnionScoreRangeFrom", EmitDefaultValue=false)]
		public string TransUnionScoreRangeFrom { get; set; }

		[DataMember(Name="transUnionScoreRangeTo", EmitDefaultValue=false)]
		public string TransUnionScoreRangeTo { get; set; }

		[DataMember(Name="transUnionState", EmitDefaultValue=false)]
		public string TransUnionState { get; set; }

		[DataMember(Name="transUnionWebsite", EmitDefaultValue=false)]
		public string TransUnionWebsite { get; set; }

		[DataMember(Name="userDefinedIncome", EmitDefaultValue=false)]
		public double? UserDefinedIncome { get; set; }

		[DataMember(Name="userDefinedIncomeDescription", EmitDefaultValue=false)]
		public string UserDefinedIncomeDescription { get; set; }

		[DataMember(Name="vACreditStandards", EmitDefaultValue=false)]
		public string VACreditStandards { get; set; }

		[DataMember(Name="vaSummarySpouseIncomeAmount", EmitDefaultValue=false)]
		public double? VaSummarySpouseIncomeAmount { get; set; }

		[DataMember(Name="vaSummaryTotalMonthlyGrossIncomeAmount", EmitDefaultValue=false)]
		public double? VaSummaryTotalMonthlyGrossIncomeAmount { get; set; }

		[DataMember(Name = "totalAdditionalLoansAmount", EmitDefaultValue = false)]
		public decimal? TotalAdditionalLoansAmount { get; set; }

		[DataMember(Name = "totalAppliedToDownpayment", EmitDefaultValue = false)]
		public decimal? TotalAppliedToDownpayment { get; set; }
	}
}