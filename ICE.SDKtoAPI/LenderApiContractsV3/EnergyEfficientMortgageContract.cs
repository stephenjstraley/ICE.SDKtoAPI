using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnergyEfficientMortgageContract
    {
        [DataMember(Name = "appraisedValue")]
        public decimal? AppraisedValue { get; set; }

        [DataMember(Name = "auditCost")]
        public decimal? AuditCost { get; set; }

        [DataMember(Name = "backRatio")]
        public decimal? BackRatio { get; set; }

        [DataMember(Name = "baseLoanAmtFromTsum")]
        public decimal? BaseLoanAmtFromTsum { get; set; }

        [DataMember(Name = "costEffectiveEnergyPackage")]
        public decimal? CostEffectiveEnergyPackage { get; set; }

        [DataMember(Name = "eeCostMaximumAmount")]
        public decimal? EeCostMaximumAmount { get; set; }

        [DataMember(Name = "eeImprovementsInstalledCost")]
        public decimal? EeImprovementsInstalledCost { get; set; }

        [DataMember(Name = "energyCost")]
        public decimal? EnergyCost { get; set; }

        [DataMember(Name = "energySavings")]
        public decimal? EnergySavings { get; set; }

        [DataMember(Name = "hoa")]
        public decimal? Hoa { get; set; }

        [DataMember(Name = "improvementCostExceed2000")]
        public decimal? ImprovementCostExceed2000 { get; set; }

        [DataMember(Name = "inspectionCost")]
        public decimal? InspectionCost { get; set; }

        [DataMember(Name = "lesserC1OrC2")]
        public decimal? LesserC1OrC2 { get; set; }

        [DataMember(Name = "monthlyHousingPayment")]
        public decimal? MonthlyHousingPayment { get; set; }

        [DataMember(Name = "monthlyMi")]
        public decimal? MonthlyMi { get; set; }

        [DataMember(Name = "mortgageAmountUsedForQualifyingRate")]
        public decimal? MortgageAmountUsedForQualifyingRate { get; set; }

        [DataMember(Name = "mortgageAmountUsedForQualifyingRateD1")]
        public decimal? MortgageAmountUsedForQualifyingRateD1 { get; set; }

        [DataMember(Name = "newOrExisting")]
        public bool? NewOrExisting { get; set; }

        [DataMember(Name = "originalSalesPriceIfLess12Months")]
        public decimal? OriginalSalesPriceIfLess12Months { get; set; }

        [DataMember(Name = "otherHousingPayment")]
        public decimal? OtherHousingPayment { get; set; }

        [DataMember(Name = "solarNotIncluded")]
        public decimal? SolarNotIncluded { get; set; }

        [DataMember(Name = "solarSystemCostAllowance")]
        public decimal? SolarSystemCostAllowance { get; set; }

        [DataMember(Name = "totalActualAmount")]
        public decimal? TotalActualAmount { get; set; }

        [DataMember(Name = "totalAllowedAmount")]
        public decimal? TotalAllowedAmount { get; set; }

        [DataMember(Name = "totalBaseEemLoanAmount")]
        public decimal? TotalBaseEemLoanAmount { get; set; }

        [DataMember(Name = "totalCombinedLoanAmount")]
        public decimal? TotalCombinedLoanAmount { get; set; }

        [DataMember(Name = "totalMonthlyHousingPayment")]
        public decimal? TotalMonthlyHousingPayment { get; set; }

        [DataMember(Name = "totalMonthlyObligations")]
        public decimal? TotalMonthlyObligations { get; set; }

        [DataMember(Name = "ufmipBasedOn")]
        public decimal? UfmipBasedOn { get; set; }

        [DataMember(Name = "ufmipFactor")]
        public decimal? UfmipFactor { get; set; }
    }
}
