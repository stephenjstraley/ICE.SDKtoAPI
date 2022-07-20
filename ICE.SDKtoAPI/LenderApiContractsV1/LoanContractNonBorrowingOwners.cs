using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractNonBorrowingOwners
	{
		[DataMember(Name="addressCity")]
		public string AddressCity { get; set; }

		[DataMember(Name="addressPostalCode")]
		public string AddressPostalCode { get; set; }

		[DataMember(Name="addressState")]
		public string AddressState { get; set; }

		[DataMember(Name="addressStreet")]
		public string AddressStreet { get; set; }

		[DataMember(Name="borrowerType")]
		public string BorrowerType { get; set; }

		[DataMember(Name="borrowerVestingRecordID")]
		public string BorrowerVestingRecordID { get; set; }

		[DataMember(Name="businessPhoneNumber")]
		public string BusinessPhoneNumber { get; set; }

		[DataMember(Name="cellPhoneNumber")]
		public string CellPhoneNumber { get; set; }

		[DataMember(Name="dateOfBirth")]
		public DateTime? DateOfBirth { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="entityDeleted")]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="eSignConsentNBOCDateAccepted")]
		public DateTime? ESignConsentNBOCDateAccepted { get; set; }

		[DataMember(Name="eSignConsentNBOCDateSent")]
		public DateTime? ESignConsentNBOCDateSent { get; set; }

		[DataMember(Name="eSignConsentNBOCIPAddress")]
		public string ESignConsentNBOCIPAddress { get; set; }

		[DataMember(Name="eSignConsentNBOCSource")]
		public string ESignConsentNBOCSource { get; set; }

		[DataMember(Name="eSignConsentNBOCStatus")]
		public string ESignConsentNBOCStatus { get; set; }

		[DataMember(Name="faxNumber")]
		public string FaxNumber { get; set; }

		[DataMember(Name="firstName")]
		public string FirstName { get; set; }

		[DataMember(Name="homePhoneNumber")]
		public string HomePhoneNumber { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastName")]
		public string LastName { get; set; }

		[DataMember(Name="middleName")]
		public string MiddleName { get; set; }

		[DataMember(Name="nBOID")]
		public string NBOID { get; set; }

		[DataMember(Name="no3rdPartyEmailIndicator")]
		public bool? No3rdPartyEmailIndicator { get; set; }

		[DataMember(Name="suffixName")]
		public string SuffixName { get; set; }

	}
}