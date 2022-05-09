using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TrackingFieldsContract
    {
        [DataMember(Name = "disclosurePackageTypes")]
        public List<object> DisclosurePackageTypes { get; set; }

        [DataMember(Name = "packageCreatedDate")]
        public string PackageCreatedDate { get; set; }

        [DataMember(Name = "packageId")]
        public string PackageId { get; set; }

        [DataMember(Name = "docPackageId")]
        public string DocPackageId { get; set; }

    }
}
