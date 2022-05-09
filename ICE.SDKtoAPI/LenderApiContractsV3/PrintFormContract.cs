using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PrintFormContract
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

    }
}
