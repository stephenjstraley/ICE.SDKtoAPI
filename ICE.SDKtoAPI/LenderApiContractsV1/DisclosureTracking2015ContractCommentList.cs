using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractCommentList
	{
		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public EntityRefContract AddedBy { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="forRole", EmitDefaultValue=false)]
		public EntityRefContract ForRole { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isInternal", EmitDefaultValue=false)]
		public bool? IsInternal { get; set; }

		[DataMember(Name="reviewedBy", EmitDefaultValue=false)]
		public EntityRefContract ReviewedBy { get; set; }

		[DataMember(Name="reviewedDate", EmitDefaultValue=false)]
		public DateTime? ReviewedDate { get; set; }

	}
}