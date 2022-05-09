using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateStatusContract
	{
		[DataMember(Name="lastModified", EmitDefaultValue=false)]
		public DateTime? LastModified { get; set; }

		[DataMember(Name="status", EmitDefaultValue=false)]
		public string Status { get; set; }

	}
}