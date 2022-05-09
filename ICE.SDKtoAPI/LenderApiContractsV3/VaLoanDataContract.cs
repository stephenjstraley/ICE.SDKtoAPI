using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class VaLoanDataContract
    {
        [DataMember(Name = "acres")]
        public decimal? Acres { get; set; }

        [DataMember(Name = "administratorAddress")]
        public string AdministratorAddress { get; set; }

        [DataMember(Name = "administratorCity")]
        public string AdministratorCity { get; set; }

        [DataMember(Name = "administratorContact")]
        public string AdministratorContact { get; set; }

        [DataMember(Name = "administratorName")]
        public string AdministratorName { get; set; }

        [DataMember(Name = "administratorPostalCode")]
        public string AdministratorPostalCode { get; set; }

        [DataMember(Name = "administratorState")]
        public string AdministratorState { get; set; }

        [DataMember(Name = "ageOfProperty")]
        public int? AgeOfProperty { get; set; }

        [DataMember(Name = "amountSpentOnEnergyImprovements")]
        public decimal? AmountSpentOnEnergyImprovements { get; set; }

        [DataMember(Name = "annualGroundRent")]
        public decimal? AnnualGroundRent { get; set; }

        [DataMember(Name = "annualMaintenanceAssessment")]
        public decimal? AnnualMaintenanceAssessment { get; set; }

        [DataMember(Name = "annualRealEstateTaxes")]
        public decimal? AnnualRealEstateTaxes { get; set; }

        [DataMember(Name = "appraisalType")]
        public string AppraisalType { get; set; }

        [DataMember(Name = "availableForInspectionAmIndicator")]
        public bool? AvailableForInspectionAmIndicator { get; set; }

        [DataMember(Name = "availableForInspectionDateAndTime")]
        public string AvailableForInspectionDateAndTime { get; set; }

        [DataMember(Name = "borrowerPaidDiscountPointsTotalAmount")]
        public decimal? BorrowerPaidDiscountPointsTotalAmount { get; set; }

        [DataMember(Name = "buildingType")]
        public string BuildingType { get; set; }

        [DataMember(Name = "buyerPurchasingLotSeparately")]
        public bool? BuyerPurchasingLotSeparately { get; set; }

        [DataMember(Name = "cashPaymentFromVeteran")]
        public decimal? CashPaymentFromVeteran { get; set; }

        [DataMember(Name = "claimDisabilityBenefits")]
        public string ClaimDisabilityBenefits { get; set; }

        [DataMember(Name = "clothesWasherIndicator")]
        public bool? ClothesWasherIndicator { get; set; }

        [DataMember(Name = "constructionCompletedDate")]
        public string ConstructionCompletedDate { get; set; }

        [DataMember(Name = "constructionPlan")]
        public string ConstructionPlan { get; set; }

        [DataMember(Name = "constructionWarrantyIncluded")]
        public bool? ConstructionWarrantyIncluded { get; set; }

        [DataMember(Name = "contractNoApprovedBy")]
        public string ContractNoApprovedBy { get; set; }

        [DataMember(Name = "creditScore")]
        public int? CreditScore { get; set; }

        [DataMember(Name = "currentlyOnMilitaryDuty")]
        public bool? CurrentlyOnMilitaryDuty { get; set; }

        [DataMember(Name = "assignmentDate")]
        public string AssignmentDate { get; set; }

        [DataMember(Name = "sarDate")]
        public string SarDate { get; set; }

        [DataMember(Name = "discountPercentage")]
        public decimal? DiscountPercentage { get; set; }

        [DataMember(Name = "discountPoint")]
        public decimal? DiscountPoint { get; set; }

        [DataMember(Name = "dishwasherIndicator")]
        public bool? DishwasherIndicator { get; set; }

        [DataMember(Name = "dryerIndicator")]
        public bool? DryerIndicator { get; set; }

        [DataMember(Name = "emailToBeNotifiedWhenUploaded")]
        public string EmailToBeNotifiedWhenUploaded { get; set; }

        [DataMember(Name = "energyImprovementsAdditionOfFeature")]
        public bool? EnergyImprovementsAdditionOfFeature { get; set; }

        [DataMember(Name = "entitlementCode")]
        public string EntitlementCode { get; set; }

        [DataMember(Name = "equipmentOtherDescription")]
        public string EquipmentOtherDescription { get; set; }

        [DataMember(Name = "finalDiscountAmount")]
        public decimal? FinalDiscountAmount { get; set; }

        [DataMember(Name = "finalFundingFeeAmount")]
        public decimal? FinalFundingFeeAmount { get; set; }

        [DataMember(Name = "firstTimeUse")]
        public bool? FirstTimeUse { get; set; }

        [DataMember(Name = "fundingFeeExempt")]
        public bool? FundingFeeExempt { get; set; }

        [DataMember(Name = "garbageDisposalIndicator")]
        public bool? GarbageDisposalIndicator { get; set; }

        [DataMember(Name = "initialTotal")]
        public decimal? InitialTotal { get; set; }

        [DataMember(Name = "inspectionWillBeMadeBy")]
        public string InspectionWillBeMadeBy { get; set; }

        [DataMember(Name = "insulation")]
        public bool? Insulation { get; set; }

        [DataMember(Name = "insuranceType")]
        public string InsuranceType { get; set; }

        [DataMember(Name = "irregularLotSizeInSquareFeet")]
        public int? IrregularLotSizeInSquareFeet { get; set; }

        [DataMember(Name = "isDelinquent30Days")]
        public bool? IsDelinquent30Days { get; set; }

        [DataMember(Name = "keysAtAddress")]
        public string KeysAtAddress { get; set; }

        [DataMember(Name = "leaseholdType")]
        public string LeaseholdType { get; set; }

        [DataMember(Name = "lenderSar")]
        public string LenderSar { get; set; }

        [DataMember(Name = "loanAnalysisRemarks1")]
        public string LoanAnalysisRemarks1 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks2")]
        public string LoanAnalysisRemarks2 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks3")]
        public string LoanAnalysisRemarks3 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks4")]
        public string LoanAnalysisRemarks4 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks5")]
        public string LoanAnalysisRemarks5 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks6")]
        public string LoanAnalysisRemarks6 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks7")]
        public string LoanAnalysisRemarks7 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks8")]
        public string LoanAnalysisRemarks8 { get; set; }

        [DataMember(Name = "loanAnalysisRemarks9")]
        public string LoanAnalysisRemarks9 { get; set; }

        [DataMember(Name = "loanCode")]
        public string LoanCode { get; set; }

        [DataMember(Name = "loanProcedure")]
        public string LoanProcedure { get; set; }

        [DataMember(Name = "loanProcessedUnderAu")]
        public bool? LoanProcessedUnderAu { get; set; }

        [DataMember(Name = "loanSummaryRemarks1")]
        public string LoanSummaryRemarks1 { get; set; }

        [DataMember(Name = "loanSummaryRemarks2")]
        public string LoanSummaryRemarks2 { get; set; }

        [DataMember(Name = "loanSummaryRemarks3")]
        public string LoanSummaryRemarks3 { get; set; }

        [DataMember(Name = "loanSummaryRemarks4")]
        public string LoanSummaryRemarks4 { get; set; }

        [DataMember(Name = "loanSummaryRemarks5")]
        public string LoanSummaryRemarks5 { get; set; }

        [DataMember(Name = "loanSummaryRemarks6")]
        public string LoanSummaryRemarks6 { get; set; }

        [DataMember(Name = "loanSummaryRemarks7")]
        public string LoanSummaryRemarks7 { get; set; }

        [DataMember(Name = "loanSummaryRemarks8")]
        public string LoanSummaryRemarks8 { get; set; }

        [DataMember(Name = "lotDimensions")]
        public string LotDimensions { get; set; }

        [DataMember(Name = "mailingAddress")]
        public string MailingAddress { get; set; }

        [DataMember(Name = "mailingCity")]
        public string MailingCity { get; set; }

        [DataMember(Name = "mailingPostalCode")]
        public string MailingPostalCode { get; set; }

        [DataMember(Name = "mailingState")]
        public string MailingState { get; set; }

        [DataMember(Name = "manufacturedHome")]
        public string ManufacturedHome { get; set; }

        [DataMember(Name = "mcrvNumber")]
        public string McrvNumber { get; set; }

        [DataMember(Name = "militaryBranchOfService")]
        public string MilitaryBranchOfService { get; set; }

        [DataMember(Name = "militaryServices")]
        public List<MilitaryServiceContract> MilitaryServices { get; set; }

        [DataMember(Name = "mineralRightsReserved")]
        public string MineralRightsReserved { get; set; }

        [DataMember(Name = "nameOfOccupant")]
        public string NameOfOccupant { get; set; }

        [DataMember(Name = "nameOfOwner")]
        public string NameOfOwner { get; set; }

        [DataMember(Name = "nameOfWarrantyProgram")]
        public string NameOfWarrantyProgram { get; set; }

        [DataMember(Name = "negativeRents")]
        public decimal? NegativeRents { get; set; }

        [DataMember(Name = "noEnergyImprovements")]
        public bool? NoEnergyImprovements { get; set; }

        [DataMember(Name = "numberOfBuildings")]
        public string NumberOfBuildings { get; set; }

        [DataMember(Name = "occupantTelephone")]
        public string OccupantTelephone { get; set; }

        [DataMember(Name = "onMilitaryDutyFollowingSeparation")]
        public bool? OnMilitaryDutyFollowingSeparation { get; set; }

        [DataMember(Name = "originalInterestRate")]
        public decimal? OriginalInterestRate { get; set; }

        [DataMember(Name = "originalLoanAmount")]
        public decimal? OriginalLoanAmount { get; set; }

        [DataMember(Name = "originalTerm")]
        public int? OriginalTerm { get; set; }

        [DataMember(Name = "originalValueEstimateChanged")]
        public bool? OriginalValueEstimateChanged { get; set; }

        [DataMember(Name = "originationFeeAmount")]
        public decimal? OriginationFeeAmount { get; set; }

        [DataMember(Name = "otherClosingCosts")]
        public decimal? OtherClosingCosts { get; set; }

        [DataMember(Name = "otherImprovements")]
        public bool? OtherImprovements { get; set; }

        [DataMember(Name = "paidInFullVaLoanNumber")]
        public string PaidInFullVaLoanNumber { get; set; }

        [DataMember(Name = "payoffIndicator1")]
        public bool? PayoffIndicator1 { get; set; }

        [DataMember(Name = "payoffIndicator2")]
        public bool? PayoffIndicator2 { get; set; }

        [DataMember(Name = "payoffIndicator3")]
        public bool? PayoffIndicator3 { get; set; }

        [DataMember(Name = "payoffIndicator4")]
        public bool? PayoffIndicator4 { get; set; }

        [DataMember(Name = "payoffIndicator5")]
        public bool? PayoffIndicator5 { get; set; }

        [DataMember(Name = "payoffIndicator6")]
        public bool? PayoffIndicator6 { get; set; }

        [DataMember(Name = "payoffIndicator7")]
        public bool? PayoffIndicator7 { get; set; }

        [DataMember(Name = "payoffIndicator8")]
        public bool? PayoffIndicator8 { get; set; }

        [DataMember(Name = "payoffIndicator9")]
        public bool? PayoffIndicator9 { get; set; }

        [DataMember(Name = "plansSubmitted")]
        public string PlansSubmitted { get; set; }

        [DataMember(Name = "pocAddress")]
        public string PocAddress { get; set; }

        [DataMember(Name = "pocCity")]
        public string PocCity { get; set; }

        [DataMember(Name = "pocName")]
        public string PocName { get; set; }

        [DataMember(Name = "pocPhone")]
        public string PocPhone { get; set; }

        [DataMember(Name = "pocState")]
        public string PocState { get; set; }

        [DataMember(Name = "pocZipCode")]
        public string PocZipCode { get; set; }

        [DataMember(Name = "preliminaryDiscountAmount")]
        public decimal? PreliminaryDiscountAmount { get; set; }

        [DataMember(Name = "preliminaryFundingFeeAmount")]
        public decimal? PreliminaryFundingFeeAmount { get; set; }

        [DataMember(Name = "preliminaryTotal")]
        public decimal? PreliminaryTotal { get; set; }

        [DataMember(Name = "previousVaLoanIndicator")]
        public bool? PreviousVaLoanIndicator { get; set; }

        [DataMember(Name = "purpleHeartRecipientIndicator")]
        public bool? PurpleHeartRecipientIndicator { get; set; }

        [DataMember(Name = "previousVaLoans")]
        public List<PreviousVaLoanContract> PreviousVaLoans { get; set; }

        [DataMember(Name = "priorLoanType")]
        public string PriorLoanType { get; set; }

        [DataMember(Name = "propertyDesignation")]
        public string PropertyDesignation { get; set; }

        [DataMember(Name = "propertyGrossLivingArea")]
        public int? PropertyGrossLivingArea { get; set; }

        [DataMember(Name = "propertyLegalDescription1")]
        public string PropertyLegalDescription1 { get; set; }

        [DataMember(Name = "propertyLegalDescription2")]
        public string PropertyLegalDescription2 { get; set; }

        [DataMember(Name = "propertyLegalDescription3")]
        public string PropertyLegalDescription3 { get; set; }

        [DataMember(Name = "propertyLegalDescription4")]
        public string PropertyLegalDescription4 { get; set; }

        [DataMember(Name = "propertyOccupancyType")]
        public string PropertyOccupancyType { get; set; }

        [DataMember(Name = "proposedSaleContractAttached")]
        public bool? ProposedSaleContractAttached { get; set; }

        [DataMember(Name = "purposeOfLoan")]
        public string PurposeOfLoan { get; set; }

        [DataMember(Name = "rangeOvenIndicator")]
        public bool? RangeOvenIndicator { get; set; }

        [DataMember(Name = "refrigeratorIndicator")]
        public bool? RefrigeratorIndicator { get; set; }

        [DataMember(Name = "rent")]
        public string Rent { get; set; }

        [DataMember(Name = "replacementOfSystem")]
        public bool? ReplacementOfSystem { get; set; }

        [DataMember(Name = "riskClassification")]
        public string RiskClassification { get; set; }

        [DataMember(Name = "serviceNumber")]
        public string ServiceNumber { get; set; }

        [DataMember(Name = "solarHeatingOrCooling")]
        public bool? SolarHeatingOrCooling { get; set; }

        [DataMember(Name = "specialAssessmentComments1")]
        public string SpecialAssessmentComments1 { get; set; }

        [DataMember(Name = "specialAssessmentComments2")]
        public string SpecialAssessmentComments2 { get; set; }

        [DataMember(Name = "specialAssessmentComments3")]
        public string SpecialAssessmentComments3 { get; set; }

        [DataMember(Name = "streetAccess")]
        public string StreetAccess { get; set; }

        [DataMember(Name = "streetMaintenance")]
        public string StreetMaintenance { get; set; }

        [DataMember(Name = "systemUsed")]
        public string SystemUsed { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "titleLimitations1")]
        public string TitleLimitations1 { get; set; }

        [DataMember(Name = "titleLimitations2")]
        public string TitleLimitations2 { get; set; }

        [DataMember(Name = "titleLimitations3")]
        public string TitleLimitations3 { get; set; }

        [DataMember(Name = "totalBaths")]
        public decimal? TotalBaths { get; set; }

        [DataMember(Name = "totalBedrooms")]
        public int? TotalBedrooms { get; set; }

        [DataMember(Name = "totalDebtMonthlyPayment")]
        public decimal? TotalDebtMonthlyPayment { get; set; }

        [DataMember(Name = "totalDiscountPointCharged")]
        public decimal? TotalDiscountPointCharged { get; set; }

        [DataMember(Name = "totalDiscountPointsCharged")]
        public decimal? TotalDiscountPointsCharged { get; set; }

        [DataMember(Name = "totalForMaxLoanAmount")]
        public decimal? TotalForMaxLoanAmount { get; set; }

        [DataMember(Name = "totalRooms")]
        public int? TotalRooms { get; set; }

        [DataMember(Name = "typeOfHybridArm")]
        public string TypeOfHybridArm { get; set; }

        [DataMember(Name = "typeOfMortgage")]
        public string TypeOfMortgage { get; set; }

        [DataMember(Name = "typeOfOwnership")]
        public string TypeOfOwnership { get; set; }

        [DataMember(Name = "typeOfStructure")]
        public string TypeOfStructure { get; set; }

        [DataMember(Name = "typeOfVeteran")]
        public string TypeOfVeteran { get; set; }

        [DataMember(Name = "utilitiesElectricDescription")]
        public string UtilitiesElectricDescription { get; set; }

        [DataMember(Name = "utilitiesGasDescription")]
        public string UtilitiesGasDescription { get; set; }

        [DataMember(Name = "utilitiesSewerDescription")]
        public string UtilitiesSewerDescription { get; set; }

        [DataMember(Name = "utilitiesWaterDescription")]
        public string UtilitiesWaterDescription { get; set; }

        [DataMember(Name = "vaBenefitRelatedIndebtedness")]
        public string VaBenefitRelatedIndebtedness { get; set; }

        [DataMember(Name = "vaBuilderIdNo")]
        public string VaBuilderIdNo { get; set; }

        [DataMember(Name = "vaClaimFolderNumber")]
        public string VaClaimFolderNumber { get; set; }

        [DataMember(Name = "vaClaimNumber")]
        public string VaClaimNumber { get; set; }

        [DataMember(Name = "vaLoanSummaryApplicantType")]
        public string VaLoanSummaryApplicantType { get; set; }

        [DataMember(Name = "ventFanIndicator")]
        public bool? VentFanIndicator { get; set; }

        [DataMember(Name = "veteranDischargedIndicator")]
        public bool? VeteranDischargedIndicator { get; set; }

        [DataMember(Name = "veteranServiceType")]
        public string VeteranServiceType { get; set; }

        [DataMember(Name = "warrantorAddress")]
        public string WarrantorAddress { get; set; }

        [DataMember(Name = "warrantorCity")]
        public string WarrantorCity { get; set; }

        [DataMember(Name = "warrantorName")]
        public string WarrantorName { get; set; }

        [DataMember(Name = "warrantorPhone")]
        public string WarrantorPhone { get; set; }

        [DataMember(Name = "warrantorPostalCode")]
        public string WarrantorPostalCode { get; set; }

        [DataMember(Name = "warrantorState")]
        public string WarrantorState { get; set; }

        [DataMember(Name = "warrantyProgramExpirationDate")]
        public string WarrantyProgramExpirationDate { get; set; }

        [DataMember(Name = "wwCarpetIndicator")]
        public bool? WwCarpetIndicator { get; set; }

        [DataMember(Name = "vaOriginalMonthlyPayment")]
        public decimal? VaOriginalMonthlyPayment { get; set; }

        [DataMember(Name = "vaOriginalAmortizationType")]
        public string VaOriginalAmortizationType { get; set; }

        [DataMember(Name = "vaRecoupmentMonthlyDecreaseInPayment")]
        public decimal? VaRecoupmentMonthlyDecreaseInPayment { get; set; }

        [DataMember(Name = "vaRecoupmentTotalClosingCosts")]
        public decimal? VaRecoupmentTotalClosingCosts { get; set; }

        [DataMember(Name = "vaRecoupmentExcludePrepaids")]
        public bool? VaRecoupmentExcludePrepaids { get; set; }

        [DataMember(Name = "vaRecoupmentClosingCosts")]
        public int? VaRecoupmentClosingCosts { get; set; }

        [DataMember(Name = "vaRecoupmentYears")]
        public int? VaRecoupmentYears { get; set; }

        [DataMember(Name = "vaRecoupmentMonths")]
        public int? VaRecoupmentMonths { get; set; }

        [DataMember(Name = "vaLatePaymentIn6Months")]
        public bool? VaLatePaymentIn6Months { get; set; }

        [DataMember(Name = "vaIsDelinquent30Days")]
        public bool? VaIsDelinquent30Days { get; set; }

        [DataMember(Name = "totalMonthlyPayment")]
        public decimal? TotalMonthlyPayment { get; set; }

        [DataMember(Name = "totalProposedMonthlyPayment")]
        public decimal? TotalProposedMonthlyPayment { get; set; }

        [DataMember(Name = "excludeTaxesInsuranceIndicator")]
        public bool? ExcludeTaxesInsuranceIndicator { get; set; }

        [DataMember(Name = "applicantBirthDate")]
        public string ApplicantBirthDate { get; set; }

        [DataMember(Name = "applicantEmailAddressText")]
        public string ApplicantEmailAddressText { get; set; }

        [DataMember(Name = "applicantHomePhoneNumber")]
        public string ApplicantHomePhoneNumber { get; set; }

        [DataMember(Name = "applicantWorkPhoneNumber")]
        public string ApplicantWorkPhoneNumber { get; set; }

        [DataMember(Name = "applicantFirstNameWithMiddleName")]
        public string ApplicantFirstNameWithMiddleName { get; set; }

        [DataMember(Name = "applicantLastNameWithSuffix")]
        public string ApplicantLastNameWithSuffix { get; set; }

        [DataMember(Name = "applicantTaxIdentificationIdentifier")]
        public string ApplicantTaxIdentificationIdentifier { get; set; }

        [DataMember(Name = "applicantHmdaGenderType")]
        public string ApplicantHmdaGenderType { get; set; }

        [DataMember(Name = "applicantAddressStreetLine1")]
        public string ApplicantAddressStreetLine1 { get; set; }

        [DataMember(Name = "applicantAddressCity")]
        public string ApplicantAddressCity { get; set; }

        [DataMember(Name = "applicantAddressState")]
        public string ApplicantAddressState { get; set; }

        [DataMember(Name = "applicantAddressPostalCode")]
        public string ApplicantAddressPostalCode { get; set; }

        [DataMember(Name = "vaBuilderDescription")]
        public string VaBuilderDescription { get; set; }

        [DataMember(Name = "automaticProcedure")]
        public bool? AutomaticProcedure { get; set; }

        [DataMember(Name = "priorApprovalProcedure")]
        public bool? PriorApprovalProcedure { get; set; }

        [DataMember(Name = "firstChattelLoanType")]
        public bool? FirstChattelLoanType { get; set; }

        [DataMember(Name = "unsecuredLoanType")]
        public bool? UnsecuredLoanType { get; set; }

        [DataMember(Name = "otherLoanType")]
        public bool? OtherLoanType { get; set; }

        [DataMember(Name = "otherDescriptionLoanType")]
        public string OtherDescriptionLoanType { get; set; }

        [DataMember(Name = "otherEstateProperty")]
        public bool? OtherEstateProperty { get; set; }

        [DataMember(Name = "otherDescriptionEstateProperty")]
        public string OtherDescriptionEstateProperty { get; set; }

        [DataMember(Name = "annualSpecialAssessment")]
        public decimal? AnnualSpecialAssessment { get; set; }

        [DataMember(Name = "totalUnpaidSpecialAssessments")]
        public decimal? TotalUnpaidSpecialAssessments { get; set; }

        [DataMember(Name = "nonRealtyDescription")]
        public string NonRealtyDescription { get; set; }

        [DataMember(Name = "additionalSecurityDescription")]
        public string AdditionalSecurityDescription { get; set; }

        [DataMember(Name = "acquiredLandDate")]
        public string AcquiredLandDate { get; set; }

        [DataMember(Name = "landPurchasePrice")]
        public decimal? LandPurchasePrice { get; set; }

        [DataMember(Name = "amountTypeWithheld")]
        public string AmountTypeWithheld { get; set; }

        [DataMember(Name = "amountWithheld")]
        public decimal? AmountWithheld { get; set; }

        [DataMember(Name = "reasonableValueCompleted")]
        public bool? ReasonableValueCompleted { get; set; }

        [DataMember(Name = "disabilityAmountCollected")]
        public decimal? DisabilityAmountCollected { get; set; }

        [DataMember(Name = "pestReportFee")]
        public decimal? PestReportFee { get; set; }

        [DataMember(Name = "vaTrackingSarName")]
        public string VaTrackingSarName { get; set; }

        [DataMember(Name = "vaTrackingSarId")]
        public string VaTrackingSarId { get; set; }

        [DataMember(Name = "vaTrackingIsSarLappCertified")]
        public bool? VaTrackingIsSarLappCertified { get; set; }

        [DataMember(Name = "vaAppraisalSentDate")]
        public string VaAppraisalSentDate { get; set; }

        [DataMember(Name = "vaNovDateReceived")]
        public string VaNovDateReceived { get; set; }

        [DataMember(Name = "vaNovDateReviewed")]
        public string VaNovDateReviewed { get; set; }

        [DataMember(Name = "vaNovIssuedDate")]
        public string VaNovIssuedDate { get; set; }

        [DataMember(Name = "vaDateNovAppraisalMailedToBorrower")]
        public string VaDateNovAppraisalMailedToBorrower { get; set; }

        [DataMember(Name = "vaTrackingOrderedDate")]
        public string VaTrackingOrderedDate { get; set; }

        [DataMember(Name = "vaTrackingCoeIssueDate")]
        public string VaTrackingCoeIssueDate { get; set; }

        [DataMember(Name = "vaTrackingCoeIssueHistory")]
        public string VaTrackingCoeIssueHistory { get; set; }

        [DataMember(Name = "vaTrackingPaidDate")]
        public string VaTrackingPaidDate { get; set; }

        [DataMember(Name = "vaTrackingReceiptReceived")]
        public bool? VaTrackingReceiptReceived { get; set; }

        [DataMember(Name = "vaTrackingLoanGuaranteeCertReceipt")]
        public string VaTrackingLoanGuaranteeCertReceipt { get; set; }

        [DataMember(Name = "vaTrackingGsaExclusionaryListChecked")]
        public bool? VaTrackingGsaExclusionaryListChecked { get; set; }

        [DataMember(Name = "vaTrackingCertOfCommitmentIssued")]
        public string VaTrackingCertOfCommitmentIssued { get; set; }

        [DataMember(Name = "vaTrackingMasterCommitmentLockExpired")]
        public string VaTrackingMasterCommitmentLockExpired { get; set; }

        [DataMember(Name = "vaTrackingFinalApprovalCommitmentDate")]
        public string VaTrackingFinalApprovalCommitmentDate { get; set; }

        [DataMember(Name = "vaTrackingPurchaseContractDate")]
        public string VaTrackingPurchaseContractDate { get; set; }

        [DataMember(Name = "vaTrackingInsuranceFloodPolicy")]
        public bool? VaTrackingInsuranceFloodPolicy { get; set; }

        [DataMember(Name = "vaTrackingInsuranceHazardPolicy")]
        public bool? VaTrackingInsuranceHazardPolicy { get; set; }

        [DataMember(Name = "vaTrackingInsuranceWoodDestroyingPolicy")]
        public bool? VaTrackingInsuranceWoodDestroyingPolicy { get; set; }

        [DataMember(Name = "vaTrackingInsuranceWindOrHailPolicy")]
        public bool? VaTrackingInsuranceWindOrHailPolicy { get; set; }

        [DataMember(Name = "vaQualificationCountryRegion")]
        public string VaQualificationCountryRegion { get; set; }

        [DataMember(Name = "vaQualification2ndTierEntitlement")]
        public string VaQualification2ndTierEntitlement { get; set; }

        [DataMember(Name = "vaQualificationCountyLimits")]
        public decimal? VaQualificationCountyLimits { get; set; }

        [DataMember(Name = "existingVaLoanNumber")]
        public string ExistingVaLoanNumber { get; set; }

        [DataMember(Name = "existingLoanBalance")]
        public decimal? ExistingLoanBalance { get; set; }

        [DataMember(Name = "estimatedImpactofLoanBalanceAmount")]
        public decimal? EstimatedImpactofLoanBalanceAmount { get; set; }

        [DataMember(Name = "estimatedImpactofRemainingTermMonths")]
        public int? EstimatedImpactofRemainingTermMonths { get; set; }

        [DataMember(Name = "estimatedImpactofInterestRate")]
        public decimal? EstimatedImpactofInterestRate { get; set; }

        [DataMember(Name = "existingTotalRemainingPaymentAmount")]
        public decimal? ExistingTotalRemainingPaymentAmount { get; set; }

        [DataMember(Name = "proposedTotalRemainingPaymentAmount")]
        public decimal? ProposedTotalRemainingPaymentAmount { get; set; }

        [DataMember(Name = "estimatedImpactofTotalRemainingPaymentAmount")]
        public decimal? EstimatedImpactofTotalRemainingPaymentAmount { get; set; }

        [DataMember(Name = "estimatedImpactofLtv")]
        public decimal? EstimatedImpactofLtv { get; set; }

        [DataMember(Name = "existingReasonableAppraisedValue")]
        public decimal? ExistingReasonableAppraisedValue { get; set; }

        [DataMember(Name = "existingHomeEquityRemainingAmount")]
        public decimal? ExistingHomeEquityRemainingAmount { get; set; }

        [DataMember(Name = "proposedHomeEquityRemainingAmount")]
        public decimal? ProposedHomeEquityRemainingAmount { get; set; }

        [DataMember(Name = "estimatedImpactofHomeEquityRemainingAmount")]
        public decimal? EstimatedImpactofHomeEquityRemainingAmount { get; set; }

        [DataMember(Name = "cashDisbursedToBorrowerAmount")]
        public decimal? CashDisbursedToBorrowerAmount { get; set; }

        [DataMember(Name = "disbursementsLessPayoffAmount")]
        public decimal? DisbursementsLessPayoffAmount { get; set; }

        [DataMember(Name = "vaImpactLoanBalanceIndicator")]
        public string VaImpactLoanBalanceIndicator { get; set; }

        [DataMember(Name = "vaImpactRemainingTermIndicator")]
        public string VaImpactRemainingTermIndicator { get; set; }

        [DataMember(Name = "vaImpactInterestRateIndicator")]
        public string VaImpactInterestRateIndicator { get; set; }

        [DataMember(Name = "vaImpactScheduledPaymentsIndicator")]
        public string VaImpactScheduledPaymentsIndicator { get; set; }

        [DataMember(Name = "vaImpactLtvIndicator")]
        public string VaImpactLtvIndicator { get; set; }

        [DataMember(Name = "vaImpactRemainingEquityIndicator")]
        public string VaImpactRemainingEquityIndicator { get; set; }

        [DataMember(Name = "totalPaidOverLifeIncreasedAmount")]
        public decimal? TotalPaidOverLifeIncreasedAmount { get; set; }

        [DataMember(Name = "existingLoanFirstPaymentDate")]
        public string ExistingLoanFirstPaymentDate { get; set; }

        [DataMember(Name = "totalClosingCostLessGuaranteeFee")]
        public decimal? TotalClosingCostLessGuaranteeFee { get; set; }

        [DataMember(Name = "vaCashOutRefinanceType")]
        public string VaCashOutRefinanceType { get; set; }

        [DataMember(Name = "amountOfProposedLiens")]
        public decimal? AmountOfProposedLiens { get; set; }

        [DataMember(Name = "vaStatutoryClosingCosts")]
        public decimal? VaStatutoryClosingCosts { get; set; }

        [DataMember(Name = "vaStatutoryMonthlyPayment")]
        public decimal? VaStatutoryMonthlyPayment { get; set; }

        [DataMember(Name = "vaStatutoryMonthlyReduction")]
        public decimal? VaStatutoryMonthlyReduction { get; set; }

        [DataMember(Name = "vaStatutoryRecoupmentMonths")]
        public int? VaStatutoryRecoupmentMonths { get; set; }

        [DataMember(Name = "vaRateReducedSolelybyDiscountPointsIndicator")]
        public bool? VaRateReducedSolelybyDiscountPointsIndicator { get; set; }

        [DataMember(Name = "vaEnergyEfficientImprovementsFinancedAmount")]
        public decimal? VaEnergyEfficientImprovementsFinancedAmount { get; set; }

        [DataMember(Name = "vaEemIncludedinBaseLoanAmountIndicator")]
        public bool? VaEemIncludedinBaseLoanAmountIndicator { get; set; }

        [DataMember(Name = "vaFinancedClosingCostsToExcludeAmount")]
        public decimal? VaFinancedClosingCostsToExcludeAmount { get; set; }

        [DataMember(Name = "initialRecoupmentFormProvidedDate")]
        public string InitialRecoupmentFormProvidedDate { get; set; }

        [DataMember(Name = "finalRecoupmentFormProvidedDate")]
        public string FinalRecoupmentFormProvidedDate { get; set; }

        [DataMember(Name = "cdNonShoppableLessFundingFee")]
        public decimal? CdNonShoppableLessFundingFee { get; set; }

        [DataMember(Name = "leTotalClosingCosts")]
        public decimal? LeTotalClosingCosts { get; set; }

        [DataMember(Name = "leRecoupmentMonths")]
        public int? LeRecoupmentMonths { get; set; }

        [DataMember(Name = "includeSectionAIndicator")]
        public bool? IncludeSectionAIndicator { get; set; }

        [DataMember(Name = "includeSectionBVaFundingFeeIndicator")]
        public bool? IncludeSectionBVaFundingFeeIndicator { get; set; }

        [DataMember(Name = "includeSectionBOtherIndicator")]
        public bool? IncludeSectionBOtherIndicator { get; set; }

        [DataMember(Name = "includeSectionCIndicator")]
        public bool? IncludeSectionCIndicator { get; set; }

        [DataMember(Name = "includeSectionEIndicator")]
        public bool? IncludeSectionEIndicator { get; set; }

        [DataMember(Name = "includeSectionFIndicator")]
        public bool? IncludeSectionFIndicator { get; set; }

        [DataMember(Name = "includeSectionGIndicator")]
        public bool? IncludeSectionGIndicator { get; set; }

        [DataMember(Name = "includeSectionHIndicator")]
        public bool? IncludeSectionHIndicator { get; set; }

        [DataMember(Name = "includeLenderCreditIndicator")]
        public bool? IncludeLenderCreditIndicator { get; set; }

        [DataMember(Name = "refinancePropertyExistingLienAmount")]
        public decimal? RefinancePropertyExistingLienAmount { get; set; }

    }
}
