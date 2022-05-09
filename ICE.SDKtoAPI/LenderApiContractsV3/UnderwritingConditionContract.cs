using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class UnderwritingConditionContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "priorTo")]
        public string PriorTo { get; set; }

        [DataMember(Name = "owner")]
        public EntityReferenceContract Owner { get; set; }

        [DataMember(Name = "isOwnerAllowedToClear")]
        public bool? IsOwnerAllowedToClear { get; set; }

        [DataMember(Name = "print")]
        public List<object> Print { get; set; }

        [DataMember(Name = "fulfilledDate")]
        public string FulfilledDate { get; set; }

        [DataMember(Name = "fulfilledBy")]
        public EntityReferenceContract FulfilledBy { get; set; }

        [DataMember(Name = "reviewedDate")]
        public string ReviewedDate { get; set; }

        [DataMember(Name = "reviewedBy")]
        public EntityReferenceContract ReviewedBy { get; set; }

        [DataMember(Name = "rejectedDate")]
        public string RejectedDate { get; set; }

        [DataMember(Name = "rejectedBy")]
        public EntityReferenceContract RejectedBy { get; set; }

        [DataMember(Name = "clearedDate")]
        public string ClearedDate { get; set; }

        [DataMember(Name = "clearedBy")]
        public EntityReferenceContract ClearedBy { get; set; }

        [DataMember(Name = "waivedDate")]
        public string WaivedDate { get; set; }

        [DataMember(Name = "waivedBy")]
        public string WaivedBy { get; set; }

        [DataMember(Name = "expiredDate")]
        public string ExpiredDate { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "borrowerPair")]
        public EntityReferenceContract BorrowerPair { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "daysTillDue")]
        public int? DaysTillDue { get; set; }

        [DataMember(Name = "requestedFrom")]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "addedDate")]
        public string AddedDate { get; set; }

        [DataMember(Name = "addedBy")]
        public EntityReferenceContract AddedBy { get; set; }

        [DataMember(Name = "expectedDate")]
        public string ExpectedDate { get; set; }

        [DataMember(Name = "requestedDate")]
        public string RequestedDate { get; set; }

        [DataMember(Name = "requestedBy")]
        public EntityReferenceContract RequestedBy { get; set; }

        [DataMember(Name = "rerequestedDate")]
        public string RerequestedDate { get; set; }

        [DataMember(Name = "rerequestedBy")]
        public EntityReferenceContract RerequestedBy { get; set; }

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
