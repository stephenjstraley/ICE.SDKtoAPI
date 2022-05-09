using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class InvestorDeliveryLogContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "deliveryStatusDate")]
        public string DeliveryStatusDate { get; set; }

        [DataMember(Name = "deliveryStatus")]
        public string DeliveryStatus { get; set; }

        [DataMember(Name = "companyDeliveredTo")]
        public string CompanyDeliveredTo { get; set; }

        [DataMember(Name = "categoryDeliveredTo")]
        public string CategoryDeliveredTo { get; set; }

    }
}
