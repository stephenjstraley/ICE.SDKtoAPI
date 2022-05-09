using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQL
	{
		[DataMember(Name="citibank4506TBaselineReportRequired", EmitDefaultValue=false)]
		public string Citibank4506TBaselineReportRequired { get; set; }

		[DataMember(Name="citibankCCVPBaselineReportRequired", EmitDefaultValue=false)]
		public string CitibankCCVPBaselineReportRequired { get; set; }

		[DataMember(Name="citibankComplianceBaselineReportRequired", EmitDefaultValue=false)]
		public string CitibankComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="citibankFloodBaselineReportRequired", EmitDefaultValue=false)]
		public string CitibankFloodBaselineReportRequired { get; set; }

		[DataMember(Name="citibankFraudBaselineReportRequired", EmitDefaultValue=false)]
		public string CitibankFraudBaselineReportRequired { get; set; }

		[DataMember(Name="currentInvestorPublishingStatus", EmitDefaultValue=false)]
		public string CurrentInvestorPublishingStatus { get; set; }

		[DataMember(Name="driveAppVerifyScore", EmitDefaultValue=false)]
		public int? DriveAppVerifyScore { get; set; }

		[DataMember(Name="driveIDVerifyScore", EmitDefaultValue=false)]
		public int? DriveIDVerifyScore { get; set; }

		[DataMember(Name="drivePropertyVerifyScore", EmitDefaultValue=false)]
		public int? DrivePropertyVerifyScore { get; set; }

		[DataMember(Name="driveScore", EmitDefaultValue=false)]
		public int? DriveScore { get; set; }

		[DataMember(Name="driveStatus", EmitDefaultValue=false)]
		public string DriveStatus { get; set; }

		[DataMember(Name="homeward4506TBaselineReportRequired", EmitDefaultValue=false)]
		public string Homeward4506TBaselineReportRequired { get; set; }

		[DataMember(Name="homewardComplianceBaselineReportRequired", EmitDefaultValue=false)]
		public string HomewardComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="homewardFloodBaselineReportRequired", EmitDefaultValue=false)]
		public string HomewardFloodBaselineReportRequired { get; set; }

		[DataMember(Name="homewardFraudBaselineReportRequired", EmitDefaultValue=false)]
		public string HomewardFraudBaselineReportRequired { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastCCVPCompletedDate", EmitDefaultValue=false)]
		public DateTime? LastCCVPCompletedDate { get; set; }

		[DataMember(Name="lastCCVPConfidenceScore", EmitDefaultValue=false)]
		public string LastCCVPConfidenceScore { get; set; }

		[DataMember(Name="lastCCVPEstimatedValue", EmitDefaultValue=false)]
		public string LastCCVPEstimatedValue { get; set; }

		[DataMember(Name="lastCCVPForecastDeviationScore", EmitDefaultValue=false)]
		public string LastCCVPForecastDeviationScore { get; set; }

		[DataMember(Name="lastCCVPReportHistoryProResult", EmitDefaultValue=false)]
		public string LastCCVPReportHistoryProResult { get; set; }

		[DataMember(Name="lastCCVPReportID", EmitDefaultValue=false)]
		public string LastCCVPReportID { get; set; }

		[DataMember(Name="lastCCVPReportOrdered", EmitDefaultValue=false)]
		public string LastCCVPReportOrdered { get; set; }

		[DataMember(Name="lastCCVPReportPassResult", EmitDefaultValue=false)]
		public string LastCCVPReportPassResult { get; set; }

		[DataMember(Name="lastCCVPResultsReportReturned", EmitDefaultValue=false)]
		public string LastCCVPResultsReportReturned { get; set; }

		[DataMember(Name="lastComplianceCompletedDate", EmitDefaultValue=false)]
		public DateTime? LastComplianceCompletedDate { get; set; }

		[DataMember(Name="lastComplianceNumberOfAlertMessages", EmitDefaultValue=false)]
		public int? LastComplianceNumberOfAlertMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfErrorMessages", EmitDefaultValue=false)]
		public int? LastComplianceNumberOfErrorMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfFailMessages", EmitDefaultValue=false)]
		public int? LastComplianceNumberOfFailMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfPassMessages", EmitDefaultValue=false)]
		public int? LastComplianceNumberOfPassMessages { get; set; }

		[DataMember(Name="lastComplianceNumberOfWarningMessages", EmitDefaultValue=false)]
		public int? LastComplianceNumberOfWarningMessages { get; set; }

		[DataMember(Name="lastComplianceOrderType", EmitDefaultValue=false)]
		public string LastComplianceOrderType { get; set; }

		[DataMember(Name="lastComplianceProductNameReportOrdered", EmitDefaultValue=false)]
		public string LastComplianceProductNameReportOrdered { get; set; }

		[DataMember(Name="lastComplianceReportID", EmitDefaultValue=false)]
		public string LastComplianceReportID { get; set; }

		[DataMember(Name="lastFraudOrderAlerts", EmitDefaultValue=false)]
		public int? LastFraudOrderAlerts { get; set; }

		[DataMember(Name="lastFraudOrderCompletedDate", EmitDefaultValue=false)]
		public DateTime? LastFraudOrderCompletedDate { get; set; }

		[DataMember(Name="lastFraudOrderProduct", EmitDefaultValue=false)]
		public string LastFraudOrderProduct { get; set; }

		[DataMember(Name="lastFraudReportID", EmitDefaultValue=false)]
		public string LastFraudReportID { get; set; }

		[DataMember(Name="lastInvestorPublishingInvestor", EmitDefaultValue=false)]
		public string LastInvestorPublishingInvestor { get; set; }

		[DataMember(Name="lastInvestorPublishingStatusChangeDate", EmitDefaultValue=false)]
		public DateTime? LastInvestorPublishingStatusChangeDate { get; set; }

		[DataMember(Name="lastInvestorPublishingUserWhoChangeStatus", EmitDefaultValue=false)]
		public string LastInvestorPublishingUserWhoChangeStatus { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedCCVP", EmitDefaultValue=false)]
		public string LastUserIDWhoOrderedCCVP { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedCompliance", EmitDefaultValue=false)]
		public string LastUserIDWhoOrderedCompliance { get; set; }

		[DataMember(Name="lastUserIDWhoOrderedFraudOrder", EmitDefaultValue=false)]
		public string LastUserIDWhoOrderedFraudOrder { get; set; }

		[DataMember(Name="mIVendorsArchAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? MIVendorsArchAutoOrderIndicator { get; set; }

		[DataMember(Name="mIVendorsMgicAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? MIVendorsMgicAutoOrderIndicator { get; set; }

		[DataMember(Name="mIVendorsRadianAutoOrderIndicator", EmitDefaultValue=false)]
		public bool? MIVendorsRadianAutoOrderIndicator { get; set; }

		[DataMember(Name="pHH4506TBaselineReportRequired", EmitDefaultValue=false)]
		public string PHH4506TBaselineReportRequired { get; set; }

		[DataMember(Name="pHHComplianceBaselineReportRequired", EmitDefaultValue=false)]
		public string PHHComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="pHHFloodBaselineReportRequired", EmitDefaultValue=false)]
		public string PHHFloodBaselineReportRequired { get; set; }

		[DataMember(Name="pHHFraudBaselineReportRequired", EmitDefaultValue=false)]
		public string PHHFraudBaselineReportRequired { get; set; }

		[DataMember(Name="stonegate4506TBaselineReport", EmitDefaultValue=false)]
		public string Stonegate4506TBaselineReport { get; set; }

		[DataMember(Name="stonegateComplianceBaselineReportRequired", EmitDefaultValue=false)]
		public string StonegateComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="stonegateFloodBaselineReportRequired", EmitDefaultValue=false)]
		public string StonegateFloodBaselineReportRequired { get; set; }

		[DataMember(Name="stonegateFraudBaselineReportRequired", EmitDefaultValue=false)]
		public string StonegateFraudBaselineReportRequired { get; set; }

		[DataMember(Name="tQLComplianceAlerts", EmitDefaultValue=false)]
		public List<LoanContractTQLTQLComplianceAlerts> TQLComplianceAlerts { get; set; }

		[DataMember(Name="tQLDocuments", EmitDefaultValue=false)]
		public List<LoanContractTQLTQLDocuments> TQLDocuments { get; set; }

		[DataMember(Name="tQLFraudAlerts", EmitDefaultValue=false)]
		public List<LoanContractTQLTQLFraudAlerts> TQLFraudAlerts { get; set; }

		[DataMember(Name="tQLFraudAlertsTotal", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotal { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalHigh", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalHigh { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalHighUnaddressed", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalHighUnaddressed { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalLow", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalLow { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalLowUnaddressed", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalLowUnaddressed { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalMedium", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalMedium { get; set; }

		[DataMember(Name="tQLFraudAlertsTotalMediumUnaddressed", EmitDefaultValue=false)]
		public int? TQLFraudAlertsTotalMediumUnaddressed { get; set; }

		[DataMember(Name="wellsFargo4506TBaselineReportRequired", EmitDefaultValue=false)]
		public string WellsFargo4506TBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoComplianceBaselineReportRequired", EmitDefaultValue=false)]
		public string WellsFargoComplianceBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoFloodBaselineReportRequired", EmitDefaultValue=false)]
		public string WellsFargoFloodBaselineReportRequired { get; set; }

		[DataMember(Name="wellsFargoFraudBaselineReportRequired", EmitDefaultValue=false)]
		public string WellsFargoFraudBaselineReportRequired { get; set; }

	}
}