using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PropertyValuationContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "avmPropertyValue")]
        public string AvmPropertyValue { get; set; }

        [DataMember(Name = "avmPropertyId")]
        public string AvmPropertyId { get; set; }

        [DataMember(Name = "avmProduct")]
        public string AvmProduct { get; set; }

        [DataMember(Name = "avmConfidenceScore")]
        public string AvmConfidenceScore { get; set; }

        [DataMember(Name = "avmConfidenceScoreAlt")]
        public string AvmConfidenceScoreAlt { get; set; }

        [DataMember(Name = "avmRetroDate")]
        public string AvmRetroDate { get; set; }

        [DataMember(Name = "avmRangeLow")]
        public string AvmRangeLow { get; set; }

        [DataMember(Name = "avmRangeHigh")]
        public string AvmRangeHigh { get; set; }

        [DataMember(Name = "avmComplexityScore")]
        public string AvmComplexityScore { get; set; }

        [DataMember(Name = "avmFsd")]
        public string AvmFsd { get; set; }

        [DataMember(Name = "avmReportId")]
        public string AvmReportId { get; set; }

        [DataMember(Name = "avmReportCompleteDate")]
        public string AvmReportCompleteDate { get; set; }

        [DataMember(Name = "avmReportOrderedDate")]
        public string AvmReportOrderedDate { get; set; }

        [DataMember(Name = "avmProvider")]
        public string AvmProvider { get; set; }

        [DataMember(Name = "propertyValuationType")]
        public string PropertyValuationType { get; set; }

        [DataMember(Name = "orderType")]
        public string OrderType { get; set; }

    }
}
