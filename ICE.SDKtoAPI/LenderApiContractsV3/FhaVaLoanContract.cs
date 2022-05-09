using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FhaVaLoanContract
    {
        [DataMember(Name = "addendumType")]
        public string AddendumType { get; set; }

        [DataMember(Name = "additionalCondition1")]
        public bool? AdditionalCondition1 { get; set; }

        [DataMember(Name = "additionalCondition2")]
        public bool? AdditionalCondition2 { get; set; }

        [DataMember(Name = "additionalCondition3")]
        public bool? AdditionalCondition3 { get; set; }

        [DataMember(Name = "additionalCondition4")]
        public bool? AdditionalCondition4 { get; set; }

        [DataMember(Name = "additionalCondition5")]
        public bool? AdditionalCondition5 { get; set; }

        [DataMember(Name = "additionalCondition6")]
        public bool? AdditionalCondition6 { get; set; }

        [DataMember(Name = "additionalCondition7")]
        public bool? AdditionalCondition7 { get; set; }

        [DataMember(Name = "additionalCondition8")]
        public bool? AdditionalCondition8 { get; set; }

        [DataMember(Name = "additionalCondition9")]
        public bool? AdditionalCondition9 { get; set; }

        [DataMember(Name = "addressValidatedBy")]
        public string AddressValidatedBy { get; set; }

        [DataMember(Name = "addressValidationMessage")]
        public string AddressValidationMessage { get; set; }

        [DataMember(Name = "appraisalLoggedDate")]
        public string AppraisalLoggedDate { get; set; }

        [DataMember(Name = "appraisalLookupBy")]
        public string AppraisalLookupBy { get; set; }

        [DataMember(Name = "beenInformed")]
        public string BeenInformed { get; set; }

        [DataMember(Name = "borrowerCertificationAddress")]
        public string BorrowerCertificationAddress { get; set; }

        [DataMember(Name = "borrowerCertificationCity")]
        public string BorrowerCertificationCity { get; set; }

        [DataMember(Name = "borrowerCertificationPostalCode")]
        public string BorrowerCertificationPostalCode { get; set; }

        [DataMember(Name = "borrowerCertificationState")]
        public string BorrowerCertificationState { get; set; }

        [DataMember(Name = "caivrsObtainedBy")]
        public string CaivrsObtainedBy { get; set; }

        [DataMember(Name = "caseBinderShippedBy")]
        public string CaseBinderShippedBy { get; set; }

        [DataMember(Name = "caseBinderShippedDate")]
        public string CaseBinderShippedDate { get; set; }

        [DataMember(Name = "closingDate")]
        public string ClosingDate { get; set; }

        [DataMember(Name = "condoPudId")]
        public string CondoPudId { get; set; }

        [DataMember(Name = "condoPudLookupBy")]
        public string CondoPudLookupBy { get; set; }

        [DataMember(Name = "condoPudLookupDate")]
        public string CondoPudLookupDate { get; set; }

        [DataMember(Name = "approvalExpirationDate")]
        public string ApprovalExpirationDate { get; set; }

        [DataMember(Name = "mortgageApprovedDate")]
        public string MortgageApprovedDate { get; set; }

        [DataMember(Name = "detailForOther")]
        public string DetailForOther { get; set; }

        [DataMember(Name = "discountPoints")]
        public decimal? DiscountPoints { get; set; }

        [DataMember(Name = "dulyAgentAddress")]
        public string DulyAgentAddress { get; set; }

        [DataMember(Name = "dulyAgentCity")]
        public string DulyAgentCity { get; set; }

        [DataMember(Name = "dulyAgentFunction1")]
        public string DulyAgentFunction1 { get; set; }

        [DataMember(Name = "dulyAgentFunction2")]
        public string DulyAgentFunction2 { get; set; }

        [DataMember(Name = "dulyAgentName")]
        public string DulyAgentName { get; set; }

        [DataMember(Name = "dulyAgentState")]
        public string DulyAgentState { get; set; }

        [DataMember(Name = "dwellingCoveredBy")]
        public bool? DwellingCoveredBy { get; set; }

        [DataMember(Name = "energyEfficientMortgage")]
        public EnergyEfficientMortgageContract EnergyEfficientMortgage { get; set; }

        [DataMember(Name = "eligibilityAssessment")]
        public string EligibilityAssessment { get; set; }

        [DataMember(Name = "energyEfficientMortgageAmount")]
        public decimal? EnergyEfficientMortgageAmount { get; set; }

        [DataMember(Name = "energyEfficientMortgageItems")]
        public List<EnergyEfficientMortgageItemContract> EnergyEfficientMortgageItems { get; set; }

        [DataMember(Name = "everHadVaHomeLoan")]
        public bool? EverHadVaHomeLoan { get; set; }

        [DataMember(Name = "excessContributionAmount")]
        public decimal? ExcessContributionAmount { get; set; }

        [DataMember(Name = "existingDebtAmount")]
        public decimal? ExistingDebtAmount { get; set; }

        [DataMember(Name = "fhaCaseOrderedBy")]
        public string FhaCaseOrderedBy { get; set; }

        [DataMember(Name = "fhaManagementCounselType")]
        public string FhaManagementCounselType { get; set; }

        [DataMember(Name = "fhaMaxLoanAmount")]
        public decimal? FhaMaxLoanAmount { get; set; }

        [DataMember(Name = "foreclosedProperty")]
        public bool? ForeclosedProperty { get; set; }

        [DataMember(Name = "freddieMacCounselType")]
        public string FreddieMacCounselType { get; set; }

        [DataMember(Name = "fundingFeePaidInCash")]
        public decimal? FundingFeePaidInCash { get; set; }

        [DataMember(Name = "giftFundsAmount")]
        public decimal? GiftFundsAmount { get; set; }

        [DataMember(Name = "haveReceivedLeadPaintPoisoningInfo")]
        public bool? HaveReceivedLeadPaintPoisoningInfo { get; set; }

        [DataMember(Name = "hud1003AddendumApproved")]
        public string Hud1003AddendumApproved { get; set; }

        [DataMember(Name = "lastRefiDate")]
        public string LastRefiDate { get; set; }

        [DataMember(Name = "ldpgsaSearchDate")]
        public string LdpgsaSearchDate { get; set; }

        [DataMember(Name = "ldpgsaSearchedBy")]
        public string LdpgsaSearchedBy { get; set; }

        [DataMember(Name = "lenderAddress")]
        public string LenderAddress { get; set; }

        [DataMember(Name = "lenderCity")]
        public string LenderCity { get; set; }

        [DataMember(Name = "lenderName")]
        public string LenderName { get; set; }

        [DataMember(Name = "lenderNmls")]
        public string LenderNmls { get; set; }

        [DataMember(Name = "lenderPostalCode")]
        public string LenderPostalCode { get; set; }

        [DataMember(Name = "lenderRepresentativeName")]
        public string LenderRepresentativeName { get; set; }

        [DataMember(Name = "lenderRepresentativePhone")]
        public string LenderRepresentativePhone { get; set; }

        [DataMember(Name = "lenderRepresentativeTitle")]
        public string LenderRepresentativeTitle { get; set; }

        [DataMember(Name = "lenderState")]
        public string LenderState { get; set; }

        [DataMember(Name = "lenderTaxId")]
        public string LenderTaxId { get; set; }

        [DataMember(Name = "loanScoreId")]
        public string LoanScoreId { get; set; }

        [DataMember(Name = "miAppliedBy")]
        public string MiAppliedBy { get; set; }

        [DataMember(Name = "miAppliedDate")]
        public string MiAppliedDate { get; set; }

        [DataMember(Name = "micRetrivedDate")]
        public string MicRetrivedDate { get; set; }

        [DataMember(Name = "minimumDownPayment")]
        public decimal? MinimumDownPayment { get; set; }

        [DataMember(Name = "mip1stDueDate")]
        public string Mip1stDueDate { get; set; }

        [DataMember(Name = "mip1stToInvestor")]
        public string Mip1stToInvestor { get; set; }

        [DataMember(Name = "mipRemittedDate")]
        public string MipRemittedDate { get; set; }

        [DataMember(Name = "miRejectedDate")]
        public string MiRejectedDate { get; set; }

        [DataMember(Name = "modifiedInterestRate")]
        public decimal? ModifiedInterestRate { get; set; }

        [DataMember(Name = "modifiedLoanAmount")]
        public decimal? ModifiedLoanAmount { get; set; }

        [DataMember(Name = "modifiedMonthlyPayment")]
        public decimal? ModifiedMonthlyPayment { get; set; }

        [DataMember(Name = "modifiedMonthlyPremium")]
        public decimal? ModifiedMonthlyPremium { get; set; }

        [DataMember(Name = "modifiedProposedMaturityMonth")]
        public int? ModifiedProposedMaturityMonth { get; set; }

        [DataMember(Name = "modifiedProposedMaturityYear")]
        public int? ModifiedProposedMaturityYear { get; set; }

        [DataMember(Name = "modifiedTermAnnualPremium")]
        public int? ModifiedTermAnnualPremium { get; set; }

        [DataMember(Name = "modifiedUpfrontPremium")]
        public decimal? ModifiedUpfrontPremium { get; set; }

        [DataMember(Name = "mortgageeRepresentative")]
        public string MortgageeRepresentative { get; set; }

        [DataMember(Name = "mortgageFinancialInterest")]
        public string MortgageFinancialInterest { get; set; }

        [DataMember(Name = "nonRealtyAndOtherItems")]
        public decimal? NonRealtyAndOtherItems { get; set; }

        [DataMember(Name = "obtainCaivrsDate")]
        public string ObtainCaivrsDate { get; set; }

        [DataMember(Name = "occupancy")]
        public string Occupancy { get; set; }

        [DataMember(Name = "oldAgencyCaseIdentifier")]
        public string OldAgencyCaseIdentifier { get; set; }

        [DataMember(Name = "originalMortgageAmount")]
        public decimal? OriginalMortgageAmount { get; set; }

        [DataMember(Name = "otherLiabilitiesMonthlyPayment")]
        public decimal? OtherLiabilitiesMonthlyPayment { get; set; }

        [DataMember(Name = "otherLiabilitiesUnpaidBalance")]
        public decimal? OtherLiabilitiesUnpaidBalance { get; set; }

        [DataMember(Name = "otherMonthlyShelterExpense")]
        public decimal? OtherMonthlyShelterExpense { get; set; }

        [DataMember(Name = "otherTitleDescription")]
        public string OtherTitleDescription { get; set; }

        [DataMember(Name = "ownMoreThanFourDwellings")]
        public bool? OwnMoreThanFourDwellings { get; set; }

        [DataMember(Name = "ownOrSoldOtherRealEstate")]
        public bool? OwnOrSoldOtherRealEstate { get; set; }

        [DataMember(Name = "paidAmount")]
        public decimal? PaidAmount { get; set; }

        [DataMember(Name = "premiumMonths")]
        public int? PremiumMonths { get; set; }

        [DataMember(Name = "prepaidExpenses")]
        public decimal? PrepaidExpenses { get; set; }

        [DataMember(Name = "previousPurchaseDate")]
        public string PreviousPurchaseDate { get; set; }

        [DataMember(Name = "priorEndorsementDate")]
        public string PriorEndorsementDate { get; set; }

        [DataMember(Name = "proposedMaturityMonths")]
        public int? ProposedMaturityMonths { get; set; }

        [DataMember(Name = "proposedMaturityYears")]
        public int? ProposedMaturityYears { get; set; }

        [DataMember(Name = "purposeOfLoan")]
        public string PurposeOfLoan { get; set; }

        [DataMember(Name = "refiAuthorizationBy")]
        public string RefiAuthorizationBy { get; set; }

        [DataMember(Name = "refiAuthorizationDate")]
        public string RefiAuthorizationDate { get; set; }

        [DataMember(Name = "salesPrice")]
        public decimal? SalesPrice { get; set; }

        [DataMember(Name = "secondMortgageAmount")]
        public decimal? SecondMortgageAmount { get; set; }

        [DataMember(Name = "sellerPaidClosingCost")]
        public decimal? SellerPaidClosingCost { get; set; }

        [DataMember(Name = "servingTransferredDate")]
        public string ServingTransferredDate { get; set; }

        [DataMember(Name = "specialAssessments")]
        public decimal? SpecialAssessments { get; set; }

        [DataMember(Name = "sponsorAgentAddress")]
        public string SponsorAgentAddress { get; set; }

        [DataMember(Name = "sponsorAgentCity")]
        public string SponsorAgentCity { get; set; }

        [DataMember(Name = "sponsorAgentName")]
        public string SponsorAgentName { get; set; }

        [DataMember(Name = "sponsorAgentNmls")]
        public string SponsorAgentNmls { get; set; }

        [DataMember(Name = "sponsorAgentPostalCode")]
        public string SponsorAgentPostalCode { get; set; }

        [DataMember(Name = "sponsorAgentState")]
        public string SponsorAgentState { get; set; }

        [DataMember(Name = "sponsorAgentTaxId")]
        public string SponsorAgentTaxId { get; set; }

        [DataMember(Name = "sponsoredOriginationsName")]
        public string SponsoredOriginationsName { get; set; }

        [DataMember(Name = "sponsoredOriginationsNmls")]
        public string SponsoredOriginationsNmls { get; set; }

        [DataMember(Name = "sponsoredOriginationsTaxId")]
        public string SponsoredOriginationsTaxId { get; set; }

        [DataMember(Name = "sponsorId")]
        public string SponsorId { get; set; }

        [DataMember(Name = "titleVestedIn")]
        public string TitleVestedIn { get; set; }

        [DataMember(Name = "toBeSold")]
        public bool? ToBeSold { get; set; }

        [DataMember(Name = "totalClosingCost")]
        public decimal? TotalClosingCost { get; set; }

        [DataMember(Name = "totalScorecardBy")]
        public string TotalScorecardBy { get; set; }

        [DataMember(Name = "totalScorecardDate")]
        public string TotalScorecardDate { get; set; }

        [DataMember(Name = "ufmipRemittanceDueDate")]
        public string UfmipRemittanceDueDate { get; set; }

        [DataMember(Name = "ufmipRemittedAmount")]
        public decimal? UfmipRemittedAmount { get; set; }

        [DataMember(Name = "ufmipRemittedBy")]
        public string UfmipRemittedBy { get; set; }

        [DataMember(Name = "ufmipRemittedDate")]
        public string UfmipRemittedDate { get; set; }

        [DataMember(Name = "ufmipVerificationCode")]
        public string UfmipVerificationCode { get; set; }

        [DataMember(Name = "useDefaultLenderInfo")]
        public bool? UseDefaultLenderInfo { get; set; }

        [DataMember(Name = "utilityIncluded")]
        public bool? UtilityIncluded { get; set; }

        [DataMember(Name = "validateAddressDate")]
        public string ValidateAddressDate { get; set; }

        [DataMember(Name = "valuation")]
        public string Valuation { get; set; }

        [DataMember(Name = "allConditionsSatisfied")]
        public bool? AllConditionsSatisfied { get; set; }

        [DataMember(Name = "fhaSalesPrice")]
        public decimal? FhaSalesPrice { get; set; }

        [DataMember(Name = "fhaMortgageAmount")]
        public decimal? FhaMortgageAmount { get; set; }

        [DataMember(Name = "fhaMortgageAmountUmip")]
        public decimal? FhaMortgageAmountUmip { get; set; }

        [DataMember(Name = "fhaClosingCost")]
        public decimal? FhaClosingCost { get; set; }

        [DataMember(Name = "fhaDownPayment")]
        public decimal? FhaDownPayment { get; set; }

        [DataMember(Name = "fhaInterestRate")]
        public decimal? FhaInterestRate { get; set; }

        [DataMember(Name = "fhaLoanTerm")]
        public int? FhaLoanTerm { get; set; }

        [DataMember(Name = "fhaMonthlyPayment")]
        public decimal? FhaMonthlyPayment { get; set; }

        [DataMember(Name = "fhaLtv")]
        public decimal? FhaLtv { get; set; }

        [DataMember(Name = "fhaMmi")]
        public decimal? FhaMmi { get; set; }

        [DataMember(Name = "fhaYearsMonthlyInsurance")]
        public int? FhaYearsMonthlyInsurance { get; set; }

        [DataMember(Name = "fhaUmip")]
        public decimal? FhaUmip { get; set; }

        [DataMember(Name = "conventionalSalesPrice")]
        public decimal? ConventionalSalesPrice { get; set; }

        [DataMember(Name = "conventionalMortgageAmount")]
        public decimal? ConventionalMortgageAmount { get; set; }

        [DataMember(Name = "conventionalClosingCost")]
        public decimal? ConventionalClosingCost { get; set; }

        [DataMember(Name = "conventionalDownPayment")]
        public decimal? ConventionalDownPayment { get; set; }

        [DataMember(Name = "conventionalInterestRate")]
        public decimal? ConventionalInterestRate { get; set; }

        [DataMember(Name = "conventionalLoanTerm")]
        public int? ConventionalLoanTerm { get; set; }

        [DataMember(Name = "conventionalMonthlyPayment")]
        public decimal? ConventionalMonthlyPayment { get; set; }

        [DataMember(Name = "conventionalLtv")]
        public decimal? ConventionalLtv { get; set; }

        [DataMember(Name = "conventionalMmi")]
        public decimal? ConventionalMmi { get; set; }

        [DataMember(Name = "conventionalMaxYearsMi")]
        public int? ConventionalMaxYearsMi { get; set; }

        [DataMember(Name = "conventionalUmip")]
        public decimal? ConventionalUmip { get; set; }

        [DataMember(Name = "isEntityActingAsAgent")]
        public bool? IsEntityActingAsAgent { get; set; }

        [DataMember(Name = "dulyAuthAgentName2")]
        public string DulyAuthAgentName2 { get; set; }

        [DataMember(Name = "dulyAuthAgentAddress2")]
        public string DulyAuthAgentAddress2 { get; set; }

        [DataMember(Name = "dulyAuthAgentCity2")]
        public string DulyAuthAgentCity2 { get; set; }

        [DataMember(Name = "dulyAuthAgentState2")]
        public string DulyAuthAgentState2 { get; set; }

        [DataMember(Name = "dulyAuthAgentName3")]
        public string DulyAuthAgentName3 { get; set; }

        [DataMember(Name = "dulyAuthAgentAddress3")]
        public string DulyAuthAgentAddress3 { get; set; }

        [DataMember(Name = "dulyAuthAgentCity3")]
        public string DulyAuthAgentCity3 { get; set; }

        [DataMember(Name = "dulyAuthAgentState3")]
        public string DulyAuthAgentState3 { get; set; }

        [DataMember(Name = "dulyAuthAgentFunction3")]
        public string DulyAuthAgentFunction3 { get; set; }

        [DataMember(Name = "dulyAuthAgentName4")]
        public string DulyAuthAgentName4 { get; set; }

        [DataMember(Name = "dulyAuthAgentAddress4")]
        public string DulyAuthAgentAddress4 { get; set; }

        [DataMember(Name = "dulyAuthAgentCity4")]
        public string DulyAuthAgentCity4 { get; set; }

        [DataMember(Name = "dulyAuthAgentState4")]
        public string DulyAuthAgentState4 { get; set; }

        [DataMember(Name = "dulyAuthAgentFunction4")]
        public string DulyAuthAgentFunction4 { get; set; }

        [DataMember(Name = "dulyAuthAgentName5")]
        public string DulyAuthAgentName5 { get; set; }

        [DataMember(Name = "dulyAuthAgentAddress5")]
        public string DulyAuthAgentAddress5 { get; set; }

        [DataMember(Name = "dulyAuthAgentCity5")]
        public string DulyAuthAgentCity5 { get; set; }

        [DataMember(Name = "dulyAuthAgentState5")]
        public string DulyAuthAgentState5 { get; set; }

        [DataMember(Name = "dulyAuthAgentFunction5")]
        public string DulyAuthAgentFunction5 { get; set; }
    }
}
