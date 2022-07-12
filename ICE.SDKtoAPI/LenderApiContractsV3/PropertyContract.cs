using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class PropertyContract
    {
        [DataMember(Name = "addressLineText")]
        public string AddressLineText { get; set; }

        [DataMember(Name = "addressUnitDesignatorType")]
        public string AddressUnitDesignatorType { get; set; }

        [DataMember(Name = "addressUnitIdentifier")]
        public string AddressUnitIdentifier { get; set; }

        [DataMember(Name = "assessorsParcelIdentifier")]
        public string AssessorsParcelIdentifier { get; set; }

        [DataMember(Name = "blockIdentifier")]
        public string BlockIdentifier { get; set; }

        [DataMember(Name = "borrowerHomesteadIndicator")]
        public bool? BorrowerHomesteadIndicator { get; set; }

        [DataMember(Name = "buildingStatusType")]
        public string BuildingStatusType { get; set; }

        [DataMember(Name = "city")]
        public string City { get; set; }

        [DataMember(Name = "condotelIndicator")]
        public bool? CondotelIndicator { get; set; }

        [DataMember(Name = "constructionImprovementCostsAmount")]
        public decimal? ConstructionImprovementCostsAmount { get; set; }

        [DataMember(Name = "county")]
        public string County { get; set; }

        [DataMember(Name = "fhaSecondaryResidenceIndicator")]
        public bool? FhaSecondaryResidenceIndicator { get; set; }

        [DataMember(Name = "financedNumberOfUnits")]
        public int? FinancedNumberOfUnits { get; set; }

        [DataMember(Name = "floodCertificationIdentifier")]
        public string FloodCertificationIdentifier { get; set; }

        [DataMember(Name = "freCashOutAmount")]
        public decimal? FreCashOutAmount { get; set; }

        [DataMember(Name = "gseRefinancePurposeType")]
        public string GseRefinancePurposeType { get; set; }

        [DataMember(Name = "gseTitleMannerHeldDescription")]
        public string GseTitleMannerHeldDescription { get; set; }

        [DataMember(Name = "isConstructionPhaseDisclosedSeparately")]
        public bool? IsConstructionPhaseDisclosedSeparately { get; set; }

        [DataMember(Name = "landEstimatedValueAmount")]
        public decimal? LandEstimatedValueAmount { get; set; }

        [DataMember(Name = "legalDescriptionText1")]
        public string LegalDescriptionText1 { get; set; }

        [DataMember(Name = "legalDescriptionText2")]
        public string LegalDescriptionText2 { get; set; }

        [DataMember(Name = "linkedMortgageType")]
        public string LinkedMortgageType { get; set; }

        [DataMember(Name = "linkedLienPriorityType")]
        public string LinkedLienPriorityType { get; set; }

        [DataMember(Name = "linkedIsConstructionPhaseDisclosedSeparately")]
        public bool? LinkedIsConstructionPhaseDisclosedSeparately { get; set; }

        [DataMember(Name = "linkedLoanPurposeType")]
        public string LinkedLoanPurposeType { get; set; }

        [DataMember(Name = "linkedInitialAdvanceAmount")]
        public decimal? LinkedInitialAdvanceAmount { get; set; }

        [DataMember(Name = "linkedClosedEndPrimaryMortgageLoanAmount")]
        public decimal? LinkedClosedEndPrimaryMortgageLoanAmount { get; set; }

        [DataMember(Name = "linkedClosedEndSubordinateMortgageLoanAmount")]
        public decimal? LinkedClosedEndSubordinateMortgageLoanAmount { get; set; }

        [DataMember(Name = "linkedHelocNewFinancingNotLinkedDrawAmount")]
        public decimal? LinkedHelocNewFinancingNotLinkedDrawAmount { get; set; }

        [DataMember(Name = "linkedHelocNewFinancingNotLinkedCreditLimit")]
        public decimal? LinkedHelocNewFinancingNotLinkedCreditLimit { get; set; }

        [DataMember(Name = "linkedAmountApplyToDownPayment")]
        public decimal? LinkedAmountApplyToDownPayment { get; set; }

        [DataMember(Name = "linkedHelocLienPosition")]
        public string LinkedHelocLienPosition { get; set; }

        [DataMember(Name = "linkedLoanNumber")]
        public string LinkedLoanNumber { get; set; }

        [DataMember(Name = "loanPurposeType")]
        public string LoanPurposeType { get; set; }

        [DataMember(Name = "loanPurposeTypeOtherDescription")]
        public string LoanPurposeTypeOtherDescription { get; set; }

        [DataMember(Name = "loanPurposeTypeUrla")]
        public string LoanPurposeTypeUrla { get; set; }

        [DataMember(Name = "lotAcres")]
        public decimal? LotAcres { get; set; }

        [DataMember(Name = "lotIdentifier")]
        public string LotIdentifier { get; set; }

        [DataMember(Name = "nameRecordingJurisdiction")]
        public string NameRecordingJurisdiction { get; set; }

        [DataMember(Name = "nonwarrantableProjectIndicator")]
        public bool? NonwarrantableProjectIndicator { get; set; }

        [DataMember(Name = "numberOfStories")]
        public decimal? NumberOfStories { get; set; }

        [DataMember(Name = "occupancyDisplayField")]
        public string OccupancyDisplayField { get; set; }

        [DataMember(Name = "oneTimeClose")]
        public bool? OneTimeClose { get; set; }

        [DataMember(Name = "otherLoanPurposeDescription")]
        public string OtherLoanPurposeDescription { get; set; }

        [DataMember(Name = "postalCode")]
        public string PostalCode { get; set; }

        [DataMember(Name = "priorLoanRecordationBookNumber")]
        public string PriorLoanRecordationBookNumber { get; set; }

        [DataMember(Name = "priorLoanRecordationCurrentPrincipalAmount")]
        public decimal? PriorLoanRecordationCurrentPrincipalAmount { get; set; }

        [DataMember(Name = "priorLoanRecordationOriginalLoanNumber")]
        public string PriorLoanRecordationOriginalLoanNumber { get; set; }

        [DataMember(Name = "priorLoanRecordationDated")]
        public string PriorLoanRecordationDated { get; set; }

        [DataMember(Name = "priorLoanRecordationOriginalPrincipalAmount")]
        public decimal? PriorLoanRecordationOriginalPrincipalAmount { get; set; }

        [DataMember(Name = "priorLoanRecordationPageNumber")]
        public string PriorLoanRecordationPageNumber { get; set; }

        [DataMember(Name = "prodIsSpInUnderservedArea")]
        public bool? ProdIsSpInUnderservedArea { get; set; }

        [DataMember(Name = "propertyAcquiredYear")]
        public string PropertyAcquiredYear { get; set; }

        [DataMember(Name = "propertyExistingLienAmount")]
        public decimal? PropertyExistingLienAmount { get; set; }

        [DataMember(Name = "propertyLeaseholdExpirationDate")]
        public string PropertyLeaseholdExpirationDate { get; set; }

        [DataMember(Name = "propertyMixedUsageIndicator")]
        public bool? PropertyMixedUsageIndicator { get; set; }

        [DataMember(Name = "propertyOriginalCostAmount")]
        public decimal? PropertyOriginalCostAmount { get; set; }

        [DataMember(Name = "propertyRightsType")]
        public string PropertyRightsType { get; set; }

        [DataMember(Name = "propertyUsageType")]
        public string PropertyUsageType { get; set; }

        [DataMember(Name = "refinanceImprovementCostsAmount")]
        public decimal? RefinanceImprovementCostsAmount { get; set; }

        [DataMember(Name = "refinanceImprovementsType")]
        public string RefinanceImprovementsType { get; set; }

        [DataMember(Name = "refinancePropertyAcquiredYear")]
        public string RefinancePropertyAcquiredYear { get; set; }

        [DataMember(Name = "refinancePropertyExistingLienAmount")]
        public decimal? RefinancePropertyExistingLienAmount { get; set; }

        [DataMember(Name = "refinancePropertyOriginalCostAmount")]
        public decimal? RefinancePropertyOriginalCostAmount { get; set; }

        [DataMember(Name = "refinanceProposedImprovementsDescription")]
        public string RefinanceProposedImprovementsDescription { get; set; }

        [DataMember(Name = "ruralAreaIndicator")]
        public bool? RuralAreaIndicator { get; set; }

        [DataMember(Name = "sectionIdentifier")]
        public string SectionIdentifier { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }

        [DataMember(Name = "streetAddress")]
        public string StreetAddress { get; set; }

        [DataMember(Name = "streetAddress2")]
        public string StreetAddress2 { get; set; }

        [DataMember(Name = "structureBuiltYear")]
        public string StructureBuiltYear { get; set; }

        [DataMember(Name = "texasContinuousMoneyLoanIndicator")]
        public bool? TexasContinuousMoneyLoanIndicator { get; set; }

        [DataMember(Name = "totalConstructionValueAmount")]
        public decimal? TotalConstructionValueAmount { get; set; }

        [DataMember(Name = "twoTimeClose")]
        public bool? TwoTimeClose { get; set; }

        [DataMember(Name = "typeRecordingJurisdiction")]
        public string TypeRecordingJurisdiction { get; set; }

        [DataMember(Name = "unincorporatedAreaName")]
        public string UnincorporatedAreaName { get; set; }

        [DataMember(Name = "linkedBaseLoanAmount")]
        public decimal? LinkedBaseLoanAmount { get; set; }

        [DataMember(Name = "linkedProposedOtherMortgagesAmount")]
        public decimal? LinkedProposedOtherMortgagesAmount { get; set; }

        [DataMember(Name = "linkedProposedOtherAmount")]
        public decimal? LinkedProposedOtherAmount { get; set; }

        [DataMember(Name = "linkedProposedFirstMortgageAmount")]
        public decimal? LinkedProposedFirstMortgageAmount { get; set; }

        [DataMember(Name = "linkedMax5YrsPrincipleAndInterest")]
        public decimal? LinkedMax5YrsPrincipleAndInterest { get; set; }

        [DataMember(Name = "linkedLenderName")]
        public string LinkedLenderName { get; set; }

        [DataMember(Name = "linkedAffordableLoan")]
        public bool? LinkedAffordableLoan { get; set; }

        [DataMember(Name = "linkedRequestedInterestRatePercent")]
        public decimal? LinkedRequestedInterestRatePercent { get; set; }

        [DataMember(Name = "Square")]
        public string Square { get; set; }
    }
}
