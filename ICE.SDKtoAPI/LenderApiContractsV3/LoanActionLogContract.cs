using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanActionLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "loanActionType")]
        public string LoanActionType { get; set; }

        [DataMember(Name = "triggeredBy")]
        public string TriggeredBy { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

    }
}
