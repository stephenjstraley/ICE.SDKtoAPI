using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractComplianceTestLogs
	{
		[DataMember(Name="details", EmitDefaultValue=false)]
		public string Details { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="result", EmitDefaultValue=false)]
		public string Result { get; set; }

		[DataMember(Name="showAlert", EmitDefaultValue=false)]
		public bool? ShowAlert { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}