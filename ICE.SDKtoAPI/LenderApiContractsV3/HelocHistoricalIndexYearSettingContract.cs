using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class HelocHistoricalIndexYearSettingContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "year")]
        public int? Year { get; set; }

        [DataMember(Name = "indexRate")]
        public decimal? IndexRate { get; set; }
    }
}
