using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ScenarioContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "effectivePropValue")]
        public decimal? EffectivePropValue { get; set; }

        [DataMember(Name = "subordinateFinancingAmount")]
        public decimal? SubordinateFinancingAmount { get; set; }

        [DataMember(Name = "qualFico")]
        public int? QualFico { get; set; }

        [DataMember(Name = "baseLoanAmount")]
        public decimal? BaseLoanAmount { get; set; }

        [DataMember(Name = "totalLoanAmount")]
        public decimal? TotalLoanAmount { get; set; }

        [DataMember(Name = "secondMortgagePandI")]
        public decimal? SecondMortgagePandI { get; set; }

        [DataMember(Name = "qualifyingRate")]
        public decimal? QualifyingRate { get; set; }

        [DataMember(Name = "baseIncome")]
        public decimal? BaseIncome { get; set; }

        [DataMember(Name = "otherIncome")]
        public decimal? OtherIncome { get; set; }

        [DataMember(Name = "positiveCashFlow")]
        public decimal? PositiveCashFlow { get; set; }

        [DataMember(Name = "totalInsurance")]
        public decimal? TotalInsurance { get; set; }

        [DataMember(Name = "totalTaxes")]
        public decimal? TotalTaxes { get; set; }

        [DataMember(Name = "totalInsuranceScenarioData")]
        public decimal? TotalInsuranceScenarioData { get; set; }

        [DataMember(Name = "totalTaxesScenarioData")]
        public decimal? TotalTaxesScenarioData { get; set; }

        [DataMember(Name = "mortgageInsurance")]
        public decimal? MortgageInsurance { get; set; }

        [DataMember(Name = "hoaFees")]
        public decimal? HoaFees { get; set; }

        [DataMember(Name = "leaseOrGroundRent")]
        public decimal? LeaseOrGroundRent { get; set; }

        [DataMember(Name = "otherHousingExpenses")]
        public decimal? OtherHousingExpenses { get; set; }

        [DataMember(Name = "negativeCashFlow")]
        public decimal? NegativeCashFlow { get; set; }

        [DataMember(Name = "allOtherMonthlyPayments")]
        public decimal? AllOtherMonthlyPayments { get; set; }

        [DataMember(Name = "monthlyPaymentTotal")]
        public decimal? MonthlyPaymentTotal { get; set; }

        [DataMember(Name = "required")]
        public decimal? Required { get; set; }

        [DataMember(Name = "verifiedAssets")]
        public decimal? VerifiedAssets { get; set; }

        [DataMember(Name = "verifiedAssetsScenarioData")]
        public decimal? VerifiedAssetsScenarioData { get; set; }

        [DataMember(Name = "interestedPartyContribution")]
        public decimal? InterestedPartyContribution { get; set; }

        [DataMember(Name = "scenarioName")]
        public string ScenarioName { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

    }
}
