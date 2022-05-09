using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanProductDataHelocRepaymentDrawPeriods
	{
		[DataMember(Name="apr", EmitDefaultValue=false)]
		public double? Apr { get; set; }

		[DataMember(Name="drawIndicator", EmitDefaultValue=false)]
		public bool? DrawIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="indexRatePercent", EmitDefaultValue=false)]
		public double? IndexRatePercent { get; set; }

		[DataMember(Name="marginRatePercent", EmitDefaultValue=false)]
		public double? MarginRatePercent { get; set; }

		[DataMember(Name="minimumMonthlyPaymentAmount", EmitDefaultValue=false)]
		public double? MinimumMonthlyPaymentAmount { get; set; }

		[DataMember(Name="year", EmitDefaultValue=false)]
		public int? Year { get; set; }

	}
}