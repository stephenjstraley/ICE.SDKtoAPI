using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFees
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="amountPerDay", EmitDefaultValue=false)]
		public double? AmountPerDay { get; set; }

		[DataMember(Name="borPaidAmount", EmitDefaultValue=false)]
		public double? BorPaidAmount { get; set; }

		[DataMember(Name="dateFrom", EmitDefaultValue=false)]
		public DateTime? DateFrom { get; set; }

		[DataMember(Name="dateTo", EmitDefaultValue=false)]
		public DateTime? DateTo { get; set; }

		[DataMember(Name="days", EmitDefaultValue=false)]
		public int? Days { get; set; }

		[DataMember(Name="deedAmount", EmitDefaultValue=false)]
		public double? DeedAmount { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="feeType", EmitDefaultValue=false)]
		public string FeeType { get; set; }

		[DataMember(Name="fHA", EmitDefaultValue=false)]
		public bool? FHA { get; set; }

		[DataMember(Name="fWBC", EmitDefaultValue=false)]
		public string FWBC { get; set; }

		[DataMember(Name="fWSC", EmitDefaultValue=false)]
		public string FWSC { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="includeAboveNumber", EmitDefaultValue=false)]
		public string IncludeAboveNumber { get; set; }

		[DataMember(Name="lenderCoverage", EmitDefaultValue=false)]
		public double? LenderCoverage { get; set; }

		[DataMember(Name="monthlyPayment", EmitDefaultValue=false)]
		public double? MonthlyPayment { get; set; }

		[DataMember(Name="mortgageAmount", EmitDefaultValue=false)]
		public double? MortgageAmount { get; set; }

		[DataMember(Name="newHUDBorPaidAmount", EmitDefaultValue=false)]
		public string NewHUDBorPaidAmount { get; set; }

		[DataMember(Name="numberOfMonths", EmitDefaultValue=false)]
		public int? NumberOfMonths { get; set; }

		[DataMember(Name="ownerCoverage", EmitDefaultValue=false)]
		public double? OwnerCoverage { get; set; }

		[DataMember(Name="paidBy", EmitDefaultValue=false)]
		public string PaidBy { get; set; }

		[DataMember(Name="paidInAdvance", EmitDefaultValue=false)]
		public double? PaidInAdvance { get; set; }

		[DataMember(Name="paidToBroker", EmitDefaultValue=false)]
		public double? PaidToBroker { get; set; }

		[DataMember(Name="paidToName", EmitDefaultValue=false)]
		public string PaidToName { get; set; }

		[DataMember(Name="paidToOthers", EmitDefaultValue=false)]
		public double? PaidToOthers { get; set; }

		[DataMember(Name="percentage", EmitDefaultValue=false)]
		public double? Percentage { get; set; }

		[DataMember(Name="pFC", EmitDefaultValue=false)]
		public bool? PFC { get; set; }

		[DataMember(Name="pOC", EmitDefaultValue=false)]
		public bool? POC { get; set; }

		[DataMember(Name="pTB", EmitDefaultValue=false)]
		public string PTB { get; set; }

		[DataMember(Name="releasesAmount", EmitDefaultValue=false)]
		public double? ReleasesAmount { get; set; }

		[DataMember(Name="sellerPaidAmount", EmitDefaultValue=false)]
		public double? SellerPaidAmount { get; set; }

		[DataMember(Name="truncatedAmountPerDay", EmitDefaultValue=false)]
		public double? TruncatedAmountPerDay { get; set; }

		[DataMember(Name="use4Decimals", EmitDefaultValue=false)]
		public bool? Use4Decimals { get; set; }

	}
}