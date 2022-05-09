using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ValuationContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "numberOfBedroomUnit3")]
        public int? NumberOfBedroomUnit3 { get; set; }

        [DataMember(Name = "numberOfBedroomUnit4")]
        public int? NumberOfBedroomUnit4 { get; set; }

        [DataMember(Name = "appraisalAddressCounty")]
        public string AppraisalAddressCounty { get; set; }

        [DataMember(Name = "appraisalApptDate")]
        public string AppraisalApptDate { get; set; }

        [DataMember(Name = "appraisalCountyName")]
        public string AppraisalCountyName { get; set; }

        [DataMember(Name = "appraisalFinalInspectionDate")]
        public string AppraisalFinalInspectionDate { get; set; }

        [DataMember(Name = "appraisalFinalInspectionFlag")]
        public bool? AppraisalFinalInspectionFlag { get; set; }

        [DataMember(Name = "appraisalFloodZone")]
        public string AppraisalFloodZone { get; set; }

        [DataMember(Name = "appraisalPropertyType")]
        public string AppraisalPropertyType { get; set; }

        [DataMember(Name = "appraisedCondition")]
        public string AppraisedCondition { get; set; }

        [DataMember(Name = "appraisedValue")]
        public int? AppraisedValue { get; set; }

        [DataMember(Name = "appraiserName")]
        public string AppraiserName { get; set; }

        [DataMember(Name = "appraiserSupervisorsName")]
        public string AppraiserSupervisorsName { get; set; }

        [DataMember(Name = "appraisersLicenseNumber")]
        public string AppraisersLicenseNumber { get; set; }

        [DataMember(Name = "appraisersStateLicenseNumber")]
        public string AppraisersStateLicenseNumber { get; set; }

        [DataMember(Name = "appraisersPropertyAddress1")]
        public string AppraisersPropertyAddress1 { get; set; }

        [DataMember(Name = "appraisersPropertyAddress2")]
        public string AppraisersPropertyAddress2 { get; set; }

        [DataMember(Name = "valuationMethod")]
        public string ValuationMethod { get; set; }

        [DataMember(Name = "avmAppraisedValue")]
        public decimal? AvmAppraisedValue { get; set; }

        [DataMember(Name = "avmConfidenceScore")]
        public string AvmConfidenceScore { get; set; }

        [DataMember(Name = "avmOrderNumber")]
        public string AvmOrderNumber { get; set; }

        [DataMember(Name = "avmOrderDate")]
        public string AvmOrderDate { get; set; }

        [DataMember(Name = "avmType")]
        public string AvmType { get; set; }

        [DataMember(Name = "buildingStatus")]
        public string BuildingStatus { get; set; }

        [DataMember(Name = "censusTrack")]
        public string CensusTrack { get; set; }

        [DataMember(Name = "dateOfSale")]
        public string DateOfSale { get; set; }

        [DataMember(Name = "energyEfficientIndicator")]
        public bool? EnergyEfficientIndicator { get; set; }

        [DataMember(Name = "estValueOfRepairs")]
        public decimal? EstValueOfRepairs { get; set; }

        [DataMember(Name = "finalInspectionReqIndicator")]
        public bool? FinalInspectionReqIndicator { get; set; }

        [DataMember(Name = "hoaBudgetedAssessmentIncome")]
        public decimal? HoaBudgetedAssessmentIncome { get; set; }

        [DataMember(Name = "hoaBudgetedReplacementReserves")]
        public decimal? HoaBudgetedReplacementReserves { get; set; }

        [DataMember(Name = "hoaLitigationStatus")]
        public string HoaLitigationStatus { get; set; }

        [DataMember(Name = "isSubjectPropertyImproved")]
        public bool? IsSubjectPropertyImproved { get; set; }

        [DataMember(Name = "appraisalLegalDescription1")]
        public string AppraisalLegalDescription1 { get; set; }

        [DataMember(Name = "appraisalLegalDescription2")]
        public string AppraisalLegalDescription2 { get; set; }

        [DataMember(Name = "livingArea")]
        public decimal? LivingArea { get; set; }

        [DataMember(Name = "monthlyRentAmountUnit3")]
        public decimal? MonthlyRentAmountUnit3 { get; set; }

        [DataMember(Name = "monthlyRentAmountUnit4")]
        public decimal? MonthlyRentAmountUnit4 { get; set; }

        [DataMember(Name = "nfipPaneldate")]
        public string NfipPaneldate { get; set; }

        [DataMember(Name = "nfipPanelNumber")]
        public string NfipPanelNumber { get; set; }

        [DataMember(Name = "numberofBedrooms")]
        public int? NumberofBedrooms { get; set; }

        [DataMember(Name = "numberofBedroomsUnit1")]
        public int? NumberofBedroomsUnit1 { get; set; }

        [DataMember(Name = "numberofBedroomsUnit2")]
        public int? NumberofBedroomsUnit2 { get; set; }

        [DataMember(Name = "numberOfUnits")]
        public int? NumberOfUnits { get; set; }

        [DataMember(Name = "panelNumber")]
        public string PanelNumber { get; set; }

        [DataMember(Name = "propertyAppraisalType")]
        public string PropertyAppraisalType { get; set; }

        [DataMember(Name = "propertyAttachmentType")]
        public string PropertyAttachmentType { get; set; }

        [DataMember(Name = "propertyUsageCode")]
        public string PropertyUsageCode { get; set; }

        [DataMember(Name = "propertyValue")]
        public decimal? PropertyValue { get; set; }

        [DataMember(Name = "purchaseContractSalesPrice")]
        public decimal? PurchaseContractSalesPrice { get; set; }

        [DataMember(Name = "rentAmountUnit1")]
        public decimal? RentAmountUnit1 { get; set; }

        [DataMember(Name = "rentAmountUnit2")]
        public decimal? RentAmountUnit2 { get; set; }

        [DataMember(Name = "siteValue")]
        public decimal? SiteValue { get; set; }

        [DataMember(Name = "standardDeviation")]
        public string StandardDeviation { get; set; }

        [DataMember(Name = "subjectPropertyState")]
        public string SubjectPropertyState { get; set; }

        [DataMember(Name = "statedGrossRent")]
        public decimal? StatedGrossRent { get; set; }

        [DataMember(Name = "statedPropertyCondition")]
        public string StatedPropertyCondition { get; set; }

        [DataMember(Name = "statedPropertyType")]
        public string StatedPropertyType { get; set; }

        [DataMember(Name = "subjectAddressCity")]
        public string SubjectAddressCity { get; set; }

        [DataMember(Name = "subjectPropertyUnitNumber")]
        public string SubjectPropertyUnitNumber { get; set; }

        [DataMember(Name = "supervisoryAppraisalLicenseNumber")]
        public string SupervisoryAppraisalLicenseNumber { get; set; }

        [DataMember(Name = "propertyAppraisalUnitNumber")]
        public string PropertyAppraisalUnitNumber { get; set; }

        [DataMember(Name = "appraisalUsage")]
        public string AppraisalUsage { get; set; }

        [DataMember(Name = "yearBuilt")]
        public string YearBuilt { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "zoningCompliance")]
        public string ZoningCompliance { get; set; }

        [DataMember(Name = "projectAttachmentType")]
        public string ProjectAttachmentType { get; set; }

        [DataMember(Name = "condoProjectStatusType")]
        public string CondoProjectStatusType { get; set; }

        [DataMember(Name = "orderType")]
        public string OrderType { get; set; }

    }
}
