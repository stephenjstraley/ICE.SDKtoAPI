using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilestoneHistoryLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "changeReason")]
        public string ChangeReason { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "addedDate")]
        public string AddedDate { get; set; }

        [DataMember(Name = "milestoneTemplate")]
        public string MilestoneTemplate { get; set; }

    }
}
