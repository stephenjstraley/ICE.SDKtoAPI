using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    [DataContract]
    public class ErrorObject
    {
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }
    }
}