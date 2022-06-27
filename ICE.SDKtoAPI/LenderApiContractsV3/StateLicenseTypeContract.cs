using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class StateLicenseTypeContract
    {
        [DataMember(Name = "selected")]
        public bool? Selected { get; set; }

        [DataMember(Name = "exempted")]
        public bool? Exempted { get; set; }

        [DataMember(Name = "stateAbbrevation")]
        public string StateAbbrevation { get; set; }

        [DataMember(Name = "licenseType")]
        public string LicenseType { get; set; }

        [DataMember(Name = "issueDate")]
        public string IssueDate { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "licenseStatus")]
        public string LicenseStatus { get; set; }

        [DataMember(Name = "statusDate")]
        public string StatusDate { get; set; }

        [DataMember(Name = "lastChecked")]
        public string LastChecked { get; set; }
    }
}
