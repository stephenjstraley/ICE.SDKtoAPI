using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class MilestoneContract
	{
		[DataMember(Name="actualDays ")]
		public int? ActualDays { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="doneIndicator")]
		public bool? DoneIndicator { get; set; }

		[DataMember(Name="expectedDays")]
		public int? ExpectedDays { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanAssociate")]
		public MilestoneContractLoanAssociate LoanAssociate { get; set; }

		[DataMember(Name="milestoneIdString")]
		public string MilestoneIdString { get; set; }

		[DataMember(Name="milestoneName")]
		public string MilestoneName { get; set; }

		[DataMember(Name="reviewedIndicator")]
		public bool? ReviewedIndicator { get; set; }

		[DataMember(Name="roleRequired")]
		public bool? RoleRequired { get; set; }

		[DataMember(Name="startDate")]
		public string StartDate { get; set; }

	}
}