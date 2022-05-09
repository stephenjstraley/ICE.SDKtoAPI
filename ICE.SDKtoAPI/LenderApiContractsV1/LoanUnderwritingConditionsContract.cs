using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanUnderwritingConditionsContract
    {
        [DataMember(Name = "allowToClear", EmitDefaultValue = false)]
        public bool? AllowToClear { get; set; }

        [DataMember(Name = "application", EmitDefaultValue = false)]
        public EntityRefContract Application { get; set; }

        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        [DataMember(Name = "clearedBy", EmitDefaultValue = false)]
        public EntityRefContract ClearedBy { get; set; }

        [DataMember(Name = "clearedDate", EmitDefaultValue = false)]
        public DateTime? ClearedDate { get; set; }

        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public List<LoanCommentContract> Comments { get; set; }

        [DataMember(Name = "conditionType", EmitDefaultValue = false)]
        public string ConditionType { get; set; }

        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EntityRefContract CreatedBy { get; set; }

        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public DateTime? CreatedDate { get; set; }

        [DataMember(Name = "daysToReceive", EmitDefaultValue = false)]
        public int? DaysToReceive { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "documents", EmitDefaultValue = false)]
        public List<EntityRefContract> Documents { get; set; }

        [DataMember(Name = "expectedDate", EmitDefaultValue = false)]
        public DateTime? ExpectedDate { get; set; }

        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public DateTime? ExpirationDate { get; set; }

        [DataMember(Name = "fulfilledBy", EmitDefaultValue = false)]
        public EntityRefContract FulfilledBy { get; set; }

        [DataMember(Name = "fulfilledDate", EmitDefaultValue = false)]
        public DateTime? FulfilledDate { get; set; }

        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }
        [DataMember(Name = "isAddedToConditionSet", EmitDefaultValue = false)]
        public bool? IsAddedToConditionSet { get; set; }

        [DataMember(Name = "isCleared", EmitDefaultValue = false)]
        public bool? IsCleared { get; set; }

        [DataMember(Name = "isFulfilled", EmitDefaultValue = false)]
        public bool? IsFulfilled { get; set; }

        [DataMember(Name = "isReceived", EmitDefaultValue = false)]
        public bool? IsReceived { get; set; }

        [DataMember(Name = "isRejected", EmitDefaultValue = false)]
        public bool? IsRejected { get; set; }

        [DataMember(Name = "isRemoved", EmitDefaultValue = false)]
        public bool? IsRemoved { get; set; }

        [DataMember(Name = "isRequested", EmitDefaultValue = false)]
        public bool? IsRequested { get; set; }

        [DataMember(Name = "isRerequested", EmitDefaultValue = false)]
        public bool? IsRerequested { get; set; }

        [DataMember(Name = "isReviewed", EmitDefaultValue = false)]
        public bool? IsReviewed { get; set; }

        [DataMember(Name = "isWaived", EmitDefaultValue = false)]
        public bool? IsWaived { get; set; }

        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        [DataMember(Name = "printExternally", EmitDefaultValue = false)]
        public bool? PrintExternally { get; set; }

        [DataMember(Name = "printInternally", EmitDefaultValue = false)]
        public bool? PrintInternally { get; set; }

        [DataMember(Name = "priorTo", EmitDefaultValue = false)]
        public string PriorTo { get; set; }

        [DataMember(Name = "receivedBy", EmitDefaultValue = false)]
        public EntityRefContract ReceivedBy { get; set; }

        [DataMember(Name = "receivedDate", EmitDefaultValue = false)]
        public DateTime? ReceivedDate { get; set; }

        [DataMember(Name = "rejectedBy", EmitDefaultValue = false)]
        public EntityRefContract RejectedBy { get; set; }

        [DataMember(Name = "rejectedDate", EmitDefaultValue = false)]
        public DateTime? RejectedDate { get; set; }

        [DataMember(Name = "requestedBy", EmitDefaultValue = false)]
        public EntityRefContract RequestedBy { get; set; }

        [DataMember(Name = "requestedDate", EmitDefaultValue = false)]
        public DateTime? RequestedDate { get; set; }

        [DataMember(Name = "requestedFrom", EmitDefaultValue = false)]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "rerequestedBy", EmitDefaultValue = false)]
        public EntityRefContract RerequestedBy { get; set; }

        [DataMember(Name = "rerequestedDate", EmitDefaultValue = false)]
        public DateTime? RerequestedDate { get; set; }

        [DataMember(Name = "reviewedBy", EmitDefaultValue = false)]
        public EntityRefContract ReviewedBy { get; set; }

        [DataMember(Name = "reviewedDate", EmitDefaultValue = false)]
        public DateTime? ReviewedDate { get; set; }

        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        [DataMember(Name = "statusDate", EmitDefaultValue = false)]
        public DateTime? StatusDate { get; set; }

        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "tpoConditionDocGuid", EmitDefaultValue = false)]
        public string TpoConditionDocGuid { get; set; }

        [DataMember(Name = "tpoConditionDocType", EmitDefaultValue = false)]
        public string TpoConditionDocType { get; set; }

        [DataMember(Name = "waivedBy", EmitDefaultValue = false)]
        public EntityRefContract WaivedBy { get; set; }

        [DataMember(Name = "waivedDate", EmitDefaultValue = false)]
        public DateTime? WaivedDate { get; set; }
    }
}
