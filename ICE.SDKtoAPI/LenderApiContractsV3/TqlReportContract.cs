using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TqlReportContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "borrowerId1")]
        public string BorrowerId1 { get; set; }

        [DataMember(Name = "borrowerId2")]
        public string BorrowerId2 { get; set; }

        [DataMember(Name = "borrowerId3")]
        public string BorrowerId3 { get; set; }

        [DataMember(Name = "borrowerId4")]
        public string BorrowerId4 { get; set; }

        [DataMember(Name = "completedDate")]
        public string CompletedDate { get; set; }

        [DataMember(Name = "investor")]
        public string Investor { get; set; }

        [DataMember(Name = "orderDate")]
        public string OrderDate { get; set; }

        [DataMember(Name = "orderNumber")]
        public string OrderNumber { get; set; }

        [DataMember(Name = "orderStatus")]
        public string OrderStatus { get; set; }

        [DataMember(Name = "percentVariance1")]
        public decimal? PercentVariance1 { get; set; }

        [DataMember(Name = "percentVariance2")]
        public decimal? PercentVariance2 { get; set; }

        [DataMember(Name = "percentVariance3")]
        public decimal? PercentVariance3 { get; set; }

        [DataMember(Name = "percentVariance4")]
        public decimal? PercentVariance4 { get; set; }

        [DataMember(Name = "productsOrdered")]
        public string ProductsOrdered { get; set; }

        [DataMember(Name = "reportYear1")]
        public string ReportYear1 { get; set; }

        [DataMember(Name = "reportYear2")]
        public string ReportYear2 { get; set; }

        [DataMember(Name = "reportYear3")]
        public string ReportYear3 { get; set; }

        [DataMember(Name = "reportYear4")]
        public string ReportYear4 { get; set; }

        [DataMember(Name = "totalIncome1")]
        public decimal? TotalIncome1 { get; set; }

        [DataMember(Name = "totalIncome2")]
        public decimal? TotalIncome2 { get; set; }

        [DataMember(Name = "totalIncome3")]
        public decimal? TotalIncome3 { get; set; }

        [DataMember(Name = "totalIncome4")]
        public decimal? TotalIncome4 { get; set; }

        [DataMember(Name = "transcriptType")]
        public string TranscriptType { get; set; }

        [DataMember(Name = "userId")]
        public string UserId { get; set; }

        [DataMember(Name = "altId")]
        public string AltId { get; set; }

    }
}
