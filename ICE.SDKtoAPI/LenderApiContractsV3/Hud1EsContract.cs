using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Hud1EsContract
    {
        [DataMember(Name = "annualCityTax")]
        public decimal? AnnualCityTax { get; set; }

        [DataMember(Name = "annualFeeCushion")]
        public int? AnnualFeeCushion { get; set; }

        [DataMember(Name = "annualFloodInsurance")]
        public decimal? AnnualFloodInsurance { get; set; }

        [DataMember(Name = "annualHazardInsurance")]
        public decimal? AnnualHazardInsurance { get; set; }

        [DataMember(Name = "annualMortgageInsurance")]
        public decimal? AnnualMortgageInsurance { get; set; }

        [DataMember(Name = "annualTax")]
        public decimal? AnnualTax { get; set; }

        [DataMember(Name = "annualUserEscrow1")]
        public decimal? AnnualUserEscrow1 { get; set; }

        [DataMember(Name = "annualUserEscrow2")]
        public decimal? AnnualUserEscrow2 { get; set; }

        [DataMember(Name = "annualUserEscrow3")]
        public decimal? AnnualUserEscrow3 { get; set; }

        [DataMember(Name = "biweeklyCityPropertyTaxes")]
        public decimal? BiweeklyCityPropertyTaxes { get; set; }

        [DataMember(Name = "biweeklyCountyTaxes")]
        public decimal? BiweeklyCountyTaxes { get; set; }

        [DataMember(Name = "biweeklyFloodInsurance")]
        public decimal? BiweeklyFloodInsurance { get; set; }

        [DataMember(Name = "biweeklyHazardInsurance")]
        public decimal? BiweeklyHazardInsurance { get; set; }

        [DataMember(Name = "biweeklyMortgageInsurance")]
        public decimal? BiweeklyMortgageInsurance { get; set; }

        [DataMember(Name = "biweeklyPiti")]
        public decimal? BiweeklyPiti { get; set; }

        [DataMember(Name = "biweeklyTotalBiweeklyPayment")]
        public decimal? BiweeklyTotalBiweeklyPayment { get; set; }

        [DataMember(Name = "biweeklyTotalBiweeklyPaymentToEscrow")]
        public decimal? BiweeklyTotalBiweeklyPaymentToEscrow { get; set; }

        [DataMember(Name = "biweeklyUsdaFee")]
        public decimal? BiweeklyUsdaFee { get; set; }

        [DataMember(Name = "biweeklyUserDefinedEscrowFee1")]
        public decimal? BiweeklyUserDefinedEscrowFee1 { get; set; }

        [DataMember(Name = "biweeklyUserDefinedEscrowFee2")]
        public decimal? BiweeklyUserDefinedEscrowFee2 { get; set; }

        [DataMember(Name = "biweeklyUserDefinedEscrowFee3")]
        public decimal? BiweeklyUserDefinedEscrowFee3 { get; set; }

        [DataMember(Name = "cityPropertyTaxAddress")]
        public string CityPropertyTaxAddress { get; set; }

        [DataMember(Name = "cityPropertyTaxAmountLastPay")]
        public decimal? CityPropertyTaxAmountLastPay { get; set; }

        [DataMember(Name = "cityPropertyTaxAmountNextDue")]
        public decimal? CityPropertyTaxAmountNextDue { get; set; }

        [DataMember(Name = "cityPropertyTaxCity")]
        public string CityPropertyTaxCity { get; set; }

        [DataMember(Name = "cityPropertyTaxContactName")]
        public string CityPropertyTaxContactName { get; set; }

        [DataMember(Name = "cityPropertyTaxDatePaid")]
        public string CityPropertyTaxDatePaid { get; set; }

        [DataMember(Name = "cityPropertyTaxDelinquentDate")]
        public string CityPropertyTaxDelinquentDate { get; set; }

        [DataMember(Name = "cityPropertyTaxEmail")]
        public string CityPropertyTaxEmail { get; set; }

        [DataMember(Name = "cityPropertyTaxFax")]
        public string CityPropertyTaxFax { get; set; }

        [DataMember(Name = "cityPropertyTaxName")]
        public string CityPropertyTaxName { get; set; }

        [DataMember(Name = "cityPropertyTaxNextDueDate")]
        public string CityPropertyTaxNextDueDate { get; set; }

        [DataMember(Name = "cityPropertyTaxPaymentSchedule")]
        public string CityPropertyTaxPaymentSchedule { get; set; }

        [DataMember(Name = "cityPropertyTaxPhone")]
        public string CityPropertyTaxPhone { get; set; }

        [DataMember(Name = "cityPropertyTaxPostalCode")]
        public string CityPropertyTaxPostalCode { get; set; }

        [DataMember(Name = "cityPropertyTaxState")]
        public string CityPropertyTaxState { get; set; }

        [DataMember(Name = "endingBalance")]
        public decimal? EndingBalance { get; set; }

        [DataMember(Name = "escrowPayment")]
        public decimal? EscrowPayment { get; set; }

        [DataMember(Name = "floodInsDisbCushion")]
        public int? FloodInsDisbCushion { get; set; }

        [DataMember(Name = "hazInsDisbCushion")]
        public int? HazInsDisbCushion { get; set; }

        [DataMember(Name = "hud1EsDates")]
        public List<Hud1EsDateContract> Hud1EsDates { get; set; }

        [DataMember(Name = "hud1EsDueDates")]
        public List<Hud1EsDueDateContract> Hud1EsDueDates { get; set; }

        [DataMember(Name = "hud1EsItemizes")]
        public List<Hud1EsItemizeContract> Hud1EsItemizes { get; set; }

        [DataMember(Name = "hud1EsItemizesTotalLines")]
        public int? Hud1EsItemizesTotalLines { get; set; }

        [DataMember(Name = "hud1EsItemizesUseItemizeEscrowIndicator")]
        public bool? Hud1EsItemizesUseItemizeEscrowIndicator { get; set; }

        [DataMember(Name = "hud1EsPayTos")]
        public List<Hud1EsPayToContract> Hud1EsPayTos { get; set; }

        [DataMember(Name = "hud1EsSetups")]
        public List<Hud1EsSetupContract> Hud1EsSetups { get; set; }

        [DataMember(Name = "mtgInsCushionTerminationIndicator")]
        public bool? MtgInsCushionTerminationIndicator { get; set; }

        [DataMember(Name = "mtgInsDisbCushion")]
        public int? MtgInsDisbCushion { get; set; }

        [DataMember(Name = "realEstateTaxAddress")]
        public string RealEstateTaxAddress { get; set; }

        [DataMember(Name = "realEstateTaxAmountLastPay")]
        public decimal? RealEstateTaxAmountLastPay { get; set; }

        [DataMember(Name = "realEstateTaxAmountNextDue")]
        public decimal? RealEstateTaxAmountNextDue { get; set; }

        [DataMember(Name = "realEstateTaxCity")]
        public string RealEstateTaxCity { get; set; }

        [DataMember(Name = "realEstateTaxContactName")]
        public string RealEstateTaxContactName { get; set; }

        [DataMember(Name = "realEstateTaxDatePaid")]
        public string RealEstateTaxDatePaid { get; set; }

        [DataMember(Name = "realEstateTaxDelinquentDate")]
        public string RealEstateTaxDelinquentDate { get; set; }

        [DataMember(Name = "realEstateTaxEmail")]
        public string RealEstateTaxEmail { get; set; }

        [DataMember(Name = "realEstateTaxFax")]
        public string RealEstateTaxFax { get; set; }

        [DataMember(Name = "realEstateTaxName")]
        public string RealEstateTaxName { get; set; }

        [DataMember(Name = "realEstateTaxNextDueDate")]
        public string RealEstateTaxNextDueDate { get; set; }

        [DataMember(Name = "realEstateTaxPaymentSchedule")]
        public string RealEstateTaxPaymentSchedule { get; set; }

        [DataMember(Name = "realEstateTaxPhone")]
        public string RealEstateTaxPhone { get; set; }

        [DataMember(Name = "realEstateTaxPostalCode")]
        public string RealEstateTaxPostalCode { get; set; }

        [DataMember(Name = "realEstateTaxState")]
        public string RealEstateTaxState { get; set; }

        [DataMember(Name = "schoolTaxesCushion")]
        public int? SchoolTaxesCushion { get; set; }

        [DataMember(Name = "servicerAddress")]
        public string ServicerAddress { get; set; }

        [DataMember(Name = "servicerCity")]
        public string ServicerCity { get; set; }

        [DataMember(Name = "servicerContactName")]
        public string ServicerContactName { get; set; }

        [DataMember(Name = "servicerPhone")]
        public string ServicerPhone { get; set; }

        [DataMember(Name = "servicerPostalCode")]
        public string ServicerPostalCode { get; set; }

        [DataMember(Name = "servicerState")]
        public string ServicerState { get; set; }

        [DataMember(Name = "singleLineAnalysis")]
        public decimal? SingleLineAnalysis { get; set; }

        [DataMember(Name = "startingBalance")]
        public decimal? StartingBalance { get; set; }

        [DataMember(Name = "taxDisbCushion")]
        public int? TaxDisbCushion { get; set; }

        [DataMember(Name = "totalEscrowReserves")]
        public decimal? TotalEscrowReserves { get; set; }

        [DataMember(Name = "usdaAnnualFee")]
        public decimal? UsdaAnnualFee { get; set; }

        [DataMember(Name = "userDefinedCushion1")]
        public int? UserDefinedCushion1 { get; set; }

        [DataMember(Name = "userDefinedCushion2")]
        public int? UserDefinedCushion2 { get; set; }

        [DataMember(Name = "userDefinedCushion3")]
        public int? UserDefinedCushion3 { get; set; }

        [DataMember(Name = "yearlyMortgageInsurance")]
        public decimal? YearlyMortgageInsurance { get; set; }

        [DataMember(Name = "yearlyUsdaFee")]
        public decimal? YearlyUsdaFee { get; set; }

        [DataMember(Name = "escrowPaymentYearly")]
        public decimal? EscrowPaymentYearly { get; set; }

        [DataMember(Name = "nonEscrowCostsYearly")]
        public decimal? NonEscrowCostsYearly { get; set; }

        [DataMember(Name = "escrowFirstPaymentDate")]
        public string EscrowFirstPaymentDate { get; set; }

        [DataMember(Name = "escrowFirstPaymentDateType")]
        public string EscrowFirstPaymentDateType { get; set; }

    }
}
