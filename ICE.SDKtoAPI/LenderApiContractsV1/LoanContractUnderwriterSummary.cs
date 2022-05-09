using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractUnderwriterSummary
	{
		[DataMember(Name="appraisal", EmitDefaultValue=false)]
		public string Appraisal { get; set; }

		[DataMember(Name="appraisalCompletedDate", EmitDefaultValue=false)]
		public DateTime? AppraisalCompletedDate { get; set; }

		[DataMember(Name="appraisalExpiredDate", EmitDefaultValue=false)]
		public DateTime? AppraisalExpiredDate { get; set; }

		[DataMember(Name="appraisalOrderedDate", EmitDefaultValue=false)]
		public DateTime? AppraisalOrderedDate { get; set; }

		[DataMember(Name="appraisalType", EmitDefaultValue=false)]
		public string AppraisalType { get; set; }

		[DataMember(Name="approvalExpiredDate", EmitDefaultValue=false)]
		public DateTime? ApprovalExpiredDate { get; set; }

		[DataMember(Name="approvedBy", EmitDefaultValue=false)]
		public string ApprovedBy { get; set; }

		[DataMember(Name="approvedDate", EmitDefaultValue=false)]
		public DateTime? ApprovedDate { get; set; }

		[DataMember(Name="ausNumber", EmitDefaultValue=false)]
		public string AusNumber { get; set; }

		[DataMember(Name="ausRunDate", EmitDefaultValue=false)]
		public DateTime? AusRunDate { get; set; }

		[DataMember(Name="ausSource", EmitDefaultValue=false)]
		public string AusSource { get; set; }

		[DataMember(Name="benefitRequiredIndicator", EmitDefaultValue=false)]
		public bool? BenefitRequiredIndicator { get; set; }

		[DataMember(Name="clearToCloseDate", EmitDefaultValue=false)]
		public DateTime? ClearToCloseDate { get; set; }

		[DataMember(Name="concerns", EmitDefaultValue=false)]
		public string Concerns { get; set; }

		[DataMember(Name="conditions", EmitDefaultValue=false)]
		public string Conditions { get; set; }

		[DataMember(Name="counterOfferDate", EmitDefaultValue=false)]
		public DateTime? CounterOfferDate { get; set; }

		[DataMember(Name="counterOfferStatus", EmitDefaultValue=false)]
		public string CounterOfferStatus { get; set; }

		[DataMember(Name="credit", EmitDefaultValue=false)]
		public string Credit { get; set; }

		[DataMember(Name="creditApprovalDate", EmitDefaultValue=false)]
		public DateTime? CreditApprovalDate { get; set; }

		[DataMember(Name="deniedBy", EmitDefaultValue=false)]
		public string DeniedBy { get; set; }

		[DataMember(Name="deniedDate", EmitDefaultValue=false)]
		public DateTime? DeniedDate { get; set; }

		[DataMember(Name="differentApprovalExpiredDate", EmitDefaultValue=false)]
		public DateTime? DifferentApprovalExpiredDate { get; set; }

		[DataMember(Name="differentApprovedBy", EmitDefaultValue=false)]
		public string DifferentApprovedBy { get; set; }

		[DataMember(Name="differentApprovedDate", EmitDefaultValue=false)]
		public DateTime? DifferentApprovedDate { get; set; }

		[DataMember(Name="exceptions", EmitDefaultValue=false)]
		public string Exceptions { get; set; }

		[DataMember(Name="exceptionSignOffBy", EmitDefaultValue=false)]
		public string ExceptionSignOffBy { get; set; }

		[DataMember(Name="exceptionSignOffDate", EmitDefaultValue=false)]
		public DateTime? ExceptionSignOffDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isAgencyManually", EmitDefaultValue=false)]
		public bool? IsAgencyManually { get; set; }

		[DataMember(Name="isAgencyWaiver", EmitDefaultValue=false)]
		public bool? IsAgencyWaiver { get; set; }

		[DataMember(Name="isAgencyWithAgreement", EmitDefaultValue=false)]
		public bool? IsAgencyWithAgreement { get; set; }

		[DataMember(Name="maxRate", EmitDefaultValue=false)]
		public double? MaxRate { get; set; }

		[DataMember(Name="miOrderedDate", EmitDefaultValue=false)]
		public DateTime? MiOrderedDate { get; set; }

		[DataMember(Name="miReceivedDate", EmitDefaultValue=false)]
		public DateTime? MiReceivedDate { get; set; }

		[DataMember(Name="modifiedLoanAmount", EmitDefaultValue=false)]
		public double? ModifiedLoanAmount { get; set; }

		[DataMember(Name="modifiedLoanRate", EmitDefaultValue=false)]
		public double? ModifiedLoanRate { get; set; }

		[DataMember(Name="modifiedLoanTerm", EmitDefaultValue=false)]
		public int? ModifiedLoanTerm { get; set; }

		[DataMember(Name="modifiedLtv", EmitDefaultValue=false)]
		public double? ModifiedLtv { get; set; }

		[DataMember(Name="modifiedMonthlyPayment", EmitDefaultValue=false)]
		public double? ModifiedMonthlyPayment { get; set; }

		[DataMember(Name="originalAppraiser", EmitDefaultValue=false)]
		public string OriginalAppraiser { get; set; }

		[DataMember(Name="originalAppraisersValue", EmitDefaultValue=false)]
		public double? OriginalAppraisersValue { get; set; }

		[DataMember(Name="resubmittedDate", EmitDefaultValue=false)]
		public DateTime? ResubmittedDate { get; set; }

		[DataMember(Name="reviewAppraiser", EmitDefaultValue=false)]
		public string ReviewAppraiser { get; set; }

		[DataMember(Name="reviewCompletedDate", EmitDefaultValue=false)]
		public DateTime? ReviewCompletedDate { get; set; }

		[DataMember(Name="reviewRequestedDate", EmitDefaultValue=false)]
		public DateTime? ReviewRequestedDate { get; set; }

		[DataMember(Name="reviewType", EmitDefaultValue=false)]
		public string ReviewType { get; set; }

		[DataMember(Name="reviewValue", EmitDefaultValue=false)]
		public double? ReviewValue { get; set; }

		[DataMember(Name="sentToDate", EmitDefaultValue=false)]
		public DateTime? SentToDate { get; set; }

		[DataMember(Name="signOffBy", EmitDefaultValue=false)]
		public string SignOffBy { get; set; }

		[DataMember(Name="signOffDate", EmitDefaultValue=false)]
		public DateTime? SignOffDate { get; set; }

		[DataMember(Name="strengths", EmitDefaultValue=false)]
		public string Strengths { get; set; }

		[DataMember(Name="submittedDate", EmitDefaultValue=false)]
		public DateTime? SubmittedDate { get; set; }

		[DataMember(Name="supervisoryAppraiserLicenseNumber", EmitDefaultValue=false)]
		public string SupervisoryAppraiserLicenseNumber { get; set; }

		[DataMember(Name="suspendedBy", EmitDefaultValue=false)]
		public string SuspendedBy { get; set; }

		[DataMember(Name="suspendedDate", EmitDefaultValue=false)]
		public DateTime? SuspendedDate { get; set; }

		[DataMember(Name="suspendedReasons", EmitDefaultValue=false)]
		public string SuspendedReasons { get; set; }

	}
}