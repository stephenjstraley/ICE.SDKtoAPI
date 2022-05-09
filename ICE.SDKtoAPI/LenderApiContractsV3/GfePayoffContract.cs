using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GfePayoffContract
    {
        [DataMember(Name = "gfePayoffIndex")]
        public int GfePayoffIndex { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
