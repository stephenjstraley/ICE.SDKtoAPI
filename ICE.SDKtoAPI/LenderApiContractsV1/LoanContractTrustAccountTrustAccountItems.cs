using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTrustAccountTrustAccountItems
	{
		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="description")]
		public string Description { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="notes")]
		public string Notes { get; set; }

		[DataMember(Name="paymentAmount")]
		public decimal? PaymentAmount { get; set; }

		[DataMember(Name="paymentCheckNo")]
		public string PaymentCheckNo { get; set; }

		[DataMember(Name="receiptAmount")]
		public decimal? ReceiptAmount { get; set; }

		[DataMember(Name="receiptCheckNo")]
		public string ReceiptCheckNo { get; set; }

		[DataMember(Name="trustAccountItemIndex")]
		public int? TrustAccountItemIndex { get; set; }

	}
}