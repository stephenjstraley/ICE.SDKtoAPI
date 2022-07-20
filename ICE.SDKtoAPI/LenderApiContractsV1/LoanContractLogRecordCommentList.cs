using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLogRecordCommentList
	{
		[DataMember(Name="addedBy")]
		public string AddedBy { get; set; }

		[DataMember(Name="addedByName")]
		public string AddedByName { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="forRoleId")]
		public int? ForRoleId { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="isInternal")]
		public bool? IsInternal { get; set; }

		[DataMember(Name="reviewedBy")]
		public string ReviewedBy { get; set; }

		[DataMember(Name="reviewedDate")]
		public DateTime? ReviewedDate { get; set; }

	}
}