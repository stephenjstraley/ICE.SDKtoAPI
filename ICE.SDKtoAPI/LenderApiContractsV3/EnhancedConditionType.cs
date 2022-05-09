using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionType
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "active")]
        public bool Active { get; set; }

        [DataMember(Name = "definitions")]
        public EnhancedConditionDefinitionContract Definitions { get; set; }
        [DataMember(Name = "createdBy")]
        public EntityReferenceContract CreatedBy { get; set; }

        [DataMember(Name = "createdDate")]
        public DateTime CreatedDate { get; set; }
        [DataMember(Name = "lastModifiedBy")]
        public EntityReferenceContract LastModifiedBy { get; set; }

        [DataMember(Name = "lastModifiedDate")]
        public DateTime LastModifiedDate { get; set; }
    }
}
