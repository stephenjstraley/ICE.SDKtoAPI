using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractEDisclosure
	{
		[DataMember(Name="applicationPackage")]
		public bool? ApplicationPackage { get; set; }

		[DataMember(Name="approvalPackage")]
		public bool? ApprovalPackage { get; set; }

		[DataMember(Name="borrowerAcceptConsentDate")]
		public DateTime? BorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="borrowerAcceptConsentIP")]
		public string BorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="borrowerAuthenticatedDate")]
		public DateTime? BorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="borrowerAuthenticatedIP")]
		public string BorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="borrowerDocumentViewedDate")]
		public DateTime? BorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="borrowerEmail")]
		public string BorrowerEmail { get; set; }

		[DataMember(Name="borrowerESignedDate")]
		public DateTime? BorrowerESignedDate { get; set; }

		[DataMember(Name="borrowereSignedIP")]
		public string BorrowereSignedIP { get; set; }

		[DataMember(Name="borrowerLoanLevelConsent")]
		public string BorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="borrowerName")]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerRejectConsentDate")]
		public DateTime? BorrowerRejectConsentDate { get; set; }

		[DataMember(Name="borrowerRejectConsentIP")]
		public string BorrowerRejectConsentIP { get; set; }

		[DataMember(Name="borrowerViewConsentDate")]
		public DateTime? BorrowerViewConsentDate { get; set; }

		[DataMember(Name="borrowerViewMessageDate")]
		public DateTime? BorrowerViewMessageDate { get; set; }

		[DataMember(Name="borrowerWetSignedDate")]
		public DateTime? BorrowerWetSignedDate { get; set; }

		[DataMember(Name="coborrowerAcceptConsentDate")]
		public DateTime? CoborrowerAcceptConsentDate { get; set; }

		[DataMember(Name="coborrowerAcceptConsentIP")]
		public string CoborrowerAcceptConsentIP { get; set; }

		[DataMember(Name="coborrowerAuthenticatedDate")]
		public DateTime? CoborrowerAuthenticatedDate { get; set; }

		[DataMember(Name="coborrowerAuthenticatedIP")]
		public string CoborrowerAuthenticatedIP { get; set; }

		[DataMember(Name="coborrowerDocumentViewedDate")]
		public DateTime? CoborrowerDocumentViewedDate { get; set; }

		[DataMember(Name="coborrowerEmail")]
		public string CoborrowerEmail { get; set; }

		[DataMember(Name="coborrowerESignedDate")]
		public DateTime? CoborrowerESignedDate { get; set; }

		[DataMember(Name="coborrowereSignedIP")]
		public string CoborrowereSignedIP { get; set; }

		[DataMember(Name="coborrowerLoanLevelConsent")]
		public string CoborrowerLoanLevelConsent { get; set; }

		[DataMember(Name="coborrowerName")]
		public string CoborrowerName { get; set; }

		[DataMember(Name="coborrowerRejectConsentDate")]
		public DateTime? CoborrowerRejectConsentDate { get; set; }

		[DataMember(Name="coborrowerRejectConsentIP")]
		public string CoborrowerRejectConsentIP { get; set; }

		[DataMember(Name="coborrowerViewConsentDate")]
		public DateTime? CoborrowerViewConsentDate { get; set; }

		[DataMember(Name="coborrowerViewMessageDate")]
		public DateTime? CoborrowerViewMessageDate { get; set; }

		[DataMember(Name="coborrowerWebSignedDate")]
		public DateTime? CoborrowerWebSignedDate { get; set; }

		[DataMember(Name="consentPdf")]
		public string ConsentPdf { get; set; }

		[DataMember(Name="disclosedMessage")]
		public string DisclosedMessage { get; set; }

		[DataMember(Name="lockPackage")]
		public bool? LockPackage { get; set; }

		[DataMember(Name="loESignedDate")]
		public DateTime? LoESignedDate { get; set; }

		[DataMember(Name="loESignedIP")]
		public string LoESignedIP { get; set; }

		[DataMember(Name="loName")]
		public string LoName { get; set; }

		[DataMember(Name="loViewMessageDate")]
		public DateTime? LoViewMessageDate { get; set; }

		[DataMember(Name="manualFulfillmentComment")]
		public string ManualFulfillmentComment { get; set; }

		[DataMember(Name="manualFulfillmentDate")]
		public DateTime? ManualFulfillmentDate { get; set; }

		[DataMember(Name="manualFulfillmentMethod")]
		public string ManualFulfillmentMethod { get; set; }

		[DataMember(Name="manuallyFulfilledBy")]
		public string ManuallyFulfilledBy { get; set; }

		[DataMember(Name="packageCreatedDate")]
		public DateTime? PackageCreatedDate { get; set; }

		[DataMember(Name="packageId")]
		public string PackageId { get; set; }

		[DataMember(Name="packageViewableFile")]
		public string PackageViewableFile { get; set; }

		[DataMember(Name="threeDayPackage")]
		public bool? ThreeDayPackage { get; set; }

	}
}