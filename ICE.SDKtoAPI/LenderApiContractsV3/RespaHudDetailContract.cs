using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class RespaHudDetailContract
    {
        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "creditDebt")]
        public string CreditDebt { get; set; }

        [DataMember(Name = "fwbc")]
        public string Fwbc { get; set; }

        [DataMember(Name = "hud1LineItemFromDate")]
        public string Hud1LineItemFromDate { get; set; }

        [DataMember(Name = "hud1LineItemToDate")]
        public string Hud1LineItemToDate { get; set; }

        [DataMember(Name = "lineItemAmount")]
        public decimal? LineItemAmount { get; set; }

        [DataMember(Name = "lineItemDescription")]
        public string LineItemDescription { get; set; }

        [DataMember(Name = "realValue")]
        public decimal? RealValue { get; set; }

    }
}
