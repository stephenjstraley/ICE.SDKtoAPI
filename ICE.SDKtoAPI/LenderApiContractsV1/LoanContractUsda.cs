using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUsda
	{
		[DataMember(Name="additionalMemberBaseIncome", EmitDefaultValue=false)]
		public double? AdditionalMemberBaseIncome { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription1", EmitDefaultValue=false)]
		public string AdjustedIncomeCalculationDescription1 { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription2", EmitDefaultValue=false)]
		public string AdjustedIncomeCalculationDescription2 { get; set; }

		[DataMember(Name="adjustedIncomeCalculationDescription3", EmitDefaultValue=false)]
		public string AdjustedIncomeCalculationDescription3 { get; set; }

		[DataMember(Name="advanceAmountToDate", EmitDefaultValue=false)]
		public double? AdvanceAmountToDate { get; set; }

		[DataMember(Name="amountLoanlineCredit", EmitDefaultValue=false)]
		public double? AmountLoanlineCredit { get; set; }

		[DataMember(Name="annualChildCareExpenses", EmitDefaultValue=false)]
		public double? AnnualChildCareExpenses { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription1", EmitDefaultValue=false)]
		public string AnnualIncomeCalculationDescription1 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription2", EmitDefaultValue=false)]
		public string AnnualIncomeCalculationDescription2 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription3", EmitDefaultValue=false)]
		public string AnnualIncomeCalculationDescription3 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription4", EmitDefaultValue=false)]
		public string AnnualIncomeCalculationDescription4 { get; set; }

		[DataMember(Name="annualIncomeCalculationDescription5", EmitDefaultValue=false)]
		public string AnnualIncomeCalculationDescription5 { get; set; }

		[DataMember(Name="annualReviewDate", EmitDefaultValue=false)]
		public DateTime? AnnualReviewDate { get; set; }

		[DataMember(Name="applicationNumber", EmitDefaultValue=false)]
		public string ApplicationNumber { get; set; }

		[DataMember(Name="approvedLenderTaxId", EmitDefaultValue=false)]
		public string ApprovedLenderTaxId { get; set; }

		[DataMember(Name="balanceOwedOnLoan", EmitDefaultValue=false)]
		public double? BalanceOwedOnLoan { get; set; }

		[DataMember(Name="borrowerTotalStableIncome", EmitDefaultValue=false)]
		public double? BorrowerTotalStableIncome { get; set; }

		[DataMember(Name="borrowerTypeCode", EmitDefaultValue=false)]
		public string BorrowerTypeCode { get; set; }

		[DataMember(Name="buydownInterestAssistanceRate", EmitDefaultValue=false)]
		public double? BuydownInterestAssistanceRate { get; set; }

		[DataMember(Name="caseNumberBorrowerId", EmitDefaultValue=false)]
		public string CaseNumberBorrowerId { get; set; }

		[DataMember(Name="caseNumberCo", EmitDefaultValue=false)]
		public string CaseNumberCo { get; set; }

		[DataMember(Name="caseNumberSt", EmitDefaultValue=false)]
		public string CaseNumberSt { get; set; }

		[DataMember(Name="certificationEffectiveDate", EmitDefaultValue=false)]
		public DateTime? CertificationEffectiveDate { get; set; }

		[DataMember(Name="certificationExpirationDate", EmitDefaultValue=false)]
		public DateTime? CertificationExpirationDate { get; set; }

		[DataMember(Name="certifiedLoanIndicator", EmitDefaultValue=false)]
		public bool? CertifiedLoanIndicator { get; set; }

		[DataMember(Name="childCareProviderAddress", EmitDefaultValue=false)]
		public string ChildCareProviderAddress { get; set; }

		[DataMember(Name="childCareProviderCity", EmitDefaultValue=false)]
		public string ChildCareProviderCity { get; set; }

		[DataMember(Name="childCareProviderPhone", EmitDefaultValue=false)]
		public string ChildCareProviderPhone { get; set; }

		[DataMember(Name="childCareProviderProviderName", EmitDefaultValue=false)]
		public string ChildCareProviderProviderName { get; set; }

		[DataMember(Name="childCareProviderState", EmitDefaultValue=false)]
		public string ChildCareProviderState { get; set; }

		[DataMember(Name="childCareProviderZip", EmitDefaultValue=false)]
		public string ChildCareProviderZip { get; set; }

		[DataMember(Name="childCostPerMonth", EmitDefaultValue=false)]
		public double? ChildCostPerMonth { get; set; }

		[DataMember(Name="childCostPerWeek", EmitDefaultValue=false)]
		public double? ChildCostPerWeek { get; set; }

		[DataMember(Name="coborrowerStableBaseIncome", EmitDefaultValue=false)]
		public double? CoborrowerStableBaseIncome { get; set; }

		[DataMember(Name="coborrowerStableBaseIncomeDesc", EmitDefaultValue=false)]
		public string CoborrowerStableBaseIncomeDesc { get; set; }

		[DataMember(Name="coborrowerStableOtherIncome", EmitDefaultValue=false)]
		public double? CoborrowerStableOtherIncome { get; set; }

		[DataMember(Name="coborrowerStableOtherIncomeDesc", EmitDefaultValue=false)]
		public string CoborrowerStableOtherIncomeDesc { get; set; }

		[DataMember(Name="coBorrowerTotalStableIncome", EmitDefaultValue=false)]
		public double? CoBorrowerTotalStableIncome { get; set; }

		[DataMember(Name="dateConfirmedObligationProcessed", EmitDefaultValue=false)]
		public DateTime? DateConfirmedObligationProcessed { get; set; }

		[DataMember(Name="dateLoanNoteGuaranteeIssued", EmitDefaultValue=false)]
		public DateTime? DateLoanNoteGuaranteeIssued { get; set; }

		[DataMember(Name="dateLoanNoteGuaranteeRequestReceived", EmitDefaultValue=false)]
		public DateTime? DateLoanNoteGuaranteeRequestReceived { get; set; }

		[DataMember(Name="dateObligationInGls", EmitDefaultValue=false)]
		public DateTime? DateObligationInGls { get; set; }

		[DataMember(Name="dateVerifiedInUnifi", EmitDefaultValue=false)]
		public DateTime? DateVerifiedInUnifi { get; set; }

		[DataMember(Name="dependentDeduction", EmitDefaultValue=false)]
		public double? DependentDeduction { get; set; }

		[DataMember(Name="disabilityDeduction", EmitDefaultValue=false)]
		public double? DisabilityDeduction { get; set; }

		[DataMember(Name="elderlyHouseholdDeduction", EmitDefaultValue=false)]
		public double? ElderlyHouseholdDeduction { get; set; }

		[DataMember(Name="feeRate", EmitDefaultValue=false)]
		public double? FeeRate { get; set; }

		[DataMember(Name="financedLoanClosingCostDescription", EmitDefaultValue=false)]
		public string FinancedLoanClosingCostDescription { get; set; }

		[DataMember(Name="financedLoanClosingCosts", EmitDefaultValue=false)]
		public double? FinancedLoanClosingCosts { get; set; }

		[DataMember(Name="guaranteeFeeCollected", EmitDefaultValue=false)]
		public double? GuaranteeFeeCollected { get; set; }

		[DataMember(Name="guaranteeFeeOnCommitment", EmitDefaultValue=false)]
		public double? GuaranteeFeeOnCommitment { get; set; }

		[DataMember(Name="guaranteeFeePurposeCodeType", EmitDefaultValue=false)]
		public string GuaranteeFeePurposeCodeType { get; set; }

		[DataMember(Name="guaranteePeriodBeginsDate", EmitDefaultValue=false)]
		public DateTime? GuaranteePeriodBeginsDate { get; set; }

		[DataMember(Name="guaranteePeriodEndsDate", EmitDefaultValue=false)]
		public DateTime? GuaranteePeriodEndsDate { get; set; }

		[DataMember(Name="guaranteeType", EmitDefaultValue=false)]
		public string GuaranteeType { get; set; }

		[DataMember(Name="householdSize", EmitDefaultValue=false)]
		public int? HouseholdSize { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="interestAssistanceCodeType", EmitDefaultValue=false)]
		public string InterestAssistanceCodeType { get; set; }

		[DataMember(Name="interestRateBasedonFannieIndicator", EmitDefaultValue=false)]
		public bool? InterestRateBasedonFannieIndicator { get; set; }

		[DataMember(Name="interestRateCodeType", EmitDefaultValue=false)]
		public string InterestRateCodeType { get; set; }

		[DataMember(Name="interestRateFloatToLoanClosingIndicator", EmitDefaultValue=false)]
		public bool? InterestRateFloatToLoanClosingIndicator { get; set; }

		[DataMember(Name="lackAdequateHeatIndicator", EmitDefaultValue=false)]
		public bool? LackAdequateHeatIndicator { get; set; }

		[DataMember(Name="lenderAuthorizedRepCompany", EmitDefaultValue=false)]
		public string LenderAuthorizedRepCompany { get; set; }

		[DataMember(Name="lenderAuthorizedRepName", EmitDefaultValue=false)]
		public string LenderAuthorizedRepName { get; set; }

		[DataMember(Name="lenderAuthorizedRepTitle", EmitDefaultValue=false)]
		public string LenderAuthorizedRepTitle { get; set; }

		[DataMember(Name="lenderIdNo", EmitDefaultValue=false)]
		public string LenderIdNo { get; set; }

		[DataMember(Name="lenderNoteRateOnGuaranteedPortion", EmitDefaultValue=false)]
		public double? LenderNoteRateOnGuaranteedPortion { get; set; }

		[DataMember(Name="lenderNoteRateOnNonGuaranteedPortion", EmitDefaultValue=false)]
		public double? LenderNoteRateOnNonGuaranteedPortion { get; set; }

		[DataMember(Name="lenderStatusCodeType", EmitDefaultValue=false)]
		public string LenderStatusCodeType { get; set; }

		[DataMember(Name="lenderTypeCode", EmitDefaultValue=false)]
		public string LenderTypeCode { get; set; }

		[DataMember(Name="loanType", EmitDefaultValue=false)]
		public string LoanType { get; set; }

		[DataMember(Name="lockCompletePlumbingIndicator", EmitDefaultValue=false)]
		public bool? LockCompletePlumbingIndicator { get; set; }

		[DataMember(Name="medicalExpenses", EmitDefaultValue=false)]
		public double? MedicalExpenses { get; set; }

		[DataMember(Name="moderateIncomeLimit", EmitDefaultValue=false)]
		public double? ModerateIncomeLimit { get; set; }

		[DataMember(Name="monthlyRepaymentIncome", EmitDefaultValue=false)]
		public double? MonthlyRepaymentIncome { get; set; }

		[DataMember(Name="numberofDependents", EmitDefaultValue=false)]
		public int? NumberofDependents { get; set; }

		[DataMember(Name="numberofPeopleInHousehold", EmitDefaultValue=false)]
		public int? NumberofPeopleInHousehold { get; set; }

		[DataMember(Name="obligationMatchesCommitmentLenderRequestIndicator", EmitDefaultValue=false)]
		public bool? ObligationMatchesCommitmentLenderRequestIndicator { get; set; }

		[DataMember(Name="officialWhoConfirmedGlsUpdated", EmitDefaultValue=false)]
		public string OfficialWhoConfirmedGlsUpdated { get; set; }

		[DataMember(Name="otherIncome", EmitDefaultValue=false)]
		public double? OtherIncome { get; set; }

		[DataMember(Name="otherStableDependableMonthlyIncome", EmitDefaultValue=false)]
		public double? OtherStableDependableMonthlyIncome { get; set; }

		[DataMember(Name="overcrowdedIndicator", EmitDefaultValue=false)]
		public bool? OvercrowdedIndicator { get; set; }

		[DataMember(Name="percentofLoanGuaranteed", EmitDefaultValue=false)]
		public double? PercentofLoanGuaranteed { get; set; }

		[DataMember(Name="periodOperatingLineCreditYearsType", EmitDefaultValue=false)]
		public string PeriodOperatingLineCreditYearsType { get; set; }

		[DataMember(Name="physicallyDeterioratedIndicator", EmitDefaultValue=false)]
		public bool? PhysicallyDeterioratedIndicator { get; set; }

		[DataMember(Name="preparedByName", EmitDefaultValue=false)]
		public string PreparedByName { get; set; }

		[DataMember(Name="preparedByTitle", EmitDefaultValue=false)]
		public string PreparedByTitle { get; set; }

		[DataMember(Name="presentLandloardAddress", EmitDefaultValue=false)]
		public string PresentLandloardAddress { get; set; }

		[DataMember(Name="presentLandloardCity", EmitDefaultValue=false)]
		public string PresentLandloardCity { get; set; }

		[DataMember(Name="presentLandloardName", EmitDefaultValue=false)]
		public string PresentLandloardName { get; set; }

		[DataMember(Name="presentLandloardPhone", EmitDefaultValue=false)]
		public string PresentLandloardPhone { get; set; }

		[DataMember(Name="presentLandloardState", EmitDefaultValue=false)]
		public string PresentLandloardState { get; set; }

		[DataMember(Name="presentLandloardZip", EmitDefaultValue=false)]
		public string PresentLandloardZip { get; set; }

		[DataMember(Name="previousLandloardAddress", EmitDefaultValue=false)]
		public string PreviousLandloardAddress { get; set; }

		[DataMember(Name="previousLandloardCity", EmitDefaultValue=false)]
		public string PreviousLandloardCity { get; set; }

		[DataMember(Name="previousLandloardName", EmitDefaultValue=false)]
		public string PreviousLandloardName { get; set; }

		[DataMember(Name="previousLandloardPhone", EmitDefaultValue=false)]
		public string PreviousLandloardPhone { get; set; }

		[DataMember(Name="previousLandloardState", EmitDefaultValue=false)]
		public string PreviousLandloardState { get; set; }

		[DataMember(Name="previousLandloardZip", EmitDefaultValue=false)]
		public string PreviousLandloardZip { get; set; }

		[DataMember(Name="purchaseOrRefinancedAmount", EmitDefaultValue=false)]
		public double? PurchaseOrRefinancedAmount { get; set; }

		[DataMember(Name="purchaseOrRefinanceDescription", EmitDefaultValue=false)]
		public string PurchaseOrRefinanceDescription { get; set; }

		[DataMember(Name="rdsfhRefinancedLoanIndicatorType", EmitDefaultValue=false)]
		public string RdsfhRefinancedLoanIndicatorType { get; set; }

		[DataMember(Name="refinanceLoanIndicator", EmitDefaultValue=false)]
		public bool? RefinanceLoanIndicator { get; set; }

		[DataMember(Name="refinanceType", EmitDefaultValue=false)]
		public string RefinanceType { get; set; }

		[DataMember(Name="repairOtherAmount", EmitDefaultValue=false)]
		public double? RepairOtherAmount { get; set; }

		[DataMember(Name="repairOtherDescription", EmitDefaultValue=false)]
		public string RepairOtherDescription { get; set; }

		[DataMember(Name="reservationAmountRequested", EmitDefaultValue=false)]
		public double? ReservationAmountRequested { get; set; }

		[DataMember(Name="reserved", EmitDefaultValue=false)]
		public string Reserved { get; set; }

		[DataMember(Name="servicingOfficeName", EmitDefaultValue=false)]
		public string ServicingOfficeName { get; set; }

		[DataMember(Name="sfhglpIndicator", EmitDefaultValue=false)]
		public bool? SfhglpIndicator { get; set; }

		[DataMember(Name="sourceOfFundsType", EmitDefaultValue=false)]
		public string SourceOfFundsType { get; set; }

		[DataMember(Name="stableDependableMonthlyIncome", EmitDefaultValue=false)]
		public double? StableDependableMonthlyIncome { get; set; }

		[DataMember(Name="stableOtherIncomeDesc", EmitDefaultValue=false)]
		public string StableOtherIncomeDesc { get; set; }

		[DataMember(Name="submittingLenderAddress", EmitDefaultValue=false)]
		public string SubmittingLenderAddress { get; set; }

		[DataMember(Name="submittingLenderCity", EmitDefaultValue=false)]
		public string SubmittingLenderCity { get; set; }

		[DataMember(Name="submittingLenderContactFax", EmitDefaultValue=false)]
		public string SubmittingLenderContactFax { get; set; }

		[DataMember(Name="submittingLenderContactName", EmitDefaultValue=false)]
		public string SubmittingLenderContactName { get; set; }

		[DataMember(Name="submittingLenderContactPhone", EmitDefaultValue=false)]
		public string SubmittingLenderContactPhone { get; set; }

		[DataMember(Name="submittingLenderName", EmitDefaultValue=false)]
		public string SubmittingLenderName { get; set; }

		[DataMember(Name="submittingLenderState", EmitDefaultValue=false)]
		public string SubmittingLenderState { get; set; }

		[DataMember(Name="submittingLenderTaxId", EmitDefaultValue=false)]
		public string SubmittingLenderTaxId { get; set; }

		[DataMember(Name="submittingLenderZip", EmitDefaultValue=false)]
		public string SubmittingLenderZip { get; set; }

		[DataMember(Name="termOfBuydown", EmitDefaultValue=false)]
		public int? TermOfBuydown { get; set; }

		[DataMember(Name="thirdPartyOriginator", EmitDefaultValue=false)]
		public string ThirdPartyOriginator { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="totalBorrowerStableBaseIncome", EmitDefaultValue=false)]
		public double? TotalBorrowerStableBaseIncome { get; set; }

		[DataMember(Name="totalBorrowerStableOtherIncome", EmitDefaultValue=false)]
		public double? TotalBorrowerStableOtherIncome { get; set; }

		[DataMember(Name="totalHouseholdDeduction", EmitDefaultValue=false)]
		public double? TotalHouseholdDeduction { get; set; }

		[DataMember(Name="totalRequestAmount", EmitDefaultValue=false)]
		public double? TotalRequestAmount { get; set; }

		[DataMember(Name="tpoTaxId", EmitDefaultValue=false)]
		public string TpoTaxId { get; set; }

		[DataMember(Name="underwritingDecisionBy", EmitDefaultValue=false)]
		public string UnderwritingDecisionBy { get; set; }

		[DataMember(Name="underwritingDecisionDate", EmitDefaultValue=false)]
		public DateTime? UnderwritingDecisionDate { get; set; }

		[DataMember(Name="underwritingDecisionType", EmitDefaultValue=false)]
		public string UnderwritingDecisionType { get; set; }

		[DataMember(Name="usdaHouseholdIncomes", EmitDefaultValue=false)]
		public List<LoanContractUsdaUsdaHouseholdIncomes> UsdaHouseholdIncomes { get; set; }

		[DataMember(Name="verificationCode", EmitDefaultValue=false)]
		public string VerificationCode { get; set; }

	}
}