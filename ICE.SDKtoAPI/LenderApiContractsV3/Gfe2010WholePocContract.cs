using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Gfe2010WholePocContract
    {
        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "gfe2010WholePocIndex")]
        public int? Gfe2010WholePocIndex { get; set; }

        [DataMember(Name = "wholePoc")]
        public decimal? WholePoc { get; set; }

        [DataMember(Name = "wholePocPaidByType")]
        public string WholePocPaidByType { get; set; }
    }
}
