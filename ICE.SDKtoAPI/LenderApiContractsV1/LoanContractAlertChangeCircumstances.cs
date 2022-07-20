using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAlertChangeCircumstances
	{
		[DataMember(Name="alertTriggerFielDID")]
		public string AlertTriggerFielDID { get; set; }

		[DataMember(Name="altId")]
		public string AltId { get; set; }

		[DataMember(Name="changedCircumstanceAlertBaseline")]
		public string ChangedCircumstanceAlertBaseline { get; set; }

		[DataMember(Name="changedCircumstanceAlertDisclosedAmount")]
		public decimal? ChangedCircumstanceAlertDisclosedAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertFeeDescription")]
		public string ChangedCircumstanceAlertFeeDescription { get; set; }

		[DataMember(Name="changedCircumstanceAlertInitialAmount")]
		public decimal? ChangedCircumstanceAlertInitialAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertItemizationAmount")]
		public decimal? ChangedCircumstanceAlertItemizationAmount { get; set; }

		[DataMember(Name="changedCircumstanceAlertVarianceAmount")]
		public decimal? ChangedCircumstanceAlertVarianceAmount { get; set; }

		[DataMember(Name="changedCircumstanceCategory")]
		public string ChangedCircumstanceCategory { get; set; }

		[DataMember(Name="changedCircumstanceComments")]
		public string ChangedCircumstanceComments { get; set; }

		[DataMember(Name="changedCircumstanceDate")]
		public DateTime? ChangedCircumstanceDate { get; set; }

		[DataMember(Name="changedCircumstanceDescription")]
		public string ChangedCircumstanceDescription { get; set; }

		[DataMember(Name="changedCircumstanceReason")]
		public string ChangedCircumstanceReason { get; set; }

		[DataMember(Name="changedCircumstanceReasonOther")]
		public string ChangedCircumstanceReasonOther { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="revisedDueDate")]
		public DateTime? RevisedDueDate { get; set; }

	}
}