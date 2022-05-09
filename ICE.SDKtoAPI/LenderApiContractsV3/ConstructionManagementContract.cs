using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ConstructionManagementContract
    {
        [DataMember(Name = "securedBySeparateProperty")]
        public bool? SecuredBySeparateProperty { get; set; }

        [DataMember(Name = "constCompletionDate")]
        public string ConstCompletionDate { get; set; }

        [DataMember(Name = "maxLtvPercent")]
        public decimal? MaxLtvPercent { get; set; }

        [DataMember(Name = "holdbackPercent")]
        public decimal? HoldbackPercent { get; set; }

        [DataMember(Name = "holdbackAmount")]
        public decimal? HoldbackAmount { get; set; }

        [DataMember(Name = "projectDelaySurchargePercent")]
        public decimal? ProjectDelaySurchargePercent { get; set; }

        [DataMember(Name = "constructionContractIssuedDate")]
        public string ConstructionContractIssuedDate { get; set; }

        [DataMember(Name = "constructionContractReceivedDate")]
        public string ConstructionContractReceivedDate { get; set; }

        [DataMember(Name = "commitmentLetterDate")]
        public string CommitmentLetterDate { get; set; }

        [DataMember(Name = "commitmentExpirationDate")]
        public string CommitmentExpirationDate { get; set; }

        [DataMember(Name = "returnLendersCopyCommitmentDays")]
        public int? ReturnLendersCopyCommitmentDays { get; set; }

        [DataMember(Name = "takeOutCommitmentIndicator")]
        public bool? TakeOutCommitmentIndicator { get; set; }

        [DataMember(Name = "takeOutCommitmentDate")]
        public string TakeOutCommitmentDate { get; set; }

        [DataMember(Name = "titleInsuranceIndicator")]
        public bool? TitleInsuranceIndicator { get; set; }

        [DataMember(Name = "titleInsuranceDate")]
        public string TitleInsuranceDate { get; set; }

        [DataMember(Name = "surveyIndicator")]
        public bool? SurveyIndicator { get; set; }

        [DataMember(Name = "surveyDate")]
        public string SurveyDate { get; set; }

        [DataMember(Name = "permitsIndicator")]
        public bool? PermitsIndicator { get; set; }

        [DataMember(Name = "permitsDate")]
        public string PermitsDate { get; set; }

        [DataMember(Name = "utilityLettersIndicator")]
        public bool? UtilityLettersIndicator { get; set; }

        [DataMember(Name = "utilityLettersDate")]
        public string UtilityLettersDate { get; set; }

        [DataMember(Name = "plansAndSpecificationsIndicator")]
        public bool? PlansAndSpecificationsIndicator { get; set; }

        [DataMember(Name = "plansAndSpecificationsDate")]
        public string PlansAndSpecificationsDate { get; set; }

        [DataMember(Name = "constructionContractIndicator")]
        public bool? ConstructionContractIndicator { get; set; }

        [DataMember(Name = "budgetIndicator")]
        public bool? BudgetIndicator { get; set; }

        [DataMember(Name = "budgetDate")]
        public string BudgetDate { get; set; }

        [DataMember(Name = "constOnlyAmortizationType")]
        public string ConstOnlyAmortizationType { get; set; }

        [DataMember(Name = "contractorsAgreementIndicator")]
        public bool? ContractorsAgreementIndicator { get; set; }

        [DataMember(Name = "contractorsAgreementDate")]
        public string ContractorsAgreementDate { get; set; }

        [DataMember(Name = "architectsCertificateIndicator")]
        public bool? ArchitectsCertificateIndicator { get; set; }

        [DataMember(Name = "architectsCertificateDate")]
        public string ArchitectsCertificateDate { get; set; }

        [DataMember(Name = "environmentalAssessmentIndicator")]
        public bool? EnvironmentalAssessmentIndicator { get; set; }

        [DataMember(Name = "environmentalAssessmentDate")]
        public string EnvironmentalAssessmentDate { get; set; }

        [DataMember(Name = "soilReportIndicator")]
        public bool? SoilReportIndicator { get; set; }

        [DataMember(Name = "soilReportDate")]
        public string SoilReportDate { get; set; }

        [DataMember(Name = "waterTestIndicator")]
        public bool? WaterTestIndicator { get; set; }

        [DataMember(Name = "waterTestDate")]
        public string WaterTestDate { get; set; }

        [DataMember(Name = "percolationTestIndicator")]
        public bool? PercolationTestIndicator { get; set; }

        [DataMember(Name = "percolationTestDate")]
        public string PercolationTestDate { get; set; }

        [DataMember(Name = "paymentAndPerformanceBondsIndicator")]
        public bool? PaymentAndPerformanceBondsIndicator { get; set; }

        [DataMember(Name = "paymentAndPerformanceBondsDate")]
        public string PaymentAndPerformanceBondsDate { get; set; }

        [DataMember(Name = "lienAgentNorthCarolinaIndicator")]
        public bool? LienAgentNorthCarolinaIndicator { get; set; }

        [DataMember(Name = "lienAgentNorthCarolinaDate")]
        public string LienAgentNorthCarolinaDate { get; set; }

        [DataMember(Name = "floodHazardDeterminationIndicator")]
        public bool? FloodHazardDeterminationIndicator { get; set; }

        [DataMember(Name = "floodHazardDeterminationDate")]
        public string FloodHazardDeterminationDate { get; set; }

        [DataMember(Name = "listOfConstructionAgreementsIndicator")]
        public bool? ListOfConstructionAgreementsIndicator { get; set; }

        [DataMember(Name = "listOfConstructionAgreementsDate")]
        public string ListOfConstructionAgreementsDate { get; set; }

        [DataMember(Name = "otherIndicator")]
        public bool? OtherIndicator { get; set; }

        [DataMember(Name = "otherDate")]
        public string OtherDate { get; set; }

        [DataMember(Name = "otherDescription")]
        public string OtherDescription { get; set; }

        [DataMember(Name = "futureAdvancePeriod")]
        public int? FutureAdvancePeriod { get; set; }

        [DataMember(Name = "minimumDaysBetweenDisbursements")]
        public int? MinimumDaysBetweenDisbursements { get; set; }

        [DataMember(Name = "additionalDisbursementsConditions")]
        public string AdditionalDisbursementsConditions { get; set; }

        [DataMember(Name = "constructionPeriodIncludedInLoanTermFlag")]
        public bool? ConstructionPeriodIncludedInLoanTermFlag { get; set; }

        [DataMember(Name = "partialPrepaymentsElection")]
        public string PartialPrepaymentsElection { get; set; }

        [DataMember(Name = "asCompletedPurchasePrice")]
        public decimal? AsCompletedPurchasePrice { get; set; }

        [DataMember(Name = "asCompletedAppraisedValue")]
        public decimal? AsCompletedAppraisedValue { get; set; }

        [DataMember(Name = "takeOutLenderName")]
        public string TakeOutLenderName { get; set; }

        [DataMember(Name = "takeOutLenderNmlsNumber")]
        public string TakeOutLenderNmlsNumber { get; set; }

        [DataMember(Name = "takeOutLenderLicenseNumber")]
        public string TakeOutLenderLicenseNumber { get; set; }

        [DataMember(Name = "takeOutLenderAddress")]
        public string TakeOutLenderAddress { get; set; }

        [DataMember(Name = "takeOutLenderCity")]
        public string TakeOutLenderCity { get; set; }

        [DataMember(Name = "takeOutLenderState")]
        public string TakeOutLenderState { get; set; }

        [DataMember(Name = "takeOutLenderZip")]
        public string TakeOutLenderZip { get; set; }

        [DataMember(Name = "takeOutCommitmentIssuedDate")]
        public string TakeOutCommitmentIssuedDate { get; set; }

        [DataMember(Name = "takeOutLenderContactName")]
        public string TakeOutLenderContactName { get; set; }

        [DataMember(Name = "takeOutLenderContactTitle")]
        public string TakeOutLenderContactTitle { get; set; }

        [DataMember(Name = "takeOutLenderPhone")]
        public string TakeOutLenderPhone { get; set; }

        [DataMember(Name = "takeOutLenderFax")]
        public string TakeOutLenderFax { get; set; }

        [DataMember(Name = "takeOutLenderEmail")]
        public string TakeOutLenderEmail { get; set; }

        [DataMember(Name = "costImprovementsIncluded")]
        public bool? CostImprovementsIncluded { get; set; }
    }
}
