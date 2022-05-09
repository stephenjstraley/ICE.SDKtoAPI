using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractEDisclosure
	{
		[DataMember(Name="applicationPackage", EmitDefaultValue=false)]
		public bool? ApplicationPackage { get; set; }

		[DataMember(Name="approvalPackage", EmitDefaultValue=false)]
		public bool? ApprovalPackage { get; set; }

		[DataMember(Name="borrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? BorrowerAcceptConsentDate { get; set; }

		[DataMember(Name="borrowerAcceptConsentIP", EmitDefaultValue=false)]
		public string BorrowerAcceptConsentIP { get; set; }

		[DataMember(Name="borrowerAuthenticatedDate", EmitDefaultValue=false)]
		public DateTime? BorrowerAuthenticatedDate { get; set; }

		[DataMember(Name="borrowerAuthenticatedIP", EmitDefaultValue=false)]
		public string BorrowerAuthenticatedIP { get; set; }

		[DataMember(Name="borrowerDocumentViewedDate", EmitDefaultValue=false)]
		public DateTime? BorrowerDocumentViewedDate { get; set; }

		[DataMember(Name="borrowerEmail", EmitDefaultValue=false)]
		public string BorrowerEmail { get; set; }

		[DataMember(Name="borrowerESignedDate", EmitDefaultValue=false)]
		public DateTime? BorrowerESignedDate { get; set; }

		[DataMember(Name="borrowereSignedIP", EmitDefaultValue=false)]
		public string BorrowereSignedIP { get; set; }

		[DataMember(Name="borrowerLoanLevelConsent", EmitDefaultValue=false)]
		public string BorrowerLoanLevelConsent { get; set; }

		[DataMember(Name="borrowerName", EmitDefaultValue=false)]
		public string BorrowerName { get; set; }

		[DataMember(Name="borrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? BorrowerRejectConsentDate { get; set; }

		[DataMember(Name="borrowerRejectConsentIP", EmitDefaultValue=false)]
		public string BorrowerRejectConsentIP { get; set; }

		[DataMember(Name="borrowerViewConsentDate", EmitDefaultValue=false)]
		public DateTime? BorrowerViewConsentDate { get; set; }

		[DataMember(Name="borrowerViewMessageDate", EmitDefaultValue=false)]
		public DateTime? BorrowerViewMessageDate { get; set; }

		[DataMember(Name="borrowerWetSignedDate", EmitDefaultValue=false)]
		public DateTime? BorrowerWetSignedDate { get; set; }

		[DataMember(Name="coborrowerAcceptConsentDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerAcceptConsentDate { get; set; }

		[DataMember(Name="coborrowerAcceptConsentIP", EmitDefaultValue=false)]
		public string CoborrowerAcceptConsentIP { get; set; }

		[DataMember(Name="coborrowerAuthenticatedDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerAuthenticatedDate { get; set; }

		[DataMember(Name="coborrowerAuthenticatedIP", EmitDefaultValue=false)]
		public string CoborrowerAuthenticatedIP { get; set; }

		[DataMember(Name="coborrowerDocumentViewedDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerDocumentViewedDate { get; set; }

		[DataMember(Name="coborrowerEmail", EmitDefaultValue=false)]
		public string CoborrowerEmail { get; set; }

		[DataMember(Name="coborrowerESignedDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerESignedDate { get; set; }

		[DataMember(Name="coborrowereSignedIP", EmitDefaultValue=false)]
		public string CoborrowereSignedIP { get; set; }

		[DataMember(Name="coborrowerLoanLevelConsent", EmitDefaultValue=false)]
		public string CoborrowerLoanLevelConsent { get; set; }

		[DataMember(Name="coborrowerName", EmitDefaultValue=false)]
		public string CoborrowerName { get; set; }

		[DataMember(Name="coborrowerRejectConsentDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerRejectConsentDate { get; set; }

		[DataMember(Name="coborrowerRejectConsentIP", EmitDefaultValue=false)]
		public string CoborrowerRejectConsentIP { get; set; }

		[DataMember(Name="coborrowerViewConsentDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerViewConsentDate { get; set; }

		[DataMember(Name="coborrowerViewMessageDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerViewMessageDate { get; set; }

		[DataMember(Name="coborrowerWebSignedDate", EmitDefaultValue=false)]
		public DateTime? CoborrowerWebSignedDate { get; set; }

		[DataMember(Name="consentPdf", EmitDefaultValue=false)]
		public string ConsentPdf { get; set; }

		[DataMember(Name="disclosedMessage", EmitDefaultValue=false)]
		public string DisclosedMessage { get; set; }

		[DataMember(Name="lockPackage", EmitDefaultValue=false)]
		public bool? LockPackage { get; set; }

		[DataMember(Name="loESignedDate", EmitDefaultValue=false)]
		public DateTime? LoESignedDate { get; set; }

		[DataMember(Name="loESignedIP", EmitDefaultValue=false)]
		public string LoESignedIP { get; set; }

		[DataMember(Name="loName", EmitDefaultValue=false)]
		public string LoName { get; set; }

		[DataMember(Name="loViewMessageDate", EmitDefaultValue=false)]
		public DateTime? LoViewMessageDate { get; set; }

		[DataMember(Name="manualFulfillmentComment", EmitDefaultValue=false)]
		public string ManualFulfillmentComment { get; set; }

		[DataMember(Name="manualFulfillmentDate", EmitDefaultValue=false)]
		public DateTime? ManualFulfillmentDate { get; set; }

		[DataMember(Name="manualFulfillmentMethod", EmitDefaultValue=false)]
		public string ManualFulfillmentMethod { get; set; }

		[DataMember(Name="manuallyFulfilledBy", EmitDefaultValue=false)]
		public string ManuallyFulfilledBy { get; set; }

		[DataMember(Name="packageCreatedDate", EmitDefaultValue=false)]
		public DateTime? PackageCreatedDate { get; set; }

		[DataMember(Name="packageId", EmitDefaultValue=false)]
		public string PackageId { get; set; }

		[DataMember(Name="packageViewableFile", EmitDefaultValue=false)]
		public string PackageViewableFile { get; set; }

		[DataMember(Name="threeDayPackage", EmitDefaultValue=false)]
		public bool? ThreeDayPackage { get; set; }

	}
}