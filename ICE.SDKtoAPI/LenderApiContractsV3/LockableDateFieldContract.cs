using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockableDateFieldContract
    {
        [DataMember(Name = "userValue")]
        public string UserValue { get; set; }

        [DataMember(Name = "computedValue")]
        public string ComputedValue { get; set; }

        [DataMember(Name = "useUserValue")]
        public bool UseUserValue { get; set; }

    }
}
