using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureTrackingSettings
    {
        [DataMember(Name = "disclosureTracking2010Forms")]
        public List<EntityReferenceContract> DisclosureTracking2010Forms { get; set; }

        [DataMember(Name = "disclosureTracking2015Forms")]
        public List<EntityReferenceContract> DisclosureTracking2015Forms { get; set; }

        [DataMember(Name = "disclosureRecordingTriggers")]
        public List<string> DisclosureRecordingTriggers { get; set; }

        [DataMember(Name = "saveDisclosureCopy")]
        public List<string> SaveDisclosureCopy { get; set; }

        [DataMember(Name = "complianceTimeCalculations")]
        public ComplianceTimeCalculations ComplianceTimeCalculations { get; set; }

        [DataMember(Name = "changedCircumstances")]
        public List<object> ChangedCircumstances { get; set; }
    }

    public class ComplianceTimeCalculations
    {
        [DataMember(Name = "respaTila")]
        public RespaTila RespaTila { get; set; }

        [DataMember(Name = "gfeTil")]
        public GfeTil GfeTil { get; set; }
    }

    public class RespaTila
    {
        [DataMember(Name = "initialDisclosureDueDateSetting")]
        public InitialDisclosureDueDateSetting InitialDisclosureDueDateSetting { get; set; }

        [DataMember(Name = "reDisclosureDueDateSetting")]
        public ReDisclosureDueDateSetting ReDisclosureDueDateSetting { get; set; }

        [DataMember(Name = "closingCostsExpiration")]
        public ClosingCostsExpiration GlosingCostsExpiration { get; set; }
    }

    public class GfeTil
    {
        [DataMember(Name = "earliestClosingDateSetting")]
        public EarliestClosingDateSetting EarliestClosingDateSetting { get; set; }

        [DataMember(Name = "gfeExpirationDateSetting")]
        public GfeExpirationDateSetting GfeExpirationDateSetting { get; set; }
    }

    public class EarliestClosingDateSetting
    {
        [DataMember(Name = "includeInitialTilSentBorrowerReceivedDate")]
        public bool IncludeInitialTilSentBorrowerReceivedDate { get; set; }
    }

    public class GfeExpirationDateSetting
    {
        [DataMember(Name = "includeInitialGfeSentDate")]
        public bool IncludeInitialGfeSentDate { get; set; }

        [DataMember(Name = "gfeExpirationDays")]
        public int GfeExpirationDays { get; set; }
    }
    public class ClosingCostsExpiration
    {
        [DataMember(Name = "time")]
        public string Time { get; set; }

        [DataMember(Name = "timezone")]
        public string Timezone { get; set; }
    }

    public class ReDisclosureDueDateSetting
    {
        [DataMember(Name = "includeChangedCircumstanceDate")]
        public bool IncludeChangedCircumstanceDate { get; set; }

        [DataMember(Name = "leExpirationDays")]
        public int LeExpirationDays { get; set; }
    }

    public class InitialDisclosureDueDateSetting
    {
        [DataMember(Name = "includeApplicationDate")]
        public bool IncludeApplicationDate { get; set; }
    }
}
