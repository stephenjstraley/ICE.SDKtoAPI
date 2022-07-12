using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLock
	{
		[DataMember(Name="actualSellAmount", EmitDefaultValue=false)]
		public double? ActualSellAmount { get; set; }

		[DataMember(Name="actualSellPrice", EmitDefaultValue=false)]
		public double? ActualSellPrice { get; set; }

		[DataMember(Name="actualSellSideSRP", EmitDefaultValue=false)]
		public double? ActualSellSideSRP { get; set; }

		[DataMember(Name="actualSRPAmount", EmitDefaultValue=false)]
		public double? ActualSRPAmount { get; set; }

		[DataMember(Name="amountDue", EmitDefaultValue=false)]
		public double? AmountDue { get; set; }

		[DataMember(Name="amountDueTo", EmitDefaultValue=false)]
		public string AmountDueTo { get; set; }

		[DataMember(Name="amountPaid", EmitDefaultValue=false)]
		public double? AmountPaid { get; set; }

		[DataMember(Name="amountPaidTo", EmitDefaultValue=false)]
		public string AmountPaidTo { get; set; }

		[DataMember(Name="amountReceived", EmitDefaultValue=false)]
		public double? AmountReceived { get; set; }

		[DataMember(Name="balloonLoanMaturityTermMonths", EmitDefaultValue=false)]
		public int? BalloonLoanMaturityTermMonths { get; set; }

		[DataMember(Name="baseLoanAmount", EmitDefaultValue=false)]
		public double? BaseLoanAmount { get; set; }

		[DataMember(Name="borrLenderPaid", EmitDefaultValue=false)]
		public string BorrLenderPaid { get; set; }

		[DataMember(Name="borrowerRequestedLoanAmount", EmitDefaultValue=false)]
		public double? BorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="branchApprovalDate", EmitDefaultValue=false)]
		public DateTime? BranchApprovalDate { get; set; }

		[DataMember(Name = "branchApprovalDate2")]
		public string BranchApprovalDate2 { get; set; }

		[DataMember(Name = "branchApprovalDate3")]
		public string BranchApprovalDate3 { get; set; }

		[DataMember(Name = "branchApprovalDate4")]
		public string BranchApprovalDate4 { get; set; }

		[DataMember(Name = "branchApprovalDate5")]
		public string BranchApprovalDate5 { get; set; }

		[DataMember(Name="branchApprovedBy", EmitDefaultValue=false)]
		public string BranchApprovedBy { get; set; }

		[DataMember(Name = "branchApprovedBy2", EmitDefaultValue = false)]
		public string BranchApprovedBy2 { get; set; }

		[DataMember(Name = "branchApprovedBy3", EmitDefaultValue = false)]
		public string BranchApprovedBy3 { get; set; }

		[DataMember(Name = "branchApprovedBy4", EmitDefaultValue = false)]
		public string BranchApprovedBy4 { get; set; }

		[DataMember(Name = "branchApprovedBy5", EmitDefaultValue = false)]
		public string BranchApprovedBy5 { get; set; }

		[DataMember(Name="branchPrice", EmitDefaultValue=false)]
		public double? BranchPrice { get; set; }

		[DataMember(Name = "branchPrice2")]
		public decimal? BranchPrice2 { get; set; }

		[DataMember(Name = "branchPrice3")]
		public decimal? BranchPrice3 { get; set; }

		[DataMember(Name = "branchPrice4")]
		public decimal? BranchPrice4 { get; set; }

		[DataMember(Name = "branchPrice5")]
		public decimal? BranchPrice5 { get; set; }

		[DataMember(Name="buySideAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> BuySideAdjustments { get; set; }

		[DataMember(Name="buySideComments", EmitDefaultValue=false)]
		public string BuySideComments { get; set; }

		[DataMember(Name="buySideCommitmentDate", EmitDefaultValue=false)]
		public DateTime? BuySideCommitmentDate { get; set; }

		[DataMember(Name="buySideCommitmentNumber", EmitDefaultValue=false)]
		public string BuySideCommitmentNumber { get; set; }

		[DataMember(Name="buySideCommitmentType", EmitDefaultValue=false)]
		public string BuySideCommitmentType { get; set; }

		[DataMember(Name="buySideCurrentRateSetDate", EmitDefaultValue=false)]
		public DateTime? BuySideCurrentRateSetDate { get; set; }

		[DataMember(Name="buySideDaystoExtend", EmitDefaultValue=false)]
		public int? BuySideDaystoExtend { get; set; }

		[DataMember(Name="buySideDeliveryExpirationDate", EmitDefaultValue=false)]
		public DateTime? BuySideDeliveryExpirationDate { get; set; }

		[DataMember(Name="buySideDeliveryType", EmitDefaultValue=false)]
		public string BuySideDeliveryType { get; set; }

		[DataMember(Name="buySideExpirationDate", EmitDefaultValue=false)]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="buySideExtendedLockExpires", EmitDefaultValue=false)]
		public DateTime? BuySideExtendedLockExpires { get; set; }

		[DataMember(Name = "buySideInvestor", EmitDefaultValue = false)]
		public string BuySideInvestor { get; set; }

		[DataMember(Name="buySideLockDate", EmitDefaultValue=false)]
		public DateTime? BuySideLockDate { get; set; }

		[DataMember(Name="buySideLockExpires", EmitDefaultValue=false)]
		public DateTime? BuySideLockExpires { get; set; }

		[DataMember(Name="buySideLockExtendPriceAdjustment", EmitDefaultValue=false)]
		public double? BuySideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="buySideMarginNetBuyRate", EmitDefaultValue=false)]
		public double? BuySideMarginNetBuyRate { get; set; }

		[DataMember(Name="buySideMarginRate", EmitDefaultValue=false)]
		public double? BuySideMarginRate { get; set; }

		[DataMember(Name="buySideMarginTotalAdjustment", EmitDefaultValue=false)]
		public double? BuySideMarginTotalAdjustment { get; set; }

		[DataMember(Name="buySideMasterCommitmentNumber", EmitDefaultValue=false)]
		public string BuySideMasterCommitmentNumber { get; set; }

		[DataMember(Name="buySideNumberOfDays", EmitDefaultValue=false)]
		public int? BuySideNumberOfDays { get; set; }

		[DataMember(Name="buySideOnrpEligible", EmitDefaultValue=false)]
		public bool? BuySideOnrpEligible { get; set; }

		[DataMember(Name="buySideOnrpLockDate", EmitDefaultValue=false)]
		public DateTime? BuySideOnrpLockDate { get; set; }

		[DataMember(Name="buySideOnrpLockTime", EmitDefaultValue=false)]
		public string BuySideOnrpLockTime { get; set; }

		[DataMember(Name="buySideOrgID", EmitDefaultValue=false)]
		public string BuySideOrgID { get; set; }

		[DataMember(Name="buySideOriginalLockExpires", EmitDefaultValue=false)]
		public DateTime? BuySideOriginalLockExpires { get; set; }

		[DataMember(Name="buySidePriceNetBuyPrice", EmitDefaultValue=false)]
		public double? BuySidePriceNetBuyPrice { get; set; }

		[DataMember(Name="buySidePriceRate", EmitDefaultValue=false)]
		public double? BuySidePriceRate { get; set; }

		[DataMember(Name="buySidePriceTotalAdjustment", EmitDefaultValue=false)]
		public double? BuySidePriceTotalAdjustment { get; set; }

		[DataMember(Name="buySideRate", EmitDefaultValue=false)]
		public double? BuySideRate { get; set; }

		[DataMember(Name="buySideRateNetBuyRate", EmitDefaultValue=false)]
		public double? BuySideRateNetBuyRate { get; set; }

		[DataMember(Name="buySideRateSheetID", EmitDefaultValue=false)]
		public string BuySideRateSheetID { get; set; }

		[DataMember(Name="buySideRateTotalAdjustment", EmitDefaultValue=false)]
		public double? BuySideRateTotalAdjustment { get; set; }

		[DataMember(Name="buySideRequestedBy", EmitDefaultValue=false)]
		public string BuySideRequestedBy { get; set; }

		[DataMember(Name="buySideSRPPaidOut", EmitDefaultValue=false)]
		public double? BuySideSRPPaidOut { get; set; }

		[DataMember(Name="buySideStartingAdjPoint", EmitDefaultValue=false)]
		public double? BuySideStartingAdjPoint { get; set; }

		[DataMember(Name="buySideStartingAdjPrice", EmitDefaultValue=false)]
		public double? BuySideStartingAdjPrice { get; set; }

		[DataMember(Name="buySideStartingAdjRate", EmitDefaultValue=false)]
		public double? BuySideStartingAdjRate { get; set; }

		[DataMember(Name="buySideTPOID", EmitDefaultValue=false)]
		public string BuySideTPOID { get; set; }

		[DataMember(Name="buySideTPOName", EmitDefaultValue=false)]
		public string BuySideTPOName { get; set; }

		[DataMember(Name="buySideTradeGuid", EmitDefaultValue=false)]
		public string BuySideTradeGuid { get; set; }

		[DataMember(Name="buySideTradeNumber", EmitDefaultValue=false)]
		public string BuySideTradeNumber { get; set; }

		[DataMember(Name="buySideUnDiscountedRate", EmitDefaultValue=false)]
		public double? BuySideUnDiscountedRate { get; set; }

		[DataMember(Name="cancellationRequestPending", EmitDefaultValue=false)]
		public string CancellationRequestPending { get; set; }

		[DataMember(Name="combinedLTV", EmitDefaultValue=false)]
		public double? CombinedLTV { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="commitment", EmitDefaultValue=false)]
		public string Commitment { get; set; }

		[DataMember(Name="commitmentType", EmitDefaultValue=false)]
		public string CommitmentType { get; set; }

		[DataMember(Name="compGainLossPercentage", EmitDefaultValue=false)]
		public double? CompGainLossPercentage { get; set; }

		[DataMember(Name="compGainLossPrice", EmitDefaultValue=false)]
		public double? CompGainLossPrice { get; set; }

		[DataMember(Name="compGainLossTotalBuyPrice", EmitDefaultValue=false)]
		public double? CompGainLossTotalBuyPrice { get; set; }

		[DataMember(Name="compGainLossTotalCompPrice", EmitDefaultValue=false)]
		public double? CompGainLossTotalCompPrice { get; set; }

		[DataMember(Name="compInvestorAddress", EmitDefaultValue=false)]
		public string CompInvestorAddress { get; set; }

		[DataMember(Name="compInvestorCity", EmitDefaultValue=false)]
		public string CompInvestorCity { get; set; }

		[DataMember(Name="compInvestorCommitment", EmitDefaultValue=false)]
		public string CompInvestorCommitment { get; set; }

		[DataMember(Name="compInvestorContact", EmitDefaultValue=false)]
		public string CompInvestorContact { get; set; }

		[DataMember(Name="compInvestorEmail", EmitDefaultValue=false)]
		public string CompInvestorEmail { get; set; }

		[DataMember(Name="compInvestorLockType", EmitDefaultValue=false)]
		public string CompInvestorLockType { get; set; }

		[DataMember(Name="compInvestorName", EmitDefaultValue=false)]
		public string CompInvestorName { get; set; }

		[DataMember(Name="compInvestorPhone", EmitDefaultValue=false)]
		public string CompInvestorPhone { get; set; }

		[DataMember(Name="compInvestorPostalCode", EmitDefaultValue=false)]
		public string CompInvestorPostalCode { get; set; }

		[DataMember(Name="compInvestorProgramCode", EmitDefaultValue=false)]
		public string CompInvestorProgramCode { get; set; }

		[DataMember(Name="compInvestorState", EmitDefaultValue=false)]
		public string CompInvestorState { get; set; }

		[DataMember(Name="compInvestorTemplateName", EmitDefaultValue=false)]
		public string CompInvestorTemplateName { get; set; }

		[DataMember(Name="compInvestorWebsite", EmitDefaultValue=false)]
		public string CompInvestorWebsite { get; set; }

		[DataMember(Name="compSideAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> CompSideAdjustments { get; set; }

		[DataMember(Name="compSideComments", EmitDefaultValue=false)]
		public string CompSideComments { get; set; }

		[DataMember(Name="compSideComparisonedBy", EmitDefaultValue=false)]
		public string CompSideComparisonedBy { get; set; }

		[DataMember(Name="compSideCurrentRateSetDate", EmitDefaultValue=false)]
		public DateTime? CompSideCurrentRateSetDate { get; set; }

		[DataMember(Name="compSideDaystoExtend", EmitDefaultValue=false)]
		public int? CompSideDaystoExtend { get; set; }

		[DataMember(Name="compSideDiscountYSP", EmitDefaultValue=false)]
		public double? CompSideDiscountYSP { get; set; }

		[DataMember(Name="compSideExtendedLockExpires", EmitDefaultValue=false)]
		public DateTime? CompSideExtendedLockExpires { get; set; }

		[DataMember(Name="compSideInvestorStatus", EmitDefaultValue=false)]
		public string CompSideInvestorStatus { get; set; }

		[DataMember(Name="compSideInvestorStatusDate", EmitDefaultValue=false)]
		public DateTime? CompSideInvestorStatusDate { get; set; }

		[DataMember(Name="compSideInvestorTradeNumber", EmitDefaultValue=false)]
		public string CompSideInvestorTradeNumber { get; set; }

		[DataMember(Name="compSideLoanProgram", EmitDefaultValue=false)]
		public string CompSideLoanProgram { get; set; }

		[DataMember(Name="compSideLockDate", EmitDefaultValue=false)]
		public DateTime? CompSideLockDate { get; set; }

		[DataMember(Name="compSideLockExpires", EmitDefaultValue=false)]
		public DateTime? CompSideLockExpires { get; set; }

		[DataMember(Name="compSideLockExtendPriceAdjustment", EmitDefaultValue=false)]
		public double? CompSideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="compSideMarginNetCompRate", EmitDefaultValue=false)]
		public double? CompSideMarginNetCompRate { get; set; }

		[DataMember(Name="compSideMarginRate", EmitDefaultValue=false)]
		public double? CompSideMarginRate { get; set; }

		[DataMember(Name="compSideMarginTotalAdjustment", EmitDefaultValue=false)]
		public double? CompSideMarginTotalAdjustment { get; set; }

		[DataMember(Name="compSideMasterContractNumber", EmitDefaultValue=false)]
		public string CompSideMasterContractNumber { get; set; }

		[DataMember(Name="compSideNetCompPrice", EmitDefaultValue=false)]
		public double? CompSideNetCompPrice { get; set; }

		[DataMember(Name="compSideNetCompRate", EmitDefaultValue=false)]
		public double? CompSideNetCompRate { get; set; }

		[DataMember(Name="compSideNumberOfDays", EmitDefaultValue=false)]
		public int? CompSideNumberOfDays { get; set; }

		[DataMember(Name="compSideOriginalLockExpires", EmitDefaultValue=false)]
		public DateTime? CompSideOriginalLockExpires { get; set; }

		[DataMember(Name="compSidePriceRate", EmitDefaultValue=false)]
		public double? CompSidePriceRate { get; set; }

		[DataMember(Name="compSidePriceTotalAdjustment", EmitDefaultValue=false)]
		public double? CompSidePriceTotalAdjustment { get; set; }

		[DataMember(Name="compSideRate", EmitDefaultValue=false)]
		public double? CompSideRate { get; set; }

		[DataMember(Name="compSideRateSheetID", EmitDefaultValue=false)]
		public string CompSideRateSheetID { get; set; }

		[DataMember(Name="compSideRateTotalAdjustment", EmitDefaultValue=false)]
		public double? CompSideRateTotalAdjustment { get; set; }

		[DataMember(Name="compSideRequestedBy", EmitDefaultValue=false)]
		public string CompSideRequestedBy { get; set; }

		[DataMember(Name="compSideServicingType", EmitDefaultValue=false)]
		public string CompSideServicingType { get; set; }

		[DataMember(Name="compSideSRPPaidOut", EmitDefaultValue=false)]
		public double? CompSideSRPPaidOut { get; set; }

		[DataMember(Name="compSideTradeGuid", EmitDefaultValue=false)]
		public string CompSideTradeGuid { get; set; }

		[DataMember(Name="compSideTradeNumber", EmitDefaultValue=false)]
		public string CompSideTradeNumber { get; set; }

		[DataMember(Name="confirmedBy", EmitDefaultValue=false)]
		public string ConfirmedBy { get; set; }

		[DataMember(Name="confirmedDate", EmitDefaultValue=false)]
		public DateTime? ConfirmedDate { get; set; }

		[DataMember(Name="corporateApprovalDate", EmitDefaultValue=false)]
		public DateTime? CorporateApprovalDate { get; set; }

		[DataMember(Name = "corporateApprovalDate2")]
		public DateTime? CorporateApprovalDate2 { get; set; }

		[DataMember(Name = "corporateApprovalDate3")]
		public DateTime? CorporateApprovalDate3 { get; set; }

		[DataMember(Name = "corporateApprovalDate4")]
		public DateTime? CorporateApprovalDate4 { get; set; }

		[DataMember(Name = "corporateApprovalDate5")]
		public DateTime? CorporateApprovalDate5 { get; set; }

		[DataMember(Name="corporateApprovedby", EmitDefaultValue=false)]
		public string CorporateApprovedBy { get; set; }

		[DataMember(Name = "corporateApprovedBy2", EmitDefaultValue = false)]
		public string CorporateApprovedBy2 { get; set; }

		[DataMember(Name = "corporateApprovedBy3", EmitDefaultValue = false)]
		public string CorporateApprovedBy3 { get; set; }

		[DataMember(Name = "corporateApprovedBy4", EmitDefaultValue = false)]
		public string CorporateApprovedBy4 { get; set; }

		[DataMember(Name = "corporateApprovedBy5", EmitDefaultValue = false)]
		public string CorporateApprovedBy5 { get; set; }

		[DataMember(Name="corporatePrice", EmitDefaultValue=false)]
		public double? CorporatePrice { get; set; }

		[DataMember(Name = "corporatePrice2")]
		public double? CorporatePrice2 { get; set; }

		[DataMember(Name = "corporatePrice3")]
		public double? CorporatePrice3 { get; set; }

		[DataMember(Name = "corporatePrice4")]
		public decimal? CorporatePrice4 { get; set; }

		[DataMember(Name = "corporatePrice5")]
		public double? CorporatePrice5 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAdditionalEscrow", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowAdditionalEscrow { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1007", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowAmount1007 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1008", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowAmount1008 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1009", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowAmount1009 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowCityPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowCityPropertyTax { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1007", EmitDefaultValue=false)]
		public string CorrespondentAdditionalEscrowDescription1007 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1008", EmitDefaultValue=false)]
		public string CorrespondentAdditionalEscrowDescription1008 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1009", EmitDefaultValue=false)]
		public string CorrespondentAdditionalEscrowDescription1009 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowFloodInsurance", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowFloodInsurance { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowHomeInsurance", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowHomeInsurance { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowMIMIP", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowMIMIP { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowNumOfPayments", EmitDefaultValue=false)]
		public int? CorrespondentAdditionalEscrowNumOfPayments { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption1Amount", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowOption1Amount { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption1Desc", EmitDefaultValue=false)]
		public string CorrespondentAdditionalEscrowOption1Desc { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption2Amount", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowOption2Amount { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption2Desc", EmitDefaultValue=false)]
		public string CorrespondentAdditionalEscrowOption2Desc { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowPropertyTax { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowSumOfPayments", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowSumOfPayments { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowUSDAAnnualFee", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalEscrowUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount1", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount1 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount10", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount10 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount11", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount11 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount12", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount12 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount13", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount13 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount2", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount2 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount3", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount3 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount4", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount4 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount5", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount5 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount6", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount6 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount7", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount7 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount8", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount8 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount9", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineAmount9 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription1", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription1 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription10", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription10 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription11", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription11 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription12", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription12 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription2", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription2 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription3", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription3 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription4", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription4 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription5", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription5 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription6", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription6 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription7", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription7 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription8", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription8 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription9", EmitDefaultValue=false)]
		public string CorrespondentAdditionalLineDescription9 { get; set; }

		[DataMember(Name="correspondentAdditionalLineTotalAmount", EmitDefaultValue=false)]
		public double? CorrespondentAdditionalLineTotalAmount { get; set; }

		[DataMember(Name="correspondentAdjusterAmount1", EmitDefaultValue=false)]
		public double? CorrespondentAdjusterAmount1 { get; set; }

		[DataMember(Name="correspondentAdjusterAmount2", EmitDefaultValue=false)]
		public double? CorrespondentAdjusterAmount2 { get; set; }

		[DataMember(Name="correspondentAdjusterAmount3", EmitDefaultValue=false)]
		public double? CorrespondentAdjusterAmount3 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription1", EmitDefaultValue=false)]
		public string CorrespondentAdjusterDescription1 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription2", EmitDefaultValue=false)]
		public string CorrespondentAdjusterDescription2 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription3", EmitDefaultValue=false)]
		public string CorrespondentAdjusterDescription3 { get; set; }

		[DataMember(Name="correspondentConfirmedBy", EmitDefaultValue=false)]
		public string CorrespondentConfirmedBy { get; set; }

		[DataMember(Name="correspondentConfirmedDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentConfirmedDate { get; set; }

		[DataMember(Name="correspondentCurrentImpounds", EmitDefaultValue=false)]
		public double? CorrespondentCurrentImpounds { get; set; }

		[DataMember(Name="correspondentCurrentPrincipal", EmitDefaultValue=false)]
		public double? CorrespondentCurrentPrincipal { get; set; }

		[DataMember(Name="correspondentDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentDate { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1007", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsAmount1007 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1008", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsAmount1008 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1009", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsAmount1009 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsCityPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsCityPropertyTax { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1007", EmitDefaultValue=false)]
		public string CorrespondentEscrowDisbursementsDescription1007 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1008", EmitDefaultValue=false)]
		public string CorrespondentEscrowDisbursementsDescription1008 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1009", EmitDefaultValue=false)]
		public string CorrespondentEscrowDisbursementsDescription1009 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsEscrowsToBePaidBySeller", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsEsrowFundedByInvestor", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsFloodInsurance", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsFloodInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsHomeInsurance", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsHomeInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsMortgageInsurance", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsMortgageInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption1Amount", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsOption1Amount { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption1Desc", EmitDefaultValue=false)]
		public string CorrespondentEscrowDisbursementsOption1Desc { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption2Amount", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsOption2Amount { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption2Desc", EmitDefaultValue=false)]
		public string CorrespondentEscrowDisbursementsOption2Desc { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsPropertyTax { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsUSDAAnnualFee", EmitDefaultValue=false)]
		public double? CorrespondentEscrowDisbursementsUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentFinalBuyAmount", EmitDefaultValue=false)]
		public double? CorrespondentFinalBuyAmount { get; set; }

		[DataMember(Name="correspondentFinalBuyPrice", EmitDefaultValue=false)]
		public double? CorrespondentFinalBuyPrice { get; set; }

		[DataMember(Name="correspondentFinalCDAggAdjAmount", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDAggAdjAmount { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1007", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDAmount1007 { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1008", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDAmount1008 { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1009", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDAmount1009 { get; set; }

		[DataMember(Name="correspondentFinalCDCityPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDCityPropertyTax { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1007", EmitDefaultValue=false)]
		public string CorrespondentFinalCDDescription1007 { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1008", EmitDefaultValue=false)]
		public string CorrespondentFinalCDDescription1008 { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1009", EmitDefaultValue=false)]
		public string CorrespondentFinalCDDescription1009 { get; set; }

		[DataMember(Name="correspondentFinalCDFloodInsurance", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDFloodInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDHomeInsurance", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDHomeInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDMortgageInsurance", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDMortgageInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDOption1Amount", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDOption1Amount { get; set; }

		[DataMember(Name="correspondentFinalCDOption1Desc", EmitDefaultValue=false)]
		public string CorrespondentFinalCDOption1Desc { get; set; }

		[DataMember(Name="correspondentFinalCDOption2Amount", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDOption2Amount { get; set; }

		[DataMember(Name="correspondentFinalCDOption2Desc", EmitDefaultValue=false)]
		public string CorrespondentFinalCDOption2Desc { get; set; }

		[DataMember(Name="correspondentFinalCDPropertyTax", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDPropertyTax { get; set; }

		[DataMember(Name="correspondentFinalCDReservesCollectedAtClosing", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDReservesCollectedAtClosing { get; set; }

		[DataMember(Name="correspondentFinalCDUSDAAnnualFee", EmitDefaultValue=false)]
		public double? CorrespondentFinalCDUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentFirstPaymentDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentFirstPaymentDate { get; set; }

		[DataMember(Name="correspondentImpounds", EmitDefaultValue=false)]
		public double? CorrespondentImpounds { get; set; }

		[DataMember(Name="correspondentInterest", EmitDefaultValue=false)]
		public double? CorrespondentInterest { get; set; }

		[DataMember(Name="correspondentInterestDays", EmitDefaultValue=false)]
		public int? CorrespondentInterestDays { get; set; }

		[DataMember(Name="correspondentLateFeeAmount", EmitDefaultValue=false)]
		public double? CorrespondentLateFeeAmount { get; set; }

		[DataMember(Name="correspondentLateFeePriceAdjustment", EmitDefaultValue=false)]
		public double? CorrespondentLateFeePriceAdjustment { get; set; }

		[DataMember(Name="correspondentPaidToDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentPaidToDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryAnticipatedPurchaseDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryCalculatedPurchasedPrincipal", EmitDefaultValue=false)]
		public double? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get; set; }

		[DataMember(Name="correspondentPaymentHistoryFirstBorrowerPaymentDueDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryFirstInvestorPaymentDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryNoteDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentPaymentHistoryNoteDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryPricipalReduction", EmitDefaultValue=false)]
		public double? CorrespondentPaymentHistoryPricipalReduction { get; set; }

		[DataMember(Name="correspondentPurchasedPrincipal", EmitDefaultValue=false)]
		public double? CorrespondentPurchasedPrincipal { get; set; }

		[DataMember(Name="correspondentReconcilationComments", EmitDefaultValue=false)]
		public string CorrespondentReconcilationComments { get; set; }

		[DataMember(Name="correspondentRemainingBuydownAmount", EmitDefaultValue=false)]
		public double? CorrespondentRemainingBuydownAmount { get; set; }

		[DataMember(Name="correspondentSRPAmount", EmitDefaultValue=false)]
		public double? CorrespondentSRPAmount { get; set; }

		[DataMember(Name="correspondentTotalBuyAmount", EmitDefaultValue=false)]
		public double? CorrespondentTotalBuyAmount { get; set; }

		[DataMember(Name="correspondentTotalFees", EmitDefaultValue=false)]
		public double? CorrespondentTotalFees { get; set; }

		[DataMember(Name="correspondentWarehouseBankABANum", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankABANum { get; set; }

		[DataMember(Name="correspondentWarehouseBankAcctName", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankAcctName { get; set; }

		[DataMember(Name="correspondentWarehouseBankAcctNum", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankAcctNum { get; set; }

		[DataMember(Name="correspondentWarehouseBankAddress", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankAddress { get; set; }

		[DataMember(Name="correspondentWarehouseBankAddress1", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankAddress1 { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeExpirationDate", EmitDefaultValue=false)]
		public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeLetterReceivedIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeLetterReqIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankCity", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankCity { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactEmail", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankContactEmail { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactFax", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankContactFax { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactName", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankContactName { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactPhone", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankContactPhone { get; set; }

		[DataMember(Name="correspondentWarehouseBankDescription", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankDescription { get; set; }

		[DataMember(Name="correspondentWarehouseBankFurtherCreditAcctName", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankFurtherCreditAcctName { get; set; }

		[DataMember(Name="correspondentWarehouseBankFurtherCreditAcctNum", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankFurtherCreditAcctNum { get; set; }

		[DataMember(Name= "correspondentWarehouseBankId", EmitDefaultValue=false)]
		public int? CorrespondentWarehouseBankId { get; set; }

		[DataMember(Name="correspondentWarehouseBankName", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankName { get; set; }

		[DataMember(Name="correspondentWarehouseBankNotes", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankNotes { get; set; }

		[DataMember(Name="correspondentWarehouseBankSelfFunderIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankSelfFunderIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankState", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankState { get; set; }

		[DataMember(Name="correspondentWarehouseBankTriPartyContractIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankUseDefaultContactIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankWireConfirmationNumber", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankWireConfirmationNumber { get; set; }

		[DataMember(Name="correspondentWarehouseBankWireInstructionsReceivedIndicator", EmitDefaultValue=false)]
		public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankZip", EmitDefaultValue=false)]
		public string CorrespondentWarehouseBankZip { get; set; }

		[DataMember(Name="creditScoreToUse", EmitDefaultValue=false)]
		public string CreditScoreToUse { get; set; }

		[DataMember(Name="cumulatedDaystoExtend", EmitDefaultValue=false)]
		public int? CumulatedDaystoExtend { get; set; }

		[DataMember(Name="currentAcquisition", EmitDefaultValue=false)]
		public bool? CurrentAcquisition { get; set; }

		[DataMember(Name="currentAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> CurrentAdjustments { get; set; }

		[DataMember(Name="currentComments", EmitDefaultValue=false)]
		public string CurrentComments { get; set; }

		[DataMember(Name="currentConstructionRefi", EmitDefaultValue=false)]
		public bool? CurrentConstructionRefi { get; set; }

		[DataMember(Name="currentLockDate", EmitDefaultValue=false)]
		public DateTime? CurrentLockDate { get; set; }

		[DataMember(Name="currentLockExpires", EmitDefaultValue=false)]
		public DateTime? CurrentLockExpires { get; set; }

		[DataMember(Name="currentMarginRate", EmitDefaultValue=false)]
		public double? CurrentMarginRate { get; set; }

		[DataMember(Name="currentMarginRateRequested", EmitDefaultValue=false)]
		public double? CurrentMarginRateRequested { get; set; }

		[DataMember(Name="currentMarginTotalAdjustment", EmitDefaultValue=false)]
		public double? CurrentMarginTotalAdjustment { get; set; }

		[DataMember(Name="currentNumberOfDays", EmitDefaultValue=false)]
		public int? CurrentNumberOfDays { get; set; }

		[DataMember(Name="currentPriceRate", EmitDefaultValue=false)]
		public double? CurrentPriceRate { get; set; }

		[DataMember(Name="currentPriceRateRequested", EmitDefaultValue=false)]
		public double? CurrentPriceRateRequested { get; set; }

		[DataMember(Name="currentPriceTotalAdjustment", EmitDefaultValue=false)]
		public double? CurrentPriceTotalAdjustment { get; set; }

		[DataMember(Name="currentRate", EmitDefaultValue=false)]
		public double? CurrentRate { get; set; }

		[DataMember(Name="currentRateRequested", EmitDefaultValue=false)]
		public double? CurrentRateRequested { get; set; }

		[DataMember(Name="currentRateSetDate", EmitDefaultValue=false)]
		public DateTime? CurrentRateSetDate { get; set; }

		[DataMember(Name="currentRateSheetID", EmitDefaultValue=false)]
		public string CurrentRateSheetID { get; set; }

		[DataMember(Name="currentRateTotalAdjustment", EmitDefaultValue=false)]
		public double? CurrentRateTotalAdjustment { get; set; }

		[DataMember(Name="date", EmitDefaultValue=false)]
		public DateTime? Date { get; set; }

		[DataMember(Name="dateFirstPaymentToInvestor", EmitDefaultValue=false)]
		public DateTime? DateFirstPaymentToInvestor { get; set; }

		[DataMember(Name="dateLockedWithInvestor", EmitDefaultValue=false)]
		public DateTime? DateLockedWithInvestor { get; set; }

		[DataMember(Name="dateSold", EmitDefaultValue=false)]
		public DateTime? DateSold { get; set; }

		[DataMember(Name="dateWarehoused", EmitDefaultValue=false)]
		public DateTime? DateWarehoused { get; set; }

		[DataMember(Name="daysToExtend", EmitDefaultValue=false)]
		public int? DaysToExtend { get; set; }

		[DataMember(Name="deliveryType", EmitDefaultValue=false)]
		public string DeliveryType { get; set; }

		[DataMember(Name="diffAmountReceived", EmitDefaultValue=false)]
		public double? DiffAmountReceived { get; set; }

		[DataMember(Name="diffImpounds", EmitDefaultValue=false)]
		public double? DiffImpounds { get; set; }

		[DataMember(Name="diffInterest", EmitDefaultValue=false)]
		public double? DiffInterest { get; set; }

		[DataMember(Name="diffPremium", EmitDefaultValue=false)]
		public double? DiffPremium { get; set; }

		[DataMember(Name="diffPrinciple", EmitDefaultValue=false)]
		public double? DiffPrinciple { get; set; }

		[DataMember(Name="diffRemainingBuydownFunds", EmitDefaultValue=false)]
		public double? DiffRemainingBuydownFunds { get; set; }

		[DataMember(Name="diffSellAmount", EmitDefaultValue=false)]
		public double? DiffSellAmount { get; set; }

		[DataMember(Name="diffSellPrice", EmitDefaultValue=false)]
		public double? DiffSellPrice { get; set; }

		[DataMember(Name="diffSellSideSRP", EmitDefaultValue=false)]
		public double? DiffSellSideSRP { get; set; }

		[DataMember(Name="diffSRP", EmitDefaultValue=false)]
		public double? DiffSRP { get; set; }

		[DataMember(Name="diffSRPAmount", EmitDefaultValue=false)]
		public double? DiffSRPAmount { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator1", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator1 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator10", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator10 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator11", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator11 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator12", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator12 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator2", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator2 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator3", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator3 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator4", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator4 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator5", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator5 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator6", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator6 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator7", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator7 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator8", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator8 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator9", EmitDefaultValue=false)]
		public bool? EmploymentBorrowerSelfEmployedIndicator9 { get; set; }

		[DataMember(Name = "energyImprovementAmount")]
		public decimal? energyImprovementAmount { get; set; }

		[DataMember(Name="expectedAmountReceived", EmitDefaultValue=false)]
		public double? ExpectedAmountReceived { get; set; }

		[DataMember(Name="expectedImpounds", EmitDefaultValue=false)]
		public double? ExpectedImpounds { get; set; }

		[DataMember(Name="expectedInterest", EmitDefaultValue=false)]
		public double? ExpectedInterest { get; set; }

		[DataMember(Name="expectedPremium", EmitDefaultValue=false)]
		public double? ExpectedPremium { get; set; }

		[DataMember(Name="expectedPrinciple", EmitDefaultValue=false)]
		public double? ExpectedPrinciple { get; set; }

		[DataMember(Name="expectedRemainingBuydownFunds", EmitDefaultValue=false)]
		public double? ExpectedRemainingBuydownFunds { get; set; }

		[DataMember(Name="expectedSRP", EmitDefaultValue=false)]
		public double? ExpectedSRP { get; set; }

		[DataMember(Name="extensionRequestPending", EmitDefaultValue=false)]
		public string ExtensionRequestPending { get; set; }

		[DataMember(Name="extensionSequenceNumber", EmitDefaultValue=false)]
		public int? ExtensionSequenceNumber { get; set; }

		[DataMember(Name="extraPayments", EmitDefaultValue=false)]
		public List<LoanContractRateLockExtraPayments> ExtraPayments { get; set; }

		[DataMember(Name="fHAUpfrontMIPremiumPercent", EmitDefaultValue=false)]
		public double? FHAUpfrontMIPremiumPercent { get; set; }

		[DataMember(Name="financedNumberOfUnits", EmitDefaultValue=false)]
		public int? FinancedNumberOfUnits { get; set; }

		[DataMember(Name="firstPaymenTo", EmitDefaultValue=false)]
		public string FirstPaymenTo { get; set; }

		[DataMember(Name="firstSubordinateAmount", EmitDefaultValue=false)]
		public double? FirstSubordinateAmount { get; set; }

		[DataMember(Name="firstTimeHomebuyersIndicator", EmitDefaultValue=false)]
		public bool? FirstTimeHomebuyersIndicator { get; set; }

		[DataMember(Name="fNMProductPlanIdentifier", EmitDefaultValue=false)]
		public string FNMProductPlanIdentifier { get; set; }

		[DataMember(Name="fundingAmount", EmitDefaultValue=false)]
		public double? FundingAmount { get; set; }

		[DataMember(Name="gainLossPercentage", EmitDefaultValue=false)]
		public double? GainLossPercentage { get; set; }

		[DataMember(Name="gainLossPrice", EmitDefaultValue=false)]
		public double? GainLossPrice { get; set; }

		[DataMember(Name="gainLossTotalBuyPrice", EmitDefaultValue=false)]
		public double? GainLossTotalBuyPrice { get; set; }

		[DataMember(Name="gPMRate", EmitDefaultValue=false)]
		public double? GPMRate { get; set; }

		[DataMember(Name="gPMYears", EmitDefaultValue=false)]
		public int? GPMYears { get; set; }

		[DataMember(Name="gSEPropertyType", EmitDefaultValue=false)]
		public string GSEPropertyType { get; set; }

		[DataMember(Name="hedging", EmitDefaultValue=false)]
		public string Hedging { get; set; }

		[DataMember(Name="hELOCActualBalance", EmitDefaultValue=false)]
		public string HELOCActualBalance { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="impounds", EmitDefaultValue=false)]
		public double? Impounds { get; set; }

		[DataMember(Name="impoundType", EmitDefaultValue=false)]
		public string ImpoundType { get; set; }

		[DataMember(Name="impoundWaived", EmitDefaultValue=false)]
		public string ImpoundWaived { get; set; }

		[DataMember(Name="impoundWavied", EmitDefaultValue=false)]
		public string ImpoundWavied { get; set; }

		[DataMember(Name="interest", EmitDefaultValue=false)]
		public double? Interest { get; set; }

		[DataMember(Name="investorAddress", EmitDefaultValue=false)]
		public string InvestorAddress { get; set; }

		[DataMember(Name="investorCity", EmitDefaultValue=false)]
		public string InvestorCity { get; set; }

		[DataMember(Name="investorCommitment", EmitDefaultValue=false)]
		public string InvestorCommitment { get; set; }

		[DataMember(Name="investorContact", EmitDefaultValue=false)]
		public string InvestorContact { get; set; }

		[DataMember(Name="investorDeliveryDate", EmitDefaultValue=false)]
		public DateTime? InvestorDeliveryDate { get; set; }

		[DataMember(Name="investorEmail", EmitDefaultValue=false)]
		public string InvestorEmail { get; set; }

		[DataMember(Name="investorLoanNumber", EmitDefaultValue=false)]
		public string InvestorLoanNumber { get; set; }

		[DataMember(Name="investorLockType", EmitDefaultValue=false)]
		public string InvestorLockType { get; set; }

		[DataMember(Name="investorMERSNumber", EmitDefaultValue=false)]
		public string InvestorMERSNumber { get; set; }

		[DataMember(Name="investorName", EmitDefaultValue=false)]
		public string InvestorName { get; set; }

		[DataMember(Name="investorPhone", EmitDefaultValue=false)]
		public string InvestorPhone { get; set; }

		[DataMember(Name="investorPostalCode", EmitDefaultValue=false)]
		public string InvestorPostalCode { get; set; }

		[DataMember(Name="investorProgramCode", EmitDefaultValue=false)]
		public string InvestorProgramCode { get; set; }

		[DataMember(Name="investorState", EmitDefaultValue=false)]
		public string InvestorState { get; set; }

		[DataMember(Name="investorTargetDeliveryDate", EmitDefaultValue=false)]
		public DateTime? InvestorTargetDeliveryDate { get; set; }

		[DataMember(Name="investorTemplateName", EmitDefaultValue=false)]
		public string InvestorTemplateName { get; set; }

		[DataMember(Name="investorWebsite", EmitDefaultValue=false)]
		public string InvestorWebsite { get; set; }

		[DataMember(Name="isCancelled", EmitDefaultValue=false)]
		public string IsCancelled { get; set; }

		[DataMember(Name="isDeliveryType", EmitDefaultValue=false)]
		public bool? IsDeliveryType { get; set; }

		[DataMember(Name="lenderFeeWaiverOption", EmitDefaultValue=false)]
		public bool? LenderFeeWaiverOption { get; set; }

		[DataMember(Name="lenderPaidMortgageInsuranceIndicator", EmitDefaultValue=false)]
		public bool? LenderPaidMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="lienPriorityType", EmitDefaultValue=false)]
		public string LienPriorityType { get; set; }

		[DataMember(Name="loanAmortizationTermMonths", EmitDefaultValue=false)]
		public int? LoanAmortizationTermMonths { get; set; }

		[DataMember(Name="loanAmortizationType", EmitDefaultValue=false)]
		public string LoanAmortizationType { get; set; }

		[DataMember(Name="loanDocumentationType", EmitDefaultValue=false)]
		public string LoanDocumentationType { get; set; }

		[DataMember(Name="loanFor203K", EmitDefaultValue=false)]
		public bool? LoanFor203K { get; set; }

		[DataMember(Name="loanProgram", EmitDefaultValue=false)]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanProgramFile", EmitDefaultValue=false)]
		public string LoanProgramFile { get; set; }

		[DataMember(Name="loanScheduledClosingDate", EmitDefaultValue=false)]
		public DateTime? LoanScheduledClosingDate { get; set; }

		[DataMember(Name="lockField", EmitDefaultValue=false)]
		public bool? LockField { get; set; }

		[DataMember(Name="lockRequestAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> LockRequestAdjustments { get; set; }

		[DataMember(Name="lockRequestBorrowers", EmitDefaultValue=false)]
		public List<LoanContractRateLockLockRequestBorrowers> LockRequestBorrowers { get; set; }

		[DataMember(Name="lockRequestLoanPurposeType", EmitDefaultValue=false)]
		public string LockRequestLoanPurposeType { get; set; }

		[DataMember(Name="lTV", EmitDefaultValue=false)]
		public double? LTV { get; set; }

		[DataMember(Name="minFICO", EmitDefaultValue=false)]
		public string MinFICO { get; set; }

		[DataMember(Name="minFICO2", EmitDefaultValue=false)]
		public string MinFICO2 { get; set; }

		[DataMember(Name="mIPPaidInCash", EmitDefaultValue=false)]
		public double? MIPPaidInCash { get; set; }

		[DataMember(Name="mortgageType", EmitDefaultValue=false)]
		public string MortgageType { get; set; }

		[DataMember(Name="netSellAmount", EmitDefaultValue=false)]
		public double? NetSellAmount { get; set; }

		[DataMember(Name="netSellPrice", EmitDefaultValue=false)]
		public double? NetSellPrice { get; set; }

		[DataMember(Name="nextPaymentDate", EmitDefaultValue=false)]
		public DateTime? NextPaymentDate { get; set; }

		[DataMember(Name="noClosingCostOption", EmitDefaultValue=false)]
		public bool? NoClosingCostOption { get; set; }

		[DataMember(Name="oNRPLock", EmitDefaultValue=false)]
		public string ONRPLock { get; set; }

		[DataMember(Name="otherAmortizationTypeDescription", EmitDefaultValue=false)]
		public string OtherAmortizationTypeDescription { get; set; }

		[DataMember(Name="otherSubordinateAmount", EmitDefaultValue=false)]
		public double? OtherSubordinateAmount { get; set; }

		[DataMember(Name="perDiemInterestRoundingType", EmitDefaultValue=false)]
		public string PerDiemInterestRoundingType { get; set; }

		[DataMember(Name="planCode", EmitDefaultValue=false)]
		public string PlanCode { get; set; }

		[DataMember(Name="premium", EmitDefaultValue=false)]
		public double? Premium { get; set; }

		[DataMember(Name="prepayPenalty", EmitDefaultValue=false)]
		public string PrepayPenalty { get; set; }

		[DataMember(Name="priceAdjustment", EmitDefaultValue=false)]
		public double? PriceAdjustment { get; set; }

		[DataMember(Name="priceAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> PriceAdjustments { get; set; }

		[DataMember(Name="pricingHistoryData", EmitDefaultValue=false)]
		public string PricingHistoryData { get; set; }

		[DataMember(Name="pricingUpdated", EmitDefaultValue=false)]
		public string PricingUpdated { get; set; }

		[DataMember(Name="principle", EmitDefaultValue=false)]
		public double? Principle { get; set; }

		[DataMember(Name="profitMarginAdjustedBuyPrice", EmitDefaultValue=false)]
		public double? ProfitMarginAdjustedBuyPrice { get; set; }

		[DataMember(Name="propertyAppraisedValueAmount", EmitDefaultValue=false)]
		public int? PropertyAppraisedValueAmount { get; set; }

		[DataMember(Name="propertyEstimatedValueAmount", EmitDefaultValue=false)]
		public int? PropertyEstimatedValueAmount { get; set; }

		[DataMember(Name="propertyUsageType", EmitDefaultValue=false)]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="purchaseAdviceNumberOfDays", EmitDefaultValue=false)]
		public int? PurchaseAdviceNumberOfDays { get; set; }

		[DataMember(Name="purchaseAdvicePayouts", EmitDefaultValue=false)]
		public List<LoanContractRateLockPurchaseAdvicePayouts> PurchaseAdvicePayouts { get; set; }

		[DataMember(Name="purchasePriceAmount", EmitDefaultValue=false)]
		public double? PurchasePriceAmount { get; set; }

		[DataMember(Name="rateRequestStatus", EmitDefaultValue=false)]
		public string RateRequestStatus { get; set; }

		[DataMember(Name="rateStatus", EmitDefaultValue=false)]
		public string RateStatus { get; set; }

		[DataMember(Name="reasonforBranchApproval", EmitDefaultValue=false)]
		public string ReasonforBranchApproval { get; set; }

		[DataMember(Name = "reasonforBranchApproval2")]
		public string ReasonforBranchApproval2 { get; set; }

		[DataMember(Name = "reasonforBranchApproval3")]
		public string ReasonforBranchApproval3 { get; set; }

		[DataMember(Name = "reasonforBranchApproval4")]
		public string ReasonforBranchApproval4 { get; set; }

		[DataMember(Name="reasonforCorporateApproval", EmitDefaultValue=false)]
		public string ReasonforCorporateApproval { get; set; }

		[DataMember(Name = "reasonForCorporateApproval2")]
		public string ReasonForCorporateApproval2 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval3")]
		public string ReasonForCorporateApproval3 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval4")]
		public string ReasonForCorporateApproval4 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval5")]
		public string ReasonForCorporateApproval5 { get; set; }

		[DataMember(Name="reconciledDiff", EmitDefaultValue=false)]
		public double? ReconciledDiff { get; set; }

		[DataMember(Name="reLockRequestPending", EmitDefaultValue=false)]
		public string ReLockRequestPending { get; set; }

		[DataMember(Name="remainingBuydownFunds", EmitDefaultValue=false)]
		public double? RemainingBuydownFunds { get; set; }

		[DataMember(Name="requestComments", EmitDefaultValue=false)]
		public string RequestComments { get; set; }

		[DataMember(Name="requestCurrentRateSetDate", EmitDefaultValue=false)]
		public DateTime? RequestCurrentRateSetDate { get; set; }

		[DataMember(Name="requestDaystoExtend", EmitDefaultValue=false)]
		public int? RequestDaystoExtend { get; set; }

		[DataMember(Name="requestExtendedLockExpires", EmitDefaultValue=false)]
		public DateTime? RequestExtendedLockExpires { get; set; }

		[DataMember(Name="requestFullfilledDateTime", EmitDefaultValue=false)]
		public string RequestFullfilledDateTime { get; set; }

		[DataMember(Name="requestImpoundType", EmitDefaultValue=false)]
		public string RequestImpoundType { get; set; }

		[DataMember(Name="requestImpoundWaived", EmitDefaultValue=false)]
		public string RequestImpoundWaived { get; set; }

		[DataMember(Name="requestImpoundWavied", EmitDefaultValue=false)]
		public string RequestImpoundWavied { get; set; }

		[DataMember(Name="requestLockCancellationComment", EmitDefaultValue=false)]
		public string RequestLockCancellationComment { get; set; }

		[DataMember(Name="requestLockCancellationDate", EmitDefaultValue=false)]
		public DateTime? RequestLockCancellationDate { get; set; }

		[DataMember(Name="requestLockDate", EmitDefaultValue=false)]
		public DateTime? RequestLockDate { get; set; }

		[DataMember(Name="requestLockExpires", EmitDefaultValue=false)]
		public DateTime? RequestLockExpires { get; set; }

		[DataMember(Name="requestLockExtendComment", EmitDefaultValue=false)]
		public string RequestLockExtendComment { get; set; }

		[DataMember(Name="requestLockExtendPriceAdjustment", EmitDefaultValue=false)]
		public double? RequestLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="requestLockStatus", EmitDefaultValue=false)]
		public string RequestLockStatus { get; set; }

		[DataMember(Name="requestLockType", EmitDefaultValue=false)]
		public string RequestLockType { get; set; }

		[DataMember(Name="requestMarginRate", EmitDefaultValue=false)]
		public double? RequestMarginRate { get; set; }

		[DataMember(Name="requestMarginRateRequested", EmitDefaultValue=false)]
		public double? RequestMarginRateRequested { get; set; }

		[DataMember(Name="requestMarginSRPPaidOut", EmitDefaultValue=false)]
		public double? RequestMarginSRPPaidOut { get; set; }

		[DataMember(Name="requestMarginTotalAdjustment", EmitDefaultValue=false)]
		public double? RequestMarginTotalAdjustment { get; set; }

		[DataMember(Name="requestNumberOfDays", EmitDefaultValue=false)]
		public int? RequestNumberOfDays { get; set; }

		[DataMember(Name="requestOnrpEligible", EmitDefaultValue=false)]
		public bool? RequestOnrpEligible { get; set; }

		[DataMember(Name="requestOnrpLockDate", EmitDefaultValue=false)]
		public DateTime? RequestOnrpLockDate { get; set; }

		[DataMember(Name="requestOnrpLockTime", EmitDefaultValue=false)]
		public string RequestOnrpLockTime { get; set; }

		[DataMember(Name="requestOriginalLockExpires", EmitDefaultValue=false)]
		public DateTime? RequestOriginalLockExpires { get; set; }

		[DataMember(Name="requestPenaltyTerm", EmitDefaultValue=false)]
		public string RequestPenaltyTerm { get; set; }

		[DataMember(Name="requestPending", EmitDefaultValue=false)]
		public string RequestPending { get; set; }

		[DataMember(Name="requestPrepayPenalty", EmitDefaultValue=false)]
		public string RequestPrepayPenalty { get; set; }

		[DataMember(Name="requestPriceRate", EmitDefaultValue=false)]
		public double? RequestPriceRate { get; set; }

		[DataMember(Name="requestPriceRateRequested", EmitDefaultValue=false)]
		public double? RequestPriceRateRequested { get; set; }

		[DataMember(Name="requestPriceTotalAdjustment", EmitDefaultValue=false)]
		public double? RequestPriceTotalAdjustment { get; set; }

		[DataMember(Name="requestProgramNotes", EmitDefaultValue=false)]
		public string RequestProgramNotes { get; set; }

		[DataMember(Name="requestRate", EmitDefaultValue=false)]
		public double? RequestRate { get; set; }

		[DataMember(Name="requestRateRequested", EmitDefaultValue=false)]
		public double? RequestRateRequested { get; set; }

		[DataMember(Name="requestRateSheetID", EmitDefaultValue=false)]
		public string RequestRateSheetID { get; set; }

		[DataMember(Name="requestRateTotalAdjustment", EmitDefaultValue=false)]
		public double? RequestRateTotalAdjustment { get; set; }

		[DataMember(Name="requestStartingAdjPoint", EmitDefaultValue=false)]
		public double? RequestStartingAdjPoint { get; set; }

		[DataMember(Name="requestStartingAdjRate", EmitDefaultValue=false)]
		public double? RequestStartingAdjRate { get; set; }

		[DataMember(Name="requestType", EmitDefaultValue=false)]
		public string RequestType { get; set; }

		[DataMember(Name="requestUnDiscountedRate", EmitDefaultValue=false)]
		public double? RequestUnDiscountedRate { get; set; }

		[DataMember(Name="roundToNearest50", EmitDefaultValue=false)]
		public bool? RoundToNearest50 { get; set; }

		[DataMember(Name="secondSubordinateAmount", EmitDefaultValue=false)]
		public double? SecondSubordinateAmount { get; set; }

		[DataMember(Name="sellerPaidMIPremium", EmitDefaultValue=false)]
		public double? SellerPaidMIPremium { get; set; }

		[DataMember(Name="sellSideAdjustments", EmitDefaultValue=false)]
		public List<LoanContractRateLockBuySideAdjustments> SellSideAdjustments { get; set; }

		[DataMember(Name="sellSideComments", EmitDefaultValue=false)]
		public string SellSideComments { get; set; }

		[DataMember(Name="sellSideCommitmentContractNumber", EmitDefaultValue=false)]
		public string SellSideCommitmentContractNumber { get; set; }

		[DataMember(Name="sellSideCommitmentDate", EmitDefaultValue=false)]
		public DateTime? SellSideCommitmentDate { get; set; }

		[DataMember(Name="sellSideCurrentRateSetDate", EmitDefaultValue=false)]
		public DateTime? SellSideCurrentRateSetDate { get; set; }

		[DataMember(Name="sellSideDaystoExtend", EmitDefaultValue=false)]
		public int? SellSideDaystoExtend { get; set; }

		[DataMember(Name="sellSideDiscountYSP", EmitDefaultValue=false)]
		public double? SellSideDiscountYSP { get; set; }

		[DataMember(Name="sellSideExtendedLockExpires", EmitDefaultValue=false)]
		public DateTime? SellSideExtendedLockExpires { get; set; }

		[DataMember(Name="sellSideGuaranteeFee", EmitDefaultValue=false)]
		public double? SellSideGuaranteeFee { get; set; }

		[DataMember(Name="sellSideGuarantyBaseFee", EmitDefaultValue=false)]
		public double? SellSideGuarantyBaseFee { get; set; }

		[DataMember(Name="sellSideInvestorStatus", EmitDefaultValue=false)]
		public string SellSideInvestorStatus { get; set; }

		[DataMember(Name="sellSideInvestorStatusDate", EmitDefaultValue=false)]
		public DateTime? SellSideInvestorStatusDate { get; set; }

		[DataMember(Name="sellSideInvestorTradeNumber", EmitDefaultValue=false)]
		public string SellSideInvestorTradeNumber { get; set; }

		[DataMember(Name="sellSideLoanProgram", EmitDefaultValue=false)]
		public string SellSideLoanProgram { get; set; }

		[DataMember(Name="sellSideLockDate", EmitDefaultValue=false)]
		public DateTime? SellSideLockDate { get; set; }

		[DataMember(Name="sellSideLockExpires", EmitDefaultValue=false)]
		public DateTime? SellSideLockExpires { get; set; }

		[DataMember(Name="sellSideLockExtendPriceAdjustment", EmitDefaultValue=false)]
		public double? SellSideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="sellSideMarginNetSellRate", EmitDefaultValue=false)]
		public double? SellSideMarginNetSellRate { get; set; }

		[DataMember(Name="sellSideMarginRate", EmitDefaultValue=false)]
		public double? SellSideMarginRate { get; set; }

		[DataMember(Name="sellSideMarginTotalAdjustment", EmitDefaultValue=false)]
		public double? SellSideMarginTotalAdjustment { get; set; }

		[DataMember(Name="sellSideMasterContractNumber", EmitDefaultValue=false)]
		public string SellSideMasterContractNumber { get; set; }

		[DataMember(Name="sellSideMSRValue", EmitDefaultValue=false)]
		public double? SellSideMSRValue { get; set; }

		[DataMember(Name="sellSideNetSellPrice", EmitDefaultValue=false)]
		public double? SellSideNetSellPrice { get; set; }

		[DataMember(Name="sellSideNetSellRate", EmitDefaultValue=false)]
		public double? SellSideNetSellRate { get; set; }

		[DataMember(Name="sellSideNumberOfDays", EmitDefaultValue=false)]
		public int? SellSideNumberOfDays { get; set; }

		[DataMember(Name="sellSideOriginalLockExpires", EmitDefaultValue=false)]
		public DateTime? SellSideOriginalLockExpires { get; set; }

		[DataMember(Name="sellSidePoolID", EmitDefaultValue=false)]
		public string SellSidePoolID { get; set; }

		[DataMember(Name="sellSidePoolNumber", EmitDefaultValue=false)]
		public string SellSidePoolNumber { get; set; }

		[DataMember(Name="sellSidePriceRate", EmitDefaultValue=false)]
		public double? SellSidePriceRate { get; set; }

		[DataMember(Name="sellSidePriceTotalAdjustment", EmitDefaultValue=false)]
		public double? SellSidePriceTotalAdjustment { get; set; }

		[DataMember(Name="sellSideProductName", EmitDefaultValue=false)]
		public string SellSideProductName { get; set; }

		[DataMember(Name="sellSideRate", EmitDefaultValue=false)]
		public double? SellSideRate { get; set; }

		[DataMember(Name="sellSideRateSheetID", EmitDefaultValue=false)]
		public string SellSideRateSheetID { get; set; }

		[DataMember(Name="sellSideRateTotalAdjustment", EmitDefaultValue=false)]
		public double? SellSideRateTotalAdjustment { get; set; }

		[DataMember(Name="sellSideRequestedBy", EmitDefaultValue=false)]
		public string SellSideRequestedBy { get; set; }

		[DataMember(Name="sellSideServicer", EmitDefaultValue=false)]
		public string SellSideServicer { get; set; }

		[DataMember(Name="sellSideServicingFee", EmitDefaultValue=false)]
		public double? SellSideServicingFee { get; set; }

		[DataMember(Name="sellSideServicingType", EmitDefaultValue=false)]
		public string SellSideServicingType { get; set; }

		[DataMember(Name="sellSideSRP", EmitDefaultValue=false)]
		public double? SellSideSRP { get; set; }

		[DataMember(Name="sellSideSRPPaidOut", EmitDefaultValue=false)]
		public double? SellSideSRPPaidOut { get; set; }

		[DataMember(Name="sellSideTradeGuid", EmitDefaultValue=false)]
		public string SellSideTradeGuid { get; set; }

		[DataMember(Name="sellSideTradeMgmtPrevConfirmedLockGuid", EmitDefaultValue=false)]
		public string SellSideTradeMgmtPrevConfirmedLockGuid { get; set; }

		[DataMember(Name="sellSideTradeNumber", EmitDefaultValue=false)]
		public string SellSideTradeNumber { get; set; }

		[DataMember(Name="servicingReleaseIndicator", EmitDefaultValue=false)]
		public bool? ServicingReleaseIndicator { get; set; }

		[DataMember(Name="sRP", EmitDefaultValue=false)]
		public double? SRP { get; set; }

		[DataMember(Name="sRPAmount", EmitDefaultValue=false)]
		public double? SRPAmount { get; set; }

		[DataMember(Name="sRPPaidOut", EmitDefaultValue=false)]
		public double? SRPPaidOut { get; set; }

		[DataMember(Name="subjectPropertyCity", EmitDefaultValue=false)]
		public string SubjectPropertyCity { get; set; }

		[DataMember(Name="subjectPropertyCondotelIndicator", EmitDefaultValue=false)]
		public bool? SubjectPropertyCondotelIndicator { get; set; }

		[DataMember(Name="subjectPropertyCounty", EmitDefaultValue=false)]
		public string SubjectPropertyCounty { get; set; }

		[DataMember(Name="subjectPropertyNonWarrantableProjectIndicator", EmitDefaultValue=false)]
		public bool? SubjectPropertyNonWarrantableProjectIndicator { get; set; }

		[DataMember(Name="subjectPropertyPostalCode", EmitDefaultValue=false)]
		public string SubjectPropertyPostalCode { get; set; }

		[DataMember(Name="subjectPropertyState", EmitDefaultValue=false)]
		public string SubjectPropertyState { get; set; }

		[DataMember(Name="subjectPropertyStreetAddress", EmitDefaultValue=false)]
		public string SubjectPropertyStreetAddress { get; set; }

		[DataMember(Name="timeLockedWithInvestor", EmitDefaultValue=false)]
		public string TimeLockedWithInvestor { get; set; }

		[DataMember(Name="totalBuyPrice", EmitDefaultValue=false)]
		public double? TotalBuyPrice { get; set; }

		[DataMember(Name="totalForLesserOfSumAsIs", EmitDefaultValue=false)]
		public double? TotalForLesserOfSumAsIs { get; set; }

		[DataMember(Name="totalPrice", EmitDefaultValue=false)]
		public double? TotalPrice { get; set; }

		[DataMember(Name="totalSubordinateFinancing", EmitDefaultValue=false)]
		public double? TotalSubordinateFinancing { get; set; }

		[DataMember(Name="twelveMonthMortgageRentalHistoryIndicator", EmitDefaultValue=false)]
		public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }

		[DataMember(Name="usePoint", EmitDefaultValue=false)]
		public bool? UsePoint { get; set; }

		[DataMember(Name = "hCLTVHTLTV", EmitDefaultValue = false)]
		public decimal? HCLTVHTLTV { get; set; }

		[DataMember(Name = "FHASecondaryResidence", EmitDefaultValue = false)]
		public bool? FHASecondaryResidence { get; set; }

		[DataMember(Name = "subjectPropertyPropertyStreetAddress", EmitDefaultValue = false)]
		public string SubjectPropertyPropertyStreetAddress { get; set; }

		[DataMember(Name = "hELOCCreditLimit", EmitDefaultValue = false)]
		public decimal? HELOCCreditLimit { get; set; }

		[DataMember(Name = "notInProjectIndicator", EmitDefaultValue = false)]
		public bool? NotInProjectIndicator { get; set; }

//		[DataMember(Name = "rateLockBuydowns")]
//		public List<RateLockBuydownContract> RateLockBuydowns { get; set; }

		[DataMember(Name = "PricingConcessionRequested")]
		public decimal? PricingConcessionRequested { get; set; }

		[DataMember(Name = "LockValidationStatus")]
		public string LockValidationStatus { get; set; }

		[DataMember(Name = "PriceConcessionIndicator")]
		public bool? PriceConcessionIndicator { get; set; }

		[DataMember(Name = "ExtensionIndicator")]
		public bool? ExtensionIndicator { get; set; }

		[DataMember(Name = "PriceConcessionRequestStatus")]
		public string PriceConcessionRequestStatus { get; set; }
	}
}