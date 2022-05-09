using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractHudLoanDataSecondaryFinancingProviders
	{
		[DataMember(Name="financingAmount", EmitDefaultValue=false)]
		public double? FinancingAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="secondaryFinancingProviderType", EmitDefaultValue=false)]
		public string SecondaryFinancingProviderType { get; set; }

		[DataMember(Name="sellerFundedDapIndicator", EmitDefaultValue=false)]
		public bool? SellerFundedDapIndicator { get; set; }

		[DataMember(Name="source", EmitDefaultValue=false)]
		public string Source { get; set; }

		[DataMember(Name="sourceFromFamilyIndicator", EmitDefaultValue=false)]
		public bool? SourceFromFamilyIndicator { get; set; }

		[DataMember(Name="sourceFromGovernmentIndicator", EmitDefaultValue=false)]
		public bool? SourceFromGovernmentIndicator { get; set; }

		[DataMember(Name="sourceFromNPIndicator", EmitDefaultValue=false)]
		public bool? SourceFromNPIndicator { get; set; }

		[DataMember(Name="sourceFromOtherIndicator", EmitDefaultValue=false)]
		public bool? SourceFromOtherIndicator { get; set; }

		[DataMember(Name="sourceOtherDetail", EmitDefaultValue=false)]
		public string SourceOtherDetail { get; set; }

	}
}