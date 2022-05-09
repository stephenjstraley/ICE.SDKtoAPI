using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.Contracts
{
    public class PipelineCanonicalFieldList
    {
        [JsonProperty(PropertyName = "PipelineLoanReportFieldDefs")]
        public List<CanonicalField> Fields { get; set; }
    }

    public class CanonicalField
    {
        [JsonProperty(PropertyName = "BorrowerPair")]
        public int Pair { get; set; }

        [JsonProperty(PropertyName = "CriterionFieldName")]
        public string Name { get; set; }
    }
}
