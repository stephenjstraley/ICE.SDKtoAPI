using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUsdaUsdaHouseholdIncomes
	{
		[DataMember(Name="age", EmitDefaultValue=false)]
		public int? Age { get; set; }

		[DataMember(Name="analysisDocumenting", EmitDefaultValue=false)]
		public string AnalysisDocumenting { get; set; }

		[DataMember(Name="annualNonWageIncome", EmitDefaultValue=false)]
		public double? AnnualNonWageIncome { get; set; }

		[DataMember(Name="annualWageIncome", EmitDefaultValue=false)]
		public double? AnnualWageIncome { get; set; }

		[DataMember(Name="disabledIndicator", EmitDefaultValue=false)]
		public bool? DisabledIndicator { get; set; }

		[DataMember(Name="fullTimeStudentIndicator", EmitDefaultValue=false)]
		public bool? FullTimeStudentIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="recordOwnerType", EmitDefaultValue=false)]
		public string RecordOwnerType { get; set; }

		[DataMember(Name="sourceofNonWageIncomeDescription", EmitDefaultValue=false)]
		public string SourceofNonWageIncomeDescription { get; set; }

		[DataMember(Name="sourceofWageIncomeEmployerName", EmitDefaultValue=false)]
		public string SourceofWageIncomeEmployerName { get; set; }

		[DataMember(Name="usdaHouseholdIncomeIndex", EmitDefaultValue=false)]
		public int? UsdaHouseholdIncomeIndex { get; set; }

	}
}