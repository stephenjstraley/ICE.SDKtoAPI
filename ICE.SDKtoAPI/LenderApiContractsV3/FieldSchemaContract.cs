using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FieldSchemaContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }

        [DataMember(Name = "readOnly")]
        public bool ReadOnly { get; set; }

        [DataMember(Name = "nullable")]
        public string Nullable { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "dataType")]
        public string DataType { get; set; }

        [DataMember(Name = "maxLength")]
        public int MaxLength { get; set; }

        [DataMember(Name = "multiInstance")]
        public bool MultiInstance { get; set; }

        [DataMember(Name = "opertions")]
        public List<FieldSchemaOption> Options { get; set; }

        [DataMember(Name = "domainPath")]

        public string DomainPath { get; set; }

        [DataMember(Name = "contractPath")]
        public string ContractPath { get; set; }

        [DataMember(Name = "jsonPath")]
        public string JsonPath { get; set; }

        [DataMember(Name = "entitiesFilterKey")]
        public string EntitiesFilterKey { get; set; }
    }

    [DataContract]
    public class FieldSchemaOption
    {
        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}
