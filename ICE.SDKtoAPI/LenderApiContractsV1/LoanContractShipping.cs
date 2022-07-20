using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractShipping
	{
		[DataMember(Name="actualShipDate")]
		public DateTime? ActualShipDate { get; set; }

		[DataMember(Name="carrierName")]
		public string CarrierName { get; set; }

		[DataMember(Name="downPaymentAmount")]
		public decimal? DownPaymentAmount { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="investorDeliveryDate")]
		public DateTime? InvestorDeliveryDate { get; set; }

		[DataMember(Name="packageTrackingNumber")]
		public string PackageTrackingNumber { get; set; }

		[DataMember(Name="physicalFileStorageComments")]
		public string PhysicalFileStorageComments { get; set; }

		[DataMember(Name="physicalFileStorageId")]
		public string PhysicalFileStorageId { get; set; }

		[DataMember(Name="physicalFileStorageLocation")]
		public string PhysicalFileStorageLocation { get; set; }

		[DataMember(Name="poolID")]
		public string PoolID { get; set; }

		[DataMember(Name="poolNumber")]
		public string PoolNumber { get; set; }

		[DataMember(Name="recordingNumber")]
		public string RecordingNumber { get; set; }

		[DataMember(Name="shipmentMethod")]
		public string ShipmentMethod { get; set; }

		[DataMember(Name="shipperName")]
		public string ShipperName { get; set; }

		[DataMember(Name="shippingContacts")]
		public List<LoanContractShippingShippingContacts> ShippingContacts { get; set; }

		[DataMember(Name="targetDeliveryDate")]
		public DateTime? TargetDeliveryDate { get; set; }

	}
}