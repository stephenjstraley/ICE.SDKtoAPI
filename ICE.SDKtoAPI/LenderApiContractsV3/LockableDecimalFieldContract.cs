using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockableDecimalFieldContract
    {
        [DataMember(Name = "useUserValue")]
        public bool UseUserValue { get; set; }

        [DataMember(Name = "userValue")]
        public decimal? UserValue { get; set; }

        [DataMember(Name = "computedValue")]
        public decimal? ComputedValue { get; set; }

    }
}
