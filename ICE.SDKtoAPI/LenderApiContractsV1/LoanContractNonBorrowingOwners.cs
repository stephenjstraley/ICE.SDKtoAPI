using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractNonBorrowingOwners
	{
		[DataMember(Name="addressCity", EmitDefaultValue=false)]
		public string AddressCity { get; set; }

		[DataMember(Name="addressPostalCode", EmitDefaultValue=false)]
		public string AddressPostalCode { get; set; }

		[DataMember(Name="addressState", EmitDefaultValue=false)]
		public string AddressState { get; set; }

		[DataMember(Name="addressStreet", EmitDefaultValue=false)]
		public string AddressStreet { get; set; }

		[DataMember(Name="borrowerType", EmitDefaultValue=false)]
		public string BorrowerType { get; set; }

		[DataMember(Name="borrowerVestingRecordID", EmitDefaultValue=false)]
		public string BorrowerVestingRecordID { get; set; }

		[DataMember(Name="businessPhoneNumber", EmitDefaultValue=false)]
		public string BusinessPhoneNumber { get; set; }

		[DataMember(Name="cellPhoneNumber", EmitDefaultValue=false)]
		public string CellPhoneNumber { get; set; }

		[DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
		public DateTime? DateOfBirth { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="eSignConsentNBOCDateAccepted", EmitDefaultValue=false)]
		public DateTime? ESignConsentNBOCDateAccepted { get; set; }

		[DataMember(Name="eSignConsentNBOCDateSent", EmitDefaultValue=false)]
		public DateTime? ESignConsentNBOCDateSent { get; set; }

		[DataMember(Name="eSignConsentNBOCIPAddress", EmitDefaultValue=false)]
		public string ESignConsentNBOCIPAddress { get; set; }

		[DataMember(Name="eSignConsentNBOCSource", EmitDefaultValue=false)]
		public string ESignConsentNBOCSource { get; set; }

		[DataMember(Name="eSignConsentNBOCStatus", EmitDefaultValue=false)]
		public string ESignConsentNBOCStatus { get; set; }

		[DataMember(Name="faxNumber", EmitDefaultValue=false)]
		public string FaxNumber { get; set; }

		[DataMember(Name="firstName", EmitDefaultValue=false)]
		public string FirstName { get; set; }

		[DataMember(Name="homePhoneNumber", EmitDefaultValue=false)]
		public string HomePhoneNumber { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastName", EmitDefaultValue=false)]
		public string LastName { get; set; }

		[DataMember(Name="middleName", EmitDefaultValue=false)]
		public string MiddleName { get; set; }

		[DataMember(Name="nBOID", EmitDefaultValue=false)]
		public string NBOID { get; set; }

		[DataMember(Name="no3rdPartyEmailIndicator", EmitDefaultValue=false)]
		public bool? No3rdPartyEmailIndicator { get; set; }

		[DataMember(Name="suffixName", EmitDefaultValue=false)]
		public string SuffixName { get; set; }

	}
}