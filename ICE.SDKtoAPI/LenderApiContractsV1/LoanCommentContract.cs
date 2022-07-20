using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanCommentContract
    {
        [DataMember(Name = "commentId")]
        public string CommentId { get; set; }

        [DataMember(Name = "comments")]
        public string Comments { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "createdByName")]
        public string CreatedByName { get; set; }

        [DataMember(Name = "dateCreated")]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "dateReviewed")]
        public DateTime? DateReviewed { get; set; }

        [DataMember(Name = "forRole")]
        public EntityRefContract ForRole { get; set; }

        [DataMember(Name = "forRoleId")]
        public int? ForRoleId { get; set; }

        [DataMember(Name = "reviewedBy")]
        public string ReviewedBy { get; set; }
    }
}
