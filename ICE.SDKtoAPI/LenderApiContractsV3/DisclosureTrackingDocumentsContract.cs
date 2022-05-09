using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureTrackingDocumentsContract
    {
        [DataMember(Name = "viewableFormsFile")]
        public string ViewableFormsFile { get; set; }

        [DataMember(Name = "forms")]
        public List<DisclosureFormContract> Forms { get; set; }
    }
}
