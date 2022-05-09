using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class AntiSteeringLoanOptionContract
    {
        [DataMember(Name = "antiSteeringLoanOptionIndex")]
        public int AntiSteeringLoanOptionIndex { get; set; }

        [DataMember(Name = "brokerCompensationFeeAmount")]
        public decimal? BrokerCompensationFeeAmount { get; set; }

        [DataMember(Name = "brokerCompensationFeeBorPaidAmount")]
        public decimal? BrokerCompensationFeeBorPaidAmount { get; set; }

        [DataMember(Name = "brokerCompensationFeePercentage")]
        public decimal? BrokerCompensationFeePercentage { get; set; }

        [DataMember(Name = "brokerFeeAmount")]
        public decimal? BrokerFeeAmount { get; set; }

        [DataMember(Name = "brokerFeeBorPaidAmount")]
        public decimal? BrokerFeeBorPaidAmount { get; set; }

        [DataMember(Name = "brokerFeePercentage")]
        public decimal? BrokerFeePercentage { get; set; }

        [DataMember(Name = "brokerFeeSellerPaidAmount")]
        public decimal? BrokerFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "creditorName")]
        public string CreditorName { get; set; }

        [DataMember(Name = "discountAdditionalAmount")]
        public decimal? DiscountAdditionalAmount { get; set; }

        [DataMember(Name = "discountAmount")]
        public decimal? DiscountAmount { get; set; }

        [DataMember(Name = "discountFeeBorPaidAmount")]
        public decimal? DiscountFeeBorPaidAmount { get; set; }

        [DataMember(Name = "discountFeeSellerPaidAmount")]
        public decimal? DiscountFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "discountPercentage")]
        public decimal? DiscountPercentage { get; set; }

        [DataMember(Name = "discountPoints")]
        public decimal? DiscountPoints { get; set; }

        [DataMember(Name = "fixedRatePeriod")]
        public int? FixedRatePeriod { get; set; }

        [DataMember(Name = "haveDemandFeature")]
        public string HaveDemandFeature { get; set; }

        [DataMember(Name = "havePrepaymentPenalty")]
        public bool? HavePrepaymentPenalty { get; set; }

        [DataMember(Name = "inspectionFeeBorPaidAmount")]
        public decimal? InspectionFeeBorPaidAmount { get; set; }

        [DataMember(Name = "inspectionFeeSellerPaidAmount")]
        public decimal? InspectionFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "interestRate")]
        public decimal? InterestRate { get; set; }

        [DataMember(Name = "isBalloonPaymentIn7Years")]
        public string IsBalloonPaymentIn7Years { get; set; }

        [DataMember(Name = "isInterestOnlyLoan")]
        public string IsInterestOnlyLoan { get; set; }

        [DataMember(Name = "isNegativeAmortization")]
        public bool? IsNegativeAmortization { get; set; }

        [DataMember(Name = "loanTerm")]
        public int? LoanTerm { get; set; }

        [DataMember(Name = "loanType")]
        public string LoanType { get; set; }

        [DataMember(Name = "originationFeeBorPaidAmount")]
        public decimal? OriginationFeeBorPaidAmount { get; set; }

        [DataMember(Name = "originationFeePercentage")]
        public decimal? OriginationFeePercentage { get; set; }

        [DataMember(Name = "originationFeeSellerPaidAmount")]
        public decimal? OriginationFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "originationPointsFees")]
        public decimal? OriginationPointsFees { get; set; }

        [DataMember(Name = "originationPointsPercentage")]
        public decimal? OriginationPointsPercentage { get; set; }

        [DataMember(Name = "processingFeeBorPaidAmount")]
        public decimal? ProcessingFeeBorPaidAmount { get; set; }

        [DataMember(Name = "processingFeeSellerPaidAmount")]
        public decimal? ProcessingFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "totalOriginationDiscountAmount")]
        public decimal? TotalOriginationDiscountAmount { get; set; }

        [DataMember(Name = "underwritingFeeBorPaidAmount")]
        public decimal? UnderwritingFeeBorPaidAmount { get; set; }

        [DataMember(Name = "underwritingFeeSellerPaidAmount")]
        public decimal? UnderwritingFeeSellerPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee1BorPaidAmount")]
        public decimal? UserDefinedFee1BorPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee1Description")]
        public string UserDefinedFee1Description { get; set; }

        [DataMember(Name = "userDefinedFee1SellerPaidAmount")]
        public decimal? UserDefinedFee1SellerPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee2BorPaidAmount")]
        public decimal? UserDefinedFee2BorPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee2Description")]
        public string UserDefinedFee2Description { get; set; }

        [DataMember(Name = "userDefinedFee2SellerPaidAmount")]
        public decimal? UserDefinedFee2SellerPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee3BorPaidAmount")]
        public decimal? UserDefinedFee3BorPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee3Description")]
        public string UserDefinedFee3Description { get; set; }

        [DataMember(Name = "userDefinedFee3SellerPaidAmount")]
        public decimal? UserDefinedFee3SellerPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee4BorPaidAmount")]
        public decimal? UserDefinedFee4BorPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee4Description")]
        public string UserDefinedFee4Description { get; set; }

        [DataMember(Name = "userDefinedFee4SellerPaidAmount")]
        public decimal? UserDefinedFee4SellerPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee5BorPaidAmount")]
        public decimal? UserDefinedFee5BorPaidAmount { get; set; }

        [DataMember(Name = "userDefinedFee5Description")]
        public string UserDefinedFee5Description { get; set; }

        [DataMember(Name = "userDefinedFee5SellerPaidAmount")]
        public decimal? UserDefinedFee5SellerPaidAmount { get; set; }
    }
}
