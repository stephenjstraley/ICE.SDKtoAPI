using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractGfe
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="agregateAdjustment", EmitDefaultValue=false)]
		public double? AgregateAdjustment { get; set; }

		[DataMember(Name="brokerCommission", EmitDefaultValue=false)]
		public double? BrokerCommission { get; set; }

		[DataMember(Name="brokerLicense", EmitDefaultValue=false)]
		public string BrokerLicense { get; set; }

		[DataMember(Name="brokerName", EmitDefaultValue=false)]
		public string BrokerName { get; set; }

		[DataMember(Name="brokerRepresentative", EmitDefaultValue=false)]
		public string BrokerRepresentative { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="compensationFromLenderAmount", EmitDefaultValue=false)]
		public double? CompensationFromLenderAmount { get; set; }

		[DataMember(Name="compensationFromLenderPercentage", EmitDefaultValue=false)]
		public double? CompensationFromLenderPercentage { get; set; }

		[DataMember(Name="compensationFromLenderTotalAmount", EmitDefaultValue=false)]
		public double? CompensationFromLenderTotalAmount { get; set; }

		[DataMember(Name="creditLifeOrDisabilityPremium", EmitDefaultValue=false)]
		public double? CreditLifeOrDisabilityPremium { get; set; }

		[DataMember(Name="creditToBorrowerAmount", EmitDefaultValue=false)]
		public double? CreditToBorrowerAmount { get; set; }

		[DataMember(Name="estimatedCashAtClosing", EmitDefaultValue=false)]
		public double? EstimatedCashAtClosing { get; set; }

		[DataMember(Name="estimatedCashToBorrower", EmitDefaultValue=false)]
		public double? EstimatedCashToBorrower { get; set; }

		[DataMember(Name="estimatedDueDate", EmitDefaultValue=false)]
		public DateTime? EstimatedDueDate { get; set; }

		[DataMember(Name="finalBalloonPayment", EmitDefaultValue=false)]
		public double? FinalBalloonPayment { get; set; }

		[DataMember(Name="firstChangePayment", EmitDefaultValue=false)]
		public double? FirstChangePayment { get; set; }

		[DataMember(Name="firstChangePercent", EmitDefaultValue=false)]
		public double? FirstChangePercent { get; set; }

		[DataMember(Name="fundingAmount", EmitDefaultValue=false)]
		public double? FundingAmount { get; set; }

		[DataMember(Name="gfeFees", EmitDefaultValue=false)]
		public List<LoanContractGfeGfeFees> GfeFees { get; set; }

		[DataMember(Name="gfeLiens", EmitDefaultValue=false)]
		public List<LoanContractGfeGfeLiens> GfeLiens { get; set; }

		[DataMember(Name="gfePayments", EmitDefaultValue=false)]
		public List<LoanContractGfeGfePayments> GfePayments { get; set; }

		[DataMember(Name="gfePayoffs", EmitDefaultValue=false)]
		public List<LoanContractGfeGfePayoffs> GfePayoffs { get; set; }

		[DataMember(Name="gfeProvidedByBrokerIndicator", EmitDefaultValue=false)]
		public bool? GfeProvidedByBrokerIndicator { get; set; }

		[DataMember(Name="hasAdditionalCompensationIndicator", EmitDefaultValue=false)]
		public bool? HasAdditionalCompensationIndicator { get; set; }

		[DataMember(Name="hasLateChargesIndicator", EmitDefaultValue=false)]
		public bool? HasLateChargesIndicator { get; set; }

		[DataMember(Name="hasPrepaymentPenaltyIndicator", EmitDefaultValue=false)]
		public bool? HasPrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="initialFixedOrArmType", EmitDefaultValue=false)]
		public string InitialFixedOrArmType { get; set; }

		[DataMember(Name="lenderOriginationFee", EmitDefaultValue=false)]
		public double? LenderOriginationFee { get; set; }

		[DataMember(Name="loanFromBrokerControledFundsType", EmitDefaultValue=false)]
		public string LoanFromBrokerControledFundsType { get; set; }

		[DataMember(Name="lockField", EmitDefaultValue=false)]
		public bool? LockField { get; set; }

		[DataMember(Name="maxLifePayment", EmitDefaultValue=false)]
		public double? MaxLifePayment { get; set; }

		[DataMember(Name="maxPaymentAfterMonth", EmitDefaultValue=false)]
		public int? MaxPaymentAfterMonth { get; set; }

		[DataMember(Name="monthlyPaymentAndEscrow", EmitDefaultValue=false)]
		public double? MonthlyPaymentAndEscrow { get; set; }

		[DataMember(Name="mortgageBrokerComissionFee", EmitDefaultValue=false)]
		public double? MortgageBrokerComissionFee { get; set; }

		[DataMember(Name="mortgageBrokerComissionFeePaidToName", EmitDefaultValue=false)]
		public string MortgageBrokerComissionFeePaidToName { get; set; }

		[DataMember(Name="natureLien1Description", EmitDefaultValue=false)]
		public string NatureLien1Description { get; set; }

		[DataMember(Name="natureLien1PayoffDescription", EmitDefaultValue=false)]
		public string NatureLien1PayoffDescription { get; set; }

		[DataMember(Name="natureLien2Description", EmitDefaultValue=false)]
		public string NatureLien2Description { get; set; }

		[DataMember(Name="natureLien2PayoffDescription", EmitDefaultValue=false)]
		public string NatureLien2PayoffDescription { get; set; }

		[DataMember(Name="natureLien3Description", EmitDefaultValue=false)]
		public string NatureLien3Description { get; set; }

		[DataMember(Name="natureLien3PayoffDescription", EmitDefaultValue=false)]
		public string NatureLien3PayoffDescription { get; set; }

		[DataMember(Name="paymentOfPrincipleIndicator", EmitDefaultValue=false)]
		public bool? PaymentOfPrincipleIndicator { get; set; }

		[DataMember(Name="paymentOfPrincipleType", EmitDefaultValue=false)]
		public string PaymentOfPrincipleType { get; set; }

		[DataMember(Name="penaltyNotToExceedMonths", EmitDefaultValue=false)]
		public int? PenaltyNotToExceedMonths { get; set; }

		[DataMember(Name="pocPaid1", EmitDefaultValue=false)]
		public string PocPaid1 { get; set; }

		[DataMember(Name="pocPaid2", EmitDefaultValue=false)]
		public string PocPaid2 { get; set; }

		[DataMember(Name="pocPaid3", EmitDefaultValue=false)]
		public string PocPaid3 { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="prepaymentOtherDescription", EmitDefaultValue=false)]
		public string PrepaymentOtherDescription { get; set; }

		[DataMember(Name="prepaymentOtherTypeIndicator", EmitDefaultValue=false)]
		public bool? PrepaymentOtherTypeIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyAmount", EmitDefaultValue=false)]
		public double? PrepaymentPenaltyAmount { get; set; }

		[DataMember(Name="prepaymentPenaltyIndicator", EmitDefaultValue=false)]
		public bool? PrepaymentPenaltyIndicator { get; set; }

		[DataMember(Name="prepaymentPenaltyPeriod", EmitDefaultValue=false)]
		public int? PrepaymentPenaltyPeriod { get; set; }

		[DataMember(Name="principalAmount", EmitDefaultValue=false)]
		public double? PrincipalAmount { get; set; }

		[DataMember(Name="purchasePayOff", EmitDefaultValue=false)]
		public double? PurchasePayOff { get; set; }

		[DataMember(Name="re882AdditionalCompensation", EmitDefaultValue=false)]
		public double? Re882AdditionalCompensation { get; set; }

		[DataMember(Name="receivedFromLenderAmount", EmitDefaultValue=false)]
		public double? ReceivedFromLenderAmount { get; set; }

		[DataMember(Name="representativeLicense", EmitDefaultValue=false)]
		public string RepresentativeLicense { get; set; }

		[DataMember(Name="sourcesDeemedReliableIndicator", EmitDefaultValue=false)]
		public bool? SourcesDeemedReliableIndicator { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="subtotalOfAllDeductions", EmitDefaultValue=false)]
		public double? SubtotalOfAllDeductions { get; set; }

		[DataMember(Name="totalBrokerCompensationAmount", EmitDefaultValue=false)]
		public double? TotalBrokerCompensationAmount { get; set; }

		[DataMember(Name="totalClosingCostWithDiscount", EmitDefaultValue=false)]
		public double? TotalClosingCostWithDiscount { get; set; }

		[DataMember(Name="totalCostsExpenses", EmitDefaultValue=false)]
		public double? TotalCostsExpenses { get; set; }

		[DataMember(Name="totalMaximumCostsExpenses", EmitDefaultValue=false)]
		public double? TotalMaximumCostsExpenses { get; set; }

		[DataMember(Name="totalOfInitialFees", EmitDefaultValue=false)]
		public double? TotalOfInitialFees { get; set; }

		[DataMember(Name="totalPrepaidClosingCost", EmitDefaultValue=false)]
		public double? TotalPrepaidClosingCost { get; set; }

		[DataMember(Name="totalSettlementCharges", EmitDefaultValue=false)]
		public double? TotalSettlementCharges { get; set; }

		[DataMember(Name="totalTaxAndInsurance", EmitDefaultValue=false)]
		public double? TotalTaxAndInsurance { get; set; }

		[DataMember(Name="yearlyFloodInsurance", EmitDefaultValue=false)]
		public double? YearlyFloodInsurance { get; set; }

		[DataMember(Name="yearlyInsurance", EmitDefaultValue=false)]
		public double? YearlyInsurance { get; set; }

		[DataMember(Name="yearlyMortgageInsurance", EmitDefaultValue=false)]
		public double? YearlyMortgageInsurance { get; set; }

		[DataMember(Name="yearlyOtherInsurance", EmitDefaultValue=false)]
		public double? YearlyOtherInsurance { get; set; }

		[DataMember(Name="yearlyOtherInsuranceDescription", EmitDefaultValue=false)]
		public string YearlyOtherInsuranceDescription { get; set; }

		[DataMember(Name="yearlyTax", EmitDefaultValue=false)]
		public double? YearlyTax { get; set; }

	}
}