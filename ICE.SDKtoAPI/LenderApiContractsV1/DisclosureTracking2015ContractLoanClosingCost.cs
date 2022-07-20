using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLoanClosingCost
	{
		[DataMember(Name="borrowerClosingCostAtClosing2")]
		public string BorrowerClosingCostAtClosing2 { get; set; }

		[DataMember(Name="financed")]
		public decimal? Financed { get; set; }

		[DataMember(Name="gfe1200BorPaidAmount")]
		public decimal? Gfe1200BorPaidAmount { get; set; }

		[DataMember(Name="gfe800BorPaidAmount")]
		public decimal? Gfe800BorPaidAmount { get; set; }

		[DataMember(Name="lenderCredits")]
		public string LenderCredits { get; set; }

		[DataMember(Name="lenderCredits2")]
		public string LenderCredits2 { get; set; }

		[DataMember(Name="section1000BorrowerTotalPaidAmount")]
		public decimal? Section1000BorrowerTotalPaidAmount { get; set; }

		[DataMember(Name="stdLegalLimit3")]
		public string StdLegalLimit3 { get; set; }

		[DataMember(Name="totalFeeAmount2015")]
		public string TotalFeeAmount2015 { get; set; }

		[DataMember(Name="totalLoanCost2")]
		public string TotalLoanCost2 { get; set; }

		[DataMember(Name="totalOtherCost2")]
		public string TotalOtherCost2 { get; set; }

	}
}