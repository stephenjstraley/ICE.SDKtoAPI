using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanMetadataContract
	{
		[DataMember(Name="createdDate")]
		public string CreatedDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="loanFolder")]
		public string LoanFolder { get; set; }

		[DataMember(Name="loanName")]
		public string LoanName { get; set; }

		[DataMember(Name="modifiedDate")]
		public string ModifiedDate { get; set; }

		[DataMember(Name="size")]
		public int? Size { get; set; }

	}
}