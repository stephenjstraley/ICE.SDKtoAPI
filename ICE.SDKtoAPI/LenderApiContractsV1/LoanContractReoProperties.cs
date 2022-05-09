using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractReoProperties
	{
		[DataMember(Name="acquiredDate", EmitDefaultValue=false)]
		public DateTime? AcquiredDate { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="dispositionStatusType", EmitDefaultValue=false)]
		public string DispositionStatusType { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="gsePropertyType", EmitDefaultValue=false)]
		public string GsePropertyType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isEmpty", EmitDefaultValue=false)]
		public bool? IsEmpty { get; set; }

		[DataMember(Name="lienInstallmentAmount", EmitDefaultValue=false)]
		public double? LienInstallmentAmount { get; set; }

		[DataMember(Name="lienUpbAmount", EmitDefaultValue=false)]
		public double? LienUpbAmount { get; set; }

		[DataMember(Name="maintenanceExpenseAmount", EmitDefaultValue=false)]
		public string MaintenanceExpenseAmount { get; set; }

		[DataMember(Name="marketValueAmount", EmitDefaultValue=false)]
		public double? MarketValueAmount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="participationPercentage", EmitDefaultValue=false)]
		public double? ParticipationPercentage { get; set; }

		[DataMember(Name="percentageofRental", EmitDefaultValue=false)]
		public double? PercentageofRental { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="printAttachIndicator", EmitDefaultValue=false)]
		public bool? PrintAttachIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="purchasePrice", EmitDefaultValue=false)]
		public int? PurchasePrice { get; set; }

		[DataMember(Name="rentalIncomeGrossAmount", EmitDefaultValue=false)]
		public double? RentalIncomeGrossAmount { get; set; }

		[DataMember(Name="rentalIncomeNetAmount", EmitDefaultValue=false)]
		public double? RentalIncomeNetAmount { get; set; }

		[DataMember(Name="reoComments", EmitDefaultValue=false)]
		public string ReoComments { get; set; }

		[DataMember(Name="reoId", EmitDefaultValue=false)]
		public string ReoId { get; set; }

		[DataMember(Name="reoPropertyIndex", EmitDefaultValue=false)]
		public int? ReoPropertyIndex { get; set; }

		[DataMember(Name="requestDate", EmitDefaultValue=false)]
		public DateTime? RequestDate { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="streetAddress", EmitDefaultValue=false)]
		public string StreetAddress { get; set; }

		[DataMember(Name="subjectIndicator", EmitDefaultValue=false)]
		public bool? SubjectIndicator { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleFax", EmitDefaultValue=false)]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }

	}
}