using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TrustAccountContract
    {
        [DataMember(Name = "balance")]
        public decimal? Balance { get; set; }

        [DataMember(Name = "total1")]
        public decimal? Total1 { get; set; }

        [DataMember(Name = "total2")]
        public decimal? Total2 { get; set; }

        [DataMember(Name = "trustAccountItems")]
        public List<TrustAccountItemContract> TrustAccountItems { get; set; }

    }
}
