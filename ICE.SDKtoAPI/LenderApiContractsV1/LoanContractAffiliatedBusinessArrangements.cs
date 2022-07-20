using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAffiliatedBusinessArrangements
	{
		[DataMember(Name="affiliatedBusinessArrangementIndex")]
		public int? AffiliatedBusinessArrangementIndex { get; set; }

		[DataMember(Name="affiliateName")]
		public string AffiliateName { get; set; }

		[DataMember(Name="chargeRangeChargesDescription1")]
		public string ChargeRangeChargesDescription1 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription2")]
		public string ChargeRangeChargesDescription2 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription3")]
		public string ChargeRangeChargesDescription3 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription4")]
		public string ChargeRangeChargesDescription4 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription5")]
		public string ChargeRangeChargesDescription5 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription6")]
		public string ChargeRangeChargesDescription6 { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lenderAddress")]
		public string LenderAddress { get; set; }

		[DataMember(Name="lenderAddressCity")]
		public string LenderAddressCity { get; set; }

		[DataMember(Name="lenderAddressState")]
		public string LenderAddressState { get; set; }

		[DataMember(Name="lenderAddressZipcode")]
		public string LenderAddressZipcode { get; set; }

		[DataMember(Name="lenderName")]
		public string LenderName { get; set; }

		[DataMember(Name="natureOfRelationship")]
		public string NatureOfRelationship { get; set; }

		[DataMember(Name="percentOwnershipInterest")]
		public decimal? PercentOwnershipInterest { get; set; }

		[DataMember(Name="purchaseSaleRefinanceIndicator")]
		public bool? PurchaseSaleRefinanceIndicator { get; set; }

		[DataMember(Name="requiredUseIndicator1")]
		public bool? RequiredUseIndicator1 { get; set; }

		[DataMember(Name="requiredUseIndicator2")]
		public bool? RequiredUseIndicator2 { get; set; }

		[DataMember(Name="requiredUseIndicator3")]
		public bool? RequiredUseIndicator3 { get; set; }

		[DataMember(Name="requiredUseIndicator4")]
		public bool? RequiredUseIndicator4 { get; set; }

		[DataMember(Name="requiredUseIndicator5")]
		public bool? RequiredUseIndicator5 { get; set; }

		[DataMember(Name="requiredUseIndicator6")]
		public bool? RequiredUseIndicator6 { get; set; }

		[DataMember(Name="serviceDescription1")]
		public string ServiceDescription1 { get; set; }

		[DataMember(Name="serviceDescription2")]
		public string ServiceDescription2 { get; set; }

		[DataMember(Name="serviceDescription3")]
		public string ServiceDescription3 { get; set; }

		[DataMember(Name="serviceDescription4")]
		public string ServiceDescription4 { get; set; }

		[DataMember(Name="serviceDescription5")]
		public string ServiceDescription5 { get; set; }

		[DataMember(Name="serviceDescription6")]
		public string ServiceDescription6 { get; set; }

		[DataMember(Name="settlementIndicator")]
		public bool? SettlementIndicator { get; set; }

	}
}