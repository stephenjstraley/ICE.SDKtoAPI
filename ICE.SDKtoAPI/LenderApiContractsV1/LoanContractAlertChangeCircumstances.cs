using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAlertChangeCircumstances
	{
		[DataMember(Name="alertTriggerFielDID", EmitDefaultValue=false)]
		public string AlertTriggerFielDID { get; set; }

		[DataMember(Name="altId", EmitDefaultValue=false)]
		public string AltId { get; set; }

		[DataMember(Name="changedCircumstanceAlertBaseline", EmitDefaultValue=false)]
		public string ChangedCircumstanceAlertBaseline { get; set; }

		[DataMember(Name="changedCircumstanceAlertDisclosedAmount", EmitDefaultValue=false)]
		public double? ChangedCircumstanceAlertDisclosedAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertFeeDescription", EmitDefaultValue=false)]
		public string ChangedCircumstanceAlertFeeDescription { get; set; }

		[DataMember(Name="changedCircumstanceAlertInitialAmount", EmitDefaultValue=false)]
		public double? ChangedCircumstanceAlertInitialAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertItemizationAmount", EmitDefaultValue=false)]
		public double? ChangedCircumstanceAlertItemizationAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertVarianceAmount", EmitDefaultValue=false)]
		public double? ChangedCircumstanceAlertVarianceAmount { get; set; }

		[DataMember(Name="changedCircumstanceCategory", EmitDefaultValue=false)]
		public string ChangedCircumstanceCategory { get; set; }

		[DataMember(Name="changedCircumstanceComments", EmitDefaultValue=false)]
		public string ChangedCircumstanceComments { get; set; }

		[DataMember(Name="changedCircumstanceDate", EmitDefaultValue=false)]
		public DateTime? ChangedCircumstanceDate { get; set; }

		[DataMember(Name="changedCircumstanceDescription", EmitDefaultValue=false)]
		public string ChangedCircumstanceDescription { get; set; }

		[DataMember(Name="changedCircumstanceReason", EmitDefaultValue=false)]
		public string ChangedCircumstanceReason { get; set; }

		[DataMember(Name="changedCircumstanceReasonOther", EmitDefaultValue=false)]
		public string ChangedCircumstanceReasonOther { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="revisedDueDate", EmitDefaultValue=false)]
		public DateTime? RevisedDueDate { get; set; }

	}
}