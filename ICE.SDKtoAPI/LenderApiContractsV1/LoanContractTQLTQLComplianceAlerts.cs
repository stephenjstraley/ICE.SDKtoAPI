using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLComplianceAlerts
	{
		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lastComplianceOrderAlertCategories")]
		public string LastComplianceOrderAlertCategories { get; set; }

		[DataMember(Name="lastComplianceOrderAlertMessage")]
		public string LastComplianceOrderAlertMessage { get; set; }

		[DataMember(Name="lastComplianceOrderDescriptionOfAlerts")]
		public string LastComplianceOrderDescriptionOfAlerts { get; set; }

		[DataMember(Name="tQLComplianceAlertIndex")]
		public int? TQLComplianceAlertIndex { get; set; }

	}
}