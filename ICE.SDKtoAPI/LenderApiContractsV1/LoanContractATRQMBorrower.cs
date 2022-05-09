using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractATRQMBorrower
	{
		[DataMember(Name="aTRQMBorrowerIndex", EmitDefaultValue=false)]
		public int? ATRQMBorrowerIndex { get; set; }

		[DataMember(Name="aUSRecommendation", EmitDefaultValue=false)]
		public string AUSRecommendation { get; set; }

		[DataMember(Name="aUSVersion", EmitDefaultValue=false)]
		public string AUSVersion { get; set; }

		[DataMember(Name="borBonusAverageOvertime", EmitDefaultValue=false)]
		public double? BorBonusAverageOvertime { get; set; }

		[DataMember(Name="borBonusMostRecentAmount", EmitDefaultValue=false)]
		public double? BorBonusMostRecentAmount { get; set; }

		[DataMember(Name="borBonusMostRecentMonths", EmitDefaultValue=false)]
		public int? BorBonusMostRecentMonths { get; set; }

		[DataMember(Name="borBonusMostRecentYear", EmitDefaultValue=false)]
		public int? BorBonusMostRecentYear { get; set; }

		[DataMember(Name="borBonusPreviousAmount1", EmitDefaultValue=false)]
		public double? BorBonusPreviousAmount1 { get; set; }

		[DataMember(Name="borBonusPreviousAmount2", EmitDefaultValue=false)]
		public double? BorBonusPreviousAmount2 { get; set; }

		[DataMember(Name="borBonusPreviousMonths1", EmitDefaultValue=false)]
		public int? BorBonusPreviousMonths1 { get; set; }

		[DataMember(Name="borBonusPreviousMonths2", EmitDefaultValue=false)]
		public int? BorBonusPreviousMonths2 { get; set; }

		[DataMember(Name="borBonusPreviousYear1", EmitDefaultValue=false)]
		public int? BorBonusPreviousYear1 { get; set; }

		[DataMember(Name="borBonusPreviousYear2", EmitDefaultValue=false)]
		public int? BorBonusPreviousYear2 { get; set; }

		[DataMember(Name="borCommissionAverageOvertime", EmitDefaultValue=false)]
		public double? BorCommissionAverageOvertime { get; set; }

		[DataMember(Name="borCommissionMostRecentAmount", EmitDefaultValue=false)]
		public double? BorCommissionMostRecentAmount { get; set; }

		[DataMember(Name="borCommissionMostRecentMonths", EmitDefaultValue=false)]
		public int? BorCommissionMostRecentMonths { get; set; }

		[DataMember(Name="borCommissionMostRecentYear", EmitDefaultValue=false)]
		public int? BorCommissionMostRecentYear { get; set; }

		[DataMember(Name="borCommissionPreviousAmount1", EmitDefaultValue=false)]
		public double? BorCommissionPreviousAmount1 { get; set; }

		[DataMember(Name="borCommissionPreviousAmount2", EmitDefaultValue=false)]
		public double? BorCommissionPreviousAmount2 { get; set; }

		[DataMember(Name="borCommissionPreviousMonths1", EmitDefaultValue=false)]
		public int? BorCommissionPreviousMonths1 { get; set; }

		[DataMember(Name="borCommissionPreviousMonths2", EmitDefaultValue=false)]
		public int? BorCommissionPreviousMonths2 { get; set; }

		[DataMember(Name="borCommissionPreviousYear1", EmitDefaultValue=false)]
		public int? BorCommissionPreviousYear1 { get; set; }

		[DataMember(Name="borCommissionPreviousYear2", EmitDefaultValue=false)]
		public int? BorCommissionPreviousYear2 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityAmount1", EmitDefaultValue=false)]
		public double? BorContingentLiabilitiesLiabilityAmount1 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityAmount2", EmitDefaultValue=false)]
		public double? BorContingentLiabilitiesLiabilityAmount2 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityAmount3", EmitDefaultValue=false)]
		public double? BorContingentLiabilitiesLiabilityAmount3 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityDescription1", EmitDefaultValue=false)]
		public string BorContingentLiabilitiesLiabilityDescription1 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityDescription2", EmitDefaultValue=false)]
		public string BorContingentLiabilitiesLiabilityDescription2 { get; set; }

		[DataMember(Name="borContingentLiabilitiesLiabilityDescription3", EmitDefaultValue=false)]
		public string BorContingentLiabilitiesLiabilityDescription3 { get; set; }

		[DataMember(Name="borContingentLiabilitiesTotalLiabilityAmount", EmitDefaultValue=false)]
		public double? BorContingentLiabilitiesTotalLiabilityAmount { get; set; }

		[DataMember(Name="borCosignedObligationsCarLoanPayment", EmitDefaultValue=false)]
		public double? BorCosignedObligationsCarLoanPayment { get; set; }

		[DataMember(Name="borCosignedObligationsMortgagePayment", EmitDefaultValue=false)]
		public double? BorCosignedObligationsMortgagePayment { get; set; }

		[DataMember(Name="borCosignedObligationsOtherPayment", EmitDefaultValue=false)]
		public double? BorCosignedObligationsOtherPayment { get; set; }

		[DataMember(Name="borCosignedObligationsOtherPaymentDescription", EmitDefaultValue=false)]
		public string BorCosignedObligationsOtherPaymentDescription { get; set; }

		[DataMember(Name="borCosignedObligationsStudentLoanPayment", EmitDefaultValue=false)]
		public double? BorCosignedObligationsStudentLoanPayment { get; set; }

		[DataMember(Name="borCosignedObligationsTotalCoMortgagorLiabilities", EmitDefaultValue=false)]
		public double? BorCosignedObligationsTotalCoMortgagorLiabilities { get; set; }

		[DataMember(Name="borDividendAverageDividend", EmitDefaultValue=false)]
		public double? BorDividendAverageDividend { get; set; }

		[DataMember(Name="borDividendPreviousAmount1", EmitDefaultValue=false)]
		public double? BorDividendPreviousAmount1 { get; set; }

		[DataMember(Name="borDividendPreviousAmount2", EmitDefaultValue=false)]
		public double? BorDividendPreviousAmount2 { get; set; }

		[DataMember(Name="borDividendPreviousMonths1", EmitDefaultValue=false)]
		public int? BorDividendPreviousMonths1 { get; set; }

		[DataMember(Name="borDividendPreviousMonths2", EmitDefaultValue=false)]
		public int? BorDividendPreviousMonths2 { get; set; }

		[DataMember(Name="borDividendPreviousYear1", EmitDefaultValue=false)]
		public int? BorDividendPreviousYear1 { get; set; }

		[DataMember(Name="borDividendPreviousYear2", EmitDefaultValue=false)]
		public int? BorDividendPreviousYear2 { get; set; }

		[DataMember(Name="borDividendRequiredForCashAmount", EmitDefaultValue=false)]
		public double? BorDividendRequiredForCashAmount { get; set; }

		[DataMember(Name="borInterestAverageDividend", EmitDefaultValue=false)]
		public double? BorInterestAverageDividend { get; set; }

		[DataMember(Name="borInterestPreviousAmount1", EmitDefaultValue=false)]
		public double? BorInterestPreviousAmount1 { get; set; }

		[DataMember(Name="borInterestPreviousAmount2", EmitDefaultValue=false)]
		public double? BorInterestPreviousAmount2 { get; set; }

		[DataMember(Name="borInterestPreviousMonths1", EmitDefaultValue=false)]
		public int? BorInterestPreviousMonths1 { get; set; }

		[DataMember(Name="borInterestPreviousMonths2", EmitDefaultValue=false)]
		public int? BorInterestPreviousMonths2 { get; set; }

		[DataMember(Name="borInterestPreviousYear1", EmitDefaultValue=false)]
		public int? BorInterestPreviousYear1 { get; set; }

		[DataMember(Name="borInterestPreviousYear2", EmitDefaultValue=false)]
		public int? BorInterestPreviousYear2 { get; set; }

		[DataMember(Name="borInterestRequiredForCashAmount", EmitDefaultValue=false)]
		public double? BorInterestRequiredForCashAmount { get; set; }

		[DataMember(Name="borMilitaryAllowanceClothingAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceClothingAllowance { get; set; }

		[DataMember(Name="borMilitaryAllowanceOtherAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceOtherAllowance { get; set; }

		[DataMember(Name="borMilitaryAllowanceOtherAllowanceDescription", EmitDefaultValue=false)]
		public string BorMilitaryAllowanceOtherAllowanceDescription { get; set; }

		[DataMember(Name="borMilitaryAllowanceQuartersAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceQuartersAllowance { get; set; }

		[DataMember(Name="borMilitaryAllowanceRationsAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceRationsAllowance { get; set; }

		[DataMember(Name="borMilitaryAllowanceTotalAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceTotalAllowance { get; set; }

		[DataMember(Name="borMilitaryAllowanceVariableHousingAllowance", EmitDefaultValue=false)]
		public double? BorMilitaryAllowanceVariableHousingAllowance { get; set; }

		[DataMember(Name="borMilitaryBasePay", EmitDefaultValue=false)]
		public double? BorMilitaryBasePay { get; set; }

		[DataMember(Name="borMilitaryCombatPay", EmitDefaultValue=false)]
		public double? BorMilitaryCombatPay { get; set; }

		[DataMember(Name="borMilitaryFlightPay", EmitDefaultValue=false)]
		public double? BorMilitaryFlightPay { get; set; }

		[DataMember(Name="borMilitaryHazardPay", EmitDefaultValue=false)]
		public double? BorMilitaryHazardPay { get; set; }

		[DataMember(Name="borMilitaryOverseasPay", EmitDefaultValue=false)]
		public double? BorMilitaryOverseasPay { get; set; }

		[DataMember(Name="borMilitaryPropPay", EmitDefaultValue=false)]
		public double? BorMilitaryPropPay { get; set; }

		[DataMember(Name="borMilitaryTotalPay", EmitDefaultValue=false)]
		public double? BorMilitaryTotalPay { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeBaseIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeBaseIncome { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeBonuseIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeBonuseIncome { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeCommissionIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeCommissionIncome { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeDividendInterestIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeDividendInterestIncome { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeOtherIncome1", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeOtherIncome1 { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeOtherIncome2", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeOtherIncome2 { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeOvertimeIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeOvertimeIncome { get; set; }

		[DataMember(Name="borMonthlyEmplymentIncomeTotalEmploymentIncome", EmitDefaultValue=false)]
		public double? BorMonthlyEmplymentIncomeTotalEmploymentIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeGovtAssitProgramIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeGovtAssitProgramIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeHomeownSubsidyIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeHomeownSubsidyIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeIsOffsetHomeownSubsidyIncome", EmitDefaultValue=false)]
		public bool? BorNonEmploymentIncomeIsOffsetHomeownSubsidyIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome", EmitDefaultValue=false)]
		public bool? BorNonEmploymentIncomeIsOffsetMtgCreditCertificateIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeMilitaryIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeMilitaryIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeMtgCreditCertificateIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeTotalNonEmploymentIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }

		[DataMember(Name="borNonEmploymentIncomeVABenefitIncome", EmitDefaultValue=false)]
		public double? BorNonEmploymentIncomeVABenefitIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeChildSupportIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeChildSupportIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeDisabilityIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeDisabilityIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeFedGovtEmplRetirementIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeMilitaryAllowances", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeMilitaryAllowances { get; set; }

		[DataMember(Name="borNonTaxableIncomeOtherIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeOtherIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomePublicAssistPayments", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomePublicAssistPayments { get; set; }

		[DataMember(Name="borNonTaxableIncomeRailroadRetirementBenefits", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeRailroadRetirementBenefits { get; set; }

		[DataMember(Name="borNonTaxableIncomeSocialSecurityIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeSocialSecurityIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeStateGovtEmplRetirementIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }

		[DataMember(Name="borNonTaxableIncomeTotalNonTaxableIncome", EmitDefaultValue=false)]
		public double? BorNonTaxableIncomeTotalNonTaxableIncome { get; set; }

		[DataMember(Name="borOtherNotesReceivableIncome", EmitDefaultValue=false)]
		public double? BorOtherNotesReceivableIncome { get; set; }

		[DataMember(Name="borOtherOtherIncome", EmitDefaultValue=false)]
		public double? BorOtherOtherIncome { get; set; }

		[DataMember(Name="borOtherParttimeIncome", EmitDefaultValue=false)]
		public double? BorOtherParttimeIncome { get; set; }

		[DataMember(Name="borOtherRetirementIncome", EmitDefaultValue=false)]
		public double? BorOtherRetirementIncome { get; set; }

		[DataMember(Name="borOtherSeasonalIncome", EmitDefaultValue=false)]
		public double? BorOtherSeasonalIncome { get; set; }

		[DataMember(Name="borOtherSocialSecurityIncome", EmitDefaultValue=false)]
		public double? BorOtherSocialSecurityIncome { get; set; }

		[DataMember(Name="borOtherTipIncome", EmitDefaultValue=false)]
		public double? BorOtherTipIncome { get; set; }

		[DataMember(Name="borOtherTrustIncome", EmitDefaultValue=false)]
		public double? BorOtherTrustIncome { get; set; }

		[DataMember(Name="borOtherUnemploymentIncome", EmitDefaultValue=false)]
		public double? BorOtherUnemploymentIncome { get; set; }

		[DataMember(Name="borOvertimeAverageOvertime", EmitDefaultValue=false)]
		public double? BorOvertimeAverageOvertime { get; set; }

		[DataMember(Name="borOvertimeMostRecentAmount", EmitDefaultValue=false)]
		public double? BorOvertimeMostRecentAmount { get; set; }

		[DataMember(Name="borOvertimeMostRecentMonths", EmitDefaultValue=false)]
		public int? BorOvertimeMostRecentMonths { get; set; }

		[DataMember(Name="borOvertimeMostRecentYear", EmitDefaultValue=false)]
		public int? BorOvertimeMostRecentYear { get; set; }

		[DataMember(Name="borOvertimePreviousAmount1", EmitDefaultValue=false)]
		public double? BorOvertimePreviousAmount1 { get; set; }

		[DataMember(Name="borOvertimePreviousAmount2", EmitDefaultValue=false)]
		public double? BorOvertimePreviousAmount2 { get; set; }

		[DataMember(Name="borOvertimePreviousMonths1", EmitDefaultValue=false)]
		public int? BorOvertimePreviousMonths1 { get; set; }

		[DataMember(Name="borOvertimePreviousMonths2", EmitDefaultValue=false)]
		public int? BorOvertimePreviousMonths2 { get; set; }

		[DataMember(Name="borOvertimePreviousYear1", EmitDefaultValue=false)]
		public int? BorOvertimePreviousYear1 { get; set; }

		[DataMember(Name="borOvertimePreviousYear2", EmitDefaultValue=false)]
		public int? BorOvertimePreviousYear2 { get; set; }

		[DataMember(Name="borProjectedIncomeProjectedBonuses", EmitDefaultValue=false)]
		public double? BorProjectedIncomeProjectedBonuses { get; set; }

		[DataMember(Name="borProjectedIncomeProjectedCostLivingAdjustment", EmitDefaultValue=false)]
		public double? BorProjectedIncomeProjectedCostLivingAdjustment { get; set; }

		[DataMember(Name="borProjectedIncomeProjectedNewJobIncome", EmitDefaultValue=false)]
		public double? BorProjectedIncomeProjectedNewJobIncome { get; set; }

		[DataMember(Name="borProjectedIncomeProjectedPerformanceRaises", EmitDefaultValue=false)]
		public double? BorProjectedIncomeProjectedPerformanceRaises { get; set; }

		[DataMember(Name="borProjectedIncomeTotalProjectedIncome", EmitDefaultValue=false)]
		public double? BorProjectedIncomeTotalProjectedIncome { get; set; }

		[DataMember(Name="cobBonusAverageOvertime", EmitDefaultValue=false)]
		public double? CobBonusAverageOvertime { get; set; }

		[DataMember(Name="cobBonusMostRecentAmount", EmitDefaultValue=false)]
		public double? CobBonusMostRecentAmount { get; set; }

		[DataMember(Name="cobBonusMostRecentMonths", EmitDefaultValue=false)]
		public int? CobBonusMostRecentMonths { get; set; }

		[DataMember(Name="cobBonusMostRecentYear", EmitDefaultValue=false)]
		public int? CobBonusMostRecentYear { get; set; }

		[DataMember(Name="cobBonusPreviousAmount1", EmitDefaultValue=false)]
		public double? CobBonusPreviousAmount1 { get; set; }

		[DataMember(Name="cobBonusPreviousAmount2", EmitDefaultValue=false)]
		public double? CobBonusPreviousAmount2 { get; set; }

		[DataMember(Name="cobBonusPreviousMonths1", EmitDefaultValue=false)]
		public int? CobBonusPreviousMonths1 { get; set; }

		[DataMember(Name="cobBonusPreviousMonths2", EmitDefaultValue=false)]
		public int? CobBonusPreviousMonths2 { get; set; }

		[DataMember(Name="cobBonusPreviousYear1", EmitDefaultValue=false)]
		public int? CobBonusPreviousYear1 { get; set; }

		[DataMember(Name="cobBonusPreviousYear2", EmitDefaultValue=false)]
		public int? CobBonusPreviousYear2 { get; set; }

		[DataMember(Name="cobCommissionAverageOvertime", EmitDefaultValue=false)]
		public double? CobCommissionAverageOvertime { get; set; }

		[DataMember(Name="cobCommissionMostRecentAmount", EmitDefaultValue=false)]
		public double? CobCommissionMostRecentAmount { get; set; }

		[DataMember(Name="cobCommissionMostRecentMonths", EmitDefaultValue=false)]
		public int? CobCommissionMostRecentMonths { get; set; }

		[DataMember(Name="cobCommissionMostRecentYear", EmitDefaultValue=false)]
		public int? CobCommissionMostRecentYear { get; set; }

		[DataMember(Name="cobCommissionPreviousAmount1", EmitDefaultValue=false)]
		public double? CobCommissionPreviousAmount1 { get; set; }

		[DataMember(Name="cobCommissionPreviousAmount2", EmitDefaultValue=false)]
		public double? CobCommissionPreviousAmount2 { get; set; }

		[DataMember(Name="cobCommissionPreviousMonths1", EmitDefaultValue=false)]
		public int? CobCommissionPreviousMonths1 { get; set; }

		[DataMember(Name="cobCommissionPreviousMonths2", EmitDefaultValue=false)]
		public int? CobCommissionPreviousMonths2 { get; set; }

		[DataMember(Name="cobCommissionPreviousYear1", EmitDefaultValue=false)]
		public int? CobCommissionPreviousYear1 { get; set; }

		[DataMember(Name="cobCommissionPreviousYear2", EmitDefaultValue=false)]
		public int? CobCommissionPreviousYear2 { get; set; }

		[DataMember(Name="cobDividendAverageDividend", EmitDefaultValue=false)]
		public double? CobDividendAverageDividend { get; set; }

		[DataMember(Name="cobDividendPreviousAmount1", EmitDefaultValue=false)]
		public double? CobDividendPreviousAmount1 { get; set; }

		[DataMember(Name="cobDividendPreviousAmount2", EmitDefaultValue=false)]
		public double? CobDividendPreviousAmount2 { get; set; }

		[DataMember(Name="cobDividendPreviousMonths1", EmitDefaultValue=false)]
		public int? CobDividendPreviousMonths1 { get; set; }

		[DataMember(Name="cobDividendPreviousMonths2", EmitDefaultValue=false)]
		public int? CobDividendPreviousMonths2 { get; set; }

		[DataMember(Name="cobDividendPreviousYear1", EmitDefaultValue=false)]
		public int? CobDividendPreviousYear1 { get; set; }

		[DataMember(Name="cobDividendPreviousYear2", EmitDefaultValue=false)]
		public int? CobDividendPreviousYear2 { get; set; }

		[DataMember(Name="cobInterestAverageDividend", EmitDefaultValue=false)]
		public double? CobInterestAverageDividend { get; set; }

		[DataMember(Name="cobInterestPreviousAmount1", EmitDefaultValue=false)]
		public double? CobInterestPreviousAmount1 { get; set; }

		[DataMember(Name="cobInterestPreviousAmount2", EmitDefaultValue=false)]
		public double? CobInterestPreviousAmount2 { get; set; }

		[DataMember(Name="cobInterestPreviousMonths1", EmitDefaultValue=false)]
		public int? CobInterestPreviousMonths1 { get; set; }

		[DataMember(Name="cobInterestPreviousMonths2", EmitDefaultValue=false)]
		public int? CobInterestPreviousMonths2 { get; set; }

		[DataMember(Name="cobInterestPreviousYear1", EmitDefaultValue=false)]
		public int? CobInterestPreviousYear1 { get; set; }

		[DataMember(Name="cobInterestPreviousYear2", EmitDefaultValue=false)]
		public int? CobInterestPreviousYear2 { get; set; }

		[DataMember(Name="cobInterestRequiredForCashAmount", EmitDefaultValue=false)]
		public double? CobInterestRequiredForCashAmount { get; set; }

		[DataMember(Name="cobMilitaryAllowanceClothingAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceClothingAllowance { get; set; }

		[DataMember(Name="cobMilitaryAllowanceOtherAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceOtherAllowance { get; set; }

		[DataMember(Name="cobMilitaryAllowanceQuartersAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceQuartersAllowance { get; set; }

		[DataMember(Name="cobMilitaryAllowanceRationsAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceRationsAllowance { get; set; }

		[DataMember(Name="cobMilitaryAllowanceTotalAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceTotalAllowance { get; set; }

		[DataMember(Name="cobMilitaryAllowanceVariableHousingAllowance", EmitDefaultValue=false)]
		public double? CobMilitaryAllowanceVariableHousingAllowance { get; set; }

		[DataMember(Name="cobMilitaryBasePay", EmitDefaultValue=false)]
		public double? CobMilitaryBasePay { get; set; }

		[DataMember(Name="cobMilitaryCombatPay", EmitDefaultValue=false)]
		public double? CobMilitaryCombatPay { get; set; }

		[DataMember(Name="cobMilitaryFlightPay", EmitDefaultValue=false)]
		public double? CobMilitaryFlightPay { get; set; }

		[DataMember(Name="cobMilitaryHazardPay", EmitDefaultValue=false)]
		public double? CobMilitaryHazardPay { get; set; }

		[DataMember(Name="cobMilitaryOverseasPay", EmitDefaultValue=false)]
		public double? CobMilitaryOverseasPay { get; set; }

		[DataMember(Name="cobMilitaryPropPay", EmitDefaultValue=false)]
		public double? CobMilitaryPropPay { get; set; }

		[DataMember(Name="cobMilitaryTotalPay", EmitDefaultValue=false)]
		public double? CobMilitaryTotalPay { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeBaseIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeBaseIncome { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeBonuseIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeBonuseIncome { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeCommissionIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeCommissionIncome { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeDividendInterestIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeDividendInterestIncome { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeOtherIncome1", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeOtherIncome1 { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeOtherIncome2", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeOtherIncome2 { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeOvertimeIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeOvertimeIncome { get; set; }

		[DataMember(Name="cobMonthlyEmplymentIncomeTotalEmploymentIncome", EmitDefaultValue=false)]
		public double? CobMonthlyEmplymentIncomeTotalEmploymentIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeGovtAssitProgramIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeGovtAssitProgramIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeHomeownSubsidyIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeHomeownSubsidyIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeMilitaryIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeMilitaryIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeMtgCreditCertificateIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeMtgCreditCertificateIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeTotalNonEmploymentIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeTotalNonEmploymentIncome { get; set; }

		[DataMember(Name="cobNonEmploymentIncomeVABenefitIncome", EmitDefaultValue=false)]
		public double? CobNonEmploymentIncomeVABenefitIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeChildSupportIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeChildSupportIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeDisabilityIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeDisabilityIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeFedGovtEmplRetirementIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeFedGovtEmplRetirementIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeMilitaryAllowances", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeMilitaryAllowances { get; set; }

		[DataMember(Name="cobNonTaxableIncomeOtherIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeOtherIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomePublicAssistPayments", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomePublicAssistPayments { get; set; }

		[DataMember(Name="cobNonTaxableIncomeRailroadRetirementBenefits", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeRailroadRetirementBenefits { get; set; }

		[DataMember(Name="cobNonTaxableIncomeSocialSecurityIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeSocialSecurityIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeStateGovtEmplRetirementIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeStateGovtEmplRetirementIncome { get; set; }

		[DataMember(Name="cobNonTaxableIncomeTotalNonTaxableIncome", EmitDefaultValue=false)]
		public double? CobNonTaxableIncomeTotalNonTaxableIncome { get; set; }

		[DataMember(Name="cobOtherNotesReceivableIncome", EmitDefaultValue=false)]
		public double? CobOtherNotesReceivableIncome { get; set; }

		[DataMember(Name="cobOtherOtherIncome", EmitDefaultValue=false)]
		public double? CobOtherOtherIncome { get; set; }

		[DataMember(Name="cobOtherParttimeIncome", EmitDefaultValue=false)]
		public double? CobOtherParttimeIncome { get; set; }

		[DataMember(Name="cobOtherRetirementIncome", EmitDefaultValue=false)]
		public double? CobOtherRetirementIncome { get; set; }

		[DataMember(Name="cobOtherSeasonalIncome", EmitDefaultValue=false)]
		public double? CobOtherSeasonalIncome { get; set; }

		[DataMember(Name="cobOtherSocialSecurityIncome", EmitDefaultValue=false)]
		public double? CobOtherSocialSecurityIncome { get; set; }

		[DataMember(Name="cobOtherTipIncome", EmitDefaultValue=false)]
		public double? CobOtherTipIncome { get; set; }

		[DataMember(Name="cobOtherTrustIncome", EmitDefaultValue=false)]
		public double? CobOtherTrustIncome { get; set; }

		[DataMember(Name="cobOtherUnemploymentIncome", EmitDefaultValue=false)]
		public double? CobOtherUnemploymentIncome { get; set; }

		[DataMember(Name="cobOvertimeAverageOvertime", EmitDefaultValue=false)]
		public double? CobOvertimeAverageOvertime { get; set; }

		[DataMember(Name="cobOvertimeMostRecentAmount", EmitDefaultValue=false)]
		public double? CobOvertimeMostRecentAmount { get; set; }

		[DataMember(Name="cobOvertimeMostRecentMonths", EmitDefaultValue=false)]
		public int? CobOvertimeMostRecentMonths { get; set; }

		[DataMember(Name="cobOvertimeMostRecentYear", EmitDefaultValue=false)]
		public int? CobOvertimeMostRecentYear { get; set; }

		[DataMember(Name="cobOvertimePreviousAmount1", EmitDefaultValue=false)]
		public double? CobOvertimePreviousAmount1 { get; set; }

		[DataMember(Name="cobOvertimePreviousAmount2", EmitDefaultValue=false)]
		public double? CobOvertimePreviousAmount2 { get; set; }

		[DataMember(Name="cobOvertimePreviousMonths1", EmitDefaultValue=false)]
		public int? CobOvertimePreviousMonths1 { get; set; }

		[DataMember(Name="cobOvertimePreviousMonths2", EmitDefaultValue=false)]
		public int? CobOvertimePreviousMonths2 { get; set; }

		[DataMember(Name="cobOvertimePreviousYear1", EmitDefaultValue=false)]
		public int? CobOvertimePreviousYear1 { get; set; }

		[DataMember(Name="cobOvertimePreviousYear2", EmitDefaultValue=false)]
		public int? CobOvertimePreviousYear2 { get; set; }

		[DataMember(Name="cobProjectedIncomeProjectedBonuses", EmitDefaultValue=false)]
		public double? CobProjectedIncomeProjectedBonuses { get; set; }

		[DataMember(Name="cobProjectedIncomeProjectedCostLivingAdjustment", EmitDefaultValue=false)]
		public double? CobProjectedIncomeProjectedCostLivingAdjustment { get; set; }

		[DataMember(Name="cobProjectedIncomeProjectedNewJobIncome", EmitDefaultValue=false)]
		public double? CobProjectedIncomeProjectedNewJobIncome { get; set; }

		[DataMember(Name="cobProjectedIncomeProjectedPerformanceRaises", EmitDefaultValue=false)]
		public double? CobProjectedIncomeProjectedPerformanceRaises { get; set; }

		[DataMember(Name="cobProjectedIncomeTotalProjectedIncome", EmitDefaultValue=false)]
		public double? CobProjectedIncomeTotalProjectedIncome { get; set; }

		[DataMember(Name="dUCaseIDorLPAUSKey", EmitDefaultValue=false)]
		public string DUCaseIDorLPAUSKey { get; set; }

		[DataMember(Name="firstSubmissionDate", EmitDefaultValue=false)]
		public DateTime? FirstSubmissionDate { get; set; }

		[DataMember(Name="firstSubmissionTime", EmitDefaultValue=false)]
		public string FirstSubmissionTime { get; set; }

		[DataMember(Name="freddieDocClass", EmitDefaultValue=false)]
		public string FreddieDocClass { get; set; }

		[DataMember(Name="housingRatio", EmitDefaultValue=false)]
		public double? HousingRatio { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isEmpty", EmitDefaultValue=false)]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="submissionDate", EmitDefaultValue=false)]
		public DateTime? SubmissionDate { get; set; }

		[DataMember(Name="submissionNumber", EmitDefaultValue=false)]
		public string SubmissionNumber { get; set; }

		[DataMember(Name="submissionTime", EmitDefaultValue=false)]
		public string SubmissionTime { get; set; }

		[DataMember(Name="submittedBy", EmitDefaultValue=false)]
		public string SubmittedBy { get; set; }

		[DataMember(Name="totalExpenseRatio", EmitDefaultValue=false)]
		public double? TotalExpenseRatio { get; set; }

		[DataMember(Name="totalHousingPayment", EmitDefaultValue=false)]
		public double? TotalHousingPayment { get; set; }

		[DataMember(Name="totalMonthlyAssets", EmitDefaultValue=false)]
		public double? TotalMonthlyAssets { get; set; }

		[DataMember(Name="totalMonthlyDebt", EmitDefaultValue=false)]
		public double? TotalMonthlyDebt { get; set; }

		[DataMember(Name="totalMonthlyIncome", EmitDefaultValue=false)]
		public double? TotalMonthlyIncome { get; set; }

		[DataMember(Name="underwritingRiskAssessOther", EmitDefaultValue=false)]
		public string UnderwritingRiskAssessOther { get; set; }

		[DataMember(Name="underwritingRiskAssessType", EmitDefaultValue=false)]
		public string UnderwritingRiskAssessType { get; set; }

	}
}