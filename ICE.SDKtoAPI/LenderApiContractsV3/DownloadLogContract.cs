using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DownloadLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "alerts")]
        public List<LogAlertContract> Alerts { get; set; }

        [DataMember(Name = "barcodePage")]
        public string BarcodePage { get; set; }

        [DataMember(Name = "commentList")]
        public List<LogCommentContract> CommentList { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "receivedDate")]
        public string ReceivedDate { get; set; }

        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "documentId")]
        public string DocumentId { get; set; }

        [DataMember(Name = "downloadId")]
        public string DownloadId { get; set; }

        [DataMember(Name = "fileSource")]
        public string FileSource { get; set; }

        [DataMember(Name = "fileType")]
        public string FileType { get; set; }

        [DataMember(Name = "receivedBy")]
        public string ReceivedBy { get; set; }

        [DataMember(Name = "sender")]
        public string Sender { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
