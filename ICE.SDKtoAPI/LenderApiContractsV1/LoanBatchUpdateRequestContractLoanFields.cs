using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateRequestContractLoanFields
	{
		[DataMember(Name="fieldId")]
		public string FieldId { get; set; }

		[DataMember(Name="value")]
		public object Value { get; set; }

	}
}