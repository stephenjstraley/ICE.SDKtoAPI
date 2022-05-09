using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractStateDisclosure
	{
		[DataMember(Name="acceptedByBorrowerIndicator", EmitDefaultValue=false)]
		public bool? AcceptedByBorrowerIndicator { get; set; }

		[DataMember(Name="acceptedDate", EmitDefaultValue=false)]
		public DateTime? AcceptedDate { get; set; }

		[DataMember(Name="actingOtherDescription1", EmitDefaultValue=false)]
		public string ActingOtherDescription1 { get; set; }

		[DataMember(Name="actingOtherDescription2", EmitDefaultValue=false)]
		public string ActingOtherDescription2 { get; set; }

		[DataMember(Name="actingOthersIndicator", EmitDefaultValue=false)]
		public bool? ActingOthersIndicator { get; set; }

		[DataMember(Name="advFeeAgmtInEfctNumDay", EmitDefaultValue=false)]
		public int? AdvFeeAgmtInEfctNumDay { get; set; }

		[DataMember(Name="advisoryCondition1", EmitDefaultValue=false)]
		public string AdvisoryCondition1 { get; set; }

		[DataMember(Name="advisoryCondition2", EmitDefaultValue=false)]
		public string AdvisoryCondition2 { get; set; }

		[DataMember(Name="advisoryCondition3", EmitDefaultValue=false)]
		public string AdvisoryCondition3 { get; set; }

		[DataMember(Name="advisoryCondition4", EmitDefaultValue=false)]
		public string AdvisoryCondition4 { get; set; }

		[DataMember(Name="amendedAcquisitionCost", EmitDefaultValue=false)]
		public double? AmendedAcquisitionCost { get; set; }

		[DataMember(Name="applicationDate", EmitDefaultValue=false)]
		public DateTime? ApplicationDate { get; set; }

		[DataMember(Name="appraisalContact", EmitDefaultValue=false)]
		public string AppraisalContact { get; set; }

		[DataMember(Name="appraisalDeposit", EmitDefaultValue=false)]
		public double? AppraisalDeposit { get; set; }

		[DataMember(Name="areas", EmitDefaultValue=false)]
		public string Areas { get; set; }

		[DataMember(Name="asAttorneyIndicator", EmitDefaultValue=false)]
		public bool? AsAttorneyIndicator { get; set; }

		[DataMember(Name="asRealBrokerIndicator", EmitDefaultValue=false)]
		public bool? AsRealBrokerIndicator { get; set; }

		[DataMember(Name="attorneyForTheBuyerIndicator", EmitDefaultValue=false)]
		public bool? AttorneyForTheBuyerIndicator { get; set; }

		[DataMember(Name="attorneyForTheLenderIndicator", EmitDefaultValue=false)]
		public bool? AttorneyForTheLenderIndicator { get; set; }

		[DataMember(Name="attorneyForTheSellerIndicator", EmitDefaultValue=false)]
		public bool? AttorneyForTheSellerIndicator { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc1BlankFldDesc1", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc1BlankFldDesc1 { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc1BlankFldDesc2", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc1BlankFldDesc2 { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc1BlankFldDesc3", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc1BlankFldDesc3 { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc1Nm", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc1Nm { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc2Nm", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc2Nm { get; set; }

		[DataMember(Name="aZCmplBlankSpcsDoc3Nm", EmitDefaultValue=false)]
		public string AZCmplBlankSpcsDoc3Nm { get; set; }

		[DataMember(Name="basedOnOthersDescription", EmitDefaultValue=false)]
		public string BasedOnOthersDescription { get; set; }

		[DataMember(Name="basedOnOthersIndicator", EmitDefaultValue=false)]
		public bool? BasedOnOthersIndicator { get; set; }

		[DataMember(Name="basedOnWholesaleOptionsIndicator", EmitDefaultValue=false)]
		public bool? BasedOnWholesaleOptionsIndicator { get; set; }

		[DataMember(Name="borrowerElectsEstablishEscrowAmount", EmitDefaultValue=false)]
		public double? BorrowerElectsEstablishEscrowAmount { get; set; }

		[DataMember(Name="borrowerElectsEstablishEscrowIndicator", EmitDefaultValue=false)]
		public bool? BorrowerElectsEstablishEscrowIndicator { get; set; }

		[DataMember(Name="brokerageFeeAddition1", EmitDefaultValue=false)]
		public double? BrokerageFeeAddition1 { get; set; }

		[DataMember(Name="brokerageFeeAddition2", EmitDefaultValue=false)]
		public double? BrokerageFeeAddition2 { get; set; }

		[DataMember(Name="brokerageFeeAddition3", EmitDefaultValue=false)]
		public double? BrokerageFeeAddition3 { get; set; }

		[DataMember(Name="brokerageFeeAmount1", EmitDefaultValue=false)]
		public double? BrokerageFeeAmount1 { get; set; }

		[DataMember(Name="brokerageFeeAmount2", EmitDefaultValue=false)]
		public double? BrokerageFeeAmount2 { get; set; }

		[DataMember(Name="brokerageFeeAmount3", EmitDefaultValue=false)]
		public double? BrokerageFeeAmount3 { get; set; }

		[DataMember(Name="brokerageFeeDays", EmitDefaultValue=false)]
		public int? BrokerageFeeDays { get; set; }

		[DataMember(Name="brokerageFeePercent1", EmitDefaultValue=false)]
		public double? BrokerageFeePercent1 { get; set; }

		[DataMember(Name="brokerageFeePercent2", EmitDefaultValue=false)]
		public double? BrokerageFeePercent2 { get; set; }

		[DataMember(Name="brokerageFeePercent3", EmitDefaultValue=false)]
		public double? BrokerageFeePercent3 { get; set; }

		[DataMember(Name="brokerAuthorizedSigningRepName", EmitDefaultValue=false)]
		public string BrokerAuthorizedSigningRepName { get; set; }

		[DataMember(Name="brokerAuthorizedSigningRepTitle", EmitDefaultValue=false)]
		public string BrokerAuthorizedSigningRepTitle { get; set; }

		[DataMember(Name="brokerForTheSeller", EmitDefaultValue=false)]
		public string BrokerForTheSeller { get; set; }

		[DataMember(Name="brokerLicense", EmitDefaultValue=false)]
		public string BrokerLicense { get; set; }

		[DataMember(Name="brokerName", EmitDefaultValue=false)]
		public string BrokerName { get; set; }

		[DataMember(Name="brokerPayAddition", EmitDefaultValue=false)]
		public double? BrokerPayAddition { get; set; }

		[DataMember(Name="brokerPayAmount", EmitDefaultValue=false)]
		public double? BrokerPayAmount { get; set; }

		[DataMember(Name="brokerPayIndicator", EmitDefaultValue=false)]
		public bool? BrokerPayIndicator { get; set; }

		[DataMember(Name="brokerPayPercent", EmitDefaultValue=false)]
		public double? BrokerPayPercent { get; set; }

		[DataMember(Name="cHARMBookletIndicator", EmitDefaultValue=false)]
		public bool? CHARMBookletIndicator { get; set; }

		[DataMember(Name="checkPayableTo", EmitDefaultValue=false)]
		public string CheckPayableTo { get; set; }

		[DataMember(Name="commitmentAmount", EmitDefaultValue=false)]
		public double? CommitmentAmount { get; set; }

		[DataMember(Name="commitmentCondition1", EmitDefaultValue=false)]
		public string CommitmentCondition1 { get; set; }

		[DataMember(Name="commitmentCondition2", EmitDefaultValue=false)]
		public string CommitmentCondition2 { get; set; }

		[DataMember(Name="commitmentFee", EmitDefaultValue=false)]
		public double? CommitmentFee { get; set; }

		[DataMember(Name="commitmentPercent", EmitDefaultValue=false)]
		public double? CommitmentPercent { get; set; }

		[DataMember(Name="compensationAddition", EmitDefaultValue=false)]
		public double? CompensationAddition { get; set; }

		[DataMember(Name="compensationPercent", EmitDefaultValue=false)]
		public double? CompensationPercent { get; set; }

		[DataMember(Name="creditDeposit", EmitDefaultValue=false)]
		public double? CreditDeposit { get; set; }

		[DataMember(Name="creditIsUsedForReason", EmitDefaultValue=false)]
		public string CreditIsUsedForReason { get; set; }

		[DataMember(Name="creditReportContact", EmitDefaultValue=false)]
		public string CreditReportContact { get; set; }

		[DataMember(Name="daysBeforeClosing", EmitDefaultValue=false)]
		public int? DaysBeforeClosing { get; set; }

		[DataMember(Name="depositReceipt", EmitDefaultValue=false)]
		public double? DepositReceipt { get; set; }

		[DataMember(Name="depositRefundableIndicator", EmitDefaultValue=false)]
		public bool? DepositRefundableIndicator { get; set; }

		[DataMember(Name="directContact", EmitDefaultValue=false)]
		public string DirectContact { get; set; }

		[DataMember(Name="directPayAmount", EmitDefaultValue=false)]
		public double? DirectPayAmount { get; set; }

		[DataMember(Name="directPayClosing", EmitDefaultValue=false)]
		public double? DirectPayClosing { get; set; }

		[DataMember(Name="directPayCommitment", EmitDefaultValue=false)]
		public double? DirectPayCommitment { get; set; }

		[DataMember(Name="directPayIndicator", EmitDefaultValue=false)]
		public bool? DirectPayIndicator { get; set; }

		[DataMember(Name="directPayPercent", EmitDefaultValue=false)]
		public double? DirectPayPercent { get; set; }

		[DataMember(Name="disclosureDeliveredBy", EmitDefaultValue=false)]
		public string DisclosureDeliveredBy { get; set; }

		[DataMember(Name="disclosureDeliveredByOtherMethod", EmitDefaultValue=false)]
		public string DisclosureDeliveredByOtherMethod { get; set; }

		[DataMember(Name="disclosureDeliveredDate", EmitDefaultValue=false)]
		public DateTime? DisclosureDeliveredDate { get; set; }

		[DataMember(Name="estimatedChargeShownOnGFEIndicator", EmitDefaultValue=false)]
		public bool? EstimatedChargeShownOnGFEIndicator { get; set; }

		[DataMember(Name="expirationDate", EmitDefaultValue=false)]
		public DateTime? ExpirationDate { get; set; }

		[DataMember(Name="federallySubsidizedAmount", EmitDefaultValue=false)]
		public double? FederallySubsidizedAmount { get; set; }

		[DataMember(Name="federallySubsidizedAmountPercentage", EmitDefaultValue=false)]
		public double? FederallySubsidizedAmountPercentage { get; set; }

		[DataMember(Name="feeReceived1", EmitDefaultValue=false)]
		public double? FeeReceived1 { get; set; }

		[DataMember(Name="feeReceived2", EmitDefaultValue=false)]
		public double? FeeReceived2 { get; set; }

		[DataMember(Name="feeReceivedByLender", EmitDefaultValue=false)]
		public string FeeReceivedByLender { get; set; }

		[DataMember(Name="feesReceiving", EmitDefaultValue=false)]
		public double? FeesReceiving { get; set; }

		[DataMember(Name="floridaApplicationFee", EmitDefaultValue=false)]
		public double? FloridaApplicationFee { get; set; }

		[DataMember(Name="floridaOtherFee1", EmitDefaultValue=false)]
		public double? FloridaOtherFee1 { get; set; }

		[DataMember(Name="floridaOtherFee2", EmitDefaultValue=false)]
		public double? FloridaOtherFee2 { get; set; }

		[DataMember(Name="floridaOtherFeeTo1", EmitDefaultValue=false)]
		public string FloridaOtherFeeTo1 { get; set; }

		[DataMember(Name="floridaOtherFeeTo2", EmitDefaultValue=false)]
		public string FloridaOtherFeeTo2 { get; set; }

		[DataMember(Name="floridaOtherFeeTo3", EmitDefaultValue=false)]
		public string FloridaOtherFeeTo3 { get; set; }

		[DataMember(Name="floridaOtherFeeTo4", EmitDefaultValue=false)]
		public string FloridaOtherFeeTo4 { get; set; }

		[DataMember(Name="furtherFeesEarnedByMortgageBroker", EmitDefaultValue=false)]
		public string FurtherFeesEarnedByMortgageBroker { get; set; }

		[DataMember(Name="gFEFeeReceived1", EmitDefaultValue=false)]
		public double? GFEFeeReceived1 { get; set; }

		[DataMember(Name="gFEFeeReceived2", EmitDefaultValue=false)]
		public double? GFEFeeReceived2 { get; set; }

		[DataMember(Name="hUDBookletIndicator", EmitDefaultValue=false)]
		public bool? HUDBookletIndicator { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="independentContractorIndicator", EmitDefaultValue=false)]
		public bool? IndependentContractorIndicator { get; set; }

		[DataMember(Name="indexUsed", EmitDefaultValue=false)]
		public string IndexUsed { get; set; }

		[DataMember(Name="informationAboutTheIndexCanBeFound", EmitDefaultValue=false)]
		public string InformationAboutTheIndexCanBeFound { get; set; }

		[DataMember(Name="inLicensedNo", EmitDefaultValue=false)]
		public string InLicensedNo { get; set; }

		[DataMember(Name="inLicensedType", EmitDefaultValue=false)]
		public string InLicensedType { get; set; }

		[DataMember(Name="isEstimateIndicator", EmitDefaultValue=false)]
		public bool? IsEstimateIndicator { get; set; }

		[DataMember(Name="ksUcccElectionIndicator", EmitDefaultValue=false)]
		public bool? KsUcccElectionIndicator { get; set; }

		[DataMember(Name="kyHomeSolicationLoanIndicator", EmitDefaultValue=false)]
		public bool? KyHomeSolicationLoanIndicator { get; set; }

		[DataMember(Name="leaseAgreementDate", EmitDefaultValue=false)]
		public DateTime? LeaseAgreementDate { get; set; }

		[DataMember(Name="lenderDate", EmitDefaultValue=false)]
		public DateTime? LenderDate { get; set; }

		[DataMember(Name="lenderName", EmitDefaultValue=false)]
		public string LenderName { get; set; }

		[DataMember(Name="lenderPaid", EmitDefaultValue=false)]
		public double? LenderPaid { get; set; }

		[DataMember(Name="lenderPayAmount", EmitDefaultValue=false)]
		public double? LenderPayAmount { get; set; }

		[DataMember(Name="lenderPayIndicator", EmitDefaultValue=false)]
		public bool? LenderPayIndicator { get; set; }

		[DataMember(Name="lenderPayMaxPoint", EmitDefaultValue=false)]
		public double? LenderPayMaxPoint { get; set; }

		[DataMember(Name="lenderPayPercent", EmitDefaultValue=false)]
		public double? LenderPayPercent { get; set; }

		[DataMember(Name="lenderPayPoint", EmitDefaultValue=false)]
		public double? LenderPayPoint { get; set; }

		[DataMember(Name="lenderPayUnknownIndicator", EmitDefaultValue=false)]
		public bool? LenderPayUnknownIndicator { get; set; }

		[DataMember(Name="lenderStatus", EmitDefaultValue=false)]
		public string LenderStatus { get; set; }

		[DataMember(Name="lessorName", EmitDefaultValue=false)]
		public string LessorName { get; set; }

		[DataMember(Name="loanTermsFixedThroughDateofLoanClosingIndicator", EmitDefaultValue=false)]
		public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get; set; }

		[DataMember(Name="lockInFee", EmitDefaultValue=false)]
		public double? LockInFee { get; set; }

		[DataMember(Name="methodDescription", EmitDefaultValue=false)]
		public string MethodDescription { get; set; }

		[DataMember(Name="methodDetermine", EmitDefaultValue=false)]
		public string MethodDetermine { get; set; }

		[DataMember(Name="mortgageAgreementIndicator", EmitDefaultValue=false)]
		public bool? MortgageAgreementIndicator { get; set; }

		[DataMember(Name="mtgBrokerLicense", EmitDefaultValue=false)]
		public string MtgBrokerLicense { get; set; }

		[DataMember(Name="nameOfLicensee", EmitDefaultValue=false)]
		public string NameOfLicensee { get; set; }

		[DataMember(Name="newMoneyAmount", EmitDefaultValue=false)]
		public double? NewMoneyAmount { get; set; }

		[DataMember(Name="newYorkApplicationFee", EmitDefaultValue=false)]
		public double? NewYorkApplicationFee { get; set; }

		[DataMember(Name="newYorkAppraisalFee", EmitDefaultValue=false)]
		public double? NewYorkAppraisalFee { get; set; }

		[DataMember(Name="newYorkCreditReportFee", EmitDefaultValue=false)]
		public double? NewYorkCreditReportFee { get; set; }

		[DataMember(Name="newYorkFees", EmitDefaultValue=false)]
		public List<LoanContractStateDisclosureNewYorkFees> NewYorkFees { get; set; }

		[DataMember(Name="newYorkPrimaryLenders", EmitDefaultValue=false)]
		public List<LoanContractStateDisclosureNewYorkPrimaryLenders> NewYorkPrimaryLenders { get; set; }

		[DataMember(Name="newYorkProcessingFee", EmitDefaultValue=false)]
		public double? NewYorkProcessingFee { get; set; }

		[DataMember(Name="notRefundableAmount", EmitDefaultValue=false)]
		public double? NotRefundableAmount { get; set; }

		[DataMember(Name="offerRetailPriceIndicator", EmitDefaultValue=false)]
		public bool? OfferRetailPriceIndicator { get; set; }

		[DataMember(Name="originalAcquisitionCost", EmitDefaultValue=false)]
		public double? OriginalAcquisitionCost { get; set; }

		[DataMember(Name="originationFeeChargedAmount", EmitDefaultValue=false)]
		public double? OriginationFeeChargedAmount { get; set; }

		[DataMember(Name="originationFeeChargedIndicator", EmitDefaultValue=false)]
		public bool? OriginationFeeChargedIndicator { get; set; }

		[DataMember(Name="originationFeeDecreasesRate", EmitDefaultValue=false)]
		public double? OriginationFeeDecreasesRate { get; set; }

		[DataMember(Name="originationFeeIncreasesRate", EmitDefaultValue=false)]
		public double? OriginationFeeIncreasesRate { get; set; }

		[DataMember(Name="originationFeeInterestRateImpactedStatus", EmitDefaultValue=false)]
		public string OriginationFeeInterestRateImpactedStatus { get; set; }

		[DataMember(Name="originationFeePaidBy", EmitDefaultValue=false)]
		public string OriginationFeePaidBy { get; set; }

		[DataMember(Name="paidByBorrower", EmitDefaultValue=false)]
		public double? PaidByBorrower { get; set; }

		[DataMember(Name="paidByLender", EmitDefaultValue=false)]
		public double? PaidByLender { get; set; }

		[DataMember(Name="paidByOther1", EmitDefaultValue=false)]
		public double? PaidByOther1 { get; set; }

		[DataMember(Name="paidByOther2", EmitDefaultValue=false)]
		public double? PaidByOther2 { get; set; }

		[DataMember(Name="paidByOtherDescription1", EmitDefaultValue=false)]
		public string PaidByOtherDescription1 { get; set; }

		[DataMember(Name="paidByOtherDescription2", EmitDefaultValue=false)]
		public string PaidByOtherDescription2 { get; set; }

		[DataMember(Name="previousMortgageAmountOne", EmitDefaultValue=false)]
		public double? PreviousMortgageAmountOne { get; set; }

		[DataMember(Name="previousMortgageAmountTwo", EmitDefaultValue=false)]
		public double? PreviousMortgageAmountTwo { get; set; }

		[DataMember(Name="printCertificationOfCosts", EmitDefaultValue=false)]
		public bool? PrintCertificationOfCosts { get; set; }

		[DataMember(Name="printInterestRateReductionRider", EmitDefaultValue=false)]
		public bool? PrintInterestRateReductionRider { get; set; }

		[DataMember(Name="printMDDeliveryIndicator", EmitDefaultValue=false)]
		public bool? PrintMDDeliveryIndicator { get; set; }

		[DataMember(Name="providedBy", EmitDefaultValue=false)]
		public string ProvidedBy { get; set; }

		[DataMember(Name="questionContact", EmitDefaultValue=false)]
		public string QuestionContact { get; set; }

		[DataMember(Name="questionContactPhone", EmitDefaultValue=false)]
		public string QuestionContactPhone { get; set; }

		[DataMember(Name="questionContactTollFree", EmitDefaultValue=false)]
		public string QuestionContactTollFree { get; set; }

		[DataMember(Name="rateLockHonoredIndicator", EmitDefaultValue=false)]
		public bool? RateLockHonoredIndicator { get; set; }

		[DataMember(Name="receivedBy", EmitDefaultValue=false)]
		public string ReceivedBy { get; set; }

		[DataMember(Name="refinancingFee", EmitDefaultValue=false)]
		public double? RefinancingFee { get; set; }

		[DataMember(Name="refundableBy", EmitDefaultValue=false)]
		public string RefundableBy { get; set; }

		[DataMember(Name="refundableIndicator", EmitDefaultValue=false)]
		public bool? RefundableIndicator { get; set; }

		[DataMember(Name="refundableType", EmitDefaultValue=false)]
		public string RefundableType { get; set; }

		[DataMember(Name="refundCondition1", EmitDefaultValue=false)]
		public string RefundCondition1 { get; set; }

		[DataMember(Name="refundCondition2", EmitDefaultValue=false)]
		public string RefundCondition2 { get; set; }

		[DataMember(Name="refundCondition3", EmitDefaultValue=false)]
		public string RefundCondition3 { get; set; }

		[DataMember(Name="refundCondition4", EmitDefaultValue=false)]
		public string RefundCondition4 { get; set; }

		[DataMember(Name="refundCondition5", EmitDefaultValue=false)]
		public string RefundCondition5 { get; set; }

		[DataMember(Name="refundCondition6", EmitDefaultValue=false)]
		public string RefundCondition6 { get; set; }

		[DataMember(Name="regulatorAddress", EmitDefaultValue=false)]
		public string RegulatorAddress { get; set; }

		[DataMember(Name="regulatorCity", EmitDefaultValue=false)]
		public string RegulatorCity { get; set; }

		[DataMember(Name="regulatorMailingAddress", EmitDefaultValue=false)]
		public string RegulatorMailingAddress { get; set; }

		[DataMember(Name="regulatorMailingCity", EmitDefaultValue=false)]
		public string RegulatorMailingCity { get; set; }

		[DataMember(Name="regulatorMailingState", EmitDefaultValue=false)]
		public string RegulatorMailingState { get; set; }

		[DataMember(Name="regulatorMailingZipCode", EmitDefaultValue=false)]
		public string RegulatorMailingZipCode { get; set; }

		[DataMember(Name="regulatorPhone", EmitDefaultValue=false)]
		public string RegulatorPhone { get; set; }

		[DataMember(Name="regulatorState", EmitDefaultValue=false)]
		public string RegulatorState { get; set; }

		[DataMember(Name="regulatorTollFreePhone", EmitDefaultValue=false)]
		public string RegulatorTollFreePhone { get; set; }

		[DataMember(Name="regulatorWebAddress", EmitDefaultValue=false)]
		public string RegulatorWebAddress { get; set; }

		[DataMember(Name="regulatorZipCode", EmitDefaultValue=false)]
		public string RegulatorZipCode { get; set; }

		[DataMember(Name="scheduleOfChargesEstimatedFinalIndicator", EmitDefaultValue=false)]
		public string ScheduleOfChargesEstimatedFinalIndicator { get; set; }

		[DataMember(Name="scRegulatoryAgencyType", EmitDefaultValue=false)]
		public string ScRegulatoryAgencyType { get; set; }

		[DataMember(Name="selectDivisionFeesIndicator", EmitDefaultValue=false)]
		public bool? SelectDivisionFeesIndicator { get; set; }

		[DataMember(Name="selectPrimaryLenderIndicator", EmitDefaultValue=false)]
		public bool? SelectPrimaryLenderIndicator { get; set; }

		[DataMember(Name="selectPrivateLenderIndicator", EmitDefaultValue=false)]
		public bool? SelectPrivateLenderIndicator { get; set; }

		[DataMember(Name="servicingFeeChargedAmount", EmitDefaultValue=false)]
		public double? ServicingFeeChargedAmount { get; set; }

		[DataMember(Name="servicingFeeChargedIndicator", EmitDefaultValue=false)]
		public bool? ServicingFeeChargedIndicator { get; set; }

		[DataMember(Name="servicingFeePaidBy", EmitDefaultValue=false)]
		public string ServicingFeePaidBy { get; set; }

		[DataMember(Name="servicingFeePaidFrequence", EmitDefaultValue=false)]
		public string ServicingFeePaidFrequence { get; set; }

		[DataMember(Name="signedByBorrowerIndicator", EmitDefaultValue=false)]
		public bool? SignedByBorrowerIndicator { get; set; }

		[DataMember(Name="specificARMIndicator", EmitDefaultValue=false)]
		public bool? SpecificARMIndicator { get; set; }

		[DataMember(Name="submitToLenderIndicator", EmitDefaultValue=false)]
		public bool? SubmitToLenderIndicator { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationAssessments", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationAssessments { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationOther", EmitDefaultValue=false)]
		public string TaxExemptAcquisitionCostCertificationOther { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationOtherAmount", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationOtherAmount { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationOwnersTitleInsurance", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationRealEstateCommission", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationRealEstateCommission { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationRepairsImprovements", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationRepairsImprovements { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationSurvey", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationSurvey { get; set; }

		[DataMember(Name="taxExemptAcquisitionCostCertificationTotalAdjustments", EmitDefaultValue=false)]
		public double? TaxExemptAcquisitionCostCertificationTotalAdjustments { get; set; }

		[DataMember(Name="termsChange", EmitDefaultValue=false)]
		public string TermsChange { get; set; }

		[DataMember(Name="texasApplicationFee", EmitDefaultValue=false)]
		public double? TexasApplicationFee { get; set; }

		[DataMember(Name="texasAppraisalFee", EmitDefaultValue=false)]
		public double? TexasAppraisalFee { get; set; }

		[DataMember(Name="texasCreditReportFee", EmitDefaultValue=false)]
		public double? TexasCreditReportFee { get; set; }

		[DataMember(Name="texasOtherFee1", EmitDefaultValue=false)]
		public double? TexasOtherFee1 { get; set; }

		[DataMember(Name="texasOtherFee2", EmitDefaultValue=false)]
		public double? TexasOtherFee2 { get; set; }

		[DataMember(Name="texasOtherFeeContact1", EmitDefaultValue=false)]
		public string TexasOtherFeeContact1 { get; set; }

		[DataMember(Name="texasOtherFeeContact2", EmitDefaultValue=false)]
		public string TexasOtherFeeContact2 { get; set; }

		[DataMember(Name="texasProcessingFee", EmitDefaultValue=false)]
		public double? TexasProcessingFee { get; set; }

		[DataMember(Name="thirdPartyFee", EmitDefaultValue=false)]
		public double? ThirdPartyFee { get; set; }

		[DataMember(Name="totalFee", EmitDefaultValue=false)]
		public double? TotalFee { get; set; }

		[DataMember(Name="transferFeeChargedAmount", EmitDefaultValue=false)]
		public double? TransferFeeChargedAmount { get; set; }

		[DataMember(Name="transferFeeChargedIndicator", EmitDefaultValue=false)]
		public bool? TransferFeeChargedIndicator { get; set; }

		[DataMember(Name="transferFeePaidBy", EmitDefaultValue=false)]
		public string TransferFeePaidBy { get; set; }

		[DataMember(Name="txVeteransLandBoardIndicator", EmitDefaultValue=false)]
		public bool? TxVeteransLandBoardIndicator { get; set; }

		[DataMember(Name="typeOfProperty", EmitDefaultValue=false)]
		public string TypeOfProperty { get; set; }

		[DataMember(Name="underwritingContact", EmitDefaultValue=false)]
		public string UnderwritingContact { get; set; }

		[DataMember(Name="underwritingFee", EmitDefaultValue=false)]
		public double? UnderwritingFee { get; set; }

		[DataMember(Name="ySPChargedAmount", EmitDefaultValue=false)]
		public double? YSPChargedAmount { get; set; }

		[DataMember(Name="ySPChargedIndicator", EmitDefaultValue=false)]
		public bool? YSPChargedIndicator { get; set; }

		[DataMember(Name="ySPDecreasesRate", EmitDefaultValue=false)]
		public double? YSPDecreasesRate { get; set; }

		[DataMember(Name="ySPIncreasesRate", EmitDefaultValue=false)]
		public double? YSPIncreasesRate { get; set; }

		[DataMember(Name="ySPInterestRateImpactedStatus", EmitDefaultValue=false)]
		public string YSPInterestRateImpactedStatus { get; set; }

		[DataMember(Name="ySPPaidBy", EmitDefaultValue=false)]
		public string YSPPaidBy { get; set; }

	}
}