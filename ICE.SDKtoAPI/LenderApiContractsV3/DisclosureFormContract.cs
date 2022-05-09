using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureFormContract
    {
        [DataMember(Name = "formName")]
        public string FormName { get; set; }

        [DataMember(Name = "formType")]
        public string FormType { get; set; }

        [DataMember(Name = "signatureType")]
        public string SignatureType { get; set; }

        [DataMember(Name = "viewableFormFile")]
        public string ViewableFormFile { get; set; }
    }
}
