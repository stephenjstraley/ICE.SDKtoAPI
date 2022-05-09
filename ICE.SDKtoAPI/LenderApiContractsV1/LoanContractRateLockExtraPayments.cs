using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLockExtraPayments
	{
		[DataMember(Name="amount", EmitDefaultValue=false)]
		public double? Amount { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="extraPaymentIndex", EmitDefaultValue=false)]
		public int? ExtraPaymentIndex { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineNumber", EmitDefaultValue=false)]
		public int? LineNumber { get; set; }

	}
}