using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TqlComplianceAlertContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "lastComplianceOrderAlertCategories")]
        public string LastComplianceOrderAlertCategories { get; set; }

        [DataMember(Name = "lastComplianceOrderAlertMessage")]
        public string LastComplianceOrderAlertMessage { get; set; }

        [DataMember(Name = "lastComplianceOrderDescriptionOfAlerts")]
        public string LastComplianceOrderDescriptionOfAlerts { get; set; }

    }
}
