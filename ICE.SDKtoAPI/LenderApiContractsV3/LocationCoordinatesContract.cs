using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LocationCoordinatesContract
    {
        [DataMember(Name = "top")]
        public int Top { get; set; }

        [DataMember(Name = "left")]
        public int Left { get; set; }

        [DataMember(Name = "bottom")]
        public int? Bottom { get; set; }

        [DataMember(Name = "right")]
        public int? Right { get; set; }

    }
}
