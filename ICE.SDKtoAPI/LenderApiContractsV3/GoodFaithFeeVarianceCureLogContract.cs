using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GoodFaithFeeVarianceCureLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "appliedCureAmount")]
        public decimal? AppliedCureAmount { get; set; }

        [DataMember(Name = "totalVariance")]
        public decimal? TotalVariance { get; set; }

        [DataMember(Name = "inLogIndicator")]
        public bool? InLogIndicator { get; set; }

        [DataMember(Name = "cureComments")]
        public string CureComments { get; set; }

        [DataMember(Name = "resolvedBy")]
        public string ResolvedBy { get; set; }

        [DataMember(Name = "dateResolved")]
        public string DateResolved { get; set; }

        [DataMember(Name = "alertDate")]
        public string AlertDate { get; set; }

        [DataMember(Name = "triggerFields")]
        public List<GffvAlertTriggerFieldContract> TriggerFields { get; set; }
    }
}
