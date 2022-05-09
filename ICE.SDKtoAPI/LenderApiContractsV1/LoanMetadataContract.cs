using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanMetadataContract
	{
		[DataMember(Name="createdDate", EmitDefaultValue=false)]
		public string CreatedDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="loanFolder", EmitDefaultValue=false)]
		public string LoanFolder { get; set; }

		[DataMember(Name="loanName", EmitDefaultValue=false)]
		public string LoanName { get; set; }

		[DataMember(Name="modifiedDate", EmitDefaultValue=false)]
		public string ModifiedDate { get; set; }

		[DataMember(Name="size", EmitDefaultValue=false)]
		public int? Size { get; set; }

	}
}