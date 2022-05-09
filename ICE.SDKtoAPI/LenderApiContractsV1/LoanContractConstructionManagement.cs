using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractConstructionManagement
	{
		[DataMember(Name="additionalDisbursementsConditions", EmitDefaultValue=false)]
		public string AdditionalDisbursementsConditions { get; set; }

		[DataMember(Name="architectsCertificateDate", EmitDefaultValue=false)]
		public DateTime? ArchitectsCertificateDate { get; set; }

		[DataMember(Name="architectsCertificateIndicator", EmitDefaultValue=false)]
		public bool? ArchitectsCertificateIndicator { get; set; }

		[DataMember(Name="asCompletedAppraisedValue", EmitDefaultValue=false)]
		public double? AsCompletedAppraisedValue { get; set; }

		[DataMember(Name="asCompletedPurchasePrice", EmitDefaultValue=false)]
		public double? AsCompletedPurchasePrice { get; set; }

		[DataMember(Name="budgetDate", EmitDefaultValue=false)]
		public DateTime? BudgetDate { get; set; }

		[DataMember(Name="budgetIndicator", EmitDefaultValue=false)]
		public bool? BudgetIndicator { get; set; }

		[DataMember(Name="commitmentExpirationDate", EmitDefaultValue=false)]
		public DateTime? CommitmentExpirationDate { get; set; }

		[DataMember(Name="commitmentLetterDate", EmitDefaultValue=false)]
		public DateTime? CommitmentLetterDate { get; set; }

		[DataMember(Name="constCompletionDate", EmitDefaultValue=false)]
		public DateTime? ConstCompletionDate { get; set; }

		[DataMember(Name="constOnlyAmortizationType", EmitDefaultValue=false)]
		public string ConstOnlyAmortizationType { get; set; }

		[DataMember(Name="constructionContractIndicator", EmitDefaultValue=false)]
		public bool? ConstructionContractIndicator { get; set; }

		[DataMember(Name="constructionContractIssuedDate", EmitDefaultValue=false)]
		public DateTime? ConstructionContractIssuedDate { get; set; }

		[DataMember(Name="constructionContractReceivedDate", EmitDefaultValue=false)]
		public DateTime? ConstructionContractReceivedDate { get; set; }

		[DataMember(Name="constructionPeriodIncludedInLoanTermFlag", EmitDefaultValue=false)]
		public bool? ConstructionPeriodIncludedInLoanTermFlag { get; set; }

		[DataMember(Name="contractorsAgreementDate", EmitDefaultValue=false)]
		public DateTime? ContractorsAgreementDate { get; set; }

		[DataMember(Name="contractorsAgreementIndicator", EmitDefaultValue=false)]
		public bool? ContractorsAgreementIndicator { get; set; }

		[DataMember(Name="costImprovementsIncluded", EmitDefaultValue=false)]
		public bool? CostImprovementsIncluded { get; set; }

		[DataMember(Name="environmentalAssessmentDate", EmitDefaultValue=false)]
		public DateTime? EnvironmentalAssessmentDate { get; set; }

		[DataMember(Name="environmentalAssessmentIndicator", EmitDefaultValue=false)]
		public bool? EnvironmentalAssessmentIndicator { get; set; }

		[DataMember(Name="floodHazardDeterminationDate", EmitDefaultValue=false)]
		public DateTime? FloodHazardDeterminationDate { get; set; }

		[DataMember(Name="floodHazardDeterminationIndicator", EmitDefaultValue=false)]
		public bool? FloodHazardDeterminationIndicator { get; set; }

		[DataMember(Name="futureAdvancePeriod", EmitDefaultValue=false)]
		public int? FutureAdvancePeriod { get; set; }

		[DataMember(Name="holdbackAmount", EmitDefaultValue=false)]
		public double? HoldbackAmount { get; set; }

		[DataMember(Name="holdbackPercent", EmitDefaultValue=false)]
		public double? HoldbackPercent { get; set; }

		[DataMember(Name="lienAgentNorthCarolinaDate", EmitDefaultValue=false)]
		public DateTime? LienAgentNorthCarolinaDate { get; set; }

		[DataMember(Name="lienAgentNorthCarolinaIndicator", EmitDefaultValue=false)]
		public bool? LienAgentNorthCarolinaIndicator { get; set; }

		[DataMember(Name="listOfConstructionAgreementsDate", EmitDefaultValue=false)]
		public DateTime? ListOfConstructionAgreementsDate { get; set; }

		[DataMember(Name="listOfConstructionAgreementsIndicator", EmitDefaultValue=false)]
		public bool? ListOfConstructionAgreementsIndicator { get; set; }

		[DataMember(Name="maxLTVPercent", EmitDefaultValue=false)]
		public double? MaxLTVPercent { get; set; }

		[DataMember(Name="minimumDaysBetweenDisbursements", EmitDefaultValue=false)]
		public int? MinimumDaysBetweenDisbursements { get; set; }

		[DataMember(Name="otherDate", EmitDefaultValue=false)]
		public DateTime? OtherDate { get; set; }

		[DataMember(Name="otherDescription", EmitDefaultValue=false)]
		public string OtherDescription { get; set; }

		[DataMember(Name="otherIndicator", EmitDefaultValue=false)]
		public bool? OtherIndicator { get; set; }

		[DataMember(Name="partialPrepaymentsElection", EmitDefaultValue=false)]
		public string PartialPrepaymentsElection { get; set; }

		[DataMember(Name="paymentAndPerformanceBondsDate", EmitDefaultValue=false)]
		public DateTime? PaymentAndPerformanceBondsDate { get; set; }

		[DataMember(Name="paymentAndPerformanceBondsIndicator", EmitDefaultValue=false)]
		public bool? PaymentAndPerformanceBondsIndicator { get; set; }

		[DataMember(Name="percolationTestDate", EmitDefaultValue=false)]
		public DateTime? PercolationTestDate { get; set; }

		[DataMember(Name="percolationTestIndicator", EmitDefaultValue=false)]
		public bool? PercolationTestIndicator { get; set; }

		[DataMember(Name="permitsDate", EmitDefaultValue=false)]
		public DateTime? PermitsDate { get; set; }

		[DataMember(Name="permitsIndicator", EmitDefaultValue=false)]
		public bool? PermitsIndicator { get; set; }

		[DataMember(Name="plansAndSpecificationsDate", EmitDefaultValue=false)]
		public DateTime? PlansAndSpecificationsDate { get; set; }

		[DataMember(Name="plansAndSpecificationsIndicator", EmitDefaultValue=false)]
		public bool? PlansAndSpecificationsIndicator { get; set; }

		[DataMember(Name="projectDelaySurchargePercent", EmitDefaultValue=false)]
		public double? ProjectDelaySurchargePercent { get; set; }

		[DataMember(Name="returnLendersCopyCommitmentDays", EmitDefaultValue=false)]
		public int? ReturnLendersCopyCommitmentDays { get; set; }

		[DataMember(Name="securedBySeparateProperty", EmitDefaultValue=false)]
		public bool? SecuredBySeparateProperty { get; set; }

		[DataMember(Name="soilReportDate", EmitDefaultValue=false)]
		public DateTime? SoilReportDate { get; set; }

		[DataMember(Name="soilReportIndicator", EmitDefaultValue=false)]
		public bool? SoilReportIndicator { get; set; }

		[DataMember(Name="surveyDate", EmitDefaultValue=false)]
		public DateTime? SurveyDate { get; set; }

		[DataMember(Name="surveyIndicator", EmitDefaultValue=false)]
		public bool? SurveyIndicator { get; set; }

		[DataMember(Name="takeOutCommitmentDate", EmitDefaultValue=false)]
		public DateTime? TakeOutCommitmentDate { get; set; }

		[DataMember(Name="takeOutCommitmentIndicator", EmitDefaultValue=false)]
		public bool? TakeOutCommitmentIndicator { get; set; }

		[DataMember(Name="takeOutCommitmentIssuedDate", EmitDefaultValue=false)]
		public DateTime? TakeOutCommitmentIssuedDate { get; set; }

		[DataMember(Name="takeOutLenderAddress", EmitDefaultValue=false)]
		public string TakeOutLenderAddress { get; set; }

		[DataMember(Name="takeOutLenderCity", EmitDefaultValue=false)]
		public string TakeOutLenderCity { get; set; }

		[DataMember(Name="takeOutLenderContactName", EmitDefaultValue=false)]
		public string TakeOutLenderContactName { get; set; }

		[DataMember(Name="takeOutLenderContactTitle", EmitDefaultValue=false)]
		public string TakeOutLenderContactTitle { get; set; }

		[DataMember(Name="takeOutLenderEmail", EmitDefaultValue=false)]
		public string TakeOutLenderEmail { get; set; }

		[DataMember(Name="takeOutLenderFax", EmitDefaultValue=false)]
		public string TakeOutLenderFax { get; set; }

		[DataMember(Name="takeOutLenderLicenseNumber", EmitDefaultValue=false)]
		public string TakeOutLenderLicenseNumber { get; set; }

		[DataMember(Name="takeOutLenderName", EmitDefaultValue=false)]
		public string TakeOutLenderName { get; set; }

		[DataMember(Name="takeOutLenderNMLSNumber", EmitDefaultValue=false)]
		public string TakeOutLenderNMLSNumber { get; set; }

		[DataMember(Name="takeOutLenderPhone", EmitDefaultValue=false)]
		public string TakeOutLenderPhone { get; set; }

		[DataMember(Name="takeOutLenderState", EmitDefaultValue=false)]
		public string TakeOutLenderState { get; set; }

		[DataMember(Name="takeOutLenderZip", EmitDefaultValue=false)]
		public string TakeOutLenderZip { get; set; }

		[DataMember(Name="titleInsuranceDate", EmitDefaultValue=false)]
		public DateTime? TitleInsuranceDate { get; set; }

		[DataMember(Name="titleInsuranceIndicator", EmitDefaultValue=false)]
		public bool? TitleInsuranceIndicator { get; set; }

		[DataMember(Name="utilityLettersDate", EmitDefaultValue=false)]
		public DateTime? UtilityLettersDate { get; set; }

		[DataMember(Name="utilityLettersIndicator", EmitDefaultValue=false)]
		public bool? UtilityLettersIndicator { get; set; }

		[DataMember(Name="waterTestDate", EmitDefaultValue=false)]
		public DateTime? WaterTestDate { get; set; }

		[DataMember(Name="waterTestIndicator", EmitDefaultValue=false)]
		public bool? WaterTestIndicator { get; set; }

	}
}