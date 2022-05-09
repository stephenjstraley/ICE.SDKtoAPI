using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class StateDisclosureContract
    {
        [DataMember(Name = "acceptedByBorrowerIndicator")]
        public bool? AcceptedByBorrowerIndicator { get; set; }

        [DataMember(Name = "acceptedDate")]
        public string AcceptedDate { get; set; }

        [DataMember(Name = "actingOtherDescription1")]
        public string ActingOtherDescription1 { get; set; }

        [DataMember(Name = "actingOtherDescription2")]
        public string ActingOtherDescription2 { get; set; }

        [DataMember(Name = "actingOthersIndicator")]
        public bool? ActingOthersIndicator { get; set; }

        [DataMember(Name = "advFeeAgmtInEfctNumDay")]
        public int? AdvFeeAgmtInEfctNumDay { get; set; }

        [DataMember(Name = "advisoryCondition1")]
        public string AdvisoryCondition1 { get; set; }

        [DataMember(Name = "advisoryCondition2")]
        public string AdvisoryCondition2 { get; set; }

        [DataMember(Name = "advisoryCondition3")]
        public string AdvisoryCondition3 { get; set; }

        [DataMember(Name = "advisoryCondition4")]
        public string AdvisoryCondition4 { get; set; }

        [DataMember(Name = "amendedAcquisitionCost")]
        public decimal? AmendedAcquisitionCost { get; set; }

        [DataMember(Name = "applicationDate")]
        public string ApplicationDate { get; set; }

        [DataMember(Name = "appraisalContact")]
        public string AppraisalContact { get; set; }

        [DataMember(Name = "appraisalDeposit")]
        public decimal? AppraisalDeposit { get; set; }

        [DataMember(Name = "areas")]
        public string Areas { get; set; }

        [DataMember(Name = "asAttorneyIndicator")]
        public bool? AsAttorneyIndicator { get; set; }

        [DataMember(Name = "asRealBrokerIndicator")]
        public bool? AsRealBrokerIndicator { get; set; }

        [DataMember(Name = "attorneyForTheBuyerIndicator")]
        public bool? AttorneyForTheBuyerIndicator { get; set; }

        [DataMember(Name = "attorneyForTheLenderIndicator")]
        public bool? AttorneyForTheLenderIndicator { get; set; }

        [DataMember(Name = "attorneyForTheSellerIndicator")]
        public bool? AttorneyForTheSellerIndicator { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc1BlankFldDesc1")]
        public string AzCmplBlankSpcsDoc1BlankFldDesc1 { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc1BlankFldDesc2")]
        public string AzCmplBlankSpcsDoc1BlankFldDesc2 { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc1BlankFldDesc3")]
        public string AzCmplBlankSpcsDoc1BlankFldDesc3 { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc1Nm")]
        public string AzCmplBlankSpcsDoc1Nm { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc2Nm")]
        public string AzCmplBlankSpcsDoc2Nm { get; set; }

        [DataMember(Name = "azCmplBlankSpcsDoc3Nm")]
        public string AzCmplBlankSpcsDoc3Nm { get; set; }

        [DataMember(Name = "basedOnOthersDescription")]
        public string BasedOnOthersDescription { get; set; }

        [DataMember(Name = "basedOnOthersIndicator")]
        public bool? BasedOnOthersIndicator { get; set; }

        [DataMember(Name = "basedOnWholesaleOptionsIndicator")]
        public bool? BasedOnWholesaleOptionsIndicator { get; set; }

        [DataMember(Name = "borrowerElectsEstablishEscrowAmount")]
        public decimal? BorrowerElectsEstablishEscrowAmount { get; set; }

        [DataMember(Name = "borrowerElectsEstablishEscrowIndicator")]
        public bool? BorrowerElectsEstablishEscrowIndicator { get; set; }

        [DataMember(Name = "brokerageFeeAddition1")]
        public decimal? BrokerageFeeAddition1 { get; set; }

        [DataMember(Name = "brokerageFeeAddition2")]
        public decimal? BrokerageFeeAddition2 { get; set; }

        [DataMember(Name = "brokerageFeeAddition3")]
        public decimal? BrokerageFeeAddition3 { get; set; }

        [DataMember(Name = "brokerageFeeAmount1")]
        public decimal? BrokerageFeeAmount1 { get; set; }

        [DataMember(Name = "brokerageFeeAmount2")]
        public decimal? BrokerageFeeAmount2 { get; set; }

        [DataMember(Name = "brokerageFeeAmount3")]
        public decimal? BrokerageFeeAmount3 { get; set; }

        [DataMember(Name = "brokerageFeeDays")]
        public int? BrokerageFeeDays { get; set; }

        [DataMember(Name = "brokerageFeePercent1")]
        public decimal? BrokerageFeePercent1 { get; set; }

        [DataMember(Name = "brokerageFeePercent2")]
        public decimal? BrokerageFeePercent2 { get; set; }

        [DataMember(Name = "brokerageFeePercent3")]
        public decimal? BrokerageFeePercent3 { get; set; }

        [DataMember(Name = "brokerAuthorizedSigningRepName")]
        public string BrokerAuthorizedSigningRepName { get; set; }

        [DataMember(Name = "brokerAuthorizedSigningRepTitle")]
        public string BrokerAuthorizedSigningRepTitle { get; set; }

        [DataMember(Name = "brokerForTheSeller")]
        public string BrokerForTheSeller { get; set; }

        [DataMember(Name = "brokerLicense")]
        public string BrokerLicense { get; set; }

        [DataMember(Name = "brokerName")]
        public string BrokerName { get; set; }

        [DataMember(Name = "brokerPayAddition")]
        public decimal? BrokerPayAddition { get; set; }

        [DataMember(Name = "brokerPayAmount")]
        public decimal? BrokerPayAmount { get; set; }

        [DataMember(Name = "brokerPayIndicator")]
        public bool? BrokerPayIndicator { get; set; }

        [DataMember(Name = "brokerPayPercent")]
        public decimal? BrokerPayPercent { get; set; }

        [DataMember(Name = "charmBookletIndicator")]
        public bool? CharmBookletIndicator { get; set; }

        [DataMember(Name = "checkPayableTo")]
        public string CheckPayableTo { get; set; }

        [DataMember(Name = "commitmentAmount")]
        public decimal? CommitmentAmount { get; set; }

        [DataMember(Name = "commitmentCondition1")]
        public string CommitmentCondition1 { get; set; }

        [DataMember(Name = "commitmentCondition2")]
        public string CommitmentCondition2 { get; set; }

        [DataMember(Name = "commitmentFee")]
        public decimal? CommitmentFee { get; set; }

        [DataMember(Name = "commitmentPercent")]
        public decimal? CommitmentPercent { get; set; }

        [DataMember(Name = "compensationAddition")]
        public decimal? CompensationAddition { get; set; }

        [DataMember(Name = "compensationPercent")]
        public decimal? CompensationPercent { get; set; }

        [DataMember(Name = "creditDeposit")]
        public decimal? CreditDeposit { get; set; }

        [DataMember(Name = "creditIsUsedForReason")]
        public string CreditIsUsedForReason { get; set; }

        [DataMember(Name = "creditReportContact")]
        public string CreditReportContact { get; set; }

        [DataMember(Name = "daysBeforeClosing")]
        public int? DaysBeforeClosing { get; set; }

        [DataMember(Name = "depositReceipt")]
        public decimal? DepositReceipt { get; set; }

        [DataMember(Name = "depositRefundableIndicator")]
        public bool? DepositRefundableIndicator { get; set; }

        [DataMember(Name = "directContact")]
        public string DirectContact { get; set; }

        [DataMember(Name = "directPayAmount")]
        public decimal? DirectPayAmount { get; set; }

        [DataMember(Name = "directPayClosing")]
        public decimal? DirectPayClosing { get; set; }

        [DataMember(Name = "directPayCommitment")]
        public decimal? DirectPayCommitment { get; set; }

        [DataMember(Name = "directPayIndicator")]
        public bool? DirectPayIndicator { get; set; }

        [DataMember(Name = "directPayPercent")]
        public decimal? DirectPayPercent { get; set; }

        [DataMember(Name = "disclosureDeliveredBy")]
        public string DisclosureDeliveredBy { get; set; }

        [DataMember(Name = "disclosureDeliveredByOtherMethod")]
        public string DisclosureDeliveredByOtherMethod { get; set; }

        [DataMember(Name = "disclosureDeliveredDate")]
        public string DisclosureDeliveredDate { get; set; }

        [DataMember(Name = "estimatedChargeShownOnGfeIndicator")]
        public bool? EstimatedChargeShownOnGfeIndicator { get; set; }

        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }

        [DataMember(Name = "federallySubsidizedAmount")]
        public decimal? FederallySubsidizedAmount { get; set; }

        [DataMember(Name = "federallySubsidizedAmountPercentage")]
        public decimal? FederallySubsidizedAmountPercentage { get; set; }

        [DataMember(Name = "feeReceived1")]
        public decimal? FeeReceived1 { get; set; }

        [DataMember(Name = "feeReceived2")]
        public decimal? FeeReceived2 { get; set; }

        [DataMember(Name = "feeReceivedByLender")]
        public string FeeReceivedByLender { get; set; }

        [DataMember(Name = "feesReceiving")]
        public decimal? FeesReceiving { get; set; }

        [DataMember(Name = "floridaApplicationFee")]
        public decimal? FloridaApplicationFee { get; set; }

        [DataMember(Name = "floridaOtherFee1")]
        public decimal? FloridaOtherFee1 { get; set; }

        [DataMember(Name = "floridaOtherFee2")]
        public decimal? FloridaOtherFee2 { get; set; }

        [DataMember(Name = "floridaOtherFeeTo1")]
        public string FloridaOtherFeeTo1 { get; set; }

        [DataMember(Name = "floridaOtherFeeTo2")]
        public string FloridaOtherFeeTo2 { get; set; }

        [DataMember(Name = "floridaOtherFeeTo3")]
        public string FloridaOtherFeeTo3 { get; set; }

        [DataMember(Name = "floridaOtherFeeTo4")]
        public string FloridaOtherFeeTo4 { get; set; }

        [DataMember(Name = "furtherFeesEarnedByMortgageBroker")]
        public string FurtherFeesEarnedByMortgageBroker { get; set; }

        [DataMember(Name = "gfeFeeReceived1")]
        public decimal? GfeFeeReceived1 { get; set; }

        [DataMember(Name = "gfeFeeReceived2")]
        public decimal? GfeFeeReceived2 { get; set; }

        [DataMember(Name = "hudBookletIndicator")]
        public bool? HudBookletIndicator { get; set; }

        [DataMember(Name = "independentContractorIndicator")]
        public bool? IndependentContractorIndicator { get; set; }

        [DataMember(Name = "indexUsed")]
        public string IndexUsed { get; set; }

        [DataMember(Name = "informationAboutTheIndexCanBeFound")]
        public string InformationAboutTheIndexCanBeFound { get; set; }

        [DataMember(Name = "isEstimateIndicator")]
        public bool? IsEstimateIndicator { get; set; }

        [DataMember(Name = "ksUcccElectionIndicator")]
        public bool? KsUcccElectionIndicator { get; set; }

        [DataMember(Name = "kyHomeSolicitationLoanIndicator")]
        public bool? KyHomeSolicitationLoanIndicator { get; set; }

        [DataMember(Name = "leaseAgreementDate")]
        public string LeaseAgreementDate { get; set; }

        [DataMember(Name = "lenderDate")]
        public string LenderDate { get; set; }

        [DataMember(Name = "lenderName")]
        public string LenderName { get; set; }

        [DataMember(Name = "lenderPaid")]
        public decimal? LenderPaid { get; set; }

        [DataMember(Name = "lenderPayAmount")]
        public decimal? LenderPayAmount { get; set; }

        [DataMember(Name = "lenderPayIndicator")]
        public bool? LenderPayIndicator { get; set; }

        [DataMember(Name = "lenderPayMaxPoint")]
        public decimal? LenderPayMaxPoint { get; set; }

        [DataMember(Name = "lenderPayPercent")]
        public decimal? LenderPayPercent { get; set; }

        [DataMember(Name = "lenderPayPoint")]
        public decimal? LenderPayPoint { get; set; }

        [DataMember(Name = "lenderPayUnknownIndicator")]
        public bool? LenderPayUnknownIndicator { get; set; }

        [DataMember(Name = "lenderStatus")]
        public string LenderStatus { get; set; }

        [DataMember(Name = "lessorName")]
        public string LessorName { get; set; }

        [DataMember(Name = "loanTermsFixedThroughDateofLoanClosingIndicator")]
        public bool? LoanTermsFixedThroughDateofLoanClosingIndicator { get; set; }

        [DataMember(Name = "lockInFee")]
        public decimal? LockInFee { get; set; }

        [DataMember(Name = "methodDescription")]
        public string MethodDescription { get; set; }

        [DataMember(Name = "methodDetermine")]
        public string MethodDetermine { get; set; }

        [DataMember(Name = "mortgageAgreementIndicator")]
        public bool? MortgageAgreementIndicator { get; set; }

        [DataMember(Name = "mtgBrokerLicense")]
        public string MtgBrokerLicense { get; set; }

        [DataMember(Name = "nameOfLicensee")]
        public string NameOfLicensee { get; set; }

        [DataMember(Name = "newMoneyAmount")]
        public decimal? NewMoneyAmount { get; set; }

        [DataMember(Name = "newYorkApplicationFee")]
        public decimal? NewYorkApplicationFee { get; set; }

        [DataMember(Name = "newYorkAppraisalFee")]
        public decimal? NewYorkAppraisalFee { get; set; }

        [DataMember(Name = "newYorkCreditReportFee")]
        public decimal? NewYorkCreditReportFee { get; set; }

        [DataMember(Name = "newYorkFees")]
        public List<NewYorkFeeContract> NewYorkFees { get; set; }

        [DataMember(Name = "newYorkPrimaryLenders")]
        public List<NewYorkPrimaryLenderContract> NewYorkPrimaryLenders { get; set; }

        [DataMember(Name = "newYorkProcessingFee")]
        public decimal? NewYorkProcessingFee { get; set; }

        [DataMember(Name = "notRefundableAmount")]
        public decimal? NotRefundableAmount { get; set; }

        [DataMember(Name = "offerRetailPriceIndicator")]
        public bool? OfferRetailPriceIndicator { get; set; }

        [DataMember(Name = "originalAcquisitionCost")]
        public decimal? OriginalAcquisitionCost { get; set; }

        [DataMember(Name = "originationFeeChargedAmount")]
        public decimal? OriginationFeeChargedAmount { get; set; }

        [DataMember(Name = "originationFeeChargedIndicator")]
        public bool? OriginationFeeChargedIndicator { get; set; }

        [DataMember(Name = "originationFeeDecreasesRate")]
        public decimal? OriginationFeeDecreasesRate { get; set; }

        [DataMember(Name = "originationFeeIncreasesRate")]
        public decimal? OriginationFeeIncreasesRate { get; set; }

        [DataMember(Name = "originationFeeInterestRateImpactedStatus")]
        public string OriginationFeeInterestRateImpactedStatus { get; set; }

        [DataMember(Name = "originationFeePaidBy")]
        public string OriginationFeePaidBy { get; set; }

        [DataMember(Name = "paidByBorrower")]
        public decimal? PaidByBorrower { get; set; }

        [DataMember(Name = "paidByLender")]
        public decimal? PaidByLender { get; set; }

        [DataMember(Name = "paidByOther1")]
        public decimal? PaidByOther1 { get; set; }

        [DataMember(Name = "paidByOther2")]
        public decimal? PaidByOther2 { get; set; }

        [DataMember(Name = "paidByOtherDescription1")]
        public string PaidByOtherDescription1 { get; set; }

        [DataMember(Name = "paidByOtherDescription2")]
        public string PaidByOtherDescription2 { get; set; }

        [DataMember(Name = "previousMortgageAmountOne")]
        public decimal? PreviousMortgageAmountOne { get; set; }

        [DataMember(Name = "previousMortgageAmountTwo")]
        public decimal? PreviousMortgageAmountTwo { get; set; }

        [DataMember(Name = "printCertificationOfCosts")]
        public bool? PrintCertificationOfCosts { get; set; }

        [DataMember(Name = "printInterestRateReductionRider")]
        public bool? PrintInterestRateReductionRider { get; set; }

        [DataMember(Name = "printMdDeliveryIndicator")]
        public bool? PrintMdDeliveryIndicator { get; set; }

        [DataMember(Name = "providedBy")]
        public string ProvidedBy { get; set; }

        [DataMember(Name = "questionContact")]
        public string QuestionContact { get; set; }

        [DataMember(Name = "questionContactPhone")]
        public string QuestionContactPhone { get; set; }

        [DataMember(Name = "questionContactTollFree")]
        public string QuestionContactTollFree { get; set; }

        [DataMember(Name = "rateLockHonoredIndicator")]
        public bool? RateLockHonoredIndicator { get; set; }

        [DataMember(Name = "receivedBy")]
        public string ReceivedBy { get; set; }

        [DataMember(Name = "refinancingFee")]
        public decimal? RefinancingFee { get; set; }

        [DataMember(Name = "refundableBy")]
        public string RefundableBy { get; set; }

        [DataMember(Name = "refundableIndicator")]
        public bool? RefundableIndicator { get; set; }

        [DataMember(Name = "refundableType")]
        public string RefundableType { get; set; }

        [DataMember(Name = "refundCondition1")]
        public string RefundCondition1 { get; set; }

        [DataMember(Name = "refundCondition2")]
        public string RefundCondition2 { get; set; }

        [DataMember(Name = "refundCondition3")]
        public string RefundCondition3 { get; set; }

        [DataMember(Name = "refundCondition4")]
        public string RefundCondition4 { get; set; }

        [DataMember(Name = "refundCondition5")]
        public string RefundCondition5 { get; set; }

        [DataMember(Name = "refundCondition6")]
        public string RefundCondition6 { get; set; }

        [DataMember(Name = "scheduleOfChargesEstimatedFinalIndicator")]
        public string ScheduleOfChargesEstimatedFinalIndicator { get; set; }

        [DataMember(Name = "scRegulatoryAgencyType")]
        public string ScRegulatoryAgencyType { get; set; }

        [DataMember(Name = "regulatorAddress")]
        public string RegulatorAddress { get; set; }

        [DataMember(Name = "regulatorWebAddress")]
        public string RegulatorWebAddress { get; set; }

        [DataMember(Name = "regulatorCity")]
        public string RegulatorCity { get; set; }

        [DataMember(Name = "regulatorState")]
        public string RegulatorState { get; set; }

        [DataMember(Name = "regulatorZipCode")]
        public string RegulatorZipCode { get; set; }

        [DataMember(Name = "regulatorPhone")]
        public string RegulatorPhone { get; set; }

        [DataMember(Name = "regulatorTollFreePhone")]
        public string RegulatorTollFreePhone { get; set; }

        [DataMember(Name = "regulatorMailingAddress")]
        public string RegulatorMailingAddress { get; set; }

        [DataMember(Name = "regulatorMailingCity")]
        public string RegulatorMailingCity { get; set; }

        [DataMember(Name = "regulatorMailingState")]
        public string RegulatorMailingState { get; set; }

        [DataMember(Name = "regulatorMailingZipCode")]
        public string RegulatorMailingZipCode { get; set; }

        [DataMember(Name = "selectDivisionFeesIndicator")]
        public bool? SelectDivisionFeesIndicator { get; set; }

        [DataMember(Name = "selectPrimaryLenderIndicator")]
        public bool? SelectPrimaryLenderIndicator { get; set; }

        [DataMember(Name = "selectPrivateLenderIndicator")]
        public bool? SelectPrivateLenderIndicator { get; set; }

        [DataMember(Name = "servicingFeeChargedAmount")]
        public decimal? ServicingFeeChargedAmount { get; set; }

        [DataMember(Name = "servicingFeeChargedIndicator")]
        public bool? ServicingFeeChargedIndicator { get; set; }

        [DataMember(Name = "servicingFeePaidBy")]
        public string ServicingFeePaidBy { get; set; }

        [DataMember(Name = "servicingFeePaidFrequency")]
        public string ServicingFeePaidFrequency { get; set; }

        [DataMember(Name = "signedByBorrowerIndicator")]
        public bool? SignedByBorrowerIndicator { get; set; }

        [DataMember(Name = "specificArmIndicator")]
        public bool? SpecificArmIndicator { get; set; }

        [DataMember(Name = "submitToLenderIndicator")]
        public bool? SubmitToLenderIndicator { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationAssessments")]
        public decimal? TaxExemptAcquisitionCostCertificationAssessments { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationOther")]
        public string TaxExemptAcquisitionCostCertificationOther { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationOtherAmount")]
        public decimal? TaxExemptAcquisitionCostCertificationOtherAmount { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationOwnersTitleInsurance")]
        public decimal? TaxExemptAcquisitionCostCertificationOwnersTitleInsurance { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationRealEstateCommission")]
        public decimal? TaxExemptAcquisitionCostCertificationRealEstateCommission { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationRepairsImprovements")]
        public decimal? TaxExemptAcquisitionCostCertificationRepairsImprovements { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationSurvey")]
        public decimal? TaxExemptAcquisitionCostCertificationSurvey { get; set; }

        [DataMember(Name = "taxExemptAcquisitionCostCertificationTotalAdjustments")]
        public decimal? TaxExemptAcquisitionCostCertificationTotalAdjustments { get; set; }

        [DataMember(Name = "termsChange")]
        public string TermsChange { get; set; }

        [DataMember(Name = "texasApplicationFee")]
        public decimal? TexasApplicationFee { get; set; }

        [DataMember(Name = "texasAppraisalFee")]
        public decimal? TexasAppraisalFee { get; set; }

        [DataMember(Name = "texasCreditReportFee")]
        public decimal? TexasCreditReportFee { get; set; }

        [DataMember(Name = "texasOtherFee1")]
        public decimal? TexasOtherFee1 { get; set; }

        [DataMember(Name = "texasOtherFee2")]
        public decimal? TexasOtherFee2 { get; set; }

        [DataMember(Name = "texasOtherFeeContact1")]
        public string TexasOtherFeeContact1 { get; set; }

        [DataMember(Name = "texasOtherFeeContact2")]
        public string TexasOtherFeeContact2 { get; set; }

        [DataMember(Name = "texasProcessingFee")]
        public decimal? TexasProcessingFee { get; set; }

        [DataMember(Name = "thirdPartyFee")]
        public decimal? ThirdPartyFee { get; set; }

        [DataMember(Name = "totalFee")]
        public decimal? TotalFee { get; set; }

        [DataMember(Name = "transferFeeChargedAmount")]
        public decimal? TransferFeeChargedAmount { get; set; }

        [DataMember(Name = "transferFeeChargedIndicator")]
        public bool? TransferFeeChargedIndicator { get; set; }

        [DataMember(Name = "transferFeePaidBy")]
        public string TransferFeePaidBy { get; set; }

        [DataMember(Name = "txVeteransLandBoardIndicator")]
        public bool? TxVeteransLandBoardIndicator { get; set; }

        [DataMember(Name = "typeOfProperty")]
        public string TypeOfProperty { get; set; }

        [DataMember(Name = "underwritingContact")]
        public string UnderwritingContact { get; set; }

        [DataMember(Name = "underwritingFee")]
        public decimal? UnderwritingFee { get; set; }

        [DataMember(Name = "yspChargedAmount")]
        public decimal? YspChargedAmount { get; set; }

        [DataMember(Name = "yspChargedIndicator")]
        public bool? YspChargedIndicator { get; set; }

        [DataMember(Name = "yspDecreasesRate")]
        public decimal? YspDecreasesRate { get; set; }

        [DataMember(Name = "yspIncreasesRate")]
        public decimal? YspIncreasesRate { get; set; }

        [DataMember(Name = "yspInterestRateImpactedStatus")]
        public string YspInterestRateImpactedStatus { get; set; }

        [DataMember(Name = "yspPaidBy")]
        public string YspPaidBy { get; set; }

        [DataMember(Name = "inLicensedNo")]
        public string InLicensedNo { get; set; }

        [DataMember(Name = "inLicensedType")]
        public string InLicensedType { get; set; }

    }
}
