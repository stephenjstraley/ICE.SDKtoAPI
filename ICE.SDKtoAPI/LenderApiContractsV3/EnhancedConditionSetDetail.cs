using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionSetDetail
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "conditionType")]
        public string ConditionType { get; set; }

        [DataMember(Name = "active")]
        public bool Active { get; set; } = true;

        [DataMember(Name = "internalId")]
        public string InternalId { get; set; }

        [DataMember(Name = "internalDescription")]
        public string InternalDescription { get; set; }

        [DataMember(Name = "externalId")]
        public string ExternalId { get; set; }

        [DataMember(Name = "externalDescription")]
        public string ExternalDescription { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "priorTo")]
        public string PriorTo { get; set; }

        [DataMember(Name = "daysToReceive")]
        public int DaysToReceive { get; set; } = 0;

        [DataMember(Name = "customizeTypeDefinition")]
        public bool CustomizeTypeDefinition { get; set; } = true;

        [DataMember(Name = "printDefinitions")]
        public List<string> PrintDefinitions { get; set; }

        [DataMember(Name = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        [DataMember(Name = "createdBy")]
        public EntityReferenceContract CreatedBy { get; set; }

        [DataMember(Name = "lastModifiedDate")]
        public DateTime? LastModifiedDate { get; set; }
    }
}
