using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class DisclosureContract
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "leOriginationCharges")]
        public decimal? LeOriginationCharges { get; set; }

        [DataMember(Name = "cdOriginationCharges")]
        public decimal? CdOriginationCharges { get; set; }

        [DataMember(Name = "pcOriginationCharges")]
        public decimal? PcOriginationCharges { get; set; }

        [DataMember(Name = "leNonShoppableServices")]
        public decimal? LeNonShoppableServices { get; set; }

        [DataMember(Name = "cdNonShoppableServices")]
        public decimal? CdNonShoppableServices { get; set; }

        [DataMember(Name = "pcNonShoppableServices")]
        public decimal? PcNonShoppableServices { get; set; }

        [DataMember(Name = "leShoppableServices")]
        public decimal? LeShoppableServices { get; set; }

        [DataMember(Name = "cdShoppableServices")]
        public decimal? CdShoppableServices { get; set; }

        [DataMember(Name = "pcShoppableServices")]
        public decimal? PcShoppableServices { get; set; }

        [DataMember(Name = "leTaxesGovtFees")]
        public decimal? LeTaxesGovtFees { get; set; }

        [DataMember(Name = "cdTaxesGovtFees")]
        public decimal? CdTaxesGovtFees { get; set; }

        [DataMember(Name = "pcTaxesGovtFees")]
        public decimal? PcTaxesGovtFees { get; set; }

        [DataMember(Name = "leLoanDiscountFee")]
        public decimal? LeLoanDiscountFee { get; set; }

        [DataMember(Name = "cdLoanDiscountFee")]
        public decimal? CdLoanDiscountFee { get; set; }

        [DataMember(Name = "pcLoanDiscountFee")]
        public decimal? PcLoanDiscountFee { get; set; }

        [DataMember(Name = "leCreditReportFee")]
        public decimal? LeCreditReportFee { get; set; }

        [DataMember(Name = "cdCreditReportFee")]
        public decimal? CdCreditReportFee { get; set; }

        [DataMember(Name = "pcCreditReportFee")]
        public decimal? PcCreditReportFee { get; set; }

        [DataMember(Name = "leAppraisalFee")]
        public decimal? LeAppraisalFee { get; set; }

        [DataMember(Name = "cdAppraisalFee")]
        public decimal? CdAppraisalFee { get; set; }

        [DataMember(Name = "pcAppraisalFee")]
        public decimal? PcAppraisalFee { get; set; }
    }
}
