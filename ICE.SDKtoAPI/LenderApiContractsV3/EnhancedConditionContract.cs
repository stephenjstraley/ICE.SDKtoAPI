using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "conditionType")]
        public string ConditionType { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "internalId")]
        public string InternalId { get; set; }

        [DataMember(Name = "internalDescription")]
        public string InternalDescription { get; set; }

        [DataMember(Name = "externalId")]
        public string ExternalId { get; set; }

        [DataMember(Name = "externalDescription")]
        public string ExternalDescription { get; set; }

        [DataMember(Name = "externalPrintDate")]
        public string ExternalPrintDate { get; set; }

        [DataMember(Name = "printDefinitions")]
        public List<object> PrintDefinitions { get; set; }

        [DataMember(Name = "publishedDate")]
        public string PublishedDate { get; set; }

        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "application")]
        public ApplicationReferenceContract Application { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "priorTo")]
        public string PriorTo { get; set; }

        [DataMember(Name = "recipient")]
        public string Recipient { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "requestedFrom")]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "daysToReceive")]
        public int? DaysToReceive { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }

        [DataMember(Name = "statusOpen")]
        public bool StatusOpen { get; set; }

        [DataMember(Name = "age")]
        public int? Age { get; set; }

        [DataMember(Name = "ageStartDate")]
        public string AgeStartDate { get; set; }

        [DataMember(Name = "ageClosedDate")]
        public string AgeClosedDate { get; set; }

        [DataMember(Name = "assignedTo")]
        public List<EntityReferenceContract> AssignedTo { get; set; }

        [DataMember(Name = "documentReceiptDate")]
        public string DocumentReceiptDate { get; set; }

        [DataMember(Name = "createdBy")]
        public EntityReferenceContract CreatedBy { get; set; }

        [DataMember(Name = "createdDate")]
        public string CreatedDate { get; set; }

        [DataMember(Name = "lastModifiedBy")]
        public EntityReferenceContract LastModifiedBy { get; set; }

        [DataMember(Name = "lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [DataMember(Name = "isRemoved")]
        public bool? IsRemoved { get; set; }

        [DataMember(Name = "tracking")]
        public List<TrackingEntryContract> Tracking { get; set; }

        [DataMember(Name = "comments")]
        public List<LogCommentContract> Comments { get; set; }

        [DataMember(Name = "commentsCount")]
        public int CommentsCount { get; set; }

        [DataMember(Name = "definitions")]
        public EnhancedConditionDefinitionContract Definitions { get; set; }

        [DataMember(Name = "sourceOfCondition")]
        public string SourceOfCondition { get; set; }

    }
}
