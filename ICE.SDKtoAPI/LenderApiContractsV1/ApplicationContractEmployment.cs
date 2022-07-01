using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class ApplicationContractEmployment
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
		public ApplicationContractContact Contact { get; set; }

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

		[DataMember(Name = "employmentStartDate", EmitDefaultValue = false)]
		public DateTime? EmploymentStartDate { get; set; }

		[DataMember(Name="titlePhone", EmitDefaultValue=false)]
		public string TitlePhone { get; set; }

		[DataMember(Name="verificationRequestDate", EmitDefaultValue=false)]
		public DateTime? VerificationRequestDate { get; set; }

		[DataMember(Name = "jobTermMonths", EmitDefaultValue = false)]
		public int? JobTermMonths { get; set; }

		[DataMember(Name = "militaryEntitlement", EmitDefaultValue = false)]
		public double? MilitaryEntitlement { get; set; }

		[DataMember(Name = "specialEmployerRelationshipIndicator", EmitDefaultValue = false)]
		public bool? SpecialEmployerRelationshipIndicator { get; set; }

		[DataMember(Name = "ownershipInterestType", EmitDefaultValue = false)]
		public string OwnershipInterestType { get; set; }

		[DataMember(Name = "employmentMonthlyIncomeAmount", EmitDefaultValue = false)]
		public decimal? EmploymentMonthlyIncomeAmount { get; set; }

		[DataMember(Name = "unitType", EmitDefaultValue = false)]
		public string UnitType { get; set; }

		[DataMember(Name = "unitNumber", EmitDefaultValue = false)]
		public string UnitNumber { get; set; }

		[DataMember(Name = "uRLA2020StreetAddress", EmitDefaultValue = false)]
		public string URLA2020StreetAddress { get; set; }

		[DataMember(Name = "countryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }

		[DataMember(Name = "individualEmployer", EmitDefaultValue = false)]
		public bool? IndividualEmployer { get; set; }

		[DataMember(Name = "militaryEmployer", EmitDefaultValue = false)]
		public bool? MilitaryEmployer { get; set; }

		[DataMember(Name = "printUserJobTitleIndicator", EmitDefaultValue = false)]
		public bool? PrintUserJobTitleIndicator { get; set; }

		[DataMember(Name = "militaryCombatPay", EmitDefaultValue = false)]
		public decimal? MilitaryCombatPay { get; set; }

		[DataMember(Name = "militaryHazardPay", EmitDefaultValue = false)]
		public decimal? MilitaryHazardPay { get; set; }

		[DataMember(Name = "militaryOverseasPay", EmitDefaultValue = false)]
		public decimal? MilitaryOverseasPay { get; set; }

		[DataMember(Name = "militaryPropPay", EmitDefaultValue = false)]
		public decimal? MilitaryPropPay { get; set; }

		[DataMember(Name = "clothingAllowance", EmitDefaultValue = false)]
		public decimal? ClothingAllowance { get; set; }

		[DataMember(Name = "rationsAllowance", EmitDefaultValue = false)]
		public decimal? RationsAllowance { get; set; }

		[DataMember(Name = "variableHousingAllowance", EmitDefaultValue = false)]
		public decimal? VariableHousingAllowance { get; set; }

		[DataMember(Name = "quartersAllowance", EmitDefaultValue = false)]
		public decimal? QuartersAllowance { get; set; }

		[DataMember(Name = "otherAllowanceDescription", EmitDefaultValue = false)]
		public string OtherAllowanceDescription { get; set; }

		[DataMember(Name = "foreignIncome", EmitDefaultValue = false)]
		public bool? ForeignIncome { get; set; }

		[DataMember(Name = "seasonalIncome", EmitDefaultValue = false)]
		public bool? SeasonalIncome { get; set; }

		[DataMember(Name = "verificationDate", EmitDefaultValue = false)]
		public DateTime? VerificationDate { get; set; }

		[DataMember(Name = "country", EmitDefaultValue = false)]
		public string Country { get; set; }

		[DataMember(Name = "foreignAddressIndicator", EmitDefaultValue = false)]
		public bool? ForeignAddressIndicator { get; set; }
	}
}