using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnergyEfficientMortgageItemContract
    {
        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "actualAmount")]
        public decimal? ActualAmount { get; set; }

        [DataMember(Name = "allowedAmount")]
        public decimal? AllowedAmount { get; set; }

        [DataMember(Name = "item")]
        public string Item { get; set; }
    }
}
