using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingCostFeeVarianceOther
	{
		[DataMember(Name="appliedCureAmount")]
		public decimal? AppliedCureAmount { get; set; }

		[DataMember(Name="cannotDecreaseCDBaselineGuid")]
		public string CannotDecreaseCDBaselineGuid { get; set; }

		[DataMember(Name="cannotDecreaseLEBaselineGuid")]
		public string CannotDecreaseLEBaselineGuid { get; set; }

		[DataMember(Name="cannotIncrease10CDBaselineGuid")]
		public string CannotIncrease10CDBaselineGuid { get; set; }

		[DataMember(Name="cannotIncrease10LEBaselineGuid")]
		public string CannotIncrease10LEBaselineGuid { get; set; }

		[DataMember(Name="cannotIncreaseCDBaselineGuid")]
		public string CannotIncreaseCDBaselineGuid { get; set; }

		[DataMember(Name="cannotIncreaseLEBaselineGuid")]
		public string CannotIncreaseLEBaselineGuid { get; set; }

		[DataMember(Name="cDInitialGuid")]
		public string CDInitialGuid { get; set; }

		[DataMember(Name="cDInitialReceivedDateGuid")]
		public string CDInitialReceivedDateGuid { get; set; }

		[DataMember(Name="cDLatestGuid")]
		public string CDLatestGuid { get; set; }

		[DataMember(Name="cDPostConGuid")]
		public string CDPostConGuid { get; set; }

		[DataMember(Name="cDRecentAppliedCure")]
		public string CDRecentAppliedCure { get; set; }

		[DataMember(Name="cDRevisedReceivedDateGuid")]
		public string CDRevisedReceivedDateGuid { get; set; }

		[DataMember(Name="chargesCannotIncrease10CD1")]
		public DateTime? ChargesCannotIncrease10CD1 { get; set; }

		[DataMember(Name="chargesCannotIncrease10InitialLE1")]
		public DateTime? ChargesCannotIncrease10InitialLE1 { get; set; }

		[DataMember(Name="chargesCannotIncrease10LE1")]
		public DateTime? ChargesCannotIncrease10LE1 { get; set; }

		[DataMember(Name="chargesThatCanChangeCD1")]
		public DateTime? ChargesThatCanChangeCD1 { get; set; }

		[DataMember(Name="chargesThatCanChangeInitialLE1")]
		public DateTime? ChargesThatCanChangeInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCanChangeLE1")]
		public DateTime? ChargesThatCanChangeLE1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseCD1")]
		public DateTime? ChargesThatCannotDecreaseCD1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseInitialLE1")]
		public DateTime? ChargesThatCannotDecreaseInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE1")]
		public DateTime? ChargesThatCannotDecreaseLE1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseCD1")]
		public DateTime? ChargesThatCannotIncreaseCD1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseInitialLE1")]
		public DateTime? ChargesThatCannotIncreaseInitialLE1 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE1")]
		public DateTime? ChargesThatCannotIncreaseLE1 { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit")]
		public decimal? CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction")]
		public decimal? CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="disclosureLogGUIDForECD")]
		public string DisclosureLogGUIDForECD { get; set; }

		[DataMember(Name="disclosureLogGUIDReceivedForECD")]
		public string DisclosureLogGUIDReceivedForECD { get; set; }

		[DataMember(Name="goodFaithAmountInitialLE1")]
		public DateTime? GoodFaithAmountInitialLE1 { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lEBaselineUsedCannotDecrease")]
		public bool? LEBaselineUsedCannotDecrease { get; set; }

		[DataMember(Name="lEBaselineUsedCannotIncrease")]
		public bool? LEBaselineUsedCannotIncrease { get; set; }

		[DataMember(Name="lEBaselineUsedCannotIncrease10")]
		public bool? LEBaselineUsedCannotIncrease10 { get; set; }

		[DataMember(Name="lEInitialDTGuid")]
		public string LEInitialDTGuid { get; set; }

		[DataMember(Name="lEInitialGuid")]
		public string LEInitialGuid { get; set; }

		[DataMember(Name="lEInitialReceivedDateGuid")]
		public string LEInitialReceivedDateGuid { get; set; }

		[DataMember(Name="lELatestGuid")]
		public string LELatestGuid { get; set; }

		[DataMember(Name="lERevisedReceivedDateGuid")]
		public string LERevisedReceivedDateGuid { get; set; }

		[DataMember(Name="lERevisedSentDateGuid")]
		public string LERevisedSentDateGuid { get; set; }

		[DataMember(Name="requiredCureAmount")]
		public decimal? RequiredCureAmount { get; set; }

		[DataMember(Name="safeHarborGuid")]
		public string SafeHarborGuid { get; set; }

		[DataMember(Name="sSPLGuid")]
		public string SSPLGuid { get; set; }

		public string CdInitialDtGuid { get; set; }
		public string CdRevisedDtGuid { get; set; }

		public string CdPostConsummationDtGuid { get; set; }

	}
}