using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class MilitaryServiceContract
    {
        [DataMember(Name = "militaryServiceIndex")]
        public int MilitaryServiceIndex { get; set; }

        [DataMember(Name = "branch")]
        public string Branch { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "officerOrEnlisted")]
        public string OfficerOrEnlisted { get; set; }

        [DataMember(Name = "serviceNumber")]
        public string ServiceNumber { get; set; }

        [DataMember(Name = "ssn")]
        public string Ssn { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

    }
}
