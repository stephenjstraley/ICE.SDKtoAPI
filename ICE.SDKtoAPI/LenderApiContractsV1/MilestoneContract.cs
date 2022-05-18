using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class MilestoneContract
	{
		[DataMember(Name="actualDays ", EmitDefaultValue=false)]
		public int? ActualDays { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="doneIndicator", EmitDefaultValue=false)]
		public bool? DoneIndicator { get; set; }

		[DataMember(Name="expectedDays", EmitDefaultValue=false)]
		public int? ExpectedDays { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanAssociate", EmitDefaultValue=false)]
		public MilestoneContractLoanAssociate LoanAssociate { get; set; }

		[DataMember(Name="milestoneIdString", EmitDefaultValue=false)]
		public string MilestoneIdString { get; set; }

		[DataMember(Name="milestoneName", EmitDefaultValue=false)]
		public string MilestoneName { get; set; }

		[DataMember(Name="reviewedIndicator", EmitDefaultValue=false)]
		public bool? ReviewedIndicator { get; set; }

		[DataMember(Name="roleRequired", EmitDefaultValue=false)]
		public bool? RoleRequired { get; set; }

		[DataMember(Name="startDate", EmitDefaultValue=false)]
		public string StartDate { get; set; }

	}
}