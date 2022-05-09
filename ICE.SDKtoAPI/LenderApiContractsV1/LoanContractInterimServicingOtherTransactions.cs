using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicingOtherTransactions
	{
		[DataMember(Name="accountNumber", EmitDefaultValue=false)]
		public string AccountNumber { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="createdById", EmitDefaultValue=false)]
		public string CreatedById { get; set; }

		[DataMember(Name="createdByName", EmitDefaultValue=false)]
		public string CreatedByName { get; set; }

		[DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? CreatedDateTimeUtc { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="institutionName", EmitDefaultValue=false)]
		public string InstitutionName { get; set; }

		[DataMember(Name="institutionRouting", EmitDefaultValue=false)]
		public string InstitutionRouting { get; set; }

		[DataMember(Name="modifiedById", EmitDefaultValue=false)]
		public string ModifiedById { get; set; }

		[DataMember(Name="modifiedByName", EmitDefaultValue=false)]
		public string ModifiedByName { get; set; }

		[DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? ModifiedDateTimeUtc { get; set; }

		[DataMember(Name="reference", EmitDefaultValue=false)]
		public string Reference { get; set; }

		[DataMember(Name="servicingPaymentMethod", EmitDefaultValue=false)]
		public string ServicingPaymentMethod { get; set; }

		[DataMember(Name="servicingTransactionType", EmitDefaultValue=false)]
		public string ServicingTransactionType { get; set; }

		[DataMember(Name="transactionAmount", EmitDefaultValue=false)]
		public double? TransactionAmount { get; set; }

		[DataMember(Name="transactionDate", EmitDefaultValue=false)]
		public DateTime? TransactionDate { get; set; }

	}
}