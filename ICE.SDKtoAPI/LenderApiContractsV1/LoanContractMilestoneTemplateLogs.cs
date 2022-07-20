using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractMilestoneTemplateLogs
	{
		[DataMember(Name="elliLogRecordId")]
		public int? ElliLogRecordId { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name = "isTemplateDatesLocked")]
		public bool? IsTemplateDatesLocked { get; set; } = false;

		[DataMember(Name = "isTemplateLocked")]
		public bool? IsTemplateLocked { get; set; } = false;

		[DataMember(Name="milestoneTemplateID")]
		public string MilestoneTemplateID { get; set; }

		[DataMember(Name="milestoneTemplateName")]
		public string MilestoneTemplateName { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}