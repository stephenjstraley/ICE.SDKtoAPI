using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateRequestContractLoanFields
	{
		[DataMember(Name="fieldId", EmitDefaultValue=false)]
		public string FieldId { get; set; }

		[DataMember(Name="value", EmitDefaultValue=false)]
		public object Value { get; set; }

	}
}