using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class FieldSchemaContract
    {
        [DataMember(Name = "schema_version")]
        public string SchemaVersion { get; set; }

        [DataMember(Name = "entity_types")]
        public object EntityTypes { get; set; }
    }
}
