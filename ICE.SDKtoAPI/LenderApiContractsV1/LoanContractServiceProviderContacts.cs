using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractServiceProviderContacts
	{
		[DataMember(Name="address", EmitDefaultValue=false)]
		public string Address { get; set; }

		[DataMember(Name="city", EmitDefaultValue=false)]
		public string City { get; set; }

		[DataMember(Name="contactName", EmitDefaultValue=false)]
		public string ContactName { get; set; }

		[DataMember(Name="cost", EmitDefaultValue=false)]
		public double? Cost { get; set; }

		[DataMember(Name="email", EmitDefaultValue=false)]
		public string Email { get; set; }

		[DataMember(Name="fax", EmitDefaultValue=false)]
		public string Fax { get; set; }

		[DataMember(Name="feeAmt1", EmitDefaultValue=false)]
		public double? FeeAmt1 { get; set; }

		[DataMember(Name="feeAmt10", EmitDefaultValue=false)]
		public double? FeeAmt10 { get; set; }

		[DataMember(Name="feeAmt2", EmitDefaultValue=false)]
		public double? FeeAmt2 { get; set; }

		[DataMember(Name="feeAmt3", EmitDefaultValue=false)]
		public double? FeeAmt3 { get; set; }

		[DataMember(Name="feeAmt4", EmitDefaultValue=false)]
		public double? FeeAmt4 { get; set; }

		[DataMember(Name="feeAmt5", EmitDefaultValue=false)]
		public double? FeeAmt5 { get; set; }

		[DataMember(Name="feeAmt6", EmitDefaultValue=false)]
		public double? FeeAmt6 { get; set; }

		[DataMember(Name="feeAmt7", EmitDefaultValue=false)]
		public double? FeeAmt7 { get; set; }

		[DataMember(Name="feeAmt8", EmitDefaultValue=false)]
		public double? FeeAmt8 { get; set; }

		[DataMember(Name="feeAmt9", EmitDefaultValue=false)]
		public double? FeeAmt9 { get; set; }

		[DataMember(Name="feeDesc1", EmitDefaultValue=false)]
		public string FeeDesc1 { get; set; }

		[DataMember(Name="feeDesc10", EmitDefaultValue=false)]
		public string FeeDesc10 { get; set; }

		[DataMember(Name="feeDesc2", EmitDefaultValue=false)]
		public string FeeDesc2 { get; set; }

		[DataMember(Name="feeDesc3", EmitDefaultValue=false)]
		public string FeeDesc3 { get; set; }

		[DataMember(Name="feeDesc4", EmitDefaultValue=false)]
		public string FeeDesc4 { get; set; }

		[DataMember(Name="feeDesc5", EmitDefaultValue=false)]
		public string FeeDesc5 { get; set; }

		[DataMember(Name="feeDesc6", EmitDefaultValue=false)]
		public string FeeDesc6 { get; set; }

		[DataMember(Name="feeDesc7", EmitDefaultValue=false)]
		public string FeeDesc7 { get; set; }

		[DataMember(Name="feeDesc8", EmitDefaultValue=false)]
		public string FeeDesc8 { get; set; }

		[DataMember(Name="feeDesc9", EmitDefaultValue=false)]
		public string FeeDesc9 { get; set; }

		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		[DataMember(Name="lineItemNumber", EmitDefaultValue=false)]
		public string LineItemNumber { get; set; }

		[DataMember(Name="phone", EmitDefaultValue=false)]
		public string Phone { get; set; }

		[DataMember(Name="postalCode", EmitDefaultValue=false)]
		public string PostalCode { get; set; }

		[DataMember(Name="providerIndex", EmitDefaultValue=false)]
		public int? ProviderIndex { get; set; }

		[DataMember(Name="providerName", EmitDefaultValue=false)]
		public string ProviderName { get; set; }

		[DataMember(Name="relationship", EmitDefaultValue=false)]
		public string Relationship { get; set; }

		[DataMember(Name="serviceProvided", EmitDefaultValue=false)]
		public string ServiceProvided { get; set; }

		[DataMember(Name="serviceProviderId", EmitDefaultValue=false)]
		public string ServiceProviderId { get; set; }

		[DataMember(Name="serviceType", EmitDefaultValue=false)]
		public string ServiceType { get; set; }

		[DataMember(Name="shopFor", EmitDefaultValue=false)]
		public bool? ShopFor { get; set; }

		[DataMember(Name="state", EmitDefaultValue=false)]
		public string State { get; set; }

		[DataMember(Name="webUrl", EmitDefaultValue=false)]
		public string WebUrl { get; set; }

	}
}