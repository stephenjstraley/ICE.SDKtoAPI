using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FileAttachmentContract
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "isActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "assignedTo")]
        public EntityReferenceContract AssignedTo { get; set; }

        [DataMember(Name = "fileSize")]
        public int FileSize { get; set; }

        [DataMember(Name = "rotation")]
        public int Rotation { get; set; }

        [DataMember(Name = "isRemoved")]
        public bool IsRemoved { get; set; }

        [DataMember(Name = "createdBy")]
        public EntityReferenceContract CreatedBy { get; set; }

        [DataMember(Name = "createdDate")]
        public string CreatedDate { get; set; }
    }
}
