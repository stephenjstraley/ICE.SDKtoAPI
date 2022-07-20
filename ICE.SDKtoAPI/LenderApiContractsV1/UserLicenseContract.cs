using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserLicenseContract
    {
        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "enabled")]
        public bool Enabled { get; set; }

        [DataMember(Name = "license")]
        public string License { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }
    }
}
