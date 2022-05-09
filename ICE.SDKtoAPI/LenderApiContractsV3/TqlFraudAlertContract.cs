using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TqlFraudAlertContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "lastFraudOrderAlertCategories")]
        public string LastFraudOrderAlertCategories { get; set; }

        [DataMember(Name = "lastFraudOrderAlertId")]
        public string LastFraudOrderAlertId { get; set; }

        [DataMember(Name = "lastFraudOrderAlertLevel")]
        public string LastFraudOrderAlertLevel { get; set; }

        [DataMember(Name = "lastFraudOrderDescriptionOfAlerts")]
        public string LastFraudOrderDescriptionOfAlerts { get; set; }

        [DataMember(Name = "driveFraudAlertStatus")]
        public string DriveFraudAlertStatus { get; set; }

        [DataMember(Name = "driveFraudAlertCode")]
        public string DriveFraudAlertCode { get; set; }

        [DataMember(Name = "fraudGuardFraudAlertStatus")]
        public string FraudGuardFraudAlertStatus { get; set; }

        [DataMember(Name = "fraudGuardFraudAlertCode")]
        public string FraudGuardFraudAlertCode { get; set; }

    }
}
