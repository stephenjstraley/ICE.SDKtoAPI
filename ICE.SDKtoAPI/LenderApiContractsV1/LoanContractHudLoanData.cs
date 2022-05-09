using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHudLoanData
	{
		[DataMember(Name="actualCashInvRequired", EmitDefaultValue=false)]
		public double? ActualCashInvRequired { get; set; }

		[DataMember(Name="adjustedMaxMtgAmount", EmitDefaultValue=false)]
		public double? AdjustedMaxMtgAmount { get; set; }

		[DataMember(Name="afterImprovedValue", EmitDefaultValue=false)]
		public double? AfterImprovedValue { get; set; }

		[DataMember(Name="afterImprovedValueAfter20Percent", EmitDefaultValue=false)]
		public double? AfterImprovedValueAfter20Percent { get; set; }

		[DataMember(Name="allowableEnergyImprovements", EmitDefaultValue=false)]
		public double? AllowableEnergyImprovements { get; set; }

		[DataMember(Name="appropriateLTVFactor", EmitDefaultValue=false)]
		public double? AppropriateLTVFactor { get; set; }

		[DataMember(Name="architecturalEngineeringFee", EmitDefaultValue=false)]
		public double? ArchitecturalEngineeringFee { get; set; }

		[DataMember(Name="asIsValue", EmitDefaultValue=false)]
		public double? AsIsValue { get; set; }

		[DataMember(Name="baseMortgageAmountFrom3COr3D", EmitDefaultValue=false)]
		public double? BaseMortgageAmountFrom3COr3D { get; set; }

		[DataMember(Name="borrowerAcknowledgement", EmitDefaultValue=false)]
		public string BorrowerAcknowledgement { get; set; }

		[DataMember(Name="borrowerEstimatedProfit1", EmitDefaultValue=false)]
		public double? BorrowerEstimatedProfit1 { get; set; }

		[DataMember(Name="borrowerEstimatedProfit2", EmitDefaultValue=false)]
		public double? BorrowerEstimatedProfit2 { get; set; }

		[DataMember(Name="borrowerPaidClosingCosts", EmitDefaultValue=false)]
		public double? BorrowerPaidClosingCosts { get; set; }

		[DataMember(Name="borrowerRequiredInvestment", EmitDefaultValue=false)]
		public double? BorrowerRequiredInvestment { get; set; }

		[DataMember(Name="borrowersOwnFundsforContingencyReserves", EmitDefaultValue=false)]
		public double? BorrowersOwnFundsforContingencyReserves { get; set; }

		[DataMember(Name="buildingOnOwnLand", EmitDefaultValue=false)]
		public bool? BuildingOnOwnLand { get; set; }

		[DataMember(Name="caseAssignedDate", EmitDefaultValue=false)]
		public DateTime? CaseAssignedDate { get; set; }

		[DataMember(Name="caseLTV", EmitDefaultValue=false)]
		public double? CaseLTV { get; set; }

		[DataMember(Name="childSupportBalance", EmitDefaultValue=false)]
		public double? ChildSupportBalance { get; set; }

		[DataMember(Name="cHUMSForAppraisal", EmitDefaultValue=false)]
		public string CHUMSForAppraisal { get; set; }

		[DataMember(Name="commitmentMaximumMortgageAmount", EmitDefaultValue=false)]
		public double? CommitmentMaximumMortgageAmount { get; set; }

		[DataMember(Name="commitmentStage", EmitDefaultValue=false)]
		public string CommitmentStage { get; set; }

		[DataMember(Name="constructionRepairsRehabilitationCosts", EmitDefaultValue=false)]
		public double? ConstructionRepairsRehabilitationCosts { get; set; }

		[DataMember(Name="contingencyReserveCostsAmount", EmitDefaultValue=false)]
		public double? ContingencyReserveCostsAmount { get; set; }

		[DataMember(Name="contingencyReserveCostsPercent", EmitDefaultValue=false)]
		public double? ContingencyReserveCostsPercent { get; set; }

		[DataMember(Name="contractSalesPrice", EmitDefaultValue=false)]
		public double? ContractSalesPrice { get; set; }

		[DataMember(Name="criteriaForAppropriateLTVFactor", EmitDefaultValue=false)]
		public string CriteriaForAppropriateLTVFactor { get; set; }

		[DataMember(Name="dealerContractorAddress", EmitDefaultValue=false)]
		public string DealerContractorAddress { get; set; }

		[DataMember(Name="dealerContractorCity", EmitDefaultValue=false)]
		public string DealerContractorCity { get; set; }

		[DataMember(Name="dealerContractorName", EmitDefaultValue=false)]
		public string DealerContractorName { get; set; }

		[DataMember(Name="dealerContractorPostalCode", EmitDefaultValue=false)]
		public string DealerContractorPostalCode { get; set; }

		[DataMember(Name="dealerContractorState", EmitDefaultValue=false)]
		public string DealerContractorState { get; set; }

		[DataMember(Name="discountPointsAmount", EmitDefaultValue=false)]
		public double? DiscountPointsAmount { get; set; }

		[DataMember(Name="discountPointsPercent", EmitDefaultValue=false)]
		public double? DiscountPointsPercent { get; set; }

		[DataMember(Name="eEMIndicator", EmitDefaultValue=false)]
		public bool? EEMIndicator { get; set; }

		[DataMember(Name="energyEfficientMortgageAmount", EmitDefaultValue=false)]
		public double? EnergyEfficientMortgageAmount { get; set; }

		[DataMember(Name="escrowCommitment", EmitDefaultValue=false)]
		public string EscrowCommitment { get; set; }

		[DataMember(Name="escrowShortages", EmitDefaultValue=false)]
		public double? EscrowShortages { get; set; }

		[DataMember(Name="existing203KDebtTotal", EmitDefaultValue=false)]
		public double? Existing203KDebtTotal { get; set; }

		[DataMember(Name="existingDebt", EmitDefaultValue=false)]
		public bool? ExistingDebt { get; set; }

		[DataMember(Name="existingDebtPlusRehabCosts", EmitDefaultValue=false)]
		public double? ExistingDebtPlusRehabCosts { get; set; }

		[DataMember(Name="existingDebtPlusRehabCostsPlusNewLoanFees", EmitDefaultValue=false)]
		public double? ExistingDebtPlusRehabCostsPlusNewLoanFees { get; set; }

		[DataMember(Name="feasibilityStudyWhenNecessary", EmitDefaultValue=false)]
		public double? FeasibilityStudyWhenNecessary { get; set; }

		[DataMember(Name="feesAssociatedWithNewLoan", EmitDefaultValue=false)]
		public double? FeesAssociatedWithNewLoan { get; set; }

		[DataMember(Name="fHA203kB10SubTotal", EmitDefaultValue=false)]
		public double? FHA203kB10SubTotal { get; set; }

		[DataMember(Name="fHA203kRemarks", EmitDefaultValue=false)]
		public string FHA203kRemarks { get; set; }

		[DataMember(Name="fHAStreamlineType", EmitDefaultValue=false)]
		public string FHAStreamlineType { get; set; }

		[DataMember(Name="finalBaseMortgageAmount", EmitDefaultValue=false)]
		public double? FinalBaseMortgageAmount { get; set; }

		[DataMember(Name="financeableMortgageFeesIfCharged", EmitDefaultValue=false)]
		public double? FinanceableMortgageFeesIfCharged { get; set; }

		[DataMember(Name="haveOtherPendingApplicationForFHA", EmitDefaultValue=false)]
		public bool? HaveOtherPendingApplicationForFHA { get; set; }

		[DataMember(Name="hUDOwned", EmitDefaultValue=false)]
		public bool? HUDOwned { get; set; }

		[DataMember(Name="hUDREOIndicator", EmitDefaultValue=false)]
		public bool? HUDREOIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="independentConsultantFee", EmitDefaultValue=false)]
		public double? IndependentConsultantFee { get; set; }

		[DataMember(Name="initialBaseMortgageAmountPlusEEMImprovementAmount", EmitDefaultValue=false)]
		public double? InitialBaseMortgageAmountPlusEEMImprovementAmount { get; set; }

		[DataMember(Name="initialDrawAtClosingArchitecturalorEngineeringFees", EmitDefaultValue=false)]
		public double? InitialDrawAtClosingArchitecturalorEngineeringFees { get; set; }

		[DataMember(Name="initialDrawAtClosingConsultantFees", EmitDefaultValue=false)]
		public double? InitialDrawAtClosingConsultantFees { get; set; }

		[DataMember(Name="initialDrawAtClosingPermitFees", EmitDefaultValue=false)]
		public double? InitialDrawAtClosingPermitFees { get; set; }

		[DataMember(Name="initialDrawAtClosingTotal", EmitDefaultValue=false)]
		public double? InitialDrawAtClosingTotal { get; set; }

		[DataMember(Name="inspectionFeeAmount", EmitDefaultValue=false)]
		public double? InspectionFeeAmount { get; set; }

		[DataMember(Name="inspectionFeesDuringRehabilitation", EmitDefaultValue=false)]
		public double? InspectionFeesDuringRehabilitation { get; set; }

		[DataMember(Name="inspectionFeeTimes", EmitDefaultValue=false)]
		public int? InspectionFeeTimes { get; set; }

		[DataMember(Name="interestDueonExistingMortgage", EmitDefaultValue=false)]
		public double? InterestDueonExistingMortgage { get; set; }

		[DataMember(Name="lateCharges", EmitDefaultValue=false)]
		public double? LateCharges { get; set; }

		[DataMember(Name="lDPGSAForBorrower", EmitDefaultValue=false)]
		public bool? LDPGSAForBorrower { get; set; }

		[DataMember(Name="lDPGSAForCoBorrower", EmitDefaultValue=false)]
		public bool? LDPGSAForCoBorrower { get; set; }

		[DataMember(Name="leasedFromSomeoneElse", EmitDefaultValue=false)]
		public bool? LeasedFromSomeoneElse { get; set; }

		[DataMember(Name="leaseExpiradionDate", EmitDefaultValue=false)]
		public DateTime? LeaseExpiradionDate { get; set; }

		[DataMember(Name="leaseMonthlyPayment", EmitDefaultValue=false)]
		public double? LeaseMonthlyPayment { get; set; }

		[DataMember(Name="lessAllowableDownpayment", EmitDefaultValue=false)]
		public double? LessAllowableDownpayment { get; set; }

		[DataMember(Name="lesserOf3AOr3B", EmitDefaultValue=false)]
		public double? LesserOf3AOr3B { get; set; }

		[DataMember(Name="lesserOf3AOr3BMultiply3F", EmitDefaultValue=false)]
		public double? LesserOf3AOr3BMultiply3F { get; set; }

		[DataMember(Name="lesserOfMaximumFinanceableSolarOrWindEnergyAmount", EmitDefaultValue=false)]
		public double? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get; set; }

		[DataMember(Name="lesserOfSalesPrice", EmitDefaultValue=false)]
		public double? LesserOfSalesPrice { get; set; }

		[DataMember(Name="lesserOfSumAmount", EmitDefaultValue=false)]
		public double? LesserOfSumAmount { get; set; }

		[DataMember(Name="lesserOfSumAsIs", EmitDefaultValue=false)]
		public double? LesserOfSumAsIs { get; set; }

		[DataMember(Name="lesserOfSumPercent", EmitDefaultValue=false)]
		public double? LesserOfSumPercent { get; set; }

		[DataMember(Name="lessLeadBasedPaintCredit", EmitDefaultValue=false)]
		public double? LessLeadBasedPaintCredit { get; set; }

		[DataMember(Name="limitedProgram", EmitDefaultValue=false)]
		public bool? LimitedProgram { get; set; }

		[DataMember(Name="loanFor203KIndicator", EmitDefaultValue=false)]
		public bool? LoanFor203KIndicator { get; set; }

		[DataMember(Name="loanPurpose", EmitDefaultValue=false)]
		public string LoanPurpose { get; set; }

		[DataMember(Name="materialCostsOrderedPrepaidByBorrowerContractor", EmitDefaultValue=false)]
		public double? MaterialCostsOrderedPrepaidByBorrowerContractor { get; set; }

		[DataMember(Name="materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent", EmitDefaultValue=false)]
		public double? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get; set; }

		[DataMember(Name="maximumMortgageWithUFMIP", EmitDefaultValue=false)]
		public double? MaximumMortgageWithUFMIP { get; set; }

		[DataMember(Name="mIPDueOnExistingMortgage", EmitDefaultValue=false)]
		public double? MIPDueOnExistingMortgage { get; set; }

		[DataMember(Name="mIPLTV", EmitDefaultValue=false)]
		public double? MIPLTV { get; set; }

		[DataMember(Name="mtgOrDeedOfTrusOnProperty", EmitDefaultValue=false)]
		public bool? MtgOrDeedOfTrusOnProperty { get; set; }

		[DataMember(Name="mtgPaymentEscrowedAmount", EmitDefaultValue=false)]
		public double? MtgPaymentEscrowedAmount { get; set; }

		[DataMember(Name="mtgPaymentEscrowedTimes", EmitDefaultValue=false)]
		public int? MtgPaymentEscrowedTimes { get; set; }

		[DataMember(Name="nationwideMortgageLimit", EmitDefaultValue=false)]
		public double? NationwideMortgageLimit { get; set; }

		[DataMember(Name="nationwideMortgageLimitAfter120Percent", EmitDefaultValue=false)]
		public double? NationwideMortgageLimitAfter120Percent { get; set; }

		[DataMember(Name="newResidential", EmitDefaultValue=false)]
		public bool? NewResidential { get; set; }

		[DataMember(Name="nonresidentialTypeOfUse", EmitDefaultValue=false)]
		public string NonresidentialTypeOfUse { get; set; }

		[DataMember(Name="numberOfHistoricUnits", EmitDefaultValue=false)]
		public int? NumberOfHistoricUnits { get; set; }

		[DataMember(Name="numberOfMultifamilyUnits", EmitDefaultValue=false)]
		public int? NumberOfMultifamilyUnits { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

		[DataMember(Name="ownedByBorrower", EmitDefaultValue=false)]
		public bool? OwnedByBorrower { get; set; }

		[DataMember(Name="percentAfterImprovedValue", EmitDefaultValue=false)]
		public double? PercentAfterImprovedValue { get; set; }

		[DataMember(Name="permitsAndOtherFee", EmitDefaultValue=false)]
		public double? PermitsAndOtherFee { get; set; }

		[DataMember(Name="planReviewerFeeAddition", EmitDefaultValue=false)]
		public double? PlanReviewerFeeAddition { get; set; }

		[DataMember(Name="planReviewerFeeAmount", EmitDefaultValue=false)]
		public double? PlanReviewerFeeAmount { get; set; }

		[DataMember(Name="planReviewerFeeMiles", EmitDefaultValue=false)]
		public int? PlanReviewerFeeMiles { get; set; }

		[DataMember(Name="prepaymentPenalties", EmitDefaultValue=false)]
		public double? PrepaymentPenalties { get; set; }

		[DataMember(Name="propertyOwnerAddress", EmitDefaultValue=false)]
		public string PropertyOwnerAddress { get; set; }

		[DataMember(Name="propertyOwnerCity", EmitDefaultValue=false)]
		public string PropertyOwnerCity { get; set; }

		[DataMember(Name="propertyOwnerName", EmitDefaultValue=false)]
		public string PropertyOwnerName { get; set; }

		[DataMember(Name="propertyOwnerPostalCode", EmitDefaultValue=false)]
		public string PropertyOwnerPostalCode { get; set; }

		[DataMember(Name="propertyOwnerState", EmitDefaultValue=false)]
		public string PropertyOwnerState { get; set; }

		[DataMember(Name="propertyToBeImproved", EmitDefaultValue=false)]
		public string PropertyToBeImproved { get; set; }

		[DataMember(Name="propertyType", EmitDefaultValue=false)]
		public string PropertyType { get; set; }

		[DataMember(Name="purchaseDate", EmitDefaultValue=false)]
		public DateTime? PurchaseDate { get; set; }

		[DataMember(Name="purchasedOnContract", EmitDefaultValue=false)]
		public bool? PurchasedOnContract { get; set; }

		[DataMember(Name="purchaseMaximumMortgageAmount", EmitDefaultValue=false)]
		public double? PurchaseMaximumMortgageAmount { get; set; }

		[DataMember(Name="purchaseMaximumMortgagePercent", EmitDefaultValue=false)]
		public double? PurchaseMaximumMortgagePercent { get; set; }

		[DataMember(Name="purchasePriceLessInducementToPurchase", EmitDefaultValue=false)]
		public double? PurchasePriceLessInducementToPurchase { get; set; }

		[DataMember(Name="refinanceMaximumMortgageAmount", EmitDefaultValue=false)]
		public double? RefinanceMaximumMortgageAmount { get; set; }

		[DataMember(Name="refinancingATitleILoan", EmitDefaultValue=false)]
		public bool? RefinancingATitleILoan { get; set; }

		[DataMember(Name="rehabilitationEscrowAccount", EmitDefaultValue=false)]
		public double? RehabilitationEscrowAccount { get; set; }

		[DataMember(Name="rehabilitationEscrowAmountBalanceForFutureDraws", EmitDefaultValue=false)]
		public double? RehabilitationEscrowAmountBalanceForFutureDraws { get; set; }

		[DataMember(Name="rentalCashFlowBalance", EmitDefaultValue=false)]
		public double? RentalCashFlowBalance { get; set; }

		[DataMember(Name="residencyType", EmitDefaultValue=false)]
		public string ResidencyType { get; set; }

		[DataMember(Name="riskClass", EmitDefaultValue=false)]
		public string RiskClass { get; set; }

		[DataMember(Name="scoredByTotal", EmitDefaultValue=false)]
		public bool? ScoredByTotal { get; set; }

		[DataMember(Name="secondaryFinancingProviders", EmitDefaultValue=false)]
		public List<LoanContractHudLoanDataSecondaryFinancingProviders> SecondaryFinancingProviders { get; set; }

		[DataMember(Name="sellerContributionRate", EmitDefaultValue=false)]
		public double? SellerContributionRate { get; set; }

		[DataMember(Name="simpleRefinance", EmitDefaultValue=false)]
		public bool? SimpleRefinance { get; set; }

		[DataMember(Name="statutoryInvestment", EmitDefaultValue=false)]
		public double? StatutoryInvestment { get; set; }

		[DataMember(Name="step2EPlusStep1E", EmitDefaultValue=false)]
		public double? Step2EPlusStep1E { get; set; }

		[DataMember(Name="streamlined", EmitDefaultValue=false)]
		public bool? Streamlined { get; set; }

		[DataMember(Name="subTotalForEscrowAccount", EmitDefaultValue=false)]
		public double? SubTotalForEscrowAccount { get; set; }

		[DataMember(Name="subTotalForReleaseAtClosing", EmitDefaultValue=false)]
		public double? SubTotalForReleaseAtClosing { get; set; }

		[DataMember(Name="sumForInvestor", EmitDefaultValue=false)]
		public double? SumForInvestor { get; set; }

		[DataMember(Name="sumForOwnerOccupied", EmitDefaultValue=false)]
		public double? SumForOwnerOccupied { get; set; }

		[DataMember(Name="sumOfExistingDebt", EmitDefaultValue=false)]
		public double? SumOfExistingDebt { get; set; }

		[DataMember(Name="suplementalOriginationFee", EmitDefaultValue=false)]
		public double? SuplementalOriginationFee { get; set; }

		[DataMember(Name="title1LoanBalance", EmitDefaultValue=false)]
		public double? Title1LoanBalance { get; set; }

		[DataMember(Name="title1LoanNumber", EmitDefaultValue=false)]
		public string Title1LoanNumber { get; set; }

		[DataMember(Name="title1LoanWithWhom", EmitDefaultValue=false)]
		public string Title1LoanWithWhom { get; set; }

		[DataMember(Name="titleUpdateFeeAmount", EmitDefaultValue=false)]
		public double? TitleUpdateFeeAmount { get; set; }

		[DataMember(Name="titleUpdateFees", EmitDefaultValue=false)]
		public double? TitleUpdateFees { get; set; }

		[DataMember(Name="titleUpdateFeeTimes", EmitDefaultValue=false)]
		public int? TitleUpdateFeeTimes { get; set; }

		[DataMember(Name="totalCostsOfRepairsInA6", EmitDefaultValue=false)]
		public double? TotalCostsOfRepairsInA6 { get; set; }

		[DataMember(Name="totalEscrowCommitment", EmitDefaultValue=false)]
		public double? TotalEscrowCommitment { get; set; }

		[DataMember(Name="totalEscrowedFunds", EmitDefaultValue=false)]
		public double? TotalEscrowedFunds { get; set; }

		[DataMember(Name="totalFixedUnpaidBalance", EmitDefaultValue=false)]
		public double? TotalFixedUnpaidBalance { get; set; }

		[DataMember(Name="totalForBorrowerEstimatedProfit", EmitDefaultValue=false)]
		public double? TotalForBorrowerEstimatedProfit { get; set; }

		[DataMember(Name="totalForInspectionAndTitleFee", EmitDefaultValue=false)]
		public double? TotalForInspectionAndTitleFee { get; set; }

		[DataMember(Name="totalForLesserOfSumAsIs", EmitDefaultValue=false)]
		public double? TotalForLesserOfSumAsIs { get; set; }

		[DataMember(Name="totalForMtgPaymentEscrowed", EmitDefaultValue=false)]
		public double? TotalForMtgPaymentEscrowed { get; set; }

		[DataMember(Name="totalForPlanReviewerFee", EmitDefaultValue=false)]
		public double? TotalForPlanReviewerFee { get; set; }

		[DataMember(Name="totalForRehabilitationCost", EmitDefaultValue=false)]
		public double? TotalForRehabilitationCost { get; set; }

		[DataMember(Name="totalRehabilitationCosts", EmitDefaultValue=false)]
		public double? TotalRehabilitationCosts { get; set; }

		[DataMember(Name="totalRehabilitationCostsFeesReserves", EmitDefaultValue=false)]
		public double? TotalRehabilitationCostsFeesReserves { get; set; }

		[DataMember(Name="unpaidPrincipalBalanceFirstLien", EmitDefaultValue=false)]
		public double? UnpaidPrincipalBalanceFirstLien { get; set; }

		[DataMember(Name="unpaidPrincipalBalanceOfAnyJuniorLiens", EmitDefaultValue=false)]
		public double? UnpaidPrincipalBalanceOfAnyJuniorLiens { get; set; }

		[DataMember(Name="unpaidPrincipalBalanceOfPurchaseJuniorLiens", EmitDefaultValue=false)]
		public double? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get; set; }

		[DataMember(Name="valueEstablished", EmitDefaultValue=false)]
		public double? ValueEstablished { get; set; }

		[DataMember(Name="waterPurificationAgent", EmitDefaultValue=false)]
		public string WaterPurificationAgent { get; set; }

		[DataMember(Name="waterPurificationOrganization", EmitDefaultValue=false)]
		public string WaterPurificationOrganization { get; set; }

		[DataMember(Name="waterPurificationPayees", EmitDefaultValue=false)]
		public string WaterPurificationPayees { get; set; }

		[DataMember(Name="windEnergySystemActualCost", EmitDefaultValue=false)]
		public double? WindEnergySystemActualCost { get; set; }

	}
}