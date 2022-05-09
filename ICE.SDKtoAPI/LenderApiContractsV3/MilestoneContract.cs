using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilestoneContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "days")]
        public int? Days { get; set; }

        [DataMember(Name = "doneIndicator")]
        public bool? DoneIndicator { get; set; }

        [DataMember(Name = "duration")]
        public int? Duration { get; set; }

        [DataMember(Name = "loanAssociate")]
        public LoanAssociateContract LoanAssociate { get; set; }

        [DataMember(Name = "reviewedIndicator")]
        public bool? ReviewedIndicator { get; set; }

        [DataMember(Name = "roleRequired")]
        public string RoleRequired { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "milestoneSetting")]
        public EntityReferenceContract MilestoneSetting { get; set; }

    }
}
