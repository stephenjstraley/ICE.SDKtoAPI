using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionCommentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "addedBy")]
        public EntityReferenceContract AddedBy { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "addedDate")]
        public DateTime? AddedDate { get; set; }

        [DataMember(Name = "forRole")]
        public EntityReferenceContract ForRole { get; set; }

        [DataMember(Name = "reviewedBy")]
        public EntityReferenceContract ReviewedBy { get; set; }

        [DataMember(Name = "reviewedDate")]
        public DateTime? ReviewedDate { get; set; }

        [DataMember(Name = "isExternal")]
        public bool? IsExternal { get; set; }
    }
}
