using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LogAlertContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "dueDate")]
        public string DueDate { get; set; }

        [DataMember(Name = "followedUpDate")]
        public string FollowedUpDate { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

    }
}
