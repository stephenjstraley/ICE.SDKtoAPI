using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentClosingEntities
	{
		[DataMember(Name="alias")]
		public string Alias { get; set; }

		[DataMember(Name="assignee")]
		public string Assignee { get; set; }

		[DataMember(Name="authorizedToSignIndicator")]
		public bool? AuthorizedToSignIndicator { get; set; }

		[DataMember(Name="borrowerPair")]
		public string BorrowerPair { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="closingEntityType")]
		public string ClosingEntityType { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="county")]
		public string County { get; set; }

		[DataMember(Name="dateOfBirth")]
		public DateTime? DateOfBirth { get; set; }

		[DataMember(Name="fax")]
		public string Fax { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="nBORecordID")]
		public string NBORecordID { get; set; }

		[DataMember(Name="occupancyIntent")]
		public string OccupancyIntent { get; set; }

		[DataMember(Name="occupancyStatus")]
		public string OccupancyStatus { get; set; }

		[DataMember(Name="organizationType")]
		public string OrganizationType { get; set; }

		[DataMember(Name="organizedUnderTheLawsOfJurisdictionName")]
		public string OrganizedUnderTheLawsOfJurisdictionName { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="phone1")]
		public string Phone1 { get; set; }

		[DataMember(Name="phone2")]
		public string Phone2 { get; set; }

		[DataMember(Name="poaSignatureText")]
		public string PoaSignatureText { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="powerOfAttorney")]
		public string PowerOfAttorney { get; set; }

		[DataMember(Name="recordableDocumentTrustDate")]
		public DateTime? RecordableDocumentTrustDate { get; set; }

		[DataMember(Name="recordCity")]
		public string RecordCity { get; set; }

		[DataMember(Name="ssn")]
		public string Ssn { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="streetAddress")]
		public string StreetAddress { get; set; }

		[DataMember(Name="taxIdentificationNumberIdentifier")]
		public string TaxIdentificationNumberIdentifier { get; set; }

		[DataMember(Name="trusteeIndex")]
		public int? TrusteeIndex { get; set; }

		[DataMember(Name="trustOfficerName1")]
		public string TrustOfficerName1 { get; set; }

		[DataMember(Name="trustOfficerName2")]
		public string TrustOfficerName2 { get; set; }

		[DataMember(Name="trustOfficerTitle1")]
		public string TrustOfficerTitle1 { get; set; }

		[DataMember(Name="trustOfficerTitle2")]
		public string TrustOfficerTitle2 { get; set; }

		[DataMember(Name="unparsedName")]
		public string UnparsedName { get; set; }

		[DataMember(Name="vesting")]
		public string Vesting { get; set; }

		[DataMember(Name="vestingGuid")]
		public string VestingGuid { get; set; }

		[DataMember(Name="vestingTrusteeOfType")]
		public string VestingTrusteeOfType { get; set; }

		[DataMember(Name="vestingType")]
		public string VestingType { get; set; }

	}
}