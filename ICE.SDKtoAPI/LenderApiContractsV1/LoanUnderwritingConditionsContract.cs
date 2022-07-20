using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanUnderwritingConditionsContract
    {
        [DataMember(Name = "allowToClear")]
        public bool? AllowToClear { get; set; }

        [DataMember(Name = "application")]
        public EntityRefContract Application { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "clearedBy")]
        public EntityRefContract ClearedBy { get; set; }

        [DataMember(Name = "clearedDate")]
        public DateTime? ClearedDate { get; set; }

        [DataMember(Name = "comments")]
        public List<LoanCommentContract> Comments { get; set; }

        [DataMember(Name = "conditionType")]
        public string ConditionType { get; set; }

        [DataMember(Name = "createdBy")]
        public EntityRefContract CreatedBy { get; set; }

        [DataMember(Name = "createdDate")]
        public DateTime? CreatedDate { get; set; }

        [DataMember(Name = "daysToReceive")]
        public int? DaysToReceive { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "documents")]
        public List<EntityRefContract> Documents { get; set; }

        [DataMember(Name = "expectedDate")]
        public DateTime? ExpectedDate { get; set; }

        [DataMember(Name = "expirationDate")]
        public DateTime? ExpirationDate { get; set; }

        [DataMember(Name = "fulfilledBy")]
        public EntityRefContract FulfilledBy { get; set; }

        [DataMember(Name = "fulfilledDate")]
        public DateTime? FulfilledDate { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "isAddedToConditionSet")]
        public bool? IsAddedToConditionSet { get; set; }

        [DataMember(Name = "isCleared")]
        public bool? IsCleared { get; set; }

        [DataMember(Name = "isFulfilled")]
        public bool? IsFulfilled { get; set; }

        [DataMember(Name = "isReceived")]
        public bool? IsReceived { get; set; }

        [DataMember(Name = "isRejected")]
        public bool? IsRejected { get; set; }

        [DataMember(Name = "isRemoved")]
        public bool? IsRemoved { get; set; }

        [DataMember(Name = "isRequested")]
        public bool? IsRequested { get; set; }

        [DataMember(Name = "isRerequested")]
        public bool? IsRerequested { get; set; }

        [DataMember(Name = "isReviewed")]
        public bool? IsReviewed { get; set; }

        [DataMember(Name = "isWaived")]
        public bool? IsWaived { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "printExternally")]
        public bool? PrintExternally { get; set; }

        [DataMember(Name = "printInternally")]
        public bool? PrintInternally { get; set; }

        [DataMember(Name = "priorTo")]
        public string PriorTo { get; set; }

        [DataMember(Name = "receivedBy")]
        public EntityRefContract ReceivedBy { get; set; }

        [DataMember(Name = "receivedDate")]
        public DateTime? ReceivedDate { get; set; }

        [DataMember(Name = "rejectedBy")]
        public EntityRefContract RejectedBy { get; set; }

        [DataMember(Name = "rejectedDate")]
        public DateTime? RejectedDate { get; set; }

        [DataMember(Name = "requestedBy")]
        public EntityRefContract RequestedBy { get; set; }

        [DataMember(Name = "requestedDate")]
        public DateTime? RequestedDate { get; set; }

        [DataMember(Name = "requestedFrom")]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "rerequestedBy")]
        public EntityRefContract RerequestedBy { get; set; }

        [DataMember(Name = "rerequestedDate")]
        public DateTime? RerequestedDate { get; set; }

        [DataMember(Name = "reviewedBy")]
        public EntityRefContract ReviewedBy { get; set; }

        [DataMember(Name = "reviewedDate")]
        public DateTime? ReviewedDate { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusDate")]
        public DateTime? StatusDate { get; set; }

        [DataMember(Name = "templateId")]
        public string TemplateId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "tpoConditionDocGuid")]
        public string TpoConditionDocGuid { get; set; }

        [DataMember(Name = "tpoConditionDocType")]
        public string TpoConditionDocType { get; set; }

        [DataMember(Name = "waivedBy")]
        public EntityRefContract WaivedBy { get; set; }

        [DataMember(Name = "waivedDate")]
        public DateTime? WaivedDate { get; set; }
    }
}
