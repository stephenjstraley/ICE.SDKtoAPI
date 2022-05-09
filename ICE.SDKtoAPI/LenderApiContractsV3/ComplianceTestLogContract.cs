using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ComplianceTestLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "result")]
        public string Result { get; set; }

        [DataMember(Name = "details")]
        public string Details { get; set; }

        [DataMember(Name = "showAlert")]
        public bool? ShowAlert { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }
    }
}
