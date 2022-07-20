using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractInterimServicingEscrowInterestTransactions
	{
		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="createdById")]
		public string CreatedById { get; set; }

		[DataMember(Name="createdByName")]
		public string CreatedByName { get; set; }

		[DataMember(Name="createdDateTimeUtc")]
		public DateTime? CreatedDateTimeUtc { get; set; }

		[DataMember(Name="guid")]
		public string Guid { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="modifiedById")]
		public string ModifiedById { get; set; }

		[DataMember(Name="modifiedByName")]
		public string ModifiedByName { get; set; }

		[DataMember(Name="modifiedDateTimeUtc")]
		public DateTime? ModifiedDateTimeUtc { get; set; }

		[DataMember(Name="servicingPaymentMethod")]
		public string ServicingPaymentMethod { get; set; }

		[DataMember(Name="servicingTransactionType")]
		public string ServicingTransactionType { get; set; }

		[DataMember(Name="transactionAmount")]
		public decimal? TransactionAmount { get; set; }

		[DataMember(Name="transactionDate")]
		public DateTime? TransactionDate { get; set; }

	}
}