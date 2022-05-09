using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFhaVaLoan
	{
		[DataMember(Name="addendumType", EmitDefaultValue=false)]
		public string AddendumType { get; set; }

		[DataMember(Name="additionalCondition1", EmitDefaultValue=false)]
		public bool? AdditionalCondition1 { get; set; }

		[DataMember(Name="additionalCondition2", EmitDefaultValue=false)]
		public bool? AdditionalCondition2 { get; set; }

		[DataMember(Name="additionalCondition3", EmitDefaultValue=false)]
		public bool? AdditionalCondition3 { get; set; }

		[DataMember(Name="additionalCondition4", EmitDefaultValue=false)]
		public bool? AdditionalCondition4 { get; set; }

		[DataMember(Name="additionalCondition5", EmitDefaultValue=false)]
		public bool? AdditionalCondition5 { get; set; }

		[DataMember(Name="additionalCondition6", EmitDefaultValue=false)]
		public bool? AdditionalCondition6 { get; set; }

		[DataMember(Name="additionalCondition7", EmitDefaultValue=false)]
		public bool? AdditionalCondition7 { get; set; }

		[DataMember(Name="additionalCondition8", EmitDefaultValue=false)]
		public bool? AdditionalCondition8 { get; set; }

		[DataMember(Name="additionalCondition9", EmitDefaultValue=false)]
		public bool? AdditionalCondition9 { get; set; }

		[DataMember(Name="addressValidatedBy", EmitDefaultValue=false)]
		public string AddressValidatedBy { get; set; }

		[DataMember(Name="addressValidationMessage", EmitDefaultValue=false)]
		public string AddressValidationMessage { get; set; }

		[DataMember(Name="allConditionsSatisfied", EmitDefaultValue=false)]
		public bool? AllConditionsSatisfied { get; set; }

		[DataMember(Name="appraisalLoggedDate", EmitDefaultValue=false)]
		public DateTime? AppraisalLoggedDate { get; set; }

		[DataMember(Name="appraisalLookupBy", EmitDefaultValue=false)]
		public string AppraisalLookupBy { get; set; }

		[DataMember(Name="beenInformed", EmitDefaultValue=false)]
		public string BeenInformed { get; set; }

		[DataMember(Name="borrowerCertificationAddress", EmitDefaultValue=false)]
		public string BorrowerCertificationAddress { get; set; }

		[DataMember(Name="borrowerCertificationCity", EmitDefaultValue=false)]
		public string BorrowerCertificationCity { get; set; }

		[DataMember(Name="borrowerCertificationPostalCode", EmitDefaultValue=false)]
		public string BorrowerCertificationPostalCode { get; set; }

		[DataMember(Name="borrowerCertificationState", EmitDefaultValue=false)]
		public string BorrowerCertificationState { get; set; }

		[DataMember(Name="cAIVRSObtainedBy", EmitDefaultValue=false)]
		public string CAIVRSObtainedBy { get; set; }

		[DataMember(Name="caseBinderShippedBy", EmitDefaultValue=false)]
		public string CaseBinderShippedBy { get; set; }

		[DataMember(Name="caseBinderShippedDate", EmitDefaultValue=false)]
		public DateTime? CaseBinderShippedDate { get; set; }

		[DataMember(Name="closingDate", EmitDefaultValue=false)]
		public DateTime? ClosingDate { get; set; }

		[DataMember(Name="condoPudID", EmitDefaultValue=false)]
		public string CondoPudID { get; set; }

		[DataMember(Name="condoPudLookupBy", EmitDefaultValue=false)]
		public string CondoPudLookupBy { get; set; }

		[DataMember(Name="condoPudLookupDate", EmitDefaultValue=false)]
		public DateTime? CondoPudLookupDate { get; set; }

		[DataMember(Name="conventionalClosingCost", EmitDefaultValue=false)]
		public double? ConventionalClosingCost { get; set; }

		[DataMember(Name="conventionalDownPayment", EmitDefaultValue=false)]
		public double? ConventionalDownPayment { get; set; }

		[DataMember(Name="conventionalInterestRate", EmitDefaultValue=false)]
		public double? ConventionalInterestRate { get; set; }

		[DataMember(Name="conventionalLoanTerm", EmitDefaultValue=false)]
		public int? ConventionalLoanTerm { get; set; }

		[DataMember(Name="conventionalLTV", EmitDefaultValue=false)]
		public double? ConventionalLTV { get; set; }

		[DataMember(Name="conventionalMaxYearsMI", EmitDefaultValue=false)]
		public int? ConventionalMaxYearsMI { get; set; }

		[DataMember(Name="conventionalMMI", EmitDefaultValue=false)]
		public double? ConventionalMMI { get; set; }

		[DataMember(Name="conventionalMonthlyPayment", EmitDefaultValue=false)]
		public double? ConventionalMonthlyPayment { get; set; }

		[DataMember(Name="conventionalMortgageAmount", EmitDefaultValue=false)]
		public double? ConventionalMortgageAmount { get; set; }

		[DataMember(Name="conventionalSalesPrice", EmitDefaultValue=false)]
		public double? ConventionalSalesPrice { get; set; }

		[DataMember(Name="conventionalUMIP", EmitDefaultValue=false)]
		public double? ConventionalUMIP { get; set; }

		[DataMember(Name="dateApprovalExpires", EmitDefaultValue=false)]
		public DateTime? DateApprovalExpires { get; set; }

		[DataMember(Name="dateMortgageApproved", EmitDefaultValue=false)]
		public DateTime? DateMortgageApproved { get; set; }

		[DataMember(Name="detailForOther", EmitDefaultValue=false)]
		public string DetailForOther { get; set; }

		[DataMember(Name="discountPoints", EmitDefaultValue=false)]
		public double? DiscountPoints { get; set; }

		[DataMember(Name="dulyAgentAddress", EmitDefaultValue=false)]
		public string DulyAgentAddress { get; set; }

		[DataMember(Name="dulyAgentCity", EmitDefaultValue=false)]
		public string DulyAgentCity { get; set; }

		[DataMember(Name="dulyAgentFunction1", EmitDefaultValue=false)]
		public string DulyAgentFunction1 { get; set; }

		[DataMember(Name="dulyAgentFunction2", EmitDefaultValue=false)]
		public string DulyAgentFunction2 { get; set; }

		[DataMember(Name="dulyAgentName", EmitDefaultValue=false)]
		public string DulyAgentName { get; set; }

		[DataMember(Name="dulyAgentState", EmitDefaultValue=false)]
		public string DulyAgentState { get; set; }

		[DataMember(Name="dwellingCoveredBy", EmitDefaultValue=false)]
		public bool? DwellingCoveredBy { get; set; }

		[DataMember(Name="eem", EmitDefaultValue=false)]
		public LoanContractFhaVaLoanEem Eem { get; set; }

		[DataMember(Name="eligibilityAssessment", EmitDefaultValue=false)]
		public string EligibilityAssessment { get; set; }

		[DataMember(Name="energyEfficientMortgageAmount", EmitDefaultValue=false)]
		public double? EnergyEfficientMortgageAmount { get; set; }

		[DataMember(Name="energyEfficientMortgageItems", EmitDefaultValue=false)]
		public List<LoanContractFhaVaLoanEnergyEfficientMortgageItems> EnergyEfficientMortgageItems { get; set; }

		[DataMember(Name="everHadVAHomeLoan", EmitDefaultValue=false)]
		public bool? EverHadVAHomeLoan { get; set; }

		[DataMember(Name="excessContributionAmount", EmitDefaultValue=false)]
		public double? ExcessContributionAmount { get; set; }

		[DataMember(Name="existingDebtAmount", EmitDefaultValue=false)]
		public double? ExistingDebtAmount { get; set; }

		[DataMember(Name="fHACaseOrderedBy", EmitDefaultValue=false)]
		public string FHACaseOrderedBy { get; set; }

		[DataMember(Name="fHAClosingCost", EmitDefaultValue=false)]
		public double? FHAClosingCost { get; set; }

		[DataMember(Name="fHADownPayment", EmitDefaultValue=false)]
		public double? FHADownPayment { get; set; }

		[DataMember(Name="fHAInterestRate", EmitDefaultValue=false)]
		public double? FHAInterestRate { get; set; }

		[DataMember(Name="fHALoanTerm", EmitDefaultValue=false)]
		public int? FHALoanTerm { get; set; }

		[DataMember(Name="fHALTV", EmitDefaultValue=false)]
		public double? FHALTV { get; set; }

		[DataMember(Name="fHAManagementCounselType", EmitDefaultValue=false)]
		public string FHAManagementCounselType { get; set; }

		[DataMember(Name="fHAMaxLoanAmount", EmitDefaultValue=false)]
		public double? FHAMaxLoanAmount { get; set; }

		[DataMember(Name="fHAMMI", EmitDefaultValue=false)]
		public double? FHAMMI { get; set; }

		[DataMember(Name="fHAMonthlyPayment", EmitDefaultValue=false)]
		public double? FHAMonthlyPayment { get; set; }

		[DataMember(Name="fHAMortgageAmount", EmitDefaultValue=false)]
		public double? FHAMortgageAmount { get; set; }

		[DataMember(Name="fHAMortgageAmountUMIP", EmitDefaultValue=false)]
		public double? FHAMortgageAmountUMIP { get; set; }

		[DataMember(Name="fHASalesPrice", EmitDefaultValue=false)]
		public double? FHASalesPrice { get; set; }

		[DataMember(Name="fHAUMIP", EmitDefaultValue=false)]
		public double? FHAUMIP { get; set; }

		[DataMember(Name="fHAYearsMonthlyInsurance", EmitDefaultValue=false)]
		public int? FHAYearsMonthlyInsurance { get; set; }

		[DataMember(Name="foreclosedProperty", EmitDefaultValue=false)]
		public bool? ForeclosedProperty { get; set; }

		[DataMember(Name="freddieMacCounselType", EmitDefaultValue=false)]
		public string FreddieMacCounselType { get; set; }

		[DataMember(Name="fundingFeePaidInCash", EmitDefaultValue=false)]
		public double? FundingFeePaidInCash { get; set; }

		[DataMember(Name="giftFundsAmount", EmitDefaultValue=false)]
		public double? GiftFundsAmount { get; set; }

		[DataMember(Name="haveReceivedLeadPaintPoisoningInfo", EmitDefaultValue=false)]
		public bool? HaveReceivedLeadPaintPoisoningInfo { get; set; }

		[DataMember(Name="hUD1003AddendumApproved", EmitDefaultValue=false)]
		public string HUD1003AddendumApproved { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastRefiDate", EmitDefaultValue=false)]
		public DateTime? LastRefiDate { get; set; }

		[DataMember(Name="lDPGSASearchDate", EmitDefaultValue=false)]
		public DateTime? LDPGSASearchDate { get; set; }

		[DataMember(Name="lDPGSASearchedBy", EmitDefaultValue=false)]
		public string LDPGSASearchedBy { get; set; }

		[DataMember(Name="lenderAddress", EmitDefaultValue=false)]
		public string LenderAddress { get; set; }

		[DataMember(Name="lenderCity", EmitDefaultValue=false)]
		public string LenderCity { get; set; }

		[DataMember(Name="lenderName", EmitDefaultValue=false)]
		public string LenderName { get; set; }

		[DataMember(Name="lenderNMLS", EmitDefaultValue=false)]
		public string LenderNMLS { get; set; }

		[DataMember(Name="lenderPostalCode", EmitDefaultValue=false)]
		public string LenderPostalCode { get; set; }

		[DataMember(Name="lenderRepresentativeName", EmitDefaultValue=false)]
		public string LenderRepresentativeName { get; set; }

		[DataMember(Name="lenderRepresentativePhone", EmitDefaultValue=false)]
		public string LenderRepresentativePhone { get; set; }

		[DataMember(Name="lenderRepresentativeTitle", EmitDefaultValue=false)]
		public string LenderRepresentativeTitle { get; set; }

		[DataMember(Name="lenderState", EmitDefaultValue=false)]
		public string LenderState { get; set; }

		[DataMember(Name="lenderTaxID", EmitDefaultValue=false)]
		public string LenderTaxID { get; set; }

		[DataMember(Name="loanScoreID", EmitDefaultValue=false)]
		public string LoanScoreID { get; set; }

		[DataMember(Name="mIAppliedBy", EmitDefaultValue=false)]
		public string MIAppliedBy { get; set; }

		[DataMember(Name="mIAppliedDate", EmitDefaultValue=false)]
		public DateTime? MIAppliedDate { get; set; }

		[DataMember(Name="mICRetrivedDate", EmitDefaultValue=false)]
		public DateTime? MICRetrivedDate { get; set; }

		[DataMember(Name="minimumDownPayment", EmitDefaultValue=false)]
		public double? MinimumDownPayment { get; set; }

		[DataMember(Name="mIP1stDueDate", EmitDefaultValue=false)]
		public DateTime? MIP1stDueDate { get; set; }

		[DataMember(Name="mIP1stToInvestor", EmitDefaultValue=false)]
		public DateTime? MIP1stToInvestor { get; set; }

		[DataMember(Name="mIPRemittedDate", EmitDefaultValue=false)]
		public DateTime? MIPRemittedDate { get; set; }

		[DataMember(Name="mIRejectedDate", EmitDefaultValue=false)]
		public DateTime? MIRejectedDate { get; set; }

		[DataMember(Name="modifiedInterestRate", EmitDefaultValue=false)]
		public double? ModifiedInterestRate { get; set; }

		[DataMember(Name="modifiedLoanAmount", EmitDefaultValue=false)]
		public double? ModifiedLoanAmount { get; set; }

		[DataMember(Name="modifiedMonthlyPayment", EmitDefaultValue=false)]
		public double? ModifiedMonthlyPayment { get; set; }

		[DataMember(Name="modifiedMonthlyPremium", EmitDefaultValue=false)]
		public double? ModifiedMonthlyPremium { get; set; }

		[DataMember(Name="modifiedProposedMaturityMonth", EmitDefaultValue=false)]
		public int? ModifiedProposedMaturityMonth { get; set; }

		[DataMember(Name="modifiedProposedMaturityYear", EmitDefaultValue=false)]
		public int? ModifiedProposedMaturityYear { get; set; }

		[DataMember(Name="modifiedTermAnnualPremium", EmitDefaultValue=false)]
		public int? ModifiedTermAnnualPremium { get; set; }

		[DataMember(Name="modifiedUpfrontPremium", EmitDefaultValue=false)]
		public double? ModifiedUpfrontPremium { get; set; }

		[DataMember(Name="mortgageeRepresentative", EmitDefaultValue=false)]
		public string MortgageeRepresentative { get; set; }

		[DataMember(Name="mortgageFinancialInterest", EmitDefaultValue=false)]
		public string MortgageFinancialInterest { get; set; }

		[DataMember(Name="nonRealtyAndOtherItems", EmitDefaultValue=false)]
		public double? NonRealtyAndOtherItems { get; set; }

		[DataMember(Name="obtainCAIVRSDate", EmitDefaultValue=false)]
		public DateTime? ObtainCAIVRSDate { get; set; }

		[DataMember(Name="occupancy", EmitDefaultValue=false)]
		public string Occupancy { get; set; }

		[DataMember(Name="oldAgencyCaseIdentifier", EmitDefaultValue=false)]
		public string OldAgencyCaseIdentifier { get; set; }

		[DataMember(Name="originalMortgageAmount", EmitDefaultValue=false)]
		public double? OriginalMortgageAmount { get; set; }

		[DataMember(Name="otherLiabilitiesMonthlyPayment", EmitDefaultValue=false)]
		public double? OtherLiabilitiesMonthlyPayment { get; set; }

		[DataMember(Name="otherLiabilitiesUnpaidBalance", EmitDefaultValue=false)]
		public double? OtherLiabilitiesUnpaidBalance { get; set; }

		[DataMember(Name="otherMonthlyShelterExpense", EmitDefaultValue=false)]
		public double? OtherMonthlyShelterExpense { get; set; }

		[DataMember(Name="otherTitleDescription", EmitDefaultValue=false)]
		public string OtherTitleDescription { get; set; }

		[DataMember(Name="ownMoreThanFourDwellings", EmitDefaultValue=false)]
		public bool? OwnMoreThanFourDwellings { get; set; }

		[DataMember(Name="ownOrSoldOtherRealEstate", EmitDefaultValue=false)]
		public bool? OwnOrSoldOtherRealEstate { get; set; }

		[DataMember(Name="paidAmount", EmitDefaultValue=false)]
		public double? PaidAmount { get; set; }

		[DataMember(Name="premiumMonths", EmitDefaultValue=false)]
		public int? PremiumMonths { get; set; }

		[DataMember(Name="prepaidExpenses", EmitDefaultValue=false)]
		public double? PrepaidExpenses { get; set; }

		[DataMember(Name="previousPurchaseDate", EmitDefaultValue=false)]
		public DateTime? PreviousPurchaseDate { get; set; }

		[DataMember(Name="priorEndorsementDate", EmitDefaultValue=false)]
		public DateTime? PriorEndorsementDate { get; set; }

		[DataMember(Name="proposedMaturityMonths", EmitDefaultValue=false)]
		public int? ProposedMaturityMonths { get; set; }

		[DataMember(Name="proposedMaturityYears", EmitDefaultValue=false)]
		public int? ProposedMaturityYears { get; set; }

		[DataMember(Name="purposeOfLoan", EmitDefaultValue=false)]
		public string PurposeOfLoan { get; set; }

		[DataMember(Name="refiAuthorizationBy", EmitDefaultValue=false)]
		public string RefiAuthorizationBy { get; set; }

		[DataMember(Name="refiAuthorizationDate", EmitDefaultValue=false)]
		public DateTime? RefiAuthorizationDate { get; set; }

		[DataMember(Name="salesPrice", EmitDefaultValue=false)]
		public double? SalesPrice { get; set; }

		[DataMember(Name="secondMortgageAmount", EmitDefaultValue=false)]
		public double? SecondMortgageAmount { get; set; }

		[DataMember(Name="sellerPaidClosingCost", EmitDefaultValue=false)]
		public double? SellerPaidClosingCost { get; set; }

		[DataMember(Name="servingTransferedDate", EmitDefaultValue=false)]
		public DateTime? ServingTransferedDate { get; set; }

		[DataMember(Name="specialAssessments", EmitDefaultValue=false)]
		public double? SpecialAssessments { get; set; }

		[DataMember(Name="sponsorAgentAddress", EmitDefaultValue=false)]
		public string SponsorAgentAddress { get; set; }

		[DataMember(Name="sponsorAgentCity", EmitDefaultValue=false)]
		public string SponsorAgentCity { get; set; }

		[DataMember(Name="sponsorAgentName", EmitDefaultValue=false)]
		public string SponsorAgentName { get; set; }

		[DataMember(Name="sponsorAgentNMLS", EmitDefaultValue=false)]
		public string SponsorAgentNMLS { get; set; }

		[DataMember(Name="sponsorAgentPostalCode", EmitDefaultValue=false)]
		public string SponsorAgentPostalCode { get; set; }

		[DataMember(Name="sponsorAgentState", EmitDefaultValue=false)]
		public string SponsorAgentState { get; set; }

		[DataMember(Name="sponsorAgentTaxID", EmitDefaultValue=false)]
		public string SponsorAgentTaxID { get; set; }

		[DataMember(Name="sponsoredOriginationsName", EmitDefaultValue=false)]
		public string SponsoredOriginationsName { get; set; }

		[DataMember(Name="sponsoredOriginationsNMLS", EmitDefaultValue=false)]
		public string SponsoredOriginationsNMLS { get; set; }

		[DataMember(Name="sponsoredOriginationsTaxID", EmitDefaultValue=false)]
		public string SponsoredOriginationsTaxID { get; set; }

		[DataMember(Name="sponsorID", EmitDefaultValue=false)]
		public string SponsorID { get; set; }

		[DataMember(Name="titleVestedIn", EmitDefaultValue=false)]
		public string TitleVestedIn { get; set; }

		[DataMember(Name="toBeSold", EmitDefaultValue=false)]
		public bool? ToBeSold { get; set; }

		[DataMember(Name="totalClosingCost", EmitDefaultValue=false)]
		public double? TotalClosingCost { get; set; }

		[DataMember(Name="totalScorecardBy", EmitDefaultValue=false)]
		public string TotalScorecardBy { get; set; }

		[DataMember(Name="totalScorecardDate", EmitDefaultValue=false)]
		public DateTime? TotalScorecardDate { get; set; }

		[DataMember(Name="uFMIPRemittanceDueDate", EmitDefaultValue=false)]
		public DateTime? UFMIPRemittanceDueDate { get; set; }

		[DataMember(Name="uFMIPRemittedAmount", EmitDefaultValue=false)]
		public double? UFMIPRemittedAmount { get; set; }

		[DataMember(Name="uFMIPRemittedBy", EmitDefaultValue=false)]
		public string UFMIPRemittedBy { get; set; }

		[DataMember(Name="uFMIPRemittedDate", EmitDefaultValue=false)]
		public DateTime? UFMIPRemittedDate { get; set; }

		[DataMember(Name="uFMIPVerificationCode", EmitDefaultValue=false)]
		public string UFMIPVerificationCode { get; set; }

		[DataMember(Name="useDefaultLenderInfo", EmitDefaultValue=false)]
		public bool? UseDefaultLenderInfo { get; set; }

		[DataMember(Name="utilityIncluded", EmitDefaultValue=false)]
		public bool? UtilityIncluded { get; set; }

		[DataMember(Name="validateAddressDate", EmitDefaultValue=false)]
		public DateTime? ValidateAddressDate { get; set; }

		[DataMember(Name="valuation", EmitDefaultValue=false)]
		public string Valuation { get; set; }

	}
}