using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureRecipientRoleReferenceContract
    {
        [DataMember(Name = "entityId")]
        public string EntityId { get; set; }

        [DataMember(Name = "entityName")]
        public string EntityName { get; set; }

        [DataMember(Name = "entityType")]
        public string EntityType { get; set; }

        [DataMember(Name = "entityUri")]
        public string EntityUri { get; set; }

        [DataMember(Name = "entityDescription")]
        public string EntityDescription { get; set; }

        [DataMember(Name = "legacyId")]
        public string LegacyId { get; set; }

        [DataMember(Name = "application")]
        public string Application { get; set; }
    }
}
