using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneTemplateLogs
	{
		[DataMember(Name="elliLogRecordId", EmitDefaultValue=false)]
		public int? ElliLogRecordId { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isTemplateDatesLocked", EmitDefaultValue=false)]
		public bool? IsTemplateDatesLocked { get; set; }

		[DataMember(Name="isTemplateLocked", EmitDefaultValue=false)]
		public bool? IsTemplateLocked { get; set; }

		[DataMember(Name="milestoneTemplateID", EmitDefaultValue=false)]
		public string MilestoneTemplateID { get; set; }

		[DataMember(Name="milestoneTemplateName", EmitDefaultValue=false)]
		public string MilestoneTemplateName { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}