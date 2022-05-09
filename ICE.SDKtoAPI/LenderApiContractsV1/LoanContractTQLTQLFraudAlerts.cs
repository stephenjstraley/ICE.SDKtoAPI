using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLFraudAlerts
	{
		[DataMember(Name="driveFraudAlertCode", EmitDefaultValue=false)]
		public string DriveFraudAlertCode { get; set; }

		[DataMember(Name="driveFraudAlertStatus", EmitDefaultValue=false)]
		public string DriveFraudAlertStatus { get; set; }

		[DataMember(Name="fraudGuardFraudAlertCode", EmitDefaultValue=false)]
		public string FraudGuardFraudAlertCode { get; set; }

		[DataMember(Name="fraudGuardFraudAlertStatus", EmitDefaultValue=false)]
		public string FraudGuardFraudAlertStatus { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastFraudOrderAlertCategories", EmitDefaultValue=false)]
		public string LastFraudOrderAlertCategories { get; set; }

		[DataMember(Name="lastFraudOrderAlertID", EmitDefaultValue=false)]
		public string LastFraudOrderAlertID { get; set; }

		[DataMember(Name="lastFraudOrderAlertLevel", EmitDefaultValue=false)]
		public string LastFraudOrderAlertLevel { get; set; }

		[DataMember(Name="lastFraudOrderDescriptionOfAlerts", EmitDefaultValue=false)]
		public string LastFraudOrderDescriptionOfAlerts { get; set; }

		[DataMember(Name="tQLFraudAlertIndex", EmitDefaultValue=false)]
		public int? TQLFraudAlertIndex { get; set; }

	}
}