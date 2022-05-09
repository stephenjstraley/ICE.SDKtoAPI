using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DocumentAuditAlertContract
    {
        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "alertType")]
        public string AlertType { get; set; }

        [DataMember(Name = "details")]
        public string Details { get; set; }

        [DataMember(Name = "fields")]
        public List<object> Fields { get; set; }
    }
}
