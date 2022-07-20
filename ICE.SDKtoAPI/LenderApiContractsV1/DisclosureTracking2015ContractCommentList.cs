using System;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015ContractCommentList
	{
		[DataMember(Name="addedBy")]
		public EntityRefContract AddedBy { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="forRole")]
		public EntityRefContract ForRole { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isInternal")]
		public bool? IsInternal { get; set; }

		[DataMember(Name="reviewedBy")]
		public EntityRefContract ReviewedBy { get; set; }

		[DataMember(Name="reviewedDate")]
		public DateTime? ReviewedDate { get; set; }

	}
}