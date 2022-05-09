using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractClosingDocumentAntiSteeringLoanOptions
	{
		[DataMember(Name="antiSteeringLoanOptionIndex", EmitDefaultValue=false)]
		public int? AntiSteeringLoanOptionIndex { get; set; }

		[DataMember(Name="brokerCompensationFeeAmount", EmitDefaultValue=false)]
		public double? BrokerCompensationFeeAmount { get; set; }

		[DataMember(Name="brokerCompensationFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? BrokerCompensationFeeBorPaidAmount { get; set; }

		[DataMember(Name="brokerCompensationFeePercentage", EmitDefaultValue=false)]
		public double? BrokerCompensationFeePercentage { get; set; }

		[DataMember(Name="brokerFeeAmount", EmitDefaultValue=false)]
		public double? BrokerFeeAmount { get; set; }

		[DataMember(Name="brokerFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? BrokerFeeBorPaidAmount { get; set; }

		[DataMember(Name="brokerFeePercentage", EmitDefaultValue=false)]
		public double? BrokerFeePercentage { get; set; }

		[DataMember(Name="brokerFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? BrokerFeeSellerPaidAmount { get; set; }

		[DataMember(Name="creditorName", EmitDefaultValue=false)]
		public string CreditorName { get; set; }

		[DataMember(Name="discountAdditionalAmount", EmitDefaultValue=false)]
		public double? DiscountAdditionalAmount { get; set; }

		[DataMember(Name="discountAmount", EmitDefaultValue=false)]
		public double? DiscountAmount { get; set; }

		[DataMember(Name="discountFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? DiscountFeeBorPaidAmount { get; set; }

		[DataMember(Name="discountFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? DiscountFeeSellerPaidAmount { get; set; }

		[DataMember(Name="discountPercentage", EmitDefaultValue=false)]
		public double? DiscountPercentage { get; set; }

		[DataMember(Name="discountPoints", EmitDefaultValue=false)]
		public double? DiscountPoints { get; set; }

		[DataMember(Name="fixedRatePeriod", EmitDefaultValue=false)]
		public int? FixedRatePeriod { get; set; }

		[DataMember(Name="haveDemandFeature", EmitDefaultValue=false)]
		public string HaveDemandFeature { get; set; }

		[DataMember(Name="havePrepaymentPenalty", EmitDefaultValue=false)]
		public bool? HavePrepaymentPenalty { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="inspectionFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? InspectionFeeBorPaidAmount { get; set; }

		[DataMember(Name="inspectionFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? InspectionFeeSellerPaidAmount { get; set; }

		[DataMember(Name="interestRate", EmitDefaultValue=false)]
		public double? InterestRate { get; set; }

		[DataMember(Name="isBalloonPaymentIn7Years", EmitDefaultValue=false)]
		public string IsBalloonPaymentIn7Years { get; set; }

		[DataMember(Name="isInterestOnlyLoan", EmitDefaultValue=false)]
		public string IsInterestOnlyLoan { get; set; }

		[DataMember(Name="isNegativeAmortization", EmitDefaultValue=false)]
		public bool? IsNegativeAmortization { get; set; }

		[DataMember(Name="loanTerm", EmitDefaultValue=false)]
		public int? LoanTerm { get; set; }

		[DataMember(Name="loanType", EmitDefaultValue=false)]
		public string LoanType { get; set; }

		[DataMember(Name="originationFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? OriginationFeeBorPaidAmount { get; set; }

		[DataMember(Name="originationFeePercentage", EmitDefaultValue=false)]
		public double? OriginationFeePercentage { get; set; }

		[DataMember(Name="originationFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? OriginationFeeSellerPaidAmount { get; set; }

		[DataMember(Name="originationPointsFees", EmitDefaultValue=false)]
		public double? OriginationPointsFees { get; set; }

		[DataMember(Name="originationPointsPercetange", EmitDefaultValue=false)]
		public double? OriginationPointsPercetange { get; set; }

		[DataMember(Name="processingFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? ProcessingFeeBorPaidAmount { get; set; }

		[DataMember(Name="processingFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? ProcessingFeeSellerPaidAmount { get; set; }

		[DataMember(Name="totalOriginationDiscountAmount", EmitDefaultValue=false)]
		public double? TotalOriginationDiscountAmount { get; set; }

		[DataMember(Name="underwritingFeeBorPaidAmount", EmitDefaultValue=false)]
		public double? UnderwritingFeeBorPaidAmount { get; set; }

		[DataMember(Name="underwritingFeeSellerPaidAmount", EmitDefaultValue=false)]
		public double? UnderwritingFeeSellerPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee1BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee1BorPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee1Description", EmitDefaultValue=false)]
		public string UserDefinedFee1Description { get; set; }

		[DataMember(Name="userDefinedFee1SellerPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee1SellerPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee2BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee2BorPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee2Description", EmitDefaultValue=false)]
		public string UserDefinedFee2Description { get; set; }

		[DataMember(Name="userDefinedFee2SellerPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee2SellerPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee3BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee3BorPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee3Description", EmitDefaultValue=false)]
		public string UserDefinedFee3Description { get; set; }

		[DataMember(Name="userDefinedFee3SellerPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee3SellerPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee4BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee4BorPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee4Description", EmitDefaultValue=false)]
		public string UserDefinedFee4Description { get; set; }

		[DataMember(Name="userDefinedFee4SellerPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee4SellerPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee5BorPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee5BorPaidAmount { get; set; }

		[DataMember(Name="userDefinedFee5Description", EmitDefaultValue=false)]
		public string UserDefinedFee5Description { get; set; }

		[DataMember(Name="userDefinedFee5SellerPaidAmount", EmitDefaultValue=false)]
		public double? UserDefinedFee5SellerPaidAmount { get; set; }

	}
}