using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class UnderwriterSummaryContract
    {
        [DataMember(Name = "appraisal")]
        public string Appraisal { get; set; }

        [DataMember(Name = "appraisalCompletedDate")]
        public string AppraisalCompletedDate { get; set; }

        [DataMember(Name = "appraisalExpiredDate")]
        public string AppraisalExpiredDate { get; set; }

        [DataMember(Name = "appraisalOrderedDate")]
        public string AppraisalOrderedDate { get; set; }

        [DataMember(Name = "appraisalType")]
        public string AppraisalType { get; set; }

        [DataMember(Name = "approvalExpiredDate")]
        public string ApprovalExpiredDate { get; set; }

        [DataMember(Name = "approvedBy")]
        public string ApprovedBy { get; set; }

        [DataMember(Name = "approvedDate")]
        public string ApprovedDate { get; set; }

        [DataMember(Name = "ausNumber")]
        public string AusNumber { get; set; }

        [DataMember(Name = "ausRunDate")]
        public string AusRunDate { get; set; }

        [DataMember(Name = "ausSource")]
        public string AusSource { get; set; }

        [DataMember(Name = "benefitRequiredIndicator")]
        public bool? BenefitRequiredIndicator { get; set; }

        [DataMember(Name = "clearToCloseDate")]
        public string ClearToCloseDate { get; set; }

        [DataMember(Name = "concerns")]
        public string Concerns { get; set; }

        [DataMember(Name = "conditions")]
        public string Conditions { get; set; }

        [DataMember(Name = "credit")]
        public string Credit { get; set; }

        [DataMember(Name = "creditApprovalDate")]
        public string CreditApprovalDate { get; set; }

        [DataMember(Name = "deniedBy")]
        public string DeniedBy { get; set; }

        [DataMember(Name = "deniedDate")]
        public string DeniedDate { get; set; }

        [DataMember(Name = "differentApprovalExpiredDate")]
        public string DifferentApprovalExpiredDate { get; set; }

        [DataMember(Name = "differentApprovedBy")]
        public string DifferentApprovedBy { get; set; }

        [DataMember(Name = "differentApprovedDate")]
        public string DifferentApprovedDate { get; set; }

        [DataMember(Name = "exceptions")]
        public string Exceptions { get; set; }

        [DataMember(Name = "exceptionSignOffBy")]
        public string ExceptionSignOffBy { get; set; }

        [DataMember(Name = "exceptionSignOffDate")]
        public string ExceptionSignOffDate { get; set; }

        [DataMember(Name = "maxRate")]
        public decimal? MaxRate { get; set; }

        [DataMember(Name = "miOrderedDate")]
        public string MiOrderedDate { get; set; }

        [DataMember(Name = "miReceivedDate")]
        public string MiReceivedDate { get; set; }

        [DataMember(Name = "modifiedLoanAmount")]
        public decimal? ModifiedLoanAmount { get; set; }

        [DataMember(Name = "modifiedLoanRate")]
        public decimal? ModifiedLoanRate { get; set; }

        [DataMember(Name = "modifiedLoanTerm")]
        public int? ModifiedLoanTerm { get; set; }

        [DataMember(Name = "modifiedLtv")]
        public decimal? ModifiedLtv { get; set; }

        [DataMember(Name = "modifiedMonthlyPayment")]
        public decimal? ModifiedMonthlyPayment { get; set; }

        [DataMember(Name = "originalAppraiser")]
        public string OriginalAppraiser { get; set; }

        [DataMember(Name = "originalAppraisersValue")]
        public decimal? OriginalAppraisersValue { get; set; }

        [DataMember(Name = "resubmittedDate")]
        public string ResubmittedDate { get; set; }

        [DataMember(Name = "reviewAppraiser")]
        public string ReviewAppraiser { get; set; }

        [DataMember(Name = "reviewCompletedDate")]
        public string ReviewCompletedDate { get; set; }

        [DataMember(Name = "reviewRequestedDate")]
        public string ReviewRequestedDate { get; set; }

        [DataMember(Name = "reviewType")]
        public string ReviewType { get; set; }

        [DataMember(Name = "reviewValue")]
        public decimal? ReviewValue { get; set; }

        [DataMember(Name = "sentToDate")]
        public string SentToDate { get; set; }

        [DataMember(Name = "signOffBy")]
        public string SignOffBy { get; set; }

        [DataMember(Name = "signOffDate")]
        public string SignOffDate { get; set; }

        [DataMember(Name = "strengths")]
        public string Strengths { get; set; }

        [DataMember(Name = "submittedDate")]
        public string SubmittedDate { get; set; }

        [DataMember(Name = "supervisoryAppraiserLicenseNumber")]
        public string SupervisoryAppraiserLicenseNumber { get; set; }

        [DataMember(Name = "suspendedBy")]
        public string SuspendedBy { get; set; }

        [DataMember(Name = "suspendedDate")]
        public string SuspendedDate { get; set; }

        [DataMember(Name = "suspendedReasons")]
        public string SuspendedReasons { get; set; }

        [DataMember(Name = "isAgencyWithAgreement")]
        public bool? IsAgencyWithAgreement { get; set; }

        [DataMember(Name = "isAgencyWaiver")]
        public bool? IsAgencyWaiver { get; set; }

        [DataMember(Name = "isAgencyManually")]
        public bool? IsAgencyManually { get; set; }

        [DataMember(Name = "counterOfferDate")]
        public string CounterOfferDate { get; set; }

        [DataMember(Name = "counterOfferStatus")]
        public string CounterOfferStatus { get; set; }

    }
}
