using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAdditionalRequests
	{
		[DataMember(Name="appraisalContactCellPhone", EmitDefaultValue=false)]
		public string AppraisalContactCellPhone { get; set; }

		[DataMember(Name="appraisalContactEmail", EmitDefaultValue=false)]
		public string AppraisalContactEmail { get; set; }

		[DataMember(Name="appraisalContactForEntry", EmitDefaultValue=false)]
		public string AppraisalContactForEntry { get; set; }

		[DataMember(Name="appraisalContactHomePhone", EmitDefaultValue=false)]
		public string AppraisalContactHomePhone { get; set; }

		[DataMember(Name="appraisalContactName", EmitDefaultValue=false)]
		public string AppraisalContactName { get; set; }

		[DataMember(Name="appraisalContactWorkPhone", EmitDefaultValue=false)]
		public string AppraisalContactWorkPhone { get; set; }

		[DataMember(Name="appraisalDateOrdered", EmitDefaultValue=false)]
		public DateTime? AppraisalDateOrdered { get; set; }

		[DataMember(Name="appraisalDescription1", EmitDefaultValue=false)]
		public string AppraisalDescription1 { get; set; }

		[DataMember(Name="appraisalDescription2", EmitDefaultValue=false)]
		public string AppraisalDescription2 { get; set; }

		[DataMember(Name="appraisalDescription3", EmitDefaultValue=false)]
		public string AppraisalDescription3 { get; set; }

		[DataMember(Name="appraisalKeyPickUp", EmitDefaultValue=false)]
		public bool? AppraisalKeyPickUp { get; set; }

		[DataMember(Name="appraisalLockBox", EmitDefaultValue=false)]
		public bool? AppraisalLockBox { get; set; }

		[DataMember(Name="appraisalVacant", EmitDefaultValue=false)]
		public bool? AppraisalVacant { get; set; }

		[DataMember(Name="floodDescription1", EmitDefaultValue=false)]
		public string FloodDescription1 { get; set; }

		[DataMember(Name="floodDescription2", EmitDefaultValue=false)]
		public string FloodDescription2 { get; set; }

		[DataMember(Name="floodDescription3", EmitDefaultValue=false)]
		public string FloodDescription3 { get; set; }

		[DataMember(Name="floodInsuranceEscrowed", EmitDefaultValue=false)]
		public bool? FloodInsuranceEscrowed { get; set; }

		[DataMember(Name="floodReplacementValue", EmitDefaultValue=false)]
		public string FloodReplacementValue { get; set; }

		[DataMember(Name="hazardDescription1", EmitDefaultValue=false)]
		public string HazardDescription1 { get; set; }

		[DataMember(Name="hazardDescription2", EmitDefaultValue=false)]
		public string HazardDescription2 { get; set; }

		[DataMember(Name="hazardDescription3", EmitDefaultValue=false)]
		public string HazardDescription3 { get; set; }

		[DataMember(Name="hazardInsuranceEscrowed", EmitDefaultValue=false)]
		public bool? HazardInsuranceEscrowed { get; set; }

		[DataMember(Name="hazardReplacementValue", EmitDefaultValue=false)]
		public string HazardReplacementValue { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="maximumDeductibleFloodAmount", EmitDefaultValue=false)]
		public double? MaximumDeductibleFloodAmount { get; set; }

		[DataMember(Name="maximumDeductibleFloodPercentage", EmitDefaultValue=false)]
		public double? MaximumDeductibleFloodPercentage { get; set; }

		[DataMember(Name="maximumDeductibleHazardAmount", EmitDefaultValue=false)]
		public double? MaximumDeductibleHazardAmount { get; set; }

		[DataMember(Name="maximumDeductibleHazardPercentage", EmitDefaultValue=false)]
		public double? MaximumDeductibleHazardPercentage { get; set; }

		[DataMember(Name="titleContract", EmitDefaultValue=false)]
		public bool? TitleContract { get; set; }

		[DataMember(Name="titleDescription1", EmitDefaultValue=false)]
		public string TitleDescription1 { get; set; }

		[DataMember(Name="titleDescription2", EmitDefaultValue=false)]
		public string TitleDescription2 { get; set; }

		[DataMember(Name="titleDescription3", EmitDefaultValue=false)]
		public string TitleDescription3 { get; set; }

		[DataMember(Name="titleInsRequirements", EmitDefaultValue=false)]
		public bool? TitleInsRequirements { get; set; }

		[DataMember(Name="titleMailAway", EmitDefaultValue=false)]
		public bool? TitleMailAway { get; set; }

		[DataMember(Name="titlePriorTitlePolicy", EmitDefaultValue=false)]
		public bool? TitlePriorTitlePolicy { get; set; }

		[DataMember(Name="titleSurvey", EmitDefaultValue=false)]
		public bool? TitleSurvey { get; set; }

		[DataMember(Name="titleTypeOfProperty", EmitDefaultValue=false)]
		public string TitleTypeOfProperty { get; set; }

		[DataMember(Name="titleWarrantyDeed", EmitDefaultValue=false)]
		public bool? TitleWarrantyDeed { get; set; }

	}
}