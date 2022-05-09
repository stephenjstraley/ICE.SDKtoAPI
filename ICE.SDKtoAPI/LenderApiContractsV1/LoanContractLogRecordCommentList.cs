using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractLogRecordCommentList
	{
		[DataMember(Name="addedBy", EmitDefaultValue=false)]
		public string AddedBy { get; set; }

		[DataMember(Name="addedByName", EmitDefaultValue=false)]
		public string AddedByName { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="forRoleId", EmitDefaultValue=false)]
		public int? ForRoleId { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="isInternal", EmitDefaultValue=false)]
		public bool? IsInternal { get; set; }

		[DataMember(Name="reviewedBy", EmitDefaultValue=false)]
		public string ReviewedBy { get; set; }

		[DataMember(Name="reviewedDate", EmitDefaultValue=false)]
		public DateTime? ReviewedDate { get; set; }

	}
}