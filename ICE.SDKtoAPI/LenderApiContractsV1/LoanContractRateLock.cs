using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractRateLock
	{
		[DataMember(Name="actualSellAmount")]
		public decimal? ActualSellAmount { get; set; }

		[DataMember(Name="actualSellPrice")]
		public decimal? ActualSellPrice { get; set; }

		[DataMember(Name="actualSellSideSRP")]
		public decimal? ActualSellSideSRP { get; set; }

		[DataMember(Name="actualSRPAmount")]
		public decimal? ActualSRPAmount { get; set; }

		[DataMember(Name="amountDue")]
		public decimal? AmountDue { get; set; }

		[DataMember(Name="amountDueTo")]
		public string AmountDueTo { get; set; }

		[DataMember(Name="amountPaid")]
		public decimal? AmountPaid { get; set; }

		[DataMember(Name="amountPaidTo")]
		public string AmountPaidTo { get; set; }

		[DataMember(Name="amountReceived")]
		public decimal? AmountReceived { get; set; }

		[DataMember(Name="balloonLoanMaturityTermMonths")]
		public int? BalloonLoanMaturityTermMonths { get; set; }

		[DataMember(Name="baseLoanAmount")]
		public decimal? BaseLoanAmount { get; set; }

		[DataMember(Name="borrLenderPaid")]
		public string BorrLenderPaid { get; set; }

		[DataMember(Name="borrowerRequestedLoanAmount")]
		public decimal? BorrowerRequestedLoanAmount { get; set; }

		[DataMember(Name="branchApprovalDate")]
		public DateTime? BranchApprovalDate { get; set; }

		[DataMember(Name = "branchApprovalDate2")]
		public string BranchApprovalDate2 { get; set; }

		[DataMember(Name = "branchApprovalDate3")]
		public string BranchApprovalDate3 { get; set; }

		[DataMember(Name = "branchApprovalDate4")]
		public string BranchApprovalDate4 { get; set; }

		[DataMember(Name = "branchApprovalDate5")]
		public string BranchApprovalDate5 { get; set; }

		[DataMember(Name="branchApprovedBy")]
		public string BranchApprovedBy { get; set; }

		[DataMember(Name = "branchApprovedBy2")]
		public string BranchApprovedBy2 { get; set; }

		[DataMember(Name = "branchApprovedBy3")]
		public string BranchApprovedBy3 { get; set; }

		[DataMember(Name = "branchApprovedBy4")]
		public string BranchApprovedBy4 { get; set; }

		[DataMember(Name = "branchApprovedBy5")]
		public string BranchApprovedBy5 { get; set; }

		[DataMember(Name="branchPrice")]
		public decimal? BranchPrice { get; set; }

		[DataMember(Name = "branchPrice2")]
		public decimal? BranchPrice2 { get; set; }

		[DataMember(Name = "branchPrice3")]
		public decimal? BranchPrice3 { get; set; }

		[DataMember(Name = "branchPrice4")]
		public decimal? BranchPrice4 { get; set; }

		[DataMember(Name = "branchPrice5")]
		public decimal? BranchPrice5 { get; set; }

		[DataMember(Name="buySideAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> BuySideAdjustments { get; set; }

		[DataMember(Name="buySideComments")]
		public string BuySideComments { get; set; }

		[DataMember(Name="buySideCommitmentDate")]
		public DateTime? BuySideCommitmentDate { get; set; }

		[DataMember(Name="buySideCommitmentNumber")]
		public string BuySideCommitmentNumber { get; set; }

		[DataMember(Name="buySideCommitmentType")]
		public string BuySideCommitmentType { get; set; }

		[DataMember(Name="buySideCurrentRateSetDate")]
		public DateTime? BuySideCurrentRateSetDate { get; set; }

		[DataMember(Name="buySideDaystoExtend")]
		public int? BuySideDaystoExtend { get; set; }

		[DataMember(Name="buySideDeliveryExpirationDate")]
		public DateTime? BuySideDeliveryExpirationDate { get; set; }

		[DataMember(Name="buySideDeliveryType")]
		public string BuySideDeliveryType { get; set; }

		[DataMember(Name="buySideExpirationDate")]
		public DateTime? BuySideExpirationDate { get; set; }

		[DataMember(Name="buySideExtendedLockExpires")]
		public DateTime? BuySideExtendedLockExpires { get; set; }

		[DataMember(Name = "buySideInvestor")]
		public string BuySideInvestor { get; set; }

		[DataMember(Name="buySideLockDate")]
		public DateTime? BuySideLockDate { get; set; }

		[DataMember(Name="buySideLockExpires")]
		public DateTime? BuySideLockExpires { get; set; }

		[DataMember(Name="buySideLockExtendPriceAdjustment")]
		public decimal? BuySideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="buySideMarginNetBuyRate")]
		public decimal? BuySideMarginNetBuyRate { get; set; }

		[DataMember(Name="buySideMarginRate")]
		public decimal? BuySideMarginRate { get; set; }

		[DataMember(Name="buySideMarginTotalAdjustment")]
		public decimal? BuySideMarginTotalAdjustment { get; set; }

		[DataMember(Name="buySideMasterCommitmentNumber")]
		public string BuySideMasterCommitmentNumber { get; set; }

		[DataMember(Name="buySideNumberOfDays")]
		public int? BuySideNumberOfDays { get; set; }

		[DataMember(Name="buySideOnrpEligible")]
		public bool? BuySideOnrpEligible { get; set; }

		[DataMember(Name="buySideOnrpLockDate")]
		public DateTime? BuySideOnrpLockDate { get; set; }

		[DataMember(Name="buySideOnrpLockTime")]
		public string BuySideOnrpLockTime { get; set; }

		[DataMember(Name="buySideOrgID")]
		public string BuySideOrgID { get; set; }

		[DataMember(Name="buySideOriginalLockExpires")]
		public DateTime? BuySideOriginalLockExpires { get; set; }

		[DataMember(Name="buySidePriceNetBuyPrice")]
		public decimal? BuySidePriceNetBuyPrice { get; set; }

		[DataMember(Name="buySidePriceRate")]
		public decimal? BuySidePriceRate { get; set; }

		[DataMember(Name="buySidePriceTotalAdjustment")]
		public decimal? BuySidePriceTotalAdjustment { get; set; }

		[DataMember(Name="buySideRate")]
		public decimal? BuySideRate { get; set; }

		[DataMember(Name="buySideRateNetBuyRate")]
		public decimal? BuySideRateNetBuyRate { get; set; }

		[DataMember(Name="buySideRateSheetID")]
		public string BuySideRateSheetID { get; set; }

		[DataMember(Name="buySideRateTotalAdjustment")]
		public decimal? BuySideRateTotalAdjustment { get; set; }

		[DataMember(Name="buySideRequestedBy")]
		public string BuySideRequestedBy { get; set; }

		[DataMember(Name="buySideSRPPaidOut")]
		public decimal? BuySideSRPPaidOut { get; set; }

		[DataMember(Name="buySideStartingAdjPoint")]
		public decimal? BuySideStartingAdjPoint { get; set; }

		[DataMember(Name="buySideStartingAdjPrice")]
		public decimal? BuySideStartingAdjPrice { get; set; }

		[DataMember(Name="buySideStartingAdjRate")]
		public decimal? BuySideStartingAdjRate { get; set; }

		[DataMember(Name="buySideTPOID")]
		public string BuySideTPOID { get; set; }

		[DataMember(Name="buySideTPOName")]
		public string BuySideTPOName { get; set; }

		[DataMember(Name="buySideTradeGuid")]
		public string BuySideTradeGuid { get; set; }

		[DataMember(Name="buySideTradeNumber")]
		public string BuySideTradeNumber { get; set; }

		[DataMember(Name="buySideUnDiscountedRate")]
		public decimal? BuySideUnDiscountedRate { get; set; }

		[DataMember(Name="cancellationRequestPending")]
		public string CancellationRequestPending { get; set; }

		[DataMember(Name="combinedLTV")]
		public decimal? CombinedLTV { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="commitment")]
		public string Commitment { get; set; }

		[DataMember(Name="commitmentType")]
		public string CommitmentType { get; set; }

		[DataMember(Name="compGainLossPercentage")]
		public decimal? CompGainLossPercentage { get; set; }

		[DataMember(Name="compGainLossPrice")]
		public decimal? CompGainLossPrice { get; set; }

		[DataMember(Name="compGainLossTotalBuyPrice")]
		public decimal? CompGainLossTotalBuyPrice { get; set; }

		[DataMember(Name="compGainLossTotalCompPrice")]
		public decimal? CompGainLossTotalCompPrice { get; set; }

		[DataMember(Name="compInvestorAddress")]
		public string CompInvestorAddress { get; set; }

		[DataMember(Name="compInvestorCity")]
		public string CompInvestorCity { get; set; }

		[DataMember(Name="compInvestorCommitment")]
		public string CompInvestorCommitment { get; set; }

		[DataMember(Name="compInvestorContact")]
		public string CompInvestorContact { get; set; }

		[DataMember(Name="compInvestorEmail")]
		public string CompInvestorEmail { get; set; }

		[DataMember(Name="compInvestorLockType")]
		public string CompInvestorLockType { get; set; }

		[DataMember(Name="compInvestorName")]
		public string CompInvestorName { get; set; }

		[DataMember(Name="compInvestorPhone")]
		public string CompInvestorPhone { get; set; }

		[DataMember(Name="compInvestorPostalCode")]
		public string CompInvestorPostalCode { get; set; }

		[DataMember(Name="compInvestorProgramCode")]
		public string CompInvestorProgramCode { get; set; }

		[DataMember(Name="compInvestorState")]
		public string CompInvestorState { get; set; }

		[DataMember(Name="compInvestorTemplateName")]
		public string CompInvestorTemplateName { get; set; }

		[DataMember(Name="compInvestorWebsite")]
		public string CompInvestorWebsite { get; set; }

		[DataMember(Name="compSideAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> CompSideAdjustments { get; set; }

		[DataMember(Name="compSideComments")]
		public string CompSideComments { get; set; }

		[DataMember(Name="compSideComparisonedBy")]
		public string CompSideComparisonedBy { get; set; }

		[DataMember(Name="compSideCurrentRateSetDate")]
		public DateTime? CompSideCurrentRateSetDate { get; set; }

		[DataMember(Name="compSideDaystoExtend")]
		public int? CompSideDaystoExtend { get; set; }

		[DataMember(Name="compSideDiscountYSP")]
		public decimal? CompSideDiscountYSP { get; set; }

		[DataMember(Name="compSideExtendedLockExpires")]
		public DateTime? CompSideExtendedLockExpires { get; set; }

		[DataMember(Name="compSideInvestorStatus")]
		public string CompSideInvestorStatus { get; set; }

		[DataMember(Name="compSideInvestorStatusDate")]
		public DateTime? CompSideInvestorStatusDate { get; set; }

		[DataMember(Name="compSideInvestorTradeNumber")]
		public string CompSideInvestorTradeNumber { get; set; }

		[DataMember(Name="compSideLoanProgram")]
		public string CompSideLoanProgram { get; set; }

		[DataMember(Name="compSideLockDate")]
		public DateTime? CompSideLockDate { get; set; }

		[DataMember(Name="compSideLockExpires")]
		public DateTime? CompSideLockExpires { get; set; }

		[DataMember(Name="compSideLockExtendPriceAdjustment")]
		public decimal? CompSideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="compSideMarginNetCompRate")]
		public decimal? CompSideMarginNetCompRate { get; set; }

		[DataMember(Name="compSideMarginRate")]
		public decimal? CompSideMarginRate { get; set; }

		[DataMember(Name="compSideMarginTotalAdjustment")]
		public decimal? CompSideMarginTotalAdjustment { get; set; }

		[DataMember(Name="compSideMasterContractNumber")]
		public string CompSideMasterContractNumber { get; set; }

		[DataMember(Name="compSideNetCompPrice")]
		public decimal? CompSideNetCompPrice { get; set; }

		[DataMember(Name="compSideNetCompRate")]
		public decimal? CompSideNetCompRate { get; set; }

		[DataMember(Name="compSideNumberOfDays")]
		public int? CompSideNumberOfDays { get; set; }

		[DataMember(Name="compSideOriginalLockExpires")]
		public DateTime? CompSideOriginalLockExpires { get; set; }

		[DataMember(Name="compSidePriceRate")]
		public decimal? CompSidePriceRate { get; set; }

		[DataMember(Name="compSidePriceTotalAdjustment")]
		public decimal? CompSidePriceTotalAdjustment { get; set; }

		[DataMember(Name="compSideRate")]
		public decimal? CompSideRate { get; set; }

		[DataMember(Name="compSideRateSheetID")]
		public string CompSideRateSheetID { get; set; }

		[DataMember(Name="compSideRateTotalAdjustment")]
		public decimal? CompSideRateTotalAdjustment { get; set; }

		[DataMember(Name="compSideRequestedBy")]
		public string CompSideRequestedBy { get; set; }

		[DataMember(Name="compSideServicingType")]
		public string CompSideServicingType { get; set; }

		[DataMember(Name="compSideSRPPaidOut")]
		public decimal? CompSideSRPPaidOut { get; set; }

		[DataMember(Name="compSideTradeGuid")]
		public string CompSideTradeGuid { get; set; }

		[DataMember(Name="compSideTradeNumber")]
		public string CompSideTradeNumber { get; set; }

		[DataMember(Name="confirmedBy")]
		public string ConfirmedBy { get; set; }

		[DataMember(Name="confirmedDate")]
		public DateTime? ConfirmedDate { get; set; }

		[DataMember(Name="corporateApprovalDate")]
		public DateTime? CorporateApprovalDate { get; set; }

		[DataMember(Name = "corporateApprovalDate2")]
		public DateTime? CorporateApprovalDate2 { get; set; }

		[DataMember(Name = "corporateApprovalDate3")]
		public DateTime? CorporateApprovalDate3 { get; set; }

		[DataMember(Name = "corporateApprovalDate4")]
		public DateTime? CorporateApprovalDate4 { get; set; }

		[DataMember(Name = "corporateApprovalDate5")]
		public DateTime? CorporateApprovalDate5 { get; set; }

		[DataMember(Name="corporateApprovedby")]
		public string CorporateApprovedBy { get; set; }

		[DataMember(Name = "corporateApprovedBy2")]
		public string CorporateApprovedBy2 { get; set; }

		[DataMember(Name = "corporateApprovedBy3")]
		public string CorporateApprovedBy3 { get; set; }

		[DataMember(Name = "corporateApprovedBy4")]
		public string CorporateApprovedBy4 { get; set; }

		[DataMember(Name = "corporateApprovedBy5")]
		public string CorporateApprovedBy5 { get; set; }

		[DataMember(Name="corporatePrice")]
		public decimal? CorporatePrice { get; set; }

		[DataMember(Name = "corporatePrice2")]
		public decimal? CorporatePrice2 { get; set; }

		[DataMember(Name = "corporatePrice3")]
		public decimal? CorporatePrice3 { get; set; }

		[DataMember(Name = "corporatePrice4")]
		public decimal? CorporatePrice4 { get; set; }

		[DataMember(Name = "corporatePrice5")]
		public decimal? CorporatePrice5 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAdditionalEscrow")]
		public decimal? CorrespondentAdditionalEscrowAdditionalEscrow { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1007")]
		public decimal? CorrespondentAdditionalEscrowAmount1007 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1008")]
		public decimal? CorrespondentAdditionalEscrowAmount1008 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowAmount1009")]
		public decimal? CorrespondentAdditionalEscrowAmount1009 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowCityPropertyTax")]
		public decimal? CorrespondentAdditionalEscrowCityPropertyTax { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1007")]
		public string CorrespondentAdditionalEscrowDescription1007 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1008")]
		public string CorrespondentAdditionalEscrowDescription1008 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowDescription1009")]
		public string CorrespondentAdditionalEscrowDescription1009 { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowFloodInsurance")]
		public decimal? CorrespondentAdditionalEscrowFloodInsurance { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowHomeInsurance")]
		public decimal? CorrespondentAdditionalEscrowHomeInsurance { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowMIMIP")]
		public decimal? CorrespondentAdditionalEscrowMIMIP { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowNumOfPayments")]
		public int? CorrespondentAdditionalEscrowNumOfPayments { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption1Amount")]
		public decimal? CorrespondentAdditionalEscrowOption1Amount { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption1Desc")]
		public string CorrespondentAdditionalEscrowOption1Desc { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption2Amount")]
		public decimal? CorrespondentAdditionalEscrowOption2Amount { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowOption2Desc")]
		public string CorrespondentAdditionalEscrowOption2Desc { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowPropertyTax")]
		public decimal? CorrespondentAdditionalEscrowPropertyTax { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowSumOfPayments")]
		public decimal? CorrespondentAdditionalEscrowSumOfPayments { get; set; }

		[DataMember(Name="correspondentAdditionalEscrowUSDAAnnualFee")]
		public decimal? CorrespondentAdditionalEscrowUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount1")]
		public decimal? CorrespondentAdditionalLineAmount1 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount10")]
		public decimal? CorrespondentAdditionalLineAmount10 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount11")]
		public decimal? CorrespondentAdditionalLineAmount11 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount12")]
		public decimal? CorrespondentAdditionalLineAmount12 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount13")]
		public decimal? CorrespondentAdditionalLineAmount13 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount2")]
		public decimal? CorrespondentAdditionalLineAmount2 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount3")]
		public decimal? CorrespondentAdditionalLineAmount3 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount4")]
		public decimal? CorrespondentAdditionalLineAmount4 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount5")]
		public decimal? CorrespondentAdditionalLineAmount5 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount6")]
		public decimal? CorrespondentAdditionalLineAmount6 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount7")]
		public decimal? CorrespondentAdditionalLineAmount7 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount8")]
		public decimal? CorrespondentAdditionalLineAmount8 { get; set; }

		[DataMember(Name="correspondentAdditionalLineAmount9")]
		public decimal? CorrespondentAdditionalLineAmount9 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription1")]
		public string CorrespondentAdditionalLineDescription1 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription10")]
		public string CorrespondentAdditionalLineDescription10 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription11")]
		public string CorrespondentAdditionalLineDescription11 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription12")]
		public string CorrespondentAdditionalLineDescription12 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription2")]
		public string CorrespondentAdditionalLineDescription2 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription3")]
		public string CorrespondentAdditionalLineDescription3 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription4")]
		public string CorrespondentAdditionalLineDescription4 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription5")]
		public string CorrespondentAdditionalLineDescription5 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription6")]
		public string CorrespondentAdditionalLineDescription6 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription7")]
		public string CorrespondentAdditionalLineDescription7 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription8")]
		public string CorrespondentAdditionalLineDescription8 { get; set; }

		[DataMember(Name="correspondentAdditionalLineDescription9")]
		public string CorrespondentAdditionalLineDescription9 { get; set; }

		[DataMember(Name="correspondentAdditionalLineTotalAmount")]
		public decimal? CorrespondentAdditionalLineTotalAmount { get; set; }

		[DataMember(Name="correspondentAdjusterAmount1")]
		public decimal? CorrespondentAdjusterAmount1 { get; set; }

		[DataMember(Name="correspondentAdjusterAmount2")]
		public decimal? CorrespondentAdjusterAmount2 { get; set; }

		[DataMember(Name="correspondentAdjusterAmount3")]
		public decimal? CorrespondentAdjusterAmount3 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription1")]
		public string CorrespondentAdjusterDescription1 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription2")]
		public string CorrespondentAdjusterDescription2 { get; set; }

		[DataMember(Name="correspondentAdjusterDescription3")]
		public string CorrespondentAdjusterDescription3 { get; set; }

		[DataMember(Name="correspondentConfirmedBy")]
		public string CorrespondentConfirmedBy { get; set; }

		[DataMember(Name="correspondentConfirmedDate")]
		public DateTime? CorrespondentConfirmedDate { get; set; }

		[DataMember(Name="correspondentCurrentImpounds")]
		public decimal? CorrespondentCurrentImpounds { get; set; }

		[DataMember(Name="correspondentCurrentPrincipal")]
		public decimal? CorrespondentCurrentPrincipal { get; set; }

		[DataMember(Name="correspondentDate")]
		public DateTime? CorrespondentDate { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1007")]
		public decimal? CorrespondentEscrowDisbursementsAmount1007 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1008")]
		public decimal? CorrespondentEscrowDisbursementsAmount1008 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsAmount1009")]
		public decimal? CorrespondentEscrowDisbursementsAmount1009 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsCityPropertyTax")]
		public decimal? CorrespondentEscrowDisbursementsCityPropertyTax { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1007")]
		public string CorrespondentEscrowDisbursementsDescription1007 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1008")]
		public string CorrespondentEscrowDisbursementsDescription1008 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsDescription1009")]
		public string CorrespondentEscrowDisbursementsDescription1009 { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsEscrowsToBePaidBySeller")]
		public decimal? CorrespondentEscrowDisbursementsEscrowsToBePaidBySeller { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsEsrowFundedByInvestor")]
		public decimal? CorrespondentEscrowDisbursementsEsrowFundedByInvestor { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsFloodInsurance")]
		public decimal? CorrespondentEscrowDisbursementsFloodInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsHomeInsurance")]
		public decimal? CorrespondentEscrowDisbursementsHomeInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsMortgageInsurance")]
		public decimal? CorrespondentEscrowDisbursementsMortgageInsurance { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption1Amount")]
		public decimal? CorrespondentEscrowDisbursementsOption1Amount { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption1Desc")]
		public string CorrespondentEscrowDisbursementsOption1Desc { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption2Amount")]
		public decimal? CorrespondentEscrowDisbursementsOption2Amount { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsOption2Desc")]
		public string CorrespondentEscrowDisbursementsOption2Desc { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsPropertyTax")]
		public decimal? CorrespondentEscrowDisbursementsPropertyTax { get; set; }

		[DataMember(Name="correspondentEscrowDisbursementsUSDAAnnualFee")]
		public decimal? CorrespondentEscrowDisbursementsUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentFinalBuyAmount")]
		public decimal? CorrespondentFinalBuyAmount { get; set; }

		[DataMember(Name="correspondentFinalBuyPrice")]
		public decimal? CorrespondentFinalBuyPrice { get; set; }

		[DataMember(Name="correspondentFinalCDAggAdjAmount")]
		public decimal? CorrespondentFinalCDAggAdjAmount { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1007")]
		public decimal? CorrespondentFinalCDAmount1007 { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1008")]
		public decimal? CorrespondentFinalCDAmount1008 { get; set; }

		[DataMember(Name="correspondentFinalCDAmount1009")]
		public decimal? CorrespondentFinalCDAmount1009 { get; set; }

		[DataMember(Name="correspondentFinalCDCityPropertyTax")]
		public decimal? CorrespondentFinalCDCityPropertyTax { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1007")]
		public string CorrespondentFinalCDDescription1007 { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1008")]
		public string CorrespondentFinalCDDescription1008 { get; set; }

		[DataMember(Name="correspondentFinalCDDescription1009")]
		public string CorrespondentFinalCDDescription1009 { get; set; }

		[DataMember(Name="correspondentFinalCDFloodInsurance")]
		public decimal? CorrespondentFinalCDFloodInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDHomeInsurance")]
		public decimal? CorrespondentFinalCDHomeInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDMortgageInsurance")]
		public decimal? CorrespondentFinalCDMortgageInsurance { get; set; }

		[DataMember(Name="correspondentFinalCDOption1Amount")]
		public decimal? CorrespondentFinalCDOption1Amount { get; set; }

		[DataMember(Name="correspondentFinalCDOption1Desc")]
		public string CorrespondentFinalCDOption1Desc { get; set; }

		[DataMember(Name="correspondentFinalCDOption2Amount")]
		public decimal? CorrespondentFinalCDOption2Amount { get; set; }

		[DataMember(Name="correspondentFinalCDOption2Desc")]
		public string CorrespondentFinalCDOption2Desc { get; set; }

		[DataMember(Name="correspondentFinalCDPropertyTax")]
		public decimal? CorrespondentFinalCDPropertyTax { get; set; }

		[DataMember(Name="correspondentFinalCDReservesCollectedAtClosing")]
		public decimal? CorrespondentFinalCDReservesCollectedAtClosing { get; set; }

		[DataMember(Name="correspondentFinalCDUSDAAnnualFee")]
		public decimal? CorrespondentFinalCDUSDAAnnualFee { get; set; }

		[DataMember(Name="correspondentFirstPaymentDate")]
		public DateTime? CorrespondentFirstPaymentDate { get; set; }

		[DataMember(Name="correspondentImpounds")]
		public decimal? CorrespondentImpounds { get; set; }

		[DataMember(Name="correspondentInterest")]
		public decimal? CorrespondentInterest { get; set; }

		[DataMember(Name="correspondentInterestDays")]
		public int? CorrespondentInterestDays { get; set; }

		[DataMember(Name="correspondentLateFeeAmount")]
		public decimal? CorrespondentLateFeeAmount { get; set; }

		[DataMember(Name="correspondentLateFeePriceAdjustment")]
		public decimal? CorrespondentLateFeePriceAdjustment { get; set; }

		[DataMember(Name="correspondentPaidToDate")]
		public DateTime? CorrespondentPaidToDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryAnticipatedPurchaseDate")]
		public DateTime? CorrespondentPaymentHistoryAnticipatedPurchaseDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryCalculatedPurchasedPrincipal")]
		public decimal? CorrespondentPaymentHistoryCalculatedPurchasedPrincipal { get; set; }

		[DataMember(Name="correspondentPaymentHistoryFirstBorrowerPaymentDueDate")]
		public DateTime? CorrespondentPaymentHistoryFirstBorrowerPaymentDueDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryFirstInvestorPaymentDate")]
		public DateTime? CorrespondentPaymentHistoryFirstInvestorPaymentDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryNoteDate")]
		public DateTime? CorrespondentPaymentHistoryNoteDate { get; set; }

		[DataMember(Name="correspondentPaymentHistoryPricipalReduction")]
		public decimal? CorrespondentPaymentHistoryPricipalReduction { get; set; }

		[DataMember(Name="correspondentPurchasedPrincipal")]
		public decimal? CorrespondentPurchasedPrincipal { get; set; }

		[DataMember(Name="correspondentReconcilationComments")]
		public string CorrespondentReconcilationComments { get; set; }

		[DataMember(Name="correspondentRemainingBuydownAmount")]
		public decimal? CorrespondentRemainingBuydownAmount { get; set; }

		[DataMember(Name="correspondentSRPAmount")]
		public decimal? CorrespondentSRPAmount { get; set; }

		[DataMember(Name="correspondentTotalBuyAmount")]
		public decimal? CorrespondentTotalBuyAmount { get; set; }

		[DataMember(Name="correspondentTotalFees")]
		public decimal? CorrespondentTotalFees { get; set; }

		[DataMember(Name="correspondentWarehouseBankABANum")]
		public string CorrespondentWarehouseBankABANum { get; set; }

		[DataMember(Name="correspondentWarehouseBankAcctName")]
		public string CorrespondentWarehouseBankAcctName { get; set; }

		[DataMember(Name="correspondentWarehouseBankAcctNum")]
		public string CorrespondentWarehouseBankAcctNum { get; set; }

		[DataMember(Name="correspondentWarehouseBankAddress")]
		public string CorrespondentWarehouseBankAddress { get; set; }

		[DataMember(Name="correspondentWarehouseBankAddress1")]
		public string CorrespondentWarehouseBankAddress1 { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeExpirationDate")]
		public DateTime? CorrespondentWarehouseBankBaileeExpirationDate { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeLetterReceivedIndicator")]
		public bool? CorrespondentWarehouseBankBaileeLetterReceivedIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankBaileeLetterReqIndicator")]
		public bool? CorrespondentWarehouseBankBaileeLetterReqIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankCity")]
		public string CorrespondentWarehouseBankCity { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactEmail")]
		public string CorrespondentWarehouseBankContactEmail { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactFax")]
		public string CorrespondentWarehouseBankContactFax { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactName")]
		public string CorrespondentWarehouseBankContactName { get; set; }

		[DataMember(Name="correspondentWarehouseBankContactPhone")]
		public string CorrespondentWarehouseBankContactPhone { get; set; }

		[DataMember(Name="correspondentWarehouseBankDescription")]
		public string CorrespondentWarehouseBankDescription { get; set; }

		[DataMember(Name="correspondentWarehouseBankFurtherCreditAcctName")]
		public string CorrespondentWarehouseBankFurtherCreditAcctName { get; set; }

		[DataMember(Name="correspondentWarehouseBankFurtherCreditAcctNum")]
		public string CorrespondentWarehouseBankFurtherCreditAcctNum { get; set; }

		[DataMember(Name = "correspondentWarehouseBankId")]
		public int? CorrespondentWarehouseBankId { get; set; } = 0;

		[DataMember(Name="correspondentWarehouseBankName")]
		public string CorrespondentWarehouseBankName { get; set; }

		[DataMember(Name="correspondentWarehouseBankNotes")]
		public string CorrespondentWarehouseBankNotes { get; set; }

		[DataMember(Name="correspondentWarehouseBankSelfFunderIndicator")]
		public bool? CorrespondentWarehouseBankSelfFunderIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankState")]
		public string CorrespondentWarehouseBankState { get; set; }

		[DataMember(Name="correspondentWarehouseBankTriPartyContractIndicator")]
		public bool? CorrespondentWarehouseBankTriPartyContractIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankUseDefaultContactIndicator")]
		public bool? CorrespondentWarehouseBankUseDefaultContactIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankWireConfirmationNumber")]
		public string CorrespondentWarehouseBankWireConfirmationNumber { get; set; }

		[DataMember(Name="correspondentWarehouseBankWireInstructionsReceivedIndicator")]
		public bool? CorrespondentWarehouseBankWireInstructionsReceivedIndicator { get; set; }

		[DataMember(Name="correspondentWarehouseBankZip")]
		public string CorrespondentWarehouseBankZip { get; set; }

		[DataMember(Name="creditScoreToUse")]
		public string CreditScoreToUse { get; set; }

		[DataMember(Name="cumulatedDaystoExtend")]
		public int? CumulatedDaystoExtend { get; set; }

		[DataMember(Name="currentAcquisition")]
		public bool? CurrentAcquisition { get; set; }

		[DataMember(Name="currentAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> CurrentAdjustments { get; set; }

		[DataMember(Name="currentComments")]
		public string CurrentComments { get; set; }

		[DataMember(Name="currentConstructionRefi")]
		public bool? CurrentConstructionRefi { get; set; }

		[DataMember(Name="currentLockDate")]
		public DateTime? CurrentLockDate { get; set; }

		[DataMember(Name="currentLockExpires")]
		public DateTime? CurrentLockExpires { get; set; }

		[DataMember(Name="currentMarginRate")]
		public decimal? CurrentMarginRate { get; set; }

		[DataMember(Name="currentMarginRateRequested")]
		public decimal? CurrentMarginRateRequested { get; set; }

		[DataMember(Name="currentMarginTotalAdjustment")]
		public decimal? CurrentMarginTotalAdjustment { get; set; }

		[DataMember(Name="currentNumberOfDays")]
		public int? CurrentNumberOfDays { get; set; }

		[DataMember(Name="currentPriceRate")]
		public decimal? CurrentPriceRate { get; set; }

		[DataMember(Name="currentPriceRateRequested")]
		public decimal? CurrentPriceRateRequested { get; set; }

		[DataMember(Name="currentPriceTotalAdjustment")]
		public decimal? CurrentPriceTotalAdjustment { get; set; }

		[DataMember(Name="currentRate")]
		public decimal? CurrentRate { get; set; }

		[DataMember(Name="currentRateRequested")]
		public decimal? CurrentRateRequested { get; set; }

		[DataMember(Name="currentRateSetDate")]
		public DateTime? CurrentRateSetDate { get; set; }

		[DataMember(Name="currentRateSheetID")]
		public string CurrentRateSheetID { get; set; }

		[DataMember(Name="currentRateTotalAdjustment")]
		public decimal? CurrentRateTotalAdjustment { get; set; }

		[DataMember(Name="date")]
		public DateTime? Date { get; set; }

		[DataMember(Name="dateFirstPaymentToInvestor")]
		public DateTime? DateFirstPaymentToInvestor { get; set; }

		[DataMember(Name="dateLockedWithInvestor")]
		public DateTime? DateLockedWithInvestor { get; set; }

		[DataMember(Name="dateSold")]
		public DateTime? DateSold { get; set; }

		[DataMember(Name="dateWarehoused")]
		public DateTime? DateWarehoused { get; set; }

		[DataMember(Name="daysToExtend")]
		public int? DaysToExtend { get; set; }

		[DataMember(Name="deliveryType")]
		public string DeliveryType { get; set; }

		[DataMember(Name="diffAmountReceived")]
		public decimal? DiffAmountReceived { get; set; }

		[DataMember(Name="diffImpounds")]
		public decimal? DiffImpounds { get; set; }

		[DataMember(Name="diffInterest")]
		public decimal? DiffInterest { get; set; }

		[DataMember(Name="diffPremium")]
		public decimal? DiffPremium { get; set; }

		[DataMember(Name="diffPrinciple")]
		public decimal? DiffPrinciple { get; set; }

		[DataMember(Name="diffRemainingBuydownFunds")]
		public decimal? DiffRemainingBuydownFunds { get; set; }

		[DataMember(Name="diffSellAmount")]
		public decimal? DiffSellAmount { get; set; }

		[DataMember(Name="diffSellPrice")]
		public decimal? DiffSellPrice { get; set; }

		[DataMember(Name="diffSellSideSRP")]
		public decimal? DiffSellSideSRP { get; set; }

		[DataMember(Name="diffSRP")]
		public decimal? DiffSRP { get; set; }

		[DataMember(Name="diffSRPAmount")]
		public decimal? DiffSRPAmount { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator1")]
		public bool? EmploymentBorrowerSelfEmployedIndicator1 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator10")]
		public bool? EmploymentBorrowerSelfEmployedIndicator10 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator11")]
		public bool? EmploymentBorrowerSelfEmployedIndicator11 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator12")]
		public bool? EmploymentBorrowerSelfEmployedIndicator12 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator2")]
		public bool? EmploymentBorrowerSelfEmployedIndicator2 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator3")]
		public bool? EmploymentBorrowerSelfEmployedIndicator3 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator4")]
		public bool? EmploymentBorrowerSelfEmployedIndicator4 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator5")]
		public bool? EmploymentBorrowerSelfEmployedIndicator5 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator6")]
		public bool? EmploymentBorrowerSelfEmployedIndicator6 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator7")]
		public bool? EmploymentBorrowerSelfEmployedIndicator7 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator8")]
		public bool? EmploymentBorrowerSelfEmployedIndicator8 { get; set; }

		[DataMember(Name="employmentBorrowerSelfEmployedIndicator9")]
		public bool? EmploymentBorrowerSelfEmployedIndicator9 { get; set; }

		[DataMember(Name = "energyImprovementAmount")]
		public decimal? energyImprovementAmount { get; set; }

		[DataMember(Name="expectedAmountReceived")]
		public decimal? ExpectedAmountReceived { get; set; }

		[DataMember(Name="expectedImpounds")]
		public decimal? ExpectedImpounds { get; set; }

		[DataMember(Name="expectedInterest")]
		public decimal? ExpectedInterest { get; set; }

		[DataMember(Name="expectedPremium")]
		public decimal? ExpectedPremium { get; set; }

		[DataMember(Name="expectedPrinciple")]
		public decimal? ExpectedPrinciple { get; set; }

		[DataMember(Name="expectedRemainingBuydownFunds")]
		public decimal? ExpectedRemainingBuydownFunds { get; set; }

		[DataMember(Name="expectedSRP")]
		public decimal? ExpectedSRP { get; set; }

		[DataMember(Name="extensionRequestPending")]
		public string ExtensionRequestPending { get; set; }

		[DataMember(Name="extensionSequenceNumber")]
		public int? ExtensionSequenceNumber { get; set; }

		[DataMember(Name="extraPayments")]
		public List<LoanContractRateLockExtraPayments> ExtraPayments { get; set; }

		[DataMember(Name="fHAUpfrontMIPremiumPercent")]
		public decimal? FHAUpfrontMIPremiumPercent { get; set; }

		[DataMember(Name="financedNumberOfUnits")]
		public int? FinancedNumberOfUnits { get; set; }

		[DataMember(Name="firstPaymenTo")]
		public string FirstPaymenTo { get; set; }

		[DataMember(Name="firstSubordinateAmount")]
		public decimal? FirstSubordinateAmount { get; set; }

		[DataMember(Name="firstTimeHomebuyersIndicator")]
		public bool? FirstTimeHomebuyersIndicator { get; set; }

		[DataMember(Name="fNMProductPlanIdentifier")]
		public string FNMProductPlanIdentifier { get; set; }

		[DataMember(Name="fundingAmount")]
		public decimal? FundingAmount { get; set; }

		[DataMember(Name="gainLossPercentage")]
		public decimal? GainLossPercentage { get; set; }

		[DataMember(Name="gainLossPrice")]
		public decimal? GainLossPrice { get; set; }

		[DataMember(Name="gainLossTotalBuyPrice")]
		public decimal? GainLossTotalBuyPrice { get; set; }

		[DataMember(Name="gPMRate")]
		public decimal? GPMRate { get; set; }

		[DataMember(Name="gPMYears")]
		public int? GPMYears { get; set; }

		[DataMember(Name="gSEPropertyType")]
		public string GSEPropertyType { get; set; }

		[DataMember(Name="hedging")]
		public string Hedging { get; set; }

		[DataMember(Name="hELOCActualBalance")]
		public string HELOCActualBalance { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="impounds")]
		public decimal? Impounds { get; set; }

		[DataMember(Name="impoundType")]
		public string ImpoundType { get; set; }

		[DataMember(Name="impoundWaived")]
		public string ImpoundWaived { get; set; }

		[DataMember(Name="impoundWavied")]
		public string ImpoundWavied { get; set; }

		[DataMember(Name="interest")]
		public decimal? Interest { get; set; }

		[DataMember(Name="investorAddress")]
		public string InvestorAddress { get; set; }

		[DataMember(Name="investorCity")]
		public string InvestorCity { get; set; }

		[DataMember(Name="investorCommitment")]
		public string InvestorCommitment { get; set; }

		[DataMember(Name="investorContact")]
		public string InvestorContact { get; set; }

		[DataMember(Name="investorDeliveryDate")]
		public DateTime? InvestorDeliveryDate { get; set; }

		[DataMember(Name="investorEmail")]
		public string InvestorEmail { get; set; }

		[DataMember(Name="investorLoanNumber")]
		public string InvestorLoanNumber { get; set; }

		[DataMember(Name="investorLockType")]
		public string InvestorLockType { get; set; }

		[DataMember(Name="investorMERSNumber")]
		public string InvestorMERSNumber { get; set; }

		[DataMember(Name="investorName")]
		public string InvestorName { get; set; }

		[DataMember(Name="investorPhone")]
		public string InvestorPhone { get; set; }

		[DataMember(Name="investorPostalCode")]
		public string InvestorPostalCode { get; set; }

		[DataMember(Name="investorProgramCode")]
		public string InvestorProgramCode { get; set; }

		[DataMember(Name="investorState")]
		public string InvestorState { get; set; }

		[DataMember(Name="investorTargetDeliveryDate")]
		public DateTime? InvestorTargetDeliveryDate { get; set; }

		[DataMember(Name="investorTemplateName")]
		public string InvestorTemplateName { get; set; }

		[DataMember(Name="investorWebsite")]
		public string InvestorWebsite { get; set; }

		[DataMember(Name="isCancelled")]
		public string IsCancelled { get; set; }

		[DataMember(Name="isDeliveryType")]
		public bool? IsDeliveryType { get; set; }

		[DataMember(Name="lenderFeeWaiverOption")]
		public bool? LenderFeeWaiverOption { get; set; }

		[DataMember(Name="lenderPaidMortgageInsuranceIndicator")]
		public bool? LenderPaidMortgageInsuranceIndicator { get; set; }

		[DataMember(Name="lienPriorityType")]
		public string LienPriorityType { get; set; }

		[DataMember(Name="loanAmortizationTermMonths")]
		public int? LoanAmortizationTermMonths { get; set; }

		[DataMember(Name="loanAmortizationType")]
		public string LoanAmortizationType { get; set; }

		[DataMember(Name="loanDocumentationType")]
		public string LoanDocumentationType { get; set; }

		[DataMember(Name="loanFor203K")]
		public bool? LoanFor203K { get; set; }

		[DataMember(Name="loanProgram")]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanProgramFile")]
		public string LoanProgramFile { get; set; }

		[DataMember(Name="loanScheduledClosingDate")]
		public DateTime? LoanScheduledClosingDate { get; set; }

		[DataMember(Name="lockField")]
		public bool? LockField { get; set; }

		[DataMember(Name="lockRequestAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> LockRequestAdjustments { get; set; }

		[DataMember(Name="lockRequestBorrowers")]
		public List<LoanContractRateLockLockRequestBorrowers> LockRequestBorrowers { get; set; }

		[DataMember(Name="lockRequestLoanPurposeType")]
		public string LockRequestLoanPurposeType { get; set; }

		[DataMember(Name="lTV")]
		public decimal? LTV { get; set; }

		[DataMember(Name="minFICO")]
		public string MinFICO { get; set; }

		[DataMember(Name="minFICO2")]
		public string MinFICO2 { get; set; }

		[DataMember(Name="mIPPaidInCash")]
		public decimal? MIPPaidInCash { get; set; }

		[DataMember(Name="mortgageType")]
		public string MortgageType { get; set; }

		[DataMember(Name="netSellAmount")]
		public decimal? NetSellAmount { get; set; }

		[DataMember(Name="netSellPrice")]
		public decimal? NetSellPrice { get; set; }

		[DataMember(Name="nextPaymentDate")]
		public DateTime? NextPaymentDate { get; set; }

		[DataMember(Name="noClosingCostOption")]
		public bool? NoClosingCostOption { get; set; }

		[DataMember(Name="oNRPLock")]
		public string ONRPLock { get; set; }

		[DataMember(Name="otherAmortizationTypeDescription")]
		public string OtherAmortizationTypeDescription { get; set; }

		[DataMember(Name="otherSubordinateAmount")]
		public decimal? OtherSubordinateAmount { get; set; }

		[DataMember(Name="perDiemInterestRoundingType")]
		public string PerDiemInterestRoundingType { get; set; }

		[DataMember(Name="planCode")]
		public string PlanCode { get; set; }

		[DataMember(Name="premium")]
		public decimal? Premium { get; set; }

		[DataMember(Name="prepayPenalty")]
		public string PrepayPenalty { get; set; }

		[DataMember(Name="priceAdjustment")]
		public decimal? PriceAdjustment { get; set; }

		[DataMember(Name="priceAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> PriceAdjustments { get; set; }

		[DataMember(Name="pricingHistoryData")]
		public string PricingHistoryData { get; set; }

		[DataMember(Name="pricingUpdated")]
		public string PricingUpdated { get; set; }

		[DataMember(Name="principle")]
		public decimal? Principle { get; set; }

		[DataMember(Name="profitMarginAdjustedBuyPrice")]
		public decimal? ProfitMarginAdjustedBuyPrice { get; set; }

		[DataMember(Name="propertyAppraisedValueAmount")]
		public int? PropertyAppraisedValueAmount { get; set; }

		[DataMember(Name="propertyEstimatedValueAmount")]
		public int? PropertyEstimatedValueAmount { get; set; }

		[DataMember(Name="propertyUsageType")]
		public string PropertyUsageType { get; set; }

		[DataMember(Name="purchaseAdviceNumberOfDays")]
		public int? PurchaseAdviceNumberOfDays { get; set; }

		[DataMember(Name="purchaseAdvicePayouts")]
		public List<LoanContractRateLockPurchaseAdvicePayouts> PurchaseAdvicePayouts { get; set; }

		[DataMember(Name="purchasePriceAmount")]
		public decimal? PurchasePriceAmount { get; set; }

		[DataMember(Name="rateRequestStatus")]
		public string RateRequestStatus { get; set; }

		[DataMember(Name="rateStatus")]
		public string RateStatus { get; set; }

		[DataMember(Name="reasonforBranchApproval")]
		public string ReasonforBranchApproval { get; set; }

		[DataMember(Name = "reasonforBranchApproval2")]
		public string ReasonforBranchApproval2 { get; set; }

		[DataMember(Name = "reasonforBranchApproval3")]
		public string ReasonforBranchApproval3 { get; set; }

		[DataMember(Name = "reasonforBranchApproval4")]
		public string ReasonforBranchApproval4 { get; set; }

		[DataMember(Name="reasonforCorporateApproval")]
		public string ReasonforCorporateApproval { get; set; }

		[DataMember(Name = "reasonForCorporateApproval2")]
		public string ReasonForCorporateApproval2 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval3")]
		public string ReasonForCorporateApproval3 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval4")]
		public string ReasonForCorporateApproval4 { get; set; }

		[DataMember(Name = "reasonForCorporateApproval5")]
		public string ReasonForCorporateApproval5 { get; set; }

		[DataMember(Name="reconciledDiff")]
		public decimal? ReconciledDiff { get; set; }

		[DataMember(Name="reLockRequestPending")]
		public string ReLockRequestPending { get; set; }

		[DataMember(Name="remainingBuydownFunds")]
		public decimal? RemainingBuydownFunds { get; set; }

		[DataMember(Name="requestComments")]
		public string RequestComments { get; set; }

		[DataMember(Name="requestCurrentRateSetDate")]
		public DateTime? RequestCurrentRateSetDate { get; set; }

		[DataMember(Name="requestDaystoExtend")]
		public int? RequestDaystoExtend { get; set; }

		[DataMember(Name="requestExtendedLockExpires")]
		public DateTime? RequestExtendedLockExpires { get; set; }

		[DataMember(Name="requestFullfilledDateTime")]
		public string RequestFullfilledDateTime { get; set; }

		[DataMember(Name="requestImpoundType")]
		public string RequestImpoundType { get; set; }

		[DataMember(Name="requestImpoundWaived")]
		public string RequestImpoundWaived { get; set; }

		[DataMember(Name="requestImpoundWavied")]
		public string RequestImpoundWavied { get; set; }

		[DataMember(Name="requestLockCancellationComment")]
		public string RequestLockCancellationComment { get; set; }

		[DataMember(Name="requestLockCancellationDate")]
		public DateTime? RequestLockCancellationDate { get; set; }

		[DataMember(Name="requestLockDate")]
		public DateTime? RequestLockDate { get; set; }

		[DataMember(Name="requestLockExpires")]
		public DateTime? RequestLockExpires { get; set; }

		[DataMember(Name="requestLockExtendComment")]
		public string RequestLockExtendComment { get; set; }

		[DataMember(Name="requestLockExtendPriceAdjustment")]
		public decimal? RequestLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="requestLockStatus")]
		public string RequestLockStatus { get; set; }

		[DataMember(Name="requestLockType")]
		public string RequestLockType { get; set; }

		[DataMember(Name="requestMarginRate")]
		public decimal? RequestMarginRate { get; set; }

		[DataMember(Name="requestMarginRateRequested")]
		public decimal? RequestMarginRateRequested { get; set; }

		[DataMember(Name="requestMarginSRPPaidOut")]
		public decimal? RequestMarginSRPPaidOut { get; set; }

		[DataMember(Name="requestMarginTotalAdjustment")]
		public decimal? RequestMarginTotalAdjustment { get; set; }

		[DataMember(Name="requestNumberOfDays")]
		public int? RequestNumberOfDays { get; set; }

		[DataMember(Name="requestOnrpEligible")]
		public bool? RequestOnrpEligible { get; set; }

		[DataMember(Name="requestOnrpLockDate")]
		public DateTime? RequestOnrpLockDate { get; set; }

		[DataMember(Name="requestOnrpLockTime")]
		public string RequestOnrpLockTime { get; set; }

		[DataMember(Name="requestOriginalLockExpires")]
		public DateTime? RequestOriginalLockExpires { get; set; }

		[DataMember(Name="requestPenaltyTerm")]
		public string RequestPenaltyTerm { get; set; }

		[DataMember(Name="requestPending")]
		public string RequestPending { get; set; }

		[DataMember(Name="requestPrepayPenalty")]
		public string RequestPrepayPenalty { get; set; }

		[DataMember(Name="requestPriceRate")]
		public decimal? RequestPriceRate { get; set; }

		[DataMember(Name="requestPriceRateRequested")]
		public decimal? RequestPriceRateRequested { get; set; }

		[DataMember(Name="requestPriceTotalAdjustment")]
		public decimal? RequestPriceTotalAdjustment { get; set; }

		[DataMember(Name="requestProgramNotes")]
		public string RequestProgramNotes { get; set; }

		[DataMember(Name="requestRate")]
		public decimal? RequestRate { get; set; }

		[DataMember(Name="requestRateRequested")]
		public decimal? RequestRateRequested { get; set; }

		[DataMember(Name="requestRateSheetID")]
		public string RequestRateSheetID { get; set; }

		[DataMember(Name="requestRateTotalAdjustment")]
		public decimal? RequestRateTotalAdjustment { get; set; }

		[DataMember(Name="requestStartingAdjPoint")]
		public decimal? RequestStartingAdjPoint { get; set; }

		[DataMember(Name="requestStartingAdjRate")]
		public decimal? RequestStartingAdjRate { get; set; }

		[DataMember(Name="requestType")]
		public string RequestType { get; set; }

		[DataMember(Name="requestUnDiscountedRate")]
		public decimal? RequestUnDiscountedRate { get; set; }

		[DataMember(Name="roundToNearest50")]
		public bool? RoundToNearest50 { get; set; }

		[DataMember(Name="secondSubordinateAmount")]
		public decimal? SecondSubordinateAmount { get; set; }

		[DataMember(Name="sellerPaidMIPremium")]
		public decimal? SellerPaidMIPremium { get; set; }

		[DataMember(Name="sellSideAdjustments")]
		public List<LoanContractRateLockBuySideAdjustments> SellSideAdjustments { get; set; }

		[DataMember(Name="sellSideComments")]
		public string SellSideComments { get; set; }

		[DataMember(Name="sellSideCommitmentContractNumber")]
		public string SellSideCommitmentContractNumber { get; set; }

		[DataMember(Name="sellSideCommitmentDate")]
		public DateTime? SellSideCommitmentDate { get; set; }

		[DataMember(Name="sellSideCurrentRateSetDate")]
		public DateTime? SellSideCurrentRateSetDate { get; set; }

		[DataMember(Name="sellSideDaystoExtend")]
		public int? SellSideDaystoExtend { get; set; }

		[DataMember(Name="sellSideDiscountYSP")]
		public decimal? SellSideDiscountYSP { get; set; }

		[DataMember(Name="sellSideExtendedLockExpires")]
		public DateTime? SellSideExtendedLockExpires { get; set; }

		[DataMember(Name="sellSideGuaranteeFee")]
		public decimal? SellSideGuaranteeFee { get; set; }

		[DataMember(Name="sellSideGuarantyBaseFee")]
		public decimal? SellSideGuarantyBaseFee { get; set; }

		[DataMember(Name="sellSideInvestorStatus")]
		public string SellSideInvestorStatus { get; set; }

		[DataMember(Name="sellSideInvestorStatusDate")]
		public DateTime? SellSideInvestorStatusDate { get; set; }

		[DataMember(Name="sellSideInvestorTradeNumber")]
		public string SellSideInvestorTradeNumber { get; set; }

		[DataMember(Name="sellSideLoanProgram")]
		public string SellSideLoanProgram { get; set; }

		[DataMember(Name="sellSideLockDate")]
		public DateTime? SellSideLockDate { get; set; }

		[DataMember(Name="sellSideLockExpires")]
		public DateTime? SellSideLockExpires { get; set; }

		[DataMember(Name="sellSideLockExtendPriceAdjustment")]
		public decimal? SellSideLockExtendPriceAdjustment { get; set; }

		[DataMember(Name="sellSideMarginNetSellRate")]
		public decimal? SellSideMarginNetSellRate { get; set; }

		[DataMember(Name="sellSideMarginRate")]
		public decimal? SellSideMarginRate { get; set; }

		[DataMember(Name="sellSideMarginTotalAdjustment")]
		public decimal? SellSideMarginTotalAdjustment { get; set; }

		[DataMember(Name="sellSideMasterContractNumber")]
		public string SellSideMasterContractNumber { get; set; }

		[DataMember(Name="sellSideMSRValue")]
		public decimal? SellSideMSRValue { get; set; }

		[DataMember(Name="sellSideNetSellPrice")]
		public decimal? SellSideNetSellPrice { get; set; }

		[DataMember(Name="sellSideNetSellRate")]
		public decimal? SellSideNetSellRate { get; set; }

		[DataMember(Name="sellSideNumberOfDays")]
		public int? SellSideNumberOfDays { get; set; }

		[DataMember(Name="sellSideOriginalLockExpires")]
		public DateTime? SellSideOriginalLockExpires { get; set; }

		[DataMember(Name="sellSidePoolID")]
		public string SellSidePoolID { get; set; }

		[DataMember(Name="sellSidePoolNumber")]
		public string SellSidePoolNumber { get; set; }

		[DataMember(Name="sellSidePriceRate")]
		public decimal? SellSidePriceRate { get; set; }

		[DataMember(Name="sellSidePriceTotalAdjustment")]
		public decimal? SellSidePriceTotalAdjustment { get; set; }

		[DataMember(Name="sellSideProductName")]
		public string SellSideProductName { get; set; }

		[DataMember(Name="sellSideRate")]
		public decimal? SellSideRate { get; set; }

		[DataMember(Name="sellSideRateSheetID")]
		public string SellSideRateSheetID { get; set; }

		[DataMember(Name="sellSideRateTotalAdjustment")]
		public decimal? SellSideRateTotalAdjustment { get; set; }

		[DataMember(Name="sellSideRequestedBy")]
		public string SellSideRequestedBy { get; set; }

		[DataMember(Name="sellSideServicer")]
		public string SellSideServicer { get; set; }

		[DataMember(Name="sellSideServicingFee")]
		public decimal? SellSideServicingFee { get; set; }

		[DataMember(Name="sellSideServicingType")]
		public string SellSideServicingType { get; set; }

		[DataMember(Name="sellSideSRP")]
		public decimal? SellSideSRP { get; set; }

		[DataMember(Name="sellSideSRPPaidOut")]
		public decimal? SellSideSRPPaidOut { get; set; }

		[DataMember(Name="sellSideTradeGuid")]
		public string SellSideTradeGuid { get; set; }

		[DataMember(Name="sellSideTradeMgmtPrevConfirmedLockGuid")]
		public string SellSideTradeMgmtPrevConfirmedLockGuid { get; set; }

		[DataMember(Name="sellSideTradeNumber")]
		public string SellSideTradeNumber { get; set; }

		[DataMember(Name="servicingReleaseIndicator")]
		public bool? ServicingReleaseIndicator { get; set; }

		[DataMember(Name="sRP")]
		public decimal? SRP { get; set; }

		[DataMember(Name="sRPAmount")]
		public decimal? SRPAmount { get; set; }

		[DataMember(Name="sRPPaidOut")]
		public decimal? SRPPaidOut { get; set; }

		[DataMember(Name="subjectPropertyCity")]
		public string SubjectPropertyCity { get; set; }

		[DataMember(Name="subjectPropertyCondotelIndicator")]
		public bool? SubjectPropertyCondotelIndicator { get; set; }

		[DataMember(Name="subjectPropertyCounty")]
		public string SubjectPropertyCounty { get; set; }

		[DataMember(Name="subjectPropertyNonWarrantableProjectIndicator")]
		public bool? SubjectPropertyNonWarrantableProjectIndicator { get; set; }

		[DataMember(Name="subjectPropertyPostalCode")]
		public string SubjectPropertyPostalCode { get; set; }

		[DataMember(Name="subjectPropertyState")]
		public string SubjectPropertyState { get; set; }

		[DataMember(Name="subjectPropertyStreetAddress")]
		public string SubjectPropertyStreetAddress { get; set; }

		[DataMember(Name="timeLockedWithInvestor")]
		public string TimeLockedWithInvestor { get; set; }

		[DataMember(Name="totalBuyPrice")]
		public decimal? TotalBuyPrice { get; set; }

		[DataMember(Name="totalForLesserOfSumAsIs")]
		public decimal? TotalForLesserOfSumAsIs { get; set; }

		[DataMember(Name="totalPrice")]
		public decimal? TotalPrice { get; set; }

		[DataMember(Name="totalSubordinateFinancing")]
		public decimal? TotalSubordinateFinancing { get; set; }

		[DataMember(Name="twelveMonthMortgageRentalHistoryIndicator")]
		public bool? TwelveMonthMortgageRentalHistoryIndicator { get; set; }

		[DataMember(Name="type")]
		public string Type { get; set; }

		[DataMember(Name="usePoint")]
		public bool? UsePoint { get; set; }

		[DataMember(Name = "hCLTVHTLTV")]
		public decimal? HCLTVHTLTV { get; set; }

		[DataMember(Name = "FHASecondaryResidence")]
		public bool? FHASecondaryResidence { get; set; }

		[DataMember(Name = "subjectPropertyPropertyStreetAddress")]
		public string SubjectPropertyPropertyStreetAddress { get; set; }

		[DataMember(Name = "hELOCCreditLimit")]
		public decimal? HELOCCreditLimit { get; set; }

		[DataMember(Name = "notInProjectIndicator")]
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

		[DataMember(Name = "correspondentRetainUserInputs")]
		public bool? CorrespondentRetainUserInputs { get; set; } = false;
	}
}