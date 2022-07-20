using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractReoProperties
	{
		[DataMember(Name="acquiredDate")]
		public DateTime? AcquiredDate { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="dispositionStatusType")]
		public string DispositionStatusType { get; set; }

		[DataMember(Name="entityDeleted")]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="gsePropertyType")]
		public string GsePropertyType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isEmpty")]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="lienInstallmentAmount")]
		public decimal? LienInstallmentAmount { get; set; }

		[DataMember(Name="lienUpbAmount")]
		public decimal? LienUpbAmount { get; set; }

		[DataMember(Name="maintenanceExpenseAmount")]
		public string MaintenanceExpenseAmount { get; set; }

		[DataMember(Name="marketValueAmount")]
		public decimal? MarketValueAmount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator")]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="participationPercentage")]
		public decimal? ParticipationPercentage { get; set; }

		[DataMember(Name="percentageofRental")]
		public decimal? PercentageofRental { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="printAttachIndicator")]
		public bool? PrintAttachIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator")]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="propertyUsageType")]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="purchasePrice")]
		public int? PurchasePrice { get; set; }

		[DataMember(Name="rentalIncomeGrossAmount")]
		public decimal? RentalIncomeGrossAmount { get; set; }

		[DataMember(Name="rentalIncomeNetAmount")]
		public decimal? RentalIncomeNetAmount { get; set; }

		[DataMember(Name="reoComments")]
		public string ReoComments { get; set; }

		[DataMember(Name="reoId")]
		public string ReoId { get; set; }

		[DataMember(Name="reoPropertyIndex")]
		public int? ReoPropertyIndex { get; set; }

		[DataMember(Name="requestDate")]
		public DateTime? RequestDate { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="streetAddress")]
		public string StreetAddress { get; set; }

		[DataMember(Name="subjectIndicator")]
		public bool? SubjectIndicator { get; set; }

		[DataMember(Name="title")]
		public string Title { get; set; }

		[DataMember(Name="titleFax")]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone")]
		public string TitlePhone { get; set; }

	}
}