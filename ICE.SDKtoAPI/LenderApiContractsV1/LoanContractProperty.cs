using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractProperty
	{
		[DataMember(Name="assessorsParcelIdentifier", EmitDefaultValue=false)]
		public string AssessorsParcelIdentifier { get; set; }

		[DataMember(Name="blockIdentifier", EmitDefaultValue=false)]
		public string BlockIdentifier { get; set; }

		[DataMember(Name="borrowerHomesteadIndicator", EmitDefaultValue=false)]
		public bool? BorrowerHomesteadIndicator { get; set; }

		[DataMember(Name="buildingStatusType", EmitDefaultValue=false)]
		public string BuildingStatusType { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="condotelIndicator", EmitDefaultValue=false)]
		public bool? CondotelIndicator { get; set; }

		[DataMember(Name="constructionImprovementCostsAmount", EmitDefaultValue=false)]
		public double? ConstructionImprovementCostsAmount { get; set; }

		[DataMember(Name="county", EmitDefaultValue=false)]
		public string County { get; set; }

		[DataMember(Name="financedNumberOfUnits", EmitDefaultValue=false)]
		public int? FinancedNumberOfUnits { get; set; }

		[DataMember(Name="floodCertificationIdentifier", EmitDefaultValue=false)]
		public string FloodCertificationIdentifier { get; set; }

		[DataMember(Name="freCashOutAmount", EmitDefaultValue=false)]
		public double? FreCashOutAmount { get; set; }

		[DataMember(Name="gseRefinancePurposeType", EmitDefaultValue=false)]
		public string GseRefinancePurposeType { get; set; }

		[DataMember(Name="gseTitleMannerHeldDescription", EmitDefaultValue=false)]
		public string GseTitleMannerHeldDescription { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isConstructionPhaseDisclosedSeparately", EmitDefaultValue=false)]
		public bool? IsConstructionPhaseDisclosedSeparately { get; set; }

		[DataMember(Name="landEstimatedValueAmount", EmitDefaultValue=false)]
		public double? LandEstimatedValueAmount { get; set; }

		[DataMember(Name="legalDescriptionText1", EmitDefaultValue=false)]
		public string LegalDescriptionText1 { get; set; }

		[DataMember(Name="legalDescriptionText2", EmitDefaultValue=false)]
		public string LegalDescriptionText2 { get; set; }

		[DataMember(Name="linkedAmountApplyToDownPayment", EmitDefaultValue=false)]
		public double? LinkedAmountApplyToDownPayment { get; set; }

		[DataMember(Name="linkedClosedEndPrimaryMortgageLoanAmount", EmitDefaultValue=false)]
		public double? LinkedClosedEndPrimaryMortgageLoanAmount { get; set; }

		[DataMember(Name="linkedClosedEndSubordinateMortgageLoanAmount", EmitDefaultValue=false)]
		public double? LinkedClosedEndSubordinateMortgageLoanAmount { get; set; }

		[DataMember(Name="linkedHelocNewFinancingNotLinkedCreditLimit", EmitDefaultValue=false)]
		public double? LinkedHelocNewFinancingNotLinkedCreditLimit { get; set; }

		[DataMember(Name="linkedHelocNewFinancingNotLinkedDrawAmount", EmitDefaultValue=false)]
		public double? LinkedHelocNewFinancingNotLinkedDrawAmount { get; set; }

		[DataMember(Name="linkedInitialAdvanceAmount", EmitDefaultValue=false)]
		public double? LinkedInitialAdvanceAmount { get; set; }

		[DataMember(Name="linkedIsConstructionPhaseDisclosedSeparately", EmitDefaultValue=false)]
		public bool? LinkedIsConstructionPhaseDisclosedSeparately { get; set; }

		[DataMember(Name="linkedLienPriorityType", EmitDefaultValue=false)]
		public string LinkedLienPriorityType { get; set; }

		[DataMember(Name="linkedLoanPurposeType", EmitDefaultValue=false)]
		public string LinkedLoanPurposeType { get; set; }

		[DataMember(Name="linkedMortgageType", EmitDefaultValue=false)]
		public string LinkedMortgageType { get; set; }

		[DataMember(Name="loanPurposeType", EmitDefaultValue=false)]
		public string LoanPurposeType { get; set; }

		[DataMember(Name="lotAcres", EmitDefaultValue=false)]
		public double? LotAcres { get; set; }

		[DataMember(Name="lotIdentifier", EmitDefaultValue=false)]
		public string LotIdentifier { get; set; }

		[DataMember(Name="nameRecordingJurisdiction", EmitDefaultValue=false)]
		public string NameRecordingJurisdiction { get; set; }

		[DataMember(Name="nonwarrantableProjectIndicator", EmitDefaultValue=false)]
		public bool? NonwarrantableProjectIndicator { get; set; }

		[DataMember(Name="numberOfStories", EmitDefaultValue=false)]
		public double? NumberOfStories { get; set; }

		[DataMember(Name="otherLoanPurposeDescription", EmitDefaultValue=false)]
		public string OtherLoanPurposeDescription { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="priorLoanRecordationBookNumber", EmitDefaultValue=false)]
		public string PriorLoanRecordationBookNumber { get; set; }

		[DataMember(Name="priorLoanRecordationCurrentPrincipalAmount", EmitDefaultValue=false)]
		public double? PriorLoanRecordationCurrentPrincipalAmount { get; set; }

		[DataMember(Name="priorLoanRecordationDated", EmitDefaultValue=false)]
		public DateTime? PriorLoanRecordationDated { get; set; }

		[DataMember(Name="priorLoanRecordationOriginalLoanNumber", EmitDefaultValue=false)]
		public string PriorLoanRecordationOriginalLoanNumber { get; set; }

		[DataMember(Name="priorLoanRecordationOriginalPrincipalAmount", EmitDefaultValue=false)]
		public double? PriorLoanRecordationOriginalPrincipalAmount { get; set; }

		[DataMember(Name="priorLoanRecordationPageNumber", EmitDefaultValue=false)]
		public string PriorLoanRecordationPageNumber { get; set; }

		[DataMember(Name="prodIsSpInUnderservedArea", EmitDefaultValue=false)]
		public bool? ProdIsSpInUnderservedArea { get; set; }

		[DataMember(Name="propertyAcquiredYear", EmitDefaultValue=false)]
		public string PropertyAcquiredYear { get; set; }

		[DataMember(Name="propertyExistingLienAmount", EmitDefaultValue=false)]
		public double? PropertyExistingLienAmount { get; set; }

		[DataMember(Name="propertyLeaseholdExpirationDate", EmitDefaultValue=false)]
		public DateTime? PropertyLeaseholdExpirationDate { get; set; }

		[DataMember(Name="propertyOriginalCostAmount", EmitDefaultValue=false)]
		public double? PropertyOriginalCostAmount { get; set; }

		[DataMember(Name="propertyRightsType", EmitDefaultValue=false)]
		public string PropertyRightsType { get; set; }

		[DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="refinanceImprovementCostsAmount", EmitDefaultValue=false)]
		public double? RefinanceImprovementCostsAmount { get; set; }

		[DataMember(Name="refinanceImprovementsType", EmitDefaultValue=false)]
		public string RefinanceImprovementsType { get; set; }

		[DataMember(Name="refinancePropertyAcquiredYear", EmitDefaultValue=false)]
		public string RefinancePropertyAcquiredYear { get; set; }

		[DataMember(Name="refinancePropertyExistingLienAmount", EmitDefaultValue=false)]
		public double? RefinancePropertyExistingLienAmount { get; set; }

		[DataMember(Name="refinancePropertyOriginalCostAmount", EmitDefaultValue=false)]
		public double? RefinancePropertyOriginalCostAmount { get; set; }

		[DataMember(Name="refinanceProposedImprovementsDescription", EmitDefaultValue=false)]
		public string RefinanceProposedImprovementsDescription { get; set; }

		[DataMember(Name="ruralAreaIndicator", EmitDefaultValue=false)]
		public bool? RuralAreaIndicator { get; set; }

		[DataMember(Name="sectionIdentifier", EmitDefaultValue=false)]
		public string SectionIdentifier { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="streetAddress", EmitDefaultValue=false)]
		public string StreetAddress { get; set; }

		[DataMember(Name="streetAddress2", EmitDefaultValue=false)]
		public string StreetAddress2 { get; set; }

		[DataMember(Name="structureBuiltYear", EmitDefaultValue=false)]
		public string StructureBuiltYear { get; set; }

		[DataMember(Name="texasContinuousMoneyLoanIndicator", EmitDefaultValue=false)]
		public bool? TexasContinuousMoneyLoanIndicator { get; set; }

		[DataMember(Name="totalConstructionValueAmount", EmitDefaultValue=false)]
		public double? TotalConstructionValueAmount { get; set; }

		[DataMember(Name="typeRecordingJurisdiction", EmitDefaultValue=false)]
		public string TypeRecordingJurisdiction { get; set; }

		[DataMember(Name="unincorporatedAreaName", EmitDefaultValue=false)]
		public string UnincorporatedAreaName { get; set; }

		[DataMember(Name = "occupancyDisplayField", EmitDefaultValue = false)]
		public string OccupancyDisplayField { get; set; }

		[DataMember(Name = "Square")]
		public string Square { get; set; }

		[DataMember(Name = "loanPurposeTypeURLA")]
		public string LoanPurposeTypeURLA { get; set; }

		[DataMember(Name = "addressLineText")]
		public string AddressLineText { get; set; }

		[DataMember(Name = "fHASecondaryResidenceIndicator")]
		public bool? FHASecondaryResidenceIndicator { get; set; } = false;

		[DataMember(Name = "propertyMixedUsageIndicator")]
		public bool? PropertyMixedUsageIndicator { get; set; } = false;
	}
}