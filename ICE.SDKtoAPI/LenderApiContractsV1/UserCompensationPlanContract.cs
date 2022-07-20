using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserCompensationPlanContract
    {
        [DataMember(Name = "userParentInformation")]
        public string UserParentInformation { get; set; }

        [DataMember(Name = "Plans")]
        public List<UserPlanContract> Plans { get; set; }
    }
}
