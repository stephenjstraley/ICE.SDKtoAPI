using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class OrderedDocumentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "documentType")]
        public string DocumentType { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "signatureType")]
        public string SignatureType { get; set; }

        [DataMember(Name = "application")]
        public string Application { get; set; }

        [DataMember(Name = "dataKey")]
        public string DataKey { get; set; }

        [DataMember(Name = "size")]
        public int? Size { get; set; }

        [DataMember(Name = "templateId")]
        public string TemplateId { get; set; }

        [DataMember(Name = "externalDocumentId")]
        public string ExternalDocumentId { get; set; }

        [DataMember(Name = "overflowDataKey")]
        public string OverflowDataKey { get; set; }

        [DataMember(Name = "overflows")]
        public List<OrderedDocumentOverflowContract> Overflows { get; set; }

    }
}
