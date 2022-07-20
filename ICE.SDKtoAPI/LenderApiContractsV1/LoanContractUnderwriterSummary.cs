using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUnderwriterSummary
	{
		[DataMember(Name="appraisal")]
		public string Appraisal { get; set; }

		[DataMember(Name="appraisalCompletedDate")]
		public DateTime? AppraisalCompletedDate { get; set; }

		[DataMember(Name="appraisalExpiredDate")]
		public DateTime? AppraisalExpiredDate { get; set; }

		[DataMember(Name="appraisalOrderedDate")]
		public DateTime? AppraisalOrderedDate { get; set; }

		[DataMember(Name="appraisalType")]
		public string AppraisalType { get; set; }

		[DataMember(Name="approvalExpiredDate")]
		public DateTime? ApprovalExpiredDate { get; set; }

		[DataMember(Name="approvedBy")]
		public string ApprovedBy { get; set; }

		[DataMember(Name="approvedDate")]
		public DateTime? ApprovedDate { get; set; }

		[DataMember(Name="ausNumber")]
		public string AusNumber { get; set; }

		[DataMember(Name="ausRunDate")]
		public DateTime? AusRunDate { get; set; }

		[DataMember(Name="ausSource")]
		public string AusSource { get; set; }

		[DataMember(Name="benefitRequiredIndicator")]
		public bool? BenefitRequiredIndicator { get; set; }

		[DataMember(Name="clearToCloseDate")]
		public DateTime? ClearToCloseDate { get; set; }

		[DataMember(Name="concerns")]
		public string Concerns { get; set; }

		[DataMember(Name="conditions")]
		public string Conditions { get; set; }

		[DataMember(Name="counterOfferDate")]
		public DateTime? CounterOfferDate { get; set; }

		[DataMember(Name="counterOfferStatus")]
		public string CounterOfferStatus { get; set; }

		[DataMember(Name="credit")]
		public string Credit { get; set; }

		[DataMember(Name="creditApprovalDate")]
		public DateTime? CreditApprovalDate { get; set; }

		[DataMember(Name="deniedBy")]
		public string DeniedBy { get; set; }

		[DataMember(Name="deniedDate")]
		public DateTime? DeniedDate { get; set; }

		[DataMember(Name="differentApprovalExpiredDate")]
		public DateTime? DifferentApprovalExpiredDate { get; set; }

		[DataMember(Name="differentApprovedBy")]
		public string DifferentApprovedBy { get; set; }

		[DataMember(Name="differentApprovedDate")]
		public DateTime? DifferentApprovedDate { get; set; }

		[DataMember(Name="exceptions")]
		public string Exceptions { get; set; }

		[DataMember(Name="exceptionSignOffBy")]
		public string ExceptionSignOffBy { get; set; }

		[DataMember(Name="exceptionSignOffDate")]
		public DateTime? ExceptionSignOffDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isAgencyManually")]
		public bool? IsAgencyManually { get; set; }

		[DataMember(Name="isAgencyWaiver")]
		public bool? IsAgencyWaiver { get; set; }

		[DataMember(Name="isAgencyWithAgreement")]
		public bool? IsAgencyWithAgreement { get; set; }

		[DataMember(Name="maxRate")]
		public decimal? MaxRate { get; set; }

		[DataMember(Name="miOrderedDate")]
		public DateTime? MiOrderedDate { get; set; }

		[DataMember(Name="miReceivedDate")]
		public DateTime? MiReceivedDate { get; set; }

		[DataMember(Name="modifiedLoanAmount")]
		public decimal? ModifiedLoanAmount { get; set; }

		[DataMember(Name="modifiedLoanRate")]
		public decimal? ModifiedLoanRate { get; set; }

		[DataMember(Name="modifiedLoanTerm")]
		public int? ModifiedLoanTerm { get; set; }

		[DataMember(Name="modifiedLtv")]
		public decimal? ModifiedLtv { get; set; }

		[DataMember(Name="modifiedMonthlyPayment")]
		public decimal? ModifiedMonthlyPayment { get; set; }

		[DataMember(Name="originalAppraiser")]
		public string OriginalAppraiser { get; set; }

		[DataMember(Name="originalAppraisersValue")]
		public decimal? OriginalAppraisersValue { get; set; }

		[DataMember(Name="resubmittedDate")]
		public DateTime? ResubmittedDate { get; set; }

		[DataMember(Name="reviewAppraiser")]
		public string ReviewAppraiser { get; set; }

		[DataMember(Name="reviewCompletedDate")]
		public DateTime? ReviewCompletedDate { get; set; }

		[DataMember(Name="reviewRequestedDate")]
		public DateTime? ReviewRequestedDate { get; set; }

		[DataMember(Name="reviewType")]
		public string ReviewType { get; set; }

		[DataMember(Name="reviewValue")]
		public decimal? ReviewValue { get; set; }

		[DataMember(Name="sentToDate")]
		public DateTime? SentToDate { get; set; }

		[DataMember(Name="signOffBy")]
		public string SignOffBy { get; set; }

		[DataMember(Name="signOffDate")]
		public DateTime? SignOffDate { get; set; }

		[DataMember(Name="strengths")]
		public string Strengths { get; set; }

		[DataMember(Name="submittedDate")]
		public DateTime? SubmittedDate { get; set; }

		[DataMember(Name="supervisoryAppraiserLicenseNumber")]
		public string SupervisoryAppraiserLicenseNumber { get; set; }

		[DataMember(Name="suspendedBy")]
		public string SuspendedBy { get; set; }

		[DataMember(Name="suspendedDate")]
		public DateTime? SuspendedDate { get; set; }

		[DataMember(Name="suspendedReasons")]
		public string SuspendedReasons { get; set; }

	}
}