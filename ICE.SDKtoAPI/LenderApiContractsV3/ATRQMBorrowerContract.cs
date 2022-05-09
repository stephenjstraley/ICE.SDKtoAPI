using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ATRQMBorrowerContract
    {
        [DataMember(Name = "borMonthlyEmploymentIncomeBaseIncome")]
        public decimal? BorMonthlyEmploymentIncomeBaseIncome { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeOvertimeIncome")]
        public decimal? BorMonthlyEmploymentIncomeOvertimeIncome { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeBonusIncome")]
        public decimal? BorMonthlyEmploymentIncomeBonusIncome { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeCommissionIncome")]
        public decimal? BorMonthlyEmploymentIncomeCommissionIncome { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeDividendInterestIncome")]
        public decimal? BorMonthlyEmploymentIncomeDividendInterestIncome { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeOtherIncome1")]
        public decimal? BorMonthlyEmploymentIncomeOtherIncome1 { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeOtherIncome2")]
        public decimal? BorMonthlyEmploymentIncomeOtherIncome2 { get; set; }

        [DataMember(Name = "borMonthlyEmploymentIncomeTotalEmploymentIncome")]
        public decimal? BorMonthlyEmploymentIncomeTotalEmploymentIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeBaseIncome")]
        public decimal? CobMonthlyEmploymentIncomeBaseIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeOvertimeIncome")]
        public decimal? CobMonthlyEmploymentIncomeOvertimeIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeBonusIncome")]
        public decimal? CobMonthlyEmploymentIncomeBonusIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeCommissionIncome")]
        public decimal? CobMonthlyEmploymentIncomeCommissionIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeDividendInterestIncome")]
        public decimal? CobMonthlyEmploymentIncomeDividendInterestIncome { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeOtherIncome1")]
        public decimal? CobMonthlyEmploymentIncomeOtherIncome1 { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeOtherIncome2")]
        public decimal? CobMonthlyEmploymentIncomeOtherIncome2 { get; set; }

        [DataMember(Name = "cobMonthlyEmploymentIncomeTotalEmploymentIncome")]
        public decimal? CobMonthlyEmploymentIncomeTotalEmploymentIncome { get; set; }

        [DataMember(Name = "borProjectedIncomeProjectedCostLivingAdjustment")]
        public decimal? BorProjectedIncomeProjectedCostLivingAdjustment { get; set; }

        [DataMember(Name = "borProjectedIncomeProjectedPerformanceRaises")]
        public decimal? BorProjectedIncomeProjectedPerformanceRaises { get; set; }

        [DataMember(Name = "borProjectedIncomeProjectedBonuses")]
        public decimal? BorProjectedIncomeProjectedBonuses { get; set; }

        [DataMember(Name = "borProjectedIncomeProjectedNewJobIncome")]
        public decimal? BorProjectedIncomeProjectedNewJobIncome { get; set; }

        [DataMember(Name = "cobProjectedIncomeProjectedCostLivingAdjustment")]
        public decimal? CobProjectedIncomeProjectedCostLivingAdjustment { get; set; }

        [DataMember(Name = "cobProjectedIncomeProjectedPerformanceRaises")]
        public decimal? CobProjectedIncomeProjectedPerformanceRaises { get; set; }

        [DataMember(Name = "cobProjectedIncomeProjectedBonuses")]
        public decimal? CobProjectedIncomeProjectedBonuses { get; set; }

        [DataMember(Name = "cobProjectedIncomeProjectedNewJobIncome")]
        public decimal? CobProjectedIncomeProjectedNewJobIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeMilitaryIncome")]
        public decimal? BorNonEmploymentIncomeMilitaryIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeVaBenefitIncome")]
        public decimal? BorNonEmploymentIncomeVaBenefitIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeGovtAssitProgramIncome")]
        public decimal? BorNonEmploymentIncomeGovtAssitProgramIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeMtgCreditCertificateIncome")]
        public decimal? BorNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeHomeownerSubsidyIncome")]
        public decimal? BorNonEmploymentIncomeHomeownerSubsidyIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeMilitaryIncome")]
        public decimal? CobNonEmploymentIncomeMilitaryIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeVaBenefitIncome")]
        public decimal? CobNonEmploymentIncomeVaBenefitIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeGovtAssitProgramIncome")]
        public decimal? CobNonEmploymentIncomeGovtAssitProgramIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeMtgCreditCertificateIncome")]
        public decimal? CobNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeHomeownerSubsidyIncome")]
        public decimal? CobNonEmploymentIncomeHomeownerSubsidyIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeSocialSecurityIncome")]
        public decimal? BorNonTaxableIncomeSocialSecurityIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeFedGovtEmplRetirementIncome")]
        public decimal? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeRailroadRetirementBenefits")]
        public decimal? BorNonTaxableIncomeRailroadRetirementBenefits { get; set; }

        [DataMember(Name = "borNonTaxableIncomeStateGovtEmplRetirementIncome")]
        public decimal? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeDisabilityIncome")]
        public decimal? BorNonTaxableIncomeDisabilityIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomePublicAssistPayments")]
        public decimal? BorNonTaxableIncomePublicAssistPayments { get; set; }

        [DataMember(Name = "borNonTaxableIncomeChildSupportIncome")]
        public decimal? BorNonTaxableIncomeChildSupportIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeMilitaryAllowances")]
        public decimal? BorNonTaxableIncomeMilitaryAllowances { get; set; }

        [DataMember(Name = "borNonTaxableIncomeOtherIncome")]
        public decimal? BorNonTaxableIncomeOtherIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeSocialSecurityIncome")]
        public decimal? CobNonTaxableIncomeSocialSecurityIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeFedGovtEmplRetirementIncome")]
        public decimal? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeRailroadRetirementBenefits")]
        public decimal? CobNonTaxableIncomeRailroadRetirementBenefits { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeStateGovtEmplRetirementIncome")]
        public decimal? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeDisabilityIncome")]
        public decimal? CobNonTaxableIncomeDisabilityIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomePublicAssistPayments")]
        public decimal? CobNonTaxableIncomePublicAssistPayments { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeChildSupportIncome")]
        public decimal? CobNonTaxableIncomeChildSupportIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeMilitaryAllowances")]
        public decimal? CobNonTaxableIncomeMilitaryAllowances { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeOtherIncome")]
        public decimal? CobNonTaxableIncomeOtherIncome { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityDescription1")]
        public string BorContingentLiabilitiesLiabilityDescription1 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityAmount1")]
        public decimal? BorContingentLiabilitiesLiabilityAmount1 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityDescription2")]
        public string BorContingentLiabilitiesLiabilityDescription2 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityAmount2")]
        public decimal? BorContingentLiabilitiesLiabilityAmount2 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityDescription3")]
        public string BorContingentLiabilitiesLiabilityDescription3 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesLiabilityAmount3")]
        public decimal? BorContingentLiabilitiesLiabilityAmount3 { get; set; }

        [DataMember(Name = "borContingentLiabilitiesTotalLiabilityAmount")]
        public decimal? BorContingentLiabilitiesTotalLiabilityAmount { get; set; }

        [DataMember(Name = "borCosignedObligationsCarLoanPayment")]
        public decimal? BorCosignedObligationsCarLoanPayment { get; set; }

        [DataMember(Name = "borCosignedObligationsStudentLoanPayment")]
        public decimal? BorCosignedObligationsStudentLoanPayment { get; set; }

        [DataMember(Name = "borCosignedObligationsMortgagePayment")]
        public decimal? BorCosignedObligationsMortgagePayment { get; set; }

        [DataMember(Name = "borCosignedObligationsOtherPaymentDescription")]
        public string BorCosignedObligationsOtherPaymentDescription { get; set; }

        [DataMember(Name = "borCosignedObligationsOtherPayment")]
        public decimal? BorCosignedObligationsOtherPayment { get; set; }

        [DataMember(Name = "borCosignedObligationsTotalCoMortgagorLiabilities")]
        public decimal? BorCosignedObligationsTotalCoMortgagorLiabilities { get; set; }

        [DataMember(Name = "borOvertimeMostRecentMonths")]
        public int? BorOvertimeMostRecentMonths { get; set; }

        [DataMember(Name = "borOvertimeMostRecentAmount")]
        public decimal? BorOvertimeMostRecentAmount { get; set; }

        [DataMember(Name = "cobOvertimeMostRecentAmount")]
        public decimal? CobOvertimeMostRecentAmount { get; set; }

        [DataMember(Name = "borOvertimePreviousYear1")]
        public int? BorOvertimePreviousYear1 { get; set; }

        [DataMember(Name = "borOvertimePreviousMonths1")]
        public int? BorOvertimePreviousMonths1 { get; set; }

        [DataMember(Name = "borOvertimePreviousAmount1")]
        public decimal? BorOvertimePreviousAmount1 { get; set; }

        [DataMember(Name = "cobOvertimePreviousAmount1")]
        public decimal? CobOvertimePreviousAmount1 { get; set; }

        [DataMember(Name = "borOvertimePreviousYear2")]
        public int? BorOvertimePreviousYear2 { get; set; }

        [DataMember(Name = "borOvertimePreviousMonths2")]
        public int? BorOvertimePreviousMonths2 { get; set; }

        [DataMember(Name = "borOvertimePreviousAmount2")]
        public decimal? BorOvertimePreviousAmount2 { get; set; }

        [DataMember(Name = "cobOvertimePreviousAmount2")]
        public decimal? CobOvertimePreviousAmount2 { get; set; }

        [DataMember(Name = "borOvertimeAverageOvertime")]
        public decimal? BorOvertimeAverageOvertime { get; set; }

        [DataMember(Name = "cobOvertimeAverageOvertime")]
        public decimal? CobOvertimeAverageOvertime { get; set; }

        [DataMember(Name = "borBonusMostRecentMonths")]
        public int? BorBonusMostRecentMonths { get; set; }

        [DataMember(Name = "borBonusMostRecentAmount")]
        public decimal? BorBonusMostRecentAmount { get; set; }

        [DataMember(Name = "cobBonusMostRecentAmount")]
        public decimal? CobBonusMostRecentAmount { get; set; }

        [DataMember(Name = "borBonusPreviousYear1")]
        public int? BorBonusPreviousYear1 { get; set; }

        [DataMember(Name = "borBonusPreviousMonths1")]
        public int? BorBonusPreviousMonths1 { get; set; }

        [DataMember(Name = "borBonusPreviousAmount1")]
        public decimal? BorBonusPreviousAmount1 { get; set; }

        [DataMember(Name = "cobBonusPreviousAmount1")]
        public decimal? CobBonusPreviousAmount1 { get; set; }

        [DataMember(Name = "borBonusPreviousYear2")]
        public int? BorBonusPreviousYear2 { get; set; }

        [DataMember(Name = "borBonusPreviousMonths2")]
        public int? BorBonusPreviousMonths2 { get; set; }

        [DataMember(Name = "borBonusPreviousAmount2")]
        public decimal? BorBonusPreviousAmount2 { get; set; }

        [DataMember(Name = "cobBonusPreviousAmount2")]
        public decimal? CobBonusPreviousAmount2 { get; set; }

        [DataMember(Name = "borBonusAverageOvertime")]
        public decimal? BorBonusAverageOvertime { get; set; }

        [DataMember(Name = "cobBonusAverageOvertime")]
        public decimal? CobBonusAverageOvertime { get; set; }

        [DataMember(Name = "borCommissionMostRecentMonths")]
        public int? BorCommissionMostRecentMonths { get; set; }

        [DataMember(Name = "borCommissionMostRecentAmount")]
        public decimal? BorCommissionMostRecentAmount { get; set; }

        [DataMember(Name = "cobCommissionMostRecentAmount")]
        public decimal? CobCommissionMostRecentAmount { get; set; }

        [DataMember(Name = "borCommissionPreviousYear1")]
        public int? BorCommissionPreviousYear1 { get; set; }

        [DataMember(Name = "borCommissionPreviousMonths1")]
        public int? BorCommissionPreviousMonths1 { get; set; }

        [DataMember(Name = "borCommissionPreviousAmount1")]
        public decimal? BorCommissionPreviousAmount1 { get; set; }

        [DataMember(Name = "cobCommissionPreviousAmount1")]
        public decimal? CobCommissionPreviousAmount1 { get; set; }

        [DataMember(Name = "borCommissionAverageOvertime")]
        public decimal? BorCommissionAverageOvertime { get; set; }

        [DataMember(Name = "cobCommissionAverageOvertime")]
        public decimal? CobCommissionAverageOvertime { get; set; }

        [DataMember(Name = "borDividendPreviousYear1")]
        public int? BorDividendPreviousYear1 { get; set; }

        [DataMember(Name = "borDividendPreviousMonths1")]
        public int? BorDividendPreviousMonths1 { get; set; }

        [DataMember(Name = "borDividendPreviousAmount1")]
        public decimal? BorDividendPreviousAmount1 { get; set; }

        [DataMember(Name = "cobDividendPreviousAmount1")]
        public decimal? CobDividendPreviousAmount1 { get; set; }

        [DataMember(Name = "borDividendPreviousYear2")]
        public int? BorDividendPreviousYear2 { get; set; }

        [DataMember(Name = "borDividendPreviousMonths2")]
        public int? BorDividendPreviousMonths2 { get; set; }

        [DataMember(Name = "borDividendPreviousAmount2")]
        public decimal? BorDividendPreviousAmount2 { get; set; }

        [DataMember(Name = "cobDividendPreviousAmount2")]
        public decimal? CobDividendPreviousAmount2 { get; set; }

        [DataMember(Name = "borDividendRequiredForCashAmount")]
        public decimal? BorDividendRequiredForCashAmount { get; set; }

        [DataMember(Name = "cobDividendRequiredForCashAmount")]
        public decimal? CobDividendRequiredForCashAmount { get; set; }

        [DataMember(Name = "borDividendAverageDividend")]
        public decimal? BorDividendAverageDividend { get; set; }

        [DataMember(Name = "cobDividendAverageDividend")]
        public decimal? CobDividendAverageDividend { get; set; }

        [DataMember(Name = "borInterestPreviousYear1")]
        public int? BorInterestPreviousYear1 { get; set; }

        [DataMember(Name = "borInterestPreviousMonths1")]
        public int? BorInterestPreviousMonths1 { get; set; }

        [DataMember(Name = "borInterestPreviousAmount1")]
        public decimal? BorInterestPreviousAmount1 { get; set; }

        [DataMember(Name = "cobInterestPreviousAmount1")]
        public decimal? CobInterestPreviousAmount1 { get; set; }

        [DataMember(Name = "borInterestPreviousYear2")]
        public int? BorInterestPreviousYear2 { get; set; }

        [DataMember(Name = "borInterestPreviousMonths2")]
        public int? BorInterestPreviousMonths2 { get; set; }

        [DataMember(Name = "borInterestPreviousAmount2")]
        public decimal? BorInterestPreviousAmount2 { get; set; }

        [DataMember(Name = "cobInterestPreviousAmount2")]
        public decimal? CobInterestPreviousAmount2 { get; set; }

        [DataMember(Name = "borInterestRequiredForCashAmount")]
        public decimal? BorInterestRequiredForCashAmount { get; set; }

        [DataMember(Name = "cobInterestRequiredForCashAmount")]
        public decimal? CobInterestRequiredForCashAmount { get; set; }

        [DataMember(Name = "borInterestAverageDividend")]
        public decimal? BorInterestAverageDividend { get; set; }

        [DataMember(Name = "cobInterestAverageDividend")]
        public decimal? CobInterestAverageDividend { get; set; }

        [DataMember(Name = "borOtherOtherIncome")]
        public decimal? BorOtherOtherIncome { get; set; }

        [DataMember(Name = "borOtherRetirementIncome")]
        public decimal? BorOtherRetirementIncome { get; set; }

        [DataMember(Name = "borOtherSocialSecurityIncome")]
        public decimal? BorOtherSocialSecurityIncome { get; set; }

        [DataMember(Name = "borOtherTrustIncome")]
        public decimal? BorOtherTrustIncome { get; set; }

        [DataMember(Name = "borOtherUnemploymentIncome")]
        public decimal? BorOtherUnemploymentIncome { get; set; }

        [DataMember(Name = "borOtherTipIncome")]
        public decimal? BorOtherTipIncome { get; set; }

        [DataMember(Name = "borOtherParttimeIncome")]
        public decimal? BorOtherParttimeIncome { get; set; }

        [DataMember(Name = "borOtherSeasonalIncome")]
        public decimal? BorOtherSeasonalIncome { get; set; }

        [DataMember(Name = "borOtherNotesReceivableIncome")]
        public decimal? BorOtherNotesReceivableIncome { get; set; }

        [DataMember(Name = "cobOtherOtherIncome")]
        public decimal? CobOtherOtherIncome { get; set; }

        [DataMember(Name = "cobOtherRetirementIncome")]
        public decimal? CobOtherRetirementIncome { get; set; }

        [DataMember(Name = "cobOtherSocialSecurityIncome")]
        public decimal? CobOtherSocialSecurityIncome { get; set; }

        [DataMember(Name = "cobOtherTrustIncome")]
        public decimal? CobOtherTrustIncome { get; set; }

        [DataMember(Name = "cobOtherUnemploymentIncome")]
        public decimal? CobOtherUnemploymentIncome { get; set; }

        [DataMember(Name = "cobOtherTipIncome")]
        public decimal? CobOtherTipIncome { get; set; }

        [DataMember(Name = "cobOtherParttimeIncome")]
        public decimal? CobOtherParttimeIncome { get; set; }

        [DataMember(Name = "cobOtherSeasonalIncome")]
        public decimal? CobOtherSeasonalIncome { get; set; }

        [DataMember(Name = "cobOtherNotesReceivableIncome")]
        public decimal? CobOtherNotesReceivableIncome { get; set; }

        [DataMember(Name = "borMilitaryBasePay")]
        public decimal? BorMilitaryBasePay { get; set; }

        [DataMember(Name = "borMilitaryCombatPay")]
        public decimal? BorMilitaryCombatPay { get; set; }

        [DataMember(Name = "borMilitaryFlightPay")]
        public decimal? BorMilitaryFlightPay { get; set; }

        [DataMember(Name = "borMilitaryHazardPay")]
        public decimal? BorMilitaryHazardPay { get; set; }

        [DataMember(Name = "borMilitaryOverseasPay")]
        public decimal? BorMilitaryOverseasPay { get; set; }

        [DataMember(Name = "borMilitaryPropPay")]
        public decimal? BorMilitaryPropPay { get; set; }

        [DataMember(Name = "borMilitaryTotalPay")]
        public decimal? BorMilitaryTotalPay { get; set; }

        [DataMember(Name = "cobMilitaryBasePay")]
        public decimal? CobMilitaryBasePay { get; set; }

        [DataMember(Name = "cobMilitaryCombatPay")]
        public decimal? CobMilitaryCombatPay { get; set; }

        [DataMember(Name = "cobMilitaryFlightPay")]
        public decimal? CobMilitaryFlightPay { get; set; }

        [DataMember(Name = "cobMilitaryHazardPay")]
        public decimal? CobMilitaryHazardPay { get; set; }

        [DataMember(Name = "cobMilitaryOverseasPay")]
        public decimal? CobMilitaryOverseasPay { get; set; }

        [DataMember(Name = "cobMilitaryPropPay")]
        public decimal? CobMilitaryPropPay { get; set; }

        [DataMember(Name = "cobMilitaryTotalPay")]
        public decimal? CobMilitaryTotalPay { get; set; }

        [DataMember(Name = "borMilitaryAllowanceClothingAllowance")]
        public decimal? BorMilitaryAllowanceClothingAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceRationsAllowance")]
        public decimal? BorMilitaryAllowanceRationsAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceVariableHousingAllowance")]
        public decimal? BorMilitaryAllowanceVariableHousingAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceQuartersAllowance")]
        public decimal? BorMilitaryAllowanceQuartersAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceOtherAllowance")]
        public decimal? BorMilitaryAllowanceOtherAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceTotalAllowance")]
        public decimal? BorMilitaryAllowanceTotalAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceClothingAllowance")]
        public decimal? CobMilitaryAllowanceClothingAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceRationsAllowance")]
        public decimal? CobMilitaryAllowanceRationsAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceVariableHousingAllowance")]
        public decimal? CobMilitaryAllowanceVariableHousingAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceQuartersAllowance")]
        public decimal? CobMilitaryAllowanceQuartersAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceOtherAllowance")]
        public decimal? CobMilitaryAllowanceOtherAllowance { get; set; }

        [DataMember(Name = "cobMilitaryAllowanceTotalAllowance")]
        public decimal? CobMilitaryAllowanceTotalAllowance { get; set; }

        [DataMember(Name = "borMilitaryAllowanceOtherAllowanceDescription")]
        public string BorMilitaryAllowanceOtherAllowanceDescription { get; set; }

        [DataMember(Name = "borProjectedIncomeTotalProjectedIncome")]
        public decimal? BorProjectedIncomeTotalProjectedIncome { get; set; }

        [DataMember(Name = "cobProjectedIncomeTotalProjectedIncome")]
        public decimal? CobProjectedIncomeTotalProjectedIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeTotalNonEmploymentIncome")]
        public decimal? BorNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }

        [DataMember(Name = "cobNonEmploymentIncomeTotalNonEmploymentIncome")]
        public decimal? CobNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }

        [DataMember(Name = "borNonTaxableIncomeTotalNonTaxableIncome")]
        public decimal? BorNonTaxableIncomeTotalNonTaxableIncome { get; set; }

        [DataMember(Name = "cobNonTaxableIncomeTotalNonTaxableIncome")]
        public decimal? CobNonTaxableIncomeTotalNonTaxableIncome { get; set; }

        [DataMember(Name = "cobOvertimeMostRecentMonths")]
        public int? CobOvertimeMostRecentMonths { get; set; }

        [DataMember(Name = "cobOvertimePreviousYear1")]
        public int? CobOvertimePreviousYear1 { get; set; }

        [DataMember(Name = "cobOvertimePreviousMonths1")]
        public int? CobOvertimePreviousMonths1 { get; set; }

        [DataMember(Name = "cobOvertimePreviousYear2")]
        public int? CobOvertimePreviousYear2 { get; set; }

        [DataMember(Name = "cobOvertimePreviousMonths2")]
        public int? CobOvertimePreviousMonths2 { get; set; }

        [DataMember(Name = "cobBonusMostRecentMonths")]
        public int? CobBonusMostRecentMonths { get; set; }

        [DataMember(Name = "cobBonusPreviousYear1")]
        public int? CobBonusPreviousYear1 { get; set; }

        [DataMember(Name = "cobBonusPreviousMonths1")]
        public int? CobBonusPreviousMonths1 { get; set; }

        [DataMember(Name = "cobBonusPreviousYear2")]
        public int? CobBonusPreviousYear2 { get; set; }

        [DataMember(Name = "cobBonusPreviousMonths2")]
        public int? CobBonusPreviousMonths2 { get; set; }

        [DataMember(Name = "cobCommissionMostRecentMonths")]
        public int? CobCommissionMostRecentMonths { get; set; }

        [DataMember(Name = "cobCommissionPreviousYear1")]
        public int? CobCommissionPreviousYear1 { get; set; }

        [DataMember(Name = "cobCommissionPreviousMonths1")]
        public int? CobCommissionPreviousMonths1 { get; set; }

        [DataMember(Name = "cobDividendPreviousYear1")]
        public int? CobDividendPreviousYear1 { get; set; }

        [DataMember(Name = "cobDividendPreviousMonths1")]
        public int? CobDividendPreviousMonths1 { get; set; }

        [DataMember(Name = "cobDividendPreviousYear2")]
        public int? CobDividendPreviousYear2 { get; set; }

        [DataMember(Name = "cobDividendPreviousMonths2")]
        public int? CobDividendPreviousMonths2 { get; set; }

        [DataMember(Name = "cobInterestPreviousYear1")]
        public int? CobInterestPreviousYear1 { get; set; }

        [DataMember(Name = "cobInterestPreviousMonths1")]
        public int? CobInterestPreviousMonths1 { get; set; }

        [DataMember(Name = "cobInterestPreviousYear2")]
        public int? CobInterestPreviousYear2 { get; set; }

        [DataMember(Name = "cobInterestPreviousMonths2")]
        public int? CobInterestPreviousMonths2 { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome")]
        public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get; set; }

        [DataMember(Name = "borNonEmploymentIncomeIsOffsetHomeownerSubsidyIncome")]
        public bool? BorNonEmploymentIncomeIsOffsetHomeownerSubsidyIncome { get; set; }

        [DataMember(Name = "borOvertimeMostRecentYear")]
        public int? BorOvertimeMostRecentYear { get; set; }

        [DataMember(Name = "cobOvertimeMostRecentYear")]
        public int? CobOvertimeMostRecentYear { get; set; }

        [DataMember(Name = "borBonusMostRecentYear")]
        public int? BorBonusMostRecentYear { get; set; }

        [DataMember(Name = "cobBonusMostRecentYear")]
        public int? CobBonusMostRecentYear { get; set; }

        [DataMember(Name = "borCommissionMostRecentYear")]
        public int? BorCommissionMostRecentYear { get; set; }

        [DataMember(Name = "cobCommissionMostRecentYear")]
        public int? CobCommissionMostRecentYear { get; set; }

        [DataMember(Name = "borCommissionPreviousYear2")]
        public int? BorCommissionPreviousYear2 { get; set; }

        [DataMember(Name = "borCommissionPreviousMonths2")]
        public int? BorCommissionPreviousMonths2 { get; set; }

        [DataMember(Name = "borCommissionPreviousAmount2")]
        public decimal? BorCommissionPreviousAmount2 { get; set; }

        [DataMember(Name = "cobCommissionPreviousYear2")]
        public int? CobCommissionPreviousYear2 { get; set; }

        [DataMember(Name = "cobCommissionPreviousMonths2")]
        public int? CobCommissionPreviousMonths2 { get; set; }

        [DataMember(Name = "cobCommissionPreviousAmount2")]
        public decimal? CobCommissionPreviousAmount2 { get; set; }

        [DataMember(Name = "totalHousingPayment")]
        public decimal? TotalHousingPayment { get; set; }

        [DataMember(Name = "totalMonthlyIncome")]
        public decimal? TotalMonthlyIncome { get; set; }

        [DataMember(Name = "totalMonthlyAssets")]
        public decimal? TotalMonthlyAssets { get; set; }

        [DataMember(Name = "totalMonthlyDebt")]
        public decimal? TotalMonthlyDebt { get; set; }

        [DataMember(Name = "housingRatio")]
        public decimal? HousingRatio { get; set; }

        [DataMember(Name = "totalExpenseRatio")]
        public decimal? TotalExpenseRatio { get; set; }

        [DataMember(Name = "underwritingRiskAssessType")]
        public string UnderwritingRiskAssessType { get; set; }

        [DataMember(Name = "underwritingRiskAssessOther")]
        public string UnderwritingRiskAssessOther { get; set; }

        [DataMember(Name = "ausRecommendation")]
        public string AusRecommendation { get; set; }

        [DataMember(Name = "duCaseIdorLpausKey")]
        public string DuCaseIdorLpausKey { get; set; }

        [DataMember(Name = "freddieDocClass")]
        public string FreddieDocClass { get; set; }

        [DataMember(Name = "submittedBy")]
        public string SubmittedBy { get; set; }

        [DataMember(Name = "submissionDate")]
        public string SubmissionDate { get; set; }

        [DataMember(Name = "submissionTime")]
        public string SubmissionTime { get; set; }

        [DataMember(Name = "firstSubmissionDate")]
        public string FirstSubmissionDate { get; set; }

        [DataMember(Name = "firstSubmissionTime")]
        public string FirstSubmissionTime { get; set; }

        [DataMember(Name = "submissionNumber")]
        public string SubmissionNumber { get; set; }

        [DataMember(Name = "ausVersion")]
        public string AusVersion { get; set; }
    }
}
