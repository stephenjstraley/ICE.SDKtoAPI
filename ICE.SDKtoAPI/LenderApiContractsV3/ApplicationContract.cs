using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ApplicationContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "legacyId")]
        public string LegacyId { get; set; }

        [DataMember(Name = "accountNumber1")]
        public string AccountNumber1 { get; set; }

        [DataMember(Name = "accountNumber2")]
        public string AccountNumber2 { get; set; }

        [DataMember(Name = "additionalLoans")]
        public List<AdditionalLoanContract> AdditionalLoans { get; set; }

        [DataMember(Name = "allOtherPaymentsAmount")]
        public decimal? AllOtherPaymentsAmount { get; set; }

        [DataMember(Name = "applicationSignedDate")]
        public string ApplicationSignedDate { get; set; }

        [DataMember(Name = "assets")]
        public List<AssetContract> Assets { get; set; }

        [DataMember(Name = "vods")]
        public List<VodContract> Vods { get; set; }

        [DataMember(Name = "assetsAvailableAmount")]
        public decimal? AssetsAvailableAmount { get; set; }

        [DataMember(Name = "balanceAvailableFamilySupportGuideline")]
        public decimal? BalanceAvailableFamilySupportGuideline { get; set; }

        [DataMember(Name = "borrower")]
        public BorrowerContract Borrower { get; set; }

        [DataMember(Name = "bottomRatioPercent")]
        public decimal? BottomRatioPercent { get; set; }

        [DataMember(Name = "brwCoBrwTotalTaxDeductions")]
        public decimal? BrwCoBrwTotalTaxDeductions { get; set; }

        [DataMember(Name = "coborrower")]
        public BorrowerContract Coborrower { get; set; }

        [DataMember(Name = "creditAliasName1")]
        public string CreditAliasName1 { get; set; }

        [DataMember(Name = "creditAliasName2")]
        public string CreditAliasName2 { get; set; }

        [DataMember(Name = "creditorName1")]
        public string CreditorName1 { get; set; }

        [DataMember(Name = "creditorName2")]
        public string CreditorName2 { get; set; }

        [DataMember(Name = "creditReportReferenceIdentifier")]
        public string CreditReportReferenceIdentifier { get; set; }

        [DataMember(Name = "equifaxAddress")]
        public string EquifaxAddress { get; set; }

        [DataMember(Name = "equifaxCity")]
        public string EquifaxCity { get; set; }

        [DataMember(Name = "equifaxFax")]
        public string EquifaxFax { get; set; }

        [DataMember(Name = "equifaxModel")]
        public string EquifaxModel { get; set; }

        [DataMember(Name = "equifaxName")]
        public string EquifaxName { get; set; }

        [DataMember(Name = "equifaxPhone")]
        public string EquifaxPhone { get; set; }

        [DataMember(Name = "equifaxPostalCode")]
        public string EquifaxPostalCode { get; set; }

        [DataMember(Name = "equifaxScoreRangeFrom")]
        public string EquifaxScoreRangeFrom { get; set; }

        [DataMember(Name = "equifaxScoreRangeTo")]
        public string EquifaxScoreRangeTo { get; set; }

        [DataMember(Name = "equifaxState")]
        public string EquifaxState { get; set; }

        [DataMember(Name = "equifaxWebsite")]
        public string EquifaxWebsite { get; set; }

        [DataMember(Name = "experianAddress")]
        public string ExperianAddress { get; set; }

        [DataMember(Name = "experianCity")]
        public string ExperianCity { get; set; }

        [DataMember(Name = "experianFax")]
        public string ExperianFax { get; set; }

        [DataMember(Name = "experianModel")]
        public string ExperianModel { get; set; }

        [DataMember(Name = "experianName")]
        public string ExperianName { get; set; }

        [DataMember(Name = "experianPhone")]
        public string ExperianPhone { get; set; }

        [DataMember(Name = "experianPostalCode")]
        public string ExperianPostalCode { get; set; }

        [DataMember(Name = "experianScoreRangeFrom")]
        public string ExperianScoreRangeFrom { get; set; }

        [DataMember(Name = "experianScoreRangeTo")]
        public string ExperianScoreRangeTo { get; set; }

        [DataMember(Name = "experianState")]
        public string ExperianState { get; set; }

        [DataMember(Name = "experianWebsite")]
        public string ExperianWebsite { get; set; }

        [DataMember(Name = "fhaVaDebtIncomeRatio")]
        public decimal? FhaVaDebtIncomeRatio { get; set; }

        [DataMember(Name = "fhaVaFamilySupportAmount")]
        public decimal? FhaVaFamilySupportAmount { get; set; }

        [DataMember(Name = "fhaVaTotalEstimatedMonthlyShelterExpenseAmount")]
        public decimal? FhaVaTotalEstimatedMonthlyShelterExpenseAmount { get; set; }

        [DataMember(Name = "fhaVaTotalNetEffectiveIncomeAmount")]
        public decimal? FhaVaTotalNetEffectiveIncomeAmount { get; set; }

        [DataMember(Name = "fhaVaTotalNetIncomeAmount")]
        public decimal? FhaVaTotalNetIncomeAmount { get; set; }

        [DataMember(Name = "fhaVaTotalNetTakeHomePayAmount")]
        public decimal? FhaVaTotalNetTakeHomePayAmount { get; set; }

        [DataMember(Name = "fhaVaTotalOtherNetIncome")]
        public decimal? FhaVaTotalOtherNetIncome { get; set; }

        [DataMember(Name = "firstMortgagePrincipalAndInterestAmount")]
        public decimal? FirstMortgagePrincipalAndInterestAmount { get; set; }

        [DataMember(Name = "freddieMacCreditReportReferenceIdentifier")]
        public string FreddieMacCreditReportReferenceIdentifier { get; set; }

        [DataMember(Name = "freddieMacOccupantHousingRatio")]
        public decimal? FreddieMacOccupantHousingRatio { get; set; }

        [DataMember(Name = "freddieMacOccupantDebtRatio")]
        public decimal? FreddieMacOccupantDebtRatio { get; set; }

        [DataMember(Name = "freDebtToHousingGapRatio")]
        public decimal? FreDebtToHousingGapRatio { get; set; }

        [DataMember(Name = "giftsGrants")]
        public List<GiftGrantContract> GiftsGrants { get; set; }

        [DataMember(Name = "grossBaseIncomeAmount")]
        public decimal? GrossBaseIncomeAmount { get; set; }

        [DataMember(Name = "grossIncomeForComortSet")]
        public decimal? GrossIncomeForComortSet { get; set; }

        [DataMember(Name = "grossNegativeCashFlow")]
        public decimal? GrossNegativeCashFlow { get; set; }

        [DataMember(Name = "grossOtherIncomeAmount")]
        public decimal? GrossOtherIncomeAmount { get; set; }

        [DataMember(Name = "grossPositiveCashFlow")]
        public decimal? GrossPositiveCashFlow { get; set; }

        [DataMember(Name = "hazardInsuranceAmount")]
        public string HazardInsuranceAmount { get; set; }

        [DataMember(Name = "homeownersAssociationDuesAndCondoFeesAmount")]
        public string HomeownersAssociationDuesAndCondoFeesAmount { get; set; }

        [DataMember(Name = "hudAutoLienHolderName1")]
        public string HudAutoLienHolderName1 { get; set; }

        [DataMember(Name = "hudAutoLienHolderName2")]
        public string HudAutoLienHolderName2 { get; set; }

        [DataMember(Name = "hudAutoLoanAmount1")]
        public decimal? HudAutoLoanAmount1 { get; set; }

        [DataMember(Name = "hudAutoLoanAmount2")]
        public decimal? HudAutoLoanAmount2 { get; set; }

        [DataMember(Name = "hudAutoMonthlyPayment1")]
        public decimal? HudAutoMonthlyPayment1 { get; set; }

        [DataMember(Name = "hudAutoMonthlyPayment2")]
        public decimal? HudAutoMonthlyPayment2 { get; set; }

        [DataMember(Name = "hudAutoPresentBalance1")]
        public decimal? HudAutoPresentBalance1 { get; set; }

        [DataMember(Name = "hudAutoPresentBalance2")]
        public decimal? HudAutoPresentBalance2 { get; set; }

        [DataMember(Name = "hudAutoYearAndMake1")]
        public string HudAutoYearAndMake1 { get; set; }

        [DataMember(Name = "hudAutoYearAndMake2")]
        public string HudAutoYearAndMake2 { get; set; }

        [DataMember(Name = "hudLoanAmount1")]
        public decimal? HudLoanAmount1 { get; set; }

        [DataMember(Name = "hudLoanAmount10")]
        public decimal? HudLoanAmount10 { get; set; }

        [DataMember(Name = "hudLoanAmount11")]
        public decimal? HudLoanAmount11 { get; set; }

        [DataMember(Name = "hudLoanAmount2")]
        public decimal? HudLoanAmount2 { get; set; }

        [DataMember(Name = "hudLoanAmount3")]
        public decimal? HudLoanAmount3 { get; set; }

        [DataMember(Name = "hudLoanAmount4")]
        public decimal? HudLoanAmount4 { get; set; }

        [DataMember(Name = "hudLoanAmount5")]
        public decimal? HudLoanAmount5 { get; set; }

        [DataMember(Name = "hudLoanAmount6")]
        public decimal? HudLoanAmount6 { get; set; }

        [DataMember(Name = "hudLoanAmount7")]
        public decimal? HudLoanAmount7 { get; set; }

        [DataMember(Name = "hudLoanAmount8")]
        public decimal? HudLoanAmount8 { get; set; }

        [DataMember(Name = "hudLoanAmount9")]
        public decimal? HudLoanAmount9 { get; set; }

        [DataMember(Name = "hudRealEstateFhaInsured1")]
        public bool? HudRealEstateFhaInsured1 { get; set; }

        [DataMember(Name = "hudRealEstateFhaInsured2")]
        public bool? HudRealEstateFhaInsured2 { get; set; }

        [DataMember(Name = "hudRealEstateLienHolder1")]
        public string HudRealEstateLienHolder1 { get; set; }

        [DataMember(Name = "hudRealEstateLienHolder2")]
        public string HudRealEstateLienHolder2 { get; set; }

        [DataMember(Name = "hudRealEstateLoanAmount1")]
        public decimal? HudRealEstateLoanAmount1 { get; set; }

        [DataMember(Name = "hudRealEstateLoanAmount2")]
        public decimal? HudRealEstateLoanAmount2 { get; set; }

        [DataMember(Name = "hudRealEstateMonthlyPayment1")]
        public decimal? HudRealEstateMonthlyPayment1 { get; set; }

        [DataMember(Name = "hudRealEstateMonthlyPayment2")]
        public decimal? HudRealEstateMonthlyPayment2 { get; set; }

        [DataMember(Name = "hudRealEstatePresentBalance1")]
        public decimal? HudRealEstatePresentBalance1 { get; set; }

        [DataMember(Name = "hudRealEstatePresentBalance2")]
        public decimal? HudRealEstatePresentBalance2 { get; set; }

        [DataMember(Name = "income")]
        public List<IncomeContract> Income { get; set; }

        [DataMember(Name = "incomeOfBorrowersSpouseUsedIndicator")]
        public bool? IncomeOfBorrowersSpouseUsedIndicator { get; set; }

        [DataMember(Name = "incomeOtherThanBorrowerUsedIndicator")]
        public bool? IncomeOtherThanBorrowerUsedIndicator { get; set; }

        [DataMember(Name = "jointAssetLiabilityReportingIndicator")]
        public bool? JointAssetLiabilityReportingIndicator { get; set; }

        [DataMember(Name = "liabilities")]
        public List<LiabilityContract> Liabilities { get; set; }

        [DataMember(Name = "vols")]
        public List<VolContract> Vols { get; set; }

        [DataMember(Name = "liquidAssetsComortSet")]
        public decimal? LiquidAssetsComortSet { get; set; }

        [DataMember(Name = "mcawBorrowerOtherMonthlyIncomeAmount")]
        public decimal? McawBorrowerOtherMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "mcawCoborrowerOtherMonthlyIncomeAmount")]
        public decimal? McawCoborrowerOtherMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "mcawGrossMonthlyIncomeAmount")]
        public decimal? McawGrossMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "mcawMortgagePaymentToIncome1Amount")]
        public decimal? McawMortgagePaymentToIncome1Amount { get; set; }

        [DataMember(Name = "mcawMortgagePaymentToIncome2Amount")]
        public decimal? McawMortgagePaymentToIncome2Amount { get; set; }

        [DataMember(Name = "mcawOtherAmount")]
        public decimal? McawOtherAmount { get; set; }

        [DataMember(Name = "mcawOtherDebtsAndObligationsAmount")]
        public decimal? McawOtherDebtsAndObligationsAmount { get; set; }

        [DataMember(Name = "mcawTotalFixedPaymentForPurchaseAmount")]
        public decimal? McawTotalFixedPaymentForPurchaseAmount { get; set; }

        [DataMember(Name = "mcawTotalFixedPaymentForRefinanceAmount")]
        public decimal? McawTotalFixedPaymentForRefinanceAmount { get; set; }

        [DataMember(Name = "mcawTotalFixedPaymentToIncome1Amount")]
        public decimal? McawTotalFixedPaymentToIncome1Amount { get; set; }

        [DataMember(Name = "mcawTotalFixedPaymentToIncome2Amount")]
        public decimal? McawTotalFixedPaymentToIncome2Amount { get; set; }

        [DataMember(Name = "mcawTotalMonthlyPaymentsAmount")]
        public decimal? McawTotalMonthlyPaymentsAmount { get; set; }

        [DataMember(Name = "mcawTotalMortgagePaymentAmount")]
        public decimal? McawTotalMortgagePaymentAmount { get; set; }

        [DataMember(Name = "monthlyExpenseComortSet")]
        public decimal? MonthlyExpenseComortSet { get; set; }

        [DataMember(Name = "monthlyHousingExpenseAmount")]
        public decimal? MonthlyHousingExpenseAmount { get; set; }

        [DataMember(Name = "monthlyInstallmentExpenseAmount")]
        public decimal? MonthlyInstallmentExpenseAmount { get; set; }

        [DataMember(Name = "monthlyNegativeRealEstateAmount")]
        public decimal? MonthlyNegativeRealEstateAmount { get; set; }

        [DataMember(Name = "monthlySecondHomeAmount")]
        public decimal? MonthlySecondHomeAmount { get; set; }

        [DataMember(Name = "mortgageInsuranceAmount")]
        public string MortgageInsuranceAmount { get; set; }

        [DataMember(Name = "netWorthAmount")]
        public decimal? NetWorthAmount { get; set; }

        [DataMember(Name = "otherAssets")]
        public List<OtherAssetContract> OtherAssets { get; set; }

        [DataMember(Name = "providedDocuments")]
        public List<ProvidedDocumentContract> ProvidedDocuments { get; set; }

        [DataMember(Name = "otherHousingExpenseAmount")]
        public decimal? OtherHousingExpenseAmount { get; set; }

        [DataMember(Name = "otherIncomeSources")]
        public List<OtherIncomeSourceContract> OtherIncomeSources { get; set; }

        [DataMember(Name = "otherItemsDeducted")]
        public decimal? OtherItemsDeducted { get; set; }

        [DataMember(Name = "otherLiabilities")]
        public List<OtherLiabilityContract> OtherLiabilities { get; set; }

        [DataMember(Name = "otherMortgagePrincipalAndInterestAmount")]
        public decimal? OtherMortgagePrincipalAndInterestAmount { get; set; }

        [DataMember(Name = "otherTotalIncome")]
        public decimal? OtherTotalIncome { get; set; }

        [DataMember(Name = "pastCreditRecord")]
        public string PastCreditRecord { get; set; }

        [DataMember(Name = "presentHousingExpComortSet")]
        public decimal? PresentHousingExpComortSet { get; set; }

        [DataMember(Name = "primaryResidenceComortSet")]
        public decimal? PrimaryResidenceComortSet { get; set; }

        [DataMember(Name = "propertyUsageType")]
        public string PropertyUsageType { get; set; }

        [DataMember(Name = "proposedDuesAmount")]
        public string ProposedDuesAmount { get; set; }

        [DataMember(Name = "proposedFirstMortgageAmount")]
        public decimal? ProposedFirstMortgageAmount { get; set; }

        [DataMember(Name = "proposedGroundRentAmount")]
        public decimal? ProposedGroundRentAmount { get; set; }

        [DataMember(Name = "proposedHazardInsuranceAmount")]
        public string ProposedHazardInsuranceAmount { get; set; }

        [DataMember(Name = "proposedMortgageInsuranceAmount")]
        public string ProposedMortgageInsuranceAmount { get; set; }

        [DataMember(Name = "proposedOtherAmount")]
        public decimal? ProposedOtherAmount { get; set; }

        [DataMember(Name = "proposedOtherMortgagesAmount")]
        public decimal? ProposedOtherMortgagesAmount { get; set; }

        [DataMember(Name = "proposedRealEstateTaxesAmount")]
        public string ProposedRealEstateTaxesAmount { get; set; }

        [DataMember(Name = "realEstateTaxAmount")]
        public string RealEstateTaxAmount { get; set; }

        [DataMember(Name = "rentAmount")]
        public decimal? RentAmount { get; set; }

        [DataMember(Name = "reoProperties")]
        public List<ReoPropertyContract> ReoProperties { get; set; }

        [DataMember(Name = "reoTotalGrossRentalIncomeAmount")]
        public decimal? ReoTotalGrossRentalIncomeAmount { get; set; }

        [DataMember(Name = "reoTotalMaintenanceAmount")]
        public decimal? ReoTotalMaintenanceAmount { get; set; }

        [DataMember(Name = "reoTotalMarketValueAmount")]
        public decimal? ReoTotalMarketValueAmount { get; set; }

        [DataMember(Name = "reoTotalMortgagePaymentsAmount")]
        public decimal? ReoTotalMortgagePaymentsAmount { get; set; }

        [DataMember(Name = "reoTotalMortgagesAndLiensAmount")]
        public decimal? ReoTotalMortgagesAndLiensAmount { get; set; }

        [DataMember(Name = "reoTotalNetRentalIncomeAmount")]
        public int? ReoTotalNetRentalIncomeAmount { get; set; }

        [DataMember(Name = "selfEmployedIncome")]
        public List<SelfEmployedIncomeContract> SelfEmployedIncome { get; set; }

        [DataMember(Name = "spouseIncomeConsider")]
        public bool? SpouseIncomeConsider { get; set; }

        [DataMember(Name = "tax4506")]
        public Tax4506ClassicContract Tax4506 { get; set; }

        [DataMember(Name = "tax4506s")]
        public List<Tax4506Contract> Tax4506s { get; set; }

        [DataMember(Name = "tax4506T")]
        public Tax4506TClassicContract Tax4506T { get; set; }

        [DataMember(Name = "tax4506Ts")]
        public List<Tax4506TContract> Tax4506Ts { get; set; }

        [DataMember(Name = "topRatioPercent")]
        public decimal? TopRatioPercent { get; set; }

        [DataMember(Name = "totalAdditionalAssetsAmount")]
        public decimal? TotalAdditionalAssetsAmount { get; set; }

        [DataMember(Name = "totalAdditionalOtherAssetsAmount")]
        public decimal? TotalAdditionalOtherAssetsAmount { get; set; }

        [DataMember(Name = "totalAssetsAmount")]
        public decimal? TotalAssetsAmount { get; set; }

        [DataMember(Name = "totalBaseIncomeAmount")]
        public decimal? TotalBaseIncomeAmount { get; set; }

        [DataMember(Name = "totalBonusAmount")]
        public decimal? TotalBonusAmount { get; set; }

        [DataMember(Name = "totalCommissionsAmount")]
        public decimal? TotalCommissionsAmount { get; set; }

        [DataMember(Name = "totalDeposit")]
        public decimal? TotalDeposit { get; set; }

        [DataMember(Name = "totalDividendsInterestAmount")]
        public decimal? TotalDividendsInterestAmount { get; set; }

        [DataMember(Name = "totalEmploymentAmount")]
        public decimal? TotalEmploymentAmount { get; set; }

        [DataMember(Name = "totalFixedPaymentAmount")]
        public decimal? TotalFixedPaymentAmount { get; set; }

        [DataMember(Name = "totalGrossMonthlyIncomeAmount")]
        public decimal? TotalGrossMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "totalIncomeAmount")]
        public decimal? TotalIncomeAmount { get; set; }

        [DataMember(Name = "totalMonthlyPaymentAmount")]
        public decimal? TotalMonthlyPaymentAmount { get; set; }

        [DataMember(Name = "totalMortgagesBalanceAmount")]
        public decimal? TotalMortgagesBalanceAmount { get; set; }

        [DataMember(Name = "totalMortgagesMonthlyPaymentAmount")]
        public decimal? TotalMortgagesMonthlyPaymentAmount { get; set; }

        [DataMember(Name = "totalNetRentalIncomeAmount")]
        public decimal? TotalNetRentalIncomeAmount { get; set; }

        [DataMember(Name = "totalOther1Amount")]
        public decimal? TotalOther1Amount { get; set; }

        [DataMember(Name = "totalOther2Amount")]
        public decimal? TotalOther2Amount { get; set; }

        [DataMember(Name = "totalOtherAssetsAmount")]
        public decimal? TotalOtherAssetsAmount { get; set; }

        [DataMember(Name = "totalOvertimeAmount")]
        public decimal? TotalOvertimeAmount { get; set; }

        [DataMember(Name = "totalPaymentsAmount")]
        public decimal? TotalPaymentsAmount { get; set; }

        [DataMember(Name = "totalPrimaryHousingExpenseAmount")]
        public decimal? TotalPrimaryHousingExpenseAmount { get; set; }

        [DataMember(Name = "totalReoMarketValueAmount")]
        public decimal? TotalReoMarketValueAmount { get; set; }

        [DataMember(Name = "totalUrla2020AssetsAmount")]
        public decimal? TotalUrla2020AssetsAmount { get; set; }

        [DataMember(Name = "totalUserDefinedIncome")]
        public decimal? TotalUserDefinedIncome { get; set; }

        [DataMember(Name = "tqlReports")]
        public List<TqlReportContract> TqlReports { get; set; }

        [DataMember(Name = "transUnionAddress")]
        public string TransUnionAddress { get; set; }

        [DataMember(Name = "transUnionCity")]
        public string TransUnionCity { get; set; }

        [DataMember(Name = "transUnionFax")]
        public string TransUnionFax { get; set; }

        [DataMember(Name = "transUnionModel")]
        public string TransUnionModel { get; set; }

        [DataMember(Name = "transUnionName")]
        public string TransUnionName { get; set; }

        [DataMember(Name = "transUnionPhone")]
        public string TransUnionPhone { get; set; }

        [DataMember(Name = "transUnionPostalCode")]
        public string TransUnionPostalCode { get; set; }

        [DataMember(Name = "transUnionScoreRangeFrom")]
        public string TransUnionScoreRangeFrom { get; set; }

        [DataMember(Name = "transUnionScoreRangeTo")]
        public string TransUnionScoreRangeTo { get; set; }

        [DataMember(Name = "transUnionState")]
        public string TransUnionState { get; set; }

        [DataMember(Name = "transUnionWebsite")]
        public string TransUnionWebsite { get; set; }

        [DataMember(Name = "userDefinedIncomeDescription")]
        public string UserDefinedIncomeDescription { get; set; }

        [DataMember(Name = "vaCreditStandards")]
        public string VaCreditStandards { get; set; }

        [DataMember(Name = "vaSummarySpouseIncomeAmount")]
        public decimal? VaSummarySpouseIncomeAmount { get; set; }

        [DataMember(Name = "vaSummaryTotalMonthlyGrossIncomeAmount")]
        public decimal? VaSummaryTotalMonthlyGrossIncomeAmount { get; set; }

        [DataMember(Name = "atrqmBorrower")]
        public ATRQMBorrowerContract AtrqmBorrower { get; set; }

        [DataMember(Name = "sofDBorrowerAddressType")]
        public string SofDBorrowerAddressType { get; set; }

        [DataMember(Name = "sofDBorrowerAddress")]
        public string SofDBorrowerAddress { get; set; }

        [DataMember(Name = "sofDBorrowerAddressCity")]
        public string SofDBorrowerAddressCity { get; set; }

        [DataMember(Name = "sofDBorrowerAddressState")]
        public string SofDBorrowerAddressState { get; set; }

        [DataMember(Name = "sofDBorrowerAddressZipcode")]
        public string SofDBorrowerAddressZipcode { get; set; }

        [DataMember(Name = "sofDCoBorrowerAddressType")]
        public string SofDCoBorrowerAddressType { get; set; }

        [DataMember(Name = "sofDCoBorrowerAddress")]
        public string SofDCoBorrowerAddress { get; set; }

        [DataMember(Name = "sofDCoBorrowerAddressCity")]
        public string SofDCoBorrowerAddressCity { get; set; }

        [DataMember(Name = "sofDCoBorrowerAddressState")]
        public string SofDCoBorrowerAddressState { get; set; }

        [DataMember(Name = "sofDCoBorrowerAddressZipcode")]
        public string SofDCoBorrowerAddressZipcode { get; set; }

        [DataMember(Name = "sofDBorrCountry")]
        public string SofDBorrCountry { get; set; }

        [DataMember(Name = "sofDCoBorrCountry")]
        public string SofDCoBorrCountry { get; set; }

        [DataMember(Name = "sofDBorrForeignAddressIndicator")]
        public bool? SofDBorrForeignAddressIndicator { get; set; }

        [DataMember(Name = "sofDCoBorrForeignAddressIndicator")]
        public bool? SofDCoBorrForeignAddressIndicator { get; set; }

        [DataMember(Name = "ausTracking")]
        public AUSTrackingContract AusTracking { get; set; }

        [DataMember(Name = "ausTrackingLogs")]
        public List<AUSTrackingLogContract> AusTrackingLogs { get; set; }

        [DataMember(Name = "loanOfficer")]
        public string LoanOfficer { get; set; }

        [DataMember(Name = "loanOfficerName")]
        public string LoanOfficerName { get; set; }

        [DataMember(Name = "lastModified")]
        public string LastModified { get; set; }

        [DataMember(Name = "respa6")]
        public string Respa6 { get; set; }

        [DataMember(Name = "loanAmount")]
        public string LoanAmount { get; set; }

        [DataMember(Name = "totalAdditionalLoansAmount")]
        public decimal? TotalAdditionalLoansAmount { get; set; }

        [DataMember(Name = "totalAppliedToDownpayment")]
        public decimal? TotalAppliedToDownpayment { get; set; }

        [DataMember(Name = "borrowerPairId")]
        public string BorrowerPairId { get; set; }

        [DataMember(Name = "closingDisclosureBorDeliveryDate")]
        public string ClosingDisclosureBorDeliveryDate { get; set; }

        [DataMember(Name = "closingDisclosureBorReceivedDate")]
        public string ClosingDisclosureBorReceivedDate { get; set; }

        [DataMember(Name = "rescissionDate")]
        public string RescissionDate { get; set; }

        [DataMember(Name = "rescissionNoteSignedDate")]
        public string RescissionNoteSignedDate { get; set; }

        [DataMember(Name = "loanEstimateDeliveryDate")]
        public string LoanEstimateDeliveryDate { get; set; }

        [DataMember(Name = "presentSupplementalPropertyInsuranceAmount")]
        public decimal? PresentSupplementalPropertyInsuranceAmount { get; set; }

        [DataMember(Name = "prequalCreditReportIndicator")]
        public bool? PrequalCreditReportIndicator { get; set; }
    }
}
