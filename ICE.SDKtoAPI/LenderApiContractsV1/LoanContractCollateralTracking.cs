using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCollateralTracking
	{
		[DataMember(Name="ctComAllComments", EmitDefaultValue=false)]
		public string CtComAllComments { get; set; }

		[DataMember(Name="ctComTransactionComment", EmitDefaultValue=false)]
		public string CtComTransactionComment { get; set; }

		[DataMember(Name="ctDotInitBookNumber", EmitDefaultValue=false)]
		public string CtDotInitBookNumber { get; set; }

		[DataMember(Name="ctDotInitContact", EmitDefaultValue=false)]
		public string CtDotInitContact { get; set; }

		[DataMember(Name="ctDotInitDaysOutstanding", EmitDefaultValue=false)]
		public string CtDotInitDaysOutstanding { get; set; }

		[DataMember(Name="ctDotInitDocumentNumber", EmitDefaultValue=false)]
		public string CtDotInitDocumentNumber { get; set; }

		[DataMember(Name="ctDotInitEmail", EmitDefaultValue=false)]
		public string CtDotInitEmail { get; set; }

		[DataMember(Name="ctDotInitLastRequested", EmitDefaultValue=false)]
		public string CtDotInitLastRequested { get; set; }

		[DataMember(Name="ctDotInitNextFollowupDate", EmitDefaultValue=false)]
		public DateTime? CtDotInitNextFollowupDate { get; set; }

		[DataMember(Name="ctDotInitOrganization", EmitDefaultValue=false)]
		public string CtDotInitOrganization { get; set; }

		[DataMember(Name="ctDotInitPageNumber", EmitDefaultValue=false)]
		public string CtDotInitPageNumber { get; set; }

		[DataMember(Name="ctDotInitPhone", EmitDefaultValue=false)]
		public string CtDotInitPhone { get; set; }

		[DataMember(Name="ctDotInitPurchaseDate", EmitDefaultValue=false)]
		public DateTime? CtDotInitPurchaseDate { get; set; }

		[DataMember(Name="ctDotInitReceived", EmitDefaultValue=false)]
		public string CtDotInitReceived { get; set; }

		[DataMember(Name="ctDotInitRequestedBy", EmitDefaultValue=false)]
		public string CtDotInitRequestedBy { get; set; }

		[DataMember(Name="ctDotInitRiderReceived", EmitDefaultValue=false)]
		public string CtDotInitRiderReceived { get; set; }

		[DataMember(Name="ctDotRetContact", EmitDefaultValue=false)]
		public string CtDotRetContact { get; set; }

		[DataMember(Name="ctDotRetEmail", EmitDefaultValue=false)]
		public string CtDotRetEmail { get; set; }

		[DataMember(Name="ctDotRetLastRequested", EmitDefaultValue=false)]
		public DateTime? CtDotRetLastRequested { get; set; }

		[DataMember(Name="ctDotRetNextFollowUpDate", EmitDefaultValue=false)]
		public DateTime? CtDotRetNextFollowUpDate { get; set; }

		[DataMember(Name="ctDotRetOrganization", EmitDefaultValue=false)]
		public string CtDotRetOrganization { get; set; }

		[DataMember(Name="ctDotRetPhone", EmitDefaultValue=false)]
		public string CtDotRetPhone { get; set; }

		[DataMember(Name="ctDotRetReceived", EmitDefaultValue=false)]
		public DateTime? CtDotRetReceived { get; set; }

		[DataMember(Name="ctDotRetRequestedBy", EmitDefaultValue=false)]
		public string CtDotRetRequestedBy { get; set; }

		[DataMember(Name="ctDotShipAddress", EmitDefaultValue=false)]
		public string CtDotShipAddress { get; set; }

		[DataMember(Name="ctDotShipCarrier", EmitDefaultValue=false)]
		public string CtDotShipCarrier { get; set; }

		[DataMember(Name="ctDotShipContact", EmitDefaultValue=false)]
		public string CtDotShipContact { get; set; }

		[DataMember(Name="ctDotShipEmail", EmitDefaultValue=false)]
		public string CtDotShipEmail { get; set; }

		[DataMember(Name="ctDotShipOrganization", EmitDefaultValue=false)]
		public string CtDotShipOrganization { get; set; }

		[DataMember(Name="ctDotShipPhone", EmitDefaultValue=false)]
		public string CtDotShipPhone { get; set; }

		[DataMember(Name="ctDotShipShippedBy", EmitDefaultValue=false)]
		public string CtDotShipShippedBy { get; set; }

		[DataMember(Name="ctDotShipShippingDate", EmitDefaultValue=false)]
		public DateTime? CtDotShipShippingDate { get; set; }

		[DataMember(Name="ctDotShipTrackingNumber", EmitDefaultValue=false)]
		public string CtDotShipTrackingNumber { get; set; }

		[DataMember(Name="ctFtpInitContact", EmitDefaultValue=false)]
		public string CtFtpInitContact { get; set; }

		[DataMember(Name="ctFtpInitDaysOutstanding", EmitDefaultValue=false)]
		public string CtFtpInitDaysOutstanding { get; set; }

		[DataMember(Name="ctFtpInitEmail", EmitDefaultValue=false)]
		public string CtFtpInitEmail { get; set; }

		[DataMember(Name="ctFtpInitLastRequested", EmitDefaultValue=false)]
		public string CtFtpInitLastRequested { get; set; }

		[DataMember(Name="ctFtpInitNextFollowupDate", EmitDefaultValue=false)]
		public DateTime? CtFtpInitNextFollowupDate { get; set; }

		[DataMember(Name="ctFtpInitOrganization", EmitDefaultValue=false)]
		public string CtFtpInitOrganization { get; set; }

		[DataMember(Name="ctFtpInitPhone", EmitDefaultValue=false)]
		public string CtFtpInitPhone { get; set; }

		[DataMember(Name="ctFtpInitReceived", EmitDefaultValue=false)]
		public string CtFtpInitReceived { get; set; }

		[DataMember(Name="ctFtpInitRequestedBy", EmitDefaultValue=false)]
		public string CtFtpInitRequestedBy { get; set; }

		[DataMember(Name="ctFtpRetContact", EmitDefaultValue=false)]
		public string CtFtpRetContact { get; set; }

		[DataMember(Name="ctFtpRetEmail", EmitDefaultValue=false)]
		public string CtFtpRetEmail { get; set; }

		[DataMember(Name="ctFtpRetLastRequested", EmitDefaultValue=false)]
		public DateTime? CtFtpRetLastRequested { get; set; }

		[DataMember(Name="ctFtpRetNextFollowUpDate", EmitDefaultValue=false)]
		public DateTime? CtFtpRetNextFollowUpDate { get; set; }

		[DataMember(Name="ctFtpRetOrganization", EmitDefaultValue=false)]
		public string CtFtpRetOrganization { get; set; }

		[DataMember(Name="ctFtpRetPhone", EmitDefaultValue=false)]
		public string CtFtpRetPhone { get; set; }

		[DataMember(Name="ctFtpRetReceived", EmitDefaultValue=false)]
		public DateTime? CtFtpRetReceived { get; set; }

		[DataMember(Name="ctFtpRetRequestedBy", EmitDefaultValue=false)]
		public string CtFtpRetRequestedBy { get; set; }

		[DataMember(Name="ctFtpShipAddress", EmitDefaultValue=false)]
		public string CtFtpShipAddress { get; set; }

		[DataMember(Name="ctFtpShipCarrier", EmitDefaultValue=false)]
		public string CtFtpShipCarrier { get; set; }

		[DataMember(Name="ctFtpShipContact", EmitDefaultValue=false)]
		public string CtFtpShipContact { get; set; }

		[DataMember(Name="ctFtpShipEmail", EmitDefaultValue=false)]
		public string CtFtpShipEmail { get; set; }

		[DataMember(Name="ctFtpShipOrganization", EmitDefaultValue=false)]
		public string CtFtpShipOrganization { get; set; }

		[DataMember(Name="ctFtpShipPhone", EmitDefaultValue=false)]
		public string CtFtpShipPhone { get; set; }

		[DataMember(Name="ctFtpShipShippedBy", EmitDefaultValue=false)]
		public string CtFtpShipShippedBy { get; set; }

		[DataMember(Name="ctFtpShipShippingDate", EmitDefaultValue=false)]
		public DateTime? CtFtpShipShippingDate { get; set; }

		[DataMember(Name="ctFtpShipTrackingNumber", EmitDefaultValue=false)]
		public string CtFtpShipTrackingNumber { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}