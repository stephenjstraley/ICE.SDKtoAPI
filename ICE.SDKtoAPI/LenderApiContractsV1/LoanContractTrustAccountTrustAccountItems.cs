using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTrustAccountTrustAccountItems
	{
		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="notes", EmitDefaultValue=false)]
		public string Notes { get; set; }

		[DataMember(Name="paymentAmount", EmitDefaultValue=false)]
		public double? PaymentAmount { get; set; }

		[DataMember(Name="paymentCheckNo", EmitDefaultValue=false)]
		public string PaymentCheckNo { get; set; }

		[DataMember(Name="receiptAmount", EmitDefaultValue=false)]
		public double? ReceiptAmount { get; set; }

		[DataMember(Name="receiptCheckNo", EmitDefaultValue=false)]
		public string ReceiptCheckNo { get; set; }

		[DataMember(Name="trustAccountItemIndex", EmitDefaultValue=false)]
		public int? TrustAccountItemIndex { get; set; }

	}
}