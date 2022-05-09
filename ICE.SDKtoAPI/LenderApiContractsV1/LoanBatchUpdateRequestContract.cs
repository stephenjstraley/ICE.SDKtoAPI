using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateRequestContract
	{
		[DataMember(Name="filter", EmitDefaultValue=false)]
		public LoanBatchUpdateRequestContractFilter Filter { get; set; }

		[DataMember(Name="loanData", EmitDefaultValue=false)]
		public LoanContract LoanData { get; set; }

		[DataMember(Name="loanFields", EmitDefaultValue=false)]
		public List<LoanBatchUpdateRequestContractLoanFields> LoanFields { get; set; }

		[DataMember(Name="loanGuids", EmitDefaultValue=false)]
		public List<string> LoanGuids { get; set; }

	}
}