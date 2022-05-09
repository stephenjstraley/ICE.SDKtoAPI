using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EmailTriggerLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "inLogIndicator")]
        public bool? InLogIndicator { get; set; }

        [DataMember(Name = "recipients")]
        public string Recipients { get; set; }

        [DataMember(Name = "sender")]
        public string Sender { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }
    }
}
