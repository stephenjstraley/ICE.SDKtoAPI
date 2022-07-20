using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCommitmentTerms
	{
		[DataMember(Name="actionDate")]
		public DateTime? ActionDate { get; set; }

		[DataMember(Name="additionalConditions")]
		public string AdditionalConditions { get; set; }

		[DataMember(Name="additionalItems1")]
		public string AdditionalItems1 { get; set; }

		[DataMember(Name="additionalItems2")]
		public string AdditionalItems2 { get; set; }

		[DataMember(Name="additionalItems3")]
		public string AdditionalItems3 { get; set; }

		[DataMember(Name="appraisalDone")]
		public bool? AppraisalDone { get; set; }

		[DataMember(Name="assuranceOfCompletion")]
		public decimal? AssuranceOfCompletion { get; set; }

		[DataMember(Name="commitmentDate")]
		public DateTime? CommitmentDate { get; set; }

		[DataMember(Name="commitmentExpired")]
		public DateTime? CommitmentExpired { get; set; }

		[DataMember(Name="commitmentIssued")]
		public DateTime? CommitmentIssued { get; set; }

		[DataMember(Name="conditionalCommitmentUnderActg")]
		public bool? ConditionalCommitmentUnderActg { get; set; }

		[DataMember(Name="eligibleForHighLtv")]
		public bool? EligibleForHighLtv { get; set; }

		[DataMember(Name="estimatedRemainingYears")]
		public int? EstimatedRemainingYears { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="improvedLivingAreas")]
		public string ImprovedLivingAreas { get; set; }

		[DataMember(Name="manufacturedHousing")]
		public bool? ManufacturedHousing { get; set; }

		[DataMember(Name="maxInsurableMortgage")]
		public decimal? MaxInsurableMortgage { get; set; }

		[DataMember(Name="mortgageeAddress")]
		public string MortgageeAddress { get; set; }

		[DataMember(Name="mortgageeCity")]
		public string MortgageeCity { get; set; }

		[DataMember(Name="mortgageeName")]
		public string MortgageeName { get; set; }

		[DataMember(Name="mortgageePostalCode")]
		public string MortgageePostalCode { get; set; }

		[DataMember(Name="mortgageeState")]
		public string MortgageeState { get; set; }

		[DataMember(Name="otherMonthlyExpenseDescription")]
		public string OtherMonthlyExpenseDescription { get; set; }

		[DataMember(Name="reportDate")]
		public DateTime? ReportDate { get; set; }

		[DataMember(Name="requirementsNumber")]
		public string RequirementsNumber { get; set; }

		[DataMember(Name="subdivisionDescription")]
		public string SubdivisionDescription { get; set; }

		[DataMember(Name="subdivisionRequirements")]
		public string SubdivisionRequirements { get; set; }

		[DataMember(Name="totalMonthlyExpense")]
		public decimal? TotalMonthlyExpense { get; set; }

	}
}