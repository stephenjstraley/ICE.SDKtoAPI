using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DocumentOrderContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "orderId")]
        public string OrderId { get; set; }

        [DataMember(Name = "orderType")]
        public string OrderType { get; set; }

        [DataMember(Name = "createdDate")]
        public string CreatedDate { get; set; }

        [DataMember(Name = "createdBy")]
        public string CreatedBy { get; set; }

        [DataMember(Name = "documentFields")]
        public object DocumentFields { get; set; }

        [DataMember(Name = "documentAudit")]
        public string DocumentAudit { get; set; }

        [DataMember(Name = "lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [DataMember(Name = "documents")]
        public List<OrderedDocumentContract> Documents { get; set; }
    }
}
