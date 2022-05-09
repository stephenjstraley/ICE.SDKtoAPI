using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class EntityRefContract
    {
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        [DataMember(Name = "entityName", EmitDefaultValue = false)]
        public string EntityName { get; set; }

        [DataMember(Name = "entityType", EmitDefaultValue = false)]
        public string EntityType { get; set; }

        [DataMember(Name = "entityUri", EmitDefaultValue = false)]
        public string EntityUri { get; set; }
    }
}
