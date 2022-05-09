using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class OrderedDocumentOverflowContract
    {
        [DataMember(Name = "pageNumber")]
        public int? PageNumber { get; set; }

        [DataMember(Name = "fieldName")]
        public string FieldName { get; set; }

        [DataMember(Name = "originalText")]
        public string OriginalText { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

    }
}
