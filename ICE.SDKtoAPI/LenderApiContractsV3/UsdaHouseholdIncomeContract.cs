using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class UsdaHouseholdIncomeContract
    {
        [DataMember(Name = "usdaHouseholdIncomeIndex")]
        public int UsdaHouseholdIncomeIndex { get; set; }

        [DataMember(Name = "age")]
        public int? Age { get; set; }

        [DataMember(Name = "analysisDocumenting")]
        public string AnalysisDocumenting { get; set; }

        [DataMember(Name = "annualNonWageIncome")]
        public decimal? AnnualNonWageIncome { get; set; }

        [DataMember(Name = "annualWageIncome")]
        public decimal? AnnualWageIncome { get; set; }

        [DataMember(Name = "disabledIndicator")]
        public bool? DisabledIndicator { get; set; }

        [DataMember(Name = "fullTimeStudentIndicator")]
        public bool? FullTimeStudentIndicator { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "recordOwnerType")]
        public string RecordOwnerType { get; set; }

        [DataMember(Name = "sourceofNonWageIncomeDescription")]
        public string SourceofNonWageIncomeDescription { get; set; }

        [DataMember(Name = "sourceofWageIncomeEmployerName")]
        public string SourceofWageIncomeEmployerName { get; set; }

    }
}
