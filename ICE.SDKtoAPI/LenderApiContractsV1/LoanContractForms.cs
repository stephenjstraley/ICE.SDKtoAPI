using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractForms
	{
		[DataMember(Name="formName", EmitDefaultValue=false)]
		public string FormName { get; set; }

		[DataMember(Name="formType", EmitDefaultValue=false)]
		public string FormType { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

	}
}