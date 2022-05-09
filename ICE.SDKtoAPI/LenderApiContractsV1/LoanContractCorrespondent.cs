using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCorrespondent
	{
		[DataMember(Name="additionalLateFeeCharge", EmitDefaultValue=false)]
		public double? AdditionalLateFeeCharge { get; set; }

		[DataMember(Name="approvedToFundDate", EmitDefaultValue=false)]
		public DateTime? ApprovedToFundDate { get; set; }

		[DataMember(Name="basePrice", EmitDefaultValue=false)]
		public double? BasePrice { get; set; }

		[DataMember(Name="cancelledDate", EmitDefaultValue=false)]
		public DateTime? CancelledDate { get; set; }

		[DataMember(Name="commitmentType", EmitDefaultValue=false)]
		public string CommitmentType { get; set; }

		[DataMember(Name="conditionsReceivedDate", EmitDefaultValue=false)]
		public DateTime? ConditionsReceivedDate { get; set; }

		[DataMember(Name="correspondentStatus", EmitDefaultValue=false)]
		public string CorrespondentStatus { get; set; }

		[DataMember(Name="deliveryExpirationDate", EmitDefaultValue=false)]
		public DateTime? DeliveryExpirationDate { get; set; }

		[DataMember(Name="deliveryType", EmitDefaultValue=false)]
		public string DeliveryType { get; set; }

		[DataMember(Name="fundedDate", EmitDefaultValue=false)]
		public DateTime? FundedDate { get; set; }

		[DataMember(Name="gracePeriodDays", EmitDefaultValue=false)]
		public int? GracePeriodDays { get; set; }

		[DataMember(Name="gracePeriodStartDate", EmitDefaultValue=false)]
		public DateTime? GracePeriodStartDate { get; set; }

		[DataMember(Name="gracePeriodStartTrigger", EmitDefaultValue=false)]
		public string GracePeriodStartTrigger { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialSuspenseDate", EmitDefaultValue=false)]
		public DateTime? InitialSuspenseDate { get; set; }

		[DataMember(Name="lateDaysBegin", EmitDefaultValue=false)]
		public DateTime? LateDaysBegin { get; set; }

		[DataMember(Name="lateDaysEnd", EmitDefaultValue=false)]
		public DateTime? LateDaysEnd { get; set; }

		[DataMember(Name="lateDaysEndTrigger", EmitDefaultValue=false)]
		public string LateDaysEndTrigger { get; set; }

		[DataMember(Name="lateFeeChargeType", EmitDefaultValue=false)]
		public string LateFeeChargeType { get; set; }

		[DataMember(Name="lateFeeFrequency", EmitDefaultValue=false)]
		public string LateFeeFrequency { get; set; }

		[DataMember(Name="lateFeeNotes", EmitDefaultValue=false)]
		public string LateFeeNotes { get; set; }

		[DataMember(Name="lateFeePercentage", EmitDefaultValue=false)]
		public double? LateFeePercentage { get; set; }

		[DataMember(Name="lateFeeTotalPriceAdjustment", EmitDefaultValue=false)]
		public double? LateFeeTotalPriceAdjustment { get; set; }

		[DataMember(Name="latestConditionsDate", EmitDefaultValue=false)]
		public DateTime? LatestConditionsDate { get; set; }

		[DataMember(Name="lFSAmount", EmitDefaultValue=false)]
		public double? LFSAmount { get; set; }

		[DataMember(Name="lFSCalculateAs", EmitDefaultValue=false)]
		public int? LFSCalculateAs { get; set; }

		[DataMember(Name="lFSDayCleared", EmitDefaultValue=false)]
		public int? LFSDayCleared { get; set; }

		[DataMember(Name="lFSDayClearedOtherDate", EmitDefaultValue=false)]
		public string LFSDayClearedOtherDate { get; set; }

		[DataMember(Name="lFSDayClearedOtherDateValue", EmitDefaultValue=false)]
		public string LFSDayClearedOtherDateValue { get; set; }

		[DataMember(Name="lFSFeeHandledAs", EmitDefaultValue=false)]
		public int? LFSFeeHandledAs { get; set; }

		[DataMember(Name="lFSGracePeriodCalendar", EmitDefaultValue=false)]
		public int? LFSGracePeriodCalendar { get; set; }

		[DataMember(Name="lFSGracePeriodDays", EmitDefaultValue=false)]
		public int? LFSGracePeriodDays { get; set; }

		[DataMember(Name="lFSGracePeriodLaterOf", EmitDefaultValue=false)]
		public int? LFSGracePeriodLaterOf { get; set; }

		[DataMember(Name="lFSGracePeriodStarts", EmitDefaultValue=false)]
		public int? LFSGracePeriodStarts { get; set; }

		[DataMember(Name="lFSIncludeDay", EmitDefaultValue=false)]
		public int? LFSIncludeDay { get; set; }

		[DataMember(Name="lFSLateFee", EmitDefaultValue=false)]
		public double? LFSLateFee { get; set; }

		[DataMember(Name="lFSLateFeeBasedOn", EmitDefaultValue=false)]
		public int? LFSLateFeeBasedOn { get; set; }

		[DataMember(Name="lFSMaxLateDays", EmitDefaultValue=false)]
		public int? LFSMaxLateDays { get; set; }

		[DataMember(Name="lFSOtherDate", EmitDefaultValue=false)]
		public string LFSOtherDate { get; set; }

		[DataMember(Name="lFSOtherDateValue", EmitDefaultValue=false)]
		public string LFSOtherDateValue { get; set; }

		[DataMember(Name="lFSStartOnWeekend", EmitDefaultValue=false)]
		public int? LFSStartOnWeekend { get; set; }

		[DataMember(Name="noteDate", EmitDefaultValue=false)]
		public DateTime? NoteDate { get; set; }

		[DataMember(Name="originalPrincipalBalance", EmitDefaultValue=false)]
		public double? OriginalPrincipalBalance { get; set; }

		[DataMember(Name="ratesheet", EmitDefaultValue=false)]
		public string Ratesheet { get; set; }

		[DataMember(Name="receivedDate", EmitDefaultValue=false)]
		public DateTime? ReceivedDate { get; set; }

		[DataMember(Name="rejectedDate", EmitDefaultValue=false)]
		public DateTime? RejectedDate { get; set; }

		[DataMember(Name="submittedforPurchaseDate", EmitDefaultValue=false)]
		public DateTime? SubmittedforPurchaseDate { get; set; }

		[DataMember(Name="totalLateDays", EmitDefaultValue=false)]
		public int? TotalLateDays { get; set; }

		[DataMember(Name="totalLateFee", EmitDefaultValue=false)]
		public double? TotalLateFee { get; set; }

		[DataMember(Name="unpaidPrincipalBalance", EmitDefaultValue=false)]
		public double? UnpaidPrincipalBalance { get; set; }

		[DataMember(Name="voidedDate", EmitDefaultValue=false)]
		public DateTime? VoidedDate { get; set; }

		[DataMember(Name="withdrawalRequestedDate", EmitDefaultValue=false)]
		public DateTime? WithdrawalRequestedDate { get; set; }

		[DataMember(Name="withdrawnDate", EmitDefaultValue=false)]
		public DateTime? WithdrawnDate { get; set; }

	}
}