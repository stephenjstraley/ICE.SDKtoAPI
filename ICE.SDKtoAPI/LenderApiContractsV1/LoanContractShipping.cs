using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractShipping
	{
		[DataMember(Name="actualShipDate", EmitDefaultValue=false)]
		public DateTime? ActualShipDate { get; set; }

		[DataMember(Name="carrierName", EmitDefaultValue=false)]
		public string CarrierName { get; set; }

		[DataMember(Name="downPaymentAmount", EmitDefaultValue=false)]
		public double? DownPaymentAmount { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="investorDeliveryDate", EmitDefaultValue=false)]
		public DateTime? InvestorDeliveryDate { get; set; }

		[DataMember(Name="packageTrackingNumber", EmitDefaultValue=false)]
		public string PackageTrackingNumber { get; set; }

		[DataMember(Name="physicalFileStorageComments", EmitDefaultValue=false)]
		public string PhysicalFileStorageComments { get; set; }

		[DataMember(Name="physicalFileStorageId", EmitDefaultValue=false)]
		public string PhysicalFileStorageId { get; set; }

		[DataMember(Name="physicalFileStorageLocation", EmitDefaultValue=false)]
		public string PhysicalFileStorageLocation { get; set; }

		[DataMember(Name="poolID", EmitDefaultValue=false)]
		public string PoolID { get; set; }

		[DataMember(Name="poolNumber", EmitDefaultValue=false)]
		public string PoolNumber { get; set; }

		[DataMember(Name="recordingNumber", EmitDefaultValue=false)]
		public string RecordingNumber { get; set; }

		[DataMember(Name="shipmentMethod", EmitDefaultValue=false)]
		public string ShipmentMethod { get; set; }

		[DataMember(Name="shipperName", EmitDefaultValue=false)]
		public string ShipperName { get; set; }

		[DataMember(Name="shippingContacts", EmitDefaultValue=false)]
		public List<LoanContractShippingShippingContacts> ShippingContacts { get; set; }

		[DataMember(Name="targetDeliveryDate", EmitDefaultValue=false)]
		public DateTime? TargetDeliveryDate { get; set; }

	}
}