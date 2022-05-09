using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractTQLTQLComplianceAlerts
	{
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lastComplianceOrderAlertCategories", EmitDefaultValue=false)]
		public string LastComplianceOrderAlertCategories { get; set; }

		[DataMember(Name="lastComplianceOrderAlertMessage", EmitDefaultValue=false)]
		public string LastComplianceOrderAlertMessage { get; set; }

		[DataMember(Name="lastComplianceOrderDescriptionOfAlerts", EmitDefaultValue=false)]
		public string LastComplianceOrderDescriptionOfAlerts { get; set; }

		[DataMember(Name="tQLComplianceAlertIndex", EmitDefaultValue=false)]
		public int? TQLComplianceAlertIndex { get; set; }

	}
}