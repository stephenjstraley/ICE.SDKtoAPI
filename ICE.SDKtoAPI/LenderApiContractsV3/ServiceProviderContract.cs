using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ServiceProviderContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "cost")]
        public decimal? Cost { get; set; }

        [DataMember(Name = "lineItemNumber")]
        public string LineItemNumber { get; set; }

        [DataMember(Name = "phone")]
        public string Phone { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "providerName")]
        public string ProviderName { get; set; }

        [DataMember(Name = "relationship")]
        public string Relationship { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "serviceType")]
        public string ServiceType { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "webUrl")]
        public string WebUrl { get; set; }

        [DataMember(Name = "shopFor")]
        public bool? ShopFor { get; set; }

        [DataMember(Name = "contactName")]
        public string ContactName { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "serviceProviderContactFees")]
        public List<ServiceProviderFeeContract> ServiceProviderContactFees { get; set; }
    }

    [DataContract]
    public class ServiceProviderContractFull : ServiceProviderContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
