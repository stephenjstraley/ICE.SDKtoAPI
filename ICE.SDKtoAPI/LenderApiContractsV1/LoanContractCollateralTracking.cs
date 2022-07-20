using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCollateralTracking
	{
		[DataMember(Name="ctComAllComments")]
		public string CtComAllComments { get; set; }

		[DataMember(Name="ctComTransactionComment")]
		public string CtComTransactionComment { get; set; }

		[DataMember(Name="ctDotInitBookNumber")]
		public string CtDotInitBookNumber { get; set; }

		[DataMember(Name="ctDotInitContact")]
		public string CtDotInitContact { get; set; }

		[DataMember(Name="ctDotInitDaysOutstanding")]
		public string CtDotInitDaysOutstanding { get; set; }

		[DataMember(Name="ctDotInitDocumentNumber")]
		public string CtDotInitDocumentNumber { get; set; }

		[DataMember(Name="ctDotInitEmail")]
		public string CtDotInitEmail { get; set; }

		[DataMember(Name="ctDotInitLastRequested")]
		public string CtDotInitLastRequested { get; set; }

		[DataMember(Name="ctDotInitNextFollowupDate")]
		public DateTime? CtDotInitNextFollowupDate { get; set; }

		[DataMember(Name="ctDotInitOrganization")]
		public string CtDotInitOrganization { get; set; }

		[DataMember(Name="ctDotInitPageNumber")]
		public string CtDotInitPageNumber { get; set; }

		[DataMember(Name="ctDotInitPhone")]
		public string CtDotInitPhone { get; set; }

		[DataMember(Name="ctDotInitPurchaseDate")]
		public DateTime? CtDotInitPurchaseDate { get; set; }

		[DataMember(Name="ctDotInitReceived")]
		public string CtDotInitReceived { get; set; }

		[DataMember(Name="ctDotInitRequestedBy")]
		public string CtDotInitRequestedBy { get; set; }

		[DataMember(Name="ctDotInitRiderReceived")]
		public string CtDotInitRiderReceived { get; set; }

		[DataMember(Name="ctDotRetContact")]
		public string CtDotRetContact { get; set; }

		[DataMember(Name="ctDotRetEmail")]
		public string CtDotRetEmail { get; set; }

		[DataMember(Name="ctDotRetLastRequested")]
		public DateTime? CtDotRetLastRequested { get; set; }

		[DataMember(Name="ctDotRetNextFollowUpDate")]
		public DateTime? CtDotRetNextFollowUpDate { get; set; }

		[DataMember(Name="ctDotRetOrganization")]
		public string CtDotRetOrganization { get; set; }

		[DataMember(Name="ctDotRetPhone")]
		public string CtDotRetPhone { get; set; }

		[DataMember(Name="ctDotRetReceived")]
		public DateTime? CtDotRetReceived { get; set; }

		[DataMember(Name="ctDotRetRequestedBy")]
		public string CtDotRetRequestedBy { get; set; }

		[DataMember(Name="ctDotShipAddress")]
		public string CtDotShipAddress { get; set; }

		[DataMember(Name="ctDotShipCarrier")]
		public string CtDotShipCarrier { get; set; }

		[DataMember(Name="ctDotShipContact")]
		public string CtDotShipContact { get; set; }

		[DataMember(Name="ctDotShipEmail")]
		public string CtDotShipEmail { get; set; }

		[DataMember(Name="ctDotShipOrganization")]
		public string CtDotShipOrganization { get; set; }

		[DataMember(Name="ctDotShipPhone")]
		public string CtDotShipPhone { get; set; }

		[DataMember(Name="ctDotShipShippedBy")]
		public string CtDotShipShippedBy { get; set; }

		[DataMember(Name="ctDotShipShippingDate")]
		public DateTime? CtDotShipShippingDate { get; set; }

		[DataMember(Name="ctDotShipTrackingNumber")]
		public string CtDotShipTrackingNumber { get; set; }

		[DataMember(Name="ctFtpInitContact")]
		public string CtFtpInitContact { get; set; }

		[DataMember(Name="ctFtpInitDaysOutstanding")]
		public string CtFtpInitDaysOutstanding { get; set; }

		[DataMember(Name="ctFtpInitEmail")]
		public string CtFtpInitEmail { get; set; }

		[DataMember(Name="ctFtpInitLastRequested")]
		public string CtFtpInitLastRequested { get; set; }

		[DataMember(Name="ctFtpInitNextFollowupDate")]
		public DateTime? CtFtpInitNextFollowupDate { get; set; }

		[DataMember(Name="ctFtpInitOrganization")]
		public string CtFtpInitOrganization { get; set; }

		[DataMember(Name="ctFtpInitPhone")]
		public string CtFtpInitPhone { get; set; }

		[DataMember(Name="ctFtpInitReceived")]
		public string CtFtpInitReceived { get; set; }

		[DataMember(Name="ctFtpInitRequestedBy")]
		public string CtFtpInitRequestedBy { get; set; }

		[DataMember(Name="ctFtpRetContact")]
		public string CtFtpRetContact { get; set; }

		[DataMember(Name="ctFtpRetEmail")]
		public string CtFtpRetEmail { get; set; }

		[DataMember(Name="ctFtpRetLastRequested")]
		public DateTime? CtFtpRetLastRequested { get; set; }

		[DataMember(Name="ctFtpRetNextFollowUpDate")]
		public DateTime? CtFtpRetNextFollowUpDate { get; set; }

		[DataMember(Name="ctFtpRetOrganization")]
		public string CtFtpRetOrganization { get; set; }

		[DataMember(Name="ctFtpRetPhone")]
		public string CtFtpRetPhone { get; set; }

		[DataMember(Name="ctFtpRetReceived")]
		public DateTime? CtFtpRetReceived { get; set; }

		[DataMember(Name="ctFtpRetRequestedBy")]
		public string CtFtpRetRequestedBy { get; set; }

		[DataMember(Name="ctFtpShipAddress")]
		public string CtFtpShipAddress { get; set; }

		[DataMember(Name="ctFtpShipCarrier")]
		public string CtFtpShipCarrier { get; set; }

		[DataMember(Name="ctFtpShipContact")]
		public string CtFtpShipContact { get; set; }

		[DataMember(Name="ctFtpShipEmail")]
		public string CtFtpShipEmail { get; set; }

		[DataMember(Name="ctFtpShipOrganization")]
		public string CtFtpShipOrganization { get; set; }

		[DataMember(Name="ctFtpShipPhone")]
		public string CtFtpShipPhone { get; set; }

		[DataMember(Name="ctFtpShipShippedBy")]
		public string CtFtpShipShippedBy { get; set; }

		[DataMember(Name="ctFtpShipShippingDate")]
		public DateTime? CtFtpShipShippingDate { get; set; }

		[DataMember(Name="ctFtpShipTrackingNumber")]
		public string CtFtpShipTrackingNumber { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}