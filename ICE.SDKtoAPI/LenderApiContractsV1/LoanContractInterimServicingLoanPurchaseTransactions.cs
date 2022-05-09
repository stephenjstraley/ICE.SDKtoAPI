using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicingLoanPurchaseTransactions
	{
		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="createdById", EmitDefaultValue=false)]
		public string CreatedById { get; set; }

		[DataMember(Name="createdByName", EmitDefaultValue=false)]
		public string CreatedByName { get; set; }

		[DataMember(Name="createdDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? CreatedDateTimeUtc { get; set; }

		[DataMember(Name="createdTime", EmitDefaultValue=false)]
		public DateTime? CreatedTime { get; set; }

		[DataMember(Name="firstPaymenttoInvestor", EmitDefaultValue=false)]
		public DateTime? FirstPaymenttoInvestor { get; set; }

		[DataMember(Name="guid", EmitDefaultValue=false)]
		public string Guid { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="investor", EmitDefaultValue=false)]
		public string Investor { get; set; }

		[DataMember(Name="investorLoanNumber", EmitDefaultValue=false)]
		public string InvestorLoanNumber { get; set; }

		[DataMember(Name="modifiedById", EmitDefaultValue=false)]
		public string ModifiedById { get; set; }

		[DataMember(Name="modifiedByName", EmitDefaultValue=false)]
		public string ModifiedByName { get; set; }

		[DataMember(Name="modifiedDateTimeUtc", EmitDefaultValue=false)]
		public DateTime? ModifiedDateTimeUtc { get; set; }

		[DataMember(Name="purchaseAdivceDate", EmitDefaultValue=false)]
		public DateTime? PurchaseAdivceDate { get; set; }

		[DataMember(Name="purchaseAmount", EmitDefaultValue=false)]
		public double? PurchaseAmount { get; set; }

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