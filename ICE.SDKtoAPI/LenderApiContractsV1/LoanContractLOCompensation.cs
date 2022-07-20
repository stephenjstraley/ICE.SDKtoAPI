using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLOCompensation
	{
		[DataMember(Name="adjustedPlanAdditonalAmountForBroker")]
		public decimal? AdjustedPlanAdditonalAmountForBroker { get; set; }

		[DataMember(Name="adjustedPlanAdditonalAmountForOfficer")]
		public decimal? AdjustedPlanAdditonalAmountForOfficer { get; set; }

		[DataMember(Name="adjustedPlanAmountForBroker")]
		public decimal? AdjustedPlanAmountForBroker { get; set; }

		[DataMember(Name="adjustedPlanAmountForOfficer")]
		public decimal? AdjustedPlanAmountForOfficer { get; set; }

		[DataMember(Name="adjustedPlanRateForBroker")]
		public decimal? AdjustedPlanRateForBroker { get; set; }

		[DataMember(Name="adjustedPlanRateForOfficer")]
		public decimal? AdjustedPlanRateForOfficer { get; set; }

		[DataMember(Name="adjustmentDescription")]
		public string AdjustmentDescription { get; set; }

		[DataMember(Name="adjustmentDescriptionForOfficer")]
		public string AdjustmentDescriptionForOfficer { get; set; }

		[DataMember(Name="basePlanAdditonalAmountForBroker")]
		public decimal? BasePlanAdditonalAmountForBroker { get; set; }

		[DataMember(Name="basePlanAdditonalAmountForOfficer")]
		public decimal? BasePlanAdditonalAmountForOfficer { get; set; }

		[DataMember(Name="basePlanAmountForBroker")]
		public decimal? BasePlanAmountForBroker { get; set; }

		[DataMember(Name="basePlanAmountForOfficer")]
		public decimal? BasePlanAmountForOfficer { get; set; }

		[DataMember(Name="basePlanMaximumAmountForBroker")]
		public decimal? BasePlanMaximumAmountForBroker { get; set; }

		[DataMember(Name="basePlanMaximumAmountForOfficer")]
		public decimal? BasePlanMaximumAmountForOfficer { get; set; }

		[DataMember(Name="basePlanMinimumAmountForBroker")]
		public decimal? BasePlanMinimumAmountForBroker { get; set; }

		[DataMember(Name="basePlanMinimumAmountForOfficer")]
		public decimal? BasePlanMinimumAmountForOfficer { get; set; }

		[DataMember(Name="basePlanRateForBroker")]
		public decimal? BasePlanRateForBroker { get; set; }

		[DataMember(Name="basePlanRateForOfficer")]
		public decimal? BasePlanRateForOfficer { get; set; }

		[DataMember(Name="bonusCompAdditonalAmount")]
		public decimal? BonusCompAdditonalAmount { get; set; }

		[DataMember(Name="bonusCompAmount")]
		public decimal? BonusCompAmount { get; set; }

		[DataMember(Name="bonusCompRate")]
		public decimal? BonusCompRate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastAppliedDate")]
		public DateTime? LastAppliedDate { get; set; }

		[DataMember(Name="lastAppliedDateTime")]
		public string LastAppliedDateTime { get; set; }

		[DataMember(Name="loanAmountType")]
		public string LoanAmountType { get; set; }

		[DataMember(Name="loanAmountTypeForOfficer")]
		public string LoanAmountTypeForOfficer { get; set; }

		[DataMember(Name="loanOriginatorID")]
		public string LoanOriginatorID { get; set; }

		[DataMember(Name="loanOriginatorIDForOfficer")]
		public string LoanOriginatorIDForOfficer { get; set; }

		[DataMember(Name="loanOriginatorName")]
		public string LoanOriginatorName { get; set; }

		[DataMember(Name="loanOriginatorNameForOfficer")]
		public string LoanOriginatorNameForOfficer { get; set; }

		[DataMember(Name="netAdjustedAmountForBroker")]
		public decimal? NetAdjustedAmountForBroker { get; set; }

		[DataMember(Name="netAdjustedAmountForOfficer")]
		public decimal? NetAdjustedAmountForOfficer { get; set; }

		[DataMember(Name="planDate")]
		public DateTime? PlanDate { get; set; }

		[DataMember(Name="planName")]
		public string PlanName { get; set; }

		[DataMember(Name="planNameForOfficer")]
		public string PlanNameForOfficer { get; set; }

		[DataMember(Name="roundingMethod")]
		public string RoundingMethod { get; set; }

		[DataMember(Name="roundingMethodForOfficer")]
		public string RoundingMethodForOfficer { get; set; }

		[DataMember(Name="triggerField")]
		public string TriggerField { get; set; }

		[DataMember(Name="whoPaidCompensation")]
		public string WhoPaidCompensation { get; set; }

	}
}