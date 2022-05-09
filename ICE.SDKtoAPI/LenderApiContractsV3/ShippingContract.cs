using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ShippingContract
    {
        [DataMember(Name = "actualShipDate")]
        public string ActualShipDate { get; set; }

        [DataMember(Name = "carrierName")]
        public string CarrierName { get; set; }

        [DataMember(Name = "downPaymentAmount")]
        public decimal? DownPaymentAmount { get; set; }

        [DataMember(Name = "investorDeliveryDate")]
        public string InvestorDeliveryDate { get; set; }

        [DataMember(Name = "packageTrackingNumber")]
        public string PackageTrackingNumber { get; set; }

        [DataMember(Name = "physicalFileStorageComments")]
        public string PhysicalFileStorageComments { get; set; }

        [DataMember(Name = "physicalFileStorageId")]
        public string PhysicalFileStorageId { get; set; }

        [DataMember(Name = "physicalFileStorageLocation")]
        public string PhysicalFileStorageLocation { get; set; }

        [DataMember(Name = "recordingNumber")]
        public string RecordingNumber { get; set; }

        [DataMember(Name = "shipmentMethod")]
        public string ShipmentMethod { get; set; }

        [DataMember(Name = "shipperName")]
        public string ShipperName { get; set; }

        [DataMember(Name = "locationCode")]
        public string LocationCode { get; set; }

        [DataMember(Name = "investorCode")]
        public string InvestorCode { get; set; }

        [DataMember(Name = "shippingContacts")]
        public List<ShippingContactContract> ShippingContacts { get; set; }

        [DataMember(Name = "targetDeliveryDate")]
        public string TargetDeliveryDate { get; set; }

        [DataMember(Name = "poolId")]
        public string PoolId { get; set; }

        [DataMember(Name = "poolNumber")]
        public string PoolNumber { get; set; }

        [DataMember(Name = "investorConnectDeliveryStatus")]
        public string InvestorConnectDeliveryStatus { get; set; }

        [DataMember(Name = "investorConnectDeliveryStatusDateTime")]
        public string InvestorConnectDeliveryStatusDateTime { get; set; }

        [DataMember(Name = "investorConnectDeliveredToCompany")]
        public string InvestorConnectDeliveredToCompany { get; set; }

        [DataMember(Name = "investorConnectDeliveredToCategory")]
        public string InvestorConnectDeliveredToCategory { get; set; }

    }
}
