using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class InvestorTemplateContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "templateName")]
        public string TemplateName { get; set; }

        [DataMember(Name = "investorContacts")]
        public List<InvestorContactDetailContract> InvestorContacts { get; set; }

        [DataMember(Name = "bulkSale")]
        public bool? BulkSale { get; set; }

        [DataMember(Name = "deliveryTimeFrame")]
        public int? DeliveryTimeFrame { get; set; }

        [DataMember(Name = "purchaserType")]
        public string PurchaserType { get; set; }

        [DataMember(Name = "purchaserTypeValue")]
        public string PurchaserTypeValue { get; set; }
    }

    [DataContract]
    public class InvestorContactDetailContract
    {
        [DataMember(Name = "contactType")]
        public string ContactType { get; set; }

        [DataMember(Name = "investorName")]
        public string InvestorName { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "addressStreet1")]
        public string AddressStreet1 { get; set; }

        [DataMember(Name = "addressStreet2")]
        public string AddressStreet2 { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "zip")]
        public string Zip { get; set; }

        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "faxNumber")]
        public string FaxNumber { get; set; }

        [DataMember(Name = "emailAddress")]
        public string EmailAddress { get; set; }

        [DataMember(Name = "webSite")]
        public string WebSite { get; set; }
    }
}
