using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class DisclosureTracking2015Contract
	{
		[DataMember(Name="actualFulfillmentDate", EmitDefaultValue=false)]
		public string ActualFulfillmentDate { get; set; }

		[DataMember(Name="actualLECD3TotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualLECD3TotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="actualLECD3TotalPayoffsAndPaymentsKFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualLECD3TotalPayoffsAndPaymentsKFromLatestRec { get; set; }

		[DataMember(Name="actualLELoanAmountFromLatestRec", EmitDefaultValue=false)]
		public string ActualLELoanAmountFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEAdjustmentAndOtherCreditsFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLEAdjustmentAndOtherCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEClosingCostFinancedFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLEClosingCostFinancedFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEDepositFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLEDepositFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLEFundForBorrowerFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLEFundForBorrowerFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLESellerCreditsFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLESellerCreditsFromLatestRec { get; set; }

		[DataMember(Name="actualSTDLETotalClosingCostJFromLatestRec", EmitDefaultValue=false)]
		public decimal? ActualSTDLETotalClosingCostJFromLatestRec { get; set; }

		[DataMember(Name="alerts", EmitDefaultValue=false)]
		public List<DisclosureTracking2015ContractAlerts> Alerts { get; set; }

		[DataMember(Name="applicationDate", EmitDefaultValue=false)]
		public DateTime? ApplicationDate { get; set; }

		[DataMember(Name="appliedCureAmount", EmitDefaultValue=false)]
		public decimal? AppliedCureAmount { get; set; }

		[DataMember(Name="automaticFulfillmentServiceName", EmitDefaultValue=false)]
		public string AutomaticFulfillmentServiceName { get; set; }

		[DataMember(Name="borrowerActualReceivedDate", EmitDefaultValue=false)]
		public string BorrowerActualReceivedDate { get; set; }

		[DataMember(Name="borrowerDisclosedMethod", EmitDefaultValue=false)]
		public string BorrowerDisclosedMethod { get; set; }

		[DataMember(Name="borrowerDisclosedMethodOther", EmitDefaultValue=false)]
		public string BorrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="borrowerPair", EmitDefaultValue=false)]
		public EntityRefContract BorrowerPair { get; set; }

		[DataMember(Name="borrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string BorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="borrowerType", EmitDefaultValue=false)]
		public string BorrowerType { get; set; }

		[DataMember(Name="cdDateIssued", EmitDefaultValue=false)]
		public string CdDateIssued { get; set; }

		[DataMember(Name="cdReason", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractCdReason CdReason { get; set; }

		[DataMember(Name="changeInCircumstance", EmitDefaultValue=false)]
		public string ChangeInCircumstance { get; set; }

		[DataMember(Name="changeInCircumstanceComments", EmitDefaultValue=false)]
		public string ChangeInCircumstanceComments { get; set; }

		[DataMember(Name="changesReceivedDate", EmitDefaultValue=false)]
		public string ChangesReceivedDate { get; set; }

		[DataMember(Name="chargesCannotIncrease10Itemization34", EmitDefaultValue=false)]
		public string ChargesCannotIncrease10Itemization34 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseItemization9", EmitDefaultValue=false)]
		public string ChargesThatCannotDecreaseItemization9 { get; set; }

		[DataMember(Name="chargesThatCannotDecreaseLE7", EmitDefaultValue=false)]
		public string ChargesThatCannotDecreaseLE7 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseItemization13", EmitDefaultValue=false)]
		public string ChargesThatCannotIncreaseItemization13 { get; set; }

		[DataMember(Name="chargesThatCannotIncreaseLE11", EmitDefaultValue=false)]
		public string ChargesThatCannotIncreaseLE11 { get; set; }

		[DataMember(Name="closingDate", EmitDefaultValue=false)]
		public string ClosingDate { get; set; }

		[DataMember(Name="coborrowerActualReceivedDate", EmitDefaultValue=false)]
		public string CoborrowerActualReceivedDate { get; set; }

		[DataMember(Name="coborrowerDisclosedMethod", EmitDefaultValue=false)]
		public string CoborrowerDisclosedMethod { get; set; }

		[DataMember(Name="coborrowerDisclosedMethodOther", EmitDefaultValue=false)]
		public string CoborrowerDisclosedMethodOther { get; set; }

		[DataMember(Name="coborrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string CoborrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="coborrowerType", EmitDefaultValue=false)]
		public string CoborrowerType { get; set; }

		[DataMember(Name="commentList", EmitDefaultValue=false)]
		public List<DisclosureTracking2015ContractCommentList> CommentList { get; set; }

		[DataMember(Name="comments", EmitDefaultValue=false)]
		public string Comments { get; set; }

		[DataMember(Name="containCD", EmitDefaultValue=false)]
		public bool? ContainCD { get; set; }

		[DataMember(Name="containLE", EmitDefaultValue=false)]
		public bool? ContainLE { get; set; }

		[DataMember(Name="cureAppliedToLenderCredit", EmitDefaultValue=false)]
		public decimal? CureAppliedToLenderCredit { get; set; }

		[DataMember(Name="cureAppliedToPrincipalReduction", EmitDefaultValue=false)]
		public decimal? CureAppliedToPrincipalReduction { get; set; }

		[DataMember(Name="dateAdded", EmitDefaultValue=false)]
		public DateTime? DateAdded { get; set; }

		[DataMember(Name="disclosedAPR", EmitDefaultValue=false)]
		public string DisclosedAPR { get; set; }

		[DataMember(Name="disclosedBy", EmitDefaultValue=false)]
		public EntityRefContract DisclosedBy { get; set; }

		[DataMember(Name="disclosedDailyInterest", EmitDefaultValue=false)]
		public string DisclosedDailyInterest { get; set; }

		[DataMember(Name="disclosedDate", EmitDefaultValue=false)]
		public string DisclosedDate { get; set; }

		[DataMember(Name="disclosedMethod", EmitDefaultValue=false)]
		public string DisclosedMethod { get; set; }

		[DataMember(Name="disclosedMethodName", EmitDefaultValue=false)]
		public string DisclosedMethodName { get; set; }

		[DataMember(Name="disclosedMethodOther", EmitDefaultValue=false)]
		public string DisclosedMethodOther { get; set; }

		[DataMember(Name="disclosedSalesPrice", EmitDefaultValue=false)]
		public string DisclosedSalesPrice { get; set; }

		[DataMember(Name="disclosureCreatedDate", EmitDefaultValue=false)]
		public DateTime? DisclosureCreatedDate { get; set; }

		[DataMember(Name="disclosureMethod", EmitDefaultValue=false)]
		public string DisclosureMethod { get; set; }

		[DataMember(Name="disclosureType", EmitDefaultValue=false)]
		public string DisclosureType { get; set; }

		[DataMember(Name="eDisclosure", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractEDisclosure EDisclosure { get; set; }

		[DataMember(Name="edsRequestGuid", EmitDefaultValue=false)]
		public string EdsRequestGuid { get; set; }

		[DataMember(Name="financeCharge", EmitDefaultValue=false)]
		public string FinanceCharge { get; set; }

		[DataMember(Name="forms", EmitDefaultValue=false)]
		public List<LoanContractForms> Forms { get; set; }

		[DataMember(Name="fulfillmentOrderedBy", EmitDefaultValue=false)]
		public EntityRefContract FulfillmentOrderedBy { get; set; }

		[DataMember(Name="fulfillmentOrderedByCoborrower", EmitDefaultValue=false)]
		public string FulfillmentOrderedByCoborrower { get; set; }

		[DataMember(Name="fulfillmentProcessedDate", EmitDefaultValue=false)]
		public DateTime? FulfillmentProcessedDate { get; set; }

		[DataMember(Name="fulfillmentProcessedDateCoborrower", EmitDefaultValue=false)]
		public DateTime? FulfillmentProcessedDateCoborrower { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="intentToProceed", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractIntentToProceed IntentToProceed { get; set; }

		[DataMember(Name="lenderCompensationCreditAmount2", EmitDefaultValue=false)]
		public decimal? LenderCompensationCreditAmount2 { get; set; }

		[DataMember(Name="lenderTotalPaidOriginatorAmount", EmitDefaultValue=false)]
		public decimal? LenderTotalPaidOriginatorAmount { get; set; }

		[DataMember(Name="leReason", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractLeReason LeReason { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount1", EmitDefaultValue=false)]
		public decimal? Line802LOCompAdditionalAmount1 { get; set; }

		[DataMember(Name="line802LOCompAdditionalAmount2", EmitDefaultValue=false)]
		public decimal? Line802LOCompAdditionalAmount2 { get; set; }

		[DataMember(Name="lineIndicators", EmitDefaultValue=false)]
		public List<string> LineIndicators { get; set; }

		[DataMember(Name="linkedGuid", EmitDefaultValue=false)]
		public string LinkedGuid { get; set; }

		[DataMember(Name="loanAdjustmentsOtherCredits", EmitDefaultValue=false)]
		public decimal? LoanAdjustmentsOtherCredits { get; set; }

		[DataMember(Name="loanAmount", EmitDefaultValue=false)]
		public decimal? LoanAmount { get; set; }

		[DataMember(Name="loanClosingCost", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractLoanClosingCost LoanClosingCost { get; set; }

		[DataMember(Name="loanDownPayment", EmitDefaultValue=false)]
		public decimal? LoanDownPayment { get; set; }

		[DataMember(Name="loanEstimate", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractLoanEstimate LoanEstimate { get; set; }

		[DataMember(Name="loanFeesCityTaxBorPaidAmount", EmitDefaultValue=false)]
		public decimal? LoanFeesCityTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFeesStateTaxBorPaidAmount", EmitDefaultValue=false)]
		public decimal? LoanFeesStateTaxBorPaidAmount { get; set; }

		[DataMember(Name="loanFundsForBorrower", EmitDefaultValue=false)]
		public decimal? LoanFundsForBorrower { get; set; }

		[DataMember(Name="loanGFEAgregateAdjustment", EmitDefaultValue=false)]
		public decimal? LoanGFEAgregateAdjustment { get; set; }

		[DataMember(Name="loanGFEGovernmentRecordingCharges", EmitDefaultValue=false)]
		public decimal? LoanGFEGovernmentRecordingCharges { get; set; }

		[DataMember(Name="loanLineItemAmount", EmitDefaultValue=false)]
		public decimal? LoanLineItemAmount { get; set; }

		[DataMember(Name="loanProgram", EmitDefaultValue=false)]
		public string LoanProgram { get; set; }

		[DataMember(Name="loanPurchaseCredit", EmitDefaultValue=false)]
		public List<DisclosureTracking2015ContractLoanPurchaseCredit> LoanPurchaseCredit { get; set; }

		[DataMember(Name="loanRefinanceIncludingDebtsToBePaidOffAmount", EmitDefaultValue=false)]
		public decimal? LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }

		[DataMember(Name="loanSection1000SellerPaidTotalAmount", EmitDefaultValue=false)]
		public decimal? LoanSection1000SellerPaidTotalAmount { get; set; }

		[DataMember(Name="loanSellerCreditAmount", EmitDefaultValue=false)]
		public decimal? LoanSellerCreditAmount { get; set; }

		[DataMember(Name="loanTotalClosingCosts", EmitDefaultValue=false)]
		public decimal? LoanTotalClosingCosts { get; set; }

		[DataMember(Name="lockedBorrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string LockedBorrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedBorrowerType", EmitDefaultValue=false)]
		public string LockedBorrowerType { get; set; }

		[DataMember(Name="lockedCoborrowerPresumedReceivedDate", EmitDefaultValue=false)]
		public string LockedCoborrowerPresumedReceivedDate { get; set; }

		[DataMember(Name="lockedCoborrowerType", EmitDefaultValue=false)]
		public string LockedCoborrowerType { get; set; }

		[DataMember(Name="lockedDisclosedAPRField", EmitDefaultValue=false)]
		public string LockedDisclosedAPRField { get; set; }

		[DataMember(Name="lockedDisclosedByField", EmitDefaultValue=false)]
		public string LockedDisclosedByField { get; set; }

		[DataMember(Name="lockedDisclosedDailyInterestField", EmitDefaultValue=false)]
		public string LockedDisclosedDailyInterestField { get; set; }

		[DataMember(Name="lockedDisclosedDateField", EmitDefaultValue=false)]
		public string LockedDisclosedDateField { get; set; }

		[DataMember(Name="lockedDisclosedFinanceChargeField", EmitDefaultValue=false)]
		public string LockedDisclosedFinanceChargeField { get; set; }

		[DataMember(Name="lockedDisclosedReceivedDate", EmitDefaultValue=false)]
		public string LockedDisclosedReceivedDate { get; set; }

		[DataMember(Name="lockedIntentReceivedByField", EmitDefaultValue=false)]
		public string LockedIntentReceivedByField { get; set; }

		[DataMember(Name="logIndicators", EmitDefaultValue=false)]
		public List<string> LogIndicators { get; set; }

		[DataMember(Name="numberOfDisclosureDocs", EmitDefaultValue=false)]
		public int? NumberOfDisclosureDocs { get; set; }

		[DataMember(Name="presumedFulfillmentDate", EmitDefaultValue=false)]
		public string PresumedFulfillmentDate { get; set; }

		[DataMember(Name="propertyAddress", EmitDefaultValue=false)]
		public DisclosureTracking2015ContractPropertyAddress PropertyAddress { get; set; }

		[DataMember(Name="purchasePriceAmount", EmitDefaultValue=false)]
		public decimal? PurchasePriceAmount { get; set; }

		[DataMember(Name="receivedDate", EmitDefaultValue=false)]
		public string ReceivedDate { get; set; }

		[DataMember(Name="revisedDueDate", EmitDefaultValue=false)]
		public string RevisedDueDate { get; set; }

		[DataMember(Name="snapshotFields", EmitDefaultValue=false)]
		public EntityRefContract SnapshotFields { get; set; }

		[DataMember(Name="stdAdjustmentAndOtherCreditsRemark", EmitDefaultValue=false)]
		public string StdAdjustmentAndOtherCreditsRemark { get; set; }

		[DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
		public DateTime? UpdatedDateUtc { get; set; }

	}
}