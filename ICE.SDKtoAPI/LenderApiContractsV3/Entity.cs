using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Entity
    {
        [DataMember(Name = "modelPathIndex")]
        public int ModelPathIndex { get; set; }

        [DataMember(Name = "parent")]
        public string Parent { get; set; }

        [DataMember(Name = "tempId")]
        public string TempId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "entityId")]
        public string EntityId { get; set; }

        [DataMember(Name = "isEmpty")]
        public bool IsEmpty { get; set; }
    }
}
