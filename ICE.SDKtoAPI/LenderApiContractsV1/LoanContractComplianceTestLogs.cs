using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractComplianceTestLogs
	{
		[DataMember(Name="details")]
		public string Details { get; set; }

		[DataMember(Name="name")]
		public string Name { get; set; }

		[DataMember(Name="result")]
		public string Result { get; set; }

		[DataMember(Name="showAlert")]
		public bool? ShowAlert { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}