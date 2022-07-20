using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015Contract
	{
		[DataMember(Name="actualFulfillmentDate")]
		public string ActualFulfillmentDate { get; set; }

		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec")]
		public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec")]
		public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec")]
		public string ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec")]
		public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec")]
		public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec")]
		public decimal? ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec")]
		public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec")]
		public decimal? ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec")]
		public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="alerts")]
		public List<DisclosureTracking2015ContractAlerts> Alerts { get; set; }

		[DataMember(Name="applicationDate")]
		public DateTime? ApplicationDate { get; set; }

		[DataMember(Name="appliedCureAmount")]
		public decimal? AppliedCureAmount { get; set; }

		[DataMember(Name="automaticFulfillmentServiceName")]
		public string AutomaticFulfillmentServiceName { get; set; }

		[DataMember(Name="borrowerActualReceivedDate")]
		public string BorrowerActualReceivedDate { get; set; }

		[DataMember(Name="borrowerDisclosedMethod")]
		public string BorrowerDisclosedMethod { get; set; }

		[DataMember(Name="borrowerDisclosedMethodOther")]
		public string BorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="borrowerPair")]
		public EntityRefContract BorrowerPair { get; set; }

		[DataMember(Name="borrowerPresumedReceivedDate")]
		public string BorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="borrowerType")]
		public string BorrowerType { get; set; }

		[DataMember(Name="cdDateIssued")]
		public string CdDateIssued { get; set; }

		[DataMember(Name="cdReason")]
		public DisclosureTracking2015ContractCdReason CdReason { get; set; }

		[DataMember(Name="changeInCircumstance")]
		public string ChangeInCircumstance { get; set; }

		[DataMember(Name="changeInCircumstanceComments")]
		public string ChangeInCircumstanceComments { get; set; }

		[DataMember(Name="changesReceivedDate")]
		public string ChangesReceivedDate { get; set; }

		[DataMember(Name="chargesCannotIncrease10Itemization34")]
		public string ChargesCannotIncrease10Itemization34 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseItemization9")]
		public string ChargesThatCannotDecreaseItemization9 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE7")]
		public string ChargesThatCannotDecreaseLE7 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseItemization13")]
		public string ChargesThatCannotIncreaseItemization13 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE11")]
		public string ChargesThatCannotIncreaseLE11 { get; set; }

		[DataMember(Name="closingDate")]
		public string ClosingDate { get; set; }

		[DataMember(Name="coborrowerActualReceivedDate")]
		public string CoborrowerActualReceivedDate { get; set; }

		[DataMember(Name="coborrowerDisclosedMethod")]
		public string CoborrowerDisclosedMethod { get; set; }

		[DataMember(Name="coborrowerDisclosedMethodOther")]
		public string CoborrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="coborrowerPresumedReceivedDate")]
		public string CoborrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="coborrowerType")]
		public string CoborrowerType { get; set; }

		[DataMember(Name="commentList")]
		public List<DisclosureTracking2015ContractCommentList> CommentList { get; set; }

		[DataMember(Name="comments")]
		public string Comments { get; set; }

		[DataMember(Name="containCD")]
		public bool? ContainCD { get; set; }

		[DataMember(Name="containLE")]
		public bool? ContainLE { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit")]
		public decimal? CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction")]
		public decimal? CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="dateAdded")]
		public DateTime? DateAdded { get; set; }

		[DataMember(Name="disclosedAPR")]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy")]
		public EntityRefContract DisclosedBy { get; set; }

		[DataMember(Name="disclosedDailyInterest")]
		public string DisclosedDailyInterest { get; set; }

		[DataMember(Name="disclosedDate")]
		public string DisclosedDate { get; set; }

		[DataMember(Name="disclosedMethod")]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosedMethodName")]
		public string DisclosedMethodName { get; set; }

		[DataMember(Name="disclosedMethodOther")]
		public string DisclosedMethodOther { get; set; }

		[DataMember(Name="disclosedSalesPrice")]
		public string DisclosedSalesPrice { get; set; }

		[DataMember(Name="disclosureCreatedDate")]
		public DateTime? DisclosureCreatedDate { get; set; }

		[DataMember(Name="disclosureMethod")]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType")]
		public string DisclosureType { get; set; }

		[DataMember(Name="eDisclosure")]
		public DisclosureTracking2015ContractEDisclosure EDisclosure { get; set; }

		[DataMember(Name="edsRequestGuid")]
		public string EdsRequestGuid { get; set; }

		[DataMember(Name="financeCharge")]
		public string FinanceCharge { get; set; }

		[DataMember(Name="forms")]
		public List<LoanContractForms> Forms { get; set; }

		[DataMember(Name="fulfillmentOrderedBy")]
		public EntityRefContract FulfillmentOrderedBy { get; set; }

		[DataMember(Name="fulfillmentOrderedByCoborrower")]
		public string FulfillmentOrderedByCoborrower { get; set; }

		[DataMember(Name="fulfillmentProcessedDate")]
		public DateTime? FulfillmentProcessedDate { get; set; }

		[DataMember(Name="fulfillmentProcessedDateCoborrower")]
		public DateTime? FulfillmentProcessedDateCoborrower { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="intentToProceed")]
		public DisclosureTracking2015ContractIntentToProceed IntentToProceed { get; set; }

		[DataMember(Name="lenderCompensationCreditAmount2")]
		public decimal? LenderCompensationCreditAmount2 { get; set; }

		[DataMember(Name="lenderTotalPaidOriginatorAmount")]
		public decimal? LenderTotalPaidOriginatorAmount { get; set; }

		[DataMember(Name="leReason")]
		public DisclosureTracking2015ContractLeReason LeReason { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount1")]
		public decimal? Line802LOCompAdditionalAmount1 { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount2")]
		public decimal? Line802LOCompAdditionalAmount2 { get; set; }

		[DataMember(Name="lineIndicators")]
		public List<string> LineIndicators { get; set; }

		[DataMember(Name="linkedGuid")]
		public string LinkedGuid { get; set; }

		[DataMember(Name="loanAdjustmentsOtherCredits")]
		public decimal? LoanAdjustmentsOtherCredits { get; set; }

		[DataMember(Name="loanAmount")]
		public decimal? LoanAmount { get; set; }

		[DataMember(Name="loanClosingCost")]
		public DisclosureTracking2015ContractLoanClosingCost LoanClosingCost { get; set; }

		[DataMember(Name="loanDownPayment")]
		public decimal? LoanDownPayment { get; set; }

		[DataMember(Name="loanEstimate")]
		public DisclosureTracking2015ContractLoanEstimate LoanEstimate { get; set; }

		[DataMember(Name="loanFeesCityTaxBorPaidAmount")]
		public decimal? LoanFeesCityTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFeesStateTaxBorPaidAmount")]
		public decimal? LoanFeesStateTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFundsForBorrower")]
		public decimal? LoanFundsForBorrower { get; set; }

		[DataMember(Name="loanGFEAgregateAdjustment")]
		public decimal? LoanGFEAgregateAdjustment { get; set; }

		[DataMember(Name="loanGFEGovernmentRecordingCharges")]
		public decimal? LoanGFEGovernmentRecordingCharges { get; set; }

		[DataMember(Name="loanLineItemAmount")]
		public decimal? LoanLineItemAmount { get; set; }

		[DataMember(Name="loanProgram")]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanPurchaseCredit")]
		public List<DisclosureTracking2015ContractLoanPurchaseCredit> LoanPurchaseCredit { get; set; }

		[DataMember(Name="loanRefinanceIncludingDebtsToBePaidOffAmount")]
		public decimal? LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="loanSection1000SellerPaidTotalAmount")]
		public decimal? LoanSection1000SellerPaidTotalAmount { get; set; }

		[DataMember(Name="loanSellerCreditAmount")]
		public decimal? LoanSellerCreditAmount { get; set; }

		[DataMember(Name="loanTotalClosingCosts")]
		public decimal? LoanTotalClosingCosts { get; set; }

		[DataMember(Name="lockedBorrowerPresumedReceivedDate")]
		public string LockedBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedBorrowerType")]
		public string LockedBorrowerType { get; set; }

		[DataMember(Name="lockedCoborrowerPresumedReceivedDate")]
		public string LockedCoborrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedCoborrowerType")]
		public string LockedCoborrowerType { get; set; }

		[DataMember(Name="lockedDisclosedAPRField")]
		public string LockedDisclosedAPRField { get; set; }

		[DataMember(Name="lockedDisclosedByField")]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedDailyInterestField")]
		public string LockedDisclosedDailyInterestField { get; set; }

		[DataMember(Name="lockedDisclosedDateField")]
		public string LockedDisclosedDateField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField")]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate")]
		public string LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="lockedIntentReceivedByField")]
		public string LockedIntentReceivedByField { get; set; }

		[DataMember(Name="logIndicators")]
		public List<string> LogIndicators { get; set; }

		[DataMember(Name="numberOfDisclosureDocs")]
		public int? NumberOfDisclosureDocs { get; set; }

		[DataMember(Name="presumedFulfillmentDate")]
		public string PresumedFulfillmentDate { get; set; }

		[DataMember(Name="propertyAddress")]
		public DisclosureTracking2015ContractPropertyAddress PropertyAddress { get; set; }

		[DataMember(Name="purchasePriceAmount")]
		public decimal? PurchasePriceAmount { get; set; }

		[DataMember(Name="receivedDate")]
		public string ReceivedDate { get; set; }

		[DataMember(Name="revisedDueDate")]
		public string RevisedDueDate { get; set; }

		[DataMember(Name="snapshotFields")]
		public EntityRefContract SnapshotFields { get; set; }

		[DataMember(Name="stdAdjustmentAndOtherCreditsRemark")]
		public string StdAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="updatedDateUtc")]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}