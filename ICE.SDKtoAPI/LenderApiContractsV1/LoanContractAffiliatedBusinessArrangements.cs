using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractAffiliatedBusinessArrangements
	{
		[DataMember(Name="affiliatedBusinessArrangementIndex", EmitDefaultValue=false)]
		public int? AffiliatedBusinessArrangementIndex { get; set; }

		[DataMember(Name="affiliateName", EmitDefaultValue=false)]
		public string AffiliateName { get; set; }

		[DataMember(Name="chargeRangeChargesDescription1", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription1 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription2", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription2 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription3", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription3 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription4", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription4 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription5", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription5 { get; set; }

		[DataMember(Name="chargeRangeChargesDescription6", EmitDefaultValue=false)]
		public string ChargeRangeChargesDescription6 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lenderAddress", EmitDefaultValue=false)]
		public string LenderAddress { get; set; }

		[DataMember(Name="lenderAddressCity", EmitDefaultValue=false)]
		public string LenderAddressCity { get; set; }

		[DataMember(Name="lenderAddressState", EmitDefaultValue=false)]
		public string LenderAddressState { get; set; }

		[DataMember(Name="lenderAddressZipcode", EmitDefaultValue=false)]
		public string LenderAddressZipcode { get; set; }

		[DataMember(Name="lenderName", EmitDefaultValue=false)]
		public string LenderName { get; set; }

		[DataMember(Name="natureOfRelationship", EmitDefaultValue=false)]
		public string NatureOfRelationship { get; set; }

		[DataMember(Name="percentOwnershipInterest", EmitDefaultValue=false)]
		public double? PercentOwnershipInterest { get; set; }

		[DataMember(Name="purchaseSaleRefinanceIndicator", EmitDefaultValue=false)]
		public bool? PurchaseSaleRefinanceIndicator { get; set; }

		[DataMember(Name="requiredUseIndicator1", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator1 { get; set; }

		[DataMember(Name="requiredUseIndicator2", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator2 { get; set; }

		[DataMember(Name="requiredUseIndicator3", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator3 { get; set; }

		[DataMember(Name="requiredUseIndicator4", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator4 { get; set; }

		[DataMember(Name="requiredUseIndicator5", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator5 { get; set; }

		[DataMember(Name="requiredUseIndicator6", EmitDefaultValue=false)]
		public bool? RequiredUseIndicator6 { get; set; }

		[DataMember(Name="serviceDescription1", EmitDefaultValue=false)]
		public string ServiceDescription1 { get; set; }

		[DataMember(Name="serviceDescription2", EmitDefaultValue=false)]
		public string ServiceDescription2 { get; set; }

		[DataMember(Name="serviceDescription3", EmitDefaultValue=false)]
		public string ServiceDescription3 { get; set; }

		[DataMember(Name="serviceDescription4", EmitDefaultValue=false)]
		public string ServiceDescription4 { get; set; }

		[DataMember(Name="serviceDescription5", EmitDefaultValue=false)]
		public string ServiceDescription5 { get; set; }

		[DataMember(Name="serviceDescription6", EmitDefaultValue=false)]
		public string ServiceDescription6 { get; set; }

		[DataMember(Name="settlementIndicator", EmitDefaultValue=false)]
		public bool? SettlementIndicator { get; set; }

	}
}