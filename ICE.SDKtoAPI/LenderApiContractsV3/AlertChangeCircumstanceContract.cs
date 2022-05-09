using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AlertChangeCircumstanceContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "alertChangeCircumstanceIndex")]
        public int AlertChangeCircumstanceIndex { get; set; }

        [DataMember(Name = "alertTriggerFieldId")]
        public string AlertTriggerFieldId { get; set; }

        [DataMember(Name = "changedCircumstanceAlertFeeDescription")]
        public string ChangedCircumstanceAlertFeeDescription { get; set; }

        [DataMember(Name = "changedCircumstanceAlertInitialAmount")]
        public decimal? ChangedCircumstanceAlertInitialAmount { get; set; }

        [DataMember(Name = "changedCircumstanceAlertBaseline")]
        public string ChangedCircumstanceAlertBaseline { get; set; }

        [DataMember(Name = "changedCircumstanceAlertDisclosedAmount")]
        public decimal? ChangedCircumstanceAlertDisclosedAmount { get; set; }

        [DataMember(Name = "changedCircumstanceAlertItemizationAmount")]
        public decimal? ChangedCircumstanceAlertItemizationAmount { get; set; }

        [DataMember(Name = "changedCircumstanceAlertVarianceAmount")]
        public decimal? ChangedCircumstanceAlertVarianceAmount { get; set; }

        [DataMember(Name = "changedCircumstanceDate")]
        public string ChangedCircumstanceDate { get; set; }

        [DataMember(Name = "revisedDueDate")]
        public string RevisedDueDate { get; set; }

        [DataMember(Name = "changedCircumstanceDescription")]
        public string ChangedCircumstanceDescription { get; set; }

        [DataMember(Name = "changedCircumstanceComments")]
        public string ChangedCircumstanceComments { get; set; }

        [DataMember(Name = "changedCircumstanceReason")]
        public string ChangedCircumstanceReason { get; set; }

        [DataMember(Name = "changedCircumstanceReasonOther")]
        public string ChangedCircumstanceReasonOther { get; set; }

        [DataMember(Name = "changedCircumstanceCategory")]
        public string ChangedCircumstanceCategory { get; set; }

    }

    [DataContract]
    public class AlertChangeCircumstanceContractFull : AlertChangeCircumstanceContract
    {

        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
