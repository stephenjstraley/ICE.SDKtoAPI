using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TrackingEntryContract
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "user")]
        public string User { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "isChecked")]
        public bool IsChecked { get; set; }
    }
}
