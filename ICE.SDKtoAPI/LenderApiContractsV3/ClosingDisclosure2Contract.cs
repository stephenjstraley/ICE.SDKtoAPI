using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class ClosingDisclosure2Contract
    {
        [DataMember(Name = "lcAtClosing")]
        public decimal? LcAtClosing { get; set; }

        [DataMember(Name = "originationChargesSubTotal")]
        public decimal? OriginationChargesSubTotal { get; set; }

        [DataMember(Name = "servicesDidNotShopSubTotal")]
        public decimal? ServicesDidNotShopSubTotal { get; set; }

        [DataMember(Name = "servicesDidShopSubTotal")]
        public decimal? ServicesDidShopSubTotal { get; set; }

        [DataMember(Name = "totalLoanCost")]
        public decimal? TotalLoanCost { get; set; }

        [DataMember(Name = "lastDisclosedLoanCosts")]
        public decimal? LastDisclosedLoanCosts { get; set; }

        [DataMember(Name = "totalBorrowerPaidAtClosing")]
        public decimal? TotalBorrowerPaidAtClosing { get; set; }

        [DataMember(Name = "totalBorrowerPaidBeforeClosing")]
        public decimal? TotalBorrowerPaidBeforeClosing { get; set; }

        [DataMember(Name = "taxesGovermentFeesSubTotal")]
        public decimal? TaxesGovermentFeesSubTotal { get; set; }

        [DataMember(Name = "prepaidsSubTotal")]
        public decimal? PrepaidsSubTotal { get; set; }

        [DataMember(Name = "initialEscrowSubTotal")]
        public decimal? InitialEscrowSubTotal { get; set; }

        [DataMember(Name = "otherSubTotal")]
        public decimal? OtherSubTotal { get; set; }

        [DataMember(Name = "totalOtherCost")]
        public decimal? TotalOtherCost { get; set; }

        [DataMember(Name = "lastDisclosedOtherCosts")]
        public decimal? LastDisclosedOtherCosts { get; set; }

        [DataMember(Name = "totalOtherCostAtClosing")]
        public decimal? TotalOtherCostAtClosing { get; set; }

        [DataMember(Name = "totalOtherCostBeforeClosing")]
        public decimal? TotalOtherCostBeforeClosing { get; set; }

        [DataMember(Name = "totalClosingCost")]
        public decimal? TotalClosingCost { get; set; }

        [DataMember(Name = "borrowerClosingCostAtClosing")]
        public decimal? BorrowerClosingCostAtClosing { get; set; }

        [DataMember(Name = "borrowerClosingCostBeforeClosing")]
        public decimal? BorrowerClosingCostBeforeClosing { get; set; }

        [DataMember(Name = "sellerClosingCostAtClosing")]
        public decimal? SellerClosingCostAtClosing { get; set; }

        [DataMember(Name = "sellerClosingCostBeforeClosing")]
        public decimal? SellerClosingCostBeforeClosing { get; set; }

        [DataMember(Name = "closingCostPaidByOthers")]
        public decimal? ClosingCostPaidByOthers { get; set; }

        [DataMember(Name = "closingCostLenderCredits")]
        public decimal? ClosingCostLenderCredits { get; set; }

        [DataMember(Name = "lastDisclosedLenderCredits")]
        public decimal? LastDisclosedLenderCredits { get; set; }

        [DataMember(Name = "discloseLenderCredits")]
        public decimal? DiscloseLenderCredits { get; set; }
    }
}
