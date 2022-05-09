using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Gfe2010FeeContract
    {
        [DataMember(Name = "gfe2010FeeParentType")]
        public string Gfe2010FeeParentType { get; set; }

        [DataMember(Name = "gfe2010FeeType")]
        public string Gfe2010FeeType { get; set; }

        [DataMember(Name = "gfe2010FeeIndex")]
        public int? Gfe2010FeeIndex { get; set; }

        [DataMember(Name = "additionalAmount")]
        public decimal? AdditionalAmount { get; set; }

        [DataMember(Name = "amount")]
        public decimal? Amount { get; set; }

        [DataMember(Name = "aprIndicator")]
        public bool? AprIndicator { get; set; }

        [DataMember(Name = "borPaidAmount")]
        public decimal? BorPaidAmount { get; set; }

        [DataMember(Name = "borrowerSelectIndicator")]
        public bool? BorrowerSelectIndicator { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "financedIndicator")]
        public bool? FinancedIndicator { get; set; }

        [DataMember(Name = "gfeAmount")]
        public decimal? GfeAmount { get; set; }

        [DataMember(Name = "paidByType")]
        public string PaidByType { get; set; }

        [DataMember(Name = "paidToName")]
        public string PaidToName { get; set; }

        [DataMember(Name = "pocPtcIndicator")]
        public bool? PocPtcIndicator { get; set; }

        [DataMember(Name = "ptbType")]
        public string PtbType { get; set; }

        [DataMember(Name = "rate")]
        public decimal? Rate { get; set; }

        [DataMember(Name = "selPaidAmount")]
        public decimal? SelPaidAmount { get; set; }

        [DataMember(Name = "titleServiceSelectIndicator")]
        public bool? TitleServiceSelectIndicator { get; set; }

        [DataMember(Name = "wholePoc")]
        public decimal? WholePoc { get; set; }

        [DataMember(Name = "wholePocPaidByType")]
        public string WholePocPaidByType { get; set; }

        [DataMember(Name = "totalFeeAmount2015")]
        public decimal? TotalFeeAmount2015 { get; set; }

        [DataMember(Name = "totalFeePercentage2015")]
        public decimal? TotalFeePercentage2015 { get; set; }

        [DataMember(Name = "lastDisclosedLoanEstimate2015")]
        public int? LastDisclosedLoanEstimate2015 { get; set; }

        [DataMember(Name = "lastDisclosedClosingDisclosure2015")]
        public decimal? LastDisclosedClosingDisclosure2015 { get; set; }

        [DataMember(Name = "borrowerFinanced2015")]
        public decimal? BorrowerFinanced2015 { get; set; }

        [DataMember(Name = "borrowerPtc2015")]
        public decimal? BorrowerPtc2015 { get; set; }

        [DataMember(Name = "borrowerPac2015")]
        public decimal? BorrowerPac2015 { get; set; }

        [DataMember(Name = "borrowerPoc2015")]
        public decimal? BorrowerPoc2015 { get; set; }

        [DataMember(Name = "borrowerAmountPaid2015")]
        public decimal? BorrowerAmountPaid2015 { get; set; }

        [DataMember(Name = "sellerPac2015")]
        public decimal? SellerPac2015 { get; set; }

        [DataMember(Name = "sellerPoc2015")]
        public decimal? SellerPoc2015 { get; set; }

        [DataMember(Name = "sellerAmountPaid2015")]
        public decimal? SellerAmountPaid2015 { get; set; }

        [DataMember(Name = "brokerPac2015")]
        public decimal? BrokerPac2015 { get; set; }

        [DataMember(Name = "brokerPoc2015")]
        public decimal? BrokerPoc2015 { get; set; }

        [DataMember(Name = "brokerAmountPaid2015")]
        public decimal? BrokerAmountPaid2015 { get; set; }

        [DataMember(Name = "lenderPac2015")]
        public decimal? LenderPac2015 { get; set; }

        [DataMember(Name = "lenderPoc2015")]
        public decimal? LenderPoc2015 { get; set; }

        [DataMember(Name = "lenderAmountPaid2015")]
        public decimal? LenderAmountPaid2015 { get; set; }

        [DataMember(Name = "otherPac2015")]
        public decimal? OtherPac2015 { get; set; }

        [DataMember(Name = "otherPoc2015")]
        public decimal? OtherPoc2015 { get; set; }

        [DataMember(Name = "otherAmountPaid2015")]
        public decimal? OtherAmountPaid2015 { get; set; }

        [DataMember(Name = "totalPaidByBLo2015")]
        public decimal? TotalPaidByBLo2015 { get; set; }

        [DataMember(Name = "borrowerCanShopForIndicator2015")]
        public bool? BorrowerCanShopForIndicator2015 { get; set; }

        [DataMember(Name = "borrowerDidShopForIndicator2015")]
        public bool? BorrowerDidShopForIndicator2015 { get; set; }

        [DataMember(Name = "sellerCreditIndicator2015")]
        public bool? SellerCreditIndicator2015 { get; set; }

        [DataMember(Name = "sellerObligatedIndicator2015")]
        public bool? SellerObligatedIndicator2015 { get; set; }

        [DataMember(Name = "sellerObligatedAmount2015")]
        public decimal? SellerObligatedAmount2015 { get; set; }

        [DataMember(Name = "sec32PointsAndFees2015")]
        public decimal? Sec32PointsAndFees2015 { get; set; }

        [DataMember(Name = "retainedAmount2015")]
        public decimal? RetainedAmount2015 { get; set; }

        [DataMember(Name = "optionalIndicator2015")]
        public bool? OptionalIndicator2015 { get; set; }

        [DataMember(Name = "numberOfMonths")]
        public int? NumberOfMonths { get; set; }

        [DataMember(Name = "monthlyPayment")]
        public decimal? MonthlyPayment { get; set; }

        [DataMember(Name = "insuranceIndicator2015")]
        public bool? InsuranceIndicator2015 { get; set; }

        [DataMember(Name = "taxesIndicator2015")]
        public bool? TaxesIndicator2015 { get; set; }

        [DataMember(Name = "escrowedIndicator2015")]
        public bool? EscrowedIndicator2015 { get; set; }

        [DataMember(Name = "propertyIndicator2015")]
        public bool? PropertyIndicator2015 { get; set; }

        [DataMember(Name = "simultaneousIssuanceIndicator2015")]
        public bool? SimultaneousIssuanceIndicator2015 { get; set; }

        [DataMember(Name = "undiscountedInsurance2015")]
        public decimal? UndiscountedInsurance2015 { get; set; }

        [DataMember(Name = "collectedPostConsummationIndicator2015")]
        public bool? CollectedPostConsummationIndicator2015 { get; set; }
    }
}
