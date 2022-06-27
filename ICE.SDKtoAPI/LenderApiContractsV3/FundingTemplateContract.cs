using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FundingTemplateContract
    {
        [DataMember(Name = "templateName")]
        public string TemplateName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "itemizationType")]
        public string ItemizationType { get; set; }

        [DataMember(Name = "path")]
        public string Path { get; set; }
    }
}
