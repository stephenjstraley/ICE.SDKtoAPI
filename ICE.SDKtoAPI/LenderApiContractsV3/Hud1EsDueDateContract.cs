using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Hud1EsDueDateContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "annualFee")]
        public string AnnualFee { get; set; }

        [DataMember(Name = "floodInsDisb")]
        public string FloodInsDisb { get; set; }

        [DataMember(Name = "hazInsDisb")]
        public string HazInsDisb { get; set; }

        [DataMember(Name = "mtgInsDisb")]
        public string MtgInsDisb { get; set; }

        [DataMember(Name = "schoolTaxes")]
        public string SchoolTaxes { get; set; }

        [DataMember(Name = "taxDisb")]
        public string TaxDisb { get; set; }

        [DataMember(Name = "userDefined1")]
        public string UserDefined1 { get; set; }

        [DataMember(Name = "userDefined2")]
        public string UserDefined2 { get; set; }

        [DataMember(Name = "userDefined3")]
        public string UserDefined3 { get; set; }

    }
}
