using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DownPaymentContract
    {
        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "downPaymentType")]
        public string DownPaymentType { get; set; }

        [DataMember(Name = "sourceDescription")]
        public string SourceDescription { get; set; }
    }
}
