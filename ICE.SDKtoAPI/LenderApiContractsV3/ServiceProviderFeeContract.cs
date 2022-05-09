using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ServiceProviderFeeContract
    {
        [DataMember(Name = "itemNumber")]
        public int ItemNumber { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
