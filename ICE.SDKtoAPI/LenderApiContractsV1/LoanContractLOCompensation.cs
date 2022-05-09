using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLOCompensation
	{
		[DataMember(Name="adjustedPlanAdditonalAmountForBroker", EmitDefaultValue=false)]
		public double? AdjustedPlanAdditonalAmountForBroker { get; set; }

		[DataMember(Name="adjustedPlanAdditonalAmountForOfficer", EmitDefaultValue=false)]
		public double? AdjustedPlanAdditonalAmountForOfficer { get; set; }

		[DataMember(Name="adjustedPlanAmountForBroker", EmitDefaultValue=false)]
		public double? AdjustedPlanAmountForBroker { get; set; }

		[DataMember(Name="adjustedPlanAmountForOfficer", EmitDefaultValue=false)]
		public double? AdjustedPlanAmountForOfficer { get; set; }

		[DataMember(Name="adjustedPlanRateForBroker", EmitDefaultValue=false)]
		public double? AdjustedPlanRateForBroker { get; set; }

		[DataMember(Name="adjustedPlanRateForOfficer", EmitDefaultValue=false)]
		public double? AdjustedPlanRateForOfficer { get; set; }

		[DataMember(Name="adjustmentDescription", EmitDefaultValue=false)]
		public string AdjustmentDescription { get; set; }

		[DataMember(Name="adjustmentDescriptionForOfficer", EmitDefaultValue=false)]
		public string AdjustmentDescriptionForOfficer { get; set; }

		[DataMember(Name="basePlanAdditonalAmountForBroker", EmitDefaultValue=false)]
		public double? BasePlanAdditonalAmountForBroker { get; set; }

		[DataMember(Name="basePlanAdditonalAmountForOfficer", EmitDefaultValue=false)]
		public double? BasePlanAdditonalAmountForOfficer { get; set; }

		[DataMember(Name="basePlanAmountForBroker", EmitDefaultValue=false)]
		public double? BasePlanAmountForBroker { get; set; }

		[DataMember(Name="basePlanAmountForOfficer", EmitDefaultValue=false)]
		public double? BasePlanAmountForOfficer { get; set; }

		[DataMember(Name="basePlanMaximumAmountForBroker", EmitDefaultValue=false)]
		public double? BasePlanMaximumAmountForBroker { get; set; }

		[DataMember(Name="basePlanMaximumAmountForOfficer", EmitDefaultValue=false)]
		public double? BasePlanMaximumAmountForOfficer { get; set; }

		[DataMember(Name="basePlanMinimumAmountForBroker", EmitDefaultValue=false)]
		public double? BasePlanMinimumAmountForBroker { get; set; }

		[DataMember(Name="basePlanMinimumAmountForOfficer", EmitDefaultValue=false)]
		public double? BasePlanMinimumAmountForOfficer { get; set; }

		[DataMember(Name="basePlanRateForBroker", EmitDefaultValue=false)]
		public double? BasePlanRateForBroker { get; set; }

		[DataMember(Name="basePlanRateForOfficer", EmitDefaultValue=false)]
		public double? BasePlanRateForOfficer { get; set; }

		[DataMember(Name="bonusCompAdditonalAmount", EmitDefaultValue=false)]
		public double? BonusCompAdditonalAmount { get; set; }

		[DataMember(Name="bonusCompAmount", EmitDefaultValue=false)]
		public double? BonusCompAmount { get; set; }

		[DataMember(Name="bonusCompRate", EmitDefaultValue=false)]
		public double? BonusCompRate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastAppliedDate", EmitDefaultValue=false)]
		public DateTime? LastAppliedDate { get; set; }

		[DataMember(Name="lastAppliedDateTime", EmitDefaultValue=false)]
		public string LastAppliedDateTime { get; set; }

		[DataMember(Name="loanAmountType", EmitDefaultValue=false)]
		public string LoanAmountType { get; set; }

		[DataMember(Name="loanAmountTypeForOfficer", EmitDefaultValue=false)]
		public string LoanAmountTypeForOfficer { get; set; }

		[DataMember(Name="loanOriginatorID", EmitDefaultValue=false)]
		public string LoanOriginatorID { get; set; }

		[DataMember(Name="loanOriginatorIDForOfficer", EmitDefaultValue=false)]
		public string LoanOriginatorIDForOfficer { get; set; }

		[DataMember(Name="loanOriginatorName", EmitDefaultValue=false)]
		public string LoanOriginatorName { get; set; }

		[DataMember(Name="loanOriginatorNameForOfficer", EmitDefaultValue=false)]
		public string LoanOriginatorNameForOfficer { get; set; }

		[DataMember(Name="netAdjustedAmountForBroker", EmitDefaultValue=false)]
		public double? NetAdjustedAmountForBroker { get; set; }

		[DataMember(Name="netAdjustedAmountForOfficer", EmitDefaultValue=false)]
		public double? NetAdjustedAmountForOfficer { get; set; }

		[DataMember(Name="planDate", EmitDefaultValue=false)]
		public DateTime? PlanDate { get; set; }

		[DataMember(Name="planName", EmitDefaultValue=false)]
		public string PlanName { get; set; }

		[DataMember(Name="planNameForOfficer", EmitDefaultValue=false)]
		public string PlanNameForOfficer { get; set; }

		[DataMember(Name="roundingMethod", EmitDefaultValue=false)]
		public string RoundingMethod { get; set; }

		[DataMember(Name="roundingMethodForOfficer", EmitDefaultValue=false)]
		public string RoundingMethodForOfficer { get; set; }

		[DataMember(Name="triggerField", EmitDefaultValue=false)]
		public string TriggerField { get; set; }

		[DataMember(Name="whoPaidCompensation", EmitDefaultValue=false)]
		public string WhoPaidCompensation { get; set; }

	}
}