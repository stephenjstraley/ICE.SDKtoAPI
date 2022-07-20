using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanData
	{
		[DataMember(Name = "acres")]
		public decimal? Acres { get; set; }

		[DataMember(Name = "additionalSecurityDescription")]
		public string AdditionalSecurityDescription { get; set; }

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

		[DataMember(Name = "amountTypeWithheld")]
		public string AmountTypeWithheld { get; set; }

		[DataMember(Name = "amountWithheld")]
		public decimal? AmountWithheld { get; set; }

		[DataMember(Name = "annualGroundRent")]
		public decimal? AnnualGroundRent { get; set; }

		[DataMember(Name = "annualMaintenanceAssessment")]
		public decimal? AnnualMaintenanceAssessment { get; set; }

		[DataMember(Name = "annualRealEstateTaxes")]
		public decimal? AnnualRealEstateTaxes { get; set; }

		[DataMember(Name = "annualSpecialAssessment")]
		public decimal? AnnualSpecialAssessment { get; set; }

		[DataMember(Name = "applicantAddressCity")]
		public string ApplicantAddressCity { get; set; }

		[DataMember(Name = "applicantAddressPostalCode")]
		public string ApplicantAddressPostalCode { get; set; }

		[DataMember(Name = "applicantAddressState")]
		public string ApplicantAddressState { get; set; }

		[DataMember(Name = "applicantAddressStreetLine1")]
		public string ApplicantAddressStreetLine1 { get; set; }

		[DataMember(Name = "applicantBirthDate")]
		public DateTime? ApplicantBirthDate { get; set; }

		[DataMember(Name = "applicantEmailAddressText")]
		public string ApplicantEmailAddressText { get; set; }

		[DataMember(Name = "applicantFirstNameWithMiddleName")]
		public string ApplicantFirstNameWithMiddleName { get; set; }

		[DataMember(Name = "applicantHmdaGenderType")]
		public string ApplicantHmdaGenderType { get; set; }

		[DataMember(Name = "applicantHomePhoneNumber")]
		public string ApplicantHomePhoneNumber { get; set; }

		[DataMember(Name = "applicantLastNameWithSuffix")]
		public string ApplicantLastNameWithSuffix { get; set; }

		[DataMember(Name = "applicantTaxIdentificationIdentifier")]
		public string ApplicantTaxIdentificationIdentifier { get; set; }

		[DataMember(Name = "appraisalType")]
		public string AppraisalType { get; set; }

		[DataMember(Name = "automaticProcedure")]
		public bool? AutomaticProcedure { get; set; }

		[DataMember(Name = "availableForInspectionAMIndicator")]
		public bool? AvailableForInspectionAMIndicator { get; set; }

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
		public DateTime? ConstructionCompletedDate { get; set; }

		[DataMember(Name = "constructionPlan")]
		public string ConstructionPlan { get; set; }

		[DataMember(Name = "constructionWarrantyIncluded")]
		public bool? ConstructionWarrantyIncluded { get; set; }

		[DataMember(Name = "contractNoApprovedByVA")]
		public string ContractNoApprovedByVA { get; set; }

		[DataMember(Name = "creditScore")]
		public int? CreditScore { get; set; }

		[DataMember(Name = "currentlyOnMilitaryDuty")]
		public bool? CurrentlyOnMilitaryDuty { get; set; }

		[DataMember(Name = "dateAquiredLand")]
		public DateTime? DateAquiredLand { get; set; }

		[DataMember(Name = "dateOfAssignment")]
		public DateTime? DateOfAssignment { get; set; }

		[DataMember(Name = "dateSAR")]
		public DateTime? DateSAR { get; set; }

		[DataMember(Name = "disabilityAmountCollected")]
		public decimal? DisabilityAmountCollected { get; set; }

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

		[DataMember(Name = "excludeTaxesInsuranceIndicator")]
		public bool? ExcludeTaxesInsuranceIndicator { get; set; }

		[DataMember(Name = "finalDiscountAmount")]
		public decimal? FinalDiscountAmount { get; set; }

		[DataMember(Name = "finalFundingFeeAmount")]
		public decimal? FinalFundingFeeAmount { get; set; }

		[DataMember(Name = "firstChattelLoanType")]
		public bool? FirstChattelLoanType { get; set; }

		[DataMember(Name = "firstTimeUse")]
		public bool? FirstTimeUse { get; set; }

		[DataMember(Name = "fundingFeeExempt")]
		public bool? FundingFeeExempt { get; set; }

		[DataMember(Name = "garbageDisposalIndicator")]
		public bool? GarbageDisposalIndicator { get; set; }

		[DataMember(Name = "id")]
		public string Id { get; set; }

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

		[DataMember(Name = "landPurchasePrice")]
		public decimal? LandPurchasePrice { get; set; }

		[DataMember(Name = "leaseholdType")]
		public string LeaseholdType { get; set; }

		[DataMember(Name = "lenderSAR")]
		public string LenderSAR { get; set; }

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

		[DataMember(Name = "loanProcessedUnderAU")]
		public bool? LoanProcessedUnderAU { get; set; }

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

		[DataMember(Name = "mCRVNumber")]
		public string MCRVNumber { get; set; }

		[DataMember(Name = "militaryBranchOfService")]
		public string MilitaryBranchOfService { get; set; }

		[DataMember(Name = "militaryServices")]
		public List<LoanContractVaLoanDataMilitaryServices> MilitaryServices { get; set; }

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

		[DataMember(Name = "nonrealtyDescription")]
		public string NonrealtyDescription { get; set; }

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

		[DataMember(Name = "otherDescriptionEstateProperty")]
		public string OtherDescriptionEstateProperty { get; set; }

		[DataMember(Name = "otherDescriptionLoanType")]
		public string OtherDescriptionLoanType { get; set; }

		[DataMember(Name = "otherEstateProperty")]
		public bool? OtherEstateProperty { get; set; }

		[DataMember(Name = "otherImprovements")]
		public bool? OtherImprovements { get; set; }

		[DataMember(Name = "otherLoanType")]
		public bool? OtherLoanType { get; set; }

		[DataMember(Name = "paidInFullVALoanNumber")]
		public string PaidInFullVALoanNumber { get; set; }

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

		[DataMember(Name = "pestReportFee")]
		public decimal? PestReportFee { get; set; }

		[DataMember(Name = "plansSubmitted")]
		public string PlansSubmitted { get; set; }

		[DataMember(Name = "pOCAddress")]
		public string POCAddress { get; set; }

		[DataMember(Name = "pOCCity")]
		public string POCCity { get; set; }

		[DataMember(Name = "pOCName")]
		public string POCName { get; set; }

		[DataMember(Name = "pOCPhone")]
		public string POCPhone { get; set; }

		[DataMember(Name = "pOCState")]
		public string POCState { get; set; }

		[DataMember(Name = "pOCZipCode")]
		public string POCZipCode { get; set; }

		[DataMember(Name = "preliminaryDiscountAmount")]
		public decimal? PreliminaryDiscountAmount { get; set; }

		[DataMember(Name = "preliminaryFundingFeeAmount")]
		public decimal? PreliminaryFundingFeeAmount { get; set; }

		[DataMember(Name = "preliminaryTotal")]
		public decimal? PreliminaryTotal { get; set; }

		[DataMember(Name = "previousVALoanIndicator")]
		public bool? PreviousVALoanIndicator { get; set; }

		[DataMember(Name = "previousVaLoans")]
		public List<LoanContractVaLoanDataPreviousVaLoans> PreviousVaLoans { get; set; }

		[DataMember(Name = "priorApprovalProcedure")]
		public bool? PriorApprovalProcedure { get; set; }

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

		[DataMember(Name = "reasonableValueCompleted")]
		public bool? ReasonableValueCompleted { get; set; }

		[DataMember(Name = "refrigeratorIndicator")]
		public bool? RefrigeratorIndicator { get; set; }

		[DataMember(Name = "rent")]
		public string Rent { get; set; }

		[DataMember(Name = "replacementOfSystem")]
		public bool? ReplacementOfSystem { get; set; }

		[DataMember(Name = "riskClasification")]
		public string RiskClasification { get; set; }

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

		[DataMember(Name = "totalMonthlyPayment")]
		public decimal? TotalMonthlyPayment { get; set; }

		[DataMember(Name = "totalProposedMonthlyPayment")]
		public decimal? TotalProposedMonthlyPayment { get; set; }

		[DataMember(Name = "totalRooms")]
		public int? TotalRooms { get; set; }

		[DataMember(Name = "totalUnpaidSpecialAssessments")]
		public decimal? TotalUnpaidSpecialAssessments { get; set; }

		[DataMember(Name = "typeOfHybridARM")]
		public string TypeOfHybridARM { get; set; }

		[DataMember(Name = "typeOfMortgage")]
		public string TypeOfMortgage { get; set; }

		[DataMember(Name = "typeOfOwnsership")]
		public string TypeOfOwnsership { get; set; }

		[DataMember(Name = "typeOfStructure")]
		public string TypeOfStructure { get; set; }

		[DataMember(Name = "typeOfVeteran")]
		public string TypeOfVeteran { get; set; }

		[DataMember(Name = "unsecuredLoanType")]
		public bool? UnsecuredLoanType { get; set; }

		[DataMember(Name = "utilitiesElectricDescription")]
		public string UtilitiesElectricDescription { get; set; }

		[DataMember(Name = "utilitiesGasDescription")]
		public string UtilitiesGasDescription { get; set; }

		[DataMember(Name = "utilitiesSewerDescription")]
		public string UtilitiesSewerDescription { get; set; }

		[DataMember(Name = "utilitiesWaterDescription")]
		public string UtilitiesWaterDescription { get; set; }

		[DataMember(Name = "vAAppraisalSentDate")]
		public DateTime? VAAppraisalSentDate { get; set; }

		[DataMember(Name = "vABenefitRelatedIndebtedness")]
		public string VABenefitRelatedIndebtedness { get; set; }

		[DataMember(Name = "vABuilderDescription")]
		public string VABuilderDescription { get; set; }

		[DataMember(Name = "vABuilderIDNo")]
		public string VABuilderIDNo { get; set; }

		[DataMember(Name = "vAClaimFolderNumber")]
		public string VAClaimFolderNumber { get; set; }

		[DataMember(Name = "vAClaimNumber")]
		public string VAClaimNumber { get; set; }

		[DataMember(Name = "vADateNOVAppraisalMailedToBorrower")]
		public DateTime? VADateNOVAppraisalMailedToBorrower { get; set; }

		[DataMember(Name = "vAIsDelinquent30Days")]
		public bool? VAIsDelinquent30Days { get; set; }

		[DataMember(Name = "vALatePaymentIn6Months")]
		public bool? VALatePaymentIn6Months { get; set; }

		[DataMember(Name = "vaLoanSummaryApplicantType")]
		public string VaLoanSummaryApplicantType { get; set; }

		[DataMember(Name = "vANOVDateReceived")]
		public DateTime? VANOVDateReceived { get; set; }

		[DataMember(Name = "vANOVDateReviewed")]
		public DateTime? VANOVDateReviewed { get; set; }

		[DataMember(Name = "vANOVIssuedDate")]
		public DateTime? VANOVIssuedDate { get; set; }

		[DataMember(Name = "vAOriginalAmortizationType")]
		public string VAOriginalAmortizationType { get; set; }

		[DataMember(Name = "vAOriginalMonthlyPayment")]
		public decimal? VAOriginalMonthlyPayment { get; set; }

		[DataMember(Name = "vAQualification2ndTierEntitlement")]
		public string VAQualification2ndTierEntitlement { get; set; }

		[DataMember(Name = "vAQualificationCountryRegion")]
		public string VAQualificationCountryRegion { get; set; }

		[DataMember(Name = "vAQualificationCountyLimits")]
		public decimal? VAQualificationCountyLimits { get; set; }

		[DataMember(Name = "vARecoupmentClosingCosts")]
		public int? VARecoupmentClosingCosts { get; set; }

		[DataMember(Name = "vARecoupmentExcludePrepaids")]
		public bool? VARecoupmentExcludePrepaids { get; set; }

		[DataMember(Name = "vARecoupmentMonthlyDecreaseInPayment")]
		public decimal? VARecoupmentMonthlyDecreaseInPayment { get; set; }

		[DataMember(Name = "vARecoupmentMonths")]
		public int? VARecoupmentMonths { get; set; }

		[DataMember(Name = "vARecoupmentTotalClosingCosts")]
		public decimal? VARecoupmentTotalClosingCosts { get; set; }

		[DataMember(Name = "vARecoupmentYears")]
		public int? VARecoupmentYears { get; set; }

		[DataMember(Name = "vATrackingCertOfCommitmentIssued")]
		public DateTime? VATrackingCertOfCommitmentIssued { get; set; }

		[DataMember(Name = "vATrackingCOEIssueDate")]
		public DateTime? VATrackingCOEIssueDate { get; set; }

		[DataMember(Name = "vATrackingCOEIssueHistory")]
		public string VATrackingCOEIssueHistory { get; set; }

		[DataMember(Name = "vATrackingFinalApprovalCommitmentDate")]
		public DateTime? VATrackingFinalApprovalCommitmentDate { get; set; }

		[DataMember(Name = "vATrackingGSAExclusionaryListChecked")]
		public bool? VATrackingGSAExclusionaryListChecked { get; set; }

		[DataMember(Name = "vATrackingInuranceFloodPolicy")]
		public bool? VATrackingInuranceFloodPolicy { get; set; }

		[DataMember(Name = "vATrackingInuranceHazardPolicy")]
		public bool? VATrackingInuranceHazardPolicy { get; set; }

		[DataMember(Name = "vATrackingInuranceWindOrHailPolicy")]
		public bool? VATrackingInuranceWindOrHailPolicy { get; set; }

		[DataMember(Name = "vATrackingInuranceWoodDestroyingPolicy")]
		public bool? VATrackingInuranceWoodDestroyingPolicy { get; set; }

		[DataMember(Name = "vATrackingIsSARLAPPCertified")]
		public bool? VATrackingIsSARLAPPCertified { get; set; }

		[DataMember(Name = "vATrackingLoanGuaranteeCertReceipt")]
		public DateTime? VATrackingLoanGuaranteeCertReceipt { get; set; }

		[DataMember(Name = "vATrackingMasterCommitmentLockExpired")]
		public DateTime? VATrackingMasterCommitmentLockExpired { get; set; }

		[DataMember(Name = "vATrackingOrderedDate")]
		public DateTime? VATrackingOrderedDate { get; set; }

		[DataMember(Name = "vATrackingPaidDate")]
		public DateTime? VATrackingPaidDate { get; set; }

		[DataMember(Name = "vATrackingPurchaseContractDate")]
		public DateTime? VATrackingPurchaseContractDate { get; set; }

		[DataMember(Name = "vATrackingReceiptReceived")]
		public bool? VATrackingReceiptReceived { get; set; }

		[DataMember(Name = "vATrackingSARID")]
		public string VATrackingSARID { get; set; }

		[DataMember(Name = "vATrackingSARName")]
		public string VATrackingSARName { get; set; }

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
		public DateTime? WarrantyProgramExpirationDate { get; set; }

		[DataMember(Name = "wWCarpetIndicator")]
		public bool? WWCarpetIndicator { get; set; }


		[DataMember(Name = "proposedHomeEquityRemainingAmount")]
		public decimal? ProposedHomeEquityRemainingAmount { get; set; }

		[DataMember(Name = "estimatedImpactofHomeEquityRemainingAmount")]
		public decimal? EstimatedImpactofHomeEquityRemainingAmount { get; set; }

		[DataMember(Name = "cashDisbursedToBorrowerAmount")]
		public decimal? CashDisbursedToBorrowerAmount { get; set; }

		[DataMember(Name = "disbursementsLessPayoffAmount")]
		public decimal? DisbursementsLessPayoffAmount { get; set; }

		[DataMember(Name = "vAImpactLoanBalanceIndicator")]
		public string VAImpactLoanBalanceIndicator { get; set; }

		[DataMember(Name = "vAImpactRemainingTermIndicator")]
		public string VAImpactRemainingTermIndicator { get; set; }

		[DataMember(Name = "vAImpactInterestRateIndicator")]
		public string VAImpactInterestRateIndicator { get; set; }

		[DataMember(Name = "vAImpactScheduledPaymentsIndicator")]
		public string VAImpactScheduledPaymentsIndicator { get; set; }

		[DataMember(Name = "vAImpactLTVIndicator")]
		public string VAImpactLTVIndicator { get; set; }

		[DataMember(Name = "existingVALoanNumber")]
		public string ExistingVALoanNumber { get; set; }

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

		[DataMember(Name = "estimatedImpactofLTV")]
		public decimal? EstimatedImpactofLTV { get; set; }

		[DataMember(Name = "existingReasonableAppraisedValue")]
		public int? ExistingReasonableAppraisedValue { get; set; }

		[DataMember(Name = "existingHomeEquityRemainingAmount")]
		public decimal? ExistingHomeEquityRemainingAmount { get; set; }

		[DataMember(Name = "vAImpactRemainingEquityIndicator")]
		public string VAImpactRemainingEquityIndicator { get; set; }

		[DataMember(Name = "totalPaidOverLifeIncreasedAmount")]
		public decimal? TotalPaidOverLifeIncreasedAmount { get; set; }

		[DataMember(Name = "existingLoanFirstPaymentDate")]
		public DateTime? ExistingLoanFirstPaymentDate { get; set; }

		[DataMember(Name = "totalClosingCostLessGuaranteeFee")]
		public decimal? TotalClosingCostLessGuaranteeFee { get; set; }

		[DataMember(Name = "vACashOutRefinanceType")]
		public string VACashOutRefinanceType { get; set; }

		[DataMember(Name = "amountOfProposedLiens")]
		public decimal? AmountOfProposedLiens { get; set; }

		[DataMember(Name = "vAStatutoryClosingCosts")]
		public decimal? VAStatutoryClosingCosts { get; set; }

		[DataMember(Name = "vAStatutoryMonthlyPayment")]
		public decimal? VAStatutoryMonthlyPayment { get; set; }

		[DataMember(Name = "vAStatutoryMonthlyReduction")]
		public decimal? VAStatutoryMonthlyReduction { get; set; }

		[DataMember(Name = "vAStatutoryRecoupmentMonths")]
		public int? VAStatutoryRecoupmentMonths { get; set; }

		[DataMember(Name = "vARateReducedSolelybyDiscountPointsIndicator")]
		public bool? VARateReducedSolelybyDiscountPointsIndicator { get; set; }

		[DataMember(Name = "vAEnergyEfficientImprovements")]
		public decimal? VAEnergyEfficientImprovements { get; set; }

		[DataMember(Name = "vAEEMIncludedinBaseLoanAmountIndicator")]
		public bool? VAEEMIncludedinBaseLoanAmountIndicator { get; set; }

		[DataMember(Name = "vAFinancedClosingCostsToExcludeAmount")]
		public decimal? VAFinancedClosingCostsToExcludeAmount { get; set; }

		[DataMember(Name = "initialRecoupmentFormProvidedDate")]
		public DateTime? InitialRecoupmentFormProvidedDate { get; set; }

		[DataMember(Name = "finalRecoupmentFormProvidedDate")]
		public DateTime? FinalRecoupmentFormProvidedDate { get; set; }

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