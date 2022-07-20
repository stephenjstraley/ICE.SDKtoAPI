using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateStatusContract
	{
		[DataMember(Name="lastModified")]
		public DateTime? LastModified { get; set; }

		[DataMember(Name="status")]
		public string Status { get; set; }

	}
}