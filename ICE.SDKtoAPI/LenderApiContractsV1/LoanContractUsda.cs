using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUsda
	{
		[DataMember(Name="additionalMemberBaseIncome")]
		public decimal? AdditionalMemberBaseIncome { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription1")]
		public string AdjustedIncomeCalculationDescription1 { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription2")]
		public string AdjustedIncomeCalculationDescription2 { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription3")]
		public string AdjustedIncomeCalculationDescription3 { get; set; }

		[DataMember(Name="advanceAmountToDate")]
		public decimal? AdvanceAmountToDate { get; set; }

		[DataMember(Name="amountLoanlineCredit")]
		public decimal? AmountLoanlineCredit { get; set; }

		[DataMember(Name="annualChildCareExpenses")]
		public decimal? AnnualChildCareExpenses { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription1")]
		public string AnnualIncomeCalculationDescription1 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription2")]
		public string AnnualIncomeCalculationDescription2 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription3")]
		public string AnnualIncomeCalculationDescription3 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription4")]
		public string AnnualIncomeCalculationDescription4 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription5")]
		public string AnnualIncomeCalculationDescription5 { get; set; }

		[DataMember(Name="annualReviewDate")]
		public DateTime? AnnualReviewDate { get; set; }

		[DataMember(Name="applicationNumber")]
		public string ApplicationNumber { get; set; }

		[DataMember(Name="approvedLenderTaxId")]
		public string ApprovedLenderTaxId { get; set; }

		[DataMember(Name="balanceOwedOnLoan")]
		public decimal? BalanceOwedOnLoan { get; set; }

		[DataMember(Name="borrowerTotalStableIncome")]
		public decimal? BorrowerTotalStableIncome { get; set; }

		[DataMember(Name="borrowerTypeCode")]
		public string BorrowerTypeCode { get; set; }

		[DataMember(Name="buydownInterestAssistanceRate")]
		public decimal? BuydownInterestAssistanceRate { get; set; }

		[DataMember(Name="caseNumberBorrowerId")]
		public string CaseNumberBorrowerId { get; set; }

		[DataMember(Name="caseNumberCo")]
		public string CaseNumberCo { get; set; }

		[DataMember(Name="caseNumberSt")]
		public string CaseNumberSt { get; set; }

		[DataMember(Name="certificationEffectiveDate")]
		public DateTime? CertificationEffectiveDate { get; set; }

		[DataMember(Name="certificationExpirationDate")]
		public DateTime? CertificationExpirationDate { get; set; }

		[DataMember(Name="certifiedLoanIndicator")]
		public bool? CertifiedLoanIndicator { get; set; }

		[DataMember(Name="childCareProviderAddress")]
		public string ChildCareProviderAddress { get; set; }

		[DataMember(Name="childCareProviderCity")]
		public string ChildCareProviderCity { get; set; }

		[DataMember(Name="childCareProviderPhone")]
		public string ChildCareProviderPhone { get; set; }

		[DataMember(Name="childCareProviderProviderName")]
		public string ChildCareProviderProviderName { get; set; }

		[DataMember(Name="childCareProviderState")]
		public string ChildCareProviderState { get; set; }

		[DataMember(Name="childCareProviderZip")]
		public string ChildCareProviderZip { get; set; }

		[DataMember(Name="childCostPerMonth")]
		public decimal? ChildCostPerMonth { get; set; }

		[DataMember(Name="childCostPerWeek")]
		public decimal? ChildCostPerWeek { get; set; }

		[DataMember(Name="coborrowerStableBaseIncome")]
		public decimal? CoborrowerStableBaseIncome { get; set; }

		[DataMember(Name="coborrowerStableBaseIncomeDesc")]
		public string CoborrowerStableBaseIncomeDesc { get; set; }

		[DataMember(Name="coborrowerStableOtherIncome")]
		public decimal? CoborrowerStableOtherIncome { get; set; }

		[DataMember(Name="coborrowerStableOtherIncomeDesc")]
		public string CoborrowerStableOtherIncomeDesc { get; set; }

		[DataMember(Name="coBorrowerTotalStableIncome")]
		public decimal? CoBorrowerTotalStableIncome { get; set; }

		[DataMember(Name="dateConfirmedObligationProcessed")]
		public DateTime? DateConfirmedObligationProcessed { get; set; }

		[DataMember(Name="dateLoanNoteGuaranteeIssued")]
		public DateTime? DateLoanNoteGuaranteeIssued { get; set; }

		[DataMember(Name="dateLoanNoteGuaranteeRequestReceived")]
		public DateTime? DateLoanNoteGuaranteeRequestReceived { get; set; }

		[DataMember(Name="dateObligationInGls")]
		public DateTime? DateObligationInGls { get; set; }

		[DataMember(Name="dateVerifiedInUnifi")]
		public DateTime? DateVerifiedInUnifi { get; set; }

		[DataMember(Name="dependentDeduction")]
		public decimal? DependentDeduction { get; set; }

		[DataMember(Name="disabilityDeduction")]
		public decimal? DisabilityDeduction { get; set; }

		[DataMember(Name="elderlyHouseholdDeduction")]
		public decimal? ElderlyHouseholdDeduction { get; set; }

		[DataMember(Name="feeRate")]
		public decimal? FeeRate { get; set; }

		[DataMember(Name="financedLoanClosingCostDescription")]
		public string FinancedLoanClosingCostDescription { get; set; }

		[DataMember(Name="financedLoanClosingCosts")]
		public decimal? FinancedLoanClosingCosts { get; set; }

		[DataMember(Name="guaranteeFeeCollected")]
		public decimal? GuaranteeFeeCollected { get; set; }

		[DataMember(Name="guaranteeFeeOnCommitment")]
		public decimal? GuaranteeFeeOnCommitment { get; set; }

		[DataMember(Name="guaranteeFeePurposeCodeType")]
		public string GuaranteeFeePurposeCodeType { get; set; }

		[DataMember(Name="guaranteePeriodBeginsDate")]
		public DateTime? GuaranteePeriodBeginsDate { get; set; }

		[DataMember(Name="guaranteePeriodEndsDate")]
		public DateTime? GuaranteePeriodEndsDate { get; set; }

		[DataMember(Name="guaranteeType")]
		public string GuaranteeType { get; set; }

		[DataMember(Name="householdSize")]
		public int? HouseholdSize { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="interestAssistanceCodeType")]
		public string InterestAssistanceCodeType { get; set; }

		[DataMember(Name="interestRateBasedonFannieIndicator")]
		public bool? InterestRateBasedonFannieIndicator { get; set; }

		[DataMember(Name="interestRateCodeType")]
		public string InterestRateCodeType { get; set; }

		[DataMember(Name="interestRateFloatToLoanClosingIndicator")]
		public bool? InterestRateFloatToLoanClosingIndicator { get; set; }

		[DataMember(Name="lackAdequateHeatIndicator")]
		public bool? LackAdequateHeatIndicator { get; set; }

		[DataMember(Name="lenderAuthorizedRepCompany")]
		public string LenderAuthorizedRepCompany { get; set; }

		[DataMember(Name="lenderAuthorizedRepName")]
		public string LenderAuthorizedRepName { get; set; }

		[DataMember(Name="lenderAuthorizedRepTitle")]
		public string LenderAuthorizedRepTitle { get; set; }

		[DataMember(Name="lenderIdNo")]
		public string LenderIdNo { get; set; }

		[DataMember(Name="lenderNoteRateOnGuaranteedPortion")]
		public decimal? LenderNoteRateOnGuaranteedPortion { get; set; }

		[DataMember(Name="lenderNoteRateOnNonGuaranteedPortion")]
		public decimal? LenderNoteRateOnNonGuaranteedPortion { get; set; }

		[DataMember(Name="lenderStatusCodeType")]
		public string LenderStatusCodeType { get; set; }

		[DataMember(Name="lenderTypeCode")]
		public string LenderTypeCode { get; set; }

		[DataMember(Name="loanType")]
		public string LoanType { get; set; }

		[DataMember(Name="lockCompletePlumbingIndicator")]
		public bool? LockCompletePlumbingIndicator { get; set; }

		[DataMember(Name="medicalExpenses")]
		public decimal? MedicalExpenses { get; set; }

		[DataMember(Name="moderateIncomeLimit")]
		public decimal? ModerateIncomeLimit { get; set; }

		[DataMember(Name="monthlyRepaymentIncome")]
		public decimal? MonthlyRepaymentIncome { get; set; }

		[DataMember(Name="numberofDependents")]
		public int? NumberofDependents { get; set; }

		[DataMember(Name="numberofPeopleInHousehold")]
		public int? NumberofPeopleInHousehold { get; set; }

		[DataMember(Name="obligationMatchesCommitmentLenderRequestIndicator")]
		public bool? ObligationMatchesCommitmentLenderRequestIndicator { get; set; }

		[DataMember(Name="officialWhoConfirmedGlsUpdated")]
		public string OfficialWhoConfirmedGlsUpdated { get; set; }

		[DataMember(Name="otherIncome")]
		public decimal? OtherIncome { get; set; }

		[DataMember(Name="otherStableDependableMonthlyIncome")]
		public decimal? OtherStableDependableMonthlyIncome { get; set; }

		[DataMember(Name="overcrowdedIndicator")]
		public bool? OvercrowdedIndicator { get; set; }

		[DataMember(Name="percentofLoanGuaranteed")]
		public decimal? PercentofLoanGuaranteed { get; set; }

		[DataMember(Name="periodOperatingLineCreditYearsType")]
		public string PeriodOperatingLineCreditYearsType { get; set; }

		[DataMember(Name="physicallyDeterioratedIndicator")]
		public bool? PhysicallyDeterioratedIndicator { get; set; }

		[DataMember(Name="preparedByName")]
		public string PreparedByName { get; set; }

		[DataMember(Name="preparedByTitle")]
		public string PreparedByTitle { get; set; }

		[DataMember(Name="presentLandloardAddress")]
		public string PresentLandloardAddress { get; set; }

		[DataMember(Name="presentLandloardCity")]
		public string PresentLandloardCity { get; set; }

		[DataMember(Name="presentLandloardName")]
		public string PresentLandloardName { get; set; }

		[DataMember(Name="presentLandloardPhone")]
		public string PresentLandloardPhone { get; set; }

		[DataMember(Name="presentLandloardState")]
		public string PresentLandloardState { get; set; }

		[DataMember(Name="presentLandloardZip")]
		public string PresentLandloardZip { get; set; }

		[DataMember(Name="previousLandloardAddress")]
		public string PreviousLandloardAddress { get; set; }

		[DataMember(Name="previousLandloardCity")]
		public string PreviousLandloardCity { get; set; }

		[DataMember(Name="previousLandloardName")]
		public string PreviousLandloardName { get; set; }

		[DataMember(Name="previousLandloardPhone")]
		public string PreviousLandloardPhone { get; set; }

		[DataMember(Name="previousLandloardState")]
		public string PreviousLandloardState { get; set; }

		[DataMember(Name="previousLandloardZip")]
		public string PreviousLandloardZip { get; set; }

		[DataMember(Name="purchaseOrRefinancedAmount")]
		public decimal? PurchaseOrRefinancedAmount { get; set; }

		[DataMember(Name="purchaseOrRefinanceDescription")]
		public string PurchaseOrRefinanceDescription { get; set; }

		[DataMember(Name="rdsfhRefinancedLoanIndicatorType")]
		public string RdsfhRefinancedLoanIndicatorType { get; set; }

		[DataMember(Name="refinanceLoanIndicator")]
		public bool? RefinanceLoanIndicator { get; set; }

		[DataMember(Name="refinanceType")]
		public string RefinanceType { get; set; }

		[DataMember(Name="repairOtherAmount")]
		public decimal? RepairOtherAmount { get; set; }

		[DataMember(Name="repairOtherDescription")]
		public string RepairOtherDescription { get; set; }

		[DataMember(Name="reservationAmountRequested")]
		public decimal? ReservationAmountRequested { get; set; }

		[DataMember(Name="reserved")]
		public string Reserved { get; set; }

		[DataMember(Name="servicingOfficeName")]
		public string ServicingOfficeName { get; set; }

		[DataMember(Name="sfhglpIndicator")]
		public bool? SfhglpIndicator { get; set; }

		[DataMember(Name="sourceOfFundsType")]
		public string SourceOfFundsType { get; set; }

		[DataMember(Name="stableDependableMonthlyIncome")]
		public decimal? StableDependableMonthlyIncome { get; set; }

		[DataMember(Name="stableOtherIncomeDesc")]
		public string StableOtherIncomeDesc { get; set; }

		[DataMember(Name="submittingLenderAddress")]
		public string SubmittingLenderAddress { get; set; }

		[DataMember(Name="submittingLenderCity")]
		public string SubmittingLenderCity { get; set; }

		[DataMember(Name="submittingLenderContactFax")]
		public string SubmittingLenderContactFax { get; set; }

		[DataMember(Name="submittingLenderContactName")]
		public string SubmittingLenderContactName { get; set; }

		[DataMember(Name="submittingLenderContactPhone")]
		public string SubmittingLenderContactPhone { get; set; }

		[DataMember(Name="submittingLenderName")]
		public string SubmittingLenderName { get; set; }

		[DataMember(Name="submittingLenderState")]
		public string SubmittingLenderState { get; set; }

		[DataMember(Name="submittingLenderTaxId")]
		public string SubmittingLenderTaxId { get; set; }

		[DataMember(Name="submittingLenderZip")]
		public string SubmittingLenderZip { get; set; }

		[DataMember(Name="termOfBuydown")]
		public int? TermOfBuydown { get; set; }

		[DataMember(Name="thirdPartyOriginator")]
		public string ThirdPartyOriginator { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="totalBorrowerStableBaseIncome")]
		public decimal? TotalBorrowerStableBaseIncome { get; set; }

		[DataMember(Name="totalBorrowerStableOtherIncome")]
		public decimal? TotalBorrowerStableOtherIncome { get; set; }

		[DataMember(Name="totalHouseholdDeduction")]
		public decimal? TotalHouseholdDeduction { get; set; }

		[DataMember(Name="totalRequestAmount")]
		public decimal? TotalRequestAmount { get; set; }

		[DataMember(Name="tpoTaxId")]
		public string TpoTaxId { get; set; }

		[DataMember(Name="underwritingDecisionBy")]
		public string UnderwritingDecisionBy { get; set; }

		[DataMember(Name="underwritingDecisionDate")]
		public DateTime? UnderwritingDecisionDate { get; set; }

		[DataMember(Name="underwritingDecisionType")]
		public string UnderwritingDecisionType { get; set; }

		[DataMember(Name="usdaHouseholdIncomes")]
		public List<LoanContractUsdaUsdaHouseholdIncomes> UsdaHouseholdIncomes { get; set; }

		[DataMember(Name="verificationCode")]
		public string VerificationCode { get; set; }

	}
}