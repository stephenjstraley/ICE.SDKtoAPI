using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DocumentAuditContract
    {
        [DataMember(Name = "reportKey")]
        public string ReportKey { get; set; }

        [DataMember(Name = "auditDateTime")]
        public string AuditDateTime { get; set; }

        [DataMember(Name = "alerts")]
        public List<DocumentAuditAlertContract> Alerts { get; set; }
    }
}
