using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAssets
	{
		[DataMember(Name="accountIdentifier")]
		public string AccountIdentifier { get; set; }

		[DataMember(Name="altId")]
		public string AltId { get; set; }

		[DataMember(Name="assetIndex")]
		public int? AssetIndex { get; set; }

		[DataMember(Name="assetType")]
		public string AssetType { get; set; }

		[DataMember(Name="attention")]
		public string Attention { get; set; }

		[DataMember(Name="borrowerId")]
		public string BorrowerId { get; set; }

		[DataMember(Name="cashOrMarketValueAmount")]
		public decimal? CashOrMarketValueAmount { get; set; }

		[DataMember(Name="contact")]
		public EntityRefContract Contact { get; set; }

		[DataMember(Name="depositoryAccountName")]
		public string DepositoryAccountName { get; set; }

		[DataMember(Name="depositoryRequestDate")]
		public DateTime? DepositoryRequestDate { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="entityDeleted")]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="holderAddressCity")]
		public string HolderAddressCity { get; set; }

		[DataMember(Name="holderAddressPostalCode")]
		public string HolderAddressPostalCode { get; set; }

		[DataMember(Name="holderAddressState")]
		public string HolderAddressState { get; set; }

		[DataMember(Name="holderAddressStreetLine1")]
		public string HolderAddressStreetLine1 { get; set; }

		[DataMember(Name="holderComments")]
		public string HolderComments { get; set; }

		[DataMember(Name="holderEmail")]
		public string HolderEmail { get; set; }

		[DataMember(Name="holderFax")]
		public string HolderFax { get; set; }

		[DataMember(Name="holderName")]
		public string HolderName { get; set; }

		[DataMember(Name="holderPhone")]
		public string HolderPhone { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isEmpty")]
		public bool? IsEmpty { get; set; } = false;

		[DataMember(Name="isVod")]
		public bool? IsVod { get; set; } = false;

		[DataMember(Name="lifeInsuranceFaceValueAmount")]
		public decimal? LifeInsuranceFaceValueAmount { get; set; }

		[DataMember(Name="nameInAccount")]
		public string NameInAccount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator")]
		public bool? NoLinkToDocTrackIndicator { get; set; } = false;

		[DataMember(Name="owner")]
		public string Owner { get; set; }

		[DataMember(Name = "printAttachmentIndicator")]
		public bool? PrintAttachmentIndicator { get; set; } = false;

		[DataMember(Name="printUserNameIndicator")]
		public bool? PrintUserNameIndicator { get; set; } = false;

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="titleFax")]
		public string TitleFax { get; set; }

		[DataMember(Name= "titlePhone")]
		public string TitlePhone { get; set; }

		[DataMember(Name="total")]
		public decimal? Total { get; set; }

		[DataMember(Name="vodIndex")]
		public int? VodIndex { get; set; }

		[DataMember(Name = "includeInAusExport")]
		public bool? IncludeInAusExport { get; set; } = false;

	}
}