using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserPlanContract
    {
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        [DataMember(Name = "plan", EmitDefaultValue = false)]
        public UserPlanPlanContract Plan { get; set; }
    }
}
