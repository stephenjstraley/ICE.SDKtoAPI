using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAdditionalRequests
	{
		[DataMember(Name="appraisalContactCellPhone")]
		public string AppraisalContactCellPhone { get; set; }

		[DataMember(Name="appraisalContactEmail")]
		public string AppraisalContactEmail { get; set; }

		[DataMember(Name="appraisalContactForEntry")]
		public string AppraisalContactForEntry { get; set; }

		[DataMember(Name="appraisalContactHomePhone")]
		public string AppraisalContactHomePhone { get; set; }

		[DataMember(Name="appraisalContactName")]
		public string AppraisalContactName { get; set; }

		[DataMember(Name="appraisalContactWorkPhone")]
		public string AppraisalContactWorkPhone { get; set; }

		[DataMember(Name="appraisalDateOrdered")]
		public DateTime? AppraisalDateOrdered { get; set; }

		[DataMember(Name="appraisalDescription1")]
		public string AppraisalDescription1 { get; set; }

		[DataMember(Name="appraisalDescription2")]
		public string AppraisalDescription2 { get; set; }

		[DataMember(Name="appraisalDescription3")]
		public string AppraisalDescription3 { get; set; }

		[DataMember(Name="appraisalKeyPickUp")]
		public bool? AppraisalKeyPickUp { get; set; }

		[DataMember(Name="appraisalLockBox")]
		public bool? AppraisalLockBox { get; set; }

		[DataMember(Name="appraisalVacant")]
		public bool? AppraisalVacant { get; set; }

		[DataMember(Name="floodDescription1")]
		public string FloodDescription1 { get; set; }

		[DataMember(Name="floodDescription2")]
		public string FloodDescription2 { get; set; }

		[DataMember(Name="floodDescription3")]
		public string FloodDescription3 { get; set; }

		[DataMember(Name="floodInsuranceEscrowed")]
		public bool? FloodInsuranceEscrowed { get; set; }

		[DataMember(Name="floodReplacementValue")]
		public string FloodReplacementValue { get; set; }

		[DataMember(Name="hazardDescription1")]
		public string HazardDescription1 { get; set; }

		[DataMember(Name="hazardDescription2")]
		public string HazardDescription2 { get; set; }

		[DataMember(Name="hazardDescription3")]
		public string HazardDescription3 { get; set; }

		[DataMember(Name="hazardInsuranceEscrowed")]
		public bool? HazardInsuranceEscrowed { get; set; }

		[DataMember(Name="hazardReplacementValue")]
		public string HazardReplacementValue { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="maximumDeductibleFloodAmount")]
		public decimal? MaximumDeductibleFloodAmount { get; set; }

		[DataMember(Name="maximumDeductibleFloodPercentage")]
		public decimal? MaximumDeductibleFloodPercentage { get; set; }

		[DataMember(Name="maximumDeductibleHazardAmount")]
		public decimal? MaximumDeductibleHazardAmount { get; set; }

		[DataMember(Name="maximumDeductibleHazardPercentage")]
		public decimal? MaximumDeductibleHazardPercentage { get; set; }

		[DataMember(Name="titleContract")]
		public bool? TitleContract { get; set; }

		[DataMember(Name="titleDescription1")]
		public string TitleDescription1 { get; set; }

		[DataMember(Name="titleDescription2")]
		public string TitleDescription2 { get; set; }

		[DataMember(Name="titleDescription3")]
		public string TitleDescription3 { get; set; }

		[DataMember(Name="titleInsRequirements")]
		public bool? TitleInsRequirements { get; set; }

		[DataMember(Name="titleMailAway")]
		public bool? TitleMailAway { get; set; }

		[DataMember(Name="titlePriorTitlePolicy")]
		public bool? TitlePriorTitlePolicy { get; set; }

		[DataMember(Name="titleSurvey")]
		public bool? TitleSurvey { get; set; }

		[DataMember(Name="titleTypeOfProperty")]
		public string TitleTypeOfProperty { get; set; }

		[DataMember(Name="titleWarrantyDeed")]
		public bool? TitleWarrantyDeed { get; set; }

	}
}