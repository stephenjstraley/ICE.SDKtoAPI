using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EarlyCheckContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "ecUcdpLastSubmissionDateTimeEarly")]
        public string EcUcdpLastSubmissionDateTimeEarly { get; set; }

        [DataMember(Name = "ecAppraisalValue")]
        public decimal? EcAppraisalValue { get; set; }

        [DataMember(Name = "ecDocumentFileId")]
        public string EcDocumentFileId { get; set; }
    }
}
