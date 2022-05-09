using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionTracking
    {
        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "user")]
        public EntityReferenceContract User { get; set; }

        [DataMember(Name = "date")]
        public DateTime date { get; set; }

        [DataMember(Name = "isChecked")]
        public bool IsChecked { get; set; }
    }
}
