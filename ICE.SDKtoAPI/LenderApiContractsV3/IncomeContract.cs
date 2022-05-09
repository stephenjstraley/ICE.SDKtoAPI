using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class IncomeContract
    {
        [DataMember(Name = "incomeType")]
        public string IncomeType { get; set; }

        [DataMember(Name = "otherIncomeIndex")]
        public int? OtherIncomeIndex { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

    }
}
