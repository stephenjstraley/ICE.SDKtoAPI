using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilestoneFreeRoleContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "loanAssociate")]
        public LoanAssociateContract LoanAssociate { get; set; }

    }
}
