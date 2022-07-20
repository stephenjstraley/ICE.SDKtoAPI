using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCorrespondent
	{
		[DataMember(Name="additionalLateFeeCharge")]
		public decimal? AdditionalLateFeeCharge { get; set; }

		[DataMember(Name="approvedToFundDate")]
		public DateTime? ApprovedToFundDate { get; set; }

		[DataMember(Name="basePrice")]
		public decimal? BasePrice { get; set; }

		[DataMember(Name="cancelledDate")]
		public DateTime? CancelledDate { get; set; }

		[DataMember(Name="commitmentType")]
		public string CommitmentType { get; set; }

		[DataMember(Name="conditionsReceivedDate")]
		public DateTime? ConditionsReceivedDate { get; set; }

		[DataMember(Name="correspondentStatus")]
		public string CorrespondentStatus { get; set; }

		[DataMember(Name="deliveryExpirationDate")]
		public DateTime? DeliveryExpirationDate { get; set; }

		[DataMember(Name="deliveryType")]
		public string DeliveryType { get; set; }

		[DataMember(Name="fundedDate")]
		public DateTime? FundedDate { get; set; }

		[DataMember(Name="gracePeriodDays")]
		public int? GracePeriodDays { get; set; }

		[DataMember(Name="gracePeriodStartDate")]
		public DateTime? GracePeriodStartDate { get; set; }

		[DataMember(Name="gracePeriodStartTrigger")]
		public string GracePeriodStartTrigger { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="initialSuspenseDate")]
		public DateTime? InitialSuspenseDate { get; set; }

		[DataMember(Name="lateDaysBegin")]
		public DateTime? LateDaysBegin { get; set; }

		[DataMember(Name="lateDaysEnd")]
		public DateTime? LateDaysEnd { get; set; }

		[DataMember(Name="lateDaysEndTrigger")]
		public string LateDaysEndTrigger { get; set; }

		[DataMember(Name="lateFeeChargeType")]
		public string LateFeeChargeType { get; set; }

		[DataMember(Name="lateFeeFrequency")]
		public string LateFeeFrequency { get; set; }

		[DataMember(Name="lateFeeNotes")]
		public string LateFeeNotes { get; set; }

		[DataMember(Name="lateFeePercentage")]
		public decimal? LateFeePercentage { get; set; }

		[DataMember(Name="lateFeeTotalPriceAdjustment")]
		public decimal? LateFeeTotalPriceAdjustment { get; set; }

		[DataMember(Name="latestConditionsDate")]
		public DateTime? LatestConditionsDate { get; set; }

		[DataMember(Name="lFSAmount")]
		public decimal? LFSAmount { get; set; }

		[DataMember(Name="lFSCalculateAs")]
		public int? LFSCalculateAs { get; set; }

		[DataMember(Name="lFSDayCleared")]
		public int? LFSDayCleared { get; set; }

		[DataMember(Name="lFSDayClearedOtherDate")]
		public string LFSDayClearedOtherDate { get; set; }

		[DataMember(Name="lFSDayClearedOtherDateValue")]
		public string LFSDayClearedOtherDateValue { get; set; }

		[DataMember(Name="lFSFeeHandledAs")]
		public int? LFSFeeHandledAs { get; set; }

		[DataMember(Name="lFSGracePeriodCalendar")]
		public int? LFSGracePeriodCalendar { get; set; }

		[DataMember(Name="lFSGracePeriodDays")]
		public int? LFSGracePeriodDays { get; set; }

		[DataMember(Name="lFSGracePeriodLaterOf")]
		public int? LFSGracePeriodLaterOf { get; set; }

		[DataMember(Name="lFSGracePeriodStarts")]
		public int? LFSGracePeriodStarts { get; set; }

		[DataMember(Name="lFSIncludeDay")]
		public int? LFSIncludeDay { get; set; }

		[DataMember(Name="lFSLateFee")]
		public decimal? LFSLateFee { get; set; }

		[DataMember(Name="lFSLateFeeBasedOn")]
		public int? LFSLateFeeBasedOn { get; set; }

		[DataMember(Name="lFSMaxLateDays")]
		public int? LFSMaxLateDays { get; set; }

		[DataMember(Name="lFSOtherDate")]
		public string LFSOtherDate { get; set; }

		[DataMember(Name="lFSOtherDateValue")]
		public string LFSOtherDateValue { get; set; }

		[DataMember(Name="lFSStartOnWeekend")]
		public int? LFSStartOnWeekend { get; set; }

		[DataMember(Name="noteDate")]
		public DateTime? NoteDate { get; set; }

		[DataMember(Name="originalPrincipalBalance")]
		public decimal? OriginalPrincipalBalance { get; set; }

		[DataMember(Name="ratesheet")]
		public string Ratesheet { get; set; }

		[DataMember(Name="receivedDate")]
		public DateTime? ReceivedDate { get; set; }

		[DataMember(Name="rejectedDate")]
		public DateTime? RejectedDate { get; set; }

		[DataMember(Name="submittedforPurchaseDate")]
		public DateTime? SubmittedforPurchaseDate { get; set; }

		[DataMember(Name="totalLateDays")]
		public int? TotalLateDays { get; set; }

		[DataMember(Name="totalLateFee")]
		public decimal? TotalLateFee { get; set; }

		[DataMember(Name="unpaidPrincipalBalance")]
		public decimal? UnpaidPrincipalBalance { get; set; }

		[DataMember(Name="voidedDate")]
		public DateTime? VoidedDate { get; set; }

		[DataMember(Name="withdrawalRequestedDate")]
		public DateTime? WithdrawalRequestedDate { get; set; }

		[DataMember(Name="withdrawnDate")]
		public DateTime? WithdrawnDate { get; set; }

	}
}