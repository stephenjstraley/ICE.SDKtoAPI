using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLReports
	{
		[DataMember(Name="altId")]
		public string AltId { get; set; }

		[DataMember(Name="borrowerID1")]
		public string BorrowerID1 { get; set; }

		[DataMember(Name="borrowerID2")]
		public string BorrowerID2 { get; set; }

		[DataMember(Name="borrowerID3")]
		public string BorrowerID3 { get; set; }

		[DataMember(Name="borrowerID4")]
		public string BorrowerID4 { get; set; }

		[DataMember(Name="completedDate")]
		public DateTime? CompletedDate { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="investor")]
		public string Investor { get; set; }

		[DataMember(Name="orderDate")]
		public DateTime? OrderDate { get; set; }

		[DataMember(Name="orderNumber")]
		public string OrderNumber { get; set; }

		[DataMember(Name="orderStatus")]
		public string OrderStatus { get; set; }

		[DataMember(Name="percentVariance1")]
		public decimal? PercentVariance1 { get; set; }

		[DataMember(Name="percentVariance2")]
		public decimal? PercentVariance2 { get; set; }

		[DataMember(Name="percentVariance3")]
		public decimal? PercentVariance3 { get; set; }

		[DataMember(Name="percentVariance4")]
		public decimal? PercentVariance4 { get; set; }

		[DataMember(Name="productsOrdered")]
		public string ProductsOrdered { get; set; }

		[DataMember(Name="reportYear1")]
		public string ReportYear1 { get; set; }

		[DataMember(Name="reportYear2")]
		public string ReportYear2 { get; set; }

		[DataMember(Name="reportYear3")]
		public string ReportYear3 { get; set; }

		[DataMember(Name="reportYear4")]
		public string ReportYear4 { get; set; }

		[DataMember(Name="totalIncome1")]
		public decimal? TotalIncome1 { get; set; }

		[DataMember(Name="totalIncome2")]
		public decimal? TotalIncome2 { get; set; }

		[DataMember(Name="totalIncome3")]
		public decimal? TotalIncome3 { get; set; }

		[DataMember(Name="totalIncome4")]
		public decimal? TotalIncome4 { get; set; }

		[DataMember(Name="transcriptType")]
		public string TranscriptType { get; set; }

		[DataMember(Name="userID")]
		public string UserID { get; set; }

	}
}