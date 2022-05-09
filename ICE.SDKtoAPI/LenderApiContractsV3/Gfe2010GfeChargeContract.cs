using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Gfe2010GfeChargeContract
    {
        [DataMember(Name = "chargeBelow10Indicator")]
        public bool ChargeBelow10Indicator { get; set; }

        [DataMember(Name = "gfe2010GfeChargeIndex")]
        public int Gfe2010GfeChargeIndex { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "gfeCharge")]
        public decimal? GfeCharge { get; set; }

        [DataMember(Name = "hudCharge")]
        public decimal? HudCharge { get; set; }

        [DataMember(Name = "line")]
        public string Line { get; set; }
    }
}
