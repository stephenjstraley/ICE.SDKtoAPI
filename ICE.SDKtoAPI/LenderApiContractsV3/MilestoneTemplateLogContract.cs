using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilestoneTemplateLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "elliLogRecordId")]
        public int ElliLogRecordId { get; set; }

        [DataMember(Name = "milestoneTemplateId")]
        public string MilestoneTemplateId { get; set; }

        [DataMember(Name = "milestoneTemplateName")]
        public string MilestoneTemplateName { get; set; }

        [DataMember(Name = "isTemplateLocked")]
        public bool IsTemplateLocked { get; set; } = false;

        [DataMember(Name = "isTemplateDatesLocked")]
        public bool IsTemplateDatesLocked { get; set; } = false;

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

    }
}
