using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRegulationZRegulationZInterestRatePeriods
	{
		[DataMember(Name="adjustmentDate")]
		public DateTime? AdjustmentDate { get; set; }

		[DataMember(Name="adjustmentMonths")]
		public int? AdjustmentMonths { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="interestPayment")]
		public decimal? InterestPayment { get; set; }

		[DataMember(Name="interestPrincipalPayment")]
		public decimal? InterestPrincipalPayment { get; set; }

		[DataMember(Name="interestRatePercent")]
		public decimal? InterestRatePercent { get; set; }

		[DataMember(Name="monthlyPayment")]
		public decimal? MonthlyPayment { get; set; }

		[DataMember(Name="principalPayment")]
		public decimal? PrincipalPayment { get; set; }

		[DataMember(Name="regulationZInterestRatePeriodType")]
		public string RegulationZInterestRatePeriodType { get; set; }

		[DataMember(Name="taxInsuranceAmount")]
		public decimal? TaxInsuranceAmount { get; set; }

		[DataMember(Name="totalPayment")]
		public decimal? TotalPayment { get; set; }

	}
}