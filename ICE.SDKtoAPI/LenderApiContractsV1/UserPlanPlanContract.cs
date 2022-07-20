using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserPlanPlanContract
    {
        [DataMember(Name = "entityId")]
        public string EntityId { get; set; }

        [DataMember(Name = "entityType")]
        public string EntityType { get; set; }

        [DataMember(Name = "entityName")]
        public string EntityName { get; set; }

    }
}
