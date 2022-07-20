using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLFraudAlerts
	{
		[DataMember(Name="driveFraudAlertCode")]
		public string DriveFraudAlertCode { get; set; }

		[DataMember(Name="driveFraudAlertStatus")]
		public string DriveFraudAlertStatus { get; set; }

		[DataMember(Name="fraudGuardFraudAlertCode")]
		public string FraudGuardFraudAlertCode { get; set; }

		[DataMember(Name="fraudGuardFraudAlertStatus")]
		public string FraudGuardFraudAlertStatus { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastFraudOrderAlertCategories")]
		public string LastFraudOrderAlertCategories { get; set; }

		[DataMember(Name="lastFraudOrderAlertID")]
		public string LastFraudOrderAlertID { get; set; }

		[DataMember(Name="lastFraudOrderAlertLevel")]
		public string LastFraudOrderAlertLevel { get; set; }

		[DataMember(Name="lastFraudOrderDescriptionOfAlerts")]
		public string LastFraudOrderDescriptionOfAlerts { get; set; }

		[DataMember(Name="tQLFraudAlertIndex")]
		public int? TQLFraudAlertIndex { get; set; }

	}
}