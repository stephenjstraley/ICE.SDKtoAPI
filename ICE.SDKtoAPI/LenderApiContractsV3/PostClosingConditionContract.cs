using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PostClosingConditionContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "recipient")]
        public string Recipient { get; set; }

        [DataMember(Name = "clearedDate")]
        public string ClearedDate { get; set; }

        [DataMember(Name = "clearedBy")]
        public string ClearedBy { get; set; }

        [DataMember(Name = "sentDate")]
        public string SentDate { get; set; }

        [DataMember(Name = "sentBy")]
        public string SentBy { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "borrowerPair")]
        public string BorrowerPair { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "daysTillDue")]
        public int? DaysTillDue { get; set; }

        [DataMember(Name = "requestedFrom")]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "addedDate")]
        public string AddedDate { get; set; }

        [DataMember(Name = "addedBy")]
        public string AddedBy { get; set; }

        [DataMember(Name = "expectedDate")]
        public string ExpectedDate { get; set; }

        [DataMember(Name = "requestedDate")]
        public string RequestedDate { get; set; }

        [DataMember(Name = "requestedBy")]
        public string RequestedBy { get; set; }

        [DataMember(Name = "rerequestedDate")]
        public string RerequestedDate { get; set; }

        [DataMember(Name = "rerequestedBy")]
        public string RerequestedBy { get; set; }

        [DataMember(Name = "receivedDate")]
        public string ReceivedDate { get; set; }

        [DataMember(Name = "receivedBy")]
        public string ReceivedBy { get; set; }

        [DataMember(Name = "isMarkedRemoved")]
        public bool IsMarkedRemoved { get; set; }

        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }

    }
}
