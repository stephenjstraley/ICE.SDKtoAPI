using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserLicenseContract
    {
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool Enabled { get; set; }

        [DataMember(Name = "license", EmitDefaultValue = false)]
        public string License { get; set; }

        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }
    }
}
