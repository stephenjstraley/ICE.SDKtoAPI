using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LogSnapshotFieldContract
    {
        [DataMember(Name = "fieldId")]
        public string FieldId { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }

    }
}
