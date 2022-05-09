using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Gfe2010FwbcFwscContract
    {
        [DataMember(Name = "lineNumber")]
        public int LineNumber { get; set; }

        [DataMember(Name = "lineLetter")]
        public string LineLetter { get; set; }

        [DataMember(Name = "gfe2010FwbcFwscIndex")]
        public int? Gfe2010FwbcFwscIndex { get; set; }

        [DataMember(Name = "fwbc")]
        public string Fwbc { get; set; }

        [DataMember(Name = "fwsc")]
        public string Fwsc { get; set; }
    }
}
