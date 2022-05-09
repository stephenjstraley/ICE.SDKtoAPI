using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class NonVolContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "adjustmentDescription")]
        public string AdjustmentDescription { get; set; }

        [DataMember(Name = "adjustmentOtherDescription")]
        public string AdjustmentOtherDescription { get; set; }

        [DataMember(Name = "adjustmentType")]
        public string AdjustmentType { get; set; }

        [DataMember(Name = "adjustmentAmount")]
        public decimal? AdjustmentAmount { get; set; }

        [DataMember(Name = "includedIndicator")]
        public bool? IncludedIndicator { get; set; }

        [DataMember(Name = "pocIndicator")]
        public bool? PocIndicator { get; set; }

        [DataMember(Name = "paidBy")]
        public string PaidBy { get; set; }

        [DataMember(Name = "principalCureAddendum")]
        public string PrincipalCureAddendum { get; set; }

        [DataMember(Name = "paidTo")]
        public string PaidTo { get; set; }
    }

    [DataContract]
    public class NonVolContractFull : NonVolContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
