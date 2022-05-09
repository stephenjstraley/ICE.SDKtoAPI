using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractEmployment
	{
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

		[DataMember(Name="attention", EmitDefaultValue=false)]
		public string Attention { get; set; }

		[DataMember(Name="badgeOrEmployeeID", EmitDefaultValue=false)]
		public string BadgeOrEmployeeID { get; set; }

		[DataMember(Name="basePayAmount", EmitDefaultValue=false)]
		public double? BasePayAmount { get; set; }

		[DataMember(Name="bonusAmount", EmitDefaultValue=false)]
		public double? BonusAmount { get; set; }

		[DataMember(Name="businessName", EmitDefaultValue=false)]
		public string BusinessName { get; set; }

		[DataMember(Name="businessOwnedPercent", EmitDefaultValue=false)]
		public double? BusinessOwnedPercent { get; set; }

		[DataMember(Name="businessPhone", EmitDefaultValue=false)]
		public string BusinessPhone { get; set; }

		[DataMember(Name="commissionsAmount", EmitDefaultValue=false)]
		public double? CommissionsAmount { get; set; }

		[DataMember(Name="contact", EmitDefaultValue=false)]
		public EntityRefContract Contact { get; set; }

		[DataMember(Name="currentEmploymentIndicator", EmitDefaultValue=false)]
		public bool? CurrentEmploymentIndicator { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="employerComments", EmitDefaultValue=false)]
		public string EmployerComments { get; set; }

		[DataMember(Name="employerName", EmitDefaultValue=false)]
		public string EmployerName { get; set; }

		[DataMember(Name="endDate", EmitDefaultValue=false)]
		public DateTime? EndDate { get; set; }

		[DataMember(Name="entityDeleted", EmitDefaultValue=false)]
		public bool? EntityDeleted { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="monthlyIncomeAmount", EmitDefaultValue=false)]
		public int? MonthlyIncomeAmount { get; set; }

		[DataMember(Name="noLinkToDocTrackIndicator", EmitDefaultValue=false)]
		public bool? NoLinkToDocTrackIndicator { get; set; }

		[DataMember(Name="otherAmount", EmitDefaultValue=false)]
		public double? OtherAmount { get; set; }

		[DataMember(Name="overtimeAmount", EmitDefaultValue=false)]
		public double? OvertimeAmount { get; set; }

		[DataMember(Name="owner", EmitDefaultValue=false)]
		public string Owner { get; set; }

		[DataMember(Name="phoneNumber", EmitDefaultValue=false)]
		public string PhoneNumber { get; set; }

		[DataMember(Name="positionDescription", EmitDefaultValue=false)]
		public string PositionDescription { get; set; }

		[DataMember(Name="printAttachmentIndicator", EmitDefaultValue=false)]
		public bool? PrintAttachmentIndicator { get; set; }

		[DataMember(Name="printUserNameIndicator", EmitDefaultValue=false)]
		public bool? PrintUserNameIndicator { get; set; }

		[DataMember(Name="selfEmployedIndicator", EmitDefaultValue=false)]
		public bool? SelfEmployedIndicator { get; set; }

		[DataMember(Name="startDate", EmitDefaultValue=false)]
		public DateTime? StartDate { get; set; }

		[DataMember(Name="timeInLineOfWorkMonths", EmitDefaultValue=false)]
		public int? TimeInLineOfWorkMonths { get; set; }

		[DataMember(Name="timeInLineOfWorkYears", EmitDefaultValue=false)]
		public int? TimeInLineOfWorkYears { get; set; }

		[DataMember(Name="timeOnJobTermMonths", EmitDefaultValue=false)]
		public int? TimeOnJobTermMonths { get; set; }

		[DataMember(Name="timeOnJobTermYears", EmitDefaultValue=false)]
		public int? TimeOnJobTermYears { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleFax", EmitDefaultValue=false)]
		public string TitleFax { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }

		[DataMember(Name="verificationRequestDate", EmitDefaultValue=false)]
		public DateTime? VerificationRequestDate { get; set; }

	}
}