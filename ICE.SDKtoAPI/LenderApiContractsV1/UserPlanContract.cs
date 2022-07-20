using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserPlanContract
    {
        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "plan")]
        public UserPlanPlanContract Plan { get; set; }
    }
}
