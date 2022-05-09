using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class Section32Contract
    {
        [DataMember(Name = "appraisalFeeToBeFinancedIndicator")]
        public bool? AppraisalFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "appraisalPortionOfFeeIndicator")]
        public bool? AppraisalPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "aprExceedsTsyForFirstMortgage")]
        public decimal? AprExceedsTsyForFirstMortgage { get; set; }

        [DataMember(Name = "aprExceedsTsyForSubordinateMortgage")]
        public decimal? AprExceedsTsyForSubordinateMortgage { get; set; }

        [DataMember(Name = "assumptionFeeToBeFinancedIndicator")]
        public bool? AssumptionFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "assumptionPortionOfFeeIndicator")]
        public bool? AssumptionPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "attorneyFeeToBeFinancedIndicator")]
        public bool? AttorneyFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "attorneyPortionOfFeeIndicator")]
        public bool? AttorneyPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "cityCountyTaxStampsFeeToBeFinancedIndicator")]
        public bool? CityCountyTaxStampsFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "cityCountyTaxStampsPortionOfFeeIndicator")]
        public bool? CityCountyTaxStampsPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "closingFeeToBeFinancedIndicator")]
        public bool? ClosingFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "closingPortionOfFeeIndicator")]
        public bool? ClosingPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "creditReportFeeToBeFinancedIndicator")]
        public bool? CreditReportFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "creditReportPortionOfFeeIndicator")]
        public bool? CreditReportPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "docPrepFeeToBeFinancedIndicator")]
        public bool? DocPrepFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "docPrepPortionOfFeeIndicator")]
        public bool? DocPrepPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "hoepaFee")]
        public decimal? HoepaFee { get; set; }

        [DataMember(Name = "jurisdictions")]
        public string Jurisdictions { get; set; }

        [DataMember(Name = "lendersInspectionFeeToBeFinancedIndicator")]
        public bool? LendersInspectionFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "lendersInspectionPortionOfFeeIndicator")]
        public bool? LendersInspectionPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "loanDiscountFeeToBeFinancedIndicator")]
        public bool? LoanDiscountFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "loanDiscountPortionOfFeeIndicator")]
        public bool? LoanDiscountPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "loanOriginationFeeToBeFinancedIndicator")]
        public bool? LoanOriginationFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "loanOriginationPortionOfFeeIndicator")]
        public bool? LoanOriginationPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "loanQualifyAsHighCostMortgage")]
        public string LoanQualifyAsHighCostMortgage { get; set; }

        [DataMember(Name = "maximumPercentageOfLoan")]
        public decimal? MaximumPercentageOfLoan { get; set; }

        [DataMember(Name = "maximumPointsAndFees")]
        public decimal? MaximumPointsAndFees { get; set; }

        [DataMember(Name = "mortgageBrokerFeeToBeFinancedIndicator")]
        public bool? MortgageBrokerFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "mortgageBrokerPortionOfFeeIndicator")]
        public bool? MortgageBrokerPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "mortgageInspectionFeeToBeFinancedIndicator")]
        public bool? MortgageInspectionFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "mortgageInspectionPortionOfFeeIndicator")]
        public bool? MortgageInspectionPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "mortgageInsuranceFeeToBeFinancedIndicator")]
        public bool? MortgageInsuranceFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "mortgageInsurancePortionOfFeeIndicator")]
        public bool? MortgageInsurancePortionOfFeeIndicator { get; set; }

        [DataMember(Name = "mortgageInsurancePremiumFeeToBeFinancedIndicator")]
        public bool? MortgageInsurancePremiumFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "mortgageInsurancePremiumPortionOfFeeIndicator")]
        public bool? MortgageInsurancePremiumPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "notaryFeeToBeFinancedIndicator")]
        public bool? NotaryFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "notaryPortionOfFeeIndicator")]
        public bool? NotaryPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "otherHighCostIndicator")]
        public bool? OtherHighCostIndicator { get; set; }

        [DataMember(Name = "pestInspectionFeeToBeFinancedIndicator")]
        public bool? PestInspectionFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "pestInspectionPortionOfFeeIndicator")]
        public bool? PestInspectionPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "processingFeeToBeFinancedIndicator")]
        public bool? ProcessingFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "processingPortionOfFeeIndicator")]
        public bool? ProcessingPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "recordingFeeToBeFinancedIndicator")]
        public bool? RecordingFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "recordingPortionOfFeeIndicator")]
        public bool? RecordingPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "resultOfPointAndFees")]
        public string ResultOfPointAndFees { get; set; }

        [DataMember(Name = "resultOfSecurityYieldTest")]
        public string ResultOfSecurityYieldTest { get; set; }

        [DataMember(Name = "section32Indicator")]
        public bool? Section32Indicator { get; set; }

        [DataMember(Name = "section35AveragePrimeRate")]
        public decimal? Section35AveragePrimeRate { get; set; }

        [DataMember(Name = "section35ResultOfSecurityYieldTest")]
        public string Section35ResultOfSecurityYieldTest { get; set; }

        [DataMember(Name = "stateTaxStampsFeeToBeFinancedIndicator")]
        public bool? StateTaxStampsFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "stateTaxStampsPortionOfFeeIndicator")]
        public bool? StateTaxStampsPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "surveyFeeToBeFinancedIndicator")]
        public bool? SurveyFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "surveyPortionOfFeeIndicator")]
        public bool? SurveyPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "taxServiceFeeToBeFinancedIndicator")]
        public bool? TaxServiceFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "taxServicePortionOfFeeIndicator")]
        public bool? TaxServicePortionOfFeeIndicator { get; set; }

        [DataMember(Name = "titleBinderFeeToBeFinancedIndicator")]
        public bool? TitleBinderFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "titleBinderPortionOfFeeIndicator")]
        public bool? TitleBinderPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "titleExaminationFeeToBeFinancedIndicator")]
        public bool? TitleExaminationFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "titleExaminationPortionOfFeeIndicator")]
        public bool? TitleExaminationPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "titleInsuranceFeeToBeFinancedIndicator")]
        public bool? TitleInsuranceFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "titleInsurancePortionOfFeeIndicator")]
        public bool? TitleInsurancePortionOfFeeIndicator { get; set; }

        [DataMember(Name = "titleSearchFeeToBeFinancedIndicator")]
        public bool? TitleSearchFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "titleSearchPortionOfFeeIndicator")]
        public bool? TitleSearchPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "totalPointsAndFees")]
        public decimal? TotalPointsAndFees { get; set; }

        [DataMember(Name = "treasurySecurityYield")]
        public decimal? TreasurySecurityYield { get; set; }

        [DataMember(Name = "underwritingFeeToBeFinancedIndicator")]
        public bool? UnderwritingFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "underwritingPortionOfFeeIndicator")]
        public bool? UnderwritingPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1109BorPaidAmount")]
        public decimal? UserDefined1109BorPaidAmount { get; set; }

        [DataMember(Name = "userDefined1109FeeToBeFinancedIndicator")]
        public bool? UserDefined1109FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1109PortionOfFeeIndicator")]
        public bool? UserDefined1109PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1110BorPaidAmount")]
        public decimal? UserDefined1110BorPaidAmount { get; set; }

        [DataMember(Name = "userDefined1110FeeToBeFinancedIndicator")]
        public bool? UserDefined1110FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1110PortionOfFeeIndicator")]
        public bool? UserDefined1110PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1111FeeToBeFinancedIndicator")]
        public bool? UserDefined1111FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1111PortionOfFeeIndicator")]
        public bool? UserDefined1111PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1112FeeToBeFinancedIndicator")]
        public bool? UserDefined1112FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1112PortionOfFeeIndicator")]
        public bool? UserDefined1112PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1113FeeToBeFinancedIndicator")]
        public bool? UserDefined1113FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1113PortionOfFeeIndicator")]
        public bool? UserDefined1113PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1114FeeToBeFinancedIndicator")]
        public bool? UserDefined1114FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1114PortionOfFeeIndicator")]
        public bool? UserDefined1114PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1204FeeToBeFinancedIndicator")]
        public bool? UserDefined1204FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1204PortionOfFeeIndicator")]
        public bool? UserDefined1204PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1205FeeToBeFinancedIndicator")]
        public bool? UserDefined1205FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1205PortionOfFeeIndicator")]
        public bool? UserDefined1205PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1206FeeToBeFinancedIndicator")]
        public bool? UserDefined1206FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1206PortionOfFeeIndicator")]
        public bool? UserDefined1206PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1303FeeToBeFinancedIndicator")]
        public bool? UserDefined1303FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1303PortionOfFeeIndicator")]
        public bool? UserDefined1303PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1304FeeToBeFinancedIndicator")]
        public bool? UserDefined1304FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1304PortionOfFeeIndicator")]
        public bool? UserDefined1304PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1305FeeToBeFinancedIndicator")]
        public bool? UserDefined1305FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1305PortionOfFeeIndicator")]
        public bool? UserDefined1305PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1306FeeToBeFinancedIndicator")]
        public bool? UserDefined1306FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1306PortionOfFeeIndicator")]
        public bool? UserDefined1306PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1307FeeToBeFinancedIndicator")]
        public bool? UserDefined1307FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1307PortionOfFeeIndicator")]
        public bool? UserDefined1307PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1308FeeToBeFinancedIndicator")]
        public bool? UserDefined1308FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1308PortionOfFeeIndicator")]
        public bool? UserDefined1308PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined1309FeeToBeFinancedIndicator")]
        public bool? UserDefined1309FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined1309PortionOfFeeIndicator")]
        public bool? UserDefined1309PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined813FeeToBeFinancedIndicator")]
        public bool? UserDefined813FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined813PortionOfFeeIndicator")]
        public bool? UserDefined813PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined814FeeToBeFinancedIndicator")]
        public bool? UserDefined814FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined814PortionOfFeeIndicator")]
        public bool? UserDefined814PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined815FeeToBeFinancedIndicator")]
        public bool? UserDefined815FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined815PortionOfFeeIndicator")]
        public bool? UserDefined815PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined816FeeToBeFinancedIndicator")]
        public bool? UserDefined816FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined816PortionOfFeeIndicator")]
        public bool? UserDefined816PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined817FeeToBeFinancedIndicator")]
        public bool? UserDefined817FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined817PortionOfFeeIndicator")]
        public bool? UserDefined817PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined818FeeToBeFinancedIndicator")]
        public bool? UserDefined818FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined818PortionOfFeeIndicator")]
        public bool? UserDefined818PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined819FeeToBeFinancedIndicator")]
        public bool? UserDefined819FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined819PortionOfFeeIndicator")]
        public bool? UserDefined819PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined820FeeToBeFinancedIndicator")]
        public bool? UserDefined820FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined820PortionOfFeeIndicator")]
        public bool? UserDefined820PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined821FeeToBeFinancedIndicator")]
        public bool? UserDefined821FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined821PortionOfFeeIndicator")]
        public bool? UserDefined821PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined822FeeToBeFinancedIndicator")]
        public bool? UserDefined822FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined822PortionOfFeeIndicator")]
        public bool? UserDefined822PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "userDefined823FeeToBeFinancedIndicator")]
        public bool? UserDefined823FeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "userDefined823PortionOfFeeIndicator")]
        public bool? UserDefined823PortionOfFeeIndicator { get; set; }

        [DataMember(Name = "wireTransferFeeToBeFinancedIndicator")]
        public bool? WireTransferFeeToBeFinancedIndicator { get; set; }

        [DataMember(Name = "wireTransferPortionOfFeeIndicator")]
        public bool? WireTransferPortionOfFeeIndicator { get; set; }

        [DataMember(Name = "rateSetIndex")]
        public decimal? RateSetIndex { get; set; }

        [DataMember(Name = "section35PriorAcquisitionSource")]
        public string Section35PriorAcquisitionSource { get; set; }

        [DataMember(Name = "section35PriorAcquisitionDate")]
        public string Section35PriorAcquisitionDate { get; set; }

        [DataMember(Name = "section35PriorAcquisitionPrice")]
        public decimal? Section35PriorAcquisitionPrice { get; set; }

        [DataMember(Name = "section35SalesContractDate")]
        public string Section35SalesContractDate { get; set; }

        [DataMember(Name = "section35IsSecondAppraisalRequired")]
        public string Section35IsSecondAppraisalRequired { get; set; }

        [DataMember(Name = "hoepaApr")]
        public decimal? HoepaApr { get; set; }

        [DataMember(Name = "prepayPenaltyPercentofAmtPrepaid")]
        public decimal? PrepayPenaltyPercentofAmtPrepaid { get; set; }

        [DataMember(Name = "exceed2PercentPrepayPenalty")]
        public string Exceed2PercentPrepayPenalty { get; set; }

        [DataMember(Name = "penaltyChargeMoreThan36Months")]
        public string PenaltyChargeMoreThan36Months { get; set; }

        [DataMember(Name = "sellerPaidFeesImpacts")]
        public bool? SellerPaidFeesImpacts { get; set; }

    }
}
