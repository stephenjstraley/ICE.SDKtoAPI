using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractLoanEstimate
	{
		[DataMember(Name="loanProduct", EmitDefaultValue=false)]
		public string LoanProduct { get; set; }

		[DataMember(Name="totalLoanAndOtherCosts2", EmitDefaultValue=false)]
		public string TotalLoanAndOtherCosts2 { get; set; }

		[DataMember(Name="totalLoanCosts2", EmitDefaultValue=false)]
		public string TotalLoanCosts2 { get; set; }

		[DataMember(Name="totalOtherCosts2", EmitDefaultValue=false)]
		public string TotalOtherCosts2 { get; set; }

		[DataMember(Name="unroundedTotalLoanCosts2", EmitDefaultValue=false)]
		public string UnroundedTotalLoanCosts2 { get; set; }

		[DataMember(Name="unroundedTotalOtherCosts2", EmitDefaultValue=false)]
		public string UnroundedTotalOtherCosts2 { get; set; }

	}
}