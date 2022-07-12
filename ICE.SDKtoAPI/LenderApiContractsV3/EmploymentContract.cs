using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class EmploymentContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "addressCity")]
        public string AddressCity { get; set; }

        [DataMember(Name = "addressPostalCode")]
        public string AddressPostalCode { get; set; }

        [DataMember(Name = "addressState")]
        public string AddressState { get; set; }

        [DataMember(Name = "addressStreetLine1")]
        public string AddressStreetLine1 { get; set; }

        [DataMember(Name = "attention")]
        public string Attention { get; set; }

        [DataMember(Name = "badgeOrEmployeeId")]
        public string BadgeOrEmployeeId { get; set; }

        [DataMember(Name = "basePayAmount")]
        public decimal? BasePayAmount { get; set; }

        [DataMember(Name = "bonusAmount")]
        public decimal? BonusAmount { get; set; }

        [DataMember(Name = "businessName")]
        public string BusinessName { get; set; }

        [DataMember(Name = "businessOwnedPercent")]
        public decimal? BusinessOwnedPercent { get; set; }

        [DataMember(Name = "businessPhone")]
        public string BusinessPhone { get; set; }

        [DataMember(Name = "commissionsAmount")]
        public decimal? CommissionsAmount { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "verificationDate")]
        public string VerificationDate { get; set; }

        [DataMember(Name = "currentEmploymentIndicator")]
        public bool? CurrentEmploymentIndicator { get; set; } = false;

        [DataMember(Name = "doesNotApply")]
        public bool? DoesNotApply { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "employerComments")]
        public string EmployerComments { get; set; }

        [DataMember(Name = "employerName")]
        public string EmployerName { get; set; }

        [DataMember(Name = "employmentStartDate")]
        public string EmploymentStartDate { get; set; }

        [DataMember(Name = "jobTermMonths")]
        public int? JobTermMonths { get; set; }

        [DataMember(Name = "baseIncome")]
        public decimal? BaseIncome { get; set; }

        [DataMember(Name = "overTime")]
        public decimal? OverTime { get; set; }

        [DataMember(Name = "bonus")]
        public decimal? Bonus { get; set; }

        [DataMember(Name = "commission")]
        public decimal? Commission { get; set; }

        [DataMember(Name = "militaryEntitlement")]
        public decimal? MilitaryEntitlement { get; set; }

        [DataMember(Name = "otherIncome")]
        public decimal? OtherIncome { get; set; }

        [DataMember(Name = "total")]
        public decimal? Total { get; set; }

        [DataMember(Name = "specialEmployerRelationshipIndicator")]
        public bool? SpecialEmployerRelationshipIndicator { get; set; }

        [DataMember(Name = "ownershipInterestType")]
        public string OwnershipInterestType { get; set; }

        [DataMember(Name = "employmentMonthlyIncomeAmount")]
        public decimal? EmploymentMonthlyIncomeAmount { get; set; }

        [DataMember(Name = "endDate")]
        public string EndDate { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

        [DataMember(Name = "monthlyIncomeAmount")]
        public int? MonthlyIncomeAmount { get; set; }

        [DataMember(Name = "otherAmount")]
        public decimal? OtherAmount { get; set; }

        [DataMember(Name = "overtimeAmount")]
        public decimal? OvertimeAmount { get; set; }

        [DataMember(Name = "phoneNumber")]
        public string PhoneNumber { get; set; }

        [DataMember(Name = "positionDescription")]
        public string PositionDescription { get; set; }

        [DataMember(Name = "printAttachmentIndicator")]
        public bool? PrintAttachmentIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "selfEmployedIndicator")]
        public bool? SelfEmployedIndicator { get; set; }

        [DataMember(Name = "startDate")]
        public string StartDate { get; set; }

        [DataMember(Name = "timeInLineOfWorkMonths")]
        public int? TimeInLineOfWorkMonths { get; set; }

        [DataMember(Name = "timeInLineOfWorkYears")]
        public int? TimeInLineOfWorkYears { get; set; }

        [DataMember(Name = "timeOnJobTermMonths")]
        public int? TimeOnJobTermMonths { get; set; }

        [DataMember(Name = "timeOnJobTermYears")]
        public int? TimeOnJobTermYears { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "titleFax")]
        public string TitleFax { get; set; }

        [DataMember(Name = "titlePhone")]
        public string TitlePhone { get; set; }

        [DataMember(Name = "unitNumber")]
        public string UnitNumber { get; set; }

        [DataMember(Name = "unitType")]
        public string UnitType { get; set; }

        [DataMember(Name = "urla2020StreetAddress")]
        public string Urla2020StreetAddress { get; set; }

        [DataMember(Name = "verificationRequestDate")]
        public string VerificationRequestDate { get; set; }

        [DataMember(Name = "individualEmployer")]
        public bool? IndividualEmployer { get; set; }

        [DataMember(Name = "militaryEmployer")]
        public bool? MilitaryEmployer { get; set; }

        [DataMember(Name = "militaryCombatPay")]
        public decimal? MilitaryCombatPay { get; set; }

        [DataMember(Name = "militaryFlightPay")]
        public decimal? MilitaryFlightPay { get; set; }

        [DataMember(Name = "militaryHazardPay")]
        public decimal? MilitaryHazardPay { get; set; }

        [DataMember(Name = "militaryOverseasPay")]
        public decimal? MilitaryOverseasPay { get; set; }

        [DataMember(Name = "militaryPropPay")]
        public decimal? MilitaryPropPay { get; set; }

        [DataMember(Name = "clothingAllowance")]
        public decimal? ClothingAllowance { get; set; }

        [DataMember(Name = "rationsAllowance")]
        public decimal? RationsAllowance { get; set; }

        [DataMember(Name = "variableHousingAllowance")]
        public decimal? VariableHousingAllowance { get; set; }

        [DataMember(Name = "quartersAllowance")]
        public decimal? QuartersAllowance { get; set; }

        [DataMember(Name = "otherAllowanceDescription")]
        public string OtherAllowanceDescription { get; set; }

        [DataMember(Name = "foreignIncome")]
        public bool? ForeignIncome { get; set; }

        [DataMember(Name = "seasonalIncome")]
        public bool? SeasonalIncome { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }
    }

    [DataContract]
    public class EmploymentContractFull : EmploymentContract
    {
        [DataMember(Name = "noLinkToDocTrackIndicator")]
        public bool? NoLinkToDocTrackIndicator { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }
    }
}
