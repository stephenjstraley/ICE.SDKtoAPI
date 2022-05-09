using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class LockRequestBorrowerContract
    {
        [DataMember(Name = "lrbIndex")]
        public int LrbIndex { get; set; }

        [DataMember(Name = "equifaxScore")]
        public string EquifaxScore { get; set; }

        [DataMember(Name = "experianScore")]
        public string ExperianScore { get; set; }

        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }

        [DataMember(Name = "lastName")]
        public string LastName { get; set; }

        [DataMember(Name = "ssn")]
        public string Ssn { get; set; }

        [DataMember(Name = "transUnionScore")]
        public string TransUnionScore { get; set; }

    }
}
