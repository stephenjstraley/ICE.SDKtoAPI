using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DocumentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }

        [DataMember(Name = "receivedBy")]
        public string ReceivedBy { get; set; }

        [DataMember(Name = "receivedDate")]
        public string ReceivedDate { get; set; }

        [DataMember(Name = "requestedBy")]
        public string RequestedBy { get; set; }

        [DataMember(Name = "requestedDate")]
        public string RequestedDate { get; set; }

        [DataMember(Name = "rerequestedBy")]
        public string RerequestedBy { get; set; }

        [DataMember(Name = "rerequestedDate")]
        public string RerequestedDate { get; set; }

        [DataMember(Name = "reviewedBy")]
        public string ReviewedBy { get; set; }

        [DataMember(Name = "reviewedDate")]
        public string ReviewedDate { get; set; }

        [DataMember(Name = "readyForUwBy")]
        public string ReadyForUwBy { get; set; }

        [DataMember(Name = "readyForUwDate")]
        public string ReadyForUwDate { get; set; }

        [DataMember(Name = "readyToShipBy")]
        public string ReadyToShipBy { get; set; }

        [DataMember(Name = "readyToShipDate")]
        public string ReadyToShipDate { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "isProtected")]
        public bool? IsProtected { get; set; }

        [DataMember(Name = "createdDate")]
        public string CreatedDate { get; set; }

        [DataMember(Name = "documentGroups")]
        public List<object> DocumentGroups { get; set; }

        [DataMember(Name = "roles")]
        public List<EntityReferenceContract> Roles { get; set; }

        [DataMember(Name = "expectedDate")]
        public string ExpectedDate { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember(Name = "milestone")]
        public string Milestone { get; set; }

        [DataMember(Name = "accessibleTo")]
        public List<object> AccessibleTo { get; set; }

        [DataMember(Name = "documentTypes")]
        public List<object> DocumentTypes { get; set; }

        [DataMember(Name = "attachments")]
        public List<FileAttachmentReferenceContract> Attachments { get; set; }

        [DataMember(Name = "isMarkedRemoved")]
        public bool IsMarkedRemoved { get; set; }

        [DataMember(Name = "daysDue")]
        public int? DaysDue { get; set; }

        [DataMember(Name = "daysTillExpire")]
        public int DaysTillExpire { get; set; }

        [DataMember(Name = "requestedFrom")]
        public string RequestedFrom { get; set; }

        [DataMember(Name = "packageId")]
        public string PackageId { get; set; }

        [DataMember(Name = "application")]
        public string Application { get; set; }

        [DataMember(Name = "verification")]
        public string Verification { get; set; }

        [DataMember(Name = "conditions")]
        public List<EntityReferenceContract> Conditions { get; set; }

        [DataMember(Name = "emnSignature")]
        public string EmnSignature { get; set; }
    }
}
