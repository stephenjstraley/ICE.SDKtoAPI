using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanBatchUpdateRequestContract
	{
		[DataMember(Name="filter")]
		public LoanBatchUpdateRequestContractFilter Filter { get; set; }

		[DataMember(Name="loanData")]
		public LoanContract LoanData { get; set; }

		[DataMember(Name="loanFields")]
		public List<LoanBatchUpdateRequestContractLoanFields> LoanFields { get; set; }

		[DataMember(Name="loanGuids")]
		public List<string> LoanGuids { get; set; }

	}
}