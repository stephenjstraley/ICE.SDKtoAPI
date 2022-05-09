using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZRegulationZInterestRatePeriods
	{
		[DataMember(Name="adjustmentDate", EmitDefaultValue=false)]
		public DateTime? AdjustmentDate { get; set; }

		[DataMember(Name="adjustmentMonths", EmitDefaultValue=false)]
		public int? AdjustmentMonths { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="interestPayment", EmitDefaultValue=false)]
		public double? InterestPayment { get; set; }

		[DataMember(Name="interestPrincipalPayment", EmitDefaultValue=false)]
		public double? InterestPrincipalPayment { get; set; }

		[DataMember(Name="interestRatePercent", EmitDefaultValue=false)]
		public double? InterestRatePercent { get; set; }

		[DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
		public double? MonthlyPayment { get; set; }

		[DataMember(Name="principalPayment", EmitDefaultValue=false)]
		public double? PrincipalPayment { get; set; }

		[DataMember(Name="regulationZInterestRatePeriodType", EmitDefaultValue=false)]
		public string RegulationZInterestRatePeriodType { get; set; }

		[DataMember(Name="taxInsuranceAmount", EmitDefaultValue=false)]
		public double? TaxInsuranceAmount { get; set; }

		[DataMember(Name="totalPayment", EmitDefaultValue=false)]
		public double? TotalPayment { get; set; }

	}
}