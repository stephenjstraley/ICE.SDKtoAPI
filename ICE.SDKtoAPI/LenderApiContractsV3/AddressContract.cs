using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AddressContract
    {
        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "street1")]
        public string Street1 { get; set; }

        [DataMember(Name = "street2")]
        public string Street2 { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }
    }
}
