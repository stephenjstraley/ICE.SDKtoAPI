using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class CustomFieldContract
    {
        [DataMember(Name = "fieldName")]
        public string FieldName { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

        [DataMember(Name = "format")]
        public string Format { get; set; }
    }
}
