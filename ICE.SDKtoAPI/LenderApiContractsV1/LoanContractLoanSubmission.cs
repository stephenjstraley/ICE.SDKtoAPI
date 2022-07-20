using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanSubmission
	{
		[DataMember(Name="amountAvailable")]
		public decimal? AmountAvailable { get; set; }

		[DataMember(Name="amountRequiredToClose")]
		public decimal? AmountRequiredToClose { get; set; }

		[DataMember(Name="buydownDescription")]
		public string BuydownDescription { get; set; }

		[DataMember(Name="buydownMonthsPerAdjustment")]
		public string BuydownMonthsPerAdjustment { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="currentRateSetDate")]
		public DateTime? CurrentRateSetDate { get; set; }

		[DataMember(Name="dateLastPaymentReceived")]
		public DateTime? DateLastPaymentReceived { get; set; }

		[DataMember(Name="floodIndicator")]
		public bool? FloodIndicator { get; set; }

		[DataMember(Name="hazardIndicator")]
		public bool? HazardIndicator { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isSecondaryRegistration")]
		public bool? IsSecondaryRegistration { get; set; }

		[DataMember(Name="loanSubmissionFees")]
		public List<LoanContractLoanSubmissionLoanSubmissionFees> LoanSubmissionFees { get; set; }

		[DataMember(Name="lockDate")]
		public DateTime? LockDate { get; set; }

		[DataMember(Name="lockDateTimestampUtc")]
		public DateTime? LockDateTimestampUtc { get; set; }

		[DataMember(Name="lockExpiresDate")]
		public DateTime? LockExpiresDate { get; set; }

		[DataMember(Name="mmmPmiIndicator")]
		public bool? MmmPmiIndicator { get; set; }

		[DataMember(Name="numberOfDays")]
		public int? NumberOfDays { get; set; }

		[DataMember(Name="otherDescription")]
		public string OtherDescription { get; set; }

		[DataMember(Name="otherIndicator")]
		public bool? OtherIndicator { get; set; }

		[DataMember(Name="programCode")]
		public string ProgramCode { get; set; }

		[DataMember(Name="rateLock")]
		public string RateLock { get; set; }

		[DataMember(Name="rateLockDisclosureDate")]
		public DateTime? RateLockDisclosureDate { get; set; }

		[DataMember(Name="reducedDocsIndicator")]
		public bool? ReducedDocsIndicator { get; set; }

		[DataMember(Name="taxesIndicator")]
		public bool? TaxesIndicator { get; set; }

		[DataMember(Name="total")]
		public decimal? Total { get; set; }

		[DataMember(Name="totalDiscountPointCharged")]
		public decimal? TotalDiscountPointCharged { get; set; }

		[DataMember(Name="totalForDueBroker")]
		public decimal? TotalForDueBroker { get; set; }

		[DataMember(Name="totalForDueLender")]
		public decimal? TotalForDueLender { get; set; }

		[DataMember(Name="totalForPrimaryResidence")]
		public decimal? TotalForPrimaryResidence { get; set; }

	}
}