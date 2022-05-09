using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class LoanContractBase
    {
        [DataMember(Name = "applications")]
        public List<LoanContractApplications> Applications { get; set; }

        [DataMember(Name = "rateLock")]
        public LoanContractRateLock RateLock { get; set; }

        [DataMember(Name = "property")]
        public LoanContractProperty Property { get; set; }

        [DataMember(Name = "customFields")]
        public List<LoanContractCustomFields> CustomFields { get; set; }

        public LoanContractBase()
        {
            Applications = new List<LoanContractApplications>();
            CustomFields = new List<LoanContractCustomFields>();
        }
    }
}
