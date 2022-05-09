using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLoanSubmission
	{
		[DataMember(Name="amountAvailable", EmitDefaultValue=false)]
		public double? AmountAvailable { get; set; }

		[DataMember(Name="amountRequiredToClose", EmitDefaultValue=false)]
		public double? AmountRequiredToClose { get; set; }

		[DataMember(Name="buydownDescription", EmitDefaultValue=false)]
		public string BuydownDescription { get; set; }

		[DataMember(Name="buydownMonthsPerAdjustment", EmitDefaultValue=false)]
		public string BuydownMonthsPerAdjustment { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="currentRateSetDate", EmitDefaultValue=false)]
		public DateTime? CurrentRateSetDate { get; set; }

		[DataMember(Name="dateLastPaymentReceived", EmitDefaultValue=false)]
		public DateTime? DateLastPaymentReceived { get; set; }

		[DataMember(Name="floodIndicator", EmitDefaultValue=false)]
		public bool? FloodIndicator { get; set; }

		[DataMember(Name="hazardIndicator", EmitDefaultValue=false)]
		public bool? HazardIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isSecondaryRegistration", EmitDefaultValue=false)]
		public bool? IsSecondaryRegistration { get; set; }

		[DataMember(Name="loanSubmissionFees", EmitDefaultValue=false)]
		public List<LoanContractLoanSubmissionLoanSubmissionFees> LoanSubmissionFees { get; set; }

		[DataMember(Name="lockDate", EmitDefaultValue=false)]
		public DateTime? LockDate { get; set; }

		[DataMember(Name="lockDateTimestampUtc", EmitDefaultValue=false)]
		public DateTime? LockDateTimestampUtc { get; set; }

		[DataMember(Name="lockExpiresDate", EmitDefaultValue=false)]
		public DateTime? LockExpiresDate { get; set; }

		[DataMember(Name="mmmPmiIndicator", EmitDefaultValue=false)]
		public bool? MmmPmiIndicator { get; set; }

		[DataMember(Name="numberOfDays", EmitDefaultValue=false)]
		public int? NumberOfDays { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

		[DataMember(Name="otherIndicator", EmitDefaultValue=false)]
		public bool? OtherIndicator { get; set; }

		[DataMember(Name="programCode", EmitDefaultValue=false)]
		public string ProgramCode { get; set; }

		[DataMember(Name="rateLock", EmitDefaultValue=false)]
		public string RateLock { get; set; }

		[DataMember(Name="rateLockDisclosureDate", EmitDefaultValue=false)]
		public DateTime? RateLockDisclosureDate { get; set; }

		[DataMember(Name="reducedDocsIndicator", EmitDefaultValue=false)]
		public bool? ReducedDocsIndicator { get; set; }

		[DataMember(Name="taxesIndicator", EmitDefaultValue=false)]
		public bool? TaxesIndicator { get; set; }

		[DataMember(Name="total", EmitDefaultValue=false)]
		public double? Total { get; set; }

		[DataMember(Name="totalDiscountPointCharged", EmitDefaultValue=false)]
		public double? TotalDiscountPointCharged { get; set; }

		[DataMember(Name="totalForDueBroker", EmitDefaultValue=false)]
		public double? TotalForDueBroker { get; set; }

		[DataMember(Name="totalForDueLender", EmitDefaultValue=false)]
		public double? TotalForDueLender { get; set; }

		[DataMember(Name="totalForPrimaryResidence", EmitDefaultValue=false)]
		public double? TotalForPrimaryResidence { get; set; }

	}
}