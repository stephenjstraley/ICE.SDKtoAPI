using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFhaVaLoan
	{
		[DataMember(Name="addendumType")]
		public string AddendumType { get; set; }

		[DataMember(Name="additionalCondition1")]
		public bool? AdditionalCondition1 { get; set; }

		[DataMember(Name="additionalCondition2")]
		public bool? AdditionalCondition2 { get; set; }

		[DataMember(Name="additionalCondition3")]
		public bool? AdditionalCondition3 { get; set; }

		[DataMember(Name="additionalCondition4")]
		public bool? AdditionalCondition4 { get; set; }

		[DataMember(Name="additionalCondition5")]
		public bool? AdditionalCondition5 { get; set; }

		[DataMember(Name="additionalCondition6")]
		public bool? AdditionalCondition6 { get; set; }

		[DataMember(Name="additionalCondition7")]
		public bool? AdditionalCondition7 { get; set; }

		[DataMember(Name="additionalCondition8")]
		public bool? AdditionalCondition8 { get; set; }

		[DataMember(Name="additionalCondition9")]
		public bool? AdditionalCondition9 { get; set; }

		[DataMember(Name="addressValidatedBy")]
		public string AddressValidatedBy { get; set; }

		[DataMember(Name="addressValidationMessage")]
		public string AddressValidationMessage { get; set; }

		[DataMember(Name="allConditionsSatisfied")]
		public bool? AllConditionsSatisfied { get; set; }

		[DataMember(Name="appraisalLoggedDate")]
		public DateTime? AppraisalLoggedDate { get; set; }

		[DataMember(Name="appraisalLookupBy")]
		public string AppraisalLookupBy { get; set; }

		[DataMember(Name="beenInformed")]
		public string BeenInformed { get; set; }

		[DataMember(Name="borrowerCertificationAddress")]
		public string BorrowerCertificationAddress { get; set; }

		[DataMember(Name="borrowerCertificationCity")]
		public string BorrowerCertificationCity { get; set; }

		[DataMember(Name="borrowerCertificationPostalCode")]
		public string BorrowerCertificationPostalCode { get; set; }

		[DataMember(Name="borrowerCertificationState")]
		public string BorrowerCertificationState { get; set; }

		[DataMember(Name="cAIVRSObtainedBy")]
		public string CAIVRSObtainedBy { get; set; }

		[DataMember(Name="caseBinderShippedBy")]
		public string CaseBinderShippedBy { get; set; }

		[DataMember(Name="caseBinderShippedDate")]
		public DateTime? CaseBinderShippedDate { get; set; }

		[DataMember(Name="closingDate")]
		public DateTime? ClosingDate { get; set; }

		[DataMember(Name="condoPudID")]
		public string CondoPudID { get; set; }

		[DataMember(Name="condoPudLookupBy")]
		public string CondoPudLookupBy { get; set; }

		[DataMember(Name="condoPudLookupDate")]
		public DateTime? CondoPudLookupDate { get; set; }

		[DataMember(Name="conventionalClosingCost")]
		public decimal? ConventionalClosingCost { get; set; }

		[DataMember(Name="conventionalDownPayment")]
		public decimal? ConventionalDownPayment { get; set; }

		[DataMember(Name="conventionalInterestRate")]
		public decimal? ConventionalInterestRate { get; set; }

		[DataMember(Name="conventionalLoanTerm")]
		public int? ConventionalLoanTerm { get; set; }

		[DataMember(Name="conventionalLTV")]
		public decimal? ConventionalLTV { get; set; }

		[DataMember(Name="conventionalMaxYearsMI")]
		public int? ConventionalMaxYearsMI { get; set; }

		[DataMember(Name="conventionalMMI")]
		public decimal? ConventionalMMI { get; set; }

		[DataMember(Name="conventionalMonthlyPayment")]
		public decimal? ConventionalMonthlyPayment { get; set; }

		[DataMember(Name="conventionalMortgageAmount")]
		public decimal? ConventionalMortgageAmount { get; set; }

		[DataMember(Name="conventionalSalesPrice")]
		public decimal? ConventionalSalesPrice { get; set; }

		[DataMember(Name="conventionalUMIP")]
		public decimal? ConventionalUMIP { get; set; }

		[DataMember(Name="dateApprovalExpires")]
		public DateTime? DateApprovalExpires { get; set; }

		[DataMember(Name="dateMortgageApproved")]
		public DateTime? DateMortgageApproved { get; set; }

		[DataMember(Name="detailForOther")]
		public string DetailForOther { get; set; }

		[DataMember(Name="discountPoints")]
		public decimal? DiscountPoints { get; set; }

		[DataMember(Name="dulyAgentAddress")]
		public string DulyAgentAddress { get; set; }

		[DataMember(Name="dulyAgentCity")]
		public string DulyAgentCity { get; set; }

		[DataMember(Name="dulyAgentFunction1")]
		public string DulyAgentFunction1 { get; set; }

		[DataMember(Name="dulyAgentFunction2")]
		public string DulyAgentFunction2 { get; set; }

		[DataMember(Name="dulyAgentName")]
		public string DulyAgentName { get; set; }

		[DataMember(Name="dulyAgentState")]
		public string DulyAgentState { get; set; }

		[DataMember(Name="dwellingCoveredBy")]
		public bool? DwellingCoveredBy { get; set; }

		[DataMember(Name="eem")]
		public LoanContractFhaVaLoanEem Eem { get; set; }

		[DataMember(Name="eligibilityAssessment")]
		public string EligibilityAssessment { get; set; }

		[DataMember(Name="energyEfficientMortgageAmount")]
		public decimal? EnergyEfficientMortgageAmount { get; set; }

		[DataMember(Name="energyEfficientMortgageItems")]
		public List<LoanContractFhaVaLoanEnergyEfficientMortgageItems> EnergyEfficientMortgageItems { get; set; }

		[DataMember(Name="everHadVAHomeLoan")]
		public bool? EverHadVAHomeLoan { get; set; }

		[DataMember(Name="excessContributionAmount")]
		public decimal? ExcessContributionAmount { get; set; }

		[DataMember(Name="existingDebtAmount")]
		public decimal? ExistingDebtAmount { get; set; }

		[DataMember(Name="fHACaseOrderedBy")]
		public string FHACaseOrderedBy { get; set; }

		[DataMember(Name="fHAClosingCost")]
		public decimal? FHAClosingCost { get; set; }

		[DataMember(Name="fHADownPayment")]
		public decimal? FHADownPayment { get; set; }

		[DataMember(Name="fHAInterestRate")]
		public decimal? FHAInterestRate { get; set; }

		[DataMember(Name="fHALoanTerm")]
		public int? FHALoanTerm { get; set; }

		[DataMember(Name="fHALTV")]
		public decimal? FHALTV { get; set; }

		[DataMember(Name="fHAManagementCounselType")]
		public string FHAManagementCounselType { get; set; }

		[DataMember(Name="fHAMaxLoanAmount")]
		public decimal? FHAMaxLoanAmount { get; set; }

		[DataMember(Name="fHAMMI")]
		public decimal? FHAMMI { get; set; }

		[DataMember(Name="fHAMonthlyPayment")]
		public decimal? FHAMonthlyPayment { get; set; }

		[DataMember(Name="fHAMortgageAmount")]
		public decimal? FHAMortgageAmount { get; set; }

		[DataMember(Name="fHAMortgageAmountUMIP")]
		public decimal? FHAMortgageAmountUMIP { get; set; }

		[DataMember(Name="fHASalesPrice")]
		public decimal? FHASalesPrice { get; set; }

		[DataMember(Name="fHAUMIP")]
		public decimal? FHAUMIP { get; set; }

		[DataMember(Name="fHAYearsMonthlyInsurance")]
		public int? FHAYearsMonthlyInsurance { get; set; }

		[DataMember(Name="foreclosedProperty")]
		public bool? ForeclosedProperty { get; set; }

		[DataMember(Name="freddieMacCounselType")]
		public string FreddieMacCounselType { get; set; }

		[DataMember(Name="fundingFeePaidInCash")]
		public decimal? FundingFeePaidInCash { get; set; }

		[DataMember(Name="giftFundsAmount")]
		public decimal? GiftFundsAmount { get; set; }

		[DataMember(Name="haveReceivedLeadPaintPoisoningInfo")]
		public bool? HaveReceivedLeadPaintPoisoningInfo { get; set; }

		[DataMember(Name="hUD1003AddendumApproved")]
		public string HUD1003AddendumApproved { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastRefiDate")]
		public DateTime? LastRefiDate { get; set; }

		[DataMember(Name="lDPGSASearchDate")]
		public DateTime? LDPGSASearchDate { get; set; }

		[DataMember(Name="lDPGSASearchedBy")]
		public string LDPGSASearchedBy { get; set; }

		[DataMember(Name="lenderAddress")]
		public string LenderAddress { get; set; }

		[DataMember(Name="lenderCity")]
		public string LenderCity { get; set; }

		[DataMember(Name="lenderName")]
		public string LenderName { get; set; }

		[DataMember(Name="lenderNMLS")]
		public string LenderNMLS { get; set; }

		[DataMember(Name="lenderPostalCode")]
		public string LenderPostalCode { get; set; }

		[DataMember(Name="lenderRepresentativeName")]
		public string LenderRepresentativeName { get; set; }

		[DataMember(Name="lenderRepresentativePhone")]
		public string LenderRepresentativePhone { get; set; }

		[DataMember(Name="lenderRepresentativeTitle")]
		public string LenderRepresentativeTitle { get; set; }

		[DataMember(Name="lenderState")]
		public string LenderState { get; set; }

		[DataMember(Name="lenderTaxID")]
		public string LenderTaxID { get; set; }

		[DataMember(Name="loanScoreID")]
		public string LoanScoreID { get; set; }

		[DataMember(Name="mIAppliedBy")]
		public string MIAppliedBy { get; set; }

		[DataMember(Name="mIAppliedDate")]
		public DateTime? MIAppliedDate { get; set; }

		[DataMember(Name="mICRetrivedDate")]
		public DateTime? MICRetrivedDate { get; set; }

		[DataMember(Name="minimumDownPayment")]
		public decimal? MinimumDownPayment { get; set; }

		[DataMember(Name="mIP1stDueDate")]
		public DateTime? MIP1stDueDate { get; set; }

		[DataMember(Name="mIP1stToInvestor")]
		public DateTime? MIP1stToInvestor { get; set; }

		[DataMember(Name="mIPRemittedDate")]
		public DateTime? MIPRemittedDate { get; set; }

		[DataMember(Name="mIRejectedDate")]
		public DateTime? MIRejectedDate { get; set; }

		[DataMember(Name="modifiedInterestRate")]
		public decimal? ModifiedInterestRate { get; set; }

		[DataMember(Name="modifiedLoanAmount")]
		public decimal? ModifiedLoanAmount { get; set; }

		[DataMember(Name="modifiedMonthlyPayment")]
		public decimal? ModifiedMonthlyPayment { get; set; }

		[DataMember(Name="modifiedMonthlyPremium")]
		public decimal? ModifiedMonthlyPremium { get; set; }

		[DataMember(Name="modifiedProposedMaturityMonth")]
		public int? ModifiedProposedMaturityMonth { get; set; }

		[DataMember(Name="modifiedProposedMaturityYear")]
		public int? ModifiedProposedMaturityYear { get; set; }

		[DataMember(Name="modifiedTermAnnualPremium")]
		public int? ModifiedTermAnnualPremium { get; set; }

		[DataMember(Name="modifiedUpfrontPremium")]
		public decimal? ModifiedUpfrontPremium { get; set; }

		[DataMember(Name="mortgageeRepresentative")]
		public string MortgageeRepresentative { get; set; }

		[DataMember(Name="mortgageFinancialInterest")]
		public string MortgageFinancialInterest { get; set; }

		[DataMember(Name="nonRealtyAndOtherItems")]
		public decimal? NonRealtyAndOtherItems { get; set; }

		[DataMember(Name="obtainCAIVRSDate")]
		public DateTime? ObtainCAIVRSDate { get; set; }

		[DataMember(Name="occupancy")]
		public string Occupancy { get; set; }

		[DataMember(Name="oldAgencyCaseIdentifier")]
		public string OldAgencyCaseIdentifier { get; set; }

		[DataMember(Name="originalMortgageAmount")]
		public decimal? OriginalMortgageAmount { get; set; }

		[DataMember(Name="otherLiabilitiesMonthlyPayment")]
		public decimal? OtherLiabilitiesMonthlyPayment { get; set; }

		[DataMember(Name="otherLiabilitiesUnpaidBalance")]
		public decimal? OtherLiabilitiesUnpaidBalance { get; set; }

		[DataMember(Name="otherMonthlyShelterExpense")]
		public decimal? OtherMonthlyShelterExpense { get; set; }

		[DataMember(Name="otherTitleDescription")]
		public string OtherTitleDescription { get; set; }

		[DataMember(Name="ownMoreThanFourDwellings")]
		public bool? OwnMoreThanFourDwellings { get; set; }

		[DataMember(Name="ownOrSoldOtherRealEstate")]
		public bool? OwnOrSoldOtherRealEstate { get; set; }

		[DataMember(Name="paidAmount")]
		public decimal? PaidAmount { get; set; }

		[DataMember(Name="premiumMonths")]
		public int? PremiumMonths { get; set; }

		[DataMember(Name="prepaidExpenses")]
		public decimal? PrepaidExpenses { get; set; }

		[DataMember(Name="previousPurchaseDate")]
		public DateTime? PreviousPurchaseDate { get; set; }

		[DataMember(Name="priorEndorsementDate")]
		public DateTime? PriorEndorsementDate { get; set; }

		[DataMember(Name="proposedMaturityMonths")]
		public int? ProposedMaturityMonths { get; set; }

		[DataMember(Name="proposedMaturityYears")]
		public int? ProposedMaturityYears { get; set; }

		[DataMember(Name="purposeOfLoan")]
		public string PurposeOfLoan { get; set; }

		[DataMember(Name="refiAuthorizationBy")]
		public string RefiAuthorizationBy { get; set; }

		[DataMember(Name="refiAuthorizationDate")]
		public DateTime? RefiAuthorizationDate { get; set; }

		[DataMember(Name="salesPrice")]
		public decimal? SalesPrice { get; set; }

		[DataMember(Name="secondMortgageAmount")]
		public decimal? SecondMortgageAmount { get; set; }

		[DataMember(Name="sellerPaidClosingCost")]
		public decimal? SellerPaidClosingCost { get; set; }

		[DataMember(Name="servingTransferedDate")]
		public DateTime? ServingTransferedDate { get; set; }

		[DataMember(Name="specialAssessments")]
		public decimal? SpecialAssessments { get; set; }

		[DataMember(Name="sponsorAgentAddress")]
		public string SponsorAgentAddress { get; set; }

		[DataMember(Name="sponsorAgentCity")]
		public string SponsorAgentCity { get; set; }

		[DataMember(Name="sponsorAgentName")]
		public string SponsorAgentName { get; set; }

		[DataMember(Name="sponsorAgentNMLS")]
		public string SponsorAgentNMLS { get; set; }

		[DataMember(Name="sponsorAgentPostalCode")]
		public string SponsorAgentPostalCode { get; set; }

		[DataMember(Name="sponsorAgentState")]
		public string SponsorAgentState { get; set; }

		[DataMember(Name="sponsorAgentTaxID")]
		public string SponsorAgentTaxID { get; set; }

		[DataMember(Name="sponsoredOriginationsName")]
		public string SponsoredOriginationsName { get; set; }

		[DataMember(Name="sponsoredOriginationsNMLS")]
		public string SponsoredOriginationsNMLS { get; set; }

		[DataMember(Name="sponsoredOriginationsTaxID")]
		public string SponsoredOriginationsTaxID { get; set; }

		[DataMember(Name="sponsorID")]
		public string SponsorID { get; set; }

		[DataMember(Name="titleVestedIn")]
		public string TitleVestedIn { get; set; }

		[DataMember(Name="toBeSold")]
		public bool? ToBeSold { get; set; }

		[DataMember(Name="totalClosingCost")]
		public decimal? TotalClosingCost { get; set; }

		[DataMember(Name="totalScorecardBy")]
		public string TotalScorecardBy { get; set; }

		[DataMember(Name="totalScorecardDate")]
		public DateTime? TotalScorecardDate { get; set; }

		[DataMember(Name="uFMIPRemittanceDueDate")]
		public DateTime? UFMIPRemittanceDueDate { get; set; }

		[DataMember(Name="uFMIPRemittedAmount")]
		public decimal? UFMIPRemittedAmount { get; set; }

		[DataMember(Name="uFMIPRemittedBy")]
		public string UFMIPRemittedBy { get; set; }

		[DataMember(Name="uFMIPRemittedDate")]
		public DateTime? UFMIPRemittedDate { get; set; }

		[DataMember(Name="uFMIPVerificationCode")]
		public string UFMIPVerificationCode { get; set; }

		[DataMember(Name="useDefaultLenderInfo")]
		public bool? UseDefaultLenderInfo { get; set; }

		[DataMember(Name="utilityIncluded")]
		public bool? UtilityIncluded { get; set; }

		[DataMember(Name="validateAddressDate")]
		public DateTime? ValidateAddressDate { get; set; }

		[DataMember(Name="valuation")]
		public string Valuation { get; set; }

	}
}