using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Tax4506TClassicContract
    {
        [DataMember(Name = "lastUpdatedHistory")]
        public int? LastUpdatedHistory { get; set; }

    }
}
