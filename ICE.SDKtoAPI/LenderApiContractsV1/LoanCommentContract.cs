using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanCommentContract
    {
        [DataMember(Name = "commentId", EmitDefaultValue = false)]
        public string CommentId { get; set; }

        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        [DataMember(Name = "createdByName", EmitDefaultValue = false)]
        public string CreatedByName { get; set; }

        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        public DateTime? DateCreated { get; set; }

        [DataMember(Name = "dateReviewed", EmitDefaultValue = false)]
        public DateTime? DateReviewed { get; set; }

        [DataMember(Name = "forRole", EmitDefaultValue = false)]
        public EntityRefContract ForRole { get; set; }

        [DataMember(Name = "forRoleId", EmitDefaultValue = false)]
        public int? ForRoleId { get; set; }

        [DataMember(Name = "reviewedBy", EmitDefaultValue = false)]
        public string ReviewedBy { get; set; }
    }
}
