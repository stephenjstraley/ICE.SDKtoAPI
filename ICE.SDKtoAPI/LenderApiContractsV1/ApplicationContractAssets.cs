using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ApplicationContractAssets
	{
		[DataMember(Name="accountIdentifier", EmitDefaultValue=false)]
		public string AccountIdentifier { get; set; }

		[DataMember(Name="altId", EmitDefaultValue=false)]
		public string AltId { get; set; }

		[DataMember(Name="assetIndex", EmitDefaultValue=false)]
		public int? AssetIndex { get; set; }

		[DataMember(Name="assetType", EmitDefaultValue=false)]
		public string AssetType { get; set; }

		[DataMember(Name="attention", EmitDefaultValue=false)]
		public string Attention { get; set; }

		[DataMember(Name="borrowerId", EmitDefaultValue=false)]
		public string BorrowerId { get; set; }

		[DataMember(Name="cashOrMarketValueAmount", EmitDefaultValue=false)]
		public double? CashOrMarketValueAmount { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public ApplicationContractContact Contact { get; set; }

		[DataMember(Name="depositoryAccountName", EmitDefaultValue=false)]
		public string DepositoryAccountName { get; set; }

		[DataMember(Name="depositoryRequestDate", EmitDefaultValue=false)]
		public DateTime? DepositoryRequestDate { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="holderAddressCity", EmitDefaultValue=false)]
		public string HolderAddressCity { get; set; }

		[DataMember(Name="holderAddressPostalCode", EmitDefaultValue=false)]
		public string HolderAddressPostalCode { get; set; }

		[DataMember(Name="holderAddressState", EmitDefaultValue=false)]
		public string HolderAddressState { get; set; }

		[DataMember(Name="holderAddressStreetLine1", EmitDefaultValue=false)]
		public string HolderAddressStreetLine1 { get; set; }

		[DataMember(Name="holderComments", EmitDefaultValue=false)]
		public string HolderComments { get; set; }

		[DataMember(Name="holderEmail", EmitDefaultValue=false)]
		public string HolderEmail { get; set; }

		[DataMember(Name="holderFax", EmitDefaultValue=false)]
		public string HolderFax { get; set; }

		[DataMember(Name="holderName", EmitDefaultValue=false)]
		public string HolderName { get; set; }

		[DataMember(Name="holderPhone", EmitDefaultValue=false)]
		public string HolderPhone { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isEmpty", EmitDefaultValue=false)]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="isVod", EmitDefaultValue=false)]
		public bool? IsVod { get; set; }

		[DataMember(Name="lifeInsuranceFaceValueAmount", EmitDefaultValue=false)]
		public double? LifeInsuranceFaceValueAmount { get; set; }

		[DataMember(Name="nameInAccount", EmitDefaultValue=false)]
		public string NameInAccount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="owner", EmitDefaultValue=false)]
		public string Owner { get; set; }

		[DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
		public bool? PrintAttachmentIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleFax", EmitDefaultValue=false)]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }

		[DataMember(Name="total", EmitDefaultValue=false)]
		public double? Total { get; set; }

		[DataMember(Name="vodIndex", EmitDefaultValue=false)]
		public int? VodIndex { get; set; }

	}
}