using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractVaLoanData
	{
		[DataMember(Name="acres", EmitDefaultValue=false)]
		public double? Acres { get; set; }

		[DataMember(Name="additionalSecurityDescription", EmitDefaultValue=false)]
		public string AdditionalSecurityDescription { get; set; }

		[DataMember(Name="administratorAddress", EmitDefaultValue=false)]
		public string AdministratorAddress { get; set; }

		[DataMember(Name="administratorCity", EmitDefaultValue=false)]
		public string AdministratorCity { get; set; }

		[DataMember(Name="administratorContact", EmitDefaultValue=false)]
		public string AdministratorContact { get; set; }

		[DataMember(Name="administratorName", EmitDefaultValue=false)]
		public string AdministratorName { get; set; }

		[DataMember(Name="administratorPostalCode", EmitDefaultValue=false)]
		public string AdministratorPostalCode { get; set; }

		[DataMember(Name="administratorState", EmitDefaultValue=false)]
		public string AdministratorState { get; set; }

		[DataMember(Name="ageOfProperty", EmitDefaultValue=false)]
		public int? AgeOfProperty { get; set; }

		[DataMember(Name="amountSpentOnEnergyImprovements", EmitDefaultValue=false)]
		public double? AmountSpentOnEnergyImprovements { get; set; }

		[DataMember(Name="amountTypeWithheld", EmitDefaultValue=false)]
		public string AmountTypeWithheld { get; set; }

		[DataMember(Name="amountWithheld", EmitDefaultValue=false)]
		public double? AmountWithheld { get; set; }

		[DataMember(Name="annualGroundRent", EmitDefaultValue=false)]
		public double? AnnualGroundRent { get; set; }

		[DataMember(Name="annualMaintenanceAssessment", EmitDefaultValue=false)]
		public double? AnnualMaintenanceAssessment { get; set; }

		[DataMember(Name="annualRealEstateTaxes", EmitDefaultValue=false)]
		public double? AnnualRealEstateTaxes { get; set; }

		[DataMember(Name="annualSpecialAssessment", EmitDefaultValue=false)]
		public double? AnnualSpecialAssessment { get; set; }

		[DataMember(Name="applicantAddressCity", EmitDefaultValue=false)]
		public string ApplicantAddressCity { get; set; }

		[DataMember(Name="applicantAddressPostalCode", EmitDefaultValue=false)]
		public string ApplicantAddressPostalCode { get; set; }

		[DataMember(Name="applicantAddressState", EmitDefaultValue=false)]
		public string ApplicantAddressState { get; set; }

		[DataMember(Name="applicantAddressStreetLine1", EmitDefaultValue=false)]
		public string ApplicantAddressStreetLine1 { get; set; }

		[DataMember(Name="applicantBirthDate", EmitDefaultValue=false)]
		public DateTime? ApplicantBirthDate { get; set; }

		[DataMember(Name="applicantEmailAddressText", EmitDefaultValue=false)]
		public string ApplicantEmailAddressText { get; set; }

		[DataMember(Name="applicantFirstNameWithMiddleName", EmitDefaultValue=false)]
		public string ApplicantFirstNameWithMiddleName { get; set; }

		[DataMember(Name="applicantHmdaGenderType", EmitDefaultValue=false)]
		public string ApplicantHmdaGenderType { get; set; }

		[DataMember(Name="applicantHomePhoneNumber", EmitDefaultValue=false)]
		public string ApplicantHomePhoneNumber { get; set; }

		[DataMember(Name="applicantLastNameWithSuffix", EmitDefaultValue=false)]
		public string ApplicantLastNameWithSuffix { get; set; }

		[DataMember(Name="applicantTaxIdentificationIdentifier", EmitDefaultValue=false)]
		public string ApplicantTaxIdentificationIdentifier { get; set; }

		[DataMember(Name="appraisalType", EmitDefaultValue=false)]
		public string AppraisalType { get; set; }

		[DataMember(Name="automaticProcedure", EmitDefaultValue=false)]
		public bool? AutomaticProcedure { get; set; }

		[DataMember(Name="availableForInspectionAMIndicator", EmitDefaultValue=false)]
		public bool? AvailableForInspectionAMIndicator { get; set; }

		[DataMember(Name="availableForInspectionDateAndTime", EmitDefaultValue=false)]
		public string AvailableForInspectionDateAndTime { get; set; }

		[DataMember(Name="borrowerPaidDiscountPointsTotalAmount", EmitDefaultValue=false)]
		public double? BorrowerPaidDiscountPointsTotalAmount { get; set; }

		[DataMember(Name="buildingType", EmitDefaultValue=false)]
		public string BuildingType { get; set; }

		[DataMember(Name="buyerPurchasingLotSeparately", EmitDefaultValue=false)]
		public bool? BuyerPurchasingLotSeparately { get; set; }

		[DataMember(Name="cashPaymentFromVeteran", EmitDefaultValue=false)]
		public double? CashPaymentFromVeteran { get; set; }

		[DataMember(Name="claimDisabilityBenefits", EmitDefaultValue=false)]
		public string ClaimDisabilityBenefits { get; set; }

		[DataMember(Name="clothesWasherIndicator", EmitDefaultValue=false)]
		public bool? ClothesWasherIndicator { get; set; }

		[DataMember(Name="constructionCompletedDate", EmitDefaultValue=false)]
		public DateTime? ConstructionCompletedDate { get; set; }

		[DataMember(Name="constructionPlan", EmitDefaultValue=false)]
		public string ConstructionPlan { get; set; }

		[DataMember(Name="constructionWarrantyIncluded", EmitDefaultValue=false)]
		public bool? ConstructionWarrantyIncluded { get; set; }

		[DataMember(Name="contractNoApprovedByVA", EmitDefaultValue=false)]
		public string ContractNoApprovedByVA { get; set; }

		[DataMember(Name="creditScore", EmitDefaultValue=false)]
		public int? CreditScore { get; set; }

		[DataMember(Name="currentlyOnMilitaryDuty", EmitDefaultValue=false)]
		public bool? CurrentlyOnMilitaryDuty { get; set; }

		[DataMember(Name="dateAquiredLand", EmitDefaultValue=false)]
		public DateTime? DateAquiredLand { get; set; }

		[DataMember(Name="dateOfAssignment", EmitDefaultValue=false)]
		public DateTime? DateOfAssignment { get; set; }

		[DataMember(Name="dateSAR", EmitDefaultValue=false)]
		public DateTime? DateSAR { get; set; }

		[DataMember(Name="disabilityAmountCollected", EmitDefaultValue=false)]
		public double? DisabilityAmountCollected { get; set; }

		[DataMember(Name="discountPercentage", EmitDefaultValue=false)]
		public double? DiscountPercentage { get; set; }

		[DataMember(Name="discountPoint", EmitDefaultValue=false)]
		public double? DiscountPoint { get; set; }

		[DataMember(Name="dishwasherIndicator", EmitDefaultValue=false)]
		public bool? DishwasherIndicator { get; set; }

		[DataMember(Name="dryerIndicator", EmitDefaultValue=false)]
		public bool? DryerIndicator { get; set; }

		[DataMember(Name="emailToBeNotifiedWhenUploaded", EmitDefaultValue=false)]
		public string EmailToBeNotifiedWhenUploaded { get; set; }

		[DataMember(Name="energyImprovementsAdditionOfFeature", EmitDefaultValue=false)]
		public bool? EnergyImprovementsAdditionOfFeature { get; set; }

		[DataMember(Name="entitlementCode", EmitDefaultValue=false)]
		public string EntitlementCode { get; set; }

		[DataMember(Name="equipmentOtherDescription", EmitDefaultValue=false)]
		public string EquipmentOtherDescription { get; set; }

		[DataMember(Name="excludeTaxesInsuranceIndicator", EmitDefaultValue=false)]
		public bool? ExcludeTaxesInsuranceIndicator { get; set; }

		[DataMember(Name="finalDiscountAmount", EmitDefaultValue=false)]
		public double? FinalDiscountAmount { get; set; }

		[DataMember(Name="finalFundingFeeAmount", EmitDefaultValue=false)]
		public double? FinalFundingFeeAmount { get; set; }

		[DataMember(Name="firstChattelLoanType", EmitDefaultValue=false)]
		public bool? FirstChattelLoanType { get; set; }

		[DataMember(Name="firstTimeUse", EmitDefaultValue=false)]
		public bool? FirstTimeUse { get; set; }

		[DataMember(Name="fundingFeeExempt", EmitDefaultValue=false)]
		public bool? FundingFeeExempt { get; set; }

		[DataMember(Name="garbageDisposalIndicator", EmitDefaultValue=false)]
		public bool? GarbageDisposalIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialTotal", EmitDefaultValue=false)]
		public double? InitialTotal { get; set; }

		[DataMember(Name="inspectionWillBeMadeBy", EmitDefaultValue=false)]
		public string InspectionWillBeMadeBy { get; set; }

		[DataMember(Name="insulation", EmitDefaultValue=false)]
		public bool? Insulation { get; set; }

		[DataMember(Name="insuranceType", EmitDefaultValue=false)]
		public string InsuranceType { get; set; }

		[DataMember(Name="irregularLotSizeInSquareFeet", EmitDefaultValue=false)]
		public int? IrregularLotSizeInSquareFeet { get; set; }

		[DataMember(Name="isDelinquent30Days", EmitDefaultValue=false)]
		public bool? IsDelinquent30Days { get; set; }

		[DataMember(Name="keysAtAddress", EmitDefaultValue=false)]
		public string KeysAtAddress { get; set; }

		[DataMember(Name="landPurchasePrice", EmitDefaultValue=false)]
		public double? LandPurchasePrice { get; set; }

		[DataMember(Name="leaseholdType", EmitDefaultValue=false)]
		public string LeaseholdType { get; set; }

		[DataMember(Name="lenderSAR", EmitDefaultValue=false)]
		public string LenderSAR { get; set; }

		[DataMember(Name="loanAnalysisRemarks1", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks1 { get; set; }

		[DataMember(Name="loanAnalysisRemarks2", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks2 { get; set; }

		[DataMember(Name="loanAnalysisRemarks3", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks3 { get; set; }

		[DataMember(Name="loanAnalysisRemarks4", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks4 { get; set; }

		[DataMember(Name="loanAnalysisRemarks5", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks5 { get; set; }

		[DataMember(Name="loanAnalysisRemarks6", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks6 { get; set; }

		[DataMember(Name="loanAnalysisRemarks7", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks7 { get; set; }

		[DataMember(Name="loanAnalysisRemarks8", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks8 { get; set; }

		[DataMember(Name="loanAnalysisRemarks9", EmitDefaultValue=false)]
		public string LoanAnalysisRemarks9 { get; set; }

		[DataMember(Name="loanCode", EmitDefaultValue=false)]
		public string LoanCode { get; set; }

		[DataMember(Name="loanProcedure", EmitDefaultValue=false)]
		public string LoanProcedure { get; set; }

		[DataMember(Name="loanProcessedUnderAU", EmitDefaultValue=false)]
		public bool? LoanProcessedUnderAU { get; set; }

		[DataMember(Name="loanSummaryRemarks1", EmitDefaultValue=false)]
		public string LoanSummaryRemarks1 { get; set; }

		[DataMember(Name="loanSummaryRemarks2", EmitDefaultValue=false)]
		public string LoanSummaryRemarks2 { get; set; }

		[DataMember(Name="loanSummaryRemarks3", EmitDefaultValue=false)]
		public string LoanSummaryRemarks3 { get; set; }

		[DataMember(Name="loanSummaryRemarks4", EmitDefaultValue=false)]
		public string LoanSummaryRemarks4 { get; set; }

		[DataMember(Name="loanSummaryRemarks5", EmitDefaultValue=false)]
		public string LoanSummaryRemarks5 { get; set; }

		[DataMember(Name="loanSummaryRemarks6", EmitDefaultValue=false)]
		public string LoanSummaryRemarks6 { get; set; }

		[DataMember(Name="loanSummaryRemarks7", EmitDefaultValue=false)]
		public string LoanSummaryRemarks7 { get; set; }

		[DataMember(Name="loanSummaryRemarks8", EmitDefaultValue=false)]
		public string LoanSummaryRemarks8 { get; set; }

		[DataMember(Name="lotDimensions", EmitDefaultValue=false)]
		public string LotDimensions { get; set; }

		[DataMember(Name="mailingAddress", EmitDefaultValue=false)]
		public string MailingAddress { get; set; }

		[DataMember(Name="mailingCity", EmitDefaultValue=false)]
		public string MailingCity { get; set; }

		[DataMember(Name="mailingPostalCode", EmitDefaultValue=false)]
		public string MailingPostalCode { get; set; }

		[DataMember(Name="mailingState", EmitDefaultValue=false)]
		public string MailingState { get; set; }

		[DataMember(Name="manufacturedHome", EmitDefaultValue=false)]
		public string ManufacturedHome { get; set; }

		[DataMember(Name="mCRVNumber", EmitDefaultValue=false)]
		public string MCRVNumber { get; set; }

		[DataMember(Name="militaryBranchOfService", EmitDefaultValue=false)]
		public string MilitaryBranchOfService { get; set; }

		[DataMember(Name="militaryServices", EmitDefaultValue=false)]
		public List<LoanContractVaLoanDataMilitaryServices> MilitaryServices { get; set; }

		[DataMember(Name="mineralRightsReserved", EmitDefaultValue=false)]
		public string MineralRightsReserved { get; set; }

		[DataMember(Name="nameOfOccupant", EmitDefaultValue=false)]
		public string NameOfOccupant { get; set; }

		[DataMember(Name="nameOfOwner", EmitDefaultValue=false)]
		public string NameOfOwner { get; set; }

		[DataMember(Name="nameOfWarrantyProgram", EmitDefaultValue=false)]
		public string NameOfWarrantyProgram { get; set; }

		[DataMember(Name="negativeRents", EmitDefaultValue=false)]
		public double? NegativeRents { get; set; }

		[DataMember(Name="noEnergyImprovements", EmitDefaultValue=false)]
		public bool? NoEnergyImprovements { get; set; }

		[DataMember(Name="nonrealtyDescription", EmitDefaultValue=false)]
		public string NonrealtyDescription { get; set; }

		[DataMember(Name="numberOfBuildings", EmitDefaultValue=false)]
		public string NumberOfBuildings { get; set; }

		[DataMember(Name="occupantTelephone", EmitDefaultValue=false)]
		public string OccupantTelephone { get; set; }

		[DataMember(Name="onMilitaryDutyFollowingSeparation", EmitDefaultValue=false)]
		public bool? OnMilitaryDutyFollowingSeparation { get; set; }

		[DataMember(Name="originalInterestRate", EmitDefaultValue=false)]
		public double? OriginalInterestRate { get; set; }

		[DataMember(Name="originalLoanAmount", EmitDefaultValue=false)]
		public double? OriginalLoanAmount { get; set; }

		[DataMember(Name="originalTerm", EmitDefaultValue=false)]
		public int? OriginalTerm { get; set; }

		[DataMember(Name="originalValueEstimateChanged", EmitDefaultValue=false)]
		public bool? OriginalValueEstimateChanged { get; set; }

		[DataMember(Name="originationFeeAmount", EmitDefaultValue=false)]
		public double? OriginationFeeAmount { get; set; }

		[DataMember(Name="otherClosingCosts", EmitDefaultValue=false)]
		public double? OtherClosingCosts { get; set; }

		[DataMember(Name="otherDescriptionEstateProperty", EmitDefaultValue=false)]
		public string OtherDescriptionEstateProperty { get; set; }

		[DataMember(Name="otherDescriptionLoanType", EmitDefaultValue=false)]
		public string OtherDescriptionLoanType { get; set; }

		[DataMember(Name="otherEstateProperty", EmitDefaultValue=false)]
		public bool? OtherEstateProperty { get; set; }

		[DataMember(Name="otherImprovements", EmitDefaultValue=false)]
		public bool? OtherImprovements { get; set; }

		[DataMember(Name="otherLoanType", EmitDefaultValue=false)]
		public bool? OtherLoanType { get; set; }

		[DataMember(Name="paidInFullVALoanNumber", EmitDefaultValue=false)]
		public string PaidInFullVALoanNumber { get; set; }

		[DataMember(Name="payoffIndicator1", EmitDefaultValue=false)]
		public bool? PayoffIndicator1 { get; set; }

		[DataMember(Name="payoffIndicator2", EmitDefaultValue=false)]
		public bool? PayoffIndicator2 { get; set; }

		[DataMember(Name="payoffIndicator3", EmitDefaultValue=false)]
		public bool? PayoffIndicator3 { get; set; }

		[DataMember(Name="payoffIndicator4", EmitDefaultValue=false)]
		public bool? PayoffIndicator4 { get; set; }

		[DataMember(Name="payoffIndicator5", EmitDefaultValue=false)]
		public bool? PayoffIndicator5 { get; set; }

		[DataMember(Name="payoffIndicator6", EmitDefaultValue=false)]
		public bool? PayoffIndicator6 { get; set; }

		[DataMember(Name="payoffIndicator7", EmitDefaultValue=false)]
		public bool? PayoffIndicator7 { get; set; }

		[DataMember(Name="payoffIndicator8", EmitDefaultValue=false)]
		public bool? PayoffIndicator8 { get; set; }

		[DataMember(Name="payoffIndicator9", EmitDefaultValue=false)]
		public bool? PayoffIndicator9 { get; set; }

		[DataMember(Name="pestReportFee", EmitDefaultValue=false)]
		public double? PestReportFee { get; set; }

		[DataMember(Name="plansSubmitted", EmitDefaultValue=false)]
		public string PlansSubmitted { get; set; }

		[DataMember(Name="pOCAddress", EmitDefaultValue=false)]
		public string POCAddress { get; set; }

		[DataMember(Name="pOCCity", EmitDefaultValue=false)]
		public string POCCity { get; set; }

		[DataMember(Name="pOCName", EmitDefaultValue=false)]
		public string POCName { get; set; }

		[DataMember(Name="pOCPhone", EmitDefaultValue=false)]
		public string POCPhone { get; set; }

		[DataMember(Name="pOCState", EmitDefaultValue=false)]
		public string POCState { get; set; }

		[DataMember(Name="pOCZipCode", EmitDefaultValue=false)]
		public string POCZipCode { get; set; }

		[DataMember(Name="preliminaryDiscountAmount", EmitDefaultValue=false)]
		public double? PreliminaryDiscountAmount { get; set; }

		[DataMember(Name="preliminaryFundingFeeAmount", EmitDefaultValue=false)]
		public double? PreliminaryFundingFeeAmount { get; set; }

		[DataMember(Name="preliminaryTotal", EmitDefaultValue=false)]
		public double? PreliminaryTotal { get; set; }

		[DataMember(Name="previousVALoanIndicator", EmitDefaultValue=false)]
		public bool? PreviousVALoanIndicator { get; set; }

		[DataMember(Name="previousVaLoans", EmitDefaultValue=false)]
		public List<LoanContractVaLoanDataPreviousVaLoans> PreviousVaLoans { get; set; }

		[DataMember(Name="priorApprovalProcedure", EmitDefaultValue=false)]
		public bool? PriorApprovalProcedure { get; set; }

		[DataMember(Name="priorLoanType", EmitDefaultValue=false)]
		public string PriorLoanType { get; set; }

		[DataMember(Name="propertyDesignation", EmitDefaultValue=false)]
		public string PropertyDesignation { get; set; }

		[DataMember(Name="propertyGrossLivingArea", EmitDefaultValue=false)]
		public int? PropertyGrossLivingArea { get; set; }

		[DataMember(Name="propertyLegalDescription1", EmitDefaultValue=false)]
		public string PropertyLegalDescription1 { get; set; }

		[DataMember(Name="propertyLegalDescription2", EmitDefaultValue=false)]
		public string PropertyLegalDescription2 { get; set; }

		[DataMember(Name="propertyLegalDescription3", EmitDefaultValue=false)]
		public string PropertyLegalDescription3 { get; set; }

		[DataMember(Name="propertyLegalDescription4", EmitDefaultValue=false)]
		public string PropertyLegalDescription4 { get; set; }

		[DataMember(Name="propertyOccupancyType", EmitDefaultValue=false)]
		public string PropertyOccupancyType { get; set; }

		[DataMember(Name="proposedSaleContractAttached", EmitDefaultValue=false)]
		public bool? ProposedSaleContractAttached { get; set; }

		[DataMember(Name="purposeOfLoan", EmitDefaultValue=false)]
		public string PurposeOfLoan { get; set; }

		[DataMember(Name="rangeOvenIndicator", EmitDefaultValue=false)]
		public bool? RangeOvenIndicator { get; set; }

		[DataMember(Name="reasonableValueCompleted", EmitDefaultValue=false)]
		public bool? ReasonableValueCompleted { get; set; }

		[DataMember(Name="refrigeratorIndicator", EmitDefaultValue=false)]
		public bool? RefrigeratorIndicator { get; set; }

		[DataMember(Name="rent", EmitDefaultValue=false)]
		public string Rent { get; set; }

		[DataMember(Name="replacementOfSystem", EmitDefaultValue=false)]
		public bool? ReplacementOfSystem { get; set; }

		[DataMember(Name="riskClasification", EmitDefaultValue=false)]
		public string RiskClasification { get; set; }

		[DataMember(Name="serviceNumber", EmitDefaultValue=false)]
		public string ServiceNumber { get; set; }

		[DataMember(Name="solarHeatingOrCooling", EmitDefaultValue=false)]
		public bool? SolarHeatingOrCooling { get; set; }

		[DataMember(Name="specialAssessmentComments1", EmitDefaultValue=false)]
		public string SpecialAssessmentComments1 { get; set; }

		[DataMember(Name="specialAssessmentComments2", EmitDefaultValue=false)]
		public string SpecialAssessmentComments2 { get; set; }

		[DataMember(Name="specialAssessmentComments3", EmitDefaultValue=false)]
		public string SpecialAssessmentComments3 { get; set; }

		[DataMember(Name="streetAccess", EmitDefaultValue=false)]
		public string StreetAccess { get; set; }

		[DataMember(Name="streetMaintenance", EmitDefaultValue=false)]
		public string StreetMaintenance { get; set; }

		[DataMember(Name="systemUsed", EmitDefaultValue=false)]
		public string SystemUsed { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="titleLimitations1", EmitDefaultValue=false)]
		public string TitleLimitations1 { get; set; }

		[DataMember(Name="titleLimitations2", EmitDefaultValue=false)]
		public string TitleLimitations2 { get; set; }

		[DataMember(Name="titleLimitations3", EmitDefaultValue=false)]
		public string TitleLimitations3 { get; set; }

		[DataMember(Name="totalBaths", EmitDefaultValue=false)]
		public double? TotalBaths { get; set; }

		[DataMember(Name="totalBedrooms", EmitDefaultValue=false)]
		public int? TotalBedrooms { get; set; }

		[DataMember(Name="totalDebtMonthlyPayment", EmitDefaultValue=false)]
		public double? TotalDebtMonthlyPayment { get; set; }

		[DataMember(Name="totalDiscountPointCharged", EmitDefaultValue=false)]
		public double? TotalDiscountPointCharged { get; set; }

		[DataMember(Name="totalDiscountPointsCharged", EmitDefaultValue=false)]
		public double? TotalDiscountPointsCharged { get; set; }

		[DataMember(Name="totalForMaxLoanAmount", EmitDefaultValue=false)]
		public double? TotalForMaxLoanAmount { get; set; }

		[DataMember(Name="totalMonthlyPayment", EmitDefaultValue=false)]
		public double? TotalMonthlyPayment { get; set; }

		[DataMember(Name="totalProposedMonthlyPayment", EmitDefaultValue=false)]
		public double? TotalProposedMonthlyPayment { get; set; }

		[DataMember(Name="totalRooms", EmitDefaultValue=false)]
		public int? TotalRooms { get; set; }

		[DataMember(Name="totalUnpaidSpecialAssessments", EmitDefaultValue=false)]
		public double? TotalUnpaidSpecialAssessments { get; set; }

		[DataMember(Name="typeOfHybridARM", EmitDefaultValue=false)]
		public string TypeOfHybridARM { get; set; }

		[DataMember(Name="typeOfMortgage", EmitDefaultValue=false)]
		public string TypeOfMortgage { get; set; }

		[DataMember(Name="typeOfOwnsership", EmitDefaultValue=false)]
		public string TypeOfOwnsership { get; set; }

		[DataMember(Name="typeOfStructure", EmitDefaultValue=false)]
		public string TypeOfStructure { get; set; }

		[DataMember(Name="typeOfVeteran", EmitDefaultValue=false)]
		public string TypeOfVeteran { get; set; }

		[DataMember(Name="unsecuredLoanType", EmitDefaultValue=false)]
		public bool? UnsecuredLoanType { get; set; }

		[DataMember(Name="utilitiesElectricDescription", EmitDefaultValue=false)]
		public string UtilitiesElectricDescription { get; set; }

		[DataMember(Name="utilitiesGasDescription", EmitDefaultValue=false)]
		public string UtilitiesGasDescription { get; set; }

		[DataMember(Name="utilitiesSewerDescription", EmitDefaultValue=false)]
		public string UtilitiesSewerDescription { get; set; }

		[DataMember(Name="utilitiesWaterDescription", EmitDefaultValue=false)]
		public string UtilitiesWaterDescription { get; set; }

		[DataMember(Name="vAAppraisalSentDate", EmitDefaultValue=false)]
		public DateTime? VAAppraisalSentDate { get; set; }

		[DataMember(Name="vABenefitRelatedIndebtedness", EmitDefaultValue=false)]
		public string VABenefitRelatedIndebtedness { get; set; }

		[DataMember(Name="vABuilderDescription", EmitDefaultValue=false)]
		public string VABuilderDescription { get; set; }

		[DataMember(Name="vABuilderIDNo", EmitDefaultValue=false)]
		public string VABuilderIDNo { get; set; }

		[DataMember(Name="vAClaimFolderNumber", EmitDefaultValue=false)]
		public string VAClaimFolderNumber { get; set; }

		[DataMember(Name="vAClaimNumber", EmitDefaultValue=false)]
		public string VAClaimNumber { get; set; }

		[DataMember(Name="vADateNOVAppraisalMailedToBorrower", EmitDefaultValue=false)]
		public DateTime? VADateNOVAppraisalMailedToBorrower { get; set; }

		[DataMember(Name="vAIsDelinquent30Days", EmitDefaultValue=false)]
		public bool? VAIsDelinquent30Days { get; set; }

		[DataMember(Name="vALatePaymentIn6Months", EmitDefaultValue=false)]
		public bool? VALatePaymentIn6Months { get; set; }

		[DataMember(Name="vaLoanSummaryApplicantType", EmitDefaultValue=false)]
		public string VaLoanSummaryApplicantType { get; set; }

		[DataMember(Name="vANOVDateReceived", EmitDefaultValue=false)]
		public DateTime? VANOVDateReceived { get; set; }

		[DataMember(Name="vANOVDateReviewed", EmitDefaultValue=false)]
		public DateTime? VANOVDateReviewed { get; set; }

		[DataMember(Name="vANOVIssuedDate", EmitDefaultValue=false)]
		public DateTime? VANOVIssuedDate { get; set; }

		[DataMember(Name="vAOriginalAmortizationType", EmitDefaultValue=false)]
		public string VAOriginalAmortizationType { get; set; }

		[DataMember(Name="vAOriginalMonthlyPayment", EmitDefaultValue=false)]
		public double? VAOriginalMonthlyPayment { get; set; }

		[DataMember(Name="vAQualification2ndTierEntitlement", EmitDefaultValue=false)]
		public string VAQualification2ndTierEntitlement { get; set; }

		[DataMember(Name="vAQualificationCountryRegion", EmitDefaultValue=false)]
		public string VAQualificationCountryRegion { get; set; }

		[DataMember(Name="vAQualificationCountyLimits", EmitDefaultValue=false)]
		public double? VAQualificationCountyLimits { get; set; }

		[DataMember(Name="vARecoupmentClosingCosts", EmitDefaultValue=false)]
		public int? VARecoupmentClosingCosts { get; set; }

		[DataMember(Name="vARecoupmentExcludePrepaids", EmitDefaultValue=false)]
		public bool? VARecoupmentExcludePrepaids { get; set; }

		[DataMember(Name="vARecoupmentMonthlyDecreaseInPayment", EmitDefaultValue=false)]
		public double? VARecoupmentMonthlyDecreaseInPayment { get; set; }

		[DataMember(Name="vARecoupmentMonths", EmitDefaultValue=false)]
		public int? VARecoupmentMonths { get; set; }

		[DataMember(Name="vARecoupmentTotalClosingCosts", EmitDefaultValue=false)]
		public double? VARecoupmentTotalClosingCosts { get; set; }

		[DataMember(Name="vARecoupmentYears", EmitDefaultValue=false)]
		public int? VARecoupmentYears { get; set; }

		[DataMember(Name="vATrackingCertOfCommitmentIssued", EmitDefaultValue=false)]
		public DateTime? VATrackingCertOfCommitmentIssued { get; set; }

		[DataMember(Name="vATrackingCOEIssueDate", EmitDefaultValue=false)]
		public DateTime? VATrackingCOEIssueDate { get; set; }

		[DataMember(Name="vATrackingCOEIssueHistory", EmitDefaultValue=false)]
		public string VATrackingCOEIssueHistory { get; set; }

		[DataMember(Name="vATrackingFinalApprovalCommitmentDate", EmitDefaultValue=false)]
		public DateTime? VATrackingFinalApprovalCommitmentDate { get; set; }

		[DataMember(Name="vATrackingGSAExclusionaryListChecked", EmitDefaultValue=false)]
		public bool? VATrackingGSAExclusionaryListChecked { get; set; }

		[DataMember(Name="vATrackingInuranceFloodPolicy", EmitDefaultValue=false)]
		public bool? VATrackingInuranceFloodPolicy { get; set; }

		[DataMember(Name="vATrackingInuranceHazardPolicy", EmitDefaultValue=false)]
		public bool? VATrackingInuranceHazardPolicy { get; set; }

		[DataMember(Name="vATrackingInuranceWindOrHailPolicy", EmitDefaultValue=false)]
		public bool? VATrackingInuranceWindOrHailPolicy { get; set; }

		[DataMember(Name="vATrackingInuranceWoodDestroyingPolicy", EmitDefaultValue=false)]
		public bool? VATrackingInuranceWoodDestroyingPolicy { get; set; }

		[DataMember(Name="vATrackingIsSARLAPPCertified", EmitDefaultValue=false)]
		public bool? VATrackingIsSARLAPPCertified { get; set; }

		[DataMember(Name="vATrackingLoanGuaranteeCertReceipt", EmitDefaultValue=false)]
		public DateTime? VATrackingLoanGuaranteeCertReceipt { get; set; }

		[DataMember(Name="vATrackingMasterCommitmentLockExpired", EmitDefaultValue=false)]
		public DateTime? VATrackingMasterCommitmentLockExpired { get; set; }

		[DataMember(Name="vATrackingOrderedDate", EmitDefaultValue=false)]
		public DateTime? VATrackingOrderedDate { get; set; }

		[DataMember(Name="vATrackingPaidDate", EmitDefaultValue=false)]
		public DateTime? VATrackingPaidDate { get; set; }

		[DataMember(Name="vATrackingPurchaseContractDate", EmitDefaultValue=false)]
		public DateTime? VATrackingPurchaseContractDate { get; set; }

		[DataMember(Name="vATrackingReceiptReceived", EmitDefaultValue=false)]
		public bool? VATrackingReceiptReceived { get; set; }

		[DataMember(Name="vATrackingSARID", EmitDefaultValue=false)]
		public string VATrackingSARID { get; set; }

		[DataMember(Name="vATrackingSARName", EmitDefaultValue=false)]
		public string VATrackingSARName { get; set; }

		[DataMember(Name="ventFanIndicator", EmitDefaultValue=false)]
		public bool? VentFanIndicator { get; set; }

		[DataMember(Name="veteranDischargedIndicator", EmitDefaultValue=false)]
		public bool? VeteranDischargedIndicator { get; set; }

		[DataMember(Name="veteranServiceType", EmitDefaultValue=false)]
		public string VeteranServiceType { get; set; }

		[DataMember(Name="warrantorAddress", EmitDefaultValue=false)]
		public string WarrantorAddress { get; set; }

		[DataMember(Name="warrantorCity", EmitDefaultValue=false)]
		public string WarrantorCity { get; set; }

		[DataMember(Name="warrantorName", EmitDefaultValue=false)]
		public string WarrantorName { get; set; }

		[DataMember(Name="warrantorPhone", EmitDefaultValue=false)]
		public string WarrantorPhone { get; set; }

		[DataMember(Name="warrantorPostalCode", EmitDefaultValue=false)]
		public string WarrantorPostalCode { get; set; }

		[DataMember(Name="warrantorState", EmitDefaultValue=false)]
		public string WarrantorState { get; set; }

		[DataMember(Name="warrantyProgramExpirationDate", EmitDefaultValue=false)]
		public DateTime? WarrantyProgramExpirationDate { get; set; }

		[DataMember(Name="wWCarpetIndicator", EmitDefaultValue=false)]
		public bool? WWCarpetIndicator { get; set; }

	}
}