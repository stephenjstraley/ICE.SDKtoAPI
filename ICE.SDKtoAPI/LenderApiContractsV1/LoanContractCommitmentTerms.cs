using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractCommitmentTerms
	{
		[DataMember(Name="actionDate", EmitDefaultValue=false)]
		public DateTime? ActionDate { get; set; }

		[DataMember(Name="additionalConditions", EmitDefaultValue=false)]
		public string AdditionalConditions { get; set; }

		[DataMember(Name="additionalItems1", EmitDefaultValue=false)]
		public string AdditionalItems1 { get; set; }

		[DataMember(Name="additionalItems2", EmitDefaultValue=false)]
		public string AdditionalItems2 { get; set; }

		[DataMember(Name="additionalItems3", EmitDefaultValue=false)]
		public string AdditionalItems3 { get; set; }

		[DataMember(Name="appraisalDone", EmitDefaultValue=false)]
		public bool? AppraisalDone { get; set; }

		[DataMember(Name="assuranceOfCompletion", EmitDefaultValue=false)]
		public double? AssuranceOfCompletion { get; set; }

		[DataMember(Name="commitmentDate", EmitDefaultValue=false)]
		public DateTime? CommitmentDate { get; set; }

		[DataMember(Name="commitmentExpired", EmitDefaultValue=false)]
		public DateTime? CommitmentExpired { get; set; }

		[DataMember(Name="commitmentIssued", EmitDefaultValue=false)]
		public DateTime? CommitmentIssued { get; set; }

		[DataMember(Name="conditionalCommitmentUnderActg", EmitDefaultValue=false)]
		public bool? ConditionalCommitmentUnderActg { get; set; }

		[DataMember(Name="eligibleForHighLtv", EmitDefaultValue=false)]
		public bool? EligibleForHighLtv { get; set; }

		[DataMember(Name="estimatedRemainingYears", EmitDefaultValue=false)]
		public int? EstimatedRemainingYears { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="improvedLivingAreas", EmitDefaultValue=false)]
		public string ImprovedLivingAreas { get; set; }

		[DataMember(Name="manufacturedHousing", EmitDefaultValue=false)]
		public bool? ManufacturedHousing { get; set; }

		[DataMember(Name="maxInsurableMortgage", EmitDefaultValue=false)]
		public double? MaxInsurableMortgage { get; set; }

		[DataMember(Name="mortgageeAddress", EmitDefaultValue=false)]
		public string MortgageeAddress { get; set; }

		[DataMember(Name="mortgageeCity", EmitDefaultValue=false)]
		public string MortgageeCity { get; set; }

		[DataMember(Name="mortgageeName", EmitDefaultValue=false)]
		public string MortgageeName { get; set; }

		[DataMember(Name="mortgageePostalCode", EmitDefaultValue=false)]
		public string MortgageePostalCode { get; set; }

		[DataMember(Name="mortgageeState", EmitDefaultValue=false)]
		public string MortgageeState { get; set; }

		[DataMember(Name="otherMonthlyExpenseDescription", EmitDefaultValue=false)]
		public string OtherMonthlyExpenseDescription { get; set; }

		[DataMember(Name="reportDate", EmitDefaultValue=false)]
		public DateTime? ReportDate { get; set; }

		[DataMember(Name="requirementsNumber", EmitDefaultValue=false)]
		public string RequirementsNumber { get; set; }

		[DataMember(Name="subdivisionDescription", EmitDefaultValue=false)]
		public string SubdivisionDescription { get; set; }

		[DataMember(Name="subdivisionRequirements", EmitDefaultValue=false)]
		public string SubdivisionRequirements { get; set; }

		[DataMember(Name="totalMonthlyExpense", EmitDefaultValue=false)]
		public double? TotalMonthlyExpense { get; set; }

	}
}