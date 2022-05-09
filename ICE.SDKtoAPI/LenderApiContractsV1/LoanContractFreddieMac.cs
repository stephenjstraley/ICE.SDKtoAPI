using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractFreddieMac
	{
		[DataMember(Name="affordableProduct", EmitDefaultValue=false)]
		public string AffordableProduct { get; set; }

		[DataMember(Name="alimonyAsIncomeReduction", EmitDefaultValue=false)]
		public double? AlimonyAsIncomeReduction { get; set; }

		[DataMember(Name="allMonthlyPayments", EmitDefaultValue=false)]
		public double? AllMonthlyPayments { get; set; }

		[DataMember(Name="allowsNegativeAmortizationIndicator", EmitDefaultValue=false)]
		public bool? AllowsNegativeAmortizationIndicator { get; set; }

		[DataMember(Name="amountOfFinancedMI", EmitDefaultValue=false)]
		public string AmountOfFinancedMI { get; set; }

		[DataMember(Name="aPNCity", EmitDefaultValue=false)]
		public string APNCity { get; set; }

		[DataMember(Name="armsLengthTransactionIndicator", EmitDefaultValue=false)]
		public bool? ArmsLengthTransactionIndicator { get; set; }

		[DataMember(Name="borrowerQualifiesAsVeteranIndicator", EmitDefaultValue=false)]
		public bool? BorrowerQualifiesAsVeteranIndicator { get; set; }

		[DataMember(Name="brokerOriginated", EmitDefaultValue=false)]
		public string BrokerOriginated { get; set; }

		[DataMember(Name="buydownContributor", EmitDefaultValue=false)]
		public string BuydownContributor { get; set; }

		[DataMember(Name="condoClass", EmitDefaultValue=false)]
		public string CondoClass { get; set; }

		[DataMember(Name="convertibleFeeAmount", EmitDefaultValue=false)]
		public double? ConvertibleFeeAmount { get; set; }

		[DataMember(Name="convertibleFeePercent", EmitDefaultValue=false)]
		public double? ConvertibleFeePercent { get; set; }

		[DataMember(Name="convertibleMaxRateAdjPercent", EmitDefaultValue=false)]
		public double? ConvertibleMaxRateAdjPercent { get; set; }

		[DataMember(Name="convertibleMinRateAdjPercent", EmitDefaultValue=false)]
		public double? ConvertibleMinRateAdjPercent { get; set; }

		[DataMember(Name="correspondentAssignmentID", EmitDefaultValue=false)]
		public string CorrespondentAssignmentID { get; set; }

		[DataMember(Name="county", EmitDefaultValue=false)]
		public string County { get; set; }

		[DataMember(Name="creditReportCompany", EmitDefaultValue=false)]
		public string CreditReportCompany { get; set; }

		[DataMember(Name="financingConcessions", EmitDefaultValue=false)]
		public double? FinancingConcessions { get; set; }

		[DataMember(Name="freddieFiel11", EmitDefaultValue=false)]
		public string FreddieFiel11 { get; set; }

		[DataMember(Name="freddieFiel12", EmitDefaultValue=false)]
		public string FreddieFiel12 { get; set; }

		[DataMember(Name="freddieFiel13", EmitDefaultValue=false)]
		public string FreddieFiel13 { get; set; }

		[DataMember(Name="freddieFiel14", EmitDefaultValue=false)]
		public string FreddieFiel14 { get; set; }

		[DataMember(Name="freddieFiel15", EmitDefaultValue=false)]
		public string FreddieFiel15 { get; set; }

		[DataMember(Name="freddieField3", EmitDefaultValue=false)]
		public string FreddieField3 { get; set; }

		[DataMember(Name="freddieField7", EmitDefaultValue=false)]
		public string FreddieField7 { get; set; }

		[DataMember(Name="hELOCActualBalance", EmitDefaultValue=false)]
		public string HELOCActualBalance { get; set; }

		[DataMember(Name="hELOCCreditLimit", EmitDefaultValue=false)]
		public string HELOCCreditLimit { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lenderAltPhone", EmitDefaultValue=false)]
		public string LenderAltPhone { get; set; }

		[DataMember(Name="lenderRegistration", EmitDefaultValue=false)]
		public string LenderRegistration { get; set; }

		[DataMember(Name="loanProspectorID", EmitDefaultValue=false)]
		public string LoanProspectorID { get; set; }

		[DataMember(Name="loanToConduitCode", EmitDefaultValue=false)]
		public string LoanToConduitCode { get; set; }

		[DataMember(Name="longLegalDescription", EmitDefaultValue=false)]
		public string LongLegalDescription { get; set; }

		[DataMember(Name="lossCoverage", EmitDefaultValue=false)]
		public string LossCoverage { get; set; }

		[DataMember(Name="lPKeyNumber", EmitDefaultValue=false)]
		public string LPKeyNumber { get; set; }

		[DataMember(Name="mIRefundOption", EmitDefaultValue=false)]
		public string MIRefundOption { get; set; }

		[DataMember(Name="mortgageInsuranceCompany", EmitDefaultValue=false)]
		public string MortgageInsuranceCompany { get; set; }

		[DataMember(Name="netPurchasePrice", EmitDefaultValue=false)]
		public double? NetPurchasePrice { get; set; }

		[DataMember(Name="newConstructionType", EmitDefaultValue=false)]
		public string NewConstructionType { get; set; }

		[DataMember(Name="noAppraisalMAF", EmitDefaultValue=false)]
		public string NoAppraisalMAF { get; set; }

		[DataMember(Name="nonOccupantNonHousingDebt", EmitDefaultValue=false)]
		public double? NonOccupantNonHousingDebt { get; set; }

		[DataMember(Name="nonOccupantPresentHE", EmitDefaultValue=false)]
		public double? NonOccupantPresentHE { get; set; }

		[DataMember(Name="orderCreditEvaluationIndicator", EmitDefaultValue=false)]
		public bool? OrderCreditEvaluationIndicator { get; set; }

		[DataMember(Name="orderMergedCreditReportIndicator", EmitDefaultValue=false)]
		public bool? OrderMergedCreditReportIndicator { get; set; }

		[DataMember(Name="orderMortgageInsurance", EmitDefaultValue=false)]
		public string OrderMortgageInsurance { get; set; }

		[DataMember(Name="orderRiskGradeEvaluationIndicator", EmitDefaultValue=false)]
		public bool? OrderRiskGradeEvaluationIndicator { get; set; }

		[DataMember(Name="originalIntRate", EmitDefaultValue=false)]
		public double? OriginalIntRate { get; set; }

		[DataMember(Name="originateID", EmitDefaultValue=false)]
		public string OriginateID { get; set; }

		[DataMember(Name="paymentFrequency", EmitDefaultValue=false)]
		public string PaymentFrequency { get; set; }

		[DataMember(Name="paymentOption", EmitDefaultValue=false)]
		public string PaymentOption { get; set; }

		[DataMember(Name="personIncomeForSelfEmployment1", EmitDefaultValue=false)]
		public double? PersonIncomeForSelfEmployment1 { get; set; }

		[DataMember(Name="personIncomeForSelfEmployment2", EmitDefaultValue=false)]
		public double? PersonIncomeForSelfEmployment2 { get; set; }

		[DataMember(Name="personPercentOfBusinessOwned1", EmitDefaultValue=false)]
		public int? PersonPercentOfBusinessOwned1 { get; set; }

		[DataMember(Name="personPercentOfBusinessOwned2", EmitDefaultValue=false)]
		public int? PersonPercentOfBusinessOwned2 { get; set; }

		[DataMember(Name="premiumSource", EmitDefaultValue=false)]
		public string PremiumSource { get; set; }

		[DataMember(Name="presentHousingExpense", EmitDefaultValue=false)]
		public double? PresentHousingExpense { get; set; }

		[DataMember(Name="processingPoint", EmitDefaultValue=false)]
		public string ProcessingPoint { get; set; }

		[DataMember(Name="propertyType", EmitDefaultValue=false)]
		public string PropertyType { get; set; }

		[DataMember(Name="purposeOfLoan", EmitDefaultValue=false)]
		public string PurposeOfLoan { get; set; }

		[DataMember(Name="renewalOption", EmitDefaultValue=false)]
		public string RenewalOption { get; set; }

		[DataMember(Name="renewalType", EmitDefaultValue=false)]
		public string RenewalType { get; set; }

		[DataMember(Name="requiredDocumentType", EmitDefaultValue=false)]
		public string RequiredDocumentType { get; set; }

		[DataMember(Name="reserves", EmitDefaultValue=false)]
		public double? Reserves { get; set; }

		[DataMember(Name="retailLoanIndicator", EmitDefaultValue=false)]
		public bool? RetailLoanIndicator { get; set; }

		[DataMember(Name="riskClass", EmitDefaultValue=false)]
		public string RiskClass { get; set; }

		[DataMember(Name="riskGradeEvaluationType", EmitDefaultValue=false)]
		public string RiskGradeEvaluationType { get; set; }

		[DataMember(Name="salesConcessions", EmitDefaultValue=false)]
		public double? SalesConcessions { get; set; }

		[DataMember(Name="secondaryFinancingType", EmitDefaultValue=false)]
		public string SecondaryFinancingType { get; set; }

		[DataMember(Name="secondTrustRefiIndicator", EmitDefaultValue=false)]
		public bool? SecondTrustRefiIndicator { get; set; }

		[DataMember(Name="simulatedPITI", EmitDefaultValue=false)]
		public double? SimulatedPITI { get; set; }

		[DataMember(Name="sizeOfHousehold", EmitDefaultValue=false)]
		public string SizeOfHousehold { get; set; }

		[DataMember(Name="specialInstruction1", EmitDefaultValue=false)]
		public string SpecialInstruction1 { get; set; }

		[DataMember(Name="specialInstruction2", EmitDefaultValue=false)]
		public string SpecialInstruction2 { get; set; }

		[DataMember(Name="specialInstruction3", EmitDefaultValue=false)]
		public string SpecialInstruction3 { get; set; }

		[DataMember(Name="specialInstruction4", EmitDefaultValue=false)]
		public string SpecialInstruction4 { get; set; }

		[DataMember(Name="specialInstruction5", EmitDefaultValue=false)]
		public string SpecialInstruction5 { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="transferLoanToConduitIndicator", EmitDefaultValue=false)]
		public bool? TransferLoanToConduitIndicator { get; set; }

		[DataMember(Name="yearsOfCoverage", EmitDefaultValue=false)]
		public string YearsOfCoverage { get; set; }

	}
}