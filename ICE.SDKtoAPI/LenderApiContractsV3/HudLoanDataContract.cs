using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class HudLoanDataContract
    {
        [DataMember(Name = "actualCashInvRequired")]
        public decimal? ActualCashInvRequired { get; set; }

        [DataMember(Name = "adjustedMaxMtgAmount")]
        public decimal? AdjustedMaxMtgAmount { get; set; }

        [DataMember(Name = "afterImprovedValue")]
        public decimal? AfterImprovedValue { get; set; }

        [DataMember(Name = "allowableEnergyImprovements")]
        public decimal? AllowableEnergyImprovements { get; set; }

        [DataMember(Name = "architecturalEngineeringFee")]
        public decimal? ArchitecturalEngineeringFee { get; set; }

        [DataMember(Name = "asIsValue")]
        public decimal? AsIsValue { get; set; }

        [DataMember(Name = "borrowerAcknowledgement")]
        public string BorrowerAcknowledgement { get; set; }

        [DataMember(Name = "borrowerEstimatedProfit1")]
        public decimal? BorrowerEstimatedProfit1 { get; set; }

        [DataMember(Name = "borrowerEstimatedProfit2")]
        public decimal? BorrowerEstimatedProfit2 { get; set; }

        [DataMember(Name = "borrowerPaidClosingCosts")]
        public decimal? BorrowerPaidClosingCosts { get; set; }

        [DataMember(Name = "borrowerRequiredInvestment")]
        public decimal? BorrowerRequiredInvestment { get; set; }

        [DataMember(Name = "buildingOnOwnLand")]
        public bool? BuildingOnOwnLand { get; set; }

        [DataMember(Name = "simpleRefinance")]
        public bool? SimpleRefinance { get; set; }

        [DataMember(Name = "caseAssignedDate")]
        public string CaseAssignedDate { get; set; }

        [DataMember(Name = "childSupportBalance")]
        public decimal? ChildSupportBalance { get; set; }

        [DataMember(Name = "chumsForAppraisal")]
        public string ChumsForAppraisal { get; set; }

        [DataMember(Name = "commitmentMaximumMortgageAmount")]
        public decimal? CommitmentMaximumMortgageAmount { get; set; }

        [DataMember(Name = "commitmentStage")]
        public string CommitmentStage { get; set; }

        [DataMember(Name = "contingencyReserveCostsAmount")]
        public decimal? ContingencyReserveCostsAmount { get; set; }

        [DataMember(Name = "contingencyReserveCostsPercent")]
        public decimal? ContingencyReserveCostsPercent { get; set; }

        [DataMember(Name = "contractSalesPrice")]
        public decimal? ContractSalesPrice { get; set; }

        [DataMember(Name = "dealerContractorAddress")]
        public string DealerContractorAddress { get; set; }

        [DataMember(Name = "dealerContractorCity")]
        public string DealerContractorCity { get; set; }

        [DataMember(Name = "dealerContractorName")]
        public string DealerContractorName { get; set; }

        [DataMember(Name = "dealerContractorPostalCode")]
        public string DealerContractorPostalCode { get; set; }

        [DataMember(Name = "dealerContractorState")]
        public string DealerContractorState { get; set; }

        [DataMember(Name = "discountPointsAmount")]
        public decimal? DiscountPointsAmount { get; set; }

        [DataMember(Name = "discountPointsPercent")]
        public decimal? DiscountPointsPercent { get; set; }

        [DataMember(Name = "eemIndicator")]
        public bool? EemIndicator { get; set; }

        [DataMember(Name = "energyEfficientMortgageAmount")]
        public decimal? EnergyEfficientMortgageAmount { get; set; }

        [DataMember(Name = "escrowCommitment")]
        public string EscrowCommitment { get; set; }

        [DataMember(Name = "existingDebt")]
        public bool? ExistingDebt { get; set; }

        [DataMember(Name = "fha203kB10SubTotal")]
        public decimal? Fha203kB10SubTotal { get; set; }

        [DataMember(Name = "fha203kRemarks")]
        public string Fha203kRemarks { get; set; }

        [DataMember(Name = "fhaStreamlineType")]
        public string FhaStreamlineType { get; set; }

        [DataMember(Name = "haveOtherPendingApplicationForFha")]
        public bool? HaveOtherPendingApplicationForFha { get; set; }

        [DataMember(Name = "hudOwned")]
        public bool? HudOwned { get; set; }

        [DataMember(Name = "hudReoIndicator")]
        public bool? HudReoIndicator { get; set; }

        [DataMember(Name = "independentConsultantFee")]
        public decimal? IndependentConsultantFee { get; set; }

        [DataMember(Name = "inspectionFeeAmount")]
        public decimal? InspectionFeeAmount { get; set; }

        [DataMember(Name = "inspectionFeeTimes")]
        public int? InspectionFeeTimes { get; set; }

        [DataMember(Name = "ldpgsaForBorrower")]
        public bool? LdpgsaForBorrower { get; set; }

        [DataMember(Name = "ldpgsaForCoBorrower")]
        public bool? LdpgsaForCoBorrower { get; set; }

        [DataMember(Name = "leasedFromSomeoneElse")]
        public bool? LeasedFromSomeoneElse { get; set; }

        [DataMember(Name = "leaseExpirationDate")]
        public string LeaseExpirationDate { get; set; }

        [DataMember(Name = "leaseMonthlyPayment")]
        public decimal? LeaseMonthlyPayment { get; set; }

        [DataMember(Name = "lessAllowableDownpayment")]
        public decimal? LessAllowableDownpayment { get; set; }

        [DataMember(Name = "lesserOfSalesPrice")]
        public decimal? LesserOfSalesPrice { get; set; }

        [DataMember(Name = "lesserOfSumAmount")]
        public decimal? LesserOfSumAmount { get; set; }

        [DataMember(Name = "lesserOfSumAsIs")]
        public decimal? LesserOfSumAsIs { get; set; }

        [DataMember(Name = "lesserOfSumPercent")]
        public decimal? LesserOfSumPercent { get; set; }

        [DataMember(Name = "loanFor203KIndicator")]
        public bool? LoanFor203KIndicator { get; set; }

        [DataMember(Name = "loanPurpose")]
        public string LoanPurpose { get; set; }

        [DataMember(Name = "maximumMortgageWithUfmip")]
        public decimal? MaximumMortgageWithUfmip { get; set; }

        [DataMember(Name = "mtgOrDeedOfTrustOnProperty")]
        public bool? MtgOrDeedOfTrustOnProperty { get; set; }

        [DataMember(Name = "mtgPaymentEscrowedAmount")]
        public decimal? MtgPaymentEscrowedAmount { get; set; }

        [DataMember(Name = "mtgPaymentEscrowedTimes")]
        public int? MtgPaymentEscrowedTimes { get; set; }

        [DataMember(Name = "newResidential")]
        public bool? NewResidential { get; set; }

        [DataMember(Name = "nonresidentialTypeOfUse")]
        public string NonresidentialTypeOfUse { get; set; }

        [DataMember(Name = "numberOfHistoricUnits")]
        public int? NumberOfHistoricUnits { get; set; }

        [DataMember(Name = "numberOfMultifamilyUnits")]
        public int? NumberOfMultifamilyUnits { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

        [DataMember(Name = "ownedByBorrower")]
        public bool? OwnedByBorrower { get; set; }

        [DataMember(Name = "percentAfterImprovedValue")]
        public decimal? PercentAfterImprovedValue { get; set; }

        [DataMember(Name = "permitsAndOtherFee")]
        public decimal? PermitsAndOtherFee { get; set; }

        [DataMember(Name = "planReviewerFeeAddition")]
        public decimal? PlanReviewerFeeAddition { get; set; }

        [DataMember(Name = "planReviewerFeeAmount")]
        public decimal? PlanReviewerFeeAmount { get; set; }

        [DataMember(Name = "planReviewerFeeMiles")]
        public int? PlanReviewerFeeMiles { get; set; }

        [DataMember(Name = "propertyOwnerAddress")]
        public string PropertyOwnerAddress { get; set; }

        [DataMember(Name = "propertyOwnerCity")]
        public string PropertyOwnerCity { get; set; }

        [DataMember(Name = "propertyOwnerName")]
        public string PropertyOwnerName { get; set; }

        [DataMember(Name = "propertyOwnerPostalCode")]
        public string PropertyOwnerPostalCode { get; set; }

        [DataMember(Name = "propertyOwnerState")]
        public string PropertyOwnerState { get; set; }

        [DataMember(Name = "propertyToBeImproved")]
        public string PropertyToBeImproved { get; set; }

        [DataMember(Name = "propertyType")]
        public string PropertyType { get; set; }

        [DataMember(Name = "purchaseDate")]
        public string PurchaseDate { get; set; }

        [DataMember(Name = "purchasedOnContract")]
        public bool? PurchasedOnContract { get; set; }

        [DataMember(Name = "purchaseMaximumMortgageAmount")]
        public decimal? PurchaseMaximumMortgageAmount { get; set; }

        [DataMember(Name = "purchaseMaximumMortgagePercent")]
        public decimal? PurchaseMaximumMortgagePercent { get; set; }

        [DataMember(Name = "refinanceMaximumMortgageAmount")]
        public decimal? RefinanceMaximumMortgageAmount { get; set; }

        [DataMember(Name = "refinancingATitleILoan")]
        public bool? RefinancingATitleILoan { get; set; }

        [DataMember(Name = "rentalCashFlowBalance")]
        public decimal? RentalCashFlowBalance { get; set; }

        [DataMember(Name = "residencyType")]
        public string ResidencyType { get; set; }

        [DataMember(Name = "riskClass")]
        public string RiskClass { get; set; }

        [DataMember(Name = "scoredByTotal")]
        public bool? ScoredByTotal { get; set; }

        [DataMember(Name = "secondaryFinancingProviders")]
        public List<SecondaryFinancingProviderContract> SecondaryFinancingProviders { get; set; }

        [DataMember(Name = "sellerContributionRate")]
        public decimal? SellerContributionRate { get; set; }

        [DataMember(Name = "statutoryInvestment")]
        public decimal? StatutoryInvestment { get; set; }

        [DataMember(Name = "streamlined")]
        public bool? Streamlined { get; set; }

        [DataMember(Name = "subTotalForEscrowAccount")]
        public decimal? SubTotalForEscrowAccount { get; set; }

        [DataMember(Name = "subTotalForReleaseAtClosing")]
        public decimal? SubTotalForReleaseAtClosing { get; set; }

        [DataMember(Name = "sumForInvestor")]
        public decimal? SumForInvestor { get; set; }

        [DataMember(Name = "sumForOwnerOccupied")]
        public decimal? SumForOwnerOccupied { get; set; }

        [DataMember(Name = "sumOfExistingDebt")]
        public decimal? SumOfExistingDebt { get; set; }

        [DataMember(Name = "supplementalOriginationFee")]
        public decimal? SupplementalOriginationFee { get; set; }

        [DataMember(Name = "title1LoanBalance")]
        public decimal? Title1LoanBalance { get; set; }

        [DataMember(Name = "title1LoanNumber")]
        public string Title1LoanNumber { get; set; }

        [DataMember(Name = "title1LoanWithWhom")]
        public string Title1LoanWithWhom { get; set; }

        [DataMember(Name = "titleUpdateFeeAmount")]
        public decimal? TitleUpdateFeeAmount { get; set; }

        [DataMember(Name = "titleUpdateFeeTimes")]
        public int? TitleUpdateFeeTimes { get; set; }

        [DataMember(Name = "totalCostsOfRepairsInA6")]
        public decimal? TotalCostsOfRepairsInA6 { get; set; }

        [DataMember(Name = "totalEscrowCommitment")]
        public decimal? TotalEscrowCommitment { get; set; }

        [DataMember(Name = "totalEscrowedFunds")]
        public decimal? TotalEscrowedFunds { get; set; }

        [DataMember(Name = "totalFixedUnpaidBalance")]
        public decimal? TotalFixedUnpaidBalance { get; set; }

        [DataMember(Name = "totalForBorrowerEstimatedProfit")]
        public decimal? TotalForBorrowerEstimatedProfit { get; set; }

        [DataMember(Name = "totalForInspectionAndTitleFee")]
        public decimal? TotalForInspectionAndTitleFee { get; set; }

        [DataMember(Name = "totalForLesserOfSumAsIs")]
        public decimal? TotalForLesserOfSumAsIs { get; set; }

        [DataMember(Name = "totalForMtgPaymentEscrowed")]
        public decimal? TotalForMtgPaymentEscrowed { get; set; }

        [DataMember(Name = "totalForPlanReviewerFee")]
        public decimal? TotalForPlanReviewerFee { get; set; }

        [DataMember(Name = "totalForRehabilitationCost")]
        public decimal? TotalForRehabilitationCost { get; set; }

        [DataMember(Name = "totalRehabilitationCosts")]
        public decimal? TotalRehabilitationCosts { get; set; }

        [DataMember(Name = "valueEstablished")]
        public decimal? ValueEstablished { get; set; }

        [DataMember(Name = "constructionRepairsRehabilitationCosts")]
        public decimal? ConstructionRepairsRehabilitationCosts { get; set; }

        [DataMember(Name = "feasibilityStudyWhenNecessary")]
        public decimal? FeasibilityStudyWhenNecessary { get; set; }

        [DataMember(Name = "financeableMortgageFeesIfCharged")]
        public decimal? FinanceableMortgageFeesIfCharged { get; set; }

        [DataMember(Name = "totalRehabilitationCostsFeesReserves")]
        public decimal? TotalRehabilitationCostsFeesReserves { get; set; }

        [DataMember(Name = "purchasePriceLessInducementToPurchase")]
        public decimal? PurchasePriceLessInducementToPurchase { get; set; }

        [DataMember(Name = "step2EPlusStep1E")]
        public decimal? Step2EPlusStep1E { get; set; }

        [DataMember(Name = "lesserOf3AOr3B")]
        public decimal? LesserOf3AOr3B { get; set; }

        [DataMember(Name = "appropriateLtvFactor")]
        public decimal? AppropriateLtvFactor { get; set; }

        [DataMember(Name = "lesserOf3AOr3BMultiply3F")]
        public decimal? LesserOf3AOr3BMultiply3F { get; set; }

        [DataMember(Name = "nationwideMortgageLimit")]
        public decimal? NationwideMortgageLimit { get; set; }

        [DataMember(Name = "baseMortgageAmountFrom3COr3D")]
        public decimal? BaseMortgageAmountFrom3COr3D { get; set; }

        [DataMember(Name = "materialCostsOrderedPrepaidByBorrowerContractor")]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractor { get; set; }

        [DataMember(Name = "materialCostsOrderedPrepaidByBorrowerContractorAfter50Percent")]
        public decimal? MaterialCostsOrderedPrepaidByBorrowerContractorAfter50Percent { get; set; }

        [DataMember(Name = "initialDrawAtClosingTotal")]
        public decimal? InitialDrawAtClosingTotal { get; set; }

        [DataMember(Name = "borrowersOwnFundsforContingencyReserves")]
        public decimal? BorrowersOwnFundsforContingencyReserves { get; set; }

        [DataMember(Name = "initialBaseMortgageAmountPlusEemImprovementAmount")]
        public decimal? InitialBaseMortgageAmountPlusEemImprovementAmount { get; set; }

        [DataMember(Name = "windEnergySystemActualCost")]
        public decimal? WindEnergySystemActualCost { get; set; }

        [DataMember(Name = "afterImprovedValueAfter20Percent")]
        public decimal? AfterImprovedValueAfter20Percent { get; set; }

        [DataMember(Name = "lesserOfMaximumFinanceableSolarOrWindEnergyAmount")]
        public decimal? LesserOfMaximumFinanceableSolarOrWindEnergyAmount { get; set; }

        [DataMember(Name = "nationwideMortgageLimitAfter120Percent")]
        public decimal? NationwideMortgageLimitAfter120Percent { get; set; }

        [DataMember(Name = "finalBaseMortgageAmount")]
        public decimal? FinalBaseMortgageAmount { get; set; }

        [DataMember(Name = "rehabilitationEscrowAccount")]
        public decimal? RehabilitationEscrowAccount { get; set; }

        [DataMember(Name = "mipltv")]
        public decimal? Mipltv { get; set; }

        [DataMember(Name = "feesAssociatedWithNewLoan")]
        public decimal? FeesAssociatedWithNewLoan { get; set; }

        [DataMember(Name = "existingDebtPlusRehabCosts")]
        public decimal? ExistingDebtPlusRehabCosts { get; set; }

        [DataMember(Name = "existingDebtPlusRehabCostsPlusNewLoanFees")]
        public decimal? ExistingDebtPlusRehabCostsPlusNewLoanFees { get; set; }

        [DataMember(Name = "inspectionFeesDuringRehabilitation")]
        public decimal? InspectionFeesDuringRehabilitation { get; set; }

        [DataMember(Name = "titleUpdateFees")]
        public decimal? TitleUpdateFees { get; set; }

        [DataMember(Name = "rehabilitationEscrowAmountBalanceForFutureDraws")]
        public decimal? RehabilitationEscrowAmountBalanceForFutureDraws { get; set; }

        [DataMember(Name = "limitedProgram")]
        public bool? LimitedProgram { get; set; }

        [DataMember(Name = "criteriaForAppropriateLtvFactor")]
        public string CriteriaForAppropriateLtvFactor { get; set; }

        [DataMember(Name = "lessLeadBasedPaintCredit")]
        public decimal? LessLeadBasedPaintCredit { get; set; }

        [DataMember(Name = "caseLtv")]
        public decimal? CaseLtv { get; set; }

        [DataMember(Name = "initialDrawAtClosingConsultantFees")]
        public decimal? InitialDrawAtClosingConsultantFees { get; set; }

        [DataMember(Name = "initialDrawAtClosingArchitecturalorEngineeringFees")]
        public decimal? InitialDrawAtClosingArchitecturalorEngineeringFees { get; set; }

        [DataMember(Name = "initialDrawAtClosingPermitFees")]
        public decimal? InitialDrawAtClosingPermitFees { get; set; }

        [DataMember(Name = "unpaidPrincipalBalanceFirstLien")]
        public decimal? UnpaidPrincipalBalanceFirstLien { get; set; }

        [DataMember(Name = "unpaidPrincipalBalanceOfPurchaseJuniorLiens")]
        public decimal? UnpaidPrincipalBalanceOfPurchaseJuniorLiens { get; set; }

        [DataMember(Name = "unpaidPrincipalBalanceOfAnyJuniorLiens")]
        public decimal? UnpaidPrincipalBalanceOfAnyJuniorLiens { get; set; }

        [DataMember(Name = "interestDueonExistingMortgage")]
        public decimal? InterestDueonExistingMortgage { get; set; }

        [DataMember(Name = "mipDueOnExistingMortgage")]
        public decimal? MipDueOnExistingMortgage { get; set; }

        [DataMember(Name = "prepaymentPenalties")]
        public decimal? PrepaymentPenalties { get; set; }

        [DataMember(Name = "lateCharges")]
        public decimal? LateCharges { get; set; }

        [DataMember(Name = "escrowShortages")]
        public decimal? EscrowShortages { get; set; }

        [DataMember(Name = "existing203KDebtTotal")]
        public decimal? Existing203KDebtTotal { get; set; }

        [DataMember(Name = "waterPurificationOrganization")]
        public string WaterPurificationOrganization { get; set; }

        [DataMember(Name = "waterPurificationAgent")]
        public string WaterPurificationAgent { get; set; }

        [DataMember(Name = "waterPurificationPayees")]
        public string WaterPurificationPayees { get; set; }

        [DataMember(Name = "rehabConstructionPeriodMonths")]
        public string RehabConstructionPeriodMonths { get; set; }

    }
}
