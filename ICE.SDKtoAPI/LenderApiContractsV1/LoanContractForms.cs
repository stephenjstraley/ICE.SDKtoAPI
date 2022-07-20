using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractForms
	{
		[DataMember(Name="formName")]
		public string FormName { get; set; }

		[DataMember(Name="formType")]
		public string FormType { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

	}
}