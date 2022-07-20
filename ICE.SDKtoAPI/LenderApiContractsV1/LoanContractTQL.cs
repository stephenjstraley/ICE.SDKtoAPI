using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQL
	{
		[DataMember(Name="citibank4506TBaselineReportRequired")]
		public string Citibank4506TBaselineReportRequired { get; set; }

		[DataMember(Name="citibankCCVPBaselineReportRequired")]
		public string CitibankCCVPBaselineReportRequired { get; set; }

		[DataMember(Name="citibankComplianceBaselineReportRequired")]
		public string CitibankComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="citibankFloodBaselineReportRequired")]
		public string CitibankFloodBaselineReportRequired { get; set; }

		[DataMember(Name="citibankFraudBaselineReportRequired")]
		public string CitibankFraudBaselineReportRequired { get; set; }

		[DataMember(Name="currentInvestorPublishingStatus")]
		public string CurrentInvestorPublishingStatus { get; set; }

		[DataMember(Name = "driveAppVerifyScore")]
		public int? DriveAppVerifyScore { get; set; } = 0;

		[DataMember(Name = "driveIDVerifyScore")]
		public int? DriveIDVerifyScore { get; set; } = 0;

		[DataMember(Name = "drivePropertyVerifyScore")]
		public int? DrivePropertyVerifyScore { get; set; } = 0;

		[DataMember(Name = "driveScore")]
		public int? DriveScore { get; set; } = 0;

		[DataMember(Name="driveStatus")]
		public string DriveStatus { get; set; }

		[DataMember(Name="homeward4506TBaselineReportRequired")]
		public string Homeward4506TBaselineReportRequired { get; set; }

		[DataMember(Name="homewardComplianceBaselineReportRequired")]
		public string HomewardComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="homewardFloodBaselineReportRequired")]
		public string HomewardFloodBaselineReportRequired { get; set; }

		[DataMember(Name="homewardFraudBaselineReportRequired")]
		public string HomewardFraudBaselineReportRequired { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastCCVPCompletedDate")]
		public DateTime? LastCCVPCompletedDate { get; set; }

		[DataMember(Name="lastCCVPConfidenceScore")]
		public string LastCCVPConfidenceScore { get; set; }

		[DataMember(Name="lastCCVPEstimatedValue")]
		public string LastCCVPEstimatedValue { get; set; }

		[DataMember(Name="lastCCVPForecastDeviationScore")]
		public string LastCCVPForecastDeviationScore { get; set; }

		[DataMember(Name="lastCCVPReportHistoryProResult")]
		public string LastCCVPReportHistoryProResult { get; set; }

		[DataMember(Name="lastCCVPReportID")]
		public string LastCCVPReportID { get; set; }

		[DataMember(Name="lastCCVPReportOrdered")]
		public string LastCCVPReportOrdered { get; set; }

		[DataMember(Name="lastCCVPReportPassResult")]
		public string LastCCVPReportPassResult { get; set; }

		[DataMember(Name="lastCCVPResultsReportReturned")]
		public string LastCCVPResultsReportReturned { get; set; }

		[DataMember(Name="lastComplianceCompletedDate")]
		public DateTime? LastComplianceCompletedDate { get; set; }

		[DataMember(Name="lastComplianceNumberOfAlertMessages")]
		public int? LastComplianceNumberOfAlertMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfErrorMessages")]
		public int? LastComplianceNumberOfErrorMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfFailMessages")]
		public int? LastComplianceNumberOfFailMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfPassMessages")]
		public int? LastComplianceNumberOfPassMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfWarningMessages")]
		public int? LastComplianceNumberOfWarningMessages { get; set; }

		[DataMember(Name="lastComplianceOrderType")]
		public string LastComplianceOrderType { get; set; }

		[DataMember(Name="lastComplianceProductNameReportOrdered")]
		public string LastComplianceProductNameReportOrdered { get; set; }

		[DataMember(Name="lastComplianceReportID")]
		public string LastComplianceReportID { get; set; }

		[DataMember(Name="lastFraudOrderAlerts")]
		public int? LastFraudOrderAlerts { get; set; }

		[DataMember(Name="lastFraudOrderCompletedDate")]
		public DateTime? LastFraudOrderCompletedDate { get; set; }

		[DataMember(Name="lastFraudOrderProduct")]
		public string LastFraudOrderProduct { get; set; }

		[DataMember(Name="lastFraudReportID")]
		public string LastFraudReportID { get; set; }

		[DataMember(Name="lastInvestorPublishingInvestor")]
		public string LastInvestorPublishingInvestor { get; set; }

		[DataMember(Name="lastInvestorPublishingStatusChangeDate")]
		public DateTime? LastInvestorPublishingStatusChangeDate { get; set; }

		[DataMember(Name="lastInvestorPublishingUserWhoChangeStatus")]
		public string LastInvestorPublishingUserWhoChangeStatus { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedCCVP")]
		public string LastUserIDWhoOrderedCCVP { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedCompliance")]
		public string LastUserIDWhoOrderedCompliance { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedFraudOrder")]
		public string LastUserIDWhoOrderedFraudOrder { get; set; }

		[DataMember(Name="mIVendorsArchAutoOrderIndicator")]
		public bool? MIVendorsArchAutoOrderIndicator { get; set; }

		[DataMember(Name="mIVendorsMgicAutoOrderIndicator")]
		public bool? MIVendorsMgicAutoOrderIndicator { get; set; }

		[DataMember(Name="mIVendorsRadianAutoOrderIndicator")]
		public bool? MIVendorsRadianAutoOrderIndicator { get; set; }

		[DataMember(Name="pHH4506TBaselineReportRequired")]
		public string PHH4506TBaselineReportRequired { get; set; }

		[DataMember(Name="pHHComplianceBaselineReportRequired")]
		public string PHHComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="pHHFloodBaselineReportRequired")]
		public string PHHFloodBaselineReportRequired { get; set; }

		[DataMember(Name="pHHFraudBaselineReportRequired")]
		public string PHHFraudBaselineReportRequired { get; set; }

		[DataMember(Name="stonegate4506TBaselineReport")]
		public string Stonegate4506TBaselineReport { get; set; }

		[DataMember(Name="stonegateComplianceBaselineReportRequired")]
		public string StonegateComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="stonegateFloodBaselineReportRequired")]
		public string StonegateFloodBaselineReportRequired { get; set; }

		[DataMember(Name="stonegateFraudBaselineReportRequired")]
		public string StonegateFraudBaselineReportRequired { get; set; }

		[DataMember(Name="tQLComplianceAlerts")]
		public List<LoanContractTQLTQLComplianceAlerts> TQLComplianceAlerts { get; set; }

		[DataMember(Name="tQLDocuments")]
		public List<LoanContractTQLTQLDocuments> TQLDocuments { get; set; }

		[DataMember(Name="tQLFraudAlerts")]
		public List<LoanContractTQLTQLFraudAlerts> TQLFraudAlerts { get; set; }

		[DataMember(Name = "tQLFraudAlertsTotal")]
		public int? TQLFraudAlertsTotal { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalHigh")]
		public int? TQLFraudAlertsTotalHigh { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalHighUnaddressed")]
		public int? TQLFraudAlertsTotalHighUnaddressed { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalLow")]
		public int? TQLFraudAlertsTotalLow { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalLowUnaddressed")]
		public int? TQLFraudAlertsTotalLowUnaddressed { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalMedium")]
		public int? TQLFraudAlertsTotalMedium { get; set; } = 0;

		[DataMember(Name="tQLFraudAlertsTotalMediumUnaddressed")]
		public int? TQLFraudAlertsTotalMediumUnaddressed { get; set; } = 0;

		[DataMember(Name="wellsFargo4506TBaselineReportRequired")]
		public string WellsFargo4506TBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoComplianceBaselineReportRequired")]
		public string WellsFargoComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoFloodBaselineReportRequired")]
		public string WellsFargoFloodBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoFraudBaselineReportRequired")]
		public string WellsFargoFraudBaselineReportRequired { get; set; }

		[DataMember(Name = "lomaOrLomrIndicator")]
		public bool? LomaOrLomrIndicator { get; set; } = false;

		[DataMember(Name = "floodProgramCode")]
		public string FloodProgramCode { get; set; }

	}
}