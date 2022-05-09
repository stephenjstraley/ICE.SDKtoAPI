using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TrackingDefinitionContract
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "open")]
        public bool? Open { get; set; }

        [DataMember(Name = "roles")]
        public List<EntityReferenceContract> Roles { get; set; }
    }
}
