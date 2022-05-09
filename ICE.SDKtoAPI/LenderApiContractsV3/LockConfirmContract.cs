using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockConfirmContract
    {
        [DataMember(Name = "alertIndicator")]
        public bool? AlertIndicator { get; set; }

        [DataMember(Name = "buySideExpirationDate")]
        public string BuySideExpirationDate { get; set; }

        [DataMember(Name = "confirmedBy")]
        public string ConfirmedBy { get; set; }

        [DataMember(Name = "confirmedByIdIndicator")]
        public bool? ConfirmedByIdIndicator { get; set; }

        [DataMember(Name = "confirmedById")]
        public string ConfirmedById { get; set; }

        [DataMember(Name = "requestGuid")]
        public string RequestGuid { get; set; }

        [DataMember(Name = "sellSideDeliveredBy")]
        public string SellSideDeliveredBy { get; set; }

        [DataMember(Name = "sellSideDeliveryDate")]
        public string SellSideDeliveryDate { get; set; }

        [DataMember(Name = "sellSideExpirationDate")]
        public string SellSideExpirationDate { get; set; }

        [DataMember(Name = "timeConfirmed")]
        public string TimeConfirmed { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "commitmentTermEnabled")]
        public bool? CommitmentTermEnabled { get; set; }

        [DataMember(Name = "voided")]
        public bool? Voided { get; set; }

        [DataMember(Name = "hideLog")]
        public bool? HideLog { get; set; }

    }
}
