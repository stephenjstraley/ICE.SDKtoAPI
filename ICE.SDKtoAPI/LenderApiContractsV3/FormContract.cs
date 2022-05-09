using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class FormContract
    {
        [DataMember(Name = "formId")]
        public int FormId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
