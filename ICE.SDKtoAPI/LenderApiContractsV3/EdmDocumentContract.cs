using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EdmDocumentContract
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
    }
}
