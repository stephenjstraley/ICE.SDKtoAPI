using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ReoPropertyContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "acquiredDate")]
        public string AcquiredDate { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; set; }

        [DataMember(Name = "dispositionStatusType")]
        public string DispositionStatusType { get; set; }

        [DataMember(Name = "gsePropertyType")]
        public string GsePropertyType { get; set; }

        [DataMember(Name = "yearBuilt")]
        public string YearBuilt { get; set; }

        [DataMember(Name = "liabilityDoesNotApply")]
        public bool? LiabilityDoesNotApply { get; set; }

        [DataMember(Name = "includeInAusExport")]
        public bool? IncludeInAusExport { get; set; }

        [DataMember(Name = "lienInstallmentAmount")]
        public decimal? LienInstallmentAmount { get; set; }

        [DataMember(Name = "lienUpbAmount")]
        public decimal? LienUpbAmount { get; set; }

        [DataMember(Name = "maintenanceExpenseAmount")]
        public string MaintenanceExpenseAmount { get; set; }

        [DataMember(Name = "marketValueAmount")]
        public decimal? MarketValueAmount { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "participationPercentage")]
        public decimal? ParticipationPercentage { get; set; }

        [DataMember(Name = "percentageofRental")]
        public decimal? PercentageofRental { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "printAttachIndicator")]
        public bool? PrintAttachIndicator { get; set; }

        [DataMember(Name = "printUserJobTitleIndicator")]
        public bool? PrintUserJobTitleIndicator { get; set; }

        [DataMember(Name = "printUserNameIndicator")]
        public bool? PrintUserNameIndicator { get; set; }

        [DataMember(Name = "propertyUsageType")]
        public string PropertyUsageType { get; set; }

        [DataMember(Name = "purchasePrice")]
        public int? PurchasePrice { get; set; }

        [DataMember(Name = "rentalIncomeGrossAmount")]
        public decimal? RentalIncomeGrossAmount { get; set; }

        [DataMember(Name = "rentalIncomeNetAmount")]
        public decimal? RentalIncomeNetAmount { get; set; }

        [DataMember(Name = "reoComments")]
        public string ReoComments { get; set; }

        [DataMember(Name = "requestDate")]
        public string RequestDate { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        [DataMember(Name = "subjectIndicator")]
        public bool? SubjectIndicator { get; set; }

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

        [DataMember(Name = "numberOfUnits")]
        public int? NumberOfUnits { get; set; }

        [DataMember(Name = "futurePropertyUsageType")]
        public string FuturePropertyUsageType { get; set; }

        [DataMember(Name = "futureUsageTypeOtherDesc")]
        public string FutureUsageTypeOtherDesc { get; set; }

        [DataMember(Name = "foreignAddressIndicator")]
        public bool? ForeignAddressIndicator { get; set; }

        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "pendingSaleDate")]
        public string PendingSaleDate { get; set; }
    }

    [DataContract]
    public class ReoPropertyContractFull : ReoPropertyContract
    {
        [DataMember(Name = "altId")]
        public string AltId { get; set; }

        [DataMember(Name = "noLinkToDocTrackIndicator")]
        public bool? NoLinkToDocTrackIndicator { get; set; }
    }
}
