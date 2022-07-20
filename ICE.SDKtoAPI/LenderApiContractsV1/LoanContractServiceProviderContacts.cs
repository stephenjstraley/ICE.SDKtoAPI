using System;
using System.Runtime.Serialization;
namespace ICE.SDKtoAPI.LenderApiContractsV1
{
	[DataContract]
	public class LoanContractServiceProviderContacts
	{
		[DataMember(Name="address")]
		public string Address { get; set; }

		[DataMember(Name="city")]
		public string City { get; set; }

		[DataMember(Name="contactName")]
		public string ContactName { get; set; }

		[DataMember(Name="cost")]
		public decimal? Cost { get; set; }

		[DataMember(Name="email")]
		public string Email { get; set; }

		[DataMember(Name="fax")]
		public string Fax { get; set; }

		[DataMember(Name="feeAmt1")]
		public decimal? FeeAmt1 { get; set; }

		[DataMember(Name="feeAmt10")]
		public decimal? FeeAmt10 { get; set; }

		[DataMember(Name="feeAmt2")]
		public decimal? FeeAmt2 { get; set; }

		[DataMember(Name="feeAmt3")]
		public decimal? FeeAmt3 { get; set; }

		[DataMember(Name="feeAmt4")]
		public decimal? FeeAmt4 { get; set; }

		[DataMember(Name="feeAmt5")]
		public decimal? FeeAmt5 { get; set; }

		[DataMember(Name="feeAmt6")]
		public decimal? FeeAmt6 { get; set; }

		[DataMember(Name="feeAmt7")]
		public decimal? FeeAmt7 { get; set; }

		[DataMember(Name="feeAmt8")]
		public decimal? FeeAmt8 { get; set; }

		[DataMember(Name="feeAmt9")]
		public decimal? FeeAmt9 { get; set; }

		[DataMember(Name="feeDesc1")]
		public string FeeDesc1 { get; set; }

		[DataMember(Name="feeDesc10")]
		public string FeeDesc10 { get; set; }

		[DataMember(Name="feeDesc2")]
		public string FeeDesc2 { get; set; }

		[DataMember(Name="feeDesc3")]
		public string FeeDesc3 { get; set; }

		[DataMember(Name="feeDesc4")]
		public string FeeDesc4 { get; set; }

		[DataMember(Name="feeDesc5")]
		public string FeeDesc5 { get; set; }

		[DataMember(Name="feeDesc6")]
		public string FeeDesc6 { get; set; }

		[DataMember(Name="feeDesc7")]
		public string FeeDesc7 { get; set; }

		[DataMember(Name="feeDesc8")]
		public string FeeDesc8 { get; set; }

		[DataMember(Name="feeDesc9")]
		public string FeeDesc9 { get; set; }

		[DataMember(Name="id")]
		public string Id { get; set; }

		[DataMember(Name="lineItemNumber")]
		public string LineItemNumber { get; set; }

		[DataMember(Name="phone")]
		public string Phone { get; set; }

		[DataMember(Name="postalCode")]
		public string PostalCode { get; set; }

		[DataMember(Name="providerIndex")]
		public int? ProviderIndex { get; set; }

		[DataMember(Name="providerName")]
		public string ProviderName { get; set; }

		[DataMember(Name="relationship")]
		public string Relationship { get; set; }

		[DataMember(Name="serviceProvided")]
		public string ServiceProvided { get; set; }

		[DataMember(Name="serviceProviderId")]
		public string ServiceProviderId { get; set; }

		[DataMember(Name="serviceType")]
		public string ServiceType { get; set; }

		[DataMember(Name="shopFor")]
		public bool? ShopFor { get; set; }

		[DataMember(Name="state")]
		public string State { get; set; }

		[DataMember(Name="webUrl")]
		public string WebUrl { get; set; }

	}
}