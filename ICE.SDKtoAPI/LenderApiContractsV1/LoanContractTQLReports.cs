using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLReports
	{
		[DataMember(Name="altId", EmitDefaultValue=false)]
		public string AltId { get; set; }

		[DataMember(Name="borrowerID1", EmitDefaultValue=false)]
		public string BorrowerID1 { get; set; }

		[DataMember(Name="borrowerID2", EmitDefaultValue=false)]
		public string BorrowerID2 { get; set; }

		[DataMember(Name="borrowerID3", EmitDefaultValue=false)]
		public string BorrowerID3 { get; set; }

		[DataMember(Name="borrowerID4", EmitDefaultValue=false)]
		public string BorrowerID4 { get; set; }

		[DataMember(Name="completedDate", EmitDefaultValue=false)]
		public DateTime? CompletedDate { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="investor", EmitDefaultValue=false)]
		public string Investor { get; set; }

		[DataMember(Name="orderDate", EmitDefaultValue=false)]
		public DateTime? OrderDate { get; set; }

		[DataMember(Name="orderNumber", EmitDefaultValue=false)]
		public string OrderNumber { get; set; }

		[DataMember(Name="orderStatus", EmitDefaultValue=false)]
		public string OrderStatus { get; set; }

		[DataMember(Name="percentVariance1", EmitDefaultValue=false)]
		public double? PercentVariance1 { get; set; }

		[DataMember(Name="percentVariance2", EmitDefaultValue=false)]
		public double? PercentVariance2 { get; set; }

		[DataMember(Name="percentVariance3", EmitDefaultValue=false)]
		public double? PercentVariance3 { get; set; }

		[DataMember(Name="percentVariance4", EmitDefaultValue=false)]
		public double? PercentVariance4 { get; set; }

		[DataMember(Name="productsOrdered", EmitDefaultValue=false)]
		public string ProductsOrdered { get; set; }

		[DataMember(Name="reportYear1", EmitDefaultValue=false)]
		public string ReportYear1 { get; set; }

		[DataMember(Name="reportYear2", EmitDefaultValue=false)]
		public string ReportYear2 { get; set; }

		[DataMember(Name="reportYear3", EmitDefaultValue=false)]
		public string ReportYear3 { get; set; }

		[DataMember(Name="reportYear4", EmitDefaultValue=false)]
		public string ReportYear4 { get; set; }

		[DataMember(Name="totalIncome1", EmitDefaultValue=false)]
		public double? TotalIncome1 { get; set; }

		[DataMember(Name="totalIncome2", EmitDefaultValue=false)]
		public double? TotalIncome2 { get; set; }

		[DataMember(Name="totalIncome3", EmitDefaultValue=false)]
		public double? TotalIncome3 { get; set; }

		[DataMember(Name="totalIncome4", EmitDefaultValue=false)]
		public double? TotalIncome4 { get; set; }

		[DataMember(Name="transcriptType", EmitDefaultValue=false)]
		public string TranscriptType { get; set; }

		[DataMember(Name="userID", EmitDefaultValue=false)]
		public string UserID { get; set; }

	}
}