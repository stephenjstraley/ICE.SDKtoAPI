using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLoanClosingCost
	{
		[DataMember(Name="borrowerClosingCostAtClosing2", EmitDefaultValue=false)]
		public string BorrowerClosingCostAtClosing2 { get; set; }

		[DataMember(Name="financed", EmitDefaultValue=false)]
		public decimal? Financed { get; set; }

		[DataMember(Name="gfe1200BorPaidAmount", EmitDefaultValue=false)]
		public decimal? Gfe1200BorPaidAmount { get; set; }

		[DataMember(Name="gfe800BorPaidAmount", EmitDefaultValue=false)]
		public decimal? Gfe800BorPaidAmount { get; set; }

		[DataMember(Name="lenderCredits", EmitDefaultValue=false)]
		public string LenderCredits { get; set; }

		[DataMember(Name="lenderCredits2", EmitDefaultValue=false)]
		public string LenderCredits2 { get; set; }

		[DataMember(Name="section1000BorrowerTotalPaidAmount", EmitDefaultValue=false)]
		public decimal? Section1000BorrowerTotalPaidAmount { get; set; }

		[DataMember(Name="stdLegalLimit3", EmitDefaultValue=false)]
		public string StdLegalLimit3 { get; set; }

		[DataMember(Name="totalFeeAmount2015", EmitDefaultValue=false)]
		public string TotalFeeAmount2015 { get; set; }

		[DataMember(Name="totalLoanCost2", EmitDefaultValue=false)]
		public string TotalLoanCost2 { get; set; }

		[DataMember(Name="totalOtherCost2", EmitDefaultValue=false)]
		public string TotalOtherCost2 { get; set; }

	}
}