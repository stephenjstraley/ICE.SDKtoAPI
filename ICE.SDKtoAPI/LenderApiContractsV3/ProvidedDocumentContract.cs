using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ProvidedDocumentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "borrowerType")]
        public string BorrowerType { get; set; }

        [DataMember(Name = "documentName")]
        public string DocumentName { get; set; }

        [DataMember(Name = "requiredIndicator")]
        public bool? RequiredIndicator { get; set; }

        [DataMember(Name = "dateProvided")]
        public string DateProvided { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }

    }
}
