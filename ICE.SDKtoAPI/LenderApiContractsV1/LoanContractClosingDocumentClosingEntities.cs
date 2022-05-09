using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentClosingEntities
	{
		[DataMember(Name="alias", EmitDefaultValue=false)]
		public string Alias { get; set; }

		[DataMember(Name="assignee", EmitDefaultValue=false)]
		public string Assignee { get; set; }

		[DataMember(Name="authorizedToSignIndicator", EmitDefaultValue=false)]
		public bool? AuthorizedToSignIndicator { get; set; }

		[DataMember(Name="borrowerPair", EmitDefaultValue=false)]
		public string BorrowerPair { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="closingEntityType", EmitDefaultValue=false)]
		public string ClosingEntityType { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="county", EmitDefaultValue=false)]
		public string County { get; set; }

		[DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
		public DateTime? DateOfBirth { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="nBORecordID", EmitDefaultValue=false)]
		public string NBORecordID { get; set; }

		[DataMember(Name="occupancyIntent", EmitDefaultValue=false)]
		public string OccupancyIntent { get; set; }

		[DataMember(Name="occupancyStatus", EmitDefaultValue=false)]
		public string OccupancyStatus { get; set; }

		[DataMember(Name="organizationType", EmitDefaultValue=false)]
		public string OrganizationType { get; set; }

		[DataMember(Name="organizedUnderTheLawsOfJurisdictionName", EmitDefaultValue=false)]
		public string OrganizedUnderTheLawsOfJurisdictionName { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="phone1", EmitDefaultValue=false)]
		public string Phone1 { get; set; }

		[DataMember(Name="phone2", EmitDefaultValue=false)]
		public string Phone2 { get; set; }

		[DataMember(Name="poaSignatureText", EmitDefaultValue=false)]
		public string PoaSignatureText { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="powerOfAttorney", EmitDefaultValue=false)]
		public string PowerOfAttorney { get; set; }

		[DataMember(Name="recordableDocumentTrustDate", EmitDefaultValue=false)]
		public DateTime? RecordableDocumentTrustDate { get; set; }

		[DataMember(Name="recordCity", EmitDefaultValue=false)]
		public string RecordCity { get; set; }

		[DataMember(Name="ssn", EmitDefaultValue=false)]
		public string Ssn { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="streetAddress", EmitDefaultValue=false)]
		public string StreetAddress { get; set; }

		[DataMember(Name="taxIdentificationNumberIdentifier", EmitDefaultValue=false)]
		public string TaxIdentificationNumberIdentifier { get; set; }

		[DataMember(Name="trusteeIndex", EmitDefaultValue=false)]
		public int? TrusteeIndex { get; set; }

		[DataMember(Name="trustOfficerName1", EmitDefaultValue=false)]
		public string TrustOfficerName1 { get; set; }

		[DataMember(Name="trustOfficerName2", EmitDefaultValue=false)]
		public string TrustOfficerName2 { get; set; }

		[DataMember(Name="trustOfficerTitle1", EmitDefaultValue=false)]
		public string TrustOfficerTitle1 { get; set; }

		[DataMember(Name="trustOfficerTitle2", EmitDefaultValue=false)]
		public string TrustOfficerTitle2 { get; set; }

		[DataMember(Name="unparsedName", EmitDefaultValue=false)]
		public string UnparsedName { get; set; }

		[DataMember(Name="vesting", EmitDefaultValue=false)]
		public string Vesting { get; set; }

		[DataMember(Name="vestingGuid", EmitDefaultValue=false)]
		public string VestingGuid { get; set; }

		[DataMember(Name="vestingTrusteeOfType", EmitDefaultValue=false)]
		public string VestingTrusteeOfType { get; set; }

		[DataMember(Name="vestingType", EmitDefaultValue=false)]
		public string VestingType { get; set; }

	}
}