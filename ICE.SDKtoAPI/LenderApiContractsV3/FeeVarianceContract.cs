using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FeeVarianceContract
    {
        [DataMember(Name = "feeVarianceFeeType")]
        public string FeeVarianceFeeType { get; set; }

        [DataMember(Name = "feeVarianceChargeIndex")]
        public int? FeeVarianceChargeIndex { get; set; }

        [DataMember(Name = "initialLe")]
        public decimal? InitialLe { get; set; }

        [DataMember(Name = "le")]
        public decimal? Le { get; set; } //= 0.00M;

        [DataMember(Name = "cd")]
        public decimal? Cd { get; set; } //= 0.00M;

        [DataMember(Name = "itemization")]
        public decimal? Itemization { get; set; } //= 0.00M;

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "line")]
        public string Line { get; set; }

        [DataMember(Name = "initialLE")]
        public decimal? InitialLE { get; set; } //= 0.00M;

    }
}
