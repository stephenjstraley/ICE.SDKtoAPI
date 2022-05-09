﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class UserPlanPlanContract
    {
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        [DataMember(Name = "entityName", EmitDefaultValue = false)]
        public string EntityName { get; set; }

    }
}
