using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FeeVarianceOtherContract
    {
        [DataMember(Name = "chargesThatCannotDecreaseInitialLe1")]
        public string ChargesThatCannotDecreaseInitialLe1 { get; set; }

        [DataMember(Name = "chargesThatCannotDecreaseLe1")]
        public string ChargesThatCannotDecreaseLe1 { get; set; }

        [DataMember(Name = "chargesThatCannotDecreaseCd1")]
        public string ChargesThatCannotDecreaseCd1 { get; set; }

        [DataMember(Name = "chargesThatCannotIncreaseInitialLe1")]
        public string ChargesThatCannotIncreaseInitialLe1 { get; set; }

        [DataMember(Name = "chargesThatCannotIncreaseLe1")]
        public string ChargesThatCannotIncreaseLe1 { get; set; }

        [DataMember(Name = "chargesThatCannotIncreaseCd1")]
        public string ChargesThatCannotIncreaseCd1 { get; set; }

        [DataMember(Name = "chargesCannotIncrease10InitialLe1")]
        public string ChargesCannotIncrease10InitialLe1 { get; set; }

        [DataMember(Name = "chargesCannotIncrease10Le1")]
        public string ChargesCannotIncrease10Le1 { get; set; }

        [DataMember(Name = "chargesCannotIncrease10Cd1")]
        public string ChargesCannotIncrease10Cd1 { get; set; }

        [DataMember(Name = "chargesThatCanChangeInitialLe1")]
        public string ChargesThatCanChangeInitialLe1 { get; set; }

        [DataMember(Name = "chargesThatCanChangeLe1")]
        public string ChargesThatCanChangeLe1 { get; set; }

        [DataMember(Name = "chargesThatCanChangeCd1")]
        public string ChargesThatCanChangeCd1 { get; set; }

        [DataMember(Name = "goodFaithAmountInitialLe1")]
        public string GoodFaithAmountInitialLe1 { get; set; }

        [DataMember(Name = "requiredCureAmount")]
        public decimal? RequiredCureAmount { get; set; }

        [DataMember(Name = "appliedCureAmount")]
        public decimal? AppliedCureAmount { get; set; }

        [DataMember(Name = "leInitialGuid")]
        public string LeInitialGuid { get; set; }

        [DataMember(Name = "leLatestGuid")]
        public string LeLatestGuid { get; set; }

        [DataMember(Name = "cdInitialGuid")]
        public string CdInitialGuid { get; set; }

        [DataMember(Name = "cdLatestGuid")]
        public string CdLatestGuid { get; set; }

        [DataMember(Name = "cannotDecreaseLeBaselineGuid")]
        public string CannotDecreaseLeBaselineGuid { get; set; }

        [DataMember(Name = "cannotDecreaseCdBaselineGuid")]
        public string CannotDecreaseCdBaselineGuid { get; set; }

        [DataMember(Name = "cannotIncreaseLeBaselineGuid")]
        public string CannotIncreaseLeBaselineGuid { get; set; }

        [DataMember(Name = "cannotIncreaseCdBaselineGuid")]
        public string CannotIncreaseCdBaselineGuid { get; set; }

        [DataMember(Name = "cannotIncrease10LeBaselineGuid")]
        public string CannotIncrease10LeBaselineGuid { get; set; }

        [DataMember(Name = "cannotIncrease10CdBaselineGuid")]
        public string CannotIncrease10CdBaselineGuid { get; set; }

        [DataMember(Name = "cdPostConGuid")]
        public string CdPostConGuid { get; set; }

        [DataMember(Name = "safeHarborGuid")]
        public string SafeHarborGuid { get; set; }

        [DataMember(Name = "ssplGuid")]
        public string SsplGuid { get; set; }

        [DataMember(Name = "leBaselineUsedCannotDecrease")]
        public bool? LeBaselineUsedCannotDecrease { get; set; }

        [DataMember(Name = "leBaselineUsedCannotIncrease")]
        public bool? LeBaselineUsedCannotIncrease { get; set; }

        [DataMember(Name = "leBaselineUsedCannotIncrease10")]
        public bool? LeBaselineUsedCannotIncrease10 { get; set; }

        [DataMember(Name = "leInitialDtGuid")]
        public string LeInitialDtGuid { get; set; }

        [DataMember(Name = "cdRecentAppliedCure")]
        public string CdRecentAppliedCure { get; set; }

        [DataMember(Name = "disclosureLogGuidForEcd")]
        public string DisclosureLogGuidForEcd { get; set; }

        [DataMember(Name = "disclosureLogGuidReceivedForEcd")]
        public string DisclosureLogGuidReceivedForEcd { get; set; }

        [DataMember(Name = "cdInitialDtGuid")]
        public string CdInitialDtGuid { get; set; }

        [DataMember(Name = "cdRevisedDtGuid")]
        public string CdRevisedDtGuid { get; set; }

        [DataMember(Name = "cdPostConsummationDtGuid")]
        public string CdPostConsummationDtGuid { get; set; }

        [DataMember(Name = "leRevisedSentDateGuid")]
        public string LeRevisedSentDateGuid { get; set; }

        [DataMember(Name = "leInitialReceivedDateGuid")]
        public string LeInitialReceivedDateGuid { get; set; }

        [DataMember(Name = "leRevisedReceivedDateGuid")]
        public string LeRevisedReceivedDateGuid { get; set; }

        [DataMember(Name = "cdInitialReceivedDateGuid")]
        public string CdInitialReceivedDateGuid { get; set; }

        [DataMember(Name = "cdRevisedReceivedDateGuid")]
        public string CdRevisedReceivedDateGuid { get; set; }

        [DataMember(Name = "cureAppliedToLenderCredit")]
        public decimal? CureAppliedToLenderCredit { get; set; }

        [DataMember(Name = "cureAppliedToPrincipalReduction")]
        public decimal? CureAppliedToPrincipalReduction { get; set; }
    }
}
