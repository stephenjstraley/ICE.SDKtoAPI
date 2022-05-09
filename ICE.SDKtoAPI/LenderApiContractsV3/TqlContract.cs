using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ICE.SDKtoAPI.LenderApiContractsV3
{
    [DataContract]
    public class TqlContract
    {
        [DataMember(Name = "currentInvestorPublishingStatus")]
        public string CurrentInvestorPublishingStatus { get; set; }

        [DataMember(Name = "gseTrackers")]
        public List<GseTrackerContract> GseTrackers { get; set; }

        [DataMember(Name = "lastCcvpCompletedDate")]
        public string LastCcvpCompletedDate { get; set; }

        [DataMember(Name = "lastCcvpConfidenceScore")]
        public string LastCcvpConfidenceScore { get; set; }

        [DataMember(Name = "lastCcvpEstimatedValue")]
        public string LastCcvpEstimatedValue { get; set; }

        [DataMember(Name = "lastCcvpForecastDeviationScore")]
        public string LastCcvpForecastDeviationScore { get; set; }

        [DataMember(Name = "lastCcvpReportHistoryProResult")]
        public string LastCcvpReportHistoryProResult { get; set; }

        [DataMember(Name = "lastCcvpReportId")]
        public string LastCcvpReportId { get; set; }

        [DataMember(Name = "lastCcvpReportOrdered")]
        public string LastCcvpReportOrdered { get; set; }

        [DataMember(Name = "lastCcvpReportPassResult")]
        public string LastCcvpReportPassResult { get; set; }

        [DataMember(Name = "lastCcvpResultsReportReturned")]
        public string LastCcvpResultsReportReturned { get; set; }

        [DataMember(Name = "lastComplianceCompletedDate")]
        public string LastComplianceCompletedDate { get; set; }

        [DataMember(Name = "lastComplianceNumberOfAlertMessages")]
        public int? LastComplianceNumberOfAlertMessages { get; set; }

        [DataMember(Name = "lastComplianceNumberOfErrorMessages")]
        public int? LastComplianceNumberOfErrorMessages { get; set; }

        [DataMember(Name = "lastComplianceNumberOfFailMessages")]
        public int? LastComplianceNumberOfFailMessages { get; set; }

        [DataMember(Name = "lastComplianceNumberOfPassMessages")]
        public int? LastComplianceNumberOfPassMessages { get; set; }

        [DataMember(Name = "lastComplianceNumberOfWarningMessages")]
        public int? LastComplianceNumberOfWarningMessages { get; set; }

        [DataMember(Name = "lastComplianceOrderType")]
        public string LastComplianceOrderType { get; set; }

        [DataMember(Name = "lastComplianceProductNameReportOrdered")]
        public string LastComplianceProductNameReportOrdered { get; set; }

        [DataMember(Name = "lastComplianceReportId")]
        public string LastComplianceReportId { get; set; }

        [DataMember(Name = "lastFraudOrderAlerts")]
        public int? LastFraudOrderAlerts { get; set; }

        [DataMember(Name = "lastFraudOrderCompletedDate")]
        public string LastFraudOrderCompletedDate { get; set; }

        [DataMember(Name = "lastFraudOrderProduct")]
        public string LastFraudOrderProduct { get; set; }

        [DataMember(Name = "lastFraudReportId")]
        public string LastFraudReportId { get; set; }

        [DataMember(Name = "lastInvestorPublishingInvestor")]
        public string LastInvestorPublishingInvestor { get; set; }

        [DataMember(Name = "lastInvestorPublishingStatusChangeDate")]
        public string LastInvestorPublishingStatusChangeDate { get; set; }

        [DataMember(Name = "lastInvestorPublishingUserWhoChangeStatus")]
        public string LastInvestorPublishingUserWhoChangeStatus { get; set; }

        [DataMember(Name = "lastUserIdWhoOrderedCcvp")]
        public string LastUserIdWhoOrderedCcvp { get; set; }

        [DataMember(Name = "lastUserIdWhoOrderedCompliance")]
        public string LastUserIdWhoOrderedCompliance { get; set; }

        [DataMember(Name = "lastUserIdWhoOrderedFraudOrder")]
        public string LastUserIdWhoOrderedFraudOrder { get; set; }

        [DataMember(Name = "tqlComplianceAlerts")]
        public List<TqlComplianceAlertContract> TqlComplianceAlerts { get; set; }

        [DataMember(Name = "tqlFraudAlerts")]
        public List<TqlFraudAlertContract> TqlFraudAlerts { get; set; }

        [DataMember(Name = "wellsFargo4506TBaselineReportRequired")]
        public string WellsFargo4506TBaselineReportRequired { get; set; }

        [DataMember(Name = "wellsFargoFraudBaselineReportRequired")]
        public string WellsFargoFraudBaselineReportRequired { get; set; }

        [DataMember(Name = "wellsFargoComplianceBaselineReportRequired")]
        public string WellsFargoComplianceBaselineReportRequired { get; set; }

        [DataMember(Name = "wellsFargoFloodBaselineReportRequired")]
        public string WellsFargoFloodBaselineReportRequired { get; set; }

        [DataMember(Name = "citibankCcvpBaselineReportRequired")]
        public string CitibankCcvpBaselineReportRequired { get; set; }

        [DataMember(Name = "citibankFraudBaselineReportRequired")]
        public string CitibankFraudBaselineReportRequired { get; set; }

        [DataMember(Name = "citibankComplianceBaselineReportRequired")]
        public string CitibankComplianceBaselineReportRequired { get; set; }

        [DataMember(Name = "citibank4506TBaselineReportRequired")]
        public string Citibank4506TBaselineReportRequired { get; set; }

        [DataMember(Name = "citibankFloodBaselineReportRequired")]
        public string CitibankFloodBaselineReportRequired { get; set; }

        [DataMember(Name = "homeward4506TBaselineReportRequired")]
        public string Homeward4506TBaselineReportRequired { get; set; }

        [DataMember(Name = "homewardFraudBaselineReportRequired")]
        public string HomewardFraudBaselineReportRequired { get; set; }

        [DataMember(Name = "homewardComplianceBaselineReportRequired")]
        public string HomewardComplianceBaselineReportRequired { get; set; }

        [DataMember(Name = "homewardFloodBaselineReportRequired")]
        public string HomewardFloodBaselineReportRequired { get; set; }

        [DataMember(Name = "stonegate4506TBaselineReport")]
        public string Stonegate4506TBaselineReport { get; set; }

        [DataMember(Name = "stonegateFraudBaselineReportRequired")]
        public string StonegateFraudBaselineReportRequired { get; set; }

        [DataMember(Name = "stonegateComplianceBaselineReportRequired")]
        public string StonegateComplianceBaselineReportRequired { get; set; }

        [DataMember(Name = "stonegateFloodBaselineReportRequired")]
        public string StonegateFloodBaselineReportRequired { get; set; }

        [DataMember(Name = "phh4506TBaselineReportRequired")]
        public string Phh4506TBaselineReportRequired { get; set; }

        [DataMember(Name = "phhFraudBaselineReportRequired")]
        public string PhhFraudBaselineReportRequired { get; set; }

        [DataMember(Name = "phhComplianceBaselineReportRequired")]
        public string PhhComplianceBaselineReportRequired { get; set; }

        [DataMember(Name = "phhFloodBaselineReportRequired")]
        public string PhhFloodBaselineReportRequired { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotal")]
        public int TqlFraudAlertsTotal { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalHigh")]
        public int TqlFraudAlertsTotalHigh { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalMedium")]
        public int TqlFraudAlertsTotalMedium { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalLow")]
        public int TqlFraudAlertsTotalLow { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalHighUnaddressed")]
        public int TqlFraudAlertsTotalHighUnaddressed { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalMediumUnaddressed")]
        public int TqlFraudAlertsTotalMediumUnaddressed { get; set; }

        [DataMember(Name = "tqlFraudAlertsTotalLowUnaddressed")]
        public int TqlFraudAlertsTotalLowUnaddressed { get; set; }

        [DataMember(Name = "driveScore")]
        public int DriveScore { get; set; }

        [DataMember(Name = "driveStatus")]
        public string DriveStatus { get; set; }

        [DataMember(Name = "driveIdVerifyScore")]
        public int DriveIdVerifyScore { get; set; }

        [DataMember(Name = "driveAppVerifyScore")]
        public int DriveAppVerifyScore { get; set; }

        [DataMember(Name = "drivePropertyVerifyScore")]
        public int DrivePropertyVerifyScore { get; set; }

        [DataMember(Name = "miVendorsArchAutoOrderIndicator")]
        public bool? MiVendorsArchAutoOrderIndicator { get; set; }

        [DataMember(Name = "miVendorsRadianAutoOrderIndicator")]
        public bool? MiVendorsRadianAutoOrderIndicator { get; set; }

        [DataMember(Name = "miVendorsMgicAutoOrderIndicator")]
        public bool? MiVendorsMgicAutoOrderIndicator { get; set; }

        [DataMember(Name = "tqlDocuments")]
        public List<TqlDocumentContract> TqlDocuments { get; set; }

        [DataMember(Name = "lpAppraisalWaiverOffered")]
        public bool? LpAppraisalWaiverOffered { get; set; }

        [DataMember(Name = "lpAppraisalWaiverMessage")]
        public string LpAppraisalWaiverMessage { get; set; }

        [DataMember(Name = "lpDocumentationLevel")]
        public string LpDocumentationLevel { get; set; }

        [DataMember(Name = "lpDocumentationLevelMessage")]
        public string LpDocumentationLevelMessage { get; set; }

        [DataMember(Name = "lpaPurchaseEligibility")]
        public string LpaPurchaseEligibility { get; set; }

        [DataMember(Name = "lpCollateralRepWarrantyMessage")]
        public string LpCollateralRepWarrantyMessage { get; set; }

        [DataMember(Name = "lpAssetRepWarrantyIndicator")]
        public bool? LpAssetRepWarrantyIndicator { get; set; }

        [DataMember(Name = "lpAssetRepWarrantyMessage")]
        public string LpAssetRepWarrantyMessage { get; set; }

        [DataMember(Name = "lpIncomeRepWarrantyIndicator")]
        public bool? LpIncomeRepWarrantyIndicator { get; set; }

        [DataMember(Name = "lpIncomeRepWarrantyMessage")]
        public string LpIncomeRepWarrantyMessage { get; set; }

        [DataMember(Name = "duPropertyDataId")]
        public string DuPropertyDataId { get; set; }

        [DataMember(Name = "duPropertyDataMessage")]
        public string DuPropertyDataMessage { get; set; }

        [DataMember(Name = "duFindingsMessageDateTime")]
        public string DuFindingsMessageDateTime { get; set; }

        [DataMember(Name = "floodTransactionType")]
        public string FloodTransactionType { get; set; }

        [DataMember(Name = "floodProductType")]
        public string FloodProductType { get; set; }

        [DataMember(Name = "floodStatus")]
        public string FloodStatus { get; set; }

        [DataMember(Name = "floodOrderDate")]
        public string FloodOrderDate { get; set; }

        [DataMember(Name = "floodReceivedDate")]
        public string FloodReceivedDate { get; set; }

        [DataMember(Name = "lomaOrLomrIndicator")]
        public bool? LomaOrLomrIndicator { get; set; }

        [DataMember(Name = "lomaOrLomrDate")]
        public string LomaOrLomrDate { get; set; }

        [DataMember(Name = "lomaOrLomrCaseNumber")]
        public string LomaOrLomrCaseNumber { get; set; }

        [DataMember(Name = "floodProgramCode")]
        public string FloodProgramCode { get; set; }

        [DataMember(Name = "duRecommendationDate")]
        public string DuRecommendationDate { get; set; }

        [DataMember(Name = "fannieUcdpStatusDate")]
        public string FannieUcdpStatusDate { get; set; }

        [DataMember(Name = "cuRiskScoreDate")]
        public string CuRiskScoreDate { get; set; }

        [DataMember(Name = "ecStatus1003Date")]
        public string EcStatus1003Date { get; set; }

        [DataMember(Name = "ecStatusUlddDate")]
        public string EcStatusUlddDate { get; set; }

        [DataMember(Name = "ucdCollectionDate")]
        public string UcdCollectionDate { get; set; }

        [DataMember(Name = "lpaRiskClassDate")]
        public string LpaRiskClassDate { get; set; }

        [DataMember(Name = "lpaPurchEligDate")]
        public string LpaPurchEligDate { get; set; }

        [DataMember(Name = "documentationLevelDate")]
        public string DocumentationLevelDate { get; set; }

        [DataMember(Name = "freddieUcdpStatusDate")]
        public string FreddieUcdpStatusDate { get; set; }

        [DataMember(Name = "collRiskScoreDate")]
        public string CollRiskScoreDate { get; set; }

        [DataMember(Name = "lqaPurchEligDate")]
        public string LqaPurchEligDate { get; set; }

        [DataMember(Name = "lqaRiskAssessmentDate")]
        public string LqaRiskAssessmentDate { get; set; }

        [DataMember(Name = "lclaUcdReqDate")]
        public string LclaUcdReqDate { get; set; }

        [DataMember(Name = "fannieApprWaiverOfferedDate")]
        public string FannieApprWaiverOfferedDate { get; set; }

        [DataMember(Name = "fannieValueRepAndWarrantDate")]
        public string FannieValueRepAndWarrantDate { get; set; }

        [DataMember(Name = "fannieAssetRepAndWarrantDate")]
        public string FannieAssetRepAndWarrantDate { get; set; }

        [DataMember(Name = "fannieMiscDate1")]
        public string FannieMiscDate1 { get; set; }

        [DataMember(Name = "fannieMiscDate2")]
        public string FannieMiscDate2 { get; set; }

        [DataMember(Name = "freddieApprWaiverOfferedDate")]
        public string FreddieApprWaiverOfferedDate { get; set; }

        [DataMember(Name = "freddieColRepAndWarrantDate")]
        public string FreddieColRepAndWarrantDate { get; set; }

        [DataMember(Name = "freddieAssetRepAndWarrantDate")]
        public string FreddieAssetRepAndWarrantDate { get; set; }

        [DataMember(Name = "freddieIncomeRepAndWarrantDate")]
        public string FreddieIncomeRepAndWarrantDate { get; set; }

        [DataMember(Name = "freddieMiscDate1")]
        public string FreddieMiscDate1 { get; set; }

        [DataMember(Name = "freddieMiscDate2")]
        public string FreddieMiscDate2 { get; set; }

        [DataMember(Name = "rwtMisc1")]
        public string RwtMisc1 { get; set; }

        [DataMember(Name = "rwtMisc2")]
        public string RwtMisc2 { get; set; }

        [DataMember(Name = "rwtMisc3")]
        public string RwtMisc3 { get; set; }

        [DataMember(Name = "rwtMiscDate1")]
        public string RwtMiscDate1 { get; set; }

        [DataMember(Name = "rwtMiscDate2")]
        public string RwtMiscDate2 { get; set; }

        [DataMember(Name = "rwtMiscDate3")]
        public string RwtMiscDate3 { get; set; }

    }
}
