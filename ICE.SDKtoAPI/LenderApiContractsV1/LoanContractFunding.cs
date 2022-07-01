using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFunding
	{
		[DataMember(Name="collateralSentDate", EmitDefaultValue=false)]
		public DateTime? CollateralSentDate { get; set; }

		[DataMember(Name="funderName", EmitDefaultValue=false)]
		public string FunderName { get; set; }

		[DataMember(Name="funderUrl", EmitDefaultValue=false)]
		public string FunderUrl { get; set; }

		[DataMember(Name="fundingClearedBy", EmitDefaultValue=false)]
		public string FundingClearedBy { get; set; }

		[DataMember(Name="fundingCloseDate", EmitDefaultValue=false)]
		public DateTime? FundingCloseDate { get; set; }

		[DataMember(Name="fundingFees", EmitDefaultValue=false)]
		public string FundingFees { get; set; }

		[DataMember(Name="fundingOrderDate", EmitDefaultValue=false)]
		public DateTime? FundingOrderDate { get; set; }

		[DataMember(Name="fundingType", EmitDefaultValue=false)]
		public string FundingType { get; set; }

		[DataMember(Name="fundsReleasedDate", EmitDefaultValue=false)]
		public DateTime? FundsReleasedDate { get; set; }

		[DataMember(Name="fundsReleaseNumber", EmitDefaultValue=false)]
		public string FundsReleaseNumber { get; set; }

		[DataMember(Name="fundsSentDate", EmitDefaultValue=false)]
		public DateTime? FundsSentDate { get; set; }

		[DataMember(Name="fundsWireTo", EmitDefaultValue=false)]
		public string FundsWireTo { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="sentToFunderDate", EmitDefaultValue=false)]
		public DateTime? SentToFunderDate { get; set; }

		[DataMember(Name="wiredToAbaNumber", EmitDefaultValue=false)]
		public string WiredToAbaNumber { get; set; }

		[DataMember(Name="wiredToAccountNumber", EmitDefaultValue=false)]
		public string WiredToAccountNumber { get; set; }

		[DataMember(Name="wiredToForCreditTo", EmitDefaultValue=false)]
		public string WiredToForCreditTo { get; set; }

		[DataMember(Name="wiredToForCreditTo1", EmitDefaultValue=false)]
		public string WiredToForCreditTo1 { get; set; }

		[DataMember(Name="wiredToForCreditTo2", EmitDefaultValue=false)]
		public string WiredToForCreditTo2 { get; set; }

		[DataMember(Name="wiredToForFurtherCreditTo1", EmitDefaultValue=false)]
		public string WiredToForFurtherCreditTo1 { get; set; }

		[DataMember(Name="wiredToForFurtherCreditTo2", EmitDefaultValue=false)]
		public string WiredToForFurtherCreditTo2 { get; set; }

		[DataMember(Name = "wireAmount", EmitDefaultValue = false)]
		public decimal? WireAmount { get; set; }
	}
}