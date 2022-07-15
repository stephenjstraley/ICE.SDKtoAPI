using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostFeeVarianceOther
	{
		[DataMember(Name="appliedCureAmount", EmitDefaultValue=false)]
		public double? AppliedCureAmount { get; set; }

		[DataMember(Name="cannotDecreaseCDBaselineGuid", EmitDefaultValue=false)]
		public string CannotDecreaseCDBaselineGuid { get; set; }

		[DataMember(Name="cannotDecreaseLEBaselineGuid", EmitDefaultValue=false)]
		public string CannotDecreaseLEBaselineGuid { get; set; }

		[DataMember(Name="cannotIncrease10CDBaselineGuid", EmitDefaultValue=false)]
		public string CannotIncrease10CDBaselineGuid { get; set; }

		[DataMember(Name="cannotIncrease10LEBaselineGuid", EmitDefaultValue=false)]
		public string CannotIncrease10LEBaselineGuid { get; set; }

		[DataMember(Name="cannotIncreaseCDBaselineGuid", EmitDefaultValue=false)]
		public string CannotIncreaseCDBaselineGuid { get; set; }

		[DataMember(Name="cannotIncreaseLEBaselineGuid", EmitDefaultValue=false)]
		public string CannotIncreaseLEBaselineGuid { get; set; }

		[DataMember(Name="cDInitialGuid", EmitDefaultValue=false)]
		public string CDInitialGuid { get; set; }

		[DataMember(Name="cDInitialReceivedDateGuid", EmitDefaultValue=false)]
		public string CDInitialReceivedDateGuid { get; set; }

		[DataMember(Name="cDLatestGuid", EmitDefaultValue=false)]
		public string CDLatestGuid { get; set; }

		[DataMember(Name="cDPostConGuid", EmitDefaultValue=false)]
		public string CDPostConGuid { get; set; }

		[DataMember(Name="cDRecentAppliedCure", EmitDefaultValue=false)]
		public string CDRecentAppliedCure { get; set; }

		[DataMember(Name="cDRevisedReceivedDateGuid", EmitDefaultValue=false)]
		public string CDRevisedReceivedDateGuid { get; set; }

		[DataMember(Name="chargesCannotIncrease10CD1", EmitDefaultValue=false)]
		public DateTime? ChargesCannotIncrease10CD1 { get; set; }

		[DataMember(Name="chargesCannotIncrease10InitialLE1", EmitDefaultValue=false)]
		public DateTime? ChargesCannotIncrease10InitialLE1 { get; set; }

		[DataMember(Name="chargesCannotIncrease10LE1", EmitDefaultValue=false)]
		public DateTime? ChargesCannotIncrease10LE1 { get; set; }

		[DataMember(Name="chargesThatCanChangeCD1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCanChangeCD1 { get; set; }

		[DataMember(Name="chargesThatCanChangeInitialLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCanChangeInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCanChangeLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCanChangeLE1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseCD1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotDecreaseCD1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseInitialLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotDecreaseInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotDecreaseLE1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseCD1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotIncreaseCD1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseInitialLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotIncreaseInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE1", EmitDefaultValue=false)]
		public DateTime? ChargesThatCannotIncreaseLE1 { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit", EmitDefaultValue=false)]
		public double? CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction", EmitDefaultValue=false)]
		public double? CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="disclosureLogGUIDForECD", EmitDefaultValue=false)]
		public string DisclosureLogGUIDForECD { get; set; }

		[DataMember(Name="disclosureLogGUIDReceivedForECD", EmitDefaultValue=false)]
		public string DisclosureLogGUIDReceivedForECD { get; set; }

		[DataMember(Name="goodFaithAmountInitialLE1", EmitDefaultValue=false)]
		public DateTime? GoodFaithAmountInitialLE1 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lEBaselineUsedCannotDecrease", EmitDefaultValue=false)]
		public bool? LEBaselineUsedCannotDecrease { get; set; }

		[DataMember(Name="lEBaselineUsedCannotIncrease", EmitDefaultValue=false)]
		public bool? LEBaselineUsedCannotIncrease { get; set; }

		[DataMember(Name="lEBaselineUsedCannotIncrease10", EmitDefaultValue=false)]
		public bool? LEBaselineUsedCannotIncrease10 { get; set; }

		[DataMember(Name="lEInitialDTGuid", EmitDefaultValue=false)]
		public string LEInitialDTGuid { get; set; }

		[DataMember(Name="lEInitialGuid", EmitDefaultValue=false)]
		public string LEInitialGuid { get; set; }

		[DataMember(Name="lEInitialReceivedDateGuid", EmitDefaultValue=false)]
		public string LEInitialReceivedDateGuid { get; set; }

		[DataMember(Name="lELatestGuid", EmitDefaultValue=false)]
		public string LELatestGuid { get; set; }

		[DataMember(Name="lERevisedReceivedDateGuid", EmitDefaultValue=false)]
		public string LERevisedReceivedDateGuid { get; set; }

		[DataMember(Name="lERevisedSentDateGuid", EmitDefaultValue=false)]
		public string LERevisedSentDateGuid { get; set; }

		[DataMember(Name="requiredCureAmount", EmitDefaultValue=false)]
		public double? RequiredCureAmount { get; set; }

		[DataMember(Name="safeHarborGuid", EmitDefaultValue=false)]
		public string SafeHarborGuid { get; set; }

		[DataMember(Name="sSPLGuid", EmitDefaultValue=false)]
		public string SSPLGuid { get; set; }

		public string CdInitialDtGuid { get; set; }
		public string CdRevisedDtGuid { get; set; }

		public string CdPostConsummationDtGuid { get; set; }

	}
}