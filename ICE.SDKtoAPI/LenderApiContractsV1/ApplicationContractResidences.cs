using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ApplicationContractResidences
	{
		[DataMember(Name="accountName", EmitDefaultValue=false)]
		public string AccountName { get; set; }

		[DataMember(Name="addressCity", EmitDefaultValue=false)]
		public string AddressCity { get; set; }

		[DataMember(Name="addressPostalCode", EmitDefaultValue=false)]
		public string AddressPostalCode { get; set; }

		[DataMember(Name="addressState", EmitDefaultValue=false)]
		public string AddressState { get; set; }

		[DataMember(Name="addressStreetLine1", EmitDefaultValue=false)]
		public string AddressStreetLine1 { get; set; }

		[DataMember(Name="altId", EmitDefaultValue=false)]
		public string AltId { get; set; }

		[DataMember(Name="applicantType", EmitDefaultValue=false)]
		public string ApplicantType { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public ApplicationContractContact Contact { get; set; }

		[DataMember(Name="county", EmitDefaultValue=false)]
		public string County { get; set; }

		[DataMember(Name="durationTermMonths", EmitDefaultValue=false)]
		public int? DurationTermMonths { get; set; }

		[DataMember(Name="durationTermYears", EmitDefaultValue=false)]
		public int? DurationTermYears { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="landlordAttention", EmitDefaultValue=false)]
		public string LandlordAttention { get; set; }

		[DataMember(Name="landlordCity", EmitDefaultValue=false)]
		public string LandlordCity { get; set; }

		[DataMember(Name="landlordComments", EmitDefaultValue=false)]
		public string LandlordComments { get; set; }

		[DataMember(Name="landlordEmail", EmitDefaultValue=false)]
		public string LandlordEmail { get; set; }

		[DataMember(Name="landlordFax", EmitDefaultValue=false)]
		public string LandlordFax { get; set; }

		[DataMember(Name="landlordName", EmitDefaultValue=false)]
		public string LandlordName { get; set; }

		[DataMember(Name="landlordPhone", EmitDefaultValue=false)]
		public string LandlordPhone { get; set; }

		[DataMember(Name="landlordPostalCode", EmitDefaultValue=false)]
		public string LandlordPostalCode { get; set; }

		[DataMember(Name="landlordState", EmitDefaultValue=false)]
		public string LandlordState { get; set; }

		[DataMember(Name="landlordStreet", EmitDefaultValue=false)]
		public string LandlordStreet { get; set; }

		[DataMember(Name="mailingAddressIndicator", EmitDefaultValue=false)]
		public bool? MailingAddressIndicator { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
		public bool? PrintAttachmentIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="rent", EmitDefaultValue=false)]
		public int? Rent { get; set; }

		[DataMember(Name="requestDate", EmitDefaultValue=false)]
		public DateTime? RequestDate { get; set; }

		[DataMember(Name="residencyBasisType", EmitDefaultValue=false)]
		public string ResidencyBasisType { get; set; }

		[DataMember(Name="residencyType", EmitDefaultValue=false)]
		public string ResidencyType { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleFax", EmitDefaultValue=false)]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }


	}
}