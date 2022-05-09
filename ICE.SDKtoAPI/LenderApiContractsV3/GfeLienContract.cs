using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GfeLienContract
    {
        [DataMember(Name = "gfeLienType")]
        public string GfeLienType { get; set; }

        [DataMember(Name = "gfeLienIndex")]
        public int GfeLienIndex { get; set; }

        [DataMember(Name = "amountOwing")]
        public decimal? AmountOwing { get; set; }

        [DataMember(Name = "holderName")]
        public string HolderName { get; set; }

        [DataMember(Name = "priority")]
        public string Priority { get; set; }
    }
}
