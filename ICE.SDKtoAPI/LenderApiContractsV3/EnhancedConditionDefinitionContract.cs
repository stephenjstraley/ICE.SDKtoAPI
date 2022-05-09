using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EnhancedConditionDefinitionContract
    {
        [DataMember(Name = "categoryDefinitions")]
        public List<OptionDefinitionContract> CategoryDefinitions { get; set; }
        [DataMember(Name = "priorToDefinitions")]
        public List<OptionDefinitionContract> PriorToDefinitions { get; set; }
        [DataMember(Name = "recipientDefinitions")]
        public List<OptionDefinitionContract> RecipientDefinitions { get; set; }
        [DataMember(Name = "sourceDefinitions")]
        public List<OptionDefinitionContract> SourceDefinitions { get; set; }
        [DataMember(Name = "trackingDefinitions")]
        public List<TrackingDefinitionContract> TrackingDefinitions { get; set; }
    }
}
