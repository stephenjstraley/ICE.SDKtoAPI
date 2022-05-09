using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LogCommentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "addedDate")]
        public string AddedDate { get; set; }

        [DataMember(Name = "forRole")]
        public string ForRole { get; set; }

        [DataMember(Name = "reviewedBy")]
        public string ReviewedBy { get; set; }

        [DataMember(Name = "reviewedDate")]
        public string ReviewedDate { get; set; }

        [DataMember(Name = "isExternal")]
        public bool? IsExternal { get; set; }

    }
}
