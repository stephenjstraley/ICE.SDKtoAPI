using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CustomFieldsContract
    {
        [DataMember(Name = "fieldName")]
        public string FieldName { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }
    }
}
