using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFees
	{
		[DataMember(Name="amount")]
		public decimal? Amount { get; set; }

		[DataMember(Name="amountPerDay")]
		public decimal? AmountPerDay { get; set; }

		[DataMember(Name="borPaidAmount")]
		public decimal? BorPaidAmount { get; set; }

		[DataMember(Name="dateFrom")]
		public DateTime? DateFrom { get; set; }

		[DataMember(Name="dateTo")]
		public DateTime? DateTo { get; set; }

		[DataMember(Name="days")]
		public int? Days { get; set; }

		[DataMember(Name="deedAmount")]
		public decimal? DeedAmount { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="feeType")]
		public string FeeType { get; set; }

		[DataMember(Name="fHA")]
		public bool? FHA { get; set; }

		[DataMember(Name="fWBC")]
		public string FWBC { get; set; }

		[DataMember(Name="fWSC")]
		public string FWSC { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="includeAboveNumber")]
		public string IncludeAboveNumber { get; set; }

		[DataMember(Name="lenderCoverage")]
		public decimal? LenderCoverage { get; set; }

		[DataMember(Name="monthlyPayment")]
		public decimal? MonthlyPayment { get; set; }

		[DataMember(Name="mortgageAmount")]
		public decimal? MortgageAmount { get; set; }

		[DataMember(Name="newHUDBorPaidAmount")]
		public string NewHUDBorPaidAmount { get; set; }

		[DataMember(Name="numberOfMonths")]
		public int? NumberOfMonths { get; set; }

		[DataMember(Name="ownerCoverage")]
		public decimal? OwnerCoverage { get; set; }

		[DataMember(Name="paidBy")]
		public string PaidBy { get; set; }

		[DataMember(Name="paidInAdvance")]
		public decimal? PaidInAdvance { get; set; }

		[DataMember(Name="paidToBroker")]
		public decimal? PaidToBroker { get; set; }

		[DataMember(Name="paidToName")]
		public string PaidToName { get; set; }

		[DataMember(Name="paidToOthers")]
		public decimal? PaidToOthers { get; set; }

		[DataMember(Name="percentage")]
		public decimal? Percentage { get; set; }

		[DataMember(Name="pFC")]
		public bool? PFC { get; set; }

		[DataMember(Name="pOC")]
		public bool? POC { get; set; }

		[DataMember(Name="pTB")]
		public string PTB { get; set; }

		[DataMember(Name="releasesAmount")]
		public decimal? ReleasesAmount { get; set; }

		[DataMember(Name="sellerPaidAmount")]
		public decimal? SellerPaidAmount { get; set; }

		[DataMember(Name="truncatedAmountPerDay")]
		public decimal? TruncatedAmountPerDay { get; set; }

		[DataMember(Name = "use4Decimals")]
		public bool? Use4Decimals { get; set; } = false;

	}
}