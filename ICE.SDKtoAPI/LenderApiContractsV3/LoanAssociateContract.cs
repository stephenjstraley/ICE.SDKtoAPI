using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LoanAssociateContract
    {
        [DataMember(Name = "loanAssociateType")]
        public string LoanAssociateType { get; set; }

        [DataMember(Name = "user")]
        public EntityReferenceContract User { get; set; }

        [DataMember(Name = "cellPhone")]
        public string CellPhone { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "role")]
        public EntityReferenceContract Role { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "writeAccess")]
        public bool? WriteAccess { get; set; }

        [DataMember(Name = "apiClientId")]
        public string ApiClientId { get; set; }

    }
}
