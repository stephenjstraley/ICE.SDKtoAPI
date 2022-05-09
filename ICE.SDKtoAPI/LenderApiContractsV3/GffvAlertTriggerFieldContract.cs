using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class GffvAlertTriggerFieldContract
    {
        [DataMember(Name = "fieldId")]
        public string FieldId { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "initialLeValue")]
        public decimal? InitialLeValue { get; set; }

        [DataMember(Name = "varianceValue")]
        public decimal? VarianceValue { get; set; }

        [DataMember(Name = "varianceLimit")]
        public string VarianceLimit { get; set; }

        [DataMember(Name = "disclosedValue")]
        public decimal? DisclosedValue { get; set; }

        [DataMember(Name = "itemizationValue")]
        public decimal? ItemizationValue { get; set; }

        [DataMember(Name = "baseline")]
        public string Baseline { get; set; }
    }
}
